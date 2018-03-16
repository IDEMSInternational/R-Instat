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
Public Class dlgStandardiseCountryNames
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsStandardiseCountryNames As New RFunction
    Public strDefaultDataFrame As String = ""
    Public strDefaultColumn As String = ""

    Private Sub dlgStandardiseCountryNames_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        SetDefaultColumn()
        bReset = False
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 530

        'ucrSelector
        ucrSelectorStandardiseCountry.SetParameter(New RParameter("data_name", 0))
        ucrSelectorStandardiseCountry.SetParameterIsString()

        'ucrReceiver
        ucrReceiverCountryNames.SetParameter(New RParameter("country_columns", 1))
        ucrReceiverCountryNames.SetParameterIsString()
        ucrReceiverCountryNames.SetIncludedDataTypes({"factor", "character"})
        ucrReceiverCountryNames.strSelectorHeading = "Characters"
        ucrReceiverCountryNames.Selector = ucrSelectorStandardiseCountry
        ucrReceiverCountryNames.SetMeAsReceiver()
    End Sub

    Private Sub SetDefaults()
        clsStandardiseCountryNames = New RFunction

        ucrSelectorStandardiseCountry.Reset()

        clsStandardiseCountryNames.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$standardise_country_names")
        ucrBase.clsRsyntax.SetBaseRFunction(clsStandardiseCountryNames)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverCountryNames.IsEmpty Then
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

    Private Sub SetDefaultColumn()
        If strDefaultDataFrame <> "" Then
            ucrSelectorStandardiseCountry.SetDataframe(strDefaultDataFrame)
        End If
        If strDefaultColumn <> "" Then
            ucrReceiverCountryNames.Add(strDefaultColumn, strDefaultDataFrame)
        End If
        strDefaultDataFrame = ""
        strDefaultColumn = ""
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverCountryNames.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class