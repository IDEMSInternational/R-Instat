<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgExperimentsGreaterthanDesign
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
        Me.lblFirstVariables = New System.Windows.Forms.Label()
        Me.ucrSaveExperimentsGreaterthanDesign = New instat.ucrSave()
        Me.ucrReceiverFirstVariables = New instat.ucrReceiverMultiple()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorReshapeGreaterthanUnnest = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'lblFirstVariables
        '
        Me.lblFirstVariables.AutoSize = True
        Me.lblFirstVariables.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFirstVariables.Location = New System.Drawing.Point(283, 52)
        Me.lblFirstVariables.Name = "lblFirstVariables"
        Me.lblFirstVariables.Size = New System.Drawing.Size(53, 13)
        Me.lblFirstVariables.TabIndex = 25
        Me.lblFirstVariables.Tag = ""
        Me.lblFirstVariables.Text = "Variables:"
        '
        'ucrSaveExperimentsGreaterthanDesign
        '
        Me.ucrSaveExperimentsGreaterthanDesign.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveExperimentsGreaterthanDesign.Location = New System.Drawing.Point(9, 299)
        Me.ucrSaveExperimentsGreaterthanDesign.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveExperimentsGreaterthanDesign.Name = "ucrSaveExperimentsGreaterthanDesign"
        Me.ucrSaveExperimentsGreaterthanDesign.Size = New System.Drawing.Size(306, 24)
        Me.ucrSaveExperimentsGreaterthanDesign.TabIndex = 27
        '
        'ucrReceiverFirstVariables
        '
        Me.ucrReceiverFirstVariables.AutoSize = True
        Me.ucrReceiverFirstVariables.frmParent = Me
        Me.ucrReceiverFirstVariables.Location = New System.Drawing.Point(283, 67)
        Me.ucrReceiverFirstVariables.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFirstVariables.Name = "ucrReceiverFirstVariables"
        Me.ucrReceiverFirstVariables.Selector = Nothing
        Me.ucrReceiverFirstVariables.Size = New System.Drawing.Size(120, 79)
        Me.ucrReceiverFirstVariables.strNcFilePath = ""
        Me.ucrReceiverFirstVariables.TabIndex = 26
        Me.ucrReceiverFirstVariables.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(9, 345)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 24
        '
        'ucrSelectorReshapeGreaterthanUnnest
        '
        Me.ucrSelectorReshapeGreaterthanUnnest.AutoSize = True
        Me.ucrSelectorReshapeGreaterthanUnnest.bDropUnusedFilterLevels = False
        Me.ucrSelectorReshapeGreaterthanUnnest.bShowHiddenColumns = False
        Me.ucrSelectorReshapeGreaterthanUnnest.bUseCurrentFilter = True
        Me.ucrSelectorReshapeGreaterthanUnnest.Location = New System.Drawing.Point(9, 35)
        Me.ucrSelectorReshapeGreaterthanUnnest.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorReshapeGreaterthanUnnest.Name = "ucrSelectorReshapeGreaterthanUnnest"
        Me.ucrSelectorReshapeGreaterthanUnnest.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorReshapeGreaterthanUnnest.TabIndex = 5
        '
        'dlgExperimentsGreaterthanDesign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 412)
        Me.Controls.Add(Me.ucrSaveExperimentsGreaterthanDesign)
        Me.Controls.Add(Me.ucrReceiverFirstVariables)
        Me.Controls.Add(Me.lblFirstVariables)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorReshapeGreaterthanUnnest)
        Me.Name = "dlgExperimentsGreaterthanDesign"
        Me.Text = "dlgExperimentsGreaterthanDesign"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorReshapeGreaterthanUnnest As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverFirstVariables As ucrReceiverMultiple
    Friend WithEvents lblFirstVariables As Label
    Friend WithEvents ucrSaveExperimentsGreaterthanDesign As ucrSave
End Class
