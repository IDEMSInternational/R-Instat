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
        Me.lblSelected = New System.Windows.Forms.Label()
        Me.rdoDispSepOutputWindow = New System.Windows.Forms.RadioButton()
        Me.rdoDispOutputWindow = New System.Windows.Forms.RadioButton()
        Me.rdoBottom = New System.Windows.Forms.RadioButton()
        Me.rdoTop = New System.Windows.Forms.RadioButton()
        Me.lblDisplayFrom = New System.Windows.Forms.Label()
        Me.lblNumberofRows = New System.Windows.Forms.Label()
        Me.ucrNudNumberRows = New instat.ucrNud()
        Me.ucrPnlDisplayFrom = New instat.UcrPanel()
        Me.ucrChkSpecifyRows = New instat.ucrCheck()
        Me.ucrPnlDisplayWindow = New instat.UcrPanel()
        Me.ucrReceiverView = New instat.ucrReceiverMultiple()
        Me.ucrSelectorForView = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblSelected
        '
        Me.lblSelected.AutoSize = True
        Me.lblSelected.Location = New System.Drawing.Point(248, 45)
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Size = New System.Drawing.Size(97, 13)
        Me.lblSelected.TabIndex = 1
        Me.lblSelected.Tag = ""
        Me.lblSelected.Text = "Variable(s) to View:"
        '
        'rdoDispSepOutputWindow
        '
        Me.rdoDispSepOutputWindow.AutoSize = True
        Me.rdoDispSepOutputWindow.Location = New System.Drawing.Point(10, 200)
        Me.rdoDispSepOutputWindow.Name = "rdoDispSepOutputWindow"
        Me.rdoDispSepOutputWindow.Size = New System.Drawing.Size(158, 17)
        Me.rdoDispSepOutputWindow.TabIndex = 3
        Me.rdoDispSepOutputWindow.TabStop = True
        Me.rdoDispSepOutputWindow.Text = "Display in Separate Window"
        Me.rdoDispSepOutputWindow.UseVisualStyleBackColor = True
        '
        'rdoDispOutputWindow
        '
        Me.rdoDispOutputWindow.AutoSize = True
        Me.rdoDispOutputWindow.Location = New System.Drawing.Point(10, 223)
        Me.rdoDispOutputWindow.Name = "rdoDispOutputWindow"
        Me.rdoDispOutputWindow.Size = New System.Drawing.Size(147, 17)
        Me.rdoDispOutputWindow.TabIndex = 4
        Me.rdoDispOutputWindow.TabStop = True
        Me.rdoDispOutputWindow.Text = "Display in Output Window"
        Me.rdoDispOutputWindow.UseVisualStyleBackColor = True
        '
        'rdoBottom
        '
        Me.rdoBottom.AutoSize = True
        Me.rdoBottom.Location = New System.Drawing.Point(325, 266)
        Me.rdoBottom.Name = "rdoBottom"
        Me.rdoBottom.Size = New System.Drawing.Size(58, 17)
        Me.rdoBottom.TabIndex = 10
        Me.rdoBottom.TabStop = True
        Me.rdoBottom.Text = "Bottom"
        Me.rdoBottom.UseVisualStyleBackColor = True
        '
        'rdoTop
        '
        Me.rdoTop.AutoSize = True
        Me.rdoTop.Location = New System.Drawing.Point(325, 243)
        Me.rdoTop.Name = "rdoTop"
        Me.rdoTop.Size = New System.Drawing.Size(44, 17)
        Me.rdoTop.TabIndex = 9
        Me.rdoTop.TabStop = True
        Me.rdoTop.Text = "Top"
        Me.rdoTop.UseVisualStyleBackColor = True
        '
        'lblDisplayFrom
        '
        Me.lblDisplayFrom.AutoSize = True
        Me.lblDisplayFrom.Location = New System.Drawing.Point(248, 244)
        Me.lblDisplayFrom.Name = "lblDisplayFrom"
        Me.lblDisplayFrom.Size = New System.Drawing.Size(70, 13)
        Me.lblDisplayFrom.TabIndex = 8
        Me.lblDisplayFrom.Tag = ""
        Me.lblDisplayFrom.Text = "Display From:"
        '
        'lblNumberofRows
        '
        Me.lblNumberofRows.AutoSize = True
        Me.lblNumberofRows.Location = New System.Drawing.Point(248, 223)
        Me.lblNumberofRows.Name = "lblNumberofRows"
        Me.lblNumberofRows.Size = New System.Drawing.Size(89, 13)
        Me.lblNumberofRows.TabIndex = 6
        Me.lblNumberofRows.Tag = "Number_of_rows"
        Me.lblNumberofRows.Text = "Number of Rows:"
        '
        'ucrNudNumberRows
        '
        Me.ucrNudNumberRows.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberRows.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNumberRows.Location = New System.Drawing.Point(343, 219)
        Me.ucrNudNumberRows.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNumberRows.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberRows.Name = "ucrNudNumberRows"
        Me.ucrNudNumberRows.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudNumberRows.TabIndex = 7
        Me.ucrNudNumberRows.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrPnlDisplayFrom
        '
        Me.ucrPnlDisplayFrom.Location = New System.Drawing.Point(325, 243)
        Me.ucrPnlDisplayFrom.Name = "ucrPnlDisplayFrom"
        Me.ucrPnlDisplayFrom.Size = New System.Drawing.Size(66, 40)
        Me.ucrPnlDisplayFrom.TabIndex = 16
        '
        'ucrChkSpecifyRows
        '
        Me.ucrChkSpecifyRows.Checked = False
        Me.ucrChkSpecifyRows.Location = New System.Drawing.Point(248, 200)
        Me.ucrChkSpecifyRows.Name = "ucrChkSpecifyRows"
        Me.ucrChkSpecifyRows.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkSpecifyRows.TabIndex = 5
        '
        'ucrPnlDisplayWindow
        '
        Me.ucrPnlDisplayWindow.Location = New System.Drawing.Point(10, 200)
        Me.ucrPnlDisplayWindow.Name = "ucrPnlDisplayWindow"
        Me.ucrPnlDisplayWindow.Size = New System.Drawing.Size(170, 46)
        Me.ucrPnlDisplayWindow.TabIndex = 6
        '
        'ucrReceiverView
        '
        Me.ucrReceiverView.frmParent = Me
        Me.ucrReceiverView.Location = New System.Drawing.Point(248, 60)
        Me.ucrReceiverView.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverView.Name = "ucrReceiverView"
        Me.ucrReceiverView.Selector = Nothing
        Me.ucrReceiverView.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverView.TabIndex = 2
        '
        'ucrSelectorForView
        '
        Me.ucrSelectorForView.bShowHiddenColumns = False
        Me.ucrSelectorForView.bUseCurrentFilter = True
        Me.ucrSelectorForView.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorForView.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForView.Name = "ucrSelectorForView"
        Me.ucrSelectorForView.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForView.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 289)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 11
        '
        'dlgView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 343)
        Me.Controls.Add(Me.ucrNudNumberRows)
        Me.Controls.Add(Me.rdoBottom)
        Me.Controls.Add(Me.rdoTop)
        Me.Controls.Add(Me.ucrPnlDisplayFrom)
        Me.Controls.Add(Me.ucrChkSpecifyRows)
        Me.Controls.Add(Me.lblDisplayFrom)
        Me.Controls.Add(Me.lblNumberofRows)
        Me.Controls.Add(Me.rdoDispOutputWindow)
        Me.Controls.Add(Me.rdoDispSepOutputWindow)
        Me.Controls.Add(Me.ucrPnlDisplayWindow)
        Me.Controls.Add(Me.lblSelected)
        Me.Controls.Add(Me.ucrReceiverView)
        Me.Controls.Add(Me.ucrSelectorForView)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "View Data"
        Me.Text = "View Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorForView As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverView As ucrReceiverMultiple
    Friend WithEvents lblSelected As Label
    Friend WithEvents rdoDispSepOutputWindow As RadioButton
    Friend WithEvents rdoDispOutputWindow As RadioButton
    Friend WithEvents ucrPnlDisplayWindow As UcrPanel
    Friend WithEvents ucrNudNumberRows As ucrNud
    Friend WithEvents rdoBottom As RadioButton
    Friend WithEvents rdoTop As RadioButton
    Friend WithEvents ucrPnlDisplayFrom As UcrPanel
    Friend WithEvents ucrChkSpecifyRows As ucrCheck
    Friend WithEvents lblDisplayFrom As Label
    Friend WithEvents lblNumberofRows As Label
End Class