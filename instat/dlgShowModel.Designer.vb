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
Partial Class dlgShowModel
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
        Me.lblQuantValues = New System.Windows.Forms.Label()
        Me.lblProbValues = New System.Windows.Forms.Label()
        Me.ucrDistributionsFOrTablePlus = New instat.ucrDistributionsWithParameters()
        Me.ucrSelectorForDataFrame = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverExpressionForTablePlus = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInputProbabilities = New instat.ucrInputComboBox()
        Me.rdoProbabilities = New System.Windows.Forms.RadioButton()
        Me.rdoQuantiles = New System.Windows.Forms.RadioButton()
        Me.ucrPnlDistTypes = New instat.UcrPanel()
        Me.ucrChkDisplayGraphResults = New instat.ucrCheck()
        Me.ucrChkEnterValues = New instat.ucrCheck()
        Me.ucrSaveGraphResults = New instat.ucrSave()
        Me.SuspendLayout()
        '
        'lblQuantValues
        '
        Me.lblQuantValues.AutoSize = True
        Me.lblQuantValues.Location = New System.Drawing.Point(243, 49)
        Me.lblQuantValues.Name = "lblQuantValues"
        Me.lblQuantValues.Size = New System.Drawing.Size(39, 13)
        Me.lblQuantValues.TabIndex = 8
        Me.lblQuantValues.Text = "Values"
        '
        'lblProbValues
        '
        Me.lblProbValues.AutoSize = True
        Me.lblProbValues.Location = New System.Drawing.Point(243, 49)
        Me.lblProbValues.Name = "lblProbValues"
        Me.lblProbValues.Size = New System.Drawing.Size(63, 13)
        Me.lblProbValues.TabIndex = 4
        Me.lblProbValues.Text = "Probabilities"
        '
        'ucrDistributionsFOrTablePlus
        '
        Me.ucrDistributionsFOrTablePlus.Location = New System.Drawing.Point(246, 97)
        Me.ucrDistributionsFOrTablePlus.Name = "ucrDistributionsFOrTablePlus"
        Me.ucrDistributionsFOrTablePlus.Size = New System.Drawing.Size(247, 185)
        Me.ucrDistributionsFOrTablePlus.TabIndex = 6
        '
        'ucrSelectorForDataFrame
        '
        Me.ucrSelectorForDataFrame.bShowHiddenColumns = False
        Me.ucrSelectorForDataFrame.bUseCurrentFilter = True
        Me.ucrSelectorForDataFrame.Location = New System.Drawing.Point(9, 49)
        Me.ucrSelectorForDataFrame.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForDataFrame.Name = "ucrSelectorForDataFrame"
        Me.ucrSelectorForDataFrame.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForDataFrame.TabIndex = 3
        '
        'ucrReceiverExpressionForTablePlus
        '
        Me.ucrReceiverExpressionForTablePlus.frmParent = Me
        Me.ucrReceiverExpressionForTablePlus.Location = New System.Drawing.Point(246, 74)
        Me.ucrReceiverExpressionForTablePlus.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverExpressionForTablePlus.Name = "ucrReceiverExpressionForTablePlus"
        Me.ucrReceiverExpressionForTablePlus.Selector = Nothing
        Me.ucrReceiverExpressionForTablePlus.Size = New System.Drawing.Size(137, 20)
        Me.ucrReceiverExpressionForTablePlus.strNcFilePath = ""
        Me.ucrReceiverExpressionForTablePlus.TabIndex = 2
        Me.ucrReceiverExpressionForTablePlus.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 311)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 10
        '
        'ucrInputProbabilities
        '
        Me.ucrInputProbabilities.AddQuotesIfUnrecognised = True
        Me.ucrInputProbabilities.IsReadOnly = False
        Me.ucrInputProbabilities.Location = New System.Drawing.Point(246, 72)
        Me.ucrInputProbabilities.Name = "ucrInputProbabilities"
        Me.ucrInputProbabilities.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputProbabilities.TabIndex = 5
        '
        'rdoProbabilities
        '
        Me.rdoProbabilities.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoProbabilities.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoProbabilities.FlatAppearance.BorderSize = 2
        Me.rdoProbabilities.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoProbabilities.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoProbabilities.Location = New System.Drawing.Point(229, 15)
        Me.rdoProbabilities.Name = "rdoProbabilities"
        Me.rdoProbabilities.Size = New System.Drawing.Size(128, 27)
        Me.rdoProbabilities.TabIndex = 2
        Me.rdoProbabilities.TabStop = True
        Me.rdoProbabilities.Text = "Probabilities"
        Me.rdoProbabilities.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoProbabilities.UseVisualStyleBackColor = True
        '
        'rdoQuantiles
        '
        Me.rdoQuantiles.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoQuantiles.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoQuantiles.FlatAppearance.BorderSize = 2
        Me.rdoQuantiles.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoQuantiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoQuantiles.Location = New System.Drawing.Point(105, 15)
        Me.rdoQuantiles.Name = "rdoQuantiles"
        Me.rdoQuantiles.Size = New System.Drawing.Size(128, 27)
        Me.rdoQuantiles.TabIndex = 1
        Me.rdoQuantiles.TabStop = True
        Me.rdoQuantiles.Text = "Quantiles"
        Me.rdoQuantiles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoQuantiles.UseVisualStyleBackColor = True
        '
        'ucrPnlDistTypes
        '
        Me.ucrPnlDistTypes.Location = New System.Drawing.Point(95, 10)
        Me.ucrPnlDistTypes.Name = "ucrPnlDistTypes"
        Me.ucrPnlDistTypes.Size = New System.Drawing.Size(273, 36)
        Me.ucrPnlDistTypes.TabIndex = 0
        '
        'ucrChkDisplayGraphResults
        '
        Me.ucrChkDisplayGraphResults.Checked = False
        Me.ucrChkDisplayGraphResults.Location = New System.Drawing.Point(12, 242)
        Me.ucrChkDisplayGraphResults.Name = "ucrChkDisplayGraphResults"
        Me.ucrChkDisplayGraphResults.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkDisplayGraphResults.TabIndex = 7
        '
        'ucrChkEnterValues
        '
        Me.ucrChkEnterValues.Checked = False
        Me.ucrChkEnterValues.Location = New System.Drawing.Point(12, 262)
        Me.ucrChkEnterValues.Name = "ucrChkEnterValues"
        Me.ucrChkEnterValues.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkEnterValues.TabIndex = 8
        '
        'ucrSaveGraphResults
        '
        Me.ucrSaveGraphResults.Location = New System.Drawing.Point(12, 281)
        Me.ucrSaveGraphResults.Name = "ucrSaveGraphResults"
        Me.ucrSaveGraphResults.Size = New System.Drawing.Size(270, 24)
        Me.ucrSaveGraphResults.TabIndex = 9
        '
        'dlgShowModel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 372)
        Me.Controls.Add(Me.ucrSaveGraphResults)
        Me.Controls.Add(Me.ucrChkEnterValues)
        Me.Controls.Add(Me.ucrChkDisplayGraphResults)
        Me.Controls.Add(Me.rdoProbabilities)
        Me.Controls.Add(Me.rdoQuantiles)
        Me.Controls.Add(Me.ucrPnlDistTypes)
        Me.Controls.Add(Me.ucrInputProbabilities)
        Me.Controls.Add(Me.ucrDistributionsFOrTablePlus)
        Me.Controls.Add(Me.lblProbValues)
        Me.Controls.Add(Me.lblQuantValues)
        Me.Controls.Add(Me.ucrSelectorForDataFrame)
        Me.Controls.Add(Me.ucrReceiverExpressionForTablePlus)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgShowModel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Show Model"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverExpressionForTablePlus As ucrReceiverSingle
    Friend WithEvents ucrSelectorForDataFrame As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblQuantValues As Label
    Friend WithEvents lblProbValues As Label
    Friend WithEvents ucrDistributionsFOrTablePlus As ucrDistributionsWithParameters
    Friend WithEvents ucrInputProbabilities As ucrInputComboBox
    Friend WithEvents ucrSaveGraphResults As ucrSave
    Friend WithEvents ucrChkEnterValues As ucrCheck
    Friend WithEvents ucrChkDisplayGraphResults As ucrCheck
    Friend WithEvents rdoProbabilities As RadioButton
    Friend WithEvents rdoQuantiles As RadioButton
    Friend WithEvents ucrPnlDistTypes As UcrPanel
End Class
