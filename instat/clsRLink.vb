﻿' R- Instat
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

Imports System.Runtime.InteropServices
Imports RDotNet
Imports unvell.ReoGrid
Imports System.IO
Imports RInsightF461

'''--------------------------------------------------------------------------------------------
''' <summary>   An object of this class represents an R interface. 
'''             Each instance of this class has its own R environment.
'''             <para>
'''             This class provides methods and fields to:</para>
''' <list type="bullet">
'''     <item><description>
'''             Define the R environment including paths and R versions.
'''     </description></item><item><description>
'''             Open a direct link to the R environment and load the required R packages. 
'''     </description></item><item><description>
'''             Execute a specified R script and display the output as text, graph or in a 
'''             web browser.
'''     </description></item><item><description>
'''             Write to log and debug files.
'''     </description></item><item><description>
'''             Specify the fonts and colours to be used in the output window.
'''     </description></item><item><description>
'''             Populate and configure the data frame control combo box, and the list view control.
'''     </description></item><item><description>
'''             Get names of data frames, columns, models, tables, filters, graphs and survs.
'''     </description></item><item><description>
'''             Get properties and other metadata.
'''     </description></item><item><description>
'''             Execute specific climatic and corruption commands.
'''     </description></item>
''' </list></summary>
'''--------------------------------------------------------------------------------------------
Public Class RLink

    ''' <summary>   Full pathname of the climate object file. </summary>
    Dim strClimateObjectPath As String = "/ClimateObject/R" 'TODO SJL 23/04/20 Not used. Delete?

    ''' <summary>   The name of the climate object. </summary>
    Public strClimateObject As String = "ClimateObject" 'TODO SJL 23/04/20 make constant?

    ''' <summary>   Full pathname of the instat object file. </summary>
    Dim strInstatObjectPath As String = "/InstatObject/R" 'TODO SJL 23/04/20 make private constant?

    ''' <summary>   The instat data book object. </summary> 
    Public strInstatDataObject As String = "data_book" 'TODO SJL 23/04/20 make private constant?

    ''' <summary> The name of the graph data book used for storing graphs. </summary>
    Private strGraphDataBook As String = ".graph_data_book"

    ''' <summary>   Name of the data book class. </summary>
    Public strDataBookClassName As String = "DataBook" 'TODO SJL 23/04/20 make private constant?


    ''' <summary>   True if no R code has been executed yet. </summary>
    Private bFirstRCode As Boolean = True

    ''' <summary>   If true then write executed R script to the debug log file. </summary>
    Private bDebugLogExists As Boolean = False

    ''' <summary>   If true then write executed R script to the save log file. </summary>
    Private bAutoSaveLogExists As Boolean = False

    ''' <summary>   True if log file has not yet been created yet. </summary>
    Private bFirstLogCode As Boolean = True

    ''' <summary>   True if there is R code still currently executing. </summary>
    Public bRCodeRunning As Boolean = False


    ''' <summary>   Full pathname of the automatic save log file. </summary>
    Public strAutoSaveLogFilePath As String = ""

    ''' <summary>   Full pathname of the automatic save debug log file. </summary>
    Public strAutoSaveDebugLogFilePath As String = ""


    ''' <summary>   The link to the R environment. </summary>
    Public clsEngine As REngine 'TODO SJL 23/04/20 Make private?

    ''' <summary>   True if the link to the R environment is initialised. </summary>
    Public bREngineInitialised As Boolean = False

    ''' <summary>   True to climate object exists. </summary>
    Public bClimateObjectExists As Boolean = False 'TODO SJL 23/04/20 Not used. Delete?

    ''' <summary>   True if the connection to R is initialized and open. </summary>
    Public bInstatObjectExists As Boolean = False

    ''' <summary>   True to climsoft link exists. </summary>
    Public bClimsoftLinkExists As Boolean = False 'TODO SJL 23/04/20 Not used. Delete?

    ''' <summary> If true then show the executed commands in the R output window.</summary>
    Public bShowCommands As Boolean = True

    ''' <summary>   The graph display option (e.g. 'view_output_window' or 'view_separate_window'). </summary>
    Public strGraphDisplayOption As String = "view_output_window"

    ''' <summary> If true then show all the selected columns to the selector listview. </summary>
    Public bUseColumnSelection As Boolean = False


    ''' <summary> The current grid (the worksheet that appears similar to a spreadsheet on the 
    ''' left-hand side of the display). </summary>
    Private grdDataView As ReoGridControl

    ''' <summary> If true then, by default, display the waiting dialog (the dialog that is 
    ''' optionally displayed while an R script Is running). </summary>
    Private bShowWaitDialog As Boolean = True

    ''' The time in seconds to wait before showing the waiting dialog
    Private iWaitDelay As Integer = 2

    ''' <summary>   The R version major required. </summary>
    Private strRVersionMajorRequired As String = "4"

    ''' <summary>   The R version minor required. </summary>
    Private strRVersionMinorRequired As String = "1"

    ''' <summary>   The R version required. </summary>
    Private strRVersionRequired As String = strRVersionMajorRequired & "." & strRVersionMinorRequired & ".0"

    ''' <summary>   The R bundled version. </summary>
    Private strRBundledVersion As String = "4.1.3"

    Private clsOutputLogger As clsOutputLogger

    Private Shared ReadOnly Logger As NLog.Logger = NLog.LogManager.GetCurrentClassLogger()

    ''' <summary>
    ''' Create method for clsRLink
    ''' Must pass in the output logger so the R link knows where to post outputs to
    ''' </summary>
    ''' <param name="outputLogger"></param>
    Public Sub New(outputLogger As clsOutputLogger)
        clsOutputLogger = outputLogger
    End Sub


    ''' <summary>
    ''' Initialises the connection with the R environment:
    ''' <list type="bullet">
    '''     <item><description>
    '''             Creates and initializes the REngine (which enacpsulates the R environment)
    '''     </description></item>
    '''     <item><description>
    '''             Ensures that a suitable version of R is installed
    '''     </description></item>
    ''' </list>
    ''' </summary>
    ''' <returns>True if it succeeds, false if it fails. </returns>
    Public Function StartREngine() As Boolean
        'reset "R engine initialised" flag
        bREngineInitialised = False

        Try
            'Get R .NET to use bundled R in static folder
            'This static folder is added as a part of the install process as described in 
            'installer/Installer_Generation_Guide.md 
            Dim rHome = Path.Combine(Path.GetFullPath("static"), "R")
            Dim rPath As String = Path.Combine(rHome, "bin", If(Environment.Is64BitProcess, "x64", "i386"))

            Logger.Info("R Home: " & rHome)
            Logger.Info("R Path: " & rPath)

            If Directory.Exists(rHome) And Directory.Exists(rPath) Then
                'use bundled R if included
                Logger.Info("Using bundled R")
                REngine.SetEnvironmentVariables(rPath, rHome)
            Else
                'use normal process for finding local R if bundled version not included
                Logger.Info("Using installed R")
                REngine.SetEnvironmentVariables()
            End If

            'initialise R engine
            clsEngine = REngine.GetInstance()
            clsEngine.Initialize()

            'check if R version is supported, important if R-Instat is not using bundled R.
            'todo. should we check the R version if R has been successfully bundled with R-Instat?
            bREngineInitialised = CheckIfRVersionIsSupported()
        Catch ex As Exception
            MsgBox(ex.Message & Environment.NewLine & "Could not establish connection to R." & Environment.NewLine &
                   "R-Instat requires version " & strRVersionRequired & " of R." & Environment.NewLine &
                   "Note that R-Instat does not work with R below 3.5.0. We recommend using R " & strRBundledVersion &
                   ".  Try reruning the installation to install R " & strRBundledVersion & " or download R " &
                   strRBundledVersion & " from https://cran.r-project.org/bin/windows/base/old/" & strRBundledVersion & "/ and restart R-Instat.",
                   MsgBoxStyle.Critical, "Cannot initialise R connection.")
        End Try

        Return bREngineInitialised
    End Function

    Private Function CheckIfRVersionIsSupported() As Boolean
        Dim bSupported As Boolean = False
        Try
            Dim expTemp As SymbolicExpression
            Dim strMajor As String = ""
            Dim strMinor As String = ""
            expTemp = RunInternalScriptGetValue("R.Version()$major", bSilent:=True)
            If expTemp IsNot Nothing AndAlso expTemp.Type <> Internals.SymbolicExpressionType.Null Then
                strMajor = expTemp.AsCharacter(0)
            End If
            expTemp = RunInternalScriptGetValue("R.Version()$minor", bSilent:=True)
            If expTemp IsNot Nothing AndAlso expTemp.Type <> Internals.SymbolicExpressionType.Null Then
                strMinor = expTemp.AsCharacter(0)
            End If

            If String.IsNullOrEmpty(strMajor) OrElse String.IsNullOrEmpty(strMinor) Then
                MsgBox("Could not determine version of R installed on your machine. R-Instat requires version: " & strRVersionRequired & vbNewLine &
                                       "Try uninstalling any versions of R and rerun the installation to install R " & strRVersionRequired & " or download R " &
                                       strRVersionRequired & "From https://cran.r-project.org/bin/windows/base/old/" & strRVersionRequired &
                                       "And restart R-Instat.",
                                       MsgBoxStyle.Critical, "R Version error.")
            ElseIf strMajor <> strRVersionMajorRequired OrElse strMinor.Substring(0, 1) < strRVersionMinorRequired Then
                MsgBox("Your current version of R is outdated. You are currently running R version: " & strMajor & "." & strMinor & Environment.NewLine &
                       "R-Instat requires at least version " & strRVersionRequired & " or greater." & Environment.NewLine &
                       "Try reruning the installation to install an updated version of R or download R from " &
                       "https://cran.r-project.org/bin/windows/base/" & strRVersionRequired & "and restart R-Instat.",
                       MsgBoxStyle.Critical, "R Version not supported.")
            Else
                bSupported = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message & Environment.NewLine & "Could not determine the version of R installed on your machine. We recommend rerunning the installation to install an updated version of R or download the latest version from https://cran.r-project.org/ and restart R-Instat.", MsgBoxStyle.Critical, "Cannot determine R version.")
        End Try

        Return bSupported
    End Function

    ''' <summary>  
    ''' Gets the default R set up script.
    ''' The script return sets the working directory and source file.
    ''' </summary>
    ''' <returns>   The R setup script. </returns>
    Public Function GetRSetupScript() As String
        Dim clsSetWd As New RFunction
        Dim clsSource As New RFunction
        Dim strScript As String = ""

        clsSetWd.SetRCommand("setwd")
        clsSetWd.AddParameter("dir", Chr(34) & Path.Combine(frmMain.strStaticPath.Replace("\", "/") & strInstatObjectPath) & Chr(34)) 'This is bad the wd should be flexible and not automatically set to the instat object directory 
        clsSource.SetRCommand("source")
        clsSource.AddParameter("file", Chr(34) & "Rsetup.R" & Chr(34))

        strScript = strScript & clsSetWd.ToScript() & Environment.NewLine
        strScript = strScript & clsSource.ToScript() & Environment.NewLine
        strScript = strScript & GetCreateNewDatabookObjectRScript() & Environment.NewLine

        Return strScript
    End Function

    ''' <summary>
    ''' Gets new databook R script. 
    ''' </summary>
    Private Function GetCreateNewDatabookObjectRScript() As String
        Dim clsCreateIO As New ROperator
        Dim clsNewDataBook As New RFunction

        clsNewDataBook.SetRCommand(strDataBookClassName & "$new")

        clsCreateIO.SetOperation("<-")
        clsCreateIO.AddParameter("left", strInstatDataObject, iPosition:=0)
        clsCreateIO.AddParameter("right", clsRFunctionParameter:=clsNewDataBook, iPosition:=1)

        Return clsCreateIO.ToScript()
    End Function

    ''' <summary>   Closes the current instat data object, and opens a new one. </summary>
    Public Sub CloseDataBook()
        Dim clsRm As New RFunction

        clsRm.SetRCommand("rm")
        clsRm.AddParameter("0", strInstatDataObject, iPosition:=0, bIncludeArgumentName:=False)
        clsRm.AddParameter("1", strGraphDataBook, iPosition:=1, bIncludeArgumentName:=False)

        bInstatObjectExists = False
        RunScript(clsRm.ToScript(), strComment:="Closing data")
        bInstatObjectExists = True
        RunScript(GetCreateNewDatabookObjectRScript(), strComment:="Defining new data book")
    End Sub

    ''' <summary>
    ''' Extracts all the complete runnable R commands from <paramref name="strScript"/>.
    ''' The command lines returned are re-formatted in a format that the R.Net engine can execute.
    ''' </summary>
    ''' <param name="strScript">R script command. Can be a multiline script command</param>
    ''' <returns>an array that contains individual complete runnable R scripts</returns>
    Public Function GetRunnableCommandLines(strScript As String) As String()
        'todo. move this implementation to another module or class or R script library?
        Dim lstRunnableCommandLines As New List(Of String)
        Dim arrScriptCommands As String() = strScript.Split(New String() {Environment.NewLine, vbLf}, StringSplitOptions.RemoveEmptyEntries)
        Dim strSplitScriptCmd As String = ""

        For Each str As String In arrScriptCommands
            'trim the script command parts (for nice formatting)
            strSplitScriptCmd &= str.Trim()
            If Not IsRunnableScript(strSplitScriptCmd) Then
                Continue For
            End If
            lstRunnableCommandLines.Add(strSplitScriptCmd)
            strSplitScriptCmd = ""
        Next
        Return lstRunnableCommandLines.ToArray
    End Function

    ''' <summary>
    ''' checks if <paramref name="strNewScript"/> is complete valid R script that can be run without an error
    ''' </summary>
    ''' <param name="strNewScript">R script command. Can be a multiline script command</param>
    ''' <returns>true, if can be run without an error, and false otherwise</returns>
    Private Function IsRunnableScript(strNewScript As String) As Boolean
        Dim strScriptCmd As String = ""
        Dim bRunnable As Boolean = False

        'for each line in script(after removing empty lines)
        For Each strScriptLine As String In strNewScript.Split(New String() {Environment.NewLine, vbLf}, StringSplitOptions.RemoveEmptyEntries)
            'remove any comments (character '#' and anything after)
            Dim iCommentPos As Integer = strScriptLine.IndexOf("#")
            Select Case iCommentPos
                Case 0      'a normal comment line (starts with '#')
                    Continue For
                Case Is > 0 ' a line with an appended comment (e.g. 'x <- 1 # generate data' converted to 'x <- 1 ')
                    strScriptLine = strScriptLine.Substring(0, iCommentPos - 1)
            End Select

            'if line is only whitespace then ignore line
            Dim strTrimmedLine As String = strScriptLine.Trim()
            If strTrimmedLine.Length <= 0 Then
                Continue For
            End If

            'else append line of script to command
            strScriptCmd &= strScriptLine

            'if line ends in a '+', ',', or '%>%'; or there are open curly braces; or open quotations, 
            '    then assume command is not complete
            Dim cLastChar As Char = strTrimmedLine.Last
            Dim strLast3Chars As String = ""
            Dim iNumOpenCurlies As Integer = strScriptCmd.Where(Function(c) c = "{"c).Count
            Dim iNumClosedCurlies As Integer = strScriptCmd.Where(Function(c) c = "}"c).Count
            Dim iNumDoubleQuotes As Integer = strScriptCmd.Where(Function(c) c = """"c).Count
            If strTrimmedLine.Length >= 3 Then
                strLast3Chars = strTrimmedLine.Substring(strTrimmedLine.Length - 3)
            End If
            If cLastChar = "+" OrElse cLastChar = "," OrElse strLast3Chars = "%>%" OrElse iNumOpenCurlies <> iNumClosedCurlies OrElse iNumDoubleQuotes Mod 2 Then
                bRunnable = False
                Continue For
            End If

            bRunnable = True
        Next

        Return bRunnable
    End Function


    ''' <summary>   Closes down the R engine (which encapsulates the R environment). </summary>
    Public Sub CloseREngine()
        If clsEngine IsNot Nothing Then
            Try
                clsEngine.Dispose()
            Catch ex As Exception
                MsgBox("Could not dispose for the connection to R" & Environment.NewLine & ex.Message, MsgBoxStyle.Exclamation, "Cannot close R connection.")
            End Try
        End If
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets packages not installed. </summary>
    '''
    ''' <returns>   The packages not installed. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetRPackagesNotInstalled() As String()
        Dim chrPackagesNotInstalled As CharacterVector
        Dim clsPackagesNotInstalled As New RFunction
        Dim expTemp As SymbolicExpression

        clsPackagesNotInstalled.SetRCommand("packages_not_installed")
        expTemp = RunInternalScriptGetValue(clsPackagesNotInstalled.ToScript(), bSilent:=True)
        If expTemp IsNot Nothing AndAlso expTemp.Type <> Internals.SymbolicExpressionType.Null Then
            chrPackagesNotInstalled = expTemp.AsCharacter
            Return chrPackagesNotInstalled.ToArray
        Else
            Return Nothing
        End If
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Loads the required packages. </summary>
    '''
    ''' <param name="bSilent">  (Optional) if false and an exception is raised then open a message
    '''                         box that displays the exception message. </param>
    '''
    ''' <returns>   True if it succeeds, false if it fails. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function LoadedRequiredPackages(Optional bSilent As Boolean = False) As Boolean
        Dim clsLoadPackages As New RFunction

        clsLoadPackages.SetRCommand("load_required_R_Instat_packages")
        Return RunInternalScript(clsLoadPackages.ToScript(), bSilent:=bSilent)
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Loads the <paramref name="strFile"/> data file. </summary>
    '''
    ''' <param name="strFile">          The data file to load. </param>
    ''' <param name="bKeepExisting">    (Optional) the value for the 'keep_existing' parameter. </param>
    ''' <param name="strComment">       (Optional) The comment to show before executing the 
    '''                                 R script. </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub LoadInstatDataObjectFromFile(strFile As String, Optional bKeepExisting As Boolean = False, Optional strComment As String = "")

        RunScript(GetImportRDSRScript(strFile, bKeepExisting), strComment:=strComment)
    End Sub

    Public Function GetImportRDSRScript(strFile As String, bKeepExisting As Boolean) As String
        Dim clsImportRDS As New RFunction
        Dim clsReadRDS As New RFunction
        Dim strScript As String = ""
        Dim strTemp As String = ""

        clsReadRDS.SetRCommand("readRDS")
        clsReadRDS.AddParameter("file", Chr(34) & strFile.Replace("\", "/") & Chr(34))
        clsReadRDS.SetAssignTo("new_RDS")

        clsImportRDS.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$import_RDS")
        clsImportRDS.AddParameter("data_RDS", clsRFunctionParameter:=clsReadRDS, iPosition:=0)
        clsImportRDS.AddParameter("keep_existing", bKeepExisting.ToString.ToUpper, iPosition:=1)

        strTemp = clsImportRDS.ToScript(strScript)

        Return strScript & strTemp

    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Sets the current grid (the worksheet that appears similar to a spreadsheet
    '''             on the left-hand side of the display). </summary>
    '''
    ''' <param name="grdNewDataGrid">   The current grid. </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub SetDataViewGrid(grdNewDataGrid As ReoGridControl)
        'TODO SJL 19/04/20 Never used, remove?
        grdDataView = grdNewDataGrid
    End Sub


    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets a list of data frame names. </summary>
    '''
    ''' <returns>   The data frame names. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetDataFrameNames() As List(Of String)
        Dim chrDataFrameNames As CharacterVector = Nothing
        Dim lstDataFrameNames As New List(Of String)
        Dim clsGetDataNames As New RFunction
        Dim expNames As SymbolicExpression

        clsGetDataNames.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_names") 'TODO SJL 20/04/20 move to inside if statement?
        If bInstatObjectExists Then
            expNames = RunInternalScriptGetValue(clsGetDataNames.ToScript(), bSilent:=True)
            If expNames IsNot Nothing AndAlso Not expNames.Type = Internals.SymbolicExpressionType.Null Then
                chrDataFrameNames = expNames.AsCharacter
                lstDataFrameNames.AddRange(chrDataFrameNames)
            End If
        End If
        Return lstDataFrameNames
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets the list of data names linked to <paramref name="strDataName"/>. </summary>
    '''
    ''' <param name="strDataName">  The data frame to link to. </param>
    ''' <param name="bIncludeSelf"> (Optional) If true then also return the <paramref name="strDataName"/> 
    '''                             data name.</param>.
    '''
    ''' <returns>   The data names linked to <paramref name="strDataName"/>. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetLinkedToDataFrameNames(strDataName As String, Optional bIncludeSelf As Boolean = True) As List(Of String)
        Dim chrDataFrameNames As CharacterVector = Nothing
        Dim lstDataFrameNames As New List(Of String)
        Dim clsGetDataNames As New RFunction
        Dim expNames As SymbolicExpression

        clsGetDataNames.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_linked_to_data_name")
        clsGetDataNames.AddParameter("from_data_frame", Chr(34) & strDataName & Chr(34), iPosition:=0)
        If bIncludeSelf Then
            clsGetDataNames.AddParameter("include_self", "TRUE", iPosition:=2)
        Else
            clsGetDataNames.AddParameter("include_self", "FALSE", iPosition:=2)
        End If
        If bInstatObjectExists Then
            expNames = RunInternalScriptGetValue(clsGetDataNames.ToScript(), bSilent:=True)
            If expNames IsNot Nothing AndAlso Not expNames.Type = Internals.SymbolicExpressionType.Null Then
                chrDataFrameNames = expNames.AsCharacter
                lstDataFrameNames.AddRange(chrDataFrameNames)
            End If
        End If
        Return lstDataFrameNames
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets the column names for a returned dataframe. </summary>
    '''
    ''' <param name="strDataFrameName">         The dataframe name. </param>
    ''' <param name="bIncludeHiddenColumns">    (Optional) If true then also include the hidden 
    '''                                         column names in the returned list. </param>
    '''
    ''' <returns>   The column names. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetColumnNames(strDataFrameName As String, Optional bIncludeHiddenColumns As Boolean = True) As List(Of String)
        Dim chrCurrColumns As CharacterVector = Nothing
        Dim lstCurrColumns As New List(Of String)
        Dim clsGetColumnNames As New RFunction
        Dim expNames As SymbolicExpression

        If strDataFrameName <> "" AndAlso DataFrameExists(strDataFrameName) Then
            clsGetColumnNames.SetRCommand(strInstatDataObject & "$get_column_names")
            clsGetColumnNames.AddParameter("data_name", Chr(34) & strDataFrameName & Chr(34))
            If Not bIncludeHiddenColumns Then
                clsGetColumnNames.AddParameter("exclude", "list(Is_Hidden = TRUE)")
            End If
            expNames = RunInternalScriptGetValue(clsGetColumnNames.ToScript(), bSilent:=True)
            If expNames IsNot Nothing AndAlso Not expNames.Type = Internals.SymbolicExpressionType.Null Then
                chrCurrColumns = expNames.AsCharacter
                lstCurrColumns.AddRange(chrCurrColumns)
            End If
        End If
        Return lstCurrColumns
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Fills the <paramref name="cboColumns"/> combo box with the <paramref name="strDataFrame"/> 
    '''             data frame's column names. </summary>
    '''
    ''' <param name="strDataFrame"> The data frame name. </param>
    ''' <param name="cboColumns">   [in,out] The combobox columns control. </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub FillColumnNames(strDataFrame As String, ByRef cboColumns As ComboBox)
        Dim lstCurrColumns As New List(Of String)

        If strDataFrame <> "" Then
            lstCurrColumns = GetColumnNames(strDataFrame)
        End If
        cboColumns.Items.Clear()
        cboColumns.Items.AddRange(lstCurrColumns.ToArray)
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   TODO SJL 20/04/20 Not used, remove?. </summary>
    '''
    ''' <param name="strDataFrame"> The data frame. </param>
    ''' <param name="lstColumns">   [in,out] The list columns. </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub FillColumnNames(strDataFrame As String, ByRef lstColumns As ListView)
        Dim lstCurrColumns As List(Of String)

        lstCurrColumns = GetColumnNames(strDataFrame)
        lstColumns.Items.Clear()
        If lstColumns.Columns.Count = 0 Then
            lstColumns.Columns.Add("Available Data")
        End If
        For Each strTemp In lstCurrColumns
            lstColumns.Items.Add(strTemp)
        Next
        lstColumns.Columns(0).Width = -2

    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets the <paramref name="strDataFrameName"/> data frame's next default column 
    '''             name. </summary>
    '''
    ''' <param name="strPrefix">        The value for the R 'prefix' parameter. </param>
    ''' <param name="strDataFrameName"> The data frame name. </param>
    '''
    ''' <returns>   The default column names. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetDefaultColumnNames(strPrefix As String, strDataFrameName As String) As String
        Dim strNextDefault As String = ""
        Dim clsGetNextDefault As New RFunction
        clsGetNextDefault.SetRCommand(strInstatDataObject & "$get_next_default_column_name")
        clsGetNextDefault.AddParameter("prefix", Chr(34) & strPrefix & Chr(34))
        clsGetNextDefault.AddParameter("data_name", Chr(34) & strDataFrameName & Chr(34))
        If strDataFrameName <> "" AndAlso DataFrameExists(strDataFrameName) Then
            strNextDefault = RunInternalScriptGetValue(clsGetNextDefault.ToScript()).AsCharacter(0)
        End If
        Return strNextDefault
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets the name of the next default item from the <paramref name="lstItems"/> 
    '''             list of named items. 
    '''             These items may be data frames, tables, graphs or any other type of named R 
    '''             item. </summary>
    '''
    ''' <param name="strPrefix">    The value for the R 'prefix' parameter. </param>
    ''' <param name="lstItems">     The list of named items. </param>
    '''
    ''' <returns>   The name of next default. If the R command doesn't return any items, then
    '''             returns "".</returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetNextDefault(strPrefix As String, lstItems As List(Of String)) As String
        Dim strNextDefault As String
        Dim clsGetDefault As New RFunction
        Dim strExistingNames As String
        Dim expPrefix As SymbolicExpression

        clsGetDefault.SetRCommand("next_default_item")
        clsGetDefault.AddParameter("prefix", Chr(34) & strPrefix & Chr(34))
        strExistingNames = GetListAsRString(lstItems)
        If strExistingNames <> "" Then
            clsGetDefault.AddParameter("existing_names", GetListAsRString(lstItems))
        End If
        expPrefix = RunInternalScriptGetValue(clsGetDefault.ToScript())
        If expPrefix IsNot Nothing AndAlso Not expPrefix.Type = Internals.SymbolicExpressionType.Null Then
            strNextDefault = expPrefix.AsCharacter(0)
        Else
            strNextDefault = ""
        End If
        Return strNextDefault
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Appends <paramref name="strScript"/> as a new line to the automatic save log
    '''             file. If the log file doesn't exist yet, then it creates it. </summary>
    '''
    ''' <param name="strScript">    The text to add to the save log file. </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub AppendToAutoSaveLog(strScript As String)
        Dim strTempFile As String
        Dim i As Integer = 1
        Try
            If bFirstLogCode Then
                If Not Directory.Exists(frmMain.strAutoSaveLogFolderPath) Then
                    Directory.CreateDirectory(frmMain.strAutoSaveLogFolderPath)
                End If
                strTempFile = "log.R"
                While File.Exists(Path.Combine(frmMain.strAutoSaveLogFolderPath, strTempFile))
                    i = i + 1
                    strTempFile = "log" & i & ".R"
                End While
                strAutoSaveLogFilePath = Path.Combine(frmMain.strAutoSaveLogFolderPath, strTempFile)
                File.WriteAllText(strAutoSaveLogFilePath, "")
                bAutoSaveLogExists = True
            End If
            If bAutoSaveLogExists Then
                Using w As StreamWriter = File.AppendText(strAutoSaveLogFilePath)
                    w.WriteLine(strScript)
                End Using
            End If
        Catch ex As Exception
            'MsgBox("Could not add script to auto save log file at:" & frmMain.strAutoSaveLogFilePath & Environment.NewLine & ex.Message, MsgBoxStyle.Exclamation, "Auot save Log File")
            bAutoSaveLogExists = False
        Finally
            bFirstLogCode = False
        End Try
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Returns an assignment statement of the form:
    '''             <code>
    '''             <paramref name="strAssignTo"/> &lt;- <paramref name="strScripts"/> 
    '''             </code>
    '''             If <paramref name="strScripts"/> is multiple lines then the assignment is done
    '''             on <paramref name="strScripts"/>'s last line. All previous lines are returned 
    '''             unchanged.
    '''             </summary>
    '''
    ''' <param name="strAssignTo">  The variable to assign to (i.e. the left side of the 
    '''                             assignment). </param>
    ''' <param name="strScripts">   The script command(s) that contains the command to assign  (i.e. the right side of the 
    '''                             assignment). </param>
    '''
    ''' <returns>   The constructed assignment statement. </returns>
    ''' 
    '''--------------------------------------------------------------------------------------------
    Public Function ConstructAssignTo(strAssignTo As String, strScripts As String) As String

        'todo. move to another class or module or in R script library?
        If String.IsNullOrEmpty(strScripts) Then
            Return ""
        Else
            Dim strReconstructed As String = ""
            Dim arrScriptParts As String()
            'if string contains more than one line, assign the last line of the multi-line string
            arrScriptParts = GetRunnableCommandLines(strScripts)
            If arrScriptParts.Length > 1 Then
                're-assemble the string, apart from the last line
                strReconstructed = String.Join(Environment.NewLine, arrScriptParts, 0, arrScriptParts.Length - 1)
                'assign the last line of the multi-line string
                strReconstructed = strReconstructed & Environment.NewLine & strAssignTo & " <- " & arrScriptParts.Last
            Else
                'else if string has only one line, then assign to the whole string
                strReconstructed = strAssignTo & " <- " & strScripts
            End If
            Return strReconstructed
        End If

    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Executes <paramref name="clsRStatement"/>. If it is not an assignment 
    '''             statement, then attempts to display the output.</summary>
    '''
    ''' <param name="clsRStatement">  The R code statement to execute </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub RunRStatement(clsRStatement As RStatement)

        'if there is no script to run then just ignore and exit sub
        If String.IsNullOrWhiteSpace(clsRStatement.Text) Then
            Exit Sub
        End If

        Try
            Dim strOutput As String = ""

            'if not an assignment operation, then capture the output
            If IsStatementViewObject(clsRStatement.TextNoFormatting) Then
                strOutput = GetFileOutput(clsRStatement.TextNoFormatting, bSilent:=False,
                                      bSeparateThread:=False, bShowWaitDialogOverride:=Nothing)
            ElseIf Not clsRStatement.IsAssignment _
                AndAlso Not String.IsNullOrWhiteSpace(clsRStatement.TextNoFormatting) Then
                strOutput = GetFileOutput("view_object_data(object = " _
                                          & clsRStatement.TextNoFormatting _
                                          & " , object_format = 'text' )", bSilent:=False,
                                          bSeparateThread:=False, bShowWaitDialogOverride:=Nothing)
            Else
                Evaluate(clsRStatement.Text, bSilent:=False, bSeparateThread:=False,
                         bShowWaitDialogOverride:=Nothing)
            End If

            ' Add output to logger
            clsOutputLogger.AddOutput(clsRStatement.Text, strOutput, bAsFile:=True,
                        bDisplayOutputInExternalViewer:=clsRStatement.TextNoFormatting.StartsWith("view_object_data"))

            ' Log the script
            LogScript(clsRStatement.Text.TrimEnd(vbCr, vbLf))

        Catch e As Exception
            MsgBox(e.Message & Environment.NewLine &
                   "The error occurred in attempting to run the following R command:" &
                   Environment.NewLine & clsRStatement.Text, MsgBoxStyle.Critical,
                   "Error running R command")
        End Try
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary> This method executes the <paramref name="strScript"/> R script and displays 
    '''           the output as text or graph (determined by <paramref name="strScript"/>).
    '''           <para>R commands may be split over multiple lines. This is only allowed if the  
    '''           non-final line ends with '+', ',', or '%>%'; or there are one or more brackets/
    '''           quotations that have not been closed.
    '''           This function is named '...FromWindow' because it's designed to execute scripts 
    '''           entered by a human from a dialog window (e.g. a script window). These scripts 
    '''           may contain R commands split over multiple lines to make the commands more 
    '''           readable.</para><para>
    '''           </para>
    ''' </summary>
    ''' <param name="strScript">    The R script to execute.</param>
    ''' <param name="strComment">   The comment to prefix to the script.</param>
    '''--------------------------------------------------------------------------------------------
    Public Sub RunScriptFromWindow(strScript As String, strComment As String)

        If String.IsNullOrWhiteSpace(strScript) Then
            Exit Sub
        End If

        'Prefix comment to script
        Dim strRStatement As String = ""
        Dim strRStatementComment As String = If(String.IsNullOrEmpty(strComment), "", GetFormattedComment(strComment))

        'for each line in script
        For Each strScriptLine As String In strScript.Split(Environment.NewLine)

            'if line is empty or only whitespace then ignore line
            Dim strTrimmedLine As String = strScriptLine.Trim(vbLf).Trim()
            If strTrimmedLine.Length <= 0 Then
                Continue For
            End If

            'find any comments (character '#' and anything after)
            Dim iCommentPos As Integer = strTrimmedLine.IndexOf("#")
            Select Case iCommentPos
                Case 0      'a normal comment line (starts with '#')
                    strRStatementComment &= If(String.IsNullOrEmpty(strRStatementComment), "", Environment.NewLine) _
                                            & strTrimmedLine
                    Continue For
                Case Is > 0 ' a line with an appended comment (e.g. 'x <- 1 # generate data' converted to 'x <- 1 ')
                    strRStatementComment &= If(String.IsNullOrEmpty(strRStatementComment), "", Environment.NewLine) _
                                            & strTrimmedLine.Substring(strTrimmedLine.IndexOf("#"c))
                    strTrimmedLine = strTrimmedLine.Substring(0, iCommentPos).Trim()
            End Select

            'else append line of script to command
            strRStatement &= If(String.IsNullOrEmpty(strRStatement), "", Environment.NewLine) & strTrimmedLine

            'if line ends in a '+', ',', or '%>%'; or there are open brackets; or open quotations, 
            '    then assume command is not complete
            Dim cLastChar As Char = strTrimmedLine.Last
            Dim strLast3Chars As String = ""
            Dim iNumOpenRound As Integer = strRStatement.Where(Function(c) c = "("c).Count
            Dim iNumClosedRound As Integer = strRStatement.Where(Function(c) c = ")"c).Count
            Dim iNumOpenCurlies As Integer = strRStatement.Where(Function(c) c = "{"c).Count
            Dim iNumClosedCurlies As Integer = strRStatement.Where(Function(c) c = "}"c).Count
            Dim iNumDoubleQuotes As Integer = strRStatement.Where(Function(c) c = """"c).Count
            If strTrimmedLine.Length >= 3 Then
                strLast3Chars = strTrimmedLine.Substring(strTrimmedLine.Length - 3)
            End If
            If cLastChar = "+" OrElse cLastChar = "," OrElse strLast3Chars = "%>%" _
                    OrElse iNumOpenRound <> iNumClosedRound _
                    OrElse iNumOpenCurlies <> iNumClosedCurlies _
                    OrElse iNumDoubleQuotes Mod 2 Then
                Continue For
            End If

            'We now have what we think is a complete R statement, so try and execute it
            Try
                Dim strOutput As String = ""
                Dim bAsFile As Boolean = True
                Dim bDisplayOutputInExternalViewer As Boolean = False

                If IsStatementViewObject(strRStatement) Then
                    strOutput = GetFileOutput(strRStatement, False, False, Nothing)
                    'if statement generates a view_object then display in external viewer (maximised)
                    bDisplayOutputInExternalViewer = strRStatement.Contains("view_object_data")
                ElseIf IsStatementPrint(strRStatement) Then
                    bAsFile = False
                    Evaluate(strRStatement, bSilent:=False, bSeparateThread:=False, bShowWaitDialogOverride:=Nothing)
                ElseIf Not IsStatementAssignment(strRStatement) Then 'if not an assignment operation, then capture the output
                    Dim strRStatementAsSingleLine As String = strRStatement.Replace(vbCr, String.Empty)
                    strRStatementAsSingleLine = strRStatementAsSingleLine.Replace(vbLf, String.Empty)
                    'wrap final command inside view_object_data just in case there is an output object
                    strOutput = GetFileOutput("view_object_data(object = " & strRStatementAsSingleLine & " , object_format = 'text' )", False, False, Nothing)
                Else
                    Evaluate(strRStatement, bSilent:=False, bSeparateThread:=False, bShowWaitDialogOverride:=Nothing)
                End If

                clsOutputLogger.AddOutput(If(String.IsNullOrEmpty(strRStatementComment), "",
                        strRStatementComment & Environment.NewLine) & strRStatement,
                        strOutput, bAsFile, bDisplayOutputInExternalViewer)
                LogScript(strRStatement, strRStatementComment)

            Catch e As Exception
                MsgBox(e.Message & Environment.NewLine &
                       "The error occurred in attempting to run the following R command(s):" &
                       Environment.NewLine &
                       strRStatement, MsgBoxStyle.Critical, "Error running R command(s)")
            End Try

            strRStatement = ""
            strRStatementComment = ""
        Next

        frmMain.UpdateAllGrids()
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>
    ''' This method executes the <paramref name="strScript"/> R script(s) and displays the output. The
    ''' output may be displayed as text, graph or html (see <paramref name="iCallType"/>).
    ''' Any R script(s) that is necessary for reproducibility has to be run through this subroutine.
    ''' </summary>
    ''' <param name="strScript"> is the R script(s) to execute.</param>
    ''' <param name="iCallType"> defines how to display the R output. todo deprecate this.
    ''' <list type="bullet">
    '''     <item>
    '''        <description>0 Executes <paramref name="strScript"/> and ignores the result.</description>
    '''     </item>
    '''     <item>
    '''        <description>1 Executes <paramref name="strScript"/>, stores the result in a 
    '''        temporary R variable, and then outputs the variable's value as text.</description>
    '''     </item>
    '''     <item>
    '''        <description>2 Executes <paramref name="strScript"/> and if successful shows the 
    '''        result as text.</description>
    '''     </item>
    '''     <item>
    '''        <description>3 Executes <paramref name="strScript"/> and if successful shows the 
    '''        result as a graph.</description>
    '''     </item>
    '''     <item>
    '''        <description>4 Executes <paramref name="strScript"/>, stores the result in a 
    '''        temporary R variable, and then outputs the variable's value in a web browser.</description>
    '''     </item>
    '''     <item>
    '''        <description>5 Executes <paramref name="strScript"/>, and displays the result 
    '''        in the output window. Use this value for manually entered R commands (e.g. for 
    '''        commands entered manually in the script window).</description>
    '''     </item>
    ''' </list>
    ''' </param>
    ''' <param name="strComment"> is shown as a comment. If this parameter is "" then shows 
    ''' <paramref name="strScript"/> as the comment.</param>
    ''' <param name="bSeparateThread"> if true then executes <paramref name="strScript"/> in a 
    ''' new thread.</param>
    ''' <param name="bShowWaitDialogOverride"> if true and <paramref name="bSeparateThread"/> is 
    ''' also true then display a waiting dialog while the R script is executing.</param>
    ''' <param name="bUpdateGrids"> if true then updates grids after executing 
    ''' <paramref name="strScript"/>.</param>
    ''' <param name="bSilent"> if false and an exception is raised then open a message box that 
    ''' displays the exception message.</param>
    '''--------------------------------------------------------------------------------------------
    Public Sub RunScript(strScript As String,
                         Optional iCallType As Integer = 0,
                         Optional strComment As String = "",
                         Optional bSeparateThread As Boolean = True,
                         Optional bShowWaitDialogOverride As Nullable(Of Boolean) = Nothing,
                         Optional bUpdateGrids As Boolean = True,
                         Optional bSilent As Boolean = False)

        'if there is no script to run then just ignore and exit sub
        If String.IsNullOrWhiteSpace(strScript) Then
            Exit Sub
        End If

        'If comment provided
        'Prefix comment to script, e.g. "# Code generated by the dialog, Import Dataset" & vbCrLf & "new_RDS <- readRDS(file=""C:/Users/myName ...
        Dim strScriptWithComment As String = If(String.IsNullOrEmpty(strComment), strScript, GetFormattedComment(strComment) & Environment.NewLine & strScript)

        frmMain.ucrScriptWindow.LogText(strScriptWithComment & Environment.NewLine)

        'TODO SJL 20/04/20 - is the commented out check below needed?
        'If strScript.Length > 2000 Then
        '    MsgBox("The following command cannot be run because it exceeds the character limit of 2000 characters for a command in R-Instat." & Environment.NewLine & strScript & Environment.NewLine & Environment.NewLine & "It may be possible to run the command directly in R.", MsgBoxStyle.Critical, "Cannot run command")

        Try
            Dim strOutput As String = ""
            Dim bAsFile As Boolean = True
            Dim bDisplayOutputInExternalViewer As Boolean = False

            'exclude lines not needed for execution e.g comments, empty lines.
            Dim arrExecutableRScriptLines() As String = GetRunnableCommandLines(strScript)
            If arrExecutableRScriptLines.Length > 0 Then
                'get the last R script command. todo, this should eventually use the RScript library functions to identify the last R script command
                Dim strLastScript As String = arrExecutableRScriptLines.Last()
                If IsStatementViewObject(strLastScript) Then
                    strOutput = GetFileOutput(strScript, bSilent, bSeparateThread, bShowWaitDialogOverride)
                    'if last function is view_object then display in external viewer (maximised)
                    bDisplayOutputInExternalViewer = strLastScript.Contains("view_object_data")
                ElseIf IsStatementPrint(strLastScript) Then
                    bAsFile = False
                    Evaluate(strScript, bSilent:=bSilent, bSeparateThread:=bSeparateThread, bShowWaitDialogOverride:=bShowWaitDialogOverride)
                ElseIf iCallType = 0 Then
                    'if script output should be ignored. todo. deprecate this block after implementing correctly
                    bAsFile = False
                    Evaluate(strScript, bSilent:=bSilent, bSeparateThread:=bSeparateThread, bShowWaitDialogOverride:=bShowWaitDialogOverride)
                ElseIf iCallType = 1 OrElse iCallType = 4 Then
                    'this is used by the calculator dialog
                    'else if script output should be stored in a temp variable
                    ' TODO SJL In RInstat, iCallType only seems to be -1, 0, 1, 2 or 3. Is icallType 4 used?
                    bAsFile = False
                    Dim strTempAssignTo As String = ".temp_val"
                    'TODO check this is valid syntax in all cases
                    '     i.e. this is potentially: x <- y <- 1
                    Evaluate(strTempAssignTo & " <- " & strScript, bSilent:=bSilent, bSeparateThread:=bSeparateThread, bShowWaitDialogOverride:=bShowWaitDialogOverride)
                    Dim expTemp As RDotNet.SymbolicExpression = GetSymbol(strTempAssignTo)
                    If expTemp IsNot Nothing Then
                        strOutput = String.Join(Environment.NewLine, expTemp.AsCharacter()) & Environment.NewLine
                    End If
                Else
                    'else if script output should not be ignored or not stored as an object or variable

                    'if output should be stored as a variable just execute the script
                    If IsStatementAssignment(arrExecutableRScriptLines.Last()) Then
                        Evaluate(strScript, bSilent:=bSilent, bSeparateThread:=bSeparateThread, bShowWaitDialogOverride:=bShowWaitDialogOverride)
                    Else
                        'else capture the output as plain text
                        Dim bSuccess As Boolean = True
                        If arrExecutableRScriptLines.Length > 1 Then
                            Dim strScriptWithoutLastLine As String = String.Join(Environment.NewLine, arrExecutableRScriptLines, 0, arrExecutableRScriptLines.Length - 1)
                            bSuccess = Evaluate(strScriptWithoutLastLine, bSilent:=bSilent, bSeparateThread:=bSeparateThread, bShowWaitDialogOverride:=bShowWaitDialogOverride)
                        End If

                        If bSuccess Then
                            strOutput = GetFileOutput("view_object_data(object = " & arrExecutableRScriptLines.Last() & " , object_format = 'text' )", bSilent, bSeparateThread, bShowWaitDialogOverride)
                        End If
                    End If

                End If
            End If

            ' If strOutput is empty or does not contain valid HTML files, add strOutput itself as an output
            clsOutputLogger.AddOutput(strScriptWithComment, strOutput, bAsFile, bDisplayOutputInExternalViewer)


        Catch e As Exception
            MsgBox(e.Message & Environment.NewLine & "The error occurred in attempting to run the following R command(s):" & Environment.NewLine & strScript, MsgBoxStyle.Critical, "Error running R command(s)")
        End Try

        AppendToAutoSaveLog(strScriptWithComment & Environment.NewLine)
        If bUpdateGrids Then
            frmMain.UpdateAllGrids()
        End If
    End Sub

    ''' <summary>
    ''' Gets the file path name if file is available and has contents, else returns an empty string
    ''' </summary>
    ''' <param name="strScript">Script that produces a file output. The last line of the script 
    '''     must be a single line R statement that generates output.</param>
    ''' <param name="bSilent"></param>
    ''' <param name="bSeparateThread"></param>
    ''' <param name="bShowWaitDialogOverride"></param>
    ''' <returns>file path name if file is avaialble and has contents else empty string</returns>
    Private Function GetFileOutput(strScript As String, bSilent As Boolean, bSeparateThread As Boolean, bShowWaitDialogOverride As Nullable(Of Boolean)) As String
        Dim strFilesPath As String = ""
        Dim strTempAssignTo As String = ".temp_val"
        Dim expTemp As RDotNet.SymbolicExpression
        Dim strNewAssignedToScript As String = ConstructAssignTo(strTempAssignTo, strScript)
        Evaluate(strNewAssignedToScript, bSilent:=bSilent, bSeparateThread:=bSeparateThread, bShowWaitDialogOverride:=bShowWaitDialogOverride)
        'get file path. If not found then silently return nothing
        expTemp = GetSymbol(strTempAssignTo, bSilent:=True)
        Evaluate("rm(" & strTempAssignTo & ")", bSilent:=True)
        If expTemp IsNot Nothing Then
            ' Convert CharacterVector to String() array
            Dim arrFilesPath As String() = expTemp.AsCharacter().Select(Function(x) x.ToString()).ToArray()

            ' Filter out invalid file paths
            arrFilesPath = arrFilesPath.Where(Function(path) File.Exists(path) AndAlso New FileInfo(path).Length > 0).ToArray()

            ' Join the valid file paths with newline characters
            strFilesPath = String.Join(Environment.NewLine, arrFilesPath)
        End If

        Return strFilesPath
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Executes the the <paramref name="strScript"/> R script and returns the result 
    '''             as a 'SymbolicExpression' object. </summary>
    '''
    ''' <param name="strScript">                The R script to execute. </param>
    ''' <param name="strVariableName">          (Optional) The name of the variable to store the 
    '''                                         result of <paramref name="strScript"/>. The variable 
    '''                                         is deleted before returning.</param>
    ''' <param name="bSilent">                  (Optional) If false and an exception is raised then
    '''                                         open a message box that displays the exception
    '''                                         message. </param>
    ''' <param name="bSeparateThread">          (Optional) If true then executes
    '''                                         <paramref name="strScript"/> in a new thread. </param>
    ''' <param name="bShowWaitDialogOverride">  (Optional) if true and
    '''                                         <paramref name="bSeparateThread"/> is also true then
    '''                                         display a waiting dialog while the R script is
    '''                                         executing. </param>
    ''' <param name="strError">                 [in,out] (Optional) The error. </param>
    '''
    ''' <returns>   The output returned from <paramref name="strScript"/> as a collection of strings.
    '''             If an exception is raised then returns 'Nothing'. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function RunInternalScriptGetValue(strScript As String, Optional strVariableName As String = ".temp_value", Optional bSilent As Boolean = False, Optional bSeparateThread As Boolean = True, Optional bShowWaitDialogOverride As Nullable(Of Boolean) = Nothing, Optional ByRef strError As String = "") As SymbolicExpression
        Dim expTemp As SymbolicExpression
        Dim strCommand As String

        expTemp = Nothing
        'TODO Legacy - Bug here if strScript is multiple lines. Wrong value will be returned
        strCommand = strVariableName & " <- " & strScript
        If clsEngine IsNot Nothing Then
            Evaluate(strCommand, bSilent:=bSilent, bSeparateThread:=bSeparateThread, bShowWaitDialogOverride:=bShowWaitDialogOverride, strError:=strError)
            expTemp = GetSymbol(strVariableName, bSilent:=True)
            'Very important to remove the variable after getting it otherwise could be returning wrong variable later if a command gives an error
            Evaluate("rm(" & strVariableName & ")", bSilent:=bSilent, bSeparateThread:=bSeparateThread)
        End If
        Return expTemp
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Executes the the <paramref name="strScript"/> R script and returns the result 
    '''             as a collection of strings. </summary>
    '''
    ''' <param name="strScript">                The R script to execute. </param>
    ''' <param name="bSilent">                  (Optional) If false and an exception is raised then
    '''                                         opens a message box that displays the exception
    '''                                         message. </param>
    ''' <param name="bSeparateThread">          (Optional) If true then executes
    '''                                         <paramref name="strScript"/> in a new thread. </param>
    ''' <param name="bShowWaitDialogOverride">  (Optional) if true and <paramref name="bSeparateThread"/> 
    '''                                         is also true then displays a waiting dialog while 
    '''                                         the R script is executing. </param>
    ''' <param name="strError">                 [in,out] (Optional) The output returned from 
    '''                                         <paramref name="strScript"/> as a collection of 
    '''                                         strings.
    '''                                         If an exception is raised then returns 'Nothing'. </param>
    '''
    ''' <returns>   The result of the script execution as a collection of strings. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function RunInternalScriptGetOutput(strScript As String, Optional bSilent As Boolean = False, Optional bSeparateThread As Boolean = True, Optional bShowWaitDialogOverride As Nullable(Of Boolean) = Nothing, Optional ByRef strError As String = "") As CharacterVector
        Dim chrTemp As CharacterVector
        Dim expTemp As SymbolicExpression

        expTemp = RunInternalScriptGetValue("capture.output(" & strScript & ")", bSilent:=bSilent, bSeparateThread:=bSeparateThread, bShowWaitDialogOverride:=bShowWaitDialogOverride, strError:=strError)
        Try
            chrTemp = expTemp.AsCharacter()
        Catch ex As Exception
            If Not bSilent Then
                MsgBox(ex.Message & Environment.NewLine & "The error occurred in attempting to run the following R command(s):" & Environment.NewLine & strScript, MsgBoxStyle.Critical, "Error running R command(s)")
            End If
            chrTemp = Nothing
        End Try
        Return chrTemp
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Executes the <paramref name="strScript"/> R script, optionally stores the 
    '''             result in <paramref name="strVariableName"/>, and returns true if execution 
    '''             was successful. </summary>
    '''
    ''' <param name="strScript">                The R script to execute. </param>
    ''' <param name="strVariableName">          (Optional) The name of the variable to store the
    '''                                         result of the R script execution. </param>
    ''' <param name="bSilent">                  (Optional) If false and an exception is raised then
    '''                                         opens a message box that displays the exception
    '''                                         message. </param>
    ''' <param name="bSeparateThread">          (Optional) If true then executes the R script in a new
    '''                                         thread. </param>
    ''' <param name="bShowWaitDialogOverride">  (Optional) If true and <paramref name="bSeparateThread"/> 
    '''                                         is also true then displays a waiting dialog while 
    '''                                         the R script is executing. </param>
    '''
    ''' <returns>   True if <paramref name="strScript"/> executes without raising an exception, 
    '''             else returns false. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function RunInternalScript(strScript As String, Optional strVariableName As String = "", Optional bSilent As Boolean = False, Optional bSeparateThread As Boolean = True, Optional bShowWaitDialogOverride As Nullable(Of Boolean) = Nothing) As Boolean
        Dim strCommand As String
        Dim bReturn As Boolean

        If strVariableName <> "" Then
            strCommand = strVariableName & "<-" & strScript
        Else
            strCommand = strScript
        End If
        If clsEngine IsNot Nothing Then
            bReturn = Evaluate(strCommand, bSilent:=bSilent, bSeparateThread:=bSeparateThread, bShowWaitDialogOverride:=bShowWaitDialogOverride)
            Return bReturn
        Else
            Return False
        End If
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Executes the <paramref name="strScript"/> R script and returns true if 
    '''             execution was successful. </summary>
    '''
    ''' <param name="strScript">                The R script to execute. </param>
    ''' <param name="bSilent">                  (Optional) If false and an exception is raised then
    '''                                         open a message box that displays the exception
    '''                                         message. </param>
    ''' <param name="bSeparateThread">          (Optional) If true then execute the R script in a new
    '''                                         thread. </param>
    ''' <param name="bShowWaitDialogOverride">  (Optional) If true and
    '''                                         <paramref name="bSeparateThread"/> is also true then
    '''                                         display a waiting dialog while the R script is
    '''                                         executing. </param>
    ''' <param name="strError">                 [in,out] (Optional) The error message of the caught 
    '''                                         error. If no error is caught then is an empty
    '''                                         string. 
    '''                                         Note that the input value is ignored. </param>
    '''
    ''' <returns>   True if <paramref name="strScript"/> executes without raising an exception, 
    '''             else returns false. </returns>
    '''--------------------------------------------------------------------------------------------
    Private Function Evaluate(strScript As String, Optional bSilent As Boolean = False, Optional bSeparateThread As Boolean = True, Optional bShowWaitDialogOverride As Nullable(Of Boolean) = Nothing, Optional ByRef strError As String = "") As Boolean
        Dim thrRScript As Threading.Thread
        Dim thrDelay As Threading.Thread
        Dim thrWaitDisplay As Threading.Thread
        Dim evtWaitHandleWaitDisplayDone As New System.Threading.AutoResetEvent(False)
        Dim evtWaitHandleDelayDone As New System.Threading.AutoResetEvent(False)
        Dim bReturn As Boolean = True
        Dim i As Integer = 1
        Dim strTempError As String = ""
        Dim strTempFile As String
        Dim bErrorMessageOpen As Boolean = False
        Dim bCurrentShowWaiting As Boolean

        ' if there is an override for the wait dialog, then use the override
        If bShowWaitDialogOverride.HasValue Then
            bCurrentShowWaiting = bShowWaitDialogOverride
        Else ' else use the current setting for the wait dialog
            bCurrentShowWaiting = bShowWaitDialog
        End If
        ' loop until any currently running R code has completed
        While bRCodeRunning
            Threading.Thread.Sleep(5)
        End While
        bRCodeRunning = True
        ' if R engine defined
        If clsEngine IsNot Nothing Then
            ' if this is the first R code executed, then open and initialise log file
            If bFirstRCode Then
                Try
                    If Not Directory.Exists(frmMain.strAutoSaveInternalLogFolderPath) Then
                        Directory.CreateDirectory(frmMain.strAutoSaveInternalLogFolderPath)
                    End If
                    strTempFile = "debug_log.R"
                    While File.Exists(Path.Combine(frmMain.strAutoSaveInternalLogFolderPath, strTempFile))
                        i = i + 1
                        strTempFile = "debug_log" & i & ".R"
                    End While
                    strAutoSaveDebugLogFilePath = Path.Combine(frmMain.strAutoSaveInternalLogFolderPath, strTempFile)
                    File.WriteAllText(strAutoSaveDebugLogFilePath, "")
                    Using w As StreamWriter = File.AppendText(strAutoSaveDebugLogFilePath)
                        w.WriteLine("# ****************************")
                        w.WriteLine("# R-Instat debugging log file")
                        w.WriteLine("# ****************************")
                        w.WriteLine("# Version: " & My.Application.Info.Version.ToString())
                        w.WriteLine("# ****************************")
                        w.WriteLine("# Created on: " & DateTime.Now)
                        w.WriteLine("# User: " & Environment.UserName)
                        w.WriteLine("# ****************************")
                    End Using
                    bDebugLogExists = True
                Catch ex As Exception
                    MsgBox("Could not create debug log file at:" & strAutoSaveDebugLogFilePath & Environment.NewLine & ex.Message, MsgBoxStyle.Exclamation, "Debug Log File")
                    bDebugLogExists = False
                Finally
                    bFirstRCode = False
                End Try
            End If
            ' append script to log file
            Try
                If bDebugLogExists Then
                    Dim ts As New Stopwatch ' TODO SJL 20/04/20 what is the purpose of the stopwatch?
                    ts.Start()
                    Using w As StreamWriter = File.AppendText(strAutoSaveDebugLogFilePath)
                        w.WriteLine(strScript)
                    End Using
                    ts.Stop()
                End If
            Catch ex As Exception
                MsgBox("Could not add text to debug log file at:" & strAutoSaveDebugLogFilePath & Environment.NewLine & ex.Message, MsgBoxStyle.Exclamation, "Debug Log File")
            End Try
            Try
                ' if script should run in a separate thread
                ' Fixed thread stack size i.e maxStackSize = 25000000 (25MB) because this may returns an overflow exception when large datasets are used. For example when producing a declustered plot on extremes dialog using Ghana dataset.
                If bSeparateThread Then
                    thrRScript = New Threading.Thread(Sub()
                                                          Try
                                                              clsEngine.Evaluate(strScript)
                                                          Catch ex As Exception
                                                              If Not bSilent Then
                                                                  bErrorMessageOpen = True
                                                                  MsgBox(ex.Message & Environment.NewLine & "The error occurred in attempting to run the following R command(s):" & Environment.NewLine & strScript, MsgBoxStyle.Critical, "Error running R command(s)")
                                                                  bErrorMessageOpen = False
                                                              End If
                                                              strTempError = ex.Message
                                                              bReturn = False
                                                          End Try
                                                      End Sub, maxStackSize:=25000000)
                    thrRScript.IsBackground = True
                    thrDelay = New Threading.Thread(Sub()
                                                        Dim t As New Stopwatch
                                                        t.Start()
                                                        While t.ElapsedMilliseconds < (iWaitDelay * 1000) AndAlso thrRScript.IsAlive
                                                            Threading.Thread.Sleep(5)
                                                        End While
                                                        evtWaitHandleDelayDone.Set()
                                                    End Sub)
                    thrDelay.IsBackground = True
                    thrWaitDisplay = New Threading.Thread(Sub()
                                                              If bCurrentShowWaiting Then
                                                                  If Not RuntimeInformation.IsOSPlatform(OSPlatform.Linux) Then
                                                                      frmSetupLoading.Show()
                                                                  End If
                                                              End If
                                                              While thrRScript.IsAlive
                                                                  If bErrorMessageOpen Then
                                                                      If Not RuntimeInformation.IsOSPlatform(OSPlatform.Linux) Then
                                                                          frmSetupLoading.Close()
                                                                      End If
                                                                  End If
                                                                  Threading.Thread.Sleep(5)
                                                                  Application.DoEvents()
                                                              End While
                                                              If Not RuntimeInformation.IsOSPlatform(OSPlatform.Linux) Then
                                                                  frmSetupLoading.Close()
                                                              End If
                                                              evtWaitHandleWaitDisplayDone.Set()
                                                          End Sub)
                    thrWaitDisplay.IsBackground = True
                    thrRScript.Start()
                    thrDelay.Start()
                    evtWaitHandleDelayDone.WaitOne()
                    If thrRScript.IsAlive Then
                        thrWaitDisplay.Start()
                        evtWaitHandleWaitDisplayDone.WaitOne()
                    End If
                Else 'else if script does NOT need to run in a separate thread
                    clsEngine.Evaluate(strScript)
                End If
            Catch ex As Exception
                If Not bSilent Then
                    MsgBox(ex.Message & Environment.NewLine & "The error occurred in attempting to run the following R command(s):" & Environment.NewLine & strScript, MsgBoxStyle.Critical, "Error running R command(s)")
                End If
                strTempError = ex.Message
                bReturn = False
            End Try
        Else
            bReturn = False
        End If
        bRCodeRunning = False
        strError = strTempError
        Return bReturn 'return if script executed without raising an exception
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets the symbol named <paramref name="strSymbol"/>. </summary>
    '''
    ''' <param name="strSymbol">    The name of the symbol to return. </param>
    ''' <param name="bSilent">      (Optional) If false and an exception is raised then open a
    '''                             message box that displays the exception message. </param>
    '''
    ''' <returns>   The symbol named <paramref name="strSymbol"/>. </returns>
    '''--------------------------------------------------------------------------------------------
    Private Function GetSymbol(strSymbol As String, Optional bSilent As Boolean = False) As SymbolicExpression
        Dim expTemp As SymbolicExpression = Nothing

        If clsEngine IsNot Nothing Then
            Try
                expTemp = clsEngine.GetSymbol(strSymbol)
            Catch ex As Exception
                If Not bSilent Then
                    MsgBox(ex.Message & Environment.NewLine & "The error occurred in attempting to retrieve:" & strSymbol, MsgBoxStyle.Critical, "Error retrieving R variable")
                End If
            End Try
        End If
        Return expTemp
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Fills the list view control <paramref name="lstView"/> with the type of items 
    '''             specified by <paramref name="strType"/>. </summary>
    '''
    ''' <param name="lstView">              The list view control. </param>
    ''' <param name="strType">              The type of item to display in the list view.
    '''                                     This can be 'data frame', 'graph', model', 'column' etc. 
    '''                                     For a full list of possible values, please see the 
    '''                                     select statement in the function body below. </param>
    ''' <param name="lstIncludedDataTypes"> (Optional) List of item names to display in the list 
    '''                                     view control. These are passed as 'include' parameters to 
    '''                                     the R 'list' command.</param>
    ''' <param name="lstExcludedDataTypes"> (Optional) List of item names **not** to display in the list
    '''                                     view control. These are passed as 'exclude' parameters to
    '''                                     the R 'list' command. </param>
    ''' <param name="strDataFrameName">     (Optional) The data frame name. </param>
    ''' <param name="strHeading">           (Optional) The heading for the list view display. </param>
    ''' <param name="strExcludedItems">     (Optional) List of item names to exclude from the list
    '''                                     view control. These are passed as parameter values for 
    '''                                     the 'excluded_items' R parameter. </param>
    ''' <param name="strDatabaseQuery">     (Optional) The database query. Only used if 
    '''                                     <paramref name="strType"/> is 'database_variables'.</param>
    ''' <param name="strNcFilePath">        (Optional) Full pathname of the non client file. 
    '''                                     Only used if <paramref name="strType"/> is 
    '''                                     'nc_dim_variables'.</param>
    '''--------------------------------------------------------------------------------------------
    Public Sub FillListView(lstView As ListView, strType As String, Optional lstIncludedDataTypes As List(Of KeyValuePair(Of String, String())) = Nothing, Optional lstExcludedDataTypes As List(Of KeyValuePair(Of String, String())) = Nothing, Optional strDataFrameName As String = "", Optional strHeading As String = "Variables", Optional strExcludedItems As String() = Nothing, Optional strDatabaseQuery As String = "", Optional strNcFilePath As String = "")
        Dim vecColumns As GenericVector = Nothing
        Dim chrCurrColumns As CharacterVector
        Dim i As Integer
        Dim grps As New ListViewGroup
        Dim clsGetItems As New RFunction
        Dim clsIncludeList As New RFunction
        Dim clsExcludeList As New RFunction
        Dim kvpInclude As KeyValuePair(Of String, String())
        Dim kvpExclude As KeyValuePair(Of String, String())
        Dim expItems As SymbolicExpression
        Dim clsGetColumnTypes As New RFunction
        Dim strCurrColumnTypes() As String
        Dim clsGetColumnLabels As New RFunction
        Dim strCurrColumnLables() As String
        Dim strColumnsRList As String
        Dim strTemp As String
        Dim lviTemp As ListViewItem
        Dim strTopItemText As String = ""

        If bInstatObjectExists Then
            Select Case strType
                Case "column"
                    clsGetItems.SetRCommand(strInstatDataObject & "$get_column_names")
                    'TODO. why not apply or not the column selection at the R level.
                    clsGetItems.AddParameter("use_current_column_selection", If(bUseColumnSelection, "TRUE", "FALSE"))
                Case "metadata"
                    clsGetItems.SetRCommand(strInstatDataObject & "$get_metadata_fields")
                Case "filter"
                    clsGetItems.SetRCommand(strInstatDataObject & "$get_filter_names")
                Case "column_selection"
                    clsGetItems.SetRCommand(strInstatDataObject & "$get_column_selection_names")
                Case "object",
                     RObjectTypeLabel.Graph,
                     RObjectTypeLabel.Model,
                     RObjectTypeLabel.Table,
                     RObjectTypeLabel.Summary,
                     RObjectTypeLabel.StructureLabel
                    clsGetItems.SetRCommand(strInstatDataObject & "$get_object_names")
                    If strType <> "object" Then
                        clsGetItems.AddParameter(strParameterName:="object_type_label",
                                          strParameterValue:=Chr(34) & strType & Chr(34))
                    End If
                Case "dataframe"
                    clsGetItems.SetRCommand(strInstatDataObject & "$get_data_names")
                Case "link"
                    clsGetItems.SetRCommand(strInstatDataObject & "$get_link_names")
                Case "key"
                    clsGetItems.SetRCommand(strInstatDataObject & "$get_key_names")
                Case "database_variables"
                    clsGetItems.SetRCommand(strInstatDataObject & "$get_database_variable_names")
                    clsGetItems.AddParameter("query", Chr(34) & strDatabaseQuery & Chr(34))
                Case "nc_dim_variables"
                    clsGetItems.SetRCommand(strInstatDataObject & "$get_nc_variable_names")
                    clsGetItems.AddParameter("file", Chr(34) & strNcFilePath & Chr(34))
                Case "variable_sets"
                    clsGetItems.SetRCommand(strInstatDataObject & "$get_variable_sets_names")
                Case "calculation"
                    clsGetItems.SetRCommand(strInstatDataObject & "$get_calculation_names")
            End Select
            clsGetItems.AddParameter("as_list", "TRUE")
            If lstView.TopItem IsNot Nothing Then
                strTopItemText = lstView.TopItem.Text
            End If
            lstView.Clear()
            lstView.Groups.Clear()
            lstView.Columns.Add(strHeading)
            If lstIncludedDataTypes.Count > 0 Then
                clsIncludeList.SetRCommand("list")
                For Each kvpInclude In lstIncludedDataTypes
                    clsIncludeList.AddParameter(kvpInclude.Key, GetListAsRString(kvpInclude.Value.ToList(), bWithQuotes:=False))
                Next
                clsGetItems.AddParameter("include", clsRFunctionParameter:=clsIncludeList)
            End If
            If lstExcludedDataTypes.Count > 0 Then
                clsExcludeList.SetRCommand("list")
                For Each kvpExclude In lstExcludedDataTypes
                    clsExcludeList.AddParameter(kvpExclude.Key, GetListAsRString(kvpExclude.Value.ToList(), bWithQuotes:=False))
                Next
                clsGetItems.AddParameter("exclude", clsRFunctionParameter:=clsExcludeList)
            End If
            If strDataFrameName <> "" Then
                clsGetItems.AddParameter("data_name", Chr(34) & strDataFrameName & Chr(34))
            End If
            If strExcludedItems IsNot Nothing AndAlso strExcludedItems.Count > 0 Then
                clsGetItems.AddParameter("excluded_items", GetListAsRString(strExcludedItems.ToList()))
            End If
            expItems = RunInternalScriptGetValue(clsGetItems.ToScript(), bSilent:=True)
            If expItems IsNot Nothing AndAlso Not expItems.Type = Internals.SymbolicExpressionType.Null Then
                vecColumns = expItems.AsList
                For i = 0 To vecColumns.Count - 1
                    If vecColumns.Count > 1 Then
                        grps = New ListViewGroup(key:=vecColumns.Names(i), headerText:=vecColumns.Names(i))
                        lstView.Groups.Add(grps)
                    End If
                    chrCurrColumns = vecColumns(i).AsCharacter
                    If chrCurrColumns IsNot Nothing Then
                        For j = 0 To chrCurrColumns.Count - 1
                            lstView.Items.Add(chrCurrColumns(j))
                            lstView.Items(j).Tag = vecColumns.Names(i)
                            lstView.Items(j).ToolTipText = chrCurrColumns(j)
                            If vecColumns.Count > 1 Then
                                lstView.Items(j).Group = lstView.Groups(i)
                            End If
                        Next
                        If strType = "column" Then
                            strColumnsRList = GetListAsRString(chrCurrColumns.ToList)
                            clsGetColumnTypes.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_column_data_types")
                            clsGetColumnTypes.AddParameter("data_name", Chr(34) & vecColumns.Names(i) & Chr(34))
                            clsGetColumnTypes.AddParameter("columns", strColumnsRList)
                            expItems = RunInternalScriptGetValue(clsGetColumnTypes.ToScript(), bSilent:=True)
                            If expItems IsNot Nothing AndAlso Not expItems.Type = Internals.SymbolicExpressionType.Null Then
                                strCurrColumnTypes = expItems.AsCharacter.ToArray
                            Else
                                strCurrColumnTypes = New String(chrCurrColumns.Count - 1) {}
                            End If
                            clsGetColumnLabels.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_column_labels")
                            clsGetColumnLabels.AddParameter("data_name", Chr(34) & vecColumns.Names(i) & Chr(34))
                            clsGetColumnLabels.AddParameter("columns", strColumnsRList)
                            expItems = frmMain.clsRLink.RunInternalScriptGetValue(clsGetColumnLabels.ToScript())
                            If expItems IsNot Nothing AndAlso Not expItems.Type = Internals.SymbolicExpressionType.Null Then
                                strCurrColumnLables = expItems.AsCharacter.ToArray
                            Else
                                strCurrColumnLables = New String(chrCurrColumns.Count - 1) {}
                            End If
                            For j = 0 To chrCurrColumns.Count - 1
                                strTemp = strCurrColumnLables(j)
                                If strCurrColumnLables(j) <> "" Then
                                    lstView.Items(j).ToolTipText = lstView.Items(j).ToolTipText & vbNewLine & strTemp
                                End If
                                strTemp = strCurrColumnTypes(j)
                                If strTemp <> "" Then
                                    lstView.Items(j).ToolTipText = lstView.Items(j).ToolTipText & vbNewLine & strTemp
                                End If
                            Next
                        End If
                    End If
                Next
                lstView.Columns(0).Width = -2
                ' When there is a vertical scroll bar, Width = -2 makes it slightly wider than needed
                ' causing the horizontal scroll bar to display even when not needed.
                ' Reducing the Width by ~ 2 removes the horizontal scroll bar when it's not needed 
                ' and doesn't affect the visibility of the longest item
                ' This has been tested on high resolution screens but needs further testing
                ' and possibly a better solution.
                lstView.Columns(0).Width = lstView.Columns(0).Width - 2
                If strTopItemText <> "" Then
                    lviTemp = lstView.FindItemWithText(strTopItemText)
                    If lviTemp IsNot Nothing Then
                        lstView.TopItem = lviTemp
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub LogScript(strScript As String, Optional strComment As String = "")

        Dim strScriptWithComment As String =
                If(String.IsNullOrWhiteSpace(strComment),
                    "", strComment & Environment.NewLine) &
                If(String.IsNullOrWhiteSpace(strScript),
                    "",
                    strScript & Environment.NewLine)

        If String.IsNullOrWhiteSpace(strScriptWithComment) Then
            Exit Sub
        End If

        frmMain.ucrScriptWindow.LogText(strScriptWithComment)
        AppendToAutoSaveLog(strScriptWithComment)
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Selects the specified <paramref name="strDataFrameName"/> data frame columns in 
    '''             the <paramref name="ucrCurrentReceiver"/> receiver. 
    '''             Columns are specified by <paramref name="strProperty"/> property and 
    '''             <paramref name="strValues"/> values.</summary>
    '''
    ''' <param name="ucrCurrentReceiver">   The receiver to add the column names to (may be a single 
    '''                                     or multiple receiver). </param>
    ''' <param name="strDataFrameName">     The data frame name. </param>
    ''' <param name="strProperty">          Type of column to display in the receiver.
    '''                                     This is passed as a parameter to the R 'list' command. </param>
    ''' <param name="strValues">            List of column names to display in the receiver.
    '''                                     These are passed as 'include' parameters to
    '''                                     the R 'list' command. </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub SelectColumnsWithMetadataProperty(ucrCurrentReceiver As ucrReceiver, strDataFrameName As String, strProperty As String, strValues As String())
        Dim vecColumns As GenericVector
        Dim chrCurrColumns As CharacterVector
        Dim i As Integer
        Dim clsGetItems As New RFunction
        Dim clsIncludeList As New RFunction
        Dim kvpInclude As KeyValuePair(Of String, String())
        Dim lstItems As New List(Of KeyValuePair(Of String, String))
        Dim expColumns As SymbolicExpression
        Dim ucrReceiverTempMultiple As ucrReceiverMultiple

        kvpInclude = New KeyValuePair(Of String, String())(strProperty, strValues)
        ucrCurrentReceiver.Selector.LoadList()
        If bInstatObjectExists Then
            clsGetItems.SetRCommand(strInstatDataObject & "$get_column_names")
            clsGetItems.AddParameter("as_list", "TRUE")
            If strDataFrameName <> "" Then
                clsGetItems.AddParameter("data_name", Chr(34) & strDataFrameName & Chr(34))
            End If
            clsIncludeList.SetRCommand("list")
            clsIncludeList.AddParameter(kvpInclude.Key, GetListAsRString(kvpInclude.Value.ToList(), bWithQuotes:=False))
            clsGetItems.AddParameter("include", clsRFunctionParameter:=clsIncludeList)
            expColumns = RunInternalScriptGetValue(clsGetItems.ToScript(), bSilent:=True)
            If expColumns IsNot Nothing AndAlso Not expColumns.Type = Internals.SymbolicExpressionType.Null Then
                vecColumns = expColumns.AsList
            Else
                vecColumns = Nothing
            End If
            ucrCurrentReceiver.Clear()
            If vecColumns IsNot Nothing Then
                For i = 0 To vecColumns.Count - 1
                    chrCurrColumns = vecColumns(i).AsCharacter
                    If chrCurrColumns Is Nothing Then
                        Continue For
                    End If
                    For Each strColumn As String In chrCurrColumns
                        lstItems.Add(New KeyValuePair(Of String, String)(strDataFrameName, strColumn))
                    Next
                Next
                If TypeOf ucrCurrentReceiver Is ucrReceiverSingle Then
                    If lstItems.Count > 0 Then
                        ucrCurrentReceiver.Add(lstItems(0).Value, lstItems(0).Key)
                    End If
                ElseIf TypeOf ucrCurrentReceiver Is ucrReceiverMultiple Then
                    ucrReceiverTempMultiple = DirectCast(ucrCurrentReceiver, ucrReceiverMultiple)
                    ucrReceiverTempMultiple.AddMultiple(lstItems.ToArray())
                End If
            End If
        End If
        ucrCurrentReceiver.Selector.LoadList()
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets a single concatenated string containing all the strings in <paramref name="lstStrings"/>.
    '''             The returned string has the form "(str1,str2,str3, ...)". </summary>
    '''
    ''' <param name="lstStrings">   The list of strings to concatenate. </param>
    ''' <param name="bWithQuotes">  (Optional) If true then surround each string with quotes. </param>
    '''
    ''' <returns>   As single concatenated string containing all the strings in <paramref name="lstStrings"/>. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetListAsRString(lstStrings As List(Of String), Optional bWithQuotes As Boolean = True) As String
        Dim strTemp As String = ""
        Dim i As Integer

        If lstStrings.Count = 1 Then
            If bWithQuotes Then
                strTemp = Chr(34) & lstStrings.Item(0) & Chr(34)
            Else
                strTemp = lstStrings.Item(0)
            End If
        ElseIf lstStrings.Count > 1 Then
            strTemp = "c" & "("
            For i = 0 To lstStrings.Count - 1
                If i > 0 Then
                    strTemp = strTemp & ","
                End If
                If lstStrings.Item(i) <> "" Then
                    If bWithQuotes Then
                        strTemp = strTemp & Chr(34) & lstStrings.Item(i) & Chr(34)
                    Else
                        strTemp = strTemp & lstStrings.Item(i)
                    End If
                End If
            Next
            strTemp = strTemp & ")"
        End If
        Return strTemp
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Queries if a given data frame exists. </summary>
    '''
    ''' <param name="strDataFrameName"> The data frame name. </param>
    '''
    ''' <returns>   True if <paramref name="strDataFrameName"/> data frame exists, else false. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function DataFrameExists(strDataFrameName As String) As Boolean
        Dim bExists As Boolean
        Dim clsDataFrameExists As New RFunction
        Dim expExists As SymbolicExpression

        clsDataFrameExists.SetRCommand(strInstatDataObject & "$data_frame_exists")
        clsDataFrameExists.AddParameter("data_name", Chr(34) & strDataFrameName & Chr(34))
        expExists = RunInternalScriptGetValue(clsDataFrameExists.ToScript(), bSilent:=True)
        If expExists IsNot Nothing AndAlso Not expExists.Type = Internals.SymbolicExpressionType.Null Then
            bExists = expExists.AsLogical(0)
        Else
            bExists = False
        End If
        Return bExists
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets the data frame count. </summary>
    '''
    ''' <returns>   The data frame count. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetDataFrameCount() As Integer
        Dim iCount As Integer
        Dim clsDataFrameCount As New RFunction
        Dim expCount As SymbolicExpression

        clsDataFrameCount.SetRCommand(strInstatDataObject & "$dataframe_count")
        expCount = RunInternalScriptGetValue(clsDataFrameCount.ToScript(), bSilent:=True)
        If expCount IsNot Nothing AndAlso Not expCount.Type = Internals.SymbolicExpressionType.Null Then
            iCount = expCount.AsInteger(0)
        Else
            iCount = 0
        End If
        Return iCount
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets the length of <paramref name="strDataFrameName"/> data frame. </summary>
    '''
    ''' <param name="strDataFrameName">     The name of the data frame. </param>
    ''' <param name="bUseCurrentFilter">    (Optional) The value for the R 'use_current_filter' 
    '''                                     parameter. </param>
    '''
    ''' <returns>   The data frame length. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetDataFrameLength(strDataFrameName As String, Optional bUseCurrentFilter As Boolean = False) As Integer
        Dim iLength As Integer
        Dim clsDataFrameLength As New RFunction
        Dim expLength As SymbolicExpression

        clsDataFrameLength.SetRCommand(strInstatDataObject & "$get_data_frame_length")
        clsDataFrameLength.AddParameter("data_name", Chr(34) & strDataFrameName & Chr(34))
        If bUseCurrentFilter Then
            clsDataFrameLength.AddParameter("use_current_filter", "TRUE")
        Else
            clsDataFrameLength.AddParameter("use_current_filter", "FALSE")
        End If
        expLength = RunInternalScriptGetValue(clsDataFrameLength.ToScript(), bSilent:=True)
        If expLength IsNot Nothing AndAlso Not expLength.Type = Internals.SymbolicExpressionType.Null Then
            iLength = expLength.AsInteger(0)
        Else
            iLength = 0
        End If
        Return iLength
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets the number of columns in the <paramref name="strDataFrameName"/> data 
    '''             frame. </summary>
    '''
    ''' <param name="strDataFrameName"> The data frame name. </param>
    '''
    ''' <returns>   The number of columns in the <paramref name="strDataFrameName"/> data frame. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetDataFrameColumnCount(strDataFrameName As String, Optional bUseCurrentSelection As Boolean = False) As Integer
        Dim iColumnCount As Integer
        Dim clsDataFrameColCount As New RFunction
        Dim expCount As SymbolicExpression

        clsDataFrameColCount.SetRCommand(strInstatDataObject & "$get_column_count")
        clsDataFrameColCount.AddParameter("data_name", Chr(34) & strDataFrameName & Chr(34))
        If bUseCurrentSelection Then
            clsDataFrameColCount.AddParameter("use_column_selection", "TRUE")
        Else
            clsDataFrameColCount.AddParameter("use_column_selection", "FALSE")
        End If
        expCount = RunInternalScriptGetValue(clsDataFrameColCount.ToScript(), bSilent:=True)
        If expCount IsNot Nothing AndAlso Not expCount.Type = Internals.SymbolicExpressionType.Null Then
            iColumnCount = expCount.AsInteger(0)
        Else
            iColumnCount = 0
        End If
        Return iColumnCount
    End Function


    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets the names of the <paramref name="strDataFrameName"/> data frame's filters. </summary>
    '''
    ''' <param name="strDataFrameName"> (Optional) The data frame name. </param>
    '''
    ''' <returns>   The names of the <paramref name="strDataFrameName"/> data frame's filters. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetFilterNames(strDataFrameName As String) As List(Of String)
        Return GetNames(strDataFrameName, "$get_filter_names")
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets the names of the <paramref name="strDataFrameName"/> data frame's column selection. </summary>
    '''
    ''' <param name="strDataFrameName"> (Optional) The data frame name. </param>
    '''
    ''' <returns>   The names of the <paramref name="strDataFrameName"/> data frame's column selection. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetColumnSelectionNames(strDataFrameName As String) As List(Of String)
        Return GetNames(strDataFrameName, "$get_column_selection_names")
    End Function


    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets the names of the <paramref name="strDataFrameName"/> data frame's keys. </summary>
    '''
    ''' <param name="strDataFrameName"> (Optional) The data frame name. </param>
    '''
    ''' <returns>   The names of the <paramref name="strDataFrameName"/> data frame's survs. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetKeyNames(Optional strDataFrameName As String = "") As List(Of String)
        Return GetNames(strDataFrameName, "$get_key_names")
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets the names of the <paramref name="strDataFrameName"/> data frame's links. </summary>
    '''
    ''' <param name="strDataFrameName"> (Optional) The data frame name. </param>
    '''
    ''' <returns>   The names of the <paramref name="strDataFrameName"/> data frame's survs. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetLinkNames(Optional strDataFrameName As String = "") As List(Of String)
        Return GetNames(strDataFrameName, "$get_link_names")
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets the table, filter, graph, key, surv or link names of the <paramref name="strDataFrameName"/> 
    '''             data frame depending on the <paramref name="strRCommand"/>. </summary>
    '''
    ''' <param name="strDataFrameName"> (Optional) The data frame name. </param>
    ''' <param name="strRCommand">(Optional)The name of the Rfunction command.</param>
    '''
    ''' <returns>   The table,filter,graph,key,surv or link names of the <paramref name="strDataFrameName"/> 
    '''             data frame. </returns>
    '''--------------------------------------------------------------------------------------------
    Private Function GetNames(strDataFrameName As String, strRCommand As String) As List(Of String)
        Dim lstNames As New List(Of String)
        Dim clsGetNames As New RFunction
        Dim expNames As SymbolicExpression

        clsGetNames.SetRCommand(strInstatDataObject & strRCommand)

        If strDataFrameName <> "" Then
            clsGetNames.AddParameter("data_name", Chr(34) & strDataFrameName & Chr(34))
        End If
        expNames = RunInternalScriptGetValue(clsGetNames.ToScript(), bSilent:=True)
        If expNames IsNot Nothing AndAlso Not expNames.Type = Internals.SymbolicExpressionType.Null Then
            lstNames = expNames.AsCharacter.ToArray.ToList
        End If
        Return lstNames
    End Function


    '''--------------------------------------------------------------------------------------------
    ''' <summary>
    '''  Gets the names of the <paramref name="strDataFrameName"/> data frame's objects. 
    ''' </summary>
    ''' <param name="strDataFrameName">(Optional) The data frame name.</param>
    ''' <param name="strRObjectTypeLabel">(Optional) The object type label to get.</param>
    ''' <returns></returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetObjectNames(Optional strDataFrameName As String = "",
                                   Optional strRObjectTypeLabel As String = "") As List(Of String)
        Dim lstObjectNames As New List(Of String)
        Dim clsGetObjectNamesRFunction As New RFunction
        Dim expNames As SymbolicExpression

        clsGetObjectNamesRFunction.SetRCommand(strInstatDataObject & "$get_object_names")
        If Not String.IsNullOrEmpty(strDataFrameName) Then
            clsGetObjectNamesRFunction.AddParameter("data_name", Chr(34) & strDataFrameName & Chr(34))
        End If
        If Not String.IsNullOrEmpty(strRObjectTypeLabel) Then
            clsGetObjectNamesRFunction.AddParameter("object_type_label", Chr(34) & strRObjectTypeLabel & Chr(34))
        End If
        expNames = RunInternalScriptGetValue(clsGetObjectNamesRFunction.ToScript(), bSilent:=True)
        If expNames IsNot Nothing AndAlso Not expNames.Type = Internals.SymbolicExpressionType.Null Then
            lstObjectNames = expNames.AsCharacter.ToArray.ToList
        End If
        Return lstObjectNames
    End Function


    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets the data type of the <paramref name="strColumnName"/> column in the 
    '''             <paramref name="strDataFrameName"/> data frame. </summary>
    '''
    ''' <param name="strDataFrameName"> The data frame name. </param>
    ''' <param name="strColumnName">    The column name. </param>
    '''
    ''' <returns>   The data type of the <paramref name="strColumnName"/> column in the
    '''             <paramref name="strDataFrameName"/> data frame. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetDataType(strDataFrameName As String, strColumnName As String) As String
        'TODO SJL 22/04/20 What's the difference between this function and the function below? Could we delete one?
        Dim strDataType As String
        Dim clsGetDataType As New RFunction
        Dim expType As SymbolicExpression

        clsGetDataType.SetRCommand(strInstatDataObject & "$get_data_type")
        clsGetDataType.AddParameter("data_name", Chr(34) & strDataFrameName & Chr(34))
        clsGetDataType.AddParameter("col_name", Chr(34) & strColumnName & Chr(34))
        expType = RunInternalScriptGetValue(clsGetDataType.ToScript(), bSilent:=True)
        If expType IsNot Nothing AndAlso Not expType.Type = Internals.SymbolicExpressionType.Null Then
            strDataType = expType.AsCharacter(0)
        Else
            strDataType = ""
        End If
        Return strDataType
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets the data type of the <paramref name="strColumnName"/> column in the 
    '''             <paramref name="strDataName"/> data frame. </summary>
    '''
    ''' <param name="strDataName"> The data frame name. </param>
    ''' <param name="strColumnName">    The column name. </param>
    '''
    ''' <returns>   The data type of the <paramref name="strColumnName"/> column in the
    '''             <paramref name="strDataName"/> data frame. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetColumnType(strDataName As String, strColumnName As String) As String
        Dim strDataType As String
        Dim clsGetColumnType As New RFunction
        Dim expDateType As SymbolicExpression

        clsGetColumnType.SetRCommand(strInstatDataObject & "$get_column_data_types")
        clsGetColumnType.AddParameter("data_name", Chr(34) & strDataName & Chr(34))
        clsGetColumnType.AddParameter("columns", Chr(34) & strColumnName & Chr(34))
        expDateType = RunInternalScriptGetValue(clsGetColumnType.ToScript(), bSilent:=True)
        If expDateType IsNot Nothing AndAlso expDateType.Type <> Internals.SymbolicExpressionType.Null Then
            strDataType = String.Join(",", expDateType.AsCharacter)
        Else
            strDataType = ""
        End If
        Return strDataType
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Makes a syntactically valid R name from <paramref name="strText"/>. Please see 
    '''             the R documentation for valid name syntax.<para>
    '''             If it's not possible to make a valid name from <paramref name="strText"/> then 
    '''             returns "".</para> </summary>
    '''
    ''' <param name="strText">  The name to convert to a valid name. </param>
    '''
    ''' <returns>   A syntactically valid R name derived from <paramref name="strText"/>. 
    '''             If it's not possible to make a valid name from <paramref name="strText"/> then
    '''             returns "".</returns>
    '''--------------------------------------------------------------------------------------------
    Public Function MakeValidText(strText As String) As String
        Dim strOut As String
        Dim clsMakeNames As New RFunction
        Dim expOut As SymbolicExpression

        clsMakeNames.SetRCommand("make.names")
        clsMakeNames.AddParameter("names", Chr(34) & strText & Chr(34))
        expOut = RunInternalScriptGetValue(clsMakeNames.ToScript(), bSilent:=True)
        If expOut IsNot Nothing AndAlso Not expOut.Type = Internals.SymbolicExpressionType.Null Then
            strOut = expOut.AsCharacter(0)
        Else
            strOut = ""
        End If
        Return strOut
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   If <paramref name="strText"/> is a syntactically valid R name then returns true, 
    '''             else returns false. 
    '''             Please see the R documentation for valid name syntax. </summary>
    '''
    ''' <param name="strText">  The name to check. </param>
    '''
    ''' <returns>   True if <paramref name="strText"/> is a syntactically valid R name,
    '''             else returns false. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function IsValidText(strText As String) As String
        Dim strValidText As String
        Dim clsMakeNames As New RFunction

        strValidText = MakeValidText(strText)
        Return (strText = strValidText)
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets corruption contract data frame names. </summary>
    '''
    ''' <returns>   The corruption contract data frame names. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetCorruptionContractDataFrameNames() As List(Of String)
        Dim clsGetDataNames As New RFunction
        Dim lstNames As List(Of String)
        Dim expDataNames As SymbolicExpression

        clsGetDataNames.SetRCommand(strInstatDataObject & "$get_corruption_contract_data_names")
        expDataNames = RunInternalScriptGetValue(clsGetDataNames.ToScript(), bSilent:=True)
        If expDataNames IsNot Nothing AndAlso Not expDataNames.Type = Internals.SymbolicExpressionType.Null Then
            lstNames = expDataNames.AsCharacter.ToList()
        Else
            lstNames = New List(Of String)
        End If
        Return lstNames
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets corruption column of type <paramref name="strType"/> in data frame 
    '''             <paramref name="strDataName"/>. </summary>
    '''
    ''' <param name="strDataName">  The data frame name. </param>
    ''' <param name="strType">      The column type. </param>
    '''
    ''' <returns>   The corruption column of type <paramref name="strType"/> in data frame <paramref name="strDataName"/>. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetCorruptionColumnOfType(strDataName As String, strType As String) As String
        Dim clsGetColumnName As New RFunction
        Dim strColumn As String
        Dim expColumn As SymbolicExpression

        clsGetColumnName.SetRCommand(strInstatDataObject & "$get_corruption_column_name")
        clsGetColumnName.AddParameter("data_name", Chr(34) & strDataName & Chr(34))
        clsGetColumnName.AddParameter("type", strType)
        expColumn = RunInternalScriptGetValue(clsGetColumnName.ToScript(), bSilent:=True)
        If expColumn IsNot Nothing AndAlso Not expColumn.Type = Internals.SymbolicExpressionType.Null Then
            strColumn = expColumn.AsCharacter(0)
        Else
            strColumn = ""
        End If
        Return strColumn
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets climatic column of type. </summary>
    '''
    ''' <param name="strDataName">  The data frame name. </param>
    ''' <param name="strType">      The column type. </param>
    '''
    ''' <returns>   The climatic column of type. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetClimaticColumnOfType(strDataName As String, strType As String) As String
        Dim clsGetColumnName As New RFunction
        Dim strColumn As String
        Dim expColumn As SymbolicExpression

        clsGetColumnName.SetRCommand(strInstatDataObject & "$get_climatic_column_name")
        clsGetColumnName.AddParameter("data_name", Chr(34) & strDataName & Chr(34))
        clsGetColumnName.AddParameter("col_name", strType)
        expColumn = RunInternalScriptGetValue(clsGetColumnName.ToScript(), bSilent:=True)
        If expColumn IsNot Nothing AndAlso Not expColumn.Type = Internals.SymbolicExpressionType.Null Then
            strColumn = expColumn.AsCharacter(0)
        Else
            strColumn = ""
        End If
        Return strColumn
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets names of the columns of the corruption components in 
    '''             the <paramref name="strDataName"/> data frame. </summary>
    '''
    ''' <param name="strDataName">  The data frame name. </param>
    '''
    ''' <returns>   The names of the columns of the corruption components in
    '''             the <paramref name="strDataName"/> data frame. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetCorruptionComponentsColumnNames(strDataName As String) As String()
        Return GetColumnNames(strDataName, "$get_CRI_component_column_names")
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets CRI column names. </summary>
    '''
    ''' <param name="strDataName">  The data frame name. </param>
    '''
    ''' <returns>   The CRI column names. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetCRIColumnNames(strDataName As String) As String()
        Return GetColumnNames(strDataName, "$get_CRI_column_names")
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets red flag column names. </summary>
    '''
    ''' <param name="strDataName">  The data frame name. </param>
    '''
    ''' <returns>   The red flag column names. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetRedFlagColumnNames(strDataName As String) As String()
        Return GetColumnNames(strDataName, "$get_red_flag_column_names")
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets specific column names from the <paramref name="strDataFrameName"/> data 
    '''             frame as specified by the <paramref name="strRCommand"/> RFunction command name. 
    '''             </summary>
    '''
    ''' <param name="strDataFrameName"> (Optional) The data frame name. </param>
    ''' <param name="strRCommand"> (Optional)The Rfunction's command name that specifies the column 
    '''                            names to get.</param>
    '''
    ''' <returns>   The column names of the <paramref name="strDataFrameName"/> data frame as 
    '''             specifed by <paramref name="strRCommand"/> RFunction command. </returns>
    '''--------------------------------------------------------------------------------------------
    Private Function GetColumnNames(strDataFrameName As String, strRCommand As String) As String()
        Dim clsGetColumnName As New RFunction
        Dim strColumn() As String
        Dim expColumn As SymbolicExpression

        clsGetColumnName.SetRCommand(strInstatDataObject & strRCommand)
        clsGetColumnName.AddParameter("data_name", Chr(34) & strDataFrameName & Chr(34))
        expColumn = RunInternalScriptGetValue(clsGetColumnName.ToScript(), bSilent:=True)
        If expColumn IsNot Nothing AndAlso Not expColumn.Type = Internals.SymbolicExpressionType.Null Then
            strColumn = expColumn.AsCharacter.ToArray()
        Else
            strColumn = Nothing
        End If
        Return strColumn
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Returns true if column <paramref name="strColumn"/> in data frame 
    '''             <paramref name="strDataName"/> contains binary data. Else returns false. </summary>
    '''
    ''' <param name="strDataName">  The data frame name. </param>
    ''' <param name="strColumn">    The column. </param>
    '''
    ''' <returns>   True if column <paramref name="strColumn"/> in data frame
    '''             <paramref name="strDataName"/> contains binary data. Else returns false. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function IsBinary(strDataName As String, strColumn As String) As Boolean
        Dim clsGetColumn As New RFunction
        Dim clsIsBinary As New RFunction
        Dim bIsBinary As Boolean
        Dim expBinary As SymbolicExpression

        clsGetColumn.SetRCommand(strInstatDataObject & "$get_columns_from_data")
        clsGetColumn.AddParameter("data_name", Chr(34) & strDataName & Chr(34))
        clsGetColumn.AddParameter("col_names", Chr(34) & strColumn & Chr(34))
        clsIsBinary.SetRCommand("is.binary")
        clsIsBinary.AddParameter("x", clsRFunctionParameter:=clsGetColumn)
        expBinary = RunInternalScriptGetValue(clsIsBinary.ToScript())
        If expBinary IsNot Nothing AndAlso Not expBinary.Type = Internals.SymbolicExpressionType.Null Then
            bIsBinary = expBinary.AsLogical(0)
        Else
            bIsBinary = False
        End If
        Return bIsBinary
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Returns true if column <paramref name="strColumn"/> in data frame 
    '''             <paramref name="strDataName"/> has property <paramref name="strProperty"/>. 
    '''             Else returns false. </summary>
    '''
    ''' <param name="strDataName">  The data frame name. </param>
    ''' <param name="strProperty">  The property to look for. </param>
    ''' <param name="strColumn">    (Optional) The column name. </param>
    '''
    ''' <returns>   True if column <paramref name="strColumn"/> in data frame
    '''             <paramref name="strDataName"/> has property <paramref name="strProperty"/>.
    '''             Else returns false. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function IsVariablesMetadata(strDataName As String, strProperty As String, Optional strColumn As String = "") As Boolean
        Dim clsIsVarMetadata As New RFunction
        Dim bIsVarMetadata As Boolean
        Dim expIsVar As SymbolicExpression

        clsIsVarMetadata.SetRCommand(strInstatDataObject & "$is_variables_metadata")
        clsIsVarMetadata.AddParameter("data_name", Chr(34) & strDataName & Chr(34))
        If strColumn <> "" Then
            clsIsVarMetadata.AddParameter("column", Chr(34) & strColumn & Chr(34))
        End If
        clsIsVarMetadata.AddParameter("property", Chr(34) & strProperty & Chr(34))
        expIsVar = RunInternalScriptGetValue(clsIsVarMetadata.ToScript(), bSilent:=True)
        If expIsVar IsNot Nothing AndAlso expIsVar.Type <> Internals.SymbolicExpressionType.Null Then
            bIsVarMetadata = expIsVar.AsLogical(0)
        Else
            bIsVarMetadata = False
        End If
        Return bIsVarMetadata
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Sets whether to show the wait window (the window that is optionally displayed 
    '''             while an R script is running). </summary>
    '''
    ''' <param name="bNewShow"> If true then show the wait window. </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub SetShowWaitDialog(bNewShow As Boolean)
        bShowWaitDialog = bNewShow
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Sets the time in seconds to wait before showing the waiting dialog. </summary>
    '''
    ''' <param name="iTimeInSeconds">   The delay in seconds (must be >= 0). </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub SetWaitDelayTime(iTimeInSeconds As Integer)
        If iTimeInSeconds <= 0 Then
            MsgBox("Wait time must be a positive integer. Resetting to default of 2 seconds.", MsgBoxStyle.Exclamation, "Invalid value")
            iTimeInSeconds = 2
        End If
        iWaitDelay = iTimeInSeconds
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Prefixes each line of text in <paramref name="strComment"/> with '# '. </summary>
    '''
    ''' <param name="strComment">   The comment text. </param>
    '''
    ''' <returns>   <paramref name="strComment"/> converted to a valid R comment. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetFormattedComment(strComment As String) As String
        Dim strReconstructedComment As String = ""
        Dim arrCommentParts As String()
        If strComment.Length > 0 Then
            arrCommentParts = strComment.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            For Each strPart As String In arrCommentParts
                If strReconstructedComment = "" Then
                    strReconstructedComment = "# " & strPart
                Else
                    strReconstructedComment = strReconstructedComment & Environment.NewLine & "# " & strPart
                End If
            Next
        End If
        Return strReconstructedComment
    End Function

    Private Function IsStatementAssignment(strRStatement As String) As Boolean
        Return strRStatement.Contains("<-")
    End Function

    Private Function IsStatementPrint(strRStatement As String) As Boolean
        Dim strRStatementTrimmed As String = TrimStartRStatement(strRStatement)
        Return strRStatementTrimmed.StartsWith("print")
    End Function

    Private Function IsStatementViewObject(strRStatement As String) As Boolean
        Dim strRStatementTrimmed As String = TrimStartRStatement(strRStatement)
        Return strRStatementTrimmed.StartsWith(strInstatDataObject & "$get_object_data") _
               OrElse strRStatementTrimmed.StartsWith(strInstatDataObject & "$get_last_object_data") _
               OrElse strRStatementTrimmed.StartsWith("view_object_data")
    End Function

    Private Function TrimStartRStatement(strRStatement As String) As String
        Dim arrTrimChars As Char() = {" "c, vbTab, vbLf, vbCr}
        Return strRStatement.TrimStart(arrTrimChars)
    End Function

End Class