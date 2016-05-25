<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.ucrSubDialogueBase = New instat.ucrButtonsSubdialogue()
        Me.tbcDataOptions = New System.Windows.Forms.TabControl()
        Me.tbRows = New System.Windows.Forms.TabPage()
        Me.tbColumns = New System.Windows.Forms.TabPage()
        Me.chkShowHiddenColumns = New System.Windows.Forms.CheckBox()
        Me.ucrSelectorFilters = New instat.ucrSelectorByDataFrame()
        Me.ucrReceiverFilter = New instat.ucrReceiverSingle()
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.cmdNewFilter = New System.Windows.Forms.Button()
        Me.tbcDataOptions.SuspendLayout()
        Me.tbRows.SuspendLayout()
        Me.tbColumns.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrSubDialogueBase
        '
        Me.ucrSubDialogueBase.Location = New System.Drawing.Point(88, 323)
        Me.ucrSubDialogueBase.Name = "ucrSubDialogueBase"
        Me.ucrSubDialogueBase.Size = New System.Drawing.Size(142, 30)
        Me.ucrSubDialogueBase.TabIndex = 0
        '
        'tbcDataOptions
        '
        Me.tbcDataOptions.Controls.Add(Me.tbRows)
        Me.tbcDataOptions.Controls.Add(Me.tbColumns)
        Me.tbcDataOptions.Location = New System.Drawing.Point(0, 0)
        Me.tbcDataOptions.Name = "tbcDataOptions"
        Me.tbcDataOptions.SelectedIndex = 0
        Me.tbcDataOptions.Size = New System.Drawing.Size(336, 317)
        Me.tbcDataOptions.TabIndex = 1
        '
        'tbRows
        '
        Me.tbRows.Controls.Add(Me.cmdNewFilter)
        Me.tbRows.Controls.Add(Me.lblFilter)
        Me.tbRows.Controls.Add(Me.ucrReceiverFilter)
        Me.tbRows.Controls.Add(Me.ucrSelectorFilters)
        Me.tbRows.Location = New System.Drawing.Point(4, 22)
        Me.tbRows.Name = "tbRows"
        Me.tbRows.Padding = New System.Windows.Forms.Padding(3)
        Me.tbRows.Size = New System.Drawing.Size(328, 291)
        Me.tbRows.TabIndex = 0
        Me.tbRows.Tag = "Rows"
        Me.tbRows.Text = "Rows"
        Me.tbRows.UseVisualStyleBackColor = True
        '
        'tbColumns
        '
        Me.tbColumns.Controls.Add(Me.chkShowHiddenColumns)
        Me.tbColumns.Location = New System.Drawing.Point(4, 22)
        Me.tbColumns.Name = "tbColumns"
        Me.tbColumns.Padding = New System.Windows.Forms.Padding(3)
        Me.tbColumns.Size = New System.Drawing.Size(328, 291)
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
        'ucrSelectorFilters
        '
        Me.ucrSelectorFilters.Location = New System.Drawing.Point(8, 8)
        Me.ucrSelectorFilters.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorFilters.Name = "ucrSelectorFilters"
        Me.ucrSelectorFilters.Size = New System.Drawing.Size(120, 180)
        Me.ucrSelectorFilters.TabIndex = 0
        '
        'ucrReceiverFilter
        '
        Me.ucrReceiverFilter.Location = New System.Drawing.Point(175, 34)
        Me.ucrReceiverFilter.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFilter.Name = "ucrReceiverFilter"
        Me.ucrReceiverFilter.Selector = Nothing
        Me.ucrReceiverFilter.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverFilter.TabIndex = 2
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
        'cmdNewFilter
        '
        Me.cmdNewFilter.Enabled = False
        Me.cmdNewFilter.Location = New System.Drawing.Point(175, 93)
        Me.cmdNewFilter.Name = "cmdNewFilter"
        Me.cmdNewFilter.Size = New System.Drawing.Size(75, 23)
        Me.cmdNewFilter.TabIndex = 4
        Me.cmdNewFilter.Tag = "New_Filter"
        Me.cmdNewFilter.Text = "New Filter"
        Me.cmdNewFilter.UseVisualStyleBackColor = True
        '
        'sdgDataOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 351)
        Me.Controls.Add(Me.tbcDataOptions)
        Me.Controls.Add(Me.ucrSubDialogueBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "sdgDataOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Data_Options"
        Me.Text = "Data Options"
        Me.TopMost = True
        Me.tbcDataOptions.ResumeLayout(False)
        Me.tbRows.ResumeLayout(False)
        Me.tbRows.PerformLayout()
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
    Friend WithEvents cmdNewFilter As Button
    Friend WithEvents lblFilter As Label
    Friend WithEvents ucrReceiverFilter As ucrReceiverSingle
End Class
