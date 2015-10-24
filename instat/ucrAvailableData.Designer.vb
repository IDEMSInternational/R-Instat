<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrAvailableData
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
        Me.components = New System.ComponentModel.Container()
        Me.lstAvailbaleData = New System.Windows.Forms.ListBox()
        Me.lblAvailableData = New System.Windows.Forms.Label()
        Me.btnAvailableData = New System.Windows.Forms.Button()
        Me.txtAvailableData = New System.Windows.Forms.MaskedTextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ChkBy = New System.Windows.Forms.CheckBox()
        Me.lblBy = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstAvailbaleData
        '
        Me.lstAvailbaleData.FormattingEnabled = True
        Me.lstAvailbaleData.Location = New System.Drawing.Point(28, 70)
        Me.lstAvailbaleData.Name = "lstAvailbaleData"
        Me.lstAvailbaleData.Size = New System.Drawing.Size(103, 95)
        Me.lstAvailbaleData.TabIndex = 1
        '
        'lblAvailableData
        '
        Me.lblAvailableData.AutoSize = True
        Me.lblAvailableData.Location = New System.Drawing.Point(28, 24)
        Me.lblAvailableData.Name = "lblAvailableData"
        Me.lblAvailableData.Size = New System.Drawing.Size(76, 13)
        Me.lblAvailableData.TabIndex = 2
        Me.lblAvailableData.Tag = "Available_Data"
        Me.lblAvailableData.Text = "Available Data"
        '
        'btnAvailableData
        '
        Me.btnAvailableData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAvailableData.Location = New System.Drawing.Point(128, 41)
        Me.btnAvailableData.Name = "btnAvailableData"
        Me.btnAvailableData.Size = New System.Drawing.Size(28, 20)
        Me.btnAvailableData.TabIndex = 3
        Me.btnAvailableData.Text = "<"
        Me.btnAvailableData.UseVisualStyleBackColor = True
        '
        'txtAvailableData
        '
        Me.txtAvailableData.Location = New System.Drawing.Point(28, 41)
        Me.txtAvailableData.Name = "txtAvailableData"
        Me.txtAvailableData.Size = New System.Drawing.Size(103, 20)
        Me.txtAvailableData.TabIndex = 4
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'ChkBy
        '
        Me.ChkBy.AutoSize = True
        Me.ChkBy.Location = New System.Drawing.Point(28, 182)
        Me.ChkBy.Name = "ChkBy"
        Me.ChkBy.Size = New System.Drawing.Size(15, 14)
        Me.ChkBy.TabIndex = 6
        Me.ChkBy.Tag = "By"
        Me.ChkBy.UseVisualStyleBackColor = True
        '
        'lblBy
        '
        Me.lblBy.AutoSize = True
        Me.lblBy.Location = New System.Drawing.Point(49, 183)
        Me.lblBy.Name = "lblBy"
        Me.lblBy.Size = New System.Drawing.Size(19, 13)
        Me.lblBy.TabIndex = 7
        Me.lblBy.Tag = "By"
        Me.lblBy.Text = "By"
        '
        'ucrAvailableData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblBy)
        Me.Controls.Add(Me.ChkBy)
        Me.Controls.Add(Me.txtAvailableData)
        Me.Controls.Add(Me.btnAvailableData)
        Me.Controls.Add(Me.lblAvailableData)
        Me.Controls.Add(Me.lstAvailbaleData)
        Me.Name = "ucrAvailableData"
        Me.Size = New System.Drawing.Size(197, 223)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstAvailbaleData As ListBox
    Friend WithEvents lblAvailableData As Label
    Friend WithEvents btnAvailableData As Button
    Friend WithEvents txtAvailableData As MaskedTextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ChkBy As CheckBox
    Friend WithEvents lblBy As Label
End Class
