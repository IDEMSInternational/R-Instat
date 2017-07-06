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

Imports instat

Public Class ucrLayerParamsControls
    Private bControlsInitialised As Boolean = False

    Private Sub InitialiseControls()
        ucrReceiverMetadataProperty.SetAddRemoveParameter(False)
        ucrChkParamName.bChangeParameterValue = False
        ucrChkParamName.AddToLinkedControls(ucrLinked:=ucrReceiverMetadataProperty, objValues:={True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True) ', objNewDefaultState:=1)
    End Sub

    Public Sub SetControl(clsNewRCode As RCodeStructure, Optional clsNewLayerParam As LayerParameter = Nothing, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        ucrReceiverMetadataProperty.SetControls(clsNewRCode:=clsNewRCode, clsNewLayerParam:=clsNewLayerParam, bReset:=bReset)
        ucrChkParamName.SetRCode(clsNewRCode, bReset)
        If clsNewLayerParam IsNot Nothing Then
            ucrChkParamName.SetText(clsNewLayerParam.strLayerParameterName)
            ucrChkParamName.AddParameterPresentCondition(True, clsNewLayerParam.strLayerParameterName)
            ucrChkParamName.AddParameterPresentCondition(False, clsNewLayerParam.strLayerParameterName, False)
            ucrChkParamName.Visible = True
        Else
            ucrChkParamName.Visible = False
        End If
    End Sub

    Private Sub ucrReceiverMetadataProperty_ControlContentsChanged() Handles ucrReceiverMetadataProperty.ControlContentsChanged, ucrChkParamName.ControlContentsChanged
        OnControlContentsChanged()
    End Sub

    Private Sub ucrReceiverMetadataProperty_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMetadataProperty.ControlValueChanged, ucrChkParamName.ControlValueChanged
        OnControlValueChanged()
    End Sub
End Class