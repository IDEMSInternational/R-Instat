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
Public Class dlgClimaticBoxPlot
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private Sub dlgClimaticBoxPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()

        ucrReceiverStation.Selector = ucrSelectorClimaticBoxPlot
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.bAutoFill = True
        ucrReceiverStation.SetMeAsReceiver()

        ucrReceiverDate.Selector = ucrSelectorClimaticBoxPlot
        ucrReceiverDate.SetClimaticType("date")
        ucrReceiverDate.bAutoFill = True

        ucrReceiverYear.Selector = ucrSelectorClimaticBoxPlot
        ucrReceiverYear.SetClimaticType("year")
        ucrReceiverYear.bAutoFill = True

        ucrPnlPlots.AddRadioButton(rdoViolin)
        ucrPnlPlots.AddRadioButton(rdoBoxplot)
        ucrPnlPlots.AddRadioButton(rdoJitter)

        ucrChkVarWidth.SetParameter(New RParameter("varwidth", 1))
        ucrChkVarWidth.SetText("Variable Width")
        ucrChkVarWidth.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkVarWidth.SetRDefault("FALSE")

        ucrSaveBoxplot.SetPrefix("boxplot")
        ucrSaveBoxplot.SetIsComboBox()
        ucrSaveBoxplot.SetCheckBoxText("Save Graph")
        ucrSaveBoxplot.SetSaveTypeAsGraph()
        ucrSaveBoxplot.SetDataFrameSelector(ucrSelectorClimaticBoxPlot.ucrAvailableDataFrames)
        ucrSaveBoxplot.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()

    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)

    End Sub

    Private Sub TestOKEnabled()

    End Sub
End Class