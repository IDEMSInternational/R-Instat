Imports System.Threading
Imports System.Globalization
Public Class InstatOptions
    Public bIncludeRDefaultParameters As Boolean
    Public fntOutput, fntScript, fntComment As Font
    Public clrOutput, clrScript, clrComment As Color
    Public txtComment, strLanguageCode As String
    Public iLines As Integer

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

    Public Sub SetNoLines(intlines As Integer)
        iLines = intlines
        dlgImportDataset.setLinesToRead(iLines)
    End Sub

    Public Sub SetComments(strText As String)
        txtComment = strText
        dlgOptions.strComment = txtComment
    End Sub

    Public Sub SetLanguage(strLanguage As String)
        strLanguageCode = strLanguage
        Select Case strLanguageCode
            Case "eng"
                Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
                Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-US")
            Case "fra"
                Thread.CurrentThread.CurrentCulture = New CultureInfo("fr-FR")
                Thread.CurrentThread.CurrentUICulture = New CultureInfo("fr-FR")
            Case "swa"
                Thread.CurrentThread.CurrentCulture = New CultureInfo("sw-KE")
                Thread.CurrentThread.CurrentUICulture = New CultureInfo("sw-KE")
        End Select

    End Sub

End Class
