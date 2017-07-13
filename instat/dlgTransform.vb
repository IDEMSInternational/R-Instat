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
Public Class dlgTransform
    Public bFirstLoad As Boolean = True
    Private Sub dlgTransform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        autoTranslate(Me)
    End Sub
    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 358
    End Sub
    Private Sub SetDefaults()
        'CommonTransformation()
        rdoCommonTransformations.Checked = True
        grpOtherTransformations.Visible = False
        rdoNonNegative.Checked = True
        rdoSquareRoot.Checked = True
        lblPowerValue.Visible = False
        txtPowerValue.Visible = False
        lblZeroAdjustment.Visible = False
        lblAdjustment.Visible = False
        lbl01Adjustment.Visible = False
        txtAdjustment.Visible = False
        grpPercentageTransformations.Visible = False
        grpCircularTransformations.Visible = False
    End Sub
    Private Sub CommonTransformation()
        rdoCommonTransformations.Checked = True
        grpCalculatedTransformations.Visible = True
        grpOtherTransformations.Visible = False
        rdoNonNegative.Checked = True
        rdoSquareRoot.Checked = True
        lblPowerValue.Visible = False
        txtPowerValue.Visible = False
        lblZeroAdjustment.Visible = False
        lblAdjustment.Visible = False
        lbl01Adjustment.Visible = False
        txtAdjustment.Visible = False
        grpPercentageTransformations.Visible = False
        grpCircularTransformations.Visible = False
    End Sub
    Private Sub OtherTransformation()

    End Sub
    Private Sub ReopenDialog()

    End Sub
    Private Sub rdoCommonTransformations_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCommonTransformations.CheckedChanged
        'If rdoCommonTransformations.Checked = True Then
        '    grpCalculatedTransformations.Visible = True
        'Else
        '    grpCalculatedTransformations.Visible = False
        'End If
    End Sub

    Private Sub rdoOtherTransformations_CheckedChanged(sender As Object, e As EventArgs) Handles rdoOtherTransformations.CheckedChanged
        If rdoOtherTransformations.Checked = True Then
            grpOtherTransformations.Visible = True
            rdoRank.Checked = True
            grpLag.Visible = False
        Else
            grpOtherTransformations.Visible = False
        End If
    End Sub

    Private Sub rdoSquareRoot_CheckedChanged(sender As Object, e As EventArgs) Handles rdoSquareRoot.CheckedChanged
        If rdoSquareRoot.Checked = True Then
            lblConstant.Visible = True
        Else
            lblConstant.Visible = False
        End If
    End Sub

    Private Sub rdoNaturalLog_CheckedChanged(sender As Object, e As EventArgs) Handles rdoNaturalLog.CheckedChanged
        If rdoNaturalLog.Checked = True Then
            lblZeroAdjustment.Visible = True
        Else
            lblZeroAdjustment.Visible = False
        End If
    End Sub

    Private Sub rdoLogBase10_CheckedChanged(sender As Object, e As EventArgs) Handles rdoLogBase10.CheckedChanged
        If rdoLogBase10.Checked = True Then
            lblZeroAdjustment.Visible = True
        Else
            lblZeroAdjustment.Visible = False
        End If
    End Sub

    Private Sub rdoPower_CheckedChanged(sender As Object, e As EventArgs) Handles rdoPower.CheckedChanged
        If rdoPower.Checked = True Then
            lblConstant.Visible = True
            lblPowerValue.Visible = True
            txtPowerValue.Visible = True
        Else
            lblConstant.Visible = False
            lblPowerValue.Visible = False
            txtPowerValue.Visible = False
        End If
    End Sub

    Private Sub rdoLag_CheckedChanged(sender As Object, e As EventArgs) Handles rdoLag.CheckedChanged
        If rdoLag.Checked = True Then
            grpLag.Visible = True
        Else
            grpLag.Visible = False
        End If
    End Sub

    Private Sub rdoDifference_CheckedChanged(sender As Object, e As EventArgs) Handles rdoDifference.CheckedChanged
        If rdoDifference.Checked = True Then
            grpLag.Visible = True
        Else
            grpLag.Visible = False
        End If
    End Sub

    Private Sub rdoNonNegative_CheckedChanged(sender As Object, e As EventArgs) Handles rdoNonNegative.CheckedChanged
        If rdoNonNegative.Checked = True Then
            grpNonNegativeTransformations.Visible = True
        Else
            grpNonNegativeTransformations.Visible = False
        End If
    End Sub

    Private Sub rdoCircular_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCircular.CheckedChanged
        If rdoCircular.Checked = True Then
            grpCircularTransformations.Visible = True
        Else
            grpCircularTransformations.Visible = False
        End If
    End Sub

    Private Sub rdoPercentage_CheckedChanged(sender As Object, e As EventArgs) Handles rdoPercentage.CheckedChanged
        If rdoPercentage.Checked = True Then
            grpPercentageTransformations.Visible = True
        Else
            grpPercentageTransformations.Visible = False
        End If
    End Sub

    Private Sub rdoProportion_CheckedChanged(sender As Object, e As EventArgs) Handles rdoProportion.CheckedChanged
        If rdoProportion.Checked = True Then
            grpPercentageTransformations.Visible = True
        Else
            grpPercentageTransformations.Visible = False
        End If
    End Sub

    Private Sub rdoLogit_CheckedChanged(sender As Object, e As EventArgs) Handles rdoLogit.CheckedChanged
        If rdoLogit.Checked = True And rdoPercentage.Checked = True Then
            lblAdjustment.Visible = True
            txtAdjustment.Visible = True
        ElseIf rdoLogit.Checked = True And rdoProportion.Checked = True Then
            lbl01Adjustment.Visible = True
            txtAdjustment.Visible = True
        Else
            lblAdjustment.Visible = False
            txtAdjustment.Visible = False
            lbl01Adjustment.Visible = False
        End If
    End Sub

    Private Sub rdoProbit_CheckedChanged(sender As Object, e As EventArgs) Handles rdoProbit.CheckedChanged
        If rdoProbit.Checked = True And rdoPercentage.Checked = True Then
            lblAdjustment.Visible = True
            txtAdjustment.Visible = True
        ElseIf rdoProbit.Checked = True And rdoProportion.Checked = True Then
            lbl01Adjustment.Visible = True
            txtAdjustment.Visible = True
        Else
            lblAdjustment.Visible = False
            txtAdjustment.Visible = False
            lbl01Adjustment.Visible = False
        End If
    End Sub

End Class