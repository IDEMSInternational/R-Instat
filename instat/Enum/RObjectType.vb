''' <summary>
''' represents R object types that are internally supported by R-Instat
''' at both R and .Net level 
''' </summary>
Public Structure RObjectType
    '-------------------
    'note an Enum would have been ideal, but VB.Net does not support String Enums
    '------------------
    Public Const Dataframe As String = "dataframe"
    Public Const Column As String = "column"
    Public Const Graph As String = "graph"
    Public Const String_Expression As String = "string"
    Public Const Table As String = "table"
    Public Const Model As String = "model"
End Structure
