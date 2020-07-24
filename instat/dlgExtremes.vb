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

Imports instat
Imports instat.Translations

Public Class dlgExtremes
    Private clsFevdFunction, clsNaExclude, clsConvertVector As New RFunction
    Private clsFevdPlotsFunction As New RFunction
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bResetFittingOptions As Boolean = False
    Public bResetDisplayOptions As Boolean = False

    Private Sub dlgExtremes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        Dim dctFevdTypes As New Dictionary(Of String, String)

        ucrReceiverVariable.Selector = ucrSelectorExtremes
        ucrReceiverVariable.strSelectorHeading = "Variables"
        ucrReceiverVariable.SetMeAsReceiver()
        ucrReceiverVariable.SetParameter(New RParameter("x", 0))
        ucrReceiverVariable.SetParameterIsRFunction()

        ucrInputExtremes.SetParameter(New RParameter("type", 1))
        dctFevdTypes.Add("GEV", Chr(34) & "GEV" & Chr(34))
        dctFevdTypes.Add("GP", Chr(34) & "GP" & Chr(34))
        dctFevdTypes.Add("PP", Chr(34) & "PP" & Chr(34))
        dctFevdTypes.Add("Gumbel", Chr(34) & "Gumbel" & Chr(34))
        dctFevdTypes.Add("Exponential", Chr(34) & "Exponential" & Chr(34))
        ucrInputExtremes.SetItems(dctFevdTypes)
        ucrInputExtremes.SetDropDownStyleAsNonEditable()

        ucrBase.clsRsyntax.iCallType = 2
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrReceiverVariable.Selector = ucrSelectorExtremes
        ucrReceiverVariable.strSelectorHeading = "Variables"
        ucrReceiverVariable.SetMeAsReceiver()
        ucrReceiverVariable.SetParameter(New RParameter("object", 0))
        ucrReceiverVariable.SetParameterIsRFunction()

        ucrSaveExtremes.SetPrefix("extreme")
        ucrSaveExtremes.SetIsComboBox()
        ucrSaveExtremes.SetCheckBoxText("Save Graph")
        ucrSaveExtremes.SetSaveTypeAsModel()
        ucrSaveExtremes.SetDataFrameSelector(ucrSelectorExtremes.ucrAvailableDataFrames)
        ucrSaveExtremes.SetAssignToIfUncheckedValue("last_model")
    End Sub

    Private Sub SetDefaults()
        clsFevdFunction = New RFunction
        clsFevdPlotsFunction = New RFunction
        clsNaExclude = New RFunction
        clsConvertVector = New RFunction

        ucrSaveExtremes.Reset()
        ucrSelectorExtremes.Reset()

        clsNaExclude.SetPackageName("stats")
        clsNaExclude.SetRCommand("na.exclude")

        clsFevdPlotsFunction.SetPackageName("extRemes")
        clsFevdPlotsFunction.SetRCommand("plot.fevd")
        clsFevdPlotsFunction.iCallType = 3
        clsFevdPlotsFunction.bExcludeAssignedFunctionOutput = False

        clsFevdFunction.SetPackageName("extRemes")
        clsFevdFunction.SetRCommand("fevd")


        clsConvertVector.SetRCommand("as.vector")
        clsConvertVector.AddParameter("x", clsRFunctionParameter:=clsNaExclude)

        clsFevdFunction.AddParameter("x", clsRFunctionParameter:=clsConvertVector, iPosition:=0)
        clsFevdFunction.AddParameter("type", Chr(34) & "GEV" & Chr(34), iPosition:=1)
        clsFevdFunction.AddParameter("method", Chr(34) & "MLE" & Chr(34), iPosition:=2)


        clsFevdFunction.SetAssignTo("last_model", strTempDataframe:=ucrSelectorExtremes.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempModel:="last_model")
        clsFevdPlotsFunction.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorExtremes.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")

        clsFevdPlotsFunction.AddParameter("x", clsRFunctionParameter:=clsFevdFunction, iPosition:=0)
        clsFevdPlotsFunction.AddParameter("type", Chr(34) & "primary" & Chr(34), iPosition:=1)

        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.AddToAfterCodes(clsFevdPlotsFunction, iPosition:=1)
        ucrBase.clsRsyntax.SetBaseRFunction(clsFevdFunction)
        bResetDisplayOptions = True
        bResetFittingOptions = True
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrInputExtremes.SetRCode(clsFevdFunction, bReset)
        ucrReceiverVariable.SetRCode(clsNaExclude, bReset)
        ucrSaveExtremes.SetRCode(clsFevdFunction, bReset)
    End Sub
    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub cmdDisplayOptions_Click(sender As Object, e As EventArgs) Handles cmdDisplayOptions.Click
        sdgExtremeDisplayOptions.SetRCode(clsNewFevdPlotFunction:=clsFevdPlotsFunction, clsNewRSyntax:=ucrBase.clsRsyntax)
        bResetDisplayOptions = False
        sdgExtremeDisplayOptions.ShowDialog()
    End Sub

    Private Sub TestOkEnabled()
        If ucrReceiverVariable.IsEmpty Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub cmdFittingOptions_Click(sender As Object, e As EventArgs) Handles cmdFittingOptions.Click
        sdgExtremesMethod.SetRCode(clsNewFevdFunction:=clsFevdFunction, bReset:=bResetFittingOptions)
        bResetFittingOptions = False
        sdgExtremesMethod.ShowDialog()
    End Sub

    Private Sub ucrReceiverVariable_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverVariable.ControlValueChanged
        TestOkEnabled()
    End Sub
End Class