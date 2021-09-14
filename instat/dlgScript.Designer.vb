<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgScript
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
        Me.lblPackage = New System.Windows.Forms.Label()
        Me.lblNewName = New System.Windows.Forms.Label()
        Me.btnGetDataFrame = New System.Windows.Forms.Button()
        Me.btnGetPackage = New System.Windows.Forms.Button()
        Me.btnNewDataframe = New System.Windows.Forms.Button()
        Me.ucrInputNewDataFrame = New instat.ucrInputTextBox()
        Me.ucrComboGetPackage = New instat.ucrInputComboBox()
        Me.ucrInputCommand = New instat.ucrInputTextBox()
        Me.ucrDataFrameGet = New instat.ucrDataFrame()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverGetCol = New instat.ucrReceiverSingle()
        Me.lblGetColumn = New System.Windows.Forms.Label()
        Me.btnGetColumn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPackage
        '
        Me.lblPackage.AutoSize = True
        Me.lblPackage.Location = New System.Drawing.Point(12, 26)
        Me.lblPackage.Name = "lblPackage"
        Me.lblPackage.Size = New System.Drawing.Size(73, 13)
        Me.lblPackage.TabIndex = 19
        Me.lblPackage.Text = "Get Package:"
        '
        'lblNewName
        '
        Me.lblNewName.AutoSize = True
        Me.lblNewName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNewName.Location = New System.Drawing.Point(12, 197)
        Me.lblNewName.Name = "lblNewName"
        Me.lblNewName.Size = New System.Drawing.Size(111, 13)
        Me.lblNewName.TabIndex = 21
        Me.lblNewName.Tag = ""
        Me.lblNewName.Text = "Write new data frame:"
        '
        'btnGetDataFrame
        '
        Me.btnGetDataFrame.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnGetDataFrame.Location = New System.Drawing.Point(182, 93)
        Me.btnGetDataFrame.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnGetDataFrame.Name = "btnGetDataFrame"
        Me.btnGetDataFrame.Size = New System.Drawing.Size(74, 23)
        Me.btnGetDataFrame.TabIndex = 23
        Me.btnGetDataFrame.Text = "Add"
        Me.btnGetDataFrame.UseVisualStyleBackColor = True
        '
        'btnGetPackage
        '
        Me.btnGetPackage.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnGetPackage.Location = New System.Drawing.Point(182, 42)
        Me.btnGetPackage.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnGetPackage.Name = "btnGetPackage"
        Me.btnGetPackage.Size = New System.Drawing.Size(74, 23)
        Me.btnGetPackage.TabIndex = 24
        Me.btnGetPackage.Text = "Add"
        Me.btnGetPackage.UseVisualStyleBackColor = True
        '
        'btnNewDataframe
        '
        Me.btnNewDataframe.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnNewDataframe.Location = New System.Drawing.Point(185, 211)
        Me.btnNewDataframe.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnNewDataframe.Name = "btnNewDataframe"
        Me.btnNewDataframe.Size = New System.Drawing.Size(74, 23)
        Me.btnNewDataframe.TabIndex = 25
        Me.btnNewDataframe.Text = "Add"
        Me.btnNewDataframe.UseVisualStyleBackColor = True
        '
        'ucrInputNewDataFrame
        '
        Me.ucrInputNewDataFrame.AddQuotesIfUnrecognised = True
        Me.ucrInputNewDataFrame.IsMultiline = False
        Me.ucrInputNewDataFrame.IsReadOnly = False
        Me.ucrInputNewDataFrame.Location = New System.Drawing.Point(12, 213)
        Me.ucrInputNewDataFrame.Name = "ucrInputNewDataFrame"
        Me.ucrInputNewDataFrame.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputNewDataFrame.TabIndex = 22
        '
        'ucrComboGetPackage
        '
        Me.ucrComboGetPackage.AddQuotesIfUnrecognised = True
        Me.ucrComboGetPackage.GetSetSelectedIndex = -1
        Me.ucrComboGetPackage.IsReadOnly = False
        Me.ucrComboGetPackage.Location = New System.Drawing.Point(15, 42)
        Me.ucrComboGetPackage.Name = "ucrComboGetPackage"
        Me.ucrComboGetPackage.Size = New System.Drawing.Size(137, 21)
        Me.ucrComboGetPackage.TabIndex = 20
        '
        'ucrInputCommand
        '
        Me.ucrInputCommand.AddQuotesIfUnrecognised = True
        Me.ucrInputCommand.IsMultiline = True
        Me.ucrInputCommand.IsReadOnly = False
        Me.ucrInputCommand.Location = New System.Drawing.Point(295, 11)
        Me.ucrInputCommand.Name = "ucrInputCommand"
        Me.ucrInputCommand.Size = New System.Drawing.Size(443, 418)
        Me.ucrInputCommand.TabIndex = 18
        '
        'ucrDataFrameGet
        '
        Me.ucrDataFrameGet.bDropUnusedFilterLevels = False
        Me.ucrDataFrameGet.bUseCurrentFilter = True
        Me.ucrDataFrameGet.Location = New System.Drawing.Point(13, 75)
        Me.ucrDataFrameGet.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataFrameGet.Name = "ucrDataFrameGet"
        Me.ucrDataFrameGet.Size = New System.Drawing.Size(148, 50)
        Me.ucrDataFrameGet.TabIndex = 17
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(112, 437)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(416, 57)
        Me.ucrBase.TabIndex = 16
        '
        'ucrReceiverGetCol
        '
        Me.ucrReceiverGetCol.frmParent = Me
        Me.ucrReceiverGetCol.Location = New System.Drawing.Point(12, 155)
        Me.ucrReceiverGetCol.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverGetCol.Name = "ucrReceiverGetCol"
        Me.ucrReceiverGetCol.Selector = Nothing
        Me.ucrReceiverGetCol.Size = New System.Drawing.Size(158, 20)
        Me.ucrReceiverGetCol.strNcFilePath = ""
        Me.ucrReceiverGetCol.TabIndex = 27
        Me.ucrReceiverGetCol.ucrSelector = Nothing
        '
        'lblGetColumn
        '
        Me.lblGetColumn.AutoSize = True
        Me.lblGetColumn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGetColumn.Location = New System.Drawing.Point(14, 140)
        Me.lblGetColumn.Name = "lblGetColumn"
        Me.lblGetColumn.Size = New System.Drawing.Size(45, 13)
        Me.lblGetColumn.TabIndex = 26
        Me.lblGetColumn.Text = "Column:"
        '
        'btnGetColumn
        '
        Me.btnGetColumn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnGetColumn.Location = New System.Drawing.Point(182, 155)
        Me.btnGetColumn.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnGetColumn.Name = "btnGetColumn"
        Me.btnGetColumn.Size = New System.Drawing.Size(74, 23)
        Me.btnGetColumn.TabIndex = 28
        Me.btnGetColumn.Text = "Add"
        Me.btnGetColumn.UseVisualStyleBackColor = True
        '
        'dlgScript
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 501)
        Me.Controls.Add(Me.btnGetColumn)
        Me.Controls.Add(Me.ucrReceiverGetCol)
        Me.Controls.Add(Me.lblGetColumn)
        Me.Controls.Add(Me.btnNewDataframe)
        Me.Controls.Add(Me.btnGetPackage)
        Me.Controls.Add(Me.btnGetDataFrame)
        Me.Controls.Add(Me.ucrInputNewDataFrame)
        Me.Controls.Add(Me.lblNewName)
        Me.Controls.Add(Me.lblPackage)
        Me.Controls.Add(Me.ucrComboGetPackage)
        Me.Controls.Add(Me.ucrInputCommand)
        Me.Controls.Add(Me.ucrDataFrameGet)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgScript"
        Me.Text = "Script"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrDataFrameGet As ucrDataFrame
    Friend WithEvents ucrInputCommand As ucrInputTextBox
    Friend WithEvents lblPackage As Label
    Friend WithEvents ucrComboGetPackage As ucrInputComboBox
    Friend WithEvents ucrInputNewDataFrame As ucrInputTextBox
    Friend WithEvents lblNewName As Label
    Friend WithEvents btnGetDataFrame As Button
    Friend WithEvents btnGetPackage As Button
    Friend WithEvents btnNewDataframe As Button
    Friend WithEvents ucrReceiverGetCol As ucrReceiverSingle
    Friend WithEvents btnGetColumn As Button
    Friend WithEvents lblGetColumn As Label
End Class
