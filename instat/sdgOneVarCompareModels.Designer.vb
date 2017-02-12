<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sdgOneVarCompareModels
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
        Me.ucrSubBase = New instat.ucrButtonsSubdialogue()
        Me.chkSaveObjects = New System.Windows.Forms.CheckBox()
        Me.chkSaveChi = New System.Windows.Forms.CheckBox()
        Me.chkInputBreakpoints = New System.Windows.Forms.CheckBox()
        Me.ucrDisplayChiData = New instat.ucrInputTextBox()
        Me.ucrObjectName = New instat.ucrInputTextBox()
        Me.ucrSavePlots = New instat.ucrSaveGraph()
        Me.chkQQ = New System.Windows.Forms.CheckBox()
        Me.chkCDF = New System.Windows.Forms.CheckBox()
        Me.chkPP = New System.Windows.Forms.CheckBox()
        Me.chkDensity = New System.Windows.Forms.CheckBox()
        Me.grpFitModel = New System.Windows.Forms.GroupBox()
        Me.grpPlot = New System.Windows.Forms.GroupBox()
        Me.grpFitModel.SuspendLayout()
        Me.grpPlot.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrSubBase
        '
        Me.ucrSubBase.Location = New System.Drawing.Point(89, 276)
        Me.ucrSubBase.Name = "ucrSubBase"
        Me.ucrSubBase.Size = New System.Drawing.Size(142, 30)
        Me.ucrSubBase.TabIndex = 1
        '
        'chkSaveObjects
        '
        Me.chkSaveObjects.AutoSize = True
        Me.chkSaveObjects.Location = New System.Drawing.Point(6, 19)
        Me.chkSaveObjects.Name = "chkSaveObjects"
        Me.chkSaveObjects.Size = New System.Drawing.Size(85, 17)
        Me.chkSaveObjects.TabIndex = 1
        Me.chkSaveObjects.Text = "Save Object"
        Me.chkSaveObjects.UseVisualStyleBackColor = True
        '
        'chkSaveChi
        '
        Me.chkSaveChi.AutoSize = True
        Me.chkSaveChi.Location = New System.Drawing.Point(6, 44)
        Me.chkSaveChi.Name = "chkSaveChi"
        Me.chkSaveChi.Size = New System.Drawing.Size(115, 17)
        Me.chkSaveChi.TabIndex = 3
        Me.chkSaveChi.Text = "Display Chi-Square"
        Me.chkSaveChi.UseVisualStyleBackColor = True
        '
        'chkInputBreakpoints
        '
        Me.chkInputBreakpoints.AutoSize = True
        Me.chkInputBreakpoints.Location = New System.Drawing.Point(6, 69)
        Me.chkInputBreakpoints.Name = "chkInputBreakpoints"
        Me.chkInputBreakpoints.Size = New System.Drawing.Size(164, 17)
        Me.chkInputBreakpoints.TabIndex = 5
        Me.chkInputBreakpoints.Text = "Input Chi-Square Breakpoints"
        Me.chkInputBreakpoints.UseVisualStyleBackColor = True
        '
        'ucrDisplayChiData
        '
        Me.ucrDisplayChiData.IsMultiline = False
        Me.ucrDisplayChiData.IsReadOnly = False
        Me.ucrDisplayChiData.Location = New System.Drawing.Point(127, 42)
        Me.ucrDisplayChiData.Name = "ucrDisplayChiData"
        Me.ucrDisplayChiData.Size = New System.Drawing.Size(139, 21)
        Me.ucrDisplayChiData.TabIndex = 4
        '
        'ucrObjectName
        '
        Me.ucrObjectName.IsMultiline = False
        Me.ucrObjectName.IsReadOnly = False
        Me.ucrObjectName.Location = New System.Drawing.Point(127, 15)
        Me.ucrObjectName.Name = "ucrObjectName"
        Me.ucrObjectName.Size = New System.Drawing.Size(139, 21)
        Me.ucrObjectName.TabIndex = 2
        '
        'ucrSavePlots
        '
        Me.ucrSavePlots.Location = New System.Drawing.Point(6, 112)
        Me.ucrSavePlots.Name = "ucrSavePlots"
        Me.ucrSavePlots.Size = New System.Drawing.Size(265, 22)
        Me.ucrSavePlots.TabIndex = 4
        '
        'chkQQ
        '
        Me.chkQQ.AutoSize = True
        Me.chkQQ.Location = New System.Drawing.Point(6, 89)
        Me.chkQQ.Name = "chkQQ"
        Me.chkQQ.Size = New System.Drawing.Size(42, 17)
        Me.chkQQ.TabIndex = 3
        Me.chkQQ.Text = "QQ"
        Me.chkQQ.UseVisualStyleBackColor = True
        '
        'chkCDF
        '
        Me.chkCDF.AutoSize = True
        Me.chkCDF.Location = New System.Drawing.Point(6, 20)
        Me.chkCDF.Name = "chkCDF"
        Me.chkCDF.Size = New System.Drawing.Size(47, 17)
        Me.chkCDF.TabIndex = 0
        Me.chkCDF.Text = "CDF"
        Me.chkCDF.UseVisualStyleBackColor = True
        '
        'chkPP
        '
        Me.chkPP.AutoSize = True
        Me.chkPP.Location = New System.Drawing.Point(6, 66)
        Me.chkPP.Name = "chkPP"
        Me.chkPP.Size = New System.Drawing.Size(40, 17)
        Me.chkPP.TabIndex = 2
        Me.chkPP.Text = "PP"
        Me.chkPP.UseVisualStyleBackColor = True
        '
        'chkDensity
        '
        Me.chkDensity.AutoSize = True
        Me.chkDensity.Location = New System.Drawing.Point(6, 43)
        Me.chkDensity.Name = "chkDensity"
        Me.chkDensity.Size = New System.Drawing.Size(61, 17)
        Me.chkDensity.TabIndex = 1
        Me.chkDensity.Text = "Density"
        Me.chkDensity.UseVisualStyleBackColor = True
        '
        'grpFitModel
        '
        Me.grpFitModel.Controls.Add(Me.ucrDisplayChiData)
        Me.grpFitModel.Controls.Add(Me.chkInputBreakpoints)
        Me.grpFitModel.Controls.Add(Me.chkSaveChi)
        Me.grpFitModel.Controls.Add(Me.chkSaveObjects)
        Me.grpFitModel.Controls.Add(Me.ucrObjectName)
        Me.grpFitModel.Location = New System.Drawing.Point(12, 12)
        Me.grpFitModel.Name = "grpFitModel"
        Me.grpFitModel.Size = New System.Drawing.Size(273, 100)
        Me.grpFitModel.TabIndex = 2
        Me.grpFitModel.TabStop = False
        Me.grpFitModel.Text = "Goodness of Fit"
        '
        'grpPlot
        '
        Me.grpPlot.Controls.Add(Me.ucrSavePlots)
        Me.grpPlot.Controls.Add(Me.chkQQ)
        Me.grpPlot.Controls.Add(Me.chkDensity)
        Me.grpPlot.Controls.Add(Me.chkCDF)
        Me.grpPlot.Controls.Add(Me.chkPP)
        Me.grpPlot.Location = New System.Drawing.Point(12, 118)
        Me.grpPlot.Name = "grpPlot"
        Me.grpPlot.Size = New System.Drawing.Size(273, 152)
        Me.grpPlot.TabIndex = 0
        Me.grpPlot.TabStop = False
        Me.grpPlot.Text = "Plot"
        '
        'sdgOneVarCompareModels
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 318)
        Me.Controls.Add(Me.grpPlot)
        Me.Controls.Add(Me.grpFitModel)
        Me.Controls.Add(Me.ucrSubBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgOneVarCompareModels"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Display Options"
        Me.grpFitModel.ResumeLayout(False)
        Me.grpFitModel.PerformLayout()
        Me.grpPlot.ResumeLayout(False)
        Me.grpPlot.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrSubBase As ucrButtonsSubdialogue
    Friend WithEvents chkSaveObjects As CheckBox
    Friend WithEvents chkSaveChi As CheckBox
    Friend WithEvents chkInputBreakpoints As CheckBox
    Friend WithEvents chkCDF As CheckBox
    Friend WithEvents chkDensity As CheckBox
    Friend WithEvents chkPP As CheckBox
    Friend WithEvents chkQQ As CheckBox
    Friend WithEvents ucrObjectName As ucrInputTextBox
    Friend WithEvents ucrSavePlots As ucrSaveGraph
    Friend WithEvents ucrDisplayChiData As ucrInputTextBox
    Friend WithEvents grpFitModel As GroupBox
    Friend WithEvents grpPlot As GroupBox
End Class
