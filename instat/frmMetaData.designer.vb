<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMetaData
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
        Me.gridMetaData = New unvell.ReoGrid.ReoGridControl()
        Me.txtMetadata = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'gridMetaData
        '
        Me.gridMetaData.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gridMetaData.BackColor = System.Drawing.Color.White
        Me.gridMetaData.ColumnHeaderContextMenuStrip = Nothing
        Me.gridMetaData.LeadHeaderContextMenuStrip = Nothing
        Me.gridMetaData.Location = New System.Drawing.Point(8, 6)
        Me.gridMetaData.Name = "gridMetaData"
        Me.gridMetaData.RowHeaderContextMenuStrip = Nothing
        Me.gridMetaData.Script = Nothing
        Me.gridMetaData.SheetTabContextMenuStrip = Nothing
        Me.gridMetaData.SheetTabControlNewButtonVisible = False
        Me.gridMetaData.SheetTabControlWidth = 100
        Me.gridMetaData.SheetTabNewButtonVisible = False
        Me.gridMetaData.Size = New System.Drawing.Size(268, 155)
        Me.gridMetaData.TabIndex = 1
        Me.gridMetaData.Text = "Meta Data"
        '
        'txtMetadata
        '
        Me.txtMetadata.Location = New System.Drawing.Point(293, 31)
        Me.txtMetadata.Multiline = True
        Me.txtMetadata.Name = "txtMetadata"
        Me.txtMetadata.ReadOnly = True
        Me.txtMetadata.Size = New System.Drawing.Size(205, 100)
        Me.txtMetadata.TabIndex = 2
        '
        'frmMetaData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 167)
        Me.Controls.Add(Me.txtMetadata)
        Me.Controls.Add(Me.gridMetaData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMetaData"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Worksheet Metadata"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gridMetaData As unvell.ReoGrid.ReoGridControl
    Friend WithEvents txtMetadata As TextBox
End Class
