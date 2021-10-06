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
        ucrPnlGetData.AddRadioButton(rdoGetpackage)
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
        ucrDataFrameGet.SetLinkedDisplayControl(btnGetPackage)



        'ucrSelectorAddRemoveColumn.ucrAvailableDataFrames.SetLabelText("Get Column:")
        'ucrSelectorAddRemoveColumn.SetParameter(New RParameter("string", 0))
        ucrSelectorGetColumn.SetParameterIsString()

        ucrReceiverGetCol.SetParameter(New RParameter("string", 0))
        ucrReceiverGetCol.SetParameterIsRFunction()
        ucrReceiverGetCol.Selector = ucrSelectorGetColumn
        ucrReceiverGetCol.bUseFilteredData = False
        ucrReceiverGetCol.SetMeAsReceiver()


        'get object controls
        ucrPnlGetObject.AddRadioButton(rdoGraph)
        ucrPnlGetObject.AddRadioButton(rdoTable)
        ucrPnlGetObject.AddRadioButton(rdoModel)

        ucrReceiverGetObject.SetParameter(New RParameter("string", 0))
        ucrReceiverGetObject.SetParameterIsRFunction()
        ucrReceiverGetObject.Selector = ucrSelectorGetObject
        ucrReceiverGetObject.bUseFilteredData = False
        ucrReceiverGetObject.SetMeAsReceiver()

        '---------------------------------------------------
        'save controls
        'ucrInputNewDataFrame.SetParameter(New RParameter("new_name", 1))
        ucrInputNewDataFrame.SetValidationTypeAsRVariable()


        'ucrSaveColoumn.SetPrefix("newcol")
        ucrSaveColumn.SetSaveTypeAsColumn()
        ucrSaveColumn.SetDataFrameSelector(ucrDataFrameColumn)
        ucrSaveColumn.SetIsComboBox()
        ucrSaveColumn.SetLabelText("Column Name:")

        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetDataFrameSelector(ucrDataFrameObject)
        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetLabelText("Graph Name:")

        ucrSaveTable.SetSaveTypeAsTable()
        ucrSaveTable.SetDataFrameSelector(ucrDataFrameObject)
        ucrSaveTable.SetIsComboBox()
        ucrSaveTable.SetLabelText("Table Name:")

        ucrSaveModel.SetSaveTypeAsModel()
        ucrSaveModel.SetDataFrameSelector(ucrDataFrameObject)
        ucrSaveModel.SetIsComboBox()
        ucrSaveModel.SetLabelText("Model Name:")

        'disable base button comment
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


        'get controls reset
        rdoGetpackage.Checked = True
        ucrComboGetPackage.Reset()
        ucrDataFrameGet.Reset()
        ucrSelectorGetColumn.Reset()
        rdoGraph.Checked = True
        ucrSelectorGetObject.Reset()
        ucrReceiverGetObject.SetItemType("graph")




        'save controls reset
        ucrInputNewDataFrame.SetName("")
        ucrDataFrameColumn.Reset()
        ucrSaveColumn.Reset()
        ucrDataFrameObject.Reset()
        ucrSaveGraph.Reset()
        ucrSaveTable.Reset()
        ucrSaveModel.Reset()

        'script text control reset 
        ucrInputCommand.SetName("# Code generated by the dialog, Script" & Environment.NewLine)

        'global function resets
        clsLibraryFunction.SetRCommand("library")
        clsLibraryFunction.AddParameter("package", Chr(34) & "datasets" & Chr(34))

        clsGetDataFrameFunction.SetRCommand("data_book$get_data_frame")
        clsGetDataFrameFunction.AddParameter("data_name", Chr(34) & ucrDataFrameGet.strCurrDataFrame & Chr(34))


    End Sub

    Private Sub TestOKEnabled()

        'enable if there is text in the input textbox
        ucrBase.OKEnabled(Not ucrInputCommand.IsEmpty)
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

    Private Sub ucrInputCommand_ContentsChanged() Handles ucrInputCommand.ContentsChanged
        ucrBase.clsRsyntax.SetCommandString(ucrInputCommand.GetText())
        TestOKEnabled()
    End Sub


    Private Sub ucrPnlGetData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlGetData.ControlValueChanged
        'If rdoGetpackage.Checked Then
        '    ucrComboGetPackage.SetVisible(True)
        'ElseIf rdoGetDataFrame.Checked Then

        'ElseIf rdoGetColumn.Checked Then

        'ElseIf rdoGetObject.Checked Then

        'End If
    End Sub

    Private Sub ucrPnlGetObject_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlGetObject.ControlValueChanged
        If rdoGraph.Checked Then
            ucrReceiverGetObject.SetItemType("graph")
        ElseIf rdoTable.Checked Then
            ucrReceiverGetObject.SetItemType("table")
        ElseIf rdoModel.Checked Then
            ucrReceiverGetObject.SetItemType("model")
        End If
    End Sub

    Private Sub btnGetPackage_Click(sender As Object, e As EventArgs)
        AddScript(clsLibraryFunction.ToScript)
    End Sub

    Private Sub btnGetDataFrame_Click(sender As Object, e As EventArgs) Handles btnGetDataFrame.Click
        Dim strAssignedScript As String = ""
        clsGetDataFrameFunction.SetAssignTo(ucrDataFrameGet.cboAvailableDataFrames.Text)
        clsGetDataFrameFunction.ToScript(strScript:=strAssignedScript)
        AddScript(strAssignedScript)
    End Sub

    Private Sub btnGetColumn_Click(sender As Object, e As EventArgs) Handles btnGetColumn.Click
        Dim clsFunction As RFunction = ucrReceiverGetCol.GetVariables()
        Dim strAssignedScript As String = ""
        clsFunction.ToScript(strScript:=strAssignedScript)
        AddScript(strAssignedScript)
    End Sub

    Private Sub btnGetObject_Click(sender As Object, e As EventArgs) Handles btnGetObject.Click
        Dim clsFunction As RFunction = ucrReceiverGetObject.GetVariables()
        Dim strAssignedScript As String = ""
        clsFunction.ToScript(strScript:=strAssignedScript)
        AddScript(strAssignedScript)
    End Sub

    'todo. do we really need this?
    Private Sub ucrInputNewDataFrame_ContentsChanged() Handles ucrInputNewDataFrame.ContentsChanged
        btnSaveNewDataframe.Enabled = Not ucrInputNewDataFrame.IsEmpty
    End Sub


    Private Sub btnSaveNewDataframe_Click(sender As Object, e As EventArgs) Handles btnSaveNewDataframe.Click
        Dim clsImportNewDataFrame As New RFunction
        Dim clsRFunctionList As New RFunction

        clsImportNewDataFrame.SetRCommand("data_book$import_data")

        clsRFunctionList.SetRCommand("list")
        clsRFunctionList.AddParameter(ucrInputNewDataFrame.GetText(), ucrInputNewDataFrame.GetText())
        clsImportNewDataFrame.AddParameter("data_tables", clsRFunctionList.ToScript)

        AddScript(ucrInputNewDataFrame.GetText() & "<-")
        AddScript(clsImportNewDataFrame.ToScript)
    End Sub



    Private Sub btnSaveNewColumn_Click(sender As Object, e As EventArgs) Handles btnSaveNewColumn.Click
        Dim strAssignedScript As String = ""
        'clone the function first because the ToScript function modifies the contents of the function.
        Dim str As String = clsSaveColumnFunction.Clone.ToScript(strScript:=strAssignedScript)
        AddScript(strAssignedScript)
    End Sub

    Private Sub btnSaveNewGraph_Click(sender As Object, e As EventArgs) Handles btnSaveNewGraph.Click
        Dim strAssignedScript As String = ""
        'clone the function first because the ToScript function modifies the contents of the function.
        Dim str As String = clsSaveGraphFunction.Clone.ToScript(strScript:=strAssignedScript)
        AddScript(strAssignedScript)
    End Sub

    Private Sub btSaveNewTable_Click(sender As Object, e As EventArgs) Handles btSaveNewTable.Click
        Dim strAssignedScript As String = ""
        'clone the function first because the ToScript function modifies the contents of the function.
        Dim str As String = clsSaveTableFunction.Clone.ToScript(strScript:=strAssignedScript)
        AddScript(strAssignedScript)
    End Sub

    Private Sub btnSaveNewModel_Click(sender As Object, e As EventArgs) Handles btnSaveNewModel.Click
        Dim strAssignedScript As String = ""
        'clone the function first because the ToScript function modifies the contents of the function.
        Dim str As String = clsSaveModelFunction.Clone.ToScript(strScript:=strAssignedScript)
        AddScript(strAssignedScript)
    End Sub

    Private Sub AddScript(strNewScript As String)
        ucrInputCommand.SetName(ucrInputCommand.GetText & Environment.NewLine & Environment.NewLine & strNewScript.Trim)
    End Sub



End Class