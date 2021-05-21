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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgClimaticDataEntry))
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
        resources.ApplyResources(Me.SplitContainer1, "SplitContainer1")
        Me.SplitContainer1.Name = "SplitContainer1"
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
        '
        'grdDataEntry
        '
        Me.grdDataEntry.BackColor = System.Drawing.Color.White
        Me.grdDataEntry.ColumnHeaderContextMenuStrip = Nothing
        Me.grdDataEntry.ContextMenuStrip = Me.cellContextMenuStrip
        resources.ApplyResources(Me.grdDataEntry, "grdDataEntry")
        Me.grdDataEntry.LeadHeaderContextMenuStrip = Nothing
        Me.grdDataEntry.Name = "grdDataEntry"
        Me.grdDataEntry.RowHeaderContextMenuStrip = Nothing
        Me.grdDataEntry.Script = Nothing
        Me.grdDataEntry.SheetTabContextMenuStrip = Nothing
        Me.grdDataEntry.SheetTabNewButtonVisible = True
        Me.grdDataEntry.SheetTabVisible = True
        Me.grdDataEntry.SheetTabWidth = 154
        Me.grdDataEntry.ShowScrollEndSpacing = True
        '
        'cellContextMenuStrip
        '
        Me.cellContextMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cellContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator3, Me.mnuCopy, Me.mnuPaste, Me.ToolStripSeparator5, Me.mnuComment})
        Me.cellContextMenuStrip.Name = "cellContextMenuStrip"
        resources.ApplyResources(Me.cellContextMenuStrip, "cellContextMenuStrip")
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        resources.ApplyResources(Me.ToolStripSeparator3, "ToolStripSeparator3")
        '
        'mnuCopy
        '
        Me.mnuCopy.Name = "mnuCopy"
        resources.ApplyResources(Me.mnuCopy, "mnuCopy")
        '
        'mnuPaste
        '
        Me.mnuPaste.Name = "mnuPaste"
        resources.ApplyResources(Me.mnuPaste, "mnuPaste")
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        resources.ApplyResources(Me.ToolStripSeparator5, "ToolStripSeparator5")
        '
        'mnuComment
        '
        Me.mnuComment.Name = "mnuComment"
        resources.ApplyResources(Me.mnuComment, "mnuComment")
        '
        'ucrChkAddFlagFieldData
        '
        Me.ucrChkAddFlagFieldData.Checked = False
        resources.ApplyResources(Me.ucrChkAddFlagFieldData, "ucrChkAddFlagFieldData")
        Me.ucrChkAddFlagFieldData.Name = "ucrChkAddFlagFieldData"
        '
        'cmdComment
        '
        resources.ApplyResources(Me.cmdComment, "cmdComment")
        Me.cmdComment.Name = "cmdComment"
        Me.cmdComment.UseVisualStyleBackColor = True
        '
        'cmdTransform
        '
        resources.ApplyResources(Me.cmdTransform, "cmdTransform")
        Me.cmdTransform.Name = "cmdTransform"
        Me.ttCmds.SetToolTip(Me.cmdTransform, resources.GetString("cmdTransform.ToolTip"))
        Me.cmdTransform.UseVisualStyleBackColor = True
        '
        'cmdReset
        '
        resources.ApplyResources(Me.cmdReset, "cmdReset")
        Me.cmdReset.Name = "cmdReset"
        Me.ttCmds.SetToolTip(Me.cmdReset, resources.GetString("cmdReset.ToolTip"))
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'ucrSdgBaseButtons
        '
        resources.ApplyResources(Me.ucrSdgBaseButtons, "ucrSdgBaseButtons")
        Me.ucrSdgBaseButtons.Name = "ucrSdgBaseButtons"
        '
        'ttCmds
        '
        Me.ttCmds.AutoPopDelay = 10000
        Me.ttCmds.InitialDelay = 500
        Me.ttCmds.ReshowDelay = 100
        '
        'sdgClimaticDataEntry
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "sdgClimaticDataEntry"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
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
