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
    Private clsDefaultFunction As New RFunction

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

    Private Sub InitialiseDialog()
        Dim dctSeparator As New Dictionary(Of String, String)
        ucrBase.iHelpTopicID = 345

        ' ucrReceiver
        ' ucrReceiverCombineText.SetParameter(New RParameter("columns"))
        ' ucrReceiverCombineText. TODO: This cannot be either SetParameterIsString() or GetVariableNamesAsList()
        ucrReceiverCombineText.Selector = ucrSelectorForCombineText
        ucrReceiverCombineText.SetMeAsReceiver()
        ucrReceiverCombineText.bUseFilteredData = False

        ucrInputSeparator.SetParameter(New RParameter("sep", iNewPosition:=0))
        dctSeparator.Add("Space ( )", Chr(34) & " " & Chr(34))
        dctSeparator.Add("No Space ()", Chr(34) & "" & Chr(34))
        dctSeparator.Add("Period .", Chr(34) & "." & Chr(34))
        dctSeparator.Add("Hyphen -", Chr(34) & "-" & Chr(34))
        dctSeparator.Add("Underscore _", Chr(34) & "_" & Chr(34))
        ucrInputSeparator.SetItems(dctSeparator)
        ucrInputSeparator.SetRDefault(Chr(34) & "" & Chr(34))
        ucrInputSeparator.bAllowNonConditionValues = True

        ' ucrSaveColumn
        ucrSaveColumn.SetIsTextBox()
        ucrSaveColumn.SetPrefix("Combine")
        ucrSaveColumn.SetSaveTypeAsColumn()
        ucrSaveColumn.SetDataFrameSelector(ucrSelectorForCombineText.ucrAvailableDataFrames)
        ucrSaveColumn.SetLabelText("Prefix for New Column:")
        iColumnsUsed = 0
    End Sub

    Private Sub SetDefaults()
        clsDefaultFunction = New RFunction
        ucrSelectorForCombineText.Reset()

        clsDefaultFunction.SetPackageName("stringr")
        clsDefaultFunction.SetRCommand("str_c")
        clsDefaultFunction.AddParameter("sep", Chr(34) & " " & Chr(34), iPosition:=0)
        clsDefaultFunction.SetAssignTo(strTemp:=ucrSaveColumn.GetText(), strTempDataframe:=ucrSelectorForCombineText.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrSaveColumn.GetText())

        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction)
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverCombineText.IsEmpty() AndAlso ucrSaveColumn.IsComplete() Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ReopenDialog()
        ColumnOrder()
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
                ucrBase.clsRsyntax.AddParameter("X" & i + 1, clsRFunctionParameter:=lstColumnFunction(i), iPosition:=i + 1)
            Next
        End If
    End Sub

    Private Sub ucrReceiverCombineText_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverCombineText.ControlValueChanged
        ColumnOrder()
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSaveColumn.ControlContentsChanged, ucrReceiverCombineText.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class