﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgStemAndLeaf
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
        Me.ucrReceiverStemAndLeaf = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.lblSelectedVariable = New System.Windows.Forms.Label()
        Me.ucrStemLeafSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'ucrReceiverStemAndLeaf
        '
        Me.ucrReceiverStemAndLeaf.frmParent = Me
        Me.ucrReceiverStemAndLeaf.Location = New System.Drawing.Point(258, 60)
        Me.ucrReceiverStemAndLeaf.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStemAndLeaf.Name = "ucrReceiverStemAndLeaf"
        Me.ucrReceiverStemAndLeaf.Selector = Nothing
        Me.ucrReceiverStemAndLeaf.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverStemAndLeaf.TabIndex = 2
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 201)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 3
        '
        'lblSelectedVariable
        '
        Me.lblSelectedVariable.AutoSize = True
        Me.lblSelectedVariable.Location = New System.Drawing.Point(256, 45)
        Me.lblSelectedVariable.Name = "lblSelectedVariable"
        Me.lblSelectedVariable.Size = New System.Drawing.Size(93, 13)
        Me.lblSelectedVariable.TabIndex = 1
        Me.lblSelectedVariable.Tag = "Selected_Variable:"
        Me.lblSelectedVariable.Text = "Selected Variable:"
        '
        'ucrStemLeafSelector
        '
        Me.ucrStemLeafSelector.bShowHiddenColumns = False
        Me.ucrStemLeafSelector.bUseCurrentFilter = True
        Me.ucrStemLeafSelector.Location = New System.Drawing.Point(10, 10)
        Me.ucrStemLeafSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrStemLeafSelector.Name = "ucrStemLeafSelector"
        Me.ucrStemLeafSelector.Size = New System.Drawing.Size(242, 188)
        Me.ucrStemLeafSelector.TabIndex = 0
        '
        'dlgStemAndLeaf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 254)
        Me.Controls.Add(Me.ucrStemLeafSelector)
        Me.Controls.Add(Me.lblSelectedVariable)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReceiverStemAndLeaf)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgStemAndLeaf"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Stem_and_Leaf"
        Me.Text = "Stem and Leaf"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrReceiverStemAndLeaf As ucrReceiverSingle
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblSelectedVariable As Label
    Friend WithEvents ucrStemLeafSelector As ucrSelectorByDataFrameAddRemove
End Class