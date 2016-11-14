<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgChiSquareTest
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
        Me.lblLayoutOfData = New System.Windows.Forms.Label()
        Me.cboLayoutOfData = New System.Windows.Forms.ComboBox()
        Me.chkContinuityCorrection = New System.Windows.Forms.CheckBox()
        Me.chkSaveValues = New System.Windows.Forms.CheckBox()
        Me.lblDataColumns = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverChiSquare = New instat.ucrReceiverMultiple()
        Me.ucrAddRemove = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'lblLayoutOfData
        '
        Me.lblLayoutOfData.AutoSize = True
        Me.lblLayoutOfData.Location = New System.Drawing.Point(243, 207)
        Me.lblLayoutOfData.Name = "lblLayoutOfData"
        Me.lblLayoutOfData.Size = New System.Drawing.Size(68, 13)
        Me.lblLayoutOfData.TabIndex = 0
        Me.lblLayoutOfData.Tag = "Data_Layout:"
        Me.lblLayoutOfData.Text = "Data Layout:"
        '
        'cboLayoutOfData
        '
        Me.cboLayoutOfData.FormattingEnabled = True
        Me.cboLayoutOfData.Items.AddRange(New Object() {"Multiple Data Columns", "Data Column and Two Factors", "Column of TABLE Counts"})
        Me.cboLayoutOfData.Location = New System.Drawing.Point(242, 222)
        Me.cboLayoutOfData.Name = "cboLayoutOfData"
        Me.cboLayoutOfData.Size = New System.Drawing.Size(122, 21)
        Me.cboLayoutOfData.TabIndex = 1
        '
        'chkContinuityCorrection
        '
        Me.chkContinuityCorrection.AutoSize = True
        Me.chkContinuityCorrection.Location = New System.Drawing.Point(10, 205)
        Me.chkContinuityCorrection.Name = "chkContinuityCorrection"
        Me.chkContinuityCorrection.Size = New System.Drawing.Size(123, 17)
        Me.chkContinuityCorrection.TabIndex = 4
        Me.chkContinuityCorrection.Tag = "Continuity_Correction"
        Me.chkContinuityCorrection.Text = "Continuity Correction"
        Me.chkContinuityCorrection.UseVisualStyleBackColor = True
        '
        'chkSaveValues
        '
        Me.chkSaveValues.AutoSize = True
        Me.chkSaveValues.Location = New System.Drawing.Point(10, 229)
        Me.chkSaveValues.Name = "chkSaveValues"
        Me.chkSaveValues.Size = New System.Drawing.Size(86, 17)
        Me.chkSaveValues.TabIndex = 5
        Me.chkSaveValues.Tag = "Save_Values"
        Me.chkSaveValues.Text = "Save Values"
        Me.chkSaveValues.UseVisualStyleBackColor = True
        '
        'lblDataColumns
        '
        Me.lblDataColumns.AutoSize = True
        Me.lblDataColumns.Location = New System.Drawing.Point(243, 44)
        Me.lblDataColumns.Name = "lblDataColumns"
        Me.lblDataColumns.Size = New System.Drawing.Size(76, 13)
        Me.lblDataColumns.TabIndex = 6
        Me.lblDataColumns.Tag = "Data_Columns:"
        Me.lblDataColumns.Text = "Data Columns:"
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 251)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 54)
        Me.ucrBase.TabIndex = 3
        '
        'ucrReceiverChiSquare
        '
        Me.ucrReceiverChiSquare.Location = New System.Drawing.Point(242, 60)
        Me.ucrReceiverChiSquare.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverChiSquare.Name = "ucrReceiverChiSquare"
        Me.ucrReceiverChiSquare.Selector = Nothing
        Me.ucrReceiverChiSquare.Size = New System.Drawing.Size(122, 130)
        Me.ucrReceiverChiSquare.TabIndex = 2
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.bShowHiddenColumns = False
        Me.ucrAddRemove.bUseCurrentFilter = True
        Me.ucrAddRemove.Location = New System.Drawing.Point(10, 10)
        Me.ucrAddRemove.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(210, 180)
        Me.ucrAddRemove.TabIndex = 7
        '
        'dlgChiSquareTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 313)
        Me.Controls.Add(Me.ucrAddRemove)
        Me.Controls.Add(Me.lblDataColumns)
        Me.Controls.Add(Me.chkSaveValues)
        Me.Controls.Add(Me.chkContinuityCorrection)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReceiverChiSquare)
        Me.Controls.Add(Me.cboLayoutOfData)
        Me.Controls.Add(Me.lblLayoutOfData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgChiSquareTest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Chi_square_Test"
        Me.Text = "Chi-Square Test"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLayoutOfData As Label
    Friend WithEvents cboLayoutOfData As ComboBox
    Friend WithEvents ucrReceiverChiSquare As ucrReceiverMultiple
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents chkContinuityCorrection As CheckBox
    Friend WithEvents chkSaveValues As CheckBox
    Friend WithEvents lblDataColumns As Label
    Friend WithEvents ucrAddRemove As ucrSelectorByDataFrameAddRemove
End Class
