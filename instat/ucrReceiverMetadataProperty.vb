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

Imports instat

Public Class ucrReceiverMetadataProperty
    Public clsLayerParam As LayerParameter
    Public ctrActive As ucrCore

    Public Sub SetControls(clsNewRCode As RCodeStructure, Optional clsNewLayerParam As LayerParameter = Nothing, Optional bReset As Boolean = False)
        Dim clsTempParam As RParameter

        clsLayerParam = clsNewLayerParam
        'This sub adapts the ucrReceiverMetadataProperty to the type of layer parameter, it's default value, the available values etc, stored within clsLayerParam.
        ClearCodeAndParameters()
        If clsLayerParam IsNot Nothing Then
            If clsLayerParam.strLayerParameterDataType = "numeric" Then
                If clsLayerParam.lstParameterStrings.Count >= 1 Then
                    ucrNudParamValue.DecimalPlaces = clsLayerParam.lstParameterStrings(0)
                Else
                    ucrNudParamValue.DecimalPlaces = 0
                End If
                ucrNudParamValue.Increment = Math.Pow(10, -ucrNudParamValue.DecimalPlaces)
                If clsLayerParam.lstParameterStrings.Count >= 2 Then
                    ucrNudParamValue.Minimum = clsLayerParam.lstParameterStrings(1)
                Else
                    ucrNudParamValue.Minimum = Decimal.MinValue
                End If
                If clsLayerParam.lstParameterStrings.Count >= 3 Then
                    ucrNudParamValue.Maximum = clsLayerParam.lstParameterStrings(2)
                Else
                    ucrNudParamValue.Maximum = Decimal.MaxValue
                End If
                ctrActive = ucrNudParamValue
            ElseIf clsLayerParam.strLayerParameterDataType = "boolean" Then
                ctrActive = ucrInputCboParamValue
            ElseIf clsLayerParam.strLayerParameterDataType = "colour" Then
                ctrActive = ucrColor
            ElseIf clsLayerParam.strLayerParameterDataType = "list" Then
                ctrActive = ucrInputCboParamValue
            ElseIf clsLayerParam.strLayerParameterDataType = "text" Then
                ctrActive = ucrInputTextValue
            Else
                ctrActive = New ucrCore 'this should never actually be used but is here to ensure the code is stable even if a developer uses an incorrect datatype
            End If
            ctrActive.Visible = True
            'Needed to remove conditions from previous use of control
            ctrActive.ClearConditions()
            ctrActive.bUpdateRCodeFromControl = True
            ctrActive.bAddRemoveParameter = False
            clsTempParam = New RParameter(clsLayerParam.strLayerParameterName)
            If clsLayerParam.strParameterDefaultValue IsNot Nothing Then
                clsTempParam.SetArgumentValue(clsLayerParam.strParameterDefaultValue)
            End If
            ctrActive.SetParameter(clsTempParam)
            'Must be done after parameter set because it affects the conditions

            If ctrActive.Equals(ucrInputCboParamValue) Then
                If clsLayerParam.strLayerParameterDataType = "boolean" Then
                    ucrInputCboParamValue.SetItems({"TRUE", "FALSE"}, bAddConditions:=True)
                ElseIf clsLayerParam.strLayerParameterDataType = "list" Then
                    If clsLayerParam.lstParameterStrings IsNot Nothing AndAlso clsLayerParam.lstParameterStrings.Count > 0 Then
                        ucrInputCboParamValue.SetItems(clsLayerParam.lstParameterStrings, bAddConditions:=True)
                    Else
                        ucrInputCboParamValue.SetItems()
                    End If
                End If
            End If
            ctrActive.SetRCode(clsNewRCode, bReset)
        End If
    End Sub

    Private Sub AllControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrColor.ControlContentsChanged, ucrInputCboParamValue.ControlContentsChanged, ucrInputTextValue.ControlContentsChanged, ucrNudParamValue.ControlContentsChanged
        OnControlContentsChanged()
    End Sub

    Private Sub AllControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrColor.ControlValueChanged, ucrInputCboParamValue.ControlValueChanged, ucrInputTextValue.ControlValueChanged, ucrNudParamValue.ControlValueChanged
        OnControlValueChanged()
    End Sub

    Public Overrides Sub ClearCodeAndParameters()
        ucrNudParamValue.ClearCodeAndParameters()
        ucrInputCboParamValue.ClearCodeAndParameters()
        ucrInputTextValue.ClearCodeAndParameters()
        ucrColor.ClearCodeAndParameters()
        ucrNudParamValue.Visible = False
        ucrInputCboParamValue.Visible = False
        ucrColor.Visible = False
        ucrInputTextValue.Visible = False
    End Sub

    Public Overrides Sub SetAddRemoveParameter(bNew As Boolean)
        MyBase.SetAddRemoveParameter(bNew)
        ucrNudParamValue.SetAddRemoveParameter(bNew)
        ucrInputCboParamValue.SetAddRemoveParameter(bNew)
        ucrInputTextValue.SetAddRemoveParameter(bNew)
        ucrColor.SetAddRemoveParameter(bNew)
    End Sub

    Public Overrides Sub AddOrRemoveParameter(bAdd As Boolean)
        If ctrActive IsNot Nothing Then
            ctrActive.AddOrRemoveParameter(bAdd)
        End If
    End Sub

    Public Overrides Function CanAddParameter() As Boolean
        If ctrActive IsNot Nothing Then
            Return ctrActive.CanAddParameter()
        Else
            Return False
        End If
    End Function
End Class