<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrReoGrid
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.grdData = New unvell.ReoGrid.ReoGridControl()
        Me.SuspendLayout()
        '
        'grdData
        '
        Me.grdData.BackColor = System.Drawing.Color.White
        Me.grdData.ColumnHeaderContextMenuStrip = Nothing
        Me.grdData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdData.LeadHeaderContextMenuStrip = Nothing
        Me.grdData.Location = New System.Drawing.Point(0, 0)
        Me.grdData.Name = "grdData"
        Me.grdData.RowHeaderContextMenuStrip = Nothing
        Me.grdData.Script = Nothing
        Me.grdData.SheetTabContextMenuStrip = Nothing
        Me.grdData.SheetTabNewButtonVisible = False
        Me.grdData.SheetTabVisible = True
        Me.grdData.SheetTabWidth = 250
        Me.grdData.ShowScrollEndSpacing = True
        Me.grdData.Size = New System.Drawing.Size(558, 423)
        Me.grdData.TabIndex = 2
        '
        'ucrReoGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grdData)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "ucrReoGrid"
        Me.Size = New System.Drawing.Size(558, 423)
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents grdData As unvell.ReoGrid.ReoGridControl
End Class
