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
    Private dctDefaultValues As New Dictionary(Of String, String)

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        InitialiseControls()
    End Sub
    Private Sub sdgClimaticDataEntryOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseControls()
        ucrChkEditNAOnly.SetText("Add/Edit new data only")
        ucrChkIncludeFirstNextMonth.SetText("Include first of the next month")

        ucrInputTransform.SetItems({"0.1", "25.4", "0.254"})
        ucrInputTransform.SetValidationTypeAsNumeric()
        ucrInputTransform.Visible = False
        ucrChkTransform.SetText("Transform")
        ucrChkTransform.AddToLinkedControls(ucrInputTransform, {True}, bNewLinkedHideIfParameterMissing:=True)

        dctDefaultValues.Add("NA", "NA")
        dctDefaultValues.Add("Blank", "")
        dctDefaultValues.Add("0", "0")
        ucrInputDefaultValue.SetItems(dctDefaultValues, bSetConditions:=False)
        ucrInputDefaultValue.SetDropDownStyleAsNonEditable()
        ttDefaultValue.SetToolTip(ucrInputDefaultValue.cboInput, "Default value for missing values.")

        ucrChkNoDecimal.SetText("No Decimal")

        ucrChkExtraRows.SetText("Extra Rows")

        ucrChkAllowTrace.SetText("Allow t for Trace")
    End Sub

    Public Sub SetUpDataEntryOptions(strEntryType As String)
        ucrChkIncludeFirstNextMonth.Enabled = (strEntryType = "Month")
    End Sub

    Public Property GetSetNoDecimals As Boolean
        Get
            Return ucrChkNoDecimal.Checked
        End Get
        Set(value As Boolean)
            ucrChkNoDecimal.Checked = value
        End Set
    End Property

    Public Property GetSetDefaultValue As String
        Get
            If dctDefaultValues.ContainsKey(ucrInputDefaultValue.GetText) Then
                Return dctDefaultValues.Item(ucrInputDefaultValue.GetText)
            Else
                Return ucrInputDefaultValue.GetText
            End If
        End Get
        Set(value As String)
            ucrInputDefaultValue.SetName(value)
        End Set
    End Property

    Public Property GetSetAllowTrace As Boolean
        Get
            Return ucrChkAllowTrace.Checked
        End Get
        Set(value As Boolean)
            ucrChkAllowTrace.Checked = value
        End Set
    End Property

    Public Property GetSetTransform As Boolean
        Get
            Return ucrChkTransform.Checked
        End Get
        Set(value As Boolean)
            ucrChkTransform.Checked = value
        End Set
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
            ucrInputTransform.SetName(value)
        End Set
    End Property

    Public Property GetSetEditNAOnly As Boolean
        Get
            Return ucrChkEditNAOnly.Checked
        End Get
        Set(value As Boolean)
            ucrChkEditNAOnly.Checked = value
        End Set
    End Property

    Public Property GetSetIncludeFirstNextOfMonth As Boolean
        Get
            Return ucrChkIncludeFirstNextMonth.Enabled AndAlso ucrChkIncludeFirstNextMonth.Checked
        End Get
        Set(value As Boolean)
            ucrChkIncludeFirstNextMonth.Enabled = value
            ucrChkIncludeFirstNextMonth.Checked = value
        End Set
    End Property

End Class