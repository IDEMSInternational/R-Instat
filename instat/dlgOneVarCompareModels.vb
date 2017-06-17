
' R-Instat 
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
Public Class dlgOneVarCompareModels
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bResetSubdialog As Boolean = False
    Private clsGofStat, clsReceiver, clsRAsDataFrame, clsRcdfcompFunction, clsRdenscompFunction, clsRqqcompFunction, clsRppcompFunction As New RFunction
    Private clsOperatorforTable, clsOperatorForBreaks As New ROperator
    Private Sub dlgOneVarCompareModels_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
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
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 174
        ucrBase.clsRsyntax.iCallType = 2

        'ucrSelector
        ucrSelectorOneVarCompModels.SetItemType("model")

        'ucrReceiver
        ucrReceiverCompareModels.SetParameter(New RParameter("f", 0))
        ucrReceiverCompareModels.SetParameterIsRFunction()
        ucrReceiverCompareModels.Selector = ucrSelectorOneVarCompModels
        ucrReceiverCompareModels.SetMeAsReceiver()

    End Sub

    Private Sub SetDefaults()
        clsGofStat = New RFunction
        clsRppcompFunction = New RFunction
        clsReceiver = New RFunction
        clsRdenscompFunction = New RFunction
        clsRqqcompFunction = New RFunction
        clsRqqcompFunction = New RFunction
        clsOperatorForBreaks = New ROperator
        clsOperatorforTable = New ROperator

        ucrSelectorOneVarCompModels.Reset()

        clsGofStat.SetPackageName("fitdistrplus")
        clsGofStat.SetRCommand("gofstat")
        clsRcdfcompFunction.SetPackageName("fitdistrplus")
        clsRcdfcompFunction.SetRCommand("cdfcomp")

        clsOperatorforTable.SetOperation("$")
        clsOperatorforTable.AddParameter(clsRFunctionParameter:=clsGofStat, iPosition:=0)
        clsOperatorforTable.AddParameter(strParameterValue:="chisqtable")

        clsRAsDataFrame.SetRCommand("as.data.frame")
        clsRAsDataFrame.AddParameter("x", clsROperatorParameter:=clsOperatorforTable)

        clsRAsDataFrame.SetAssignTo(ucrSelectorOneVarCompModels.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_ChiSquare", strTempDataframe:=ucrSelectorOneVarCompModels.ucrAvailableDataFrames.cboAvailableDataFrames.Text)

        ucrBase.clsRsyntax.SetBaseRFunction(clsGofStat)
        bResetSubdialog = True
    End Sub

    'Only distributions that can be accepted into the receiver have to be from the same variable
    ' If variable from variablex is selected then
    ' variables not fromvariablex cannot be in dataframe

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverCompareModels.SetRCode(clsGofStat, bReset)
        'SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Public Sub TestOKEnabled()
        If Not ucrReceiverCompareModels.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    'Private Sub ReopenDialog()
    '    sdgOneVarCompareModels.Reopen()
    'End Sub

    Private Sub ucrSelectorOneVarCompModels_DataFrameChanged() Handles ucrSelectorOneVarCompModels.DataFrameChanged
        '    sdgOneVarCompareModels.DisplayChiSquare()
    End Sub

    Private Sub ucrReceiver_SelectionChanged(ucrChangedControl As ucrCore) Handles ucrReceiverCompareModels.ControlContentsChanged
        If ucrReceiverCompareModels.IsEmpty Then
            cmdDisplayObjects.Enabled = False
        Else
            cmdDisplayObjects.Enabled = True
        End If
        TestOKEnabled()
        '        sdgOneVarCompareModels.SetModelFunction(ucrBase.clsRsyntax.clsBaseFunction)
    End Sub

    Private Sub cmdDisplayObjects_Click(sender As Object, e As EventArgs) Handles cmdDisplayObjects.Click
        sdgOneVarCompareModels.SetRCode(clsGofStat, clsReceiver, clsRdenscompFunction, clsRcdfcompFunction, clsRqqcompFunction, clsRppcompFunction, clsRAsDataFrame, clsOperatorforTable, clsOperatorForBreaks, bResetSubdialog)
        bResetSubdialog = False
        sdgOneVarCompareModels.ShowDialog()
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        sdgOneVarCompareModels.CreateGraphs()
    End Sub

    Private Sub ucrReceiverCompare_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverCompareModels.ControlValueChanged
        clsReceiver = ucrReceiverCompareModels.GetVariables()
    End Sub
End Class


