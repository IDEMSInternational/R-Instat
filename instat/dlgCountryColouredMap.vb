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
Public Class dlgCountryColouredMap
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsMapdataFunction, clsRightjoinfunction, clsconcatenateFunction As New RFunction
    Private clsBaseOperator As New ROperator
    Private clsGgplot As New RFunction
    Private clsRGeomPolygon As New RFunction
    Private clsRaesFunc As New RFunction
    Private clsCoordMap As New RFunction

    Private Sub dlgCountryColouredMap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ucrReceiverCountry.Selector = ucrSelectorCountryColouredMap
        ucrReceiverColourBy.Selector = ucrSelectorCountryColouredMap

        ucrSelectorCountryColouredMap.SetParameter(New RParameter("", 1))
        ucrSelectorCountryColouredMap.SetParameterIsrfunction()

        ucrReceiverCountry.SetParameter(New RParameter("region", 2))
        ucrReceiverCountry.SetParameterIsString()

        ucrReceiverColourBy.SetParameter(New RParameter("group", 3))
        ucrReceiverCountry.SetParameterIsString()

        ucrSaveMap.SetPrefix("Map")
        ucrSaveMap.SetSaveTypeAsGraph()
        ucrSaveMap.SetIsComboBox()
        ucrSaveMap.SetCheckBoxText("Save Graph")
        ucrSaveMap.SetAssignToIfUncheckedValue("last_graph")
        ucrSaveMap.SetDataFrameSelector(ucrSelectorCountryColouredMap.ucrAvailableDataFrames)
    End Sub

    Private Sub SetDefaults()
        clsMapdataFunction = New RFunction
        clsRightjoinfunction = New RFunction
        clsconcatenateFunction = New RFunction

        clsBaseOperator = New ROperator
        clsGgplot = New RFunction
        clsRGeomPolygon = New RFunction
        clsCoordMap = New RFunction
        clsRaesFunc = New RFunction

        ucrSelectorCountryColouredMap.Reset()
        ucrReceiverCountry.SetMeAsReceiver()
        clsMapdataFunction.SetPackageName("ggplot2")
        clsMapdataFunction.SetRCommand("map_data")
        clsMapdataFunction.SetAssignTo("world")
        clsMapdataFunction.AddParameter("map", strParameterValue:=Chr(34) & "world" & Chr(34))

        clsRightjoinfunction.SetPackageName("dplyr")
        clsRightjoinfunction.SetRCommand("right_join")
        clsRightjoinfunction.SetAssignTo("merged_country")
        clsRightjoinfunction.AddParameter("x", clsRFunctionParameter:=clsMapdataFunction, bIncludeArgumentName:=False)
        clsRightjoinfunction.AddParameter("by", clsRFunctionParameter:=clsconcatenateFunction)
        clsconcatenateFunction.SetRCommand("c")


        clsBaseOperator.SetOperation("+")
        clsGgplot.SetPackageName("ggplot2")
        clsGgplot.SetRCommand("ggplot")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsGgplot, iPosition:=0)

        clsRGeomPolygon.SetPackageName("ggplot2")
        clsRGeomPolygon.SetRCommand("geom_polygon")
        clsRGeomPolygon.AddParameter("data", clsRFunctionParameter:=clsRightjoinfunction, iPosition:=0)

        clsRaesFunc.SetPackageName("ggplot2")
        clsRaesFunc.SetRCommand("aes")
        clsRGeomPolygon.AddParameter("aes", clsRFunctionParameter:=clsRaesFunc, iPosition:=1, bIncludeArgumentName:=False)
        clsRaesFunc.AddParameter("x", "long", iPosition:=0)
        clsRaesFunc.AddParameter("y", "lat", iPosition:=1)
        clsRaesFunc.AddParameter("fill", "count")
        clsBaseOperator.AddParameter("polygon", clsRFunctionParameter:=clsRGeomPolygon, iPosition:=1)

        clsCoordMap.SetPackageName("ggplot2")
        clsCoordMap.SetRCommand("coord_map")
        clsBaseOperator.AddParameter("coordmap", clsRFunctionParameter:=clsCoordMap, iPosition:=2)


        ucrBase.clsRsyntax.AddToBeforeCodes(clsMapdataFunction)
        ucrBase.clsRsyntax.AddToBeforeCodes(clsRightjoinfunction)
        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorCountryColouredMap.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrSelectorCountryColouredMap.SetRCode(clsMapdataFunction, bReset)
        ucrReceiverCountry.SetRCode(clsconcatenateFunction, bReset)
        ucrReceiverColourBy.SetRCode(clsRaesFunc, bReset)
        ucrSaveMap.SetRCode(clsBaseOperator, bReset)

    End Sub

    Private Sub TestOKEnabled()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub
End Class