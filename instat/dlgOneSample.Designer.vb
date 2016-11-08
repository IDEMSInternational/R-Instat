<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgOneSample
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
        Me.grpAnalysis = New System.Windows.Forms.GroupBox()
        Me.lblValue = New System.Windows.Forms.Label()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.chkSignificanceTest = New System.Windows.Forms.CheckBox()
        Me.lblParameters = New System.Windows.Forms.Label()
        Me.cboParameters = New System.Windows.Forms.ComboBox()
        Me.lblModels = New System.Windows.Forms.Label()
        Me.cboModels = New System.Windows.Forms.ComboBox()
        Me.lblDataColumn = New System.Windows.Forms.Label()
        Me.grpGraphs = New System.Windows.Forms.GroupBox()
        Me.lblGraphs = New System.Windows.Forms.Label()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.ucrReceiverDataColumn = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrAddRemove = New instat.ucrSelectorByDataFrameAddRemove()
        Me.grpAnalysis.SuspendLayout()
        Me.grpGraphs.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpAnalysis
        '
        Me.grpAnalysis.Controls.Add(Me.lblValue)
        Me.grpAnalysis.Controls.Add(Me.txtValue)
        Me.grpAnalysis.Controls.Add(Me.chkSignificanceTest)
        Me.grpAnalysis.Controls.Add(Me.lblParameters)
        Me.grpAnalysis.Controls.Add(Me.cboParameters)
        Me.grpAnalysis.Controls.Add(Me.lblModels)
        Me.grpAnalysis.Controls.Add(Me.cboModels)
        Me.grpAnalysis.Location = New System.Drawing.Point(238, 83)
        Me.grpAnalysis.Name = "grpAnalysis"
        Me.grpAnalysis.Size = New System.Drawing.Size(220, 153)
        Me.grpAnalysis.TabIndex = 3
        Me.grpAnalysis.TabStop = False
        Me.grpAnalysis.Tag = "Analysis"
        Me.grpAnalysis.Text = "Analysis"
        '
        'lblValue
        '
        Me.lblValue.AutoSize = True
        Me.lblValue.Location = New System.Drawing.Point(130, 120)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(34, 13)
        Me.lblValue.TabIndex = 5
        Me.lblValue.Tag = "Value"
        Me.lblValue.Text = "Value"
        Me.lblValue.Visible = False
        '
        'txtValue
        '
        Me.txtValue.Location = New System.Drawing.Point(173, 117)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(41, 20)
        Me.txtValue.TabIndex = 6
        Me.txtValue.Visible = False
        '
        'chkSignificanceTest
        '
        Me.chkSignificanceTest.AutoSize = True
        Me.chkSignificanceTest.Location = New System.Drawing.Point(16, 120)
        Me.chkSignificanceTest.Name = "chkSignificanceTest"
        Me.chkSignificanceTest.Size = New System.Drawing.Size(108, 17)
        Me.chkSignificanceTest.TabIndex = 4
        Me.chkSignificanceTest.Tag = "Significance_test"
        Me.chkSignificanceTest.Text = "Significance Test"
        Me.chkSignificanceTest.UseVisualStyleBackColor = True
        '
        'lblParameters
        '
        Me.lblParameters.AutoSize = True
        Me.lblParameters.Location = New System.Drawing.Point(14, 69)
        Me.lblParameters.Name = "lblParameters"
        Me.lblParameters.Size = New System.Drawing.Size(55, 13)
        Me.lblParameters.TabIndex = 2
        Me.lblParameters.Tag = "Parameter"
        Me.lblParameters.Text = "Parameter"
        '
        'cboParameters
        '
        Me.cboParameters.FormattingEnabled = True
        Me.cboParameters.Items.AddRange(New Object() {"Mean            " & Global.Microsoft.VisualBasic.ChrW(9) & "   (t-interval)", "Mean, known variance (z-interval)", "Variance        " & Global.Microsoft.VisualBasic.ChrW(9) & "    (F-interval)"})
        Me.cboParameters.Location = New System.Drawing.Point(13, 88)
        Me.cboParameters.Name = "cboParameters"
        Me.cboParameters.Size = New System.Drawing.Size(201, 21)
        Me.cboParameters.TabIndex = 3
        '
        'lblModels
        '
        Me.lblModels.AutoSize = True
        Me.lblModels.Location = New System.Drawing.Point(10, 21)
        Me.lblModels.Name = "lblModels"
        Me.lblModels.Size = New System.Drawing.Size(41, 13)
        Me.lblModels.TabIndex = 0
        Me.lblModels.Tag = "Models"
        Me.lblModels.Text = "Models"
        '
        'cboModels
        '
        Me.cboModels.FormattingEnabled = True
        Me.cboModels.Items.AddRange(New Object() {"Normal", "Proportional", "Poisson"})
        Me.cboModels.Location = New System.Drawing.Point(13, 39)
        Me.cboModels.Name = "cboModels"
        Me.cboModels.Size = New System.Drawing.Size(201, 21)
        Me.cboModels.TabIndex = 1
        Me.cboModels.Tag = ""
        '
        'lblDataColumn
        '
        Me.lblDataColumn.AutoSize = True
        Me.lblDataColumn.Location = New System.Drawing.Point(314, 26)
        Me.lblDataColumn.Name = "lblDataColumn"
        Me.lblDataColumn.Size = New System.Drawing.Size(68, 13)
        Me.lblDataColumn.TabIndex = 1
        Me.lblDataColumn.Tag = "Data_Column"
        Me.lblDataColumn.Text = "Data Column"
        '
        'grpGraphs
        '
        Me.grpGraphs.Controls.Add(Me.lblGraphs)
        Me.grpGraphs.Location = New System.Drawing.Point(9, 201)
        Me.grpGraphs.Name = "grpGraphs"
        Me.grpGraphs.Size = New System.Drawing.Size(173, 66)
        Me.grpGraphs.TabIndex = 4
        Me.grpGraphs.TabStop = False
        Me.grpGraphs.Tag = "Graphs"
        Me.grpGraphs.Text = "Graphs"
        '
        'lblGraphs
        '
        Me.lblGraphs.AutoSize = True
        Me.lblGraphs.Location = New System.Drawing.Point(6, 35)
        Me.lblGraphs.Name = "lblGraphs"
        Me.lblGraphs.Size = New System.Drawing.Size(97, 13)
        Me.lblGraphs.TabIndex = 0
        Me.lblGraphs.Text = "To be implemented"
        '
        'cmdOptions
        '
        Me.cmdOptions.Location = New System.Drawing.Point(311, 249)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(75, 23)
        Me.cmdOptions.TabIndex = 5
        Me.cmdOptions.Tag = "Options..."
        Me.cmdOptions.Text = "Options..."
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'ucrReceiverDataColumn
        '
        Me.ucrReceiverDataColumn.Location = New System.Drawing.Point(293, 48)
        Me.ucrReceiverDataColumn.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDataColumn.Name = "ucrReceiverDataColumn"
        Me.ucrReceiverDataColumn.Selector = Nothing
        Me.ucrReceiverDataColumn.Size = New System.Drawing.Size(110, 26)
        Me.ucrReceiverDataColumn.TabIndex = 2
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 279)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 53)
        Me.ucrBase.TabIndex = 6
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.bShowHiddenColumns = False
        Me.ucrAddRemove.bUseCurrentFilter = True
        Me.ucrAddRemove.Location = New System.Drawing.Point(9, 14)
        Me.ucrAddRemove.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(210, 180)
        Me.ucrAddRemove.TabIndex = 0
        '
        'dlgOneSample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 339)
        Me.Controls.Add(Me.ucrAddRemove)
        Me.Controls.Add(Me.ucrReceiverDataColumn)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.grpGraphs)
        Me.Controls.Add(Me.lblDataColumn)
        Me.Controls.Add(Me.grpAnalysis)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgOneSample"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "One_Sample"
        Me.Text = "One Sample"
        Me.grpAnalysis.ResumeLayout(False)
        Me.grpAnalysis.PerformLayout()
        Me.grpGraphs.ResumeLayout(False)
        Me.grpGraphs.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpAnalysis As GroupBox
    Friend WithEvents lblParameters As Label
    Friend WithEvents cboParameters As ComboBox
    Friend WithEvents lblModels As Label
    Friend WithEvents cboModels As ComboBox
    Friend WithEvents lblDataColumn As Label
    Friend WithEvents lblValue As Label
    Friend WithEvents txtValue As TextBox
    Friend WithEvents chkSignificanceTest As CheckBox
    Friend WithEvents grpGraphs As GroupBox
    Friend WithEvents lblGraphs As Label
    Friend WithEvents cmdOptions As Button
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverDataColumn As ucrReceiverSingle
    Friend WithEvents ucrAddRemove As ucrSelectorByDataFrameAddRemove
End Class
