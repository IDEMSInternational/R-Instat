<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgANOVAOptions
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
        Me.tbcOptions = New System.Windows.Forms.TabControl()
        Me.tbpDisplay = New System.Windows.Forms.TabPage()
        Me.chkTableOfMeans = New System.Windows.Forms.CheckBox()
        Me.chkEstimateValues = New System.Windows.Forms.CheckBox()
        Me.chkANOVATable = New System.Windows.Forms.CheckBox()
        Me.tbpGraphics = New System.Windows.Forms.TabPage()
        Me.chkMeans = New System.Windows.Forms.CheckBox()
        Me.chkResiduals = New System.Windows.Forms.CheckBox()
        Me.ucrBaseSdg = New instat.ucrButtonsSubdialogue()
        Me.tbcOptions.SuspendLayout()
        Me.tbpDisplay.SuspendLayout()
        Me.tbpGraphics.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbcOptions
        '
        Me.tbcOptions.Controls.Add(Me.tbpDisplay)
        Me.tbcOptions.Controls.Add(Me.tbpGraphics)
        Me.tbcOptions.Location = New System.Drawing.Point(-1, -1)
        Me.tbcOptions.Name = "tbcOptions"
        Me.tbcOptions.SelectedIndex = 0
        Me.tbcOptions.Size = New System.Drawing.Size(292, 165)
        Me.tbcOptions.TabIndex = 1
        '
        'tbpDisplay
        '
        Me.tbpDisplay.Controls.Add(Me.chkTableOfMeans)
        Me.tbpDisplay.Controls.Add(Me.chkEstimateValues)
        Me.tbpDisplay.Controls.Add(Me.chkANOVATable)
        Me.tbpDisplay.Location = New System.Drawing.Point(4, 22)
        Me.tbpDisplay.Name = "tbpDisplay"
        Me.tbpDisplay.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpDisplay.Size = New System.Drawing.Size(284, 139)
        Me.tbpDisplay.TabIndex = 0
        Me.tbpDisplay.Tag = "Display"
        Me.tbpDisplay.Text = "Display"
        Me.tbpDisplay.UseVisualStyleBackColor = True
        '
        'chkTableOfMeans
        '
        Me.chkTableOfMeans.AutoSize = True
        Me.chkTableOfMeans.Location = New System.Drawing.Point(9, 105)
        Me.chkTableOfMeans.Name = "chkTableOfMeans"
        Me.chkTableOfMeans.Size = New System.Drawing.Size(99, 17)
        Me.chkTableOfMeans.TabIndex = 5
        Me.chkTableOfMeans.Tag = "Table_of_means"
        Me.chkTableOfMeans.Text = "Table of means"
        Me.chkTableOfMeans.UseVisualStyleBackColor = True
        '
        'chkEstimateValues
        '
        Me.chkEstimateValues.AutoSize = True
        Me.chkEstimateValues.Location = New System.Drawing.Point(10, 62)
        Me.chkEstimateValues.Name = "chkEstimateValues"
        Me.chkEstimateValues.Size = New System.Drawing.Size(67, 17)
        Me.chkEstimateValues.TabIndex = 4
        Me.chkEstimateValues.Tag = "P_values"
        Me.chkEstimateValues.Text = "P values"
        Me.chkEstimateValues.UseVisualStyleBackColor = True
        '
        'chkANOVATable
        '
        Me.chkANOVATable.AutoSize = True
        Me.chkANOVATable.Location = New System.Drawing.Point(10, 20)
        Me.chkANOVATable.Name = "chkANOVATable"
        Me.chkANOVATable.Size = New System.Drawing.Size(93, 17)
        Me.chkANOVATable.TabIndex = 1
        Me.chkANOVATable.Tag = "ANOVA Table"
        Me.chkANOVATable.Text = "ANOVA Table"
        Me.chkANOVATable.UseVisualStyleBackColor = True
        '
        'tbpGraphics
        '
        Me.tbpGraphics.Controls.Add(Me.chkMeans)
        Me.tbpGraphics.Controls.Add(Me.chkResiduals)
        Me.tbpGraphics.Location = New System.Drawing.Point(4, 22)
        Me.tbpGraphics.Name = "tbpGraphics"
        Me.tbpGraphics.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpGraphics.Size = New System.Drawing.Size(175, 155)
        Me.tbpGraphics.TabIndex = 1
        Me.tbpGraphics.Tag = "Graphics"
        Me.tbpGraphics.Text = "Graphics"
        Me.tbpGraphics.UseVisualStyleBackColor = True
        '
        'chkMeans
        '
        Me.chkMeans.AutoSize = True
        Me.chkMeans.Location = New System.Drawing.Point(18, 71)
        Me.chkMeans.Name = "chkMeans"
        Me.chkMeans.Size = New System.Drawing.Size(58, 17)
        Me.chkMeans.TabIndex = 1
        Me.chkMeans.Tag = "Means"
        Me.chkMeans.Text = "Means"
        Me.chkMeans.UseVisualStyleBackColor = True
        '
        'chkResiduals
        '
        Me.chkResiduals.AutoSize = True
        Me.chkResiduals.Location = New System.Drawing.Point(18, 24)
        Me.chkResiduals.Name = "chkResiduals"
        Me.chkResiduals.Size = New System.Drawing.Size(72, 17)
        Me.chkResiduals.TabIndex = 0
        Me.chkResiduals.Tag = "Residuals"
        Me.chkResiduals.Text = "Residuals"
        Me.chkResiduals.UseVisualStyleBackColor = True
        '
        'ucrBaseSdg
        '
        Me.ucrBaseSdg.Location = New System.Drawing.Point(48, 170)
        Me.ucrBaseSdg.Name = "ucrBaseSdg"
        Me.ucrBaseSdg.Size = New System.Drawing.Size(142, 30)
        Me.ucrBaseSdg.TabIndex = 2
        '
        'sdgANOVAOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 208)
        Me.Controls.Add(Me.ucrBaseSdg)
        Me.Controls.Add(Me.tbcOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "sdgANOVAOptions"
        Me.Tag = "ANOVA_options"
        Me.Text = "ANOVA options"
        Me.tbcOptions.ResumeLayout(False)
        Me.tbpDisplay.ResumeLayout(False)
        Me.tbpDisplay.PerformLayout()
        Me.tbpGraphics.ResumeLayout(False)
        Me.tbpGraphics.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBaseSubdialog As ucrButtonsSubdialogue
    Friend WithEvents tbcOptions As TabControl
    Friend WithEvents tbpDisplay As TabPage
    Friend WithEvents chkTableOfMeans As CheckBox
    Friend WithEvents chkEstimateValues As CheckBox
    Friend WithEvents chkANOVATable As CheckBox
    Friend WithEvents tbpGraphics As TabPage
    Friend WithEvents chkMeans As CheckBox
    Friend WithEvents chkResiduals As CheckBox
    Friend WithEvents ucrBaseSdg As ucrButtonsSubdialogue
End Class
