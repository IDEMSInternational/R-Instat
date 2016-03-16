﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgView
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
        Me.grpDisplayFrom = New System.Windows.Forms.GroupBox()
        Me.rdoBottom = New System.Windows.Forms.RadioButton()
        Me.rdoTop = New System.Windows.Forms.RadioButton()
        Me.nudNumberRows = New System.Windows.Forms.NumericUpDown()
        Me.lblSelected = New System.Windows.Forms.Label()
        Me.lblNumberofRows = New System.Windows.Forms.Label()
        Me.ucrReceiverView = New instat.ucrReceiverMultiple()
        Me.ucrSelctorForView = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpDisplayFrom.SuspendLayout()
        CType(Me.nudNumberRows, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpDisplayFrom
        '
        Me.grpDisplayFrom.Controls.Add(Me.rdoBottom)
        Me.grpDisplayFrom.Controls.Add(Me.rdoTop)
        Me.grpDisplayFrom.Location = New System.Drawing.Point(3, 220)
        Me.grpDisplayFrom.Name = "grpDisplayFrom"
        Me.grpDisplayFrom.Size = New System.Drawing.Size(112, 87)
        Me.grpDisplayFrom.TabIndex = 4
        Me.grpDisplayFrom.TabStop = False
        Me.grpDisplayFrom.Tag = "Display_from"
        Me.grpDisplayFrom.Text = "Display from"
        '
        'rdoBottom
        '
        Me.rdoBottom.AutoSize = True
        Me.rdoBottom.Location = New System.Drawing.Point(11, 52)
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
        Me.rdoTop.Location = New System.Drawing.Point(11, 22)
        Me.rdoTop.Name = "rdoTop"
        Me.rdoTop.Size = New System.Drawing.Size(44, 17)
        Me.rdoTop.TabIndex = 0
        Me.rdoTop.TabStop = True
        Me.rdoTop.Tag = "Top"
        Me.rdoTop.Text = "Top"
        Me.rdoTop.UseVisualStyleBackColor = True
        '
        'nudNumberRows
        '
        Me.nudNumberRows.Location = New System.Drawing.Point(126, 187)
        Me.nudNumberRows.Maximum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.nudNumberRows.Name = "nudNumberRows"
        Me.nudNumberRows.Size = New System.Drawing.Size(73, 20)
        Me.nudNumberRows.TabIndex = 4
        '
        'lblSelected
        '
        Me.lblSelected.AutoSize = True
        Me.lblSelected.Location = New System.Drawing.Point(265, 56)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(49, 13)
        Me.lblSelected.TabIndex = 7
        Me.lblSelected.Tag = "Selected"
        Me.lblSelected.Text = "Selected"
        '
        'lblNumberofRows
        '
        Me.lblNumberofRows.AutoSize = True
        Me.lblNumberofRows.Location = New System.Drawing.Point(2, 189)
        Me.lblNumberofRows.Name = "lblNumberofRows"
        Me.lblNumberofRows.Size = New System.Drawing.Size(89, 13)
        Me.lblNumberofRows.TabIndex = 8
        Me.lblNumberofRows.Tag = "Number_of_rows"
        Me.lblNumberofRows.Text = "Number  of Rows"
        '
        'ucrReceiverView
        '
        Me.ucrReceiverView.Location = New System.Drawing.Point(258, 69)
        Me.ucrReceiverView.Name = "ucrReceiverView"
        Me.ucrReceiverView.Selector = Nothing
        Me.ucrReceiverView.Size = New System.Drawing.Size(121, 104)
        Me.ucrReceiverView.TabIndex = 6
        '
        'ucrSelctorForView
        '
        Me.ucrSelctorForView.Location = New System.Drawing.Point(2, 2)
        Me.ucrSelctorForView.Name = "ucrSelctorForView"
        Me.ucrSelctorForView.Size = New System.Drawing.Size(242, 179)
        Me.ucrSelctorForView.TabIndex = 5
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(1, 316)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(401, 53)
        Me.ucrBase.TabIndex = 1
        '
        'dlgView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 368)
        Me.Controls.Add(Me.lblNumberofRows)
        Me.Controls.Add(Me.lblSelected)
        Me.Controls.Add(Me.nudNumberRows)
        Me.Controls.Add(Me.ucrReceiverView)
        Me.Controls.Add(Me.ucrSelctorForView)
        Me.Controls.Add(Me.grpDisplayFrom)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "View"
        Me.Text = "View"
        Me.grpDisplayFrom.ResumeLayout(False)
        Me.grpDisplayFrom.PerformLayout()
        CType(Me.nudNumberRows, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents grpDisplayFrom As GroupBox
    Friend WithEvents rdoBottom As RadioButton
    Friend WithEvents rdoTop As RadioButton
    Friend WithEvents ucrSelctorForView As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverView As ucrReceiverMultiple
    Friend WithEvents lblSelected As Label
    Friend WithEvents nudNumberRows As NumericUpDown
    Friend WithEvents lblNumberofRows As Label
End Class
