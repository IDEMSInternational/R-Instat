
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

Public Class ucrReceiverMetadataProperty
    Public clsLayerParam As LayerParameter
    Public ctrActive As Control
    Public Event ControlContentsChanged()

    Public Sub SetControls()
        'This sub creates adapts the ucrReceiverMetadataProperty to the type of layer parameter, it's default value, the available values etc, stored within clsLayerParam.
        nudParamValue.Visible = False
        ucrCboParamValue.Visible = False
        ucrColor.Visible = False
        ucrInputTextValue.Visible = False
        If clsLayerParam IsNot Nothing Then
            If clsLayerParam.strLayerParameterDataType = "numeric" Then
                If clsLayerParam.lstParameterStrings.Count >= 1 Then
                    nudParamValue.DecimalPlaces = clsLayerParam.lstParameterStrings(0)
                Else
                    nudParamValue.DecimalPlaces = 0
                End If
                nudParamValue.Increment = Math.Pow(10, -nudParamValue.DecimalPlaces)
                If clsLayerParam.lstParameterStrings.Count >= 2 Then
                    nudParamValue.Minimum = clsLayerParam.lstParameterStrings(1)
                Else
                    nudParamValue.Minimum = Decimal.MinValue
                End If
                If clsLayerParam.lstParameterStrings.Count >= 3 Then
                    nudParamValue.Maximum = clsLayerParam.lstParameterStrings(2)
                Else
                    nudParamValue.Maximum = Decimal.MaxValue
                End If
                ctrActive = nudParamValue
            ElseIf clsLayerParam.strLayerParameterDataType = "boolean" Then
                ctrActive = ucrCboParamValue
                ucrCboParamValue.SetItems({"TRUE", "FALSE"})
            ElseIf clsLayerParam.strLayerParameterDataType = "colour" Then
                ctrActive = ucrColor
            ElseIf clsLayerParam.strLayerParameterDataType = "list" Then
                ctrActive = ucrCboParamValue
                If clsLayerParam.lstParameterStrings IsNot Nothing AndAlso clsLayerParam.lstParameterStrings.Count > 0 Then
                    ucrCboParamValue.SetItems(clsLayerParam.lstParameterStrings)
                Else
                    ucrCboParamValue.cboInput.Items.Clear()
                End If
            ElseIf clsLayerParam.strLayerParameterDataType = "text" Then
                ctrActive = ucrInputTextValue
            Else
                ctrActive = New Control 'this should never actually be used but is here to ensure the code is stable even if a developper uses an incorrect datatype
            End If
            ctrActive.Visible = True
        End If
    End Sub

    Private Sub nudParamValue_TextChanged(sender As Object, e As EventArgs) Handles nudParamValue.TextChanged
        RaiseEvent ControlContentsChanged()
    End Sub

    Private Sub ucrCboParamValue_NameChanged() Handles ucrCboParamValue.NameChanged
        RaiseEvent ControlContentsChanged()
    End Sub

    Private Sub ucrColor_NameChanged() Handles ucrColor.NameChanged
        RaiseEvent ControlContentsChanged()
    End Sub

    Private Sub ucrInputTextValue_NameChanged() Handles ucrInputTextValue.NameChanged
        RaiseEvent ControlContentsChanged()
    End Sub

    Public Sub SetValue(strValue As String)
        If TypeOf (ctrActive) Is NumericUpDown Then
            If strValue <> "" Then
                nudParamValue.Value = strValue
            End If
        Else
            ctrActive.Text = strValue
        End If
    End Sub
End Class