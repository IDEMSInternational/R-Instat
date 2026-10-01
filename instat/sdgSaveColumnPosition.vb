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

' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.

' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat.Translations
Public Class sdgSaveColumnPosition
    Private clsColPosFunction As New RFunction
    Public bControlsNotInitialised As Boolean = True
    Public bUserSelected As Boolean = False
    Public bRcodeFlag As Boolean = False

    ' Reference to the buttons control on the parent dialog (so we can add/remove handler)
    Private clsParentSdgButtons As ucrButtonsSubdialogue = Nothing

    Private Sub sdgSaveColumnPosition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bControlsNotInitialised Then
            InitialiseControl()
            bControlsNotInitialised = False
        End If

        ' translate designer/localizable text initially
        Translations.autoTranslate(Me)

        ' find the ucrButtonsSubdialogue on the owner form (search recursively)
        ' Use Owner (set when ShowDialog(owner) is called); ParentForm may be Nothing for modal dialogs
        ' find the ucrButtonsSubdialogue on the owner form (search recursively)
        ' Use Owner (set when ShowDialog(owner) is called); ParentForm may be Nothing for modal dialogs
        Dim parent As Control = If(Me.Owner, Me.ParentForm)
        If parent IsNot Nothing Then
            clsParentSdgButtons = FindControlRecursive(Of ucrButtonsSubdialogue)(parent)
            If clsParentSdgButtons IsNot Nothing Then
                AddHandler clsParentSdgButtons.LanguageChanged, AddressOf ParentButtons_LanguageChanged
            End If
        End If
    End Sub

    Private Sub InitialiseControl()
        'For ucrSelector
        ucrSelectorColumns.btnDataOptions.Visible = False

        ucrBaseSubdialog.iHelpTopicID = 179

        'Panel and radio buttons
        ucrPnlColumnPosition.SetParameter(New RParameter("before"))

        ucrPnlColumnPosition.AddRadioButton(rdoStart, "TRUE")
        ucrPnlColumnPosition.AddRadioButton(rdoEnd, "FALSE")
        ucrPnlColumnPosition.AddRadioButton(rdoBefore, "TRUE")
        ucrPnlColumnPosition.AddRadioButton(rdoAfter, "FALSE")

        ucrPnlColumnPosition.AddParameterPresentCondition(rdoStart, "adjacent_column", False)
        ucrPnlColumnPosition.AddParameterPresentCondition(rdoEnd, "adjacent_column", False)
        ucrPnlColumnPosition.AddParameterPresentCondition(rdoBefore, "adjacent_column", True)
        ucrPnlColumnPosition.AddParameterPresentCondition(rdoAfter, "adjacent_column", True)

        'For ucrReceiver
        ucrReceiverColumn.SetParameter(New RParameter("adjacent_column"))
        ucrReceiverColumn.SetParameterIsString()
        ucrReceiverColumn.Selector = ucrSelectorColumns
        ucrReceiverColumn.SetMeAsReceiver()
        ucrReceiverColumn.bUseFilteredData = False
        ucrReceiverColumn.SetLinkedDisplayControl(lblColumns)

        'todo. change visibility to true once this feature is implemented
        ucrChkKeepExistingPos.Visible = False
        ' use GetTranslation when setting programmatic texts at init, but we will also refresh them in UpdateTranslations
        ucrChkKeepExistingPos.Text = GetTranslation("Keep existing position")
        ucrChkKeepExistingPos.SetParameter(New RParameter("keep_existing_position"))
        ucrChkKeepExistingPos.Checked = True
    End Sub

    Public Sub SetUp(strDataFrameName As String, bInsertColumnBefore As Boolean, strAdjacentColumn As String, bKeepExistingPosition As Boolean)
        If bControlsNotInitialised Then
            InitialiseControl()
            bControlsNotInitialised = False
        End If

        clsColPosFunction = New RFunction

        clsColPosFunction.AddParameter(strParameterName:="before", strParameterValue:=If(bInsertColumnBefore, "TRUE", "FALSE"))

        If Not String.IsNullOrEmpty(strAdjacentColumn) Then
            clsColPosFunction.AddParameter(strParameterName:="adjacent_column", strParameterValue:=strAdjacentColumn)
        End If

        clsColPosFunction.AddParameter(strParameterName:="keep_existing_position", strParameterValue:=If(bKeepExistingPosition, "TRUE", "FALSE"))

        bRcodeFlag = True
        ucrSelectorColumns.SetDataframe(strDataFrameName, False)
        ucrPnlColumnPosition.SetRCode(clsColPosFunction, True)
        ucrReceiverColumn.SetRCode(clsColPosFunction, True)
        ucrChkKeepExistingPos.SetRCode(clsColPosFunction, True)
        bRcodeFlag = False
        SetColumnControlsAndParameterState()
    End Sub

    Private Sub Controls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlColumnPosition.ControlValueChanged, ucrReceiverColumn.ControlValueChanged
        If Not bRcodeFlag Then
            'in future this should be moved to UserValueChanged event
            bUserSelected = True
            SetColumnControlsAndParameterState()
        End If
    End Sub

    Private Sub SetColumnControlsAndParameterState()
        If rdoStart.Checked Then
            clsColPosFunction.RemoveParameterByName("adjacent_column")
            ucrSelectorColumns.Visible = False
            ucrReceiverColumn.Visible = False
            lblColumns.Visible = False
            ' Use exact key without trailing space
            grpColumnPosition.Text = GetTranslation("New column will be at the:")
        ElseIf rdoEnd.Checked Then
            clsColPosFunction.RemoveParameterByName("adjacent_column")
            ucrSelectorColumns.Visible = False
            ucrReceiverColumn.Visible = False
            lblColumns.Visible = False
            grpColumnPosition.Text = GetTranslation("New column will be at the:")
        ElseIf rdoBefore.Checked Then
            If Not ucrReceiverColumn.IsEmpty Then
                clsColPosFunction.AddParameter(strParameterName:="adjacent_column", strParameterValue:=ucrReceiverColumn.GetVariableNames())
            Else
                clsColPosFunction.RemoveParameterByName("adjacent_column")
            End If
            ucrSelectorColumns.Visible = True
            ucrReceiverColumn.Visible = True
            lblColumns.Visible = True
            grpColumnPosition.Text = GetTranslation("New column will be:")
        ElseIf rdoAfter.Checked Then
            If Not ucrReceiverColumn.IsEmpty Then
                clsColPosFunction.AddParameter(strParameterName:="adjacent_column", strParameterValue:=ucrReceiverColumn.GetVariableNames())
            Else
                clsColPosFunction.RemoveParameterByName("adjacent_column")
            End If
            ucrSelectorColumns.Visible = True
            ucrReceiverColumn.Visible = True
            lblColumns.Visible = True
            grpColumnPosition.Text = GetTranslation("New column will be:")
        End If
    End Sub

    ' Update only textual properties so translations are refreshed for preview/changes
    Private Sub UpdateTranslations()
        ' Translate designer/localizable texts for this form
        Translations.autoTranslate(Me)

        ' Update programmatic texts exactly matching the keys used in SetColumnControlsAndParameterState
        If rdoStart.Checked OrElse rdoEnd.Checked Then
            grpColumnPosition.Text = Translations.GetTranslation("New column will be at the:")
        ElseIf rdoBefore.Checked OrElse rdoAfter.Checked Then
            grpColumnPosition.Text = Translations.GetTranslation("New column will be:")
        End If

        ' Update other programmatic texts
        ucrChkKeepExistingPos.Text = Translations.GetTranslation("Keep existing position")
        lblColumns.Text = Translations.GetTranslation("Columns")
    End Sub

    ' Handler invoked during language preview/change raised by parent buttons
    Private Sub ParentButtons_LanguageChanged(ByVal newCulture As String)
        Me.SuspendLayout()
        Try
            UpdateTranslations()
        Finally
            Me.ResumeLayout()
            Me.PerformLayout()
            Me.Refresh()
        End Try
    End Sub

    ' Remove the handler to avoid leaks when the dialog closes
    Private Sub sdgSaveColumnPosition_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If clsParentSdgButtons IsNot Nothing Then
            RemoveHandler clsParentSdgButtons.LanguageChanged, AddressOf ParentButtons_LanguageChanged
            clsParentSdgButtons = Nothing
        End If
    End Sub

    Public ReadOnly Property InsertColumnBefore() As Boolean
        Get
            Return Not IsNothing(clsColPosFunction.GetParameter("before")) AndAlso clsColPosFunction.GetParameter("before").strArgumentValue = "TRUE"
        End Get
    End Property

    Public ReadOnly Property AdjacentColumn() As String
        Get
            Return If(IsNothing(clsColPosFunction.GetParameter("adjacent_column")), "", clsColPosFunction.GetParameter("adjacent_column").strArgumentValue)
        End Get
    End Property

    Public ReadOnly Property KeepExistingPosition() As Boolean
        Get
            Return Not IsNothing(clsColPosFunction.GetParameter("keep_existing_position")) AndAlso clsColPosFunction.GetParameter("keep_existing_position").strArgumentValue = "TRUE"
        End Get
    End Property

    ' Recursive helper to find a control of a given type in the form's control hierarchy.
    Private Function FindControlRecursive(Of T As Control)(parent As Control) As T
        If parent Is Nothing Then Return Nothing
        ' check parent itself
        If TypeOf parent Is T Then
            Return DirectCast(parent, T)
        End If
        ' search children recursively
        For Each ctl As Control In parent.Controls
            Dim result As T = FindControlRecursive(Of T)(ctl)
            If result IsNot Nothing Then
                Return result
            End If
        Next
        Return Nothing
    End Function
End Class