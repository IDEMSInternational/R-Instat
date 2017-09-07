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
        Me.lblMinimumLongitude = New System.Windows.Forms.Label()
        Me.lblMinimumLatitude = New System.Windows.Forms.Label()
        Me.lblMinZ = New System.Windows.Forms.Label()
        Me.lblMinTime = New System.Windows.Forms.Label()
        Me.lblMaxTime = New System.Windows.Forms.Label()
        Me.lblMaxZ = New System.Windows.Forms.Label()
        Me.lblMaxLatitude = New System.Windows.Forms.Label()
        Me.lblMaxLongitude = New System.Windows.Forms.Label()
        Me.ucrInputMinLong = New instat.ucrInputTextBox()
        Me.ucrInputMinLat = New instat.ucrInputTextBox()
        Me.ucrInputMinZ = New instat.ucrInputTextBox()
        Me.ucrInputMinTime = New instat.ucrInputTextBox()
        Me.ucrInputMaxLong = New instat.ucrInputTextBox()
        Me.ucrInputMaxLat = New instat.ucrInputTextBox()
        Me.ucrInputMaxZ = New instat.ucrInputTextBox()
        Me.ucrInputMaxTime = New instat.ucrInputTextBox()
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
        Me.lblMinimumLongitude.AutoSize = True
        Me.lblMinimumLongitude.Location = New System.Drawing.Point(8, 177)
        Me.lblMinimumLongitude.Name = "lblMinimumLongitude"
        Me.lblMinimumLongitude.Size = New System.Drawing.Size(101, 13)
        Me.lblMinimumLongitude.TabIndex = 1
        Me.lblMinimumLongitude.Text = "Minimum Longitude:"
        '
        'lblMinimumLatitude
        '
        Me.lblMinimumLatitude.AutoSize = True
        Me.lblMinimumLatitude.Location = New System.Drawing.Point(8, 204)
        Me.lblMinimumLatitude.Name = "lblMinimumLatitude"
        Me.lblMinimumLatitude.Size = New System.Drawing.Size(92, 13)
        Me.lblMinimumLatitude.TabIndex = 5
        Me.lblMinimumLatitude.Text = "Minimum Latitude:"
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
        Me.lblMinTime.AutoSize = True
        Me.lblMinTime.Location = New System.Drawing.Point(8, 258)
        Me.lblMinTime.Name = "lblMinTime"
        Me.lblMinTime.Size = New System.Drawing.Size(77, 13)
        Me.lblMinTime.TabIndex = 13
        Me.lblMinTime.Text = "Minimum Time:"
        '
        'lblMaxTime
        '
        Me.lblMaxTime.AutoSize = True
        Me.lblMaxTime.Location = New System.Drawing.Point(168, 258)
        Me.lblMaxTime.Name = "lblMaxTime"
        Me.lblMaxTime.Size = New System.Drawing.Size(80, 13)
        Me.lblMaxTime.TabIndex = 15
        Me.lblMaxTime.Text = "Maximum Time:"
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
        Me.lblMaxLatitude.AutoSize = True
        Me.lblMaxLatitude.Location = New System.Drawing.Point(168, 204)
        Me.lblMaxLatitude.Name = "lblMaxLatitude"
        Me.lblMaxLatitude.Size = New System.Drawing.Size(95, 13)
        Me.lblMaxLatitude.TabIndex = 7
        Me.lblMaxLatitude.Text = "Maximum Latitude:"
        '
        'lblMaxLongitude
        '
        Me.lblMaxLongitude.AutoSize = True
        Me.lblMaxLongitude.Location = New System.Drawing.Point(168, 177)
        Me.lblMaxLongitude.Name = "lblMaxLongitude"
        Me.lblMaxLongitude.Size = New System.Drawing.Size(104, 13)
        Me.lblMaxLongitude.TabIndex = 3
        Me.lblMaxLongitude.Text = "Maximum Longitude:"
        '
        'ucrInputMinLong
        '
        Me.ucrInputMinLong.AddQuotesIfUnrecognised = True
        Me.ucrInputMinLong.IsMultiline = False
        Me.ucrInputMinLong.IsReadOnly = False
        Me.ucrInputMinLong.Location = New System.Drawing.Point(110, 174)
        Me.ucrInputMinLong.Name = "ucrInputMinLong"
        Me.ucrInputMinLong.Size = New System.Drawing.Size(52, 21)
        Me.ucrInputMinLong.TabIndex = 2
        '
        'ucrInputMinLat
        '
        Me.ucrInputMinLat.AddQuotesIfUnrecognised = True
        Me.ucrInputMinLat.IsMultiline = False
        Me.ucrInputMinLat.IsReadOnly = False
        Me.ucrInputMinLat.Location = New System.Drawing.Point(110, 201)
        Me.ucrInputMinLat.Name = "ucrInputMinLat"
        Me.ucrInputMinLat.Size = New System.Drawing.Size(52, 21)
        Me.ucrInputMinLat.TabIndex = 6
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
        Me.ucrInputMinTime.AddQuotesIfUnrecognised = True
        Me.ucrInputMinTime.IsMultiline = False
        Me.ucrInputMinTime.IsReadOnly = False
        Me.ucrInputMinTime.Location = New System.Drawing.Point(110, 255)
        Me.ucrInputMinTime.Name = "ucrInputMinTime"
        Me.ucrInputMinTime.Size = New System.Drawing.Size(52, 21)
        Me.ucrInputMinTime.TabIndex = 14
        '
        'ucrInputMaxLong
        '
        Me.ucrInputMaxLong.AddQuotesIfUnrecognised = True
        Me.ucrInputMaxLong.IsMultiline = False
        Me.ucrInputMaxLong.IsReadOnly = False
        Me.ucrInputMaxLong.Location = New System.Drawing.Point(275, 174)
        Me.ucrInputMaxLong.Name = "ucrInputMaxLong"
        Me.ucrInputMaxLong.Size = New System.Drawing.Size(52, 21)
        Me.ucrInputMaxLong.TabIndex = 4
        '
        'ucrInputMaxLat
        '
        Me.ucrInputMaxLat.AddQuotesIfUnrecognised = True
        Me.ucrInputMaxLat.IsMultiline = False
        Me.ucrInputMaxLat.IsReadOnly = False
        Me.ucrInputMaxLat.Location = New System.Drawing.Point(275, 201)
        Me.ucrInputMaxLat.Name = "ucrInputMaxLat"
        Me.ucrInputMaxLat.Size = New System.Drawing.Size(52, 21)
        Me.ucrInputMaxLat.TabIndex = 8
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
        Me.ucrInputMaxTime.AddQuotesIfUnrecognised = True
        Me.ucrInputMaxTime.IsMultiline = False
        Me.ucrInputMaxTime.IsReadOnly = False
        Me.ucrInputMaxTime.Location = New System.Drawing.Point(275, 255)
        Me.ucrInputMaxTime.Name = "ucrInputMaxTime"
        Me.ucrInputMaxTime.Size = New System.Drawing.Size(52, 21)
        Me.ucrInputMaxTime.TabIndex = 16
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
        Me.tbSubset.Controls.Add(Me.lblMaxTime)
        Me.tbSubset.Controls.Add(Me.ucrInputMaxTime)
        Me.tbSubset.Controls.Add(Me.lblMaxZ)
        Me.tbSubset.Controls.Add(Me.ucrInputMaxZ)
        Me.tbSubset.Controls.Add(Me.lblMaxLatitude)
        Me.tbSubset.Controls.Add(Me.ucrInputMaxLat)
        Me.tbSubset.Controls.Add(Me.lblMaxLongitude)
        Me.tbSubset.Controls.Add(Me.ucrInputMaxLong)
        Me.tbSubset.Controls.Add(Me.lblMinTime)
        Me.tbSubset.Controls.Add(Me.ucrInputMinTime)
        Me.tbSubset.Controls.Add(Me.lblMinZ)
        Me.tbSubset.Controls.Add(Me.ucrInputMinZ)
        Me.tbSubset.Controls.Add(Me.lblMinimumLatitude)
        Me.tbSubset.Controls.Add(Me.ucrInputMinLat)
        Me.tbSubset.Controls.Add(Me.lblMinimumLongitude)
        Me.tbSubset.Controls.Add(Me.ucrInputMinLong)
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
    Friend WithEvents ucrInputMaxTime As ucrInputTextBox
    Friend WithEvents ucrInputMaxZ As ucrInputTextBox
    Friend WithEvents ucrInputMaxLat As ucrInputTextBox
    Friend WithEvents ucrInputMaxLong As ucrInputTextBox
    Friend WithEvents ucrInputMinTime As ucrInputTextBox
    Friend WithEvents ucrInputMinZ As ucrInputTextBox
    Friend WithEvents ucrInputMinLat As ucrInputTextBox
    Friend WithEvents ucrInputMinLong As ucrInputTextBox
    Friend WithEvents lblMinimumLongitude As Label
    Friend WithEvents lblMinimumLatitude As Label
    Friend WithEvents lblMinZ As Label
    Friend WithEvents lblMinTime As Label
    Friend WithEvents lblMaxTime As Label
    Friend WithEvents lblMaxZ As Label
    Friend WithEvents lblMaxLatitude As Label
    Friend WithEvents lblMaxLongitude As Label
    Friend WithEvents tbNetCDF As TabControl
    Friend WithEvents tbSubset As TabPage
    Friend WithEvents tbOptions As TabPage
    Friend WithEvents ucrBase As ucrButtonsSubdialogue
    Friend WithEvents ucrChkOnlyDataVariables As ucrCheck
    Friend WithEvents ucrChkKeepRawTime As ucrCheck
    Friend WithEvents ucrChkIncludeMetadata As ucrCheck
End Class
