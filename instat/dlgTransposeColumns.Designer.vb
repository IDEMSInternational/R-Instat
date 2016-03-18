<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgTransposeColumns
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
        Me.UcrButtons1 = New instat.ucrButtons()
        Me.ucrSelectorTransposeColumns = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrColumsToTranspose = New instat.ucrReceiverMultiple()
        Me.lblColumnsToTranspose = New System.Windows.Forms.Label()
        Me.chkNameNewColumns = New System.Windows.Forms.CheckBox()
        Me.ucrInputNewDataFrame = New instat.ucrInputTextBox()
        Me.lblNewDataFrameName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'UcrButtons1
        '
        Me.UcrButtons1.Location = New System.Drawing.Point(1, 252)
        Me.UcrButtons1.Name = "UcrButtons1"
        Me.UcrButtons1.Size = New System.Drawing.Size(410, 53)
        Me.UcrButtons1.TabIndex = 0
        '
        'ucrSelectorTransposeColumns
        '
        Me.ucrSelectorTransposeColumns.Location = New System.Drawing.Point(2, 12)
        Me.ucrSelectorTransposeColumns.Name = "ucrSelectorTransposeColumns"
        Me.ucrSelectorTransposeColumns.Size = New System.Drawing.Size(242, 179)
        Me.ucrSelectorTransposeColumns.TabIndex = 1
        '
        'ucrColumsToTranspose
        '
        Me.ucrColumsToTranspose.Location = New System.Drawing.Point(250, 69)
        Me.ucrColumsToTranspose.Name = "ucrColumsToTranspose"
        Me.ucrColumsToTranspose.Selector = Nothing
        Me.ucrColumsToTranspose.Size = New System.Drawing.Size(121, 104)
        Me.ucrColumsToTranspose.TabIndex = 2
        '
        'lblColumnsToTranspose
        '
        Me.lblColumnsToTranspose.AutoSize = True
        Me.lblColumnsToTranspose.Location = New System.Drawing.Point(250, 32)
        Me.lblColumnsToTranspose.Name = "lblColumnsToTranspose"
        Me.lblColumnsToTranspose.Size = New System.Drawing.Size(116, 13)
        Me.lblColumnsToTranspose.TabIndex = 3
        Me.lblColumnsToTranspose.Tag = "Columns_To_Transpose"
        Me.lblColumnsToTranspose.Text = "Columns To Transpose"
        '
        'chkNameNewColumns
        '
        Me.chkNameNewColumns.AutoSize = True
        Me.chkNameNewColumns.Location = New System.Drawing.Point(10, 196)
        Me.chkNameNewColumns.Name = "chkNameNewColumns"
        Me.chkNameNewColumns.Size = New System.Drawing.Size(122, 17)
        Me.chkNameNewColumns.TabIndex = 4
        Me.chkNameNewColumns.Tag = "Name_New_Columns"
        Me.chkNameNewColumns.Text = "Name New Columns"
        Me.chkNameNewColumns.UseVisualStyleBackColor = True
        '
        'ucrInputNewDataFrame
        '
        Me.ucrInputNewDataFrame.Location = New System.Drawing.Point(172, 220)
        Me.ucrInputNewDataFrame.Name = "ucrInputNewDataFrame"
        Me.ucrInputNewDataFrame.Size = New System.Drawing.Size(194, 21)
        Me.ucrInputNewDataFrame.TabIndex = 5
        '
        'lblNewDataFrameName
        '
        Me.lblNewDataFrameName.AutoSize = True
        Me.lblNewDataFrameName.Location = New System.Drawing.Point(8, 220)
        Me.lblNewDataFrameName.Name = "lblNewDataFrameName"
        Me.lblNewDataFrameName.Size = New System.Drawing.Size(118, 13)
        Me.lblNewDataFrameName.TabIndex = 6
        Me.lblNewDataFrameName.Tag = "New_Data_Frame_Name"
        Me.lblNewDataFrameName.Text = "New Data Frame Name"
        '
        'dlgTransposeColumns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 305)
        Me.Controls.Add(Me.lblNewDataFrameName)
        Me.Controls.Add(Me.ucrInputNewDataFrame)
        Me.Controls.Add(Me.chkNameNewColumns)
        Me.Controls.Add(Me.lblColumnsToTranspose)
        Me.Controls.Add(Me.ucrColumsToTranspose)
        Me.Controls.Add(Me.ucrSelectorTransposeColumns)
        Me.Controls.Add(Me.UcrButtons1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgTransposeColumns"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Transpose_Columns"
        Me.Text = "Transpose Columns"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UcrButtons1 As ucrButtons
    Friend WithEvents ucrSelectorTransposeColumns As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrColumsToTranspose As ucrReceiverMultiple
    Friend WithEvents lblColumnsToTranspose As Label
    Friend WithEvents chkNameNewColumns As CheckBox
    Friend WithEvents ucrInputNewDataFrame As ucrInputTextBox
    Friend WithEvents lblNewDataFrameName As Label
End Class
