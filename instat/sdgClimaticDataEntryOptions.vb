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
Public Class sdgClimaticDataEntryOptions
    Private bControlsInitialised As Boolean = False
    Private bMissing As Boolean = True

    Private Sub sdgClimaticDataEntryOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseControls()
        ucrChkTransform.SetText("Transform:")
        ttucrChkTransform.SetToolTip(ucrChkTransform.chkCheck, "The values written to the data frame are transformed, usually multiplied, by the value given here.")

        ucrInputTransform.SetItems({"0.1", "25.4", "0.254"})
        ucrInputTransform.SetValidationTypeAsNumeric()
        ucrInputTransform.Visible = False

        ucrChkDefaultValue.SetText("Default Value:")

        ucrInputDefaultValue.SetValidationTypeAsNumeric()
        ucrInputDefaultValue.Visible = False

        ucrChkMissingValues.SetText("Missing values shown as NA")

        ucrChkNoDecimal.SetText("No Decimal")

        ucrChkExtraRows.SetText("Extra Rows")

        ucrChkDefaultValue.AddToLinkedControls(ucrInputDefaultValue, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkTransform.AddToLinkedControls(ucrInputTransform, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkAllowTrace.SetText("Allow t for Trace")
        ttucrChkDefaultValue.SetToolTip(ucrChkDefaultValue.chkCheck, "The data must be defined as climatic to recognise which variable is precipitation.")
        bControlsInitialised = True
    End Sub

    Public Sub SetUpDataEntryOptions(Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If

        ucrChkMissingValues.Checked = True

        If bReset Then
            ucrChkDefaultValue.Checked = False
            ucrChkAllowTrace.Checked = False
            ucrChkTransform.Checked = False
            ucrChkNoDecimal.Checked = False
        End If
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

    Public Property GetSetDefaultValue As Double
        Get
            Dim dTemp As Double
            If Not Double.TryParse(ucrInputDefaultValue.GetValue, dTemp) Then
                MsgBox("Developer error: The ucrInputDefaultValue input contains the value '" & ucrInputDefaultValue.GetValue & "'. Cannot convert this to a double.")
            End If
            Return dTemp
        End Get
        Set(value As Double)
            ucrInputDefaultValue.SetText(value)
        End Set
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

    Public Property GetSetTransformValue As Double
        Get
            Dim dTemp As Double
            If Not Double.TryParse(ucrInputTransform.GetValue, dTemp) Then
                MsgBox("Developer error: The ucrInputTransform combo box contains the value '" & ucrInputTransform.GetValue & "'. Cannot convert this to a double.")
            End If
            Return dTemp
        End Get
        Set(value As Double)
            ucrInputTransform.SetText(value)
        End Set
    End Property

    Private Sub ucrChkMissingValues_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkMissingValues.ControlValueChanged
        bMissing = ucrChkMissingValues.Checked
    End Sub
End Class