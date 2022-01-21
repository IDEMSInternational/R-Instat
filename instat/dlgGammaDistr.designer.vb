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
Partial Class dlgGammaDistr
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
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.grpColumns = New System.Windows.Forms.GroupBox()
        Me.rdoMultipleColumns = New System.Windows.Forms.RadioButton()
        Me.rdoSingleColumn = New System.Windows.Forms.RadioButton()
        Me.ucrReceiverColumn = New instat.ucrReceiverSingle()
        Me.lblSelectedColumn = New System.Windows.Forms.Label()
        Me.grpEstimationMethods = New System.Windows.Forms.GroupBox()
        Me.cboMethodOfMoments = New System.Windows.Forms.ComboBox()
        Me.cboMaximumLikelihood = New System.Windows.Forms.ComboBox()
        Me.lblSaveEstimates = New System.Windows.Forms.Label()
        Me.chkMethodOfMoments = New System.Windows.Forms.CheckBox()
        Me.chkMaximumLikelihood = New System.Windows.Forms.CheckBox()
        Me.chkRestrictValues = New System.Windows.Forms.CheckBox()
        Me.lblBetween = New System.Windows.Forms.Label()
        Me.lblAnd = New System.Windows.Forms.Label()
        Me.txtBetween = New System.Windows.Forms.TextBox()
        Me.txtAnd = New System.Windows.Forms.TextBox()
        Me.chkProbabilityPlot = New System.Windows.Forms.CheckBox()
        Me.grpColumns.SuspendLayout()
        Me.grpEstimationMethods.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(12, 295)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.AutoSize = True
        Me.ucrAddRemove.bShowHiddenColumns = False
        Me.ucrAddRemove.Location = New System.Drawing.Point(12, 44)
        Me.ucrAddRemove.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(213, 133)
        Me.ucrAddRemove.TabIndex = 1
        '
        'grpColumns
        '
        Me.grpColumns.Controls.Add(Me.rdoMultipleColumns)
        Me.grpColumns.Controls.Add(Me.rdoSingleColumn)
        Me.grpColumns.Location = New System.Drawing.Point(12, -1)
        Me.grpColumns.Name = "grpColumns"
        Me.grpColumns.Size = New System.Drawing.Size(392, 39)
        Me.grpColumns.TabIndex = 2
        Me.grpColumns.TabStop = False
        '
        'rdoMultipleColumns
        '
        Me.rdoMultipleColumns.AutoSize = True
        Me.rdoMultipleColumns.Location = New System.Drawing.Point(209, 13)
        Me.rdoMultipleColumns.Name = "rdoMultipleColumns"
        Me.rdoMultipleColumns.Size = New System.Drawing.Size(103, 17)
        Me.rdoMultipleColumns.TabIndex = 1
        Me.rdoMultipleColumns.TabStop = True
        Me.rdoMultipleColumns.Tag = "Multiple_columns"
        Me.rdoMultipleColumns.Text = "Multiple columns"
        Me.rdoMultipleColumns.UseVisualStyleBackColor = True
        '
        'rdoSingleColumn
        '
        Me.rdoSingleColumn.AutoSize = True
        Me.rdoSingleColumn.Location = New System.Drawing.Point(6, 13)
        Me.rdoSingleColumn.Name = "rdoSingleColumn"
        Me.rdoSingleColumn.Size = New System.Drawing.Size(91, 17)
        Me.rdoSingleColumn.TabIndex = 0
        Me.rdoSingleColumn.TabStop = True
        Me.rdoSingleColumn.Tag = "Single_column"
        Me.rdoSingleColumn.Text = "Single column"
        Me.rdoSingleColumn.UseVisualStyleBackColor = True
        '
        'ucrReceiverColumn
        '
        Me.ucrReceiverColumn.AutoSize = True
        Me.ucrReceiverColumn.frmParent = Me
        Me.ucrReceiverColumn.Location = New System.Drawing.Point(221, 60)
        Me.ucrReceiverColumn.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColumn.Name = "ucrReceiverColumn"
        Me.ucrReceiverColumn.Selector = Nothing
        Me.ucrReceiverColumn.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverColumn.strNcFilePath = ""
        Me.ucrReceiverColumn.TabIndex = 3
        Me.ucrReceiverColumn.ucrSelector = Nothing
        '
        'lblSelectedColumn
        '
        Me.lblSelectedColumn.AutoSize = True
        Me.lblSelectedColumn.Location = New System.Drawing.Point(221, 44)
        Me.lblSelectedColumn.Name = "lblSelectedColumn"
        Me.lblSelectedColumn.Size = New System.Drawing.Size(86, 13)
        Me.lblSelectedColumn.TabIndex = 4
        Me.lblSelectedColumn.Tag = "Selected_column"
        Me.lblSelectedColumn.Text = "Selected column"
        '
        'grpEstimationMethods
        '
        Me.grpEstimationMethods.Controls.Add(Me.cboMethodOfMoments)
        Me.grpEstimationMethods.Controls.Add(Me.cboMaximumLikelihood)
        Me.grpEstimationMethods.Controls.Add(Me.lblSaveEstimates)
        Me.grpEstimationMethods.Controls.Add(Me.chkMethodOfMoments)
        Me.grpEstimationMethods.Controls.Add(Me.chkMaximumLikelihood)
        Me.grpEstimationMethods.Location = New System.Drawing.Point(18, 177)
        Me.grpEstimationMethods.Name = "grpEstimationMethods"
        Me.grpEstimationMethods.Size = New System.Drawing.Size(241, 91)
        Me.grpEstimationMethods.TabIndex = 5
        Me.grpEstimationMethods.TabStop = False
        Me.grpEstimationMethods.Tag = "Estimation_methods"
        Me.grpEstimationMethods.Text = "Estimation methods"
        '
        'cboMethodOfMoments
        '
        Me.cboMethodOfMoments.FormattingEnabled = True
        Me.cboMethodOfMoments.Location = New System.Drawing.Point(147, 65)
        Me.cboMethodOfMoments.Name = "cboMethodOfMoments"
        Me.cboMethodOfMoments.Size = New System.Drawing.Size(84, 21)
        Me.cboMethodOfMoments.TabIndex = 4
        '
        'cboMaximumLikelihood
        '
        Me.cboMaximumLikelihood.FormattingEnabled = True
        Me.cboMaximumLikelihood.Location = New System.Drawing.Point(147, 32)
        Me.cboMaximumLikelihood.Name = "cboMaximumLikelihood"
        Me.cboMaximumLikelihood.Size = New System.Drawing.Size(84, 21)
        Me.cboMaximumLikelihood.TabIndex = 3
        '
        'lblSaveEstimates
        '
        Me.lblSaveEstimates.AutoSize = True
        Me.lblSaveEstimates.Location = New System.Drawing.Point(144, 16)
        Me.lblSaveEstimates.Name = "lblSaveEstimates"
        Me.lblSaveEstimates.Size = New System.Drawing.Size(90, 13)
        Me.lblSaveEstimates.TabIndex = 2
        Me.lblSaveEstimates.Tag = "Save_estimates_in"
        Me.lblSaveEstimates.Text = "Save estimates in"
        '
        'chkMethodOfMoments
        '
        Me.chkMethodOfMoments.AutoSize = True
        Me.chkMethodOfMoments.Location = New System.Drawing.Point(6, 65)
        Me.chkMethodOfMoments.Name = "chkMethodOfMoments"
        Me.chkMethodOfMoments.Size = New System.Drawing.Size(119, 17)
        Me.chkMethodOfMoments.TabIndex = 1
        Me.chkMethodOfMoments.Tag = "Method_of_moments"
        Me.chkMethodOfMoments.Text = "Method of moments"
        Me.chkMethodOfMoments.UseVisualStyleBackColor = True
        '
        'chkMaximumLikelihood
        '
        Me.chkMaximumLikelihood.AutoSize = True
        Me.chkMaximumLikelihood.Location = New System.Drawing.Point(6, 32)
        Me.chkMaximumLikelihood.Name = "chkMaximumLikelihood"
        Me.chkMaximumLikelihood.Size = New System.Drawing.Size(117, 17)
        Me.chkMaximumLikelihood.TabIndex = 0
        Me.chkMaximumLikelihood.Tag = "Maximum_likelihood_"
        Me.chkMaximumLikelihood.Text = "Maximum likelihood"
        Me.chkMaximumLikelihood.UseVisualStyleBackColor = True
        '
        'chkRestrictValues
        '
        Me.chkRestrictValues.AutoSize = True
        Me.chkRestrictValues.Location = New System.Drawing.Point(249, 104)
        Me.chkRestrictValues.Name = "chkRestrictValues"
        Me.chkRestrictValues.Size = New System.Drawing.Size(120, 17)
        Me.chkRestrictValues.TabIndex = 6
        Me.chkRestrictValues.Tag = "Restrict_data_values"
        Me.chkRestrictValues.Text = "Restrict data values"
        Me.chkRestrictValues.UseVisualStyleBackColor = True
        '
        'lblBetween
        '
        Me.lblBetween.AutoSize = True
        Me.lblBetween.Location = New System.Drawing.Point(259, 132)
        Me.lblBetween.Name = "lblBetween"
        Me.lblBetween.Size = New System.Drawing.Size(48, 13)
        Me.lblBetween.TabIndex = 7
        Me.lblBetween.Tag = "between"
        Me.lblBetween.Text = "between"
        '
        'lblAnd
        '
        Me.lblAnd.AutoSize = True
        Me.lblAnd.Location = New System.Drawing.Point(352, 132)
        Me.lblAnd.Name = "lblAnd"
        Me.lblAnd.Size = New System.Drawing.Size(25, 13)
        Me.lblAnd.TabIndex = 8
        Me.lblAnd.Tag = "and"
        Me.lblAnd.Text = "and"
        '
        'txtBetween
        '
        Me.txtBetween.Location = New System.Drawing.Point(313, 129)
        Me.txtBetween.Name = "txtBetween"
        Me.txtBetween.Size = New System.Drawing.Size(33, 20)
        Me.txtBetween.TabIndex = 9
        '
        'txtAnd
        '
        Me.txtAnd.Location = New System.Drawing.Point(383, 128)
        Me.txtAnd.Name = "txtAnd"
        Me.txtAnd.Size = New System.Drawing.Size(35, 20)
        Me.txtAnd.TabIndex = 10
        '
        'chkProbabilityPlot
        '
        Me.chkProbabilityPlot.AutoSize = True
        Me.chkProbabilityPlot.Location = New System.Drawing.Point(279, 193)
        Me.chkProbabilityPlot.Name = "chkProbabilityPlot"
        Me.chkProbabilityPlot.Size = New System.Drawing.Size(94, 17)
        Me.chkProbabilityPlot.TabIndex = 11
        Me.chkProbabilityPlot.Tag = "Probability_plot"
        Me.chkProbabilityPlot.Text = "Probability plot"
        Me.chkProbabilityPlot.UseVisualStyleBackColor = True
        '
        'dlgGammaDistr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(429, 350)
        Me.Controls.Add(Me.chkProbabilityPlot)
        Me.Controls.Add(Me.txtAnd)
        Me.Controls.Add(Me.txtBetween)
        Me.Controls.Add(Me.lblAnd)
        Me.Controls.Add(Me.lblBetween)
        Me.Controls.Add(Me.chkRestrictValues)
        Me.Controls.Add(Me.grpEstimationMethods)
        Me.Controls.Add(Me.lblSelectedColumn)
        Me.Controls.Add(Me.ucrReceiverColumn)
        Me.Controls.Add(Me.grpColumns)
        Me.Controls.Add(Me.ucrAddRemove)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgGammaDistr"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Fit_a_Gamma_distribution"
        Me.Text = "Fit a Gamma Distribution"
        Me.grpColumns.ResumeLayout(False)
        Me.grpColumns.PerformLayout()
        Me.grpEstimationMethods.ResumeLayout(False)
        Me.grpEstimationMethods.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents grpColumns As GroupBox
    Friend WithEvents ucrReceiverColumn As ucrReceiverSingle
    Friend WithEvents lblSelectedColumn As Label
    Friend WithEvents rdoMultipleColumns As RadioButton
    Friend WithEvents rdoSingleColumn As RadioButton
    Friend WithEvents grpEstimationMethods As GroupBox
    Friend WithEvents lblSaveEstimates As Label
    Friend WithEvents chkMethodOfMoments As CheckBox
    Friend WithEvents chkMaximumLikelihood As CheckBox
    Friend WithEvents cboMethodOfMoments As ComboBox
    Friend WithEvents cboMaximumLikelihood As ComboBox
    Friend WithEvents chkRestrictValues As CheckBox
    Friend WithEvents lblBetween As Label
    Friend WithEvents lblAnd As Label
    Friend WithEvents txtBetween As TextBox
    Friend WithEvents txtAnd As TextBox
    Friend WithEvents chkProbabilityPlot As CheckBox
End Class
