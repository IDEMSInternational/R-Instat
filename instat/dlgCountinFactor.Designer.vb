<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgCountinFactor
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
        Me.ucrCountSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrCountReceiver = New instat.ucrReceiverSingle()
        Me.ucrInputColumnName = New instat.ucrInputComboBox()
        Me.lblNewColumnName = New System.Windows.Forms.Label()
        Me.lblSelectedFactor = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 240)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrCountSelector
        '
        Me.ucrCountSelector.bShowHiddenColumns = False
        Me.ucrCountSelector.bUseCurrentFilter = False
        Me.ucrCountSelector.Location = New System.Drawing.Point(9, 9)
        Me.ucrCountSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrCountSelector.Name = "ucrCountSelector"
        Me.ucrCountSelector.Size = New System.Drawing.Size(210, 180)
        Me.ucrCountSelector.TabIndex = 1
        '
        'ucrCountReceiver
        '
        Me.ucrCountReceiver.Location = New System.Drawing.Point(269, 60)
        Me.ucrCountReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrCountReceiver.Name = "ucrCountReceiver"
        Me.ucrCountReceiver.Selector = Nothing
        Me.ucrCountReceiver.Size = New System.Drawing.Size(130, 20)
        Me.ucrCountReceiver.TabIndex = 2
        '
        'ucrInputColumnName
        '
        Me.ucrInputColumnName.IsReadOnly = False
        Me.ucrInputColumnName.Location = New System.Drawing.Point(144, 205)
        Me.ucrInputColumnName.Name = "ucrInputColumnName"
        Me.ucrInputColumnName.Size = New System.Drawing.Size(204, 21)
        Me.ucrInputColumnName.TabIndex = 3
        '
        'lblNewColumnName
        '
        Me.lblNewColumnName.AutoSize = True
        Me.lblNewColumnName.Location = New System.Drawing.Point(12, 205)
        Me.lblNewColumnName.Name = "lblNewColumnName"
        Me.lblNewColumnName.Size = New System.Drawing.Size(98, 13)
        Me.lblNewColumnName.TabIndex = 4
        Me.lblNewColumnName.Text = "New Column Name"
        '
        'lblSelectedFactor
        '
        Me.lblSelectedFactor.AutoSize = True
        Me.lblSelectedFactor.Location = New System.Drawing.Point(266, 36)
        Me.lblSelectedFactor.Name = "lblSelectedFactor"
        Me.lblSelectedFactor.Size = New System.Drawing.Size(82, 13)
        Me.lblSelectedFactor.TabIndex = 5
        Me.lblSelectedFactor.Text = "Selected Factor"
        '
        'dlgCountinFactor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 297)
        Me.Controls.Add(Me.lblSelectedFactor)
        Me.Controls.Add(Me.lblNewColumnName)
        Me.Controls.Add(Me.ucrInputColumnName)
        Me.Controls.Add(Me.ucrCountReceiver)
        Me.Controls.Add(Me.ucrCountSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCountinFactor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Count_in_Factor"
        Me.Text = "Count in Factor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrCountSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrCountReceiver As ucrReceiverSingle
    Friend WithEvents ucrInputColumnName As ucrInputComboBox
    Friend WithEvents lblNewColumnName As Label
    Friend WithEvents lblSelectedFactor As Label
End Class
