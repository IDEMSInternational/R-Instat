<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgStringDistance
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
        Me.UcrBaseStringDistance = New instat.ucrButtons()
        Me.UcrSelectorStringDistance = New instat.ucrSelectorByDataFrame()
        Me.UcrReceiverStringDistance = New instat.ucrReceiverSingle()
        Me.UcrInputPattern = New instat.ucrInputTextBox()
        Me.UcrSaveStringDistance = New instat.ucrSave()
        Me.lblColumn = New System.Windows.Forms.Label()
        Me.lblPattern = New System.Windows.Forms.Label()
        Me.UcrInputComboBox1 = New instat.ucrInputComboBox()
        Me.lblMethod = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'UcrBaseStringDistance
        '
        Me.UcrBaseStringDistance.Location = New System.Drawing.Point(10, 264)
        Me.UcrBaseStringDistance.Name = "UcrBaseStringDistance"
        Me.UcrBaseStringDistance.Size = New System.Drawing.Size(410, 52)
        Me.UcrBaseStringDistance.TabIndex = 0
        '
        'UcrSelectorStringDistance
        '
        Me.UcrSelectorStringDistance.bShowHiddenColumns = False
        Me.UcrSelectorStringDistance.bUseCurrentFilter = True
        Me.UcrSelectorStringDistance.Location = New System.Drawing.Point(10, 23)
        Me.UcrSelectorStringDistance.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrSelectorStringDistance.Name = "UcrSelectorStringDistance"
        Me.UcrSelectorStringDistance.Size = New System.Drawing.Size(120, 180)
        Me.UcrSelectorStringDistance.TabIndex = 1
        '
        'UcrReceiverStringDistance
        '
        Me.UcrReceiverStringDistance.frmParent = Me
        Me.UcrReceiverStringDistance.Location = New System.Drawing.Point(202, 48)
        Me.UcrReceiverStringDistance.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrReceiverStringDistance.Name = "UcrReceiverStringDistance"
        Me.UcrReceiverStringDistance.Selector = Nothing
        Me.UcrReceiverStringDistance.Size = New System.Drawing.Size(137, 20)
        Me.UcrReceiverStringDistance.TabIndex = 2
        Me.UcrReceiverStringDistance.ucrSelector = Nothing
        '
        'UcrInputPattern
        '
        Me.UcrInputPattern.AddQuotesIfUnrecognised = True
        Me.UcrInputPattern.IsMultiline = False
        Me.UcrInputPattern.IsReadOnly = False
        Me.UcrInputPattern.Location = New System.Drawing.Point(202, 109)
        Me.UcrInputPattern.Name = "UcrInputPattern"
        Me.UcrInputPattern.Size = New System.Drawing.Size(137, 21)
        Me.UcrInputPattern.TabIndex = 3
        '
        'UcrSaveStringDistance
        '
        Me.UcrSaveStringDistance.Location = New System.Drawing.Point(10, 218)
        Me.UcrSaveStringDistance.Name = "UcrSaveStringDistance"
        Me.UcrSaveStringDistance.Size = New System.Drawing.Size(398, 24)
        Me.UcrSaveStringDistance.TabIndex = 4
        '
        'lblColumn
        '
        Me.lblColumn.AutoSize = True
        Me.lblColumn.Location = New System.Drawing.Point(199, 35)
        Me.lblColumn.Name = "lblColumn"
        Me.lblColumn.Size = New System.Drawing.Size(45, 13)
        Me.lblColumn.TabIndex = 5
        Me.lblColumn.Text = "Column:"
        '
        'lblPattern
        '
        Me.lblPattern.AutoSize = True
        Me.lblPattern.Location = New System.Drawing.Point(199, 93)
        Me.lblPattern.Name = "lblPattern"
        Me.lblPattern.Size = New System.Drawing.Size(44, 13)
        Me.lblPattern.TabIndex = 6
        Me.lblPattern.Text = "Pattern:"
        '
        'UcrInputComboBox1
        '
        Me.UcrInputComboBox1.AddQuotesIfUnrecognised = True
        Me.UcrInputComboBox1.IsReadOnly = False
        Me.UcrInputComboBox1.Location = New System.Drawing.Point(202, 172)
        Me.UcrInputComboBox1.Name = "UcrInputComboBox1"
        Me.UcrInputComboBox1.Size = New System.Drawing.Size(137, 21)
        Me.UcrInputComboBox1.TabIndex = 7
        '
        'lblMethod
        '
        Me.lblMethod.AutoSize = True
        Me.lblMethod.Location = New System.Drawing.Point(199, 156)
        Me.lblMethod.Name = "lblMethod"
        Me.lblMethod.Size = New System.Drawing.Size(46, 13)
        Me.lblMethod.TabIndex = 8
        Me.lblMethod.Text = "Method:"
        '
        'dlgStringDistance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 328)
        Me.Controls.Add(Me.lblMethod)
        Me.Controls.Add(Me.UcrInputComboBox1)
        Me.Controls.Add(Me.lblPattern)
        Me.Controls.Add(Me.lblColumn)
        Me.Controls.Add(Me.UcrSaveStringDistance)
        Me.Controls.Add(Me.UcrInputPattern)
        Me.Controls.Add(Me.UcrReceiverStringDistance)
        Me.Controls.Add(Me.UcrSelectorStringDistance)
        Me.Controls.Add(Me.UcrBaseStringDistance)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgStringDistance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "String Distance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UcrBaseStringDistance As ucrButtons
    Friend WithEvents UcrSelectorStringDistance As ucrSelectorByDataFrame
    Friend WithEvents UcrReceiverStringDistance As ucrReceiverSingle
    Friend WithEvents lblMethod As Label
    Friend WithEvents UcrInputComboBox1 As ucrInputComboBox
    Friend WithEvents lblPattern As Label
    Friend WithEvents lblColumn As Label
    Friend WithEvents UcrSaveStringDistance As ucrSave
    Friend WithEvents UcrInputPattern As ucrInputTextBox
End Class
