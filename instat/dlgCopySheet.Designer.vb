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
        Me.ucrInputLabel = New instat.ucrInputTextBox()
        Me.lblLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 118)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 3
        '
        'ucrDataFrameCopySheets
        '
        Me.ucrDataFrameCopySheets.bUseCurrentFilter = True
        Me.ucrDataFrameCopySheets.Location = New System.Drawing.Point(10, 10)
        Me.ucrDataFrameCopySheets.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataFrameCopySheets.Name = "ucrDataFrameCopySheets"
        Me.ucrDataFrameCopySheets.Size = New System.Drawing.Size(120, 40)
        Me.ucrDataFrameCopySheets.TabIndex = 0
        '
        'lblNewSheetName
        '
        Me.lblNewSheetName.Location = New System.Drawing.Point(194, 12)
        Me.lblNewSheetName.Name = "lblNewSheetName"
        Me.lblNewSheetName.Size = New System.Drawing.Size(70, 13)
        Me.lblNewSheetName.TabIndex = 1
        Me.lblNewSheetName.Tag = "New_Sheet_Name"
        Me.lblNewSheetName.Text = "New Name:"
        '
        'ucrNewDataFrameName
        '
        Me.ucrNewDataFrameName.AddQuotesIfUnrecognised = True
        Me.ucrNewDataFrameName.IsMultiline = False
        Me.ucrNewDataFrameName.IsReadOnly = False
        Me.ucrNewDataFrameName.Location = New System.Drawing.Point(194, 28)
        Me.ucrNewDataFrameName.Name = "ucrNewDataFrameName"
        Me.ucrNewDataFrameName.Size = New System.Drawing.Size(137, 21)
        Me.ucrNewDataFrameName.TabIndex = 2
        '
        'ucrInputLabel
        '
        Me.ucrInputLabel.AddQuotesIfUnrecognised = True
        Me.ucrInputLabel.IsMultiline = False
        Me.ucrInputLabel.IsReadOnly = False
        Me.ucrInputLabel.Location = New System.Drawing.Point(194, 80)
        Me.ucrInputLabel.Name = "ucrInputLabel"
        Me.ucrInputLabel.Size = New System.Drawing.Size(131, 22)
        Me.ucrInputLabel.TabIndex = 6
        '
        'lblLabel
        '
        Me.lblLabel.AutoSize = True
        Me.lblLabel.Location = New System.Drawing.Point(194, 64)
        Me.lblLabel.Name = "lblLabel"
        Me.lblLabel.Size = New System.Drawing.Size(94, 13)
        Me.lblLabel.TabIndex = 5
        Me.lblLabel.Text = "Data Frame Label:"
        '
        'dlgCopySheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 176)
        Me.Controls.Add(Me.ucrInputLabel)
        Me.Controls.Add(Me.lblLabel)
        Me.Controls.Add(Me.ucrNewDataFrameName)
        Me.Controls.Add(Me.lblNewSheetName)
        Me.Controls.Add(Me.ucrDataFrameCopySheets)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCopySheet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Copy Sheet"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrDataFrameCopySheets As ucrDataFrame
    Friend WithEvents lblNewSheetName As Label
    Friend WithEvents ucrNewDataFrameName As ucrInputTextBox
    Friend WithEvents ucrInputLabel As ucrInputTextBox
    Friend WithEvents lblLabel As Label
End Class
