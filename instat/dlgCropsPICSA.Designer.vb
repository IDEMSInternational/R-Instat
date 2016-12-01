<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgCropsPICSA
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
        Me.ucrInputSaveResults = New instat.ucrInputComboBox()
        Me.chkSaveResults = New System.Windows.Forms.CheckBox()
        Me.ucrbase = New instat.ucrButtons()
        Me.ucrSelectorForPICSACrops = New instat.ucrSelectorByDataFrameAddRemove()
        Me.grpCropModels = New System.Windows.Forms.GroupBox()
        Me.lblSlelectedVar = New System.Windows.Forms.Label()
        Me.ucrReceiverForPICSACrops = New instat.ucrReceiverSingle()
        Me.SuspendLayout()
        '
        'ucrInputSaveResults
        '
        Me.ucrInputSaveResults.IsReadOnly = False
        Me.ucrInputSaveResults.Location = New System.Drawing.Point(98, 199)
        Me.ucrInputSaveResults.Name = "ucrInputSaveResults"
        Me.ucrInputSaveResults.Size = New System.Drawing.Size(153, 21)
        Me.ucrInputSaveResults.TabIndex = 11
        '
        'chkSaveResults
        '
        Me.chkSaveResults.AutoSize = True
        Me.chkSaveResults.Location = New System.Drawing.Point(10, 199)
        Me.chkSaveResults.Name = "chkSaveResults"
        Me.chkSaveResults.Size = New System.Drawing.Size(89, 17)
        Me.chkSaveResults.TabIndex = 10
        Me.chkSaveResults.Text = "Save Results"
        Me.chkSaveResults.UseVisualStyleBackColor = True
        '
        'ucrbase
        '
        Me.ucrbase.Location = New System.Drawing.Point(9, 226)
        Me.ucrbase.Name = "ucrbase"
        Me.ucrbase.Size = New System.Drawing.Size(410, 52)
        Me.ucrbase.TabIndex = 9
        '
        'ucrSelectorForPICSACrops
        '
        Me.ucrSelectorForPICSACrops.bShowHiddenColumns = False
        Me.ucrSelectorForPICSACrops.bUseCurrentFilter = True
        Me.ucrSelectorForPICSACrops.Location = New System.Drawing.Point(9, 9)
        Me.ucrSelectorForPICSACrops.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForPICSACrops.Name = "ucrSelectorForPICSACrops"
        Me.ucrSelectorForPICSACrops.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForPICSACrops.TabIndex = 12
        '
        'grpCropModels
        '
        Me.grpCropModels.Location = New System.Drawing.Point(222, 62)
        Me.grpCropModels.Name = "grpCropModels"
        Me.grpCropModels.Size = New System.Drawing.Size(153, 127)
        Me.grpCropModels.TabIndex = 16
        Me.grpCropModels.TabStop = False
        Me.grpCropModels.Text = "Crop Models"
        '
        'lblSlelectedVar
        '
        Me.lblSlelectedVar.AutoSize = True
        Me.lblSlelectedVar.Location = New System.Drawing.Point(218, 21)
        Me.lblSlelectedVar.Name = "lblSlelectedVar"
        Me.lblSlelectedVar.Size = New System.Drawing.Size(90, 13)
        Me.lblSlelectedVar.TabIndex = 18
        Me.lblSlelectedVar.Text = "Selected Variable"
        '
        'ucrReceiverForPICSACrops
        '
        Me.ucrReceiverForPICSACrops.Location = New System.Drawing.Point(219, 39)
        Me.ucrReceiverForPICSACrops.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverForPICSACrops.Name = "ucrReceiverForPICSACrops"
        Me.ucrReceiverForPICSACrops.Selector = Nothing
        Me.ucrReceiverForPICSACrops.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverForPICSACrops.TabIndex = 17
        '
        'dlgCropsPICSA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 285)
        Me.Controls.Add(Me.lblSlelectedVar)
        Me.Controls.Add(Me.ucrReceiverForPICSACrops)
        Me.Controls.Add(Me.grpCropModels)
        Me.Controls.Add(Me.ucrSelectorForPICSACrops)
        Me.Controls.Add(Me.ucrInputSaveResults)
        Me.Controls.Add(Me.chkSaveResults)
        Me.Controls.Add(Me.ucrbase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCropsPICSA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crops"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrInputSaveResults As ucrInputComboBox
    Friend WithEvents chkSaveResults As CheckBox
    Friend WithEvents ucrbase As ucrButtons
    Friend WithEvents ucrSelectorForPICSACrops As ucrSelectorByDataFrameAddRemove
    Friend WithEvents grpCropModels As GroupBox
    Friend WithEvents lblSlelectedVar As Label
    Friend WithEvents ucrReceiverForPICSACrops As ucrReceiverSingle
End Class
