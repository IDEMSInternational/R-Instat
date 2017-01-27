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
Public Class dlgRowStats
    Private bFirstLoad As Boolean = True
    Private clsDefaultFunction As New RFunction
    Private Sub dlgRowStats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        'Checks if Ok can be enabled.
        TestOKEnabled()

    End Sub

    Private Sub SetDefaults()
        ' Set default RFunction as the base function
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
        ucrSelectorForRowStats.Reset()
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, True)
        ' ucrSelectorForRowStats.Focus()
    End Sub

    Private Sub ReopenDialog()
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverForRowStatistics.IsEmpty AndAlso ucrSaveResults.IsComplete Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    'this is only temporary and needs to be worked on later
    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 45
        cmdUserDefined.Enabled = False
        ' ucrBase.clsRsyntax.SetFunction("apply")

        'Setting receiver Data rypes, parameters and making it as a receiver
        ucrReceiverForRowStatistics.Selector = ucrSelectorForRowStats
        ucrReceiverForRowStatistics.SetMeAsReceiver()
        ucrReceiverForRowStatistics.SetDataType("numeric")
        ucrReceiverForRowStatistics.SetParameter(New RParameter("X"))
        ucrReceiverForRowStatistics.SetParameterIsString()


        ucrPanelStatistics.SetParameter(New RParameter("FUN"))
        ucrPanelStatistics.AddRadioButton(rdoMean, "mean")
        ucrPanelStatistics.AddRadioButton(rdoMinimum, "min")
        ucrPanelStatistics.AddRadioButton(rdoSum, "sum")
        ucrPanelStatistics.AddRadioButton(rdoMedian, "median")
        ucrPanelStatistics.AddRadioButton(rdoNumberofMissing, "function(z) sum(is.na(z))")
        ucrPanelStatistics.AddRadioButton(rdoStandardDeviation, "sd")
        ucrPanelStatistics.AddRadioButton(rdoMaximum, "max")
        ucrPanelStatistics.AddRadioButton(rdoCount, "function(z) sum(!is.na(z))")
        ucrPanelStatistics.SetRDefault("mean")

        ucrSaveResults.SetPrefix("row_summary")
        ucrSaveResults.SetSaveTypeAsColumn()
        ucrSaveResults.SetDataFrameSelector(ucrSelectorForRowStats.ucrAvailableDataFrames)
        ucrSaveResults.SetLabelText("Row Summary")
        ucrSaveResults.SetIsComboBox()

        'Defining the default RFunction
        clsDefaultFunction.SetRCommand("apply")
        clsDefaultFunction.AddParameter("FUN", "mean")
        clsDefaultFunction.AddParameter("MARGIN", 1)
        clsDefaultFunction.SetAssignTo("row_summary", strTempDataframe:=ucrSelectorForRowStats.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:="row_summary")


    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSelectorForRowStats.ControlContentsChanged, ucrReceiverForRowStatistics.ControlContentsChanged, ucrSaveResults.ControlContentsChanged
        TestOKEnabled()
    End Sub

End Class