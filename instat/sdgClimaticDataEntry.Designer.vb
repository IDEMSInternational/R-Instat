<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgClimaticDataEntry
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
        Me.components = New System.ComponentModel.Container()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.grdDataEntry = New unvell.ReoGrid.ReoGridControl()
        Me.cellContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuComment = New System.Windows.Forms.ToolStripMenuItem()
        Me.ucrChkAddFlagFieldData = New instat.ucrCheck()
        Me.cmdComment = New System.Windows.Forms.Button()
        Me.cmdTransform = New System.Windows.Forms.Button()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.ucrSdgBaseButtons = New instat.ucrButtonsSubdialogue()
        Me.ttCmds = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.cellContextMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.grdDataEntry)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ucrChkAddFlagFieldData)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdComment)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdTransform)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdReset)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ucrSdgBaseButtons)
        Me.SplitContainer1.Size = New System.Drawing.Size(647, 295)
        Me.SplitContainer1.SplitterDistance = 251
        Me.SplitContainer1.TabIndex = 0
        '
        'grdDataEntry
        '
        Me.grdDataEntry.BackColor = System.Drawing.Color.White
        Me.grdDataEntry.ColumnHeaderContextMenuStrip = Nothing
        Me.grdDataEntry.ContextMenuStrip = Me.cellContextMenuStrip
        Me.grdDataEntry.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdDataEntry.LeadHeaderContextMenuStrip = Nothing
        Me.grdDataEntry.Location = New System.Drawing.Point(0, 0)
        Me.grdDataEntry.Name = "grdDataEntry"
        Me.grdDataEntry.RowHeaderContextMenuStrip = Nothing
        Me.grdDataEntry.Script = Nothing
        Me.grdDataEntry.SheetTabContextMenuStrip = Nothing
        Me.grdDataEntry.SheetTabNewButtonVisible = True
        Me.grdDataEntry.SheetTabVisible = True
        Me.grdDataEntry.SheetTabWidth = 154
        Me.grdDataEntry.ShowScrollEndSpacing = True
        Me.grdDataEntry.Size = New System.Drawing.Size(647, 251)
        Me.grdDataEntry.TabIndex = 3
        Me.grdDataEntry.Text = "Variables"
        '
        'cellContextMenuStrip
        '
        Me.cellContextMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cellContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator3, Me.mnuCopy, Me.mnuPaste, Me.ToolStripSeparator5, Me.mnuComment})
        Me.cellContextMenuStrip.Name = "cellContextMenuStrip"
        Me.cellContextMenuStrip.Size = New System.Drawing.Size(145, 82)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(141, 6)
        '
        'mnuCopy
        '
        Me.mnuCopy.Name = "mnuCopy"
        Me.mnuCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuCopy.Size = New System.Drawing.Size(144, 22)
        Me.mnuCopy.Text = "Copy"
        '
        'mnuPaste
        '
        Me.mnuPaste.Name = "mnuPaste"
        Me.mnuPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.mnuPaste.Size = New System.Drawing.Size(144, 22)
        Me.mnuPaste.Text = "Paste"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(141, 6)
        '
        'mnuComment
        '
        Me.mnuComment.Name = "mnuComment"
        Me.mnuComment.Size = New System.Drawing.Size(144, 22)
        Me.mnuComment.Text = "Comment"
        '
        'ucrChkAddFlagFieldData
        '
        Me.ucrChkAddFlagFieldData.AutoSize = True
        Me.ucrChkAddFlagFieldData.Checked = False
        Me.ucrChkAddFlagFieldData.Location = New System.Drawing.Point(185, 10)
        Me.ucrChkAddFlagFieldData.Name = "ucrChkAddFlagFieldData"
        Me.ucrChkAddFlagFieldData.Size = New System.Drawing.Size(146, 23)
        Me.ucrChkAddFlagFieldData.TabIndex = 91
        '
        'cmdComment
        '
        Me.cmdComment.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdComment.Location = New System.Drawing.Point(337, 7)
        Me.cmdComment.Name = "cmdComment"
        Me.cmdComment.Size = New System.Drawing.Size(90, 24)
        Me.cmdComment.TabIndex = 90
        Me.cmdComment.Text = "Comment"
        Me.cmdComment.UseVisualStyleBackColor = True
        '
        'cmdTransform
        '
        Me.cmdTransform.Enabled = False
        Me.cmdTransform.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdTransform.Location = New System.Drawing.Point(431, 7)
        Me.cmdTransform.Name = "cmdTransform"
        Me.cmdTransform.Size = New System.Drawing.Size(104, 24)
        Me.cmdTransform.TabIndex = 89
        Me.cmdTransform.Text = "Transform"
        Me.ttCmds.SetToolTip(Me.cmdTransform, "When implemented, this is an option to show the transformed data.")
        Me.cmdTransform.UseVisualStyleBackColor = True
        '
        'cmdReset
        '
        Me.cmdReset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdReset.Location = New System.Drawing.Point(541, 7)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(72, 24)
        Me.cmdReset.TabIndex = 88
        Me.cmdReset.Text = "Reset"
        Me.ttCmds.SetToolTip(Me.cmdReset, "Clears all data entry.")
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'ucrSdgBaseButtons
        '
        Me.ucrSdgBaseButtons.AutoSize = True
        Me.ucrSdgBaseButtons.Location = New System.Drawing.Point(13, 6)
        Me.ucrSdgBaseButtons.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrSdgBaseButtons.Name = "ucrSdgBaseButtons"
        Me.ucrSdgBaseButtons.Size = New System.Drawing.Size(224, 30)
        Me.ucrSdgBaseButtons.TabIndex = 87
        '
        'ttCmds
        '
        Me.ttCmds.AutoPopDelay = 10000
        Me.ttCmds.InitialDelay = 500
        Me.ttCmds.ReshowDelay = 100
        '
        'sdgClimaticDataEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(647, 295)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "sdgClimaticDataEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Climatic Data Entry"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.cellContextMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents ucrSdgBaseButtons As ucrButtonsSubdialogue
    Friend WithEvents grdDataEntry As unvell.ReoGrid.ReoGridControl
    Friend WithEvents cmdReset As Button
    Friend WithEvents ttCmds As ToolTip
    Friend WithEvents cmdTransform As Button
    Friend WithEvents cmdComment As Button
    Friend WithEvents ucrChkAddFlagFieldData As ucrCheck
    Private WithEvents cellContextMenuStrip As ContextMenuStrip
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents mnuCopy As ToolStripMenuItem
    Friend WithEvents mnuPaste As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents mnuComment As ToolStripMenuItem
End Class
