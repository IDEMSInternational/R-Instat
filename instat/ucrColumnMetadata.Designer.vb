<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrColumnMetadata
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.grdVariables = New unvell.ReoGrid.ReoGridControl()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'grdVariables
        '
        Me.grdVariables.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdVariables.BackColor = System.Drawing.Color.White
        Me.grdVariables.ColumnHeaderContextMenuStrip = Nothing
        Me.grdVariables.LeadHeaderContextMenuStrip = Nothing
        Me.grdVariables.Location = New System.Drawing.Point(0, 20)
        Me.grdVariables.Name = "grdVariables"
        Me.grdVariables.RowHeaderContextMenuStrip = Nothing
        Me.grdVariables.Script = Nothing
        Me.grdVariables.SheetTabContextMenuStrip = Nothing
        Me.grdVariables.SheetTabNewButtonVisible = True
        Me.grdVariables.SheetTabVisible = True
        Me.grdVariables.SheetTabWidth = 200
        Me.grdVariables.Size = New System.Drawing.Size(344, 118)
        Me.grdVariables.TabIndex = 2
        Me.grdVariables.Text = "Variables"
        '
        'lblHeader
        '
        Me.lblHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.lblHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.SystemColors.Control
        Me.lblHeader.Location = New System.Drawing.Point(0, 0)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(344, 20)
        Me.lblHeader.TabIndex = 6
        Me.lblHeader.Text = "Column Metadata"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ucrColumnMetadata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.grdVariables)
        Me.Name = "ucrColumnMetadata"
        Me.Size = New System.Drawing.Size(344, 138)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grdVariables As unvell.ReoGrid.ReoGridControl
    Friend WithEvents lblHeader As Label
End Class
