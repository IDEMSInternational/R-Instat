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
Partial Class dlgCompareModels
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
        Me.ucrDistributionForCompareModels = New instat.ucrDistributionsWithParameters()
        Me.grpPlotGraphs = New System.Windows.Forms.GroupBox()
        Me.nudNumberofColumns = New System.Windows.Forms.NumericUpDown()
        Me.lblNumberofColumns = New System.Windows.Forms.Label()
        Me.rdoCombine = New System.Windows.Forms.RadioButton()
        Me.rdoSingle = New System.Windows.Forms.RadioButton()
        Me.cmdAddNewDistributions = New System.Windows.Forms.Button()
        Me.grpPlotOptions = New System.Windows.Forms.GroupBox()
        Me.rdoDensity = New System.Windows.Forms.RadioButton()
        Me.rdoqq = New System.Windows.Forms.RadioButton()
        Me.rdoCDF = New System.Windows.Forms.RadioButton()
        Me.rdoHistogram = New System.Windows.Forms.RadioButton()
        Me.grpChangeLimits = New System.Windows.Forms.GroupBox()
        Me.nudYlimMax = New System.Windows.Forms.NumericUpDown()
        Me.nudXlimMax = New System.Windows.Forms.NumericUpDown()
        Me.nudYlimMin = New System.Windows.Forms.NumericUpDown()
        Me.nudXlimMin = New System.Windows.Forms.NumericUpDown()
        Me.lblYlim = New System.Windows.Forms.Label()
        Me.lblXlim = New System.Windows.Forms.Label()
        Me.grpPlotGraphs.SuspendLayout()
        CType(Me.nudNumberofColumns, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPlotOptions.SuspendLayout()
        Me.grpChangeLimits.SuspendLayout()
        CType(Me.nudYlimMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudXlimMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudYlimMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudXlimMin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(12, 320)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrDistributionForCompareModels
        '
        Me.ucrDistributionForCompareModels.AutoSize = True
        Me.ucrDistributionForCompareModels.Location = New System.Drawing.Point(13, 13)
        Me.ucrDistributionForCompareModels.Name = "ucrDistributionForCompareModels"
        Me.ucrDistributionForCompareModels.Size = New System.Drawing.Size(1037, 194)
        Me.ucrDistributionForCompareModels.TabIndex = 1
        '
        'grpPlotGraphs
        '
        Me.grpPlotGraphs.Controls.Add(Me.nudNumberofColumns)
        Me.grpPlotGraphs.Controls.Add(Me.lblNumberofColumns)
        Me.grpPlotGraphs.Controls.Add(Me.rdoCombine)
        Me.grpPlotGraphs.Controls.Add(Me.rdoSingle)
        Me.grpPlotGraphs.Location = New System.Drawing.Point(14, 202)
        Me.grpPlotGraphs.Name = "grpPlotGraphs"
        Me.grpPlotGraphs.Size = New System.Drawing.Size(238, 73)
        Me.grpPlotGraphs.TabIndex = 2
        Me.grpPlotGraphs.TabStop = False
        Me.grpPlotGraphs.Text = "Plot Graph"
        '
        'nudNumberofColumns
        '
        Me.nudNumberofColumns.Location = New System.Drawing.Point(184, 44)
        Me.nudNumberofColumns.Name = "nudNumberofColumns"
        Me.nudNumberofColumns.Size = New System.Drawing.Size(48, 20)
        Me.nudNumberofColumns.TabIndex = 3
        '
        'lblNumberofColumns
        '
        Me.lblNumberofColumns.AutoSize = True
        Me.lblNumberofColumns.Location = New System.Drawing.Point(79, 46)
        Me.lblNumberofColumns.Name = "lblNumberofColumns"
        Me.lblNumberofColumns.Size = New System.Drawing.Size(99, 13)
        Me.lblNumberofColumns.TabIndex = 2
        Me.lblNumberofColumns.Text = "Number of Columns"
        '
        'rdoCombine
        '
        Me.rdoCombine.AutoSize = True
        Me.rdoCombine.Location = New System.Drawing.Point(7, 44)
        Me.rdoCombine.Name = "rdoCombine"
        Me.rdoCombine.Size = New System.Drawing.Size(66, 17)
        Me.rdoCombine.TabIndex = 1
        Me.rdoCombine.TabStop = True
        Me.rdoCombine.Text = "Combine"
        Me.rdoCombine.UseVisualStyleBackColor = True
        '
        'rdoSingle
        '
        Me.rdoSingle.AutoSize = True
        Me.rdoSingle.Location = New System.Drawing.Point(7, 20)
        Me.rdoSingle.Name = "rdoSingle"
        Me.rdoSingle.Size = New System.Drawing.Size(54, 17)
        Me.rdoSingle.TabIndex = 0
        Me.rdoSingle.TabStop = True
        Me.rdoSingle.Text = "Single"
        Me.rdoSingle.UseVisualStyleBackColor = True
        '
        'cmdAddNewDistributions
        '
        Me.cmdAddNewDistributions.Location = New System.Drawing.Point(13, 282)
        Me.cmdAddNewDistributions.Name = "cmdAddNewDistributions"
        Me.cmdAddNewDistributions.Size = New System.Drawing.Size(128, 23)
        Me.cmdAddNewDistributions.TabIndex = 3
        Me.cmdAddNewDistributions.Text = "Add New Distribution"
        Me.cmdAddNewDistributions.UseVisualStyleBackColor = True
        '
        'grpPlotOptions
        '
        Me.grpPlotOptions.Controls.Add(Me.rdoDensity)
        Me.grpPlotOptions.Controls.Add(Me.rdoqq)
        Me.grpPlotOptions.Controls.Add(Me.rdoCDF)
        Me.grpPlotOptions.Controls.Add(Me.rdoHistogram)
        Me.grpPlotOptions.Location = New System.Drawing.Point(240, 12)
        Me.grpPlotOptions.Name = "grpPlotOptions"
        Me.grpPlotOptions.Size = New System.Drawing.Size(171, 103)
        Me.grpPlotOptions.TabIndex = 4
        Me.grpPlotOptions.TabStop = False
        '
        'rdoDensity
        '
        Me.rdoDensity.AutoSize = True
        Me.rdoDensity.Location = New System.Drawing.Point(6, 10)
        Me.rdoDensity.Name = "rdoDensity"
        Me.rdoDensity.Size = New System.Drawing.Size(60, 17)
        Me.rdoDensity.TabIndex = 6
        Me.rdoDensity.TabStop = True
        Me.rdoDensity.Text = "Density"
        Me.rdoDensity.UseVisualStyleBackColor = True
        '
        'rdoqq
        '
        Me.rdoqq.AutoSize = True
        Me.rdoqq.Location = New System.Drawing.Point(6, 79)
        Me.rdoqq.Name = "rdoqq"
        Me.rdoqq.Size = New System.Drawing.Size(37, 17)
        Me.rdoqq.TabIndex = 5
        Me.rdoqq.TabStop = True
        Me.rdoqq.Text = "qq"
        Me.rdoqq.UseVisualStyleBackColor = True
        '
        'rdoCDF
        '
        Me.rdoCDF.AutoSize = True
        Me.rdoCDF.Location = New System.Drawing.Point(6, 56)
        Me.rdoCDF.Name = "rdoCDF"
        Me.rdoCDF.Size = New System.Drawing.Size(46, 17)
        Me.rdoCDF.TabIndex = 4
        Me.rdoCDF.TabStop = True
        Me.rdoCDF.Text = "CDF"
        Me.rdoCDF.UseVisualStyleBackColor = True
        '
        'rdoHistogram
        '
        Me.rdoHistogram.AutoSize = True
        Me.rdoHistogram.Location = New System.Drawing.Point(6, 33)
        Me.rdoHistogram.Name = "rdoHistogram"
        Me.rdoHistogram.Size = New System.Drawing.Size(72, 17)
        Me.rdoHistogram.TabIndex = 3
        Me.rdoHistogram.TabStop = True
        Me.rdoHistogram.Text = "Histogram"
        Me.rdoHistogram.UseVisualStyleBackColor = True
        '
        'grpChangeLimits
        '
        Me.grpChangeLimits.Controls.Add(Me.nudYlimMax)
        Me.grpChangeLimits.Controls.Add(Me.nudXlimMax)
        Me.grpChangeLimits.Controls.Add(Me.nudYlimMin)
        Me.grpChangeLimits.Controls.Add(Me.nudXlimMin)
        Me.grpChangeLimits.Controls.Add(Me.lblYlim)
        Me.grpChangeLimits.Controls.Add(Me.lblXlim)
        Me.grpChangeLimits.Location = New System.Drawing.Point(240, 124)
        Me.grpChangeLimits.Name = "grpChangeLimits"
        Me.grpChangeLimits.Size = New System.Drawing.Size(171, 83)
        Me.grpChangeLimits.TabIndex = 5
        Me.grpChangeLimits.TabStop = False
        Me.grpChangeLimits.Text = "Change Limits"
        '
        'nudYlimMax
        '
        Me.nudYlimMax.Location = New System.Drawing.Point(107, 44)
        Me.nudYlimMax.Name = "nudYlimMax"
        Me.nudYlimMax.Size = New System.Drawing.Size(45, 20)
        Me.nudYlimMax.TabIndex = 5
        '
        'nudXlimMax
        '
        Me.nudXlimMax.Location = New System.Drawing.Point(108, 20)
        Me.nudXlimMax.Name = "nudXlimMax"
        Me.nudXlimMax.Size = New System.Drawing.Size(44, 20)
        Me.nudXlimMax.TabIndex = 4
        '
        'nudYlimMin
        '
        Me.nudYlimMin.Location = New System.Drawing.Point(51, 44)
        Me.nudYlimMin.Name = "nudYlimMin"
        Me.nudYlimMin.Size = New System.Drawing.Size(45, 20)
        Me.nudYlimMin.TabIndex = 3
        '
        'nudXlimMin
        '
        Me.nudXlimMin.Location = New System.Drawing.Point(52, 20)
        Me.nudXlimMin.Name = "nudXlimMin"
        Me.nudXlimMin.Size = New System.Drawing.Size(44, 20)
        Me.nudXlimMin.TabIndex = 2
        '
        'lblYlim
        '
        Me.lblYlim.AutoSize = True
        Me.lblYlim.Location = New System.Drawing.Point(0, 46)
        Me.lblYlim.Name = "lblYlim"
        Me.lblYlim.Size = New System.Drawing.Size(26, 13)
        Me.lblYlim.TabIndex = 1
        Me.lblYlim.Text = "Ylim"
        '
        'lblXlim
        '
        Me.lblXlim.AutoSize = True
        Me.lblXlim.Location = New System.Drawing.Point(0, 20)
        Me.lblXlim.Name = "lblXlim"
        Me.lblXlim.Size = New System.Drawing.Size(26, 13)
        Me.lblXlim.TabIndex = 0
        Me.lblXlim.Text = "Xlim"
        '
        'dlgCompareModels
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(436, 384)
        Me.Controls.Add(Me.grpChangeLimits)
        Me.Controls.Add(Me.grpPlotOptions)
        Me.Controls.Add(Me.cmdAddNewDistributions)
        Me.Controls.Add(Me.grpPlotGraphs)
        Me.Controls.Add(Me.ucrDistributionForCompareModels)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCompareModels"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compare Models"
        Me.grpPlotGraphs.ResumeLayout(False)
        Me.grpPlotGraphs.PerformLayout()
        CType(Me.nudNumberofColumns, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPlotOptions.ResumeLayout(False)
        Me.grpPlotOptions.PerformLayout()
        Me.grpChangeLimits.ResumeLayout(False)
        Me.grpChangeLimits.PerformLayout()
        CType(Me.nudYlimMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudXlimMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudYlimMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudXlimMin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrDistributionForCompareModels As ucrDistributionsWithParameters
    Friend WithEvents grpPlotGraphs As GroupBox
    Friend WithEvents nudNumberofColumns As NumericUpDown
    Friend WithEvents lblNumberofColumns As Label
    Friend WithEvents rdoCombine As RadioButton
    Friend WithEvents rdoSingle As RadioButton
    Friend WithEvents cmdAddNewDistributions As Button
    Friend WithEvents grpPlotOptions As GroupBox
    Friend WithEvents grpChangeLimits As GroupBox
    Friend WithEvents nudYlimMax As NumericUpDown
    Friend WithEvents nudXlimMax As NumericUpDown
    Friend WithEvents nudYlimMin As NumericUpDown
    Friend WithEvents nudXlimMin As NumericUpDown
    Friend WithEvents lblYlim As Label
    Friend WithEvents lblXlim As Label
    Friend WithEvents rdoDensity As RadioButton
    Friend WithEvents rdoqq As RadioButton
    Friend WithEvents rdoCDF As RadioButton
    Friend WithEvents rdoHistogram As RadioButton
End Class
