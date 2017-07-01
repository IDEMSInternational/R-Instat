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
Partial Class sdgOneVarFitModel
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ucrBase = New instat.ucrButtonsSubdialogue()
        Me.ucrPnlFitMethod = New instat.UcrPanel()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.rdoMme = New System.Windows.Forms.RadioButton()
        Me.rdoQme = New System.Windows.Forms.RadioButton()
        Me.rdoMle = New System.Windows.Forms.RadioButton()
        Me.rdoMge = New System.Windows.Forms.RadioButton()
        Me.ucrPnlOptimisation = New instat.UcrPanel()
        Me.rdoSANN = New System.Windows.Forms.RadioButton()
        Me.rdoCG = New System.Windows.Forms.RadioButton()
        Me.rdoBFGS = New System.Windows.Forms.RadioButton()
        Me.rdoNelderMead = New System.Windows.Forms.RadioButton()
        Me.rdoDefault = New System.Windows.Forms.RadioButton()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(201, 177)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(193, 151)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Optimisation"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoSANN)
        Me.GroupBox1.Controls.Add(Me.rdoCG)
        Me.GroupBox1.Controls.Add(Me.rdoBFGS)
        Me.GroupBox1.Controls.Add(Me.rdoNelderMead)
        Me.GroupBox1.Controls.Add(Me.rdoDefault)
        Me.GroupBox1.Controls.Add(Me.ucrPnlOptimisation)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(181, 139)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Optimisation Method"
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(16, 195)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(142, 30)
        Me.ucrBase.TabIndex = 1
        '
        'ucrPnlFitMethod
        '
        Me.ucrPnlFitMethod.Location = New System.Drawing.Point(3, 6)
        Me.ucrPnlFitMethod.Name = "ucrPnlFitMethod"
        Me.ucrPnlFitMethod.Size = New System.Drawing.Size(171, 95)
        Me.ucrPnlFitMethod.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.rdoMme)
        Me.TabPage1.Controls.Add(Me.rdoQme)
        Me.TabPage1.Controls.Add(Me.rdoMle)
        Me.TabPage1.Controls.Add(Me.rdoMge)
        Me.TabPage1.Controls.Add(Me.ucrPnlFitMethod)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(193, 151)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Fitting Method"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'rdoMme
        '
        Me.rdoMme.AutoSize = True
        Me.rdoMme.Location = New System.Drawing.Point(3, 29)
        Me.rdoMme.Name = "rdoMme"
        Me.rdoMme.Size = New System.Drawing.Size(102, 17)
        Me.rdoMme.TabIndex = 7
        Me.rdoMme.TabStop = True
        Me.rdoMme.Text = "Moments (MME)"
        Me.rdoMme.UseVisualStyleBackColor = True
        '
        'rdoQme
        '
        Me.rdoQme.AutoSize = True
        Me.rdoQme.Location = New System.Drawing.Point(3, 52)
        Me.rdoQme.Name = "rdoQme"
        Me.rdoQme.Size = New System.Drawing.Size(99, 17)
        Me.rdoQme.TabIndex = 8
        Me.rdoQme.TabStop = True
        Me.rdoQme.Text = "Quartiles (QME)"
        Me.rdoQme.UseVisualStyleBackColor = True
        '
        'rdoMle
        '
        Me.rdoMle.AutoSize = True
        Me.rdoMle.Location = New System.Drawing.Point(3, 6)
        Me.rdoMle.Name = "rdoMle"
        Me.rdoMle.Size = New System.Drawing.Size(151, 17)
        Me.rdoMle.TabIndex = 6
        Me.rdoMle.TabStop = True
        Me.rdoMle.Text = "Maximum Likelihood (MLE)"
        Me.rdoMle.UseVisualStyleBackColor = True
        '
        'rdoMge
        '
        Me.rdoMge.AutoSize = True
        Me.rdoMge.Location = New System.Drawing.Point(3, 75)
        Me.rdoMge.Name = "rdoMge"
        Me.rdoMge.Size = New System.Drawing.Size(132, 17)
        Me.rdoMge.TabIndex = 9
        Me.rdoMge.TabStop = True
        Me.rdoMge.Text = "Goodness of Fit (MGE)"
        Me.rdoMge.UseVisualStyleBackColor = True
        '
        'ucrPnlOptimisation
        '
        Me.ucrPnlOptimisation.Location = New System.Drawing.Point(6, 13)
        Me.ucrPnlOptimisation.Name = "ucrPnlOptimisation"
        Me.ucrPnlOptimisation.Size = New System.Drawing.Size(165, 120)
        Me.ucrPnlOptimisation.TabIndex = 6
        '
        'rdoSANN
        '
        Me.rdoSANN.AutoSize = True
        Me.rdoSANN.Location = New System.Drawing.Point(21, 107)
        Me.rdoSANN.Name = "rdoSANN"
        Me.rdoSANN.Size = New System.Drawing.Size(55, 17)
        Me.rdoSANN.TabIndex = 11
        Me.rdoSANN.TabStop = True
        Me.rdoSANN.Text = "SANN"
        Me.rdoSANN.UseVisualStyleBackColor = True
        '
        'rdoCG
        '
        Me.rdoCG.AutoSize = True
        Me.rdoCG.Location = New System.Drawing.Point(21, 84)
        Me.rdoCG.Name = "rdoCG"
        Me.rdoCG.Size = New System.Drawing.Size(138, 17)
        Me.rdoCG.TabIndex = 10
        Me.rdoCG.TabStop = True
        Me.rdoCG.Text = "Conjugent Gradent (CG)"
        Me.rdoCG.UseVisualStyleBackColor = True
        '
        'rdoBFGS
        '
        Me.rdoBFGS.AutoSize = True
        Me.rdoBFGS.Location = New System.Drawing.Point(21, 61)
        Me.rdoBFGS.Name = "rdoBFGS"
        Me.rdoBFGS.Size = New System.Drawing.Size(53, 17)
        Me.rdoBFGS.TabIndex = 9
        Me.rdoBFGS.TabStop = True
        Me.rdoBFGS.Text = "BFGS"
        Me.rdoBFGS.UseVisualStyleBackColor = True
        '
        'rdoNelderMead
        '
        Me.rdoNelderMead.AutoSize = True
        Me.rdoNelderMead.Location = New System.Drawing.Point(21, 38)
        Me.rdoNelderMead.Name = "rdoNelderMead"
        Me.rdoNelderMead.Size = New System.Drawing.Size(86, 17)
        Me.rdoNelderMead.TabIndex = 8
        Me.rdoNelderMead.TabStop = True
        Me.rdoNelderMead.Text = "Nelder-Mead"
        Me.rdoNelderMead.UseVisualStyleBackColor = True
        '
        'rdoDefault
        '
        Me.rdoDefault.AutoSize = True
        Me.rdoDefault.Location = New System.Drawing.Point(21, 15)
        Me.rdoDefault.Name = "rdoDefault"
        Me.rdoDefault.Size = New System.Drawing.Size(59, 17)
        Me.rdoDefault.TabIndex = 7
        Me.rdoDefault.TabStop = True
        Me.rdoDefault.Text = "Default"
        Me.rdoDefault.UseVisualStyleBackColor = True
        '
        'sdgOneVarFitModel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(216, 228)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgOneVarFitModel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Fitting Options"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdoSANN As RadioButton
    Friend WithEvents rdoCG As RadioButton
    Friend WithEvents rdoBFGS As RadioButton
    Friend WithEvents rdoNelderMead As RadioButton
    Friend WithEvents rdoDefault As RadioButton
    Friend WithEvents ucrBase As ucrButtonsSubdialogue
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents rdoMme As RadioButton
    Friend WithEvents rdoQme As RadioButton
    Friend WithEvents rdoMle As RadioButton
    Friend WithEvents rdoMge As RadioButton
    Friend WithEvents ucrPnlFitMethod As UcrPanel
    Friend WithEvents ucrPnlOptimisation As UcrPanel
End Class
