<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sdgTableRowExpression
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
        Me.cboCondition.Location = New System.Drawing.Point(360, 38)
        Me.cboCondition.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboCondition.Name = "cboCondition"
        Me.cboCondition.Size = New System.Drawing.Size(220, 28)
        Me.cboCondition.TabIndex = 285
        '
        'lblCondition
        '
        Me.lblCondition.AutoSize = True
        Me.lblCondition.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCondition.Location = New System.Drawing.Point(356, 14)
        Me.lblCondition.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCondition.Name = "lblCondition"
        Me.lblCondition.Size = New System.Drawing.Size(80, 20)
        Me.lblCondition.TabIndex = 284
        Me.lblCondition.Text = "Condition:"
        '
        'lblExpression
        '
        Me.lblExpression.AutoSize = True
        Me.lblExpression.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblExpression.Location = New System.Drawing.Point(356, 157)
        Me.lblExpression.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblExpression.Name = "lblExpression"
        Me.lblExpression.Size = New System.Drawing.Size(91, 20)
        Me.lblExpression.TabIndex = 283
        Me.lblExpression.Text = "Expression:"
        '
        'ucrSelectorCols
        '
        Me.ucrSelectorCols.AutoSize = True
        Me.ucrSelectorCols.bDropUnusedFilterLevels = False
        Me.ucrSelectorCols.bShowHiddenColumns = False
        Me.ucrSelectorCols.bUseCurrentFilter = True
        Me.ucrSelectorCols.Location = New System.Drawing.Point(8, 6)
        Me.ucrSelectorCols.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorCols.Name = "ucrSelectorCols"
        Me.ucrSelectorCols.Size = New System.Drawing.Size(320, 282)
        Me.ucrSelectorCols.TabIndex = 281
        '
        'ucrSdgBaseButtons
        '
        Me.ucrSdgBaseButtons.AutoSize = True
        Me.ucrSdgBaseButtons.Location = New System.Drawing.Point(159, 338)
        Me.ucrSdgBaseButtons.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrSdgBaseButtons.Name = "ucrSdgBaseButtons"
        Me.ucrSdgBaseButtons.Size = New System.Drawing.Size(336, 46)
        Me.ucrSdgBaseButtons.TabIndex = 344
        '
        'btnAddCondition
        '
        Me.btnAddCondition.Location = New System.Drawing.Point(580, 35)
        Me.btnAddCondition.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAddCondition.Name = "btnAddCondition"
        Me.btnAddCondition.Size = New System.Drawing.Size(98, 35)
        Me.btnAddCondition.TabIndex = 346
        Me.btnAddCondition.Text = "Add"
        Me.btnAddCondition.UseVisualStyleBackColor = True
        '
        'ucrReceiverExpression
        '
        Me.ucrReceiverExpression.AutoSize = True
        Me.ucrReceiverExpression.frmParent = Me
        Me.ucrReceiverExpression.Location = New System.Drawing.Point(360, 182)
        Me.ucrReceiverExpression.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrReceiverExpression.Name = "ucrReceiverExpression"
        Me.ucrReceiverExpression.Selector = Nothing
        Me.ucrReceiverExpression.Size = New System.Drawing.Size(266, 45)
        Me.ucrReceiverExpression.strNcFilePath = ""
        Me.ucrReceiverExpression.TabIndex = 347
        Me.ucrReceiverExpression.ucrSelector = Nothing
        '
        'sdgTableRowExpression
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 397)
        Me.Controls.Add(Me.ucrReceiverExpression)
        Me.Controls.Add(Me.btnAddCondition)
        Me.Controls.Add(Me.ucrSdgBaseButtons)
        Me.Controls.Add(Me.cboCondition)
        Me.Controls.Add(Me.lblCondition)
        Me.Controls.Add(Me.lblExpression)
        Me.Controls.Add(Me.ucrSelectorCols)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
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
