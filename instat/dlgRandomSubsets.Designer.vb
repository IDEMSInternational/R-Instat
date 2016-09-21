<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgRandomSubsets
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgRandomSubsets))
        Me.lblSelected = New System.Windows.Forms.Label()
        Me.lblSampleSize = New System.Windows.Forms.Label()
        Me.lblNumberOfColumns = New System.Windows.Forms.Label()
        Me.nudSampleSize = New System.Windows.Forms.NumericUpDown()
        Me.nudNumberOfColumns = New System.Windows.Forms.NumericUpDown()
        Me.chkWithReplacement = New System.Windows.Forms.CheckBox()
        Me.lblNewDataFrameName = New System.Windows.Forms.Label()
        Me.nudSetSeed = New System.Windows.Forms.NumericUpDown()
        Me.chkSetSeed = New System.Windows.Forms.CheckBox()
        Me.ucrNewDataFrameName = New instat.ucrInputTextBox()
        Me.ucrReceiverSelected = New instat.ucrReceiverSingle()
        Me.ucrSelectorRandomSubsets = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        CType(Me.nudSampleSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNumberOfColumns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSetSeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSelected
        '
        resources.ApplyResources(Me.lblSelected, "lblSelected")
        Me.lblSelected.Name = "lblSelected"
        Me.lblSelected.Tag = "Selected"
        '
        'lblSampleSize
        '
        resources.ApplyResources(Me.lblSampleSize, "lblSampleSize")
        Me.lblSampleSize.Name = "lblSampleSize"
        Me.lblSampleSize.Tag = "Sample_Size"
        '
        'lblNumberOfColumns
        '
        resources.ApplyResources(Me.lblNumberOfColumns, "lblNumberOfColumns")
        Me.lblNumberOfColumns.Name = "lblNumberOfColumns"
        Me.lblNumberOfColumns.Tag = "Number_of_Columns"
        '
        'nudSampleSize
        '
        resources.ApplyResources(Me.nudSampleSize, "nudSampleSize")
        Me.nudSampleSize.Name = "nudSampleSize"
        '
        'nudNumberOfColumns
        '
        resources.ApplyResources(Me.nudNumberOfColumns, "nudNumberOfColumns")
        Me.nudNumberOfColumns.Name = "nudNumberOfColumns"
        '
        'chkWithReplacement
        '
        resources.ApplyResources(Me.chkWithReplacement, "chkWithReplacement")
        Me.chkWithReplacement.Name = "chkWithReplacement"
        Me.chkWithReplacement.Tag = "With_Replacement"
        Me.chkWithReplacement.UseVisualStyleBackColor = True
        '
        'lblNewDataFrameName
        '
        resources.ApplyResources(Me.lblNewDataFrameName, "lblNewDataFrameName")
        Me.lblNewDataFrameName.Name = "lblNewDataFrameName"
        Me.lblNewDataFrameName.Tag = "New_Data_Frame_Name"
        '
        'nudSetSeed
        '
        resources.ApplyResources(Me.nudSetSeed, "nudSetSeed")
        Me.nudSetSeed.Name = "nudSetSeed"
        '
        'chkSetSeed
        '
        resources.ApplyResources(Me.chkSetSeed, "chkSetSeed")
        Me.chkSetSeed.Name = "chkSetSeed"
        Me.chkSetSeed.Tag = "Seed"
        Me.chkSetSeed.UseVisualStyleBackColor = True
        '
        'ucrNewDataFrameName
        '
        Me.ucrNewDataFrameName.IsReadOnly = False
        resources.ApplyResources(Me.ucrNewDataFrameName, "ucrNewDataFrameName")
        Me.ucrNewDataFrameName.Name = "ucrNewDataFrameName"
        '
        'ucrReceiverSelected
        '
        resources.ApplyResources(Me.ucrReceiverSelected, "ucrReceiverSelected")
        Me.ucrReceiverSelected.Name = "ucrReceiverSelected"
        Me.ucrReceiverSelected.Selector = Nothing
        '
        'ucrSelectorRandomSubsets
        '
        Me.ucrSelectorRandomSubsets.bShowHiddenColumns = False
        Me.ucrSelectorRandomSubsets.bUseCurrentFilter = False
        resources.ApplyResources(Me.ucrSelectorRandomSubsets, "ucrSelectorRandomSubsets")
        Me.ucrSelectorRandomSubsets.Name = "ucrSelectorRandomSubsets"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgRandomSubsets
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrNewDataFrameName)
        Me.Controls.Add(Me.chkSetSeed)
        Me.Controls.Add(Me.nudSetSeed)
        Me.Controls.Add(Me.lblNewDataFrameName)
        Me.Controls.Add(Me.chkWithReplacement)
        Me.Controls.Add(Me.nudNumberOfColumns)
        Me.Controls.Add(Me.nudSampleSize)
        Me.Controls.Add(Me.lblNumberOfColumns)
        Me.Controls.Add(Me.lblSampleSize)
        Me.Controls.Add(Me.lblSelected)
        Me.Controls.Add(Me.ucrReceiverSelected)
        Me.Controls.Add(Me.ucrSelectorRandomSubsets)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRandomSubsets"
        Me.Tag = "Random_Subsets"
        CType(Me.nudSampleSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNumberOfColumns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSetSeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorRandomSubsets As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverSelected As ucrReceiverSingle
    Friend WithEvents lblSelected As Label
    Friend WithEvents lblSampleSize As Label
    Friend WithEvents lblNumberOfColumns As Label
    Friend WithEvents nudSampleSize As NumericUpDown
    Friend WithEvents nudNumberOfColumns As NumericUpDown
    Friend WithEvents chkWithReplacement As CheckBox
    Friend WithEvents lblNewDataFrameName As Label
    Friend WithEvents nudSetSeed As NumericUpDown
    Friend WithEvents chkSetSeed As CheckBox
    Friend WithEvents ucrNewDataFrameName As ucrInputTextBox
End Class
