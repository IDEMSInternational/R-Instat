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
    Private clsDefaultFunction As New RFunction
    Private iColumnsUsed As Integer

    Private Sub dlgCombineText_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        TestOKEnabled()
    End Sub

    Private Sub ReopenDialog()
        ColumnOrder()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 345

        ' Sort items in ucrInputSeparator
        Dim lstSeparator As New List(Of KeyValuePair(Of String, String))

        ucrInputSeparator.SetParameter(New RParameter("sep"))
        lstSeparator.Add(New KeyValuePair(Of String, String)("Space ( )", Chr(34) & " " & Chr(34)))
        lstSeparator.Add(New KeyValuePair(Of String, String)("Period .", Chr(34) & "." & Chr(34) & ")"))
        lstSeparator.Add(New KeyValuePair(Of String, String)("Hyphen -", Chr(34) & "-" & Chr(34)))
        lstSeparator.Add(New KeyValuePair(Of String, String)("Underscore _", Chr(34) & "_" & Chr(34)))
        ucrInputSeparator.SetItems(lstSeparator)

        ' ucrReceiver
        '     ucrReceiverCombineText.SetParameter(New RParameter("columns"))
        '     ucrReceiverCombineText.SetParameterIs
        ucrReceiverCombineText.Selector = ucrSelectorForCombineText
        ucrReceiverCombineText.SetMeAsReceiver()
        ucrReceiverCombineText.bUseFilteredData = False
        ucrReceiverCombineText.SetIncludedDataTypes({"factor", "character"})

        ' ucrSaveColumn
        ucrSaveColumn.SetIsTextBox()
        ucrSaveColumn.SetSaveTypeAsColumn()
        ucrSaveColumn.SetDataFrameSelector(ucrSelectorForCombineText.ucrAvailableDataFrames)
        ucrSaveColumn.SetAssignToBooleans(bTempAssignToIsPrefix:=True)
        ucrSaveColumn.SetLabelText("Prefix for New Columns:")
        iColumnsUsed = 0

        ' default functions
        clsDefaultFunction.SetRCommand("stringr::str_c")
        clsDefaultFunction.AddParameter("sep", Chr(34) & "" & Chr(34))
        clsDefaultFunction.SetAssignTo(strTemp:="Combine", strTempDataframe:=ucrSelectorForCombineText.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:="Combine", bAssignToIsPrefix:=True)
    End Sub

    Private Sub SetDefaults()
        ucrSelectorForCombineText.Reset()
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, True)
        TestOKEnabled()
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