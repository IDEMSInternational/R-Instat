<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgView
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
        Me.ucrSelectorForView = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverView = New instat.ucrReceiverMultiple()
        Me.lblSelected = New System.Windows.Forms.Label()
        Me.grpSelectedRows = New System.Windows.Forms.GroupBox()
        Me.txtBottom = New System.Windows.Forms.TextBox()
        Me.txtTop = New System.Windows.Forms.TextBox()
        Me.rdoBottom = New System.Windows.Forms.RadioButton()
        Me.rdoTop = New System.Windows.Forms.RadioButton()
        Me.grpSelectedRows.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrSelectorForView
        '
        Me.ucrSelectorForView.Location = New System.Drawing.Point(13, 13)
        Me.ucrSelectorForView.Name = "ucrSelectorForView"
        Me.ucrSelectorForView.Size = New System.Drawing.Size(242, 179)
        Me.ucrSelectorForView.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(13, 269)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(401, 53)
        Me.ucrBase.TabIndex = 1
        '
        'ucrReceiverView
        '
        Me.ucrReceiverView.Location = New System.Drawing.Point(261, 88)
        Me.ucrReceiverView.Name = "ucrReceiverView"
        Me.ucrReceiverView.Selector = Nothing
        Me.ucrReceiverView.Size = New System.Drawing.Size(121, 104)
        Me.ucrReceiverView.TabIndex = 2
        '
        'lblSelected
        '
        Me.lblSelected.AutoSize = True
        Me.lblSelected.Location = New System.Drawing.Point(262, 69)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(49, 13)
        Me.lblSelected.TabIndex = 3
        Me.lblSelected.Tag = "Selected"
        Me.lblSelected.Text = "Selected"
        '
        'grpSelectedRows
        '
        Me.grpSelectedRows.Controls.Add(Me.txtBottom)
        Me.grpSelectedRows.Controls.Add(Me.txtTop)
        Me.grpSelectedRows.Controls.Add(Me.rdoBottom)
        Me.grpSelectedRows.Controls.Add(Me.rdoTop)
        Me.grpSelectedRows.Location = New System.Drawing.Point(13, 199)
        Me.grpSelectedRows.Name = "grpSelectedRows"
        Me.grpSelectedRows.Size = New System.Drawing.Size(401, 52)
        Me.grpSelectedRows.TabIndex = 4
        Me.grpSelectedRows.TabStop = False
        Me.grpSelectedRows.Tag = "Display_specified_rows"
        Me.grpSelectedRows.Text = "Display specified rows"
        '
        'txtBottom
        '
        Me.txtBottom.Location = New System.Drawing.Point(330, 20)
        Me.txtBottom.Name = "txtBottom"
        Me.txtBottom.Size = New System.Drawing.Size(40, 20)
        Me.txtBottom.TabIndex = 3
        '
        'txtTop
        '
        Me.txtTop.Location = New System.Drawing.Point(121, 19)
        Me.txtTop.Name = "txtTop"
        Me.txtTop.Size = New System.Drawing.Size(40, 20)
        Me.txtTop.TabIndex = 2
        '
        'rdoBottom
        '
        Me.rdoBottom.AutoSize = True
        Me.rdoBottom.Location = New System.Drawing.Point(233, 19)
        Me.rdoBottom.Name = "rdoBottom"
        Me.rdoBottom.Size = New System.Drawing.Size(58, 17)
        Me.rdoBottom.TabIndex = 1
        Me.rdoBottom.TabStop = True
        Me.rdoBottom.Tag = "Bottom"
        Me.rdoBottom.Text = "Bottom"
        Me.rdoBottom.UseVisualStyleBackColor = True
        '
        'rdoTop
        '
        Me.rdoTop.AutoSize = True
        Me.rdoTop.Location = New System.Drawing.Point(24, 20)
        Me.rdoTop.Name = "rdoTop"
        Me.rdoTop.Size = New System.Drawing.Size(44, 17)
        Me.rdoTop.TabIndex = 0
        Me.rdoTop.TabStop = True
        Me.rdoTop.Tag = "Top"
        Me.rdoTop.Text = "Top"
        Me.rdoTop.UseVisualStyleBackColor = True
        '
        'dlgView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 334)
        Me.Controls.Add(Me.grpSelectedRows)
        Me.Controls.Add(Me.lblSelected)
        Me.Controls.Add(Me.ucrReceiverView)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorForView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "View"
        Me.Text = "View"
        Me.grpSelectedRows.ResumeLayout(False)
        Me.grpSelectedRows.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorForView As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverView As ucrReceiverMultiple
    Friend WithEvents lblSelected As Label
    Friend WithEvents grpSelectedRows As GroupBox
    Friend WithEvents rdoBottom As RadioButton
    Friend WithEvents rdoTop As RadioButton
    Friend WithEvents txtBottom As TextBox
    Friend WithEvents txtTop As TextBox
End Class
