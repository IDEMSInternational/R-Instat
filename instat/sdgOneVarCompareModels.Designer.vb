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
        Me.ucrBase = New instat.ucrButtonsSubdialogue()
        Me.chkSaveObjects = New System.Windows.Forms.CheckBox()
        Me.chkSaveChi = New System.Windows.Forms.CheckBox()
        Me.chkInputBreakpoints = New System.Windows.Forms.CheckBox()
        Me.lblGoF = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ucrObjectName = New instat.ucrInputTextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.chkQQ = New System.Windows.Forms.CheckBox()
        Me.chkCDF = New System.Windows.Forms.CheckBox()
        Me.chkPP = New System.Windows.Forms.CheckBox()
        Me.chkDensity = New System.Windows.Forms.CheckBox()
        Me.ucrSaveChiSq = New instat.ucrInputTextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(14, 168)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(142, 30)
        Me.ucrBase.TabIndex = 0
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
        Me.chkSaveChi.Size = New System.Drawing.Size(106, 17)
        Me.chkSaveChi.TabIndex = 2
        Me.chkSaveChi.Text = "Save Chi-Square"
        Me.chkSaveChi.UseVisualStyleBackColor = True
        '
        'chkInputBreakpoints
        '
        Me.chkInputBreakpoints.AutoSize = True
        Me.chkInputBreakpoints.Location = New System.Drawing.Point(6, 75)
        Me.chkInputBreakpoints.Name = "chkInputBreakpoints"
        Me.chkInputBreakpoints.Size = New System.Drawing.Size(176, 17)
        Me.chkInputBreakpoints.TabIndex = 3
        Me.chkInputBreakpoints.Text = "Input Breakpoints to Chi-Square"
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
        Me.TabControl1.Size = New System.Drawing.Size(243, 152)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ucrSaveChiSq)
        Me.TabPage1.Controls.Add(Me.ucrObjectName)
        Me.TabPage1.Controls.Add(Me.chkSaveObjects)
        Me.TabPage1.Controls.Add(Me.lblGoF)
        Me.TabPage1.Controls.Add(Me.chkSaveChi)
        Me.TabPage1.Controls.Add(Me.chkInputBreakpoints)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(235, 126)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Fit"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ucrObjectName
        '
        Me.ucrObjectName.IsReadOnly = False
        Me.ucrObjectName.Location = New System.Drawing.Point(112, 27)
        Me.ucrObjectName.Name = "ucrObjectName"
        Me.ucrObjectName.Size = New System.Drawing.Size(107, 21)
        Me.ucrObjectName.TabIndex = 5
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.chkQQ)
        Me.TabPage2.Controls.Add(Me.chkCDF)
        Me.TabPage2.Controls.Add(Me.chkPP)
        Me.TabPage2.Controls.Add(Me.chkDensity)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(235, 126)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Plot"
        Me.TabPage2.UseVisualStyleBackColor = True
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
        'ucrSaveChiSq
        '
        Me.ucrSaveChiSq.IsReadOnly = False
        Me.ucrSaveChiSq.Location = New System.Drawing.Point(112, 50)
        Me.ucrSaveChiSq.Name = "ucrSaveChiSq"
        Me.ucrSaveChiSq.Size = New System.Drawing.Size(107, 21)
        Me.ucrSaveChiSq.TabIndex = 6
        '
        'sdgOneVarCompareModels
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(256, 200)
        Me.Controls.Add(Me.ucrBase)
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

    Friend WithEvents ucrBase As ucrButtonsSubdialogue
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
    Friend WithEvents ucrSaveChiSq As ucrInputTextBox
End Class
