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
    Private clsLeftJoin As RFunction
    Private clsByList As RFunction
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
        ucrFirstDataFrame.SetParameter(New RParameter("x", 0))
        ucrFirstDataFrame.SetParameterIsRFunction()
        ucrFirstDataFrame.SetLabelText("Main Data Frame:")

        ucrSecondSelector.SetLabelText("Additional Data Frame:")

        ucrReceiverSecond.SetParameter(New RParameter("y", 1))
        ucrReceiverSecond.SetParameterIsRFunction()
        ucrReceiverSecond.Selector = ucrSecondSelector
        ucrReceiverSecond.bForceAsDataFrame = True

        ucrInputMergingBy.IsReadOnly = True
        ucrInputMergingBy.IsMultiline = True
    End Sub

    Private Sub SetDefaults()
        clsLeftJoin = New RFunction
        clsByList = New RFunction

        ucrFirstDataFrame.Reset()
        ucrSecondSelector.Reset()
        ucrReceiverSecond.SetMeAsReceiver()
        ucrInputMergingBy.SetName("")

        clsLeftJoin.SetPackageName("dplyr")
        clsLeftJoin.SetRCommand("left_join")

        clsByList.SetRCommand("c")

        SetDataFrameAssign()
        ucrBase.clsRsyntax.SetBaseRFunction(clsLeftJoin)
        bResetSubdialog = True
    End Sub

    Private Sub SetRCodeforControls(bResetControls As Boolean)
        ucrFirstDataFrame.SetRCode(clsLeftJoin, bResetControls)
        ucrReceiverSecond.SetRCode(clsLeftJoin, bResetControls)
    End Sub

    Private Sub TestOkEnabled()
        If ucrFirstDataFrame.cboAvailableDataFrames.Text <> "" AndAlso ucrSecondSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" AndAlso Not ucrReceiverSecond.IsEmpty() AndAlso bBySpecified Then
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

    Private Sub ucrFirstDataFrame_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrFirstDataFrame.ControlValueChanged
        SetDataFrameAssign()
        GetLinkInformation()
    End Sub

    Private Sub SetDataFrameAssign()
        If clsLeftJoin IsNot Nothing Then
            If ucrFirstDataFrame.cboAvailableDataFrames.Text <> "" Then
                clsLeftJoin.SetAssignTo(ucrFirstDataFrame.cboAvailableDataFrames.Text, ucrFirstDataFrame.cboAvailableDataFrames.Text)
            Else
                clsLeftJoin.RemoveAssignTo()
            End If
        End If
    End Sub

    Private Sub GetLinkInformation()
        Dim expTemp As SymbolicExpression
        Dim clsGetLink As New RFunction
        Dim clsItemOperator As New ROperator
        Dim chrColumns As CharacterVector

        clsByList.ClearParameters()
        If ucrFirstDataFrame.cboAvailableDataFrames.Text <> "" AndAlso ucrSecondSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            clsGetLink.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_link_between")
            clsGetLink.AddParameter("from_data_frame", Chr(34) & ucrFirstDataFrame.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
            clsGetLink.AddParameter("to_data_frame", Chr(34) & ucrSecondSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=1)
            clsGetLink.AddParameter("ordered", "TRUE", iPosition:=2)
            clsItemOperator.SetOperation("$")
            clsItemOperator.AddParameter("left", clsRFunctionParameter:=clsGetLink, iPosition:=0)
            clsItemOperator.AddParameter("right", "link_columns", iPosition:=1)
            expTemp = frmMain.clsRLink.RunInternalScriptGetValue(clsItemOperator.ToScript(), bSilent:=True)
            If expTemp IsNot Nothing AndAlso expTemp.Type = Internals.SymbolicExpressionType.List AndAlso expTemp.AsList.Count > 0 Then
                chrColumns = expTemp.AsList(0).AsCharacter
                For i As Integer = 0 To chrColumns.Count - 1
                    clsByList.AddParameter(Chr(34) & chrColumns.Names(i) & Chr(34), Chr(34) & chrColumns(i) & Chr(34))
                    ucrReceiverSecond.Add(chrColumns(i), ucrSecondSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
                Next
                clsLeftJoin.AddParameter("by", clsRFunctionParameter:=clsByList, iPosition:=2)
                PopulateMergeByText()
                bBySpecified = True
            Else
                ucrInputMergingBy.SetName("No link between these data frames. Click 'Join Options' to specify merging columns.")
                clsLeftJoin.RemoveParameterByName("by")
                bBySpecified = False
            End If
        Else
            ucrInputMergingBy.SetName("")
            clsLeftJoin.RemoveParameterByName("by")
            bBySpecified = False
        End If
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrFirstDataFrame.ControlContentsChanged, ucrSecondSelector.ControlContentsChanged, ucrReceiverSecond.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrSecondSelector_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSecondSelector.ControlValueChanged
        GetLinkInformation()
    End Sub

    Private Sub cmdModify_Click(sender As Object, e As EventArgs) Handles cmdModify.Click
        sdgMerge.Setup(ucrFirstDataFrame.cboAvailableDataFrames.Text, ucrSecondSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, clsLeftJoin, clsByList, bResetSubdialog)
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

        If clsLeftJoin.ContainsParameter("by") AndAlso clsByList.clsParameters.Count > 0 Then
            strMergeBy = clsByList.ToScript()
            ucrInputMergingBy.SetName(strMergeBy.Substring(2, strMergeBy.Length - 3).Replace(Chr(34), ""))
            For i As Integer = 0 To clsByList.clsParameters.Count - 1
                ucrReceiverSecond.Add(clsByList.clsParameters(i).strArgumentValue.Replace(Chr(34), ""), ucrSecondSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
            Next
        Else
            strMergeBy = ""
            clsNames1.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_column_names")
            clsNames1.AddParameter("data_name", Chr(34) & ucrFirstDataFrame.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
            clsNames2.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_column_names")
            clsNames2.AddParameter("data_name", Chr(34) & ucrSecondSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
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
                        ucrReceiverSecond.Add(chrColumns(i), ucrSecondSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
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