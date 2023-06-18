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

Imports System.ComponentModel
Imports System.IO
Imports instat.Translations

'''--------------------------------------------------------------------------------------------
''' <summary>
''' An object of this class represents a file path custom control that inherits 
''' System.Windows.Forms.UserControl and is used to select the file name and path to be used in 
''' saving a file.
''' <para>
''' This class provides methods and fields to:</para>
''' <list type="bullet">
''' <item><description>
''' Set the parameter of the path control
''' </description></item>
''' <item><description>
''' Set the R code structure of the path control
''' </description></item>
''' <item><description>
''' Optional. Set a default suggested name
''' </description></item>
''' </list>
''' </summary>
'''--------------------------------------------------------------------------------------------
Public Class ucrFilePath
    Private bFirstLoad As Boolean = True
    Private strFilePathDialogFilter As String = "All Files *.*"

    ''' <summary>
    ''' event raised when the file path contents has changed
    ''' </summary>
    Public Event FilePathChanged()

    ''' <summary>
    ''' gets and sets the text property value of the browse button.
    ''' </summary>
    Public Property FilePathBrowseText() As String
        Get
            Return btnBrowse.Text
        End Get
        Set(value As String)
            btnBrowse.Text = If(DesignMode, value, GetTranslation(value))
        End Set
    End Property

    ''' <summary>
    ''' flag used to determine whether the opened dialog prompt will be 
    ''' FolderBrowserDialog or SaveFileDialog
    ''' </summary>
    Public Property FolderBrowse As Boolean = False

    ''' <summary>
    ''' gets and sets the label text property value of the input textbox
    ''' </summary>
    Public Property FilePathLabel() As String
        Get
            Return lblName.Text
        End Get
        Set(value As String)
            lblName.Text = If(DesignMode, value, GetTranslation(value))
        End Set
    End Property

    ''' <summary>
    ''' used to set the title of the SaveFileDialog prompt
    ''' </summary> 
    Public Property FilePathDialogTitle As String = "Save As"

    ''' <summary>
    ''' Used to set the allowed file filters or file extensions 
    ''' <para>Format example; Excel files|*.xls;*.xlsx|R Data Structure files|*.RDS</para>
    ''' <para> Note. this should be set before setting FilePath property.
    ''' the first file filter or extension set here overwrites the set FilePath extension</para>
    ''' </summary> 
    Public Property FilePathDialogFilter As String
        Get
            Return strFilePathDialogFilter
        End Get
        Set(value As String)
            strFilePathDialogFilter = value
            'reset the filter index(start index is based on 1). 
            'its safer To, just incase number of filters set are different from previously set
            SelectedFileFilterIndex = 1

            If String.IsNullOrEmpty(strFilePathDialogFilter) OrElse FolderBrowse OrElse String.IsNullOrEmpty(FilePath) Then
                Exit Property
            End If

            'for file browse, if file path name was already set,
            'change the extension set to use the new one.
            'get the new file extension from the list of filter names in strFilePathDialogFilter
            'for instance if strFilePathDialogFilter is
            'Excel files|*.xls;*.xlsx|R Data Structure files|*.RDS
            'the new file path will have .xls as its extension
            Dim arrStr() As String = strFilePathDialogFilter.Split({"|"}, StringSplitOptions.RemoveEmptyEntries)
                arrStr = arrStr(1).Split({";"}, StringSplitOptions.RemoveEmptyEntries)
                FilePath = Path.GetDirectoryName(FilePath) & "\" &
                    Path.GetFileNameWithoutExtension(FilePath) & arrStr(0).Substring(1)

        End Set
    End Property

    ''' <summary>
    ''' gets or sets the last selected filter index.
    ''' used by the SaveFileDiaolog prompt to 'remember' last selected file type filter
    ''' and by dialogs to know selected filter index
    ''' </summary>
    Public Property SelectedFileFilterIndex As Integer

    ''' <summary>
    ''' used to set the suggested name if no file name was set before by the user
    ''' Note. The name should not have a file extension
    ''' </summary>
    ''' <returns></returns>
    Public Property DefaultFileSuggestionName As String = ""

    ''' <summary>
    ''' holds last user set file name, without the path and extension
    ''' value is set when the user browses the file system
    ''' </summary>
    ''' <returns></returns>
    <Browsable(False)>
    Private Property UserSetFilePathName As String = ""


    ''' <summary>
    ''' gets or sets the input file path used by the FolderBrowseDialog or SaveFileDialog prompt 
    ''' also sets PreviousSelectedWindowsFilePath to 'remember' the last selected file name and directory
    ''' </summary> 
    Public Property FilePath() As String
        Get
            Return PathControl().GetText()
        End Get
        Set(value As String)
            'first replace backward slashed with forward slashes cause of R path formats
            PathControl().SetName(value.Replace("\", "/"))
            RaiseEvent FilePathChanged()
        End Set
    End Property

    ''' <summary>
    ''' gets the file path directory. if file path is directory, 
    ''' then the last directory will also be included
    ''' </summary>
    ''' <returns></returns>
    <Browsable(False)>
    Public ReadOnly Property FilePathDirectory() As String
        Get
            If IsEmpty() Then
                Return ""
            Else
                'check for extension to determine if its a directory
                'GetDirectoryName omits the last directory
                'yet here we need it as path of the directory path
                If String.IsNullOrEmpty(Path.GetExtension(FilePath)) Then
                    Return FilePath
                Else
                    Return Path.GetDirectoryName(FilePath)
                End If
            End If
        End Get
    End Property

    <Browsable(False)>
    Public ReadOnly Property SuggestionNameWithoutExtension() As String
        Get
            If Not String.IsNullOrEmpty(UserSetFilePathName) Then
                Return Path.GetFileNameWithoutExtension(UserSetFilePathName)
            ElseIf Not String.IsNullOrEmpty(DefaultFileSuggestionName) Then
                Return DefaultFileSuggestionName
            Else
                Return ""
            End If
        End Get
    End Property

    ''' <summary>
    ''' gets the control that contains the input file path and name
    ''' </summary>
    ''' <returns>ucrInputTextBox</returns>   
    <Browsable(False)>
    Public ReadOnly Property PathControl() As ucrInputTextBox
        Get
            Return ucrInputFilePath
        End Get
    End Property

    ''' <summary>
    ''' Sets the R parameter to the path control
    ''' </summary>
    ''' <param name="rParameter"></param>
    Public Sub SetPathControlParameter(rParameter As RParameter)
        PathControl().SetParameter(rParameter)
    End Sub

    ''' <summary>
    ''' sets the R code to the path control
    ''' </summary>
    ''' <param name="clsNewCodeStructure"></param>
    ''' <param name="bReset"></param>
    Public Sub SetPathControlRcode(clsNewCodeStructure As RCodeStructure, Optional bReset As Boolean = False)
        PathControl().SetRCode(clsNewCodeStructure, bReset)
    End Sub

    ''' <summary>
    ''' resets the path control and and the file path
    ''' </summary>
    Public Sub ResetPathControl()
        PathControl().Reset()
        Clear()
    End Sub

    Public Function IsEmpty() As Boolean
        Return String.IsNullOrEmpty(FilePath)
    End Function

    Public Sub Clear()
        FilePath = ""
    End Sub

    Private Sub ucrFilePath_Load(sender As Object, e As EventArgs) Handles Me.Load
        If bFirstLoad Then
            AddButtonInFilePathControlTextbox()
            bFirstLoad = False
        End If
    End Sub

    ''' <summary>
    ''' opens a SaveFileDialog prompt thats allows user to specify file name and path 
    ''' to be used in saving a file
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        If FolderBrowse Then
            Using dlgFolderBrowse As New FolderBrowserDialog
                If IsEmpty() Then
                    dlgFolderBrowse.SelectedPath = frmMain.clsInstatOptions.strWorkingDirectory
                Else
                    dlgFolderBrowse.SelectedPath = FilePathDirectory 'Path.GetDirectoryName(FilePath)
                End If
                If DialogResult.OK = dlgFolderBrowse.ShowDialog() Then
                    FilePath = dlgFolderBrowse.SelectedPath
                    'reset the filter index(start index is 1). its safer to, just incase save dialog is used later
                    SelectedFileFilterIndex = 1
                End If
            End Using
        Else
            Using dlgSaveFile As New SaveFileDialog
                dlgSaveFile.Title = FilePathDialogTitle
                dlgSaveFile.Filter = FilePathDialogFilter
                If IsEmpty() Then
                    dlgSaveFile.FileName = SuggestionNameWithoutExtension()
                    dlgSaveFile.InitialDirectory = frmMain.clsInstatOptions.strWorkingDirectory
                Else
                    'if there is no current file path and there is a default suggested name, then use the default suggestion
                    'else check if previous selected path has an extension to determine if the previous path included a file name and use it
                    'else leave the FileName as empty(it's the default)
                    If Not String.IsNullOrEmpty(Path.GetExtension(FilePath)) Then
                        dlgSaveFile.FileName = Path.GetFileNameWithoutExtension(FilePath)
                    ElseIf Not String.IsNullOrEmpty(SuggestionNameWithoutExtension()) Then
                        dlgSaveFile.FileName = SuggestionNameWithoutExtension()
                    End If
                    dlgSaveFile.InitialDirectory = Path.GetDirectoryName(FilePath)
                    dlgSaveFile.FilterIndex = SelectedFileFilterIndex
                End If
                If DialogResult.OK = dlgSaveFile.ShowDialog() Then
                    FilePath = dlgSaveFile.FileName
                    SelectedFileFilterIndex = dlgSaveFile.FilterIndex
                    UserSetFilePathName = dlgSaveFile.FileName
                End If
            End Using
        End If
    End Sub


    Private Sub ucrInputFilePath_Click(sender As Object, e As EventArgs) Handles ucrInputFilePath.Click
        btnBrowse.PerformClick()
    End Sub

    ''' <summary>
    ''' adds the button for showing popup used to view the whole file path
    ''' </summary>
    Private Sub AddButtonInFilePathControlTextbox()
        Dim btnViewMore As New Button
        'add the button to the comment textbox first
        'PathControl.txtInput.Controls.Clear()
        PathControl.txtInput.Controls.Add(btnViewMore)

        'then set the  button properties
        btnViewMore.Text = ":::" 'temp. This will be shown as centered.
        btnViewMore.Size = New Size(25, PathControl.txtInput.ClientSize.Height + 2)
        btnViewMore.TextAlign = ContentAlignment.TopCenter
        btnViewMore.FlatStyle = FlatStyle.Standard
        btnViewMore.FlatAppearance.BorderSize = 0
        btnViewMore.Cursor = Cursors.Default
        btnViewMore.Dock = DockStyle.Right
        btnViewMore.BackColor = btnBrowse.BackColor
        btnViewMore.UseVisualStyleBackColor = True

        'set the button event handler
        AddHandler btnViewMore.Click, Sub()
                                          'shows a popup that displays the whole file path
                                          Dim objPopup As New clsPopup
                                          Dim txtShowFilePath As New TextBox With {
                                                    .Multiline = True,
                                                    .ScrollBars = ScrollBars.Vertical,
                                                    .WordWrap = True
                                             }

                                          'attach event handlers that allow editing of the poped up text
                                          AddHandler txtShowFilePath.LostFocus, Sub()
                                                                                    FilePath = txtShowFilePath.Text
                                                                                End Sub
                                          AddHandler txtShowFilePath.KeyDown, Sub(sender As Object, e As KeyEventArgs)
                                                                                  If e.Control AndAlso e.KeyCode = Keys.Enter Then
                                                                                      FilePath = txtShowFilePath.Text
                                                                                      objPopup.Hide()
                                                                                  End If
                                                                              End Sub
                                          'set the contents control and show the popup
                                          objPopup.SetContentControl(txtShowFilePath)
                                          objPopup.SetSize(ucrInputFilePath.Width, ucrInputFilePath.Height + 100)
                                          objPopup.Show(ucrInputFilePath)
                                          txtShowFilePath.Text = FilePath
                                          txtShowFilePath.SelectionStart = FilePath.Length
                                      End Sub

    End Sub


End Class
