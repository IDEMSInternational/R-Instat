Imports System.IO

Public Class ucrOutputPagess

    Private _pages As clsPages
    Public Sub SetPagesViewModel(pages As clsPages)
        _pages = pages
        AddHandler _pages.NewPageAdded, AddressOf NewPageAdded



        _pages.AddNewPage(New clsPage("main"))

    End Sub


    Private Sub SetPageBindings(page As clsPage)

        '  rbSelectEdit.
        '    rtbComment.DataBindings.Add(New Binding(NameOf(rtbComment.Text), _outputScriptViewModel,
        '             NameOf(_outputScriptViewModel.ScriptComment), True, DataSourceUpdateMode.OnValidation))
    End Sub

    Private Sub NewPageAdded(page As clsPage)
        Dim tabPage As New TabPage With {
            .Text = page.Name
            }
        Dim outputPage As New ucrOutputPage(page) With {
                .Dock = DockStyle.Fill
            }
        tabPage.Controls.Add(outputPage)
        tabControl.TabPages.Add(tabPage)

        UpdateRibbonButtonsForPage()
    End Sub


    Private Sub UpdateRibbonButtonsForPage()
        UpdatePageShowCheckBoxes()
        UpdateRibbonSelectionMode()
    End Sub

    Private Sub UpdateRibbonSelectionMode()
        Select Case _pages.SelectedPage.SelectionMode
            Case PageSelectionMode.Edit
                rbSelectEdit.Checked = True
            Case PageSelectionMode.Group
                rbSelectGroup.Checked = True
            Case PageSelectionMode.Element
                rbSelectElement.Checked = True
        End Select
    End Sub

    Private Sub UpdatePageShowCheckBoxes()
        rcbShowComments.Checked = _pages.SelectedPage.ShowComments
        rcbShowScripts.Checked = _pages.SelectedPage.ShowScripts
        rcbShowImages.Checked = _pages.SelectedPage.ShowImages
        rcbShowTextOutputs.Checked = _pages.SelectedPage.ShowImages
        rcbShowCleanUp.Checked = _pages.SelectedPage.ShowCleanUpScripts
    End Sub



    Private Sub rbSelectGroup_Click(sender As Object, e As EventArgs) Handles rbSelectGroup.Click
        _pages.SelectedPage.SelectionMode = PageSelectionMode.Group
    End Sub

    Private Sub rbSelectElement_Click(sender As Object, e As EventArgs) Handles rbSelectElement.Click
        _pages.SelectedPage.SelectionMode = PageSelectionMode.Element
    End Sub


    Private Sub rcbShowComments_CheckBoxCheckChanged(sender As Object, e As EventArgs) Handles rcbShowComments.CheckBoxCheckChanged
        _pages.SelectedPage.ShowComments = rcbShowComments.Checked
    End Sub

    Private Sub rcbShowScripts_CheckBoxCheckChanged(sender As Object, e As EventArgs) Handles rcbShowScripts.CheckBoxCheckChanged
        _pages.SelectedPage.ShowScripts = rcbShowScripts.Checked
    End Sub

    Private Sub rcbShowImages_CheckBoxCheckChanged(sender As Object, e As EventArgs) Handles rcbShowImages.CheckBoxCheckChanged
        _pages.SelectedPage.ShowImages = rcbShowImages.Checked
    End Sub

    Private Sub rcbShowTextOutputs_CheckBoxCheckChanged(sender As Object, e As EventArgs) Handles rcbShowTextOutputs.CheckBoxCheckChanged
        _pages.SelectedPage.ShowTextOutputs = rcbShowTextOutputs.Checked
    End Sub

    Private Sub rcbShowCleanUp_CheckBoxCheckChanged(sender As Object, e As EventArgs) Handles rcbShowCleanUp.CheckBoxCheckChanged
        _pages.SelectedPage.ShowCleanUpScripts = rcbShowCleanUp.Checked
    End Sub

    Private Sub rbSelectEdit_Click(sender As Object, e As EventArgs) Handles rbSelectEdit.Click
        _pages.SelectedPage.SelectionMode = PageSelectionMode.Edit
    End Sub

    Private Sub rbMoveToNew_Click(sender As Object, e As EventArgs) Handles rbMoveToNew.Click
        Dim sourcePage As clsPage = _pages.SelectedPage
        Dim newPage As New clsPage("New Tab")
        _pages.AddNewPage(newPage)
        _pages.MoveSelectedToPage(sourcePage)

    End Sub

    Private Sub rbSave_Click(sender As Object, e As EventArgs) Handles rbSave.Click
        'Saves the content of the output window in RichTextFormat.
        Using dlgSaveFile As New SaveFileDialog
            dlgSaveFile.Title = "Save Output Window"
            dlgSaveFile.Filter = "Rich Text Format (*.rtf)|*.rtf"
            dlgSaveFile.FileName = Path.GetFileName(_pages.SelectedPage.Name)
            'ToDo Sort out instat options to be global
            '   dlgSaveFile.InitialDirectory = _clsInstatOptions.strWorkingDirectory
            If DialogResult.OK = dlgSaveFile.ShowDialog() Then
                Try
                    _pages.SelectedPage.Save(dlgSaveFile.FileName)
                Catch
                    MsgBox("Could not save the output window." & Environment.NewLine & "The file may be in use by another program or you may not have access to write to the specified location.", MsgBoxStyle.Critical)
                End Try
            End If
        End Using
    End Sub

    Private Sub tabControl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabControl.SelectedIndexChanged
        _pages.SelectedPage = CType(tabControl.SelectedTab.Controls(0), ucrOutputPage).Page
    End Sub
End Class
