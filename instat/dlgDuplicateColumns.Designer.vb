<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgDuplicateColumns
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.ucrSelectColumnstoCopy = New instat.ucrSelectorByDataFrame()
        Me.lblColumns = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiveColumns = New instat.ucrReceiverMultiple()
        Me.SuspendLayout()
        '
        'ucrSelectColumnstoCopy
        '
        Me.ucrSelectColumnstoCopy.bShowHiddenColumns = False
        Me.ucrSelectColumnstoCopy.bUseCurrentFilter = True
        Me.ucrSelectColumnstoCopy.Location = New System.Drawing.Point(3, 1)
        Me.ucrSelectColumnstoCopy.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectColumnstoCopy.Name = "ucrSelectColumnstoCopy"
        Me.ucrSelectColumnstoCopy.Size = New System.Drawing.Size(147, 177)
        Me.ucrSelectColumnstoCopy.TabIndex = 8
        '
        'lblColumns
        '
        Me.lblColumns.AutoSize = True
        Me.lblColumns.Location = New System.Drawing.Point(290, 58)
        Me.lblColumns.Name = "lblColumns"
        Me.lblColumns.Size = New System.Drawing.Size(109, 13)
        Me.lblColumns.TabIndex = 7
        Me.lblColumns.Text = "Columns to be copied"
        '
        'ucrBase
        '
        Me.ucrBase.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ucrBase.Location = New System.Drawing.Point(3, 182)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(403, 53)
        Me.ucrBase.TabIndex = 6
        '
        'ucrReceiveColumns
        '
        Me.ucrReceiveColumns.Location = New System.Drawing.Point(285, 74)
        Me.ucrReceiveColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiveColumns.Name = "ucrReceiveColumns"
        Me.ucrReceiveColumns.Selector = Nothing
        Me.ucrReceiveColumns.Size = New System.Drawing.Size(121, 104)
        Me.ucrReceiveColumns.TabIndex = 5
        '
        'dlgDuplicateColumns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 234)
        Me.Controls.Add(Me.ucrSelectColumnstoCopy)
        Me.Controls.Add(Me.lblColumns)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReceiveColumns)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDuplicateColumns"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Duplicate_copy_paste_columns"
        Me.Text = "Duplicate (copy/paste) columns"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectColumnstoCopy As ucrSelectorByDataFrame
    Friend WithEvents lblColumns As Label
    Friend WithEvents ucrReceiveColumns As ucrReceiverMultiple
    Friend WithEvents ucrBase As ucrButtons
End Class
