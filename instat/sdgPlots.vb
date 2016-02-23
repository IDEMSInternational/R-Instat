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
    Public clsRfacetFunction As RFunction
    Private Sub sdgPlots_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chkFreeScalesX.Checked = False
        chkFreeScalesY.Checked = False
        rdoHorizontal.Checked = True
        chkMargin.Checked = False
        chkWrapOptions.Checked = False
        lblNoOfColumns.Visible = False
        txtNoOfColumns.Visible = False
        txtNoOfRows.Visible = False
        ucrReceiveFactor1.Selector = ucrAddRemove
        ucrReceiveFactor1.SetDataType("factor")
        ucrReceiveFactor1.SetMeAsReceiver()
        ucrReceiveFactor2.Selector = ucrAddRemove
        ucrReceiveFactor2.SetDataType("factor")
        autoTranslate(Me)
    End Sub

    Private Sub chkWrapOptions_CheckedChanged(sender As Object, e As EventArgs) Handles chkWrapOptions.CheckedChanged
        If chkWrapOptions.Checked = True Then
            lblNoOfColumns.Visible = True
            txtNoOfColumns.Visible = True
            txtNoOfRows.Visible = True
        Else
            lblNoOfColumns.Visible = False
            txtNoOfColumns.Visible = False
            txtNoOfRows.Visible = False
        End If
    End Sub

    Public Sub SetFacetParameter()

        Dim clsTempOp As New ROperator
        Dim strFactor1 As String
        Dim strFactor2 As String

        clsTempOp.SetOperation("~")
        strFactor1 = ucrReceiveFactor1.GetVariableNames(False)
        strFactor2 = ucrReceiveFactor2.GetVariableNames(False)
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

    End Sub

    Public Sub SetFacetFunction()

        If ucrReceiveFactor2.GetVariableNames = "" Then
            If chkMargin.Checked Then
                clsRfacetFunction.SetRCommand("facet_grid")
            Else
                clsRfacetFunction.SetRCommand("facet_wrap")
            End If
        Else
            clsRfacetFunction.SetRCommand("facet_grid")
        End If

    End Sub

    Private Sub ucrReceiveFactor1_Leave(sender As Object, e As EventArgs) Handles ucrReceiveFactor1.Leave
        SetFacetFunction()
        SetFacetParameter()
    End Sub

    Private Sub ucrReceiveFactor2_Leave(sender As Object, e As EventArgs) Handles ucrReceiveFactor2.Leave
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

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked Then
            clsRsyntax.AddOperatorParameter("facet", clsRFunc:=clsRfacetFunction)
        Else
            clsRsyntax.RemoveOperatorParameter("facet")
        End If

    End Sub
End Class