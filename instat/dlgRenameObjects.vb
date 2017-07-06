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
Public Class dlgRenameObjects
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Dim bUseSelectedColumn As Boolean = False
    Dim strSelectedColumn As String = ""
    Dim strSelectedDataFrame As String = ""

    Private Sub dlgRenameObjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeforControls(bReset)
        bReset = False
        autoTranslate(Me)
        If bUseSelectedColumn Then
            Setdefaultcolumn()
        End If
    End Sub

    Private Sub ReopenDialog()
        ' temp. fix, the receivers should clear only if the name of the object in it has changed
        ucrSelectorForRenameObject.Reset()
        NewDefaultName()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 350

        'ucrSelector
        ucrSelectorForRenameObject.SetParameter(New RParameter("data_name", 0))
        ucrSelectorForRenameObject.SetParameterIsString()

        'ucrReceiver
        ucrReceiverCurrentName.SetParameter(New RParameter("object_name", 1))
        ucrReceiverCurrentName.Selector = ucrSelectorForRenameObject
        ucrReceiverCurrentName.SetMeAsReceiver()
        ucrReceiverCurrentName.SetParameterIsString()
        ucrReceiverCurrentName.SetItemType("object")
        ucrReceiverCurrentName.strSelectorHeading = "Objects"

        'ucrNewName
        ucrInputNewName.SetParameter(New RParameter("new_name", 2))
        ucrInputNewName.SetValidationTypeAsRVariable()

        NewDefaultName()
    End Sub

    Private Sub SetDefaults()
        Dim clsDefaultFunction As New RFunction

        ucrSelectorForRenameObject.Reset()
        ucrInputNewName.Reset()

        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$rename_object")
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If (Not ucrReceiverCurrentName.IsEmpty) AndAlso (Not ucrInputNewName.IsEmpty) AndAlso (ucrReceiverCurrentName.GetVariableNames(bWithQuotes:=False) <> ucrInputNewName.GetText) AndAlso (ucrSelectorForRenameObject.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "") Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrs_ContentsChanged() Handles ucrInputNewName.ControlContentsChanged, ucrSelectorForRenameObject.ControlContentsChanged, ucrReceiverCurrentName.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Public Sub Setcurrentcolumn(strcolumn As String, strdataframe As String)
        strSelectedColumn = strcolumn
        strSelectedDataFrame = strdataframe
        bUseSelectedColumn = True
    End Sub

    Private Sub Setdefaultcolumn()
        ucrSelectorForRenameObject.SetDataframe(strSelectedDataFrame)
        ucrReceiverCurrentName.Add(strSelectedColumn, strSelectedDataFrame)
        bUseSelectedColumn = False
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrInputNewName_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverCurrentName.ControlValueChanged
        NewDefaultName()
    End Sub

    Private Sub NewDefaultName()
        If Not ucrReceiverCurrentName.IsEmpty AndAlso Not ucrInputNewName.bUserTyped Then
            ucrInputNewName.SetName(ucrReceiverCurrentName.GetVariableNames(bWithQuotes:=False) & "1")
        End If
    End Sub
End Class