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
Partial Class sdgModelOptions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgModelOptions))
        Me.rdoCloglog = New System.Windows.Forms.RadioButton()
        Me.rdoSqrt = New System.Windows.Forms.RadioButton()
        Me.rdoMuSquaredInverse = New System.Windows.Forms.RadioButton()
        Me.rdoInverse = New System.Windows.Forms.RadioButton()
        Me.rdoCauchit = New System.Windows.Forms.RadioButton()
        Me.rdoProbit = New System.Windows.Forms.RadioButton()
        Me.grpLinkFunctions = New System.Windows.Forms.GroupBox()
        Me.rdoIdentity = New System.Windows.Forms.RadioButton()
        Me.rdoLog = New System.Windows.Forms.RadioButton()
        Me.rdoLogit = New System.Windows.Forms.RadioButton()
        Me.ucrPnlLinkFunctions = New instat.UcrPanel()
        Me.ucrDistributionChoice = New instat.ucrDistributions()
        Me.ucrButtonsSDGModelOptions = New instat.ucrButtonsSubdialogue()
        Me.grpLinkFunctions.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoCloglog
        '
        resources.ApplyResources(Me.rdoCloglog, "rdoCloglog")
        Me.rdoCloglog.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdoCloglog.Name = "rdoCloglog"
        Me.rdoCloglog.Tag = "cloglog"
        Me.rdoCloglog.UseVisualStyleBackColor = True
        '
        'rdoSqrt
        '
        resources.ApplyResources(Me.rdoSqrt, "rdoSqrt")
        Me.rdoSqrt.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdoSqrt.Name = "rdoSqrt"
        Me.rdoSqrt.Tag = "Sqrt"
        Me.rdoSqrt.UseVisualStyleBackColor = True
        '
        'rdoMuSquaredInverse
        '
        resources.ApplyResources(Me.rdoMuSquaredInverse, "rdoMuSquaredInverse")
        Me.rdoMuSquaredInverse.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdoMuSquaredInverse.Name = "rdoMuSquaredInverse"
        Me.rdoMuSquaredInverse.Tag = "1/mu^2"
        Me.rdoMuSquaredInverse.UseVisualStyleBackColor = True
        '
        'rdoInverse
        '
        resources.ApplyResources(Me.rdoInverse, "rdoInverse")
        Me.rdoInverse.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdoInverse.Name = "rdoInverse"
        Me.rdoInverse.Tag = "Inverse"
        Me.rdoInverse.UseVisualStyleBackColor = True
        '
        'rdoCauchit
        '
        resources.ApplyResources(Me.rdoCauchit, "rdoCauchit")
        Me.rdoCauchit.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdoCauchit.Name = "rdoCauchit"
        Me.rdoCauchit.Tag = "Cauchit"
        Me.rdoCauchit.UseVisualStyleBackColor = True
        '
        'rdoProbit
        '
        resources.ApplyResources(Me.rdoProbit, "rdoProbit")
        Me.rdoProbit.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdoProbit.Name = "rdoProbit"
        Me.rdoProbit.Tag = "Probit"
        Me.rdoProbit.UseVisualStyleBackColor = True
        '
        'grpLinkFunctions
        '
        Me.grpLinkFunctions.Controls.Add(Me.rdoIdentity)
        Me.grpLinkFunctions.Controls.Add(Me.rdoLog)
        Me.grpLinkFunctions.Controls.Add(Me.rdoLogit)
        Me.grpLinkFunctions.Controls.Add(Me.rdoCloglog)
        Me.grpLinkFunctions.Controls.Add(Me.rdoSqrt)
        Me.grpLinkFunctions.Controls.Add(Me.rdoMuSquaredInverse)
        Me.grpLinkFunctions.Controls.Add(Me.rdoInverse)
        Me.grpLinkFunctions.Controls.Add(Me.rdoCauchit)
        Me.grpLinkFunctions.Controls.Add(Me.rdoProbit)
        Me.grpLinkFunctions.Controls.Add(Me.ucrPnlLinkFunctions)
        resources.ApplyResources(Me.grpLinkFunctions, "grpLinkFunctions")
        Me.grpLinkFunctions.Name = "grpLinkFunctions"
        Me.grpLinkFunctions.TabStop = False
        '
        'rdoIdentity
        '
        resources.ApplyResources(Me.rdoIdentity, "rdoIdentity")
        Me.rdoIdentity.Name = "rdoIdentity"
        Me.rdoIdentity.UseVisualStyleBackColor = True
        '
        'rdoLog
        '
        resources.ApplyResources(Me.rdoLog, "rdoLog")
        Me.rdoLog.Name = "rdoLog"
        Me.rdoLog.UseVisualStyleBackColor = True
        '
        'rdoLogit
        '
        resources.ApplyResources(Me.rdoLogit, "rdoLogit")
        Me.rdoLogit.Name = "rdoLogit"
        Me.rdoLogit.UseVisualStyleBackColor = True
        '
        'ucrPnlLinkFunctions
        '
        resources.ApplyResources(Me.ucrPnlLinkFunctions, "ucrPnlLinkFunctions")
        Me.ucrPnlLinkFunctions.Name = "ucrPnlLinkFunctions"
        '
        'ucrDistributionChoice
        '
        resources.ApplyResources(Me.ucrDistributionChoice, "ucrDistributionChoice")
        Me.ucrDistributionChoice.Name = "ucrDistributionChoice"
        '
        'ucrButtonsSDGModelOptions
        '
        resources.ApplyResources(Me.ucrButtonsSDGModelOptions, "ucrButtonsSDGModelOptions")
        Me.ucrButtonsSDGModelOptions.Name = "ucrButtonsSDGModelOptions"
        '
        'sdgModelOptions
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrDistributionChoice)
        Me.Controls.Add(Me.grpLinkFunctions)
        Me.Controls.Add(Me.ucrButtonsSDGModelOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgModelOptions"
        Me.Tag = "Model_Options"
        Me.grpLinkFunctions.ResumeLayout(False)
        Me.grpLinkFunctions.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrButtonsSDGModelOptions As ucrButtonsSubdialogue
    Friend WithEvents rdoCloglog As RadioButton
    Friend WithEvents rdoSqrt As RadioButton
    Friend WithEvents rdoMuSquaredInverse As RadioButton
    Friend WithEvents rdoInverse As RadioButton
    Friend WithEvents rdoCauchit As RadioButton
    Friend WithEvents rdoProbit As RadioButton
    Friend WithEvents ucrPnlLinkFunctions As UcrPanel
    Friend WithEvents grpLinkFunctions As GroupBox
    Friend WithEvents ucrDistributionChoice As ucrDistributions
    Friend WithEvents rdoIdentity As RadioButton
    Friend WithEvents rdoLog As RadioButton
    Friend WithEvents rdoLogit As RadioButton
End Class
