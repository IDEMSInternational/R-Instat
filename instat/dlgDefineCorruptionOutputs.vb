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

Imports instat.Translations
Public Class dlgDefineCorruptionOutputs
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Dim bUseSelectedColumn As Boolean = False
    Dim strSelectedColumn As String = ""
    Dim strSelectedDataFrame As String = ""
    Private clsCorruptionOutputs As New RFunction

    Private Sub dlgDefineCorruptionOutputs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        bReset = False

    End Sub

    Private Sub SetDefaults()
        'Reset 
        ucrSelectorCorruptionOutputs.Reset()
        clsCorruptionOutputs = New RFunction
        clsCorruptionOutputs.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$define_corruption_outputs")
        ucrBase.clsRsyntax.SetBaseRFunction(clsCorruptionOutputs)
    End Sub

    Private Sub InitialiseDialog()
        'helpID
        '  ucrBase.iHelpTopicID =

        'selector
        ucrSelectorCorruptionOutputs.SetParameter(New RParameter("data_name", 0))
        ucrSelectorCorruptionOutputs.SetParameterIsString()

        'ucrreceiver
        ucrReceiverCorruptionOutputs.SetParameter(New RParameter("output_columns", 1))
        ucrReceiverCorruptionOutputs.SetParameterIsString()
    End Sub

    Public Sub SetCurrentColumn(strColumn As String, strDataFrame As String)
        strSelectedColumn = strColumn
        strSelectedDataFrame = strDataFrame
        bUseSelectedColumn = True
    End Sub

    Private Sub SetDefaultColumn()
        ucrSelectorCorruptionOutputs.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem = strSelectedDataFrame
        ucrReceiverCorruptionOutputs.Add(strSelectedColumn, strSelectedDataFrame)
        bUseSelectedColumn = False
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverCorruptionOutputs.IsEmpty Then
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

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverCorruptionOutputs.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class