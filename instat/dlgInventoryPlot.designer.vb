<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgInventoryPlot
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
        Me.txtPlotName = New System.Windows.Forms.TextBox()
        Me.txtYlabel = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblYLabel = New System.Windows.Forms.Label()
        Me.chkSort = New System.Windows.Forms.CheckBox()
        Me.chkRemoveNA = New System.Windows.Forms.CheckBox()
        Me.txtWetColour = New System.Windows.Forms.TextBox()
        Me.txtDryColour = New System.Windows.Forms.TextBox()
        Me.lblDry = New System.Windows.Forms.Label()
        Me.lblWet = New System.Windows.Forms.Label()
        Me.lblColour = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'txtPlotName
        '
        Me.txtPlotName.Location = New System.Drawing.Point(119, 12)
        Me.txtPlotName.Name = "txtPlotName"
        Me.txtPlotName.Size = New System.Drawing.Size(219, 20)
        Me.txtPlotName.TabIndex = 0
        Me.txtPlotName.Tag = "Plot_Name"
        '
        'txtYlabel
        '
        Me.txtYlabel.Location = New System.Drawing.Point(119, 38)
        Me.txtYlabel.Name = "txtYlabel"
        Me.txtYlabel.Size = New System.Drawing.Size(100, 20)
        Me.txtYlabel.TabIndex = 1
        Me.txtYlabel.Tag = "Ylabel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Tag = "Title"
        Me.Label1.Text = "Title"
        '
        'lblYLabel
        '
        Me.lblYLabel.AutoSize = True
        Me.lblYLabel.Location = New System.Drawing.Point(36, 41)
        Me.lblYLabel.Name = "lblYLabel"
        Me.lblYLabel.Size = New System.Drawing.Size(39, 13)
        Me.lblYLabel.TabIndex = 3
        Me.lblYLabel.Tag = "Y_Label"
        Me.lblYLabel.Text = "Label1"
        '
        'chkSort
        '
        Me.chkSort.AutoSize = True
        Me.chkSort.Location = New System.Drawing.Point(119, 157)
        Me.chkSort.Name = "chkSort"
        Me.chkSort.Size = New System.Drawing.Size(81, 17)
        Me.chkSort.TabIndex = 4
        Me.chkSort.Tag = "Sort"
        Me.chkSort.Text = "CheckBox1"
        Me.chkSort.UseVisualStyleBackColor = True
        '
        'chkRemoveNA
        '
        Me.chkRemoveNA.AutoSize = True
        Me.chkRemoveNA.Location = New System.Drawing.Point(249, 157)
        Me.chkRemoveNA.Name = "chkRemoveNA"
        Me.chkRemoveNA.Size = New System.Drawing.Size(81, 17)
        Me.chkRemoveNA.TabIndex = 5
        Me.chkRemoveNA.Tag = "Remove_NA"
        Me.chkRemoveNA.Text = "CheckBox2"
        Me.chkRemoveNA.UseVisualStyleBackColor = True
        '
        'txtWetColour
        '
        Me.txtWetColour.Location = New System.Drawing.Point(119, 87)
        Me.txtWetColour.Name = "txtWetColour"
        Me.txtWetColour.Size = New System.Drawing.Size(100, 20)
        Me.txtWetColour.TabIndex = 7
        Me.txtWetColour.Tag = "Wet"
        '
        'txtDryColour
        '
        Me.txtDryColour.Location = New System.Drawing.Point(301, 87)
        Me.txtDryColour.Name = "txtDryColour"
        Me.txtDryColour.Size = New System.Drawing.Size(100, 20)
        Me.txtDryColour.TabIndex = 8
        Me.txtDryColour.Tag = "Dry"
        '
        'lblDry
        '
        Me.lblDry.AutoSize = True
        Me.lblDry.Location = New System.Drawing.Point(233, 90)
        Me.lblDry.Name = "lblDry"
        Me.lblDry.Size = New System.Drawing.Size(39, 13)
        Me.lblDry.TabIndex = 9
        Me.lblDry.Tag = "Dry"
        Me.lblDry.Text = "Label2"
        '
        'lblWet
        '
        Me.lblWet.AutoSize = True
        Me.lblWet.Location = New System.Drawing.Point(52, 90)
        Me.lblWet.Name = "lblWet"
        Me.lblWet.Size = New System.Drawing.Size(39, 13)
        Me.lblWet.TabIndex = 10
        Me.lblWet.Tag = "Wet"
        Me.lblWet.Text = "Label3"
        '
        'lblColour
        '
        Me.lblColour.AutoSize = True
        Me.lblColour.Location = New System.Drawing.Point(66, 65)
        Me.lblColour.Name = "lblColour"
        Me.lblColour.Size = New System.Drawing.Size(37, 13)
        Me.lblColour.TabIndex = 11
        Me.lblColour.Tag = "Colour"
        Me.lblColour.Text = "Colour"
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(27, 217)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 12
        '
        'dlgInventoryPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 268)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblColour)
        Me.Controls.Add(Me.lblWet)
        Me.Controls.Add(Me.lblDry)
        Me.Controls.Add(Me.txtDryColour)
        Me.Controls.Add(Me.txtWetColour)
        Me.Controls.Add(Me.chkRemoveNA)
        Me.Controls.Add(Me.chkSort)
        Me.Controls.Add(Me.lblYLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtYlabel)
        Me.Controls.Add(Me.txtPlotName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgInventoryPlot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Inventory_Plot"
        Me.Text = "Inventory Plot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPlotName As TextBox
    Friend WithEvents txtYlabel As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblYLabel As Label
    Friend WithEvents chkSort As CheckBox
    Friend WithEvents chkRemoveNA As CheckBox
    Friend WithEvents txtWetColour As TextBox
    Friend WithEvents txtDryColour As TextBox
    Friend WithEvents lblDry As Label
    Friend WithEvents lblWet As Label
    Friend WithEvents lblColour As Label
    Friend WithEvents ucrBase As ucrButtons
End Class
