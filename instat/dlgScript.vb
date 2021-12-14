' R- Instat
' Copyright (C) 2015-2017
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports RDotNet
Imports instat.Translations
Public Class dlgScript
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private clsLibraryFunction, clsGetDataFrameFunction, clsSaveColumnFunction, clsSaveGraphFunction, clsSaveTableFunction, clsSaveModelFunction As New RFunction
    Private lstAssignToStrings As New List(Of String)

    Private Sub dlgScript_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()

        'todo. the iCallType will probably be dynamic
        'ucrBase.clsRsyntax.iCallType = 2
        'ucrBase.clsRsyntax.bSeparateThread = False


        '--------------------------------
        'get data controls
        ucrPnlGetData.AddRadioButton(rdoGetPackage)
        ucrPnlGetData.AddRadioButton(rdoGetDataFrame)
        ucrPnlGetData.AddRadioButton(rdoGetColumn)
        ucrPnlGetData.AddRadioButton(rdoGetObject)

        'todo. this combobox can be a custom package control in future. Its also needed in dlgHelpVignettes
        ucrComboGetPackage.SetParameter(New RParameter("package", 0))
        ucrComboGetPackage.SetItems(GetPackages(), bAddConditions:=True)
        ucrComboGetPackage.SetDropDownStyleAsNonEditable()
        ucrComboGetPackage.SetLinkedDisplayControl(New List(Of Control)({lblGetPackage, btnGetPackage}))

        ucrDataFrameGet.SetLabelText("Get Data Frame:")
        ucrDataFrameGet.SetParameter(New RParameter("data_name", 0))
        ucrDataFrameGet.SetParameterIsString()
        ucrDataFrameGet.SetLinkedDisplayControl(btnGetDataFrame)

        ucrSelectorGet.SetParameterIsString()

        'get object controls
        ucrPnlGetObject.AddRadioButton(rdoGetGraph)
        ucrPnlGetObject.AddRadioButton(rdoGetTable)
        ucrPnlGetObject.AddRadioButton(rdoGetModel)

        ucrReceiverGet.SetParameter(New RParameter("string", 0))
        ucrReceiverGet.SetParameterIsRFunction()
        ucrReceiverGet.Selector = ucrSelectorGet
        ucrReceiverGet.bUseFilteredData = False
        ucrReceiverGet.SetMeAsReceiver()
        ucrReceiverGet.SetLinkedDisplayControl(New List(Of Control)({lblGet, btnGet}))


        '---------------------------------------------------
        'save controls
        ucrPnlSaveData.AddRadioButton(rdoSaveDataFrame)
        ucrPnlSaveData.AddRadioButton(rdoSaveColumn)
        ucrPnlSaveData.AddRadioButton(rdoSaveObject)

        ucrInputSaveDataFrame.SetValidationTypeAsRVariable()
        ucrInputSaveDataFrame.SetLinkedDisplayControl(New List(Of Control)({lblSaveDataFrame, btnSaveDataframe}))

        ucrSaveColumn.SetSaveTypeAsColumn()
        ucrSaveColumn.SetDataFrameSelector(ucrDataFrameSave)
        ucrSaveColumn.SetIsComboBox()
        ucrSaveColumn.SetLabelText("Column Name:")
        ucrSaveColumn.SetLinkedDisplayControl(btnSaveColumn)

        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetDataFrameSelector(ucrDataFrameSave)
        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetLabelText("Graph Name:")
        ucrSaveGraph.SetLinkedDisplayControl(btnSaveGraph)

        ucrSaveTable.SetSaveTypeAsTable()
        ucrSaveTable.SetDataFrameSelector(ucrDataFrameSave)
        ucrSaveTable.SetIsComboBox()
        ucrSaveTable.SetLabelText("Table Name:")
        ucrSaveTable.SetLinkedDisplayControl(btnSaveTable)

        ucrSaveModel.SetSaveTypeAsModel()
        ucrSaveModel.SetDataFrameSelector(ucrDataFrameSave)
        ucrSaveModel.SetIsComboBox()
        ucrSaveModel.SetLabelText("Model Name:")
        ucrSaveModel.SetLinkedDisplayControl(btnSaveModel)

        'hide base button comment controls
        ucrBase.chkComment.Checked = False
        ucrBase.chkComment.Visible = False
        ucrBase.txtComment.Visible = False


    End Sub

    'todo. this function should eventually be removed once we have a control that displays packages
    Private Function GetPackages() As String()
        Dim arrAvailablePackages() As String = {}
        Dim clsGetPackages As New RFunction
        clsGetPackages.SetRCommand("get_installed_packages_with_data")
        clsGetPackages.AddParameter("with_data", "FALSE")
        Dim expPackageNames As SymbolicExpression = frmMain.clsRLink.RunInternalScriptGetValue(clsGetPackages.ToScript(), bSeparateThread:=False, bSilent:=True)
        If expPackageNames IsNot Nothing AndAlso expPackageNames.Type <> Internals.SymbolicExpressionType.Null Then
            arrAvailablePackages = expPackageNames.AsCharacter.ToArray
            Array.Sort(arrAvailablePackages)
        End If
        Return arrAvailablePackages
    End Function

    Private Sub SetDefaults()
        clsLibraryFunction = New RFunction
        clsGetDataFrameFunction = New RFunction
        clsSaveColumnFunction = New RFunction
        clsSaveGraphFunction = New RFunction
        clsSaveTableFunction = New RFunction
        clsSaveModelFunction = New RFunction

        lstAssignToStrings.Clear()

        'get controls reset
        rdoGetPackage.Checked = True
        ucrComboGetPackage.Reset()
        ucrDataFrameGet.Reset()
        ucrSelectorGet.Reset()
        'ucrReceiverGetCol.SetMeAsReceiver()
        rdoGetGraph.Checked = True
        'ucrReceiverGetObject.SetItemType("graph")


        'save controls reset
        rdoSaveDataFrame.Checked = True
        ucrInputSaveDataFrame.SetName("")
        ucrDataFrameSave.Reset()
        ucrSaveColumn.Reset()
        ucrSaveGraph.Reset()
        ucrSaveTable.Reset()
        ucrSaveModel.Reset()

        'script text control reset 
        txtScript.Text = "# Code generated by the dialog, Script" & Environment.NewLine

        'global function resets
        clsLibraryFunction.SetRCommand("library")
        clsLibraryFunction.AddParameter("package", Chr(34) & "datasets" & Chr(34))

        clsGetDataFrameFunction.SetRCommand("data_book$get_data_frame")
        clsGetDataFrameFunction.AddParameter("data_name", Chr(34) & ucrDataFrameGet.strCurrDataFrame & Chr(34))

    End Sub

    Private Sub TestOKEnabled()
        ucrBase.OKEnabled(txtScript.Text.Length > 0)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrComboGetPackage.SetRCode(clsLibraryFunction, bReset)
        ucrDataFrameGet.SetRCode(clsGetDataFrameFunction, bReset)

        'saving results
        ucrSaveColumn.SetRCode(clsSaveColumnFunction, bReset)
        ucrSaveGraph.SetRCode(clsSaveGraphFunction, bReset)
        ucrSaveTable.SetRCode(clsSaveTableFunction, bReset)
        ucrSaveModel.SetRCode(clsSaveModelFunction, bReset)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
    End Sub

    Private Sub ucrPnlGetData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlGetData.ControlValueChanged
        ucrComboGetPackage.SetVisible(False)
        ucrDataFrameGet.SetVisible(False)
        ucrSelectorGet.SetVisible(False)
        ucrPnlGetObject.SetVisible(False)
        ucrReceiverGet.SetVisible(False)
        If rdoGetPackage.Checked Then
            ucrComboGetPackage.SetVisible(True)
        ElseIf rdoGetDataFrame.Checked Then
            ucrDataFrameGet.SetVisible(True)
        ElseIf rdoGetColumn.Checked OrElse rdoGetObject.Checked Then
            ucrPnlGetObject.SetVisible(False)
            ucrSelectorGet.SetVisible(True)
            ucrReceiverGet.SetVisible(True)
            SetGetReceiverItemType()
        End If
    End Sub

    Private Sub ucrPnlGetObject_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlGetObject.ControlValueChanged
        SetGetReceiverItemType()
    End Sub

    Private Sub SetGetReceiverItemType()
        ucrReceiverGet.Clear()
        If rdoGetColumn.Checked Then
            lblGet.Text = "Selected Column:"
            ucrReceiverGet.SetItemType("column")
        ElseIf rdoGetGraph.Checked Then
            lblGet.Text = "Selected Graph:"
            ucrReceiverGet.SetItemType("graph")
        ElseIf rdoGetTable.Checked Then
            lblGet.Text = "Selected Table:"
            ucrReceiverGet.SetItemType("table")
        ElseIf rdoGetModel.Checked Then
            lblGet.Text = "Selected Model:"
            ucrReceiverGet.SetItemType("model")
        End If
    End Sub

    Private Sub ucrPnlSaveData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlSaveData.ControlValueChanged
        ucrInputSaveDataFrame.SetVisible(False)
        ucrDataFrameSave.SetVisible(False)
        ucrSaveColumn.SetVisible(False)
        ucrSaveGraph.SetVisible(False)
        ucrSaveTable.SetVisible(False)
        ucrSaveModel.SetVisible(False)
        If rdoSaveDataFrame.Checked Then
            ucrInputSaveDataFrame.SetVisible(True)
        ElseIf rdoSaveColumn.Checked Then
            ucrDataFrameSave.SetVisible(True)
            ucrSaveColumn.SetVisible(True)
        ElseIf rdoSaveObject.Checked Then
            ucrDataFrameSave.SetVisible(True)
            ucrSaveGraph.SetVisible(True)
            ucrSaveTable.SetVisible(True)
            ucrSaveModel.SetVisible(True)
        End If
    End Sub

    Private Sub btnGetPackage_Click(sender As Object, e As EventArgs) Handles btnGetPackage.Click
        AppendTextScript(clsLibraryFunction.Clone.ToScript)
    End Sub

    Private Sub btnGetDataFrame_Click(sender As Object, e As EventArgs) Handles btnGetDataFrame.Click
        If ucrDataFrameGet.cboAvailableDataFrames.Text.Length < 1 Then
            Exit Sub
        End If

        Dim strAssignedScript As String = ""
        clsGetDataFrameFunction.SetAssignTo(ucrDataFrameGet.cboAvailableDataFrames.Text)
        Dim strAssignedTo As String = clsGetDataFrameFunction.Clone.ToScript(strScript:=strAssignedScript)
        AppendTextScript(strAssignedScript)
        AddAssignToString(strAssignedTo)
    End Sub

    Private Sub btnGetObject_Click(sender As Object, e As EventArgs) Handles btnGet.Click
        If ucrReceiverGet.IsEmpty Then
            Exit Sub
        End If

        Dim clsFunction As RFunction = ucrReceiverGet.GetVariables()
        Dim strAssignedScript As String = ""
        Dim strAssignedTo As String = clsFunction.ToScript(strScript:=strAssignedScript)
        AppendTextScript(strAssignedScript)
        AddAssignToString(strAssignedTo)
    End Sub

    Private Sub btnSaveNewDataframe_Click(sender As Object, e As EventArgs) Handles btnSaveDataframe.Click
        If ucrInputSaveDataFrame.IsEmpty Then
            Exit Sub
        End If

        Dim clsImportNewDataFrame As New RFunction
        Dim clsRFunctionList As New RFunction

        clsImportNewDataFrame.SetRCommand("data_book$import_data")

        clsRFunctionList.SetRCommand("list")
        clsRFunctionList.AddParameter(ucrInputSaveDataFrame.GetText(), ucrInputSaveDataFrame.GetText())
        clsImportNewDataFrame.AddParameter("data_tables", clsRFunctionList.ToScript)

        AppendTextScript(ucrInputSaveDataFrame.GetText() & "<-" & Environment.NewLine & clsImportNewDataFrame.ToScript)
    End Sub

    Private Sub btnSaveNewColumn_Click(sender As Object, e As EventArgs) Handles btnSaveColumn.Click
        If Not ucrSaveColumn.IsComplete Then
            Exit Sub
        End If

        Dim strAssignedScript As String = ""
        'clone the function first because the ToScript function modifies the contents of the function.
        Dim strAssignedTo As String = clsSaveColumnFunction.Clone.ToScript(strScript:=strAssignedScript)
        AppendTextScript(strAssignedScript)
        AddAssignToString(ucrSaveColumn.GetText)
    End Sub

    Private Sub btnSaveNewGraph_Click(sender As Object, e As EventArgs) Handles btnSaveGraph.Click
        If Not ucrSaveGraph.IsComplete Then
            Exit Sub
        End If

        Dim strAssignedScript As String = ""
        'clone the function first because the ToScript function modifies the contents of the function.
        Dim strGetScript As String = clsSaveGraphFunction.Clone.ToScript(strScript:=strAssignedScript)
        AppendTextScript(strAssignedScript.Trim & Environment.NewLine & strGetScript)
        AddAssignToString(ucrSaveGraph.GetText)
    End Sub



    Private Sub btnSaveNewTable_Click(sender As Object, e As EventArgs) Handles btnSaveTable.Click
        If Not ucrSaveTable.IsComplete Then
            Exit Sub
        End If

        Dim strAssignedScript As String = ""
        'clone the function first because the ToScript function modifies the contents of the function.
        Dim strGetScript As String = clsSaveTableFunction.Clone.ToScript(strScript:=strAssignedScript)
        AppendTextScript(strAssignedScript.Trim & Environment.NewLine & strGetScript)
        AddAssignToString(ucrSaveTable.GetText)
    End Sub

    Private Sub btnSaveNewModel_Click(sender As Object, e As EventArgs) Handles btnSaveModel.Click

        If Not ucrSaveModel.IsComplete Then
            Exit Sub
        End If

        Dim strAssignedScript As String = ""
        'clone the function first because the ToScript function modifies the contents of the function.
        Dim strGetScript As String = clsSaveModelFunction.Clone.ToScript(strScript:=strAssignedScript)
        AppendTextScript(strAssignedScript.Trim & Environment.NewLine & strGetScript)
        AddAssignToString(ucrSaveModel.GetText)
    End Sub

    Private Sub btnRemoveObjects_Click(sender As Object, e As EventArgs) Handles btnRemoveObjects.Click
        'create function to remove the objects added in the script
        Dim clsRemoveFunc As New RFunction
        Dim clsRemoveListFun As New RFunction
        clsRemoveFunc.SetRCommand("rm")
        clsRemoveListFun.SetRCommand("c")
        For i As Integer = 0 To lstAssignToStrings.Count - 1
            clsRemoveListFun.AddParameter(i, Chr(34) & lstAssignToStrings(i) & Chr(34), bIncludeArgumentName:=False)
        Next
        clsRemoveFunc.AddParameter("list", clsRFunctionParameter:=clsRemoveListFun)

        AppendTextScript(clsRemoveFunc.ToScript())
    End Sub

    Private Sub txtScript_TextChanged(sender As Object, e As EventArgs) Handles txtScript.TextChanged
        ucrBase.clsRsyntax.SetCommandString(txtScript.Text)
        TestOKEnabled()
    End Sub

    Private Sub AppendTextScript(strNewScript As String)
        txtScript.Text = txtScript.Text & Environment.NewLine & Environment.NewLine & strNewScript.Trim
        txtScript.SelectionStart = txtScript.Text.Length
        txtScript.ScrollToCaret()
        txtScript.Refresh()
    End Sub

    Private Sub AddAssignToString(strObjectName As String)
        If Not lstAssignToStrings.Contains(strObjectName) Then
            lstAssignToStrings.Add(strObjectName)
        End If
    End Sub


End Class