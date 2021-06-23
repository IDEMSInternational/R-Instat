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
    Private strSelectedDataFrame As String = ""
    Private ucrBaseSelector As ucrSelector
    Private bControlsInitialised As Boolean = False
    Private bClearComments As Boolean
    Private clsListFunction As RFunction
    Private clsCommentsListFunction As RFunction
    Private clsSaveDataEntryFunction As RFunction
    Private clsGetKeyFunction As RFunction
    Private iNumComments As Integer = 0

    Private Sub sdgCommentForDataEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseControls()
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
        ucrReceiverColumn.SetMeAsReceiver()

        ucrInputComment.SetParameter(New RParameter("comment", iNewPosition:=3))
        ucrInputComment.IsMultiline = True
        bControlsInitialised = True

        ttcmdAddComment.SetToolTip(ucrInputComment.txtInput, "Add Comment button is enabled when the key exists in the data frame and the input comment is not empty.")
    End Sub

    Public Sub SetUpCommentsSubdialog(clsNewSaveDataEntry As RFunction, clsNewGetKey As RFunction,
                      clsNewCommentsList As RFunction, clsNewList As RFunction, strDataFrame As String,
                                      Optional strRow As String = "", Optional strColumn As String = "", Optional ucrNewBaseSelector As ucrSelector = Nothing, Optional bReset As Boolean = False)

        If Not bControlsInitialised Then
            InitialiseControls()
        End If

        clsSaveDataEntryFunction = clsNewSaveDataEntry
        clsGetKeyFunction = clsNewGetKey
        clsCommentsListFunction = clsNewCommentsList
        clsListFunction = clsNewList
        ucrBaseSelector = ucrNewBaseSelector

        If ucrBaseSelector IsNot Nothing AndAlso ucrBaseSelector.strCurrentDataFrame <> "" Then
            strSelectedDataFrame = ucrBaseSelector.strCurrentDataFrame
            ucrSelectorAddComment.SetDataframe(strSelectedDataFrame, False)
            clsGetKeyFunction.AddParameter("data_name", Chr(34) & strSelectedDataFrame & Chr(34), iPosition:=0)
        Else
            clsGetKeyFunction.RemoveParameterByName("data_name")
        End If

        ucrSelectorAddComment.SetRCode(clsCommentsListFunction, bReset, bCloneIfNeeded:=True)
        ucrInputComment.SetRCode(clsCommentsListFunction, bReset, bCloneIfNeeded:=True)
        ucrInputRow.SetRCode(clsCommentsListFunction, bReset, bCloneIfNeeded:=True)
        ucrReceiverColumn.SetRCode(clsCommentsListFunction, bReset, bCloneIfNeeded:=True)

        ucrInputRow.SetName(strRow)
        If strColumn <> "" AndAlso strRow <> "" Then
            ucrReceiverColumn.Add(strColumn, strSelectedDataFrame)
            rdoCell.Checked = True
        ElseIf strColumn <> "" AndAlso strRow = "" Then
            ucrReceiverColumn.Add(strColumn, strSelectedDataFrame)
            rdoColumn.Checked = True
        ElseIf strColumn = "" AndAlso strRow <> "" Then
            rdoRow.Checked = True
        Else
            rdoDataFrame.Checked = True
        End If

        If bReset Then
            EnableDisableAddComment()
            iNumComments = 0
        End If
    End Sub

    Private Sub EnableDisableAddComment()
        Dim expTemp As SymbolicExpression
        If clsGetKeyFunction IsNot Nothing Then
            expTemp = frmMain.clsRLink.RunInternalScriptGetValue(clsGetKeyFunction.ToScript(), bSilent:=True)
            If expTemp IsNot Nothing AndAlso expTemp.AsCharacter(0) = "TRUE" AndAlso Not ucrInputComment.IsEmpty Then
                cmdAddComment.Enabled = True
            Else
                cmdAddComment.Enabled = False
            End If
        End If
    End Sub

    Private Sub ucrPnlCellRowColumnDataFrame_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlCellRowColumnDataFrame.ControlValueChanged
        ucrSelectorAddComment.ShowColumnSelector(rdoCell.Checked OrElse rdoColumn.Checked)
    End Sub

    Private Sub cmdAddComment_Click(sender As Object, e As EventArgs) Handles cmdAddComment.Click
        clsListFunction.AddParameter("C" & iNumComments, clsRFunctionParameter:=clsCommentsListFunction, iPosition:=iNumComments)
        iNumComments = iNumComments + 1
        Me.Close()
    End Sub

    Public Property GetSetNumberOfCommentsEntered As Integer
        Get
            Return iNumComments
        End Get
        Set(value As Integer)
            iNumComments = value
        End Set
    End Property

    Private Sub ucrInputComment_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputComment.ControlContentsChanged
        EnableDisableAddComment()
    End Sub

    Public Sub ClearComments()
        If bClearComments Then
            clsListFunction.ClearParameters()
            iNumComments = 0
        End If
    End Sub
End Class