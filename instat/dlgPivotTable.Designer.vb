<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgPivotTable
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
        Me.components = New System.ComponentModel.Container()
        Me.lblInitialRowFactor = New System.Windows.Forms.Label()
        Me.lblInitialColumnFactor = New System.Windows.Forms.Label()
        Me.ttSelectedVariable = New System.Windows.Forms.ToolTip(Me.components)
        Me.UcrReceiverMultipleIntialRowFactor = New instat.ucrReceiverMultiple()
        Me.ucrSavePivot = New instat.ucrSave()
        Me.ucrChkIncludeSubTotals = New instat.ucrCheck()
        Me.ucrReceiverSelectedVariable = New instat.ucrReceiverMultiple()
        Me.ucrChkSelectedVariable = New instat.ucrCheck()
        Me.ucrReceiverInitialColumnFactor = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorPivot = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'lblInitialRowFactor
        '
        Me.lblInitialRowFactor.AutoSize = True
        Me.lblInitialRowFactor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblInitialRowFactor.Location = New System.Drawing.Point(251, 34)
        Me.lblInitialRowFactor.Name = "lblInitialRowFactor"
        Me.lblInitialRowFactor.Size = New System.Drawing.Size(103, 13)
        Me.lblInitialRowFactor.TabIndex = 25
        Me.lblInitialRowFactor.Tag = "Initial Row Factor:"
        Me.lblInitialRowFactor.Text = "Initial Row Factor(s):"
        '
        'lblInitialColumnFactor
        '
        Me.lblInitialColumnFactor.AutoSize = True
        Me.lblInitialColumnFactor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblInitialColumnFactor.Location = New System.Drawing.Point(248, 156)
        Me.lblInitialColumnFactor.Name = "lblInitialColumnFactor"
        Me.lblInitialColumnFactor.Size = New System.Drawing.Size(105, 13)
        Me.lblInitialColumnFactor.TabIndex = 27
        Me.lblInitialColumnFactor.Tag = "Initial Column Factor:"
        Me.lblInitialColumnFactor.Text = "Initial Column Factor:"
        '
        'UcrReceiverMultipleIntialRowFactor
        '
        Me.UcrReceiverMultipleIntialRowFactor.AutoSize = True
        Me.UcrReceiverMultipleIntialRowFactor.frmParent = Me
        Me.UcrReceiverMultipleIntialRowFactor.Location = New System.Drawing.Point(248, 49)
        Me.UcrReceiverMultipleIntialRowFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrReceiverMultipleIntialRowFactor.Name = "UcrReceiverMultipleIntialRowFactor"
        Me.UcrReceiverMultipleIntialRowFactor.Selector = Nothing
        Me.UcrReceiverMultipleIntialRowFactor.Size = New System.Drawing.Size(120, 100)
        Me.UcrReceiverMultipleIntialRowFactor.strNcFilePath = ""
        Me.UcrReceiverMultipleIntialRowFactor.TabIndex = 38
        Me.UcrReceiverMultipleIntialRowFactor.ucrSelector = Nothing
        '
        'ucrSavePivot
        '
        Me.ucrSavePivot.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSavePivot.Location = New System.Drawing.Point(9, 331)
        Me.ucrSavePivot.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSavePivot.Name = "ucrSavePivot"
        Me.ucrSavePivot.Size = New System.Drawing.Size(314, 23)
        Me.ucrSavePivot.TabIndex = 37
        '
        'ucrChkIncludeSubTotals
        '
        Me.ucrChkIncludeSubTotals.AutoSize = True
        Me.ucrChkIncludeSubTotals.Checked = False
        Me.ucrChkIncludeSubTotals.Location = New System.Drawing.Point(9, 197)
        Me.ucrChkIncludeSubTotals.Name = "ucrChkIncludeSubTotals"
        Me.ucrChkIncludeSubTotals.Size = New System.Drawing.Size(167, 23)
        Me.ucrChkIncludeSubTotals.TabIndex = 36
        '
        'ucrReceiverSelectedVariable
        '
        Me.ucrReceiverSelectedVariable.AutoSize = True
        Me.ucrReceiverSelectedVariable.frmParent = Me
        Me.ucrReceiverSelectedVariable.Location = New System.Drawing.Point(248, 214)
        Me.ucrReceiverSelectedVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSelectedVariable.Name = "ucrReceiverSelectedVariable"
        Me.ucrReceiverSelectedVariable.Selector = Nothing
        Me.ucrReceiverSelectedVariable.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverSelectedVariable.strNcFilePath = ""
        Me.ucrReceiverSelectedVariable.TabIndex = 35
        Me.ucrReceiverSelectedVariable.ucrSelector = Nothing
        '
        'ucrChkSelectedVariable
        '
        Me.ucrChkSelectedVariable.AutoSize = True
        Me.ucrChkSelectedVariable.Checked = False
        Me.ucrChkSelectedVariable.Location = New System.Drawing.Point(248, 197)
        Me.ucrChkSelectedVariable.Name = "ucrChkSelectedVariable"
        Me.ucrChkSelectedVariable.Size = New System.Drawing.Size(135, 23)
        Me.ucrChkSelectedVariable.TabIndex = 34
        '
        'ucrReceiverInitialColumnFactor
        '
        Me.ucrReceiverInitialColumnFactor.AutoSize = True
        Me.ucrReceiverInitialColumnFactor.frmParent = Me
        Me.ucrReceiverInitialColumnFactor.Location = New System.Drawing.Point(248, 169)
        Me.ucrReceiverInitialColumnFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverInitialColumnFactor.Name = "ucrReceiverInitialColumnFactor"
        Me.ucrReceiverInitialColumnFactor.Selector = Nothing
        Me.ucrReceiverInitialColumnFactor.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverInitialColumnFactor.strNcFilePath = ""
        Me.ucrReceiverInitialColumnFactor.TabIndex = 28
        Me.ucrReceiverInitialColumnFactor.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(9, 362)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 24
        '
        'ucrSelectorPivot
        '
        Me.ucrSelectorPivot.AutoSize = True
        Me.ucrSelectorPivot.bDropUnusedFilterLevels = False
        Me.ucrSelectorPivot.bShowHiddenColumns = False
        Me.ucrSelectorPivot.bUseCurrentFilter = True
        Me.ucrSelectorPivot.Location = New System.Drawing.Point(9, 9)
        Me.ucrSelectorPivot.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorPivot.Name = "ucrSelectorPivot"
        Me.ucrSelectorPivot.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorPivot.TabIndex = 5
        '
        'dlgPivotTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(418, 419)
        Me.Controls.Add(Me.UcrReceiverMultipleIntialRowFactor)
        Me.Controls.Add(Me.ucrSavePivot)
        Me.Controls.Add(Me.ucrChkIncludeSubTotals)
        Me.Controls.Add(Me.ucrReceiverSelectedVariable)
        Me.Controls.Add(Me.ucrChkSelectedVariable)
        Me.Controls.Add(Me.lblInitialColumnFactor)
        Me.Controls.Add(Me.ucrReceiverInitialColumnFactor)
        Me.Controls.Add(Me.lblInitialRowFactor)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorPivot)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgPivotTable"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pivot Table"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorPivot As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblInitialRowFactor As Label
    Friend WithEvents lblInitialColumnFactor As Label
    Friend WithEvents ucrReceiverInitialColumnFactor As ucrReceiverSingle
    Friend WithEvents ucrChkSelectedVariable As ucrCheck
    Friend WithEvents ttSelectedVariable As ToolTip
    Friend WithEvents ucrReceiverSelectedVariable As ucrReceiverMultiple
    Friend WithEvents ucrChkIncludeSubTotals As ucrCheck
    Friend WithEvents ucrSavePivot As ucrSave
    Friend WithEvents UcrReceiverMultipleIntialRowFactor As ucrReceiverMultiple
End Class
