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
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 290)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(400, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSelectorDataframes
        '
        Me.ucrSelectorDataframes.bShowHiddenColumns = False
        Me.ucrSelectorDataframes.Location = New System.Drawing.Point(10, 31)
        Me.ucrSelectorDataframes.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDataframes.Name = "ucrSelectorDataframes"
        Me.ucrSelectorDataframes.Size = New System.Drawing.Size(195, 197)
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
        Me.lblAppendToDataframe.Text = "Selected Data Frames"
        '
        'lblDataframes
        '
        Me.lblDataframes.AutoSize = True
        Me.lblDataframes.Location = New System.Drawing.Point(10, 9)
        Me.lblDataframes.Name = "lblDataframes"
        Me.lblDataframes.Size = New System.Drawing.Size(67, 13)
        Me.lblDataframes.TabIndex = 4
        Me.lblDataframes.Text = "Data Frames"
        '
        'lblIDColNAme
        '
        Me.lblIDColNAme.AutoSize = True
        Me.lblIDColNAme.Location = New System.Drawing.Point(128, 266)
        Me.lblIDColNAme.Name = "lblIDColNAme"
        Me.lblIDColNAme.Size = New System.Drawing.Size(87, 13)
        Me.lblIDColNAme.TabIndex = 3
        Me.lblIDColNAme.Text = "ID Column Name"
        '
        'chkIncludeIDColumn
        '
        Me.chkIncludeIDColumn.AutoSize = True
        Me.chkIncludeIDColumn.Location = New System.Drawing.Point(10, 265)
        Me.chkIncludeIDColumn.Name = "chkIncludeIDColumn"
        Me.chkIncludeIDColumn.Size = New System.Drawing.Size(113, 17)
        Me.chkIncludeIDColumn.TabIndex = 5
        Me.chkIncludeIDColumn.Text = "Include ID Column"
        Me.chkIncludeIDColumn.UseVisualStyleBackColor = True
        '
        'ucrInputIDColName
        '
        Me.ucrInputIDColName.IsReadOnly = False
        Me.ucrInputIDColName.Location = New System.Drawing.Point(219, 263)
        Me.ucrInputIDColName.Name = "ucrInputIDColName"
        Me.ucrInputIDColName.Size = New System.Drawing.Size(147, 21)
        Me.ucrInputIDColName.TabIndex = 6
        '
        'lblNewDataframeName
        '
        Me.lblNewDataframeName.AutoSize = True
        Me.lblNewDataframeName.Location = New System.Drawing.Point(10, 239)
        Me.lblNewDataframeName.Name = "lblNewDataframeName"
        Me.lblNewDataframeName.Size = New System.Drawing.Size(118, 13)
        Me.lblNewDataframeName.TabIndex = 7
        Me.lblNewDataframeName.Text = "New Data Frame Name"
        '
        'ucrInputNewDataframeName
        '
        Me.ucrInputNewDataframeName.IsReadOnly = False
        Me.ucrInputNewDataframeName.Location = New System.Drawing.Point(131, 236)
        Me.ucrInputNewDataframeName.Name = "ucrInputNewDataframeName"
        Me.ucrInputNewDataframeName.Size = New System.Drawing.Size(235, 21)
        Me.ucrInputNewDataframeName.TabIndex = 8
        '
        'dlgAppend
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 346)
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
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgAppend"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Append_to_Dataframe"
        Me.Text = "Append to Dataframe"
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
End Class
