<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgOpenNetCDF
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
        Me.tbNetCDF = New System.Windows.Forms.TabControl()
        Me.tbOptions = New System.Windows.Forms.TabPage()
        Me.lblX = New System.Windows.Forms.Label()
        Me.lblMinY = New System.Windows.Forms.Label()
        Me.lblMinZ = New System.Windows.Forms.Label()
        Me.lblT = New System.Windows.Forms.Label()
        Me.lblMaxX = New System.Windows.Forms.Label()
        Me.lblMaxY = New System.Windows.Forms.Label()
        Me.lblMaxZ = New System.Windows.Forms.Label()
        Me.lblMinT = New System.Windows.Forms.Label()
        Me.tbSubset = New System.Windows.Forms.TabPage()
        Me.lblMaxT = New System.Windows.Forms.Label()
        Me.dtpMaxT = New System.Windows.Forms.DateTimePicker()
        Me.dtpMinT = New System.Windows.Forms.DateTimePicker()
        Me.lblMinX = New System.Windows.Forms.Label()
        Me.lblY = New System.Windows.Forms.Label()
        Me.lblZ = New System.Windows.Forms.Label()
        Me.lblS = New System.Windows.Forms.Label()
        Me.lblMinS = New System.Windows.Forms.Label()
        Me.lblMaxS = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtonsSubdialogue()
        Me.ucrInputFileDetails = New instat.ucrInputTextBox()
        Me.ucrInputMaxS = New instat.ucrInputTextBox()
        Me.ucrInputMaxZ = New instat.ucrInputTextBox()
        Me.ucrInputMaxY = New instat.ucrInputTextBox()
        Me.ucrInputMaxX = New instat.ucrInputTextBox()
        Me.ucrInputMinS = New instat.ucrInputTextBox()
        Me.ucrInputMinZ = New instat.ucrInputTextBox()
        Me.ucrInputMinY = New instat.ucrInputTextBox()
        Me.ucrInputMinX = New instat.ucrInputTextBox()
        Me.ucrChkOnlyDataVariables = New instat.ucrCheck()
        Me.ucrChkKeepRawTime = New instat.ucrCheck()
        Me.ucrChkIncludeMetadata = New instat.ucrCheck()
        Me.tbNetCDF.SuspendLayout()
        Me.tbOptions.SuspendLayout()
        Me.tbSubset.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbNetCDF
        '
        Me.tbNetCDF.Controls.Add(Me.tbSubset)
        Me.tbNetCDF.Controls.Add(Me.tbOptions)
        Me.tbNetCDF.Location = New System.Drawing.Point(8, 8)
        Me.tbNetCDF.Name = "tbNetCDF"
        Me.tbNetCDF.SelectedIndex = 0
        Me.tbNetCDF.Size = New System.Drawing.Size(483, 423)
        Me.tbNetCDF.TabIndex = 0
        '
        'tbOptions
        '
        Me.tbOptions.Controls.Add(Me.ucrChkOnlyDataVariables)
        Me.tbOptions.Controls.Add(Me.ucrChkKeepRawTime)
        Me.tbOptions.Controls.Add(Me.ucrChkIncludeMetadata)
        Me.tbOptions.Location = New System.Drawing.Point(4, 22)
        Me.tbOptions.Name = "tbOptions"
        Me.tbOptions.Padding = New System.Windows.Forms.Padding(3)
        Me.tbOptions.Size = New System.Drawing.Size(475, 397)
        Me.tbOptions.TabIndex = 1
        Me.tbOptions.Text = "Options"
        Me.tbOptions.UseVisualStyleBackColor = True
        '
        'lblX
        '
        Me.lblX.AutoSize = True
        Me.lblX.Location = New System.Drawing.Point(8, 177)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(17, 13)
        Me.lblX.TabIndex = 1
        Me.lblX.Text = "X:"
        '
        'lblMinY
        '
        Me.lblMinY.AutoSize = True
        Me.lblMinY.Location = New System.Drawing.Point(120, 204)
        Me.lblMinY.Name = "lblMinY"
        Me.lblMinY.Size = New System.Drawing.Size(27, 13)
        Me.lblMinY.TabIndex = 7
        Me.lblMinY.Text = "Min:"
        '
        'lblMinZ
        '
        Me.lblMinZ.AutoSize = True
        Me.lblMinZ.Location = New System.Drawing.Point(120, 231)
        Me.lblMinZ.Name = "lblMinZ"
        Me.lblMinZ.Size = New System.Drawing.Size(27, 13)
        Me.lblMinZ.TabIndex = 12
        Me.lblMinZ.Text = "Min:"
        '
        'lblT
        '
        Me.lblT.AutoSize = True
        Me.lblT.Location = New System.Drawing.Point(8, 285)
        Me.lblT.Name = "lblT"
        Me.lblT.Size = New System.Drawing.Size(17, 13)
        Me.lblT.TabIndex = 21
        Me.lblT.Text = "T:"
        '
        'lblMaxX
        '
        Me.lblMaxX.AutoSize = True
        Me.lblMaxX.Location = New System.Drawing.Point(296, 177)
        Me.lblMaxX.Name = "lblMaxX"
        Me.lblMaxX.Size = New System.Drawing.Size(30, 13)
        Me.lblMaxX.TabIndex = 4
        Me.lblMaxX.Text = "Max:"
        '
        'lblMaxY
        '
        Me.lblMaxY.AutoSize = True
        Me.lblMaxY.Location = New System.Drawing.Point(296, 204)
        Me.lblMaxY.Name = "lblMaxY"
        Me.lblMaxY.Size = New System.Drawing.Size(30, 13)
        Me.lblMaxY.TabIndex = 9
        Me.lblMaxY.Text = "Max:"
        '
        'lblMaxZ
        '
        Me.lblMaxZ.AutoSize = True
        Me.lblMaxZ.Location = New System.Drawing.Point(296, 231)
        Me.lblMaxZ.Name = "lblMaxZ"
        Me.lblMaxZ.Size = New System.Drawing.Size(30, 13)
        Me.lblMaxZ.TabIndex = 14
        Me.lblMaxZ.Text = "Max:"
        '
        'lblMinT
        '
        Me.lblMinT.AutoSize = True
        Me.lblMinT.Location = New System.Drawing.Point(120, 285)
        Me.lblMinT.Name = "lblMinT"
        Me.lblMinT.Size = New System.Drawing.Size(27, 13)
        Me.lblMinT.TabIndex = 22
        Me.lblMinT.Text = "Min:"
        '
        'tbSubset
        '
        Me.tbSubset.Controls.Add(Me.lblMaxS)
        Me.tbSubset.Controls.Add(Me.lblMinS)
        Me.tbSubset.Controls.Add(Me.lblS)
        Me.tbSubset.Controls.Add(Me.lblZ)
        Me.tbSubset.Controls.Add(Me.lblY)
        Me.tbSubset.Controls.Add(Me.lblMinX)
        Me.tbSubset.Controls.Add(Me.dtpMinT)
        Me.tbSubset.Controls.Add(Me.dtpMaxT)
        Me.tbSubset.Controls.Add(Me.lblMaxT)
        Me.tbSubset.Controls.Add(Me.ucrInputFileDetails)
        Me.tbSubset.Controls.Add(Me.lblMinT)
        Me.tbSubset.Controls.Add(Me.ucrInputMaxS)
        Me.tbSubset.Controls.Add(Me.lblMaxZ)
        Me.tbSubset.Controls.Add(Me.ucrInputMaxZ)
        Me.tbSubset.Controls.Add(Me.lblMaxY)
        Me.tbSubset.Controls.Add(Me.ucrInputMaxY)
        Me.tbSubset.Controls.Add(Me.lblMaxX)
        Me.tbSubset.Controls.Add(Me.ucrInputMaxX)
        Me.tbSubset.Controls.Add(Me.lblT)
        Me.tbSubset.Controls.Add(Me.ucrInputMinS)
        Me.tbSubset.Controls.Add(Me.lblMinZ)
        Me.tbSubset.Controls.Add(Me.ucrInputMinZ)
        Me.tbSubset.Controls.Add(Me.lblMinY)
        Me.tbSubset.Controls.Add(Me.ucrInputMinY)
        Me.tbSubset.Controls.Add(Me.lblX)
        Me.tbSubset.Controls.Add(Me.ucrInputMinX)
        Me.tbSubset.Location = New System.Drawing.Point(4, 22)
        Me.tbSubset.Name = "tbSubset"
        Me.tbSubset.Padding = New System.Windows.Forms.Padding(3)
        Me.tbSubset.Size = New System.Drawing.Size(475, 397)
        Me.tbSubset.TabIndex = 0
        Me.tbSubset.Text = "Subset"
        Me.tbSubset.UseVisualStyleBackColor = True
        '
        'lblMaxT
        '
        Me.lblMaxT.AutoSize = True
        Me.lblMaxT.Location = New System.Drawing.Point(296, 285)
        Me.lblMaxT.Name = "lblMaxT"
        Me.lblMaxT.Size = New System.Drawing.Size(30, 13)
        Me.lblMaxT.TabIndex = 24
        Me.lblMaxT.Text = "Max:"
        '
        'dtpMaxT
        '
        Me.dtpMaxT.Location = New System.Drawing.Point(328, 282)
        Me.dtpMaxT.Name = "dtpMaxT"
        Me.dtpMaxT.Size = New System.Drawing.Size(133, 20)
        Me.dtpMaxT.TabIndex = 25
        '
        'dtpMinT
        '
        Me.dtpMinT.Location = New System.Drawing.Point(149, 282)
        Me.dtpMinT.Name = "dtpMinT"
        Me.dtpMinT.Size = New System.Drawing.Size(133, 20)
        Me.dtpMinT.TabIndex = 23
        '
        'lblMinX
        '
        Me.lblMinX.AutoSize = True
        Me.lblMinX.Location = New System.Drawing.Point(120, 177)
        Me.lblMinX.Name = "lblMinX"
        Me.lblMinX.Size = New System.Drawing.Size(27, 13)
        Me.lblMinX.TabIndex = 2
        Me.lblMinX.Text = "Min:"
        '
        'lblY
        '
        Me.lblY.AutoSize = True
        Me.lblY.Location = New System.Drawing.Point(8, 204)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(17, 13)
        Me.lblY.TabIndex = 6
        Me.lblY.Text = "Y:"
        '
        'lblZ
        '
        Me.lblZ.AutoSize = True
        Me.lblZ.Location = New System.Drawing.Point(8, 231)
        Me.lblZ.Name = "lblZ"
        Me.lblZ.Size = New System.Drawing.Size(17, 13)
        Me.lblZ.TabIndex = 11
        Me.lblZ.Text = "Z:"
        '
        'lblS
        '
        Me.lblS.AutoSize = True
        Me.lblS.Location = New System.Drawing.Point(8, 258)
        Me.lblS.Name = "lblS"
        Me.lblS.Size = New System.Drawing.Size(17, 13)
        Me.lblS.TabIndex = 16
        Me.lblS.Text = "S:"
        '
        'lblMinS
        '
        Me.lblMinS.AutoSize = True
        Me.lblMinS.Location = New System.Drawing.Point(120, 257)
        Me.lblMinS.Name = "lblMinS"
        Me.lblMinS.Size = New System.Drawing.Size(27, 13)
        Me.lblMinS.TabIndex = 17
        Me.lblMinS.Text = "Min:"
        '
        'lblMaxS
        '
        Me.lblMaxS.AutoSize = True
        Me.lblMaxS.Location = New System.Drawing.Point(296, 258)
        Me.lblMaxS.Name = "lblMaxS"
        Me.lblMaxS.Size = New System.Drawing.Size(30, 13)
        Me.lblMaxS.TabIndex = 19
        Me.lblMaxS.Text = "Max:"
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(176, 433)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(142, 30)
        Me.ucrBase.TabIndex = 1
        '
        'ucrInputFileDetails
        '
        Me.ucrInputFileDetails.AddQuotesIfUnrecognised = True
        Me.ucrInputFileDetails.IsMultiline = True
        Me.ucrInputFileDetails.IsReadOnly = True
        Me.ucrInputFileDetails.Location = New System.Drawing.Point(11, 9)
        Me.ucrInputFileDetails.Name = "ucrInputFileDetails"
        Me.ucrInputFileDetails.Size = New System.Drawing.Size(450, 159)
        Me.ucrInputFileDetails.TabIndex = 0
        '
        'ucrInputMaxS
        '
        Me.ucrInputMaxS.AddQuotesIfUnrecognised = True
        Me.ucrInputMaxS.IsMultiline = False
        Me.ucrInputMaxS.IsReadOnly = False
        Me.ucrInputMaxS.Location = New System.Drawing.Point(328, 255)
        Me.ucrInputMaxS.Name = "ucrInputMaxS"
        Me.ucrInputMaxS.Size = New System.Drawing.Size(90, 21)
        Me.ucrInputMaxS.TabIndex = 20
        '
        'ucrInputMaxZ
        '
        Me.ucrInputMaxZ.AddQuotesIfUnrecognised = True
        Me.ucrInputMaxZ.IsMultiline = False
        Me.ucrInputMaxZ.IsReadOnly = False
        Me.ucrInputMaxZ.Location = New System.Drawing.Point(328, 228)
        Me.ucrInputMaxZ.Name = "ucrInputMaxZ"
        Me.ucrInputMaxZ.Size = New System.Drawing.Size(90, 21)
        Me.ucrInputMaxZ.TabIndex = 15
        '
        'ucrInputMaxY
        '
        Me.ucrInputMaxY.AddQuotesIfUnrecognised = True
        Me.ucrInputMaxY.IsMultiline = False
        Me.ucrInputMaxY.IsReadOnly = False
        Me.ucrInputMaxY.Location = New System.Drawing.Point(328, 201)
        Me.ucrInputMaxY.Name = "ucrInputMaxY"
        Me.ucrInputMaxY.Size = New System.Drawing.Size(90, 21)
        Me.ucrInputMaxY.TabIndex = 10
        '
        'ucrInputMaxX
        '
        Me.ucrInputMaxX.AddQuotesIfUnrecognised = True
        Me.ucrInputMaxX.IsMultiline = False
        Me.ucrInputMaxX.IsReadOnly = False
        Me.ucrInputMaxX.Location = New System.Drawing.Point(328, 174)
        Me.ucrInputMaxX.Name = "ucrInputMaxX"
        Me.ucrInputMaxX.Size = New System.Drawing.Size(90, 21)
        Me.ucrInputMaxX.TabIndex = 5
        '
        'ucrInputMinS
        '
        Me.ucrInputMinS.AddQuotesIfUnrecognised = True
        Me.ucrInputMinS.IsMultiline = False
        Me.ucrInputMinS.IsReadOnly = False
        Me.ucrInputMinS.Location = New System.Drawing.Point(149, 255)
        Me.ucrInputMinS.Name = "ucrInputMinS"
        Me.ucrInputMinS.Size = New System.Drawing.Size(90, 21)
        Me.ucrInputMinS.TabIndex = 18
        '
        'ucrInputMinZ
        '
        Me.ucrInputMinZ.AddQuotesIfUnrecognised = True
        Me.ucrInputMinZ.IsMultiline = False
        Me.ucrInputMinZ.IsReadOnly = False
        Me.ucrInputMinZ.Location = New System.Drawing.Point(149, 228)
        Me.ucrInputMinZ.Name = "ucrInputMinZ"
        Me.ucrInputMinZ.Size = New System.Drawing.Size(90, 21)
        Me.ucrInputMinZ.TabIndex = 13
        '
        'ucrInputMinY
        '
        Me.ucrInputMinY.AddQuotesIfUnrecognised = True
        Me.ucrInputMinY.IsMultiline = False
        Me.ucrInputMinY.IsReadOnly = False
        Me.ucrInputMinY.Location = New System.Drawing.Point(149, 201)
        Me.ucrInputMinY.Name = "ucrInputMinY"
        Me.ucrInputMinY.Size = New System.Drawing.Size(90, 21)
        Me.ucrInputMinY.TabIndex = 8
        '
        'ucrInputMinX
        '
        Me.ucrInputMinX.AddQuotesIfUnrecognised = True
        Me.ucrInputMinX.IsMultiline = False
        Me.ucrInputMinX.IsReadOnly = False
        Me.ucrInputMinX.Location = New System.Drawing.Point(149, 174)
        Me.ucrInputMinX.Name = "ucrInputMinX"
        Me.ucrInputMinX.Size = New System.Drawing.Size(90, 21)
        Me.ucrInputMinX.TabIndex = 3
        '
        'ucrChkOnlyDataVariables
        '
        Me.ucrChkOnlyDataVariables.Checked = False
        Me.ucrChkOnlyDataVariables.Location = New System.Drawing.Point(11, 18)
        Me.ucrChkOnlyDataVariables.Name = "ucrChkOnlyDataVariables"
        Me.ucrChkOnlyDataVariables.Size = New System.Drawing.Size(162, 20)
        Me.ucrChkOnlyDataVariables.TabIndex = 0
        '
        'ucrChkKeepRawTime
        '
        Me.ucrChkKeepRawTime.Checked = False
        Me.ucrChkKeepRawTime.Location = New System.Drawing.Point(11, 44)
        Me.ucrChkKeepRawTime.Name = "ucrChkKeepRawTime"
        Me.ucrChkKeepRawTime.Size = New System.Drawing.Size(162, 20)
        Me.ucrChkKeepRawTime.TabIndex = 1
        '
        'ucrChkIncludeMetadata
        '
        Me.ucrChkIncludeMetadata.Checked = False
        Me.ucrChkIncludeMetadata.Location = New System.Drawing.Point(11, 70)
        Me.ucrChkIncludeMetadata.Name = "ucrChkIncludeMetadata"
        Me.ucrChkIncludeMetadata.Size = New System.Drawing.Size(162, 20)
        Me.ucrChkIncludeMetadata.TabIndex = 2
        '
        'sdgOpenNetCDF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 468)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.tbNetCDF)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgOpenNetCDF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "NetCDF Options"
        Me.tbNetCDF.ResumeLayout(False)
        Me.tbOptions.ResumeLayout(False)
        Me.tbSubset.ResumeLayout(False)
        Me.tbSubset.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbNetCDF As TabControl
    Friend WithEvents tbOptions As TabPage
    Friend WithEvents ucrBase As ucrButtonsSubdialogue
    Friend WithEvents ucrChkOnlyDataVariables As ucrCheck
    Friend WithEvents ucrChkKeepRawTime As ucrCheck
    Friend WithEvents ucrChkIncludeMetadata As ucrCheck
    Friend WithEvents tbSubset As TabPage
    Friend WithEvents lblMaxS As Label
    Friend WithEvents lblMinS As Label
    Friend WithEvents lblS As Label
    Friend WithEvents lblZ As Label
    Friend WithEvents lblY As Label
    Friend WithEvents lblMinX As Label
    Friend WithEvents dtpMinT As DateTimePicker
    Friend WithEvents dtpMaxT As DateTimePicker
    Friend WithEvents lblMaxT As Label
    Friend WithEvents ucrInputFileDetails As ucrInputTextBox
    Friend WithEvents lblMinT As Label
    Friend WithEvents ucrInputMaxS As ucrInputTextBox
    Friend WithEvents lblMaxZ As Label
    Friend WithEvents ucrInputMaxZ As ucrInputTextBox
    Friend WithEvents lblMaxY As Label
    Friend WithEvents ucrInputMaxY As ucrInputTextBox
    Friend WithEvents lblMaxX As Label
    Friend WithEvents ucrInputMaxX As ucrInputTextBox
    Friend WithEvents lblT As Label
    Friend WithEvents ucrInputMinS As ucrInputTextBox
    Friend WithEvents lblMinZ As Label
    Friend WithEvents ucrInputMinZ As ucrInputTextBox
    Friend WithEvents lblMinY As Label
    Friend WithEvents ucrInputMinY As ucrInputTextBox
    Friend WithEvents lblX As Label
    Friend WithEvents ucrInputMinX As ucrInputTextBox
End Class
