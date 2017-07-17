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
Partial Class dlgDescribeTwoVariable
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
        Me.cmdSummaries = New System.Windows.Forms.Button()
        Me.cmdDisplayOptions = New System.Windows.Forms.Button()
        Me.lblFirstVariable = New System.Windows.Forms.Label()
        Me.lbMultipleVariables = New System.Windows.Forms.Label()
        Me.ucrReceiverFirstVar = New instat.ucrReceiverSingle()
        Me.ucrReceiverSecondVar = New instat.ucrReceiverMultiple()
        Me.ucrSelectorDescribeTwoVar = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrChkSaveResult = New instat.ucrCheck()
        Me.ucrChkOmitMissing = New instat.ucrCheck()
        Me.SuspendLayout()
        '
        'cmdSummaries
        '
        Me.cmdSummaries.Location = New System.Drawing.Point(305, 222)
        Me.cmdSummaries.Name = "cmdSummaries"
        Me.cmdSummaries.Size = New System.Drawing.Size(105, 23)
        Me.cmdSummaries.TabIndex = 7
        Me.cmdSummaries.Tag = "Summaries"
        Me.cmdSummaries.Text = "Summaries"
        Me.cmdSummaries.UseVisualStyleBackColor = True
        '
        'cmdDisplayOptions
        '
        Me.cmdDisplayOptions.Location = New System.Drawing.Point(304, 221)
        Me.cmdDisplayOptions.Name = "cmdDisplayOptions"
        Me.cmdDisplayOptions.Size = New System.Drawing.Size(105, 23)
        Me.cmdDisplayOptions.TabIndex = 8
        Me.cmdDisplayOptions.Tag = "Display_Options"
        Me.cmdDisplayOptions.Text = "Display Options"
        Me.cmdDisplayOptions.UseVisualStyleBackColor = True
        '
        'lblFirstVariable
        '
        Me.lblFirstVariable.AutoSize = True
        Me.lblFirstVariable.Location = New System.Drawing.Point(268, 45)
        Me.lblFirstVariable.Name = "lblFirstVariable"
        Me.lblFirstVariable.Size = New System.Drawing.Size(70, 13)
        Me.lblFirstVariable.TabIndex = 1
        Me.lblFirstVariable.Tag = "First_Variable"
        Me.lblFirstVariable.Text = "First Variable:"
        '
        'lbMultipleVariables
        '
        Me.lbMultipleVariables.Location = New System.Drawing.Point(268, 90)
        Me.lbMultipleVariables.Name = "lbMultipleVariables"
        Me.lbMultipleVariables.Size = New System.Drawing.Size(100, 15)
        Me.lbMultipleVariables.TabIndex = 3
        Me.lbMultipleVariables.Tag = "Multiple_Variables"
        Me.lbMultipleVariables.Text = "Multiple Variables:"
        '
        'ucrReceiverFirstVar
        '
        Me.ucrReceiverFirstVar.frmParent = Me
        Me.ucrReceiverFirstVar.Location = New System.Drawing.Point(268, 60)
        Me.ucrReceiverFirstVar.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFirstVar.Name = "ucrReceiverFirstVar"
        Me.ucrReceiverFirstVar.Selector = Nothing
        Me.ucrReceiverFirstVar.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverFirstVar.strNcFilePath = ""
        Me.ucrReceiverFirstVar.TabIndex = 2
        Me.ucrReceiverFirstVar.ucrSelector = Nothing
        '
        'ucrReceiverSecondVar
        '
        Me.ucrReceiverSecondVar.frmParent = Me
        Me.ucrReceiverSecondVar.Location = New System.Drawing.Point(268, 105)
        Me.ucrReceiverSecondVar.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSecondVar.Name = "ucrReceiverSecondVar"
        Me.ucrReceiverSecondVar.Selector = Nothing
        Me.ucrReceiverSecondVar.Size = New System.Drawing.Size(120, 87)
        Me.ucrReceiverSecondVar.strNcFilePath = ""
        Me.ucrReceiverSecondVar.TabIndex = 4
        Me.ucrReceiverSecondVar.ucrSelector = Nothing
        '
        'ucrSelectorDescribeTwoVar
        '
        Me.ucrSelectorDescribeTwoVar.bShowHiddenColumns = False
        Me.ucrSelectorDescribeTwoVar.bUseCurrentFilter = True
        Me.ucrSelectorDescribeTwoVar.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorDescribeTwoVar.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDescribeTwoVar.Name = "ucrSelectorDescribeTwoVar"
        Me.ucrSelectorDescribeTwoVar.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorDescribeTwoVar.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 250)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 9
        '
        'ucrChkSaveResult
        '
        Me.ucrChkSaveResult.Checked = False
        Me.ucrChkSaveResult.Location = New System.Drawing.Point(10, 224)
        Me.ucrChkSaveResult.Name = "ucrChkSaveResult"
        Me.ucrChkSaveResult.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkSaveResult.TabIndex = 5
        '
        'ucrChkOmitMissing
        '
        Me.ucrChkOmitMissing.Checked = False
        Me.ucrChkOmitMissing.Location = New System.Drawing.Point(10, 198)
        Me.ucrChkOmitMissing.Name = "ucrChkOmitMissing"
        Me.ucrChkOmitMissing.Size = New System.Drawing.Size(143, 20)
        Me.ucrChkOmitMissing.TabIndex = 6
        '
        'dlgDescribeTwoVariable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 309)
        Me.Controls.Add(Me.ucrChkSaveResult)
        Me.Controls.Add(Me.ucrChkOmitMissing)
        Me.Controls.Add(Me.lbMultipleVariables)
        Me.Controls.Add(Me.lblFirstVariable)
        Me.Controls.Add(Me.cmdDisplayOptions)
        Me.Controls.Add(Me.ucrReceiverFirstVar)
        Me.Controls.Add(Me.ucrReceiverSecondVar)
        Me.Controls.Add(Me.cmdSummaries)
        Me.Controls.Add(Me.ucrSelectorDescribeTwoVar)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDescribeTwoVariable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Describe_Two_Variable"
        Me.Text = "Describe Two Variables"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorDescribeTwoVar As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverSecondVar As ucrReceiverMultiple
    Friend WithEvents cmdSummaries As Button
    Friend WithEvents ucrReceiverFirstVar As ucrReceiverSingle
    Friend WithEvents cmdDisplayOptions As Button
    Friend WithEvents lblFirstVariable As Label
    Friend WithEvents lbMultipleVariables As Label
    Friend WithEvents ucrChkSaveResult As ucrCheck
    Friend WithEvents ucrChkOmitMissing As ucrCheck
End Class
