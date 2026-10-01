<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrStubOptions
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
        Me.ucrSelectorByDF = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrInputStubHead = New instat.ucrInputTextBox()
        Me.lblStubHeadLabel = New System.Windows.Forms.Label()
        Me.lblRowName = New System.Windows.Forms.Label()
        Me.ucrReceiverSingleRowName = New instat.ucrReceiverSingle()
        Me.lblGroupByCol = New System.Windows.Forms.Label()
        Me.ucrReceiverSingleGroupByCol = New instat.ucrReceiverSingle()
        Me.ucrSelectorByTableDF = New instat.ucrSelectorByOutputObject()
        Me.SuspendLayout()
        '
        'ucrSelectorByDF
        '
        Me.ucrSelectorByDF.AutoSize = True
        Me.ucrSelectorByDF.bDropUnusedFilterLevels = False
        Me.ucrSelectorByDF.bShowHiddenColumns = False
        Me.ucrSelectorByDF.bUseCurrentFilter = True
        Me.ucrSelectorByDF.Location = New System.Drawing.Point(3, 1)
        Me.ucrSelectorByDF.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorByDF.Name = "ucrSelectorByDF"
        Me.ucrSelectorByDF.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorByDF.TabIndex = 1
        '
        'ucrInputStubHead
        '
        Me.ucrInputStubHead.AddQuotesIfUnrecognised = True
        Me.ucrInputStubHead.AutoSize = True
        Me.ucrInputStubHead.IsMultiline = False
        Me.ucrInputStubHead.IsReadOnly = False
        Me.ucrInputStubHead.Location = New System.Drawing.Point(256, 122)
        Me.ucrInputStubHead.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrInputStubHead.Name = "ucrInputStubHead"
        Me.ucrInputStubHead.Size = New System.Drawing.Size(142, 21)
        Me.ucrInputStubHead.TabIndex = 4
        '
        'lblStubHeadLabel
        '
        Me.lblStubHeadLabel.AutoSize = True
        Me.lblStubHeadLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStubHeadLabel.Location = New System.Drawing.Point(254, 106)
        Me.lblStubHeadLabel.Name = "lblStubHeadLabel"
        Me.lblStubHeadLabel.Size = New System.Drawing.Size(133, 13)
        Me.lblStubHeadLabel.TabIndex = 296
        Me.lblStubHeadLabel.Text = "Stubhead Label (Optional):"
        '
        'lblRowName
        '
        Me.lblRowName.AutoSize = True
        Me.lblRowName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRowName.Location = New System.Drawing.Point(254, 16)
        Me.lblRowName.Name = "lblRowName"
        Me.lblRowName.Size = New System.Drawing.Size(63, 13)
        Me.lblRowName.TabIndex = 295
        Me.lblRowName.Text = "Row Name:"
        '
        'ucrReceiverSingleRowName
        '
        Me.ucrReceiverSingleRowName.AutoSize = True
        Me.ucrReceiverSingleRowName.frmParent = Nothing
        Me.ucrReceiverSingleRowName.Location = New System.Drawing.Point(257, 29)
        Me.ucrReceiverSingleRowName.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSingleRowName.Name = "ucrReceiverSingleRowName"
        Me.ucrReceiverSingleRowName.Selector = Nothing
        Me.ucrReceiverSingleRowName.Size = New System.Drawing.Size(142, 20)
        Me.ucrReceiverSingleRowName.strNcFilePath = ""
        Me.ucrReceiverSingleRowName.TabIndex = 2
        Me.ucrReceiverSingleRowName.ucrSelector = Nothing
        '
        'lblGroupByCol
        '
        Me.lblGroupByCol.AutoSize = True
        Me.lblGroupByCol.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGroupByCol.Location = New System.Drawing.Point(253, 61)
        Me.lblGroupByCol.Name = "lblGroupByCol"
        Me.lblGroupByCol.Size = New System.Drawing.Size(102, 13)
        Me.lblGroupByCol.TabIndex = 293
        Me.lblGroupByCol.Text = "Group By (Optional):"
        '
        'ucrReceiverSingleGroupByCol
        '
        Me.ucrReceiverSingleGroupByCol.AutoSize = True
        Me.ucrReceiverSingleGroupByCol.frmParent = Nothing
        Me.ucrReceiverSingleGroupByCol.Location = New System.Drawing.Point(255, 75)
        Me.ucrReceiverSingleGroupByCol.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSingleGroupByCol.Name = "ucrReceiverSingleGroupByCol"
        Me.ucrReceiverSingleGroupByCol.Selector = Nothing
        Me.ucrReceiverSingleGroupByCol.Size = New System.Drawing.Size(142, 20)
        Me.ucrReceiverSingleGroupByCol.strNcFilePath = ""
        Me.ucrReceiverSingleGroupByCol.TabIndex = 3
        Me.ucrReceiverSingleGroupByCol.ucrSelector = Nothing
        '
        'ucrSelectorByTableDF
        '
        Me.ucrSelectorByTableDF.AutoSize = True
        Me.ucrSelectorByTableDF.bShowHiddenColumns = False
        Me.ucrSelectorByTableDF.Location = New System.Drawing.Point(4, 4)
        Me.ucrSelectorByTableDF.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorByTableDF.Name = "ucrSelectorByTableDF"
        Me.ucrSelectorByTableDF.Size = New System.Drawing.Size(216, 194)
        Me.ucrSelectorByTableDF.TabIndex = 376
        '
        'ucrStubOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrSelectorByTableDF)
        Me.Controls.Add(Me.ucrSelectorByDF)
        Me.Controls.Add(Me.ucrInputStubHead)
        Me.Controls.Add(Me.lblStubHeadLabel)
        Me.Controls.Add(Me.lblRowName)
        Me.Controls.Add(Me.ucrReceiverSingleRowName)
        Me.Controls.Add(Me.lblGroupByCol)
        Me.Controls.Add(Me.ucrReceiverSingleGroupByCol)
        Me.Name = "ucrStubOptions"
        Me.Size = New System.Drawing.Size(405, 209)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorByDF As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrInputStubHead As ucrInputTextBox
    Friend WithEvents lblStubHeadLabel As Label
    Friend WithEvents lblRowName As Label
    Friend WithEvents ucrReceiverSingleRowName As ucrReceiverSingle
    Friend WithEvents lblGroupByCol As Label
    Friend WithEvents ucrReceiverSingleGroupByCol As ucrReceiverSingle
    Friend WithEvents ucrSelectorByTableDF As ucrSelectorByOutputObject
End Class
