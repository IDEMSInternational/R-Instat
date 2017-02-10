<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgAppend
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblAppendToDataframe = New System.Windows.Forms.Label()
        Me.lblDataframes = New System.Windows.Forms.Label()
        Me.lblIDColName = New System.Windows.Forms.Label()
        Me.ucrInputIDColName = New instat.ucrInputTextBox()
        Me.ucrReceiverAppendDataframe = New instat.ucrReceiverMultiple()
        Me.ucrSelectorDataframes = New instat.ucrSelectorAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrChkIncludeIDColumn = New instat.ucrCheck()
        Me.SuspendLayout()
        '
        'lblAppendToDataframe
        '
        Me.lblAppendToDataframe.AutoSize = True
        Me.lblAppendToDataframe.Location = New System.Drawing.Point(243, 37)
        Me.lblAppendToDataframe.Name = "lblAppendToDataframe"
        Me.lblAppendToDataframe.Size = New System.Drawing.Size(115, 13)
        Me.lblAppendToDataframe.TabIndex = 3
        Me.lblAppendToDataframe.Text = "Selected Data Frames:"
        '
        'lblDataframes
        '
        Me.lblDataframes.AutoSize = True
        Me.lblDataframes.Location = New System.Drawing.Point(10, 10)
        Me.lblDataframes.Name = "lblDataframes"
        Me.lblDataframes.Size = New System.Drawing.Size(70, 13)
        Me.lblDataframes.TabIndex = 4
        Me.lblDataframes.Text = "Data Frames:"
        '
        'lblIDColName
        '
        Me.lblIDColName.AutoSize = True
        Me.lblIDColName.Location = New System.Drawing.Point(132, 246)
        Me.lblIDColName.Name = "lblIDColName"
        Me.lblIDColName.Size = New System.Drawing.Size(90, 13)
        Me.lblIDColName.TabIndex = 3
        Me.lblIDColName.Text = "ID Column Name:"
        '
        'ucrInputIDColName
        '
        Me.ucrInputIDColName.IsMultiline = False
        Me.ucrInputIDColName.IsReadOnly = False
        Me.ucrInputIDColName.Location = New System.Drawing.Point(221, 243)
        Me.ucrInputIDColName.Name = "ucrInputIDColName"
        Me.ucrInputIDColName.Size = New System.Drawing.Size(147, 21)
        Me.ucrInputIDColName.TabIndex = 6
        '
        'ucrReceiverAppendDataframe
        '
        Me.ucrReceiverAppendDataframe.frmParent = Me
        Me.ucrReceiverAppendDataframe.Location = New System.Drawing.Point(246, 53)
        Me.ucrReceiverAppendDataframe.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverAppendDataframe.Name = "ucrReceiverAppendDataframe"
        Me.ucrReceiverAppendDataframe.Selector = Nothing
        Me.ucrReceiverAppendDataframe.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverAppendDataframe.TabIndex = 2
        '
        'ucrSelectorDataframes
        '
        Me.ucrSelectorDataframes.bShowHiddenColumns = False
        Me.ucrSelectorDataframes.Location = New System.Drawing.Point(10, 31)
        Me.ucrSelectorDataframes.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorDataframes.Name = "ucrSelectorDataframes"
        Me.ucrSelectorDataframes.Size = New System.Drawing.Size(216, 191)
        Me.ucrSelectorDataframes.TabIndex = 1
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 269)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(400, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.Location = New System.Drawing.Point(10, 217)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(305, 24)
        Me.ucrSaveGraph.TabIndex = 12
        '
        'ucrChkIncludeIDColumn
        '
        Me.ucrChkIncludeIDColumn.Checked = False
        Me.ucrChkIncludeIDColumn.Location = New System.Drawing.Point(10, 243)
        Me.ucrChkIncludeIDColumn.Name = "ucrChkIncludeIDColumn"
        Me.ucrChkIncludeIDColumn.Size = New System.Drawing.Size(116, 20)
        Me.ucrChkIncludeIDColumn.TabIndex = 13
        '
        'dlgAppend
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 328)
        Me.Controls.Add(Me.ucrChkIncludeIDColumn)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.ucrInputIDColName)
        Me.Controls.Add(Me.lblDataframes)
        Me.Controls.Add(Me.lblIDColName)
        Me.Controls.Add(Me.lblAppendToDataframe)
        Me.Controls.Add(Me.ucrReceiverAppendDataframe)
        Me.Controls.Add(Me.ucrSelectorDataframes)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgAppend"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Append_Data_Frames"
        Me.Text = "Append Data Frames"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorDataframes As ucrSelectorAddRemove
    Friend WithEvents ucrReceiverAppendDataframe As ucrReceiverMultiple
    Friend WithEvents lblAppendToDataframe As Label
    Friend WithEvents lblDataframes As Label
    Friend WithEvents lblIDColName As Label
    Friend WithEvents ucrInputIDColName As ucrInputTextBox
    Friend WithEvents ucrSaveGraph As ucrSave
    Friend WithEvents ucrChkIncludeIDColumn As ucrCheck
End Class