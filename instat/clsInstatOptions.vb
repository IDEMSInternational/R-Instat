Public Class InstatOptions
    Public bIncludeRDefaultParameters As Boolean
    Public fntOutput As Font
    Public clrOutput As Color

    Public Sub SetFormatOutput(fntNew As Font, clrNew As Color)
        fntOutput = fntNew
        clrOutput = clrNew
        frmMain.clsRLink.setFormatOutput(fntOutput, clrOutput)
    End Sub

End Class
