''' <summary>
''' Represents R object types that are internally supported by R-Instat
''' at both R and .Net level.
''' They correspond to the object labels at R level
''' </summary>
Public Structure RObjectTypeLabel
    '-------------------
    'note an Enum would have been ideal, but VB.Net does not support String Enums
    '------------------
    Public Const Dataframe As String = "dataframe"
    Public Const Column As String = "column"
    Public Const Graph As String = "graph"
    Public Const Table As String = "table"
    Public Const Model As String = "model"
    Public Const StructureLabel As String = "structure" ' e.g Survival objects
    Public Const Summary As String = "summary" ' e.g objects of text formats
End Structure