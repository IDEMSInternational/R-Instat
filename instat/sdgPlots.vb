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
Public Class sdgPlots
    Public clsRsyntax As RSyntax
    Public clsRfacetFunction As New RFunction
    Public clsXLabFunction As New RFunction
    Public clsYLabFunction As New RFunction
    Public bFirstLoad As Boolean = True
    Private Sub sdgPlots_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False

        End If
        autoTranslate(Me)
    End Sub

    Private Sub SetDefaults()
        ucr1stFactorReceiver.SetMeAsReceiver()
        chkWrapOptions.Checked = False
        chkFreeScalesX.Checked = False
        chkFreeScalesY.Checked = False
        rdoHorizontal.Checked = True
        chkDisplayYTitle.Checked = False
        chkDisplayYTitle.Checked = False
        chkMargin.Checked = False
        chkIncludeFacets.Checked = False
        FacetsCheck(False)

    End Sub
    Private Sub InitialiseDialog()
        ucr1stFactorReceiver.Selector = ucrAddRemove
        ucr1stFactorReceiver.SetIncludedDataTypes({"factor"})
        ucr2ndFactorReceiver.Selector = ucrAddRemove
        ucr2ndFactorReceiver.SetIncludedDataTypes({"factor"})
        chkIncludeFacets.Checked = True
    End Sub
    Private Sub chkWrapOptions_CheckedChanged(sender As Object, e As EventArgs) Handles chkWrapOptions.CheckedChanged
        If chkWrapOptions.Checked = True Then
            lblNoOfColumns.Visible = True
            txtNoOfColumns.Visible = True
            txtNoOfRows.Visible = True
            lblNoofRows.Visible = True
        Else
            lblNoOfColumns.Visible = False
            txtNoOfColumns.Visible = False
            txtNoOfRows.Visible = False
            lblNoofRows.Visible = False
        End If
    End Sub

    Public Sub SetFacetParameter()
        Dim clsTempOp As New ROperator
        Dim strFactor1 As String
        Dim strFactor2 As String

        clsTempOp.SetOperation("~")
        strFactor1 = ucr1stFactorReceiver.GetVariableNames(False)
        strFactor2 = ucr2ndFactorReceiver.GetVariableNames(False)

        If strFactor1 = "" Then
            clsRfacetFunction.RemoveParameterByName("facets")
        Else
            If chkMargin.Checked And strFactor2 = "" Then
                strFactor2 = "."
            End If

            If rdoHorizontal.Checked Then
                clsTempOp.SetParameter(False, strFactor1)
                clsTempOp.SetParameter(True, strFactor2)
            Else
                clsTempOp.SetParameter(True, strFactor1)
                clsTempOp.SetParameter(False, strFactor2)
            End If
            clsRfacetFunction.AddParameter("facets", clsROperatorParameter:=clsTempOp)
        End If
    End Sub

    Public Sub SetFacetFunction()
        If ucr2ndFactorReceiver.IsEmpty() = True Then
            If chkMargin.Checked Then
                clsRfacetFunction.SetRCommand("facet_grid")
            Else
                clsRfacetFunction.SetRCommand("facet_wrap")
            End If
        Else
            clsRfacetFunction.SetRCommand("facet_grid")
        End If

    End Sub

    Private Sub ucr1stFactorReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucr1stFactorReceiver.SelectionChanged
        SetFacetFunction()
        SetFacetParameter()
    End Sub

    Private Sub ucr2ndFactorReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucr2ndFactorReceiver.SelectionChanged
        SetFacetFunction()
        SetFacetParameter()
    End Sub

    Private Sub rdoHorizontal_CheckedChanged(sender As Object, e As EventArgs) Handles rdoHorizontal.CheckedChanged
        SetFacetParameter()
    End Sub

    Private Sub rdoVertical_CheckedChanged(sender As Object, e As EventArgs) Handles rdoVertical.CheckedChanged
        SetFacetParameter()
    End Sub

    Private Sub chkMargin_CheckedChanged(sender As Object, e As EventArgs) Handles chkMargin.CheckedChanged
        SetFacetFunction()
        SetFacetParameter()
        If chkMargin.Checked Then
            clsRfacetFunction.AddParameter("margins", "TRUE")
        Else
            clsRfacetFunction.RemoveParameterByName("margins")
        End If
    End Sub

    Private Sub SetScaleOption()
        If chkFreeScalesX.Checked Then
            If chkFreeScalesY.Checked Then
                clsRfacetFunction.AddParameter("scales", "free")
            Else
                clsRfacetFunction.AddParameter("scales", "free_x")
            End If
        Else
            If chkFreeScalesY.Checked Then
                clsRfacetFunction.AddParameter("scales", "free_y")
            Else
                clsRfacetFunction.AddParameter("scales", "fixed")
            End If
        End If
    End Sub

    Public Sub SetRSyntax(clsRSyntaxIn As RSyntax)
        clsRsyntax = clsRSyntaxIn
    End Sub

    Private Sub chkIncludeFacets_CheckedChanged(sender As Object, e As EventArgs) Handles chkIncludeFacets.CheckedChanged
        FacetsCheck(chkIncludeFacets.Checked)
    End Sub

    Private Sub FacetsCheck(bChecked As Boolean)
        If bChecked Then
            IncludeFacets()
            clsRsyntax.AddOperatorParameter("facet", clsRFunc:=clsRfacetFunction)
        Else
            clsRsyntax.RemoveOperatorParameter("facet")
            RemoveFacets()
        End If
    End Sub

    Private Sub IncludeFacets()
        rdoHorizontal.Visible = True
        rdoVertical.Visible = True
        chkWrapOptions.Visible = True
        chkMargin.Visible = True
        chkFreeScalesX.Visible = True
        chkFreeScalesY.Visible = True
    End Sub

    Private Sub RemoveFacets()
        rdoHorizontal.Visible = False
        rdoVertical.Visible = False
        chkWrapOptions.Visible = False
        chkMargin.Visible = False
        chkFreeScalesX.Visible = False
        chkFreeScalesY.Visible = False
        lblNoofRows.Visible = False
        lblNoOfColumns.Visible = False
        txtNoOfRows.Visible = False
        txtNoOfColumns.Visible = False
        txtXTitle.Visible = False
        txtYTitle.Visible = False
        chkWrapOptions.Checked = False
    End Sub

    Private Sub chkChangeTitle_CheckedChanged(sender As Object, e As EventArgs) Handles chkChangeTitle.CheckedChanged
        If chkChangeTitle.Checked Then
            txtChangeTitle.Visible = True
        Else
            txtChangeTitle.Visible = False
        End If
    End Sub

    Private Sub chkDisplayLegend_CheckedChanged(sender As Object, e As EventArgs) Handles chkDisplayLegend.CheckedChanged
        If chkDisplayLegend.Checked Then
            grpLabels.Visible = True
            grpTitle.Visible = True
        Else
            grpLabels.Visible = False
            grpTitle.Visible = False
        End If
    End Sub

    Private Sub txtXTitle_Leave(sender As Object, e As EventArgs) Handles txtXTitle.Leave
        clsXLabFunction.AddParameter("label", Chr(34) & txtXTitle.Text & Chr(34))
    End Sub

    Private Sub chkXDisplayTitle_CheckedChanged(sender As Object, e As EventArgs) Handles chkXDisplayTitle.CheckedChanged
        If chkXDisplayTitle.Checked Then
            txtXTitle.Visible = True
            clsXLabFunction.SetRCommand("xlab")
            clsRsyntax.AddOperatorParameter("xlab", clsRFunc:=clsXLabFunction)
        Else
            clsRsyntax.RemoveOperatorParameter("xlab")
            txtXTitle.Visible = False
        End If

    End Sub

    Private Sub chkDisplayYTitle_CheckedChanged(sender As Object, e As EventArgs) Handles chkDisplayYTitle.CheckedChanged
        If chkDisplayYTitle.Checked Then
            txtYTitle.Visible = True
            clsYLabFunction.SetRCommand("ylab")
            clsRsyntax.AddOperatorParameter("ylab", clsRFunc:=clsYLabFunction)
        Else
            clsRsyntax.RemoveOperatorParameter("ylab")
            txtYTitle.Visible = False
        End If
    End Sub

    Private Sub txtYTitle_Leave(sender As Object, e As EventArgs) Handles txtYTitle.Leave
        clsYLabFunction.AddParameter("label", Chr(34) & txtYTitle.Text & Chr(34))
    End Sub

    Private Sub chkFreeScalesY_CheckedChanged(sender As Object, e As EventArgs) Handles chkFreeScalesY.CheckedChanged

    End Sub
End Class
