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
Public Class dlgInventoryPlot
    Private bFirstLoad As Boolean = True
    Private Sub dlgInventoryPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$make_inventory_plot")
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.iHelpTopicID = 455

        ucrYearReceiver.SetIncludedDataTypes({"factor"})
        ucrDayOfYearReceiver.SetIncludedDataTypes({"numeric"})
        ucrColourReceiver.SetIncludedDataTypes({"numeric"})

        ucrYearReceiver.Selector = UcrInventoryPlotSelector
        ucrColourReceiver.Selector = UcrInventoryPlotSelector
        ucrDayOfYearReceiver.Selector = UcrInventoryPlotSelector
        ucrSaveInventoryPlot.strPrefix = "InventoryPlot"
        ucrSaveInventoryPlot.SetDataFrameSelector(UcrInventoryPlotSelector.ucrAvailableDataFrames)
        nudThreshold.Minimum = 0.85

    End Sub

    Private Sub TestOkEnabled()
        If (Not ucrYearReceiver.IsEmpty AndAlso Not ucrDayOfYearReceiver.IsEmpty AndAlso Not ucrColourReceiver.IsEmpty) OrElse (ucrSaveInventoryPlot.chkSaveGraph.Checked AndAlso Not ucrSaveInventoryPlot.ucrInputGraphName.IsEmpty) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub
    Private Sub SetDefaults()
        UcrInventoryPlotSelector.Reset()
        ucrYearReceiver.SetMeAsReceiver()
        chkThreshold.Checked = False
        nudThreshold.Visible = False
        nudThreshold.Value = 0.85
        nudThreshold.Increment = 0.01
        nudThreshold.DecimalPlaces = 2
        ucrBase.clsRsyntax.AddParameter("threshold", nudThreshold.Value)
        TestOkEnabled()
    End Sub

    Public Sub SetCoordFlip()
        Dim clsTempRFunc As New RFunction
        If chkFlipCoordinates.Checked Then
            clsTempRFunc.SetRCommand("coord_flip")
            ucrBase.clsRsyntax.AddOperatorParameter("coord_flip", clsRFunc:=clsTempRFunc)
        Else
            ucrBase.clsRsyntax.RemoveOperatorParameter("coord_flip")
        End If
    End Sub

    Private Sub ucrSaveInventoryPlot_GraphNameChanged() Handles ucrSaveInventoryPlot.GraphNameChanged, ucrSaveInventoryPlot.SaveGraphCheckedChanged
        If ucrSaveInventoryPlot.bSaveGraph Then
            ucrBase.clsRsyntax.SetAssignTo(ucrSaveInventoryPlot.strGraphName, strTempDataframe:=UcrInventoryPlotSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:=ucrSaveInventoryPlot.strGraphName)
        Else
            ucrBase.clsRsyntax.SetAssignTo("last_graph", strTempDataframe:=UcrInventoryPlotSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        End If
    End Sub

    Private Sub chkFlipCoordinates_CheckedChanged(sender As Object, e As EventArgs) Handles chkFlipCoordinates.CheckedChanged
        SetCoordFlip()
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgPlots.SetRSyntax(ucrBase.clsRsyntax)
        sdgPlots.ShowDialog()
    End Sub

    Private Sub UcrInventoryPlotSelector_DataFrameChanged() Handles UcrInventoryPlotSelector.DataFrameChanged
        ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & UcrInventoryPlotSelector.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
    End Sub

    Private Sub ucrSaveInventoryPlot_ContentsChanged() Handles ucrSaveInventoryPlot.ContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrDayOfYearReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrDayOfYearReceiver.SelectionChanged
        If Not ucrDayOfYearReceiver.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("doy", ucrDayOfYearReceiver.GetVariableNames())
        Else
            ucrBase.clsRsyntax.RemoveParameter("doy")
        End If

        TestOkEnabled()

    End Sub

    Private Sub ucrColourReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrColourReceiver.SelectionChanged
        If Not ucrColourReceiver.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("col_name", ucrColourReceiver.GetVariableNames())
        Else
            ucrBase.clsRsyntax.RemoveParameter("col_name")
        End If
        TestOkEnabled()
    End Sub

    Private Sub ucrYearReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrYearReceiver.SelectionChanged
        If Not ucrYearReceiver.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("year", ucrYearReceiver.GetVariableNames())
        Else
            ucrBase.clsRsyntax.RemoveParameter("year")
        End If
        TestOkEnabled()
    End Sub

    Private Sub chkAddRecodetoData_CheckedChanged(sender As Object, e As EventArgs) Handles chkAddRecodetoData.CheckedChanged
        If chkAddRecodetoData.Checked Then
            ucrBase.clsRsyntax.AddParameter("add_to_data", "TRUE")
        Else
            ucrBase.clsRsyntax.RemoveParameter("add_to_data")
        End If
    End Sub

    Private Sub SetThreshold()
        If chkThreshold.Checked AndAlso nudThreshold.Value > 0.85 Then
            ucrBase.clsRsyntax.AddParameter("threshold", nudThreshold.Value)
        Else
            ucrBase.clsRsyntax.RemoveParameter("threshold")
        End If
    End Sub

    Private Sub nudThreshold_ValueChanged(sender As Object, e As EventArgs) Handles nudThreshold.TextChanged
        SetThreshold()
    End Sub

    Private Sub chkThreshold_CheckedChanged(sender As Object, e As EventArgs) Handles chkThreshold.CheckedChanged
        If chkThreshold.Checked Then
            nudThreshold.Visible = True
        Else
            nudThreshold.Visible = False
            ucrBase.clsRsyntax.AddParameter("threshold", 0.85)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub
End Class