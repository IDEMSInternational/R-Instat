Public Class RSyntax
    Dim strScript As String
    Public Sub manage(lstOfString As List(Of String), submenu As String, subsubmenu As String, type As String)
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

                            Case "date"

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
