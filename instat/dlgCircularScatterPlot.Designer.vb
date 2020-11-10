<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgCircularScatterPlot
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
        Me.ucrSelectorCircularDataFrame = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverCircularData = New instat.ucrReceiverSingle()
        Me.lblElement = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(5, 266)
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
        'ucrReceiverCircularData
        '
        Me.ucrReceiverCircularData.frmParent = Me
        Me.ucrReceiverCircularData.Location = New System.Drawing.Point(276, 41)
        Me.ucrReceiverCircularData.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverCircularData.Name = "ucrReceiverCircularData"
        Me.ucrReceiverCircularData.Selector = Nothing
        Me.ucrReceiverCircularData.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverCircularData.strNcFilePath = ""
        Me.ucrReceiverCircularData.TabIndex = 2
        Me.ucrReceiverCircularData.ucrSelector = Nothing
        '
        'lblElement
        '
        Me.lblElement.AutoSize = True
        Me.lblElement.Location = New System.Drawing.Point(279, 25)
        Me.lblElement.Name = "lblElement"
        Me.lblElement.Size = New System.Drawing.Size(48, 13)
        Me.lblElement.TabIndex = 3
        Me.lblElement.Text = "Element:"
        '
        'dlgCircularScatterPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 323)
        Me.Controls.Add(Me.lblElement)
        Me.Controls.Add(Me.ucrReceiverCircularData)
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
    Friend WithEvents ucrReceiverCircularData As ucrReceiverSingle
    Friend WithEvents lblElement As Label
End Class
