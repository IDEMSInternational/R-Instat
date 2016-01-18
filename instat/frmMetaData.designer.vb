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
        Me.grdMetaData = New unvell.ReoGrid.ReoGridControl()
        Me.txtMetadata = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'grdMetaData
        '
        Me.grdMetaData.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grdMetaData.BackColor = System.Drawing.Color.White
        Me.grdMetaData.ColumnHeaderContextMenuStrip = Nothing
        Me.grdMetaData.LeadHeaderContextMenuStrip = Nothing
        Me.grdMetaData.Location = New System.Drawing.Point(8, 6)
        Me.grdMetaData.Name = "grdMetaData"
        Me.grdMetaData.RowHeaderContextMenuStrip = Nothing
        Me.grdMetaData.Script = Nothing
        Me.grdMetaData.SheetTabContextMenuStrip = Nothing
        Me.grdMetaData.SheetTabControlNewButtonVisible = False
        Me.grdMetaData.SheetTabControlWidth = 100
        Me.grdMetaData.SheetTabNewButtonVisible = False
        Me.grdMetaData.Size = New System.Drawing.Size(322, 105)
        Me.grdMetaData.TabIndex = 1
        Me.grdMetaData.Text = "Meta Data"
        '
        'txtMetadata
        '
        Me.txtMetadata.Location = New System.Drawing.Point(213, 11)
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
        Me.ClientSize = New System.Drawing.Size(334, 117)
        Me.Controls.Add(Me.grdMetaData)
        Me.Controls.Add(Me.txtMetadata)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMetaData"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Worksheet Metadata"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdMetaData As unvell.ReoGrid.ReoGridControl
    Friend WithEvents txtMetadata As TextBox
End Class
