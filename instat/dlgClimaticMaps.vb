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
Public Class dlgClimaticMaps
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsBaseOperator As New ROperator
    Dim lstReceivers As New List(Of ucrReceiverSingle)
    Dim dctRecognisedTypes As New Dictionary(Of String, List(Of String))
    Private clsRggplotFunction, clsRaesFunction, clsRgeompointFunction, clsRgeompolygonFunction, clsRgeompathFunction, clsRgeomtextFunction As RFunction
    Private clsRlabsFunction, clsRscalefilldiscreteFunction, clsRscaleshapeFunction As RFunction
    Private Sub dlgClimaticMaps_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        TestOkEnabled()
    End Sub
    Private Sub InitialiseDialog()
        dctRecognisedTypes.Add("long", {"long"}.ToList())
        dctRecognisedTypes.Add("lat", {"lat"}.ToList())
        dctRecognisedTypes.Add("group", {"group"}.ToList())
        dctRecognisedTypes.Add("fill", {"fill"}.ToList())
        dctRecognisedTypes.Add("x", {"x"}.ToList())
        dctRecognisedTypes.Add("y", {"y"}.ToList())
        dctRecognisedTypes.Add("shape", {"shape"}.ToList())
        dctRecognisedTypes.Add("colour", {"colour"}.ToList())

        lstReceivers.AddRange({UcrReceiverSingle1, UcrReceiverSingle2, UcrReceiverSingle3, UcrReceiverSingle4, UcrReceiverSingle5, UcrReceiverSingle6,
                              UcrReceiverSingle7, UcrReceiverSingle8})
    End Sub
    Private Sub SetDefaults()
        clsRggplotFunction = New RFunction
        clsRgeompolygonFunction = New RFunction
        clsRgeompointFunction = New RFunction
        clsRgeompathFunction = New RFunction
        clsRgeomtextFunction = New RFunction
        clsRlabsFunction = New RFunction
        clsRscalefilldiscreteFunction = New RFunction
        clsRscaleshapeFunction = New RFunction
        clsBaseOperator = New ROperator

        ucrSelectorClimaticMaps.Reset()


        clsBaseOperator.SetOperation("+")


        clsRggplotFunction.SetPackageName("ggplot2")
        clsRggplotFunction.SetRCommand("ggplot")


        clsRgeompolygonFunction.SetPackageName("ggplot2")
        clsRgeompolygonFunction.SetRCommand("geom_polygon")
        clsRgeompolygonFunction.AddParameter("data", clsRFunctionParameter:=, iPosition:=0)
        clsRgeompolygonFunction.AddParameter("aes", clsRFunctionParameter:=clsRaesFunction, iPosition:=1)
        clsRgeompolygonFunction.AddParameter("size", strParameterValue:=3, iPosition:=2)
        clsRgeompolygonFunction.AddParameter("alpha", strParameterValue:=0.5, iPosition:=3)

        clsRgeompointFunction.SetPackageName("ggplot2")
        clsRgeompointFunction.SetRCommand("geom_point")
        clsRgeompointFunction.AddParameter("data", clsRFunctionParameter:=, iPosition:=0)
        clsRgeompointFunction.AddParameter("aes", clsRFunctionParameter:=clsRaesFunction, iPosition:=1)
        clsRgeompointFunction.AddParameter("shape", strParameterValue:="colour", iPosition:=2)
        clsRgeompointFunction.AddParameter("size", strParameterValue:=3, iPosition:=3)
        clsRgeompointFunction.AddParameter("alpha", strParameterValue:=0.5, iPosition:=4)

        clsRaesFunction.SetPackageName("ggplot2")
        clsRaesFunction.SetRCommand("aes")
        clsRaesFunction.AddParameter("x", strParameterValue:="long", iPosition:=0)
        clsRaesFunction.AddParameter("y", strParameterValue:="lat", iPosition:=0)
        clsRaesFunction.AddParameter("group", strParameterValue:="group", iPosition:=0)




    End Sub
    Private Sub SetRCodeForControls(bReset As Boolean)

    End Sub
    Private Sub TestOkEnabled()
        If ucrVariablesAsFactorforHist.IsEmpty OrElse Not ucrSaveHist.IsComplete Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub
End Class