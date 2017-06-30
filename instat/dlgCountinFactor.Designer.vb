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
        Me.lblSelectedFactor = New System.Windows.Forms.Label()
        Me.ucrNewColName = New instat.ucrSave()
        Me.UcrDialogDisabled1 = New instat.ucrDialogDisabled()
        Me.ucrCountReceiver = New instat.ucrReceiverSingle()
        Me.ucrCountSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
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
        'ucrNewColName
        '
        Me.ucrNewColName.Location = New System.Drawing.Point(9, 210)
        Me.ucrNewColName.Name = "ucrNewColName"
        Me.ucrNewColName.Size = New System.Drawing.Size(255, 24)
        Me.ucrNewColName.TabIndex = 0
        '
        'UcrDialogDisabled1
        '
        Me.UcrDialogDisabled1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UcrDialogDisabled1.Location = New System.Drawing.Point(96, 98)
        Me.UcrDialogDisabled1.Name = "UcrDialogDisabled1"
        Me.UcrDialogDisabled1.Size = New System.Drawing.Size(209, 106)
        Me.UcrDialogDisabled1.TabIndex = 6
        '
        'ucrCountReceiver
        '
        Me.ucrCountReceiver.frmParent = Me
        Me.ucrCountReceiver.Location = New System.Drawing.Point(269, 60)
        Me.ucrCountReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrCountReceiver.Name = "ucrCountReceiver"
        Me.ucrCountReceiver.Selector = Nothing
        Me.ucrCountReceiver.Size = New System.Drawing.Size(130, 20)
        Me.ucrCountReceiver.strNcFilePath = ""
        Me.ucrCountReceiver.TabIndex = 2
        Me.ucrCountReceiver.ucrSelector = Nothing
        '
        'ucrCountSelector
        '
        Me.ucrCountSelector.bShowHiddenColumns = False
        Me.ucrCountSelector.bUseCurrentFilter = True
        Me.ucrCountSelector.Location = New System.Drawing.Point(9, 9)
        Me.ucrCountSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrCountSelector.Name = "ucrCountSelector"
        Me.ucrCountSelector.Size = New System.Drawing.Size(210, 180)
        Me.ucrCountSelector.TabIndex = 1
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 240)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'dlgCountinFactor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 297)
        Me.Controls.Add(Me.ucrNewColName)
        Me.Controls.Add(Me.UcrDialogDisabled1)
        Me.Controls.Add(Me.lblSelectedFactor)
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
    Friend WithEvents lblSelectedFactor As Label
    Friend WithEvents UcrDialogDisabled1 As ucrDialogDisabled
    Friend WithEvents ucrNewColName As ucrSave
End Class
