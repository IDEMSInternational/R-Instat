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
        Me.lblGoF = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ucrObjectName = New instat.ucrInputTextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ucrSavePlots = New instat.ucrSaveGraph()
        Me.chkQQ = New System.Windows.Forms.CheckBox()
        Me.chkCDF = New System.Windows.Forms.CheckBox()
        Me.chkPP = New System.Windows.Forms.CheckBox()
        Me.chkDensity = New System.Windows.Forms.CheckBox()
        Me.ucrDisplayChiData = New instat.ucrInputTextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrSubBase
        '
        Me.ucrSubBase.Location = New System.Drawing.Point(14, 168)
        Me.ucrSubBase.Name = "ucrSubBase"
        Me.ucrSubBase.Size = New System.Drawing.Size(142, 30)
        Me.ucrSubBase.TabIndex = 0
        '
        'chkSaveObjects
        '
        Me.chkSaveObjects.AutoSize = True
        Me.chkSaveObjects.Location = New System.Drawing.Point(6, 29)
        Me.chkSaveObjects.Name = "chkSaveObjects"
        Me.chkSaveObjects.Size = New System.Drawing.Size(85, 17)
        Me.chkSaveObjects.TabIndex = 1
        Me.chkSaveObjects.Text = "Save Object"
        Me.chkSaveObjects.UseVisualStyleBackColor = True
        '
        'chkSaveChi
        '
        Me.chkSaveChi.AutoSize = True
        Me.chkSaveChi.Location = New System.Drawing.Point(6, 52)
        Me.chkSaveChi.Name = "chkSaveChi"
        Me.chkSaveChi.Size = New System.Drawing.Size(115, 17)
        Me.chkSaveChi.TabIndex = 2
        Me.chkSaveChi.Text = "Display Chi-Square"
        Me.chkSaveChi.UseVisualStyleBackColor = True
        '
        'chkInputBreakpoints
        '
        Me.chkInputBreakpoints.AutoSize = True
        Me.chkInputBreakpoints.Location = New System.Drawing.Point(6, 75)
        Me.chkInputBreakpoints.Name = "chkInputBreakpoints"
        Me.chkInputBreakpoints.Size = New System.Drawing.Size(164, 17)
        Me.chkInputBreakpoints.TabIndex = 3
        Me.chkInputBreakpoints.Text = "Input Chi-Square Breakpoints"
        Me.chkInputBreakpoints.UseVisualStyleBackColor = True
        '
        'lblGoF
        '
        Me.lblGoF.AutoSize = True
        Me.lblGoF.Location = New System.Drawing.Point(6, 10)
        Me.lblGoF.Name = "lblGoF"
        Me.lblGoF.Size = New System.Drawing.Size(126, 13)
        Me.lblGoF.TabIndex = 4
        Me.lblGoF.Text = "Goodness of Fit Statistics"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(10, 10)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(299, 152)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ucrDisplayChiData)
        Me.TabPage1.Controls.Add(Me.ucrObjectName)
        Me.TabPage1.Controls.Add(Me.chkSaveObjects)
        Me.TabPage1.Controls.Add(Me.lblGoF)
        Me.TabPage1.Controls.Add(Me.chkSaveChi)
        Me.TabPage1.Controls.Add(Me.chkInputBreakpoints)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(291, 126)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Fit"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ucrObjectName
        '
        Me.ucrObjectName.IsReadOnly = False
        Me.ucrObjectName.Location = New System.Drawing.Point(129, 27)
        Me.ucrObjectName.Name = "ucrObjectName"
        Me.ucrObjectName.Size = New System.Drawing.Size(139, 21)
        Me.ucrObjectName.TabIndex = 5
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ucrSavePlots)
        Me.TabPage2.Controls.Add(Me.chkQQ)
        Me.TabPage2.Controls.Add(Me.chkCDF)
        Me.TabPage2.Controls.Add(Me.chkPP)
        Me.TabPage2.Controls.Add(Me.chkDensity)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(291, 126)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Plot"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ucrSavePlots
        '
        Me.ucrSavePlots.Location = New System.Drawing.Point(6, 95)
        Me.ucrSavePlots.Name = "ucrSavePlots"
        Me.ucrSavePlots.Size = New System.Drawing.Size(265, 22)
        Me.ucrSavePlots.TabIndex = 10
        '
        'chkQQ
        '
        Me.chkQQ.AutoSize = True
        Me.chkQQ.Location = New System.Drawing.Point(6, 75)
        Me.chkQQ.Name = "chkQQ"
        Me.chkQQ.Size = New System.Drawing.Size(42, 17)
        Me.chkQQ.TabIndex = 9
        Me.chkQQ.Text = "QQ"
        Me.chkQQ.UseVisualStyleBackColor = True
        '
        'chkCDF
        '
        Me.chkCDF.AutoSize = True
        Me.chkCDF.Location = New System.Drawing.Point(6, 6)
        Me.chkCDF.Name = "chkCDF"
        Me.chkCDF.Size = New System.Drawing.Size(47, 17)
        Me.chkCDF.TabIndex = 6
        Me.chkCDF.Text = "CDF"
        Me.chkCDF.UseVisualStyleBackColor = True
        '
        'chkPP
        '
        Me.chkPP.AutoSize = True
        Me.chkPP.Location = New System.Drawing.Point(6, 52)
        Me.chkPP.Name = "chkPP"
        Me.chkPP.Size = New System.Drawing.Size(40, 17)
        Me.chkPP.TabIndex = 8
        Me.chkPP.Text = "PP"
        Me.chkPP.UseVisualStyleBackColor = True
        '
        'chkDensity
        '
        Me.chkDensity.AutoSize = True
        Me.chkDensity.Location = New System.Drawing.Point(6, 29)
        Me.chkDensity.Name = "chkDensity"
        Me.chkDensity.Size = New System.Drawing.Size(61, 17)
        Me.chkDensity.TabIndex = 7
        Me.chkDensity.Text = "Density"
        Me.chkDensity.UseVisualStyleBackColor = True
        '
        'ucrDisplayChiData
        '
        Me.ucrDisplayChiData.IsReadOnly = False
        Me.ucrDisplayChiData.Location = New System.Drawing.Point(129, 51)
        Me.ucrDisplayChiData.Name = "ucrDisplayChiData"
        Me.ucrDisplayChiData.Size = New System.Drawing.Size(139, 21)
        Me.ucrDisplayChiData.TabIndex = 6
        '
        'sdgOneVarCompareModels
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 200)
        Me.Controls.Add(Me.ucrSubBase)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgOneVarCompareModels"
        Me.Text = "Display Options"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrSubBase As ucrButtonsSubdialogue
    Friend WithEvents chkSaveObjects As CheckBox
    Friend WithEvents chkSaveChi As CheckBox
    Friend WithEvents chkInputBreakpoints As CheckBox
    Friend WithEvents lblGoF As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents chkCDF As CheckBox
    Friend WithEvents chkDensity As CheckBox
    Friend WithEvents chkPP As CheckBox
    Friend WithEvents chkQQ As CheckBox
    Friend WithEvents ucrObjectName As ucrInputTextBox
    Friend WithEvents ucrSavePlots As ucrSaveGraph
    Friend WithEvents ucrDisplayChiData As ucrInputTextBox
End Class
