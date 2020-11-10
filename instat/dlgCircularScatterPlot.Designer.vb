<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgCircularScatterPlot
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
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorCircularDataFrame = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverVariable = New instat.ucrReceiverSingle()
        Me.lblElement = New System.Windows.Forms.Label()
        Me.ucrSaveScatterPlot = New instat.ucrSave()
        Me.cmdScatterPlotOptions = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(5, 297)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSelectorCircularDataFrame
        '
        Me.ucrSelectorCircularDataFrame.bDropUnusedFilterLevels = False
        Me.ucrSelectorCircularDataFrame.bShowHiddenColumns = False
        Me.ucrSelectorCircularDataFrame.bUseCurrentFilter = True
        Me.ucrSelectorCircularDataFrame.Location = New System.Drawing.Point(9, 9)
        Me.ucrSelectorCircularDataFrame.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorCircularDataFrame.Name = "ucrSelectorCircularDataFrame"
        Me.ucrSelectorCircularDataFrame.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorCircularDataFrame.TabIndex = 1
        '
        'ucrReceiverVariable
        '
        Me.ucrReceiverVariable.frmParent = Me
        Me.ucrReceiverVariable.Location = New System.Drawing.Point(276, 41)
        Me.ucrReceiverVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverVariable.Name = "ucrReceiverVariable"
        Me.ucrReceiverVariable.Selector = Nothing
        Me.ucrReceiverVariable.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverVariable.strNcFilePath = ""
        Me.ucrReceiverVariable.TabIndex = 2
        Me.ucrReceiverVariable.ucrSelector = Nothing
        '
        'lblElement
        '
        Me.lblElement.AutoSize = True
        Me.lblElement.Location = New System.Drawing.Point(271, 26)
        Me.lblElement.Name = "lblElement"
        Me.lblElement.Size = New System.Drawing.Size(48, 13)
        Me.lblElement.TabIndex = 3
        Me.lblElement.Text = "Variable:"
        '
        'ucrSaveScatterPlot
        '
        Me.ucrSaveScatterPlot.Location = New System.Drawing.Point(5, 263)
        Me.ucrSaveScatterPlot.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveScatterPlot.Name = "ucrSaveScatterPlot"
        Me.ucrSaveScatterPlot.Size = New System.Drawing.Size(255, 24)
        Me.ucrSaveScatterPlot.TabIndex = 4
        '
        'cmdScatterPlotOptions
        '
        Me.cmdScatterPlotOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdScatterPlotOptions.Location = New System.Drawing.Point(5, 194)
        Me.cmdScatterPlotOptions.Name = "cmdScatterPlotOptions"
        Me.cmdScatterPlotOptions.Size = New System.Drawing.Size(120, 25)
        Me.cmdScatterPlotOptions.TabIndex = 9
        Me.cmdScatterPlotOptions.Tag = ""
        Me.cmdScatterPlotOptions.Text = "Scatter Plot Options"
        Me.cmdScatterPlotOptions.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(5, 225)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 25)
        Me.Button1.TabIndex = 10
        Me.Button1.Tag = ""
        Me.Button1.Text = "Scatter Plot Options"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dlgCircularScatterPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 351)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmdScatterPlotOptions)
        Me.Controls.Add(Me.ucrSaveScatterPlot)
        Me.Controls.Add(Me.lblElement)
        Me.Controls.Add(Me.ucrReceiverVariable)
        Me.Controls.Add(Me.ucrSelectorCircularDataFrame)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCircularScatterPlot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Scatter Plot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorCircularDataFrame As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverVariable As ucrReceiverSingle
    Friend WithEvents lblElement As Label
    Friend WithEvents ucrSaveScatterPlot As ucrSave
    Friend WithEvents cmdScatterPlotOptions As Button
    Friend WithEvents Button1 As Button
End Class
