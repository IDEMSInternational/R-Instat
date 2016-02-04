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
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorDataFrame = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverView = New instat.ucrReceiverMultiple()
        Me.lblSelected = New System.Windows.Forms.Label()
        Me.grpSpecifiedRows = New System.Windows.Forms.GroupBox()
        Me.rdoTop = New System.Windows.Forms.RadioButton()
        Me.rdoBottom = New System.Windows.Forms.RadioButton()
        Me.grpSpecifiedRows.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 257)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSelectorDataFrame
        '
        Me.ucrSelectorDataFrame.Location = New System.Drawing.Point(12, 12)
        Me.ucrSelectorDataFrame.Name = "ucrSelectorDataFrame"
        Me.ucrSelectorDataFrame.Size = New System.Drawing.Size(242, 179)
        Me.ucrSelectorDataFrame.TabIndex = 1
        '
        'ucrReceiverView
        '
        Me.ucrReceiverView.Location = New System.Drawing.Point(293, 84)
        Me.ucrReceiverView.Name = "ucrReceiverView"
        Me.ucrReceiverView.Size = New System.Drawing.Size(121, 104)
        Me.ucrReceiverView.TabIndex = 2
        '
        'lblSelected
        '
        Me.lblSelected.AutoSize = True
        Me.lblSelected.Location = New System.Drawing.Point(290, 68)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(49, 13)
        Me.lblSelected.TabIndex = 3
        Me.lblSelected.Tag = "Selected"
        Me.lblSelected.Text = "Selected"
        '
        'grpSpecifiedRows
        '
        Me.grpSpecifiedRows.Controls.Add(Me.rdoBottom)
        Me.grpSpecifiedRows.Controls.Add(Me.rdoTop)
        Me.grpSpecifiedRows.Location = New System.Drawing.Point(12, 197)
        Me.grpSpecifiedRows.Name = "grpSpecifiedRows"
        Me.grpSpecifiedRows.Size = New System.Drawing.Size(402, 54)
        Me.grpSpecifiedRows.TabIndex = 4
        Me.grpSpecifiedRows.TabStop = False
        Me.grpSpecifiedRows.Tag = "Specified_rows"
        Me.grpSpecifiedRows.Text = "Specified rows"
        '
        'rdoTop
        '
        Me.rdoTop.AutoSize = True
        Me.rdoTop.Location = New System.Drawing.Point(6, 19)
        Me.rdoTop.Name = "rdoTop"
        Me.rdoTop.Size = New System.Drawing.Size(44, 17)
        Me.rdoTop.TabIndex = 0
        Me.rdoTop.TabStop = True
        Me.rdoTop.Tag = "Top"
        Me.rdoTop.Text = "Top"
        Me.rdoTop.UseVisualStyleBackColor = True
        '
        'rdoBottom
        '
        Me.rdoBottom.AutoSize = True
        Me.rdoBottom.Location = New System.Drawing.Point(152, 19)
        Me.rdoBottom.Name = "rdoBottom"
        Me.rdoBottom.Size = New System.Drawing.Size(58, 17)
        Me.rdoBottom.TabIndex = 1
        Me.rdoBottom.TabStop = True
        Me.rdoBottom.Tag = "Bottom"
        Me.rdoBottom.Text = "Bottom"
        Me.rdoBottom.UseVisualStyleBackColor = True
        '
        'dlgView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 320)
        Me.Controls.Add(Me.grpSpecifiedRows)
        Me.Controls.Add(Me.lblSelected)
        Me.Controls.Add(Me.ucrReceiverView)
        Me.Controls.Add(Me.ucrSelectorDataFrame)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "View"
        Me.Text = "View"
        Me.grpSpecifiedRows.ResumeLayout(False)
        Me.grpSpecifiedRows.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorDataFrame As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverView As ucrReceiverMultiple
    Friend WithEvents lblSelected As Label
    Friend WithEvents grpSpecifiedRows As GroupBox
    Friend WithEvents rdoBottom As RadioButton
    Friend WithEvents rdoTop As RadioButton
End Class
