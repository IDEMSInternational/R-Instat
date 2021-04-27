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
Public Class sdgCommentForDataEntry
    Private bUseSelectedPosition As Boolean = False
    Private strSelectedDataFrame As String = ""
    Private strSelectedRow As String = ""
    Private strSelectedColumn As String = ""
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bClearComments As Boolean
    Public clsList As RFunction
    Private clsCommentsList As RFunction
    Private clsSaveDataEntry As RFunction
    Private clsGetKey As RFunction
    Private iNumComments As Integer = 0

    Private Sub sdgCommentForDataEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        bReset = False
        autoTranslate(Me)
        SetRCodeForControls(bReset)
        If bUseSelectedPosition Then
            SetDefaultPosition()
        End If
    End Sub

    Private Sub InitialiseDialog()
        ucrPnlCellRowColumnDataFrame.AddRadioButton(rdoCell)
        ucrPnlCellRowColumnDataFrame.AddRadioButton(rdoRow)
        ucrPnlCellRowColumnDataFrame.AddRadioButton(rdoColumn)
        ucrPnlCellRowColumnDataFrame.AddRadioButton(rdoDataFrame)

        ucrPnlCellRowColumnDataFrame.AddParameterPresentCondition(rdoCell, "column")
        ucrPnlCellRowColumnDataFrame.AddParameterPresentCondition(rdoCell, "row")
        ucrPnlCellRowColumnDataFrame.AddParameterPresentCondition(rdoRow, "row")
        ucrPnlCellRowColumnDataFrame.AddParameterPresentCondition(rdoColumn, "column")
        ucrPnlCellRowColumnDataFrame.AddParameterPresentCondition(rdoColumn, "row", False)
        ucrPnlCellRowColumnDataFrame.AddParameterPresentCondition(rdoRow, "column", False)
        ucrPnlCellRowColumnDataFrame.AddParameterPresentCondition(rdoDataFrame, "column", False)
        ucrPnlCellRowColumnDataFrame.AddParameterPresentCondition(rdoDataFrame, "row", False)


        ucrPnlCellRowColumnDataFrame.AddToLinkedControls(ucrReceiverColumn, {rdoCell, rdoColumn}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrPnlCellRowColumnDataFrame.AddToLinkedControls(ucrInputRow, {rdoCell, rdoRow}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrInputRow.SetLinkedDisplayControl(lblRow)
        ucrReceiverColumn.SetLinkedDisplayControl(lblColumn)

        ucrSelectorAddComment.SetParameter(New RParameter("data_name", 0))
        ucrSelectorAddComment.SetParameterIsString()

        ucrInputRow.SetParameter(New RParameter("row", iNewPosition:=1))
        ucrInputRow.SetValidationTypeAsNumeric()

        ucrReceiverColumn.Selector = ucrSelectorAddComment
        ucrReceiverColumn.SetParameter(New RParameter("column", iNewPosition:=2))
        ucrReceiverColumn.SetParameterIsString()

        ucrInputComment.SetParameter(New RParameter("comment", iNewPosition:=3))

        ttcmdAddComment.SetToolTip(cmdAddComment, "This is Enable when the key exits in the data frame and the input comment is not empty.")
    End Sub

    Private Sub SetDefaults()
        clsCommentsList = New RFunction
        clsList = New RFunction
        clsGetKey = New RFunction

        ucrSelectorAddComment.Reset()
        ucrInputComment.IsMultiline = True

        cmdAddComment.Enabled = False

        ucrReceiverColumn.SetMeAsReceiver()

        clsGetKey.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_keys")
        clsGetKey.AddParameter("key_name", Chr(34) & "key" & Chr(34), iPosition:=0)
        clsCommentsList.SetRCommand("list")

        clsList.SetRCommand("list")
        bClearComments = True
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrSelectorAddComment.AddAdditionalCodeParameterPair(clsGetKey, ucrSelectorAddComment.GetParameter(), iAdditionalPairNo:=1)
        ucrSelectorAddComment.SetRCode(clsCommentsList, bReset)
        ucrInputComment.SetRCode(clsCommentsList, bReset)
        ucrInputRow.SetRCode(clsCommentsList, bReset)
        ucrReceiverColumn.SetRCode(clsCommentsList, bReset)
    End Sub

    Private Sub SetDefaultPosition()
        ucrSelectorAddComment.SetDataframe(strSelectedDataFrame)
        ucrInputRow.SetName(strSelectedRow)
        If strSelectedColumn <> "" AndAlso strSelectedRow <> "" Then
            ucrReceiverColumn.Add(strSelectedColumn, strSelectedDataFrame)
            rdoCell.Checked = True
        ElseIf strSelectedColumn <> "" AndAlso strSelectedRow = "" Then
            ucrReceiverColumn.Add(strSelectedColumn, strSelectedDataFrame)
            rdoColumn.Checked = True
        ElseIf strSelectedColumn = "" AndAlso strSelectedRow <> "" Then
            rdoRow.Checked = True
        Else
            rdoDataFrame.Checked = True
        End If
        strSelectedDataFrame = ""
        strSelectedRow = ""
        strSelectedColumn = ""
        bUseSelectedPosition = False
    End Sub

    Public Sub SetRfunctions(clsNewSaveDataEntry As RFunction)
        clsSaveDataEntry = clsNewSaveDataEntry
        EnableDisableAddComment()
    End Sub

    Private Sub EnableDisableAddComment()
        If Not ucrInputComment.IsEmpty Then
            Dim expTemp As SymbolicExpression
            expTemp = frmMain.clsRLink.RunInternalScriptGetValue(clsGetKey.ToScript(), bSilent:=True)
            If expTemp IsNot Nothing Then
                cmdAddComment.Enabled = True
            Else
                cmdAddComment.Enabled = False
            End If
        End If
    End Sub

    Public Sub SetPosition(strDataFrame As String, Optional strRow As String = "", Optional strColumn As String = "")
        strSelectedDataFrame = strDataFrame
        strSelectedRow = strRow
        strSelectedColumn = strColumn
        bUseSelectedPosition = True
    End Sub

    Private Sub ucrPnlCellRowColumnDataFrame_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlCellRowColumnDataFrame.ControlValueChanged
        ucrSelectorAddComment.ShowColumnSelector(rdoCell.Checked OrElse rdoColumn.Checked)
    End Sub

    Private Sub cmdAddComment_Click(sender As Object, e As EventArgs) Handles cmdAddComment.Click
        clsList.AddParameter("C" & iNumComments, clsRFunctionParameter:=clsCommentsList, iPosition:=iNumComments)
        iNumComments = iNumComments + 1
        Me.Close()
    End Sub

    Public Function NbCommentEntered() As Integer
        Return iNumComments
    End Function

    Private Sub ucrInputComment_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputComment.ControlContentsChanged
        EnableDisableAddComment()
    End Sub

    Public Sub ClearInputComment()
        ucrInputComment.ResetText()
    End Sub
    Public Sub ClearComments()
        If bClearComments Then
            clsList.ClearParameters()
            iNumComments = 0
        End If
    End Sub
End Class