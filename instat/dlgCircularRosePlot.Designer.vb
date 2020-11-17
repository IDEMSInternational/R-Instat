<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgCircularRosePlot
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
        Me.ucrSelctorCircularDataFrame = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrSaveCircularRosePlot = New instat.ucrSave()
        Me.ucrReceiverVariable = New instat.ucrReceiverSingle()
        Me.lblVariable = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(6, 273)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(406, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSelctorCircularDataFrame
        '
        Me.ucrSelctorCircularDataFrame.bDropUnusedFilterLevels = False
        Me.ucrSelctorCircularDataFrame.bShowHiddenColumns = False
        Me.ucrSelctorCircularDataFrame.bUseCurrentFilter = True
        Me.ucrSelctorCircularDataFrame.Location = New System.Drawing.Point(6, 9)
        Me.ucrSelctorCircularDataFrame.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelctorCircularDataFrame.Name = "ucrSelctorCircularDataFrame"
        Me.ucrSelctorCircularDataFrame.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelctorCircularDataFrame.TabIndex = 1
        '
        'ucrSaveCircularRosePlot
        '
        Me.ucrSaveCircularRosePlot.Location = New System.Drawing.Point(6, 232)
        Me.ucrSaveCircularRosePlot.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveCircularRosePlot.Name = "ucrSaveCircularRosePlot"
        Me.ucrSaveCircularRosePlot.Size = New System.Drawing.Size(279, 28)
        Me.ucrSaveCircularRosePlot.TabIndex = 2
        '
        'ucrReceiverVariable
        '
        Me.ucrReceiverVariable.frmParent = Me
        Me.ucrReceiverVariable.Location = New System.Drawing.Point(292, 64)
        Me.ucrReceiverVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverVariable.Name = "ucrReceiverVariable"
        Me.ucrReceiverVariable.Selector = Nothing
        Me.ucrReceiverVariable.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverVariable.strNcFilePath = ""
        Me.ucrReceiverVariable.TabIndex = 3
        Me.ucrReceiverVariable.ucrSelector = Nothing
        '
        'lblVariable
        '
        Me.lblVariable.AutoSize = True
        Me.lblVariable.Location = New System.Drawing.Point(289, 42)
        Me.lblVariable.Name = "lblVariable"
        Me.lblVariable.Size = New System.Drawing.Size(48, 13)
        Me.lblVariable.TabIndex = 4
        Me.lblVariable.Text = "Variable:"
        '
        'dlgCircularRosePlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 330)
        Me.Controls.Add(Me.lblVariable)
        Me.Controls.Add(Me.ucrReceiverVariable)
        Me.Controls.Add(Me.ucrSaveCircularRosePlot)
        Me.Controls.Add(Me.ucrSelctorCircularDataFrame)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCircularRosePlot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rose Plot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelctorCircularDataFrame As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSaveCircularRosePlot As ucrSave
    Friend WithEvents ucrReceiverVariable As ucrReceiverSingle
    Friend WithEvents lblVariable As Label
End Class
