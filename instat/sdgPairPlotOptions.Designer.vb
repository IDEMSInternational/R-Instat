<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgPairPlotOptions
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tpLegend = New System.Windows.Forms.TabPage()
        Me.tbInventory = New System.Windows.Forms.TabControl()
        Me.ucrButtonsInventoryplot = New instat.ucrButtonsSubdialogue()
        Me.ucrChkShowLegend = New instat.ucrCheck()
        Me.ucrInputLegendPosition = New instat.ucrInputComboBox()
        Me.ucrChkLegendPosition = New instat.ucrCheck()
        Me.tpLegend.SuspendLayout()
        Me.tbInventory.SuspendLayout()
        Me.SuspendLayout()
        '
        'tpLegend
        '
        Me.tpLegend.Controls.Add(Me.ucrChkShowLegend)
        Me.tpLegend.Controls.Add(Me.ucrInputLegendPosition)
        Me.tpLegend.Controls.Add(Me.ucrChkLegendPosition)
        Me.tpLegend.Location = New System.Drawing.Point(4, 22)
        Me.tpLegend.Name = "tpLegend"
        Me.tpLegend.Padding = New System.Windows.Forms.Padding(3)
        Me.tpLegend.Size = New System.Drawing.Size(299, 62)
        Me.tpLegend.TabIndex = 3
        Me.tpLegend.Text = "Legend"
        Me.tpLegend.UseVisualStyleBackColor = True
        '
        'tbInventory
        '
        Me.tbInventory.Controls.Add(Me.tpLegend)
        Me.tbInventory.Location = New System.Drawing.Point(3, 0)
        Me.tbInventory.Name = "tbInventory"
        Me.tbInventory.SelectedIndex = 0
        Me.tbInventory.Size = New System.Drawing.Size(307, 88)
        Me.tbInventory.TabIndex = 2
        '
        'ucrButtonsInventoryplot
        '
        Me.ucrButtonsInventoryplot.AutoSize = True
        Me.ucrButtonsInventoryplot.Location = New System.Drawing.Point(46, 94)
        Me.ucrButtonsInventoryplot.Name = "ucrButtonsInventoryplot"
        Me.ucrButtonsInventoryplot.Size = New System.Drawing.Size(224, 30)
        Me.ucrButtonsInventoryplot.TabIndex = 4
        '
        'ucrChkShowLegend
        '
        Me.ucrChkShowLegend.AutoSize = True
        Me.ucrChkShowLegend.Checked = False
        Me.ucrChkShowLegend.Location = New System.Drawing.Point(7, 5)
        Me.ucrChkShowLegend.Name = "ucrChkShowLegend"
        Me.ucrChkShowLegend.Size = New System.Drawing.Size(204, 23)
        Me.ucrChkShowLegend.TabIndex = 2
        '
        'ucrInputLegendPosition
        '
        Me.ucrInputLegendPosition.AddQuotesIfUnrecognised = True
        Me.ucrInputLegendPosition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLegendPosition.GetSetSelectedIndex = -1
        Me.ucrInputLegendPosition.IsReadOnly = False
        Me.ucrInputLegendPosition.Location = New System.Drawing.Point(154, 33)
        Me.ucrInputLegendPosition.Name = "ucrInputLegendPosition"
        Me.ucrInputLegendPosition.Size = New System.Drawing.Size(134, 25)
        Me.ucrInputLegendPosition.TabIndex = 1
        '
        'ucrChkLegendPosition
        '
        Me.ucrChkLegendPosition.AutoSize = True
        Me.ucrChkLegendPosition.Checked = False
        Me.ucrChkLegendPosition.Location = New System.Drawing.Point(7, 35)
        Me.ucrChkLegendPosition.Name = "ucrChkLegendPosition"
        Me.ucrChkLegendPosition.Size = New System.Drawing.Size(204, 23)
        Me.ucrChkLegendPosition.TabIndex = 0
        '
        'sdgPairPlotOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 128)
        Me.Controls.Add(Me.ucrButtonsInventoryplot)
        Me.Controls.Add(Me.tbInventory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgPairPlotOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pair Plot Options"
        Me.tpLegend.ResumeLayout(False)
        Me.tpLegend.PerformLayout()
        Me.tbInventory.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tpLegend As TabPage
    Friend WithEvents ucrInputLegendPosition As ucrInputComboBox
    Friend WithEvents ucrChkLegendPosition As ucrCheck
    Friend WithEvents tbInventory As TabControl
    Friend WithEvents ucrChkShowLegend As ucrCheck
    Friend WithEvents ucrButtonsInventoryplot As ucrButtonsSubdialogue
End Class
