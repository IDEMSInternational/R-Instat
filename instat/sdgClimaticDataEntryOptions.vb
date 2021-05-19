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
    Private dctDefaultValues As New Dictionary(Of String, String)

    Private Sub sdgClimaticDataEntryOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not bControlsInitialised Then
            InitialiseControls()
            SetDefaults()
        End If
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseControls()
        ucrChkEditNAOnly.SetText("Edit/Add new data(NA) only")
        ucrChkIncludeFirstNextMonth.SetText("Include first of the next month:")

        ucrInputTransform.SetItems({"0.1", "25.4", "0.254"})
        ucrInputTransform.SetValidationTypeAsNumeric()
        ucrInputTransform.Visible = False
        ucrChkTransform.SetText("Transform:")
        ucrChkTransform.AddToLinkedControls(ucrInputTransform, {True}, bNewLinkedHideIfParameterMissing:=True)

        dctDefaultValues.Add("NA", "NA")
        dctDefaultValues.Add("Blank", "")
        dctDefaultValues.Add("0", "0")
        ucrInputDefaultValue.SetItems(dctDefaultValues, bSetCondtions:=False)
        ucrInputDefaultValue.SetDropDownStyleAsNonEditable()
        ttDefaultValue.SetToolTip(ucrInputDefaultValue, "Default value for missing values.")

        ucrChkNoDecimal.SetText("No Decimal")

        ucrChkExtraRows.SetText("Extra Rows")

        ucrChkAllowTrace.SetText("Allow t for Trace")
        bControlsInitialised = True
    End Sub

    Public Sub SetDefaults()
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        ucrInputDefaultValue.GetSetSelectedIndex = 0
        ucrInputTransform.GetSetSelectedIndex = 0
        ucrChkAllowTrace.Checked = False
        ucrChkTransform.Checked = False
        ucrChkNoDecimal.Checked = False
        ucrChkEditNAOnly.Checked = False
        ucrChkIncludeFirstNextMonth.Checked = False
        ucrChkIncludeFirstNextMonth.Enabled = False
    End Sub

    Public Sub Setup(strEntryType As String)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        ucrChkIncludeFirstNextMonth.Enabled = (strEntryType = "Month")
    End Sub

    Public ReadOnly Property NoDecimals As Boolean
        Get
            Return ucrChkNoDecimal.Checked
        End Get
    End Property

    Public ReadOnly Property DefaultValue As String
        Get
            Return dctDefaultValues.Item(ucrInputDefaultValue.GetValue)
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
            Dim dTemp As Double
            If Not Double.TryParse(ucrInputTransform.GetValue, dTemp) Then
                MsgBox("Developer error: The ucrInputTransform combo box contains the value '" & ucrInputTransform.GetValue & "'. Cannot convert this to a double.")
            End If
            Return dTemp
        End Get
    End Property

    Public ReadOnly Property EditNAOnly As Boolean
        Get
            Return ucrChkEditNAOnly.Checked
        End Get
    End Property

    Public ReadOnly Property IncludeFirstNextOfMonth As Boolean
        Get
            Return ucrChkIncludeFirstNextMonth.Enabled AndAlso ucrChkIncludeFirstNextMonth.Checked
        End Get
    End Property

End Class