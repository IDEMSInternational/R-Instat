<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgTableRowExpression
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
        Me.cboCondition = New System.Windows.Forms.ComboBox()
        Me.lblCondition = New System.Windows.Forms.Label()
        Me.lblExpression = New System.Windows.Forms.Label()
        Me.ucrSelectorCols = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrSdgBaseButtons = New instat.ucrButtonsSubdialogue()
        Me.btnAddCondition = New System.Windows.Forms.Button()
        Me.ucrReceiverExpression = New instat.ucrReceiverExpression()
        Me.SuspendLayout()
        '
        'cboCondition
        '
        Me.cboCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCondition.FormattingEnabled = True
        Me.cboCondition.Items.AddRange(New Object() {"==", "<", "<=", ">", ">=", "!=", "Expression"})
        Me.cboCondition.Location = New System.Drawing.Point(240, 25)
        Me.cboCondition.Name = "cboCondition"
        Me.cboCondition.Size = New System.Drawing.Size(148, 21)
        Me.cboCondition.TabIndex = 285
        '
        'lblCondition
        '
        Me.lblCondition.AutoSize = True
        Me.lblCondition.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCondition.Location = New System.Drawing.Point(237, 9)
        Me.lblCondition.Name = "lblCondition"
        Me.lblCondition.Size = New System.Drawing.Size(54, 13)
        Me.lblCondition.TabIndex = 284
        Me.lblCondition.Text = "Condition:"
        '
        'lblExpression
        '
        Me.lblExpression.AutoSize = True
        Me.lblExpression.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblExpression.Location = New System.Drawing.Point(237, 102)
        Me.lblExpression.Name = "lblExpression"
        Me.lblExpression.Size = New System.Drawing.Size(61, 13)
        Me.lblExpression.TabIndex = 283
        Me.lblExpression.Text = "Expression:"
        '
        'ucrSelectorCols
        '
        Me.ucrSelectorCols.AutoSize = True
        Me.ucrSelectorCols.bDropUnusedFilterLevels = False
        Me.ucrSelectorCols.bShowHiddenColumns = False
        Me.ucrSelectorCols.bUseCurrentFilter = True
        Me.ucrSelectorCols.Location = New System.Drawing.Point(5, 4)
        Me.ucrSelectorCols.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorCols.Name = "ucrSelectorCols"
        Me.ucrSelectorCols.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorCols.TabIndex = 281
        '
        'ucrSdgBaseButtons
        '
        Me.ucrSdgBaseButtons.AutoSize = True
        Me.ucrSdgBaseButtons.Location = New System.Drawing.Point(106, 220)
        Me.ucrSdgBaseButtons.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrSdgBaseButtons.Name = "ucrSdgBaseButtons"
        Me.ucrSdgBaseButtons.Size = New System.Drawing.Size(224, 30)
        Me.ucrSdgBaseButtons.TabIndex = 344
        '
        'btnAddCondition
        '
        Me.btnAddCondition.Location = New System.Drawing.Point(387, 23)
        Me.btnAddCondition.Name = "btnAddCondition"
        Me.btnAddCondition.Size = New System.Drawing.Size(65, 23)
        Me.btnAddCondition.TabIndex = 346
        Me.btnAddCondition.Text = "Add"
        Me.btnAddCondition.UseVisualStyleBackColor = True
        '
        'ucrReceiverExpression
        '
        Me.ucrReceiverExpression.AutoSize = True
        Me.ucrReceiverExpression.frmParent = Me
        Me.ucrReceiverExpression.Location = New System.Drawing.Point(240, 118)
        Me.ucrReceiverExpression.Name = "ucrReceiverExpression"
        Me.ucrReceiverExpression.Selector = Nothing
        Me.ucrReceiverExpression.Size = New System.Drawing.Size(177, 29)
        Me.ucrReceiverExpression.strNcFilePath = ""
        Me.ucrReceiverExpression.TabIndex = 347
        Me.ucrReceiverExpression.ucrSelector = Nothing
        '
        'sdgTableRowExpression
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 258)
        Me.Controls.Add(Me.ucrReceiverExpression)
        Me.Controls.Add(Me.btnAddCondition)
        Me.Controls.Add(Me.ucrSdgBaseButtons)
        Me.Controls.Add(Me.cboCondition)
        Me.Controls.Add(Me.lblCondition)
        Me.Controls.Add(Me.lblExpression)
        Me.Controls.Add(Me.ucrSelectorCols)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "sdgTableRowExpression"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Set Expression"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboCondition As ComboBox
    Friend WithEvents lblCondition As Label
    Friend WithEvents lblExpression As Label
    Friend WithEvents ucrSelectorCols As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSdgBaseButtons As ucrButtonsSubdialogue
    Friend WithEvents btnAddCondition As Button
    Friend WithEvents ucrReceiverExpression As ucrReceiverExpression
End Class
