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
        Me.lblMinX = New System.Windows.Forms.Label()
        Me.lblMinY = New System.Windows.Forms.Label()
        Me.lblMinZ = New System.Windows.Forms.Label()
        Me.lblMinT = New System.Windows.Forms.Label()
        Me.lblMaxT = New System.Windows.Forms.Label()
        Me.lblMaxZ = New System.Windows.Forms.Label()
        Me.lblMaxY = New System.Windows.Forms.Label()
        Me.lblMaxX = New System.Windows.Forms.Label()
        Me.ucrInputMinX = New instat.ucrInputTextBox()
        Me.ucrInputMinY = New instat.ucrInputTextBox()
        Me.ucrInputMinZ = New instat.ucrInputTextBox()
        Me.ucrInputMinT = New instat.ucrInputTextBox()
        Me.ucrInputMaxX = New instat.ucrInputTextBox()
        Me.ucrInputMaxY = New instat.ucrInputTextBox()
        Me.ucrInputMaxZ = New instat.ucrInputTextBox()
        Me.ucrInputMaxT = New instat.ucrInputTextBox()
        Me.ucrInputFileDetails = New instat.ucrInputTextBox()
        Me.tbNetCDF = New System.Windows.Forms.TabControl()
        Me.tbSubset = New System.Windows.Forms.TabPage()
        Me.tbOptions = New System.Windows.Forms.TabPage()
        Me.ucrBase = New instat.ucrButtonsSubdialogue()
        Me.ucrChkOnlyDataVariables = New instat.ucrCheck()
        Me.ucrChkKeepRawTime = New instat.ucrCheck()
        Me.ucrChkIncludeMetadata = New instat.ucrCheck()
        Me.tbNetCDF.SuspendLayout()
        Me.tbSubset.SuspendLayout()
        Me.tbOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMinimumLongitude
        '
        Me.lblMinX.AutoSize = True
        Me.lblMinX.Location = New System.Drawing.Point(8, 177)
        Me.lblMinX.Name = "lblMinimumLongitude"
        Me.lblMinX.Size = New System.Drawing.Size(101, 13)
        Me.lblMinX.TabIndex = 1
        Me.lblMinX.Text = "Minimum Longitude:"
        '
        'lblMinimumLatitude
        '
        Me.lblMinY.AutoSize = True
        Me.lblMinY.Location = New System.Drawing.Point(8, 204)
        Me.lblMinY.Name = "lblMinimumLatitude"
        Me.lblMinY.Size = New System.Drawing.Size(92, 13)
        Me.lblMinY.TabIndex = 5
        Me.lblMinY.Text = "Minimum Latitude:"
        '
        'lblMinZ
        '
        Me.lblMinZ.AutoSize = True
        Me.lblMinZ.Location = New System.Drawing.Point(8, 231)
        Me.lblMinZ.Name = "lblMinZ"
        Me.lblMinZ.Size = New System.Drawing.Size(61, 13)
        Me.lblMinZ.TabIndex = 9
        Me.lblMinZ.Text = "Minimum Z:"
        '
        'lblMinTime
        '
        Me.lblMinT.AutoSize = True
        Me.lblMinT.Location = New System.Drawing.Point(8, 258)
        Me.lblMinT.Name = "lblMinTime"
        Me.lblMinT.Size = New System.Drawing.Size(77, 13)
        Me.lblMinT.TabIndex = 13
        Me.lblMinT.Text = "Minimum Time:"
        '
        'lblMaxTime
        '
        Me.lblMaxT.AutoSize = True
        Me.lblMaxT.Location = New System.Drawing.Point(168, 258)
        Me.lblMaxT.Name = "lblMaxTime"
        Me.lblMaxT.Size = New System.Drawing.Size(80, 13)
        Me.lblMaxT.TabIndex = 15
        Me.lblMaxT.Text = "Maximum Time:"
        '
        'lblMaxZ
        '
        Me.lblMaxZ.AutoSize = True
        Me.lblMaxZ.Location = New System.Drawing.Point(168, 231)
        Me.lblMaxZ.Name = "lblMaxZ"
        Me.lblMaxZ.Size = New System.Drawing.Size(64, 13)
        Me.lblMaxZ.TabIndex = 11
        Me.lblMaxZ.Text = "Maximum Z:"
        '
        'lblMaxLatitude
        '
        Me.lblMaxY.AutoSize = True
        Me.lblMaxY.Location = New System.Drawing.Point(168, 204)
        Me.lblMaxY.Name = "lblMaxLatitude"
        Me.lblMaxY.Size = New System.Drawing.Size(95, 13)
        Me.lblMaxY.TabIndex = 7
        Me.lblMaxY.Text = "Maximum Latitude:"
        '
        'lblMaxLongitude
        '
        Me.lblMaxX.AutoSize = True
        Me.lblMaxX.Location = New System.Drawing.Point(168, 177)
        Me.lblMaxX.Name = "lblMaxLongitude"
        Me.lblMaxX.Size = New System.Drawing.Size(104, 13)
        Me.lblMaxX.TabIndex = 3
        Me.lblMaxX.Text = "Maximum Longitude:"
        '
        'ucrInputMinLong
        '
        Me.ucrInputMinX.AddQuotesIfUnrecognised = True
        Me.ucrInputMinX.IsMultiline = False
        Me.ucrInputMinX.IsReadOnly = False
        Me.ucrInputMinX.Location = New System.Drawing.Point(110, 174)
        Me.ucrInputMinX.Name = "ucrInputMinLong"
        Me.ucrInputMinX.Size = New System.Drawing.Size(52, 21)
        Me.ucrInputMinX.TabIndex = 2
        '
        'ucrInputMinLat
        '
        Me.ucrInputMinY.AddQuotesIfUnrecognised = True
        Me.ucrInputMinY.IsMultiline = False
        Me.ucrInputMinY.IsReadOnly = False
        Me.ucrInputMinY.Location = New System.Drawing.Point(110, 201)
        Me.ucrInputMinY.Name = "ucrInputMinLat"
        Me.ucrInputMinY.Size = New System.Drawing.Size(52, 21)
        Me.ucrInputMinY.TabIndex = 6
        '
        'ucrInputMinZ
        '
        Me.ucrInputMinZ.AddQuotesIfUnrecognised = True
        Me.ucrInputMinZ.IsMultiline = False
        Me.ucrInputMinZ.IsReadOnly = False
        Me.ucrInputMinZ.Location = New System.Drawing.Point(110, 228)
        Me.ucrInputMinZ.Name = "ucrInputMinZ"
        Me.ucrInputMinZ.Size = New System.Drawing.Size(52, 21)
        Me.ucrInputMinZ.TabIndex = 10
        '
        'ucrInputMinTime
        '
        Me.ucrInputMinT.AddQuotesIfUnrecognised = True
        Me.ucrInputMinT.IsMultiline = False
        Me.ucrInputMinT.IsReadOnly = False
        Me.ucrInputMinT.Location = New System.Drawing.Point(110, 255)
        Me.ucrInputMinT.Name = "ucrInputMinTime"
        Me.ucrInputMinT.Size = New System.Drawing.Size(52, 21)
        Me.ucrInputMinT.TabIndex = 14
        '
        'ucrInputMaxLong
        '
        Me.ucrInputMaxX.AddQuotesIfUnrecognised = True
        Me.ucrInputMaxX.IsMultiline = False
        Me.ucrInputMaxX.IsReadOnly = False
        Me.ucrInputMaxX.Location = New System.Drawing.Point(275, 174)
        Me.ucrInputMaxX.Name = "ucrInputMaxLong"
        Me.ucrInputMaxX.Size = New System.Drawing.Size(52, 21)
        Me.ucrInputMaxX.TabIndex = 4
        '
        'ucrInputMaxLat
        '
        Me.ucrInputMaxY.AddQuotesIfUnrecognised = True
        Me.ucrInputMaxY.IsMultiline = False
        Me.ucrInputMaxY.IsReadOnly = False
        Me.ucrInputMaxY.Location = New System.Drawing.Point(275, 201)
        Me.ucrInputMaxY.Name = "ucrInputMaxLat"
        Me.ucrInputMaxY.Size = New System.Drawing.Size(52, 21)
        Me.ucrInputMaxY.TabIndex = 8
        '
        'ucrInputMaxZ
        '
        Me.ucrInputMaxZ.AddQuotesIfUnrecognised = True
        Me.ucrInputMaxZ.IsMultiline = False
        Me.ucrInputMaxZ.IsReadOnly = False
        Me.ucrInputMaxZ.Location = New System.Drawing.Point(275, 228)
        Me.ucrInputMaxZ.Name = "ucrInputMaxZ"
        Me.ucrInputMaxZ.Size = New System.Drawing.Size(52, 21)
        Me.ucrInputMaxZ.TabIndex = 12
        '
        'ucrInputMaxTime
        '
        Me.ucrInputMaxT.AddQuotesIfUnrecognised = True
        Me.ucrInputMaxT.IsMultiline = False
        Me.ucrInputMaxT.IsReadOnly = False
        Me.ucrInputMaxT.Location = New System.Drawing.Point(275, 255)
        Me.ucrInputMaxT.Name = "ucrInputMaxTime"
        Me.ucrInputMaxT.Size = New System.Drawing.Size(52, 21)
        Me.ucrInputMaxT.TabIndex = 16
        '
        'ucrInputFileDetails
        '
        Me.ucrInputFileDetails.AddQuotesIfUnrecognised = True
        Me.ucrInputFileDetails.IsMultiline = True
        Me.ucrInputFileDetails.IsReadOnly = True
        Me.ucrInputFileDetails.Location = New System.Drawing.Point(11, 9)
        Me.ucrInputFileDetails.Name = "ucrInputFileDetails"
        Me.ucrInputFileDetails.Size = New System.Drawing.Size(320, 159)
        Me.ucrInputFileDetails.TabIndex = 0
        '
        'tbNetCDF
        '
        Me.tbNetCDF.Controls.Add(Me.tbSubset)
        Me.tbNetCDF.Controls.Add(Me.tbOptions)
        Me.tbNetCDF.Location = New System.Drawing.Point(8, 8)
        Me.tbNetCDF.Name = "tbNetCDF"
        Me.tbNetCDF.SelectedIndex = 0
        Me.tbNetCDF.Size = New System.Drawing.Size(348, 312)
        Me.tbNetCDF.TabIndex = 0
        '
        'tbSubset
        '
        Me.tbSubset.Controls.Add(Me.ucrInputFileDetails)
        Me.tbSubset.Controls.Add(Me.lblMaxT)
        Me.tbSubset.Controls.Add(Me.ucrInputMaxT)
        Me.tbSubset.Controls.Add(Me.lblMaxZ)
        Me.tbSubset.Controls.Add(Me.ucrInputMaxZ)
        Me.tbSubset.Controls.Add(Me.lblMaxY)
        Me.tbSubset.Controls.Add(Me.ucrInputMaxY)
        Me.tbSubset.Controls.Add(Me.lblMaxX)
        Me.tbSubset.Controls.Add(Me.ucrInputMaxX)
        Me.tbSubset.Controls.Add(Me.lblMinT)
        Me.tbSubset.Controls.Add(Me.ucrInputMinT)
        Me.tbSubset.Controls.Add(Me.lblMinZ)
        Me.tbSubset.Controls.Add(Me.ucrInputMinZ)
        Me.tbSubset.Controls.Add(Me.lblMinY)
        Me.tbSubset.Controls.Add(Me.ucrInputMinY)
        Me.tbSubset.Controls.Add(Me.lblMinX)
        Me.tbSubset.Controls.Add(Me.ucrInputMinX)
        Me.tbSubset.Location = New System.Drawing.Point(4, 22)
        Me.tbSubset.Name = "tbSubset"
        Me.tbSubset.Padding = New System.Windows.Forms.Padding(3)
        Me.tbSubset.Size = New System.Drawing.Size(340, 286)
        Me.tbSubset.TabIndex = 0
        Me.tbSubset.Text = "Subset"
        Me.tbSubset.UseVisualStyleBackColor = True
        '
        'tbOptions
        '
        Me.tbOptions.Controls.Add(Me.ucrChkOnlyDataVariables)
        Me.tbOptions.Controls.Add(Me.ucrChkKeepRawTime)
        Me.tbOptions.Controls.Add(Me.ucrChkIncludeMetadata)
        Me.tbOptions.Location = New System.Drawing.Point(4, 22)
        Me.tbOptions.Name = "tbOptions"
        Me.tbOptions.Padding = New System.Windows.Forms.Padding(3)
        Me.tbOptions.Size = New System.Drawing.Size(340, 286)
        Me.tbOptions.TabIndex = 1
        Me.tbOptions.Text = "Options"
        Me.tbOptions.UseVisualStyleBackColor = True
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(109, 322)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(142, 30)
        Me.ucrBase.TabIndex = 1
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
        Me.ClientSize = New System.Drawing.Size(361, 355)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.tbNetCDF)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgOpenNetCDF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "NetCDF Options"
        Me.tbNetCDF.ResumeLayout(False)
        Me.tbSubset.ResumeLayout(False)
        Me.tbSubset.PerformLayout()
        Me.tbOptions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrInputFileDetails As ucrInputTextBox
    Friend WithEvents ucrInputMaxT As ucrInputTextBox
    Friend WithEvents ucrInputMaxZ As ucrInputTextBox
    Friend WithEvents ucrInputMaxY As ucrInputTextBox
    Friend WithEvents ucrInputMaxX As ucrInputTextBox
    Friend WithEvents ucrInputMinT As ucrInputTextBox
    Friend WithEvents ucrInputMinZ As ucrInputTextBox
    Friend WithEvents ucrInputMinY As ucrInputTextBox
    Friend WithEvents ucrInputMinX As ucrInputTextBox
    Friend WithEvents lblMinX As Label
    Friend WithEvents lblMinY As Label
    Friend WithEvents lblMinZ As Label
    Friend WithEvents lblMinT As Label
    Friend WithEvents lblMaxT As Label
    Friend WithEvents lblMaxZ As Label
    Friend WithEvents lblMaxY As Label
    Friend WithEvents lblMaxX As Label
    Friend WithEvents tbNetCDF As TabControl
    Friend WithEvents tbSubset As TabPage
    Friend WithEvents tbOptions As TabPage
    Friend WithEvents ucrBase As ucrButtonsSubdialogue
    Friend WithEvents ucrChkOnlyDataVariables As ucrCheck
    Friend WithEvents ucrChkKeepRawTime As ucrCheck
    Friend WithEvents ucrChkIncludeMetadata As ucrCheck
End Class
