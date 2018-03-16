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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgViewGraph))
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
        resources.ApplyResources(Me.grpDisplayOptions, "grpDisplayOptions")
        Me.grpDisplayOptions.Name = "grpDisplayOptions"
        Me.grpDisplayOptions.TabStop = False
        '
        'rdoDisplayInteractiveView
        '
        resources.ApplyResources(Me.rdoDisplayInteractiveView, "rdoDisplayInteractiveView")
        Me.rdoDisplayInteractiveView.Name = "rdoDisplayInteractiveView"
        Me.rdoDisplayInteractiveView.TabStop = True
        Me.rdoDisplayInteractiveView.UseVisualStyleBackColor = True
        '
        'rdoDisplaySeparateWindow
        '
        resources.ApplyResources(Me.rdoDisplaySeparateWindow, "rdoDisplaySeparateWindow")
        Me.rdoDisplaySeparateWindow.Name = "rdoDisplaySeparateWindow"
        Me.rdoDisplaySeparateWindow.TabStop = True
        Me.rdoDisplaySeparateWindow.UseVisualStyleBackColor = True
        '
        'rdoDisplayRViewer
        '
        resources.ApplyResources(Me.rdoDisplayRViewer, "rdoDisplayRViewer")
        Me.rdoDisplayRViewer.Name = "rdoDisplayRViewer"
        Me.rdoDisplayRViewer.TabStop = True
        Me.rdoDisplayRViewer.UseVisualStyleBackColor = True
        '
        'rdoDisplayOutputWindow
        '
        resources.ApplyResources(Me.rdoDisplayOutputWindow, "rdoDisplayOutputWindow")
        Me.rdoDisplayOutputWindow.Name = "rdoDisplayOutputWindow"
        Me.rdoDisplayOutputWindow.TabStop = True
        Me.rdoDisplayOutputWindow.UseVisualStyleBackColor = True
        '
        'ucrPnlDisplayOptions
        '
        resources.ApplyResources(Me.ucrPnlDisplayOptions, "ucrPnlDisplayOptions")
        Me.ucrPnlDisplayOptions.Name = "ucrPnlDisplayOptions"
        '
        'lblGraphtoUse
        '
        resources.ApplyResources(Me.lblGraphtoUse, "lblGraphtoUse")
        Me.lblGraphtoUse.Name = "lblGraphtoUse"
        '
        'ucrGraphReceiver
        '
        Me.ucrGraphReceiver.frmParent = Me
        resources.ApplyResources(Me.ucrGraphReceiver, "ucrGraphReceiver")
        Me.ucrGraphReceiver.Name = "ucrGraphReceiver"
        Me.ucrGraphReceiver.Selector = Nothing
        Me.ucrGraphReceiver.strNcFilePath = ""
        Me.ucrGraphReceiver.ucrSelector = Nothing
        '
        'ucrGraphsSelector
        '
        Me.ucrGraphsSelector.bShowHiddenColumns = False
        Me.ucrGraphsSelector.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrGraphsSelector, "ucrGraphsSelector")
        Me.ucrGraphsSelector.Name = "ucrGraphsSelector"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgViewGraph
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrGraphReceiver)
        Me.Controls.Add(Me.lblGraphtoUse)
        Me.Controls.Add(Me.grpDisplayOptions)
        Me.Controls.Add(Me.ucrGraphsSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgViewGraph"
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
