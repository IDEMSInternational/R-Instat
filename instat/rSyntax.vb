Public Class RSyntax
    Dim strScript As String
    Public Sub manage(lstOfString As Object, submenu As String, subsubmenu As String, type As String)
        Select Case submenu
            Case "Calculations"

            Case "Data"
                Select Case subsubmenu
                    Case "Regular Sequence"
                        Select Case type
                            Case "regular"
                                strScript = "capture.output(seq(from = " & Convert.ToInt32(lstOfString(0)) & ", to = " & Convert.ToInt32(lstOfString(1)) & ", by = " & Convert.ToInt32(lstOfString(2)) & "))"
                                frmMain.clsRInterface.RunScript(strScript)
                            Case "repeated"
                                strScript = "capture.output(seq(from = " & Convert.ToInt32(lstOfString(0)) & ", to = " & Convert.ToInt32(lstOfString(0)) & ", length.out = " & Convert.ToInt32(lstOfString(1)) & "))"
                                frmMain.clsRInterface.RunScript(strScript)
                            Case "date"
                                strScript = "capture.output(seq(from = as.Date('" & Format(lstOfString(0), "yyyy/MM/dd") & "'), to = as.Date('" & Format(lstOfString(1), "yyyy/MM/dd") & "'), by = '" & lstOfString(2) & "'))"
                                frmMain.clsRInterface.RunScript(strScript)
                        End Select
                    Case "Duplicate"

                    Case "Random Samples"

                    Case "Remove"
                End Select

            Case "Manipulate"
                Select Case subsubmenu
                    Case "Sort"

                    Case "Row Statistics"

                End Select
            Case "Resize Worksheet"

            Case "Worksheet Information"

        End Select


    End Sub

    Public Sub graphics(strString As String, submenu As String)



    End Sub

    Public Sub statistcs(strString As String, submenu As String)



    End Sub

    Public Sub climatic(strString As String, submenu As String)



    End Sub

End Class
