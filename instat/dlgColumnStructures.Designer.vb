<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgColumnStructure
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
        Me.chkColourColumnsByStr = New System.Windows.Forms.CheckBox()
        Me.lblMeasurement = New System.Windows.Forms.Label()
        Me.lblTreatment = New System.Windows.Forms.Label()
        Me.lblLayout = New System.Windows.Forms.Label()
        Me.ucrReceiverMeasurement = New instat.ucrReceiverMultiple()
        Me.ucrReceiverTreatment = New instat.ucrReceiverMultiple()
        Me.ucrReceiverForLayout = New instat.ucrReceiverMultiple()
        Me.ucrSelectorColumnStructure = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'chkColourColumnsByStr
        '
        Me.chkColourColumnsByStr.AutoSize = True
        Me.chkColourColumnsByStr.Location = New System.Drawing.Point(12, 224)
        Me.chkColourColumnsByStr.Name = "chkColourColumnsByStr"
        Me.chkColourColumnsByStr.Size = New System.Drawing.Size(159, 17)
        Me.chkColourColumnsByStr.TabIndex = 17
        Me.chkColourColumnsByStr.Text = "Colour Columns by Structure"
        Me.chkColourColumnsByStr.UseVisualStyleBackColor = True
        '
        'lblMeasurement
        '
        Me.lblMeasurement.AutoSize = True
        Me.lblMeasurement.Location = New System.Drawing.Point(247, 210)
        Me.lblMeasurement.Name = "lblMeasurement"
        Me.lblMeasurement.Size = New System.Drawing.Size(71, 13)
        Me.lblMeasurement.TabIndex = 16
        Me.lblMeasurement.Text = "Measurement"
        '
        'lblTreatment
        '
        Me.lblTreatment.AutoSize = True
        Me.lblTreatment.Location = New System.Drawing.Point(244, 117)
        Me.lblTreatment.Name = "lblTreatment"
        Me.lblTreatment.Size = New System.Drawing.Size(55, 13)
        Me.lblTreatment.TabIndex = 15
        Me.lblTreatment.Text = "Treatment"
        '
        'lblLayout
        '
        Me.lblLayout.AutoSize = True
        Me.lblLayout.Location = New System.Drawing.Point(247, 18)
        Me.lblLayout.Name = "lblLayout"
        Me.lblLayout.Size = New System.Drawing.Size(39, 13)
        Me.lblLayout.TabIndex = 14
        Me.lblLayout.Text = "Layout"
        '
        'ucrReceiverMeasurement
        '
        Me.ucrReceiverMeasurement.Location = New System.Drawing.Point(247, 225)
        Me.ucrReceiverMeasurement.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMeasurement.Name = "ucrReceiverMeasurement"
        Me.ucrReceiverMeasurement.Selector = Nothing
        Me.ucrReceiverMeasurement.Size = New System.Drawing.Size(120, 76)
        Me.ucrReceiverMeasurement.TabIndex = 13
        '
        'ucrReceiverTreatment
        '
        Me.ucrReceiverTreatment.Location = New System.Drawing.Point(247, 135)
        Me.ucrReceiverTreatment.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTreatment.Name = "ucrReceiverTreatment"
        Me.ucrReceiverTreatment.Selector = Nothing
        Me.ucrReceiverTreatment.Size = New System.Drawing.Size(120, 73)
        Me.ucrReceiverTreatment.TabIndex = 12
        '
        'ucrReceiverForLayout
        '
        Me.ucrReceiverForLayout.Location = New System.Drawing.Point(247, 39)
        Me.ucrReceiverForLayout.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverForLayout.Name = "ucrReceiverForLayout"
        Me.ucrReceiverForLayout.Selector = Nothing
        Me.ucrReceiverForLayout.Size = New System.Drawing.Size(120, 74)
        Me.ucrReceiverForLayout.TabIndex = 11
        '
        'ucrSelectorColumnStructure
        '
        Me.ucrSelectorColumnStructure.bShowHiddenColumns = False
        Me.ucrSelectorColumnStructure.Location = New System.Drawing.Point(12, 9)
        Me.ucrSelectorColumnStructure.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorColumnStructure.Name = "ucrSelectorColumnStructure"
        Me.ucrSelectorColumnStructure.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorColumnStructure.TabIndex = 10
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 304)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 9
        '
        'dlgColumnStructure
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 368)
        Me.Controls.Add(Me.chkColourColumnsByStr)
        Me.Controls.Add(Me.lblMeasurement)
        Me.Controls.Add(Me.lblTreatment)
        Me.Controls.Add(Me.lblLayout)
        Me.Controls.Add(Me.ucrReceiverMeasurement)
        Me.Controls.Add(Me.ucrReceiverTreatment)
        Me.Controls.Add(Me.ucrReceiverForLayout)
        Me.Controls.Add(Me.ucrSelectorColumnStructure)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgColumnStructure"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Column_Structure"
        Me.Text = "Column Structure"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkColourColumnsByStr As CheckBox
    Friend WithEvents lblMeasurement As Label
    Friend WithEvents lblTreatment As Label
    Friend WithEvents lblLayout As Label
    Friend WithEvents ucrReceiverMeasurement As ucrReceiverMultiple
    Friend WithEvents ucrReceiverTreatment As ucrReceiverMultiple
    Friend WithEvents ucrReceiverForLayout As ucrReceiverMultiple
    Friend WithEvents ucrSelectorColumnStructure As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
End Class
