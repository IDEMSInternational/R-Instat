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
        Me.tbFittingOptions = New System.Windows.Forms.TabControl()
        Me.tbFittingMethod = New System.Windows.Forms.TabPage()
        Me.rdoMme = New System.Windows.Forms.RadioButton()
        Me.rdoQme = New System.Windows.Forms.RadioButton()
        Me.rdoMle = New System.Windows.Forms.RadioButton()
        Me.rdoMge = New System.Windows.Forms.RadioButton()
        Me.ucrPnlFitMethod = New instat.UcrPanel()
        Me.tbOptimisationMethod = New System.Windows.Forms.TabPage()
        Me.rdoSANN = New System.Windows.Forms.RadioButton()
        Me.rdoDefault = New System.Windows.Forms.RadioButton()
        Me.rdoCG = New System.Windows.Forms.RadioButton()
        Me.rdoNelderMead = New System.Windows.Forms.RadioButton()
        Me.rdoBFGS = New System.Windows.Forms.RadioButton()
        Me.ucrPnlOptimisation = New instat.UcrPanel()
        Me.ucrBase = New instat.ucrButtonsSubdialogue()
        Me.tbFittingOptions.SuspendLayout()
        Me.tbFittingMethod.SuspendLayout()
        Me.tbOptimisationMethod.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbFittingOptions
        '
        Me.tbFittingOptions.Controls.Add(Me.tbFittingMethod)
        Me.tbFittingOptions.Controls.Add(Me.tbOptimisationMethod)
        Me.tbFittingOptions.Location = New System.Drawing.Point(5, 12)
        Me.tbFittingOptions.Name = "tbFittingOptions"
        Me.tbFittingOptions.SelectedIndex = 0
        Me.tbFittingOptions.Size = New System.Drawing.Size(201, 177)
        Me.tbFittingOptions.TabIndex = 0
        '
        'tbFittingMethod
        '
        Me.tbFittingMethod.Controls.Add(Me.rdoMme)
        Me.tbFittingMethod.Controls.Add(Me.rdoQme)
        Me.tbFittingMethod.Controls.Add(Me.rdoMle)
        Me.tbFittingMethod.Controls.Add(Me.rdoMge)
        Me.tbFittingMethod.Controls.Add(Me.ucrPnlFitMethod)
        Me.tbFittingMethod.Location = New System.Drawing.Point(4, 22)
        Me.tbFittingMethod.Name = "tbFittingMethod"
        Me.tbFittingMethod.Padding = New System.Windows.Forms.Padding(3)
        Me.tbFittingMethod.Size = New System.Drawing.Size(193, 151)
        Me.tbFittingMethod.TabIndex = 0
        Me.tbFittingMethod.Text = "Fitting Method"
        Me.tbFittingMethod.UseVisualStyleBackColor = True
        '
        'rdoMme
        '
        Me.rdoMme.AutoSize = True
        Me.rdoMme.Location = New System.Drawing.Point(10, 33)
        Me.rdoMme.Name = "rdoMme"
        Me.rdoMme.Size = New System.Drawing.Size(102, 17)
        Me.rdoMme.TabIndex = 2
        Me.rdoMme.TabStop = True
        Me.rdoMme.Text = "Moments (MME)"
        Me.rdoMme.UseVisualStyleBackColor = True
        '
        'rdoQme
        '
        Me.rdoQme.AutoSize = True
        Me.rdoQme.Location = New System.Drawing.Point(10, 56)
        Me.rdoQme.Name = "rdoQme"
        Me.rdoQme.Size = New System.Drawing.Size(99, 17)
        Me.rdoQme.TabIndex = 3
        Me.rdoQme.TabStop = True
        Me.rdoQme.Text = "Quartiles (QME)"
        Me.rdoQme.UseVisualStyleBackColor = True
        '
        'rdoMle
        '
        Me.rdoMle.AutoSize = True
        Me.rdoMle.Location = New System.Drawing.Point(10, 10)
        Me.rdoMle.Name = "rdoMle"
        Me.rdoMle.Size = New System.Drawing.Size(151, 17)
        Me.rdoMle.TabIndex = 1
        Me.rdoMle.TabStop = True
        Me.rdoMle.Text = "Maximum Likelihood (MLE)"
        Me.rdoMle.UseVisualStyleBackColor = True
        '
        'rdoMge
        '
        Me.rdoMge.AutoSize = True
        Me.rdoMge.Location = New System.Drawing.Point(10, 79)
        Me.rdoMge.Name = "rdoMge"
        Me.rdoMge.Size = New System.Drawing.Size(132, 17)
        Me.rdoMge.TabIndex = 4
        Me.rdoMge.TabStop = True
        Me.rdoMge.Text = "Goodness of Fit (MGE)"
        Me.rdoMge.UseVisualStyleBackColor = True
        '
        'ucrPnlFitMethod
        '
        Me.ucrPnlFitMethod.Location = New System.Drawing.Point(3, 6)
        Me.ucrPnlFitMethod.Name = "ucrPnlFitMethod"
        Me.ucrPnlFitMethod.Size = New System.Drawing.Size(184, 114)
        Me.ucrPnlFitMethod.TabIndex = 0
        '
        'tbOptimisationMethod
        '
        Me.tbOptimisationMethod.Controls.Add(Me.rdoSANN)
        Me.tbOptimisationMethod.Controls.Add(Me.rdoDefault)
        Me.tbOptimisationMethod.Controls.Add(Me.rdoCG)
        Me.tbOptimisationMethod.Controls.Add(Me.rdoNelderMead)
        Me.tbOptimisationMethod.Controls.Add(Me.rdoBFGS)
        Me.tbOptimisationMethod.Controls.Add(Me.ucrPnlOptimisation)
        Me.tbOptimisationMethod.Location = New System.Drawing.Point(4, 22)
        Me.tbOptimisationMethod.Name = "tbOptimisationMethod"
        Me.tbOptimisationMethod.Padding = New System.Windows.Forms.Padding(3)
        Me.tbOptimisationMethod.Size = New System.Drawing.Size(193, 151)
        Me.tbOptimisationMethod.TabIndex = 1
        Me.tbOptimisationMethod.Text = "Optimisation"
        Me.tbOptimisationMethod.UseVisualStyleBackColor = True
        '
        'rdoSANN
        '
        Me.rdoSANN.AutoSize = True
        Me.rdoSANN.Location = New System.Drawing.Point(10, 102)
        Me.rdoSANN.Name = "rdoSANN"
        Me.rdoSANN.Size = New System.Drawing.Size(55, 17)
        Me.rdoSANN.TabIndex = 5
        Me.rdoSANN.TabStop = True
        Me.rdoSANN.Text = "SANN"
        Me.rdoSANN.UseVisualStyleBackColor = True
        '
        'rdoDefault
        '
        Me.rdoDefault.AutoSize = True
        Me.rdoDefault.Location = New System.Drawing.Point(10, 10)
        Me.rdoDefault.Name = "rdoDefault"
        Me.rdoDefault.Size = New System.Drawing.Size(59, 17)
        Me.rdoDefault.TabIndex = 1
        Me.rdoDefault.TabStop = True
        Me.rdoDefault.Text = "Default"
        Me.rdoDefault.UseVisualStyleBackColor = True
        '
        'rdoCG
        '
        Me.rdoCG.AutoSize = True
        Me.rdoCG.Location = New System.Drawing.Point(10, 79)
        Me.rdoCG.Name = "rdoCG"
        Me.rdoCG.Size = New System.Drawing.Size(138, 17)
        Me.rdoCG.TabIndex = 4
        Me.rdoCG.TabStop = True
        Me.rdoCG.Text = "Conjugent Gradent (CG)"
        Me.rdoCG.UseVisualStyleBackColor = True
        '
        'rdoNelderMead
        '
        Me.rdoNelderMead.AutoSize = True
        Me.rdoNelderMead.Location = New System.Drawing.Point(10, 33)
        Me.rdoNelderMead.Name = "rdoNelderMead"
        Me.rdoNelderMead.Size = New System.Drawing.Size(86, 17)
        Me.rdoNelderMead.TabIndex = 2
        Me.rdoNelderMead.TabStop = True
        Me.rdoNelderMead.Text = "Nelder-Mead"
        Me.rdoNelderMead.UseVisualStyleBackColor = True
        '
        'rdoBFGS
        '
        Me.rdoBFGS.AutoSize = True
        Me.rdoBFGS.Location = New System.Drawing.Point(10, 56)
        Me.rdoBFGS.Name = "rdoBFGS"
        Me.rdoBFGS.Size = New System.Drawing.Size(53, 17)
        Me.rdoBFGS.TabIndex = 3
        Me.rdoBFGS.TabStop = True
        Me.rdoBFGS.Text = "BFGS"
        Me.rdoBFGS.UseVisualStyleBackColor = True
        '
        'ucrPnlOptimisation
        '
        Me.ucrPnlOptimisation.Location = New System.Drawing.Point(6, 6)
        Me.ucrPnlOptimisation.Name = "ucrPnlOptimisation"
        Me.ucrPnlOptimisation.Size = New System.Drawing.Size(165, 120)
        Me.ucrPnlOptimisation.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(33, 195)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(142, 30)
        Me.ucrBase.TabIndex = 1
        '
        'sdgOneVarFitModel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(209, 228)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.tbFittingOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgOneVarFitModel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Fitting Options"
        Me.tbFittingOptions.ResumeLayout(False)
        Me.tbFittingMethod.ResumeLayout(False)
        Me.tbFittingMethod.PerformLayout()
        Me.tbOptimisationMethod.ResumeLayout(False)
        Me.tbOptimisationMethod.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbFittingOptions As TabControl
    Friend WithEvents tbOptimisationMethod As TabPage
    Friend WithEvents rdoSANN As RadioButton
    Friend WithEvents rdoCG As RadioButton
    Friend WithEvents rdoBFGS As RadioButton
    Friend WithEvents rdoNelderMead As RadioButton
    Friend WithEvents rdoDefault As RadioButton
    Friend WithEvents ucrBase As ucrButtonsSubdialogue
    Friend WithEvents tbFittingMethod As TabPage
    Friend WithEvents rdoMme As RadioButton
    Friend WithEvents rdoQme As RadioButton
    Friend WithEvents rdoMle As RadioButton
    Friend WithEvents rdoMge As RadioButton
    Friend WithEvents ucrPnlFitMethod As UcrPanel
    Friend WithEvents ucrPnlOptimisation As UcrPanel
End Class
