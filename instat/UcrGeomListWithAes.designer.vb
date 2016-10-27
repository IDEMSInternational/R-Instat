<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UcrGeomListWithParameters
    Inherits instat.ucrGeom

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.UcrSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblAesList = New System.Windows.Forms.Label()
        Me.ucrReceiverParam1 = New instat.ucrReceiverSingle()
        Me.ucrReceiverParam2 = New instat.ucrReceiverSingle()
        Me.ucrReceiverParam3 = New instat.ucrReceiverSingle()
        Me.ucrReceiverParam4 = New instat.ucrReceiverSingle()
        Me.ucrReceiverParam5 = New instat.ucrReceiverSingle()
        Me.grpAesList = New System.Windows.Forms.GroupBox()
        Me.lblGgParam6 = New System.Windows.Forms.Label()
        Me.lblGgParam10 = New System.Windows.Forms.Label()
        Me.lblGgParam9 = New System.Windows.Forms.Label()
        Me.lblGgParam8 = New System.Windows.Forms.Label()
        Me.lblGgParam7 = New System.Windows.Forms.Label()
        Me.lblGgParam5 = New System.Windows.Forms.Label()
        Me.lblGgParam4 = New System.Windows.Forms.Label()
        Me.lblGgParam3 = New System.Windows.Forms.Label()
        Me.lblGgParam2 = New System.Windows.Forms.Label()
        Me.lblGgParam1 = New System.Windows.Forms.Label()
        Me.ucrReceiverParam10 = New instat.ucrReceiverSingle()
        Me.ucrReceiverParam9 = New instat.ucrReceiverSingle()
        Me.ucrReceiverParam8 = New instat.ucrReceiverSingle()
        Me.ucrReceiverParam7 = New instat.ucrReceiverSingle()
        Me.ucrReceiverParam6 = New instat.ucrReceiverSingle()
        Me.chkApplyOnAllLayers = New System.Windows.Forms.CheckBox()
        Me.chkIgnoreGlobalAes = New System.Windows.Forms.CheckBox()
        Me.grpAesList.SuspendLayout()
        Me.SuspendLayout()
        '
        'UcrSelector
        '
        Me.UcrSelector.bShowHiddenColumns = False
        Me.UcrSelector.bUseCurrentFilter = False
        Me.UcrSelector.Location = New System.Drawing.Point(3, 56)
        Me.UcrSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrSelector.Name = "UcrSelector"
        Me.UcrSelector.Size = New System.Drawing.Size(232, 192)
        Me.UcrSelector.TabIndex = 5
        '
        'lblAesList
        '
        Me.lblAesList.AutoSize = True
        Me.lblAesList.Location = New System.Drawing.Point(256, 69)
        Me.lblAesList.Name = "lblAesList"
        Me.lblAesList.Size = New System.Drawing.Size(0, 13)
        Me.lblAesList.TabIndex = 6
        '
        'ucrReceiverParam1
        '
        Me.ucrReceiverParam1.Location = New System.Drawing.Point(98, 25)
        Me.ucrReceiverParam1.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverParam1.Name = "ucrReceiverParam1"
        Me.ucrReceiverParam1.Selector = Nothing
        Me.ucrReceiverParam1.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverParam1.TabIndex = 8
        '
        'ucrReceiverParam2
        '
        Me.ucrReceiverParam2.Location = New System.Drawing.Point(98, 53)
        Me.ucrReceiverParam2.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverParam2.Name = "ucrReceiverParam2"
        Me.ucrReceiverParam2.Selector = Nothing
        Me.ucrReceiverParam2.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverParam2.TabIndex = 8
        '
        'ucrReceiverParam3
        '
        Me.ucrReceiverParam3.Location = New System.Drawing.Point(98, 81)
        Me.ucrReceiverParam3.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverParam3.Name = "ucrReceiverParam3"
        Me.ucrReceiverParam3.Selector = Nothing
        Me.ucrReceiverParam3.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverParam3.TabIndex = 8
        '
        'ucrReceiverParam4
        '
        Me.ucrReceiverParam4.Location = New System.Drawing.Point(98, 109)
        Me.ucrReceiverParam4.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverParam4.Name = "ucrReceiverParam4"
        Me.ucrReceiverParam4.Selector = Nothing
        Me.ucrReceiverParam4.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverParam4.TabIndex = 8
        '
        'ucrReceiverParam5
        '
        Me.ucrReceiverParam5.Location = New System.Drawing.Point(98, 137)
        Me.ucrReceiverParam5.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverParam5.Name = "ucrReceiverParam5"
        Me.ucrReceiverParam5.Selector = Nothing
        Me.ucrReceiverParam5.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverParam5.TabIndex = 8
        '
        'grpAesList
        '
        Me.grpAesList.Controls.Add(Me.lblGgParam6)
        Me.grpAesList.Controls.Add(Me.lblGgParam10)
        Me.grpAesList.Controls.Add(Me.lblGgParam9)
        Me.grpAesList.Controls.Add(Me.lblGgParam8)
        Me.grpAesList.Controls.Add(Me.lblGgParam7)
        Me.grpAesList.Controls.Add(Me.lblGgParam5)
        Me.grpAesList.Controls.Add(Me.lblGgParam4)
        Me.grpAesList.Controls.Add(Me.lblGgParam3)
        Me.grpAesList.Controls.Add(Me.lblGgParam2)
        Me.grpAesList.Controls.Add(Me.lblGgParam1)
        Me.grpAesList.Controls.Add(Me.ucrReceiverParam10)
        Me.grpAesList.Controls.Add(Me.ucrReceiverParam9)
        Me.grpAesList.Controls.Add(Me.ucrReceiverParam8)
        Me.grpAesList.Controls.Add(Me.ucrReceiverParam1)
        Me.grpAesList.Controls.Add(Me.ucrReceiverParam7)
        Me.grpAesList.Controls.Add(Me.ucrReceiverParam5)
        Me.grpAesList.Controls.Add(Me.ucrReceiverParam6)
        Me.grpAesList.Controls.Add(Me.ucrReceiverParam4)
        Me.grpAesList.Controls.Add(Me.ucrReceiverParam3)
        Me.grpAesList.Controls.Add(Me.ucrReceiverParam2)
        Me.grpAesList.Location = New System.Drawing.Point(242, 19)
        Me.grpAesList.Name = "grpAesList"
        Me.grpAesList.Size = New System.Drawing.Size(219, 296)
        Me.grpAesList.TabIndex = 9
        Me.grpAesList.TabStop = False
        Me.grpAesList.Text = "Geom Aesthetics"
        '
        'lblGgParam6
        '
        Me.lblGgParam6.AutoSize = True
        Me.lblGgParam6.Location = New System.Drawing.Point(7, 165)
        Me.lblGgParam6.Name = "lblGgParam6"
        Me.lblGgParam6.Size = New System.Drawing.Size(29, 13)
        Me.lblGgParam6.TabIndex = 10
        Me.lblGgParam6.Text = "label"
        '
        'lblGgParam10
        '
        Me.lblGgParam10.AutoSize = True
        Me.lblGgParam10.Location = New System.Drawing.Point(6, 267)
        Me.lblGgParam10.Name = "lblGgParam10"
        Me.lblGgParam10.Size = New System.Drawing.Size(39, 13)
        Me.lblGgParam10.TabIndex = 10
        Me.lblGgParam10.Text = "Label2"
        '
        'lblGgParam9
        '
        Me.lblGgParam9.AutoSize = True
        Me.lblGgParam9.Location = New System.Drawing.Point(7, 241)
        Me.lblGgParam9.Name = "lblGgParam9"
        Me.lblGgParam9.Size = New System.Drawing.Size(39, 13)
        Me.lblGgParam9.TabIndex = 10
        Me.lblGgParam9.Text = "Label2"
        '
        'lblGgParam8
        '
        Me.lblGgParam8.AutoSize = True
        Me.lblGgParam8.Location = New System.Drawing.Point(6, 216)
        Me.lblGgParam8.Name = "lblGgParam8"
        Me.lblGgParam8.Size = New System.Drawing.Size(39, 13)
        Me.lblGgParam8.TabIndex = 10
        Me.lblGgParam8.Text = "Label2"
        '
        'lblGgParam7
        '
        Me.lblGgParam7.AutoSize = True
        Me.lblGgParam7.Location = New System.Drawing.Point(7, 193)
        Me.lblGgParam7.Name = "lblGgParam7"
        Me.lblGgParam7.Size = New System.Drawing.Size(39, 13)
        Me.lblGgParam7.TabIndex = 10
        Me.lblGgParam7.Text = "Label2"
        '
        'lblGgParam5
        '
        Me.lblGgParam5.AutoSize = True
        Me.lblGgParam5.Location = New System.Drawing.Point(7, 137)
        Me.lblGgParam5.Name = "lblGgParam5"
        Me.lblGgParam5.Size = New System.Drawing.Size(39, 13)
        Me.lblGgParam5.TabIndex = 10
        Me.lblGgParam5.Text = "Label2"
        '
        'lblGgParam4
        '
        Me.lblGgParam4.AutoSize = True
        Me.lblGgParam4.Location = New System.Drawing.Point(7, 109)
        Me.lblGgParam4.Name = "lblGgParam4"
        Me.lblGgParam4.Size = New System.Drawing.Size(39, 13)
        Me.lblGgParam4.TabIndex = 10
        Me.lblGgParam4.Text = "Label2"
        '
        'lblGgParam3
        '
        Me.lblGgParam3.AutoSize = True
        Me.lblGgParam3.Location = New System.Drawing.Point(7, 81)
        Me.lblGgParam3.Name = "lblGgParam3"
        Me.lblGgParam3.Size = New System.Drawing.Size(39, 13)
        Me.lblGgParam3.TabIndex = 10
        Me.lblGgParam3.Text = "Label2"
        '
        'lblGgParam2
        '
        Me.lblGgParam2.AutoSize = True
        Me.lblGgParam2.Location = New System.Drawing.Point(7, 53)
        Me.lblGgParam2.Name = "lblGgParam2"
        Me.lblGgParam2.Size = New System.Drawing.Size(39, 13)
        Me.lblGgParam2.TabIndex = 10
        Me.lblGgParam2.Text = "Label2"
        '
        'lblGgParam1
        '
        Me.lblGgParam1.AutoSize = True
        Me.lblGgParam1.Location = New System.Drawing.Point(7, 25)
        Me.lblGgParam1.Name = "lblGgParam1"
        Me.lblGgParam1.Size = New System.Drawing.Size(39, 13)
        Me.lblGgParam1.TabIndex = 9
        Me.lblGgParam1.Text = "Label1"
        '
        'ucrReceiverParam10
        '
        Me.ucrReceiverParam10.Location = New System.Drawing.Point(97, 267)
        Me.ucrReceiverParam10.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverParam10.Name = "ucrReceiverParam10"
        Me.ucrReceiverParam10.Selector = Nothing
        Me.ucrReceiverParam10.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverParam10.TabIndex = 8
        '
        'ucrReceiverParam9
        '
        Me.ucrReceiverParam9.Location = New System.Drawing.Point(98, 241)
        Me.ucrReceiverParam9.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverParam9.Name = "ucrReceiverParam9"
        Me.ucrReceiverParam9.Selector = Nothing
        Me.ucrReceiverParam9.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverParam9.TabIndex = 8
        '
        'ucrReceiverParam8
        '
        Me.ucrReceiverParam8.Location = New System.Drawing.Point(97, 216)
        Me.ucrReceiverParam8.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverParam8.Name = "ucrReceiverParam8"
        Me.ucrReceiverParam8.Selector = Nothing
        Me.ucrReceiverParam8.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverParam8.TabIndex = 8
        '
        'ucrReceiverParam7
        '
        Me.ucrReceiverParam7.Location = New System.Drawing.Point(98, 193)
        Me.ucrReceiverParam7.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverParam7.Name = "ucrReceiverParam7"
        Me.ucrReceiverParam7.Selector = Nothing
        Me.ucrReceiverParam7.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverParam7.TabIndex = 8
        '
        'ucrReceiverParam6
        '
        Me.ucrReceiverParam6.Location = New System.Drawing.Point(98, 165)
        Me.ucrReceiverParam6.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverParam6.Name = "ucrReceiverParam6"
        Me.ucrReceiverParam6.Selector = Nothing
        Me.ucrReceiverParam6.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverParam6.TabIndex = 8
        '
        'chkApplyOnAllLayers
        '
        Me.chkApplyOnAllLayers.AutoSize = True
        Me.chkApplyOnAllLayers.Location = New System.Drawing.Point(3, 245)
        Me.chkApplyOnAllLayers.Name = "chkApplyOnAllLayers"
        Me.chkApplyOnAllLayers.Size = New System.Drawing.Size(117, 17)
        Me.chkApplyOnAllLayers.TabIndex = 10
        Me.chkApplyOnAllLayers.Text = "Apply On All Layers"
        Me.chkApplyOnAllLayers.UseVisualStyleBackColor = True
        '
        'chkIgnoreGlobalAes
        '
        Me.chkIgnoreGlobalAes.AutoSize = True
        Me.chkIgnoreGlobalAes.Location = New System.Drawing.Point(3, 266)
        Me.chkIgnoreGlobalAes.Name = "chkIgnoreGlobalAes"
        Me.chkIgnoreGlobalAes.Size = New System.Drawing.Size(141, 17)
        Me.chkIgnoreGlobalAes.TabIndex = 11
        Me.chkIgnoreGlobalAes.Text = "Ignore Global Aesthetics"
        Me.chkIgnoreGlobalAes.UseVisualStyleBackColor = True
        '
        'UcrGeomListWithParameters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.chkIgnoreGlobalAes)
        Me.Controls.Add(Me.chkApplyOnAllLayers)
        Me.Controls.Add(Me.grpAesList)
        Me.Controls.Add(Me.lblAesList)
        Me.Controls.Add(Me.UcrSelector)
        Me.Name = "UcrGeomListWithParameters"
        Me.Size = New System.Drawing.Size(467, 317)
        Me.Controls.SetChildIndex(Me.UcrSelector, 0)
        Me.Controls.SetChildIndex(Me.lblAesList, 0)
        Me.Controls.SetChildIndex(Me.grpAesList, 0)
        Me.Controls.SetChildIndex(Me.chkApplyOnAllLayers, 0)
        Me.Controls.SetChildIndex(Me.chkIgnoreGlobalAes, 0)
        Me.grpAesList.ResumeLayout(False)
        Me.grpAesList.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UcrSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblAesList As Label
    Friend WithEvents ucrReceiverParam1 As ucrReceiverSingle
    Friend WithEvents ucrReceiverParam2 As ucrReceiverSingle
    Friend WithEvents ucrReceiverParam3 As ucrReceiverSingle
    Friend WithEvents ucrReceiverParam4 As ucrReceiverSingle
    Friend WithEvents ucrReceiverParam5 As ucrReceiverSingle
    Friend WithEvents grpAesList As GroupBox
    Friend WithEvents ucrReceiverParam7 As ucrReceiverSingle
    Friend WithEvents ucrReceiverParam6 As ucrReceiverSingle
    Friend WithEvents lblGgParam6 As Label
    Friend WithEvents lblGgParam7 As Label
    Friend WithEvents lblGgParam5 As Label
    Friend WithEvents lblGgParam4 As Label
    Friend WithEvents lblGgParam3 As Label
    Friend WithEvents lblGgParam2 As Label
    Friend WithEvents lblGgParam1 As Label
    Friend WithEvents lblGgParam9 As Label
    Friend WithEvents lblGgParam8 As Label
    Friend WithEvents ucrReceiverParam9 As ucrReceiverSingle
    Friend WithEvents ucrReceiverParam8 As ucrReceiverSingle
    Friend WithEvents chkApplyOnAllLayers As CheckBox
    Friend WithEvents chkIgnoreGlobalAes As CheckBox
    Friend WithEvents lblGgParam10 As Label
    Friend WithEvents ucrReceiverParam10 As ucrReceiverSingle
End Class
