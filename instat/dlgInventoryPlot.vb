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
    Private clsRggplotFunction As New RFunction
    Private clsRgeom_geompointFunction As New RFunction
    Private clsRaesFunction As New RFunction

    Private Sub dlgInventoryPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
        End If

        autoTranslate(Me)

    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.SetOperation("+")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRgeom_geompointFunction.SetRCommand("geom_point")
        clsRaesFunction.SetRCommand("aes")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction)
        ucrBase.clsRsyntax.SetOperatorParameter(True, clsRFunc:=clsRggplotFunction)
        ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRgeom_geompointFunction)
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        'ucrBase.iHelpTopicID 

        ucrYearReceiver.SetIncludedDataTypes({"factor"})
        ucrDayOfYearReceiver.SetIncludedDataTypes({"numeric"})
        UcrReceiverSingle2.SetIncludedDataTypes({"factor"})

        ucrYearReceiver.Selector = UcrInventoryPlotSelector
        UcrReceiverSingle2.Selector = UcrInventoryPlotSelector
        ucrDayOfYearReceiver.Selector = UcrInventoryPlotSelector
        ucrSaveInventoryPlot.strPrefix = "InventoryPlot"
        ucrSaveInventoryPlot.SetDataFrameSelector(UcrInventoryPlotSelector.ucrAvailableDataFrames)
    End Sub

    Private Sub TestOkEnabled()
        If (Not ucrYearReceiver.IsEmpty AndAlso Not ucrDayOfYearReceiver.IsEmpty AndAlso Not UcrReceiverSingle2.IsEmpty) OrElse (ucrSaveInventoryPlot.chkSaveGraph.Checked AndAlso Not ucrSaveInventoryPlot.ucrInputGraphName.IsEmpty) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub
    Private Sub SetDefaults()
        ucrYearReceiver.SetMeAsReceiver()
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
        clsRggplotFunction.AddParameter("data", clsRFunctionParameter:=UcrInventoryPlotSelector.ucrAvailableDataFrames.clsCurrDataFrame)
    End Sub

    Private Sub ucrSaveInventoryPlot_ContentsChanged() Handles ucrSaveInventoryPlot.ContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrDayOfYearReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrDayOfYearReceiver.SelectionChanged
        If Not ucrDayOfYearReceiver.IsEmpty Then
            clsRaesFunction.AddParameter("y", ucrDayOfYearReceiver.GetVariableNames(False))
        Else
            clsRaesFunction.RemoveParameterByName("y")
        End If

        TestOkEnabled()

    End Sub

    Private Sub UcrReceiverSingle2_SelectionChanged(sender As Object, e As EventArgs) Handles UcrReceiverSingle2.SelectionChanged
        If Not UcrReceiverSingle2.IsEmpty Then
            clsRaesFunction.AddParameter("colour", UcrReceiverSingle2.GetVariableNames(False))
        Else
            clsRaesFunction.RemoveParameterByName("colour")
        End If
        TestOkEnabled()
    End Sub

    Private Sub ucrYearReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrYearReceiver.SelectionChanged
        If Not ucrYearReceiver.IsEmpty Then
            clsRaesFunction.AddParameter("x", ucrYearReceiver.GetVariableNames(False))
        Else
            clsRaesFunction.RemoveParameterByName("x")
        End If
        TestOkEnabled()
    End Sub
End Class