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

Imports System.Runtime.InteropServices
''' <summary>
''' Output page for R outputs
''' </summary>
Public Class ucrOutputPage
    Private _checkBoxes As List(Of CheckBox)
    Private _bCanReOrder As Boolean
    Private _bCanRename As Boolean
    Private _bCanDelete As Boolean

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
    ''' Clears all check boxes on the page
    ''' </summary>
    Public Sub ClearAllCheckBoxes()
        For Each checkbox In _checkBoxes
            checkbox.Checked = False
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
    Public Sub AddNewOutput(outputElement As clsOutputElement)
        Select Case outputElement.OutputType
            Case OutputType.Script
                AddNewScript(outputElement)
            Case OutputType.TextOutput
                AddNewTextOutput(outputElement)
            Case OutputType.ImageOutput
                AddNewImageOutput(outputElement)
        End Select
        pnlMain.VerticalScroll.Value = pnlMain.VerticalScroll.Maximum
        pnlMain.PerformLayout()
    End Sub

    ''' <summary>
    ''' Copies selected elenments to clipboard
    ''' </summary>
    Public Sub CopySelectedElementsToClipboard()
        If CopyOneImageOnly() Then
            Exit Sub
        End If

        Dim richText As New RichTextBox
        For Each element In SelectedElements
            AddElementToRichTextBox(element, richText)
        Next
        Dim dto As New DataObject()
        dto.SetText(richText.Rtf, TextDataFormat.Rtf)
        dto.SetText(richText.Text, TextDataFormat.UnicodeText)
        Clipboard.Clear()
        Clipboard.SetDataObject(dto)
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

    Private Function AddElementPanel(outputElement As clsOutputElement) As Panel
        Dim panel As New Panel With {
            .Height = 10, ' = 10 'small height as panel will grow
            .AutoSize = True,
            .Dock = DockStyle.Top
        }
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
        AddHandler checkBox.Click, AddressOf checkButton_Click
    End Sub

    Private Sub AddNewScript(outputElement As clsOutputElement)
        Dim richTextBox As New RichTextBox With {
           .Dock = DockStyle.Top,
           .BorderStyle = BorderStyle.None
        }
        FillRichTextBoxWithFormatedRScript(richTextBox, outputElement.FormatedRScript)
        Dim panel As Panel = AddElementPanel(outputElement)
        panel.Controls.Add(richTextBox)
        panel.Controls.SetChildIndex(richTextBox, 0)
        SetRichTextBoxHeight(richTextBox)
    End Sub

    Private Function CopyOneImageOnly() As Boolean
        If SelectedElements.Count = 1 AndAlso SelectedElements(0).OutputType = OutputType.ImageOutput Then
            Dim element As clsOutputElement = SelectedElements(0)
            Clipboard.Clear()
            Clipboard.SetImage(element.ImageOutput)
            Return True
        End If
        Return False
    End Function

    Private Sub AddElementToRichTextBox(element As clsOutputElement, richText As RichTextBox)
        Select Case element.OutputType
            Case OutputType.Script
                FillRichTextBoxWithFormatedRScript(richText, element.FormatedRScript)
            Case OutputType.TextOutput
                AddFormatedTextToRichTextBox(richText, element.StringOutput, OutputFont.ROutputFont, OutputFont.ROutputColour)
            Case OutputType.ImageOutput
                Clipboard.Clear()
                Clipboard.SetImage(element.ImageOutput)
                richText.Paste()
        End Select
        richText.AppendText(Environment.NewLine)
        richText.AppendText(Environment.NewLine)
    End Sub

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

    Private Sub AddNewTextOutput(outputElement As clsOutputElement)
        Dim richTextBox As New RichTextBox With {
           .Dock = DockStyle.Top,
           .BorderStyle = BorderStyle.None
        }
        AddFormatedTextToRichTextBox(richTextBox, outputElement.StringOutput, OutputFont.ROutputFont, OutputFont.ROutputColour)
        Dim panel As Panel = AddElementPanel(outputElement)
        panel.Controls.Add(richTextBox)
        panel.Controls.SetChildIndex(richTextBox, 0)
        SetRichTextBoxHeight(richTextBox)
    End Sub

    Private Sub AddNewImageOutput(outputElement As clsOutputElement)
        Dim pictureBox As New PictureBox
        pictureBox.Image = outputElement.ImageOutput
        Dim panel As Panel = AddElementPanel(outputElement)
        panel.Controls.Add(pictureBox)
        panel.Controls.SetChildIndex(pictureBox, 0)
        pictureBox.Dock = DockStyle.Top
        pictureBox.SizeMode = PictureBoxSizeMode.Zoom
        SetPictureBoxHeight(pictureBox)
    End Sub

    Private Sub SetRichTextBoxHeight(richTextBox As RichTextBox)
        richTextBox.Height = (richTextBox.GetLineFromCharIndex(richTextBox.Text.Length) + 1) * (richTextBox.Font.Height + richTextBox.Margin.Vertical) + 5
    End Sub

    Private Sub SetPictureBoxHeight(pictureBox As PictureBox)
        pictureBox.Height = pictureBox.Width / (pictureBox.Image.Width / pictureBox.Image.Height)
    End Sub

    Private Sub checkButton_Click(sender As Object, e As EventArgs)
        RaiseEvent RefreshContextButtons()
    End Sub

    Private Sub Panel_Resize(sender As Object, e As EventArgs)
        Dim panel As Panel = CType(sender, Panel)
        For Each control In panel.Controls
            If TypeOf control Is RichTextBox Then
                SetRichTextBoxHeight(control)
            ElseIf TypeOf control Is PictureBox Then
                SetPictureBoxHeight(control)
            End If
        Next
    End Sub

End Class
