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
        Me.chkSaveChi = New System.Windows.Forms.CheckBox()
        Me.ucrDisplayChiData = New instat.ucrInputTextBox()
        Me.grpFitModel = New System.Windows.Forms.GroupBox()
        Me.ucrSaveGOF = New instat.ucrSave()
        Me.ucrChkInputChiSquareBreakpoints = New instat.ucrCheck()
        Me.grpPlot = New System.Windows.Forms.GroupBox()
        Me.ucrChkCDF = New instat.ucrCheck()
        Me.ucrChkDensity = New instat.ucrCheck()
        Me.ucrChkPP = New instat.ucrCheck()
        Me.ucrChkQQ = New instat.ucrCheck()
        Me.ucrSavePlots = New instat.ucrSave()
        Me.grpFitModel.SuspendLayout()
        Me.grpPlot.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrSubBase
        '
        Me.ucrSubBase.Location = New System.Drawing.Point(89, 276)
        Me.ucrSubBase.Name = "ucrSubBase"
        Me.ucrSubBase.Size = New System.Drawing.Size(142, 30)
        Me.ucrSubBase.TabIndex = 2
        '
        'chkSaveChi
        '
        Me.chkSaveChi.AutoSize = True
        Me.chkSaveChi.Location = New System.Drawing.Point(6, 44)
        Me.chkSaveChi.Name = "chkSaveChi"
        Me.chkSaveChi.Size = New System.Drawing.Size(115, 17)
        Me.chkSaveChi.TabIndex = 1
        Me.chkSaveChi.Text = "Display Chi-Square"
        Me.chkSaveChi.UseVisualStyleBackColor = True
        '
        'ucrDisplayChiData
        '
        Me.ucrDisplayChiData.IsMultiline = False
        Me.ucrDisplayChiData.IsReadOnly = False
        Me.ucrDisplayChiData.Location = New System.Drawing.Point(127, 42)
        Me.ucrDisplayChiData.Name = "ucrDisplayChiData"
        Me.ucrDisplayChiData.Size = New System.Drawing.Size(139, 21)
        Me.ucrDisplayChiData.TabIndex = 2
        '
        'grpFitModel
        '
        Me.grpFitModel.Controls.Add(Me.ucrDisplayChiData)
        Me.grpFitModel.Controls.Add(Me.ucrSaveGOF)
        Me.grpFitModel.Controls.Add(Me.chkSaveChi)
        Me.grpFitModel.Controls.Add(Me.ucrChkInputChiSquareBreakpoints)
        Me.grpFitModel.Location = New System.Drawing.Point(12, 12)
        Me.grpFitModel.Name = "grpFitModel"
        Me.grpFitModel.Size = New System.Drawing.Size(273, 100)
        Me.grpFitModel.TabIndex = 0
        Me.grpFitModel.TabStop = False
        Me.grpFitModel.Text = "Goodness of Fit"
        '
        'ucrSaveGOF
        '
        Me.ucrSaveGOF.Location = New System.Drawing.Point(6, 19)
        Me.ucrSaveGOF.Name = "ucrSaveGOF"
        Me.ucrSaveGOF.Size = New System.Drawing.Size(260, 24)
        Me.ucrSaveGOF.TabIndex = 0
        '
        'ucrChkInputChiSquareBreakpoints
        '
        Me.ucrChkInputChiSquareBreakpoints.Checked = False
        Me.ucrChkInputChiSquareBreakpoints.Location = New System.Drawing.Point(6, 69)
        Me.ucrChkInputChiSquareBreakpoints.Name = "ucrChkInputChiSquareBreakpoints"
        Me.ucrChkInputChiSquareBreakpoints.Size = New System.Drawing.Size(229, 20)
        Me.ucrChkInputChiSquareBreakpoints.TabIndex = 3
        '
        'grpPlot
        '
        Me.grpPlot.Controls.Add(Me.ucrSavePlots)
        Me.grpPlot.Controls.Add(Me.ucrChkQQ)
        Me.grpPlot.Controls.Add(Me.ucrChkPP)
        Me.grpPlot.Controls.Add(Me.ucrChkDensity)
        Me.grpPlot.Controls.Add(Me.ucrChkCDF)
        Me.grpPlot.Location = New System.Drawing.Point(12, 118)
        Me.grpPlot.Name = "grpPlot"
        Me.grpPlot.Size = New System.Drawing.Size(273, 152)
        Me.grpPlot.TabIndex = 1
        Me.grpPlot.TabStop = False
        Me.grpPlot.Text = "Plot"
        '
        'ucrChkCDF
        '
        Me.ucrChkCDF.Checked = False
        Me.ucrChkCDF.Location = New System.Drawing.Point(6, 20)
        Me.ucrChkCDF.Name = "ucrChkCDF"
        Me.ucrChkCDF.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkCDF.TabIndex = 0
        '
        'ucrChkDensity
        '
        Me.ucrChkDensity.Checked = False
        Me.ucrChkDensity.Location = New System.Drawing.Point(6, 46)
        Me.ucrChkDensity.Name = "ucrChkDensity"
        Me.ucrChkDensity.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkDensity.TabIndex = 1
        '
        'ucrChkPP
        '
        Me.ucrChkPP.Checked = False
        Me.ucrChkPP.Location = New System.Drawing.Point(6, 72)
        Me.ucrChkPP.Name = "ucrChkPP"
        Me.ucrChkPP.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkPP.TabIndex = 2
        '
        'ucrChkQQ
        '
        Me.ucrChkQQ.Checked = False
        Me.ucrChkQQ.Location = New System.Drawing.Point(6, 98)
        Me.ucrChkQQ.Name = "ucrChkQQ"
        Me.ucrChkQQ.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkQQ.TabIndex = 3
        '
        'ucrSavePlots
        '
        Me.ucrSavePlots.Location = New System.Drawing.Point(6, 122)
        Me.ucrSavePlots.Name = "ucrSavePlots"
        Me.ucrSavePlots.Size = New System.Drawing.Size(260, 24)
        Me.ucrSavePlots.TabIndex = 4
        '
        'sdgOneVarCompareModels
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(296, 318)
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrSubBase As ucrButtonsSubdialogue
    Friend WithEvents chkSaveChi As CheckBox
    Friend WithEvents ucrDisplayChiData As ucrInputTextBox
    Friend WithEvents grpFitModel As GroupBox
    Friend WithEvents grpPlot As GroupBox
    Friend WithEvents ucrChkInputChiSquareBreakpoints As ucrCheck
    Friend WithEvents ucrChkCDF As ucrCheck
    Friend WithEvents ucrChkDensity As ucrCheck
    Friend WithEvents ucrChkPP As ucrCheck
    Friend WithEvents ucrChkQQ As ucrCheck
    Friend WithEvents ucrSaveGOF As ucrSave
    Friend WithEvents ucrSavePlots As ucrSave
End Class
