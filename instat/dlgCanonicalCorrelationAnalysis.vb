' Instat-R
' Copyright (C) 2015
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
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.
Imports instat.Translations
Public Class dlgCanonicalCorrelationAnalysis
    Public strModelName As String = ""
    Public bFirstLoad As Boolean = True
    Private Sub dlgCanonicalCorrelationAnalysis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If

        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBaseCCA.clsRsyntax.SetFunction("cancor")
        ucrBaseCCA.clsRsyntax.iCallType = 0
        ucrReceiverYvariables.Selector = ucrSelectorCCA
        ucrReceiverXvariables.Selector = ucrSelectorCCA
        ucrBaseCCA.iHelpTopicID = 423
        ucrReceiverYvariables.SetIncludedDataTypes({"numeric"})
        ucrReceiverXvariables.SetIncludedDataTypes({"numeric"})
        ucrResultName.SetDefaultTypeAsModel()
        ucrResultName.SetPrefix("CCA")
        ucrResultName.SetValidationTypeAsRVariable()

    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub SetDefaults()
        ucrSelectorCCA.Reset()
        ucrReceiverYvariables.SetMeAsReceiver()
        ucrSelectorCCA.Focus()
        chkSaveResult.Checked = True
        ucrResultName.Visible = True
        sdgCanonicalCorrelation.SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If chkSaveResult.Checked AndAlso ucrResultName.IsEmpty Then
            ucrBaseCCA.OKEnabled(False)
        ElseIf (Not ucrReceiverYvariables.IsEmpty()) And (Not ucrReceiverXvariables.IsEmpty()) Then
            ucrBaseCCA.OKEnabled(True)
            AssignName()
        Else
            ucrBaseCCA.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrSelectorCCA_DataFrameChanged() Handles ucrSelectorCCA.DataFrameChanged
        AssignName()
    End Sub

    Private Sub ucrBaseCCA_ClickReset(sender As Object, e As EventArgs) Handles ucrBaseCCA.ClickReset
        SetDefaults()
    End Sub

    Public Sub ucrreceiverxvariables_selectionchanged() Handles ucrReceiverXvariables.SelectionChanged
        TestOKEnabled()
        ucrBaseCCA.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrReceiverXvariables.GetVariables())
    End Sub

    Public Sub ucrReceiverYvariables_SelectionChanged() Handles ucrReceiverYvariables.SelectionChanged
        TestOKEnabled()
        ucrBaseCCA.clsRsyntax.AddParameter("y", clsRFunctionParameter:=ucrReceiverYvariables.GetVariables())
    End Sub

    Private Sub cmdCCAOptions_Click(sender As Object, e As EventArgs) Handles cmdCCAOptions.Click
        sdgCanonicalCorrelation.ShowDialog()
    End Sub

    Private Sub ucrResultName_NameChanged() Handles ucrResultName.NameChanged
        AssignName()
        TestOKEnabled()
    End Sub

    Private Sub chkSaveResult_CheckedChanged(sender As Object, e As EventArgs) Handles chkSaveResult.CheckedChanged
        If chkSaveResult.Checked Then
            ucrResultName.Visible = True
        Else
            ucrResultName.Visible = False
        End If
        AssignName()
        TestOKEnabled()
    End Sub

    Public Sub AssignName()
        If chkSaveResult.Checked AndAlso ucrResultName.GetText() <> "" Then
            ucrBaseCCA.clsRsyntax.SetAssignTo(ucrResultName.GetText(), strTempModel:=ucrResultName.GetText(), strTempDataframe:=ucrSelectorCCA.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem)
            ucrBaseCCA.clsRsyntax.bExcludeAssignedFunctionOutput = False
            strModelName = ucrResultName.GetText()
        Else
            ucrBaseCCA.clsRsyntax.SetAssignTo("last_CCA", strTempModel:="last_CCA", strTempDataframe:=ucrSelectorCCA.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem)
            ucrBaseCCA.clsRsyntax.bExcludeAssignedFunctionOutput = False
            strModelName = "last_CCA"
        End If
    End Sub

    Private Sub ucrBaseCCA_clickok(sender As Object, e As EventArgs) Handles ucrBaseCCA.ClickOk
        sdgCanonicalCorrelation.CCAOptions()
    End Sub

End Class