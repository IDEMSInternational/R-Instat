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
Public Class dlgCombineText
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private iColumnsUsed As Integer

    Private Sub dlgCombineText_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub ReopenDialog()
        ColumnOrder()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 345

        ' Sort items in ucrInputSeparator
        Dim dctSeparator As New Dictionary(Of String, String)
        ucrInputSeparator.SetParameter(New RParameter("sep"))
        dctSeparator.Add("Space ( )", Chr(34) & " " & Chr(34))
        dctSeparator.Add("Period .", Chr(34) & "." & Chr(34) & ")")
        dctSeparator.Add("Hyphen -", Chr(34) & "-" & Chr(34))
        dctSeparator.Add("Underscore _", Chr(34) & "_" & Chr(34))
        ucrInputSeparator.SetItems(dctSeparator)

        ' ucrReceiver
        ucrReceiverCombineText.SetParameter(New RParameter("columns"))
        ' ucrReceiverCombineText.SetParameterIsString() ' reached problem: GetVariableNamesAsList()
        ucrReceiverCombineText.Selector = ucrSelectorForCombineText
        ucrReceiverCombineText.SetMeAsReceiver()
        ucrReceiverCombineText.bUseFilteredData = False
        ucrReceiverCombineText.SetIncludedDataTypes({"factor", "character"})

        ' ucrSaveColumn
        ucrSaveColumn.SetIsTextBox()
        ucrSaveColumn.SetPrefix("Combine")
        ucrSaveColumn.SetSaveTypeAsColumn()
        ucrSaveColumn.SetDataFrameSelector(ucrSelectorForCombineText.ucrAvailableDataFrames)
        ucrSaveColumn.SetLabelText("Prefix for New Column:")
        iColumnsUsed = 0
    End Sub

    ' got
    'Combine <- stringr::str_c(X1=InstatDataObject$get_columns_from_data(use_current_filter=FALSE, col_names="variable",
    'data_name="data1_stackedNoCarry"),
    'X2=InstatDataObject$get_columns_from_data(use_current_filter=FALSE, col_names="value",
    'data_name="data1_stackedNoCarry"), 
    '###columns=c("variable","value"),###
    ''sep=" ")

    ' want
    'Combine1 <- stringr::str_c(X2=InstatDataObject$get_columns_from_data(use_current_filter=FALSE, col_names="value",
    'data_name="data1_stackedNoCarry"),
    'X1=InstatDataObject$get_columns_from_data(use_current_filter=FALSE, col_names="variable", data_name="data1_stackedNoCarry"),
    ''sep=" ")

    Private Sub SetDefaults()
        Dim clsDefaultFunction As New RFunction
        ucrSelectorForCombineText.Reset()

        clsDefaultFunction.SetRCommand("stringr::str_c")
        clsDefaultFunction.AddParameter("sep", Chr(34) & " " & Chr(34))
        clsDefaultFunction.SetAssignTo(strTemp:=ucrSaveColumn.GetText(), strTempDataframe:=ucrSelectorForCombineText.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrSaveColumn.GetText())

        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverCombineText.IsEmpty() AndAlso ucrSaveColumn.IsComplete() Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ColumnOrder()
        Dim lstColumnFunction As List(Of RFunction)

        For i = 1 To iColumnsUsed
            ucrBase.clsRsyntax.RemoveParameter("X" & i)
        Next

        If Not ucrReceiverCombineText.IsEmpty Then
            lstColumnFunction = ucrReceiverCombineText.GetVariablesAsList()
            iColumnsUsed = lstColumnFunction.Count
            For i = 0 To lstColumnFunction.Count - 1
                ucrBase.clsRsyntax.AddParameter("X" & i + 1, clsRFunctionParameter:=lstColumnFunction(i))
            Next
        End If
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSaveColumn.ControlContentsChanged, ucrReceiverCombineText.ControlContentsChanged
        ColumnOrder()
        TestOKEnabled()
    End Sub
End Class