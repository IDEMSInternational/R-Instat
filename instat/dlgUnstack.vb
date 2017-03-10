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

Public Class dlgUnstack
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsFormula As New ROperator
    Private clsIDColumns As New ROperator

    Private Sub dlgunstack_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeforControls(bReset)
        bReset = False
        autoTranslate(Me)
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    ' for factor = month, other col = dayy
    'Damango_temp <- InstatDataObject$get_data_frame(data_name="Damango")
    'Unstack <- dcast(value.var="Day", , data=Damango_temp, "Month")
    'InstatDataObject$import_data(data_tables = List(Unstack = Unstack))

    'wnat
    'DamangoShort_temp <- InstatDataObject$get_data_frame(data_name="DamangoShort")
    'DamangoShort_unstacked <- dcast(value.var="Day", formula=Year ~ Month, data=DamangoShort_temp)
    'InstatDataObject$import_data(data_tables = List(DamangoShort_unstacked = DamangoShort_unstacked))

    ' run formula line!
    ' formula = FACTOR ~ COLUMN

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 58

        clsIDColumns.SetOperation("+")
        clsIDColumns.bForceIncludeOperation = False

        ' 
        ' formula = FACTOR ~ COLUMN + ...
        ' ucrbase.clsRsyntax.AddParameter("formula", clsROperatorParameter:=clsFormula)
        clsFormula.SetOperation("~")
        clsFormula.bBrackets = False
        clsFormula.AddParameter(0, strParameterValue:=ucrFactorToUnstackReceiver.GetVariableNames(False))
        clsFormula.AddParameter(1, clsROperatorParameter:=clsIDColumns)

        'ucrID
        ucrIDColumns.Selector = ucrSelectorForunstack

        'ucrColumn
        ucrColumnToUnstackReceiver.Selector = ucrSelectorForunstack

        'ucrFactor
        ucrFactorToUnstackReceiver.SetParameter(New RParameter(""))
        ucrFactorToUnstackReceiver.SetParameterIsString()
        ucrFactorToUnstackReceiver.Selector = ucrSelectorForunstack
        ucrFactorToUnstackReceiver.SetMeAsReceiver()
        ucrFactorToUnstackReceiver.SetDataType("factor")

        'ucrSelector
        ' I did ucrBase.clsRsyntax("data", dataname)
        ' now I set the parameter for ucrSelectorForUnstack here
        ucrSelectorForunstack.SetParameter(New RParameter("data", 0))
        ucrSelectorForunstack.SetParameterIsString()

        'ucrSave
        ucrNewDFName.SetIsTextBox()
        ucrNewDFName.SetSaveTypeAsDataFrame()
        ucrNewDFName.SetDataFrameSelector(ucrSelectorForunstack.ucrAvailableDataFrames)
        ucrNewDFName.SetLabelText("New Data Frame Name:")
        ' is the below line correct? Shouldn't have this and my assign to line, right?
        ucrNewDFName.SetPrefix(ucrSelectorForunstack.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_unstacked")

        'chkbox
        ucrChkDropMissingCombinations.SetText("Drop Missing Combinations")
        ucrChkDropMissingCombinations.SetParameter(New RParameter("drop"))
        ucrChkDropMissingCombinations.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkDropMissingCombinations.SetRDefault("TRUE")


    End Sub

    Private Sub SetDefaults()
        Dim clsDefaultFunction As New RFunction
        Dim clsFormula As New ROperator
        ucrSelectorForunstack.Reset()
        ucrNewDFName.Reset()

        clsDefaultFunction.SetRCommand("dcast")
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction)

        clsFormula.SetAssignTo(strTemp:="Unstack", strTempDataframe:="Unstack")
        ucrBase.clsRsyntax.SetBaseROperator(clsFormula) ' we have two operators however.
    End Sub

    Private Sub ReopenDialog()
    End Sub

    Private Sub TestOKEnabled()
        '       If Not ucrFactorToUnstackReceiver.IsEmpty() AndAlso Not ucrColumnToUnstackReceiver.IsEmpty() AndAlso Not ucrIDColumns.IsEmpty() AndAlso Not ucrNewDataName.IsEmpty() Then
        '      ucrBase.OKEnabled(True)
        '     Else
        '    ucrBase.OKEnabled(False)
        '   End If
    End Sub

    Private Sub ucrSelectorForunstack_DataFrameChanged() Handles ucrSelectorForunstack.DataFrameChanged
        ucrBase.clsRsyntax.AddParameter("data", clsRFunctionParameter:=ucrSelectorForunstack.ucrAvailableDataFrames.clsCurrDataFrame)
        ' SetDefaultDataName()
    End Sub

    '    Private Sub SetDefaultDataName()
    '    If Not ucrNewDFName.bUserTyped AndAlso ucrSelectorForunstack.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
    '            ucrNewDataName.SetName(ucrSelectorForunstack.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_unstacked")
    '    End If
    '    End Sub

    Private Sub ucrFactorToUnstackReceiver_SelectionChanged() Handles ucrFactorToUnstackReceiver.SelectionChanged
        If Not ucrFactorToUnstackReceiver.IsEmpty Then
            clsFormula.AddParameter(strParameterValue:=ucrFactorToUnstackReceiver.GetVariableNames(False))
        Else
            clsFormula.RemoveAllAdditionalParameters()
        End If
        TestOKEnabled()
    End Sub

    Private Sub ucrColumnToUnstackReceiver_SelectionChanged() Handles ucrColumnToUnstackReceiver.SelectionChanged
        If Not ucrColumnToUnstackReceiver.IsEmpty() Then
            ucrBase.clsRsyntax.AddParameter("value.var", ucrColumnToUnstackReceiver.GetVariableNames())
        Else
            ucrBase.clsRsyntax.RemoveParameter("value.var")
        End If

        TestOKEnabled()
    End Sub

    Private Sub chkKeepUnusedFactorLevels_CheckedChanged(sender As Object, e As EventArgs)
        TestOKEnabled()
    End Sub

    '  Private Sub SetDropParameter()
    '       If chkDropMissingCombinations.Checked Then
    '       If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
    '       ucrBase.clsRsyntax.AddParameter("drop", "TRUE")
    '       Else
    '       ucrBase.clsRsyntax.RemoveParameter("drop")
    '       End If
    '       Else
    '       ucrBase.clsRsyntax.AddParameter("drop", "FALSE")
    '       End If
    '   End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOKEnabled()
    End Sub

    '    Private Sub ucrNewDataName_NameChanged()
    '   If Not ucrNewDataName.IsEmpty Then
    '          ucrBase.clsRsyntax.SetAssignTo(ucrNewDataName.GetText(), strTempDataframe:=ucrNewDataName.GetText())
    ' ' had a similar start to this in append
    'Else
    '       ucrBase.clsRsyntax.RemoveAssignTo()
    'End If
    '   TestOKEnabled()
    'End Sub

    Private Sub ucrIDColumns_SelectionChanged() Handles ucrIDColumns.SelectionChanged
        Dim lstColumns As List(Of String)

        clsIDColumns.ClearParameters()
        lstColumns = ucrIDColumns.GetVariableNamesAsList()
        For i = 0 To lstColumns.Count - 1
            If i = 0 Then
                clsIDColumns.AddParameter(iPosition:=0, strParameterValue:=lstColumns(i))
            ElseIf i = 1 Then
                clsIDColumns.AddParameter(strParameterValue:=lstColumns(i))
            Else
                clsIDColumns.AddParameter("X" & i, lstColumns(i))
            End If
        Next
        TestOKEnabled()
    End Sub
End Class

