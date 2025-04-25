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
    Public iMaxWidth As Nullable(Of Integer)
    Public iMaxCols As Nullable(Of Integer)
    Public iUndoColLimit As Nullable(Of Integer)
    Public iUndoRowLimit As Nullable(Of Integer)
    Public lstColourPalette As List(Of Color)
    Public strGraphDisplayOption As String
    Public bCommandsinOutput As Nullable(Of Boolean)
    Public bIncludeCommentDefault As Nullable(Of Boolean) 'sets the default for comments on the dialog
    Public bShowProcurementMenu As Nullable(Of Boolean)
    Public bShowTricotMenu As Nullable(Of Boolean)
    Public bShowTricotXpMenu As Nullable(Of Boolean)
    Public bShowStructuredMenu As Nullable(Of Boolean)
    Public bShowClimaticMenu As Nullable(Of Boolean)
    Public bShowOptionsByContextMenu As Nullable(Of Boolean)
    Public iDigits As Nullable(Of Integer)
    Public bShowSignifStars As Nullable(Of Boolean)
    Public bChangeDataFrame As Nullable(Of Boolean)
    Public bAutoSaveData As Nullable(Of Boolean)
    Public bSwitchOffUndo As Nullable(Of Boolean)
    Public bUndoSwitchAction As Nullable(Of Boolean)
    Public iAutoSaveDataMinutes As Nullable(Of Integer)
    Public bShowWaitDialog As Nullable(Of Boolean)
    Public iWaitTimeDelaySeconds As Nullable(Of Integer)
    Public iToolbarHeight As Nullable(Of Integer)
    Public strClimsoftDatabaseName As String
    Public strClimsoftHost As String
    Public strClimsoftPort As String
    Public strClimsoftUsername As String
    Public iMaxOutputsHeight As Nullable(Of Integer)
    Public bRemindLaterOption As Nullable(Of Boolean)

    Public Sub New(Optional bSetOptions As Boolean = True)
        'TODO Is this sensible to do in constructor?
        bIncludeRDefaultParameters = clsInstatOptionsDefaults.DEFAULTbIncludeRDefaultParameters
        bCommandsinOutput = clsInstatOptionsDefaults.DEFAULTbCommandsinOutput
        bRemindLaterOption = clsInstatOptionsDefaults.DEFAULTbRemindLaterOption
        bIncludeCommentDefault = clsInstatOptionsDefaults.DEFAULTbIncludeCommentDefault
        bShowClimaticMenu = clsInstatOptionsDefaults.DEFAULTbShowClimaticMenu
        bShowStructuredMenu = clsInstatOptionsDefaults.DEFAULTbShowStructuredMenu
        bShowProcurementMenu = clsInstatOptionsDefaults.DEFAULTbShowProcurementMenu
        bShowTricotMenu = clsInstatOptionsDefaults.DEFAULTbShowTricotMenu
        bShowTricotXpMenu = clsInstatOptionsDefaults.DEFAULTbShowTricotXpMenu
        bShowOptionsByContextMenu = clsInstatOptionsDefaults.DEFAULTbShowOptionsByContextMenu
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
        iMaxWidth = clsInstatOptionsDefaults.DEFAULTiMaxWidth
        iMaxCols = clsInstatOptionsDefaults.DEFAULTiMaxCols
        iUndoColLimit = clsInstatOptionsDefaults.DEFAULTiUndoColLimit
        iUndoRowLimit = clsInstatOptionsDefaults.DEFAULTiUndoRowLimit
        strComment = Translations.GetTranslation(clsInstatOptionsDefaults.DEFAULTstrComment)
        strGraphDisplayOption = clsInstatOptionsDefaults.DEFAULTstrGraphDisplayOption
        strLanguageCultureCode = clsInstatOptionsDefaults.DEFAULTstrLanguageCultureCode
        strWorkingDirectory = clsInstatOptionsDefaults.DEFAULTstrWorkingDirectory
        lstColourPalette = clsInstatOptionsDefaults.DEFAULTlstColourPalette
        iDigits = clsInstatOptionsDefaults.DEFAULTiDigits
        bShowSignifStars = clsInstatOptionsDefaults.DEFAULTbShowSignifStars
        bChangeDataFrame = clsInstatOptionsDefaults.DEFAULTbChangeDataFrame
        bAutoSaveData = clsInstatOptionsDefaults.DEFAULTbAutoSaveData
        bSwitchOffUndo = clsInstatOptionsDefaults.DEFAULTbSwitchOffUndo
        iAutoSaveDataMinutes = clsInstatOptionsDefaults.DEFAULTiAutoSaveDataMinutes
        bShowWaitDialog = clsInstatOptionsDefaults.DEFAULTbShowWaitDialog
        iWaitTimeDelaySeconds = clsInstatOptionsDefaults.DEFAULTiWaitTimeDelaySeconds
        iToolbarHeight = clsInstatOptionsDefaults.DEFAULTiToolbarHeight
        strClimsoftDatabaseName = clsInstatOptionsDefaults.DEFAULTstrClimsoftDatabaseName
        strClimsoftHost = clsInstatOptionsDefaults.DEFAULTstrClimsoftHost
        strClimsoftPort = clsInstatOptionsDefaults.DEFAULTstrClimsoftPort
        strClimsoftUsername = clsInstatOptionsDefaults.DEFAULTstrClimsoftUsername
        iMaxOutputsHeight = clsInstatOptionsDefaults.DEFAULTiMaxOutputsHeight
        If bSetOptions Then
            SetDefaultValuesToOptionsNotSet()
        End If
    End Sub

    ''' <summary>
    ''' sets the default values to options that have not been set with values
    ''' </summary>
    Public Sub SetDefaultValuesToOptionsNotSet()
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

        If iMaxWidth.HasValue Then
            SetMaxWidth(iMaxWidth)
        Else
            SetMaxWidth(clsInstatOptionsDefaults.DEFAULTiMaxWidth)
        End If

        If iMaxCols.HasValue Then
            SetMaxCols(iMaxCols)
        Else
            SetMaxCols(clsInstatOptionsDefaults.DEFAULTiMaxCols)
        End If

        If iUndoColLimit.HasValue Then
            SetUndoColLimit(iUndoColLimit)
        Else
            SetUndoColLimit(clsInstatOptionsDefaults.DEFAULTiUndoColLimit)
        End If

        If iUndoRowLimit.HasValue Then
            SetUndoRowLimit(iUndoRowLimit)
        Else
            SetUndoRowLimit(clsInstatOptionsDefaults.DEFAULTiUndoRowLimit)
        End If

        If bCommandsinOutput.HasValue Then
            SetCommandInOutpt(bCommandsinOutput)
        Else
            SetCommandInOutpt(clsInstatOptionsDefaults.DEFAULTbCommandsinOutput)
        End If

        If bRemindLaterOption.HasValue Then
            SetRemindLaterOption(bRemindLaterOption)
        Else
            SetRemindLaterOption(clsInstatOptionsDefaults.DEFAULTbRemindLaterOption)
        End If

        If strComment Is Nothing Then
            SetComment(Translations.GetTranslation(clsInstatOptionsDefaults.DEFAULTstrComment))
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

        If bShowOptionsByContextMenu.HasValue Then
            SetShowOptionsByContextMenu(bShowOptionsByContextMenu)
        Else
            SetShowOptionsByContextMenu(clsInstatOptionsDefaults.DEFAULTbShowOptionsByContextMenu)
        End If

        If bShowTricotMenu.HasValue Then
            SetShowTricotMenu(bShowTricotMenu)
        Else
            SetShowTricotMenu(clsInstatOptionsDefaults.DEFAULTbShowTricotMenu)
        End If

        If bShowTricotXpMenu.HasValue Then
            SetShowTricotXpMenu(bShowTricotXpMenu)
        Else
            SetShowTricotXpMenu(clsInstatOptionsDefaults.DEFAULTbShowTricotXpMenu)
        End If

        If bShowProcurementMenu.HasValue Then
            SetShowProcurementMenu(bShowProcurementMenu)
        Else
            SetShowProcurementMenu(clsInstatOptionsDefaults.DEFAULTbShowProcurementMenu)
        End If

        If bShowStructuredMenu.HasValue Then
            SetShowStructuredMenu(bShowStructuredMenu)
        Else
            SetShowStructuredMenu(clsInstatOptionsDefaults.DEFAULTbShowStructuredMenu)
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

        If bSwitchOffUndo.HasValue Then
            SetOffUndo(bSwitchOffUndo)
        Else
            SetOffUndo(clsInstatOptionsDefaults.DEFAULTbSwitchOffUndo)
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

        If strClimsoftDatabaseName IsNot Nothing Then
            SetClimsoftDatabaseName(strClimsoftDatabaseName)
        Else
            SetClimsoftDatabaseName(clsInstatOptionsDefaults.DEFAULTstrClimsoftDatabaseName)
        End If

        If strClimsoftHost IsNot Nothing Then
            SetClimsoftHost(strClimsoftHost)
        Else
            SetClimsoftHost(clsInstatOptionsDefaults.DEFAULTstrClimsoftHost)
        End If

        If strClimsoftPort IsNot Nothing Then
            SetClimsoftPort(strClimsoftPort)
        Else
            SetClimsoftPort(clsInstatOptionsDefaults.DEFAULTstrClimsoftPort)
        End If

        If strClimsoftUsername IsNot Nothing Then
            SetClimsoftUsername(strClimsoftUsername)
        Else
            SetClimsoftUsername(clsInstatOptionsDefaults.DEFAULTstrClimsoftUsername)
        End If

        SetMaximumOutputsHeight(If(iMaxOutputsHeight Is Nothing, clsInstatOptionsDefaults.DEFAULTiMaxOutputsHeight, iMaxOutputsHeight))

    End Sub

    ''' <summary>
    ''' executes the set R options if they have been changed or not set in the R environment
    ''' </summary>
    Public Sub ExecuteRGlobalOptions()
        Dim clsOptionsFunction As New RFunction
        Dim strROption As String

        clsOptionsFunction.SetRCommand("options")

        'add "digits" as options parameter of its been changed
        strROption = GetROption("digits")
        If strROption Is Nothing OrElse strROption <> iDigits.ToString Then
            clsOptionsFunction.AddParameter("digits", iDigits)
        End If

        'add "show.signif.stars" as options parameter of its been changed
        strROption = GetROption("show.signif.stars")
        If strROption Is Nothing OrElse strROption <> bShowSignifStars.ToString Then
            clsOptionsFunction.AddParameter("show.signif.stars", If(bShowSignifStars, "TRUE", "FALSE"))
        End If

        'add "dplyr.summarise.inform"" as options parameter of it was not set as FALSE
        strROption = GetROption("dplyr.summarise.inform")
        If strROption Is Nothing OrElse strROption <> False.ToString Then
            clsOptionsFunction.AddParameter("dplyr.summarise.inform", "FALSE")
        End If

        strROption = GetROption("width")
        If strROption Is Nothing OrElse strROption <> iMaxWidth.ToString Then
            clsOptionsFunction.AddParameter("width", iMaxWidth)
        End If

        'add "R.commands.displayed.in.the.output.window" as options parameter of its been changed
        If frmMain.mnuShowRCommand.Checked Then
            clsOptionsFunction.AddParameter("R.commands.displayed.in.the.output.window", "TRUE")
        Else
            clsOptionsFunction.AddParameter("R.commands.displayed.in.the.output.window", "FALSE")
        End If

        'add "Comments.from.dialogs.displayed.in.the.output.window" as options parameter of its been changed
        If frmMain.mnuIncludeComments.Checked Then
            clsOptionsFunction.AddParameter("Comments.from.dialogs.displayed.in.the.output.window", "TRUE")
        Else
            clsOptionsFunction.AddParameter("Comments.from.dialogs.displayed.in.the.output.window", "FALSE")
        End If

        frmMain.clsRLink.RunScript(clsOptionsFunction.ToScript(),
                                   strComment:="Setting display options (e.g Number of significant digits)")

    End Sub

    ''' <summary>
    ''' gets an option from R environment if it's been set
    ''' </summary>
    ''' <param name="strOptionName"></param>
    ''' <returns>string representation of the R option</returns>
    Private Function GetROption(strOptionName As String) As String
        Dim expression As SymbolicExpression
        Dim clsGetOptionFunction As New RFunction
        clsGetOptionFunction.SetRCommand("getOption")
        clsGetOptionFunction.AddParameter("x", Chr(34) & strOptionName & Chr(34))
        expression = frmMain.clsRLink.RunInternalScriptGetValue(clsGetOptionFunction.ToScript(), bSilent:=True)
        Return If(expression Is Nothing OrElse expression.Type = Internals.SymbolicExpressionType.Null, Nothing, expression.AsCharacter(0))
    End Function

    Public Sub SetUndoColLimit(iNewUndoColLimit As Integer)
        iUndoColLimit = iNewUndoColLimit
    End Sub

    Public Sub SetUndoRowLimit(iNewUndoRowLimit As Integer)
        iUndoRowLimit = iNewUndoRowLimit
    End Sub

    Public Sub SetMaxRows(iRows As Integer)
        iMaxRows = iRows
        frmMain.UpdateAllGrids()
    End Sub

    Public Sub SetMaxWidth(iNewMaxWidth As Integer)
        iMaxWidth = iNewMaxWidth
        'frmMain.UpdateAllGrids()
    End Sub
    Public Sub SetMaxCols(iCols As Integer)
        iMaxCols = iCols
        frmMain.UpdateAllGrids()
    End Sub

    Public Sub SetFormatOutput(fntNew As Font, clrNew As Color)
        'TODO OutputFont should be the one saved back and loaded up
        'currently need to keep fntOutput for saving
        OutputFont.ROutputFont = fntNew
        OutputFont.ROutputColour = clrNew
        fntOutput = fntNew
        clrOutput = clrNew
    End Sub

    Public Sub SetFormatScript(fntNew As Font, clrNew As Color)
        OutputFont.RSyntacticNameFont = fntNew
        OutputFont.RFunctionNameFont = fntNew
        OutputFont.RKeyWordFont = fntNew
        OutputFont.RConstantStringFont = fntNew
        OutputFont.RSpaceFont = fntNew
        OutputFont.RBracketFont = fntNew
        OutputFont.RSeparatorFont = fntNew
        OutputFont.REndStatementFont = fntNew
        OutputFont.RNewLineFont = fntNew
        OutputFont.ROperatorUnaryLeftFont = fntNew
        OutputFont.ROperatorUnaryRightFont = fntNew
        OutputFont.ROperatorBinaryFont = fntNew
        OutputFont.ROperatorBracketFont = fntNew
        OutputFont.RPresentationFont = fntNew
        OutputFont.RInvalidFont = fntNew

        OutputFont.RSyntacticNameColour = clrNew
        OutputFont.RFunctionNameColour = clrNew
        OutputFont.RKeyWordColour = clrNew
        OutputFont.RConstantStringColour = clrNew
        OutputFont.RSpaceColour = clrNew
        OutputFont.RBracketColour = clrNew
        OutputFont.RSeparatorColour = clrNew
        OutputFont.REndStatementColour = clrNew
        OutputFont.RNewLineColour = clrNew
        OutputFont.ROperatorUnaryLeftColour = clrNew
        OutputFont.ROperatorUnaryRightColour = clrNew
        OutputFont.ROperatorBinaryColour = clrNew
        OutputFont.ROperatorBracketColour = clrNew
        OutputFont.RPresentationColour = clrNew
        OutputFont.RInvalidColour = clrNew
        fntScript = fntNew
        clrScript = clrNew
    End Sub

    Public Sub SetFormatComment(fntNew As Font, clrNew As Color)
        OutputFont.RCommentFont = fntNew
        OutputFont.RCommentColour = clrNew
        fntComment = fntNew
        clrComment = clrNew
    End Sub

    Public Sub SetFormatEditor(fntNew As Font, clrNew As Color)
        fntEditor = fntNew
        clrEditor = clrNew
        frmMain.UpdateFontsOnlyOnAllGrids()
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
                Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-GB")
            Case "fr-FR"
                Thread.CurrentThread.CurrentUICulture = New CultureInfo("fr-FR")
            Case "sw-KE"
                Thread.CurrentThread.CurrentUICulture = New CultureInfo("sw-KE")
            Case "es-ES"
                Thread.CurrentThread.CurrentUICulture = New CultureInfo("es-ES")
            Case Else
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

    Public Sub SetRemindLaterOption(bRemind As Boolean)
        bRemindLaterOption = bRemind
    End Sub

    Public Sub SetCommandInOutpt(bCommand As Boolean)
        bCommandsinOutput = bCommand
        frmMain.clsRLink.bShowCommands = bCommandsinOutput
    End Sub

    Public Sub SetCommentsInOutput(bComment As Boolean)
        bCommandsinOutput = bComment
    End Sub

    Public Sub SetDigits(iNewDigits As Integer)
        If iNewDigits > 22 OrElse iNewDigits < 0 Then
            MsgBox("Cannot set digits to: " & iNewDigits & ". Digits must be an integer between 0 and 22.", MsgBoxStyle.Critical, "Error setting digits")
        Else
            iDigits = iNewDigits
        End If
    End Sub

    Public Sub SetSignifStars(bShowStars As Boolean)
        bShowSignifStars = bShowStars
    End Sub

    Public Sub SetChangeDataFrame(bNewChange As Boolean)
        bChangeDataFrame = bNewChange
    End Sub

    Public Sub SetIncludeCommentByDefault(bNewInclude As Boolean)
        bIncludeCommentDefault = bNewInclude
    End Sub

    Public Sub SetShowTricotMenu(bNewShowTricotMenu As Boolean)
        bShowTricotMenu = bNewShowTricotMenu
        frmMain.SetShowTricotMenu(bNewShowTricotMenu)
    End Sub

    Public Sub SetShowTricotXpMenu(bNewShowTricotXpMenu As Boolean)
        bShowTricotXpMenu = bNewShowTricotXpMenu
        frmMain.SetShowTricotXpMenu(bNewShowTricotXpMenu)
    End Sub

    Public Sub SetShowProcurementMenu(bNewShowProcurementMenu As Boolean)
        bShowProcurementMenu = bNewShowProcurementMenu
        frmMain.SetShowProcurementMenu(bNewShowProcurementMenu)
    End Sub

    Public Sub SetShowStructuredMenu(bNewShowStructuredMenu As Boolean)
        bShowStructuredMenu = bNewShowStructuredMenu
        frmMain.SetShowStructuredMenu(bNewShowStructuredMenu)
    End Sub

    Public Sub SetShowClimaticMenu(bNewShowClimaticMenu As Boolean)
        bShowClimaticMenu = bNewShowClimaticMenu
        frmMain.SetShowClimaticMenu(bNewShowClimaticMenu)
    End Sub

    Public Sub SetShowOptionsByContextMenu(bNewShowOptionsByContextMenu As Boolean)
        bShowOptionsByContextMenu = bNewShowOptionsByContextMenu
        frmMain.SetShowOptionsByContextMenu(bNewShowOptionsByContextMenu)
    End Sub

    Public Sub SetIncludeRDefaultParameters(bNewInclude As Boolean)
        bIncludeRDefaultParameters = bNewInclude
    End Sub

    Public Sub SetAutoSaveData(bNewAutoSave As Boolean)
        bAutoSaveData = bNewAutoSave
    End Sub

    Public Sub SetOffUndo(bNewSwitchOffUndo As Boolean)
        bSwitchOffUndo = bNewSwitchOffUndo
    End Sub

    Public Sub SetAutoSaveDataMinutes(iNewMinutes As Integer)
        iAutoSaveDataMinutes = iNewMinutes
        frmMain.ResetTimer()
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

    Public Sub SetClimsoftDatabaseName(strNewClimsoftDatabaseName As String)
        strClimsoftDatabaseName = strNewClimsoftDatabaseName
    End Sub

    Public Sub SetClimsoftHost(strNewClimsoftHost As String)
        strClimsoftHost = strNewClimsoftHost
    End Sub

    Public Sub SetClimsoftPort(strNewClimsoftPort As String)
        strClimsoftPort = strNewClimsoftPort
    End Sub

    Public Sub SetClimsoftUsername(strNewClimsoftUsername As String)
        strClimsoftUsername = strNewClimsoftUsername
    End Sub

    Public Sub SetMaximumOutputsHeight(iNewMaxOutputsHeight As Integer)
        iMaxOutputsHeight = iNewMaxOutputsHeight
    End Sub

End Class