<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgAppend
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
        Me.components = New System.ComponentModel.Container()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorDataframes = New instat.ucrSelectorAddRemove()
        Me.ucrReceiverAppendDataframe = New instat.ucrReceiverMultiple()
        Me.lblAppendToDataframe = New System.Windows.Forms.Label()
        Me.lblDataframes = New System.Windows.Forms.Label()
        Me.lblIDColNAme = New System.Windows.Forms.Label()
        Me.chkIncludeIDColumn = New System.Windows.Forms.CheckBox()
        Me.ucrInputIDColName = New instat.ucrInputTextBox()
        Me.lblNewDataframeName = New System.Windows.Forms.Label()
        Me.ucrInputNewDataframeName = New instat.ucrInputTextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 292)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(400, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSelectorDataframes
        '
        Me.ucrSelectorDataframes.bShowHiddenColumns = False
        Me.ucrSelectorDataframes.Location = New System.Drawing.Point(9, 31)
        Me.ucrSelectorDataframes.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDataframes.Name = "ucrSelectorDataframes"
        Me.ucrSelectorDataframes.Size = New System.Drawing.Size(195, 193)
        Me.ucrSelectorDataframes.TabIndex = 1
        '
        'ucrReceiverAppendDataframe
        '
        Me.ucrReceiverAppendDataframe.Location = New System.Drawing.Point(246, 31)
        Me.ucrReceiverAppendDataframe.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverAppendDataframe.Name = "ucrReceiverAppendDataframe"
        Me.ucrReceiverAppendDataframe.Selector = Nothing
        Me.ucrReceiverAppendDataframe.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverAppendDataframe.TabIndex = 2
        '
        'lblAppendToDataframe
        '
        Me.lblAppendToDataframe.AutoSize = True
        Me.lblAppendToDataframe.Location = New System.Drawing.Point(243, 9)
        Me.lblAppendToDataframe.Name = "lblAppendToDataframe"
        Me.lblAppendToDataframe.Size = New System.Drawing.Size(112, 13)
        Me.lblAppendToDataframe.TabIndex = 3
        Me.lblAppendToDataframe.Text = "Selected  Data frames"
        '
        'lblDataframes
        '
        Me.lblDataframes.AutoSize = True
        Me.lblDataframes.Location = New System.Drawing.Point(9, 9)
        Me.lblDataframes.Name = "lblDataframes"
        Me.lblDataframes.Size = New System.Drawing.Size(64, 13)
        Me.lblDataframes.TabIndex = 4
        Me.lblDataframes.Text = "Data frames"
        '
        'lblIDColNAme
        '
        Me.lblIDColNAme.AutoSize = True
        Me.lblIDColNAme.Location = New System.Drawing.Point(128, 262)
        Me.lblIDColNAme.Name = "lblIDColNAme"
        Me.lblIDColNAme.Size = New System.Drawing.Size(87, 13)
        Me.lblIDColNAme.TabIndex = 3
        Me.lblIDColNAme.Text = "ID Column Name"
        '
        'chkIncludeIDColumn
        '
        Me.chkIncludeIDColumn.AutoSize = True
        Me.chkIncludeIDColumn.Location = New System.Drawing.Point(9, 262)
        Me.chkIncludeIDColumn.Name = "chkIncludeIDColumn"
        Me.chkIncludeIDColumn.Size = New System.Drawing.Size(113, 17)
        Me.chkIncludeIDColumn.TabIndex = 5
        Me.chkIncludeIDColumn.Text = "Include ID Column"
        Me.chkIncludeIDColumn.UseVisualStyleBackColor = True
        '
        'ucrInputIDColName
        '
        Me.ucrInputIDColName.IsReadOnly = False
        Me.ucrInputIDColName.Location = New System.Drawing.Point(221, 258)
        Me.ucrInputIDColName.Name = "ucrInputIDColName"
        Me.ucrInputIDColName.Size = New System.Drawing.Size(143, 21)
        Me.ucrInputIDColName.TabIndex = 6
        '
        'lblNewDataframeName
        '
        Me.lblNewDataframeName.AutoSize = True
        Me.lblNewDataframeName.Location = New System.Drawing.Point(12, 239)
        Me.lblNewDataframeName.Name = "lblNewDataframeName"
        Me.lblNewDataframeName.Size = New System.Drawing.Size(115, 13)
        Me.lblNewDataframeName.TabIndex = 7
        Me.lblNewDataframeName.Text = "New Data frame Name"
        '
        'ucrInputNewDataframeName
        '
        Me.ucrInputNewDataframeName.IsReadOnly = False
        Me.ucrInputNewDataframeName.Location = New System.Drawing.Point(131, 231)
        Me.ucrInputNewDataframeName.Name = "ucrInputNewDataframeName"
        Me.ucrInputNewDataframeName.Size = New System.Drawing.Size(235, 21)
        Me.ucrInputNewDataframeName.TabIndex = 8
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(7, 79)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 9
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(131, 79)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(200, 100)
        Me.TabControl1.TabIndex = 10
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(192, 74)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(192, 74)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dlgAppend
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 356)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ucrInputNewDataframeName)
        Me.Controls.Add(Me.lblNewDataframeName)
        Me.Controls.Add(Me.ucrInputIDColName)
        Me.Controls.Add(Me.chkIncludeIDColumn)
        Me.Controls.Add(Me.lblDataframes)
        Me.Controls.Add(Me.lblIDColNAme)
        Me.Controls.Add(Me.lblAppendToDataframe)
        Me.Controls.Add(Me.ucrReceiverAppendDataframe)
        Me.Controls.Add(Me.ucrSelectorDataframes)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgAppend"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Append_to_Dataframe"
        Me.Text = "Append to Dataframe"
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorDataframes As ucrSelectorAddRemove
    Friend WithEvents ucrReceiverAppendDataframe As ucrReceiverMultiple
    Friend WithEvents lblAppendToDataframe As Label
    Friend WithEvents lblDataframes As Label
    Friend WithEvents lblIDColNAme As Label
    Friend WithEvents chkIncludeIDColumn As CheckBox
    Friend WithEvents ucrInputIDColName As ucrInputTextBox
    Friend WithEvents lblNewDataframeName As Label
    Friend WithEvents ucrInputNewDataframeName As ucrInputTextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
End Class
