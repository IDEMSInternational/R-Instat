<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgVisualizeData
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
        Me.ucrSelectorVisualizeData = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrPnlVisualizeData = New instat.UcrPanel()
        Me.rdoVisDat = New System.Windows.Forms.RadioButton()
        Me.rdoVisMiss = New System.Windows.Forms.RadioButton()
        Me.rdoVisGuess = New System.Windows.Forms.RadioButton()
        Me.ucrPnlSelectData = New instat.UcrPanel()
        Me.rdoWholeDataFrame = New System.Windows.Forms.RadioButton()
        Me.rdoSelectedColumn = New System.Windows.Forms.RadioButton()
        Me.ucrReceiverVisualizeData = New instat.ucrReceiverMultiple()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 288)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSelectorVisualizeData
        '
        Me.ucrSelectorVisualizeData.bDropUnusedFilterLevels = False
        Me.ucrSelectorVisualizeData.bShowHiddenColumns = False
        Me.ucrSelectorVisualizeData.bUseCurrentFilter = True
        Me.ucrSelectorVisualizeData.Location = New System.Drawing.Point(10, 61)
        Me.ucrSelectorVisualizeData.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorVisualizeData.Name = "ucrSelectorVisualizeData"
        Me.ucrSelectorVisualizeData.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorVisualizeData.TabIndex = 1
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.Location = New System.Drawing.Point(10, 258)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(264, 24)
        Me.ucrSaveGraph.TabIndex = 2
        '
        'ucrPnlVisualizeData
        '
        Me.ucrPnlVisualizeData.Location = New System.Drawing.Point(44, 12)
        Me.ucrPnlVisualizeData.Name = "ucrPnlVisualizeData"
        Me.ucrPnlVisualizeData.Size = New System.Drawing.Size(324, 46)
        Me.ucrPnlVisualizeData.TabIndex = 3
        '
        'rdoVisDat
        '
        Me.rdoVisDat.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoVisDat.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoVisDat.FlatAppearance.BorderSize = 2
        Me.rdoVisDat.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoVisDat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoVisDat.Location = New System.Drawing.Point(60, 22)
        Me.rdoVisDat.Name = "rdoVisDat"
        Me.rdoVisDat.Size = New System.Drawing.Size(100, 28)
        Me.rdoVisDat.TabIndex = 4
        Me.rdoVisDat.TabStop = True
        Me.rdoVisDat.Text = "Data"
        Me.rdoVisDat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoVisDat.UseVisualStyleBackColor = True
        '
        'rdoVisMiss
        '
        Me.rdoVisMiss.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoVisMiss.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoVisMiss.FlatAppearance.BorderSize = 2
        Me.rdoVisMiss.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoVisMiss.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoVisMiss.Location = New System.Drawing.Point(156, 22)
        Me.rdoVisMiss.Name = "rdoVisMiss"
        Me.rdoVisMiss.Size = New System.Drawing.Size(100, 28)
        Me.rdoVisMiss.TabIndex = 5
        Me.rdoVisMiss.TabStop = True
        Me.rdoVisMiss.Text = "Missing"
        Me.rdoVisMiss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoVisMiss.UseVisualStyleBackColor = True
        '
        'rdoVisGuess
        '
        Me.rdoVisGuess.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoVisGuess.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoVisGuess.FlatAppearance.BorderSize = 2
        Me.rdoVisGuess.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoVisGuess.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoVisGuess.Location = New System.Drawing.Point(252, 22)
        Me.rdoVisGuess.Name = "rdoVisGuess"
        Me.rdoVisGuess.Size = New System.Drawing.Size(100, 28)
        Me.rdoVisGuess.TabIndex = 6
        Me.rdoVisGuess.TabStop = True
        Me.rdoVisGuess.Text = "Guess"
        Me.rdoVisGuess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoVisGuess.UseVisualStyleBackColor = True
        '
        'ucrPnlSelectData
        '
        Me.ucrPnlSelectData.Location = New System.Drawing.Point(235, 80)
        Me.ucrPnlSelectData.Name = "ucrPnlSelectData"
        Me.ucrPnlSelectData.Size = New System.Drawing.Size(133, 40)
        Me.ucrPnlSelectData.TabIndex = 7
        '
        'rdoWholeDataFrame
        '
        Me.rdoWholeDataFrame.AutoSize = True
        Me.rdoWholeDataFrame.Location = New System.Drawing.Point(243, 80)
        Me.rdoWholeDataFrame.Name = "rdoWholeDataFrame"
        Me.rdoWholeDataFrame.Size = New System.Drawing.Size(108, 17)
        Me.rdoWholeDataFrame.TabIndex = 8
        Me.rdoWholeDataFrame.TabStop = True
        Me.rdoWholeDataFrame.Text = "Whole Dataframe"
        Me.rdoWholeDataFrame.UseVisualStyleBackColor = True
        '
        'rdoSelectedColumn
        '
        Me.rdoSelectedColumn.AutoSize = True
        Me.rdoSelectedColumn.Location = New System.Drawing.Point(243, 103)
        Me.rdoSelectedColumn.Name = "rdoSelectedColumn"
        Me.rdoSelectedColumn.Size = New System.Drawing.Size(105, 17)
        Me.rdoSelectedColumn.TabIndex = 9
        Me.rdoSelectedColumn.TabStop = True
        Me.rdoSelectedColumn.Text = "Selected Column"
        Me.rdoSelectedColumn.UseVisualStyleBackColor = True
        '
        'ucrReceiverVisualizeData
        '
        Me.ucrReceiverVisualizeData.frmParent = Me
        Me.ucrReceiverVisualizeData.Location = New System.Drawing.Point(248, 141)
        Me.ucrReceiverVisualizeData.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverVisualizeData.Name = "ucrReceiverVisualizeData"
        Me.ucrReceiverVisualizeData.Selector = Nothing
        Me.ucrReceiverVisualizeData.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverVisualizeData.strNcFilePath = ""
        Me.ucrReceiverVisualizeData.TabIndex = 10
        Me.ucrReceiverVisualizeData.ucrSelector = Nothing
        '
        'dlgVisualizeData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 342)
        Me.Controls.Add(Me.ucrReceiverVisualizeData)
        Me.Controls.Add(Me.rdoSelectedColumn)
        Me.Controls.Add(Me.rdoWholeDataFrame)
        Me.Controls.Add(Me.ucrPnlSelectData)
        Me.Controls.Add(Me.rdoVisGuess)
        Me.Controls.Add(Me.rdoVisMiss)
        Me.Controls.Add(Me.rdoVisDat)
        Me.Controls.Add(Me.ucrPnlVisualizeData)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.ucrSelectorVisualizeData)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgVisualizeData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visualize Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorVisualizeData As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSaveGraph As ucrSave
    Friend WithEvents ucrPnlVisualizeData As UcrPanel
    Friend WithEvents rdoVisDat As RadioButton
    Friend WithEvents rdoVisMiss As RadioButton
    Friend WithEvents rdoVisGuess As RadioButton
    Friend WithEvents ucrPnlSelectData As UcrPanel
    Friend WithEvents rdoWholeDataFrame As RadioButton
    Friend WithEvents rdoSelectedColumn As RadioButton
    Friend WithEvents ucrReceiverVisualizeData As ucrReceiverMultiple
End Class
