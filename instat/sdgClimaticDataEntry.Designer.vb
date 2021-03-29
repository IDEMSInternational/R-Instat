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
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.ucrSdgPICSARainfalbuttons = New instat.ucrButtonsSubdialogue()
        Me.ttCmdReset = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdReset)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ucrSdgPICSARainfalbuttons)
        Me.SplitContainer1.Size = New System.Drawing.Size(494, 295)
        Me.SplitContainer1.SplitterDistance = 251
        Me.SplitContainer1.TabIndex = 0
        '
        'grdDataEntry
        '
        Me.grdDataEntry.BackColor = System.Drawing.Color.White
        Me.grdDataEntry.ColumnHeaderContextMenuStrip = Nothing
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
        Me.grdDataEntry.Size = New System.Drawing.Size(494, 251)
        Me.grdDataEntry.TabIndex = 3
        Me.grdDataEntry.Text = "Variables"
        '
        'cmdReset
        '
        Me.cmdReset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdReset.Location = New System.Drawing.Point(410, 9)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(72, 24)
        Me.cmdReset.TabIndex = 88
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'ucrSdgPICSARainfalbuttons
        '
        Me.ucrSdgPICSARainfalbuttons.Location = New System.Drawing.Point(161, 5)
        Me.ucrSdgPICSARainfalbuttons.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrSdgPICSARainfalbuttons.Name = "ucrSdgPICSARainfalbuttons"
        Me.ucrSdgPICSARainfalbuttons.Size = New System.Drawing.Size(144, 30)
        Me.ucrSdgPICSARainfalbuttons.TabIndex = 87
        '
        'ttCmdReset
        '
        Me.ttCmdReset.AutoPopDelay = 10000
        Me.ttCmdReset.InitialDelay = 500
        Me.ttCmdReset.ReshowDelay = 100
        '
        'sdgClimaticDataEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 295)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "sdgClimaticDataEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Climatic Data Entry"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents ucrSdgPICSARainfalbuttons As ucrButtonsSubdialogue
    Friend WithEvents grdDataEntry As unvell.ReoGrid.ReoGridControl
    Friend WithEvents cmdReset As Button
    Friend WithEvents ttCmdReset As ToolTip
End Class
