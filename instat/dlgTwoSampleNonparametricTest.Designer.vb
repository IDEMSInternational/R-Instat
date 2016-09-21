<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgTwoSampleNonparametricTest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgTwoSampleNonparametricTest))
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrTwoSampleSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.grpLayoutOfData = New System.Windows.Forms.GroupBox()
        Me.rdotwoColinSamedataframe = New System.Windows.Forms.RadioButton()
        Me.rdoTwoColinSeparateDataFrame = New System.Windows.Forms.RadioButton()
        Me.rdoDataColandFactorCol = New System.Windows.Forms.RadioButton()
        Me.rdoSignTest = New System.Windows.Forms.RadioButton()
        Me.rdoWilcoxon = New System.Windows.Forms.RadioButton()
        Me.lblVariable = New System.Windows.Forms.Label()
        Me.ucrReceiverVariable = New instat.ucrReceiverSingle()
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.ucrReceiverFactor = New instat.ucrReceiverSingle()
        Me.grpTypeOfTest = New System.Windows.Forms.GroupBox()
        Me.rdoOneSidedy2 = New System.Windows.Forms.RadioButton()
        Me.rdoOnesidedy1 = New System.Windows.Forms.RadioButton()
        Me.rdoTwoSided = New System.Windows.Forms.RadioButton()
        Me.grpLayoutOfData.SuspendLayout()
        Me.grpTypeOfTest.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrTwoSampleSelector
        '
        Me.ucrTwoSampleSelector.bShowHiddenColumns = False
        Me.ucrTwoSampleSelector.bUseCurrentFilter = False
        resources.ApplyResources(Me.ucrTwoSampleSelector, "ucrTwoSampleSelector")
        Me.ucrTwoSampleSelector.Name = "ucrTwoSampleSelector"
        '
        'grpLayoutOfData
        '
        Me.grpLayoutOfData.Controls.Add(Me.rdotwoColinSamedataframe)
        Me.grpLayoutOfData.Controls.Add(Me.rdoTwoColinSeparateDataFrame)
        Me.grpLayoutOfData.Controls.Add(Me.rdoDataColandFactorCol)
        resources.ApplyResources(Me.grpLayoutOfData, "grpLayoutOfData")
        Me.grpLayoutOfData.Name = "grpLayoutOfData"
        Me.grpLayoutOfData.TabStop = False
        Me.grpLayoutOfData.Tag = "Layout_Of_Data"
        '
        'rdotwoColinSamedataframe
        '
        resources.ApplyResources(Me.rdotwoColinSamedataframe, "rdotwoColinSamedataframe")
        Me.rdotwoColinSamedataframe.Name = "rdotwoColinSamedataframe"
        Me.rdotwoColinSamedataframe.TabStop = True
        Me.rdotwoColinSamedataframe.Tag = "Two_Columns_in_Same_Data_Frame"
        Me.rdotwoColinSamedataframe.UseVisualStyleBackColor = True
        '
        'rdoTwoColinSeparateDataFrame
        '
        resources.ApplyResources(Me.rdoTwoColinSeparateDataFrame, "rdoTwoColinSeparateDataFrame")
        Me.rdoTwoColinSeparateDataFrame.Name = "rdoTwoColinSeparateDataFrame"
        Me.rdoTwoColinSeparateDataFrame.TabStop = True
        Me.rdoTwoColinSeparateDataFrame.Tag = "Two_Columns_in_Separate_Data_Frames"
        Me.rdoTwoColinSeparateDataFrame.UseVisualStyleBackColor = True
        '
        'rdoDataColandFactorCol
        '
        resources.ApplyResources(Me.rdoDataColandFactorCol, "rdoDataColandFactorCol")
        Me.rdoDataColandFactorCol.Name = "rdoDataColandFactorCol"
        Me.rdoDataColandFactorCol.TabStop = True
        Me.rdoDataColandFactorCol.Tag = "Data_Column_and_Factor_Column"
        Me.rdoDataColandFactorCol.UseVisualStyleBackColor = True
        '
        'rdoSignTest
        '
        resources.ApplyResources(Me.rdoSignTest, "rdoSignTest")
        Me.rdoSignTest.Name = "rdoSignTest"
        Me.rdoSignTest.TabStop = True
        Me.rdoSignTest.Tag = "Sign_Test"
        Me.rdoSignTest.UseVisualStyleBackColor = True
        '
        'rdoWilcoxon
        '
        resources.ApplyResources(Me.rdoWilcoxon, "rdoWilcoxon")
        Me.rdoWilcoxon.Name = "rdoWilcoxon"
        Me.rdoWilcoxon.TabStop = True
        Me.rdoWilcoxon.Tag = "Wilcoxon"
        Me.rdoWilcoxon.UseVisualStyleBackColor = True
        '
        'lblVariable
        '
        resources.ApplyResources(Me.lblVariable, "lblVariable")
        Me.lblVariable.Name = "lblVariable"
        Me.lblVariable.Tag = "Variable"
        '
        'ucrReceiverVariable
        '
        resources.ApplyResources(Me.ucrReceiverVariable, "ucrReceiverVariable")
        Me.ucrReceiverVariable.Name = "ucrReceiverVariable"
        Me.ucrReceiverVariable.Selector = Nothing
        '
        'lblFactor
        '
        resources.ApplyResources(Me.lblFactor, "lblFactor")
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Tag = "Factor"
        '
        'ucrReceiverFactor
        '
        resources.ApplyResources(Me.ucrReceiverFactor, "ucrReceiverFactor")
        Me.ucrReceiverFactor.Name = "ucrReceiverFactor"
        Me.ucrReceiverFactor.Selector = Nothing
        '
        'grpTypeOfTest
        '
        Me.grpTypeOfTest.Controls.Add(Me.rdoOneSidedy2)
        Me.grpTypeOfTest.Controls.Add(Me.rdoOnesidedy1)
        Me.grpTypeOfTest.Controls.Add(Me.rdoTwoSided)
        resources.ApplyResources(Me.grpTypeOfTest, "grpTypeOfTest")
        Me.grpTypeOfTest.Name = "grpTypeOfTest"
        Me.grpTypeOfTest.TabStop = False
        Me.grpTypeOfTest.Tag = "Type_of_Test"
        '
        'rdoOneSidedy2
        '
        resources.ApplyResources(Me.rdoOneSidedy2, "rdoOneSidedy2")
        Me.rdoOneSidedy2.Name = "rdoOneSidedy2"
        Me.rdoOneSidedy2.TabStop = True
        Me.rdoOneSidedy2.Tag = "One_Sided _y1y2"
        Me.rdoOneSidedy2.UseVisualStyleBackColor = True
        '
        'rdoOnesidedy1
        '
        resources.ApplyResources(Me.rdoOnesidedy1, "rdoOnesidedy1")
        Me.rdoOnesidedy1.Name = "rdoOnesidedy1"
        Me.rdoOnesidedy1.TabStop = True
        Me.rdoOnesidedy1.Tag = "One_Sided _y1_y2)"
        Me.rdoOnesidedy1.UseVisualStyleBackColor = True
        '
        'rdoTwoSided
        '
        resources.ApplyResources(Me.rdoTwoSided, "rdoTwoSided")
        Me.rdoTwoSided.Name = "rdoTwoSided"
        Me.rdoTwoSided.TabStop = True
        Me.rdoTwoSided.Tag = "Two_Sided"
        Me.rdoTwoSided.UseVisualStyleBackColor = True
        '
        'dlgTwoSampleNonparametricTest
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpTypeOfTest)
        Me.Controls.Add(Me.ucrReceiverFactor)
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.ucrReceiverVariable)
        Me.Controls.Add(Me.lblVariable)
        Me.Controls.Add(Me.rdoWilcoxon)
        Me.Controls.Add(Me.rdoSignTest)
        Me.Controls.Add(Me.grpLayoutOfData)
        Me.Controls.Add(Me.ucrTwoSampleSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgTwoSampleNonparametricTest"
        Me.Tag = "Two_Sample_Non_parametric_Tests"
        Me.grpLayoutOfData.ResumeLayout(False)
        Me.grpLayoutOfData.PerformLayout()
        Me.grpTypeOfTest.ResumeLayout(False)
        Me.grpTypeOfTest.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrTwoSampleSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents grpLayoutOfData As GroupBox
    Friend WithEvents rdotwoColinSamedataframe As RadioButton
    Friend WithEvents rdoTwoColinSeparateDataFrame As RadioButton
    Friend WithEvents rdoDataColandFactorCol As RadioButton
    Friend WithEvents rdoSignTest As RadioButton
    Friend WithEvents rdoWilcoxon As RadioButton
    Friend WithEvents lblVariable As Label
    Friend WithEvents ucrReceiverVariable As ucrReceiverSingle
    Friend WithEvents lblFactor As Label
    Friend WithEvents ucrReceiverFactor As ucrReceiverSingle
    Friend WithEvents grpTypeOfTest As GroupBox
    Friend WithEvents rdoOneSidedy2 As RadioButton
    Friend WithEvents rdoOnesidedy1 As RadioButton
    Friend WithEvents rdoTwoSided As RadioButton
End Class
