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
        Me.ucrBase.Location = New System.Drawing.Point(10, 74)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 3
        '
        'ucrDataFrameCopySheets
        '
        Me.ucrDataFrameCopySheets.bUseCurrentFilter = False
        Me.ucrDataFrameCopySheets.Location = New System.Drawing.Point(10, 10)
        Me.ucrDataFrameCopySheets.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataFrameCopySheets.Name = "ucrDataFrameCopySheets"
        Me.ucrDataFrameCopySheets.Size = New System.Drawing.Size(120, 40)
        Me.ucrDataFrameCopySheets.TabIndex = 2
        '
        'lblNewSheetName
        '
        Me.lblNewSheetName.Location = New System.Drawing.Point(194, 10)
        Me.lblNewSheetName.Name = "lblNewSheetName"
        Me.lblNewSheetName.Size = New System.Drawing.Size(156, 23)
        Me.lblNewSheetName.TabIndex = 1
        Me.lblNewSheetName.Tag = "New_Sheet_Name"
        Me.lblNewSheetName.Text = "New Data Frame Name:"
        '
        'ucrNewDataFrameName
        '
        Me.ucrNewDataFrameName.IsReadOnly = False
        Me.ucrNewDataFrameName.Location = New System.Drawing.Point(194, 28)
        Me.ucrNewDataFrameName.Name = "ucrNewDataFrameName"
        Me.ucrNewDataFrameName.Size = New System.Drawing.Size(137, 21)
        Me.ucrNewDataFrameName.TabIndex = 0
        '
        'dlgCopySheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 134)
        Me.Controls.Add(Me.ucrNewDataFrameName)
        Me.Controls.Add(Me.lblNewSheetName)
        Me.Controls.Add(Me.ucrDataFrameCopySheets)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCopySheet"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrDataFrameCopySheets As ucrDataFrame
    Friend WithEvents lblNewSheetName As Label
    Friend WithEvents ucrNewDataFrameName As ucrInputTextBox
End Class
