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
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bFirstLevelDefault As Boolean = False
    Private clsReplaceValue As New RFunction
    Private strRowText As String = ""
    Private strRowIndex As String = ""
    Private bUseSelectedColumn As Boolean = False
    Private strSelectedColumn As String = ""
    Private strLastSelectedLevel As String = ""
    Private bDate As Boolean = False
    Private bNewName As Boolean = False
    Private bInputRow As Boolean = False
    Private bInputLogical As Boolean = False


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
        Dim dctLogical As New Dictionary(Of String, String)

        ucrBase.iHelpTopicID = 699
        ucrSelectValues.SetParameter(New RParameter("data_name", 0))
        ucrSelectValues.SetParameterIsString()
        ucrSelectValues.ucrAvailableDataFrames.Enabled = False
        ucrSelectValues.lstAvailableVariable.Visible = False
        ucrSelectValues.btnAdd.Visible = False
        ucrSelectValues.btnDataOptions.Visible = False

        ucrReceiverName.SetParameter(New RParameter("column_name", 1))
        ucrReceiverName.SetParameterIsString()
        ucrReceiverName.Selector = ucrSelectValues
        ucrReceiverName.bAsReceiver = False

        ucrNewName.SetValidationTypeAsList()

        ucrInputRows.SetFactorReceiver(ucrReceiverName, True)
        ucrInputRows.strQuotes = ""

        ucrDate.SetParameterIsRDate()


        ucrInputLogical.SetItems({"TRUE", "FALSE", "NA"})
        ucrInputLogical.bAllowNonConditionValues = False
    End Sub

    Private Sub SetDefaults()
        clsReplaceValue = New RFunction
        ucrSelectValues.Reset()
        strLastSelectedLevel = ""
        bFirstLevelDefault = True
        ucrDate.Format = DateTimePickerFormat.Custom
        ucrDate.Format = "yyyy-MM-dd"
        ucrInputLogical.GetSetSelectedIndex = 0
        ucrBase.cmdReset.Enabled = False

        clsReplaceValue.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$replace_value_in_data")
        clsReplaceValue.AddParameter("data_name", Chr(34) & ucrSelectValues.strCurrentDataFrame & Chr(34), iPosition:=0)
        clsReplaceValue.AddParameter("col_name", Chr(34) & strSelectedColumn & Chr(34), iPosition:=1)
        clsReplaceValue.AddParameter("rows", Chr(34) & strRowIndex & Chr(34), iPosition:=2)
        ucrBase.clsRsyntax.SetBaseRFunction(clsReplaceValue)
        SetControlProperties()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrSelectValues.SetRCode(clsReplaceValue, bReset)
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
        ucrInputRows.SetName(strRowText)
        ucrInputLogical.SetName(strRowText)
        bUseSelectedColumn = False
    End Sub

    Private Sub ucrCoreControls_ControlContentsChanged() Handles ucrNewName.ControlContentsChanged, ucrReceiverName.ControlContentsChanged, ucrRowNumber.ControlContentsChanged, ucrInputRows.ControlContentsChanged, ucrReceiverRow.ControlContentsChanged,
        ucrDate.ControlContentsChanged, ucrInputLogical.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Public Sub SetCurrentDataframe(strDataframe As String)
        ucrSelectValues.SetDataframe(strDataframe, True)
    End Sub


    Public Sub SetCurrentColumn(strColumn As String, strRowContents As String, strRowNumber As String)
        strSelectedColumn = strColumn
        strRowText = strRowContents
        strRowIndex = strRowNumber
        bUseSelectedColumn = True
    End Sub

    Private Sub ucrReceiverName_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverName.ControlValueChanged
        Dim expTemp As SymbolicExpression
        Dim strLevels() As String
        Dim lstLevels As New List(Of String)
        Dim clsFactor As New RFunction
        Dim clsLevels As New RFunction

        If ucrReceiverName Is Nothing OrElse ucrReceiverName.IsEmpty Then
            ucrInputRows.SetItems()
            ucrInputRows.Visible = True
        Else
            ' This is done because of bug in RunInternalScriptGetValue cannot return correct value when R code is multiple lines
            clsFactor.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
            clsFactor.AddParameter("data_name", Chr(34) & ucrSelectValues.strCurrentDataFrame & Chr(34))
            clsFactor.AddParameter("col_names", ucrReceiverName.GetVariableNames(True))
            clsFactor.RemoveAssignTo()
            clsLevels.SetRCommand("levels")
            clsLevels.AddParameter("x", clsRFunctionParameter:=clsFactor, iPosition:=0)
            ucrInputRows.Visible = False
            expTemp = frmMain.clsRLink.RunInternalScriptGetValue(clsLevels.ToScript(), bSilent:=True)
            If expTemp IsNot Nothing AndAlso expTemp.Type <> Internals.SymbolicExpressionType.Null Then
                Try
                    strLevels = expTemp.AsCharacter.ToArray
                    ucrInputRows.Visible = True
                Catch ex As Exception
                    strLevels = Nothing
                    ucrInputRows.Visible = False
                End Try
                For i As Integer = 0 To strLevels.Count - 1
                    lstLevels.Add(strLevels(i))
                Next
                ucrInputRows.SetItems(lstLevels.ToArray())

                'restore last selected level if its still contained in the new list of retrieved levels
                If strLastSelectedLevel <> "" AndAlso lstLevels.Contains(strLastSelectedLevel) Then
                    ucrInputRows.SetName(strLastSelectedLevel)
                ElseIf bFirstLevelDefault AndAlso lstLevels.Count > 0 Then
                    ucrInputRows.GetSetSelectedIndex = 0
                End If
            End If
        End If
        SetControlProperties()
    End Sub

    Private Sub ucrNewName_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNewName.ControlValueChanged
        Dim dblValue As Double
        Dim iValue As Integer
        Dim strNewValue As String = ucrNewName.GetText

        If bNewName Then
            If Double.TryParse(strNewValue, dblValue) OrElse Integer.TryParse(strNewValue, iValue) Then
                strNewValue = strNewValue
            Else
                strNewValue = Chr(34) & strNewValue & Chr(34)
            End If
            clsReplaceValue.AddParameter("new_value", strNewValue, iPosition:=2)
        End If
    End Sub

    Private Sub ucrInputRows_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputRows.ControlValueChanged
        If bInputRow Then
            Dim strValue As String = ucrInputRows.GetValue
            If strValue <> "NA" Then
                strValue = Chr(34) & strValue & Chr(34)
            End If
            clsReplaceValue.AddParameter("new_value", strValue, iPosition:=3)
        End If
    End Sub

    Private Sub SetControlProperties()
        ucrInputRows.Visible = False
        ucrDate.Visible = False
        ucrNewName.Visible = False
        ucrInputLogical.Visible = False
        If Not ucrReceiverName.IsEmpty() Then
            Select Case ucrReceiverName.strCurrDataType.ToLower
                Case "factor"
                    ucrInputRows.Visible = True
                    bInputRow = True
                    bInputLogical = False
                    bDate = False
                    bNewName = False
                Case "ordered,factor"
                    ucrInputRows.Visible = True
                    bInputRow = True
                    bInputLogical = False
                    bDate = False
                    bNewName = False
                Case "date"
                    ucrDate.Visible = True
                    bInputRow = False
                    bInputLogical = False
                    bDate = True
                    bNewName = False
                    Dim strDate As String() = ucrReceiverRow.GetVariableNames.Replace("""", "").Split("-")
                    If strDate.Length > 1 Then
                        ucrDate.DateValue = New Date(strDate(0), strDate(1), strDate(2))
                    End If
                Case "logical"
                    ucrInputLogical.Visible = True
                    bInputRow = False
                    bInputLogical = True
                    bDate = False
                    bNewName = False
                Case Else
                    ucrNewName.Visible = True
                    bInputRow = False
                    bInputLogical = False
                    bDate = False
                    bNewName = True
            End Select
        End If
    End Sub

    Private Sub ucrDate_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrDate.ControlValueChanged
        If bDate Then
            clsReplaceValue.AddParameter("new_value", clsRCodeStructureParameter:=ucrDate.ValueAsRDate(), iPosition:=3)
        End If
    End Sub

    Private Sub ucrInputogical_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputLogical.ControlValueChanged
        If bInputLogical Then
            Dim strValue As String = ucrInputLogical.GetValue
            clsReplaceValue.AddParameter("new_value", strValue, iPosition:=3)
        End If
    End Sub

    Private Sub ucrRowNumber_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrRowNumber.ControlValueChanged
        SetControlProperties()
    End Sub
End Class