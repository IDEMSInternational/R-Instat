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

Public Class ucrRadio
    Public strValueIfChecked As String = "TRUE"

    'This control is no longer needed and can be deleted.
    'Public Overrides Sub UpdateControl(Optional bReset As Boolean = False)
    '    MyBase.UpdateControl(bReset)
    '    If clsParameter IsNot Nothing Then
    '        If bChangeParameterValue Then
    '            rdoRadio.Checked = (clsParameter.strArgumentValue = strValueIfChecked)
    '        ElseIf bAddRemoveParameter Then
    '            'Commented out as not currently needed. Can be included if needed.
    '            'If bParameterIncludedWhenChecked Then
    '            rdoRadio.Checked = clsRCode.ContainsParameter(clsParameter)
    '            'Else
    '            'chkCheck.Checked = Not clsRCodeObject.clsParameters.Contains(clsParameter)
    '            'End If
    '        End If
    '    Else
    '        If lstValuesAndControl.Count > 0 Then
    '            rdoRadio.Checked = LinkedControlsParametersPresent()
    '        End If
    '    End If
    '    UpdateLinkedControls()
    'End Sub

    'Private Sub rdoRadio_CheckedChanged(sender As Object, e As EventArgs) Handles rdoRadio.CheckedChanged
    '    If bChangeParameterValue AndAlso clsParameter IsNot Nothing Then
    '        If rdoRadio.Checked Then
    '            clsParameter.strArgumentValue = strValueIfChecked
    '        End If
    '    End If
    '    UpdateRCode()
    '    OnControlValueChanged()
    'End Sub

    'Public Property Checked As Boolean
    '    Get
    '        Return rdoRadio.Checked
    '    End Get
    '    Set(bChecked As Boolean)
    '        rdoRadio.Checked = bChecked
    '    End Set
    'End Property
End Class
