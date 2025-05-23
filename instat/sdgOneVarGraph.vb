﻿' R- Instat
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
Public Class sdgOneVarGraph
    Public bControlsInitialised As Boolean = False
    Public clsGraphOneVariable As New RFunction

    Private Sub sdgOneVarGraph_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetHelpOptions()
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        Dim dctNumericPairs As New Dictionary(Of String, String)
        Dim dctCategoricalPairs As New Dictionary(Of String, String)

        ucrButtonsOneVarGraph.iHelpTopicID = 737

        ucrInputNumeric.SetParameter(New RParameter("numeric", 2))
        dctNumericPairs.Add("Boxplot", Chr(34) & "geom_boxplot" & Chr(34))
        dctNumericPairs.Add("Histogram", Chr(34) & "geom_histogram" & Chr(34))
        dctNumericPairs.Add("Dotplot", Chr(34) & "geom_dotplot" & Chr(34))
        dctNumericPairs.Add("Point Plot", Chr(34) & "geom_point" & Chr(34))
        dctNumericPairs.Add("Density Plot", Chr(34) & "geom_density" & Chr(34))
        dctNumericPairs.Add("Frequency Polygon", Chr(34) & "geom_freqpoly" & Chr(34))
        dctNumericPairs.Add("Violin Plot", Chr(34) & "geom_violin" & Chr(34))
        dctNumericPairs.Add("Jitter Plot", Chr(34) & "geom_jitter" & Chr(34))
        dctNumericPairs.Add("Boxplot + Jitter", Chr(34) & "box_jitter" & Chr(34))
        dctNumericPairs.Add("Violin + Jitter", Chr(34) & "violin_jitter" & Chr(34))
        dctNumericPairs.Add("Violin + Boxplot", Chr(34) & "violin_box" & Chr(34))
        ucrInputNumeric.SetItems(dctNumericPairs)
        ucrInputNumeric.SetDropDownStyleAsNonEditable()

        ucrInputCategorical.SetParameter(New RParameter("categorical", 3))
        dctCategoricalPairs.Add("Bar Chart", Chr(34) & "geom_bar" & Chr(34))
        dctCategoricalPairs.Add("Pie Chart", Chr(34) & "pie_chart" & Chr(34))
        dctCategoricalPairs.Add("Dot Plot", Chr(34) & "geom_dotplot" & Chr(34))
        ucrInputCategorical.SetItems(dctCategoricalPairs)
        ucrInputCategorical.SetDropDownStyleAsNonEditable()

        ucrChkFreeScaleAxisforFacets.SetParameter(New RParameter("free_scale_axis", 5))
        ucrChkFreeScaleAxisforFacets.SetText("Free Scale Axis for Facets")
        ucrChkFreeScaleAxisforFacets.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkFreeScaleAxisforFacets.SetRDefault("FALSE")

        ucrNudNumberofColumns.SetParameter(New RParameter("ncol", 6))
        ucrNudNumberofColumns.SetMinMax(1, 10)
        ucrNudNumberofColumns.bAddRemoveParameter = False
        ucrNudNumberofColumns.SetLinkedDisplayControl(lblNumberofColumns)

        ucrChkSpecifyLayout.SetText("Specify Layout")
        ucrChkSpecifyLayout.AddToLinkedControls(ucrLinked:=ucrNudNumberofColumns, objValues:={True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=1)
        ucrChkSpecifyLayout.AddParameterPresentCondition(True, "ncol")
        ucrChkSpecifyLayout.AddParameterPresentCondition(False, "ncol", False)

        bControlsInitialised = True
    End Sub

    Public Sub SetRFunction(clsNewRFunction As RFunction, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsGraphOneVariable = clsNewRFunction
        SetRCode(Me, clsGraphOneVariable, bReset)
        If bReset Then
            tbcOneVarGraph.SelectedIndex = 0
        End If
    End Sub

    Private Sub SetHelpOptions()
        Select Case dlgOneVariableGraph.enumOnevariableMode
            Case dlgOneVariableGraph.OnevariableMode.Prepare
                ucrButtonsOneVarGraph.iHelpTopicID = 187
            Case dlgOneVariableGraph.OnevariableMode.Describe
                ucrButtonsOneVarGraph.iHelpTopicID = 170
            Case dlgOneVariableGraph.OnevariableMode.Climatic
                ucrButtonsOneVarGraph.iHelpTopicID = 623
        End Select
    End Sub
End Class