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
Imports System.Data.SQLite
Imports System.IO
Imports System.Reflection

Public Class Translations

    '''--------------------------------------------------------------------------------------------
    ''' <summary>
    '''     Attempts to translate all the text in <paramref name="clsControl"/> to the currently
    '''     configured language.
    ''' </summary>
    '''
    ''' <param name="clsControl">    The WinForm control to translate. </param>
    '''--------------------------------------------------------------------------------------------
    Public Shared Sub autoTranslate(clsControl As Control)
        If IsNothing(TryCast(clsControl, Form)) Then
            Exit Sub
        End If

        HandleError(TranslateWinForm.clsTranslateWinForm.TranslateForm(clsControl, GetDbPath(), GetLanguageCode()))
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>
    '''     Attempts to translate all the text in the menu items in <paramref name="tsCollection"/> 
    '''     to  the currently configured language.
    ''' </summary>
    '''
    ''' <param name="tsCollection">     The WinForm menu items to translate. </param>
    ''' <param name="ctrParent">        The WinForm control that is the parent of the menu. </param>
    '''--------------------------------------------------------------------------------------------
    Public Shared Sub translateMenu(tsCollection As ToolStripItemCollection, ctrParent As Control)
        ' The 'WriteCsvFile' function call below should normally be commented out. 
        ' It only needs be uncommented and executed once, prior to each new release.
        'WriteCsvFile()

        ' The 'SetTranslateIgnore' function call below should normally be commented out.
        ' It only needs be uncommented when the 'translateIgnore.txt' file is updated, and the 
        ' changes need to be applied to the database.
        'SetTranslateIgnore()

        If IsNothing(tsCollection) OrElse IsNothing(ctrParent) OrElse IsNothing(TryCast(ctrParent, Form)) Then
            Exit Sub
        End If

        'translate the main form, including all its output windows and menus
        Dim strDbPath = GetDbPath()
        Dim strLanguageCode = GetLanguageCode()
        HandleError(TranslateWinForm.clsTranslateWinForm.TranslateForm(ctrParent, strDbPath, strLanguageCode))

        'The right mouse button menus for the 6 output windows are not accessible via 
        '    the control lists. Therefore, translate these menus explicitly
        HandleError(TranslateWinForm.clsTranslateWinForm.TranslateMenuItems(frmMain.ucrOutput.Name, frmMain.ucrOutput.UcrOutputPages.tsButtons.Items, strDbPath, strLanguageCode))
        HandleError(TranslateWinForm.clsTranslateWinForm.TranslateMenuItems(frmMain.ucrColumnMeta.Name, frmMain.ucrColumnMeta.cellContextMenuStrip.Items, strDbPath, strLanguageCode))
        HandleError(TranslateWinForm.clsTranslateWinForm.TranslateMenuItems(frmMain.ucrColumnMeta.Name, frmMain.ucrColumnMeta.columnContextMenuStrip.Items, strDbPath, strLanguageCode))
        HandleError(TranslateWinForm.clsTranslateWinForm.TranslateMenuItems(frmMain.ucrColumnMeta.Name, frmMain.ucrColumnMeta.statusColumnMenu.Items, strDbPath, strLanguageCode))
        HandleError(TranslateWinForm.clsTranslateWinForm.TranslateMenuItems(frmMain.ucrDataFrameMeta.Name, frmMain.ucrDataFrameMeta.cellContextMenuStrip.Items, strDbPath, strLanguageCode))
        HandleError(TranslateWinForm.clsTranslateWinForm.TranslateMenuItems(frmMain.ucrDataFrameMeta.Name, frmMain.ucrDataFrameMeta.rowRightClickMenu.Items, strDbPath, strLanguageCode))
        HandleError(TranslateWinForm.clsTranslateWinForm.TranslateMenuItems(frmMain.ucrLogWindow.Name, frmMain.ucrLogWindow.mnuContextLogFile.Items, strDbPath, strLanguageCode))
        HandleError(TranslateWinForm.clsTranslateWinForm.TranslateMenuItems(frmMain.ucrScriptWindow.Name, frmMain.ucrScriptWindow.mnuContextScript.Items, strDbPath, strLanguageCode))
        HandleError(TranslateWinForm.clsTranslateWinForm.TranslateMenuItems(frmMain.ucrDataViewer.Name, frmMain.ucrDataViewer.rowContextMenu.Items, strDbPath, strLanguageCode))
        HandleError(TranslateWinForm.clsTranslateWinForm.TranslateMenuItems(frmMain.ucrDataViewer.Name, frmMain.ucrDataViewer.ColumnContextMenu.Items, strDbPath, strLanguageCode))
        HandleError(TranslateWinForm.clsTranslateWinForm.TranslateMenuItems(frmMain.ucrDataViewer.Name, frmMain.ucrDataViewer.CellContextMenu.Items, strDbPath, strLanguageCode))
        HandleError(TranslateWinForm.clsTranslateWinForm.TranslateMenuItems(frmMain.ucrDataViewer.Name, frmMain.ucrDataViewer.SheetTabContextMenu.Items, strDbPath, strLanguageCode))
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   
    '''     Returns <paramref name="strText"/> translated into the current language (e.g. French). 
    ''' </summary>
    '''
    ''' <param name="strText">  The text to translate. </param>
    '''
    ''' <returns>   <paramref name="strText"/> translated into the current language (e.g. French). 
    '''             </returns>
    '''--------------------------------------------------------------------------------------------
    Public Shared Function GetTranslation(strText As String) As String
        If String.IsNullOrEmpty(strText) Then
            Return ""
        End If

        Return TranslateWinForm.clsTranslateWinForm.GetTranslation(strText, GetDbPath(), GetLanguageCode())
    End Function


    '''--------------------------------------------------------------------------------------------
    ''' <summary>   
    '''    Displays an error message box that displays <paramref name="strErrorMsg"/>.
    '''    If <paramref name="strErrorMsg"/> is empty then does nothing.
    ''' </summary>
    '''
    ''' <param name="strErrorMsg">  The error message to display. </param>
    '''--------------------------------------------------------------------------------------------
    Private Shared Sub HandleError(strErrorMsg As String)
        If Not String.IsNullOrEmpty(strErrorMsg) Then
            MsgBox(strErrorMsg, MsgBoxStyle.Exclamation)
        End If
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Returns the language code for the currently configured language (e.g. 'en' for 
    '''             English, 'fr' for French etc.). </summary>
    '''
    ''' <returns>   The language code for the currently configured language (e.g. 'en' for
    '''             English, 'fr' for French etc.). </returns>
    '''--------------------------------------------------------------------------------------------
    Private Shared Function GetLanguageCode() As String
        If IsNothing(frmMain) OrElse IsNothing(frmMain.clsInstatOptions) OrElse
                IsNothing(frmMain.clsInstatOptions.strLanguageCultureCode) Then
            Return "en"
        End If
        Dim arrLanguageCodes As String() = frmMain.clsInstatOptions.strLanguageCultureCode.Split(New Char() {"-"c})
        Return arrLanguageCodes(0)
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Returns the full path of the SQLite translations database file. </summary>
    '''
    ''' <returns>   The full path of the SQLite translations database file. </returns>
    '''--------------------------------------------------------------------------------------------
    Private Shared Function GetDbPath() As String
        Dim strTranslationsPath As String = String.Concat(System.Windows.Forms.Application.StartupPath, "/translations")
        Dim strDbFile As String = "rInstatTranslations.db"
        Dim strDbPath As String = System.IO.Path.Combine(strTranslationsPath, strDbFile)
        Return strDbPath
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   
    '''    Writes a CSV file that can be imported into the `TranslateWinForm` library database. 
    '''    This sub should be executed prior to each release to ensure that the `TranslateWinForm` 
    '''    database contains all the translatable text for the new release.
    '''    <para>
    '''    The CSV file contains the identifiers and associated text of each form, control and menu 
    '''    item in the application.     Please note that `ucrCheck` and `ucrInput` controls are 
    '''    specifically excluded. This is because the text for these controls is set dynamically 
    '''    at runtime.
    '''    </para><para>
    '''    This sub uses the `Reflection` package to automatically identify and traverse all the 
    '''    forms, menus and controls in the current release. This information can also be found by 
    '''    parsing the application source code files (e.g. the `resx` or `xlf` files). However, 
    '''    we considered the `Reflection` package to be a simpler and less error-prone solution.
    '''    </para>
    ''' </summary>
    '''--------------------------------------------------------------------------------------------
    Private Shared Sub WriteCsvFile()

        'Get list of all form classes in the application 
        '    (specifically, a list of 'Type' objects, each 'Type' object contains details about 
        '    a class)
        Dim clsAssembly As Assembly = Assembly.GetExecutingAssembly()
        Dim lstFormClasses As List(Of Type) = clsAssembly.GetTypes().Where(Function(t) t.BaseType = GetType(Form)).ToList()

        'Populate the csv string for each form in the project
        'Note: We know the name of each form class (see list above). We also know that 
        '      the 'My.Forms' object contains an object for each form class.
        '      Conveniently, the name of each object in 'My.Forms' is the same as the name of 
        '      the object's class. 
        '      Therefore we can use the class name as the object name in 'CallByName'.
        Dim strControlsAsCsv As String = ""
        For Each typFormClass As Type In lstFormClasses
            Dim frmTemp As Form = CallByName(My.Forms, typFormClass.Name, CallType.Get)
            Dim strTemp = TranslateWinForm.clsTranslateWinForm.GetControlsAsCsv(frmTemp)

            'Special case for radio buttons in panels: 
            '  Before the dialog is shown, each radio button is a direct child of the dialog 
            '  (e.g. 'dlg_Augment_rdoNewDataframe'). After the dialog is shown, the raio button becomes 
            '  a direct child of its parent panel.
            '  Therefore, we need to show the dialog before we traverse the dialog's control hierarchy.
            '  Unfortunately showing the dialog means that it has to be manually closed. So we only 
            '  show the dialog for this special case to save the developer from having to manually 
            '  close too many dialogs.
            '  TODO: launch each dialog in a new thread to avoid need for manual close?
            If strTemp.ToLower().Contains("pnl") AndAlso strTemp.ToLower().Contains("rdo") Then
                frmTemp.ShowDialog()
                strTemp = TranslateWinForm.clsTranslateWinForm.GetControlsAsCsv(frmTemp)
            End If

            strControlsAsCsv &= strTemp
        Next

        'The right mouse button menus for the 6 output windows are not accessible via 
        '    the control lists. Therefore, add these manually to the CSV file
        strControlsAsCsv &= TranslateWinForm.clsTranslateWinForm.GetMenuItemsAsCsv(frmMain.ucrOutput, frmMain.ucrOutput.UcrOutputPages.tsButtons.Items)
        strControlsAsCsv &= TranslateWinForm.clsTranslateWinForm.GetMenuItemsAsCsv(frmMain.ucrColumnMeta, frmMain.ucrColumnMeta.cellContextMenuStrip.Items)
        strControlsAsCsv &= TranslateWinForm.clsTranslateWinForm.GetMenuItemsAsCsv(frmMain.ucrColumnMeta, frmMain.ucrColumnMeta.columnContextMenuStrip.Items)
        strControlsAsCsv &= TranslateWinForm.clsTranslateWinForm.GetMenuItemsAsCsv(frmMain.ucrColumnMeta, frmMain.ucrColumnMeta.statusColumnMenu.Items)
        strControlsAsCsv &= TranslateWinForm.clsTranslateWinForm.GetMenuItemsAsCsv(frmMain.ucrDataFrameMeta, frmMain.ucrDataFrameMeta.cellContextMenuStrip.Items)
        strControlsAsCsv &= TranslateWinForm.clsTranslateWinForm.GetMenuItemsAsCsv(frmMain.ucrDataFrameMeta, frmMain.ucrDataFrameMeta.rowRightClickMenu.Items)
        strControlsAsCsv &= TranslateWinForm.clsTranslateWinForm.GetMenuItemsAsCsv(frmMain.ucrLogWindow, frmMain.ucrLogWindow.mnuContextLogFile.Items)
        strControlsAsCsv &= TranslateWinForm.clsTranslateWinForm.GetMenuItemsAsCsv(frmMain.ucrScriptWindow, frmMain.ucrScriptWindow.mnuContextScript.Items)
        strControlsAsCsv &= TranslateWinForm.clsTranslateWinForm.GetMenuItemsAsCsv(frmMain.ucrDataViewer, frmMain.ucrDataViewer.RowContextMenu.Items)
        strControlsAsCsv &= TranslateWinForm.clsTranslateWinForm.GetMenuItemsAsCsv(frmMain.ucrDataViewer, frmMain.ucrDataViewer.ColumnContextMenu.Items)
        strControlsAsCsv &= TranslateWinForm.clsTranslateWinForm.GetMenuItemsAsCsv(frmMain.ucrDataViewer, frmMain.ucrDataViewer.CellContextMenu.Items)
        strControlsAsCsv &= TranslateWinForm.clsTranslateWinForm.GetMenuItemsAsCsv(frmMain.ucrDataViewer, frmMain.ucrDataViewer.SheetTabContextMenu.Items)

        'Write the csv file
        Dim strDesktopPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Dim strFileName As String = "form_controls.csv"
        Dim strPath As String = System.IO.Path.Combine(strDesktopPath, strFileName)
        Using sw As New System.IO.StreamWriter(strPath)
            Console.WriteLine(strControlsAsCsv)
            sw.WriteLine(strControlsAsCsv)
            sw.Flush()
            sw.Close()
        End Using

        'This sub should only be used by developers to create the translation export files.
        'Therefore, exit the application with a message to ensure that this sub is not run 
        'accidentally in the release version. 
        MsgBox("The form controls' translation text was written to: " & strPath &
               ". The application will now exit.", MsgBoxStyle.Exclamation)
        System.Windows.Forms.Application.Exit()
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   
    '''    Updates the `TranslateWinForm` library database based on the specifications in the 
    '''    'translateIgnore.txt' file. This file provides a way to ignore specified WinForm 
    '''    controls when the application or dialog is translated into a different language.
    '''    <para>
    '''    For example, this file can be used to ensure that text that references pre-existing data 
    '''    or meta data (e.g. a file name, data frame name, column name, cell value etc.) stays the 
    '''    same, even when the rest of the dialog is translated into French or Portuguese.
    '''    </para><para>
    '''    This sub should be executed prior to each release to ensure that the `TranslateWinForm` 
    '''    database specifies all the controls to ignore during the translation.  </para>  
    ''' </summary>
    '''--------------------------------------------------------------------------------------------
    Private Shared Sub SetTranslateIgnore()
        Dim lstIgnore As New List(Of String)
        Dim lstIgnoreNegations As New List(Of String)

        'For each line in the ignore file
        Dim strDesktopPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Dim strFileName As String = "translateIgnore.txt"
        Dim strPath As String = System.IO.Path.Combine(strDesktopPath, strFileName)
        Using clsReader As New StreamReader(strPath)
            Do While clsReader.Peek() >= 0
                Dim strIgnoreFileLine = clsReader.ReadLine().Trim()
                If String.IsNullOrEmpty(strIgnoreFileLine) Then
                    Continue Do
                End If

                Select Case (strIgnoreFileLine(0))
                    Case "#"
                        'Ignore comment lines
                    Case "!"
                        'Add negation pattern to negation list
                        lstIgnoreNegations.Add(strIgnoreFileLine.Substring(1)) 'remove leading '!'
                    Case Else
                        'Add pattern to ignore list
                        lstIgnore.Add(strIgnoreFileLine)
                End Select
            Loop
        End Using

        'If the ignore file didn't contain any specifications, then exit
        If lstIgnore.Count <= 0 AndAlso lstIgnoreNegations.Count <= 0 Then
            MsgBox("The " & strPath & " ignore file was processed. No ignore specifications were found. " &
                   "The database was not updated. The application will now exit.", MsgBoxStyle.Exclamation)
            Application.Exit()
        End If

        'create the SQL command to update the database
        Dim strSqlUpdate As String = "UPDATE form_controls SET id_text = 'DoNotTranslate' WHERE "

        If lstIgnore.Count > 0 Then
            strSqlUpdate &= "("
            For iListPos As Integer = 0 To lstIgnore.Count - 1
                strSqlUpdate &= If(iListPos > 0, " OR ", "")
                strSqlUpdate &= "control_name LIKE '" & lstIgnore.Item(iListPos) & "'"
            Next iListPos
            strSqlUpdate &= ")"
        End If

        If lstIgnoreNegations.Count > 0 Then
            strSqlUpdate &= If(lstIgnore.Count > 0, " AND ", "")
            strSqlUpdate &= "NOT ("
            For iListPos As Integer = 0 To lstIgnoreNegations.Count - 1
                strSqlUpdate &= If(iListPos > 0, " OR ", "")
                strSqlUpdate &= "control_name LIKE '" & lstIgnoreNegations.Item(iListPos) & "'"
            Next iListPos
            strSqlUpdate &= ")"
        End If

        'execute the SQL command
        Try
            'specify the path of the SQLite database that contains the translations (2 levels up from the execution folder)
            Dim strDbPath As String = Directory.GetParent(Application.StartupPath).FullName
            strDbPath = Directory.GetParent(strDbPath).FullName
            strDbPath = Path.Combine(strDbPath, "translations")
            strDbPath = Path.Combine(strDbPath, "rInstatTranslations.db")

            'connect to the database and execute the SQL command
            Dim clsBuilder As New SQLiteConnectionStringBuilder With {
                    .FailIfMissing = True,
                    .DataSource = strDbPath}
            Using clsConnection As New SQLiteConnection(clsBuilder.ConnectionString)
                Using clsSqliteCmd As New SQLiteCommand(strSqlUpdate, clsConnection)
                    clsConnection.Open()
                    Dim iRowsUpdated As Integer = clsSqliteCmd.ExecuteNonQuery()
                    clsConnection.Close()
                    MsgBox("The " & strPath & " ignore file was processed. " &
                           iRowsUpdated & " database rows were updated. " &
                           "The application will now exit.", MsgBoxStyle.Exclamation)
                End Using
            End Using
        Catch e As Exception
            MsgBox(e.Message & Environment.NewLine & "An error occured processing ignore file: " &
                   strPath, MsgBoxStyle.Exclamation)
        End Try

        'This sub should only be used by developers to process the translation ignore file.
        'Therefore, exit the application with a message to ensure that this sub is not run 
        'accidentally in the release version. 
        Application.Exit()
    End Sub

End Class
