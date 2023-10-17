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

# Convert-XmlToMarkdown "..\src\Slotmaps\SlotMap\codesnippets.xml" `
#     "csharp" "samples\codesnippets" "SlotMap<TValue>" "(?-i)^.*D$" "slotmap.md" $removeTrailingD
# Add-TocEntry "SlotMap<TValue>" "codesnippets\slotmap.md"

# Convert-XmlToMarkdown "..\src\Slotmaps\SlotMap\codesnippets.xml" "csharp" `
#     "samples\codesnippets" "SlotMap<TKey, TValue>" ".*(?<!D)$" "slotmap-generic.md"
# Add-TocEntry "SlotMap<TKey, TValue>" "codesnippets\slotmap-generic.md"

# Convert-XmlToMarkdown "..\src\Slotmaps\SecondaryMap\codesnippets.xml" `
#     "csharp" "samples\codesnippets" "SecondaryMap<TValue>" "(?-i)^.*D$" "secondarymap.md" $removeTrailingD
# Add-TocEntry "SecondaryMap<TValue>" "codesnippets\secondarymap.md"

# Convert-XmlToMarkdown "..\src\Slotmaps\SecondaryMap\codesnippets.xml" "csharp" `
#     "samples\codesnippets" "SecondaryMap<TKey, TValue>" ".*(?<!D)$" "secondarymap-generic.md"
# Add-TocEntry "SecondaryMap<TKey, TValue>" "codesnippets\secondarymap-generic.md"

docfx -s