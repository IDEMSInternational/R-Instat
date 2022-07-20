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
Imports System.IO
Public Class dlgApsimx
    Public bFirstLoad As Boolean = True
    Private bFromLibrary As Boolean = False
    Private strFilePath As String = ""
    Private strLibraryPath As String = Path.Combine(frmMain.strStaticPath, "Library", "Climatic", "Apsimxfiles/")
    Private bReset As Boolean = True
    Private clsApsimxExampleFunction, clsApsimExampleFunction As New RFunction
    'Public Sub New()
    '    ' This call is required by the designer.
    '    InitializeComponent()
    '    bFirstLoad = True
    '    ucrInputDataName.bAutoChangeOnLeave = True
    'End Sub

    Private Sub dlgApsimx_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 479

        ucrInputPath.IsReadOnly = True

        ucrChkSilent.SetText("Silent")
        ucrChkSilent.SetParameter(New RParameter("silent", 1))
        ucrChkSilent.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkSilent.SetRDefault("FALSE")

        ucrSaveFile.SetSaveTypeAsDataFrame()
        ucrSaveFile.SetLabelText("New Data Frame Name:")
        ucrSaveFile.SetIsTextBox()
    End Sub

    Private Sub SetDefaults()
        clsApsimxExampleFunction = New RFunction
        clsApsimExampleFunction = New RFunction


        'ucrInputDataName.SetName("")
        ucrInputPath.SetName("")
        clsApsimxExampleFunction.SetPackageName("apsimx")
        clsApsimxExampleFunction.SetRCommand("apsimx_example")

        clsApsimExampleFunction.SetPackageName("apsimx")
        clsApsimExampleFunction.SetRCommand("apsim_example")

        ucrBase.clsRsyntax.SetBaseRFunction(clsApsimxExampleFunction)

    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrChkSilent.AddAdditionalCodeParameterPair(clsApsimExampleFunction, New RParameter("silent", 1), iAdditionalPairNo:=1)

        ucrChkSilent.SetRCode(clsApsimxExampleFunction, bReset)
        ucrSaveFile.AddAdditionalRCode(clsApsimExampleFunction, bReset)
        ucrSaveFile.SetRCode(clsApsimxExampleFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If ucrSaveFile.IsComplete AndAlso ucrInputPath.Text <> "" Then
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

    Public Sub GetFileFromOpenDialog()
        Dim strFileName As String = ""
        Dim strFileExt As String = ""
        Dim strTemp As String = ""

        Using dlgOpen As New OpenFileDialog
            dlgOpen.Filter = "Apsimxfiles|*.apsimx|All Apsimxfiles|*.apsimx;*.apsim"
            dlgOpen.Title = "Import Shape File"
            If bFromLibrary Then
                dlgOpen.InitialDirectory = Path.GetDirectoryName(Replace(strLibraryPath, "/", "\"))
            ElseIf Not ucrInputPath.IsEmpty() Then
                dlgOpen.InitialDirectory = Path.GetDirectoryName(Replace(ucrInputPath.GetText(), "/", "\"))
            Else
                dlgOpen.InitialDirectory = frmMain.clsInstatOptions.strWorkingDirectory
            End If

            If dlgOpen.ShowDialog() = DialogResult.OK Then
                clsApsimxExampleFunction.RemoveParameterByName("path")
                If dlgOpen.FileName <> "" Then
                    strFileName = Path.GetFileNameWithoutExtension(dlgOpen.FileName)
                    strFilePath = dlgOpen.FileName
                    strFileExt = Path.GetExtension(strFilePath)
                    ucrInputPath.SetName(Replace(strFilePath, "\", "/"))
                    If strFileExt = ".apsimx" Then
                        ucrBase.clsRsyntax.SetBaseRFunction(clsApsimxExampleFunction)
                        ucrSaveFile.SetPrefix(strFileName)
                        clsApsimxExampleFunction.AddParameter("example", Chr(34) & strFileName & Chr(34), iPosition:=0)
                    Else
                        ucrBase.clsRsyntax.SetBaseRFunction(clsApsimExampleFunction)
                        ucrSaveFile.SetPrefix(strFileName)
                        clsApsimExampleFunction.AddParameter("example", Chr(34) & strFileName & Chr(34), iPosition:=0)
                    End If
                End If
            End If
        End Using
    End Sub

    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click
        GetFileFromOpenDialog()
    End Sub

    Private Sub ucrInputPath_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSaveFile.ControlContentsChanged, ucrInputPath.ControlContentsChanged, ucrChkSilent.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class