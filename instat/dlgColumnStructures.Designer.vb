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
        Me.lblMeasurement = New System.Windows.Forms.Label()
        Me.lblTreatment = New System.Windows.Forms.Label()
        Me.lblLayout = New System.Windows.Forms.Label()
        Me.ucrChkColourColumnsByStructure = New instat.ucrCheck()
        Me.ucrReceiverType3 = New instat.ucrReceiverMultiple()
        Me.ucrReceiverType2 = New instat.ucrReceiverMultiple()
        Me.ucrReceiverType1 = New instat.ucrReceiverMultiple()
        Me.ucrSelectorColumnStructure = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblMeasurement
        '
        Me.lblMeasurement.AutoSize = True
        Me.lblMeasurement.Location = New System.Drawing.Point(250, 197)
        Me.lblMeasurement.Name = "lblMeasurement"
        Me.lblMeasurement.Size = New System.Drawing.Size(74, 13)
        Me.lblMeasurement.TabIndex = 5
        Me.lblMeasurement.Text = "Measurement:"
        '
        'lblTreatment
        '
        Me.lblTreatment.AutoSize = True
        Me.lblTreatment.Location = New System.Drawing.Point(250, 104)
        Me.lblTreatment.Name = "lblTreatment"
        Me.lblTreatment.Size = New System.Drawing.Size(58, 13)
        Me.lblTreatment.TabIndex = 3
        Me.lblTreatment.Text = "Treatment:"
        '
        'lblLayout
        '
        Me.lblLayout.AutoSize = True
        Me.lblLayout.Location = New System.Drawing.Point(250, 11)
        Me.lblLayout.Name = "lblLayout"
        Me.lblLayout.Size = New System.Drawing.Size(42, 13)
        Me.lblLayout.TabIndex = 1
        Me.lblLayout.Text = "Layout:"
        '
        'ucrChkColourColumnsByStructure
        '
        Me.ucrChkColourColumnsByStructure.Checked = False
        Me.ucrChkColourColumnsByStructure.Location = New System.Drawing.Point(10, 194)
        Me.ucrChkColourColumnsByStructure.Name = "ucrChkColourColumnsByStructure"
        Me.ucrChkColourColumnsByStructure.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkColourColumnsByStructure.TabIndex = 7
        '
        'ucrReceiverType3
        '
        Me.ucrReceiverType3.frmParent = Me
        Me.ucrReceiverType3.Location = New System.Drawing.Point(247, 212)
        Me.ucrReceiverType3.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverType3.Name = "ucrReceiverType3"
        Me.ucrReceiverType3.Selector = Nothing
        Me.ucrReceiverType3.Size = New System.Drawing.Size(120, 76)
        Me.ucrReceiverType3.TabIndex = 6
        '
        'ucrReceiverType2
        '
        Me.ucrReceiverType2.frmParent = Me
        Me.ucrReceiverType2.Location = New System.Drawing.Point(247, 119)
        Me.ucrReceiverType2.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverType2.Name = "ucrReceiverType2"
        Me.ucrReceiverType2.Selector = Nothing
        Me.ucrReceiverType2.Size = New System.Drawing.Size(120, 73)
        Me.ucrReceiverType2.TabIndex = 4
        '
        'ucrReceiverType1
        '
        Me.ucrReceiverType1.frmParent = Me
        Me.ucrReceiverType1.Location = New System.Drawing.Point(247, 26)
        Me.ucrReceiverType1.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverType1.Name = "ucrReceiverType1"
        Me.ucrReceiverType1.Selector = Nothing
        Me.ucrReceiverType1.Size = New System.Drawing.Size(120, 74)
        Me.ucrReceiverType1.TabIndex = 2
        '
        'ucrSelectorColumnStructure
        '
        Me.ucrSelectorColumnStructure.bShowHiddenColumns = False
        Me.ucrSelectorColumnStructure.bUseCurrentFilter = True
        Me.ucrSelectorColumnStructure.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorColumnStructure.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorColumnStructure.Name = "ucrSelectorColumnStructure"
        Me.ucrSelectorColumnStructure.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorColumnStructure.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(5, 291)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 8
        '
        'dlgColumnStructure
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 345)
        Me.Controls.Add(Me.ucrChkColourColumnsByStructure)
        Me.Controls.Add(Me.lblMeasurement)
        Me.Controls.Add(Me.lblTreatment)
        Me.Controls.Add(Me.lblLayout)
        Me.Controls.Add(Me.ucrReceiverType3)
        Me.Controls.Add(Me.ucrReceiverType2)
        Me.Controls.Add(Me.ucrReceiverType1)
        Me.Controls.Add(Me.ucrSelectorColumnStructure)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgColumnStructure"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Column_Structure"
        Me.Text = "Column Structure"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMeasurement As Label
    Friend WithEvents lblTreatment As Label
    Friend WithEvents lblLayout As Label
    Friend WithEvents ucrReceiverType3 As ucrReceiverMultiple
    Friend WithEvents ucrReceiverType2 As ucrReceiverMultiple
    Friend WithEvents ucrReceiverType1 As ucrReceiverMultiple
    Friend WithEvents ucrSelectorColumnStructure As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrChkColourColumnsByStructure As ucrCheck
End Class
