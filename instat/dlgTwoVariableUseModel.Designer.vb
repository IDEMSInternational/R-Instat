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
Partial Class dlgTwoVariableUseModel
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
        Me.lblModeltoUse = New System.Windows.Forms.Label()
        Me.lblModelFormula = New System.Windows.Forms.Label()
        Me.cmdPredict = New System.Windows.Forms.Button()
        Me.cmdDisplayOptions = New System.Windows.Forms.Button()
        Me.ucrModel = New instat.ucrInputTextBox()
        Me.ucrReceiverUseModel = New instat.ucrReceiverSingle()
        Me.ucrSelectorUseModel = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBaseUseModel = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblModeltoUse
        '
        Me.lblModeltoUse.AutoSize = True
        Me.lblModeltoUse.Location = New System.Drawing.Point(257, 37)
        Me.lblModeltoUse.Name = "lblModeltoUse"
        Me.lblModeltoUse.Size = New System.Drawing.Size(84, 13)
        Me.lblModeltoUse.TabIndex = 1
        Me.lblModeltoUse.Tag = "Selected_Model:"
        Me.lblModeltoUse.Text = "Selected Model:"
        '
        'lblModelFormula
        '
        Me.lblModelFormula.AutoSize = True
        Me.lblModelFormula.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblModelFormula.Location = New System.Drawing.Point(12, 202)
        Me.lblModelFormula.Name = "lblModelFormula"
        Me.lblModelFormula.Size = New System.Drawing.Size(79, 13)
        Me.lblModelFormula.TabIndex = 4
        Me.lblModelFormula.Text = "Model Formula:"
        '
        'cmdPredict
        '
        Me.cmdPredict.Enabled = False
        Me.cmdPredict.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPredict.Location = New System.Drawing.Point(300, 168)
        Me.cmdPredict.Name = "cmdPredict"
        Me.cmdPredict.Size = New System.Drawing.Size(110, 23)
        Me.cmdPredict.TabIndex = 3
        Me.cmdPredict.Tag = "Predict..."
        Me.cmdPredict.Text = "Predict..."
        Me.cmdPredict.UseVisualStyleBackColor = True
        '
        'cmdDisplayOptions
        '
        Me.cmdDisplayOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDisplayOptions.Location = New System.Drawing.Point(300, 197)
        Me.cmdDisplayOptions.Name = "cmdDisplayOptions"
        Me.cmdDisplayOptions.Size = New System.Drawing.Size(110, 23)
        Me.cmdDisplayOptions.TabIndex = 6
        Me.cmdDisplayOptions.Tag = "Display_Options..."
        Me.cmdDisplayOptions.Text = "Display Options..."
        Me.cmdDisplayOptions.UseVisualStyleBackColor = True
        '
        'ucrModel
        '
        Me.ucrModel.AddQuotesIfUnrecognised = True
        Me.ucrModel.IsMultiline = False
        Me.ucrModel.IsReadOnly = False
        Me.ucrModel.Location = New System.Drawing.Point(97, 199)
        Me.ucrModel.Name = "ucrModel"
        Me.ucrModel.Size = New System.Drawing.Size(158, 21)
        Me.ucrModel.TabIndex = 5
        '
        'ucrReceiverUseModel
        '
        Me.ucrReceiverUseModel.frmParent = Me
        Me.ucrReceiverUseModel.Location = New System.Drawing.Point(256, 52)
        Me.ucrReceiverUseModel.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverUseModel.Name = "ucrReceiverUseModel"
        Me.ucrReceiverUseModel.Selector = Nothing
        Me.ucrReceiverUseModel.Size = New System.Drawing.Size(120, 22)
        Me.ucrReceiverUseModel.strNcFilePath = ""
        Me.ucrReceiverUseModel.TabIndex = 2
        Me.ucrReceiverUseModel.ucrSelector = Nothing
        '
        'ucrSelectorUseModel
        '
        Me.ucrSelectorUseModel.bShowHiddenColumns = False
        Me.ucrSelectorUseModel.bUseCurrentFilter = True
        Me.ucrSelectorUseModel.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorUseModel.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorUseModel.Name = "ucrSelectorUseModel"
        Me.ucrSelectorUseModel.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorUseModel.TabIndex = 0
        '
        'ucrBaseUseModel
        '
        Me.ucrBaseUseModel.Location = New System.Drawing.Point(10, 226)
        Me.ucrBaseUseModel.Name = "ucrBaseUseModel"
        Me.ucrBaseUseModel.Size = New System.Drawing.Size(410, 52)
        Me.ucrBaseUseModel.TabIndex = 7
        '
        'dlgTwoVariableUseModel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 283)
        Me.Controls.Add(Me.ucrModel)
        Me.Controls.Add(Me.lblModelFormula)
        Me.Controls.Add(Me.cmdPredict)
        Me.Controls.Add(Me.cmdDisplayOptions)
        Me.Controls.Add(Me.lblModeltoUse)
        Me.Controls.Add(Me.ucrReceiverUseModel)
        Me.Controls.Add(Me.ucrSelectorUseModel)
        Me.Controls.Add(Me.ucrBaseUseModel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgTwoVariableUseModel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Two_Variable_Use_Model"
        Me.Text = "Two Variable Use Model"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBaseUseModel As ucrButtons
    Friend WithEvents lblModeltoUse As Label
    Friend WithEvents ucrReceiverUseModel As ucrReceiverSingle
    Friend WithEvents ucrSelectorUseModel As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrModel As ucrInputTextBox
    Friend WithEvents lblModelFormula As Label
    Friend WithEvents cmdPredict As Button
    Friend WithEvents cmdDisplayOptions As Button
End Class
