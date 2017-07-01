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
Partial Class dlgProbabilityPlot
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
        Me.grpDistributions = New System.Windows.Forms.GroupBox()
        Me.rdoExtrmeValue = New System.Windows.Forms.RadioButton()
        Me.rdoExponential = New System.Windows.Forms.RadioButton()
        Me.rdoEmperical = New System.Windows.Forms.RadioButton()
        Me.rdoGamma = New System.Windows.Forms.RadioButton()
        Me.rdoNormal = New System.Windows.Forms.RadioButton()
        Me.ucrBase = New instat.ucrButtons()
        Me.lblVariableToPlot = New System.Windows.Forms.Label()
        Me.ucrReceiverPlotVariable = New instat.ucrReceiverSingle()
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.grpDistributions.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpDistributions
        '
        Me.grpDistributions.Controls.Add(Me.rdoExtrmeValue)
        Me.grpDistributions.Controls.Add(Me.rdoExponential)
        Me.grpDistributions.Controls.Add(Me.rdoEmperical)
        Me.grpDistributions.Controls.Add(Me.rdoGamma)
        Me.grpDistributions.Controls.Add(Me.rdoNormal)
        Me.grpDistributions.Location = New System.Drawing.Point(215, 67)
        Me.grpDistributions.Name = "grpDistributions"
        Me.grpDistributions.Size = New System.Drawing.Size(181, 90)
        Me.grpDistributions.TabIndex = 1
        Me.grpDistributions.TabStop = False
        Me.grpDistributions.Tag = "Distributions"
        Me.grpDistributions.Text = "Distributions"
        '
        'rdoExtrmeValue
        '
        Me.rdoExtrmeValue.AutoSize = True
        Me.rdoExtrmeValue.Location = New System.Drawing.Point(6, 65)
        Me.rdoExtrmeValue.Name = "rdoExtrmeValue"
        Me.rdoExtrmeValue.Size = New System.Drawing.Size(93, 17)
        Me.rdoExtrmeValue.TabIndex = 0
        Me.rdoExtrmeValue.TabStop = True
        Me.rdoExtrmeValue.Tag = "Extreme_Value"
        Me.rdoExtrmeValue.Text = "Extreme Value"
        Me.rdoExtrmeValue.UseVisualStyleBackColor = True
        '
        'rdoExponential
        '
        Me.rdoExponential.AutoSize = True
        Me.rdoExponential.Location = New System.Drawing.Point(87, 42)
        Me.rdoExponential.Name = "rdoExponential"
        Me.rdoExponential.Size = New System.Drawing.Size(83, 17)
        Me.rdoExponential.TabIndex = 0
        Me.rdoExponential.TabStop = True
        Me.rdoExponential.Tag = "Exponential"
        Me.rdoExponential.Text = "Exponential "
        Me.rdoExponential.UseVisualStyleBackColor = True
        '
        'rdoEmperical
        '
        Me.rdoEmperical.AutoSize = True
        Me.rdoEmperical.Location = New System.Drawing.Point(87, 19)
        Me.rdoEmperical.Name = "rdoEmperical"
        Me.rdoEmperical.Size = New System.Drawing.Size(71, 17)
        Me.rdoEmperical.TabIndex = 0
        Me.rdoEmperical.TabStop = True
        Me.rdoEmperical.Tag = "Emperical"
        Me.rdoEmperical.Text = "Emperical"
        Me.rdoEmperical.UseVisualStyleBackColor = True
        '
        'rdoGamma
        '
        Me.rdoGamma.AutoSize = True
        Me.rdoGamma.Location = New System.Drawing.Point(6, 42)
        Me.rdoGamma.Name = "rdoGamma"
        Me.rdoGamma.Size = New System.Drawing.Size(64, 17)
        Me.rdoGamma.TabIndex = 0
        Me.rdoGamma.TabStop = True
        Me.rdoGamma.Tag = "Gamma"
        Me.rdoGamma.Text = "Gamma "
        Me.rdoGamma.UseVisualStyleBackColor = True
        '
        'rdoNormal
        '
        Me.rdoNormal.AutoSize = True
        Me.rdoNormal.Location = New System.Drawing.Point(6, 19)
        Me.rdoNormal.Name = "rdoNormal"
        Me.rdoNormal.Size = New System.Drawing.Size(58, 17)
        Me.rdoNormal.TabIndex = 0
        Me.rdoNormal.TabStop = True
        Me.rdoNormal.Tag = "Normal"
        Me.rdoNormal.Text = "Normal"
        Me.rdoNormal.UseVisualStyleBackColor = True
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(-1, 157)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 54)
        Me.ucrBase.TabIndex = 0
        '
        'lblVariableToPlot
        '
        Me.lblVariableToPlot.AutoSize = True
        Me.lblVariableToPlot.Location = New System.Drawing.Point(218, 5)
        Me.lblVariableToPlot.Name = "lblVariableToPlot"
        Me.lblVariableToPlot.Size = New System.Drawing.Size(78, 13)
        Me.lblVariableToPlot.TabIndex = 8
        Me.lblVariableToPlot.Tag = "Variable_to_Plot"
        Me.lblVariableToPlot.Text = "Variable to Plot"
        '
        'ucrReceiverPlotVariable
        '
        Me.ucrReceiverPlotVariable.Location = New System.Drawing.Point(216, 29)
        Me.ucrReceiverPlotVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverPlotVariable.Name = "ucrReceiverPlotVariable"
        Me.ucrReceiverPlotVariable.Selector = Nothing
        Me.ucrReceiverPlotVariable.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverPlotVariable.TabIndex = 7
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.bShowHiddenColumns = False
        Me.ucrAddRemove.Location = New System.Drawing.Point(7, 3)
        Me.ucrAddRemove.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(202, 154)
        Me.ucrAddRemove.TabIndex = 6
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(302, 5)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(100, 20)
        Me.txtTitle.TabIndex = 9
        '
        'dlgProbabilityPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 212)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.lblVariableToPlot)
        Me.Controls.Add(Me.ucrReceiverPlotVariable)
        Me.Controls.Add(Me.ucrAddRemove)
        Me.Controls.Add(Me.grpDistributions)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgProbabilityPlot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Probability_Plot"
        Me.Text = "Probability Plot"
        Me.grpDistributions.ResumeLayout(False)
        Me.grpDistributions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents grpDistributions As GroupBox
    Friend WithEvents rdoExtrmeValue As RadioButton
    Friend WithEvents rdoExponential As RadioButton
    Friend WithEvents rdoEmperical As RadioButton
    Friend WithEvents rdoGamma As RadioButton
    Friend WithEvents rdoNormal As RadioButton
    Friend WithEvents lblVariableToPlot As Label
    Friend WithEvents ucrReceiverPlotVariable As ucrReceiverSingle
    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents txtTitle As TextBox
End Class
