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
Partial Class dlgPrincipalComponentAnalysis
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
        Me.lblExplanatoryVariables = New System.Windows.Forms.Label()
        Me.cmdPCAOptions = New System.Windows.Forms.Button()
        Me.nudComponents = New System.Windows.Forms.NumericUpDown()
        Me.lblComponents = New System.Windows.Forms.Label()
        Me.chkScaleData = New System.Windows.Forms.CheckBox()
        Me.chkSaveResult = New System.Windows.Forms.CheckBox()
        Me.ucrResultName = New instat.ucrInputComboBox()
        Me.ucrReceiverMultiplePCA = New instat.ucrReceiverMultiple()
        Me.ucrSelectorPCA = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBasePCA = New instat.ucrButtons()
        CType(Me.nudComponents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblExplanatoryVariables
        '
        Me.lblExplanatoryVariables.AutoSize = True
        Me.lblExplanatoryVariables.Location = New System.Drawing.Point(248, 18)
        Me.lblExplanatoryVariables.Name = "lblExplanatoryVariables"
        Me.lblExplanatoryVariables.Size = New System.Drawing.Size(111, 13)
        Me.lblExplanatoryVariables.TabIndex = 1
        Me.lblExplanatoryVariables.Tag = "Explanatory_Variables"
        Me.lblExplanatoryVariables.Text = "Explanatory Variables:"
        '
        'cmdPCAOptions
        '
        Me.cmdPCAOptions.Location = New System.Drawing.Point(302, 204)
        Me.cmdPCAOptions.Name = "cmdPCAOptions"
        Me.cmdPCAOptions.Size = New System.Drawing.Size(106, 23)
        Me.cmdPCAOptions.TabIndex = 6
        Me.cmdPCAOptions.Tag = "PCA_Options..."
        Me.cmdPCAOptions.Text = "PCA Options..."
        Me.cmdPCAOptions.UseVisualStyleBackColor = True
        '
        'nudComponents
        '
        Me.nudComponents.Location = New System.Drawing.Point(372, 145)
        Me.nudComponents.Name = "nudComponents"
        Me.nudComponents.Size = New System.Drawing.Size(42, 20)
        Me.nudComponents.TabIndex = 4
        '
        'lblComponents
        '
        Me.lblComponents.AutoSize = True
        Me.lblComponents.Location = New System.Drawing.Point(247, 147)
        Me.lblComponents.Name = "lblComponents"
        Me.lblComponents.Size = New System.Drawing.Size(121, 13)
        Me.lblComponents.TabIndex = 3
        Me.lblComponents.Tag = "Number_of_Components"
        Me.lblComponents.Text = "Number of Components:"
        '
        'chkScaleData
        '
        Me.chkScaleData.AutoSize = True
        Me.chkScaleData.Location = New System.Drawing.Point(250, 173)
        Me.chkScaleData.Name = "chkScaleData"
        Me.chkScaleData.Size = New System.Drawing.Size(79, 17)
        Me.chkScaleData.TabIndex = 5
        Me.chkScaleData.Tag = "Scale_Data"
        Me.chkScaleData.Text = "Scale Data"
        Me.chkScaleData.UseVisualStyleBackColor = True
        '
        'chkSaveResult
        '
        Me.chkSaveResult.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkSaveResult.Location = New System.Drawing.Point(10, 204)
        Me.chkSaveResult.Name = "chkSaveResult"
        Me.chkSaveResult.Size = New System.Drawing.Size(87, 24)
        Me.chkSaveResult.TabIndex = 7
        Me.chkSaveResult.Tag = "Save_Result"
        Me.chkSaveResult.Text = "Save Result"
        Me.chkSaveResult.UseVisualStyleBackColor = True
        '
        'ucrResultName
        '
        Me.ucrResultName.IsReadOnly = False
        Me.ucrResultName.Location = New System.Drawing.Point(92, 205)
        Me.ucrResultName.Name = "ucrResultName"
        Me.ucrResultName.Size = New System.Drawing.Size(145, 21)
        Me.ucrResultName.TabIndex = 8
        '
        'ucrReceiverMultiplePCA
        '
        Me.ucrReceiverMultiplePCA.Location = New System.Drawing.Point(250, 34)
        Me.ucrReceiverMultiplePCA.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultiplePCA.Name = "ucrReceiverMultiplePCA"
        Me.ucrReceiverMultiplePCA.Selector = Nothing
        Me.ucrReceiverMultiplePCA.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverMultiplePCA.TabIndex = 2
        '
        'ucrSelectorPCA
        '
        Me.ucrSelectorPCA.bShowHiddenColumns = False
        Me.ucrSelectorPCA.bUseCurrentFilter = True
        Me.ucrSelectorPCA.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorPCA.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorPCA.Name = "ucrSelectorPCA"
        Me.ucrSelectorPCA.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorPCA.TabIndex = 0
        '
        'ucrBasePCA
        '
        Me.ucrBasePCA.Location = New System.Drawing.Point(10, 233)
        Me.ucrBasePCA.Name = "ucrBasePCA"
        Me.ucrBasePCA.Size = New System.Drawing.Size(410, 52)
        Me.ucrBasePCA.TabIndex = 9
        '
        'dlgPrincipalComponentAnalysis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 290)
        Me.Controls.Add(Me.ucrResultName)
        Me.Controls.Add(Me.chkSaveResult)
        Me.Controls.Add(Me.chkScaleData)
        Me.Controls.Add(Me.lblComponents)
        Me.Controls.Add(Me.nudComponents)
        Me.Controls.Add(Me.cmdPCAOptions)
        Me.Controls.Add(Me.lblExplanatoryVariables)
        Me.Controls.Add(Me.ucrReceiverMultiplePCA)
        Me.Controls.Add(Me.ucrSelectorPCA)
        Me.Controls.Add(Me.ucrBasePCA)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgPrincipalComponentAnalysis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Principal_Component_Analysis"
        Me.Text = "Principal Component Analysis"
        CType(Me.nudComponents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBasePCA As ucrButtons
    Friend WithEvents ucrSelectorPCA As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverMultiplePCA As ucrReceiverMultiple
    Friend WithEvents lblExplanatoryVariables As Label
    Friend WithEvents cmdPCAOptions As Button
    Friend WithEvents nudComponents As NumericUpDown
    Friend WithEvents lblComponents As Label
    Friend WithEvents chkScaleData As CheckBox
    Friend WithEvents chkSaveResult As CheckBox
    Friend WithEvents ucrResultName As ucrInputComboBox
End Class