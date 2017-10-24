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

Public Class dlgHideDataframes
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsHideDataFramesFunction As New RFunction

    Private Sub dlgHideDataframes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        SetHiddenColumns()
        bReset = False
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrReceiverMultiple.SetParameter(New RParameter("data_names", 0))
        ucrReceiverMultiple.SetParameterIsString()
        ucrReceiverMultiple.Selector = ucrSelectorForDataFrames
        ucrReceiverMultiple.strSelectorHeading = "Data Frames"
        ucrReceiverMultiple.SetItemType("dataframe")
        ucrReceiverMultiple.SetMeAsReceiver()

    End Sub

    Private Sub SetDefaults()
        clsHideDataFramesFunction = New RFunction
        clsHideDataFramesFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$set_hidden_data_frames")
        ucrBase.clsRsyntax.SetBaseRFunction(clsHideDataFramesFunction)
    End Sub

    Private Sub TestOKEnabled()
        ' You cannot hide all data frames. When the receiver is blank all data frames are unhidden so this is allowed.
        If ucrReceiverMultiple.lstSelectedVariables.Items.Count <> ucrSelectorForDataFrames.lstAvailableVariable.Items.Count Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub SetHiddenColumns()
        Dim expTemp As SymbolicExpression
        Dim chrHiddenColumns As CharacterVector
        Dim clsGetHiddenDataFrames As New RFunction

        clsGetHiddenDataFrames.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_hidden_data_frames")

        ucrReceiverMultiple.Clear()
        expTemp = frmMain.clsRLink.RunInternalScriptGetValue(clsGetHiddenDataFrames.ToScript(), bSilent:=True)
        If expTemp IsNot Nothing AndAlso expTemp.Type <> Internals.SymbolicExpressionType.Null Then
            chrHiddenColumns = expTemp.AsCharacter
            For Each strDataFrame As String In chrHiddenColumns
                ucrReceiverMultiple.Add(strDataFrame)
            Next
        End If
    End Sub
End Class