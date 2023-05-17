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
Partial Class dlgCanonicalCorrelationAnalysis
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
        Me.lblYVariables = New System.Windows.Forms.Label()
        Me.lblXVariables = New System.Windows.Forms.Label()
        Me.ucrReceiverXVariables = New instat.ucrReceiverMultiple()
        Me.ucrReceiverYVariables = New instat.ucrReceiverMultiple()
        Me.ucrSelectorCCA = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSaveResult = New instat.ucrSave()
        Me.ucrChkCoefficients = New instat.ucrCheck()
        Me.grpGraphics = New System.Windows.Forms.GroupBox()
        Me.rdoYVariables = New System.Windows.Forms.RadioButton()
        Me.ucrChkPairwisePlot = New instat.ucrCheck()
        Me.rdoXVariables = New System.Windows.Forms.RadioButton()
        Me.ucrPnlVariables = New instat.UcrPanel()
        Me.grpGraphics.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblYVariables
        '
        Me.lblYVariables.AutoSize = True
        Me.lblYVariables.Location = New System.Drawing.Point(266, 168)
        Me.lblYVariables.Name = "lblYVariables"
        Me.lblYVariables.Size = New System.Drawing.Size(63, 13)
        Me.lblYVariables.TabIndex = 3
        Me.lblYVariables.Tag = "Y_Variables:"
        Me.lblYVariables.Text = "Y Variables:"
        '
        'lblXVariables
        '
        Me.lblXVariables.AutoSize = True
        Me.lblXVariables.Location = New System.Drawing.Point(266, 45)
        Me.lblXVariables.Name = "lblXVariables"
        Me.lblXVariables.Size = New System.Drawing.Size(63, 13)
        Me.lblXVariables.TabIndex = 1
        Me.lblXVariables.Tag = "X_Variables:"
        Me.lblXVariables.Text = "X Variables:"
        '
        'ucrReceiverXVariables
        '
        Me.ucrReceiverXVariables.AutoSize = True
        Me.ucrReceiverXVariables.frmParent = Me
        Me.ucrReceiverXVariables.Location = New System.Drawing.Point(266, 60)
        Me.ucrReceiverXVariables.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverXVariables.Name = "ucrReceiverXVariables"
        Me.ucrReceiverXVariables.Selector = Nothing
        Me.ucrReceiverXVariables.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverXVariables.strNcFilePath = ""
        Me.ucrReceiverXVariables.TabIndex = 2
        Me.ucrReceiverXVariables.ucrSelector = Nothing
        '
        'ucrReceiverYVariables
        '
        Me.ucrReceiverYVariables.AutoSize = True
        Me.ucrReceiverYVariables.frmParent = Me
        Me.ucrReceiverYVariables.Location = New System.Drawing.Point(266, 183)
        Me.ucrReceiverYVariables.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYVariables.Name = "ucrReceiverYVariables"
        Me.ucrReceiverYVariables.Selector = Nothing
        Me.ucrReceiverYVariables.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverYVariables.strNcFilePath = ""
        Me.ucrReceiverYVariables.TabIndex = 4
        Me.ucrReceiverYVariables.ucrSelector = Nothing
        '
        'ucrSelectorCCA
        '
        Me.ucrSelectorCCA.AutoSize = True
        Me.ucrSelectorCCA.bDropUnusedFilterLevels = False
        Me.ucrSelectorCCA.bShowHiddenColumns = False
        Me.ucrSelectorCCA.bUseCurrentFilter = True
        Me.ucrSelectorCCA.Location = New System.Drawing.Point(10, 9)
        Me.ucrSelectorCCA.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorCCA.Name = "ucrSelectorCCA"
        Me.ucrSelectorCCA.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorCCA.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(8, 366)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 7
        '
        'ucrSaveResult
        '
        Me.ucrSaveResult.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveResult.Location = New System.Drawing.Point(10, 336)
        Me.ucrSaveResult.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveResult.Name = "ucrSaveResult"
        Me.ucrSaveResult.Size = New System.Drawing.Size(278, 24)
        Me.ucrSaveResult.TabIndex = 5
        '
        'ucrChkCoefficients
        '
        Me.ucrChkCoefficients.AutoSize = True
        Me.ucrChkCoefficients.Checked = False
        Me.ucrChkCoefficients.Location = New System.Drawing.Point(17, 205)
        Me.ucrChkCoefficients.Name = "ucrChkCoefficients"
        Me.ucrChkCoefficients.Size = New System.Drawing.Size(184, 23)
        Me.ucrChkCoefficients.TabIndex = 8
        '
        'grpGraphics
        '
        Me.grpGraphics.Controls.Add(Me.rdoYVariables)
        Me.grpGraphics.Controls.Add(Me.ucrChkPairwisePlot)
        Me.grpGraphics.Controls.Add(Me.rdoXVariables)
        Me.grpGraphics.Controls.Add(Me.ucrPnlVariables)
        Me.grpGraphics.Location = New System.Drawing.Point(7, 234)
        Me.grpGraphics.Name = "grpGraphics"
        Me.grpGraphics.Size = New System.Drawing.Size(200, 100)
        Me.grpGraphics.TabIndex = 9
        Me.grpGraphics.TabStop = False
        Me.grpGraphics.Text = "Graphics"
        '
        'rdoYVariables
        '
        Me.rdoYVariables.AutoSize = True
        Me.rdoYVariables.Location = New System.Drawing.Point(46, 67)
        Me.rdoYVariables.Name = "rdoYVariables"
        Me.rdoYVariables.Size = New System.Drawing.Size(78, 17)
        Me.rdoYVariables.TabIndex = 3
        Me.rdoYVariables.Tag = "Y_Variables"
        Me.rdoYVariables.Text = "Y Variables"
        Me.rdoYVariables.UseVisualStyleBackColor = True
        '
        'ucrChkPairwisePlot
        '
        Me.ucrChkPairwisePlot.AutoSize = True
        Me.ucrChkPairwisePlot.Checked = False
        Me.ucrChkPairwisePlot.Location = New System.Drawing.Point(10, 18)
        Me.ucrChkPairwisePlot.Name = "ucrChkPairwisePlot"
        Me.ucrChkPairwisePlot.Size = New System.Drawing.Size(184, 23)
        Me.ucrChkPairwisePlot.TabIndex = 0
        '
        'rdoXVariables
        '
        Me.rdoXVariables.AutoSize = True
        Me.rdoXVariables.Location = New System.Drawing.Point(46, 44)
        Me.rdoXVariables.Name = "rdoXVariables"
        Me.rdoXVariables.Size = New System.Drawing.Size(78, 17)
        Me.rdoXVariables.TabIndex = 2
        Me.rdoXVariables.Tag = "X_Variables"
        Me.rdoXVariables.Text = "X Variables"
        Me.rdoXVariables.UseVisualStyleBackColor = True
        '
        'ucrPnlVariables
        '
        Me.ucrPnlVariables.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlVariables.Location = New System.Drawing.Point(36, 36)
        Me.ucrPnlVariables.Name = "ucrPnlVariables"
        Me.ucrPnlVariables.Size = New System.Drawing.Size(127, 58)
        Me.ucrPnlVariables.TabIndex = 1
        '
        'dlgCanonicalCorrelationAnalysis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(416, 421)
        Me.Controls.Add(Me.grpGraphics)
        Me.Controls.Add(Me.ucrChkCoefficients)
        Me.Controls.Add(Me.ucrSaveResult)
        Me.Controls.Add(Me.ucrReceiverYVariables)
        Me.Controls.Add(Me.ucrReceiverXVariables)
        Me.Controls.Add(Me.lblYVariables)
        Me.Controls.Add(Me.ucrSelectorCCA)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblXVariables)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCanonicalCorrelationAnalysis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Canonical_Correlation_Analysis"
        Me.Text = "Canonical Correlations"
        Me.grpGraphics.ResumeLayout(False)
        Me.grpGraphics.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorCCA As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverYVariables As ucrReceiverMultiple
    Friend WithEvents ucrReceiverXVariables As ucrReceiverMultiple
    Friend WithEvents lblYVariables As Label
    Friend WithEvents lblXVariables As Label
    Friend WithEvents ucrSaveResult As ucrSave
    Friend WithEvents ucrChkCoefficients As ucrCheck
    Friend WithEvents grpGraphics As GroupBox
    Friend WithEvents rdoYVariables As RadioButton
    Friend WithEvents ucrChkPairwisePlot As ucrCheck
    Friend WithEvents rdoXVariables As RadioButton
    Friend WithEvents ucrPnlVariables As UcrPanel
End Class