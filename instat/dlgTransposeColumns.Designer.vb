<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgTransposeColumns
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgTransposeColumns))
        Me.lblColumnsToTranspose = New System.Windows.Forms.Label()
        Me.chkNameNewColumns = New System.Windows.Forms.CheckBox()
        Me.lblNewDataFrameName = New System.Windows.Forms.Label()
        Me.ucrNewDataFrameName = New instat.ucrInputTextBox()
        Me.ucrReceiverColumsToTranspose = New instat.ucrReceiverMultiple()
        Me.ucrSelectorTransposeColumns = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBaseTransposeColumns = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblColumnsToTranspose
        '
        resources.ApplyResources(Me.lblColumnsToTranspose, "lblColumnsToTranspose")
        Me.lblColumnsToTranspose.Name = "lblColumnsToTranspose"
        Me.lblColumnsToTranspose.Tag = "Columns_to_Transpose"
        '
        'chkNameNewColumns
        '
        resources.ApplyResources(Me.chkNameNewColumns, "chkNameNewColumns")
        Me.chkNameNewColumns.Name = "chkNameNewColumns"
        Me.chkNameNewColumns.Tag = "Name_New_Columns"
        Me.chkNameNewColumns.UseVisualStyleBackColor = True
        '
        'lblNewDataFrameName
        '
        resources.ApplyResources(Me.lblNewDataFrameName, "lblNewDataFrameName")
        Me.lblNewDataFrameName.Name = "lblNewDataFrameName"
        Me.lblNewDataFrameName.Tag = "New_Data_Frame_Name"
        '
        'ucrNewDataFrameName
        '
        Me.ucrNewDataFrameName.IsReadOnly = False
        resources.ApplyResources(Me.ucrNewDataFrameName, "ucrNewDataFrameName")
        Me.ucrNewDataFrameName.Name = "ucrNewDataFrameName"
        '
        'ucrReceiverColumsToTranspose
        '
        resources.ApplyResources(Me.ucrReceiverColumsToTranspose, "ucrReceiverColumsToTranspose")
        Me.ucrReceiverColumsToTranspose.Name = "ucrReceiverColumsToTranspose"
        Me.ucrReceiverColumsToTranspose.Selector = Nothing
        '
        'ucrSelectorTransposeColumns
        '
        Me.ucrSelectorTransposeColumns.bShowHiddenColumns = False
        Me.ucrSelectorTransposeColumns.bUseCurrentFilter = False
        resources.ApplyResources(Me.ucrSelectorTransposeColumns, "ucrSelectorTransposeColumns")
        Me.ucrSelectorTransposeColumns.Name = "ucrSelectorTransposeColumns"
        '
        'ucrBaseTransposeColumns
        '
        resources.ApplyResources(Me.ucrBaseTransposeColumns, "ucrBaseTransposeColumns")
        Me.ucrBaseTransposeColumns.Name = "ucrBaseTransposeColumns"
        '
        'dlgTransposeColumns
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblNewDataFrameName)
        Me.Controls.Add(Me.ucrNewDataFrameName)
        Me.Controls.Add(Me.chkNameNewColumns)
        Me.Controls.Add(Me.lblColumnsToTranspose)
        Me.Controls.Add(Me.ucrReceiverColumsToTranspose)
        Me.Controls.Add(Me.ucrSelectorTransposeColumns)
        Me.Controls.Add(Me.ucrBaseTransposeColumns)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgTransposeColumns"
        Me.Tag = "Transpose_Columns"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBaseTransposeColumns As ucrButtons
    Friend WithEvents ucrSelectorTransposeColumns As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverColumsToTranspose As ucrReceiverMultiple
    Friend WithEvents lblColumnsToTranspose As Label
    Friend WithEvents chkNameNewColumns As CheckBox
    Friend WithEvents ucrNewDataFrameName As ucrInputTextBox
    Friend WithEvents lblNewDataFrameName As Label
End Class
