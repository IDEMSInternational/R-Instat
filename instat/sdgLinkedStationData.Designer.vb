<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgLinkedStationData
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ucrSelectorLinkedDataFrame = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblDiscritMeta = New System.Windows.Forms.Label()
        Me.ucrReceiverDiscritMeta = New instat.ucrReceiverSingle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ucrReceiverStationMeta = New instat.ucrReceiverSingle()
        Me.ucrReceiverLonMeta = New instat.ucrReceiverSingle()
        Me.ucrReceiverLatMeta = New instat.ucrReceiverSingle()
        Me.ucrReceiverAltMeta = New instat.ucrReceiverSingle()
        Me.ucrSdgLayerBase = New instat.ucrButtonsSubdialogue()
        Me.ucrInputCheckInput = New instat.ucrInputTextBox()
        Me.cmdCheckUnique = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ucrSelectorLinkedDataFrame
        '
        Me.ucrSelectorLinkedDataFrame.AutoSize = True
        Me.ucrSelectorLinkedDataFrame.bDropUnusedFilterLevels = False
        Me.ucrSelectorLinkedDataFrame.bShowHiddenColumns = False
        Me.ucrSelectorLinkedDataFrame.bUseCurrentFilter = True
        Me.ucrSelectorLinkedDataFrame.Location = New System.Drawing.Point(13, 25)
        Me.ucrSelectorLinkedDataFrame.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorLinkedDataFrame.Name = "ucrSelectorLinkedDataFrame"
        Me.ucrSelectorLinkedDataFrame.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorLinkedDataFrame.TabIndex = 10
        '
        'lblDiscritMeta
        '
        Me.lblDiscritMeta.AutoSize = True
        Me.lblDiscritMeta.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDiscritMeta.Location = New System.Drawing.Point(258, 63)
        Me.lblDiscritMeta.Name = "lblDiscritMeta"
        Me.lblDiscritMeta.Size = New System.Drawing.Size(40, 13)
        Me.lblDiscritMeta.TabIndex = 13
        Me.lblDiscritMeta.Text = "district:"
        '
        'ucrReceiverDiscritMeta
        '
        Me.ucrReceiverDiscritMeta.AutoSize = True
        Me.ucrReceiverDiscritMeta.frmParent = Me
        Me.ucrReceiverDiscritMeta.Location = New System.Drawing.Point(260, 78)
        Me.ucrReceiverDiscritMeta.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDiscritMeta.Name = "ucrReceiverDiscritMeta"
        Me.ucrReceiverDiscritMeta.Selector = Nothing
        Me.ucrReceiverDiscritMeta.Size = New System.Drawing.Size(93, 20)
        Me.ucrReceiverDiscritMeta.strNcFilePath = ""
        Me.ucrReceiverDiscritMeta.TabIndex = 14
        Me.ucrReceiverDiscritMeta.ucrSelector = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(258, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Longitude:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(258, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Latitude:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(258, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Altitude:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(258, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Name:"
        '
        'ucrReceiverStationMeta
        '
        Me.ucrReceiverStationMeta.AutoSize = True
        Me.ucrReceiverStationMeta.frmParent = Me
        Me.ucrReceiverStationMeta.Location = New System.Drawing.Point(260, 38)
        Me.ucrReceiverStationMeta.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStationMeta.Name = "ucrReceiverStationMeta"
        Me.ucrReceiverStationMeta.Selector = Nothing
        Me.ucrReceiverStationMeta.Size = New System.Drawing.Size(93, 20)
        Me.ucrReceiverStationMeta.strNcFilePath = ""
        Me.ucrReceiverStationMeta.TabIndex = 12
        Me.ucrReceiverStationMeta.ucrSelector = Nothing
        '
        'ucrReceiverLonMeta
        '
        Me.ucrReceiverLonMeta.AutoSize = True
        Me.ucrReceiverLonMeta.frmParent = Me
        Me.ucrReceiverLonMeta.Location = New System.Drawing.Point(258, 155)
        Me.ucrReceiverLonMeta.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLonMeta.Name = "ucrReceiverLonMeta"
        Me.ucrReceiverLonMeta.Selector = Nothing
        Me.ucrReceiverLonMeta.Size = New System.Drawing.Size(93, 20)
        Me.ucrReceiverLonMeta.strNcFilePath = ""
        Me.ucrReceiverLonMeta.TabIndex = 18
        Me.ucrReceiverLonMeta.ucrSelector = Nothing
        '
        'ucrReceiverLatMeta
        '
        Me.ucrReceiverLatMeta.AutoSize = True
        Me.ucrReceiverLatMeta.frmParent = Me
        Me.ucrReceiverLatMeta.Location = New System.Drawing.Point(258, 117)
        Me.ucrReceiverLatMeta.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLatMeta.Name = "ucrReceiverLatMeta"
        Me.ucrReceiverLatMeta.Selector = Nothing
        Me.ucrReceiverLatMeta.Size = New System.Drawing.Size(93, 20)
        Me.ucrReceiverLatMeta.strNcFilePath = ""
        Me.ucrReceiverLatMeta.TabIndex = 16
        Me.ucrReceiverLatMeta.ucrSelector = Nothing
        '
        'ucrReceiverAltMeta
        '
        Me.ucrReceiverAltMeta.AutoSize = True
        Me.ucrReceiverAltMeta.frmParent = Me
        Me.ucrReceiverAltMeta.Location = New System.Drawing.Point(258, 196)
        Me.ucrReceiverAltMeta.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverAltMeta.Name = "ucrReceiverAltMeta"
        Me.ucrReceiverAltMeta.Selector = Nothing
        Me.ucrReceiverAltMeta.Size = New System.Drawing.Size(93, 20)
        Me.ucrReceiverAltMeta.strNcFilePath = ""
        Me.ucrReceiverAltMeta.TabIndex = 20
        Me.ucrReceiverAltMeta.ucrSelector = Nothing
        '
        'ucrSdgLayerBase
        '
        Me.ucrSdgLayerBase.AutoSize = True
        Me.ucrSdgLayerBase.Location = New System.Drawing.Point(44, 263)
        Me.ucrSdgLayerBase.Name = "ucrSdgLayerBase"
        Me.ucrSdgLayerBase.Size = New System.Drawing.Size(224, 30)
        Me.ucrSdgLayerBase.TabIndex = 21
        '
        'ucrInputCheckInput
        '
        Me.ucrInputCheckInput.AddQuotesIfUnrecognised = True
        Me.ucrInputCheckInput.AutoSize = True
        Me.ucrInputCheckInput.IsMultiline = False
        Me.ucrInputCheckInput.IsReadOnly = False
        Me.ucrInputCheckInput.Location = New System.Drawing.Point(146, 225)
        Me.ucrInputCheckInput.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputCheckInput.Name = "ucrInputCheckInput"
        Me.ucrInputCheckInput.Size = New System.Drawing.Size(232, 21)
        Me.ucrInputCheckInput.TabIndex = 23
        '
        'cmdCheckUnique
        '
        Me.cmdCheckUnique.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCheckUnique.Location = New System.Drawing.Point(6, 223)
        Me.cmdCheckUnique.Name = "cmdCheckUnique"
        Me.cmdCheckUnique.Size = New System.Drawing.Size(128, 23)
        Me.cmdCheckUnique.TabIndex = 22
        Me.cmdCheckUnique.Text = "Check Duplicates"
        Me.cmdCheckUnique.UseVisualStyleBackColor = True
        '
        'sdgLinkedStationData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 299)
        Me.Controls.Add(Me.ucrInputCheckInput)
        Me.Controls.Add(Me.cmdCheckUnique)
        Me.Controls.Add(Me.ucrSdgLayerBase)
        Me.Controls.Add(Me.lblDiscritMeta)
        Me.Controls.Add(Me.ucrReceiverDiscritMeta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ucrReceiverStationMeta)
        Me.Controls.Add(Me.ucrReceiverLonMeta)
        Me.Controls.Add(Me.ucrReceiverLatMeta)
        Me.Controls.Add(Me.ucrReceiverAltMeta)
        Me.Controls.Add(Me.ucrSelectorLinkedDataFrame)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgLinkedStationData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Linked Station Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorLinkedDataFrame As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblDiscritMeta As Label
    Friend WithEvents ucrReceiverDiscritMeta As ucrReceiverSingle
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ucrReceiverStationMeta As ucrReceiverSingle
    Friend WithEvents ucrReceiverLonMeta As ucrReceiverSingle
    Friend WithEvents ucrReceiverLatMeta As ucrReceiverSingle
    Friend WithEvents ucrReceiverAltMeta As ucrReceiverSingle
    Friend WithEvents ucrSdgLayerBase As ucrButtonsSubdialogue
    Friend WithEvents ucrInputCheckInput As ucrInputTextBox
    Friend WithEvents cmdCheckUnique As Button
End Class
