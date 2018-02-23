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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgOneVarFitModel))
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
        resources.ApplyResources(Me.tbFittingOptions, "tbFittingOptions")
        Me.tbFittingOptions.Name = "tbFittingOptions"
        Me.tbFittingOptions.SelectedIndex = 0
        '
        'tbFittingMethod
        '
        Me.tbFittingMethod.Controls.Add(Me.rdoMme)
        Me.tbFittingMethod.Controls.Add(Me.rdoQme)
        Me.tbFittingMethod.Controls.Add(Me.rdoMle)
        Me.tbFittingMethod.Controls.Add(Me.rdoMge)
        Me.tbFittingMethod.Controls.Add(Me.ucrPnlFitMethod)
        resources.ApplyResources(Me.tbFittingMethod, "tbFittingMethod")
        Me.tbFittingMethod.Name = "tbFittingMethod"
        Me.tbFittingMethod.UseVisualStyleBackColor = True
        '
        'rdoMme
        '
        resources.ApplyResources(Me.rdoMme, "rdoMme")
        Me.rdoMme.Name = "rdoMme"
        Me.rdoMme.TabStop = True
        Me.rdoMme.UseVisualStyleBackColor = True
        '
        'rdoQme
        '
        resources.ApplyResources(Me.rdoQme, "rdoQme")
        Me.rdoQme.Name = "rdoQme"
        Me.rdoQme.TabStop = True
        Me.rdoQme.UseVisualStyleBackColor = True
        '
        'rdoMle
        '
        resources.ApplyResources(Me.rdoMle, "rdoMle")
        Me.rdoMle.Name = "rdoMle"
        Me.rdoMle.TabStop = True
        Me.rdoMle.UseVisualStyleBackColor = True
        '
        'rdoMge
        '
        resources.ApplyResources(Me.rdoMge, "rdoMge")
        Me.rdoMge.Name = "rdoMge"
        Me.rdoMge.TabStop = True
        Me.rdoMge.UseVisualStyleBackColor = True
        '
        'ucrPnlFitMethod
        '
        resources.ApplyResources(Me.ucrPnlFitMethod, "ucrPnlFitMethod")
        Me.ucrPnlFitMethod.Name = "ucrPnlFitMethod"
        '
        'tbOptimisationMethod
        '
        Me.tbOptimisationMethod.Controls.Add(Me.rdoSANN)
        Me.tbOptimisationMethod.Controls.Add(Me.rdoDefault)
        Me.tbOptimisationMethod.Controls.Add(Me.rdoCG)
        Me.tbOptimisationMethod.Controls.Add(Me.rdoNelderMead)
        Me.tbOptimisationMethod.Controls.Add(Me.rdoBFGS)
        Me.tbOptimisationMethod.Controls.Add(Me.ucrPnlOptimisation)
        resources.ApplyResources(Me.tbOptimisationMethod, "tbOptimisationMethod")
        Me.tbOptimisationMethod.Name = "tbOptimisationMethod"
        Me.tbOptimisationMethod.UseVisualStyleBackColor = True
        '
        'rdoSANN
        '
        resources.ApplyResources(Me.rdoSANN, "rdoSANN")
        Me.rdoSANN.Name = "rdoSANN"
        Me.rdoSANN.TabStop = True
        Me.rdoSANN.UseVisualStyleBackColor = True
        '
        'rdoDefault
        '
        resources.ApplyResources(Me.rdoDefault, "rdoDefault")
        Me.rdoDefault.Name = "rdoDefault"
        Me.rdoDefault.TabStop = True
        Me.rdoDefault.UseVisualStyleBackColor = True
        '
        'rdoCG
        '
        resources.ApplyResources(Me.rdoCG, "rdoCG")
        Me.rdoCG.Name = "rdoCG"
        Me.rdoCG.TabStop = True
        Me.rdoCG.UseVisualStyleBackColor = True
        '
        'rdoNelderMead
        '
        resources.ApplyResources(Me.rdoNelderMead, "rdoNelderMead")
        Me.rdoNelderMead.Name = "rdoNelderMead"
        Me.rdoNelderMead.TabStop = True
        Me.rdoNelderMead.UseVisualStyleBackColor = True
        '
        'rdoBFGS
        '
        resources.ApplyResources(Me.rdoBFGS, "rdoBFGS")
        Me.rdoBFGS.Name = "rdoBFGS"
        Me.rdoBFGS.TabStop = True
        Me.rdoBFGS.UseVisualStyleBackColor = True
        '
        'ucrPnlOptimisation
        '
        resources.ApplyResources(Me.ucrPnlOptimisation, "ucrPnlOptimisation")
        Me.ucrPnlOptimisation.Name = "ucrPnlOptimisation"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'sdgOneVarFitModel
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.tbFittingOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgOneVarFitModel"
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
