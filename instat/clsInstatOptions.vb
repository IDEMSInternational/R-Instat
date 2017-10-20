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

Imports System.Threading
Imports System.Globalization
Imports unvell.ReoGrid
Imports RDotNet

'Serializable allows the class to be exported as a file
<Serializable()> Public Class InstatOptions
    Public fntOutput, fntScript, fntComment, fntEditor As Font
    Public clrOutput, clrScript, clrComment, clrEditor As Color
    Public strComment, strLanguageCultureCode As String
    Public strWorkingDirectory As String
    ' Nullable allows us to have integers and booleans with value = Nothing
    ' Needed so we can check if variable has been specified, not just has default value
    Public bIncludeRDefaultParameters As Nullable(Of Boolean)
    Public iPreviewRows As Nullable(Of Integer)
    Public iMaxRows As Nullable(Of Integer)
    Public iMaxCols As Nullable(Of Integer)
    Public lstColourPalette As List(Of Color)
    Public strGraphDisplayOption As String
    Public bCommandsinOutput As Nullable(Of Boolean)
    Public bIncludeCommentDefault As Nullable(Of Boolean) 'sets the default for comments on the dialog
    Public bShowProcurementMenu As Nullable(Of Boolean)
    Public bShowClimaticMenu As Nullable(Of Boolean)
    Public iDigits As Nullable(Of Integer)
    Public bShowSignifStars As Nullable(Of Boolean)
    Public bChangeDataFrame As Nullable(Of Boolean)
    Public bAutoSaveData As Nullable(Of Boolean)
    Public iAutoSaveDataMinutes As Nullable(Of Integer)
    Public bShowWaitDialog As Nullable(Of Boolean)
    Public iWaitTimeDelaySeconds As Nullable(Of Integer)
    Public iToolbarHeight As Nullable(Of Integer)

    Public Sub New(Optional bSetOptions As Boolean = True)
        'TODO Is this sensible to do in constructor?
        bIncludeRDefaultParameters = clsInstatOptionsDefaults.DEFAULTbIncludeRDefaultParameters
        bCommandsinOutput = clsInstatOptionsDefaults.DEFAULTbCommandsinOutput
        bIncludeCommentDefault = clsInstatOptionsDefaults.DEFAULTbIncludeCommentDefault
        bShowClimaticMenu = clsInstatOptionsDefaults.DEFAULTbShowClimaticMenu
        bShowProcurementMenu = clsInstatOptionsDefaults.DEFAULTbShowProcurementMenu
        fntOutput = clsInstatOptionsDefaults.DEFAULTfntOutput
        clrOutput = clsInstatOptionsDefaults.DEFAULTclrOutput
        fntComment = clsInstatOptionsDefaults.DEFAULTfntComment
        clrComment = clsInstatOptionsDefaults.DEFAULTclrComment
        fntScript = clsInstatOptionsDefaults.DEFAULTfntScript
        clrScript = clsInstatOptionsDefaults.DEFAULTclrScript
        fntEditor = clsInstatOptionsDefaults.DEFAULTfntEditor
        clrEditor = clsInstatOptionsDefaults.DEFAULTclrEditor
        iPreviewRows = clsInstatOptionsDefaults.DEFAULTiPreviewRows
        iMaxRows = clsInstatOptionsDefaults.DEFAULTiMaxRows
        iMaxCols = clsInstatOptionsDefaults.DEFAULTiMaxCols
        strComment = clsInstatOptionsDefaults.DEFAULTstrComment
        strGraphDisplayOption = clsInstatOptionsDefaults.DEFAULTstrGraphDisplayOption
        strLanguageCultureCode = clsInstatOptionsDefaults.DEFAULTstrLanguageCultureCode
        strWorkingDirectory = clsInstatOptionsDefaults.DEFAULTstrWorkingDirectory
        lstColourPalette = clsInstatOptionsDefaults.DEFAULTlstColourPalette
        iDigits = clsInstatOptionsDefaults.DEFAULTiDigits
        bShowSignifStars = clsInstatOptionsDefaults.DEFAULTbShowSignifStars
        bChangeDataFrame = clsInstatOptionsDefaults.DEFAULTbChangeDataFrame
        bAutoSaveData = clsInstatOptionsDefaults.DEFAULTbAutoSaveData
        iAutoSaveDataMinutes = clsInstatOptionsDefaults.DEFAULTiAutoSaveDataMinutes
        bShowWaitDialog = clsInstatOptionsDefaults.DEFAULTbShowWaitDialog
        iWaitTimeDelaySeconds = clsInstatOptionsDefaults.DEFAULTiWaitTimeDelaySeconds
        iToolbarHeight = clsInstatOptionsDefaults.DEFAULTiToolbarHeight
        If bSetOptions Then
            SetOptions()
        End If
    End Sub

    Public Sub SetOptions()
        If fntOutput IsNot Nothing AndAlso clrOutput <> Color.Empty Then
            SetFormatOutput(fntOutput, clrOutput)
        Else
            SetFormatOutput(clsInstatOptionsDefaults.DEFAULTfntOutput, clsInstatOptionsDefaults.DEFAULTclrOutput)
        End If

        If fntComment IsNot Nothing AndAlso clrComment <> Color.Empty Then
            SetFormatComment(fntComment, clrComment)
        Else
            SetFormatComment(clsInstatOptionsDefaults.DEFAULTfntComment, clsInstatOptionsDefaults.DEFAULTclrComment)
        End If

        If fntScript IsNot Nothing AndAlso clrScript <> Color.Empty Then
            SetFormatScript(fntScript, clrScript)
        Else
            SetFormatScript(clsInstatOptionsDefaults.DEFAULTfntScript, clsInstatOptionsDefaults.DEFAULTclrScript)
        End If

        If fntEditor IsNot Nothing AndAlso clrEditor <> Color.Empty Then
            SetFormatEditor(fntEditor, clrEditor)
        Else
            SetFormatEditor(clsInstatOptionsDefaults.DEFAULTfntEditor, clsInstatOptionsDefaults.DEFAULTclrEditor)
        End If

        If iPreviewRows.HasValue Then
            SetPreviewRows(iPreviewRows)
        Else
            SetPreviewRows(clsInstatOptionsDefaults.DEFAULTiPreviewRows)
        End If

        If iMaxRows.HasValue Then
            SetMaxRows(iMaxRows)
        Else
            SetMaxRows(clsInstatOptionsDefaults.DEFAULTiMaxRows)
        End If

        If iMaxCols.HasValue Then
            SetMaxCols(iMaxCols)
        Else
            SetMaxCols(clsInstatOptionsDefaults.DEFAULTiMaxCols)
        End If

        If bCommandsinOutput.HasValue Then
            SetCommandInOutpt(bCommandsinOutput)
        Else
            SetCommandInOutpt(clsInstatOptionsDefaults.DEFAULTbCommandsinOutput)
        End If

        If strComment IsNot Nothing Then
            SetComment(strComment)
        Else
            SetComment(clsInstatOptionsDefaults.DEFAULTstrComment)
        End If

        If strGraphDisplayOption IsNot Nothing Then
            SetGraphDisplayOption(strGraphDisplayOption)
        Else
            SetGraphDisplayOption(clsInstatOptionsDefaults.DEFAULTstrGraphDisplayOption)
        End If

        If strLanguageCultureCode IsNot Nothing Then
            SetLanguageCultureCode(strLanguageCultureCode)
        Else
            SetLanguageCultureCode(clsInstatOptionsDefaults.DEFAULTstrLanguageCultureCode)
        End If

        If strWorkingDirectory IsNot Nothing Then
            SetWorkingDirectory(strWorkingDirectory)
        Else
            SetWorkingDirectory(clsInstatOptionsDefaults.DEFAULTstrWorkingDirectory)
        End If

        If iDigits.HasValue Then
            SetDigits(iDigits)
        Else
            SetDigits(clsInstatOptionsDefaults.DEFAULTiDigits)
        End If

        If bShowSignifStars.HasValue Then
            SetSignifStars(bShowSignifStars)
        Else
            SetSignifStars(clsInstatOptionsDefaults.DEFAULTbShowSignifStars)
        End If

        If bChangeDataFrame.HasValue Then
            SetChangeDataFrame(bChangeDataFrame)
        Else
            SetChangeDataFrame(clsInstatOptionsDefaults.DEFAULTbChangeDataFrame)
        End If

        If bIncludeCommentDefault.HasValue Then
            SetIncludeCommentByDefault(bIncludeCommentDefault)
        Else
            SetIncludeCommentByDefault(clsInstatOptionsDefaults.DEFAULTbIncludeCommentDefault)
        End If

        If bShowProcurementMenu.HasValue Then
            SetShowProcurementMenu(bShowProcurementMenu)
        Else
            SetShowProcurementMenu(clsInstatOptionsDefaults.DEFAULTbShowProcurementMenu)
        End If

        If bShowClimaticMenu.HasValue Then
            SetShowClimaticMenu(bShowClimaticMenu)
        Else
            SetShowClimaticMenu(clsInstatOptionsDefaults.DEFAULTbShowClimaticMenu)
        End If

        If bIncludeRDefaultParameters.HasValue Then
            SetIncludeRDefaultParameters(bIncludeRDefaultParameters)
        Else
            SetIncludeRDefaultParameters(clsInstatOptionsDefaults.DEFAULTbIncludeRDefaultParameters)
        End If

        If lstColourPalette IsNot Nothing Then
            SetColorPalette(lstColourPalette)
        Else
            SetColorPalette(clsInstatOptionsDefaults.DEFAULTlstColourPalette)
        End If

        If bAutoSaveData.HasValue Then
            SetAutoSaveData(bAutoSaveData)
        Else
            SetAutoSaveData(clsInstatOptionsDefaults.DEFAULTbAutoSaveData)
        End If

        If iAutoSaveDataMinutes.HasValue Then
            SetAutoSaveDataMinutes(iAutoSaveDataMinutes)
        Else
            SetAutoSaveDataMinutes(clsInstatOptionsDefaults.DEFAULTiAutoSaveDataMinutes)
        End If

        If bShowWaitDialog.HasValue Then
            SetShowWaitDialog(bShowWaitDialog)
        Else
            SetShowWaitDialog(clsInstatOptionsDefaults.DEFAULTbShowWaitDialog)
        End If

        If iWaitTimeDelaySeconds.HasValue Then
            SetWaitTimeDelaySeconds(iWaitTimeDelaySeconds)
        Else
            SetWaitTimeDelaySeconds(clsInstatOptionsDefaults.DEFAULTiWaitTimeDelaySeconds)
        End If

        If iToolbarHeight.HasValue Then
            SetToolbarHeight(iToolbarHeight)
        Else
            SetToolbarHeight(clsInstatOptionsDefaults.DEFAULTiToolbarHeight)
        End If
    End Sub

    Public Sub SetMaxRows(iRows As Integer)
        iMaxRows = iRows
        frmMain.clsGrids.SetMaxRows(iMaxRows)
    End Sub

    Public Sub SetMaxCols(iCols As Integer)
        iMaxCols = iCols
        frmMain.clsGrids.SetMaxCols(iMaxCols)
    End Sub

    Public Sub SetFormatOutput(fntNew As Font, clrNew As Color)
        fntOutput = fntNew
        clrOutput = clrNew
        frmMain.clsRLink.setFormatOutput(fntOutput, clrOutput)
    End Sub

    Public Sub SetFormatScript(fntNew As Font, clrNew As Color)
        fntScript = fntNew
        clrScript = clrNew
        frmMain.clsRLink.setFormatScript(fntScript, clrScript)
    End Sub

    Public Sub SetFormatComment(fntNew As Font, clrNew As Color)
        fntComment = fntNew
        clrComment = clrNew
        frmMain.clsRLink.setFormatComment(fntComment, clrComment)
    End Sub

    Public Sub SetFormatEditor(fntNew As Font, clrNew As Color)
        fntEditor = fntNew
        clrEditor = clrNew
        frmMain.clsGrids.SetFormatDataView(fntEditor, clrEditor)
    End Sub

    Public Sub SetPreviewRows(intlines As Integer)
        iPreviewRows = intlines
    End Sub

    Public Sub SetComment(strText As String)
        strComment = strText
    End Sub

    Public Sub SetLanguageCultureCode(strLanguage As String)
        strLanguageCultureCode = strLanguage
        Select Case strLanguageCultureCode
            Case "en-GB"
                Thread.CurrentThread.CurrentCulture = New CultureInfo("en-GB")
                Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-GB")
            Case "fr-FR"
                Thread.CurrentThread.CurrentCulture = New CultureInfo("fr-FR")
                Thread.CurrentThread.CurrentUICulture = New CultureInfo("fr-FR")
            Case "sw-KE"
                Thread.CurrentThread.CurrentCulture = New CultureInfo("sw-KE")
                Thread.CurrentThread.CurrentUICulture = New CultureInfo("sw-KE")
            Case "es-ES"
                Thread.CurrentThread.CurrentCulture = New CultureInfo("es-ES")
                Thread.CurrentThread.CurrentUICulture = New CultureInfo("es-ES")
            Case Else
                Thread.CurrentThread.CurrentCulture = New CultureInfo("en-GB")
                Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-GB")
        End Select
    End Sub

    Public Sub SetWorkingDirectory(strWD As String)
        Dim clsSetwdFunction As New RFunction

        clsSetwdFunction.SetRCommand("setwd")
        clsSetwdFunction.AddParameter("dir", Chr(34) & strWorkingDirectory & Chr(34))
        strWorkingDirectory = strWD
        'This is done in R link setup. Need to rethink how this is done.
        'Commented out for now to not repeat.
        'frmMain.clsRLink.RunScript(clsSetwdFunction.ToScript(), strComment:="Option: Setting working directory")
    End Sub

    Public Sub SetColorPalette(lstColours As List(Of Color))
        lstColourPalette = lstColours
    End Sub

    Public Sub SetGraphDisplayOption(strGraphOption As String)
        strGraphDisplayOption = strGraphOption
        'setting the string for graphs display
        frmMain.clsRLink.strGraphDisplayOption = strGraphDisplayOption
    End Sub

    Public Sub SetCommandInOutpt(bCommand As Boolean)
        bCommandsinOutput = bCommand
        frmMain.clsRLink.bShowCommands = bCommandsinOutput
    End Sub

    Public Sub SetCommentsInOutput(bComment As Boolean)
        bCommandsinOutput = bComment
    End Sub

    Public Sub SetDigits(iNewDigits As Integer)
        Dim clsOptionsFunction As New RFunction
        Dim clsGetOptionFunction As New RFunction
        Dim expCurrDigits As SymbolicExpression

        If iNewDigits > 22 OrElse iNewDigits < 0 Then
            MsgBox("Cannot set digits to: " & iNewDigits & ". Digits must be an integer between 0 and 22.", MsgBoxStyle.Critical, "Error setting digits")
        Else
            iDigits = iNewDigits
            clsGetOptionFunction.SetRCommand("getOption")
            clsGetOptionFunction.AddParameter("x", Chr(34) & "digits" & Chr(34))
            expCurrDigits = frmMain.clsRLink.RunInternalScriptGetValue(clsGetOptionFunction.ToScript(), bSilent:=True)
            If (expCurrDigits IsNot Nothing AndAlso expCurrDigits.Type <> Internals.SymbolicExpressionType.Null AndAlso expCurrDigits.AsInteger(0) <> iDigits) OrElse expCurrDigits Is Nothing Then
                clsOptionsFunction.SetRCommand("options")
                clsOptionsFunction.AddParameter("digits", iDigits)
                frmMain.clsRLink.RunScript(clsOptionsFunction.ToScript(), strComment:="Option: Number of digits to display")
            End If
        End If
    End Sub

    Public Sub SetSignifStars(bShowStars As Boolean)
        Dim clsOptionsFunction As New RFunction
        Dim clsGetOptionsFunction As New RFunction
        Dim expCurrStars As SymbolicExpression

        bShowSignifStars = bShowStars
        clsGetOptionsFunction.SetRCommand("getOption")
        clsGetOptionsFunction.AddParameter("x", Chr(34) & "show.signif.stars" & Chr(34))
        clsOptionsFunction.SetRCommand("options")
        expCurrStars = frmMain.clsRLink.RunInternalScriptGetValue(clsGetOptionsFunction.ToScript(), bSilent:=True)
        If (expCurrStars IsNot Nothing AndAlso expCurrStars.Type <> Internals.SymbolicExpressionType.Null AndAlso expCurrStars.AsLogical(0) <> bShowSignifStars) OrElse expCurrStars Is Nothing Then
            If bShowSignifStars Then
                clsOptionsFunction.AddParameter("show.signif.stars", "TRUE")
            Else
                clsOptionsFunction.AddParameter("show.signif.stars", "FALSE")
            End If
            frmMain.clsRLink.RunScript(clsOptionsFunction.ToScript(), strComment:="Option: Show stars on summary tables of coefficients")
        End If
    End Sub

    Public Sub SetChangeDataFrame(bNewChange As Boolean)
        bChangeDataFrame = bNewChange
    End Sub

    Public Sub SetIncludeCommentByDefault(bNewInclude As Boolean)
        bIncludeCommentDefault = bNewInclude
    End Sub

    Public Sub SetShowProcurementMenu(bNewShowProcurementMenu As Boolean)
        bShowProcurementMenu = bNewShowProcurementMenu
        frmMain.SetShowProcurementMenu(bNewShowProcurementMenu)
    End Sub

    Public Sub SetShowClimaticMenu(bNewShowClimaticMenu As Boolean)
        bShowClimaticMenu = bNewShowClimaticMenu
        frmMain.SetShowClimaticMenu(bNewShowClimaticMenu)
    End Sub

    Public Sub SetIncludeRDefaultParameters(bNewInclude As Boolean)
        bIncludeRDefaultParameters = bNewInclude
    End Sub

    Public Sub SetAutoSaveData(bNewAutoSave As Boolean)
        bAutoSaveData = bNewAutoSave
    End Sub

    Public Sub SetAutoSaveDataMinutes(iNewMinutes As Integer)
        iAutoSaveDataMinutes = iNewMinutes
    End Sub

    Public Sub SetShowWaitDialog(bNewShow As Boolean)
        bShowWaitDialog = bNewShow
        frmMain.clsRLink.SetShowWaitDialog(bShowWaitDialog)
    End Sub

    Public Sub SetWaitTimeDelaySeconds(iNewTimeInSeconds As Integer)
        iWaitTimeDelaySeconds = iNewTimeInSeconds
        frmMain.clsRLink.SetWaitDelayTime(iWaitTimeDelaySeconds)
    End Sub

    Public Sub SetToolbarHeight(iNewToolbarHeight As Integer)
        iToolbarHeight = iNewToolbarHeight
        frmMain.SetToolbarHeight(iToolbarHeight)
    End Sub
End Class