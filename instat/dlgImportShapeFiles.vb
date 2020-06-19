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

Public Class dlgImportShapeFiles
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bFromLibrary As Boolean = False
    Private strFilePath As String = ""
    Private clsPipeOperator As New ROperator
    Private strLibraryPath As String = Path.Combine(frmMain.strStaticPath, "Library", "Climatic", "Shapefiles/")
    Private clsReadShapeFiles As New RFunction
    Private clsDummyRcode As New RCodeStructure
    Private clsMutateFunction, clsMapdblFunction, clsMapdbl2Function, clsStCentroidFunction As New RFunction

    Private Sub dlgImportShapeFiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        'TODO:Disabled temporarily
        cmdLibrary.Enabled = False

        ucrInputFilePath.IsReadOnly = True
        ucrSaveDataframeName.SetSaveTypeAsDataFrame()
        ucrSaveDataframeName.SetIsTextBox()
        ucrSaveDataframeName.SetLabelText("Dataframe Name:")

        ucrChkSplitGeometry.SetText("Split Geometry")
        ucrChkSplitGeometry.AddParameterPresentCondition(True, "mutate")
        ucrChkSplitGeometry.AddParameterPresentCondition(False, "mutate", False)

    End Sub

    Private Sub SetDefaults()
        clsReadShapeFiles = New RFunction
        clsMapdblFunction = New RFunction
        clsMutateFunction = New RFunction
        clsStCentroidFunction = New RFunction
        clsMapdbl2Function = New RFunction
        clsPipeOperator = New ROperator

        ucrSaveDataframeName.SetName("")
        ucrInputFilePath.SetName("")

        clsReadShapeFiles.SetPackageName("sf")
        clsReadShapeFiles.SetRCommand("st_read")
        clsReadShapeFiles.AddParameter("quiet", "TRUE", iPosition:=1)

        clsMutateFunction.SetPackageName("dplyr")
        clsMutateFunction.SetRCommand("mutate")
        clsMutateFunction.AddParameter("lon", clsRFunctionParameter:=clsMapdblFunction, iPosition:=1)
        clsMutateFunction.AddParameter("lat", clsRFunctionParameter:=clsMapdbl2Function, iPosition:=2)

        clsMapdblFunction.SetPackageName("purrr")
        clsMapdblFunction.SetRCommand("map_dbl")
        clsMapdblFunction.AddParameter("geometry", "geometry", bIncludeArgumentName:=False, iPosition:=0)
        clsMapdblFunction.AddParameter("st_centroid", "~sf::st_centroid(.x)[[1]]", bIncludeArgumentName:=False, iPosition:=1)

        clsMapdbl2Function.SetPackageName("purrr")
        clsMapdbl2Function.SetRCommand("map_dbl")
        clsMapdbl2Function.AddParameter("geometry", "geometry", bIncludeArgumentName:=False, iPosition:=0)
        clsMapdbl2Function.AddParameter("st_centroid", "~sf::st_centroid(.x)[[2]]", bIncludeArgumentName:=False, iPosition:=1)

        clsStCentroidFunction.SetPackageName("sf")
        clsStCentroidFunction.SetRCommand("st_centroid")

        clsPipeOperator.SetOperation("%>%")
        clsPipeOperator.AddParameter("st_read", clsRFunctionParameter:=clsReadShapeFiles, bIncludeArgumentName:=False, iPosition:=0)
        clsPipeOperator.AddParameter("mutate", clsRFunctionParameter:=clsMutateFunction, bIncludeArgumentName:=False, iPosition:=1)

        clsDummyRcode = clsPipeOperator
        ucrBase.clsRsyntax.SetBaseROperator(clsPipeOperator)
    End Sub

    Public Sub GetFileFromOpenDialog()
        Dim strFileName As String = ""
        Dim strFileExt As String = ""
        Dim strTemp As String = ""

        Using dlgOpen As New OpenFileDialog
            dlgOpen.Filter = "Shapefiles|*.shp|All Shapefiles|*.shp;*.dbf;*shx"
            dlgOpen.Title = "Import Shape File"

            If bFromLibrary Then
                dlgOpen.InitialDirectory = Path.GetDirectoryName(Replace(strLibraryPath, "/", "\"))
            ElseIf Not ucrInputFilePath.IsEmpty() Then
                dlgOpen.InitialDirectory = Path.GetDirectoryName(Replace(ucrInputFilePath.GetText(), "/", "\"))
            Else
                dlgOpen.InitialDirectory = frmMain.clsInstatOptions.strWorkingDirectory
            End If

            If dlgOpen.ShowDialog() = DialogResult.OK Then

                If dlgOpen.FileName <> "" Then
                    strFileName = Path.GetFileNameWithoutExtension(dlgOpen.FileName)
                    strFilePath = dlgOpen.FileName
                    strFileExt = Path.GetExtension(strFilePath)
                    ucrInputFilePath.SetName(Replace(strFilePath, "\", "/"))
                    If strFileExt = ".shp" OrElse strFileExt = ".dbf" OrElse strFileExt = ".shx" Then
                        ucrSaveDataframeName.SetName(frmMain.clsRLink.MakeValidText(strFileName))
                        clsReadShapeFiles.AddParameter("dsn", Chr(34) & Replace(strFilePath, "\", "/") & Chr(34))
                    End If
                End If
            End If
        End Using
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrSaveDataframeName.SetRCode(clsDummyRcode, bReset)
        ucrChkSplitGeometry.SetRCode(clsDummyRcode, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrInputFilePath.IsEmpty AndAlso ucrSaveDataframeName.IsComplete Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If

    End Sub

    Private Sub cmdLibrary_Click(sender As Object, e As EventArgs) Handles cmdLibrary.Click
        bFromLibrary = True
        GetFileFromOpenDialog()
        bFromLibrary = False
    End Sub

    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click
        GetFileFromOpenDialog()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrInputFilePath_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputFilePath.ControlContentsChanged, ucrSaveDataframeName.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrChkSplitGeometry_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSplitGeometry.ControlValueChanged
        If ucrChkSplitGeometry.Checked Then
            clsDummyRcode = clsPipeOperator
            ucrBase.clsRsyntax.SetBaseROperator(clsPipeOperator)
            clsReadShapeFiles.RemoveAssignTo()
        Else
            clsDummyRcode = clsReadShapeFiles
            ucrBase.clsRsyntax.SetBaseRFunction(clsReadShapeFiles)
            clsPipeOperator.RemoveAssignTo()
        End If
        ucrSaveDataframeName.SetRCode(clsDummyRcode)
    End Sub
End Class