Public Class ucrOutputGroup
    Private _pageOutputGroup As clsPageGroup

    Private prescript As Binding

    Public Sub New(outputGroupViewModel As clsPageGroup)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _pageOutputGroup = outputGroupViewModel

        '     AddScript()
        '       AddHandler _pageOutputGroup.AddAPreScript, AddressOf AddPreScript
        AddHandler _pageOutputGroup.AddAScript, AddressOf AddScript
        '    AddHandler _pageOutputGroup.AddAPostScript, AddressOf AddPostScript
        '    AddHandler _pageOutputGroup.AddACleanUpScript, AddressOf AddCleanUpScript
    End Sub

    'Private Sub AddPreScript()
    '    Dim pageElement As New ucrOutputScript(_pageOutputGroup.PreScripts.Last())
    '    preScriptPanel.Controls.Add(pageElement)
    '    pageElement.Dock = DockStyle.Top
    '    preScriptPanel.Controls.SetChildIndex(pageElement, 0)
    'End Sub
    Private Sub AddScript()
        'Dim pageElement As New ucrOutputScript(_pageOutputGroup.Script)
        'scriptPanel.Controls.Add(pageElement)
        'pageElement.Dock = DockStyle.Fill

        Dim pageElement As New ucrOutputScript(_pageOutputGroup.Scripts.Last())
        scriptPanel.Controls.Add(pageElement)
        pageElement.Dock = DockStyle.Top
        scriptPanel.Controls.SetChildIndex(pageElement, 0)
    End Sub

    'Private Sub AddPostScript()
    '    Dim pageElement As New ucrOutputScript(_pageOutputGroup.PostScripts.Last())
    '    postScriptPanel.Controls.Add(pageElement)
    '    pageElement.Dock = DockStyle.Top
    '    postScriptPanel.Controls.SetChildIndex(pageElement, 0)
    'End Sub

    'Private Sub AddCleanUpScript()
    '    Dim pageElement As New ucrOutputScript(_pageOutputGroup.CleanUpScript)
    '    cleanUpScriptPanel.Controls.Add(pageElement)
    '    pageElement.Dock = DockStyle.Fill
    'End Sub
End Class
