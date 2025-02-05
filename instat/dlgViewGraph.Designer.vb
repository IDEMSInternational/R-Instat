' R- Instat
' Copyright (C) 2015-2017
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.rdoMaximised = New System.Windows.Forms.RadioButton()
        Me.rdoInteractiveView = New System.Windows.Forms.RadioButton()
        Me.rdoRViewer = New System.Windows.Forms.RadioButton()
        Me.rdoOutputWindow = New System.Windows.Forms.RadioButton()
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
        Me.grpDisplayOptions.Controls.Add(Me.rdoMaximised)
        Me.grpDisplayOptions.Controls.Add(Me.rdoInteractiveView)
        Me.grpDisplayOptions.Controls.Add(Me.rdoRViewer)
        Me.grpDisplayOptions.Controls.Add(Me.rdoOutputWindow)
        Me.grpDisplayOptions.Controls.Add(Me.ucrPnlDisplayOptions)
        Me.grpDisplayOptions.Location = New System.Drawing.Point(246, 90)
        Me.grpDisplayOptions.Name = "grpDisplayOptions"
        Me.grpDisplayOptions.Size = New System.Drawing.Size(217, 124)
        Me.grpDisplayOptions.TabIndex = 3
        Me.grpDisplayOptions.TabStop = False
        Me.grpDisplayOptions.Text = "Display Options"
        '
        'rdoMaximised
        '
        Me.rdoMaximised.AutoSize = True
        Me.rdoMaximised.Location = New System.Drawing.Point(9, 43)
        Me.rdoMaximised.Name = "rdoMaximised"
        Me.rdoMaximised.Size = New System.Drawing.Size(113, 17)
        Me.rdoMaximised.TabIndex = 4
        Me.rdoMaximised.TabStop = True
        Me.rdoMaximised.Text = "Maximised window"
        Me.rdoMaximised.UseVisualStyleBackColor = True
        '
        'rdoInteractiveView
        '
        Me.rdoInteractiveView.AutoSize = True
        Me.rdoInteractiveView.Location = New System.Drawing.Point(9, 65)
        Me.rdoInteractiveView.Name = "rdoInteractiveView"
        Me.rdoInteractiveView.Size = New System.Drawing.Size(140, 17)
        Me.rdoInteractiveView.TabIndex = 1
        Me.rdoInteractiveView.TabStop = True
        Me.rdoInteractiveView.Text = "Interactive viewer(Plotly)"
        Me.rdoInteractiveView.UseVisualStyleBackColor = True
        '
        'rdoRViewer
        '
        Me.rdoRViewer.AutoSize = True
        Me.rdoRViewer.Location = New System.Drawing.Point(9, 87)
        Me.rdoRViewer.Name = "rdoRViewer"
        Me.rdoRViewer.Size = New System.Drawing.Size(68, 17)
        Me.rdoRViewer.TabIndex = 2
        Me.rdoRViewer.TabStop = True
        Me.rdoRViewer.Text = "R-Viewer"
        Me.rdoRViewer.UseVisualStyleBackColor = True
        '
        'rdoOutputWindow
        '
        Me.rdoOutputWindow.AutoSize = True
        Me.rdoOutputWindow.Location = New System.Drawing.Point(9, 22)
        Me.rdoOutputWindow.Name = "rdoOutputWindow"
        Me.rdoOutputWindow.Size = New System.Drawing.Size(96, 17)
        Me.rdoOutputWindow.TabIndex = 3
        Me.rdoOutputWindow.TabStop = True
        Me.rdoOutputWindow.Text = "Output window"
        Me.rdoOutputWindow.UseVisualStyleBackColor = True
        '
        'ucrPnlDisplayOptions
        '
        Me.ucrPnlDisplayOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlDisplayOptions.Location = New System.Drawing.Point(6, 19)
        Me.ucrPnlDisplayOptions.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrPnlDisplayOptions.Name = "ucrPnlDisplayOptions"
        Me.ucrPnlDisplayOptions.Size = New System.Drawing.Size(203, 99)
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
        Me.ucrGraphReceiver.AutoSize = True
        Me.ucrGraphReceiver.frmParent = Me
        Me.ucrGraphReceiver.Location = New System.Drawing.Point(250, 60)
        Me.ucrGraphReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrGraphReceiver.Name = "ucrGraphReceiver"
        Me.ucrGraphReceiver.Selector = Nothing
        Me.ucrGraphReceiver.Size = New System.Drawing.Size(120, 20)
        Me.ucrGraphReceiver.strNcFilePath = ""
        Me.ucrGraphReceiver.TabIndex = 2
        Me.ucrGraphReceiver.ucrSelector = Nothing
        '
        'ucrGraphsSelector
        '
        Me.ucrGraphsSelector.AutoSize = True
        Me.ucrGraphsSelector.bDropUnusedFilterLevels = False
        Me.ucrGraphsSelector.bShowHiddenColumns = False
        Me.ucrGraphsSelector.bUseCurrentFilter = True
        Me.ucrGraphsSelector.Location = New System.Drawing.Point(10, 10)
        Me.ucrGraphsSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrGraphsSelector.Name = "ucrGraphsSelector"
        Me.ucrGraphsSelector.Size = New System.Drawing.Size(213, 183)
        Me.ucrGraphsSelector.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 220)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 4
        '
        'dlgViewGraph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(471, 276)
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
    Friend WithEvents rdoRViewer As RadioButton
    Friend WithEvents rdoOutputWindow As RadioButton
    Friend WithEvents ucrPnlDisplayOptions As UcrPanel
    Friend WithEvents rdoInteractiveView As RadioButton
    Friend WithEvents lblGraphtoUse As Label
    Friend WithEvents ucrGraphReceiver As ucrReceiverSingle
    Friend WithEvents rdoMaximised As RadioButton
End Class
