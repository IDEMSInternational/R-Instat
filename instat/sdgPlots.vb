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
    Public clsRsyntax As New RSyntax
    Public clsRFacetFunction As New RFunction
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
        chkIncludeFacets.Checked = False
        IncludeFacets()
        ucr1stFactorReceiver.SetMeAsReceiver()
    End Sub

    Private Sub InitialiseDialog()
        IncludeFacets()
        ucr1stFactorReceiver.Selector = ucrAddRemove
        ucr1stFactorReceiver.SetIncludedDataTypes({"factor"})
        ucr2ndFactorReceiver.Selector = ucrAddRemove
        ucr2ndFactorReceiver.SetIncludedDataTypes({"factor"})
    End Sub

    Private Sub IncludeFacets()
        If chkIncludeFacets.Checked Then
            ucrAddRemove.Visible = True
            ucr1stFactorReceiver.Visible = True
            ucr2ndFactorReceiver.Visible = True
            lblFactor1.Visible = True
            lblFactor2.Visible = True
            rdoHorizontal.Visible = True
            rdoHorizontal.Checked = True
            rdoVertical.Visible = True
            chkNoOfRowsOrColumns.Visible = True
            chkNoOfRowsOrColumns.Checked = True
            nudNoOfRowsOrColumns.Visible = True
            chkMargin.Visible = True
            chkFreeScalesX.Visible = True
            chkFreeScalesY.Visible = True
            SetFacets()
            IncludeFacetsOperator()
        Else
            ucrAddRemove.Visible = False
            ucr1stFactorReceiver.Visible = False
            ucr2ndFactorReceiver.Visible = False
            lblFactor1.Visible = False
            lblFactor2.Visible = False
            rdoHorizontal.Visible = False
            rdoVertical.Visible = False
            chkMargin.Visible = False
            chkFreeScalesX.Visible = False
            chkFreeScalesY.Visible = False
            chkNoOfRowsOrColumns.Visible = False
            nudNoOfRowsOrColumns.Visible = False
        End If
    End Sub

    Private Sub SetFacets()
        Dim clsTempOp As New ROperator
        clsTempOp.SetOperation("~")
        clsRFacetFunction.RemoveParameterByName("nrow")
        clsRFacetFunction.RemoveParameterByName("ncol")

        If Not ucr1stFactorReceiver.IsEmpty() AndAlso ucr2ndFactorReceiver.IsEmpty() Then
            If rdoHorizontal.Checked AndAlso (chkMargin.Checked OrElse Not chkNoOfRowsOrColumns.Checked) Then
                clsRFacetFunction.SetRCommand("facet_grid")
                clsTempOp.SetParameter(True, strValue:=".")
                clsTempOp.SetParameter(False, strValue:=ucr1stFactorReceiver.GetVariableNames(False))
                clsRFacetFunction.AddParameter("facets", clsROperatorParameter:=clsTempOp)

            ElseIf rdoVertical.Checked AndAlso (chkMargin.Checked OrElse Not chkNoOfRowsOrColumns.Checked) Then
                clsRFacetFunction.SetRCommand("facet_grid")
                clsTempOp.SetParameter(False, strValue:=".")
                clsTempOp.SetParameter(True, strValue:=ucr1stFactorReceiver.GetVariableNames(False))
                clsRFacetFunction.AddParameter("facets", clsROperatorParameter:=clsTempOp)

            Else
                clsRFacetFunction.SetRCommand("facet_wrap")
                clsTempOp.SetParameter(True, strValue:="")
                clsTempOp.SetParameter(False, strValue:=ucr1stFactorReceiver.GetVariableNames(False))
                clsRFacetFunction.AddParameter("facets", clsROperatorParameter:=clsTempOp)
                If rdoHorizontal.Checked AndAlso chkNoOfRowsOrColumns.Checked AndAlso nudNoOfRowsOrColumns.Value > 0 Then
                    clsRFacetFunction.AddParameter("nrow", nudNoOfRowsOrColumns.Value)
                ElseIf rdoVertical.Checked AndAlso chkNoOfRowsOrColumns.Checked AndAlso nudNoOfRowsOrColumns.Value > 0 Then
                    clsRFacetFunction.AddParameter("ncol", nudNoOfRowsOrColumns.Value)
                End If
            End If

        ElseIf Not ucr1stFactorReceiver.IsEmpty() AndAlso Not ucr2ndFactorReceiver.IsEmpty() Then
            clsRFacetFunction.SetRCommand("facet_grid")
            If rdoHorizontal.Checked Then
                clsTempOp.SetParameter(False, strValue:=ucr1stFactorReceiver.GetVariableNames(False))
                clsTempOp.SetParameter(True, strValue:=ucr2ndFactorReceiver.GetVariableNames(False))
                clsRFacetFunction.AddParameter("facets", clsROperatorParameter:=clsTempOp)
            ElseIf rdoVertical.Checked Then
                clsTempOp.SetParameter(True, strValue:=ucr1stFactorReceiver.GetVariableNames(False))
                clsTempOp.SetParameter(False, strValue:=ucr2ndFactorReceiver.GetVariableNames(False))
                clsRFacetFunction.AddParameter("facets", clsROperatorParameter:=clsTempOp)
            End If
        Else
            clsRFacetFunction.RemoveParameterByName("facets")
        End If

    End Sub

    Private Sub IncludeFacetsOperator()
        If chkIncludeFacets.Checked AndAlso Not ucr1stFactorReceiver.IsEmpty() Then
            clsRsyntax.AddOperatorParameter("facet", clsRFunc:=clsRFacetFunction)
        Else
            clsRsyntax.RemoveOperatorParameter("facet")
        End If
    End Sub

    Private Sub chkIncludeFacets_CheckedChanged(sender As Object, e As EventArgs) Handles chkIncludeFacets.CheckedChanged
        IncludeFacets()
    End Sub

    Private Sub ucr1stFactorReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucr1stFactorReceiver.SelectionChanged
        SetFacets()
        IncludeFacetsOperator()
    End Sub

    Private Sub ucr2ndFactorReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucr2ndFactorReceiver.SelectionChanged
        VisibileNumberOfRowsOrColumns()
        SetFacets()
        IncludeFacetsOperator()
    End Sub

    Private Sub rdoHorVer_CheckedChanged(sender As Object, e As EventArgs) Handles rdoHorizontal.CheckedChanged, rdoVertical.CheckedChanged
        If rdoHorizontal.Checked Then
            chkNoOfRowsOrColumns.Text = "Fixed Number of Rows"
        ElseIf rdoVertical.Checked Then
            chkNoOfRowsOrColumns.Text = "Fixed Number of Columns"
        End If
        SetFacets()
        IncludeFacetsOperator()
    End Sub

    Private Sub VisibileNumberOfRowsOrColumns()
        If chkMargin.Checked OrElse Not ucr2ndFactorReceiver.IsEmpty Then
            chkNoOfRowsOrColumns.Visible = False
            nudNoOfRowsOrColumns.Visible = False
        Else
            chkNoOfRowsOrColumns.Visible = True
            nudNoOfRowsOrColumns.Visible = chkNoOfRowsOrColumns.Checked
        End If
    End Sub

    Private Sub chkNoOfRowsOrColumns_CheckedChanged(sender As Object, e As EventArgs) Handles chkNoOfRowsOrColumns.CheckedChanged
        nudNoOfRowsOrColumns.Visible = chkNoOfRowsOrColumns.Checked
        SetFacets()
        IncludeFacetsOperator()
    End Sub

    Private Sub nudNoOfRowsOrColumns_TextChanged(sender As Object, e As EventArgs) Handles nudNoOfRowsOrColumns.TextChanged
        SetFacets()
        IncludeFacetsOperator()
    End Sub


    Private Sub chkMargin_CheckedChanged(sender As Object, e As EventArgs) Handles chkMargin.CheckedChanged
        If chkMargin.Checked Then
            clsRFacetFunction.AddParameter("margins", "TRUE")
        Else
            clsRFacetFunction.RemoveParameterByName("margins")

        End If
        VisibileNumberOfRowsOrColumns()
        SetFacets()
        IncludeFacetsOperator()
    End Sub

    Private Sub SetScaleOption()
        If chkFreeScalesX.Checked AndAlso chkFreeScalesY.Checked Then
            clsRFacetFunction.AddParameter("scales", "free")
        ElseIf chkFreeScalesX.Checked AndAlso Not chkFreeScalesY.Checked Then
            clsRFacetFunction.AddParameter("scales", "free_x")
        ElseIf Not chkFreeScalesX.Checked AndAlso chkFreeScalesY.Checked Then
            clsRFacetFunction.AddParameter("scales", "free_y")
        Else
            clsRFacetFunction.RemoveParameterByName("scales")
        End If
    End Sub

    Private Sub chkScales_CheckedChanged(sender As Object, e As EventArgs) Handles chkFreeScalesX.CheckedChanged, chkFreeScalesY.CheckedChanged
        SetScaleOption()
        IncludeFacetsOperator()
        SetFacets()
    End Sub

    Public Sub SetRSyntax(clsRSyntaxIn As RSyntax)
        clsRsyntax = clsRSyntaxIn
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


End Class
