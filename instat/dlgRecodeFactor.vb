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

Public Class dlgRecodeFactor
    Private bFirstLoad As Boolean = True
    Private clsReplaceFunction, clsRevalueFunction As RFunction
    Private bReset As Boolean = True
    Private Sub dlgRecodeFactor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 37

        ucrReceiverFactor.SetParameter(New RParameter("x", 0))
        ucrReceiverFactor.Selector = ucrSelectorForRecode
        ucrReceiverFactor.SetIncludedDataTypes({"factor"}, bStrict:=True)
        ucrReceiverFactor.strSelectorHeading = "Factors"
        ucrReceiverFactor.SetMeAsReceiver()
        ucrReceiverFactor.SetParameterIsRFunction()

        ucrFactorGrid.SetReceiver(ucrReceiverFactor)
        ucrFactorGrid.SetAsViewerOnly()
        ucrFactorGrid.bIncludeCopyOfLevels = True
        ucrFactorGrid.AddEditableColumns({"New Label"})

        ucrSaveNewColumn.SetSaveTypeAsColumn()
        ucrSaveNewColumn.SetDataFrameSelector(ucrSelectorForRecode.ucrAvailableDataFrames)
        ucrSaveNewColumn.SetIsComboBox()
        ucrSaveNewColumn.SetLabelText("New Column Name:")
    End Sub

    Private Sub SetDefaults()
        clsReplaceFunction = New RFunction
        clsRevalueFunction = New RFunction

        ucrSelectorForRecode.Reset()
        ucrSelectorForRecode.Focus()
        ucrFactorGrid.ResetText()
        ucrSaveNewColumn.Reset()

        clsRevalueFunction.SetPackageName("plyr")
        clsRevalueFunction.SetRCommand("revalue")
        clsRevalueFunction.AddParameter("replace", clsRFunctionParameter:=clsReplaceFunction)
        clsRevalueFunction.SetAssignTo(strTemp:=ucrSaveNewColumn.GetText(), strTempDataframe:=ucrSelectorForRecode.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrSaveNewColumn.GetText())

        clsReplaceFunction.SetRCommand("c")

        ucrBase.clsRsyntax.SetBaseRFunction(clsRevalueFunction)
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        SetRCode(Me, clsRevalueFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverFactor.IsEmpty AndAlso ucrSaveNewColumn.IsComplete AndAlso ucrFactorGrid.IsColumnComplete("New Label") Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOKEnabled()
    End Sub

    Private Sub DefaultNewName()
        If ((Not ucrSaveNewColumn.bUserTyped) AndAlso (Not ucrReceiverFactor.IsEmpty)) Then
            ucrSaveNewColumn.SetPrefix(ucrReceiverFactor.GetVariableNames(bWithQuotes:=False) & "_recoded")
        End If
    End Sub

    Private Sub ucrFactorGrid_GridContentChanged() Handles ucrFactorGrid.GridContentChanged
        Dim strCurrentLabels As List(Of String)
        Dim strNewLabels As List(Of String)
        Dim strReplace As String = ""

        strCurrentLabels = ucrFactorGrid.GetColumnAsList(ucrFactorGrid.strLabelsName, False)
        strNewLabels = ucrFactorGrid.GetColumnAsList("New Label", True)
        clsReplaceFunction.ClearParameters()

        If ucrFactorGrid.IsColumnComplete("New Label") AndAlso strCurrentLabels.Count = strNewLabels.Count Then
            For i = 0 To strCurrentLabels.Count - 1
                ' Backtick needed for names of the vector incase the levels are not valid R names
                clsReplaceFunction.AddParameter(Chr(96) & strCurrentLabels(i) & Chr(96), strNewLabels(i))
            Next
            ucrBase.clsRsyntax.AddParameter("replace", clsRFunctionParameter:=clsReplaceFunction)
        Else
            ucrBase.clsRsyntax.RemoveParameter("replace")
        End If
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverFactor_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFactor.ControlValueChanged
        DefaultNewName()
    End Sub

    Private Sub ucrReceiverFactor_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFactor.ControlContentsChanged, ucrSaveNewColumn.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class