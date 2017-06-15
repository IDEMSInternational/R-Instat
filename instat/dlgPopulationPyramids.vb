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
Public Class dlgPopulationPyramids
    Private clsRggplotFunction As New RFunction
    Private clsRgeom_bar As New RFunction
    Private clsRgeom_bar2 As New RFunction
    Private clsRaesFunction As New RFunction
    Private clsRgeom_CoordFlip As New RFunction
    Private bFirstLoad As Boolean = True
    Private Sub dlgPopulationPyramids_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()

        End If
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 455
        ucrBase.clsRsyntax.SetOperation("+")

        clsRggplotFunction.SetPackageName("ggplot")
        clsRggplotFunction.SetRCommand("ggplot")

        clsRaesFunction.SetPackageName("ggplot")
        clsRaesFunction.SetRCommand("aes")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction)
        ucrBase.clsRsyntax.SetOperatorParameter(True, clsRFunc:=clsRggplotFunction)

        clsRgeom_bar.SetPackageName("ggplot")
        clsRgeom_bar.SetRCommand("geom_bar")
        clsRgeom_bar.AddParameter("stat", Chr(34) & "identity" & Chr(34))
        ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRgeom_bar)

        clsRgeom_bar2.SetPackageName("ggplot")
        clsRgeom_bar2.SetRCommand("geom_bar")
        clsRgeom_bar2.AddParameter("stat", Chr(34) & "identity" & Chr(34))
        ucrBase.clsRsyntax.AddOperatorParameter("geom_bar", clsRFunc:=clsRgeom_bar)

        clsRgeom_CoordFlip.SetPackageName("ggplot")
        clsRgeom_CoordFlip.SetRCommand("coord_flip")
        ucrBase.clsRsyntax.AddOperatorParameter("coord_flip", "coord_flip")

        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrXVariableReceiver.Selector = ucrPopulationPyramidselector
        ucrYVariableReceiver.Selector = ucrPopulationPyramidselector
        ucrSecondFactorReceiver.Selector = ucrPopulationPyramidselector
        ucrBase.clsRsyntax.iCallType = 3

    End Sub

    Private Sub SetDefaults()
        ucrPopulationPyramidselector.Reset()
        ucrXVariableReceiver.SetMeAsReceiver()
        TestOkEnabled()
    End Sub

    Private Sub ReopenDialog()

    End Sub
    Private Sub TestOkEnabled()
        If (ucrXVariableReceiver.IsEmpty AndAlso ucrYVariableReceiver.IsEmpty) Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub ucrPopulationPyramidselector_DataFrameChanged() Handles ucrPopulationPyramidselector.DataFrameChanged
        clsRggplotFunction.AddParameter("data", clsRFunctionParameter:=ucrPopulationPyramidselector.ucrAvailableDataFrames.clsCurrDataFrame)
    End Sub
    Private Sub ucrXVariableReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrXVariableReceiver.SelectionChanged
        If Not ucrXVariableReceiver.IsEmpty Then
            clsRaesFunction.AddParameter("x", ucrXVariableReceiver.GetVariableNames(False))
        Else
            clsRaesFunction.RemoveParameterByName("x")
        End If
        TestOkEnabled()
    End Sub

    Private Sub ucrYVariableReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrYVariableReceiver.SelectionChanged
        If Not ucrYVariableReceiver.IsEmpty Then
            clsRaesFunction.AddParameter("y", ucrYVariableReceiver.GetVariableNames(False))
        Else
            clsRaesFunction.RemoveParameterByName("y")
        End If
        TestOkEnabled()
    End Sub

    Private Sub ucrSecondFactorReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrSecondFactorReceiver.SelectionChanged
        If Not ucrSecondFactorReceiver.IsEmpty Then
            clsRaesFunction.AddParameter("fill", ucrSecondFactorReceiver.GetVariableNames(False))
        Else
            clsRaesFunction.RemoveParameterByName("fill")
        End If
    End Sub

    Private Sub ucrSavePopulationPyramid_ContentsChanged() Handles ucrSavePopulationPyramid.ContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrSavePopulationPyramid_GraphNameChanged() Handles ucrSavePopulationPyramid.GraphNameChanged, ucrSavePopulationPyramid.SaveGraphCheckedChanged
        If ucrSavePopulationPyramid.bSaveGraph Then
            ucrBase.clsRsyntax.SetAssignTo(ucrSavePopulationPyramid.strGraphName, strTempDataframe:=ucrPopulationPyramidselector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:=ucrSavePopulationPyramid.strGraphName)
        Else
            ucrBase.clsRsyntax.SetAssignTo("last_graph", strTempDataframe:=ucrPopulationPyramidselector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        End If
        TestOkEnabled()
    End Sub
End Class