<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgClimaticNCMPSummaryFile
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
        Me.lblSaveFile = New System.Windows.Forms.Label()
        Me.cmdChooseFile = New System.Windows.Forms.Button()
        Me.ucrInputFilePath = New instat.ucrInputTextBox()
        Me.ucrSelectorA6 = New instat.ucrDataFrame()
        Me.ucrSelectorA4 = New instat.ucrDataFrame()
        Me.ucrSelectorA2 = New instat.ucrDataFrame()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.ucrChkEndYear = New instat.ucrCheck()
        Me.ucrChkStartYear = New instat.ucrCheck()
        Me.ucrNudNYE = New instat.ucrNud()
        Me.ucrNudNYB = New instat.ucrNud()
        Me.grpOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSaveFile
        '
        Me.lblSaveFile.AutoSize = True
        Me.lblSaveFile.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSaveFile.Location = New System.Drawing.Point(7, 252)
        Me.lblSaveFile.Name = "lblSaveFile"
        Me.lblSaveFile.Size = New System.Drawing.Size(86, 13)
        Me.lblSaveFile.TabIndex = 4
        Me.lblSaveFile.Text = "Save Output To:"
        '
        'cmdChooseFile
        '
        Me.cmdChooseFile.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdChooseFile.Location = New System.Drawing.Point(309, 248)
        Me.cmdChooseFile.Name = "cmdChooseFile"
        Me.cmdChooseFile.Size = New System.Drawing.Size(75, 23)
        Me.cmdChooseFile.TabIndex = 6
        Me.cmdChooseFile.Text = "Browse"
        Me.cmdChooseFile.UseVisualStyleBackColor = True
        '
        'ucrInputFilePath
        '
        Me.ucrInputFilePath.AddQuotesIfUnrecognised = True
        Me.ucrInputFilePath.IsMultiline = False
        Me.ucrInputFilePath.IsReadOnly = False
        Me.ucrInputFilePath.Location = New System.Drawing.Point(94, 249)
        Me.ucrInputFilePath.Name = "ucrInputFilePath"
        Me.ucrInputFilePath.Size = New System.Drawing.Size(210, 21)
        Me.ucrInputFilePath.TabIndex = 5
        '
        'ucrSelectorA6
        '
        Me.ucrSelectorA6.bDropUnusedFilterLevels = False
        Me.ucrSelectorA6.bUseCurrentFilter = True
        Me.ucrSelectorA6.Location = New System.Drawing.Point(10, 110)
        Me.ucrSelectorA6.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorA6.Name = "ucrSelectorA6"
        Me.ucrSelectorA6.Size = New System.Drawing.Size(148, 50)
        Me.ucrSelectorA6.TabIndex = 2
        '
        'ucrSelectorA4
        '
        Me.ucrSelectorA4.bDropUnusedFilterLevels = False
        Me.ucrSelectorA4.bUseCurrentFilter = True
        Me.ucrSelectorA4.Location = New System.Drawing.Point(10, 60)
        Me.ucrSelectorA4.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorA4.Name = "ucrSelectorA4"
        Me.ucrSelectorA4.Size = New System.Drawing.Size(148, 50)
        Me.ucrSelectorA4.TabIndex = 1
        '
        'ucrSelectorA2
        '
        Me.ucrSelectorA2.bDropUnusedFilterLevels = False
        Me.ucrSelectorA2.bUseCurrentFilter = True
        Me.ucrSelectorA2.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorA2.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorA2.Name = "ucrSelectorA2"
        Me.ucrSelectorA2.Size = New System.Drawing.Size(148, 50)
        Me.ucrSelectorA2.TabIndex = 0
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.ucrChkEndYear)
        Me.grpOptions.Controls.Add(Me.ucrChkStartYear)
        Me.grpOptions.Controls.Add(Me.ucrNudNYE)
        Me.grpOptions.Controls.Add(Me.ucrNudNYB)
        Me.grpOptions.Location = New System.Drawing.Point(10, 163)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(258, 73)
        Me.grpOptions.TabIndex = 3
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options"
        '
        'ucrChkEndYear
        '
        Me.ucrChkEndYear.Checked = False
        Me.ucrChkEndYear.Location = New System.Drawing.Point(6, 46)
        Me.ucrChkEndYear.Name = "ucrChkEndYear"
        Me.ucrChkEndYear.Size = New System.Drawing.Size(187, 20)
        Me.ucrChkEndYear.TabIndex = 2
        '
        'ucrChkStartYear
        '
        Me.ucrChkStartYear.Checked = False
        Me.ucrChkStartYear.Location = New System.Drawing.Point(6, 20)
        Me.ucrChkStartYear.Name = "ucrChkStartYear"
        Me.ucrChkStartYear.Size = New System.Drawing.Size(187, 20)
        Me.ucrChkStartYear.TabIndex = 0
        '
        'ucrNudNYE
        '
        Me.ucrNudNYE.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNYE.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNYE.Location = New System.Drawing.Point(199, 45)
        Me.ucrNudNYE.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNYE.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNYE.Name = "ucrNudNYE"
        Me.ucrNudNYE.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudNYE.TabIndex = 3
        Me.ucrNudNYE.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudNYB
        '
        Me.ucrNudNYB.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNYB.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNYB.Location = New System.Drawing.Point(199, 19)
        Me.ucrNudNYB.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNYB.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNYB.Name = "ucrNudNYB"
        Me.ucrNudNYB.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudNYB.TabIndex = 1
        Me.ucrNudNYB.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'dlgClimaticNCMPSummaryFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 340)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.ucrSelectorA6)
        Me.Controls.Add(Me.ucrSelectorA4)
        Me.Controls.Add(Me.ucrSelectorA2)
        Me.Controls.Add(Me.lblSaveFile)
        Me.Controls.Add(Me.cmdChooseFile)
        Me.Controls.Add(Me.ucrInputFilePath)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgClimaticNCMPSummaryFile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NCMP Summary File"
        Me.grpOptions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSaveFile As Label
    Friend WithEvents cmdChooseFile As Button
    Friend WithEvents ucrInputFilePath As ucrInputTextBox
    Friend WithEvents ucrSelectorA6 As ucrDataFrame
    Friend WithEvents ucrSelectorA4 As ucrDataFrame
    Friend WithEvents ucrSelectorA2 As ucrDataFrame
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents ucrChkEndYear As ucrCheck
    Friend WithEvents ucrChkStartYear As ucrCheck
    Friend WithEvents ucrNudNYE As ucrNud
    Friend WithEvents ucrNudNYB As ucrNud
End Class