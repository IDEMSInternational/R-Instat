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
Public Class sdgDescribeTwoVarGraph
    Public bFirstLoad As Boolean = True
    Private Sub sdgDescribeTwoVarGraph_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)

        If bFirstLoad Then
            'SetDefaults()
            bFirstLoad = False
        End If
    End Sub

    Public Sub SetDefaults()
        ucrNumericByNumeric.Enabled = False
        ucrNumericByCategorical.Enabled = False
        ucrCategoricalByNumeric.Enabled = False
        ucrCategoricalByCategorical.Enabled = False
        GraphOptions()
    End Sub

    Private Sub GraphOptions()
        ucrNumericByNumeric.SetItems({"Scatter plot", "Line plot", "Scatter and line plot"})
        ucrNumericByNumeric.cboInput.SelectedItem = "Scatter plot"
        ucrNumericByCategorical.SetItems({"Box plot", "Histogram", "Density plot", "Frequency polygon"})
        'ucrNumericByCategorical.cboInput.Items.Add("Dot plot")
        'ucrNumericByCategorical.cboInput.Items.Add("Point plot")
        ucrNumericByCategorical.cboInput.SelectedItem = "Box plot"
        ucrCategoricalByNumeric.SetItems({"Summary plot"})
        ucrCategoricalByNumeric.cboInput.SelectedItem = "Summary plot"
        ucrCategoricalByCategorical.SetItems({"Bar plot", "Dot plot"})
        ucrCategoricalByCategorical.cboInput.SelectedItem = "Bar plot"
    End Sub

    Public Sub GrpBoxEnable()
        If ((dlgDescribeTwoVarGraph.strVarType = "numeric" OrElse dlgDescribeTwoVarGraph.strVarType = "integer") And (dlgDescribeTwoVarGraph.strSecondVarType = "numeric" OrElse dlgDescribeTwoVarGraph.strSecondVarType = "integer")) Then
            ucrNumericByNumeric.Enabled = True
            ucrNumericByCategorical.Enabled = False
            ucrCategoricalByNumeric.Enabled = False
            ucrCategoricalByCategorical.Enabled = False
        ElseIf ((dlgDescribeTwoVarGraph.strVarType = "numeric" OrElse dlgDescribeTwoVarGraph.strVarType = "integer") And (dlgDescribeTwoVarGraph.strSecondVarType = "factor")) Then
            ucrNumericByNumeric.Enabled = False
            ucrNumericByCategorical.Enabled = True
            ucrCategoricalByNumeric.Enabled = False
            ucrCategoricalByCategorical.Enabled = False
        ElseIf ((dlgDescribeTwoVarGraph.strVarType = "factor") And (dlgDescribeTwoVarGraph.strSecondVarType = "numeric" OrElse dlgDescribeTwoVarGraph.strSecondVarType = "integer")) Then
            ucrNumericByNumeric.Enabled = False
            ucrNumericByCategorical.Enabled = False
            ucrCategoricalByNumeric.Enabled = True
            ucrCategoricalByCategorical.Enabled = False
        ElseIf ((dlgDescribeTwoVarGraph.strVarType = "factor") And (dlgDescribeTwoVarGraph.strSecondVarType = "factor")) Then
            ucrNumericByNumeric.Enabled = False
            ucrNumericByCategorical.Enabled = False
            ucrCategoricalByNumeric.Enabled = False
            lblCategoricalByCategorical.Enabled = True
            ucrCategoricalByCategorical.Enabled = True
        End If
    End Sub

    Private Sub ucrGraphs_NameChanged() Handles ucrNumericByNumeric.NameChanged, ucrNumericByCategorical.NameChanged, ucrCategoricalByNumeric.NameChanged, ucrCategoricalByCategorical.NameChanged
        dlgDescribeTwoVarGraph.Results()
    End Sub
End Class