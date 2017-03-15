<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgOneWayFrequencies
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
        Me.grpSort = New System.Windows.Forms.GroupBox()
        Me.rdoDescending = New System.Windows.Forms.RadioButton()
        Me.rdoAscending = New System.Windows.Forms.RadioButton()
        Me.rdoNone = New System.Windows.Forms.RadioButton()
        Me.ucrPnlSort = New instat.UcrPanel()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.lblSelectedVariable = New System.Windows.Forms.Label()
        Me.ucrChkFlip = New instat.ucrCheck()
        Me.ucrChkGraph = New instat.ucrCheck()
        Me.ucrChkTable = New instat.ucrCheck()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrReceiverOneWayFreq = New instat.ucrReceiverSingle()
        Me.ucrSelectorOneWayFreq = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrChkweights = New instat.ucrCheck()
        Me.grpSort.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSort
        '
        Me.grpSort.Controls.Add(Me.rdoDescending)
        Me.grpSort.Controls.Add(Me.rdoAscending)
        Me.grpSort.Controls.Add(Me.rdoNone)
        Me.grpSort.Controls.Add(Me.ucrPnlSort)
        Me.grpSort.Location = New System.Drawing.Point(267, 114)
        Me.grpSort.Name = "grpSort"
        Me.grpSort.Size = New System.Drawing.Size(123, 91)
        Me.grpSort.TabIndex = 14
        Me.grpSort.TabStop = False
        Me.grpSort.Text = "Sort"
        '
        'rdoDescending
        '
        Me.rdoDescending.AutoSize = True
        Me.rdoDescending.Location = New System.Drawing.Point(10, 65)
        Me.rdoDescending.Name = "rdoDescending"
        Me.rdoDescending.Size = New System.Drawing.Size(82, 17)
        Me.rdoDescending.TabIndex = 3
        Me.rdoDescending.TabStop = True
        Me.rdoDescending.Text = "Descending"
        Me.rdoDescending.UseVisualStyleBackColor = True
        '
        'rdoAscending
        '
        Me.rdoAscending.AutoSize = True
        Me.rdoAscending.Location = New System.Drawing.Point(10, 43)
        Me.rdoAscending.Name = "rdoAscending"
        Me.rdoAscending.Size = New System.Drawing.Size(75, 17)
        Me.rdoAscending.TabIndex = 2
        Me.rdoAscending.TabStop = True
        Me.rdoAscending.Text = "Ascending"
        Me.rdoAscending.UseVisualStyleBackColor = True
        '
        'rdoNone
        '
        Me.rdoNone.AutoSize = True
        Me.rdoNone.Location = New System.Drawing.Point(10, 21)
        Me.rdoNone.Name = "rdoNone"
        Me.rdoNone.Size = New System.Drawing.Size(51, 17)
        Me.rdoNone.TabIndex = 1
        Me.rdoNone.TabStop = True
        Me.rdoNone.Text = "None"
        Me.rdoNone.UseVisualStyleBackColor = True
        '
        'ucrPnlSort
        '
        Me.ucrPnlSort.Location = New System.Drawing.Point(3, 16)
        Me.ucrPnlSort.Name = "ucrPnlSort"
        Me.ucrPnlSort.Size = New System.Drawing.Size(114, 69)
        Me.ucrPnlSort.TabIndex = 0
        '
        'cmdOptions
        '
        Me.cmdOptions.Location = New System.Drawing.Point(280, 216)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(69, 23)
        Me.cmdOptions.TabIndex = 15
        Me.cmdOptions.Text = " Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'lblSelectedVariable
        '
        Me.lblSelectedVariable.AutoSize = True
        Me.lblSelectedVariable.Location = New System.Drawing.Point(267, 61)
        Me.lblSelectedVariable.Name = "lblSelectedVariable"
        Me.lblSelectedVariable.Size = New System.Drawing.Size(93, 13)
        Me.lblSelectedVariable.TabIndex = 16
        Me.lblSelectedVariable.Text = "Selected Variable:"
        '
        'ucrChkFlip
        '
        Me.ucrChkFlip.Checked = False
        Me.ucrChkFlip.Location = New System.Drawing.Point(10, 202)
        Me.ucrChkFlip.Name = "ucrChkFlip"
        Me.ucrChkFlip.Size = New System.Drawing.Size(145, 20)
        Me.ucrChkFlip.TabIndex = 17
        '
        'ucrChkGraph
        '
        Me.ucrChkGraph.Checked = False
        Me.ucrChkGraph.Location = New System.Drawing.Point(9, 252)
        Me.ucrChkGraph.Name = "ucrChkGraph"
        Me.ucrChkGraph.Size = New System.Drawing.Size(145, 20)
        Me.ucrChkGraph.TabIndex = 12
        '
        'ucrChkTable
        '
        Me.ucrChkTable.Checked = False
        Me.ucrChkTable.Location = New System.Drawing.Point(10, 227)
        Me.ucrChkTable.Name = "ucrChkTable"
        Me.ucrChkTable.Size = New System.Drawing.Size(145, 20)
        Me.ucrChkTable.TabIndex = 10
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 302)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 6
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.Location = New System.Drawing.Point(9, 277)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(294, 24)
        Me.ucrSaveGraph.TabIndex = 5
        '
        'ucrReceiverOneWayFreq
        '
        Me.ucrReceiverOneWayFreq.frmParent = Me
        Me.ucrReceiverOneWayFreq.Location = New System.Drawing.Point(270, 77)
        Me.ucrReceiverOneWayFreq.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverOneWayFreq.Name = "ucrReceiverOneWayFreq"
        Me.ucrReceiverOneWayFreq.Selector = Nothing
        Me.ucrReceiverOneWayFreq.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverOneWayFreq.TabIndex = 1
        '
        'ucrSelectorOneWayFreq
        '
        Me.ucrSelectorOneWayFreq.bShowHiddenColumns = False
        Me.ucrSelectorOneWayFreq.bUseCurrentFilter = True
        Me.ucrSelectorOneWayFreq.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorOneWayFreq.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorOneWayFreq.Name = "ucrSelectorOneWayFreq"
        Me.ucrSelectorOneWayFreq.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorOneWayFreq.TabIndex = 0
        '
        'ucrChkweights
        '
        Me.ucrChkweights.Checked = False
        Me.ucrChkweights.Location = New System.Drawing.Point(270, 27)
        Me.ucrChkweights.Name = "ucrChkweights"
        Me.ucrChkweights.Size = New System.Drawing.Size(145, 20)
        Me.ucrChkweights.TabIndex = 18
        '
        'dlgOneWayFrequencies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 361)
        Me.Controls.Add(Me.ucrChkweights)
        Me.Controls.Add(Me.ucrChkFlip)
        Me.Controls.Add(Me.lblSelectedVariable)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.grpSort)
        Me.Controls.Add(Me.ucrChkGraph)
        Me.Controls.Add(Me.ucrChkTable)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.ucrReceiverOneWayFreq)
        Me.Controls.Add(Me.ucrSelectorOneWayFreq)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgOneWayFrequencies"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "One Way Frequencies"
        Me.grpSort.ResumeLayout(False)
        Me.grpSort.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorOneWayFreq As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverOneWayFreq As ucrReceiverSingle
    Friend WithEvents ucrSaveGraph As ucrSave
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrChkGraph As ucrCheck
    Friend WithEvents ucrChkTable As ucrCheck
    Friend WithEvents grpSort As GroupBox
    Friend WithEvents rdoDescending As RadioButton
    Friend WithEvents rdoAscending As RadioButton
    Friend WithEvents rdoNone As RadioButton
    Friend WithEvents ucrPnlSort As UcrPanel
    Friend WithEvents cmdOptions As Button
    Friend WithEvents lblSelectedVariable As Label
    Friend WithEvents ucrChkFlip As ucrCheck
    Friend WithEvents ucrChkweights As ucrCheck
End Class
