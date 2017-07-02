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
Public Class dlgAppend
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsBindRows As New RFunction

    Private Sub dlgAppend_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 465

        ' ucrReceiver
        ucrReceiverAppendDataframe.SetParameter(New RParameter("x", 0))
        ucrReceiverAppendDataframe.SetParameterIsRFunction()
        ucrReceiverAppendDataframe.GetParameter().bIncludeArgumentName = False
        ucrReceiverAppendDataframe.Selector = ucrSelectorDataframes
        ucrReceiverAppendDataframe.SetMeAsReceiver()
        ucrReceiverAppendDataframe.SetItemType("dataframe")
        ucrReceiverAppendDataframe.strSelectorHeading = "Data Frames"

        'chkID
        SetParameter({ucrChkIncludeIDColumn, ucrInputIDColName}, New RParameter(".id", 1))
        ucrChkIncludeIDColumn.SetText("Include ID Column")
        ucrChkIncludeIDColumn.bChangeParameterValue = False
        ucrChkIncludeIDColumn.AddToLinkedControls(ucrLinked:=ucrInputIDColName, objValues:={True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputIDColName.bAddRemoveParameter = False
        ucrInputIDColName.SetLinkedDisplayControl(lblIDColName)

        ' ucrSave
        ucrSaveGraph.SetIsTextBox()
        ucrSaveGraph.SetSaveTypeAsDataFrame()
        ucrSaveGraph.SetLabelText("New Data Frame Name:")
        ucrSaveGraph.SetPrefix("Append")
    End Sub

    Private Sub SetDefaults()
        clsBindRows = New RFunction

        ucrSelectorDataframes.Reset()
        ucrSaveGraph.Reset()

        clsBindRows.SetPackageName("dplyr")
        clsBindRows.SetRCommand("bind_rows")
        clsBindRows.AddParameter(".id", Chr(34) & "id" & Chr(34))
        clsBindRows.SetAssignTo(ucrSaveGraph.GetText(), strTempDataframe:=ucrSaveGraph.GetText())

        ucrBase.clsRsyntax.SetBaseRFunction(clsBindRows)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If ucrReceiverAppendDataframe.lstSelectedVariables.Items.Count > 1 AndAlso ucrSaveGraph.IsComplete() Then
            If ucrChkIncludeIDColumn.Checked AndAlso ucrInputIDColName.IsEmpty Then
                ucrBase.OKEnabled(False)
            Else
                ucrBase.OKEnabled(True)
            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ReopenDialog()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverAppendDataframe_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverAppendDataframe.ControlContentsChanged, ucrSaveGraph.ControlContentsChanged, ucrChkIncludeIDColumn.ControlContentsChanged, ucrInputIDColName.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class