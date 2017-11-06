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

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sdgDataOptions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tbcDataOptions = New System.Windows.Forms.TabControl()
        Me.tbRows = New System.Windows.Forms.TabPage()
        Me.ucrInputFilterPreview = New instat.ucrInputTextBox()
        Me.lblFilterPreview = New System.Windows.Forms.Label()
        Me.grpApplyOptions = New System.Windows.Forms.GroupBox()
        Me.rdoForDialog = New System.Windows.Forms.RadioButton()
        Me.rdoAllDialogs = New System.Windows.Forms.RadioButton()
        Me.cmdDefineNewFilter = New System.Windows.Forms.Button()
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.ucrReceiverFilter = New instat.ucrReceiverSingle()
        Me.ucrSelectorFilters = New instat.ucrSelectorByDataFrame()
        Me.tbColumns = New System.Windows.Forms.TabPage()
        Me.chkShowHiddenColumns = New System.Windows.Forms.CheckBox()
        Me.ucrSubDialogueBase = New instat.ucrButtonsSubdialogue()
        Me.tbcDataOptions.SuspendLayout()
        Me.tbRows.SuspendLayout()
        Me.grpApplyOptions.SuspendLayout()
        Me.tbColumns.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbcDataOptions
        '
        Me.tbcDataOptions.Controls.Add(Me.tbRows)
        Me.tbcDataOptions.Controls.Add(Me.tbColumns)
        Me.tbcDataOptions.Location = New System.Drawing.Point(0, 0)
        Me.tbcDataOptions.Name = "tbcDataOptions"
        Me.tbcDataOptions.SelectedIndex = 0
        Me.tbcDataOptions.Size = New System.Drawing.Size(315, 317)
        Me.tbcDataOptions.TabIndex = 1
        '
        'tbRows
        '
        Me.tbRows.Controls.Add(Me.ucrInputFilterPreview)
        Me.tbRows.Controls.Add(Me.lblFilterPreview)
        Me.tbRows.Controls.Add(Me.grpApplyOptions)
        Me.tbRows.Controls.Add(Me.cmdDefineNewFilter)
        Me.tbRows.Controls.Add(Me.lblFilter)
        Me.tbRows.Controls.Add(Me.ucrReceiverFilter)
        Me.tbRows.Controls.Add(Me.ucrSelectorFilters)
        Me.tbRows.Location = New System.Drawing.Point(4, 22)
        Me.tbRows.Name = "tbRows"
        Me.tbRows.Padding = New System.Windows.Forms.Padding(3)
        Me.tbRows.Size = New System.Drawing.Size(307, 291)
        Me.tbRows.TabIndex = 0
        Me.tbRows.Tag = "Rows"
        Me.tbRows.Text = "Rows"
        Me.tbRows.UseVisualStyleBackColor = True
        '
        'ucrInputFilterPreview
        '
        Me.ucrInputFilterPreview.AddQuotesIfUnrecognised = True
        Me.ucrInputFilterPreview.IsMultiline = False
        Me.ucrInputFilterPreview.IsReadOnly = False
        Me.ucrInputFilterPreview.Location = New System.Drawing.Point(128, 209)
        Me.ucrInputFilterPreview.Name = "ucrInputFilterPreview"
        Me.ucrInputFilterPreview.Size = New System.Drawing.Size(167, 21)
        Me.ucrInputFilterPreview.TabIndex = 6
        '
        'lblFilterPreview
        '
        Me.lblFilterPreview.AutoSize = True
        Me.lblFilterPreview.Location = New System.Drawing.Point(8, 211)
        Me.lblFilterPreview.Name = "lblFilterPreview"
        Me.lblFilterPreview.Size = New System.Drawing.Size(115, 13)
        Me.lblFilterPreview.TabIndex = 5
        Me.lblFilterPreview.Text = "Selected Filter Preview"
        '
        'grpApplyOptions
        '
        Me.grpApplyOptions.Controls.Add(Me.rdoForDialog)
        Me.grpApplyOptions.Controls.Add(Me.rdoAllDialogs)
        Me.grpApplyOptions.Location = New System.Drawing.Point(8, 236)
        Me.grpApplyOptions.Name = "grpApplyOptions"
        Me.grpApplyOptions.Size = New System.Drawing.Size(247, 49)
        Me.grpApplyOptions.TabIndex = 2
        Me.grpApplyOptions.TabStop = False
        Me.grpApplyOptions.Tag = "Apply_Options"
        Me.grpApplyOptions.Text = "Apply Options"
        '
        'rdoForDialog
        '
        Me.rdoForDialog.AutoSize = True
        Me.rdoForDialog.Enabled = False
        Me.rdoForDialog.Location = New System.Drawing.Point(120, 19)
        Me.rdoForDialog.Name = "rdoForDialog"
        Me.rdoForDialog.Size = New System.Drawing.Size(120, 17)
        Me.rdoForDialog.TabIndex = 6
        Me.rdoForDialog.TabStop = True
        Me.rdoForDialog.Text = "For This Dialog Only"
        Me.rdoForDialog.UseVisualStyleBackColor = True
        '
        'rdoAllDialogs
        '
        Me.rdoAllDialogs.AutoSize = True
        Me.rdoAllDialogs.Location = New System.Drawing.Point(10, 19)
        Me.rdoAllDialogs.Name = "rdoAllDialogs"
        Me.rdoAllDialogs.Size = New System.Drawing.Size(92, 17)
        Me.rdoAllDialogs.TabIndex = 5
        Me.rdoAllDialogs.TabStop = True
        Me.rdoAllDialogs.Text = "For All Dialogs"
        Me.rdoAllDialogs.UseVisualStyleBackColor = True
        '
        'cmdDefineNewFilter
        '
        Me.cmdDefineNewFilter.Location = New System.Drawing.Point(175, 93)
        Me.cmdDefineNewFilter.Name = "cmdDefineNewFilter"
        Me.cmdDefineNewFilter.Size = New System.Drawing.Size(120, 23)
        Me.cmdDefineNewFilter.TabIndex = 4
        Me.cmdDefineNewFilter.Tag = "Define_New_Filter"
        Me.cmdDefineNewFilter.Text = "Define New Filter"
        Me.cmdDefineNewFilter.UseVisualStyleBackColor = True
        '
        'lblFilter
        '
        Me.lblFilter.AutoSize = True
        Me.lblFilter.Location = New System.Drawing.Point(172, 21)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(29, 13)
        Me.lblFilter.TabIndex = 3
        Me.lblFilter.Tag = "Filter"
        Me.lblFilter.Text = "Filter"
        '
        'ucrReceiverFilter
        '
        Me.ucrReceiverFilter.frmParent = Nothing
        Me.ucrReceiverFilter.Location = New System.Drawing.Point(175, 34)
        Me.ucrReceiverFilter.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFilter.Name = "ucrReceiverFilter"
        Me.ucrReceiverFilter.Selector = Nothing
        Me.ucrReceiverFilter.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverFilter.strNcFilePath = ""
        Me.ucrReceiverFilter.TabIndex = 2
        Me.ucrReceiverFilter.ucrSelector = Nothing
        '
        'ucrSelectorFilters
        '
        Me.ucrSelectorFilters.bShowHiddenColumns = False
        Me.ucrSelectorFilters.bUseCurrentFilter = True
        Me.ucrSelectorFilters.Location = New System.Drawing.Point(8, 8)
        Me.ucrSelectorFilters.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorFilters.Name = "ucrSelectorFilters"
        Me.ucrSelectorFilters.Size = New System.Drawing.Size(154, 180)
        Me.ucrSelectorFilters.TabIndex = 0
        '
        'tbColumns
        '
        Me.tbColumns.Controls.Add(Me.chkShowHiddenColumns)
        Me.tbColumns.Location = New System.Drawing.Point(4, 22)
        Me.tbColumns.Name = "tbColumns"
        Me.tbColumns.Padding = New System.Windows.Forms.Padding(3)
        Me.tbColumns.Size = New System.Drawing.Size(307, 291)
        Me.tbColumns.TabIndex = 1
        Me.tbColumns.Tag = "Columns"
        Me.tbColumns.Text = "Columns"
        Me.tbColumns.UseVisualStyleBackColor = True
        '
        'chkShowHiddenColumns
        '
        Me.chkShowHiddenColumns.AutoSize = True
        Me.chkShowHiddenColumns.Location = New System.Drawing.Point(6, 39)
        Me.chkShowHiddenColumns.Name = "chkShowHiddenColumns"
        Me.chkShowHiddenColumns.Size = New System.Drawing.Size(186, 17)
        Me.chkShowHiddenColumns.TabIndex = 0
        Me.chkShowHiddenColumns.Tag = "Show_Hidden_Columns_in_Selector"
        Me.chkShowHiddenColumns.Text = "Show Hidden Columns in Selector"
        Me.chkShowHiddenColumns.UseVisualStyleBackColor = True
        '
        'ucrSubDialogueBase
        '
        Me.ucrSubDialogueBase.Location = New System.Drawing.Point(88, 323)
        Me.ucrSubDialogueBase.Name = "ucrSubDialogueBase"
        Me.ucrSubDialogueBase.Size = New System.Drawing.Size(142, 30)
        Me.ucrSubDialogueBase.TabIndex = 0
        '
        'sdgDataOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 351)
        Me.Controls.Add(Me.tbcDataOptions)
        Me.Controls.Add(Me.ucrSubDialogueBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgDataOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "Data_Options"
        Me.Text = "Data Options"
        Me.TopMost = True
        Me.tbcDataOptions.ResumeLayout(False)
        Me.tbRows.ResumeLayout(False)
        Me.tbRows.PerformLayout()
        Me.grpApplyOptions.ResumeLayout(False)
        Me.grpApplyOptions.PerformLayout()
        Me.tbColumns.ResumeLayout(False)
        Me.tbColumns.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrSubDialogueBase As ucrButtonsSubdialogue
    Friend WithEvents tbcDataOptions As TabControl
    Friend WithEvents tbRows As TabPage
    Friend WithEvents tbColumns As TabPage
    Friend WithEvents chkShowHiddenColumns As CheckBox
    Friend WithEvents ucrSelectorFilters As ucrSelectorByDataFrame
    Friend WithEvents cmdDefineNewFilter As Button
    Friend WithEvents lblFilter As Label
    Friend WithEvents ucrReceiverFilter As ucrReceiverSingle
    Friend WithEvents grpApplyOptions As GroupBox
    Friend WithEvents rdoForDialog As RadioButton
    Friend WithEvents rdoAllDialogs As RadioButton
    Friend WithEvents ucrInputFilterPreview As ucrInputTextBox
    Friend WithEvents lblFilterPreview As Label
End Class
