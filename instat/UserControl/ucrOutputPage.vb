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

Imports instat
Imports instat.Translations
Imports System.Runtime.InteropServices
Imports RInsightF461

''' <summary>
''' Output page for R outputs
''' </summary>
Public Class ucrOutputPage
    Private _checkBoxes As List(Of CheckBox)

    ''' <summary> lastCheckedBox used to store a reference to a CheckBox control. </summary>
    Private lastCheckedBox As CheckBox = Nothing

    Private _bCanReOrder As Boolean
    Private _bCanRename As Boolean
    Private _bCanDelete As Boolean
    Private _clsInstatOptions As InstatOptions

    ''' <summary>
    ''' Returns all the selected elements
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property SelectedElements() As List(Of clsOutputElement)
        Get
            Dim elements As New List(Of clsOutputElement)
            For Each checkbox In _checkBoxes
                If checkbox.Checked Then
                    elements.Add(checkbox.Tag)
                End If
            Next
            Return elements
        End Get
    End Property

    ''' <summary>
    ''' Checks to see if elements on the page can be re ordered
    ''' </summary>
    ''' <returns></returns>
    Public Property BCanReOrder() As Boolean
        Get
            Return _bCanReOrder
        End Get
        Set(ByVal value As Boolean)
            _bCanReOrder = value
        End Set
    End Property

    ''' <summary>
    ''' Checks to see if page can be renamed
    ''' </summary>
    ''' <returns></returns>
    Public Property BCanRename() As Boolean
        Get
            Return _bCanRename
        End Get
        Set(ByVal value As Boolean)
            _bCanRename = value
        End Set
    End Property

    ''' <summary>
    ''' Checks to see if elements on the page can be deleted
    ''' </summary>
    ''' <returns></returns>
    Public Property BCanDelete() As Boolean
        Get
            Return _bCanDelete
        End Get
        Set(ByVal value As Boolean)
            _bCanDelete = value
        End Set
    End Property



    Public Event RefreshContextButtons()

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _checkBoxes = New List(Of CheckBox)
    End Sub


    ''' <summary>
    ''' Holds options.
    ''' TODO InstatOptions should have bindable objects as it's options 
    ''' </summary>
    Public WriteOnly Property clsInstatOptions() As InstatOptions
        Set(value As InstatOptions)
            _clsInstatOptions = value
        End Set
    End Property

    ''' <summary>
    ''' Clears all check boxes on the page
    ''' </summary>
    Public Sub ClearAllCheckBoxes()
        For Each checkbox In _checkBoxes
            checkbox.Checked = False
        Next
    End Sub

    ''' <summary>
    ''' Selects all check boxes on the page
    ''' </summary>
    Public Sub SelectAllCheckBoxes()
        For Each checkbox In _checkBoxes
            checkbox.Checked = True
        Next
    End Sub

    ''' <summary>
    ''' Clears all outputs on the page
    ''' </summary>
    Public Sub ClearAllOutputs()
        _checkBoxes.Clear()
        While pnlMain.Controls.Count > 0
            pnlMain.Controls(0).Dispose()
        End While
    End Sub

    ''' <summary>
    ''' Add output to page
    ''' </summary>
    ''' <param name="outputElement"></param>
    Public Sub AddNewOutput(outputElement As clsOutputElement, Optional bDisplayOutputInExternalViewer As Boolean = False)
        'add the script first. This applies to whether the output has an output or not or
        'whether it's just a script output

        'todo. temporary fix. Output element should always have an R script
        If outputElement.Script IsNot Nothing Then
            AddNewScript(outputElement)
        End If


        'then add the output of the script if there is an output
        If Not String.IsNullOrEmpty(outputElement.Output) Then
            If bDisplayOutputInExternalViewer Then
                Dim frmMaximiseOutput As New frmMaximiseOutput
                frmMaximiseOutput.Show(strFileName:=outputElement.Output)
            Else
                Select Case outputElement.OutputType
                    Case OutputType.TextOutput
                        AddNewTextOutput(outputElement)
                    Case OutputType.ImageOutput
                        AddNewImageOutput(outputElement)
                    Case OutputType.HtmlOutput
                        AddNewHtmlOutput(outputElement)
                End Select
            End If
        End If
        pnlMain.VerticalScroll.Value = pnlMain.VerticalScroll.Maximum
        pnlMain.PerformLayout()
    End Sub

    Private Sub AddNewScript(outputElement As clsOutputElement)
        Dim richTextBox As New RichTextBox With {
         .Dock = DockStyle.Top,
         .BorderStyle = BorderStyle.None
        }

        Dim formattedRScript As List(Of clsRScriptElement) = outputElement.FormattedRScript
        'if settings are not available or both show commands and comments settings are enabled then just show the whole script
        If formattedRScript.Count > 0 Then
            FillRichTextWithRScriptBasedOnSettings(richTextBox, formattedRScript)
        Else
            AddFormatedTextToRichTextBox(richTextBox, outputElement.Script, OutputFont.RPresentationFont, OutputFont.RPresentationColour)
        End If

        'if no contents added just exit sub
        If String.IsNullOrWhiteSpace(richTextBox.Text) Then
            Exit Sub
        End If

        Dim panel As Panel = AddElementPanel(outputElement)
        panel.Controls.Add(richTextBox)
        panel.Controls.SetChildIndex(richTextBox, 0)
        SetRichTextBoxHeight(richTextBox)
        AddHandler richTextBox.KeyUp, AddressOf richTextBox_CopySelectedText
        AddHandler richTextBox.MouseLeave, AddressOf panelContents_MouseLeave
    End Sub


    'fills rich textbox with r script provided based on the global options provided
    'if all disabled then richtext will not be filled
    Private Sub FillRichTextWithRScriptBasedOnSettings(richTextBox As RichTextBox, formattedRScript As List(Of clsRScriptElement))
        'if settings are not available or both show commands and comments settings are enabled then just show the whole script
        If frmMain.clsInstatOptions Is Nothing OrElse (frmMain.clsInstatOptions.bIncludeCommentDefault AndAlso frmMain.clsInstatOptions.bCommandsinOutput) Then
            FillRichTextBoxWithFormatedRScript(richTextBox, formattedRScript)
        Else
            'if either show commands or comments settings is enabled show the script that corresponds to either
            If frmMain.clsInstatOptions.bIncludeCommentDefault Then
                'show comments only
                For Each line As clsRScriptElement In formattedRScript
                    If line.Type = RToken.TokenTypes.RComment OrElse line.Type = RToken.TokenTypes.RNewLine Then
                        AddFormatedTextToRichTextBox(richTextBox, line.Text, OutputFont.GetFontForScriptType(line.Type), OutputFont.GetColourForScriptType(line.Type))
                    End If
                Next
            ElseIf frmMain.clsInstatOptions.bCommandsinOutput Then
                'show command lines that are not comments
                For Each line As clsRScriptElement In formattedRScript
                    If Not (line.Type = RToken.TokenTypes.RComment) Then
                        AddFormatedTextToRichTextBox(richTextBox, line.Text, OutputFont.GetFontForScriptType(line.Type), OutputFont.GetColourForScriptType(line.Type))
                    End If
                Next
            End If

        End If
    End Sub

    Private Sub AddNewTextOutput(outputElement As clsOutputElement)
        Dim panel As Panel = AddElementPanel(outputElement)

        If outputElement.IsFile Then
            Dim linkLabel As New LinkLabel
            Dim ucrTextViewer As New ucrTextViewer

            linkLabel.Text = "Maximise"
            AddHandler linkLabel.Click, Sub()
                                            Dim frmMaximiseOutput As New frmMaximiseOutput
                                            frmMaximiseOutput.Show(strFileName:=outputElement.Output)
                                        End Sub

            ucrTextViewer.LoadTextFile(strFileName:=outputElement.Output)
            ucrTextViewer.FormatText(OutputFont.ROutputFont, OutputFont.ROutputColour)

            AddHandler ucrTextViewer.richTextBox.MouseLeave, AddressOf panelContents_MouseLeave

            If frmMain.clsInstatOptions IsNot Nothing AndAlso frmMain.clsInstatOptions.iMaxOutputsHeight > -1 Then
                'ucrTextViewer.Height = frmMain.clsInstatOptions.iMaxOutputsHeight
                ucrTextViewer.MaximumSize = New Size(Integer.MaxValue, frmMain.clsInstatOptions.iMaxOutputsHeight)
            End If

            panel.Controls.Add(linkLabel)
            panel.Controls.Add(ucrTextViewer)
            panel.Controls.SetChildIndex(linkLabel, 0)
            panel.Controls.SetChildIndex(ucrTextViewer, 0)
            linkLabel.Dock = DockStyle.Top
            ucrTextViewer.Dock = DockStyle.Top


        Else
            Dim richTextBox As New RichTextBox With {
               .Dock = DockStyle.Top,
               .BorderStyle = BorderStyle.None
            }
            AddFormatedTextToRichTextBox(richTextBox, outputElement.Output, OutputFont.ROutputFont, OutputFont.ROutputColour)
            panel.Controls.Add(richTextBox)
            panel.Controls.SetChildIndex(richTextBox, 0)
            SetRichTextBoxHeight(richTextBox)
            AddHandler richTextBox.KeyUp, AddressOf richTextBox_CopySelectedText
            AddHandler richTextBox.MouseLeave, AddressOf panelContents_MouseLeave

        End If
    End Sub

    Private Sub AddNewImageOutput(outputElement As clsOutputElement)
        Dim panel As Panel = AddElementPanel(outputElement)
        Dim linkLabel As New LinkLabel
        Dim pictureBox As New PictureBox

        linkLabel.Text = "Maximise"

        pictureBox.Load(outputElement.Output)

        If frmMain.clsInstatOptions IsNot Nothing AndAlso frmMain.clsInstatOptions.iMaxOutputsHeight > -1 Then
            pictureBox.Height = frmMain.clsInstatOptions.iMaxOutputsHeight
        Else
            SetPictureBoxHeight(pictureBox)
        End If

        panel.Controls.Add(linkLabel)
        panel.Controls.Add(pictureBox)
        panel.Controls.SetChildIndex(linkLabel, 0)
        panel.Controls.SetChildIndex(pictureBox, 0)
        linkLabel.Dock = DockStyle.Top
        pictureBox.Dock = DockStyle.Top
        pictureBox.SizeMode = PictureBoxSizeMode.Zoom



        AddHandler linkLabel.Click, Sub()
                                        Dim frmMaximiseOutput As New frmMaximiseOutput
                                        frmMaximiseOutput.Show(strFileName:=outputElement.Output)
                                    End Sub
    End Sub

    Private Sub AddNewHtmlOutput(outputElement As clsOutputElement)
        Dim panel As Panel = AddElementPanel(outputElement)
        Dim linkLabel As New LinkLabel

        If RuntimeInformation.IsOSPlatform(OSPlatform.Windows) AndAlso CefRuntimeWrapper.IsCefInitilised Then
            Dim ucrWebview As New ucrWebViewer()
            linkLabel.Text = "Maximise"
            AddHandler linkLabel.Click, Sub()
                                            Dim frmMaximiseOutput As New frmMaximiseOutput
                                            frmMaximiseOutput.Show(strFileName:=outputElement.Output)
                                        End Sub

            ucrWebview.LoadHtmlFile(outputElement.Output)

            If frmMain.clsInstatOptions IsNot Nothing AndAlso frmMain.clsInstatOptions.iMaxOutputsHeight > -1 Then
                'ucrWebview.Height = frmMain.clsInstatOptions.iMaxOutputsHeight
                ucrWebview.MaximumSize = New Size(Integer.MaxValue, frmMain.clsInstatOptions.iMaxOutputsHeight)
            End If

            panel.Controls.Add(linkLabel)
            panel.Controls.Add(ucrWebview)
            panel.Controls.SetChildIndex(linkLabel, 0)
            panel.Controls.SetChildIndex(ucrWebview, 0)

            linkLabel.Dock = DockStyle.Top
            ucrWebview.Dock = DockStyle.Top


        Else

            linkLabel.Text = "View html file"
            AddHandler linkLabel.Click, Sub()
                                            'display the html output in default browser
                                            Cursor = Cursors.WaitCursor
                                            Process.Start(outputElement.Output)
                                            Cursor = Cursors.Default
                                        End Sub

            panel.Controls.Add(linkLabel)
            panel.Controls.SetChildIndex(linkLabel, 0)

            linkLabel.Dock = DockStyle.Top

            'display the html output in default browser
            Cursor = Cursors.WaitCursor
            Process.Start(outputElement.Output)
            Cursor = Cursors.Default
        End If

    End Sub

    Private Function AddElementPanel(outputElement As clsOutputElement) As Panel
        Dim panel As New Panel With {
          .Dock = DockStyle.Top,
          .Height = 10,
          .AutoSize = True
        }

        'if maximum height of outputs provided provided set it as the maximum height of panel 
        'If frmMain.clsInstatOptions IsNot Nothing AndAlso frmMain.clsInstatOptions.iMaxOutputsHeight > -1 Then
        '    panel.MaximumSize = New Size(Integer.MaxValue, frmMain.clsInstatOptions.iMaxOutputsHeight)
        '    'panel.Height = frmMain.clsInstatOptions.iMaxOutputsHeight
        '    panel.AutoScroll = True
        'Else
        '    panel.AutoScroll = False
        'End If
        pnlMain.Controls.Add(panel)
        pnlMain.Controls.SetChildIndex(panel, 0)
        AddCheckBoxToElementPanel(panel, outputElement)
        AddHandler panel.Resize, AddressOf Panel_Resize
        Return panel
    End Function

    Private Sub AddCheckBoxToElementPanel(panel As Panel, outputElement As clsOutputElement)
        Dim checkBox As New CheckBox With {
          .Text = "",
          .CheckAlign = ContentAlignment.TopLeft,
          .Dock = DockStyle.Left,
          .AutoSize = True,
          .Tag = outputElement
        }
        panel.Controls.Add(checkBox)
        _checkBoxes.Add(checkBox)
        AddHandler checkBox.CheckedChanged, AddressOf CheckBox_CheckedChanged
        AddHandler checkBox.Click, AddressOf checkButton_Click
        AddHandler checkBox.MouseLeave, AddressOf panelContents_MouseLeave
    End Sub

    ''' <summary>
    ''' Copies selected elements to clipboard
    ''' </summary>
    Public Sub CopySelectedElementsToClipboard()
        If CopyOneImageOnly() Then
            Exit Sub
        End If

        Dim richText As New RichTextBox
        For Each element In SelectedElements
            AddElementToRichTextBox(element, richText)
        Next
        CopySelectedTextToClipBoard(richText, richText.Rtf)
    End Sub

    ''' <summary>
    ''' Saves page to rich text file
    ''' </summary>
    ''' <param name="path"></param>
    Public Sub Save(path As String)
        Dim richText As New RichTextBox
        For Each checkbox In _checkBoxes
            Dim element As clsOutputElement = checkbox.Tag
            AddElementToRichTextBox(element, richText)
        Next
        richText.SaveFile(path)
    End Sub

    Private Function CopyOneImageOnly() As Boolean
        If SelectedElements.Count = 1 AndAlso SelectedElements(0).OutputType = OutputType.ImageOutput Then
            Dim element As clsOutputElement = SelectedElements(0)
            Clipboard.Clear()
            Clipboard.SetImage(GetBitmapFromFile(element.Output))
            Return True
        End If
        Return False
    End Function

    Private Sub AddElementToRichTextBox(element As clsOutputElement, richText As RichTextBox)
        Select Case element.OutputType
            Case OutputType.Script
                Dim formattedRScript As List(Of clsRScriptElement) = element.FormattedRScript
                'if settings are not available or both show commands and comments settings are enabled then just show the whole script
                If formattedRScript.Count > 0 Then
                    FillRichTextWithRScriptBasedOnSettings(richText, formattedRScript)
                Else
                    AddFormatedTextToRichTextBox(richText, element.Script, OutputFont.RPresentationFont, OutputFont.RPresentationColour)
                End If
            Case OutputType.TextOutput
                Dim strOutput As String = ""
                If element.IsFile Then
                    For Each strLine As String In IO.File.ReadLines(element.Output)
                        strOutput = strOutput & strLine & Environment.NewLine
                    Next strLine
                Else
                    strOutput = element.Output
                End If
                AddFormatedTextToRichTextBox(richText, strOutput, OutputFont.ROutputFont, OutputFont.ROutputColour)
            Case OutputType.ImageOutput
                Clipboard.Clear()
                'todo. instead of copy paste, add image to rtf directly from file?
                Clipboard.SetImage(GetBitmapFromFile(element.Output))
                richText.Paste()
        End Select
        richText.AppendText(Environment.NewLine)
        richText.AppendText(Environment.NewLine)
    End Sub

    Private Function GetBitmapFromFile(strFilename As String) As Bitmap
        Return New Bitmap(strFilename)
    End Function

    Private Sub AddFormatedTextToRichTextBox(richTextBox As RichTextBox, text As String, font As Font, colour As Color)
        Dim intStartSelection As Integer = richTextBox.Text.Length
        richTextBox.AppendText(text)
        If RuntimeInformation.IsOSPlatform(OSPlatform.Linux) Then
            'Through Mono cannot have multiple fonts and colours within RichTextBox
            richTextBox.SelectAll()
            richTextBox.Font = font
            richTextBox.ForeColor = colour
            richTextBox.SelectionLength = 0
        Else
            richTextBox.SelectionStart = intStartSelection
            richTextBox.SelectionLength = text.Length()
            richTextBox.SelectionFont = font
            richTextBox.SelectionColor = colour
        End If
    End Sub

    Private Sub FillRichTextBoxWithFormatedRScript(richTextBox As RichTextBox, formatedRScript As List(Of clsRScriptElement))
        For Each line In formatedRScript
            AddFormatedTextToRichTextBox(richTextBox, line.Text, OutputFont.GetFontForScriptType(line.Type), OutputFont.GetColourForScriptType(line.Type))
        Next
    End Sub

    Private Sub SetRichTextBoxHeight(richTextBox As RichTextBox)
        richTextBox.Height = (richTextBox.GetLineFromCharIndex(richTextBox.Text.Length) + 1) * (richTextBox.Font.Height + richTextBox.Margin.Vertical) + 5
    End Sub

    Private Sub SetPictureBoxHeight(pictureBox As PictureBox)
        pictureBox.Height = pictureBox.Width / (pictureBox.Image.Width / pictureBox.Image.Height)
    End Sub

    Private Sub CheckBox_CheckedChanged(sender As Object, e As EventArgs)
        Dim currentBox As CheckBox = DirectCast(sender, CheckBox)

        If lastCheckedBox IsNot Nothing AndAlso Control.ModifierKeys = Keys.Shift Then
            Dim startIndex As Integer = _checkBoxes.IndexOf(lastCheckedBox)
            Dim endIndex As Integer = _checkBoxes.IndexOf(currentBox)

            ' Toggle check state for checkboxes between startIndex and endIndex
            For i As Integer = Math.Min(startIndex, endIndex) To Math.Max(startIndex, endIndex)
                _checkBoxes(i).Checked = currentBox.Checked
            Next
        End If

        lastCheckedBox = currentBox
    End Sub

    Private Sub CheckBox_MouseDown(sender As Object, e As MouseEventArgs)
        Dim currentBox As CheckBox = DirectCast(sender, CheckBox)

        If e.Button = MouseButtons.Left AndAlso Control.ModifierKeys = Keys.Shift Then
            ' Deselect all checkboxes between lastCheckedBox and currentBox
            Dim startIndex As Integer = _checkBoxes.IndexOf(lastCheckedBox)
            Dim endIndex As Integer = _checkBoxes.IndexOf(currentBox)

            For i As Integer = Math.Min(startIndex, endIndex) + 1 To Math.Max(startIndex, endIndex) - 1
                _checkBoxes(i).Checked = False
            Next
        ElseIf currentBox.Checked AndAlso Not Control.ModifierKeys = Keys.Shift Then
            ' Deselect the current checkbox if already checked without Shift key
            currentBox.Checked = False
        End If

        lastCheckedBox = currentBox
    End Sub

    Private Sub checkButton_Click(sender As Object, e As EventArgs)
        RaiseEvent RefreshContextButtons()
    End Sub

    Private Sub richTextBox_CopySelectedText(sender As Object, e As KeyEventArgs)
        If e.KeyData = Keys.Control + Keys.C Then
            Try
                Dim richText As RichTextBox = CType(sender, RichTextBox)
                Dim richSelectedText As New RichTextBox
                richSelectedText.AppendText(richText.SelectedText)
                CopySelectedTextToClipBoard(richSelectedText, richText.SelectedRtf)
            Catch ex As Exception
                MsgBoxTranslate(ex.Message)
            End Try
        End If
    End Sub

    Private Sub panelContents_MouseLeave(sender As Object, e As EventArgs)
        pnlMain.Focus()
    End Sub

    Private Sub CopySelectedTextToClipBoard(richText As RichTextBox, richTextFormat As String)
        Dim strClip As String = String.Empty
        Dim dto As New DataObject()

        For Each Line As String In richText.Lines
            strClip &= Line & Environment.NewLine
        Next

        dto.SetText(richTextFormat, TextDataFormat.Rtf)
        dto.SetText(strClip, TextDataFormat.UnicodeText)
        Clipboard.Clear()
        Clipboard.SetDataObject(dto)
    End Sub

    Private Sub Panel_Resize(sender As Object, e As EventArgs)
        'Dim panel As Panel = CType(sender, Panel)
        'For Each control In panel.Controls
        '    If TypeOf control Is RichTextBox Then
        '        SetRichTextBoxHeight(control)
        '    ElseIf TypeOf control Is PictureBox Then
        '        SetPictureBoxHeight(control)
        '    End If
        'Next
    End Sub

End Class