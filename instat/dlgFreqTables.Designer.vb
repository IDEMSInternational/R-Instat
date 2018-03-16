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
Partial Class dlgFreqTables
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
        Me.lblFactors = New System.Windows.Forms.Label()
        Me.grpDisplay = New System.Windows.Forms.GroupBox()
        Me.cboPercentFactor = New System.Windows.Forms.ComboBox()
        Me.rdoPercentFactor = New System.Windows.Forms.RadioButton()
        Me.rdoPercentOverallTotal = New System.Windows.Forms.RadioButton()
        Me.rdoCounts = New System.Windows.Forms.RadioButton()
        Me.chkWeights = New System.Windows.Forms.CheckBox()
        Me.cboWeights = New System.Windows.Forms.ComboBox()
        Me.grpDisplayMargins = New System.Windows.Forms.GroupBox()
        Me.lblSelectedVariables = New System.Windows.Forms.Label()
        Me.ucrReceiverMultiple = New instat.ucrReceiverMultiple()
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpDisplay.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFactors
        '
        Me.lblFactors.AutoSize = True
        Me.lblFactors.Location = New System.Drawing.Point(9, 12)
        Me.lblFactors.Name = "lblFactors"
        Me.lblFactors.Size = New System.Drawing.Size(42, 13)
        Me.lblFactors.TabIndex = 2
        Me.lblFactors.Tag = "Factors"
        Me.lblFactors.Text = "Factors"
        '
        'grpDisplay
        '
        Me.grpDisplay.Controls.Add(Me.cboPercentFactor)
        Me.grpDisplay.Controls.Add(Me.rdoPercentFactor)
        Me.grpDisplay.Controls.Add(Me.rdoPercentOverallTotal)
        Me.grpDisplay.Controls.Add(Me.rdoCounts)
        Me.grpDisplay.Location = New System.Drawing.Point(12, 183)
        Me.grpDisplay.Name = "grpDisplay"
        Me.grpDisplay.Size = New System.Drawing.Size(226, 117)
        Me.grpDisplay.TabIndex = 4
        Me.grpDisplay.TabStop = False
        Me.grpDisplay.Tag = "Display"
        Me.grpDisplay.Text = "Display"
        '
        'cboPercentFactor
        '
        Me.cboPercentFactor.FormattingEnabled = True
        Me.cboPercentFactor.Location = New System.Drawing.Point(140, 95)
        Me.cboPercentFactor.Name = "cboPercentFactor"
        Me.cboPercentFactor.Size = New System.Drawing.Size(80, 21)
        Me.cboPercentFactor.TabIndex = 3
        '
        'rdoPercentFactor
        '
        Me.rdoPercentFactor.AutoSize = True
        Me.rdoPercentFactor.Location = New System.Drawing.Point(12, 99)
        Me.rdoPercentFactor.Name = "rdoPercentFactor"
        Me.rdoPercentFactor.Size = New System.Drawing.Size(122, 17)
        Me.rdoPercentFactor.TabIndex = 2
        Me.rdoPercentFactor.TabStop = True
        Me.rdoPercentFactor.Tag = "Percentage_of_factor"
        Me.rdoPercentFactor.Text = "Percentage of factor"
        Me.rdoPercentFactor.UseVisualStyleBackColor = True
        '
        'rdoPercentOverallTotal
        '
        Me.rdoPercentOverallTotal.AutoSize = True
        Me.rdoPercentOverallTotal.Location = New System.Drawing.Point(12, 67)
        Me.rdoPercentOverallTotal.Name = "rdoPercentOverallTotal"
        Me.rdoPercentOverallTotal.Size = New System.Drawing.Size(154, 17)
        Me.rdoPercentOverallTotal.TabIndex = 1
        Me.rdoPercentOverallTotal.TabStop = True
        Me.rdoPercentOverallTotal.Tag = "Percentages_of_overall_total"
        Me.rdoPercentOverallTotal.Text = "Percentages of overall total"
        Me.rdoPercentOverallTotal.UseVisualStyleBackColor = True
        '
        'rdoCounts
        '
        Me.rdoCounts.AutoSize = True
        Me.rdoCounts.Location = New System.Drawing.Point(12, 33)
        Me.rdoCounts.Name = "rdoCounts"
        Me.rdoCounts.Size = New System.Drawing.Size(58, 17)
        Me.rdoCounts.TabIndex = 0
        Me.rdoCounts.TabStop = True
        Me.rdoCounts.Tag = "Counts"
        Me.rdoCounts.Text = "Counts"
        Me.rdoCounts.UseVisualStyleBackColor = True
        '
        'chkWeights
        '
        Me.chkWeights.AutoSize = True
        Me.chkWeights.Location = New System.Drawing.Point(340, 47)
        Me.chkWeights.Name = "chkWeights"
        Me.chkWeights.Size = New System.Drawing.Size(65, 17)
        Me.chkWeights.TabIndex = 5
        Me.chkWeights.Tag = "Weights"
        Me.chkWeights.Text = "Weights"
        Me.chkWeights.UseVisualStyleBackColor = True
        '
        'cboWeights
        '
        Me.cboWeights.FormattingEnabled = True
        Me.cboWeights.Location = New System.Drawing.Point(413, 45)
        Me.cboWeights.Name = "cboWeights"
        Me.cboWeights.Size = New System.Drawing.Size(83, 21)
        Me.cboWeights.TabIndex = 6
        '
        'grpDisplayMargins
        '
        Me.grpDisplayMargins.Location = New System.Drawing.Point(244, 187)
        Me.grpDisplayMargins.Name = "grpDisplayMargins"
        Me.grpDisplayMargins.Size = New System.Drawing.Size(200, 117)
        Me.grpDisplayMargins.TabIndex = 7
        Me.grpDisplayMargins.TabStop = False
        Me.grpDisplayMargins.Tag = "Display_Margins"
        Me.grpDisplayMargins.Text = "Display Margins"
        '
        'lblSelectedVariables
        '
        Me.lblSelectedVariables.AutoSize = True
        Me.lblSelectedVariables.Location = New System.Drawing.Point(212, 30)
        Me.lblSelectedVariables.Name = "lblSelectedVariables"
        Me.lblSelectedVariables.Size = New System.Drawing.Size(95, 13)
        Me.lblSelectedVariables.TabIndex = 8
        Me.lblSelectedVariables.Tag = "Selected_Variable"
        Me.lblSelectedVariables.Text = "Selected Variables"
        '
        'ucrReceiverMultiple
        '
        Me.ucrReceiverMultiple.Location = New System.Drawing.Point(205, 45)
        Me.ucrReceiverMultiple.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultiple.Name = "ucrReceiverMultiple"
        Me.ucrReceiverMultiple.Selector = Nothing
        Me.ucrReceiverMultiple.Size = New System.Drawing.Size(127, 136)
        Me.ucrReceiverMultiple.TabIndex = 3
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.bShowHiddenColumns = False
        Me.ucrAddRemove.Location = New System.Drawing.Point(-2, 28)
        Me.ucrAddRemove.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(204, 132)
        Me.ucrAddRemove.TabIndex = 1
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(51, 310)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 55)
        Me.ucrBase.TabIndex = 0
        '
        'dlgFreqTables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 366)
        Me.Controls.Add(Me.lblSelectedVariables)
        Me.Controls.Add(Me.grpDisplayMargins)
        Me.Controls.Add(Me.cboWeights)
        Me.Controls.Add(Me.chkWeights)
        Me.Controls.Add(Me.grpDisplay)
        Me.Controls.Add(Me.ucrReceiverMultiple)
        Me.Controls.Add(Me.lblFactors)
        Me.Controls.Add(Me.ucrAddRemove)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgFreqTables"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Frequency_table"
        Me.Text = "Frequency Tables"
        Me.grpDisplay.ResumeLayout(False)
        Me.grpDisplay.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents lblFactors As Label
    Friend WithEvents ucrReceiverMultiple As ucrReceiverMultiple
    Friend WithEvents grpDisplay As GroupBox
    Friend WithEvents rdoPercentFactor As RadioButton
    Friend WithEvents rdoPercentOverallTotal As RadioButton
    Friend WithEvents rdoCounts As RadioButton
    Friend WithEvents chkWeights As CheckBox
    Friend WithEvents cboWeights As ComboBox
    Friend WithEvents grpDisplayMargins As GroupBox
    Friend WithEvents lblSelectedVariables As Label
    Friend WithEvents cboPercentFactor As ComboBox
End Class
