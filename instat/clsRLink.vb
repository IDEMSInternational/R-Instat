﻿' Instat+R
' Copyright (C) 2015
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
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports RDotNet

Public Class RLink
    ' R interface class. Each instance of the class has its own REngine instance
    Dim strClimateObjectPath As String = "/ClimateObject/R" 'new climateobject path
    Public strClimateObject As String = "ClimateObject"
    Dim strInstatObjectPath As String = "/InstatObject/R" 'path to the Instat object
    Public strInstatDataObject As String = "InstatDataObject"
    Public clsEngine As REngine
    Dim txtOutput As New RichTextBox
    Dim wbOutput As New WebBrowser 'TEST temporary...
    Dim rtbOutput2 As New ucrWPFRichTextBox 'TEST temporary...
    Dim txtLog As New TextBox
    Public bLog As Boolean = False
    Public bOutput As Boolean = False
    Public bClimateObjectExists As Boolean = False
    Public bInstatObjectExists As Boolean = False
    Public bClimsoftLinkExists As Boolean = False
    'sets the default fonts and colors
    Public fScript As Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular)
    Public clrScript As Color = Color.Black
    '
    Public fOutput As Font = New Font(FontFamily.GenericMonospace, 8, FontStyle.Regular)
    Public clrOutput As Color = Color.Blue
    '
    Public fComments As Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular)
    Public clrComments As Color = Color.Green

    Public Sub New(Optional bWithInstatObj As Boolean = False, Optional bWithClimsoft As Boolean = False)

    End Sub

    Public Sub SetEngine()
        Try
            REngine.SetEnvironmentVariables()
        Catch ex As Exception
            MsgBox(ex.Message & vbNewLine & "Ensure that the correct version of R is installed and restart the program.", MsgBoxStyle.Critical, "Cannot initialise R Link.")
            Application.Exit()
        End Try
        Try
            clsEngine = REngine.GetInstance()
        Catch ex As Exception
            MsgBox(ex.Message & vbNewLine & "Ensure that the correct version of R is installed and restart the program.", MsgBoxStyle.Critical, "Cannot initialise R Link.")
            Application.Exit()
        End Try
        clsEngine.Initialize()
    End Sub

    Public Sub setFormatOutput(tempFont As Font, tempColor As Color)
        fOutput = tempFont
        clrOutput = tempColor
    End Sub

    Public Sub setFormatScript(tempFont As Font, tempColor As Color)
        fScript = tempFont
        clrScript = tempColor
    End Sub

    Public Sub setFormatComment(tempFont As Font, tempColor As Color)
        fComments = tempFont
        clrComments = tempColor
    End Sub

    Public Sub SetOutput(tempOutput As RichTextBox)
        txtOutput = tempOutput
        bOutput = True
    End Sub
    Public Sub SetWbOutput(tempOutput As WebBrowser)
        'TEST temporary
        wbOutput = tempOutput
        bOutput = True
    End Sub

    Public Sub SetOutput2(tempOutput As ucrWPFRichTextBox)
        'TEST temporary
        rtbOutput2 = tempOutput
        bOutput = True
    End Sub

    Public Sub SetLog(tempLog As TextBox)
        txtLog = tempLog
        bLog = True
    End Sub

    Public Function GetDataFrameNames() As List(Of String)
        Dim chrDataFrameNames As CharacterVector
        Dim lstDataFrameNames As New List(Of String)
        Dim clsGetDataNames As New RFunction

        clsGetDataNames.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_names")
        chrDataFrameNames = RunInternalScriptGetValue(clsGetDataNames.ToScript()).AsCharacter
        If chrDataFrameNames IsNot Nothing Then
            lstDataFrameNames.AddRange(chrDataFrameNames)
        End If
        Return lstDataFrameNames
    End Function

    Public Function GetColumnNames(strDataFrameName As String) As List(Of String)
        Dim chrCurrColumns As CharacterVector
        Dim lstCurrColumns As New List(Of String)
        Dim clsGetColumnNames As New RFunction

        clsGetColumnNames.SetRCommand(strInstatDataObject & "$get_column_names")
        clsGetColumnNames.AddParameter("data_name", Chr(34) & strDataFrameName & Chr(34))
        chrCurrColumns = RunInternalScriptGetValue(clsGetColumnNames.ToScript()).AsCharacter
        lstCurrColumns.AddRange(chrCurrColumns)
        Return lstCurrColumns
    End Function

    Public Sub FillComboDataFrames(ByRef cboDataFrames As ComboBox, Optional bSetDefault As Boolean = True, Optional bIncludeOverall As Boolean = False, Optional strCurrentDataFrame As String = "")
        'This sub is filling the cboDataFrames with the relevant dat frame names (obtained by using GetDataFrameNames()) and potentially "[Overall]".  On thing it is doing, is setting the selected index in the cboDataFrames.
        'It is used on the ucrDataFrame in the FillComboBox sub.
        If bInstatObjectExists Then
            If bIncludeOverall Then
                cboDataFrames.Items.Add("[Overall]") 'Task/question: explain this.
            End If
            cboDataFrames.Items.AddRange(GetDataFrameNames().ToArray)
            AdjustComboBoxWidth(cboDataFrames)
            'Task/Question: From what I understood, if bSetDefault is true or if the strCurrentDataFrame (given as an argument) is actually not in cboDataFrames (is this case generic or should it never happen ?), then the selected Index should be the current worksheet.
            If (bSetDefault OrElse cboDataFrames.Items.IndexOf(strCurrentDataFrame) = -1) AndAlso (frmEditor.grdData IsNot Nothing) AndAlso (frmEditor.grdData.CurrentWorksheet IsNot Nothing) Then
                cboDataFrames.SelectedIndex = cboDataFrames.Items.IndexOf(frmEditor.grdData.CurrentWorksheet.Name)
            ElseIf cboDataFrames.Items.IndexOf(strCurrentDataFrame) <> -1 Then
                cboDataFrames.SelectedIndex = cboDataFrames.Items.IndexOf(strCurrentDataFrame)
            End If
        End If
    End Sub

    'TODO This is used above but will not be once ucrDataFrame uses proper controls
    ' Then this can be removed
    Public Shared Sub AdjustComboBoxWidth(cboCurrent As ComboBox)
        Dim iWidth As Integer = cboCurrent.DropDownWidth
        Dim graTemp As Graphics = cboCurrent.CreateGraphics()
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

    Public Sub FillColumnNames(strDataFrame As String, ByRef cboColumns As ComboBox)
        Dim lstCurrColumns As List(Of String)
        If strDataFrame <> "" AndAlso DataFrameExists(strDataFrame) Then
            lstCurrColumns = GetColumnNames(strDataFrame)
        Else
            lstCurrColumns = New List(Of String)
        End If
        cboColumns.Items.Clear()
        cboColumns.Items.AddRange(lstCurrColumns.ToArray)
    End Sub

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

    Public Function GetDefaultColumnNames(strPrefix As String) As GenericVector
        Dim lstNextDefaults As GenericVector = Nothing
        Dim clsGetNextDefault As New RFunction
        clsGetNextDefault.SetRCommand(strInstatDataObject & "$get_next_default_column_name")
        clsGetNextDefault.AddParameter("prefix", Chr(34) & strPrefix & Chr(34))
        lstNextDefaults = RunInternalScriptGetValue(clsGetNextDefault.ToScript()).AsList
        Return lstNextDefaults
    End Function

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

    Public Function GetNextDefault(strPrefix As String, lstItems As List(Of String)) As String
        Dim strNextDefault As String = ""
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
        If Not expPrefix.Type = Internals.SymbolicExpressionType.Null Then
            strNextDefault = expPrefix.AsCharacter(0)
        End If
        Return strNextDefault
    End Function

    Public Sub RunScript(strScript As String, Optional bReturnOutput As Integer = 0, Optional strComment As String = "", Optional bHtmlOutput As Boolean = False)
        Dim strCapturedScript As String
        Dim temp As RDotNet.SymbolicExpression
        Dim strTemp As String
        Dim strOutput As String
        Dim strScriptWithComment As String
        Dim strSplitScript As String
        strOutput = ""

        If strComment <> "" Then
            strComment = "# " & strComment
            strScriptWithComment = strComment & vbCrLf & strScript
        Else
            strScriptWithComment = strScript
        End If
        If bLog Then
            txtLog.Text = txtLog.Text & strScriptWithComment & vbCrLf
        End If
        If bOutput Then
            If strComment <> "" Then
                AppendText(txtOutput, clrComments, fComments, strComment & vbCrLf)
                AppendText(txtOutput, clrScript, fScript, strScript & vbCrLf)
                AppendText2(rtbOutput2, clrComments, fComments, strComment & vbCrLf, clrScript, fScript, strScript & vbCrLf) 'TEST temporary
                WbAppendText(wbOutput, clrComments, fComments, strComment & vbCrLf) 'TEST temporary
                WbAppendText(wbOutput, clrScript, fScript, strScript & vbCrLf) 'TEST temporary
            Else
                AppendText(txtOutput, clrScript, fScript, strScript & vbCrLf)
                AppendText2(rtbOutput2, clrScript, fScript, strScript & vbCrLf) 'TEST temporary
                WbAppendText(wbOutput, clrScript, fScript, strScript & vbCrLf) 'TEST temporary
            End If
        End If

        'If strScript.Length > 2000 Then
        '    MsgBox("The following command cannot be run because it exceeds the character limit of 2000 characters for a command in R-Instat." & vbNewLine & strScript & vbNewLine & vbNewLine & "It may be possible to run the command directly in R.", MsgBoxStyle.Critical, "Cannot run command")
        If bReturnOutput = 0 Then
            Try
                clsEngine.Evaluate(strScript)
            Catch e As Exception
                MsgBox(e.Message & vbNewLine & "The error occurred in attempting to run the following R command(s):" & vbNewLine & strScript, MsgBoxStyle.Critical, "Error running R command(s)")
            End Try
        ElseIf bReturnOutput = 1 Then
            Try
                temp = clsEngine.Evaluate(strScript)
                strTemp = String.Join(vbCrLf, temp.AsCharacter())
                strOutput = strOutput & strTemp & vbCrLf
            Catch e As Exception
                MsgBox(e.Message & vbNewLine & "The error occurred in attempting to run the following R command(s):" & vbNewLine & strScript, MsgBoxStyle.Critical, "Error running R command(s)")
            End Try
        Else
            If strScript.Trim(vbCrLf).LastIndexOf(vbCrLf) = -1 Then
                strCapturedScript = "capture.output(" & strScript & ")"
            Else
                strSplitScript = Left(strScript, strScript.Trim(vbCrLf).LastIndexOf(vbCrLf))
                If strSplitScript <> "" Then
                    Try
                        clsEngine.Evaluate(strSplitScript)
                    Catch e As Exception
                        MsgBox(e.Message & vbNewLine & "The error occurred in attempting to run the following R command(s):" & vbNewLine & strScript, MsgBoxStyle.Critical, "Error running R command(s)")
                    End Try
                End If
                strSplitScript = Right(strScript, strScript.Length - strScript.Trim(vbCrLf).LastIndexOf(vbCrLf) - 2)
                strCapturedScript = "capture.output(" & strSplitScript & ")"
            End If
            Try
                temp = clsEngine.Evaluate(strCapturedScript)
                strTemp = String.Join(vbCrLf, temp.AsCharacter())
                strOutput = strOutput & strTemp & vbCrLf
            Catch e As Exception
                MsgBox(e.Message & vbNewLine & "The error occurred in attempting to run the following R command(s):" & vbNewLine & strScript, MsgBoxStyle.Critical, "Error running R command(s)")
            End Try
        End If
        If bOutput AndAlso strOutput <> "" Then
            If bHtmlOutput Then 'TEST temporary
                AppendText(txtOutput, clrOutput, fOutput, strOutput)
                rtbOutput2.AddIntoWebBrowser(strHtmlCode:=strOutput)
                WbAppendText(wbOutput, clrOutput, fOutput, strOutput) 'TEST temporary
            Else
                AppendText(txtOutput, clrOutput, fOutput, strOutput)
                AppendText2(rtbOutput2, clrOutput, fOutput, strOutput) 'TEST temporary
                WbAppendText(wbOutput, clrOutput, fOutput, strOutput) 'TEST temporary
            End If
        End If
            frmMain.clsGrids.UpdateGrids()
    End Sub

    Public Function GetImageRTFCode(strImageLocation As String, iWidth As Integer, iHeight As Integer) As String

        'use reference
        'http://stackoverflow.com/questions/1490734/programatically-adding-images-to-rtf-document

        Dim img As Image = Image.FromFile(strImageLocation)
        Dim stream As New IO.MemoryStream
        img.Save(stream, Imaging.ImageFormat.Png)
        Dim bytes As Byte() = stream.ToArray()
        Dim strBytes As String = BitConverter.ToString(bytes).Replace("-", "")

        Dim strRTFPic As String = "{\pict\pngblip\picw" +
        img.Width.ToString() & "\pich" & img.Height.ToString() &
        "\picwgoa" & iWidth.ToString() + "\pichgoa" & iHeight.ToString() +
        "\hex " & strBytes & "}"

        stream.Dispose()

        Return strRTFPic
    End Function

    Public Sub DisplayGraphInRTB(strImageLocation As String)
        'TEST temporary
        'First method, pasting
        txtOutput.ReadOnly = False
        Dim img As Image = Image.FromFile(strImageLocation)
        Dim bimg = New Bitmap(img, (txtOutput.Width * 0.9), (img.Height * (txtOutput.Width / img.Width) * 0.9))
        Dim orgData = Clipboard.GetDataObject

        Clipboard.SetImage(bimg)
        txtOutput.Paste()
        Clipboard.SetDataObject(orgData)
        img.Dispose()
        bimg.Dispose()
        'Second method add to rtf code, this doesn't work yet.. either because GetImage is crap, or because the code is not inserted at the right place...
        'txtOutput.Rtf = txtOutput.Rtf & GetImageRTFCode(strImageLocation, (txtOutput.Width * 0.9), (img.Height * (txtOutput.Width / img.Width) * 0.9))

        'IO.File.Delete(strImageLocation) 'need to close the file first... It's still in use when coming to this line...
        'FileIO.FileSystem.DeleteFile(strImageLocation) 

        txtOutput.ReadOnly = True
    End Sub
    Public Sub DisplayGraphInOutput2(strImageLocation As String)
        'Task: migrate the sub to the ucrWPFRichTextBox class ?
        'TEST temporary
        Dim conImage As Windows.Documents.BlockUIContainer
        Dim UIEimage As New Windows.Controls.Image()
        Dim bimg As New Windows.Media.Imaging.BitmapImage()
        Dim thickness As New Windows.Thickness(1)
        Using fstream As New IO.FileStream(strImageLocation, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read)
            bimg.BeginInit()
            bimg.CacheOption = Windows.Media.Imaging.BitmapCacheOption.OnLoad
            bimg.StreamSource = fstream
            bimg.EndInit()
        End Using
        bimg.Freeze()
        UIEimage.Source = bimg
        UIEimage.Stretch = Windows.Media.Stretch.Uniform
        UIEimage.StretchDirection = Windows.Controls.StretchDirection.DownOnly
        conImage = New Windows.Documents.BlockUIContainer(UIEimage)
        conImage.BorderThickness = thickness
        conImage.BorderBrush = Windows.Media.Brushes.Black
        conImage.Padding = thickness
        rtbOutput2.rtbOutput.Document.Blocks.Add(conImage)
        rtbOutput2.rtbOutput.Document.Blocks.Add(New Windows.Documents.Paragraph)

        'TESTING TO BE REMOVED
        Dim strStargazer As String = "<table style=" & Chr(34) & "text-align:center" & Chr(34) & "><tr><td colspan=" & Chr(34) & "6" & Chr(34) & " style=" & Chr(34) & "border-bottom:  1px solid black" & Chr(34) & "></td></tr><tr><td style=" & Chr(34) & "text-align:Left" & Chr(34) & ">Statistic</td><td>N</td><td>Mean</td><td>St. Dev.</td><td>Min</td><td>Max</td></tr>
