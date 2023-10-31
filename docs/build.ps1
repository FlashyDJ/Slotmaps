Import-Module .\XmlToMarkdown.psm1 -Force

$removeTrailingD = {
    param([string]$name)
    return $name -replace 'D$', ''
}

$classes = @("SlotMap", "SecondaryMap")

foreach ($class in $classes) {
    $xmlPath = Join-Path -Path "..\src\Slotmaps\" -ChildPath "$class\codesnippets.xml"
    $classSmall = $class.ToLower()

    Convert-XmlToMarkdown $xmlPath "csharp" "samples\codesnippets" "$class<TValue>" `
        "(?-i)^.*D$" "$classSmall.md" $removeTrailingD

    Convert-XmlToMarkdown $xmlPath "csharp" "samples\codesnippets" "$class<TKey, TValue>" `
        ".*(?<!D)$" "$classSmall-generic.md"

    Add-TocEntry "$class<TValue>" "codesnippets\$classSmall.md"
    Add-TocEntry "$class<TKey, TValue>" "codesnippets\$classSmall-generic.md"
}

docfx .\docfx.json