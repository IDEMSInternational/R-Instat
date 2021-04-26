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
Imports instat.Translations
Public Class sdgClimaticDataEntryOptions
    Private bFirstLoad As Boolean = True
    Private bMissing As Boolean = True
    Private Sub sdgClimaticDataEntryOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseControls()
            SetDefaults()
            bFirstLoad = False
        End If
        autoTranslate(Me)
    End Sub
    Private Sub InitialiseControls()
        ucrChkTransform.SetText("Transform:")
        ttucrChkTransform.SetToolTip(ucrChkTransform, "The values written to the data frame are transformed, usually multiplied, by the value given here.")

        ucrInputTransform.SetItems({"0.1", "25.4", "0.254"})
        ucrInputTransform.SetValidationTypeAsNumeric(dcmMin:=0.1)
        ucrInputTransform.Visible = False

        ucrChkDefaultValue.SetText("Default Value:")
        ucrInputDefaultValue.SetText("0")
        ucrInputDefaultValue.Visible = False

        ucrChkMissingValues.SetText("Missing values shown as NA")

        ucrChkNoDecimal.SetText("No Decimal")

        ucrChkExtraRows.SetText("Extra Rows")

        ucrChkAllowTrace.SetText("Allow t for Trace")
        ttucrChkDefaultValue.SetToolTip(ucrChkDefaultValue, "The data must be defined as climatic to recognise which variable is precipitation.")
    End Sub

    Private Sub SetDefaults()
        ucrChkDefaultValue.Checked = False
        ucrChkAllowTrace.Checked = False
        ucrChkTransform.Checked = False
        ucrChkMissingValues.Checked = True
        ucrInputTransform.GetSetSelectedIndex = 0
    End Sub

    Private Sub ucrChkDefaultValue_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkDefaultValue.ControlValueChanged
        'todo. can this "toggling" be done in another way?
        ucrInputDefaultValue.Visible = ucrChkDefaultValue.Checked
    End Sub

    Private Sub ucrChkTransform_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkTransform.ControlValueChanged
        'todo. can this "toggling" be done in another way?
        ucrInputTransform.Visible = ucrChkTransform.Checked
    End Sub

    Public ReadOnly Property NoDecimals As Boolean
        Get
            Return ucrChkNoDecimal.Checked
        End Get
    End Property

    Public ReadOnly Property UseDefault As Boolean
        Get
            Return ucrChkDefaultValue.Checked
        End Get
    End Property
    Public ReadOnly Property MissingValueAsNA As Boolean
        Get
            Return bMissing
        End Get
    End Property


    'todo. why is this a string?
    Public ReadOnly Property DefaultValue As Double
        Get
            Return If(String.IsNullOrEmpty(ucrInputDefaultValue.GetValue), 0, ucrInputDefaultValue.GetValue)
        End Get
    End Property

    Public ReadOnly Property AllowTrace As Boolean
        Get
            Return ucrChkAllowTrace.Checked
        End Get
    End Property

    Public ReadOnly Property Transform As Boolean
        Get
            Return ucrChkTransform.Checked
        End Get
    End Property

    Public ReadOnly Property TransformValue As Double
        Get
            'todo. do explicit conversion. Currently ucrInputTransform validation type is number
            Return If(String.IsNullOrEmpty(ucrInputTransform.GetValue), 0, ucrInputTransform.GetValue)
        End Get
    End Property

    Private Sub ucrChkMissingValues_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkMissingValues.ControlValueChanged
        bMissing = ucrChkMissingValues.Checked
    End Sub
End Class