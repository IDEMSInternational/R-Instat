<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgChisquare
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
        Me.cboLayoutOfData = New System.Windows.Forms.ComboBox()
        Me.lblLayoutOfData = New System.Windows.Forms.Label()
        Me.chkContinuityCorrections = New System.Windows.Forms.CheckBox()
        Me.ucrReceiverMultiple = New instat.ucrReceiverMultiple()
        Me.lblDataColumns = New System.Windows.Forms.Label()
        Me.chkSaveValues = New System.Windows.Forms.CheckBox()
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(11, 237)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 32)
        Me.ucrBase.TabIndex = 0
        '
        'cboLayoutOfData
        '
        Me.cboLayoutOfData.FormattingEnabled = True
        Me.cboLayoutOfData.Items.AddRange(New Object() {"Multiple data columns"})
        Me.cboLayoutOfData.Location = New System.Drawing.Point(11, 185)
        Me.cboLayoutOfData.Name = "cboLayoutOfData"
        Me.cboLayoutOfData.Size = New System.Drawing.Size(121, 21)
        Me.cboLayoutOfData.TabIndex = 1
        '
        'lblLayoutOfData
        '
        Me.lblLayoutOfData.AutoSize = True
        Me.lblLayoutOfData.Location = New System.Drawing.Point(9, 159)
        Me.lblLayoutOfData.Name = "lblLayoutOfData"
        Me.lblLayoutOfData.Size = New System.Drawing.Size(75, 13)
        Me.lblLayoutOfData.TabIndex = 2
        Me.lblLayoutOfData.Tag = "Layout_of_data"
        Me.lblLayoutOfData.Text = "Layout of data"
        '
        'chkContinuityCorrections
        '
        Me.chkContinuityCorrections.AutoSize = True
        Me.chkContinuityCorrections.Location = New System.Drawing.Point(230, 140)
        Me.chkContinuityCorrections.Name = "chkContinuityCorrections"
        Me.chkContinuityCorrections.Size = New System.Drawing.Size(127, 17)
        Me.chkContinuityCorrections.TabIndex = 3
        Me.chkContinuityCorrections.Tag = "Continuity_corrections"
        Me.chkContinuityCorrections.Text = "Continuity corrections"
        Me.chkContinuityCorrections.UseVisualStyleBackColor = True
        '
        'ucrReceiverMultiple
        '
        Me.ucrReceiverMultiple.Location = New System.Drawing.Point(230, 43)
        Me.ucrReceiverMultiple.Name = "ucrReceiverMultiple"
        Me.ucrReceiverMultiple.Size = New System.Drawing.Size(121, 78)
        Me.ucrReceiverMultiple.TabIndex = 5
        '
        'lblDataColumns
        '
        Me.lblDataColumns.AutoSize = True
        Me.lblDataColumns.Location = New System.Drawing.Point(227, 27)
        Me.lblDataColumns.Name = "lblDataColumns"
        Me.lblDataColumns.Size = New System.Drawing.Size(72, 13)
        Me.lblDataColumns.TabIndex = 2
        Me.lblDataColumns.Tag = "Data_columns"
        Me.lblDataColumns.Text = "Data columns"
        '
        'chkSaveValues
        '
        Me.chkSaveValues.AutoSize = True
        Me.chkSaveValues.Location = New System.Drawing.Point(230, 185)
        Me.chkSaveValues.Name = "chkSaveValues"
        Me.chkSaveValues.Size = New System.Drawing.Size(85, 17)
        Me.chkSaveValues.TabIndex = 6
        Me.chkSaveValues.Tag = "Save_values"
        Me.chkSaveValues.Text = "Save values"
        Me.chkSaveValues.UseVisualStyleBackColor = True
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.Location = New System.Drawing.Point(2, 12)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(203, 127)
        Me.ucrAddRemove.TabIndex = 7
        '
        'dlgChisquare
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 281)
        Me.Controls.Add(Me.ucrAddRemove)
        Me.Controls.Add(Me.chkSaveValues)
        Me.Controls.Add(Me.ucrReceiverMultiple)
        Me.Controls.Add(Me.chkContinuityCorrections)
        Me.Controls.Add(Me.lblDataColumns)
        Me.Controls.Add(Me.lblLayoutOfData)
        Me.Controls.Add(Me.cboLayoutOfData)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgChisquare"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Chi_Square"
        Me.Text = "Chi-Square"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents cboLayoutOfData As ComboBox
    Friend WithEvents lblLayoutOfData As Label
    Friend WithEvents chkContinuityCorrections As CheckBox
    Friend WithEvents ucrReceiverMultiple As ucrReceiverMultiple
    Friend WithEvents lblDataColumns As Label
    Friend WithEvents chkSaveValues As CheckBox
    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
End Class
