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
Public Class dlgCombineText
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private iColumnsUsed As Integer
    Private clsDefaultFunction As New RFunction
    Private clsAttach As New RFunction
    Private clsDetach As New RFunction
    Private clsColumnOperator As New ROperator

    Private lstRCodeStructure As List(Of RCodeStructure)

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
        ucrSaveColumn.SetIsComboBox()
        ucrSaveColumn.SetPrefix("Combine")
        ucrSaveColumn.SetSaveTypeAsColumn()
        ucrSaveColumn.SetDataFrameSelector(ucrSelectorForCombineText.ucrAvailableDataFrames)
        ucrSaveColumn.SetLabelText("Prefix for New Column:")
        iColumnsUsed = 0
    End Sub

    Private Sub SetRFunctionDefaultParameters()
        clsDefaultFunction.AddParameter("sep", Chr(34) & " " & Chr(34), iPosition:=0)
        clsDefaultFunction.SetAssignTo(strTemp:=ucrSaveColumn.GetText(), strTempDataframe:=ucrSelectorForCombineText.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrSaveColumn.GetText())
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction)
    End Sub

    Private Sub SetClAttachClsDetachDefaultPArameters()
        clsAttach.AddParameter("what", clsRFunctionParameter:=ucrSelectorForCombineText.ucrAvailableDataFrames.clsCurrDataFrame)
        clsDetach.AddParameter("name", clsRFunctionParameter:=ucrSelectorForCombineText.ucrAvailableDataFrames.clsCurrDataFrame)
        clsDetach.AddParameter("unload", "TRUE")
        ucrBase.clsRsyntax.AddToBeforeCodes(clsAttach)
        ucrBase.clsRsyntax.AddToAfterCodes(clsDetach)
    End Sub

    Private Sub ResetFunction()
        clsDefaultFunction = New RFunction
        clsAttach = New RFunction
        clsDetach = New RFunction
        clsColumnOperator = New ROperator

        clsColumnOperator.SetOperation(",")

        clsDetach.SetRCommand("detach")

        clsAttach.SetRCommand("attach")

        clsDefaultFunction.SetPackageName("stringr")
        clsDefaultFunction.SetRCommand("str_c")

    End Sub

    Private Sub SetDefaults()
        ResetFunction()
        SetClAttachClsDetachDefaultPArameters()

        ucrSelectorForCombineText.Reset()
        ucrSaveColumn.Reset()

        If IsNothing(lstRCodeStructure) Then
            SetRFunctionDefaultParameters()
        ElseIf lstRCodeStructure.Count = 1 Then
            If Not IsNothing(TryCast(lstRCodeStructure(0), RFunction)) Then
                If TryCast(lstRCodeStructure(0), RFunction).strRCommand = "str_c" Then
                    clsDefaultFunction = lstRCodeStructure(0)
                    ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction)
                Else
                    SetRFunctionDefaultParameters()
                    MsgBox("Developer error:This Dialogue only uses the ""str_c "" Function")
                End If
            End If
        Else
            MsgBox("Developer error: List of RCodeStructure must have only one RFunction")

        End If
        'Setting lstRcodeStructure to Nothing is important so that the dialogue isnt affected on reopening
        lstRCodeStructure = Nothing
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

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ColumnOrder()
        If Not ucrReceiverCombineText.IsEmpty Then
            Dim icolumnIndex As Integer = 0
            Dim chrstartCharacters As Char() = {"c", "("}
            Dim chrendCharacters As Char() = {")"}
            'removing the "c(" before the list of columns and ")" after thelist of columns 
            Dim strVariableNames As String = ucrReceiverCombineText.GetVariableNames(False).TrimStart(chrstartCharacters).TrimEnd(chrendCharacters)
            'Splitting the list of columns using comma
            Dim strColumns As String() = strVariableNames.Split(New Char() {","})

            clsColumnOperator.ClearParameters()
            For Each column As String In strColumns
                clsColumnOperator.AddParameter("col" & icolumnIndex, column, iPosition:=icolumnIndex)
                icolumnIndex = icolumnIndex + 1
            Next
            ucrBase.clsRsyntax.AddParameter("columns", clsROperatorParameter:=clsColumnOperator, bIncludeArgumentName:=False)
        Else
            ucrBase.clsRsyntax.RemoveParameter("column")
        End If
    End Sub

    Private Sub ucrReceiverCombineText_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverCombineText.ControlValueChanged
        ColumnOrder()
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSaveColumn.ControlContentsChanged, ucrReceiverCombineText.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Public Property lstScriptsRCodeStructure As List(Of RCodeStructure)
        Get
            Return lstRCodeStructure
        End Get
        Set(lstNewRCodeStructure As List(Of RCodeStructure))
            lstRCodeStructure = lstNewRCodeStructure
            bReset = True
        End Set
    End Property
End Class
