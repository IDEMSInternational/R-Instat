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
        Me.lblComponents = New System.Windows.Forms.Label()
        Me.ucrReceiverMultiplePCA = New instat.ucrReceiverMultiple()
        Me.ucrSelectorPCA = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrNudNumberOfComp = New instat.ucrNud()
        Me.ucrSaveResult = New instat.ucrSave()
        Me.ucrChkScaleData = New instat.ucrCheck()
        Me.SuspendLayout()
        '
        'lblExplanatoryVariables
        '
        Me.lblExplanatoryVariables.AutoSize = True
        Me.lblExplanatoryVariables.Location = New System.Drawing.Point(247, 45)
        Me.lblExplanatoryVariables.Name = "lblExplanatoryVariables"
        Me.lblExplanatoryVariables.Size = New System.Drawing.Size(111, 13)
        Me.lblExplanatoryVariables.TabIndex = 1
        Me.lblExplanatoryVariables.Tag = "Explanatory_Variables"
        Me.lblExplanatoryVariables.Text = "Explanatory Variables:"
        '
        'cmdPCAOptions
        '
        Me.cmdPCAOptions.Location = New System.Drawing.Point(302, 204)
        Me.cmdPCAOptions.Name = "cmdPCAOptions"
        Me.cmdPCAOptions.Size = New System.Drawing.Size(106, 23)
        Me.cmdPCAOptions.TabIndex = 6
        Me.cmdPCAOptions.Tag = "PCA_Options..."
        Me.cmdPCAOptions.Text = "Options..."
        Me.cmdPCAOptions.UseVisualStyleBackColor = True
        '
        'lblComponents
        '
        Me.lblComponents.AutoSize = True
        Me.lblComponents.Location = New System.Drawing.Point(247, 154)
        Me.lblComponents.Name = "lblComponents"
        Me.lblComponents.Size = New System.Drawing.Size(121, 13)
        Me.lblComponents.TabIndex = 3
        Me.lblComponents.Tag = "Number_of_Components"
        Me.lblComponents.Text = "Number of Components:"
        '
        'ucrReceiverMultiplePCA
        '
        Me.ucrReceiverMultiplePCA.frmParent = Me
        Me.ucrReceiverMultiplePCA.Location = New System.Drawing.Point(247, 60)
        Me.ucrReceiverMultiplePCA.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultiplePCA.Name = "ucrReceiverMultiplePCA"
        Me.ucrReceiverMultiplePCA.Selector = Nothing
        Me.ucrReceiverMultiplePCA.Size = New System.Drawing.Size(120, 88)
        Me.ucrReceiverMultiplePCA.strNcFilePath = ""
        Me.ucrReceiverMultiplePCA.TabIndex = 2
        Me.ucrReceiverMultiplePCA.ucrSelector = Nothing
        '
        'ucrSelectorPCA
        '
        Me.ucrSelectorPCA.bShowHiddenColumns = False
        Me.ucrSelectorPCA.bUseCurrentFilter = True
        Me.ucrSelectorPCA.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorPCA.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorPCA.Name = "ucrSelectorPCA"
        Me.ucrSelectorPCA.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorPCA.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 233)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 8
        '
        'ucrNudNumberOfComp
        '
        Me.ucrNudNumberOfComp.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberOfComp.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNumberOfComp.Location = New System.Drawing.Point(370, 151)
        Me.ucrNudNumberOfComp.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNumberOfComp.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberOfComp.Name = "ucrNudNumberOfComp"
        Me.ucrNudNumberOfComp.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudNumberOfComp.TabIndex = 4
        Me.ucrNudNumberOfComp.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrSaveResult
        '
        Me.ucrSaveResult.Location = New System.Drawing.Point(10, 204)
        Me.ucrSaveResult.Name = "ucrSaveResult"
        Me.ucrSaveResult.Size = New System.Drawing.Size(255, 24)
        Me.ucrSaveResult.TabIndex = 7
        '
        'ucrChkScaleData
        '
        Me.ucrChkScaleData.Checked = False
        Me.ucrChkScaleData.Location = New System.Drawing.Point(250, 175)
        Me.ucrChkScaleData.Name = "ucrChkScaleData"
        Me.ucrChkScaleData.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkScaleData.TabIndex = 5
        '
        'dlgPrincipalComponentAnalysis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 290)
        Me.Controls.Add(Me.ucrChkScaleData)
        Me.Controls.Add(Me.ucrSaveResult)
        Me.Controls.Add(Me.ucrNudNumberOfComp)
        Me.Controls.Add(Me.lblComponents)
        Me.Controls.Add(Me.cmdPCAOptions)
        Me.Controls.Add(Me.lblExplanatoryVariables)
        Me.Controls.Add(Me.ucrReceiverMultiplePCA)
        Me.Controls.Add(Me.ucrSelectorPCA)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgPrincipalComponentAnalysis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Principal_Component_Analysis"
        Me.Text = "Principal Component Analysis"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorPCA As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverMultiplePCA As ucrReceiverMultiple
    Friend WithEvents lblExplanatoryVariables As Label
    Friend WithEvents cmdPCAOptions As Button
    Friend WithEvents lblComponents As Label
    Friend WithEvents ucrNudNumberOfComp As ucrNud
    Friend WithEvents ucrChkScaleData As ucrCheck
    Friend WithEvents ucrSaveResult As ucrSave
End Class