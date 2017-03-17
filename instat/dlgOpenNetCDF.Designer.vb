<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgOpenNetCDF
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
        Me.lblLocationName = New System.Windows.Forms.Label()
        Me.cmdOpenDataSet = New System.Windows.Forms.Button()
        Me.lblFileOpenPath = New System.Windows.Forms.Label()
        Me.lblSSTName = New System.Windows.Forms.Label()
        Me.ucrInputLocDataName = New instat.ucrInputTextBox()
        Me.ucrInputFilePath = New instat.ucrInputTextBox()
        Me.ucrInputDataName = New instat.ucrInputTextBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblLocationName
        '
        Me.lblLocationName.AutoSize = True
        Me.lblLocationName.Location = New System.Drawing.Point(10, 82)
        Me.lblLocationName.Name = "lblLocationName"
        Me.lblLocationName.Size = New System.Drawing.Size(134, 13)
        Me.lblLocationName.TabIndex = 5
        Me.lblLocationName.Tag = "Lat_Lon_Data_Name_Prefix:"
        Me.lblLocationName.Text = "Lat/Lon Data Name Prefix:"
        '
        'cmdOpenDataSet
        '
        Me.cmdOpenDataSet.Location = New System.Drawing.Point(225, 15)
        Me.cmdOpenDataSet.Name = "cmdOpenDataSet"
        Me.cmdOpenDataSet.Size = New System.Drawing.Size(66, 23)
        Me.cmdOpenDataSet.TabIndex = 2
        Me.cmdOpenDataSet.Tag = "select_file"
        Me.cmdOpenDataSet.Text = "Select File"
        Me.cmdOpenDataSet.UseVisualStyleBackColor = True
        '
        'lblFileOpenPath
        '
        Me.lblFileOpenPath.AutoSize = True
        Me.lblFileOpenPath.Location = New System.Drawing.Point(10, 18)
        Me.lblFileOpenPath.Name = "lblFileOpenPath"
        Me.lblFileOpenPath.Size = New System.Drawing.Size(26, 13)
        Me.lblFileOpenPath.TabIndex = 0
        Me.lblFileOpenPath.Text = "File:"
        '
        'lblSSTName
        '
        Me.lblSSTName.AutoSize = True
        Me.lblSSTName.Location = New System.Drawing.Point(10, 49)
        Me.lblSSTName.Name = "lblSSTName"
        Me.lblSSTName.Size = New System.Drawing.Size(114, 13)
        Me.lblSSTName.TabIndex = 3
        Me.lblSSTName.Tag = "SST_Dataframe_Name:"
        Me.lblSSTName.Text = "SST Dataframe Name:"
        '
        'ucrInputLocDataName
        '
        Me.ucrInputLocDataName.AddQuotesIfUnrecognised = True
        Me.ucrInputLocDataName.IsMultiline = False
        Me.ucrInputLocDataName.IsReadOnly = False
        Me.ucrInputLocDataName.Location = New System.Drawing.Point(163, 77)
        Me.ucrInputLocDataName.Name = "ucrInputLocDataName"
        Me.ucrInputLocDataName.Size = New System.Drawing.Size(142, 21)
        Me.ucrInputLocDataName.TabIndex = 6
        '
        'ucrInputFilePath
        '
        Me.ucrInputFilePath.AddQuotesIfUnrecognised = True
        Me.ucrInputFilePath.IsMultiline = False
        Me.ucrInputFilePath.IsReadOnly = False
        Me.ucrInputFilePath.Location = New System.Drawing.Point(52, 15)
        Me.ucrInputFilePath.Name = "ucrInputFilePath"
        Me.ucrInputFilePath.Size = New System.Drawing.Size(161, 21)
        Me.ucrInputFilePath.TabIndex = 1
        '
        'ucrInputDataName
        '
        Me.ucrInputDataName.AddQuotesIfUnrecognised = True
        Me.ucrInputDataName.IsMultiline = False
        Me.ucrInputDataName.IsReadOnly = False
        Me.ucrInputDataName.Location = New System.Drawing.Point(147, 45)
        Me.ucrInputDataName.Name = "ucrInputDataName"
        Me.ucrInputDataName.Size = New System.Drawing.Size(142, 21)
        Me.ucrInputDataName.TabIndex = 4
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 116)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 7
        '
        'dlgOpenNetCDF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 181)
        Me.Controls.Add(Me.ucrInputLocDataName)
        Me.Controls.Add(Me.lblLocationName)
        Me.Controls.Add(Me.ucrInputFilePath)
        Me.Controls.Add(Me.ucrInputDataName)
        Me.Controls.Add(Me.cmdOpenDataSet)
        Me.Controls.Add(Me.lblFileOpenPath)
        Me.Controls.Add(Me.lblSSTName)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgOpenNetCDF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Open NetCDF"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrInputLocDataName As ucrInputTextBox
    Friend WithEvents lblLocationName As Label
    Friend WithEvents ucrInputFilePath As ucrInputTextBox
    Friend WithEvents ucrInputDataName As ucrInputTextBox
    Friend WithEvents cmdOpenDataSet As Button
    Friend WithEvents lblFileOpenPath As Label
    Friend WithEvents lblSSTName As Label
End Class
