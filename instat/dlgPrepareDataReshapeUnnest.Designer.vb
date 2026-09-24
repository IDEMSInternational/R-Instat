<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgPrepareDataReshapeUnnest
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
        Me.ucrSavePrepareDataReshapeUnnest = New instat.ucrSave()
        Me.ucrReceiverFirstVariables = New instat.ucrReceiverMultiple()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorPrepareDataReshapeUnnest = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'lblFirstVariables
        '
        Me.lblFirstVariables.AutoSize = True
        Me.lblFirstVariables.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFirstVariables.Location = New System.Drawing.Point(377, 64)
        Me.lblFirstVariables.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFirstVariables.Name = "lblFirstVariables"
        Me.lblFirstVariables.Size = New System.Drawing.Size(68, 16)
        Me.lblFirstVariables.TabIndex = 25
        Me.lblFirstVariables.Tag = ""
        Me.lblFirstVariables.Text = "Variables:"
        '
        'ucrSavePrepareDataReshapeUnnest
        '
        Me.ucrSavePrepareDataReshapeUnnest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSavePrepareDataReshapeUnnest.Location = New System.Drawing.Point(12, 368)
        Me.ucrSavePrepareDataReshapeUnnest.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ucrSavePrepareDataReshapeUnnest.Name = "ucrSavePrepareDataReshapeUnnest"
        Me.ucrSavePrepareDataReshapeUnnest.Size = New System.Drawing.Size(408, 30)
        Me.ucrSavePrepareDataReshapeUnnest.TabIndex = 27
        '
        'ucrReceiverFirstVariables
        '
        Me.ucrReceiverFirstVariables.AutoSize = True
        Me.ucrReceiverFirstVariables.frmParent = Me
        Me.ucrReceiverFirstVariables.Location = New System.Drawing.Point(377, 82)
        Me.ucrReceiverFirstVariables.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFirstVariables.Name = "ucrReceiverFirstVariables"
        Me.ucrReceiverFirstVariables.Selector = Nothing
        Me.ucrReceiverFirstVariables.Size = New System.Drawing.Size(160, 97)
        Me.ucrReceiverFirstVariables.strNcFilePath = ""
        Me.ucrReceiverFirstVariables.TabIndex = 26
        Me.ucrReceiverFirstVariables.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(12, 425)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(511, 65)
        Me.ucrBase.TabIndex = 24
        '
        'ucrSelectorPrepareDataReshapeUnnest
        '
        Me.ucrSelectorPrepareDataReshapeUnnest.AutoSize = True
        Me.ucrSelectorPrepareDataReshapeUnnest.bDropUnusedFilterLevels = False
        Me.ucrSelectorPrepareDataReshapeUnnest.bShowHiddenColumns = False
        Me.ucrSelectorPrepareDataReshapeUnnest.bUseCurrentFilter = True
        Me.ucrSelectorPrepareDataReshapeUnnest.Location = New System.Drawing.Point(12, 43)
        Me.ucrSelectorPrepareDataReshapeUnnest.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorPrepareDataReshapeUnnest.Name = "ucrSelectorPrepareDataReshapeUnnest"
        Me.ucrSelectorPrepareDataReshapeUnnest.Size = New System.Drawing.Size(284, 227)
        Me.ucrSelectorPrepareDataReshapeUnnest.TabIndex = 5
        '
        'dlgPrepareDataReshapeUnnest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 507)
        Me.Controls.Add(Me.ucrSavePrepareDataReshapeUnnest)
        Me.Controls.Add(Me.ucrReceiverFirstVariables)
        Me.Controls.Add(Me.lblFirstVariables)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorPrepareDataReshapeUnnest)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgPrepareDataReshapeUnnest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Unnest"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorPrepareDataReshapeUnnest As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverFirstVariables As ucrReceiverMultiple
    Friend WithEvents lblFirstVariables As Label
    Friend WithEvents ucrSavePrepareDataReshapeUnnest As ucrSave
End Class



