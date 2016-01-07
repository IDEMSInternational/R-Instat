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

Public Class dlgRandomSample
    'Private Sub dlgRandomSample_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    ucrBase.clsRsyntax.SetFunction("rnorm")
    '    ucrBase.clsRsyntax.iCallType = 2
    '    autoTranslate(Me)
    '    UcrReceiverSingle.Selector = UcrAddRemove
    '    UcrReceiverSingle.SetMeAsReceiver()
    '    ucrBase.OKEnabled(False)

    '    cboDistributionType.SelectedItem = "Normal"
    '    cboSampleType.SelectedItem = "Probability Distribution"

    '    txtMean.Visible = True
    '    lblMean.Visible = True
    '    txtStDev.Visible = True
    '    lblStDev.Visible = True

    '    lblEXMean.Visible = False
    '    txtExMean.Visible = False

    '    txtProp.Visible = False
    '    lblProp.Visible = False

    '    lblMode.Visible = False
    '    txtMode.Visible = False
    '    lblSacle.Visible = False
    '    txtScale.Visible = False

    '    lblWMean.Visible = False
    '    txtWmean.Visible = False

    '    txtShape.Visible = False
    '    lblShape.Visible = False
    'End Sub

    'Private Sub cboDistributionType_TextChanged(sender As Object, e As EventArgs) Handles cboDistributionType.TextChanged
    '    If cboDistributionType.Text = "Geometric" Then
    '        txtProp.Visible = True
    '        lblProp.Visible = True

    '        txtMean.Visible = False
    '        lblMean.Visible = False
    '        txtStDev.Visible = False
    '        lblStDev.Visible = False

    '        lblEXMean.Visible = False
    '        txtExMean.Visible = False

    '        lblMode.Visible = False
    '        txtMode.Visible = False
    '        lblSacle.Visible = False
    '        txtScale.Visible = False

    '    ElseIf cboDistributionType.Text = "Exponential" Then
    '        txtProp.Visible = False
    '        lblProp.Visible = False

    '        txtMean.Visible = True
    '        lblMean.Visible = True
    '        txtStDev.Visible = False
    '        lblStDev.Visible = False

    '        lblEXMean.Visible = False
    '        txtExMean.Visible = False

    '        lblMode.Visible = False
    '        txtMode.Visible = False
    '        lblSacle.Visible = False
    '        txtScale.Visible = False
    '    ElseIf cboDistributionType.Text = "Normal" Then
    '        txtMean.Visible = True
    '        lblMean.Visible = True
    '        txtStDev.Visible = True
    '        lblStDev.Visible = True

    '        lblEXMean.Visible = False
    '        txtExMean.Visible = False

    '        txtProp.Visible = False
    '        lblProp.Visible = False

    '        lblMode.Visible = False
    '        txtMode.Visible = False
    '        lblSacle.Visible = False
    '        txtScale.Visible = False

    '    ElseIf cboDistributionType.Text = "Extreme Value" Then
    '        txtProp.Visible = False
    '        lblProp.Visible = False

    '        txtMean.Visible = False
    '        lblMean.Visible = False
    '        txtStDev.Visible = False
    '        lblStDev.Visible = False

    '        lblEXMean.Visible = False
    '        txtExMean.Visible = False

    '        lblMode.Visible = True
    '        txtMode.Visible = True
    '        lblSacle.Visible = True
    '        txtScale.Visible = True

    '    ElseIf cboDistributionType.Text = "Weibull" Then

    '        lblWMean.Visible = True
    '        txtWmean.Visible = True

    '        txtShape.Visible = True
    '        lblShape.Visible = True

    '        txtProp.Visible = False
    '        lblProp.Visible = False

    '        txtMean.Visible = False
    '        lblMean.Visible = False
    '        txtStDev.Visible = False
    '        lblStDev.Visible = False

    '        lblEXMean.Visible = False
    '        txtExMean.Visible = False

    '        lblMode.Visible = False
    '        txtMode.Visible = False
    '        lblSacle.Visible = False
    '        txtScale.Visible = False
    '    Else
    '        txtProp.Visible = False
    '        lblProp.Visible = False

    '        txtMean.Visible = False
    '        lblMean.Visible = False
    '        txtStDev.Visible = False
    '        lblStDev.Visible = False

    '        lblEXMean.Visible = False
    '        txtExMean.Visible = False

    '        lblMode.Visible = False
    '        txtMode.Visible = False
    '        lblSacle.Visible = False
    '        txtScale.Visible = False
    '    End If
    'End Sub
End Class