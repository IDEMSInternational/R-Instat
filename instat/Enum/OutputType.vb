
Public Enum OutputType
    Script = 1
    TextOutput = 2
    ImageOutput = 4


    PreScript = 5
    PostScript = 6
    CleanUpScript = 7

    'HeaderComment = 11
    'RScript = 12
    'FooterComment = 13
    'Output = 14
    'CleanUpScript = 15
End Enum

Public Enum ScriptType
    PreScript
    Script
    PostScript
    CleanUpScript
End Enum

Public Enum OutputDisplayElementType
    Comment
    Script
    OutputComment
    OutputText
    OutputImage
End Enum
