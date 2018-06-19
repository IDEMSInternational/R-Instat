<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgDefineOptionsByContext
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
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorOptionsByContext = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblOptions = New System.Windows.Forms.Label()
        Me.ucrReceiverOptions = New instat.ucrReceiverMultiple()
        Me.ucrReceiverContexts = New instat.ucrReceiverMultiple()
        Me.lblContexts = New System.Windows.Forms.Label()
        Me.ucrReceiverMeasurements = New instat.ucrReceiverMultiple()
        Me.lblMeasurements = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 419)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSelectorOptionsByContext
        '
        Me.ucrSelectorOptionsByContext.bDropUnusedFilterLevels = False
        Me.ucrSelectorOptionsByContext.bShowHiddenColumns = False
        Me.ucrSelectorOptionsByContext.bUseCurrentFilter = True
        Me.ucrSelectorOptionsByContext.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorOptionsByContext.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorOptionsByContext.Name = "ucrSelectorOptionsByContext"
        Me.ucrSelectorOptionsByContext.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorOptionsByContext.TabIndex = 1
        '
        'lblOptions
        '
        Me.lblOptions.AutoSize = True
        Me.lblOptions.Location = New System.Drawing.Point(269, 25)
        Me.lblOptions.Name = "lblOptions"
        Me.lblOptions.Size = New System.Drawing.Size(46, 13)
        Me.lblOptions.TabIndex = 2
        Me.lblOptions.Text = "Options:"
        '
        'ucrReceiverOptions
        '
        Me.ucrReceiverOptions.frmParent = Me
        Me.ucrReceiverOptions.Location = New System.Drawing.Point(272, 44)
        Me.ucrReceiverOptions.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverOptions.Name = "ucrReceiverOptions"
        Me.ucrReceiverOptions.Selector = Nothing
        Me.ucrReceiverOptions.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverOptions.strNcFilePath = ""
        Me.ucrReceiverOptions.TabIndex = 3
        Me.ucrReceiverOptions.ucrSelector = Nothing
        '
        'ucrReceiverContexts
        '
        Me.ucrReceiverContexts.frmParent = Me
        Me.ucrReceiverContexts.Location = New System.Drawing.Point(272, 174)
        Me.ucrReceiverContexts.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverContexts.Name = "ucrReceiverContexts"
        Me.ucrReceiverContexts.Selector = Nothing
        Me.ucrReceiverContexts.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverContexts.strNcFilePath = ""
        Me.ucrReceiverContexts.TabIndex = 5
        Me.ucrReceiverContexts.ucrSelector = Nothing
        '
        'lblContexts
        '
        Me.lblContexts.AutoSize = True
        Me.lblContexts.Location = New System.Drawing.Point(269, 155)
        Me.lblContexts.Name = "lblContexts"
        Me.lblContexts.Size = New System.Drawing.Size(51, 13)
        Me.lblContexts.TabIndex = 4
        Me.lblContexts.Text = "Contexts:"
        '
        'ucrReceiverMeasurements
        '
        Me.ucrReceiverMeasurements.frmParent = Me
        Me.ucrReceiverMeasurements.Location = New System.Drawing.Point(272, 301)
        Me.ucrReceiverMeasurements.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMeasurements.Name = "ucrReceiverMeasurements"
        Me.ucrReceiverMeasurements.Selector = Nothing
        Me.ucrReceiverMeasurements.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverMeasurements.strNcFilePath = ""
        Me.ucrReceiverMeasurements.TabIndex = 7
        Me.ucrReceiverMeasurements.ucrSelector = Nothing
        '
        'lblMeasurements
        '
        Me.lblMeasurements.AutoSize = True
        Me.lblMeasurements.Location = New System.Drawing.Point(269, 282)
        Me.lblMeasurements.Name = "lblMeasurements"
        Me.lblMeasurements.Size = New System.Drawing.Size(79, 13)
        Me.lblMeasurements.TabIndex = 6
        Me.lblMeasurements.Text = "Measurements:"
        '
        'dlgDefineOptionsByContext
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 476)
        Me.Controls.Add(Me.ucrReceiverMeasurements)
        Me.Controls.Add(Me.lblMeasurements)
        Me.Controls.Add(Me.ucrReceiverContexts)
        Me.Controls.Add(Me.lblContexts)
        Me.Controls.Add(Me.ucrReceiverOptions)
        Me.Controls.Add(Me.lblOptions)
        Me.Controls.Add(Me.ucrSelectorOptionsByContext)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDefineOptionsByContext"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Define Options By Context Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorOptionsByContext As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblOptions As Label
    Friend WithEvents ucrReceiverOptions As ucrReceiverMultiple
    Friend WithEvents ucrReceiverMeasurements As ucrReceiverMultiple
    Friend WithEvents lblMeasurements As Label
    Friend WithEvents ucrReceiverContexts As ucrReceiverMultiple
    Friend WithEvents lblContexts As Label
End Class
