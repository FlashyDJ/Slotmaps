function Convert-XmlToMarkdown {
    param(
        [string]$XmlFilePath,
        [string]$ProgrammingLanguage,
        [string]$OutputDirectory,
        [string]$ClassName,
        [string]$MethodNameRegex,
        [string]$FileName,
        [scriptblock]$MethodNameTransformation
    )

    $xmlDoc = [xml](Get-Content $XmlFilePath)

    if ([string]::IsNullOrEmpty($OutputDirectory)) {
        $OutputDirectory = [System.IO.Path]::GetDirectoryName($XmlFilePath)
    }
    if ([string]::IsNullOrEmpty($ClassName)) {
        $ParentFolderName = [System.IO.Path]::GetFileName((Get-Item $XmlFilePath).Directory.FullName)
        $ClassName = $ParentFolderName
    }
    if ([string]::IsNullOrEmpty($FileName)) {
        $FileName = "$ClassName.md"
    }

    $markdownContent = "# $ClassName Code Snippets `n `n"

    # Helper function to remove common indentation
    function Remove-CommonIndent([string]$text) {
        $lines = $text.Trim() -split '\r?\n'
        $commonIndent = [int]($lines 
            | Where-Object { $_ -match '^\s+' } 
            | ForEach-Object { $matches[0].Length } 
            | Measure-Object -Minimum).Minimum

        $result = $lines | ForEach-Object {
            $_ -replace ('^\s{' + $commonIndent + '}'), ''
        } | Out-String

        return $result
    }

    # Helper function to remove common indentation
    function TransformMethodName($name) {
        if ($null -ne $MethodNameTransformation) {
            return & $MethodNameTransformation $name
        }
        return $name
    }

    # Helper function to check if a method node should be selected
    function IsMethodNodeSelected($nodeName) {
        if ([string]::IsNullOrEmpty($MethodNameRegex)) {
            return $true
        }
        else {
            return $nodeName -match $MethodNameRegex
        }
    }

    # Iterate through method nodes
    foreach ($methodNode in $xmlDoc.SelectNodes("/*/*")) {
        $methodName = $methodNode.Name

        if (!(IsMethodNodeSelected($methodName))) {
            continue
        }

        $transformedMethodName = TransformMethodName $methodName
        $codeNodes = $methodNode.SelectNodes(".//code")

        if ($codeNodes.Count -gt 0) {
            $markdownContent += "## $transformedMethodName `n `n"

            foreach ($codeNode in $codeNodes) {
                $formattedCode = Remove-CommonIndent $codeNode.InnerText
                $markdownContent += "``````$ProgrammingLanguage `n$formattedCode`````` `n `n"
            }
        }
    }

    $markdownFilePath = Join-Path $OutputDirectory -ChildPath $FileName
    $markdownContent | Set-Content -Path $markdownFilePath

    $markdownFilePath
}

function Add-TocEntry {
    param(
        [string]$Name,
        [string]$Href
    )

    if ([string]::IsNullOrEmpty($Href)) {
        $Href = "$Name.md"
    }

    $sampleTocPath = ".\samples\toc.yml"
    $tocEntry = "- name: $Name`n  href: $Href"

    $existingEntries = Get-Content -Path $sampleTocPath

    $entryExists = $false
    for ($i = 0; $i -lt $existingEntries.Length - 1; $i++) {
        $entryName = $existingEntries[$i]
        $entryHref = $existingEntries[$i + 1]
    
        if ($entryName -like "*name: $Name*") {
            $entryExists = $true

            if ($entryHref -notlike "*href: $Href*") {
                Write-Host "Error: Entry '$Name' already exists with a different href."
            }
            break
        }
    }

    if (!$entryExists) {
        Add-Content -Path $sampleTocPath -Value $tocEntry
    }
}