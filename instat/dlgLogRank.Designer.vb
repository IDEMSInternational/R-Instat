<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgLogRank
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
        Me.grpDataColumns = New System.Windows.Forms.GroupBox()
        Me.lbl2ndGroup = New System.Windows.Forms.Label()
        Me.lbl1st_Group = New System.Windows.Forms.Label()
        Me.grpCensoringColumns = New System.Windows.Forms.GroupBox()
        Me.lbl2ndGroup2 = New System.Windows.Forms.Label()
        Me.lbl1stGroup2 = New System.Windows.Forms.Label()
        Me.grpSurvivorFunction = New System.Windows.Forms.GroupBox()
        Me.rdoLoglogplot = New System.Windows.Forms.RadioButton()
        Me.rdoKaplanMeierPlot = New System.Windows.Forms.RadioButton()
        Me.chkRemovecolumns = New System.Windows.Forms.CheckBox()
        Me.grpDisplayOptions = New System.Windows.Forms.GroupBox()
        Me.chkRelativeRiskofEvent = New System.Windows.Forms.CheckBox()
        Me.chkDetailsofCalculations = New System.Windows.Forms.CheckBox()
        Me.chkWilcoxonTest = New System.Windows.Forms.CheckBox()
        Me.chkCensoringColumns = New System.Windows.Forms.CheckBox()
        Me.chkExploratoryPlot = New System.Windows.Forms.CheckBox()
        Me.chkDisplayOptions = New System.Windows.Forms.CheckBox()
        Me.UcrSelectorAddRemove1 = New instat.ucrSelectorAddRemove()
        Me.UcrReceiverSingle4 = New instat.ucrReceiverSingle()
        Me.UcrReceiverSingle3 = New instat.ucrReceiverSingle()
        Me.UcrReceiverSingle2 = New instat.ucrReceiverSingle()
        Me.UcrReceiverSingle1 = New instat.ucrReceiverSingle()
        Me.UcrButtons1 = New instat.ucrButtons()
        Me.grpDataColumns.SuspendLayout()
        Me.grpCensoringColumns.SuspendLayout()
        Me.grpSurvivorFunction.SuspendLayout()
        Me.grpDisplayOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpDataColumns
        '
        Me.grpDataColumns.Controls.Add(Me.lbl2ndGroup)
        Me.grpDataColumns.Controls.Add(Me.lbl1st_Group)
        Me.grpDataColumns.Controls.Add(Me.UcrReceiverSingle2)
        Me.grpDataColumns.Controls.Add(Me.UcrReceiverSingle1)
        Me.grpDataColumns.Location = New System.Drawing.Point(221, 3)
        Me.grpDataColumns.Name = "grpDataColumns"
        Me.grpDataColumns.Size = New System.Drawing.Size(172, 86)
        Me.grpDataColumns.TabIndex = 1
        Me.grpDataColumns.TabStop = False
        Me.grpDataColumns.Tag = "Data_Columns"
        Me.grpDataColumns.Text = "Data Columns"
        '
        'lbl2ndGroup
        '
        Me.lbl2ndGroup.AutoSize = True
        Me.lbl2ndGroup.Location = New System.Drawing.Point(6, 52)
        Me.lbl2ndGroup.Name = "lbl2ndGroup"
        Me.lbl2ndGroup.Size = New System.Drawing.Size(57, 13)
        Me.lbl2ndGroup.TabIndex = 3
        Me.lbl2ndGroup.Tag = "2nd_Group"
        Me.lbl2ndGroup.Text = "2nd Group"
        '
        'lbl1st_Group
        '
        Me.lbl1st_Group.AutoSize = True
        Me.lbl1st_Group.Location = New System.Drawing.Point(10, 20)
        Me.lbl1st_Group.Name = "lbl1st_Group"
        Me.lbl1st_Group.Size = New System.Drawing.Size(53, 13)
        Me.lbl1st_Group.TabIndex = 2
        Me.lbl1st_Group.Tag = "1st_Group"
        Me.lbl1st_Group.Text = "1st Group"
        '
        'grpCensoringColumns
        '
        Me.grpCensoringColumns.Controls.Add(Me.lbl2ndGroup2)
        Me.grpCensoringColumns.Controls.Add(Me.UcrReceiverSingle4)
        Me.grpCensoringColumns.Controls.Add(Me.lbl1stGroup2)
        Me.grpCensoringColumns.Controls.Add(Me.UcrReceiverSingle3)
        Me.grpCensoringColumns.Location = New System.Drawing.Point(221, 90)
        Me.grpCensoringColumns.Name = "grpCensoringColumns"
        Me.grpCensoringColumns.Size = New System.Drawing.Size(172, 72)
        Me.grpCensoringColumns.TabIndex = 2
        Me.grpCensoringColumns.TabStop = False
        '
        'lbl2ndGroup2
        '
        Me.lbl2ndGroup2.AutoSize = True
        Me.lbl2ndGroup2.Location = New System.Drawing.Point(6, 41)
        Me.lbl2ndGroup2.Name = "lbl2ndGroup2"
        Me.lbl2ndGroup2.Size = New System.Drawing.Size(57, 13)
        Me.lbl2ndGroup2.TabIndex = 5
        Me.lbl2ndGroup2.Tag = "2nd_Group"
        Me.lbl2ndGroup2.Text = "2nd Group"
        '
        'lbl1stGroup2
        '
        Me.lbl1stGroup2.AutoSize = True
        Me.lbl1stGroup2.Location = New System.Drawing.Point(10, 9)
        Me.lbl1stGroup2.Name = "lbl1stGroup2"
        Me.lbl1stGroup2.Size = New System.Drawing.Size(53, 13)
        Me.lbl1stGroup2.TabIndex = 4
        Me.lbl1stGroup2.Tag = "1st_Group"
        Me.lbl1stGroup2.Text = "1st Group"
        '
        'grpSurvivorFunction
        '
        Me.grpSurvivorFunction.Controls.Add(Me.rdoLoglogplot)
        Me.grpSurvivorFunction.Controls.Add(Me.rdoKaplanMeierPlot)
        Me.grpSurvivorFunction.Controls.Add(Me.chkRemovecolumns)
        Me.grpSurvivorFunction.Location = New System.Drawing.Point(12, 191)
        Me.grpSurvivorFunction.Name = "grpSurvivorFunction"
        Me.grpSurvivorFunction.Size = New System.Drawing.Size(179, 78)
        Me.grpSurvivorFunction.TabIndex = 2
        Me.grpSurvivorFunction.TabStop = False
        Me.grpSurvivorFunction.Tag = "Survivor_Function"
        Me.grpSurvivorFunction.Text = "Survivor Function"
        '
        'rdoLoglogplot
        '
        Me.rdoLoglogplot.AutoSize = True
        Me.rdoLoglogplot.Location = New System.Drawing.Point(6, 39)
        Me.rdoLoglogplot.Name = "rdoLoglogplot"
        Me.rdoLoglogplot.Size = New System.Drawing.Size(80, 17)
        Me.rdoLoglogplot.TabIndex = 2
        Me.rdoLoglogplot.TabStop = True
        Me.rdoLoglogplot.Tag = "Log_log_plot"
        Me.rdoLoglogplot.Text = "Log-log plot"
        Me.rdoLoglogplot.UseVisualStyleBackColor = True
        '
        'rdoKaplanMeierPlot
        '
        Me.rdoKaplanMeierPlot.AutoSize = True
        Me.rdoKaplanMeierPlot.Location = New System.Drawing.Point(6, 19)
        Me.rdoKaplanMeierPlot.Name = "rdoKaplanMeierPlot"
        Me.rdoKaplanMeierPlot.Size = New System.Drawing.Size(108, 17)
        Me.rdoKaplanMeierPlot.TabIndex = 1
        Me.rdoKaplanMeierPlot.TabStop = True
        Me.rdoKaplanMeierPlot.Tag = "Kaplan_Meier_Plot"
        Me.rdoKaplanMeierPlot.Text = "Kaplan Meier Plot"
        Me.rdoKaplanMeierPlot.UseVisualStyleBackColor = True
        '
        'chkRemovecolumns
        '
        Me.chkRemovecolumns.AutoSize = True
        Me.chkRemovecolumns.Location = New System.Drawing.Point(6, 59)
        Me.chkRemovecolumns.Name = "chkRemovecolumns"
        Me.chkRemovecolumns.Size = New System.Drawing.Size(155, 17)
        Me.chkRemovecolumns.TabIndex = 0
        Me.chkRemovecolumns.Tag = "Remove _columns_after_plot"
        Me.chkRemovecolumns.Text = "Remove  columns after plot"
        Me.chkRemovecolumns.UseVisualStyleBackColor = True
        '
        'grpDisplayOptions
        '
        Me.grpDisplayOptions.Controls.Add(Me.chkRelativeRiskofEvent)
        Me.grpDisplayOptions.Controls.Add(Me.chkDetailsofCalculations)
        Me.grpDisplayOptions.Controls.Add(Me.chkWilcoxonTest)
        Me.grpDisplayOptions.Location = New System.Drawing.Point(213, 191)
        Me.grpDisplayOptions.Name = "grpDisplayOptions"
        Me.grpDisplayOptions.Size = New System.Drawing.Size(174, 78)
        Me.grpDisplayOptions.TabIndex = 2
        Me.grpDisplayOptions.TabStop = False
        '
        'chkRelativeRiskofEvent
        '
        Me.chkRelativeRiskofEvent.AutoSize = True
        Me.chkRelativeRiskofEvent.Location = New System.Drawing.Point(6, 58)
        Me.chkRelativeRiskofEvent.Name = "chkRelativeRiskofEvent"
        Me.chkRelativeRiskofEvent.Size = New System.Drawing.Size(132, 17)
        Me.chkRelativeRiskofEvent.TabIndex = 2
        Me.chkRelativeRiskofEvent.Tag = "Relative_Risk_of_Event"
        Me.chkRelativeRiskofEvent.Text = "Relative Risk of Event"
        Me.chkRelativeRiskofEvent.UseVisualStyleBackColor = True
        '
        'chkDetailsofCalculations
        '
        Me.chkDetailsofCalculations.AutoSize = True
        Me.chkDetailsofCalculations.Location = New System.Drawing.Point(6, 35)
        Me.chkDetailsofCalculations.Name = "chkDetailsofCalculations"
        Me.chkDetailsofCalculations.Size = New System.Drawing.Size(130, 17)
        Me.chkDetailsofCalculations.TabIndex = 1
        Me.chkDetailsofCalculations.Tag = "Details_of_Calculations"
        Me.chkDetailsofCalculations.Text = "Details of Calculations"
        Me.chkDetailsofCalculations.UseVisualStyleBackColor = True
        '
        'chkWilcoxonTest
        '
        Me.chkWilcoxonTest.AutoSize = True
        Me.chkWilcoxonTest.Location = New System.Drawing.Point(6, 12)
        Me.chkWilcoxonTest.Name = "chkWilcoxonTest"
        Me.chkWilcoxonTest.Size = New System.Drawing.Size(94, 17)
        Me.chkWilcoxonTest.TabIndex = 0
        Me.chkWilcoxonTest.Tag = "Wilcoxon_Test"
        Me.chkWilcoxonTest.Text = "Wilcoxon Test"
        Me.chkWilcoxonTest.UseVisualStyleBackColor = True
        '
        'chkCensoringColumns
        '
        Me.chkCensoringColumns.AutoSize = True
        Me.chkCensoringColumns.Location = New System.Drawing.Point(139, 114)
        Me.chkCensoringColumns.Name = "chkCensoringColumns"
        Me.chkCensoringColumns.Size = New System.Drawing.Size(76, 30)
        Me.chkCensoringColumns.TabIndex = 4
        Me.chkCensoringColumns.Tag = "Censoring_Columns"
        Me.chkCensoringColumns.Text = "Censoring " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Columns"
        Me.chkCensoringColumns.UseVisualStyleBackColor = True
        '
        'chkExploratoryPlot
        '
        Me.chkExploratoryPlot.AutoSize = True
        Me.chkExploratoryPlot.Location = New System.Drawing.Point(18, 168)
        Me.chkExploratoryPlot.Name = "chkExploratoryPlot"
        Me.chkExploratoryPlot.Size = New System.Drawing.Size(99, 17)
        Me.chkExploratoryPlot.TabIndex = 5
        Me.chkExploratoryPlot.Tag = "Exploratory_Plot"
        Me.chkExploratoryPlot.Text = "Exploratory Plot"
        Me.chkExploratoryPlot.UseVisualStyleBackColor = True
        '
        'chkDisplayOptions
        '
        Me.chkDisplayOptions.AutoSize = True
        Me.chkDisplayOptions.Location = New System.Drawing.Point(219, 168)
        Me.chkDisplayOptions.Name = "chkDisplayOptions"
        Me.chkDisplayOptions.Size = New System.Drawing.Size(99, 17)
        Me.chkDisplayOptions.TabIndex = 6
        Me.chkDisplayOptions.Tag = "Display_Options"
        Me.chkDisplayOptions.Text = "Display Options"
        Me.chkDisplayOptions.UseVisualStyleBackColor = True
        '
        'UcrSelectorAddRemove1
        '
        Me.UcrSelectorAddRemove1.Location = New System.Drawing.Point(12, 3)
        Me.UcrSelectorAddRemove1.Name = "UcrSelectorAddRemove1"
        Me.UcrSelectorAddRemove1.Size = New System.Drawing.Size(203, 127)
        Me.UcrSelectorAddRemove1.TabIndex = 3
        '
        'UcrReceiverSingle4
        '
        Me.UcrReceiverSingle4.Location = New System.Drawing.Point(60, 41)
        Me.UcrReceiverSingle4.Name = "UcrReceiverSingle4"
        Me.UcrReceiverSingle4.Size = New System.Drawing.Size(106, 26)
        Me.UcrReceiverSingle4.TabIndex = 1
        '
        'UcrReceiverSingle3
        '
        Me.UcrReceiverSingle3.Location = New System.Drawing.Point(60, 9)
        Me.UcrReceiverSingle3.Name = "UcrReceiverSingle3"
        Me.UcrReceiverSingle3.Size = New System.Drawing.Size(106, 26)
        Me.UcrReceiverSingle3.TabIndex = 0
        '
        'UcrReceiverSingle2
        '
        Me.UcrReceiverSingle2.Location = New System.Drawing.Point(60, 52)
        Me.UcrReceiverSingle2.Name = "UcrReceiverSingle2"
        Me.UcrReceiverSingle2.Size = New System.Drawing.Size(106, 26)
        Me.UcrReceiverSingle2.TabIndex = 1
        '
        'UcrReceiverSingle1
        '
        Me.UcrReceiverSingle1.Location = New System.Drawing.Point(60, 20)
        Me.UcrReceiverSingle1.Name = "UcrReceiverSingle1"
        Me.UcrReceiverSingle1.Size = New System.Drawing.Size(106, 26)
        Me.UcrReceiverSingle1.TabIndex = 0
        '
        'UcrButtons1
        '
        Me.UcrButtons1.Location = New System.Drawing.Point(1, 275)
        Me.UcrButtons1.Name = "UcrButtons1"
        Me.UcrButtons1.Size = New System.Drawing.Size(410, 32)
        Me.UcrButtons1.TabIndex = 0
        '
        'dlgLogRank
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 306)
        Me.Controls.Add(Me.chkDisplayOptions)
        Me.Controls.Add(Me.chkExploratoryPlot)
        Me.Controls.Add(Me.chkCensoringColumns)
        Me.Controls.Add(Me.UcrSelectorAddRemove1)
        Me.Controls.Add(Me.grpCensoringColumns)
        Me.Controls.Add(Me.grpSurvivorFunction)
        Me.Controls.Add(Me.grpDisplayOptions)
        Me.Controls.Add(Me.grpDataColumns)
        Me.Controls.Add(Me.UcrButtons1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgLogRank"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Log_Rank"
        Me.Text = "Log Rank"
        Me.grpDataColumns.ResumeLayout(False)
        Me.grpDataColumns.PerformLayout()
        Me.grpCensoringColumns.ResumeLayout(False)
        Me.grpCensoringColumns.PerformLayout()
        Me.grpSurvivorFunction.ResumeLayout(False)
        Me.grpSurvivorFunction.PerformLayout()
        Me.grpDisplayOptions.ResumeLayout(False)
        Me.grpDisplayOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UcrButtons1 As ucrButtons
    Friend WithEvents grpDataColumns As GroupBox
    Friend WithEvents lbl2ndGroup As Label
    Friend WithEvents lbl1st_Group As Label
    Friend WithEvents UcrReceiverSingle2 As ucrReceiverSingle
    Friend WithEvents UcrReceiverSingle1 As ucrReceiverSingle
    Friend WithEvents grpCensoringColumns As GroupBox
    Friend WithEvents lbl2ndGroup2 As Label
    Friend WithEvents UcrReceiverSingle4 As ucrReceiverSingle
    Friend WithEvents lbl1stGroup2 As Label
    Friend WithEvents UcrReceiverSingle3 As ucrReceiverSingle
    Friend WithEvents grpSurvivorFunction As GroupBox
    Friend WithEvents grpDisplayOptions As GroupBox
    Friend WithEvents UcrSelectorAddRemove1 As ucrSelectorAddRemove
    Friend WithEvents chkCensoringColumns As CheckBox
    Friend WithEvents rdoLoglogplot As RadioButton
    Friend WithEvents rdoKaplanMeierPlot As RadioButton
    Friend WithEvents chkRemovecolumns As CheckBox
    Friend WithEvents chkRelativeRiskofEvent As CheckBox
    Friend WithEvents chkDetailsofCalculations As CheckBox
    Friend WithEvents chkWilcoxonTest As CheckBox
    Friend WithEvents chkExploratoryPlot As CheckBox
    Friend WithEvents chkDisplayOptions As CheckBox
End Class
