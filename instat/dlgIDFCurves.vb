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
Public Class dlgIDFCurves
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bResetRCode As Boolean = True
    Private clsIDFCurvesFunction, clsPmatchFunction, clsGetColumnsFunction, clsColumnsFunction As New RFunction
    Private clsVarsColumnsOperator, clsVars1ColumnsOperator As ROperator

    Private Sub dlgIDFCurves_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOKEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.iCallType = 3

        ucrIDFCurvesSelector.SetParameter(New RParameter("prdat", 0))
        ucrIDFCurvesSelector.SetParameterIsrfunction()

        ucrReceiverDateTime.SetParameter(New RParameter("clmn", 1))
        ucrReceiverDateTime.Selector = ucrIDFCurvesSelector

        ucrReceiverPrec.SetParameter(New RParameter("clmn", 1))
        ucrReceiverPrec.Selector = ucrIDFCurvesSelector

        ucrStationName.SetParameter(New RParameter("stname", 2))

        ucrNudMaxPrec.SetParameter(New RParameter("mindpy", 3))
        ucrNudMaxPrec.SetMinMax(0.0, 1.0)
        ucrNudMaxPrec.Increment = 0.1
        ucrNudMaxPrec.DecimalPlaces = 1
        ucrNudMaxPrec.SetRDefault(0.8)


        'ucrSave.SetPrefix("IDF_Curve")
        'ucrSave.SetIsComboBox()
        'ucrSave.SetCheckBoxText("Save Graph")
        'ucrSave.SetSaveTypeAsGraph()
        ''ucrSave.SetSaveType(RObjectTypeLabel.Summary, strRObjectFormat:=RObjectFormat.Text)
        'ucrSave.SetDataFrameSelector(ucrIDFCurvesSelector.ucrAvailableDataFrames)
        'ucrSave.SetAssignToIfUncheckedValue("last_summary")

    End Sub

    Private Sub SetDefaults()
        clsIDFCurvesFunction = New RFunction
        clsPmatchFunction = New RFunction
        clsGetColumnsFunction = New RFunction

        clsColumnsFunction = New RFunction

        clsVarsColumnsOperator = New ROperator
        clsVars1ColumnsOperator = New ROperator

        ucrIDFCurvesSelector.Reset()
        ucrReceiverDateTime.SetMeAsReceiver()

        clsGetColumnsFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
        clsGetColumnsFunction.SetAssignTo("col_data")

        clsIDFCurvesFunction.SetPackageName("climatol")
        clsIDFCurvesFunction.SetRCommand("IDFcurves")
        clsIDFCurvesFunction.AddParameter("clmn", clsRFunctionParameter:=clsPmatchFunction, iPosition:=2)
        clsIDFCurvesFunction.AddParameter("na.code", "NA", iPosition:=3)
        'clsIDFCurvesFunction.iCallType = 1
        'clsIDFCurvesFunction.SetAssignToOutputObject(strRObjectToAssignTo:="last_summary",
        '                                           strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Summary,
        '                                           strRObjectFormatToAssignTo:=RObjectFormat.Text,
        '                                           strRDataFrameNameToAddObjectTo:=ucrIDFCurvesSelector.strCurrentDataFrame,
        '                                           strObjectName:="last_summary")


        clsVarsColumnsOperator.SetOperation("", bBracketsTemp:=False)
        clsVarsColumnsOperator.SetAssignTo("var_1")

        clsVars1ColumnsOperator.SetOperation("", bBracketsTemp:=False)
        clsVars1ColumnsOperator.SetAssignTo("var_2")

        clsColumnsFunction.SetRCommand("colnames")

        clsPmatchFunction.SetRCommand("pmatch")
        clsPmatchFunction.AddParameter("elements", clsRFunctionParameter:=clsColumnsFunction, bIncludeArgumentName:=False, iPosition:=0)
        clsPmatchFunction.AddParameter("duplicates.ok", "TRUE", iPosition:=1)
        clsPmatchFunction.AddParameter("cols", clsROperatorParameter:=clsVars1ColumnsOperator, bIncludeArgumentName:=False, iPosition:=0)
        clsPmatchFunction.SetAssignTo("data_file")

        ucrBase.clsRsyntax.SetBaseRFunction(clsIDFCurvesFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrIDFCurvesSelector.SetRCode(clsGetColumnsFunction, bReset)

        ucrNudMaxPrec.SetRCode(clsIDFCurvesFunction, bReset)
        ucrStationName.SetRCode(clsIDFCurvesFunction, bReset)
        'ucrSave.SetRCode(clsIDFCurvesFunction, bReset)

        If bReset Then
            ucrReceiverDateTime.SetRCode(clsGetColumnsFunction, bReset)
            ucrReceiverPrec.SetRCode(clsGetColumnsFunction, bReset)
        End If
    End Sub

    Private Sub TestOkEnabled()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub


    Private Sub ucrReceiverPrec_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverPrec.ControlValueChanged, ucrReceiverDateTime.ControlValueChanged
        If Not ucrReceiverPrec.IsEmpty AndAlso Not ucrReceiverDateTime.IsEmpty Then
            clsVars1ColumnsOperator.AddParameter("cols", "c(" & ucrReceiverDateTime.GetVariableNames() & ", " & ucrReceiverPrec.GetVariableNames() & ")", iPosition:=0, bIncludeArgumentName:=False)
        Else
            clsVars1ColumnsOperator.RemoveParameterByName("cols")
        End If
    End Sub

    Private Sub ucrNudMaxPrec_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudMaxPrec.ControlValueChanged
        clsIDFCurvesFunction.AddParameter("mindpy", ucrNudMaxPrec.GetText, iPosition:=5)
    End Sub

    Private Sub ucrStationName_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrStationName.ControlValueChanged
        If Not ucrStationName.IsEmpty Then
            clsIDFCurvesFunction.AddParameter("stname", Chr(34) & ucrStationName.GetText & Chr(34), iPosition:=4)
        Else
            clsIDFCurvesFunction.RemoveParameterByName("stname")
        End If
    End Sub

    Private Sub ucrIDFCurvesSelector_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrIDFCurvesSelector.ControlValueChanged
        clsColumnsFunction.AddParameter("data", clsRCodeStructureParameter:=ucrIDFCurvesSelector.ucrAvailableDataFrames.clsCurrDataFrame, bIncludeArgumentName:=False, iPosition:=0)
        clsIDFCurvesFunction.AddParameter("data", ucrIDFCurvesSelector.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, bIncludeArgumentName:=False, iPosition:=0)
    End Sub
End Class