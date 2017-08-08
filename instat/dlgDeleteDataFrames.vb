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
Public Class dlgDeleteDataFrames
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsDeleteFunction As New RFunction
    Private bUseSelectedDataFrame As Boolean = False
    Private strSelectedDataFrame As String = ""

    Private Sub dlgDeleteDataFrames_Load(sender As Object, e As EventArgs) Handles Me.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        ReopenDialog()
        If bUseSelectedDataFrame Then
            SetDefaultDataFrame()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 63

        ucrReceiverDataFrames.SetParameter(New RParameter("data_names", 0))
        ucrReceiverDataFrames.SetParameterIsString()
        ucrReceiverDataFrames.Selector = ucrSelectorDataFramesToDelete
        ucrReceiverDataFrames.SetMeAsReceiver()
        ucrReceiverDataFrames.SetItemType("dataframe")
        ucrReceiverDataFrames.strSelectorHeading = "Data Frames"
    End Sub

    Private Sub SetDefaults()
        clsDeleteFunction = New RFunction

        ucrSelectorDataFramesToDelete.Reset()

        clsDeleteFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$delete_dataframes")
        ucrBase.clsRsyntax.SetBaseRFunction(clsDeleteFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverDataFrames.IsEmpty Then
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

    Private Sub ReopenDialog()
        ucrSelectorDataFramesToDelete.Reset()
    End Sub

    Private Sub SetDefaultDataFrame()
        ucrReceiverDataFrames.Add(strSelectedDataFrame)
        bUseSelectedDataFrame = False
    End Sub

    Public Sub SetDataFrameToAdd(strNewSelectedDataFrame As String)
        strSelectedDataFrame = strNewSelectedDataFrame
        bUseSelectedDataFrame = True
    End Sub

    ' To be fixed and implemented in future versions
    'Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
    '    Dim strScript As String
    '    Dim Delete = MsgBox("Are you sure you want to delete this data frame?" & Environment.NewLine & "This action cannot be undone.", MessageBoxButtons.YesNo, "Delete Sheet")
    '    If Delete = DialogResult.Yes Then
    '        ' run base code
    ''        strScript = frmMain.clsRLink.strInstatDataObject & "$delete_dataframe"
    ''        frmMain.clsRLink.RunScript(strScript)
    '    Else
    '        'return to dialog
    '    End If
    'End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDataFrames.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class