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

Imports instat
Imports instat.Translations
Public Class dlgDefineRedFlags
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Dim bUseSelectedColumn As Boolean = False
    Dim strSelectedColumn As String = ""
    Dim strSelectedDataFrame As String = ""
    Private clsRedFlag As New RFunction

    Private Sub dlgDefineRedFlags_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bUseSelectedColumn Then
            SetDefaultColumn()
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        SetRedFlagColumnsInReceiver()
        bReset = False
    End Sub

    Private Sub SetDefaults()
        clsRedFlag = New RFunction

        ucrSelectorDefineRedFlag.Reset()

        clsRedFlag.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$define_red_flags")
        ucrBase.clsRsyntax.SetBaseRFunction(clsRedFlag)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 202
        'selector
        ucrSelectorDefineRedFlag.SetParameter(New RParameter("data_name", 0))
        ucrSelectorDefineRedFlag.SetParameterIsString()

        'ucrreceiver
        ucrReceiverRedFlag.SetParameter(New RParameter("red_flags", 1))
        ucrReceiverRedFlag.SetParameterIsString()

        ucrReceiverRedFlag.Selector = ucrSelectorDefineRedFlag
        ucrReceiverRedFlag.SetMeAsReceiver()
    End Sub

    Public Sub SetCurrentColumn(strColumn As String, strDataFrame As String)
        strSelectedColumn = strColumn
        strSelectedDataFrame = strDataFrame
        bUseSelectedColumn = True
    End Sub

    Private Sub SetDefaultColumn()
        ucrSelectorDefineRedFlag.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem = strSelectedDataFrame
        ucrReceiverRedFlag.Add(strSelectedColumn, strSelectedDataFrame)
        bUseSelectedColumn = False
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverRedFlag.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        SetRedFlagColumnsInReceiver()
        TestOKEnabled()
    End Sub

    Private Sub SetRedFlagColumnsInReceiver()
        ucrReceiverRedFlag.AddItemsWithMetadataProperty(ucrSelectorDefineRedFlag.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "Is_Corruption_Red_Flag", {"TRUE"})
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverRedFlag.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrSelectorDefineRedFlag_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorDefineRedFlag.ControlValueChanged
        SetRedFlagColumnsInReceiver()
    End Sub
End Class