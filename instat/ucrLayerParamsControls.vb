
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

Public Class ucrLayerParamsControls
    Public clsLayerParam As LayerParameters
    Public ctrActive As Control
    Public clsGeomFunction As RFunction

    Public Event RParameterChanged(ucrControl As ucrLayerParamsControls)

    Private Sub InitialiseControl()

    End Sub

    Public Sub SetGeomFunction(clsTempFunction As RFunction)
        clsGeomFunction = clsTempFunction
        RaiseEvent RParameterChanged(Me)
    End Sub

    Public Sub SetLayerParameter(clsTempLayerParam As LayerParameters)

        clsLayerParam = clsTempLayerParam

        nudParamValue.Visible = False
        ucrcborParamValue.Visible = False
        ucrColor.Visible = False
        If Not IsNothing(clsLayerParam) Then
            chkParamName.Visible = True
            chkParamName.Text = clsLayerParam.strLayerParameterName
            If clsLayerParam.strLayerParameterDataType = "numeric" Then
                If clsLayerParam.lstParameterStrings.Count >= 1 Then
                    nudParamValue.DecimalPlaces = clsLayerParam.lstParameterStrings(0)
                Else
                    nudParamValue.DecimalPlaces = 0
                End If
                nudParamValue.Increment = Math.Pow(10, -nudParamValue.DecimalPlaces)
                If clsLayerParam.lstParameterStrings.Count >= 3 Then
                    nudParamValue.Minimum = clsLayerParam.lstParameterStrings(1)
                    nudParamValue.Maximum = clsLayerParam.lstParameterStrings(2)
                Else
                    nudParamValue.Minimum = Decimal.MinValue
                    nudParamValue.Maximum = Decimal.MaxValue
                End If
                ctrActive = nudParamValue
            ElseIf clsLayerParam.strLayerParameterDataType = "boolean" Then
                ctrActive = ucrcborParamValue
                ucrcborParamValue.SetItems({"TRUE", "FALSE"})
            ElseIf clsLayerParam.strLayerParameterDataType = "colour" Then
                ctrActive = ucrColor
            ElseIf clsLayerParam.strLayerParameterDataType = "list" Then
                ctrActive = ucrcborParamValue
                ucrcborParamValue.SetItems(clsLayerParam.lstParameterStrings)
            Else
                ctrActive = New Control 'this should never actually be used but is here to ensure the code is stable even if a developper uses an incorrect datatype
            End If
            If clsGeomFunction.GetParameter(clsLayerParam.strLayerParameterName) Is Nothing Then
                SetValue(clsLayerParam.strParameterDefaultValue)
            Else
                SetValue(clsGeomFunction.GetParameter(clsLayerParam.strLayerParameterName).strArgumentValue, True)
            End If
            ctrActive.Visible = chkParamName.Checked
        Else
            chkParamName.Visible = False
        End If
    End Sub

    Private Sub chkParamName_CheckedChanged(sender As Object, e As EventArgs) Handles chkParamName.CheckedChanged
        ctrActive.Visible = chkParamName.Checked
        RaiseEvent RParameterChanged(Me)
    End Sub

    Private Sub nudParamValue_ValueChanged(sender As Object, e As EventArgs) Handles nudParamValue.TextChanged
        RaiseEvent RParameterChanged(Me)
    End Sub

    Private Sub ucrcborParamValue_NameChanged() Handles ucrcborParamValue.NameChanged
        RaiseEvent RParameterChanged(Me)
    End Sub

    Private Sub ucrLayerParamsControls_RParameterChanged(ucrControl As ucrLayerParamsControls) Handles Me.RParameterChanged
        If Not IsNothing(clsLayerParam) AndAlso Not IsNothing(clsGeomFunction) Then
            If chkParamName.Checked AndAlso ctrActive.Text <> "" Then
                clsGeomFunction.AddParameter(clsLayerParam.strLayerParameterName, ctrActive.Text)
            Else
                clsGeomFunction.RemoveParameterByName(clsLayerParam.strLayerParameterName)
            End If
        End If
    End Sub

    Private Sub ucrColor_NameChanged() Handles ucrColor.NameChanged
        RaiseEvent RParameterChanged(Me)
    End Sub

    Public Sub SetValue(strValue As String, Optional bInclude As Boolean = False)
        If TypeOf (ctrActive) Is NumericUpDown Then
            nudParamValue.Value = strValue
        Else
            ctrActive.Text = strValue
        End If
        chkParamName.Checked = bInclude
    End Sub
End Class