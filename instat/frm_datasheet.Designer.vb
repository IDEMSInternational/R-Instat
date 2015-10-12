<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_datasheet
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_datasheet))
        Me.dtViewData = New System.Windows.Forms.DataGridView()
        Me.grid = New unvell.ReoGrid.ReoGridControl()
        CType(Me.dtViewData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtViewData
        '
        Me.dtViewData.AllowDrop = True
        Me.dtViewData.AllowUserToOrderColumns = True
        Me.dtViewData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtViewData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtViewData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtViewData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtViewData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dtViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtViewData.Location = New System.Drawing.Point(-12, 135)
        Me.dtViewData.Name = "dtViewData"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.dtViewData.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dtViewData.Size = New System.Drawing.Size(511, 335)
        Me.dtViewData.TabIndex = 0
        Me.dtViewData.Visible = False
        '
        'grid
        '
        Me.grid.BackColor = System.Drawing.Color.White
        Me.grid.ColumnHeaderContextMenuStrip = Nothing
        Me.grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid.LeadHeaderContextMenuStrip = Nothing
        Me.grid.Location = New System.Drawing.Point(0, 10)
        Me.grid.Name = "grid"
        Me.grid.RowHeaderContextMenuStrip = Nothing
        Me.grid.Script = Nothing
        Me.grid.SheetTabContextMenuStrip = Nothing
        Me.grid.SheetTabControlNewButtonVisible = True
        Me.grid.SheetTabControlWidth = 60
        Me.grid.SheetTabNewButtonVisible = True
        Me.grid.Size = New System.Drawing.Size(511, 335)
        Me.grid.TabIndex = 1
        Me.grid.Text = "ReoGridControl1"
        '
        'frm_datasheet
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(511, 345)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.dtViewData)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(10, 0)
        Me.MinimizeBox = False
        Me.Name = "frm_datasheet"
        Me.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Current Worksheet - "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dtViewData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtViewData As DataGridView
    Friend WithEvents grid As unvell.ReoGrid.ReoGridControl
End Class
