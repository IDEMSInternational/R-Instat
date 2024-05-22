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

Imports instat
Imports instat.Translations
Imports RDotNet

Public Class dlgHideDataframes
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsHideDataFramesFunction As New RFunction
    Private clsAppendToDataFrameFunction As New RFunction
    Private clsMappingFunction As New RFunction
    Private clsDataUnhideOperator As New ROperator
    Private clsTildeOperator As New ROperator

    Private clsDummyFunction As New RFunction

    Private Sub dlgHideDataframes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetHiddenColumns()
        ReopenDialog()
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        CountLevels()
    End Sub

    Private Sub InitialiseDialog()
        ucrReceiverMultiple.SetParameter(New RParameter("data_names", 0))
        ucrReceiverMultiple.SetParameterIsString()
        ucrReceiverMultiple.Selector = ucrSelectorForDataFrames
        ucrReceiverMultiple.strSelectorHeading = "Data Frames"
        ucrReceiverMultiple.SetItemType("dataframe")

        ucrReceiverMultipleUnhide.SetParameter(New RParameter("data_names", 0))
        ucrReceiverMultipleUnhide.SetParameterIsString()
        ucrReceiverMultipleUnhide.Selector = ucrSelectorForDataFrames

        ucrPnlHideUnhide.AddRadioButton(rdoHideDataFrame)
        ucrPnlHideUnhide.AddRadioButton(rdoUnhideDataFrame)
        ucrPnlHideUnhide.AddParameterValuesCondition(rdoHideDataFrame, "checked", "rdoHide")
        ucrPnlHideUnhide.AddParameterValuesCondition(rdoUnhideDataFrame, "checked", "rdoUnhide")

        Dim lstControlsHidden As New List(Of Control)
        lstControlsHidden.Add(lblHiddenDataFrames)
        lstControlsHidden.Add(lblHiddenNumber)
        ucrReceiverMultiple.SetLinkedDisplayControl(lstControlsHidden)
        Dim lstControlsUnhidden As New List(Of Control)
        lstControlsUnhidden.Add(lblUnhideDataFrame)
        lstControlsUnhidden.Add(lblUnHiddenNumber)
        ucrReceiverMultipleUnhide.SetLinkedDisplayControl(lstControlsUnhidden)

        ucrPnlHideUnhide.AddToLinkedControls(ucrReceiverMultiple, {rdoHideDataFrame}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlHideUnhide.AddToLinkedControls(ucrReceiverMultipleUnhide, {rdoUnhideDataFrame}, bNewLinkedHideIfParameterMissing:=True)

        lblHiddenNumber.ForeColor = Color.Red
        lblUnHiddenNumber.ForeColor = Color.Red
    End Sub

    Private Sub SetDefaults()
        clsHideDataFramesFunction = New RFunction
        clsAppendToDataFrameFunction = New RFunction
        clsMappingFunction = New RFunction
        clsDataUnhideOperator = New ROperator
        clsTildeOperator = New ROperator
        clsDummyFunction = New RFunction

        ucrSelectorForDataFrames.Reset()

        clsDummyFunction.AddParameter("checked", "rdoUnhide", iPosition:=0)

        clsMappingFunction.SetPackageName("purrr")
        clsMappingFunction.SetRCommand("map")
        clsMappingFunction.AddParameter(".x", clsROperatorParameter:=clsDataUnhideOperator, iPosition:=0)
        clsMappingFunction.AddParameter(".f", clsROperatorParameter:=clsTildeOperator, iPosition:=1)

        clsTildeOperator.SetOperation("~")
        clsTildeOperator.AddParameter("right", clsRFunctionParameter:=clsAppendToDataFrameFunction, iPosition:=1)
        clsTildeOperator.bForceIncludeOperation = True

        clsDataUnhideOperator.SetOperation("", bBracketsTemp:=False)
        clsDataUnhideOperator.SetAssignTo("data_to_unhide")

        clsHideDataFramesFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$set_hidden_data_frames")
        clsAppendToDataFrameFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$append_to_dataframe_metadata")
        clsAppendToDataFrameFunction.AddParameter("data_name", ".x", iPosition:=0)
        clsAppendToDataFrameFunction.AddParameter("property", "is_hidden_label", iPosition:=1)
        clsAppendToDataFrameFunction.AddParameter("new_val", "FALSE", iPosition:=2)

        ucrBase.clsRsyntax.SetBaseRFunction(clsHideDataFramesFunction)
    End Sub

    Private Sub TestOKEnabled()
        If rdoUnhideDataFrame.Checked Then
            ucrBase.OKEnabled(Not ucrReceiverMultipleUnhide.IsEmpty)
        Else
            ' You cannot hide all data frames. When the receiver is blank all data frames are unhidden so this is allowed.
            ucrBase.OKEnabled(ucrReceiverMultiple.lstSelectedVariables.Items.Count <> ucrSelectorForDataFrames.lstAvailableVariable.Items.Count)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrPnlHideUnhide.SetRCode(clsDummyFunction, bReset)
        ucrReceiverMultiple.SetRCode(clsHideDataFramesFunction, bReset)
    End Sub

    Private Sub SetHiddenColumns()
        Dim expTemp As SymbolicExpression
        Dim chrHiddenColumns As CharacterVector
        Dim clsGetHiddenDataFrames As New RFunction

        clsGetHiddenDataFrames.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_hidden_data_frames")
        clsHideDataFramesFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$set_hidden_data_frames")

        ucrSelectorForDataFrames.lstAvailableVariable.Items.Clear()
        expTemp = frmMain.clsRLink.RunInternalScriptGetValue(clsGetHiddenDataFrames.ToScript(), bSilent:=True)

        If expTemp IsNot Nothing AndAlso expTemp.Type <> Internals.SymbolicExpressionType.Null Then
            chrHiddenColumns = expTemp.AsCharacter
            For i As Integer = 0 To chrHiddenColumns.Length - 1
                Dim strDataFrame As String = chrHiddenColumns(i)
                Dim listItem As New ListViewItem(strDataFrame)
                listItem.Tag = "data_names"
                ucrSelectorForDataFrames.lstAvailableVariable.Items.Add(listItem)
            Next
        End If
    End Sub

    Private Sub ucrReceiverMultiple_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMultiple.ControlContentsChanged
        TestOKEnabled()
        CountLevels()
    End Sub

    Private Sub ucrPnlHideUnhide_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlHideUnhide.ControlValueChanged
        If rdoHideDataFrame.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsHideDataFramesFunction)
            clsDummyFunction.AddParameter("checked", "rdoHide", iPosition:=0)
            ucrReceiverMultiple.SetMeAsReceiver()
        Else
            ucrBase.clsRsyntax.SetBaseRFunction(clsMappingFunction)
            clsDummyFunction.AddParameter("checked", "rdoUnhide", iPosition:=0)
            SetHiddenColumns()
            ucrReceiverMultipleUnhide.SetMeAsReceiver()
        End If
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverMultipleUnhide_Enter(sender As Object, e As EventArgs) Handles ucrReceiverMultipleUnhide.Enter
        SetHiddenColumns()
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverMultipleUnhide_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMultipleUnhide.ControlValueChanged
        SetHiddenColumns()
        TestOKEnabled()
        CountLevels()
        clsDataUnhideOperator.AddParameter("data", ucrReceiverMultipleUnhide.GetVariableNames(True), iPosition:=0, bIncludeArgumentName:=False)
    End Sub

    Private Sub ReopenDialog()
        ucrReceiverMultiple.Clear()
        ucrReceiverMultipleUnhide.Clear()
    End Sub

    Private Sub CountLevels()

        lblHiddenNumber.Text = " " & ucrReceiverMultiple.Count
        lblHiddenNumber.Visible = ucrReceiverMultiple.Count > 0

        lblUnHiddenNumber.Text = " " & ucrReceiverMultipleUnhide.Count
        lblUnHiddenNumber.Visible = ucrReceiverMultipleUnhide.Count > 0
    End Sub
End Class