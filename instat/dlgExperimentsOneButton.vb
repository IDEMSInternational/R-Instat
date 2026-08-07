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
Public Class dlgExperimentsOneButton

    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bRCodeSet As Boolean = True

    Private clsBkRbdFunction As New RFunction
    Private clsBkFrbdFunction As New RFunction

    Private clsBkPlotFunction As New RFunction
    Private clsCheckGraphFunction As New RFunction
    Private clsAddPlotObjectFunction As New RFunction
    Private clsGetPlotObjectDataFunction As New RFunction
    Private clsDummyFunction As New RFunction

    Private clsCurrentDataFrameFunction As New RFunction
    Private ReadOnly strLastModel As String = "last_model"
    Private ReadOnly strLastGraph As String = "last_graph"

    Private Sub dlgExperimentsOneButton_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        UcrBaseExperimentsOneButton.iHelpTopicID = 0
        UcrBaseExperimentsOneButton.clsRsyntax.iCallType = 2
        UcrBaseExperimentsOneButton.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrPnlExperimentsOneButtonOptions.AddRadioButton(rdoGeneral)
        ucrPnlExperimentsOneButtonOptions.AddRadioButton(rdoSpecial)
        ucrPnlExperimentsOneButtonOptions.AddParameterValuesCondition(rdoGeneral, "top_option", "General")
        ucrPnlExperimentsOneButtonOptions.AddParameterValuesCondition(rdoSpecial, "top_option", "Special")

        ucrSelectorForRank.SetParameter(New RParameter("data", 0))
        ucrSelectorForRank.SetParameterIsrfunction()

        ucrReceiverResponse.Selector = ucrSelectorForRank
        ucrReceiverResponse.SetParameter(New RParameter("trait", 1))
        ucrReceiverResponse.SetParameterIsString()
        ucrReceiverResponse.SetDataType("numeric")
        ucrReceiverResponse.strSelectorHeading = "Numerics"

        UcrReceiverTreat.Selector = ucrSelectorForRank
        UcrReceiverTreat.SetParameter(New RParameter("gen", 2))
        UcrReceiverTreat.SetParameterIsString()
        UcrReceiverTreat.SetDataType("factor")
        UcrReceiverTreat.strSelectorHeading = "Factors"

        ucrReceiverFactorA.Selector = ucrSelectorForRank
        ucrReceiverFactorA.SetParameter(New RParameter("factorA", 2))
        ucrReceiverFactorA.SetParameterIsString()
        ucrReceiverFactorA.SetDataType("factor")
        ucrReceiverFactorA.strSelectorHeading = "Factors"

        ucrReceiverFactorB.Selector = ucrSelectorForRank
        ucrReceiverFactorB.SetParameter(New RParameter("factorB", 3))
        ucrReceiverFactorB.SetParameterIsString()
        ucrReceiverFactorB.SetDataType("factor")
        ucrReceiverFactorB.strSelectorHeading = "Factors"

        ucrRep.Selector = ucrSelectorForRank
        ucrRep.SetParameter(New RParameter("rep", 3))
        ucrRep.SetParameterIsString()
        ucrRep.SetDataType("factor")
        ucrRep.strSelectorHeading = "Factors"

        ucrChkPlot.SetText("Generate Plot")
        ucrChkPlot.AddParameterValuesCondition(True, "plot", "True")
        ucrChkPlot.AddParameterValuesCondition(False, "plot", "False")

        ucrAlpha.SetParameter(New RParameter("alpha", 4))
        Dim dctAlpha As New Dictionary(Of String, String)
        dctAlpha.Add("0.001", "0.001")
        dctAlpha.Add("0.01", "0.01")
        dctAlpha.Add("0.02", "0.02")
        dctAlpha.Add("0.05", "0.05")
        dctAlpha.Add("0.1", "0.1")
        ucrAlpha.SetItems(dctAlpha)
        ucrAlpha.SetRDefault("0.05")
        ucrAlpha.SetDropDownStyleAsNonEditable()

        ucrSave.SetSaveTypeAsModel()
        ucrSave.SetPrefix("one_button_model")
        ucrSave.SetDataFrameSelector(ucrSelectorForRank.ucrAvailableDataFrames)
        ucrSave.SetCheckBoxText("Store Model")
        ucrSave.SetIsComboBox()
        ucrSave.SetAssignToIfUncheckedValue(strLastModel)
    End Sub

    Private Sub SetDefaults()
        bRCodeSet = False

        clsBkRbdFunction = New RFunction
        clsBkFrbdFunction = New RFunction
        clsBkPlotFunction = New RFunction
        clsCheckGraphFunction = New RFunction
        clsAddPlotObjectFunction = New RFunction
        clsGetPlotObjectDataFunction = New RFunction
        clsDummyFunction = New RFunction

        ucrSelectorForRank.Reset()
        ucrSave.Reset()
        ucrReceiverResponse.SetMeAsReceiver()

        clsDummyFunction.AddParameter("top_option", "General", iPosition:=0)
        clsDummyFunction.AddParameter("plot", "True", iPosition:=1)


        clsCurrentDataFrameFunction = ucrSelectorForRank.ucrAvailableDataFrames.clsCurrDataFrame

        clsBkRbdFunction.SetPackageName("BKBreed")
        clsBkRbdFunction.SetRCommand("bk_rbd")
        clsBkRbdFunction.AddParameter("data", clsRFunctionParameter:=clsCurrentDataFrameFunction, iPosition:=0)
        clsBkRbdFunction.AddParameter("alpha", "0.05", iPosition:=4)

        clsBkFrbdFunction.SetPackageName("BKBreed")
        clsBkFrbdFunction.SetRCommand("bk_frbd")
        clsBkFrbdFunction.AddParameter("data", clsRFunctionParameter:=clsCurrentDataFrameFunction, iPosition:=0)
        clsBkFrbdFunction.AddParameter("alpha", "0.05", iPosition:=5)

        clsBkPlotFunction.SetPackageName("BKBreed")
        clsBkPlotFunction.SetRCommand("bk_plot")
        clsBkPlotFunction.SetAssignTo(strLastGraph)

        clsCheckGraphFunction.SetPackageName("instatExtras")
        clsCheckGraphFunction.SetRCommand("check_graph")
        clsCheckGraphFunction.AddParameter("graph_object", strLastGraph, iPosition:=0)

        clsAddPlotObjectFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_object")
        clsAddPlotObjectFunction.AddParameter("object_name", Chr(34) & strLastGraph & Chr(34), iPosition:=1)
        clsAddPlotObjectFunction.AddParameter("object_type_label", Chr(34) & "graph" & Chr(34), iPosition:=2)
        clsAddPlotObjectFunction.AddParameter("object_format", Chr(34) & "image" & Chr(34), iPosition:=3)
        clsAddPlotObjectFunction.AddParameter("object", clsRFunctionParameter:=clsCheckGraphFunction, iPosition:=4)

        clsGetPlotObjectDataFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_object_data")
        clsGetPlotObjectDataFunction.AddParameter("object_name", Chr(34) & strLastGraph & Chr(34), iPosition:=1)
        clsGetPlotObjectDataFunction.AddParameter("as_file", "TRUE", iPosition:=2)

        UpdatePlotDataFrameName()

        rdorbd.Checked = True

        UcrBaseExperimentsOneButton.clsRsyntax.ClearCodes()
        UcrBaseExperimentsOneButton.clsRsyntax.SetBaseRFunction(clsBkRbdFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        bRCodeSet = False

        ucrAlpha.AddAdditionalCodeParameterPair(clsBkFrbdFunction, New RParameter("alpha", 5), iAdditionalPairNo:=1)

        ucrReceiverResponse.SetRCode(clsBkRbdFunction, bReset)
        ucrReceiverResponse.AddAdditionalCodeParameterPair(clsBkFrbdFunction, New RParameter("trait", 1), iAdditionalPairNo:=1)

        UcrReceiverTreat.SetRCode(clsBkRbdFunction, bReset)

        ucrReceiverFactorA.SetRCode(clsBkFrbdFunction, bReset)
        ucrReceiverFactorB.SetRCode(clsBkFrbdFunction, bReset)

        ucrRep.SetRCode(clsBkRbdFunction, bReset)
        ucrRep.AddAdditionalCodeParameterPair(clsBkFrbdFunction, New RParameter("rep", 4), iAdditionalPairNo:=1)

        ucrAlpha.SetRCode(clsBkRbdFunction, bReset)

        ucrSave.SetRCode(clsBkRbdFunction, bReset)
        ucrSave.SetRCode(clsBkFrbdFunction, bReset)

        If bReset Then
            ucrPnlExperimentsOneButtonOptions.SetRCode(clsDummyFunction, bReset)
            ucrChkPlot.SetRCode(clsDummyFunction, bReset)
        End If

        UpdatePlotCode()

        bRCodeSet = True
    End Sub

    Private Sub UpdatePlotDataFrameName()
        Dim strDataFrame As String = ucrSelectorForRank.ucrAvailableDataFrames.cboAvailableDataFrames.Text
        clsAddPlotObjectFunction.AddParameter("data_name", Chr(34) & strDataFrame & Chr(34), iPosition:=0)
        clsGetPlotObjectDataFunction.AddParameter("data_name", Chr(34) & strDataFrame & Chr(34), iPosition:=0)
    End Sub

    Private Sub UpdatePlotCode()
        UcrBaseExperimentsOneButton.clsRsyntax.RemoveFromAfterCodes(clsGetPlotObjectDataFunction)
        UcrBaseExperimentsOneButton.clsRsyntax.RemoveFromAfterCodes(clsAddPlotObjectFunction)
        UcrBaseExperimentsOneButton.clsRsyntax.RemoveFromAfterCodes(clsBkPlotFunction)

        If ucrChkPlot.Checked Then
            Dim strModelName As String = If(ucrSave.ucrChkSave.Checked, ucrSave.GetText(), strLastModel)

            If Not String.IsNullOrEmpty(strModelName) Then
                clsBkPlotFunction.ClearParameters()
                clsBkPlotFunction.AddParameter("x", strModelName, iPosition:=0, bIncludeArgumentName:=False)

                UpdatePlotDataFrameName()

                UcrBaseExperimentsOneButton.clsRsyntax.AddToAfterCodes(clsBkPlotFunction)
                UcrBaseExperimentsOneButton.clsRsyntax.AddToAfterCodes(clsAddPlotObjectFunction)
                UcrBaseExperimentsOneButton.clsRsyntax.AddToAfterCodes(clsGetPlotObjectDataFunction)
            End If
        End If
    End Sub

    Private Sub TestOKEnabled()
        If rdorbd.Checked Then
            UcrBaseExperimentsOneButton.OKEnabled(Not ucrReceiverResponse.IsEmpty AndAlso
                                                 Not UcrReceiverTreat.IsEmpty AndAlso
                                                 Not ucrRep.IsEmpty AndAlso
                                                 ucrSave.IsComplete)
        ElseIf rdoFactorial.Checked Then
            UcrBaseExperimentsOneButton.OKEnabled(Not ucrReceiverResponse.IsEmpty AndAlso
                                                 Not ucrReceiverFactorA.IsEmpty AndAlso
                                                 Not ucrReceiverFactorB.IsEmpty AndAlso
                                                 Not ucrRep.IsEmpty AndAlso
                                                 ucrSave.IsComplete)
        Else
            UcrBaseExperimentsOneButton.OKEnabled(False)
        End If
    End Sub

    Private Sub UcrBaseExperimentsOneButton_ClickReset(sender As Object, e As EventArgs) Handles UcrBaseExperimentsOneButton.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        SwitchDesignVisibility()
        TestOKEnabled()
    End Sub

    Private Sub rdorbd_CheckedChanged(sender As Object, e As EventArgs) Handles rdorbd.CheckedChanged
        If rdorbd.Checked Then
            SwitchDesignVisibility()
            If bRCodeSet Then
                UcrBaseExperimentsOneButton.clsRsyntax.SetBaseRFunction(clsBkRbdFunction)
                UpdatePlotCode()
            End If
            TestOKEnabled()
        End If
    End Sub

    Private Sub rdoFactorial_CheckedChanged(sender As Object, e As EventArgs) Handles rdoFactorial.CheckedChanged
        If rdoFactorial.Checked Then
            SwitchDesignVisibility()
            If bRCodeSet Then
                UcrBaseExperimentsOneButton.clsRsyntax.SetBaseRFunction(clsBkFrbdFunction)
                UpdatePlotCode()
            End If
            TestOKEnabled()
        End If
    End Sub

    Private Sub SwitchDesignVisibility()
        Dim bIsFactorial As Boolean = rdoFactorial.Checked

        lblTreat.Visible = Not bIsFactorial
        UcrReceiverTreat.Visible = Not bIsFactorial

        lblFactorA.Visible = bIsFactorial
        ucrReceiverFactorA.Visible = bIsFactorial
        lblFactorB.Visible = bIsFactorial
        ucrReceiverFactorB.Visible = bIsFactorial
    End Sub

    Private Sub ucrSelectorForRank_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorForRank.ControlValueChanged
        clsCurrentDataFrameFunction = ucrSelectorForRank.ucrAvailableDataFrames.clsCurrDataFrame
        clsBkRbdFunction.AddParameter("data", clsRFunctionParameter:=clsCurrentDataFrameFunction, iPosition:=0)
        clsBkFrbdFunction.AddParameter("data", clsRFunctionParameter:=clsCurrentDataFrameFunction, iPosition:=0)
        UpdatePlotDataFrameName()
    End Sub

    Private Sub ucrChkPlot_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkPlot.ControlValueChanged
        If bRCodeSet Then
            UpdatePlotCode()
        End If
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverResponse.ControlContentsChanged,
        UcrReceiverTreat.ControlContentsChanged, ucrReceiverFactorA.ControlContentsChanged,
        ucrReceiverFactorB.ControlContentsChanged, ucrRep.ControlContentsChanged, ucrSave.ControlContentsChanged
        If bRCodeSet Then
            TestOKEnabled()
            UpdatePlotCode()
        End If
    End Sub

End Class