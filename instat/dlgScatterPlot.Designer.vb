<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgScatterPlot
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
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrScatterplotSelector = New instat.ucrSelectorAddRemove()
        Me.ucrYVariableReceiver = New instat.ucrReceiverSingle()
        Me.lblYAxisVariable = New System.Windows.Forms.Label()
        Me.ucrXVariableReceiver = New instat.ucrReceiverSingle()
        Me.lblXAxisVariable = New System.Windows.Forms.Label()
        Me.chkDisplayLetterValues = New System.Windows.Forms.CheckBox()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(7, 203)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 32)
        Me.ucrBase.TabIndex = 0
        '
        'ucrScatterplotSelector
        '
        Me.ucrScatterplotSelector.Location = New System.Drawing.Point(12, 12)
        Me.ucrScatterplotSelector.Name = "ucrScatterplotSelector"
        Me.ucrScatterplotSelector.Size = New System.Drawing.Size(203, 127)
        Me.ucrScatterplotSelector.TabIndex = 1
        '
        'ucrYVariableReceiver
        '
        Me.ucrYVariableReceiver.Location = New System.Drawing.Point(293, 38)
        Me.ucrYVariableReceiver.Name = "ucrYVariableReceiver"
        Me.ucrYVariableReceiver.Size = New System.Drawing.Size(106, 26)
        Me.ucrYVariableReceiver.TabIndex = 2
        '
        'lblYAxisVariable
        '
        Me.lblYAxisVariable.AutoSize = True
        Me.lblYAxisVariable.Location = New System.Drawing.Point(300, 19)
        Me.lblYAxisVariable.Name = "lblYAxisVariable"
        Me.lblYAxisVariable.Size = New System.Drawing.Size(77, 13)
        Me.lblYAxisVariable.TabIndex = 3
        Me.lblYAxisVariable.Tag = "Y_Axis_Variable"
        Me.lblYAxisVariable.Text = "Y Axis Variable"
        '
        'ucrXVariableReceiver
        '
        Me.ucrXVariableReceiver.Location = New System.Drawing.Point(293, 90)
        Me.ucrXVariableReceiver.Name = "ucrXVariableReceiver"
        Me.ucrXVariableReceiver.Size = New System.Drawing.Size(106, 26)
        Me.ucrXVariableReceiver.TabIndex = 2
        '
        'lblXAxisVariable
        '
        Me.lblXAxisVariable.AutoSize = True
        Me.lblXAxisVariable.Location = New System.Drawing.Point(300, 71)
        Me.lblXAxisVariable.Name = "lblXAxisVariable"
        Me.lblXAxisVariable.Size = New System.Drawing.Size(77, 13)
        Me.lblXAxisVariable.TabIndex = 3
        Me.lblXAxisVariable.Tag = "X_Axis_Variable"
        Me.lblXAxisVariable.Text = "X Axis Variable"
        '
        'chkDisplayLetterValues
        '
        Me.chkDisplayLetterValues.AutoSize = True
        Me.chkDisplayLetterValues.Location = New System.Drawing.Point(28, 146)
        Me.chkDisplayLetterValues.Name = "chkDisplayLetterValues"
        Me.chkDisplayLetterValues.Size = New System.Drawing.Size(125, 17)
        Me.chkDisplayLetterValues.TabIndex = 4
        Me.chkDisplayLetterValues.Tag = "Display_Letter_Values"
        Me.chkDisplayLetterValues.Text = "Display Letter Values"
        Me.chkDisplayLetterValues.UseVisualStyleBackColor = True
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Location = New System.Drawing.Point(230, 146)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(38, 13)
        Me.lblHeight.TabIndex = 5
        Me.lblHeight.Tag = "Height"
        Me.lblHeight.Text = "Height"
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Location = New System.Drawing.Point(230, 176)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(41, 13)
        Me.lblWeight.TabIndex = 5
        Me.lblWeight.Tag = "Weight"
        Me.lblWeight.Text = "Weight"
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(298, 146)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(95, 20)
        Me.txtHeight.TabIndex = 6
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(299, 172)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(94, 20)
        Me.txtWeight.TabIndex = 6
        '
        'dlgScatterPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 239)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.lblHeight)
        Me.Controls.Add(Me.chkDisplayLetterValues)
        Me.Controls.Add(Me.lblXAxisVariable)
        Me.Controls.Add(Me.lblYAxisVariable)
        Me.Controls.Add(Me.ucrXVariableReceiver)
        Me.Controls.Add(Me.ucrYVariableReceiver)
        Me.Controls.Add(Me.ucrScatterplotSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgScatterPlot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ScatterPlot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrScatterplotSelector As ucrSelectorAddRemove
    Friend WithEvents ucrYVariableReceiver As ucrReceiverSingle
    Friend WithEvents lblYAxisVariable As Label
    Friend WithEvents ucrXVariableReceiver As ucrReceiverSingle
    Friend WithEvents lblXAxisVariable As Label
    Friend WithEvents chkDisplayLetterValues As CheckBox
    Friend WithEvents lblHeight As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents txtWeight As TextBox
End Class
