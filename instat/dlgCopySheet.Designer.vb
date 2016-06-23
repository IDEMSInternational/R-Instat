<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgCopySheet
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
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrDataFrameCopySheets = New instat.ucrDataFrame()
        Me.lblNewSheetName = New System.Windows.Forms.Label()
        Me.ucrNewDataFrameName = New instat.ucrInputTextBox()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 69)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrDataFrameCopySheets
        '
        Me.ucrDataFrameCopySheets.Location = New System.Drawing.Point(10, 10)
        Me.ucrDataFrameCopySheets.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataFrameCopySheets.Name = "ucrDataFrameCopySheets"
        Me.ucrDataFrameCopySheets.Size = New System.Drawing.Size(120, 40)
        Me.ucrDataFrameCopySheets.TabIndex = 1
        '
        'lblNewSheetName
        '
        Me.lblNewSheetName.AutoSize = True
        Me.lblNewSheetName.Location = New System.Drawing.Point(150, 31)
        Me.lblNewSheetName.Name = "lblNewSheetName"
        Me.lblNewSheetName.Size = New System.Drawing.Size(118, 13)
        Me.lblNewSheetName.TabIndex = 2
        Me.lblNewSheetName.Tag = "New_Sheet_Name"
        Me.lblNewSheetName.Text = "New Data Frame Name"
        '
        'ucrNewDataFrameName
        '
        Me.ucrNewDataFrameName.IsReadOnly = False
        Me.ucrNewDataFrameName.Location = New System.Drawing.Point(270, 27)
        Me.ucrNewDataFrameName.Name = "ucrNewDataFrameName"
        Me.ucrNewDataFrameName.Size = New System.Drawing.Size(137, 21)
        Me.ucrNewDataFrameName.TabIndex = 3
        '
        'dlgCopySheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 123)
        Me.Controls.Add(Me.ucrNewDataFrameName)
        Me.Controls.Add(Me.lblNewSheetName)
        Me.Controls.Add(Me.ucrDataFrameCopySheets)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgCopySheet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Copy Sheet (s) "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrDataFrameCopySheets As ucrDataFrame
    Friend WithEvents lblNewSheetName As Label
    Friend WithEvents ucrNewDataFrameName As ucrInputTextBox
End Class
