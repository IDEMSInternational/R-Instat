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

Imports instat.Translations
Public Class dlgFitCorruptionModel
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Dim bUseSelectedColumn As Boolean = False
    Dim strSelectedColumn As String = ""
    Dim strSelectedDataFrame As String = ""
    Private bResetSubdialog As Boolean = False
    Private clsCorruptionModel, clsBinomialModel As New RFunction
    Private clsModel, clsModel1 As New ROperator

    Private Sub dlgFitCorruptionModel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bUseSelectedColumn Then
            SetDefaultColumn()
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 529
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrInputModelPreview.IsReadOnly = True

        clsBinomialModel.SetRCommand("binomial")
        clsBinomialModel.AddParameter("link", Chr(34) & "logit" & Chr(34))

        clsModel.SetOperation("~")
        clsModel.AddParameter("input", clsROperatorParameter:=clsModel1, iPosition:=1)

        'Selector
        ucrSelectorFitModel.SetParameter(New RParameter("data", 0))
        ucrSelectorFitModel.SetParameterIsrfunction()

        'Receivers
        ucrReceiverOutput.SetParameter(New RParameter("y", 1))
        ucrReceiverOutput.SetParameterIsRFunction()
        ucrReceiverOutput.Selector = ucrSelectorFitModel
        ucrReceiverOutput.SetIncludedDataTypes({"integer", "numeric", "logical"})
        ucrReceiverOutput.AddIncludedMetadataProperty("Is_Corruption_Output", {"TRUE"})

        ucrReceiverControlVariables.SetParameter(New RParameter("x", 2))
        ucrReceiverControlVariables.SetParameterIsString()
        ucrReceiverControlVariables.Selector = ucrSelectorFitModel

        ucrReceiverIndicators.SetParameter(New RParameter("z", 3))
        ucrReceiverIndicators.SetParameterIsString()
        ucrReceiverIndicators.Selector = ucrSelectorFitModel

        'ucrSave
        ucrSaveCorruptionModel.SetPrefix("Corruption_Model")
        ucrSaveCorruptionModel.SetSaveTypeAsModel()
        ucrSaveCorruptionModel.SetDataFrameSelector(ucrSelectorFitModel.ucrAvailableDataFrames)
        ucrSaveCorruptionModel.SetCheckBoxText("Save Model")
        ucrSaveCorruptionModel.SetIsComboBox()
        ucrSaveCorruptionModel.SetAssignToIfUncheckedValue("last_model")
    End Sub

    Private Sub SetDefaults()
        clsCorruptionModel = New RFunction
        ucrReceiverOutput.SetMeAsReceiver()

        'Reset 
        ucrSelectorFitModel.Reset()
        ucrSaveCorruptionModel.Reset()
        ucrInputModelPreview.SetName("")

        clsCorruptionModel.SetRCommand("glm")
        clsCorruptionModel.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorFitModel.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")

        ucrBase.clsRsyntax.SetBaseRFunction(clsCorruptionModel)
        bResetSubdialog = True
        ChangeBaseFunction()
        LoadSubdialog()
    End Sub

    Private Sub SetCurrentColumn(strColumn As String, strDataFrame As String)
        strSelectedColumn = strColumn
        strSelectedDataFrame = strDataFrame
        bUseSelectedColumn = True
    End Sub

    Private Sub SetDefaultColumn()
        ucrSelectorFitModel.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem = strSelectedDataFrame
        ucrReceiverControlVariables.Add(strSelectedColumn, strSelectedDataFrame)
        ucrReceiverIndicators.Add(strSelectedColumn, strSelectedDataFrame)
        bUseSelectedColumn = False
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrSelectorFitModel.SetRCode(clsCorruptionModel, bReset)
        ucrSaveCorruptionModel.SetRCode(clsCorruptionModel, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverOutput.IsEmpty AndAlso (Not ucrReceiverIndicators.IsEmpty OrElse Not ucrReceiverControlVariables.IsEmpty) AndAlso ucrSaveCorruptionModel.IsComplete Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ChangeBaseFunction()
        If Not ucrReceiverOutput.IsEmpty Then
            If frmMain.clsRLink.IsBinary(ucrSelectorFitModel.ucrAvailableDataFrames.cboAvailableDataFrames.Text, ucrReceiverOutput.GetVariableNames(False)) Then
                clsCorruptionModel.SetRCommand("glm")
                clsCorruptionModel.AddParameter("family", clsRFunctionParameter:=clsBinomialModel)
            Else
                clsCorruptionModel.SetRCommand("lm")
                clsCorruptionModel.RemoveParameterByName("family")
            End If
        End If
    End Sub

    Private Sub SetFormula()
        Dim i As Integer = 0
        If Not ucrReceiverOutput.IsEmpty AndAlso (Not ucrReceiverIndicators.IsEmpty OrElse Not ucrReceiverControlVariables.IsEmpty) Then
            clsCorruptionModel.AddParameter("formula", clsROperatorParameter:=clsModel)

            clsModel.AddParameter("output", ucrReceiverOutput.GetVariableNames(False), iPosition:=0)

            clsModel1.SetOperation("+")
            clsModel1.ClearParameters()
            For Each strControlVar As String In ucrReceiverControlVariables.GetVariableNamesAsList
                clsModel1.AddParameter(i, strControlVar, iPosition:=i)
                i = i + 1
            Next
            For Each strIndicatorVar As String In ucrReceiverIndicators.GetVariableNamesAsList
                clsModel1.AddParameter(i, strIndicatorVar, iPosition:=i)
                i = i + 1
            Next
            ucrInputModelPreview.SetName(clsModel.ToScript)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverOutput.ControlContentsChanged, ucrReceiverIndicators.ControlContentsChanged, ucrReceiverControlVariables.ControlContentsChanged, ucrSaveCorruptionModel.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub cmdDisplayOptions_Click(sender As Object, e As EventArgs) Handles cmdDisplayOptions.Click
        'sdgSimpleRegOptions.SetRFunction(ucrBase.clsRsyntax.clsBaseFunction, bResetSubdialog)
        'bResetSubdialog = False
        sdgSimpleRegOptions.ShowDialog()
    End Sub

    Private Sub LoadSubdialog()
        'sdgSimpleRegOptions.SetRModelFunction(clsCorruptionModel)
        sdgSimpleRegOptions.SetRDataFrame(ucrSelectorFitModel.ucrAvailableDataFrames)
        ' sdgSimpleRegOptions.SetRYVariable(ucrReceiverOutput)
        ' sdgSimpleRegOptions.SetDefaults()
        ' sdgSimpleRegOptions.chkDisplayCLimits.Enabled = True
        sdgSimpleRegOptions.lblConfLevel.Enabled = True
        ' sdgSimpleRegOptions.nudDisplayCLevel.Enabled = True
    End Sub

    Private Sub ucrReceiverOutput_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverOutput.ControlValueChanged, ucrReceiverControlVariables.ControlValueChanged, ucrReceiverIndicators.ControlValueChanged
        ChangeBaseFunction()
        SetFormula()
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        'sdgSimpleRegOptions.RegOptions()
    End Sub
End Class