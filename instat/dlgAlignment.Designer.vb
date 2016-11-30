<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgAlignment
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
        Me.lstAlignment = New System.Windows.Forms.ListBox()
        Me.lblAlignment = New System.Windows.Forms.Label()
        Me.lblColumnWidth = New System.Windows.Forms.Label()
        Me.txtColumnWidth = New System.Windows.Forms.TextBox()
        Me.lblSelectedColumns = New System.Windows.Forms.Label()
        Me.ucrMultiple = New instat.ucrReceiverMultiple()
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lstAlignment
        '
        Me.lstAlignment.FormattingEnabled = True
        Me.lstAlignment.Items.AddRange(New Object() {"Left", "Centre", "Right", "General"})
        Me.lstAlignment.Location = New System.Drawing.Point(366, 29)
        Me.lstAlignment.Name = "lstAlignment"
        Me.lstAlignment.Size = New System.Drawing.Size(108, 56)
        Me.lstAlignment.TabIndex = 1
        '
        'lblAlignment
        '
        Me.lblAlignment.AutoSize = True
        Me.lblAlignment.Location = New System.Drawing.Point(366, 10)
        Me.lblAlignment.Name = "lblAlignment"
        Me.lblAlignment.Size = New System.Drawing.Size(53, 13)
        Me.lblAlignment.TabIndex = 3
        Me.lblAlignment.Tag = "Alignment"
        Me.lblAlignment.Text = "Alignment"
        '
        'lblColumnWidth
        '
        Me.lblColumnWidth.AutoSize = True
        Me.lblColumnWidth.Location = New System.Drawing.Point(363, 96)
        Me.lblColumnWidth.Name = "lblColumnWidth"
        Me.lblColumnWidth.Size = New System.Drawing.Size(70, 13)
        Me.lblColumnWidth.TabIndex = 4
        Me.lblColumnWidth.Tag = "Column_width"
        Me.lblColumnWidth.Text = "Column width"
        '
        'txtColumnWidth
        '
        Me.txtColumnWidth.Location = New System.Drawing.Point(440, 92)
        Me.txtColumnWidth.Name = "txtColumnWidth"
        Me.txtColumnWidth.Size = New System.Drawing.Size(34, 20)
        Me.txtColumnWidth.TabIndex = 5
        '
        'lblSelectedColumns
        '
        Me.lblSelectedColumns.AutoSize = True
        Me.lblSelectedColumns.Location = New System.Drawing.Point(232, 10)
        Me.lblSelectedColumns.Name = "lblSelectedColumns"
        Me.lblSelectedColumns.Size = New System.Drawing.Size(92, 13)
        Me.lblSelectedColumns.TabIndex = 7
        Me.lblSelectedColumns.Tag = "Selected_Columns"
        Me.lblSelectedColumns.Text = "Selected Columns"
        '
        'ucrMultiple
        '
        Me.ucrMultiple.Location = New System.Drawing.Point(239, 23)
        Me.ucrMultiple.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrMultiple.Name = "ucrMultiple"
        Me.ucrMultiple.Selector = Nothing
        Me.ucrMultiple.Size = New System.Drawing.Size(127, 106)
        Me.ucrMultiple.TabIndex = 6
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.bShowHiddenColumns = False
        Me.ucrAddRemove.Location = New System.Drawing.Point(10, 10)
        Me.ucrAddRemove.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Padding = New System.Windows.Forms.Padding(10)
        Me.ucrAddRemove.Size = New System.Drawing.Size(226, 127)
        Me.ucrAddRemove.TabIndex = 2
        Me.ucrAddRemove.Tag = "Format_current_or_selected_columns"
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(33, 152)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 8
        '
        'dlgAlignment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 217)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblSelectedColumns)
        Me.Controls.Add(Me.ucrMultiple)
        Me.Controls.Add(Me.txtColumnWidth)
        Me.Controls.Add(Me.lblColumnWidth)
        Me.Controls.Add(Me.lblAlignment)
        Me.Controls.Add(Me.ucrAddRemove)
        Me.Controls.Add(Me.lstAlignment)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgAlignment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Format_current_or_selected_columns"
        Me.Text = "Format current or selected columns"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstAlignment As ListBox
    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents lblAlignment As Label
    Friend WithEvents lblColumnWidth As Label
    Friend WithEvents txtColumnWidth As TextBox
    Friend WithEvents ucrMultiple As ucrReceiverMultiple
    Friend WithEvents lblSelectedColumns As Label
    Friend WithEvents ucrBase As ucrButtons
End Class
