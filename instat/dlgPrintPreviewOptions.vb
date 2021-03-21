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

Imports System.Drawing.Printing
Imports instat.Translations
Imports unvell.ReoGrid
Public Class dlgPrintPreviewOptions
    Public WithEvents printDocument As New PrintDocument
    Dim previewPrint As New PrintPreviewDialog
    Dim pd As New PrintDialog
    Dim printTextCtrl As TextBoxBase
    Dim sheetPreview As Worksheet

    Dim bFirstLoad As Boolean = True
    Private Sub cmdPrevSheet_Click(sender As Object, e As EventArgs) Handles cmdPrevSheet.Click
        Dim session = sheetPreview.CreatePrintSession()
        previewPrint.Document = sheetPreview.CreatePrintSession().PrintDocument
        previewPrint.SetBounds(200, 200, 1024, 768)
        previewPrint.PrintPreviewControl.Zoom = 1.0
        previewPrint.ShowDialog(Me)

        session.Dispose()
    End Sub

    Private Sub cmdPrtSheet_Click(sender As Object, e As EventArgs) Handles cmdPrtSheet.Click
        Dim docToPrint As PrintDocument = Nothing
        Try
            docToPrint = sheetPreview.CreatePrintSession().PrintDocument

        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, Me.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End Try
        pd.Document = docToPrint
        pd.UseEXDialog = True
        If pd.ShowDialog() = DialogResult.OK Then
            docToPrint.PrinterSettings = pd.PrinterSettings
            docToPrint.Print()
        End If
        docToPrint.Dispose()

    End Sub

    Private Sub cmdPrtLog_Click(sender As Object, e As EventArgs) Handles cmdPrtLog.Click
        printControl(frmLog.txtLog)
    End Sub

    Private Sub cmdPrtOutput_Click(sender As Object, e As EventArgs) Handles cmdPrtOutput.Click
        printControl(frmCommand.txtCommand)
    End Sub

    Private Sub printControl(ctrl As Control)
        printTextCtrl = ctrl
        Using pd
            pd.Document = printDocument
            pd.UseEXDialog = True
            If pd.ShowDialog(ctrl) = DialogResult.OK Then
                printDocument.PrinterSettings = pd.PrinterSettings
                printDocument.Print()
            End If
        End Using
    End Sub
    Private Sub cmdPrevLog_Click(sender As Object, e As EventArgs) Handles cmdPrevLog.Click
        previewControl(frmLog.txtLog)
    End Sub

    Private Sub cmdPrevOutput_Click(sender As Object, e As EventArgs) Handles cmdPrevOutput.Click
        previewControl(frmCommand.txtCommand)
    End Sub

    Private Sub previewControl(ctrl As Control)
        printTextCtrl = ctrl
        previewPrint.Document = printDocument
        previewPrint.ShowDialog(ctrl)
    End Sub

    Private Sub printDocument_PrintPage(sender As Object, e As PrintPageEventArgs) Handles printDocument.PrintPage
        Static currentChar As Integer
        Static currentLine As Integer
        Dim textfont As Font = printTextCtrl.Font
        Dim h, w As Integer
        Dim left, top As Integer
        With printDocument.DefaultPageSettings
            h = .PaperSize.Height - .Margins.Top - .Margins.Bottom
            w = .PaperSize.Width - .Margins.Left - .Margins.Right
            left = printDocument.DefaultPageSettings.Margins.Left
            top = printDocument.DefaultPageSettings.Margins.Top
        End With
        e.Graphics.DrawRectangle(Pens.Black, New Rectangle(left, top, w, h))
        If printDocument.DefaultPageSettings.Landscape Then
            Dim a As Integer
            a = h
            h = w
            w = a
        End If
        Dim lines As Integer = CInt(Math.Round(h / textfont.Height))
        Dim b As New Rectangle(left, top, w, h)
        Dim format As StringFormat
        If Not printTextCtrl.WordWrap Then
            format = New StringFormat(StringFormatFlags.NoWrap)
            format.Trimming = StringTrimming.EllipsisWord
            Dim i As Integer
            For i = currentLine To Math.Min(currentLine + lines, printTextCtrl.Lines.Length - 1)
                e.Graphics.DrawString(printTextCtrl.Lines(i), textfont, Brushes.Black, New RectangleF(left, top + textfont.Height * (i - currentLine), w, textfont.Height), format)
            Next
            currentLine += lines
            If currentLine >= printTextCtrl.Lines.Length Then
                e.HasMorePages = False
                currentLine = 0
            Else
                e.HasMorePages = True
            End If
            Exit Sub
        End If
        format = New StringFormat(StringFormatFlags.LineLimit)
        Dim line, chars As Integer
        e.Graphics.MeasureString(Mid(printTextCtrl.Text, currentChar + 1), textfont, New SizeF(w, h), format, chars, line)
        If currentChar + chars < printTextCtrl.Text.Length Then
            If printTextCtrl.Text.Substring(currentChar + chars, 1) <> " " And printTextCtrl.Text.Substring(currentChar + chars, 1) <> vbLf Then
                While chars > 0
                    printTextCtrl.Text.Substring(currentChar + chars, 1)
                    printTextCtrl.Text.Substring(currentChar + chars, 1)
                    chars -= 1
                End While
                chars += 1
            End If
        End If
        e.Graphics.DrawString(printTextCtrl.Text.Substring(currentChar, chars), textfont, Brushes.Black, b, format)
        currentChar = currentChar + chars
        If currentChar < printTextCtrl.Text.Length Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
            currentChar = 0
        End If
    End Sub

    Private Sub cmdExitPreview_Click(sender As Object, e As EventArgs) Handles cmdExitPreview.Click
        'reverts to original
        sheetPreview.SetRangeBorders(sheetPreview.PrintableRange, unvell.ReoGrid.BorderPositions.All, unvell.ReoGrid.RangeBorderStyle.Empty)
        Me.Close()
    End Sub

    Private Sub chkGridLines_CheckStateChanged(sender As Object, e As EventArgs) Handles chkGridLines.CheckStateChanged
        sheetPreview.CreatePrintSession()
        If chkGridLines.Checked Then
            'shows the gridlines
            sheetPreview.SetRangeBorders(sheetPreview.PrintableRange, unvell.ReoGrid.BorderPositions.All, unvell.ReoGrid.RangeBorderStyle.BlackSolid)
        Else
            'hides the grid lines
            sheetPreview.SetRangeBorders(sheetPreview.PrintableRange, unvell.ReoGrid.BorderPositions.All, unvell.ReoGrid.RangeBorderStyle.Empty)
        End If
    End Sub

    Private Sub dlgPrintPreviewOptions_Load(sender As Object, e As EventArgs) Handles Me.Load
        sheetPreview = frmEditor.grdData.CurrentWorksheet
        autoTranslate(Me)
        setDefaults()
    End Sub

    Private Sub setDefaults()
        chkGridLines.Checked = True
    End Sub
End Class