''' <summary>
''' represents display formats for R objects that are internally supported by R-Instat
''' at both R and .Net level
''' </summary>
Public Structure RObjectFormat
    '-------------------
    'note an Enum would have been ideal, but VB.Net does not support String Enums
    '------------------
    Public Const Image As String = "image"
    Public Const Text As String = "text" 'e.g objects of type "table"
    Public Const Html As String = "html" 'e.g objects of type "htmlwidget", "sjTable", "gt_tbl"
End Structure