<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrStub
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lblRowName = New System.Windows.Forms.Label()
        Me.ucrReceiverSingleRowName = New instat.ucrReceiverSingle()
        Me.lblGroupByCol = New System.Windows.Forms.Label()
        Me.ucrReceiverSingleGroupByCol = New instat.ucrReceiverSingle()
        Me.lblStubHeadLabel = New System.Windows.Forms.Label()
        Me.ucrInputStubHead = New instat.ucrInputTextBox()
        Me.ucrSelectorCols = New instat.ucrSelectorByDataFrameAddRemove()
        Me.SuspendLayout()
        '
        'lblRowName
        '
        Me.lblRowName.AutoSize = True
        Me.lblRowName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRowName.Location = New System.Drawing.Point(252, 54)
        Me.lblRowName.Name = "lblRowName"
        Me.lblRowName.Size = New System.Drawing.Size(63, 13)
        Me.lblRowName.TabIndex = 37
        Me.lblRowName.Text = "Row Name:"
        '
        'ucrReceiverSingleRowName
        '
        Me.ucrReceiverSingleRowName.AutoSize = True
        Me.ucrReceiverSingleRowName.frmParent = Nothing
        Me.ucrReceiverSingleRowName.Location = New System.Drawing.Point(255, 67)
        Me.ucrReceiverSingleRowName.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSingleRowName.Name = "ucrReceiverSingleRowName"
        Me.ucrReceiverSingleRowName.Selector = Nothing
        Me.ucrReceiverSingleRowName.Size = New System.Drawing.Size(142, 20)
        Me.ucrReceiverSingleRowName.strNcFilePath = ""
        Me.ucrReceiverSingleRowName.TabIndex = 36
        Me.ucrReceiverSingleRowName.ucrSelector = Nothing
        '
        'lblGroupByCol
        '
        Me.lblGroupByCol.AutoSize = True
        Me.lblGroupByCol.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGroupByCol.Location = New System.Drawing.Point(253, 9)
        Me.lblGroupByCol.Name = "lblGroupByCol"
        Me.lblGroupByCol.Size = New System.Drawing.Size(54, 13)
        Me.lblGroupByCol.TabIndex = 35
        Me.lblGroupByCol.Text = "Group By:"
        '
        'ucrReceiverSingleGroupByCol
        '
        Me.ucrReceiverSingleGroupByCol.AutoSize = True
        Me.ucrReceiverSingleGroupByCol.frmParent = Nothing
        Me.ucrReceiverSingleGroupByCol.Location = New System.Drawing.Point(255, 23)
        Me.ucrReceiverSingleGroupByCol.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSingleGroupByCol.Name = "ucrReceiverSingleGroupByCol"
        Me.ucrReceiverSingleGroupByCol.Selector = Nothing
        Me.ucrReceiverSingleGroupByCol.Size = New System.Drawing.Size(142, 20)
        Me.ucrReceiverSingleGroupByCol.strNcFilePath = ""
        Me.ucrReceiverSingleGroupByCol.TabIndex = 34
        Me.ucrReceiverSingleGroupByCol.ucrSelector = Nothing
        '
        'lblStubHeadLabel
        '
        Me.lblStubHeadLabel.AutoSize = True
        Me.lblStubHeadLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStubHeadLabel.Location = New System.Drawing.Point(253, 100)
        Me.lblStubHeadLabel.Name = "lblStubHeadLabel"
        Me.lblStubHeadLabel.Size = New System.Drawing.Size(85, 13)
        Me.lblStubHeadLabel.TabIndex = 39
        Me.lblStubHeadLabel.Text = "Stubhead Label:"
        '
        'ucrInputStubHead
        '
        Me.ucrInputStubHead.AddQuotesIfUnrecognised = True
        Me.ucrInputStubHead.AutoSize = True
        Me.ucrInputStubHead.IsMultiline = False
        Me.ucrInputStubHead.IsReadOnly = False
        Me.ucrInputStubHead.Location = New System.Drawing.Point(255, 116)
        Me.ucrInputStubHead.Name = "ucrInputStubHead"
        Me.ucrInputStubHead.Size = New System.Drawing.Size(142, 21)
        Me.ucrInputStubHead.TabIndex = 40
        '
        'ucrSelectorCols
        '
        Me.ucrSelectorCols.AutoSize = True
        Me.ucrSelectorCols.bDropUnusedFilterLevels = False
        Me.ucrSelectorCols.bShowHiddenColumns = False
        Me.ucrSelectorCols.bUseCurrentFilter = True
        Me.ucrSelectorCols.Location = New System.Drawing.Point(2, 3)
        Me.ucrSelectorCols.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorCols.Name = "ucrSelectorCols"
        Me.ucrSelectorCols.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorCols.TabIndex = 291
        '
        'ucrStub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrSelectorCols)
        Me.Controls.Add(Me.ucrInputStubHead)
        Me.Controls.Add(Me.lblStubHeadLabel)
        Me.Controls.Add(Me.lblRowName)
        Me.Controls.Add(Me.ucrReceiverSingleRowName)
        Me.Controls.Add(Me.lblGroupByCol)
        Me.Controls.Add(Me.ucrReceiverSingleGroupByCol)
        Me.Name = "ucrStub"
        Me.Size = New System.Drawing.Size(411, 191)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRowName As Label
    Friend WithEvents ucrReceiverSingleRowName As ucrReceiverSingle
    Friend WithEvents lblGroupByCol As Label
    Friend WithEvents ucrReceiverSingleGroupByCol As ucrReceiverSingle
    Friend WithEvents lblStubHeadLabel As Label
    Friend WithEvents ucrInputStubHead As ucrInputTextBox
    Friend WithEvents ucrSelectorCols As ucrSelectorByDataFrameAddRemove
End Class
