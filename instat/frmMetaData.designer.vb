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
        Me.grdMetaData.BackColor = System.Drawing.Color.White
        Me.grdMetaData.ColumnHeaderContextMenuStrip = Nothing
        Me.grdMetaData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdMetaData.LeadHeaderContextMenuStrip = Nothing
        Me.grdMetaData.Location = New System.Drawing.Point(0, 0)
        Me.grdMetaData.Name = "grdMetaData"
        Me.grdMetaData.RowHeaderContextMenuStrip = Nothing
        Me.grdMetaData.Script = Nothing
        Me.grdMetaData.SheetTabContextMenuStrip = Nothing
        Me.grdMetaData.SheetTabNewButtonVisible = False
        Me.grdMetaData.SheetTabVisible = False
        Me.grdMetaData.SheetTabWidth = 100
        Me.grdMetaData.Size = New System.Drawing.Size(477, 317)
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
        Me.ClientSize = New System.Drawing.Size(477, 317)
        Me.Controls.Add(Me.grdMetaData)
        Me.Controls.Add(Me.txtMetadata)
        Me.Name = "frmMetaData"
        Me.ShowIcon = False
        Me.Text = "Data frame Metadata"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdMetaData As unvell.ReoGrid.ReoGridControl
    Friend WithEvents txtMetadata As TextBox
End Class
