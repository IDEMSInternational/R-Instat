Public Class InstatOptions
    Public bIncludeRDefaultParameters, bKis, bEng, bFr As Boolean
    Public fntOutput, fntScript, fntComment As Font
    Public clrOutput, clrScript, clrComment As Color
    Public txtComment As String
    Public iLines As Integer = 10

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

End Class
