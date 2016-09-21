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
        Me.lblColumnsToTranspose.Location = New System.Drawing.Point(269, 28)
        Me.lblColumnsToTranspose.Name = "lblColumnsToTranspose"
        Me.lblColumnsToTranspose.Size = New System.Drawing.Size(133, 23)
        Me.lblColumnsToTranspose.TabIndex = 3
        Me.lblColumnsToTranspose.Tag = "Columns_to_Transpose"
        Me.lblColumnsToTranspose.Text = "Columns to Transpose:"
        '
        'chkNameNewColumns
        '
        Me.chkNameNewColumns.Location = New System.Drawing.Point(272, 161)
        Me.chkNameNewColumns.Name = "chkNameNewColumns"
        Me.chkNameNewColumns.Size = New System.Drawing.Size(125, 24)
        Me.chkNameNewColumns.TabIndex = 2
        Me.chkNameNewColumns.Tag = "Name_New_Columns"
        Me.chkNameNewColumns.Text = "Name New Columns"
        Me.chkNameNewColumns.UseVisualStyleBackColor = True
        '
        'lblNewDataFrameName
        '
        Me.lblNewDataFrameName.Location = New System.Drawing.Point(9, 205)
        Me.lblNewDataFrameName.Name = "lblNewDataFrameName"
        Me.lblNewDataFrameName.Size = New System.Drawing.Size(126, 23)
        Me.lblNewDataFrameName.TabIndex = 0
        Me.lblNewDataFrameName.Tag = "New_Data_Frame_Name"
        Me.lblNewDataFrameName.Text = "New Data Frame Name:"
        '
        'ucrNewDataFrameName
        '
        Me.ucrNewDataFrameName.IsReadOnly = False
        Me.ucrNewDataFrameName.Location = New System.Drawing.Point(133, 203)
        Me.ucrNewDataFrameName.Name = "ucrNewDataFrameName"
        Me.ucrNewDataFrameName.Size = New System.Drawing.Size(137, 21)
        Me.ucrNewDataFrameName.TabIndex = 1
        '
        'ucrReceiverColumsToTranspose
        '
        Me.ucrReceiverColumsToTranspose.Location = New System.Drawing.Point(272, 47)
        Me.ucrReceiverColumsToTranspose.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColumsToTranspose.Name = "ucrReceiverColumsToTranspose"
        Me.ucrReceiverColumsToTranspose.Selector = Nothing
        Me.ucrReceiverColumsToTranspose.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverColumsToTranspose.TabIndex = 4
        '
        'ucrSelectorTransposeColumns
        '
        Me.ucrSelectorTransposeColumns.bShowHiddenColumns = False
        Me.ucrSelectorTransposeColumns.bUseCurrentFilter = False
        Me.ucrSelectorTransposeColumns.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorTransposeColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorTransposeColumns.Name = "ucrSelectorTransposeColumns"
        Me.ucrSelectorTransposeColumns.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorTransposeColumns.TabIndex = 5
        '
        'ucrBaseTransposeColumns
        '
        Me.ucrBaseTransposeColumns.Location = New System.Drawing.Point(10, 235)
        Me.ucrBaseTransposeColumns.Name = "ucrBaseTransposeColumns"
        Me.ucrBaseTransposeColumns.Size = New System.Drawing.Size(410, 52)
        Me.ucrBaseTransposeColumns.TabIndex = 6
        '
        'dlgTransposeColumns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 297)
        Me.Controls.Add(Me.ucrNewDataFrameName)
        Me.Controls.Add(Me.lblNewDataFrameName)
        Me.Controls.Add(Me.chkNameNewColumns)
        Me.Controls.Add(Me.ucrReceiverColumsToTranspose)
        Me.Controls.Add(Me.ucrSelectorTransposeColumns)
        Me.Controls.Add(Me.ucrBaseTransposeColumns)
        Me.Controls.Add(Me.lblColumnsToTranspose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgTransposeColumns"
        Me.Tag = "Transpose_Columns"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBaseTransposeColumns As ucrButtons
    Friend WithEvents ucrSelectorTransposeColumns As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverColumsToTranspose As ucrReceiverMultiple
    Friend WithEvents lblColumnsToTranspose As Label
    Friend WithEvents chkNameNewColumns As CheckBox
    Friend WithEvents ucrNewDataFrameName As ucrInputTextBox
    Friend WithEvents lblNewDataFrameName As Label
End Class
