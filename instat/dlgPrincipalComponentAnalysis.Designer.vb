<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgPrincipalComponentAnalysis
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
        Me.lblExplanatoryVariables = New System.Windows.Forms.Label()
        Me.cmdPCAOptions = New System.Windows.Forms.Button()
        Me.nudComponents = New System.Windows.Forms.NumericUpDown()
        Me.lblComponents = New System.Windows.Forms.Label()
        Me.chkScaleData = New System.Windows.Forms.CheckBox()
        Me.chkSaveResult = New System.Windows.Forms.CheckBox()
        Me.ucrReceiverMultiplePCA = New instat.ucrReceiverMultiple()
        Me.ucrSelectorPCA = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBasePCA = New instat.ucrButtons()
        Me.ucrResultName = New instat.ucrInputComboBox()
        CType(Me.nudComponents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblExplanatoryVariables
        '
        Me.lblExplanatoryVariables.AutoSize = True
        Me.lblExplanatoryVariables.Location = New System.Drawing.Point(274, 42)
        Me.lblExplanatoryVariables.Name = "lblExplanatoryVariables"
        Me.lblExplanatoryVariables.Size = New System.Drawing.Size(108, 13)
        Me.lblExplanatoryVariables.TabIndex = 1
        Me.lblExplanatoryVariables.Tag = "Explanatory_Variables"
        Me.lblExplanatoryVariables.Text = "Explanatory Variables"
        '
        'cmdPCAOptions
        '
        Me.cmdPCAOptions.Location = New System.Drawing.Point(299, 219)
        Me.cmdPCAOptions.Name = "cmdPCAOptions"
        Me.cmdPCAOptions.Size = New System.Drawing.Size(106, 23)
        Me.cmdPCAOptions.TabIndex = 8
        Me.cmdPCAOptions.Tag = "PCA_Options..."
        Me.cmdPCAOptions.Text = "PCA Options..."
        Me.cmdPCAOptions.UseVisualStyleBackColor = True
        '
        'nudComponents
        '
        Me.nudComponents.Location = New System.Drawing.Point(141, 191)
        Me.nudComponents.Name = "nudComponents"
        Me.nudComponents.Size = New System.Drawing.Size(42, 20)
        Me.nudComponents.TabIndex = 4
        '
        'lblComponents
        '
        Me.lblComponents.AutoSize = True
        Me.lblComponents.Location = New System.Drawing.Point(15, 193)
        Me.lblComponents.Name = "lblComponents"
        Me.lblComponents.Size = New System.Drawing.Size(118, 13)
        Me.lblComponents.TabIndex = 3
        Me.lblComponents.Tag = "Number_of_Components"
        Me.lblComponents.Text = "Number of Components"
        '
        'chkScaleData
        '
        Me.chkScaleData.AutoSize = True
        Me.chkScaleData.Location = New System.Drawing.Point(315, 193)
        Me.chkScaleData.Name = "chkScaleData"
        Me.chkScaleData.Size = New System.Drawing.Size(79, 17)
        Me.chkScaleData.TabIndex = 5
        Me.chkScaleData.Tag = "Scale_Data"
        Me.chkScaleData.Text = "Scale Data"
        Me.chkScaleData.UseVisualStyleBackColor = True
        '
        'chkSaveResult
        '
        Me.chkSaveResult.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkSaveResult.Location = New System.Drawing.Point(14, 219)
        Me.chkSaveResult.Name = "chkSaveResult"
        Me.chkSaveResult.Size = New System.Drawing.Size(104, 24)
        Me.chkSaveResult.TabIndex = 6
        Me.chkSaveResult.Tag = "Save_Result"
        Me.chkSaveResult.Text = "Save Result"
        Me.chkSaveResult.UseVisualStyleBackColor = True
        '
        'ucrReceiverMultiplePCA
        '
        Me.ucrReceiverMultiplePCA.Location = New System.Drawing.Point(268, 58)
        Me.ucrReceiverMultiplePCA.Name = "ucrReceiverMultiplePCA"
        Me.ucrReceiverMultiplePCA.Selector = Nothing
        Me.ucrReceiverMultiplePCA.Size = New System.Drawing.Size(121, 104)
        Me.ucrReceiverMultiplePCA.TabIndex = 2
        '
        'ucrSelectorPCA
        '
        Me.ucrSelectorPCA.Location = New System.Drawing.Point(11, 5)
        Me.ucrSelectorPCA.Name = "ucrSelectorPCA"
        Me.ucrSelectorPCA.Size = New System.Drawing.Size(242, 179)
        Me.ucrSelectorPCA.TabIndex = 0
        '
        'ucrBasePCA
        '
        Me.ucrBasePCA.Location = New System.Drawing.Point(12, 246)
        Me.ucrBasePCA.Name = "ucrBasePCA"
        Me.ucrBasePCA.Size = New System.Drawing.Size(410, 53)
        Me.ucrBasePCA.TabIndex = 9
        '
        'ucrResultName
        '
        Me.ucrResultName.Location = New System.Drawing.Point(115, 219)
        Me.ucrResultName.Name = "ucrResultName"
        Me.ucrResultName.Size = New System.Drawing.Size(137, 25)
        Me.ucrResultName.TabIndex = 10
        '
        'dlgPrincipalComponentAnalysis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 298)
        Me.Controls.Add(Me.ucrResultName)
        Me.Controls.Add(Me.chkSaveResult)
        Me.Controls.Add(Me.chkScaleData)
        Me.Controls.Add(Me.lblComponents)
        Me.Controls.Add(Me.nudComponents)
        Me.Controls.Add(Me.cmdPCAOptions)
        Me.Controls.Add(Me.lblExplanatoryVariables)
        Me.Controls.Add(Me.ucrReceiverMultiplePCA)
        Me.Controls.Add(Me.ucrSelectorPCA)
        Me.Controls.Add(Me.ucrBasePCA)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgPrincipalComponentAnalysis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Principal_Component_Analysis"
        Me.Text = "Principal Component Analysis"
        CType(Me.nudComponents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBasePCA As ucrButtons
    Friend WithEvents ucrSelectorPCA As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverMultiplePCA As ucrReceiverMultiple
    Friend WithEvents lblExplanatoryVariables As Label
    Friend WithEvents cmdPCAOptions As Button
    Friend WithEvents nudComponents As NumericUpDown
    Friend WithEvents lblComponents As Label
    Friend WithEvents chkScaleData As CheckBox
    Friend WithEvents chkSaveResult As CheckBox
    Friend WithEvents ucrResultName As ucrInputComboBox
End Class