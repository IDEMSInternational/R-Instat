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
Imports instat
Imports instat.Translations
Public Class dlgAppend
    Public bFirstLoad As Boolean = True
    Private clsBindRows, clsDefaultBindRows As New RFunction

    Private Sub dlgAppend_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 465

        ' ucrReceiver
        ucrReceiverAppendDataframe.SetParameter(New RParameter("x", 0))
        ucrReceiverAppendDataframe.GetParameter().bIncludeArgumentName = False
        ucrReceiverAppendDataframe.SetParameterIsRFunction()
        ucrReceiverAppendDataframe.Selector = ucrSelectorDataframes
        ucrReceiverAppendDataframe.SetMeAsReceiver()
        ucrReceiverAppendDataframe.SetItemType("dataframe")

        'clsRFunctionParameter:=ucrReceiverAppendDataframe.GetVariables, bIncludeArgumentName:=False) 

        ' ucrSave
        ucrSaveGraph.SetIsTextBox()
        ucrSaveGraph.SetSaveTypeAsDataFrame()
        ucrSaveGraph.SetLabelText("New Data Frame Name:")


        'chkID
        SetParameter({ucrChkIncludeIDColumn, ucrInputIDColName}, New RParameter(".id", 1))
        ucrChkIncludeIDColumn.SetText("Include ID Column")
        ucrChkIncludeIDColumn.bChangeParameterValue = False
        ucrChkIncludeIDColumn.AddToLinkedControls(ucrLinked:=ucrInputIDColName, objValues:={True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputIDColName.bAddRemoveParameter = False
        ucrInputIDColName.SetLabel(lblIDColName)


        'Default Function
        clsDefaultBindRows.SetRCommand("bind_rows")
        clsDefaultBindRows.AddParameter(".id", Chr(34) & "id" & Chr(34))
        clsDefaultBindRows.SetAssignTo(strTemp:="Append", strTempDataframe:="Append")
    End Sub

    Private Sub SetDefaults()
        clsBindRows = clsDefaultBindRows.Clone()
        ucrBase.clsRsyntax.SetBaseRFunction(clsBindRows)
        ucrSelectorDataframes.Reset()
        ucrSaveGraph.Reset()
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, True)
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverAppendDataframe.IsEmpty AndAlso ucrSaveGraph.IsComplete() Then
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
    End Sub

    Private Sub ucrReceiverAppendDataframe_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverAppendDataframe.ControlContentsChanged, ucrSaveGraph.ControlContentsChanged, ucrChkIncludeIDColumn.ControlContentsChanged, ucrInputIDColName.ControlContentsChanged
        TestOKEnabled()
    End Sub

End Class