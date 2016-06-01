﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgWindrose
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
        Me.ucrWindRoseSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrSaveWindRose = New instat.ucrSaveGraph()
        Me.lblXVariable = New System.Windows.Forms.Label()
        Me.ucrXReceiver = New instat.ucrReceiverSingle()
        Me.lblYVariable = New System.Windows.Forms.Label()
        Me.ucrYReceiver = New instat.ucrReceiverSingle()
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.ucrFillReceiver = New instat.ucrReceiverSingle()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 238)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrWindRoseSelector
        '
        Me.ucrWindRoseSelector.Location = New System.Drawing.Point(10, 10)
        Me.ucrWindRoseSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrWindRoseSelector.Name = "ucrWindRoseSelector"
        Me.ucrWindRoseSelector.Size = New System.Drawing.Size(210, 180)
        Me.ucrWindRoseSelector.TabIndex = 1
        '
        'ucrSaveWindRose
        '
        Me.ucrSaveWindRose.Location = New System.Drawing.Point(10, 209)
        Me.ucrSaveWindRose.Name = "ucrSaveWindRose"
        Me.ucrSaveWindRose.Size = New System.Drawing.Size(265, 20)
        Me.ucrSaveWindRose.TabIndex = 2
        '
        'lblXVariable
        '
        Me.lblXVariable.AutoSize = True
        Me.lblXVariable.Location = New System.Drawing.Point(255, 25)
        Me.lblXVariable.Name = "lblXVariable"
        Me.lblXVariable.Size = New System.Drawing.Size(55, 13)
        Me.lblXVariable.TabIndex = 3
        Me.lblXVariable.Text = "X Variable"
        '
        'ucrXReceiver
        '
        Me.ucrXReceiver.Location = New System.Drawing.Point(255, 42)
        Me.ucrXReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrXReceiver.Name = "ucrXReceiver"
        Me.ucrXReceiver.Selector = Nothing
        Me.ucrXReceiver.Size = New System.Drawing.Size(120, 20)
        Me.ucrXReceiver.TabIndex = 4
        '
        'lblYVariable
        '
        Me.lblYVariable.AutoSize = True
        Me.lblYVariable.Location = New System.Drawing.Point(255, 76)
        Me.lblYVariable.Name = "lblYVariable"
        Me.lblYVariable.Size = New System.Drawing.Size(55, 13)
        Me.lblYVariable.TabIndex = 3
        Me.lblYVariable.Text = "Y Variable"
        '
        'ucrYReceiver
        '
        Me.ucrYReceiver.Location = New System.Drawing.Point(255, 93)
        Me.ucrYReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrYReceiver.Name = "ucrYReceiver"
        Me.ucrYReceiver.Selector = Nothing
        Me.ucrYReceiver.Size = New System.Drawing.Size(120, 20)
        Me.ucrYReceiver.TabIndex = 4
        '
        'lblFactor
        '
        Me.lblFactor.AutoSize = True
        Me.lblFactor.Location = New System.Drawing.Point(255, 128)
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Size = New System.Drawing.Size(37, 13)
        Me.lblFactor.TabIndex = 3
        Me.lblFactor.Text = "Factor"
        '
        'ucrFillReceiver
        '
        Me.ucrFillReceiver.Location = New System.Drawing.Point(255, 145)
        Me.ucrFillReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFillReceiver.Name = "ucrFillReceiver"
        Me.ucrFillReceiver.Selector = Nothing
        Me.ucrFillReceiver.Size = New System.Drawing.Size(120, 20)
        Me.ucrFillReceiver.TabIndex = 4
        '
        'dlgWindrose
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 293)
        Me.Controls.Add(Me.ucrFillReceiver)
        Me.Controls.Add(Me.ucrYReceiver)
        Me.Controls.Add(Me.ucrXReceiver)
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.lblYVariable)
        Me.Controls.Add(Me.lblXVariable)
        Me.Controls.Add(Me.ucrSaveWindRose)
        Me.Controls.Add(Me.ucrWindRoseSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgWindrose"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Windrose"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrWindRoseSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSaveWindRose As ucrSaveGraph
    Friend WithEvents lblXVariable As Label
    Friend WithEvents ucrXReceiver As ucrReceiverSingle
    Friend WithEvents lblYVariable As Label
    Friend WithEvents ucrYReceiver As ucrReceiverSingle
    Friend WithEvents lblFactor As Label
    Friend WithEvents ucrFillReceiver As ucrReceiverSingle
End Class
