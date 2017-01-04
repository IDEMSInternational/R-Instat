<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sdgCalculationsSummmary
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
        Me.tbSummaryCalcs = New System.Windows.Forms.TabControl()
        Me.tbMain = New System.Windows.Forms.TabPage()
        Me.ucrReceiverBy = New instat.ucrReceiverSingle()
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.ucrColumnName = New instat.ucrInputComboBox()
        Me.ucrCalculationName = New instat.ucrInputComboBox()
        Me.lblColumnName = New System.Windows.Forms.Label()
        Me.lblCalcName = New System.Windows.Forms.Label()
        Me.rdoSaveCalcAndResult = New System.Windows.Forms.RadioButton()
        Me.rdoSaveCalculation = New System.Windows.Forms.RadioButton()
        Me.rdoDoNotSave = New System.Windows.Forms.RadioButton()
        Me.lblType = New System.Windows.Forms.Label()
        Me.ucrType = New instat.ucrInputComboBox()
        Me.ucrSelectorBy = New instat.ucrSelectorByDataFrameAddRemove()
        Me.tbManipulations = New System.Windows.Forms.TabPage()
        Me.UcrReorder1 = New instat.ucrReorder()
        Me.cmdManipDuplicate = New System.Windows.Forms.Button()
        Me.cmdManipDelete = New System.Windows.Forms.Button()
        Me.lblManipulations = New System.Windows.Forms.Label()
        Me.cmdManipEdit = New System.Windows.Forms.Button()
        Me.cmdManipAdd = New System.Windows.Forms.Button()
        Me.tbSubCalcs = New System.Windows.Forms.TabPage()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.cmdSubDuplicate = New System.Windows.Forms.Button()
        Me.cmdSubDelete = New System.Windows.Forms.Button()
        Me.cmdSubAdd = New System.Windows.Forms.Button()
        Me.lblSubCalcs = New System.Windows.Forms.Label()
        Me.cmdSubEdit = New System.Windows.Forms.Button()
        Me.ucrBaseSummmaryCalcSubdialog = New instat.ucrButtonsSubdialogue()
        Me.ucrCalcSummary = New instat.ucrCalculator()
        Me.tbSummaryCalcs.SuspendLayout()
        Me.tbMain.SuspendLayout()
        Me.tbManipulations.SuspendLayout()
        Me.tbSubCalcs.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbSummaryCalcs
        '
        Me.tbSummaryCalcs.Controls.Add(Me.tbMain)
        Me.tbSummaryCalcs.Controls.Add(Me.tbManipulations)
        Me.tbSummaryCalcs.Controls.Add(Me.tbSubCalcs)
        Me.tbSummaryCalcs.Location = New System.Drawing.Point(0, 0)
        Me.tbSummaryCalcs.Name = "tbSummaryCalcs"
        Me.tbSummaryCalcs.SelectedIndex = 0
        Me.tbSummaryCalcs.Size = New System.Drawing.Size(643, 446)
        Me.tbSummaryCalcs.TabIndex = 1
        '
        'tbMain
        '
        Me.tbMain.Controls.Add(Me.ucrReceiverBy)
        Me.tbMain.Controls.Add(Me.lblFactor)
        Me.tbMain.Controls.Add(Me.ucrCalcSummary)
        Me.tbMain.Controls.Add(Me.ucrColumnName)
        Me.tbMain.Controls.Add(Me.ucrCalculationName)
        Me.tbMain.Controls.Add(Me.lblColumnName)
        Me.tbMain.Controls.Add(Me.lblCalcName)
        Me.tbMain.Controls.Add(Me.rdoSaveCalcAndResult)
        Me.tbMain.Controls.Add(Me.rdoSaveCalculation)
        Me.tbMain.Controls.Add(Me.rdoDoNotSave)
        Me.tbMain.Controls.Add(Me.lblType)
        Me.tbMain.Controls.Add(Me.ucrType)
        Me.tbMain.Controls.Add(Me.ucrSelectorBy)
        Me.tbMain.Location = New System.Drawing.Point(4, 22)
        Me.tbMain.Name = "tbMain"
        Me.tbMain.Padding = New System.Windows.Forms.Padding(3)
        Me.tbMain.Size = New System.Drawing.Size(635, 420)
        Me.tbMain.TabIndex = 0
        Me.tbMain.Text = "Main"
        Me.tbMain.UseVisualStyleBackColor = True
        '
        'ucrReceiverBy
        '
        Me.ucrReceiverBy.Location = New System.Drawing.Point(235, 141)
        Me.ucrReceiverBy.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverBy.Name = "ucrReceiverBy"
        Me.ucrReceiverBy.Selector = Nothing
        Me.ucrReceiverBy.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverBy.TabIndex = 16
        '
        'lblFactor
        '
        Me.lblFactor.AutoSize = True
        Me.lblFactor.Location = New System.Drawing.Point(236, 126)
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Size = New System.Drawing.Size(40, 13)
        Me.lblFactor.TabIndex = 15
        Me.lblFactor.Text = "Factor:"
        '
        'ucrColumnName
        '
        Me.ucrColumnName.IsReadOnly = False
        Me.ucrColumnName.Location = New System.Drawing.Point(109, 365)
        Me.ucrColumnName.Name = "ucrColumnName"
        Me.ucrColumnName.Size = New System.Drawing.Size(137, 21)
        Me.ucrColumnName.TabIndex = 13
        '
        'ucrCalculationName
        '
        Me.ucrCalculationName.IsReadOnly = False
        Me.ucrCalculationName.Location = New System.Drawing.Point(109, 342)
        Me.ucrCalculationName.Name = "ucrCalculationName"
        Me.ucrCalculationName.Size = New System.Drawing.Size(137, 21)
        Me.ucrCalculationName.TabIndex = 12
        '
        'lblColumnName
        '
        Me.lblColumnName.AutoSize = True
        Me.lblColumnName.Location = New System.Drawing.Point(9, 369)
        Me.lblColumnName.Name = "lblColumnName"
        Me.lblColumnName.Size = New System.Drawing.Size(76, 13)
        Me.lblColumnName.TabIndex = 10
        Me.lblColumnName.Text = "Column Name:"
        '
        'lblCalcName
        '
        Me.lblCalcName.AutoSize = True
        Me.lblCalcName.Location = New System.Drawing.Point(9, 346)
        Me.lblCalcName.Name = "lblCalcName"
        Me.lblCalcName.Size = New System.Drawing.Size(93, 13)
        Me.lblCalcName.TabIndex = 9
        Me.lblCalcName.Text = "Calculation Name:"
        '
        'rdoSaveCalcAndResult
        '
        Me.rdoSaveCalcAndResult.AutoSize = True
        Me.rdoSaveCalcAndResult.Location = New System.Drawing.Point(259, 392)
        Me.rdoSaveCalcAndResult.Name = "rdoSaveCalcAndResult"
        Me.rdoSaveCalcAndResult.Size = New System.Drawing.Size(159, 17)
        Me.rdoSaveCalcAndResult.TabIndex = 8
        Me.rdoSaveCalcAndResult.TabStop = True
        Me.rdoSaveCalcAndResult.Text = "Save Calculation and Result"
        Me.rdoSaveCalcAndResult.UseVisualStyleBackColor = True
        '
        'rdoSaveCalculation
        '
        Me.rdoSaveCalculation.AutoSize = True
        Me.rdoSaveCalculation.Location = New System.Drawing.Point(136, 392)
        Me.rdoSaveCalculation.Name = "rdoSaveCalculation"
        Me.rdoSaveCalculation.Size = New System.Drawing.Size(105, 17)
        Me.rdoSaveCalculation.TabIndex = 7
        Me.rdoSaveCalculation.TabStop = True
        Me.rdoSaveCalculation.Text = "Save Calculation"
        Me.rdoSaveCalculation.UseVisualStyleBackColor = True
        '
        'rdoDoNotSave
        '
        Me.rdoDoNotSave.AutoSize = True
        Me.rdoDoNotSave.Location = New System.Drawing.Point(12, 392)
        Me.rdoDoNotSave.Name = "rdoDoNotSave"
        Me.rdoDoNotSave.Size = New System.Drawing.Size(87, 17)
        Me.rdoDoNotSave.TabIndex = 6
        Me.rdoDoNotSave.TabStop = True
        Me.rdoDoNotSave.Text = "Do Not Save"
        Me.rdoDoNotSave.UseVisualStyleBackColor = True
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(9, 12)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(34, 13)
        Me.lblType.TabIndex = 4
        Me.lblType.Text = "Type:"
        '
        'ucrType
        '
        Me.ucrType.IsReadOnly = False
        Me.ucrType.Location = New System.Drawing.Point(8, 28)
        Me.ucrType.Name = "ucrType"
        Me.ucrType.Size = New System.Drawing.Size(120, 21)
        Me.ucrType.TabIndex = 3
        '
        'ucrSelectorBy
        '
        Me.ucrSelectorBy.bShowHiddenColumns = False
        Me.ucrSelectorBy.bUseCurrentFilter = True
        Me.ucrSelectorBy.Location = New System.Drawing.Point(8, 114)
        Me.ucrSelectorBy.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorBy.Name = "ucrSelectorBy"
        Me.ucrSelectorBy.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorBy.TabIndex = 14
        '
        'tbManipulations
        '
        Me.tbManipulations.Controls.Add(Me.UcrReorder1)
        Me.tbManipulations.Controls.Add(Me.cmdManipDuplicate)
        Me.tbManipulations.Controls.Add(Me.cmdManipDelete)
        Me.tbManipulations.Controls.Add(Me.lblManipulations)
        Me.tbManipulations.Controls.Add(Me.cmdManipEdit)
        Me.tbManipulations.Controls.Add(Me.cmdManipAdd)
        Me.tbManipulations.Location = New System.Drawing.Point(4, 22)
        Me.tbManipulations.Name = "tbManipulations"
        Me.tbManipulations.Padding = New System.Windows.Forms.Padding(3)
        Me.tbManipulations.Size = New System.Drawing.Size(737, 420)
        Me.tbManipulations.TabIndex = 1
        Me.tbManipulations.Text = "Manipulations"
        Me.tbManipulations.UseVisualStyleBackColor = True
        '
        'UcrReorder1
        '
        Me.UcrReorder1.Location = New System.Drawing.Point(6, 30)
        Me.UcrReorder1.Name = "UcrReorder1"
        Me.UcrReorder1.Size = New System.Drawing.Size(154, 139)
        Me.UcrReorder1.TabIndex = 21
        Me.UcrReorder1.ucrDataFrameList = Nothing
        Me.UcrReorder1.ucrReceiver = Nothing
        '
        'cmdManipDuplicate
        '
        Me.cmdManipDuplicate.Location = New System.Drawing.Point(166, 132)
        Me.cmdManipDuplicate.Name = "cmdManipDuplicate"
        Me.cmdManipDuplicate.Size = New System.Drawing.Size(75, 23)
        Me.cmdManipDuplicate.TabIndex = 20
        Me.cmdManipDuplicate.Text = "Duplicate"
        Me.cmdManipDuplicate.UseVisualStyleBackColor = True
        '
        'cmdManipDelete
        '
        Me.cmdManipDelete.Location = New System.Drawing.Point(166, 103)
        Me.cmdManipDelete.Name = "cmdManipDelete"
        Me.cmdManipDelete.Size = New System.Drawing.Size(75, 23)
        Me.cmdManipDelete.TabIndex = 17
        Me.cmdManipDelete.Text = "Delete"
        Me.cmdManipDelete.UseVisualStyleBackColor = True
        '
        'lblManipulations
        '
        Me.lblManipulations.AutoSize = True
        Me.lblManipulations.Location = New System.Drawing.Point(9, 17)
        Me.lblManipulations.Name = "lblManipulations"
        Me.lblManipulations.Size = New System.Drawing.Size(75, 13)
        Me.lblManipulations.TabIndex = 16
        Me.lblManipulations.Text = "Manipulations:"
        '
        'cmdManipEdit
        '
        Me.cmdManipEdit.Location = New System.Drawing.Point(166, 74)
        Me.cmdManipEdit.Name = "cmdManipEdit"
        Me.cmdManipEdit.Size = New System.Drawing.Size(75, 23)
        Me.cmdManipEdit.TabIndex = 18
        Me.cmdManipEdit.Text = "Edit"
        Me.cmdManipEdit.UseVisualStyleBackColor = True
        '
        'cmdManipAdd
        '
        Me.cmdManipAdd.Location = New System.Drawing.Point(166, 45)
        Me.cmdManipAdd.Name = "cmdManipAdd"
        Me.cmdManipAdd.Size = New System.Drawing.Size(75, 23)
        Me.cmdManipAdd.TabIndex = 19
        Me.cmdManipAdd.Text = "Add"
        Me.cmdManipAdd.UseVisualStyleBackColor = True
        '
        'tbSubCalcs
        '
        Me.tbSubCalcs.Controls.Add(Me.ListView1)
        Me.tbSubCalcs.Controls.Add(Me.cmdSubDuplicate)
        Me.tbSubCalcs.Controls.Add(Me.cmdSubDelete)
        Me.tbSubCalcs.Controls.Add(Me.cmdSubAdd)
        Me.tbSubCalcs.Controls.Add(Me.lblSubCalcs)
        Me.tbSubCalcs.Controls.Add(Me.cmdSubEdit)
        Me.tbSubCalcs.Location = New System.Drawing.Point(4, 22)
        Me.tbSubCalcs.Name = "tbSubCalcs"
        Me.tbSubCalcs.Padding = New System.Windows.Forms.Padding(3)
        Me.tbSubCalcs.Size = New System.Drawing.Size(737, 420)
        Me.tbSubCalcs.TabIndex = 2
        Me.tbSubCalcs.Text = "Sub-Calculations"
        Me.tbSubCalcs.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(9, 33)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(121, 133)
        Me.ListView1.TabIndex = 21
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.List
        '
        'cmdSubDuplicate
        '
        Me.cmdSubDuplicate.Location = New System.Drawing.Point(166, 132)
        Me.cmdSubDuplicate.Name = "cmdSubDuplicate"
        Me.cmdSubDuplicate.Size = New System.Drawing.Size(75, 23)
        Me.cmdSubDuplicate.TabIndex = 26
        Me.cmdSubDuplicate.Text = "Duplicate"
        Me.cmdSubDuplicate.UseVisualStyleBackColor = True
        '
        'cmdSubDelete
        '
        Me.cmdSubDelete.Location = New System.Drawing.Point(166, 103)
        Me.cmdSubDelete.Name = "cmdSubDelete"
        Me.cmdSubDelete.Size = New System.Drawing.Size(75, 23)
        Me.cmdSubDelete.TabIndex = 23
        Me.cmdSubDelete.Text = "Delete"
        Me.cmdSubDelete.UseVisualStyleBackColor = True
        '
        'cmdSubAdd
        '
        Me.cmdSubAdd.Location = New System.Drawing.Point(166, 45)
        Me.cmdSubAdd.Name = "cmdSubAdd"
        Me.cmdSubAdd.Size = New System.Drawing.Size(75, 23)
        Me.cmdSubAdd.TabIndex = 25
        Me.cmdSubAdd.Text = "Add"
        Me.cmdSubAdd.UseVisualStyleBackColor = True
        '
        'lblSubCalcs
        '
        Me.lblSubCalcs.AutoSize = True
        Me.lblSubCalcs.Location = New System.Drawing.Point(9, 17)
        Me.lblSubCalcs.Name = "lblSubCalcs"
        Me.lblSubCalcs.Size = New System.Drawing.Size(89, 13)
        Me.lblSubCalcs.TabIndex = 22
        Me.lblSubCalcs.Text = "Sub-Calculations:"
        '
        'cmdSubEdit
        '
        Me.cmdSubEdit.Location = New System.Drawing.Point(166, 74)
        Me.cmdSubEdit.Name = "cmdSubEdit"
        Me.cmdSubEdit.Size = New System.Drawing.Size(75, 23)
        Me.cmdSubEdit.TabIndex = 24
        Me.cmdSubEdit.Text = "Edit"
        Me.cmdSubEdit.UseVisualStyleBackColor = True
        '
        'ucrBaseSummmaryCalcSubdialog
        '
        Me.ucrBaseSummmaryCalcSubdialog.Location = New System.Drawing.Point(239, 452)
        Me.ucrBaseSummmaryCalcSubdialog.Name = "ucrBaseSummmaryCalcSubdialog"
        Me.ucrBaseSummmaryCalcSubdialog.Size = New System.Drawing.Size(142, 30)
        Me.ucrBaseSummmaryCalcSubdialog.TabIndex = 0
        '
        'ucrCalcSummary
        '
        Me.ucrCalcSummary.Location = New System.Drawing.Point(8, 50)
        Me.ucrCalcSummary.Name = "ucrCalcSummary"
        Me.ucrCalcSummary.Size = New System.Drawing.Size(623, 282)
        Me.ucrCalcSummary.TabIndex = 17
        '
        'sdgCalculationsSummmary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 491)
        Me.Controls.Add(Me.tbSummaryCalcs)
        Me.Controls.Add(Me.ucrBaseSummmaryCalcSubdialog)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgCalculationsSummmary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "General Summaries"
        Me.tbSummaryCalcs.ResumeLayout(False)
        Me.tbMain.ResumeLayout(False)
        Me.tbMain.PerformLayout()
        Me.tbManipulations.ResumeLayout(False)
        Me.tbManipulations.PerformLayout()
        Me.tbSubCalcs.ResumeLayout(False)
        Me.tbSubCalcs.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBaseSummmaryCalcSubdialog As ucrButtonsSubdialogue
    Friend WithEvents tbSummaryCalcs As TabControl
    Friend WithEvents tbMain As TabPage
    Friend WithEvents lblColumnName As Label
    Friend WithEvents lblCalcName As Label
    Friend WithEvents rdoSaveCalcAndResult As RadioButton
    Friend WithEvents rdoSaveCalculation As RadioButton
    Friend WithEvents rdoDoNotSave As RadioButton
    Friend WithEvents lblType As Label
    Friend WithEvents ucrType As ucrInputComboBox
    Friend WithEvents tbManipulations As TabPage
    Friend WithEvents tbSubCalcs As TabPage
    Friend WithEvents ucrColumnName As ucrInputComboBox
    Friend WithEvents ucrCalculationName As ucrInputComboBox
    Friend WithEvents ucrReceiverBy As ucrReceiverSingle
    Friend WithEvents lblFactor As Label
    Friend WithEvents ucrSelectorBy As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrCalcSummary As ucrCalculator
    Friend WithEvents cmdManipDuplicate As Button
    Friend WithEvents cmdManipDelete As Button
    Friend WithEvents lblManipulations As Label
    Friend WithEvents cmdManipEdit As Button
    Friend WithEvents cmdManipAdd As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents UcrReorder1 As ucrReorder
    Friend WithEvents cmdSubDuplicate As Button
    Friend WithEvents cmdSubDelete As Button
    Friend WithEvents cmdSubAdd As Button
    Friend WithEvents lblSubCalcs As Label
    Friend WithEvents cmdSubEdit As Button
End Class
