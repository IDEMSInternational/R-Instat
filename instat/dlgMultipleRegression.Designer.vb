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
Partial Class dlgMultipleRegression
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
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiveExplanatoryVaraibles = New instat.ucrReceiverMultiple()
        Me.ucrReceiveResponseVariable = New instat.ucrReceiverSingle()
        Me.lblExplanatoryVariables = New System.Windows.Forms.Label()
        Me.lblResponseVariable = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.Location = New System.Drawing.Point(12, 12)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(226, 131)
        Me.ucrAddRemove.TabIndex = 3
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(4, 206)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 55)
        Me.ucrBase.TabIndex = 2
        '
        'ucrReceiveExplanatoryVaraibles
        '
        Me.ucrReceiveExplanatoryVaraibles.Location = New System.Drawing.Point(247, 105)
        Me.ucrReceiveExplanatoryVaraibles.Name = "ucrReceiveExplanatoryVaraibles"
        Me.ucrReceiveExplanatoryVaraibles.Selector = Nothing
        Me.ucrReceiveExplanatoryVaraibles.Size = New System.Drawing.Size(131, 118)
        Me.ucrReceiveExplanatoryVaraibles.TabIndex = 0
        '
        'ucrReceiveResponseVariable
        '
        Me.ucrReceiveResponseVariable.Location = New System.Drawing.Point(247, 50)
        Me.ucrReceiveResponseVariable.Name = "ucrReceiveResponseVariable"
        Me.ucrReceiveResponseVariable.Selector = Nothing
        Me.ucrReceiveResponseVariable.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiveResponseVariable.TabIndex = 4
        '
        'lblExplanatoryVariables
        '
        Me.lblExplanatoryVariables.AutoSize = True
        Me.lblExplanatoryVariables.Location = New System.Drawing.Point(244, 89)
        Me.lblExplanatoryVariables.Name = "lblExplanatoryVariables"
        Me.lblExplanatoryVariables.Size = New System.Drawing.Size(121, 13)
        Me.lblExplanatoryVariables.TabIndex = 5
        Me.lblExplanatoryVariables.Tag = "Explanatory_variables"
        Me.lblExplanatoryVariables.Text = "Explanatory variables (x)"
        '
        'lblResponseVariable
        '
        Me.lblResponseVariable.AutoSize = True
        Me.lblResponseVariable.Location = New System.Drawing.Point(244, 24)
        Me.lblResponseVariable.Name = "lblResponseVariable"
        Me.lblResponseVariable.Size = New System.Drawing.Size(109, 13)
        Me.lblResponseVariable.TabIndex = 6
        Me.lblResponseVariable.Tag = "Response_variable"
        Me.lblResponseVariable.Text = "Response variable (y)"
        '
        'dlgMultipleRegression
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 263)
        Me.Controls.Add(Me.lblResponseVariable)
        Me.Controls.Add(Me.lblExplanatoryVariables)
        Me.Controls.Add(Me.ucrReceiveResponseVariable)
        Me.Controls.Add(Me.ucrAddRemove)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReceiveExplanatoryVaraibles)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgMultipleRegression"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Multiple Regression"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrReceiveExplanatoryVaraibles As ucrReceiverMultiple
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents ucrReceiveResponseVariable As ucrReceiverSingle
    Friend WithEvents lblExplanatoryVariables As Label
    Friend WithEvents lblResponseVariable As Label
End Class
