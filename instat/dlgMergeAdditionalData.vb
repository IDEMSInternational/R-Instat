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

Imports instat.Translations
Imports RDotNet

Public Class dlgMergeAdditionalData
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsLeftJoinFunction As New RFunction
    Private clsByListFunction, clsInsertColumnFunction As New RFunction
    Private bResetSubdialog As Boolean = True
    Private bBySpecified As Boolean

    Private Sub dlgMergeAdditionalData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeforControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrToDataFrame.SetParameter(New RParameter("x", 0))
        ucrToDataFrame.SetParameterIsRFunction()
        ucrToDataFrame.SetLabelText("To Data Frame:")

        ucrFromDataFrame.SetLabelText("From Data Frame:")

        ucrReceiverSecond.SetParameter(New RParameter("y", 1))
        ucrReceiverSecond.SetParameterIsRFunction()
        ucrReceiverSecond.Selector = ucrFromDataFrame
        ucrReceiverSecond.bForceAsDataFrame = True

        ucrChkSaveDataFrame.SetText("New Data Frame:")
        ucrChkSaveDataFrame.AddFunctionNamesCondition(True, "left_join")
        ucrChkSaveDataFrame.AddFunctionNamesCondition(False, frmMain.clsRLink.strInstatDataObject & "$add_columns_to_data")

        ucrInputMergingBy.IsReadOnly = True
        ucrInputMergingBy.IsMultiline = True
    End Sub

    Private Sub SetDefaults()
        clsLeftJoinFunction = New RFunction
        clsByListFunction = New RFunction
        clsInsertColumnFunction = New RFunction

        ucrToDataFrame.Reset()
        ucrFromDataFrame.Reset()
        ucrReceiverSecond.SetMeAsReceiver()
        ucrInputMergingBy.SetName("")
        ucrInputSaveDataFrame.SetName("merge")

        clsInsertColumnFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_columns_to_data")

        clsLeftJoinFunction.SetPackageName("dplyr")
        clsLeftJoinFunction.SetRCommand("left_join")

        clsByListFunction.SetRCommand("c")

        SetDataFrameAssign()
        ucrBase.clsRsyntax.SetBaseRFunction(clsInsertColumnFunction)
        bResetSubdialog = True
    End Sub

    Private Sub SetRCodeforControls(bResetControls As Boolean)
        ucrToDataFrame.SetRCode(clsLeftJoinFunction, bResetControls)
        ucrReceiverSecond.SetRCode(clsLeftJoinFunction, bResetControls)
        ucrChkSaveDataFrame.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If ucrToDataFrame.cboAvailableDataFrames.Text <> "" AndAlso ucrFromDataFrame.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" AndAlso Not ucrReceiverSecond.IsEmpty() AndAlso bBySpecified Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrFirstDataFrame_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrToDataFrame.ControlValueChanged
        SetDataFrameAssign()
        GetLinkInformation()
    End Sub

    Private Sub ucrChkSaveDataFrame_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSaveDataFrame.ControlValueChanged, ucrInputSaveDataFrame.ControlValueChanged
        SetDataFrameAssign()
    End Sub

    Private Sub SetDataFrameAssign()
        If clsLeftJoinFunction IsNot Nothing Then
            If ucrToDataFrame.cboAvailableDataFrames.Text <> "" Then
                clsLeftJoinFunction.RemoveAssignTo()
                If ucrChkSaveDataFrame.Checked Then
                    clsLeftJoinFunction.SetAssignTo(ucrInputSaveDataFrame.GetText, strTempDataframe:=ucrInputSaveDataFrame.GetText)
                    ucrBase.clsRsyntax.SetBaseRFunction(clsLeftJoinFunction)
                    ucrInputSaveDataFrame.Visible = True
                Else
                    clsLeftJoinFunction.SetAssignTo(ucrToDataFrame.cboAvailableDataFrames.Text)
                    clsInsertColumnFunction.AddParameter("data_name", Chr(34) & ucrToDataFrame.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
                    clsInsertColumnFunction.AddParameter("col_data", clsRFunctionParameter:=clsLeftJoinFunction, iPosition:=1)
                    ucrBase.clsRsyntax.SetBaseRFunction(clsInsertColumnFunction)
                    ucrInputSaveDataFrame.Visible = False
                End If
            Else
                clsLeftJoinFunction.RemoveAssignTo()
            End If
        End If
    End Sub

    Private Sub GetLinkInformation()
        Dim expTemp As SymbolicExpression
        Dim clsGetLink As New RFunction
        Dim clsItemOperator As New ROperator
        Dim chrColumns As CharacterVector

        clsByListFunction.ClearParameters()
        If ucrToDataFrame.cboAvailableDataFrames.Text <> "" AndAlso ucrFromDataFrame.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            clsGetLink.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_link_between")
            clsGetLink.AddParameter("from_data_frame", Chr(34) & ucrToDataFrame.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
            clsGetLink.AddParameter("to_data_frame", Chr(34) & ucrFromDataFrame.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=1)
            clsGetLink.AddParameter("ordered", "TRUE", iPosition:=2)
            clsItemOperator.SetOperation("$")
            clsItemOperator.AddParameter("left", clsRFunctionParameter:=clsGetLink, iPosition:=0)
            clsItemOperator.AddParameter("right", "link_columns", iPosition:=1)
            expTemp = frmMain.clsRLink.RunInternalScriptGetValue(clsItemOperator.ToScript(), bSilent:=True)
            If expTemp IsNot Nothing AndAlso expTemp.Type = Internals.SymbolicExpressionType.List AndAlso expTemp.AsList.Count > 0 Then
                chrColumns = expTemp.AsList(0).AsCharacter
                For i As Integer = 0 To chrColumns.Count - 1
                    clsByListFunction.AddParameter(Chr(34) & chrColumns.Names(i) & Chr(34), Chr(34) & chrColumns(i) & Chr(34))
                    ucrReceiverSecond.Add(chrColumns(i), ucrFromDataFrame.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
                Next
                clsLeftJoinFunction.AddParameter("by", clsRFunctionParameter:=clsByListFunction, iPosition:=2)
                PopulateMergeByText()
                bBySpecified = True
            Else
                ucrInputMergingBy.SetName("No link between these data frames. Click 'Join Options' to specify merging columns.")
                clsLeftJoinFunction.RemoveParameterByName("by")
                bBySpecified = False
            End If
        Else
            ucrInputMergingBy.SetName("")
            clsLeftJoinFunction.RemoveParameterByName("by")
            bBySpecified = False
        End If
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrToDataFrame.ControlContentsChanged, ucrFromDataFrame.ControlContentsChanged, ucrReceiverSecond.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrSecondSelector_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrFromDataFrame.ControlValueChanged
        GetLinkInformation()
    End Sub

    Private Sub cmdModify_Click(sender As Object, e As EventArgs) Handles cmdModify.Click
        sdgMerge.Setup(ucrToDataFrame.cboAvailableDataFrames.Text, ucrFromDataFrame.ucrAvailableDataFrames.cboAvailableDataFrames.Text, clsLeftJoinFunction, clsByListFunction, bResetSubdialog)
        sdgMerge.ShowDialog()
        PopulateMergeByText()
        bResetSubdialog = False
        TestOkEnabled()
    End Sub

    Private Sub PopulateMergeByText()
        Dim strMergeBy As String
        Dim clsNames1 As New RFunction
        Dim clsNames2 As New RFunction
        Dim clsIntersect As New RFunction
        Dim expTemp As SymbolicExpression
        Dim chrColumns As CharacterVector
        Dim strTemp As String = ""
        Dim strScript As String = ""

        If clsLeftJoinFunction.ContainsParameter("by") AndAlso clsByListFunction.clsParameters.Count > 0 Then
            strMergeBy = clsByListFunction.ToScript()
            ucrInputMergingBy.SetName(strMergeBy.Substring(2, strMergeBy.Length - 3).Replace(Chr(34), ""))
            For i As Integer = 0 To clsByListFunction.clsParameters.Count - 1
                ucrReceiverSecond.Add(clsByListFunction.clsParameters(i).strArgumentValue.Replace(Chr(34), ""), ucrFromDataFrame.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
            Next
        Else
            strMergeBy = ""
            clsNames1.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_column_names")
            clsNames1.AddParameter("data_name", Chr(34) & ucrToDataFrame.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
            clsNames2.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_column_names")
            clsNames2.AddParameter("data_name", Chr(34) & ucrFromDataFrame.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
            clsIntersect.SetPackageName("dplyr")
            clsIntersect.SetRCommand("intersect")
            clsIntersect.AddParameter("x", clsRFunctionParameter:=clsNames1, iPosition:=0)
            clsIntersect.AddParameter("y", clsRFunctionParameter:=clsNames2, iPosition:=1)
            strScript = clsIntersect.ToScript(strTemp)
            strScript = strTemp & strScript
            expTemp = frmMain.clsRLink.RunInternalScriptGetValue(strScript, bSilent:=True)
            If expTemp IsNot Nothing AndAlso expTemp.Type <> Internals.SymbolicExpressionType.Null Then
                chrColumns = expTemp.AsCharacter
                If chrColumns.Count > 0 Then
                    For i As Integer = 0 To chrColumns.Count - 1
                        If i <> 0 Then
                            strMergeBy = strMergeBy & ", "
                        End If
                        strMergeBy = strMergeBy & chrColumns(i) & "=" & chrColumns(i)
                        ucrReceiverSecond.Add(chrColumns(i), ucrFromDataFrame.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
                    Next
                    bBySpecified = True
                Else
                    strMergeBy = "No columns with the same name. Click 'Join Options' to specify merging columns."
                    bBySpecified = False
                End If
            End If
            ucrInputMergingBy.SetName(strMergeBy)
        End If
    End Sub
End Class