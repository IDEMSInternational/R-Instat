﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgFactorDataFrame
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
        Me.ucrBaseFactorSubdlg = New instat.ucrButtonsSubdialogue()
        Me.ucrSelectorSubDlgFactorDatafrme = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverLabels = New instat.ucrReceiverSingle()
        Me.ucrReceiverMatchColumn = New instat.ucrReceiverSingle()
        Me.lblMatchingColumn = New System.Windows.Forms.Label()
        Me.lbllabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBaseFactorSubdlg
        '
        Me.ucrBaseFactorSubdlg.Location = New System.Drawing.Point(12, 219)
        Me.ucrBaseFactorSubdlg.Name = "ucrBaseFactorSubdlg"
        Me.ucrBaseFactorSubdlg.Size = New System.Drawing.Size(142, 30)
        Me.ucrBaseFactorSubdlg.TabIndex = 0
        '
        'ucrSelectorSubDlgFactorDatafrme
        '
        Me.ucrSelectorSubDlgFactorDatafrme.bShowHiddenColumns = False
        Me.ucrSelectorSubDlgFactorDatafrme.bUseCurrentFilter = False
        Me.ucrSelectorSubDlgFactorDatafrme.Location = New System.Drawing.Point(9, 9)
        Me.ucrSelectorSubDlgFactorDatafrme.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorSubDlgFactorDatafrme.Name = "ucrSelectorSubDlgFactorDatafrme"
        Me.ucrSelectorSubDlgFactorDatafrme.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorSubDlgFactorDatafrme.TabIndex = 1
        '
        'ucrReceiverLabels
        '
        Me.ucrReceiverLabels.Location = New System.Drawing.Point(252, 110)
        Me.ucrReceiverLabels.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLabels.Name = "ucrReceiverLabels"
        Me.ucrReceiverLabels.Selector = Nothing
        Me.ucrReceiverLabels.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverLabels.TabIndex = 2
        '
        'ucrReceiverMatchColumn
        '
        Me.ucrReceiverMatchColumn.Location = New System.Drawing.Point(252, 51)
        Me.ucrReceiverMatchColumn.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMatchColumn.Name = "ucrReceiverMatchColumn"
        Me.ucrReceiverMatchColumn.Selector = Nothing
        Me.ucrReceiverMatchColumn.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverMatchColumn.TabIndex = 2
        '
        'lblMatchingColumn
        '
        Me.lblMatchingColumn.AutoSize = True
        Me.lblMatchingColumn.Location = New System.Drawing.Point(249, 36)
        Me.lblMatchingColumn.Name = "lblMatchingColumn"
        Me.lblMatchingColumn.Size = New System.Drawing.Size(137, 13)
        Me.lblMatchingColumn.TabIndex = 3
        Me.lblMatchingColumn.Text = "Matching Column (Optional)"
        '
        'lbllabel
        '
        Me.lbllabel.AutoSize = True
        Me.lbllabel.Location = New System.Drawing.Point(249, 95)
        Me.lbllabel.Name = "lbllabel"
        Me.lbllabel.Size = New System.Drawing.Size(122, 13)
        Me.lbllabel.TabIndex = 3
        Me.lbllabel.Text = "Levels/Labels (Optional)"
        '
        'sdgFactorDataFrame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 261)
        Me.Controls.Add(Me.lbllabel)
        Me.Controls.Add(Me.lblMatchingColumn)
        Me.Controls.Add(Me.ucrReceiverMatchColumn)
        Me.Controls.Add(Me.ucrReceiverLabels)
        Me.Controls.Add(Me.ucrSelectorSubDlgFactorDatafrme)
        Me.Controls.Add(Me.ucrBaseFactorSubdlg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgFactorDataFrame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Use Factor Sheet"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBaseFactorSubdlg As ucrButtonsSubdialogue
    Friend WithEvents ucrSelectorSubDlgFactorDatafrme As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverLabels As ucrReceiverSingle
    Friend WithEvents ucrReceiverMatchColumn As ucrReceiverSingle
    Friend WithEvents lblMatchingColumn As Label
    Friend WithEvents lbllabel As Label
End Class
