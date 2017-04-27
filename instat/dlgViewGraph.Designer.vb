﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgViewGraph
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
        Me.grpDisplayOptions = New System.Windows.Forms.GroupBox()
        Me.rdoDisplayInteractiveView = New System.Windows.Forms.RadioButton()
        Me.rdoDisplaySeparateWindow = New System.Windows.Forms.RadioButton()
        Me.rdoDisplayRViewer = New System.Windows.Forms.RadioButton()
        Me.rdoDisplayOutputWindow = New System.Windows.Forms.RadioButton()
        Me.ucrPnlDisplayOptions = New instat.UcrPanel()
        Me.lblGraphtoUse = New System.Windows.Forms.Label()
        Me.ucrGraphReceiver = New instat.ucrReceiverSingle()
        Me.ucrGraphsSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpDisplayOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpDisplayOptions
        '
        Me.grpDisplayOptions.Controls.Add(Me.rdoDisplayInteractiveView)
        Me.grpDisplayOptions.Controls.Add(Me.rdoDisplaySeparateWindow)
        Me.grpDisplayOptions.Controls.Add(Me.rdoDisplayRViewer)
        Me.grpDisplayOptions.Controls.Add(Me.rdoDisplayOutputWindow)
        Me.grpDisplayOptions.Controls.Add(Me.ucrPnlDisplayOptions)
        Me.grpDisplayOptions.Location = New System.Drawing.Point(250, 90)
        Me.grpDisplayOptions.Name = "grpDisplayOptions"
        Me.grpDisplayOptions.Size = New System.Drawing.Size(171, 124)
        Me.grpDisplayOptions.TabIndex = 3
        Me.grpDisplayOptions.TabStop = False
        Me.grpDisplayOptions.Text = "Display Options"
        '
        'rdoDisplayInteractiveView
        '
        Me.rdoDisplayInteractiveView.AutoSize = True
        Me.rdoDisplayInteractiveView.Location = New System.Drawing.Point(9, 22)
        Me.rdoDisplayInteractiveView.Name = "rdoDisplayInteractiveView"
        Me.rdoDisplayInteractiveView.Size = New System.Drawing.Size(158, 17)
        Me.rdoDisplayInteractiveView.TabIndex = 1
        Me.rdoDisplayInteractiveView.TabStop = True
        Me.rdoDisplayInteractiveView.Text = "Display in Interactive Viewer"
        Me.rdoDisplayInteractiveView.UseVisualStyleBackColor = True
        '
        'rdoDisplaySeparateWindow
        '
        Me.rdoDisplaySeparateWindow.AutoSize = True
        Me.rdoDisplaySeparateWindow.Location = New System.Drawing.Point(9, 91)
        Me.rdoDisplaySeparateWindow.Name = "rdoDisplaySeparateWindow"
        Me.rdoDisplaySeparateWindow.Size = New System.Drawing.Size(158, 17)
        Me.rdoDisplaySeparateWindow.TabIndex = 4
        Me.rdoDisplaySeparateWindow.TabStop = True
        Me.rdoDisplaySeparateWindow.Text = "Display in Separate Window"
        Me.rdoDisplaySeparateWindow.UseVisualStyleBackColor = True
        '
        'rdoDisplayRViewer
        '
        Me.rdoDisplayRViewer.AutoSize = True
        Me.rdoDisplayRViewer.Location = New System.Drawing.Point(9, 45)
        Me.rdoDisplayRViewer.Name = "rdoDisplayRViewer"
        Me.rdoDisplayRViewer.Size = New System.Drawing.Size(116, 17)
        Me.rdoDisplayRViewer.TabIndex = 2
        Me.rdoDisplayRViewer.TabStop = True
        Me.rdoDisplayRViewer.Text = "Display in R-Viewer"
        Me.rdoDisplayRViewer.UseVisualStyleBackColor = True
        '
        'rdoDisplayOutputWindow
        '
        Me.rdoDisplayOutputWindow.AutoSize = True
        Me.rdoDisplayOutputWindow.Location = New System.Drawing.Point(9, 68)
        Me.rdoDisplayOutputWindow.Name = "rdoDisplayOutputWindow"
        Me.rdoDisplayOutputWindow.Size = New System.Drawing.Size(147, 17)
        Me.rdoDisplayOutputWindow.TabIndex = 3
        Me.rdoDisplayOutputWindow.TabStop = True
        Me.rdoDisplayOutputWindow.Text = "Display in Output Window"
        Me.rdoDisplayOutputWindow.UseVisualStyleBackColor = True
        '
        'ucrPnlDisplayOptions
        '
        Me.ucrPnlDisplayOptions.Location = New System.Drawing.Point(6, 19)
        Me.ucrPnlDisplayOptions.Name = "ucrPnlDisplayOptions"
        Me.ucrPnlDisplayOptions.Size = New System.Drawing.Size(159, 99)
        Me.ucrPnlDisplayOptions.TabIndex = 0
        '
        'lblGraphtoUse
        '
        Me.lblGraphtoUse.AutoSize = True
        Me.lblGraphtoUse.Location = New System.Drawing.Point(250, 45)
        Me.lblGraphtoUse.Name = "lblGraphtoUse"
        Me.lblGraphtoUse.Size = New System.Drawing.Size(77, 13)
        Me.lblGraphtoUse.TabIndex = 1
        Me.lblGraphtoUse.Text = "Graph to View:"
        '
        'ucrGraphReceiver
        '
        Me.ucrGraphReceiver.frmParent = Me
        Me.ucrGraphReceiver.Location = New System.Drawing.Point(250, 60)
        Me.ucrGraphReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrGraphReceiver.Name = "ucrGraphReceiver"
        Me.ucrGraphReceiver.Selector = Nothing
        Me.ucrGraphReceiver.Size = New System.Drawing.Size(120, 20)
        Me.ucrGraphReceiver.TabIndex = 2
        Me.ucrGraphReceiver.ucrSelector = Nothing
        '
        'ucrGraphsSelector
        '
        Me.ucrGraphsSelector.bShowHiddenColumns = False
        Me.ucrGraphsSelector.bUseCurrentFilter = True
        Me.ucrGraphsSelector.Location = New System.Drawing.Point(10, 10)
        Me.ucrGraphsSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrGraphsSelector.Name = "ucrGraphsSelector"
        Me.ucrGraphsSelector.Size = New System.Drawing.Size(210, 180)
        Me.ucrGraphsSelector.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 220)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 4
        '
        'dlgViewGraph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 276)
        Me.Controls.Add(Me.ucrGraphReceiver)
        Me.Controls.Add(Me.lblGraphtoUse)
        Me.Controls.Add(Me.grpDisplayOptions)
        Me.Controls.Add(Me.ucrGraphsSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgViewGraph"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Graph"
        Me.grpDisplayOptions.ResumeLayout(False)
        Me.grpDisplayOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrGraphsSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents grpDisplayOptions As GroupBox
    Friend WithEvents rdoDisplaySeparateWindow As RadioButton
    Friend WithEvents rdoDisplayRViewer As RadioButton
    Friend WithEvents rdoDisplayOutputWindow As RadioButton
    Friend WithEvents ucrPnlDisplayOptions As UcrPanel
    Friend WithEvents rdoDisplayInteractiveView As RadioButton
    Friend WithEvents lblGraphtoUse As Label
    Friend WithEvents ucrGraphReceiver As ucrReceiverSingle
End Class
