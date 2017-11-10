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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgOpenNetCDF))
        Me.tbNetCDF = New System.Windows.Forms.TabControl()
        Me.tbSubset = New System.Windows.Forms.TabPage()
        Me.lblMaxS = New System.Windows.Forms.Label()
        Me.lblMinS = New System.Windows.Forms.Label()
        Me.lblS = New System.Windows.Forms.Label()
        Me.lblZ = New System.Windows.Forms.Label()
        Me.lblY = New System.Windows.Forms.Label()
        Me.lblMinX = New System.Windows.Forms.Label()
        Me.dtpMinT = New System.Windows.Forms.DateTimePicker()
        Me.dtpMaxT = New System.Windows.Forms.DateTimePicker()
        Me.lblMaxT = New System.Windows.Forms.Label()
        Me.ucrInputFileDetails = New instat.ucrInputTextBox()
        Me.lblMinT = New System.Windows.Forms.Label()
        Me.ucrInputMaxS = New instat.ucrInputTextBox()
        Me.lblMaxZ = New System.Windows.Forms.Label()
        Me.ucrInputMaxZ = New instat.ucrInputTextBox()
        Me.lblMaxY = New System.Windows.Forms.Label()
        Me.ucrInputMaxY = New instat.ucrInputTextBox()
        Me.lblMaxX = New System.Windows.Forms.Label()
        Me.ucrInputMaxX = New instat.ucrInputTextBox()
        Me.lblT = New System.Windows.Forms.Label()
        Me.ucrInputMinS = New instat.ucrInputTextBox()
        Me.lblMinZ = New System.Windows.Forms.Label()
        Me.ucrInputMinZ = New instat.ucrInputTextBox()
        Me.lblMinY = New System.Windows.Forms.Label()
        Me.ucrInputMinY = New instat.ucrInputTextBox()
        Me.lblX = New System.Windows.Forms.Label()
        Me.ucrInputMinX = New instat.ucrInputTextBox()
        Me.tbOptions = New System.Windows.Forms.TabPage()
        Me.ucrChkOnlyDataVariables = New instat.ucrCheck()
        Me.ucrChkKeepRawTime = New instat.ucrCheck()
        Me.ucrChkIncludeMetadata = New instat.ucrCheck()
        Me.ucrBase = New instat.ucrButtonsSubdialogue()
        Me.tbNetCDF.SuspendLayout()
        Me.tbSubset.SuspendLayout()
        Me.tbOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbNetCDF
        '
        Me.tbNetCDF.Controls.Add(Me.tbSubset)
        Me.tbNetCDF.Controls.Add(Me.tbOptions)
        resources.ApplyResources(Me.tbNetCDF, "tbNetCDF")
        Me.tbNetCDF.Name = "tbNetCDF"
        Me.tbNetCDF.SelectedIndex = 0
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
        resources.ApplyResources(Me.tbSubset, "tbSubset")
        Me.tbSubset.Name = "tbSubset"
        Me.tbSubset.UseVisualStyleBackColor = True
        '
        'lblMaxS
        '
        resources.ApplyResources(Me.lblMaxS, "lblMaxS")
        Me.lblMaxS.Name = "lblMaxS"
        '
        'lblMinS
        '
        resources.ApplyResources(Me.lblMinS, "lblMinS")
        Me.lblMinS.Name = "lblMinS"
        '
        'lblS
        '
        resources.ApplyResources(Me.lblS, "lblS")
        Me.lblS.Name = "lblS"
        '
        'lblZ
        '
        resources.ApplyResources(Me.lblZ, "lblZ")
        Me.lblZ.Name = "lblZ"
        '
        'lblY
        '
        resources.ApplyResources(Me.lblY, "lblY")
        Me.lblY.Name = "lblY"
        '
        'lblMinX
        '
        resources.ApplyResources(Me.lblMinX, "lblMinX")
        Me.lblMinX.Name = "lblMinX"
        '
        'dtpMinT
        '
        resources.ApplyResources(Me.dtpMinT, "dtpMinT")
        Me.dtpMinT.Name = "dtpMinT"
        '
        'dtpMaxT
        '
        resources.ApplyResources(Me.dtpMaxT, "dtpMaxT")
        Me.dtpMaxT.Name = "dtpMaxT"
        '
        'lblMaxT
        '
        resources.ApplyResources(Me.lblMaxT, "lblMaxT")
        Me.lblMaxT.Name = "lblMaxT"
        '
        'ucrInputFileDetails
        '
        Me.ucrInputFileDetails.AddQuotesIfUnrecognised = True
        Me.ucrInputFileDetails.IsMultiline = True
        Me.ucrInputFileDetails.IsReadOnly = True
        resources.ApplyResources(Me.ucrInputFileDetails, "ucrInputFileDetails")
        Me.ucrInputFileDetails.Name = "ucrInputFileDetails"
        '
        'lblMinT
        '
        resources.ApplyResources(Me.lblMinT, "lblMinT")
        Me.lblMinT.Name = "lblMinT"
        '
        'ucrInputMaxS
        '
        Me.ucrInputMaxS.AddQuotesIfUnrecognised = True
        Me.ucrInputMaxS.IsMultiline = False
        Me.ucrInputMaxS.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMaxS, "ucrInputMaxS")
        Me.ucrInputMaxS.Name = "ucrInputMaxS"
        '
        'lblMaxZ
        '
        resources.ApplyResources(Me.lblMaxZ, "lblMaxZ")
        Me.lblMaxZ.Name = "lblMaxZ"
        '
        'ucrInputMaxZ
        '
        Me.ucrInputMaxZ.AddQuotesIfUnrecognised = True
        Me.ucrInputMaxZ.IsMultiline = False
        Me.ucrInputMaxZ.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMaxZ, "ucrInputMaxZ")
        Me.ucrInputMaxZ.Name = "ucrInputMaxZ"
        '
        'lblMaxY
        '
        resources.ApplyResources(Me.lblMaxY, "lblMaxY")
        Me.lblMaxY.Name = "lblMaxY"
        '
        'ucrInputMaxY
        '
        Me.ucrInputMaxY.AddQuotesIfUnrecognised = True
        Me.ucrInputMaxY.IsMultiline = False
        Me.ucrInputMaxY.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMaxY, "ucrInputMaxY")
        Me.ucrInputMaxY.Name = "ucrInputMaxY"
        '
        'lblMaxX
        '
        resources.ApplyResources(Me.lblMaxX, "lblMaxX")
        Me.lblMaxX.Name = "lblMaxX"
        '
        'ucrInputMaxX
        '
        Me.ucrInputMaxX.AddQuotesIfUnrecognised = True
        Me.ucrInputMaxX.IsMultiline = False
        Me.ucrInputMaxX.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMaxX, "ucrInputMaxX")
        Me.ucrInputMaxX.Name = "ucrInputMaxX"
        '
        'lblT
        '
        resources.ApplyResources(Me.lblT, "lblT")
        Me.lblT.Name = "lblT"
        '
        'ucrInputMinS
        '
        Me.ucrInputMinS.AddQuotesIfUnrecognised = True
        Me.ucrInputMinS.IsMultiline = False
        Me.ucrInputMinS.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMinS, "ucrInputMinS")
        Me.ucrInputMinS.Name = "ucrInputMinS"
        '
        'lblMinZ
        '
        resources.ApplyResources(Me.lblMinZ, "lblMinZ")
        Me.lblMinZ.Name = "lblMinZ"
        '
        'ucrInputMinZ
        '
        Me.ucrInputMinZ.AddQuotesIfUnrecognised = True
        Me.ucrInputMinZ.IsMultiline = False
        Me.ucrInputMinZ.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMinZ, "ucrInputMinZ")
        Me.ucrInputMinZ.Name = "ucrInputMinZ"
        '
        'lblMinY
        '
        resources.ApplyResources(Me.lblMinY, "lblMinY")
        Me.lblMinY.Name = "lblMinY"
        '
        'ucrInputMinY
        '
        Me.ucrInputMinY.AddQuotesIfUnrecognised = True
        Me.ucrInputMinY.IsMultiline = False
        Me.ucrInputMinY.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMinY, "ucrInputMinY")
        Me.ucrInputMinY.Name = "ucrInputMinY"
        '
        'lblX
        '
        resources.ApplyResources(Me.lblX, "lblX")
        Me.lblX.Name = "lblX"
        '
        'ucrInputMinX
        '
        Me.ucrInputMinX.AddQuotesIfUnrecognised = True
        Me.ucrInputMinX.IsMultiline = False
        Me.ucrInputMinX.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMinX, "ucrInputMinX")
        Me.ucrInputMinX.Name = "ucrInputMinX"
        '
        'tbOptions
        '
        Me.tbOptions.Controls.Add(Me.ucrChkOnlyDataVariables)
        Me.tbOptions.Controls.Add(Me.ucrChkKeepRawTime)
        Me.tbOptions.Controls.Add(Me.ucrChkIncludeMetadata)
        resources.ApplyResources(Me.tbOptions, "tbOptions")
        Me.tbOptions.Name = "tbOptions"
        Me.tbOptions.UseVisualStyleBackColor = True
        '
        'ucrChkOnlyDataVariables
        '
        Me.ucrChkOnlyDataVariables.Checked = False
        resources.ApplyResources(Me.ucrChkOnlyDataVariables, "ucrChkOnlyDataVariables")
        Me.ucrChkOnlyDataVariables.Name = "ucrChkOnlyDataVariables"
        '
        'ucrChkKeepRawTime
        '
        Me.ucrChkKeepRawTime.Checked = False
        resources.ApplyResources(Me.ucrChkKeepRawTime, "ucrChkKeepRawTime")
        Me.ucrChkKeepRawTime.Name = "ucrChkKeepRawTime"
        '
        'ucrChkIncludeMetadata
        '
        Me.ucrChkIncludeMetadata.Checked = False
        resources.ApplyResources(Me.ucrChkIncludeMetadata, "ucrChkIncludeMetadata")
        Me.ucrChkIncludeMetadata.Name = "ucrChkIncludeMetadata"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'sdgOpenNetCDF
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.tbNetCDF)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgOpenNetCDF"
        Me.tbNetCDF.ResumeLayout(False)
        Me.tbSubset.ResumeLayout(False)
        Me.tbSubset.PerformLayout()
        Me.tbOptions.ResumeLayout(False)
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
