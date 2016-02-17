<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgInsertColumn
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
        Me.ucrDataFramesList = New instat.ucrDataFrame()
        Me.txtDefaultData = New System.Windows.Forms.TextBox()
        Me.lblDefaultValues = New System.Windows.Forms.Label()
        Me.lblNumberCols = New System.Windows.Forms.Label()
        Me.lblStartPos = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.txtStartPos = New System.Windows.Forms.TextBox()
        Me.chkPos = New System.Windows.Forms.CheckBox()
        Me.nudPos = New System.Windows.Forms.NumericUpDown()
        Me.nudNumCols = New System.Windows.Forms.NumericUpDown()
        CType(Me.nudPos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNumCols, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ucrDataFramesList
        '
        Me.ucrDataFramesList.Location = New System.Drawing.Point(4, 8)
        Me.ucrDataFramesList.Name = "ucrDataFramesList"
        Me.ucrDataFramesList.Size = New System.Drawing.Size(127, 41)
        Me.ucrDataFramesList.TabIndex = 0
        '
        'txtDefaultData
        '
        Me.txtDefaultData.Location = New System.Drawing.Point(12, 71)
        Me.txtDefaultData.Name = "txtDefaultData"
        Me.txtDefaultData.ReadOnly = True
        Me.txtDefaultData.Size = New System.Drawing.Size(100, 20)
        Me.txtDefaultData.TabIndex = 1
        '
        'lblDefaultValues
        '
        Me.lblDefaultValues.AutoSize = True
        Me.lblDefaultValues.Location = New System.Drawing.Point(9, 51)
        Me.lblDefaultValues.Name = "lblDefaultValues"
        Me.lblDefaultValues.Size = New System.Drawing.Size(75, 13)
        Me.lblDefaultValues.TabIndex = 4
        Me.lblDefaultValues.Text = "Default values"
        '
        'lblNumberCols
        '
        Me.lblNumberCols.AutoSize = True
        Me.lblNumberCols.Location = New System.Drawing.Point(139, 15)
        Me.lblNumberCols.Name = "lblNumberCols"
        Me.lblNumberCols.Size = New System.Drawing.Size(138, 13)
        Me.lblNumberCols.TabIndex = 5
        Me.lblNumberCols.Text = "Number of columns to insert"
        '
        'lblStartPos
        '
        Me.lblStartPos.AutoSize = True
        Me.lblStartPos.Location = New System.Drawing.Point(141, 55)
        Me.lblStartPos.Name = "lblStartPos"
        Me.lblStartPos.Size = New System.Drawing.Size(110, 13)
        Me.lblStartPos.TabIndex = 6
        Me.lblStartPos.Text = "Insert at what position"
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(5, 101)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 7
        '
        'txtStartPos
        '
        Me.txtStartPos.Location = New System.Drawing.Point(144, 75)
        Me.txtStartPos.Name = "txtStartPos"
        Me.txtStartPos.ReadOnly = True
        Me.txtStartPos.Size = New System.Drawing.Size(96, 20)
        Me.txtStartPos.TabIndex = 3
        '
        'chkPos
        '
        Me.chkPos.AutoSize = True
        Me.chkPos.Location = New System.Drawing.Point(247, 78)
        Me.chkPos.Name = "chkPos"
        Me.chkPos.Size = New System.Drawing.Size(101, 17)
        Me.chkPos.TabIndex = 8
        Me.chkPos.Text = "Choose position"
        Me.chkPos.UseVisualStyleBackColor = True
        '
        'nudPos
        '
        Me.nudPos.Location = New System.Drawing.Point(354, 76)
        Me.nudPos.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudPos.Name = "nudPos"
        Me.nudPos.Size = New System.Drawing.Size(36, 20)
        Me.nudPos.TabIndex = 9
        Me.nudPos.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudNumCols
        '
        Me.nudNumCols.Location = New System.Drawing.Point(144, 32)
        Me.nudNumCols.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudNumCols.Name = "nudNumCols"
        Me.nudNumCols.Size = New System.Drawing.Size(96, 20)
        Me.nudNumCols.TabIndex = 10
        Me.nudNumCols.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'dlgInsertColumn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 158)
        Me.Controls.Add(Me.nudNumCols)
        Me.Controls.Add(Me.nudPos)
        Me.Controls.Add(Me.chkPos)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblStartPos)
        Me.Controls.Add(Me.lblNumberCols)
        Me.Controls.Add(Me.lblDefaultValues)
        Me.Controls.Add(Me.txtStartPos)
        Me.Controls.Add(Me.txtDefaultData)
        Me.Controls.Add(Me.ucrDataFramesList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgInsertColumn"
        Me.Text = "Insert Column (s)"
        CType(Me.nudPos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNumCols, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrDataFramesList As ucrDataFrame
    Friend WithEvents txtDefaultData As TextBox
    Friend WithEvents lblDefaultValues As Label
    Friend WithEvents lblNumberCols As Label
    Friend WithEvents lblStartPos As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents txtStartPos As TextBox
    Friend WithEvents chkPos As CheckBox
    Friend WithEvents nudPos As NumericUpDown
    Friend WithEvents nudNumCols As NumericUpDown
End Class
