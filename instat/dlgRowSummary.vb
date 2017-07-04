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
Public Class dlgRowSummary
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsApplyFunction As New RFunction

    Private Sub dlgRowSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 45
        cmdUserDefined.Enabled = False ' temporarily disabled

        'Setting receiver data types and parameters
        ucrReceiverForRowSummaries.SetParameter(New RParameter("X", 0))
        ucrReceiverForRowSummaries.Selector = ucrSelectorForRowSummaries
        ucrReceiverForRowSummaries.SetMeAsReceiver()
        ucrReceiverForRowSummaries.strSelectorHeading = "Numerics"
        ucrReceiverForRowSummaries.SetIncludedDataTypes({"numeric"})
        ucrReceiverForRowSummaries.bUseFilteredData = False
        ucrReceiverForRowSummaries.bForceAsDataFrame = True
        ucrReceiverForRowSummaries.SetParameterIsRFunction()

        ucrPanelStatistics.SetParameter(New RParameter("FUN", 2))
        ucrPanelStatistics.AddRadioButton(rdoMean, "mean")
        ucrPanelStatistics.AddRadioButton(rdoMinimum, "min")
        ucrPanelStatistics.AddRadioButton(rdoSum, "sum")
        ucrPanelStatistics.AddRadioButton(rdoMedian, "median")
        ucrPanelStatistics.AddRadioButton(rdoNumberofMissing, "function(z) sum(is.na(z))")
        ucrPanelStatistics.AddRadioButton(rdoStandardDeviation, "sd")
        ucrPanelStatistics.AddRadioButton(rdoMaximum, "max")
        ucrPanelStatistics.AddRadioButton(rdoCount, "function(z) sum(!is.na(z))")

        ucrSaveResults.SetPrefix("row_summary")
        ucrSaveResults.SetSaveTypeAsColumn()
        ucrSaveResults.SetDataFrameSelector(ucrSelectorForRowSummaries.ucrAvailableDataFrames)
        ucrSaveResults.SetLabelText("New Column Name:")
        ucrSaveResults.SetIsComboBox()
    End Sub

    Private Sub SetDefaults()
        clsApplyFunction = New RFunction

        'reset
        ucrSelectorForRowSummaries.Reset()
        ucrSaveResults.Reset()

        'Defining the default RFunction
        clsApplyFunction.SetPackageName("base")
        clsApplyFunction.SetRCommand("apply")
        clsApplyFunction.AddParameter("FUN", "mean")
        clsApplyFunction.AddParameter("MARGIN", 1)
        clsApplyFunction.SetAssignTo(ucrSaveResults.GetText, strTempDataframe:=ucrSelectorForRowSummaries.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        ucrBase.clsRsyntax.SetBaseRFunction(clsApplyFunction)
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverForRowSummaries.IsEmpty AndAlso ucrSaveResults.IsComplete Then
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

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverForRowSummaries.ControlContentsChanged, ucrSaveResults.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class