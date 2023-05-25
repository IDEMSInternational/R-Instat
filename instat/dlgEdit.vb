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
Imports RDotNet
Imports unvell.ReoGrid
Imports unvell.ReoGrid.Events

Public Class dlgEdit
    Dim bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsReplaceValue As New RFunction
    Private strRowText As String = ""
    Private strRowIndex As String = ""
    Private bUseSelectedColumn As Boolean = False
    Private strSelectedColumn As String = ""


    Private Sub dlgEdit_Load(sender As Object, e As EventArgs) Handles Me.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        If bUseSelectedColumn Then
            SetSelectedColumn()
        End If
        SetRCodeForControls(bReset)
        bReset = True
        TestOKEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()

        ucrSelectValues.SetParameter(New RParameter("data_name", 0))
        ucrSelectValues.SetParameterIsString()

        ucrReceiverName.SetParameter(New RParameter("column_name", 1))
        ucrReceiverName.Selector = ucrSelectValues
        ucrReceiverName.SetParameterIsString()

        ucrNewName.SetParameter(New RParameter("new_value", 2))
        ucrNewName.SetValidationTypeAsList()


        ucrInputRows.SetFactorReceiver(ucrReceiverName)
        ucrInputRows.SetParameter(New RParameter("new_value", 3))
        ucrInputRows.strQuotes = ""


        ucrInputRows.SetLinkedDisplayControl(lblNewValue)
    End Sub

    Private Sub SetDefaults()
        clsReplaceValue = New RFunction
        ucrSelectValues.Reset()

        clsReplaceValue.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$replace_value_in_data")
        clsReplaceValue.AddParameter("data_name", Chr(34) & ucrSelectValues.strCurrentDataFrame & Chr(34), iPosition:=0)
        clsReplaceValue.AddParameter("col_name", Chr(34) & strSelectedColumn & Chr(34), iPosition:=1)
        clsReplaceValue.AddParameter("rows", Chr(34) & strRowIndex & Chr(34), iPosition:=2)
        ucrBase.clsRsyntax.SetBaseRFunction(clsReplaceValue)

    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrSelectValues.SetRCode(clsReplaceValue, bReset)
        ucrNewName.SetRCode(clsReplaceValue, bReset)
        ucrInputRows.SetRCode(clsReplaceValue, bReset)
    End Sub

    Private Sub TestOKEnabled()
        ucrBase.OKEnabled(Not ucrNewName.IsEmpty OrElse Not ucrInputRows.IsEmpty)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub SetSelectedColumn()
        ucrReceiverName.Add(strSelectedColumn)
        ucrReceiverRow.Add(strRowText)
        ucrRowNumber.SetName(strRowIndex)
        ucrNewName.SetName(strRowText)
        bUseSelectedColumn = False
    End Sub

    Private Sub ucrCoreControls_ControlContentsChanged() Handles ucrNewName.ControlContentsChanged, ucrReceiverName.ControlContentsChanged, ucrRowNumber.ControlContentsChanged, ucrInputRows.ControlContentsChanged, ucrReceiverRow.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Public Sub SetCurrentColumn(strColumn As String, strRowContents As String, strRowNumber As String)
        strSelectedColumn = strColumn
        strRowText = strRowContents
        strRowIndex = strRowNumber
        bUseSelectedColumn = True
    End Sub

    Private Sub ucrReceiverName_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverName.ControlValueChanged, ucrInputRows.ControlValueChanged
        If Not ucrReceiverName.IsEmpty Then
            ucrNewName.Visible = ucrInputRows.IsEmpty
        End If
    End Sub

    Private Sub ucrNewName_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNewName.ControlValueChanged
        Dim dblValue As Double
        Dim iValue As Integer
        Dim strNewValue As String = ucrNewName.GetText

        If Double.TryParse(strNewValue, dblValue) OrElse Integer.TryParse(strNewValue, iValue) Then
            clsReplaceValue.AddParameter("new_value", strNewValue, iPosition:=2)
        Else
            clsReplaceValue.AddParameter("new_value", Chr(34) & strNewValue & Chr(34), iPosition:=2)
        End If
    End Sub

End Class