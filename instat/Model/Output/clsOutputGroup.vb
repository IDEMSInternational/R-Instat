Imports System.ComponentModel

Public Class clsOutputGroup
    '   Implements INotifyPropertyChanged


    'ToDo add an interface for the object
    ' Private _preScripts As List(Of clsOutputScript)
    ' Private _script As clsOutputScript
    '  Private _postScripts As List(Of clsOutputScript)
    '  Private _cleanUpScript As clsOutputScript

    Private _scripts As List(Of clsOutputScript)

    '   Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    'Private Sub NotifyPropertyChanged(info As String)
    '    PropertyChanged?.Invoke(Me, New PropertyChangedEventArgs(info))
    'End Sub


    'Public Event ScriptAdded()
    'Public Event PreScriptAdded()
    'Public Event PostScriptAdded()
    'Public Event CleanUpScriptAdded()


    'Public Property PreScripts() As List(Of clsOutputScript)
    '    Get
    '        Return _preScripts
    '    End Get
    '    Set(ByVal value As List(Of clsOutputScript))
    '        _preScripts = value
    '    End Set
    'End Property
    'Public Property Script() As Object
    '    Get
    '        Return _script
    '    End Get
    '    Set(ByVal value As Object)
    '        _script = value
    '    End Set
    'End Property
    'Public Property PostScripts() As List(Of clsOutputScript)
    '    Get
    '        Return _postScripts
    '    End Get
    '    Set(ByVal value As List(Of clsOutputScript))
    '        _postScripts = value
    '    End Set
    'End Property
    'Public Property CleanUpScript() As Object
    '    Get
    '        Return _cleanUpScript
    '    End Get
    '    Set(ByVal value As Object)
    '        _cleanUpScript = value
    '    End Set
    'End Property





    Public Sub New()
        '   _preScripts = New List(Of clsOutputScript)
        '  _postScripts = New List(Of clsOutputScript)
        _scripts = New List(Of clsOutputScript)
    End Sub

    Public ReadOnly Property ContainsScript() As Boolean
        Get
            Return _scripts.Count > 0
            'Return _script IsNot Nothing
        End Get
    End Property

    Public Function Add(script As String, output As String, retunType As R_ReturnType, scriptType As ScriptType) As clsOutputScript
        Dim outputScript As clsOutputScript = CreateOutput(script, output, retunType, scriptType)
        _scripts.Add(outputScript)
        'Select Case scriptType
        '    Case ScriptType.PreScript
        '        _preScripts.Add(outputScript)
        '    '    RaiseEvent PreScriptAdded()
        '    Case ScriptType.Script
        '        _script = outputScript
        '     '   RaiseEvent ScriptAdded()
        '    Case ScriptType.PostScript
        '        PostScripts.Add(outputScript)
        '      '  RaiseEvent PostScriptAdded()
        '    Case ScriptType.CleanUpScript
        '        _cleanUpScript = outputScript
        '        '   RaiseEvent CleanUpScriptAdded()
        'End Select
        Return outputScript
    End Function

    Private Function CreateOutput(script As String, output As String, returnType As R_ReturnType, scriptType As ScriptType) As clsOutputScript
        Select Case returnType
            Case R_ReturnType.IgnoreResult,
                R_ReturnType.ResultAsTemporaryVariable
                Return New clsOutputScript(scriptType, script)
            Case R_ReturnType.ResultAsText
                Return New clsOutputScript(scriptType, script, output)
            Case R_ReturnType.ResultAsImage
                Return New clsOutputScript(scriptType, script, GetImageFromFile(output))
            Case R_ReturnType.ResultAsWebControl
                '  ToDo add WebControl
                Return Nothing
            Case Else
                Return Nothing

        End Select
    End Function

    Private Function GetImageFromFile(fileLocation As String) As Image
        Dim image As Bitmap
        Using fs As New IO.FileStream(fileLocation, IO.FileMode.Open)
            image = New Bitmap(Drawing.Image.FromStream(fs))
        End Using
        '     image.Save("C:\Users\Christopher Marsh\AppData\Local\Temp\R_Instat_Temp_Graphs\test.png")
        Return image
    End Function



End Class
