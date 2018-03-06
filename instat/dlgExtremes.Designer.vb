' R- Instat
' Copyright (C) 2015-2017
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgExtremes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgExtremes))
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.ucrReceiverDataToFit = New instat.ucrReceiverSingle()
        Me.lblDataToFit = New System.Windows.Forms.Label()
        Me.grpDistributions = New System.Windows.Forms.GroupBox()
        Me.rdoGEV = New System.Windows.Forms.RadioButton()
        Me.rdoGumbel = New System.Windows.Forms.RadioButton()
        Me.grpEstimationMethods = New System.Windows.Forms.GroupBox()
        Me.cboMethodOfMoments = New System.Windows.Forms.ComboBox()
        Me.cboMaximumLikelihood = New System.Windows.Forms.ComboBox()
        Me.lblSaveEstimates = New System.Windows.Forms.Label()
        Me.chkMethodOfMoments = New System.Windows.Forms.CheckBox()
        Me.chkMaximumLikelihood = New System.Windows.Forms.CheckBox()
        Me.chkRestrictValues = New System.Windows.Forms.CheckBox()
        Me.lblBetween = New System.Windows.Forms.Label()
        Me.txtBetween = New System.Windows.Forms.TextBox()
        Me.lblAnd = New System.Windows.Forms.Label()
        Me.txtAnd = New System.Windows.Forms.TextBox()
        Me.chkProbabilityPlot = New System.Windows.Forms.CheckBox()
        Me.UcrDialogDisabled1 = New instat.ucrDialogDisabled()
        Me.grpDistributions.SuspendLayout()
        Me.grpEstimationMethods.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.bShowHiddenColumns = False
        resources.ApplyResources(Me.ucrAddRemove, "ucrAddRemove")
        Me.ucrAddRemove.Name = "ucrAddRemove"
        '
        'ucrReceiverDataToFit
        '
        Me.ucrReceiverDataToFit.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverDataToFit, "ucrReceiverDataToFit")
        Me.ucrReceiverDataToFit.Name = "ucrReceiverDataToFit"
        Me.ucrReceiverDataToFit.Selector = Nothing
        Me.ucrReceiverDataToFit.strNcFilePath = ""
        Me.ucrReceiverDataToFit.ucrSelector = Nothing
        '
        'lblDataToFit
        '
        resources.ApplyResources(Me.lblDataToFit, "lblDataToFit")
        Me.lblDataToFit.Name = "lblDataToFit"
        Me.lblDataToFit.Tag = "Data_to_be_fitted"
        '
        'grpDistributions
        '
        Me.grpDistributions.Controls.Add(Me.rdoGEV)
        Me.grpDistributions.Controls.Add(Me.rdoGumbel)
        resources.ApplyResources(Me.grpDistributions, "grpDistributions")
        Me.grpDistributions.Name = "grpDistributions"
        Me.grpDistributions.TabStop = False
        Me.grpDistributions.Tag = "Distributions"
        '
        'rdoGEV
        '
        resources.ApplyResources(Me.rdoGEV, "rdoGEV")
        Me.rdoGEV.Name = "rdoGEV"
        Me.rdoGEV.TabStop = True
        Me.rdoGEV.Tag = "GEV"
        Me.rdoGEV.UseVisualStyleBackColor = True
        '
        'rdoGumbel
        '
        resources.ApplyResources(Me.rdoGumbel, "rdoGumbel")
        Me.rdoGumbel.Name = "rdoGumbel"
        Me.rdoGumbel.TabStop = True
        Me.rdoGumbel.Tag = "Gumbel"
        Me.rdoGumbel.UseVisualStyleBackColor = True
        '
        'grpEstimationMethods
        '
        Me.grpEstimationMethods.Controls.Add(Me.cboMethodOfMoments)
        Me.grpEstimationMethods.Controls.Add(Me.cboMaximumLikelihood)
        Me.grpEstimationMethods.Controls.Add(Me.lblSaveEstimates)
        Me.grpEstimationMethods.Controls.Add(Me.chkMethodOfMoments)
        Me.grpEstimationMethods.Controls.Add(Me.chkMaximumLikelihood)
        resources.ApplyResources(Me.grpEstimationMethods, "grpEstimationMethods")
        Me.grpEstimationMethods.Name = "grpEstimationMethods"
        Me.grpEstimationMethods.TabStop = False
        Me.grpEstimationMethods.Tag = "Estimation_methods"
        '
        'cboMethodOfMoments
        '
        Me.cboMethodOfMoments.FormattingEnabled = True
        resources.ApplyResources(Me.cboMethodOfMoments, "cboMethodOfMoments")
        Me.cboMethodOfMoments.Name = "cboMethodOfMoments"
        '
        'cboMaximumLikelihood
        '
        Me.cboMaximumLikelihood.FormattingEnabled = True
        resources.ApplyResources(Me.cboMaximumLikelihood, "cboMaximumLikelihood")
        Me.cboMaximumLikelihood.Name = "cboMaximumLikelihood"
        '
        'lblSaveEstimates
        '
        resources.ApplyResources(Me.lblSaveEstimates, "lblSaveEstimates")
        Me.lblSaveEstimates.Name = "lblSaveEstimates"
        Me.lblSaveEstimates.Tag = "Save_estimates_in"
        '
        'chkMethodOfMoments
        '
        resources.ApplyResources(Me.chkMethodOfMoments, "chkMethodOfMoments")
        Me.chkMethodOfMoments.Name = "chkMethodOfMoments"
        Me.chkMethodOfMoments.Tag = "Method_of_moments"
        Me.chkMethodOfMoments.UseVisualStyleBackColor = True
        '
        'chkMaximumLikelihood
        '
        resources.ApplyResources(Me.chkMaximumLikelihood, "chkMaximumLikelihood")
        Me.chkMaximumLikelihood.Name = "chkMaximumLikelihood"
        Me.chkMaximumLikelihood.Tag = "Maximum_likelihood_"
        Me.chkMaximumLikelihood.UseVisualStyleBackColor = True
        '
        'chkRestrictValues
        '
        resources.ApplyResources(Me.chkRestrictValues, "chkRestrictValues")
        Me.chkRestrictValues.Name = "chkRestrictValues"
        Me.chkRestrictValues.Tag = "Restrict_data_values"
        Me.chkRestrictValues.UseVisualStyleBackColor = True
        '
        'lblBetween
        '
        resources.ApplyResources(Me.lblBetween, "lblBetween")
        Me.lblBetween.Name = "lblBetween"
        Me.lblBetween.Tag = "between"
        '
        'txtBetween
        '
        resources.ApplyResources(Me.txtBetween, "txtBetween")
        Me.txtBetween.Name = "txtBetween"
        '
        'lblAnd
        '
        resources.ApplyResources(Me.lblAnd, "lblAnd")
        Me.lblAnd.Name = "lblAnd"
        Me.lblAnd.Tag = "and"
        '
        'txtAnd
        '
        resources.ApplyResources(Me.txtAnd, "txtAnd")
        Me.txtAnd.Name = "txtAnd"
        '
        'chkProbabilityPlot
        '
        resources.ApplyResources(Me.chkProbabilityPlot, "chkProbabilityPlot")
        Me.chkProbabilityPlot.Name = "chkProbabilityPlot"
        Me.chkProbabilityPlot.Tag = "Probability_plot"
        Me.chkProbabilityPlot.UseVisualStyleBackColor = True
        '
        'UcrDialogDisabled1
        '
        Me.UcrDialogDisabled1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.UcrDialogDisabled1, "UcrDialogDisabled1")
        Me.UcrDialogDisabled1.Name = "UcrDialogDisabled1"
        '
        'dlgExtremes
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.UcrDialogDisabled1)
        Me.Controls.Add(Me.chkProbabilityPlot)
        Me.Controls.Add(Me.txtAnd)
        Me.Controls.Add(Me.lblAnd)
        Me.Controls.Add(Me.txtBetween)
        Me.Controls.Add(Me.lblBetween)
        Me.Controls.Add(Me.chkRestrictValues)
        Me.Controls.Add(Me.grpEstimationMethods)
        Me.Controls.Add(Me.grpDistributions)
        Me.Controls.Add(Me.lblDataToFit)
        Me.Controls.Add(Me.ucrReceiverDataToFit)
        Me.Controls.Add(Me.ucrAddRemove)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgExtremes"
        Me.Tag = "Fit_an_Extreme_distribution"
        Me.grpDistributions.ResumeLayout(False)
        Me.grpDistributions.PerformLayout()
        Me.grpEstimationMethods.ResumeLayout(False)
        Me.grpEstimationMethods.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents ucrReceiverDataToFit As ucrReceiverSingle
    Friend WithEvents lblDataToFit As Label
    Friend WithEvents grpDistributions As GroupBox
    Friend WithEvents rdoGEV As RadioButton
    Friend WithEvents rdoGumbel As RadioButton
    Friend WithEvents grpEstimationMethods As GroupBox
    Friend WithEvents cboMethodOfMoments As ComboBox
    Friend WithEvents cboMaximumLikelihood As ComboBox
    Friend WithEvents lblSaveEstimates As Label
    Friend WithEvents chkMethodOfMoments As CheckBox
    Friend WithEvents chkMaximumLikelihood As CheckBox
    Friend WithEvents chkRestrictValues As CheckBox
    Friend WithEvents lblBetween As Label
    Friend WithEvents txtBetween As TextBox
    Friend WithEvents lblAnd As Label
    Friend WithEvents txtAnd As TextBox
    Friend WithEvents chkProbabilityPlot As CheckBox
    Friend WithEvents UcrDialogDisabled1 As ucrDialogDisabled
End Class