<tr><td colspan = " & Chr(34) & "6" & Chr(34) & " style=" & Chr(34) & "border-bottom:  1px solid black" & Chr(34) & "></td></tr><tr><td style=" & Chr(34) & "text-align:Left" & Chr(34) & ">rating</td><td>30</td><td>64.633</td><td>12.173</td><td>40</td><td>85</td></tr>
<tr><td style=" & Chr(34) & "text-align: Left" & Chr(34) & ">complaints</td><td>30</td><td>66.600</td><td>13.315</td><td>37</td><td>90</td></tr>
<tr><td style = " & Chr(34) & "text-align: Left" & Chr(34) & ">privileges</td><td>30</td><td>53.133</td><td>12.235</td><td>30</td><td>83</td></tr>
<tr><td style=" & Chr(34) & "text-align: Left" & Chr(34) & ">learning</td><td>30</td><td>56.367</td><td>11.737</td><td>34</td><td>75</td></tr>
<tr><td style = " & Chr(34) & "text-align: Left" & Chr(34) & ">raises</td><td>30</td><td>64.633</td><td>10.397</td><td>43</td><td>88</td></tr>
<tr><td style=" & Chr(34) & "text-align: Left" & Chr(34) & ">critical</td><td>30</td><td>74.767</td><td>9.895</td><td>49</td><td>92</td></tr>
<tr><td style = " & Chr(34) & "text-align: Left" & Chr(34) & ">advance</td><td>30</td><td>42.933</td><td>10.289</td><td>25</td><td>72</td></tr>
<tr><td colspan=" & Chr(34) & "6" & Chr(34) & " style=" & Chr(34) & "border-bottom: 1px solid black" & Chr(34) & "></td></tr></table>"
        rtbOutput2.AddIntoWebBrowser(strFilePath:="file:///C:/Users/Fran%C3%A7ois/Documents/Administratif/jobs/ADI/R_HTML_Files/firstggplotgrphinhtml.html")
        rtbOutput2.AddIntoWebBrowser(strHtmlCode:=strStargazer)
    End Sub
    Public Sub DisplayGraphInWB(strImageLocation As String)
        'TEST temporary

        'WebBrowser.DocumentStream.??? 
        'https://msdn.microsoft.com/en-us/library/system.windows.forms.webbrowser.documentstream(v=vs.110).aspx

        'Use references... also need something handles DocumentFinished event... or something...
        'https://social.msdn.microsoft.com/Forums/en-US/2b2244ed-c628-4e82-9751-d829be620689/display-images-in-web-browser-control?forum=vblanguage
        'http://www.dotnetspark.com/Forum/2673-insert-image-web-browser-control-windows.aspx

        'wbOutput.DocumentText = "< img src='" & strImageLocation & "' />"
        'http://www.rasteredge.com/how-to/asp-net-imaging/imaging-viewing/
        If (wbOutput.Document IsNot Nothing) Then
            With wbOutput.Document
                Dim imgElement As HtmlElement = .CreateElement("img src")
                imgElement.InnerText = strImageLocation
                .Body.AppendChild(imgElement)
            End With
        End If


    End Sub

    Private Sub AppendText(box As RichTextBox, color As Color, font As Font, text As String)
        Dim iStart As Integer
        Dim iEnd As Integer

        iStart = box.TextLength
        box.AppendText(text)
        iEnd = box.TextLength


        ' Textbox may transform chars, so (end-start) != text.Length
        box.[Select](iStart, iEnd - iStart)
        box.SelectionColor = color
        box.SelectionFont = font
        'TClears selection
        box.SelectionLength = 0
        ' clear
        box.SelectionStart = box.Text.Length
        box.ScrollToCaret()
    End Sub

    Private Sub AppendText2(TempRtf As ucrWPFRichTextBox, color As Color, font As Font, text As String, Optional color2 As Color = Nothing, Optional font2 As Font = Nothing, Optional text2 As String = Nothing)
        'Task: migrate the sub to the ucrWPFRichTextBox...
        Dim run1 As New Windows.Documents.Run(text)
        run1.FontFamily = New Windows.Media.FontFamily(font.FontFamily.Name)
        run1.Foreground = New Windows.Media.BrushConverter().ConvertFromString(color.Name)
        Dim Paragraph As New Windows.Documents.Paragraph(run1)
        If font2 IsNot Nothing AndAlso text2 IsNot Nothing AndAlso color2 <> Nothing Then 'Note: IsNot only works for reference types...
            Dim run2 As New Windows.Documents.Run(text2)
            run2.FontFamily = New Windows.Media.FontFamily(font2.FontFamily.Name)
            run2.Foreground = New Windows.Media.BrushConverter().ConvertFromString(color2.Name)
            Paragraph.Inlines.Add(run2)
        End If
        TempRtf.rtbOutput.Document.Blocks.Add(Paragraph)
    End Sub

    Private Sub WbAppendText(WebBrowser As WebBrowser, color As Color, font As Font, text As String)
        'TEST temporary

        If (WebBrowser.Document IsNot Nothing) Then
            With WebBrowser.Document
                Dim TextElem As HtmlElement = .CreateElement("DIV")
                TextElem.InnerText = text
                .Body.AppendChild(TextElem)
            End With
        End If

        'wbOutput.DocumentText.Insert(wbOutput.DocumentText.Length, text)
        'Dim iStart As Integer
        'Dim iEnd As Integer

        'iStart = WebBrowser.DocumentText.Length
        'WebBrowser.DocumentText = WebBrowser.DocumentText & text
        'WebBrowser.Document.Write(text)
        'iEnd = WebBrowser.DocumentText.Length

        'Warning: so far don't know how to change font and colour of the text...
        ' Textbox may transform chars, so (end-start) != text.Length
        ' WebBrowser.DocumentText.Substring(iStart, iEnd - iStart)
        'WebBrowser.SelectionColor = color
        'WebBrowser.SelectionFont = font
        'TClears selection
        'WebBrowser.SelectionLength = 0
        ' clear
        'WebBrowser.SelectionStart = WebBrowser.Text.Length
        'WebBrowser.ScrollToCaret()
    End Sub

    Public Function RunInternalScriptGetValue(strScript As String, Optional strVariableName As String = ".temp_value", Optional bSilent As Boolean = False) As SymbolicExpression
        Dim expTemp As SymbolicExpression
        Dim strCommand As String
        'Dim iSplitIndex As Integer
        'Dim iRemaining As Integer
        'Dim iStartPoint As Integer

        expTemp = Nothing
        strCommand = strVariableName & "<-" & strScript
        'If strCommand.Length > 2000 Then
        'MsgBox("The following command cannot be run because it exceeds the character limit of 2000 characters for a command in R-Instat." & vbNewLine & strScript & vbNewLine & vbNewLine & "It may be possible to run the command directly in R.", MsgBoxStyle.Critical, "Cannot run command")
        If clsEngine IsNot Nothing Then
            Try
                'iRemaining = strScript.Length
                'iStartPoint = 1000
                'While iRemaining > 1000
                '    iSplitIndex = strScript.Substring(iStartPoint).IndexOf(",") + iStartPoint
                '    iRemaining = strScript.Length - iSplitIndex
                '    strScript = strScript.Insert(iSplitIndex + 1, vbNewLine)
                '    iStartPoint = iSplitIndex + 1000
                'End While
                clsEngine.Evaluate(strCommand)
                expTemp = clsEngine.GetSymbol(strVariableName)
            Catch ex As Exception
                If Not bSilent Then
                    MsgBox(ex.Message & vbNewLine & "The error occurred in attempting to run the following R command(s):" & vbNewLine & strScript, MsgBoxStyle.Critical, "Error running R command(s)")
                End If
            End Try
        End If
        Return expTemp
    End Function

    Public Function RunInternalScriptGetOutput(strScript As String, Optional bSilent As Boolean = False) As CharacterVector
        Dim chrTemp As CharacterVector
        Dim expTemp As SymbolicExpression

        expTemp = RunInternalScriptGetValue("capture.output(" & strScript & ")", bSilent:=bSilent)
        Try
            chrTemp = expTemp.AsCharacter()
        Catch ex As Exception
            If Not bSilent Then
                MsgBox(ex.Message & vbNewLine & "The error occurred in attempting to run the following R command(s):" & vbNewLine & strScript, MsgBoxStyle.Critical, "Error running R command(s)")
            End If
            chrTemp = Nothing
        End Try
        Return chrTemp
    End Function

    Public Function RunInternalScript(strScript As String, Optional strVariableName As String = "", Optional bSilent As Boolean = False) As Boolean
        'Dim iSplitIndex As Integer
        'Dim iRemaining As Integer
        Dim strCommand As String

        strCommand = strVariableName & "<-" & strScript
        'If strCommand.Length > 2000 Then
        '    MsgBox("The following command cannot be run because it exceeds the character limit of 2000 characters for a command in R-Instat." & vbNewLine & strScript & vbNewLine & vbNewLine & "It may be possible to run the command directly in R.", MsgBoxStyle.Critical, "Cannot run command")
        '    Return False
        If clsEngine IsNot Nothing Then
            Try
                'iRemaining = strScript.Length
                'While iRemaining > 1000
                '    iSplitIndex = strScript.Substring(1000).IndexOf(",")
                '    iRemaining = strScript.Length - iSplitIndex
                '    strScript = strScript.Insert(iSplitIndex + 1, vbNewLine)
                'End While
                If strVariableName <> "" Then
                    clsEngine.Evaluate(strVariableName & "<-" & strScript)
                Else
                    clsEngine.Evaluate(strScript)
                End If
                Return True
            Catch ex As Exception
                If Not bSilent Then
                    MsgBox(ex.Message & vbNewLine & "The error occurred in attempting to run the following R command(s):" & vbNewLine & strScript, MsgBoxStyle.Critical, "Error running R command(s)")
                End If
                Return False
            End Try
        Else
            Return False
        End If
    End Function

    Public Function GetDefaultDataFrameName(strPrefix As String, Optional iStartIndex As Integer = 1, Optional bIncludeIndex As Boolean = True) As String
        Dim strTemp As String
        Dim clsGetNextDataName As New RFunction

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
        strTemp = RunInternalScriptGetValue(clsGetNextDataName.ToScript()).AsCharacter(0)
        Return strTemp
    End Function

    Public Sub CreateNewClimateObject() 'creates an instance of the climate object
        If Not bClimateObjectExists Then
            frmMain.Cursor = Cursors.WaitCursor
            frmSetupLoading.Show()
            RunScript("setwd('" & frmMain.strStaticPath.Replace("\", "/") & strClimateObjectPath & "')")
            RunScript("source(" & Chr(34) & "SourcingScript.R" & Chr(34) & ")")
            RunScript(strClimateObject & "<-climate$new()")
            bClimateObjectExists = True
            frmSetupLoading.Close()
            frmMain.Cursor = Cursors.Default
        End If
    End Sub

    Public Sub RSetup()
        'run script to load libraries
        frmMain.Cursor = Cursors.WaitCursor
        frmSetupLoading.Show()
        RunScript("setwd('" & frmMain.strStaticPath.Replace("\", "/") & strInstatObjectPath & "')") 'This is bad the wd should be flexible and not automatically set to the instat object directory 
        RunScript("source(" & Chr(34) & "Rsetup.R" & Chr(34) & ")")
        CreateNewInstatObject()
        frmSetupLoading.Close()
        frmMain.Cursor = Cursors.Default
    End Sub

    Public Sub CreateNewInstatObject()
        RunScript(strInstatDataObject & " <- instat_object$new()")
        bInstatObjectExists = True
    End Sub

    Public Sub FillListView(lstView As ListView, strType As String, Optional lstIncludedDataTypes As List(Of KeyValuePair(Of String, String())) = Nothing, Optional lstExcludedDataTypes As List(Of KeyValuePair(Of String, String())) = Nothing, Optional strDataFrameName As String = "", Optional strHeading As String = "Variables", Optional strExcludedItems As String() = Nothing)
        Dim vecColumns As GenericVector
        Dim chrCurrColumns As CharacterVector
        Dim i As Integer
        Dim grps As New ListViewGroup
        Dim clsGetItems As New RFunction
        Dim clsIncludeList As New RFunction
        Dim clsExcludeList As New RFunction
        Dim kvpInclude As KeyValuePair(Of String, String())
        Dim kvpExclude As KeyValuePair(Of String, String())

        If bInstatObjectExists Then
            Select Case strType
                Case "column"
                    clsGetItems.SetRCommand(strInstatDataObject & "$get_column_names")
                Case "metadata"
                    clsGetItems.SetRCommand(strInstatDataObject & "$get_metadata_fields")
                Case "filter"
                    clsGetItems.SetRCommand(strInstatDataObject & "$get_filter_names")
                Case "object"
                    clsGetItems.SetRCommand(strInstatDataObject & "$get_object_names")
                Case "model"
                    clsGetItems.SetRCommand(strInstatDataObject & "$get_model_names")
                Case "graph"
                    clsGetItems.SetRCommand(strInstatDataObject & "$get_graph_names")
                Case "dataframe"
                    clsGetItems.SetRCommand(strInstatDataObject & "$get_data_names")
            End Select
            clsGetItems.AddParameter("as_list", "TRUE")
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
            vecColumns = RunInternalScriptGetValue(clsGetItems.ToScript()).AsList

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
                            If vecColumns.Count > 1 Then
                                lstView.Items(j).Group = lstView.Groups(i)
                            End If
                        Next
                    End If
                Next
                'TODO Find out how to get this to set automatically ( Width = -2 almost works)
                lstView.Columns(0).Width = lstView.Width - 25
            End If
    End Sub

    Public Sub SelectColumnsWithMetadataProperty(ucrCurrentReceiver As ucrReceiverMultiple, strDataFrameName As String, strProperty As String, strValues As String())
        Dim vecColumns As GenericVector
        Dim chrCurrColumns As CharacterVector
        Dim i As Integer
        Dim clsGetItems As New RFunction
        Dim clsIncludeList As New RFunction
        Dim kvpInclude As KeyValuePair(Of String, String())
        Dim lstItems As New List(Of KeyValuePair(Of String, String))

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
            vecColumns = RunInternalScriptGetValue(clsGetItems.ToScript()).AsList
            ucrCurrentReceiver.Clear()
            For i = 0 To vecColumns.Count - 1
                chrCurrColumns = vecColumns(i).AsCharacter
                For Each strColumn As String In chrCurrColumns
                    lstItems.Add(New KeyValuePair(Of String, String)(strDataFrameName, strColumn))
                Next
                ucrCurrentReceiver.AddMultiple(lstItems.ToArray())
            Next
        End If
        ucrCurrentReceiver.Selector.LoadList()
    End Sub

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

    Public Function DataFrameExists(strDataFrameName As String) As Boolean
        Dim bExists As Boolean
        Dim clsDataFrameExists As New RFunction

        clsDataFrameExists.SetRCommand(strInstatDataObject & "$data_frame_exists")
        clsDataFrameExists.AddParameter("data_name", Chr(34) & strDataFrameName & Chr(34))
        bExists = RunInternalScriptGetValue(clsDataFrameExists.ToScript()).AsLogical(0)
        Return bExists
    End Function

    Public Function GetDataFrameLength(strDataFrameName As String) As Integer
        Dim intLength As Integer
        Dim clsDataFrameLength As New RFunction

        clsDataFrameLength.SetRCommand(strInstatDataObject & "$get_data_frame_length")
        clsDataFrameLength.AddParameter("data_name", Chr(34) & strDataFrameName & Chr(34))
        intLength = RunInternalScriptGetValue(clsDataFrameLength.ToScript()).AsInteger(0)
        Return intLength
    End Function

    Public Function GetDataFrameColumnCount(strDataFrameName As String) As Integer
        Dim intColumnCount As Integer
        Dim clsDataFrameColCount As New RFunction

        clsDataFrameColCount.SetRCommand(strInstatDataObject & "$get_column_count")
        clsDataFrameColCount.AddParameter("data_name", Chr(34) & strDataFrameName & Chr(34))
        intColumnCount = RunInternalScriptGetValue(clsDataFrameColCount.ToScript()).AsInteger(0)
        Return intColumnCount
    End Function

    Public Function GetModelNames(Optional strDataFrameName As String = "") As List(Of String)
        Dim chrModelNames As CharacterVector
        Dim lstModelNames As New List(Of String)
        Dim clsGetModelNames As New RFunction
        Dim expModelNames As SymbolicExpression

        clsGetModelNames.SetRCommand(strInstatDataObject & "$get_model_names")
        If strDataFrameName <> "" Then
            clsGetModelNames.AddParameter("data_name", Chr(34) & strDataFrameName & Chr(34))
        End If
        expModelNames = RunInternalScriptGetValue(clsGetModelNames.ToScript(), bSilent:=True)
        If expModelNames IsNot Nothing AndAlso (Not expModelNames.Type = Internals.SymbolicExpressionType.Null) Then
            chrModelNames = expModelNames.AsCharacter()
            If chrModelNames.Length > 0 Then
                lstModelNames.AddRange(chrModelNames)
            End If
        End If
        Return lstModelNames
    End Function

    Public Function GetFilterNames(strDataFrameName As String) As List(Of String)
        Dim expFilterNames As SymbolicExpression
        Dim chrFilterNames As CharacterVector
        Dim lstFilterNames As New List(Of String)
        Dim clsGetFilterNames As New RFunction

        clsGetFilterNames.SetRCommand(strInstatDataObject & "$get_filter_names")
        clsGetFilterNames.AddParameter("data_name", Chr(34) & strDataFrameName & Chr(34))
        expFilterNames = RunInternalScriptGetValue(clsGetFilterNames.ToScript(), bSilent:=True)
        If Not expFilterNames.Type = Internals.SymbolicExpressionType.Null Then
            chrFilterNames = expFilterNames.AsCharacter()
            If chrFilterNames.Length > 0 Then
                lstFilterNames.AddRange(chrFilterNames)
            End If
        End If
        Return lstFilterNames
    End Function

    Public Function GetGraphNames(Optional strDataFrameName As String = "") As List(Of String)
        Dim chrGraphNames As CharacterVector
        Dim lstGraphNames As New List(Of String)
        Dim clsGetGraphNames As New RFunction
        Dim expGraphNames As SymbolicExpression

        clsGetGraphNames.SetRCommand(strInstatDataObject & "$get_graph_names")
        If strDataFrameName <> "" Then
            clsGetGraphNames.AddParameter("data_name", Chr(34) & strDataFrameName & Chr(34))
        End If
        expGraphNames = RunInternalScriptGetValue(clsGetGraphNames.ToScript(), bSilent:=True)
        If expGraphNames IsNot Nothing AndAlso Not expGraphNames.Type = Internals.SymbolicExpressionType.Null Then
            chrGraphNames = expGraphNames.AsCharacter()
            If chrGraphNames.Length > 0 Then
                lstGraphNames.AddRange(chrGraphNames)
            End If
        End If
        Return lstGraphNames
    End Function

    Public Function GetDataType(strDataFrameName As String, strColumnName As String) As String
        Dim strDataType As String
        Dim clsGetDataType As New RFunction

        clsGetDataType.SetRCommand(strInstatDataObject & "$get_data_type")
        clsGetDataType.AddParameter("data_name", Chr(34) & strDataFrameName & Chr(34))
        clsGetDataType.AddParameter("col_name", Chr(34) & strColumnName & Chr(34))
        strDataType = RunInternalScriptGetValue(clsGetDataType.ToScript()).AsCharacter(0)
        Return strDataType
    End Function

    Public Function MakeValidText(strText As String) As String
        Dim strOut As String
        Dim clsMakeNames As New RFunction

        clsMakeNames.SetRCommand("make.names")
        clsMakeNames.AddParameter("names", Chr(34) & strText & Chr(34))
        strOut = RunInternalScriptGetValue(clsMakeNames.ToScript()).AsCharacter(0)
        Return strOut
    End Function
End Class