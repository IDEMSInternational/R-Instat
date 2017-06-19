' Instat-R
' Copyright (C) 2015
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
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.
Imports instat.Translations

Public Class dlgCorrelation
    Public bFirstLoad As Boolean = True
    Public bIsTwoColumnFunction As Boolean
    Public clsRCorrelation As New RFunction
    Dim clsTempFunc As RFunction
    Private Sub dlgCorrelation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        TestOKEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrReceiverFirstColumn.Selector = ucrSelectorCorrelation
        ucrReceiverSecondColumn.Selector = ucrSelectorCorrelation
        ucrReceiverMultipleColumns.Selector = ucrSelectorCorrelation
        ucrReceiverFirstColumn.SetDataType("numeric")
        ucrReceiverFirstColumn.strSelectorHeading = "Numerics"
        ucrReceiverSecondColumn.SetDataType("numeric")
        ucrReceiverSecondColumn.strSelectorHeading = "Numerics"
        ucrSelectorCorrelation.Focus()
        ucrReceiverMultipleColumns.SetDataType("numeric")
        ucrReceiverMultipleColumns.strSelectorHeading = "Numerics"
        ucrSaveModel.chkSaveModel.Text = "Result Name"
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        'TODO: Fix bugs produced when rdoScatterplotMatrix is checked. Disabled for now
        sdgCorrPlot.rdoScatterplotMatrix.Enabled = False

        sdgCorrPlot.ucrSelectFactor.SetDataframe(ucrSelectorCorrelation.ucrAvailableDataFrames.strCurrDataFrame, bEnableDataframe:=False)
        nudConfidenceInterval.Minimum = 0
        nudConfidenceInterval.Maximum = 1
        nudConfidenceInterval.Increment = 0.05
        ucrBase.iHelpTopicID = 421
        'Help ID changed from 186
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub SetDefaults()
        rdoPearson.Checked = True
        rdoCompleteRowsOnly.Checked = True
        rdoMultipleColumns.Checked = True
        nudConfidenceInterval.Value = 0.95
        sdgCorrPlot.SetDefaults()
        ucrSelectorCorrelation.Reset()
        ucrReceiverMultipleColumns.SetMeAsReceiver()
        ucrSaveModel.ucrInputModelName.SetName("Cor")
        ucrSaveModel.chkSaveModel.Checked = False
        ucrSaveModel.ucrInputModelName.Visible = False
        chkCorrelationMatrix.Checked = True
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverFirstColumn_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverFirstColumn.SelectionChanged
        If Not ucrReceiverFirstColumn.IsEmpty() Then
            clsRCorrelation.AddParameter("x", clsRFunctionParameter:=ucrReceiverFirstColumn.GetVariables())
        End If
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverSecondColumn_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverSecondColumn.SelectionChanged
        If Not ucrReceiverSecondColumn.IsEmpty() Then
            clsRCorrelation.AddParameter("y", clsRFunctionParameter:=ucrReceiverSecondColumn.GetVariables())
        End If
        TestOKEnabled()
    End Sub

    Public Sub ucrReceiverMultipleColumns_SelectionChanged() Handles ucrReceiverMultipleColumns.SelectionChanged
        If Not ucrReceiverMultipleColumns.IsEmpty() Then
            clsRCorrelation.AddParameter("x", clsRFunctionParameter:=ucrReceiverMultipleColumns.GetVariables())
            sdgCorrPlot.clsRGraphics.AddParameter("columns", ucrReceiverMultipleColumns.GetVariableNames())
            sdgCorrPlot.clsRGGscatmatrix.AddParameter("columns", ucrReceiverMultipleColumns.GetVariableNames)
        End If
        TestOKEnabled()
    End Sub

    Private Sub rdoForMethodsCheckedChanged(sender As Object, e As EventArgs) Handles rdoPearson.CheckedChanged, rdoKendall.CheckedChanged, rdoSpearman.CheckedChanged
        If rdoPearson.Checked Then
            clsRCorrelation.AddParameter("method", Chr(34) & "pearson" & Chr(34))
            If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                clsRCorrelation.AddParameter("method", Chr(34) & "pearson" & Chr(34))
            Else
                clsRCorrelation.RemoveParameterByName("method")
            End If
        ElseIf rdoKendall.Checked Then
            clsRCorrelation.AddParameter("method", Chr(34) & "kendall" & Chr(34))

        ElseIf rdoSpearman.Checked Then
            clsRCorrelation.AddParameter("method", Chr(34) & "spearman" & Chr(34))
        Else
            clsRCorrelation.RemoveParameterByName("method")
        End If
    End Sub

    Private Sub rdoCompleteRowsOnly_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCompleteRowsOnly.CheckedChanged, rdoPairwise.CheckedChanged
        SetUseParameter()
    End Sub

    Private Sub SetUseParameter()
        If rdoCompleteRowsOnly.Checked Then
            clsRCorrelation.AddParameter("use", Chr(34) & "pairwise.complete.obs" & Chr(34))
        ElseIf rdoPairwise.Checked Then
            clsRCorrelation.AddParameter("use", Chr(34) & "complete.obs" & Chr(34))
        Else
            ucrBase.clsRsyntax.RemoveParameter("use")
        End If
    End Sub

    Private Sub SetTwoColumnAsFunction()
        ucrBase.clsRsyntax.iCallType = 2
        ucrReceiverFirstColumn.SetMeAsReceiver()
        clsRCorrelation.SetRCommand("cor.test")
        ucrBase.clsRsyntax.SetBaseRFunction(clsRCorrelation)
        grpMissing.Visible = False
        cmdOptions.Visible = False
        lblConfInterval.Visible = True
        nudConfidenceInterval.Visible = True
        ucrReceiverFirstColumn.Visible = True
        ucrReceiverSecondColumn.Visible = True
        ucrReceiverMultipleColumns.Visible = False
        clsRCorrelation.RemoveParameterByName("use")
        If nudConfidenceInterval.Value.ToString = "" Then
            nudConfidenceInterval.Value = 0.95
        End If
        clsRCorrelation.AddParameter("conf.level", nudConfidenceInterval.Value.ToString)
        clsRCorrelation.AddParameter("x", clsRFunctionParameter:=ucrReceiverFirstColumn.GetVariables())
        clsRCorrelation.AddParameter("y", clsRFunctionParameter:=ucrReceiverSecondColumn.GetVariables())
        clsRCorrelation.AddParameter("alternative", Chr(34) & "two.sided" & Chr(34))
        clsRCorrelation.AddParameter("exact", "NULL")
        bIsTwoColumnFunction = True
        TestOKEnabled()
    End Sub

    Private Sub nudConfidenceInterval_ValueChanged(sender As Object, e As EventArgs) Handles nudConfidenceInterval.ValueChanged
        clsRCorrelation.AddParameter("conf.level", nudConfidenceInterval.Value.ToString)
    End Sub

    Public Sub SetMultipleColumnAsFunction()
        ucrBase.clsRsyntax.iCallType = 0
        ucrReceiverMultipleColumns.SetMeAsReceiver()
        clsRCorrelation.SetRCommand("cor")
        grpMissing.Visible = True
        cmdOptions.Visible = True
        lblConfInterval.Visible = False
        nudConfidenceInterval.Visible = False
        ucrReceiverFirstColumn.Visible = False
        ucrReceiverSecondColumn.Visible = False
        ucrReceiverMultipleColumns.Visible = True
        clsRCorrelation.RemoveParameterByName("alternative")
        clsRCorrelation.RemoveParameterByName("exact")
        clsRCorrelation.RemoveParameterByName("conf.level")
        clsRCorrelation.RemoveParameterByName("y")
        SetUseParameter()
        clsRCorrelation.AddParameter("x", clsRFunctionParameter:=ucrReceiverMultipleColumns.GetVariables())
        bIsTwoColumnFunction = False
        TestOKEnabled()
    End Sub

    Private Sub ColumnTypeChanged(sender As Object, e As EventArgs) Handles rdoTwoColumns.CheckedChanged, rdoMultipleColumns.CheckedChanged
        If rdoTwoColumns.Checked Then
            SetTwoColumnAsFunction()
        ElseIf rdoMultipleColumns.Checked Then
            SetMultipleColumnAsFunction()
            sdgCorrPlot.CorrOptions()
        End If
        TestOKEnabled()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub cmdPlots_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgCorrPlot.ShowDialog()
    End Sub

    Public Sub TestOKEnabled()
        If rdoTwoColumns.Checked Then
            ucrBase.clsRsyntax.RemoveAssignTo()
            If (Not ucrReceiverFirstColumn.IsEmpty()) AndAlso (Not ucrReceiverSecondColumn.IsEmpty()) AndAlso (rdoPearson.Checked = True Or rdoKendall.Checked = True Or rdoSpearman.Checked = True) Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        ElseIf rdoMultipleColumns.Checked AndAlso ucrReceiverMultipleColumns.lstSelectedVariables.Items.Count > 1 AndAlso (rdoCompleteRowsOnly.Checked OrElse rdoPairwise.Checked) AndAlso (rdoPearson.Checked OrElse rdoKendall.Checked OrElse rdoSpearman.Checked) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
        If (rdoMultipleColumns.Checked) AndAlso (ucrSaveModel.chkSaveModel.Checked OrElse chkCorrelationMatrix.Checked OrElse sdgCorrPlot.rdoCorrelationPlot.Checked OrElse sdgCorrPlot.rdoScatterplotMatrix.Checked OrElse sdgCorrPlot.rdoPairwisePlot.Checked) Then
            If (Not ucrReceiverMultipleColumns.IsEmpty()) AndAlso ucrReceiverMultipleColumns.lstSelectedVariables.Items.Count > 1 AndAlso (rdoCompleteRowsOnly.Checked OrElse rdoPairwise.Checked) AndAlso (rdoPearson.Checked OrElse rdoKendall.Checked OrElse rdoSpearman.Checked) Then
                SaveModel()
                TempData()
                AssignModelName()
            End If
        End If
    End Sub

    Public Sub TempData()
        clsTempFunc = ucrSelectorCorrelation.ucrAvailableDataFrames.clsCurrDataFrame.Clone()
        clsTempFunc.AddParameter("remove_attr", "TRUE")
        sdgCorrPlot.clsRGraphics.AddParameter("data", clsRFunctionParameter:=clsTempFunc)
        sdgCorrPlot.clsRGGscatmatrix.AddParameter("data", clsRFunctionParameter:=clsTempFunc)
    End Sub

    Private Sub ucrSelectorCorrelation_DataFrameChanged() Handles ucrSelectorCorrelation.DataFrameChanged
        TestOKEnabled()
        sdgCorrPlot.chkColour.Checked = False
        sdgCorrPlot.SetDataFrame(strNewDataFrame:=ucrSelectorCorrelation.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        If rdoMultipleColumns.Checked AndAlso chkCorrelationMatrix.Checked AndAlso ((sdgCorrPlot.rdoPairwisePlot.Checked OrElse sdgCorrPlot.rdoCorrelationPlot.Checked OrElse sdgCorrPlot.rdoScatterplotMatrix.Checked)) Then
            frmMain.clsRLink.RunScript(clsRCorrelation.ToScript(), 2)
        End If
        If ucrSaveModel.chkSaveModel.Checked AndAlso sdgCorrPlot.rdoNone.Checked AndAlso (chkCorrelationMatrix.Checked) Then
            ucrBase.clsRsyntax.RemoveAssignTo()
            frmMain.clsRLink.RunScript(clsRCorrelation.ToScript(), 2)
        End If
    End Sub

    Public Sub AssignModelName()
        If ucrSaveModel.chkSaveModel.Checked AndAlso ucrSaveModel.ucrInputModelName.GetText() <> "" AndAlso rdoMultipleColumns.Checked AndAlso sdgCorrPlot.rdoNone.Checked Then
            ucrBase.clsRsyntax.SetAssignTo(ucrSaveModel.ucrInputModelName.GetText(), strTempModel:=ucrSaveModel.ucrInputModelName.GetText(), strTempDataframe:=ucrSelectorCorrelation.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem)
            ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
            ucrBase.clsRsyntax.iCallType = 0
        ElseIf sdgCorrPlot.ucrSaveGraph.bSaveGraph Then
            ucrBase.clsRsyntax.SetAssignTo(sdgCorrPlot.ucrSaveGraph.strGraphName, strTempDataframe:=ucrSelectorCorrelation.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:=sdgCorrPlot.ucrSaveGraph.strGraphName)
            ucrBase.clsRsyntax.iCallType = 0
        Else
            ucrBase.clsRsyntax.iCallType = 2
            ucrBase.clsRsyntax.RemoveAssignTo()
        End If
    End Sub
    Public Sub SaveModel()
        If chkCorrelationMatrix.Checked AndAlso sdgCorrPlot.rdoNone.Checked AndAlso rdoMultipleColumns.Checked Then
            ucrSaveModel.Visible = True
        Else
            ucrSaveModel.Visible = False
        End If
    End Sub

    Private Sub ucrSaveModel_CheckedChanged(bChecked As Boolean) Handles ucrSaveModel.CheckedChanged
        TestOKEnabled()
    End Sub
End Class