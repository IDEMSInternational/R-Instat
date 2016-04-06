<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcrGeomListWithParameters
    Inherits instat.UcrGeoms

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.UcrSelectorByDataFrameAddRemove1 = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblAesList = New System.Windows.Forms.Label()
        Me.UcrReceiverSingle1 = New instat.ucrReceiverSingle()
        Me.UcrReceiverSingle2 = New instat.ucrReceiverSingle()
        Me.UcrReceiverSingle3 = New instat.ucrReceiverSingle()
        Me.UcrReceiverSingle4 = New instat.ucrReceiverSingle()
        Me.UcrReceiverSingle5 = New instat.ucrReceiverSingle()
        Me.grpAesList = New System.Windows.Forms.GroupBox()
        Me.grpAesList.SuspendLayout()
        Me.SuspendLayout()
        '
        'UcrSelectorByDataFrameAddRemove1
        '
        Me.UcrSelectorByDataFrameAddRemove1.Location = New System.Drawing.Point(7, 69)
        Me.UcrSelectorByDataFrameAddRemove1.Name = "UcrSelectorByDataFrameAddRemove1"
        Me.UcrSelectorByDataFrameAddRemove1.Size = New System.Drawing.Size(242, 179)
        Me.UcrSelectorByDataFrameAddRemove1.TabIndex = 5
        '
        'lblAesList
        '
        Me.lblAesList.AutoSize = True
        Me.lblAesList.Location = New System.Drawing.Point(256, 69)
        Me.lblAesList.Name = "lblAesList"
        Me.lblAesList.Size = New System.Drawing.Size(0, 13)
        Me.lblAesList.TabIndex = 6
        '
        'UcrReceiverSingle1
        '
        Me.UcrReceiverSingle1.Location = New System.Drawing.Point(107, 13)
        Me.UcrReceiverSingle1.Name = "UcrReceiverSingle1"
        Me.UcrReceiverSingle1.Selector = Nothing
        Me.UcrReceiverSingle1.Size = New System.Drawing.Size(106, 26)
        Me.UcrReceiverSingle1.TabIndex = 8
        '
        'UcrReceiverSingle2
        '
        Me.UcrReceiverSingle2.Location = New System.Drawing.Point(107, 39)
        Me.UcrReceiverSingle2.Name = "UcrReceiverSingle2"
        Me.UcrReceiverSingle2.Selector = Nothing
        Me.UcrReceiverSingle2.Size = New System.Drawing.Size(106, 26)
        Me.UcrReceiverSingle2.TabIndex = 8
        '
        'UcrReceiverSingle3
        '
        Me.UcrReceiverSingle3.Location = New System.Drawing.Point(107, 69)
        Me.UcrReceiverSingle3.Name = "UcrReceiverSingle3"
        Me.UcrReceiverSingle3.Selector = Nothing
        Me.UcrReceiverSingle3.Size = New System.Drawing.Size(106, 26)
        Me.UcrReceiverSingle3.TabIndex = 8
        '
        'UcrReceiverSingle4
        '
        Me.UcrReceiverSingle4.Location = New System.Drawing.Point(107, 96)
        Me.UcrReceiverSingle4.Name = "UcrReceiverSingle4"
        Me.UcrReceiverSingle4.Selector = Nothing
        Me.UcrReceiverSingle4.Size = New System.Drawing.Size(106, 26)
        Me.UcrReceiverSingle4.TabIndex = 8
        '
        'UcrReceiverSingle5
        '
        Me.UcrReceiverSingle5.Location = New System.Drawing.Point(107, 123)
        Me.UcrReceiverSingle5.Name = "UcrReceiverSingle5"
        Me.UcrReceiverSingle5.Selector = Nothing
        Me.UcrReceiverSingle5.Size = New System.Drawing.Size(106, 26)
        Me.UcrReceiverSingle5.TabIndex = 8
        '
        'grpAesList
        '
        Me.grpAesList.Controls.Add(Me.UcrReceiverSingle1)
        Me.grpAesList.Controls.Add(Me.UcrReceiverSingle5)
        Me.grpAesList.Controls.Add(Me.UcrReceiverSingle4)
        Me.grpAesList.Controls.Add(Me.UcrReceiverSingle3)
        Me.grpAesList.Controls.Add(Me.UcrReceiverSingle2)
        Me.grpAesList.Location = New System.Drawing.Point(242, 85)
        Me.grpAesList.Name = "grpAesList"
        Me.grpAesList.Size = New System.Drawing.Size(219, 195)
        Me.grpAesList.TabIndex = 9
        Me.grpAesList.TabStop = False
        Me.grpAesList.Text = "Geom Aesthetics"
        '
        'UcrGeomListWithParameters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.grpAesList)
        Me.Controls.Add(Me.lblAesList)
        Me.Controls.Add(Me.UcrSelectorByDataFrameAddRemove1)
        Me.Name = "UcrGeomListWithParameters"
        Me.Size = New System.Drawing.Size(467, 286)
        Me.Controls.SetChildIndex(Me.UcrSelectorByDataFrameAddRemove1, 0)
        Me.Controls.SetChildIndex(Me.lblAesList, 0)
        Me.Controls.SetChildIndex(Me.grpAesList, 0)
        Me.grpAesList.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UcrSelectorByDataFrameAddRemove1 As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblAesList As Label
    Friend WithEvents UcrReceiverSingle1 As ucrReceiverSingle
    Friend WithEvents UcrReceiverSingle2 As ucrReceiverSingle
    Friend WithEvents UcrReceiverSingle3 As ucrReceiverSingle
    Friend WithEvents UcrReceiverSingle4 As ucrReceiverSingle
    Friend WithEvents UcrReceiverSingle5 As ucrReceiverSingle
    Friend WithEvents grpAesList As GroupBox
End Class
