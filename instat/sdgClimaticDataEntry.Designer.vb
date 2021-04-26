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
        Me.ucrChkAddFlagFieldData = New instat.ucrCheck()
        Me.cmdComment = New System.Windows.Forms.Button()
        Me.cmdTransform = New System.Windows.Forms.Button()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.ucrSdgBaseButtons = New instat.ucrButtonsSubdialogue()
        Me.ttCmdReset = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttCmdTransformButton = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
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
        Me.cmdTransform.UseVisualStyleBackColor = True
        '
        'cmdReset
        '
        resources.ApplyResources(Me.cmdReset, "cmdReset")
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'ucrSdgBaseButtons
        '
        resources.ApplyResources(Me.ucrSdgBaseButtons, "ucrSdgBaseButtons")
        Me.ucrSdgBaseButtons.Name = "ucrSdgBaseButtons"
        '
        'ttCmdReset
        '
        Me.ttCmdReset.AutoPopDelay = 10000
        Me.ttCmdReset.InitialDelay = 500
        Me.ttCmdReset.ReshowDelay = 100
        '
        'ttCmdTransformButton
        '
        Me.ttCmdTransformButton.AutoPopDelay = 10000
        Me.ttCmdTransformButton.InitialDelay = 500
        Me.ttCmdTransformButton.ReshowDelay = 100
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents ucrSdgBaseButtons As ucrButtonsSubdialogue
    Friend WithEvents grdDataEntry As unvell.ReoGrid.ReoGridControl
    Friend WithEvents cmdReset As Button
    Friend WithEvents ttCmdReset As ToolTip
    Friend WithEvents cmdTransform As Button
    Friend WithEvents ttCmdTransformButton As ToolTip
    Friend WithEvents cmdComment As Button
    Friend WithEvents ucrChkAddFlagFieldData As ucrCheck
End Class
