<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgNon_ParametricOneSampleTests
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgNon_ParametricOneSampleTests))
        Me.lblDataColumn = New System.Windows.Forms.Label()
        Me.nudMedian = New System.Windows.Forms.NumericUpDown()
        Me.nudConfidenceInterval = New System.Windows.Forms.NumericUpDown()
        Me.lblMedian = New System.Windows.Forms.Label()
        Me.lblConfidenceInterval = New System.Windows.Forms.Label()
        Me.grpTypeOfTest = New System.Windows.Forms.GroupBox()
        Me.rdoLessThan = New System.Windows.Forms.RadioButton()
        Me.rdoGreaterThan = New System.Windows.Forms.RadioButton()
        Me.rdoTwoSided = New System.Windows.Forms.RadioButton()
        Me.ucrReceiverDataColumn = New instat.ucrReceiverSingle()
        Me.ucrSelectorNPOneSample = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        CType(Me.nudMedian, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudConfidenceInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTypeOfTest.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDataColumn
        '
        resources.ApplyResources(Me.lblDataColumn, "lblDataColumn")
        Me.lblDataColumn.Name = "lblDataColumn"
        Me.lblDataColumn.Tag = "Data_column"
        '
        'nudMedian
        '
        resources.ApplyResources(Me.nudMedian, "nudMedian")
        Me.nudMedian.Name = "nudMedian"
        '
        'nudConfidenceInterval
        '
        resources.ApplyResources(Me.nudConfidenceInterval, "nudConfidenceInterval")
        Me.nudConfidenceInterval.Name = "nudConfidenceInterval"
        Me.nudConfidenceInterval.Value = New Decimal(New Integer() {95, 0, 0, 0})
        '
        'lblMedian
        '
        resources.ApplyResources(Me.lblMedian, "lblMedian")
        Me.lblMedian.Name = "lblMedian"
        Me.lblMedian.Tag = "Assumed_median_value"
        '
        'lblConfidenceInterval
        '
        resources.ApplyResources(Me.lblConfidenceInterval, "lblConfidenceInterval")
        Me.lblConfidenceInterval.Name = "lblConfidenceInterval"
        Me.lblConfidenceInterval.Tag = "Confidence_interval"
        '
        'grpTypeOfTest
        '
        Me.grpTypeOfTest.Controls.Add(Me.rdoLessThan)
        Me.grpTypeOfTest.Controls.Add(Me.rdoGreaterThan)
        Me.grpTypeOfTest.Controls.Add(Me.rdoTwoSided)
        resources.ApplyResources(Me.grpTypeOfTest, "grpTypeOfTest")
        Me.grpTypeOfTest.Name = "grpTypeOfTest"
        Me.grpTypeOfTest.TabStop = False
        Me.grpTypeOfTest.Tag = "Type_of_test"
        '
        'rdoLessThan
        '
        resources.ApplyResources(Me.rdoLessThan, "rdoLessThan")
        Me.rdoLessThan.Name = "rdoLessThan"
        Me.rdoLessThan.TabStop = True
        Me.rdoLessThan.Tag = "Less_than"
        Me.rdoLessThan.UseVisualStyleBackColor = True
        '
        'rdoGreaterThan
        '
        resources.ApplyResources(Me.rdoGreaterThan, "rdoGreaterThan")
        Me.rdoGreaterThan.Name = "rdoGreaterThan"
        Me.rdoGreaterThan.TabStop = True
        Me.rdoGreaterThan.Tag = "Greater_than"
        Me.rdoGreaterThan.UseVisualStyleBackColor = True
        '
        'rdoTwoSided
        '
        resources.ApplyResources(Me.rdoTwoSided, "rdoTwoSided")
        Me.rdoTwoSided.Name = "rdoTwoSided"
        Me.rdoTwoSided.TabStop = True
        Me.rdoTwoSided.Tag = "Two_sided"
        Me.rdoTwoSided.UseVisualStyleBackColor = True
        '
        'ucrReceiverDataColumn
        '
        resources.ApplyResources(Me.ucrReceiverDataColumn, "ucrReceiverDataColumn")
        Me.ucrReceiverDataColumn.Name = "ucrReceiverDataColumn"
        Me.ucrReceiverDataColumn.Selector = Nothing
        '
        'ucrSelectorNPOneSample
        '
        Me.ucrSelectorNPOneSample.bShowHiddenColumns = False
        Me.ucrSelectorNPOneSample.bUseCurrentFilter = False
        resources.ApplyResources(Me.ucrSelectorNPOneSample, "ucrSelectorNPOneSample")
        Me.ucrSelectorNPOneSample.Name = "ucrSelectorNPOneSample"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgNon_ParametricOneSampleTests
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpTypeOfTest)
        Me.Controls.Add(Me.lblConfidenceInterval)
        Me.Controls.Add(Me.lblMedian)
        Me.Controls.Add(Me.nudConfidenceInterval)
        Me.Controls.Add(Me.nudMedian)
        Me.Controls.Add(Me.lblDataColumn)
        Me.Controls.Add(Me.ucrReceiverDataColumn)
        Me.Controls.Add(Me.ucrSelectorNPOneSample)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgNon_ParametricOneSampleTests"
        Me.Tag = "Non-Parametric_One_Sample_Tests"
        CType(Me.nudMedian, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudConfidenceInterval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTypeOfTest.ResumeLayout(False)
        Me.grpTypeOfTest.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorNPOneSample As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverDataColumn As ucrReceiverSingle
    Friend WithEvents lblDataColumn As Label
    Friend WithEvents nudMedian As NumericUpDown
    Friend WithEvents nudConfidenceInterval As NumericUpDown
    Friend WithEvents lblMedian As Label
    Friend WithEvents lblConfidenceInterval As Label
    Friend WithEvents grpTypeOfTest As GroupBox
    Friend WithEvents rdoLessThan As RadioButton
    Friend WithEvents rdoGreaterThan As RadioButton
    Friend WithEvents rdoTwoSided As RadioButton
End Class
