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

Imports RDotNet
Imports unvell.ReoGrid
Imports System.IO
Imports RScript

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

    ''' The log window.
    Public txtLog As New TextBox

    ''' True if the log window is defined
    Public bLog As Boolean = False

    ''' <summary> True if the R output window is defined.</summary>
    Public bOutput As Boolean = True


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
    Private strRBundledVersion As String = "4.1.0"

    Private clsOutputLogger As clsOutputLogger

    ''' <summary>
    ''' Create method for clsRLink
    ''' Must pass in the output logger so the R link knows where to post outputs to
    ''' </summary>
    ''' <param name="outputLogger"></param>
    Public Sub New(outputLogger As clsOutputLogger)
        clsOutputLogger = outputLogger
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Initialises the connection with the R environment:
    ''' <list type="bullet">
    '''     <item><description>
    '''             Ensures that a suitable version of R is installed
    '''     </description></item><item><description>
    '''             Sets the necessary environment variables
    '''     </description></item><item><description>
    '''             Creates and initializes the REngine (which enacpsulates the R environment)
    '''     </description></item><item><description>
    '''             Sets the working directory
    '''     </description></item><item><description>
    '''             Loads the R packages, and displays information about any missing packages 
    '''     </description></item>
    ''' </list></summary>
    '''
    ''' <param name="strScript">        (Optional) The R setup script to execute. If "" then 
    '''                                 a default setup script is used. </param>
    ''' <param name="iCallType">        (Optional) How to display the output from the setup script:
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
    ''' </list>
    '''                                 Note: If a script line contains "$get_graphs" then call 
    '''                                 type is set to 3 just for that line.</param>
    ''' <param name="strComment">       (Optional) The comment to display before the first line of
    '''                                 <paramref name="strScript"/>.
    '''                                 If <paramref name="strScript"/> is not defined then a
    '''                                 default comment is used. </param>
    ''' <param name="bSeparateThread">  (Optional) If true then execute the R script in a new 
    '''                                 thread. </param>
    '''
    ''' <returns>   True if it succeeds, false if it fails. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function StartREngine(Optional strScript As String = "", Optional iCallType As Integer = 0, Optional strComment As String = "", Optional bSeparateThread As Boolean = True) As Boolean
        Dim strMissingPackages() As String
        Dim expTemp As SymbolicExpression
        Dim strMajor As String = ""
        Dim strMinor As String = ""
        Dim iCurrentCallType As Integer
        Dim bClose As Boolean = False
        Dim strStaticPath = Path.GetFullPath("static")
        Dim rHome = Path.Combine(strStaticPath, "R-" & strRBundledVersion)
        Dim cpuArchitectureFolder = "i386"

        Try
            ' Get R .NET to use bundled R in static folder
            ' This static folder is added as a part of the install process as described in 
            ' installer/Installer_Generation_Guide.md
            ' 
            If Environment.Is64BitProcess Then
                cpuArchitectureFolder = "x64"
            End If
            Dim rPath = Path.Combine(rHome, "bin", cpuArchitectureFolder)
            Console.WriteLine("R Home: " & rHome)
            Console.WriteLine("R Path: " & rPath)

            ' Use bundled R if included
            If Directory.Exists(rHome) And Directory.Exists(rPath) Then
                Console.WriteLine("Using bundled R")
                REngine.SetEnvironmentVariables(rPath, rHome)
            Else
                ' Use normal process for finding local R if bundled version not included
                REngine.SetEnvironmentVariables()
            End If

            clsEngine = REngine.GetInstance()
            clsEngine.Initialize()
        Catch ex As Exception
            ' Modified message since currently we recommend use of same R version as bundled version
            MsgBox(ex.Message & Environment.NewLine & "Could not establish connection to R." & vbNewLine & "R-Instat requires version " & strRVersionRequired & " of R." & vbNewLine & "Note that R-Instat does not work with R below 3.5.0. We recommend using R " & strRBundledVersion & ".  Try reruning the installation to install R " & strRBundledVersion & " or download R " & strRBundledVersion & " from https://cran.r-project.org/bin/windows/base/old/" & strRBundledVersion & "/ and restart R-Instat." & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Cannot initialise R connection.")
            Application.Exit()
            Environment.Exit(0)
        End Try
        Try
            expTemp = RunInternalScriptGetValue("R.Version()$major", bSilent:=True)
            If expTemp IsNot Nothing AndAlso expTemp.Type <> Internals.SymbolicExpressionType.Null Then
                strMajor = expTemp.AsCharacter(0)
            End If
            expTemp = RunInternalScriptGetValue("R.Version()$minor", bSilent:=True)
            If expTemp IsNot Nothing AndAlso expTemp.Type <> Internals.SymbolicExpressionType.Null Then
                strMinor = expTemp.AsCharacter(0)
            End If
            Dim strRVersionRunning = strMajor & "." & strMinor
            If strMinor.Count >= 3 Then
                If Not (strMajor = strRVersionMajorRequired AndAlso strMinor.Count > 0 AndAlso strMinor(0) >= strRVersionMinorRequired) Then
                    MsgBox("Your current version of R is outdated. You are currently running R version: " & strRVersionRunning & vbNewLine &
                           "R-Instat requires at least version " & strRVersionRequired & " or greater." &
                           vbNewLine & "Try reruning the installation to install an updated version of R or download R from " &
                           "https://cran.r-project.org/bin/windows/base/" & strRVersionRequired & "and restart R-Instat.", MsgBoxStyle.Critical, "R Version not supported.")
                    Application.Exit()
                    Environment.Exit(0)
                End If
            Else
                MsgBox("Could not determine version of R installed on your machine. R-Instat requires version: " & strRVersionRequired & vbNewLine &
                       "Try uninstalling any versions of R and rerun the installation to install R " & strRVersionRequired & " or download R " &
                       strRVersionRequired & "From https://cran.r-project.org/bin/windows/base/old/" & strRVersionRequired &
                       "And restart R-Instat.", MsgBoxStyle.Critical, "R Version error.")
                Application.Exit()
                Environment.Exit(0)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & Environment.NewLine & "Could not determine the version of R installed on your machine. We recommend rerunning the installation to install an updated version of R or download the latest version from https://cran.r-project.org/ and restart R-Instat.", MsgBoxStyle.Critical, "Cannot determine R version.")

            Application.Exit()
            Environment.Exit(0)
        End Try
        bREngineInitialised = True
        If strScript = "" Then
            strScript = GetRSetupScript()
            iCallType = 0
            strComment = "Setting working directory, sourcing R code and loading R packages"

            bSeparateThread = True
        End If
        For Each strLine As String In strScript.Split(Environment.NewLine)
            If strLine.Trim(vbLf).Count > 0 Then
                If strLine.Contains(strInstatDataObject & "$get_graphs") Then
                    iCurrentCallType = 3
                Else
                    iCurrentCallType = iCallType
                End If
                RunScript(strScript:=strLine.Trim(vbLf), iCallType:=iCurrentCallType, strComment:=strComment, bSeparateThread:=bSeparateThread, bSilent:=True)
            End If
            strComment = ""
        Next
        strMissingPackages = GetPackagesNotInstalled()
        If strMissingPackages IsNot Nothing AndAlso strMissingPackages.Count > 0 Then
            frmPackageIssues.SetMissingPackages(strMissingPackages)
            frmPackageIssues.ShowDialog()
            bClose = frmPackageIssues.bCloseRInstat
        End If
        bInstatObjectExists = True
        Return bClose
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary> This method executes the <paramref name="strNewScript"/> R script and displays 
    '''           the output as text or graph (determined by <paramref name="strNewScript"/>).
    '''           <para>R commands may be split over multiple lines. This is only allowed if the  
    '''           non-final line ends with '+', ',', or '%>%'; or there are one or more '{'
    '''           brackets that have not been closed with an equivalent '}' bracket.
    '''           This function is named '...FromWindow' because it's designed to execute scripts 
    '''           entered by a human from a dialog window (e.g. a script window). These scripts 
    '''           may contain R commands split over multiple lines to make the commands more 
    '''           readable.</para>
    ''' </summary>
    ''' <param name="strNewScript">    The R script to execute.</param>
    ''' <param name="strNewComment">   Shown as a comment. If this parameter is "" then shows 
    '''                                <paramref name="strNewScript"/> as the comment.</param>
    ''' 
    ''' <returns> Any text at the end of <paramref name="strNewScript"/> that was not executed.
    '''           If all the text in <paramref name="strNewScript"/> was executed then returns "".
    '''           </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function RunScriptFromWindow(strNewScript As String, strNewComment As String) As String
        Dim strScriptCmd As String = ""


        'for each line in script
        For Each strScriptLine As String In strNewScript.Split(Environment.NewLine)
            'remove any comments (character '#' and anything after)
            Dim iCommentPos As Integer = strScriptLine.IndexOf("#")
            Select Case iCommentPos
                Case 0      'a normal comment line (starts with '#')
                    Continue For
                Case Is > 0 ' a line with an appended comment (e.g. 'x <- 1 # generate data' converted to 'x <- 1 ')
                    strScriptLine = strScriptLine.Substring(0, iCommentPos - 1)
            End Select

            'if line is empty or only whitespace then ignore line
            Dim strTrimmedLine As String = strScriptLine.Trim(vbLf).Trim()
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
                Continue For
            End If

            'else execute command
            Dim iCallType As Integer = 5
            If strScriptCmd.Contains(strInstatDataObject & "$get_graphs") Then
                iCallType = 3
            End If
            RunScript(strScriptCmd.Trim(vbLf), iCallType:=iCallType, strComment:=strNewComment, bSeparateThread:=False, bSilent:=False)
            strScriptCmd = ""
            strNewComment = ""
        Next
        Return strScriptCmd
    End Function

    ''' <summary>
    ''' Extracts all the complete runnable R commands from <paramref name="strScript"/>.
    ''' The command lines returned are re-formatted in a format that the R.Net engine can execute.
    ''' </summary>
    ''' <param name="strScript">R script command. Can be a multiline script command</param>
    ''' <returns>an array that contains individual complete runnable R scripts</returns>
    Public Function GetRunnableCommandLines(strScript As String) As String()
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
    Public Function GetPackagesNotInstalled() As String()
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
        Dim clsImportRDS As New RFunction
        Dim clsReadRDS As New RFunction
        Dim strScript As String = ""
        Dim strTemp As String = ""

        clsReadRDS.SetRCommand("readRDS")
        clsReadRDS.AddParameter("file", Chr(34) & strFile.Replace("\", "/") & Chr(34))
        clsReadRDS.SetAssignTo("new_RDS")

        clsImportRDS.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$import_RDS")
        clsImportRDS.AddParameter("data_RDS", clsRFunctionParameter:=clsReadRDS, iPosition:=0)
        'This RFunction takes booleans in capitals hence ToUpper
        clsImportRDS.AddParameter("keep_existing", bKeepExisting.ToString.ToUpper, iPosition:=1)

        strTemp = clsImportRDS.ToScript(strScript)
        RunScript(strScript & strTemp, strComment:=strComment)
        bInstatObjectExists = True
    End Sub

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
    ''' <summary>   Sets the log window. </summary>
    '''
    ''' <param name="tempLog">  The log window. </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub SetLog(tempLog As TextBox)
        txtLog = tempLog
        bLog = True
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
    ''' <summary>   Fills the data frame control combo box with the specified data frame names and
    '''             sets the combo box index.
    '''             The data frames to include, and the source of the index are set by the 
    '''             parameters below.</summary>
    '''
    ''' <param name="cboDataFrames">                    [in,out] The combobox data frames control. </param>
    ''' <param name="bSetDefault">                      (Optional) If true then sets the combo box 
    '''                                                 index to the index of the current worksheet.
    '''                                                 If false then sets the index to the index of 
    '''                                                 the current data frame. </param>
    ''' <param name="bIncludeOverall">                  (Optional) If true then adds an extra item 
    '''                                                 in the combo box for '[Overall]' i.e. items 
    '''                                                 not at data frame level. </param>
    ''' <param name="strCurrentDataFrame">              (Optional) The current data frame. </param>
    ''' <param name="bOnlyLinkedToPrimaryDataFrames">   (Optional) If true then only fill the 
    '''                                                 combo box with data frame names linked to 
    '''                                                 <paramref name="strPrimaryDataFrame"/>. </param>
    ''' <param name="strPrimaryDataFrame">              (Optional) The primary data frame. </param>
    ''' <param name="bIncludePrimaryDataFrameAsLinked"> (Optional) If true then also include the 
    '''                                                 <paramref name="strPrimaryDataFrame"/> in 
    '''                                                 the list of data frames. 
    '''                                                 This parameter is only used if 
    '''                                                 <paramref name="bOnlyLinkedToPrimaryDataFrames"/> 
    '''                                                 is true.</param>
    '''--------------------------------------------------------------------------------------------
    Public Sub FillComboDataFrames(ByRef cboDataFrames As ComboBox, Optional bSetDefault As Boolean = True, Optional bIncludeOverall As Boolean = False, Optional strCurrentDataFrame As String = "", Optional bOnlyLinkedToPrimaryDataFrames As Boolean = False, Optional strPrimaryDataFrame As String = "", Optional bIncludePrimaryDataFrameAsLinked As Boolean = True)
        If bInstatObjectExists Then
            If bIncludeOverall Then
                cboDataFrames.Items.Add("[Overall]") 'TODO legacy - Task/question: explain this.
            End If
            If bOnlyLinkedToPrimaryDataFrames Then
                cboDataFrames.Items.AddRange(GetLinkedToDataFrameNames(strPrimaryDataFrame, bIncludePrimaryDataFrameAsLinked).ToArray)
            Else
                cboDataFrames.Items.AddRange(GetDataFrameNames().ToArray)
            End If
            AdjustComboBoxWidth(cboDataFrames)
            'TODO Legacy - Task/Question: From what I understood, if bSetDefault is true or if the strCurrentDataFrame (given as an argument) is actually not in cboDataFrames (is this case generic or should it never happen ?), then the selected Index should be the current worksheet.
            If (bSetDefault OrElse cboDataFrames.Items.IndexOf(strCurrentDataFrame) = -1) AndAlso (grdDataView IsNot Nothing) AndAlso (grdDataView.CurrentWorksheet IsNot Nothing) Then
                cboDataFrames.SelectedIndex = cboDataFrames.Items.IndexOf(grdDataView.CurrentWorksheet.Name)
            ElseIf cboDataFrames.Items.IndexOf(strCurrentDataFrame) <> -1 Then
                cboDataFrames.SelectedIndex = cboDataFrames.Items.IndexOf(strCurrentDataFrame)
            End If
        End If
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Adjust combo box width. </summary>
    '''
    ''' <param name="cboCurrent">   The combo box to adjust. </param>
    '''--------------------------------------------------------------------------------------------
    Public Shared Sub AdjustComboBoxWidth(cboCurrent As ComboBox)
        'TODO Legacy - This is used above but will not be once ucrDataFrame uses proper controls
        ' Then this can be removed
        ' TODO SJL 20/04/20 This is only used by the function above. Make private?
        Dim iWidth As Integer = cboCurrent.DropDownWidth
        Dim graTemp As System.Drawing.Graphics = cboCurrent.CreateGraphics()
        Dim font As Font = cboCurrent.Font
        Dim iScrollBarWidth As Integer
        Dim iNewWidth As Integer

        If cboCurrent.Items.Count > cboCurrent.MaxDropDownItems Then
            iScrollBarWidth = SystemInformation.VerticalScrollBarWidth
        Else
            iScrollBarWidth = 0
        End If

        For Each strItem As String In cboCurrent.Items
            iNewWidth = CInt(graTemp.MeasureString(strItem, font).Width) + iScrollBarWidth
            iWidth = Math.Max(iWidth, iNewWidth)
        Next
        cboCurrent.DropDownWidth = iWidth
    End Sub

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
    Private Sub AppendToAutoSaveLog(strScript As String)
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
    ''' <summary>
    ''' This method executes the <paramref name="strScript"/> R script and displays the output. The
    ''' output may be displayed as text, graph or in a web browser (see <paramref name="iCallType"/>).
    ''' </summary>
    ''' <param name="strScript"> is the R script to execute.</param>
    ''' <param name="iCallType"> defines how to display the R output.
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
    Public Sub RunScript(strScript As String, Optional iCallType As Integer = 0, Optional strComment As String = "", Optional bSeparateThread As Boolean = True, Optional bShowWaitDialogOverride As Nullable(Of Boolean) = Nothing, Optional bUpdateGrids As Boolean = True, Optional bSilent As Boolean = False)
        Dim strCapturedScript As String
        Dim expTemp As RDotNet.SymbolicExpression
        Dim strTemp As String = ""
        Dim strOutput As String
        Dim strScriptWithComment As String
        Dim strSplitScript As String
        Dim strTempGraphsDirectory As String
        Dim clsPNGFunction As New RFunction
        Dim strTempAssignTo As String = ".temp_val"
        Dim bSuccess As Boolean
        Dim bError As Boolean = False

        ' set temp folder for graphs, e.g. to "C:\Users\myName\Temp\R_Instat_Temp_Graphs"
        strTempGraphsDirectory = System.IO.Path.Combine(System.IO.Path.GetTempPath() & "R_Instat_Temp_Graphs")
        'Need to create directory as R unable to create the directory in linux
        If Not Directory.Exists(strTempGraphsDirectory) Then
            Directory.CreateDirectory(strTempGraphsDirectory)
        End If

        strOutput = ""

        ' if comment provided
        If strComment <> "" Then
            ' Prefix comment to script, e.g. "# Code generated by the dialog, Import Dataset" & vbCrLf & "new_RDS <- readRDS(file=""C:/Users/myName ...
            strComment = GetFormattedComment(strComment)
            strScriptWithComment = strComment & Environment.NewLine & strScript
        Else
            strScriptWithComment = strScript
        End If
        If bLog Then
            txtLog.Text = txtLog.Text & strScriptWithComment & Environment.NewLine
        End If
        ' if the output window is defined then output comments (if exists) and script (if 'bShowCommands' is true).
        If bOutput Then
            clsOutputLogger.AddRScript(strScriptWithComment)
        End If

        'TODO SJL 20/04/20 - is the commented out check below needed?
        'If strScript.Length > 2000 Then
        '    MsgBox("The following command cannot be run because it exceeds the character limit of 2000 characters for a command in R-Instat." & Environment.NewLine & strScript & Environment.NewLine & Environment.NewLine & "It may be possible to run the command directly in R.", MsgBoxStyle.Critical, "Cannot run command")

        ' if script output should be ignored, or returned as a graph
        If iCallType = 0 OrElse iCallType = 3 Then
            Try
                'if output should be returned as a graph
                If iCallType = 3 Then
                    If strGraphDisplayOption = "view_output_window" OrElse strGraphDisplayOption = "view_separate_window" Then
                        clsPNGFunction.SetPackageName("grDevices")
                        clsPNGFunction.SetRCommand("png")
                        clsPNGFunction.AddParameter("filename", Chr(34) & System.IO.Path.Combine(strTempGraphsDirectory & "/Graph.png").Replace("\", "/") & Chr(34))
                        'TODO make these options
                        clsPNGFunction.AddParameter("width", 4000)
                        clsPNGFunction.AddParameter("height", 4000)
                        clsPNGFunction.AddParameter("res", 500)
                        bSuccess = Evaluate(clsPNGFunction.ToScript(), bSilent:=True, bSeparateThread:=bSeparateThread, bShowWaitDialogOverride:=bShowWaitDialogOverride)
                        ' Temporary solution to being unable to save graphs in a temporary location for display.
                        ' This can occur if System.IO.Path.GetTempPath() returns a path that is not writable.
                        If Not bSuccess Then
                            Evaluate("graphics.off()", bSilent:=bSilent, bSeparateThread:=bSeparateThread, bShowWaitDialogOverride:=bShowWaitDialogOverride)
                            strGraphDisplayOption = "view_R_viewer"
                            MsgBox("A problem occured saving graphs in the temporary location " & strTempGraphsDirectory & vbNewLine & vbNewLine & "To ensure graphs can still be viewed, graphs will now appear in a pop up R viewer." & vbNewLine & "Restarting R-Instat and/or your machine usually resolves this. You can change this setting back in Tools > Options: 'Graph Display' if this later becomes resolved.", MsgBoxStyle.Exclamation)

                        End If
                        'need to boost resolution of the devices, it's not as good as with ggsave.
                    End If
                End If
                If iCallType = 3 AndAlso strGraphDisplayOption = "view_R_viewer" Then
                    Evaluate(strScript, bSilent:=bSilent, bSeparateThread:=False, bShowWaitDialogOverride:=bShowWaitDialogOverride)
                Else 'TODO SJL this is the only line executed if iCallType is 0. Move outside if block to simplify logic?
                    Evaluate(strScript, bSilent:=bSilent, bSeparateThread:=bSeparateThread, bShowWaitDialogOverride:=bShowWaitDialogOverride)
                End If
                If iCallType = 3 Then
                    If strGraphDisplayOption = "view_output_window" OrElse strGraphDisplayOption = "view_separate_window" Then
                        'add an R script (maybe in the form of one of our methods) that copies divices to the temp directory, using the default device production... use dev.list() and dev.copy() with arguments device = the devices in the list and which = jpeg devices with different paths leading to the temp directory, using a paste() method to find different names for the files
                        Evaluate("graphics.off()", bSilent:=bSilent, bSeparateThread:=bSeparateThread, bShowWaitDialogOverride:=bShowWaitDialogOverride) 'not quite sure if this would work, otherwise find the right way to close the appropriate devices.
                        'clsEngine.Evaluate("ggsave(" & Chr(34) & strTempGraphsDirectory.Replace("\", "/") & "Graph.jpg" & Chr(34) & ")")
                        'This sub is used to display graphics in the output window when necessary.
                        'This sub is checking the temp directory "R_Instat_Temp_Graphs", created during setup to see if there are any graphs to display. If there are some, then it sends them to the output window, and removes them from the directory.
                        'It is called from RLink at the end of RunScript.
                        Dim lstTempGraphFiles As ObjectModel.ReadOnlyCollection(Of String)
                        Dim iNumberOfFiles As Integer = -1
                        strTempGraphsDirectory = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "R_Instat_Temp_Graphs")
                        Try
                            lstTempGraphFiles = FileIO.FileSystem.GetFiles(strTempGraphsDirectory)
                        Catch e As Exception
                            lstTempGraphFiles = Nothing
                            MsgBox(e.Message & Environment.NewLine & "A problem occured in getting the content of the temporary graphs directory: " & strTempGraphsDirectory & " Possible exceptions are described here: https://msdn.microsoft.com/en-us/library/kf41fdf4.aspx", MsgBoxStyle.Critical)
                        End Try
                        If lstTempGraphFiles IsNot Nothing Then
                            iNumberOfFiles = CStr(lstTempGraphFiles.Count)
                        End If
                        If iNumberOfFiles > 0 Then
                            For Each strFileName As String In lstTempGraphFiles
                                If strGraphDisplayOption = "view_output_window" Then
                                    clsOutputLogger.AddImageOutput(strFileName)
                                ElseIf strGraphDisplayOption = "view_separate_window" Then
                                    frmMain.AddGraphForm(strFileName)
                                End If
                                Try
                                    My.Computer.FileSystem.DeleteFile(strFileName)
                                Catch e As Exception
                                    MsgBox(e.Message & Environment.NewLine & "A problem occured in attempting to delete the temporary file: " & strFileName & " The possible exceptions are described here: https://msdn.microsoft.com/en-us/library/tdx72k4b.aspx", MsgBoxStyle.Critical)
                                End Try
                            Next
                        End If
                    End If
                End If
            Catch e As Exception
                MsgBox(e.Message & Environment.NewLine & "The error occurred in attempting to run the following R command(s):" & Environment.NewLine & strScript, MsgBoxStyle.Critical, "Error running R command(s)")
            End Try
        ElseIf iCallType = 1 OrElse iCallType = 4 Then 'else if script output should be stored in a temp variable
            ' TODO SJL In RInstat, iCallType only seems to be 0, 2 or 3. Are call types 1 and 4 used?
            Try
                'TODO check this is valid syntax in all cases
                '     i.e. this is potentially: x <- y <- 1
                Evaluate(strTempAssignTo & " <- " & strScript, bSilent:=bSilent, bSeparateThread:=bSeparateThread, bShowWaitDialogOverride:=bShowWaitDialogOverride)
                expTemp = GetSymbol(strTempAssignTo)
                If expTemp IsNot Nothing Then
                    strTemp = String.Join(Environment.NewLine, expTemp.AsCharacter())
                    strOutput = strOutput & strTemp & Environment.NewLine
                End If
            Catch e As Exception
                MsgBox(e.Message & Environment.NewLine & "The error occurred in attempting to run the following R command(s):" & Environment.NewLine & strScript, MsgBoxStyle.Critical, "Error running R command(s)")
            End Try
        Else ' else if script output should not be ignored, not stored in a graph and not stored in a variable
            'if script comes from script window, or else script is a single line
            If iCallType = 5 OrElse strScript.Trim(Environment.NewLine.ToCharArray).LastIndexOf(Environment.NewLine.ToCharArray) = -1 Then
                'wrap the whole script in 'capture.output'
                '  'capture.output' returns the result of the R command as a string.
                '  This string can be displayed later in the output window.
                strCapturedScript = "capture.output(" & strScript & ")"
            Else 'else if script is multi-line
                'execute all lines apart from the final line
                strSplitScript = Left(strScript, strScript.Trim(Environment.NewLine.ToCharArray).LastIndexOf(Environment.NewLine.ToCharArray))
                If strSplitScript <> "" Then
                    Try
                        bError = Not Evaluate(strSplitScript, bSilent:=bSilent, bSeparateThread:=bSeparateThread, bShowWaitDialogOverride:=bShowWaitDialogOverride)
                    Catch e As Exception
                        MsgBox(e.Message & Environment.NewLine & "The error occurred in attempting to run the following R command(s):" & Environment.NewLine & strScript, MsgBoxStyle.Critical, "Error running R command(s)")
                    End Try
                End If
                'ensure that the final line of the script will be executed next
                strSplitScript = Right(strScript, strScript.Length - strScript.Trim(Environment.NewLine.ToCharArray).LastIndexOf(Environment.NewLine.ToCharArray) - 2)
                'wrap the final line in 'capture.output' so that when it's executed, the result can be displayed in the output window
                strCapturedScript = "capture.output(" & strSplitScript & ")"
            End If
            Try
                If Not bError Then
                    'execute the script and assign the result to a temporary variable
                    If Evaluate(strTempAssignTo & " <- " & strCapturedScript, bSilent:=bSilent, bSeparateThread:=bSeparateThread, bShowWaitDialogOverride:=bShowWaitDialogOverride) Then
                        expTemp = GetSymbol(strTempAssignTo)
                        Evaluate("rm(" & strTempAssignTo & ")", bSilent:=True)
                        If expTemp IsNot Nothing Then
                            strTemp = String.Join(Environment.NewLine, expTemp.AsCharacter())
                            If strTemp <> "" Then
                                'ensure that the data returned from the script will be displayed in the output window
                                strOutput = strOutput & strTemp & Environment.NewLine
                            End If
                        End If
                    End If
                End If
            Catch e As Exception
                MsgBox(e.Message & Environment.NewLine & "The error occurred in attempting to run the following R command(s):" & Environment.NewLine & strScript, MsgBoxStyle.Critical, "Error running R command(s)")
            End Try
        End If

        ' if output window is defined, and there's something to output
        If bOutput AndAlso strOutput IsNot Nothing AndAlso strOutput <> "" Then
            ' if output should be sent to web browser
            If iCallType = 4 Then
                '  rtbOutput.AddIntoWebBrowser(strHtmlCode:=strOutput)
                'TODO Add to web browser
            Else
                clsOutputLogger.AddStringOutput(strOutput)
            End If
        End If
        AppendToAutoSaveLog(strScriptWithComment & Environment.NewLine)
        If bUpdateGrids Then
            frmMain.UpdateAllGrids()
        End If
    End Sub

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
                                                                  frmSetupLoading.Show()
                                                              End If
                                                              While thrRScript.IsAlive
                                                                  If bErrorMessageOpen Then
                                                                      frmSetupLoading.Close()
                                                                  End If
                                                                  Threading.Thread.Sleep(5)
                                                                  Application.DoEvents()
                                                              End While
                                                              frmSetupLoading.Close()
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
    ''' <summary>   Gets the next default data frame name. </summary>
    '''
    ''' <param name="strPrefix">        The value for the R 'prefix' parameter. </param>
    ''' <param name="iStartIndex">      (Optional) The value for the R 'start_index' parameter. </param>
    ''' <param name="bIncludeIndex">    (Optional) The value for the R 'include_index' parameter. </param>
    '''
    ''' <returns>   The next default data frame name. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetDefaultDataFrameName(strPrefix As String, Optional iStartIndex As Integer = 1, Optional bIncludeIndex As Boolean = True) As String
        Dim strTemp As String
        Dim clsGetNextDataName As New RFunction
        Dim expName As SymbolicExpression

        clsGetNextDataName.SetRCommand(strInstatDataObject & "$get_next_default_dataframe_name")
        clsGetNextDataName.AddParameter("prefix", Chr(34) & strPrefix & Chr(34))
        clsGetNextDataName.AddParameter("start_index", iStartIndex)
        If Not bInstatObjectExists Then
            CreateNewInstatObject()
        End If
        If bIncludeIndex Then
            clsGetNextDataName.AddParameter("include_index", "TRUE")
        Else
            clsGetNextDataName.AddParameter("include_index", "FALSE")
        End If
        expName = RunInternalScriptGetValue(clsGetNextDataName.ToScript(), bSilent:=True)
        If expName IsNot Nothing AndAlso Not expName.Type = Internals.SymbolicExpressionType.Null Then
            strTemp = expName.AsCharacter(0)
        Else
            strTemp = ""
        End If
        Return strTemp
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets the R setup script.</summary>
    '''
    ''' <returns>   The R setup script. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetRSetupScript() As String
        Dim clsSetWd As New RFunction
        Dim clsSource As New RFunction
        Dim clsCreateIO As New ROperator
        Dim clsDplyrOption As New RFunction
        Dim strScript As String = ""

        clsSetWd.SetRCommand("setwd")
        clsSetWd.AddParameter("dir", Chr(34) & Path.Combine(frmMain.strStaticPath.Replace("\", "/") & strInstatObjectPath) & Chr(34)) 'This is bad the wd should be flexible and not automatically set to the instat object directory 
        clsSource.SetRCommand("source")
        clsSource.AddParameter("file", Chr(34) & "Rsetup.R" & Chr(34))
        clsCreateIO.SetOperation("<-")
        clsCreateIO.AddParameter("left", strInstatDataObject, iPosition:=0)
        clsCreateIO.AddParameter("right", strDataBookClassName & "$new()", iPosition:=1)
        clsDplyrOption.SetRCommand("options")
        clsDplyrOption.AddParameter("dplyr.summarise.inform", "FALSE", iPosition:=0)

        strScript = ""
        strScript = strScript & clsSetWd.ToScript() & Environment.NewLine
        strScript = strScript & clsSource.ToScript() & Environment.NewLine
        strScript = strScript & clsCreateIO.ToScript() & Environment.NewLine
        strScript = strScript & clsDplyrOption.ToScript()

        Return strScript
    End Function

    ''' <summary>   Creates a new instat object. </summary>
    Public Sub CreateNewInstatObject()
        RunScript(strInstatDataObject & " <- " & strDataBookClassName & "$new()", strComment:="Defining new Instat Object")
        bInstatObjectExists = True
    End Sub

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
                Case "metadata"
                    clsGetItems.SetRCommand(strInstatDataObject & "$get_metadata_fields")
                Case "filter"
                    clsGetItems.SetRCommand(strInstatDataObject & "$get_filter_names")
                Case "column_selection"
                    clsGetItems.SetRCommand(strInstatDataObject & "$get_column_selection_names")
                Case "object"
                    clsGetItems.SetRCommand(strInstatDataObject & "$get_object_names")
                Case "model"
                    clsGetItems.SetRCommand(strInstatDataObject & "$get_model_names")
                Case "graph"
                    clsGetItems.SetRCommand(strInstatDataObject & "$get_graph_names")
                Case "surv"
                    clsGetItems.SetRCommand(strInstatDataObject & "$get_surv_names")
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
                Case "table"
                    clsGetItems.SetRCommand(strInstatDataObject & "$get_table_names")
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
    Public Function GetDataFrameColumnCount(strDataFrameName As String) As Integer
        Dim iColumnCount As Integer
        Dim clsDataFrameColCount As New RFunction
        Dim expCount As SymbolicExpression

        clsDataFrameColCount.SetRCommand(strInstatDataObject & "$get_column_count")
        clsDataFrameColCount.AddParameter("data_name", Chr(34) & strDataFrameName & Chr(34))
        expCount = RunInternalScriptGetValue(clsDataFrameColCount.ToScript(), bSilent:=True)
        If expCount IsNot Nothing AndAlso Not expCount.Type = Internals.SymbolicExpressionType.Null Then
            iColumnCount = expCount.AsInteger(0)
        Else
            iColumnCount = 0
        End If
        Return iColumnCount
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets the names of the <paramref name="strDataFrameName"/> data frame's models. </summary>
    '''
    ''' <param name="strDataFrameName"> (Optional) The data frame name. </param>
    '''
    ''' <returns>   The names of the <paramref name="strDataFrameName"/> data frame's models. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetModelNames(Optional strDataFrameName As String = "") As List(Of String)
        Return GetNames(strDataFrameName, "$get_model_names")
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets the names of the <paramref name="strDataFrameName"/> data frame's tables. </summary>
    '''
    ''' <param name="strDataFrameName"> (Optional) The data frame name. </param>
    '''
    ''' <returns>   The names of the <paramref name="strDataFrameName"/> data frame's tables. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetTableNames(Optional strDataFrameName As String = "") As List(Of String)
        Return GetNames(strDataFrameName, "$get_table_names")
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
    ''' <summary>   Gets the names of the <paramref name="strDataFrameName"/> data frame's graphs. </summary>
    '''
    ''' <param name="strDataFrameName"> (Optional) The data frame name. </param>
    '''
    ''' <returns>   The names of the <paramref name="strDataFrameName"/> data frame's graphs. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetGraphNames(Optional strDataFrameName As String = "") As List(Of String)
        Return GetNames(strDataFrameName, "$get_graph_names")
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets the names of the <paramref name="strDataFrameName"/> data frame's survs. </summary>
    '''
    ''' <param name="strDataFrameName"> (Optional) The data frame name. </param>
    '''
    ''' <returns>   The names of the <paramref name="strDataFrameName"/> data frame's survs. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetSurvNames(Optional strDataFrameName As String = "") As List(Of String)
        Return GetNames(strDataFrameName, "$get_surv_names")
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

    ''' <summary>   Closes the current instat data object, and opens a new one. </summary>
    Public Sub CloseData()
        Dim clsRm As New RFunction
        Dim clsCreateIO As New ROperator

        clsRm.SetRCommand("rm")
        clsRm.AddParameter("0", strInstatDataObject, iPosition:=0, bIncludeArgumentName:=False)
        clsRm.AddParameter("1", strGraphDataBook, iPosition:=1, bIncludeArgumentName:=False)

        clsCreateIO.SetOperation("<-")
        clsCreateIO.AddParameter("left", strInstatDataObject, iPosition:=0)
        clsCreateIO.AddParameter("right", strDataBookClassName & "$new()", iPosition:=1)

        bInstatObjectExists = False
        RunScript(clsRm.ToScript(), strComment:="Closing data")
        bInstatObjectExists = True
        RunScript(clsCreateIO.ToScript(), strComment:="Creating New Instat Object")
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   View last graph. </summary>
    '''
    ''' <param name="bAsPlotly">    (Optional) If true then view last graph as plotly. </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub ViewLastGraph(Optional bAsPlotly As Boolean = False)
        Dim clsLastGraph As New RFunction
        clsLastGraph.SetRCommand(strInstatDataObject & "$get_last_graph")

        If bAsPlotly Then
            Dim clsInteractivePlot As New RFunction
            clsLastGraph.AddParameter("print_graph", "FALSE", iPosition:=0)
            clsInteractivePlot.SetPackageName("plotly")
            clsInteractivePlot.SetRCommand("ggplotly")
            clsInteractivePlot.AddParameter("p", clsRFunctionParameter:=clsLastGraph, iPosition:=0)
            'Need to set iCallType = 2 to obtain a graph in an interactive viewer.
            RunScript(clsInteractivePlot.ToScript(), iCallType:=2, strComment:="View last graph as Plotly", bSeparateThread:=False)
        Else
            Dim strGlobalGraphDisplayOption As String
            'store the current set graph display option, to restore after display
            strGlobalGraphDisplayOption = Me.strGraphDisplayOption
            Me.strGraphDisplayOption = "view_R_viewer"
            RunScript(clsLastGraph.ToScript(), iCallType:=3, strComment:="View last graph", bSeparateThread:=False)
            'restore the graph display option
            Me.strGraphDisplayOption = strGlobalGraphDisplayOption
        End If
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

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   
    ''' Gets the list of clsRParameters from the <paramref name="strFunctionName"/> function 
    ''' definition. 
    ''' For example, the function "str_split(string, pattern, n = Inf, simplify = FALSE)" returns 
    ''' the following parameters:
    ''' <list type="bullet">
    '''     <item><description>
    '''             clsParameter 1: Argument Name ="string" , Parameter position = 0 , Default value = NOTHING 
    '''     </description></item><item><description>
    '''             clsParameter 2: Argument Name = "patterm" , Parameter position = 1 , Default value = NOTHING
    '''     </description></item><item><description>
    '''             clsParameter 3: Argument Name="n" , Parameter position = 2 , Default value = "Inf"
    '''     </description></item><item><description>
    '''             clsParameter 4: Argument Name="simplify" , Parameter position = 3 , Default value = "FALSE")
    '''     </description></item>
    ''' </list></summary>
    ''' 
    ''' <param name="strFunctionName">  The function name provided. </param>
    '''
    ''' <returns>   The list of clsRParameters. </returns>
    '''--------------------------------------------------------------------------------------------
    Private Function GetRFunctionDefinitionParameters(strFunctionName As String) As List(Of clsRParameter)
        'Note: this function is not currently called but it will be used in future
        '      functionality to populate dialogs from script.
        '      Please do not delete this function. (@lloyddewit 24/11/21)
        
        'temporary object that retrieves the output from the environment
        Dim strTempAssignTo As String = ".temp_func"
        Dim expTemp As SymbolicExpression
        Dim clsFormalsFunction As New RFunction
        Dim lstRParameters As New List(Of clsRParameter)
        Dim clsAsListFunction As New RFunction

        clsAsListFunction.SetRCommand("as.list")
        clsAsListFunction.AddParameter(clsRFunctionParameter:=clsFormalsFunction, bIncludeArgumentName:=False, iPosition:=0)

        'The 'formals' function returns the parameters for a specified function. 
        'for example, for the function "str_split(string, pattern, n = Inf, simplify = FALSE)", formals returns
        '    $string
        '    $pattern 
        '    $n 
        '    [1] Inf 
        '    $simplify 
        '    [1] FALSE 
        clsFormalsFunction.SetRCommand("formals")
        clsFormalsFunction.AddParameter(strParameterValue:=strFunctionName, bIncludeArgumentName:=False, iPosition:=0)

        'TODO check that the fuction name provided has no pening and closing brackets at the end
        '?QUESTION /CLARIFICATION Parameters value fror the function  ?gt::cols_merge() are being split into different parts
        If Not Evaluate(strTempAssignTo & " <- " & "capture.output(" & clsAsListFunction.ToScript() & ")", bSilent:=True) Then
            'Error getting the parameters either the function name provided is incorrect/package containing the function isn't loaded 
            Return Nothing
        End If
        expTemp = GetSymbol(strTempAssignTo)
        Evaluate("rm(" & strTempAssignTo & ")", bSilent:=True)
        If expTemp Is Nothing Then
            Return Nothing
        End If
        Dim iNewArgPosition As Integer = 0
        'parameter name position
        Dim iParameterName As Integer = 0
        'parameter value position
        Dim iParameterValue As Integer = 1
        While (iParameterName < expTemp.AsCharacter().Length)
            Dim clsNewRParameter As New clsRParameter

            'Assign the parameter Name
            clsNewRParameter.strArgName = expTemp.AsCharacter(iParameterName).TrimStart("$")
            'Adding the parameter value
            'check to remove the [1] notation before some parameter values
            If expTemp.AsCharacter(iParameterValue).Contains("[1]") Then
                Dim strcleanArgument As String = expTemp.AsCharacter(iParameterValue).Remove(expTemp.AsCharacter(iParameterValue).IndexOf("["), 3)
                clsNewRParameter.clsArgValueDefault = New clsRScript(strcleanArgument).lstRStatements(0).clsElement
            Else
                'Empty String are Not accepted hence the modification below
                If String.IsNullOrEmpty(expTemp.AsCharacter(iParameterValue)) Then
                    clsNewRParameter.clsArgValueDefault = New clsRScript("NODEFAULTVALUE").lstRStatements(0).clsElement
                Else
                    clsNewRParameter.clsArgValueDefault = New clsRScript(expTemp.AsCharacter(iParameterValue)).lstRStatements(0).clsElement
                End If

            End If
            'Assign the parameter Value
            clsNewRParameter.iArgPosDefinition = iNewArgPosition

            'TEMPORARY FUNCTIONALITY FOR PRESENTATION
            Console.WriteLine("PARAMETER" & clsNewRParameter.iArgPosDefinition)
            Console.WriteLine("..strArgumentName:" & clsNewRParameter.strArgName)
            Console.WriteLine("..strArgumentValue:" & clsNewRParameter.clsArgValueDefault.strTxt)
            Console.WriteLine("..ArgumentPosition:" & clsNewRParameter.iArgPosDefinition)

            iNewArgPosition += 1
            iParameterName += 3
            iParameterValue += 3
            lstRParameters.Add(clsNewRParameter)
        End While

        Return lstRParameters
    End Function
End Class
