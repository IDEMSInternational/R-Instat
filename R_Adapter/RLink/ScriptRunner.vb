Imports Microsoft.VisualBasic
Imports R_Adapter2.R_Adapter.Constant
Imports R_Link.ScriptBuilder
Imports RDotNet
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Net.Mime.MediaTypeNames

Namespace R_Adapter.RLink
    Public NotInheritable Class ScriptRunner
        Inherits RConnector

        Event OutputAdded()
        Event StatusChanged()
        Event DatabookRefresh()


        Private Sub New()
        End Sub

        Private Shared ReadOnly padlock As Object = New Object()
        Private Shared instance As ScriptRunner = Nothing

        Public Shared ReadOnly Property SingletonInstance As ScriptRunner
            Get

                SyncLock padlock
                    If instance Is Nothing Then
                        instance = New ScriptRunner()
                    End If
                    Return instance
                End SyncLock
            End Get
        End Property


        Public HelperFunctions As HelperFunction = New HelperFunction()

        Public Sub ConfigureREngine(ByVal rSetupOptions As RSetupOptions)
            SetEnviromentVariables(rSetupOptions.RPath, rSetupOptions.RHome)
            Connect()
        End Sub

        Public Function RunUnvalidatedScript(ByVal strNewScript As String, ByVal strNewComment As String) As String
            Dim strScriptCmd As String = ""
            Dim test As String = ""

            For Each strScriptLine As String In strNewScript.Split(Environment.NewLine)
                Dim iCommentPos As Integer = strScriptLine.IndexOf("#")

                'Select Case iCommentPos
                '    Case 0
                '        Continue For
                '    Case Object _ When iCommentPos > 0 
                '        test = strScriptLine.Substring(0, iCommentPos - 1)
                '        Exit Select
                'End Select

                Dim strTrimmedLine As String = ""

                If test <> "" Then
                    strTrimmedLine = test
                    test = ""
                Else
                    strTrimmedLine = strScriptLine.Trim(Constants.vbLf.ToCharArray()).Trim()
                End If

                If strTrimmedLine.Length <= 0 Then Continue For
                strScriptCmd += strScriptLine
                Dim cLastChar As Char = strTrimmedLine.Last()
                Dim strLast3Chars As String = ""
                Dim iNumOpenRound As Integer = strScriptCmd.Where(Function(c) c = "("c).Count()
                Dim iNumClosedRound As Integer = strScriptCmd.Where(Function(c) c = ")"c).Count()
                Dim iNumOpenCurlies As Integer = strScriptCmd.Where(Function(c) c = "{"c).Count()
                Dim iNumClosedCurlies As Integer = strScriptCmd.Where(Function(c) c = "}"c).Count()
                Dim iNumDoubleQuotes As Integer = strScriptCmd.Where(Function(c) c = """"c).Count()
                If strTrimmedLine.Length >= 3 Then strLast3Chars = strTrimmedLine.Substring(strTrimmedLine.Length - 3)
                If cLastChar = "+"c OrElse cLastChar = ","c OrElse strLast3Chars = "%>%" OrElse iNumOpenRound <> iNumClosedRound OrElse iNumOpenCurlies <> iNumClosedCurlies OrElse Convert.ToBoolean(iNumDoubleQuotes Mod 2) Then Continue For
                Dim iCallType As Integer = 5
                If strScriptCmd.Contains(RCodeConstant.DataBookName & "$get_graphs") Then iCallType = 3
                RunScript(strScriptCmd.Trim(Constants.vbLf.ToCharArray()), iCallType:=iCallType, strComment:=strNewComment, bSeparateThread:=False, bSilent:=False)
                strScriptCmd = ""
                strNewComment = ""
            Next

            Return strScriptCmd
        End Function

        Private Function GetFormattedComment(ByVal strComment As String) As String
            Dim strReconstructedComment As String = ""
            Dim arrCommentParts As String()

            If strComment.Length > 0 Then
                arrCommentParts = strComment.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries)

                For Each strPart As String In arrCommentParts

                    If strReconstructedComment = "" Then
                        strReconstructedComment = "# " & strPart
                    Else
                        strReconstructedComment = strReconstructedComment & Environment.NewLine & "# " & strPart
                    End If
                Next
            End If

            Return strReconstructedComment
        End Function

        Public Sub RunScript(ByVal strScript As String, ByVal Optional iCallType As Integer = 0, ByVal Optional strComment As String = "", ByVal Optional bSeparateThread As Boolean = True, ByVal Optional bShowWaitDialogOverride As Nullable(Of Boolean) = Nothing, ByVal Optional bUpdateGrids As Boolean = True, ByVal Optional bSilent As Boolean = False)
            Evaluate(strScript)
            RaiseEvent DatabookRefresh()
        End Sub

        Public Sub RunScriptNoResult(ByVal strScript As String)
            Evaluate(strScript)
        End Sub

        Public Function RunScriptGetTemporaryVariable(ByVal strScript As String) As String
            Dim expTemp As SymbolicExpression
            Dim strOutput As String = ""
            Dim clsPNGFunction As RFunction = New RFunction()
            Dim strTempAssignTo As String = ".temp_val"

            Try
                Evaluate(strTempAssignTo & " <- " & strScript)
                expTemp = GetSymbol(strTempAssignTo)

                If expTemp IsNot Nothing Then
                    Dim strTemp As String = String.Join(Environment.NewLine, expTemp.AsCharacter())
                    strOutput = strOutput & strTemp & Environment.NewLine
                End If

            Catch e As Exception
            End Try

            Return strOutput
        End Function

        Public Function RunScriptGetText(ByVal strScript As String) As String
            Dim strCapturedScript As String
            Dim expTemp As RDotNet.SymbolicExpression
            Dim strTemp As String = ""
            Dim strOutput As String = ""
            Dim strSplitScript As String
            Dim clsPNGFunction As RFunction = New RFunction()
            Dim strTempAssignTo As String = ".temp_val"
            Dim bError As Boolean = False

            If strScript.Trim(Environment.NewLine.ToCharArray()).LastIndexOf(Environment.NewLine.ToCharArray()(0)) = -1 Then
                strCapturedScript = "capture.output(" & strScript & ")"
            Else
                strSplitScript = Strings.Left(strScript, strScript.Trim(Environment.NewLine.ToCharArray()).LastIndexOf(Environment.NewLine.ToCharArray()(0)))

                If strSplitScript <> "" Then

                    Try
                        bError = Not Evaluate(strSplitScript)
                    Catch e As Exception
                    End Try
                End If

                strSplitScript = Strings.Right(strScript, strScript.Length - strScript.Trim(Environment.NewLine.ToCharArray()).LastIndexOf(Environment.NewLine.ToCharArray()(0)) - 2)
                strCapturedScript = "capture.output(" & strSplitScript & ")"
            End If

            Try

                If Not bError Then

                    If Evaluate(strTempAssignTo & " <- " & strCapturedScript) Then
                        expTemp = GetSymbol(strTempAssignTo)
                        Evaluate("rm(" & strTempAssignTo & ")")

                        If expTemp IsNot Nothing Then
                            strTemp = String.Join(Environment.NewLine, expTemp.AsCharacter())
                            If strTemp <> "" Then strOutput = strOutput & strTemp & Environment.NewLine
                        End If
                    End If
                End If

            Catch e As Exception
            End Try

            Return strOutput
        End Function

        Private Function RunScriptAndShowInWeb(ByVal strScript As String) As String
            Dim strCapturedScript As String
            Dim expTemp As RDotNet.SymbolicExpression
            Dim strOutput As String = ""
            Dim strSplitScript As String
            Dim clsPNGFunction As RFunction = New RFunction()
            Dim strTempAssignTo As String = ".temp_val"
            Dim bError As Boolean = False
            Dim strTemp As String

            Try
                Evaluate(strTempAssignTo & " <- " & strScript)
                expTemp = GetSymbol(strTempAssignTo)

                If expTemp IsNot Nothing Then
                    strTemp = String.Join(Environment.NewLine, expTemp.AsCharacter())
                    strOutput = strOutput & strTemp & Environment.NewLine
                End If

            Catch e As Exception
            End Try

            If strScript.Trim(Environment.NewLine.ToCharArray()).LastIndexOf(Environment.NewLine.ToCharArray()(0)) = -1 Then
                strCapturedScript = "capture.output(" & strScript & ")"
            Else
                strSplitScript = Strings.Left(strScript, strScript.Trim(Environment.NewLine.ToCharArray()).LastIndexOf(Environment.NewLine.ToCharArray()(0)))

                If strSplitScript <> "" Then

                    Try
                        bError = Not Evaluate(strSplitScript)
                    Catch e As Exception
                    End Try
                End If

                strSplitScript = Strings.Right(strScript, strScript.Length - strScript.Trim(Environment.NewLine.ToCharArray()).LastIndexOf(Environment.NewLine.ToCharArray()(0)) - 2)
                strCapturedScript = "capture.output(" & strSplitScript & ")"
            End If

            Try

                If Not bError Then

                    If Evaluate(strTempAssignTo & " <- " & strCapturedScript) Then
                        expTemp = GetSymbol(strTempAssignTo)
                        Evaluate("rm(" & strTempAssignTo & ")")

                        If expTemp IsNot Nothing Then
                            strTemp = String.Join(Environment.NewLine, expTemp.AsCharacter())
                            If strTemp <> "" Then strOutput = strOutput & strTemp & Environment.NewLine
                        End If
                    End If
                End If

            Catch e As Exception
            End Try

            Return strOutput
        End Function

        Public Function RunInternalScriptGetString(ByVal strScript As String, ByVal Optional strVariableName As String = ".temp_value") As String
            Dim expTemp As SymbolicExpression
            expTemp = RunInternalScriptGetValue(strScript, strVariableName)

            If expTemp IsNot Nothing AndAlso expTemp.Type <> RDotNet.Internals.SymbolicExpressionType.Null Then
                Return expTemp.AsCharacter()(0)
            Else
                Return ""
            End If
        End Function

        Public Function RunInternalScriptGetStringArray(ByVal strScript As String, ByVal Optional strVariableName As String = ".temp_value") As String()
            Dim expTemp As SymbolicExpression
            expTemp = RunInternalScriptGetValue(strScript, strVariableName)

            If expTemp IsNot Nothing AndAlso expTemp.Type <> RDotNet.Internals.SymbolicExpressionType.Null Then
                Return expTemp.AsCharacter().ToArray()
            Else
                Return Nothing
            End If
        End Function

        Public Function RunInternalScriptGetOutput(ByVal strScript As String) As CharacterVector
            Dim chrTemp As CharacterVector
            Dim expTemp As SymbolicExpression
            expTemp = RunInternalScriptGetValue("capture.output(" & strScript & ")", ".temp_value")

            Try
                chrTemp = expTemp.AsCharacter()
            Catch ex As Exception
                chrTemp = Nothing
            End Try

            Return chrTemp
        End Function

        Public Function RunInternalScript(ByVal strScript As String, ByVal Optional strVariableName As String = "") As Boolean
            Dim strCommand As String
            Dim bReturn As Boolean

            If strVariableName <> "" Then
                strCommand = strVariableName & "<-" & strScript
            Else
                strCommand = strScript
            End If

            If IsConnectedToR() Then
                bReturn = Evaluate(strCommand)
                Return bReturn
            Else
                Return False
            End If
        End Function

        Public Function RunInternalScriptGetValue(ByVal strScript As String, ByVal Optional strVariableName As String = "test") As SymbolicExpression
            Dim expTemp As SymbolicExpression
            Dim strCommand As String
            strCommand = strVariableName & " <- " & strScript
            Evaluate(strCommand)
            expTemp = GetSymbol(strVariableName, bSilent:=True)
            Evaluate("rm(" & strVariableName & ")")
            Return expTemp
        End Function

        Public Function RunInternalScriptGetBoolean(ByVal strScript As String, ByVal Optional strVariableName As String = ".temp_value") As Boolean?
            Dim expTemp As SymbolicExpression
            expTemp = RunInternalScriptGetValue(strScript, strVariableName)

            If expTemp IsNot Nothing AndAlso expTemp.Type <> RDotNet.Internals.SymbolicExpressionType.Null Then
                Return expTemp.AsLogical()(0)
            Else
                Return Nothing
            End If
        End Function

        Public Function GetColumnType(strDataName As String, strColumnName As String) As String
            Dim strDataType As String
            Dim clsGetColumnType As New RFunction
            Dim expDateType As SymbolicExpression

            clsGetColumnType.SetRCommand(RCodeConstant.DataBookName & "$get_column_data_types")
            clsGetColumnType.AddParameter("data_name", Chr(34) & strDataName & Chr(34))
            clsGetColumnType.AddParameter("columns", Chr(34) & strColumnName & Chr(34))
            expDateType = RunInternalScriptGetValue(clsGetColumnType.ToScript())
            If expDateType IsNot Nothing AndAlso expDateType.Type <> Internals.SymbolicExpressionType.Null Then
                strDataType = String.Join(",", expDateType.AsCharacter)
            Else
                strDataType = ""
            End If
            Return strDataType
        End Function


        Public Function ConnectAndCheckVersion(ByVal expectedMajorVersion As String, ByVal expectedMinorVersion As String) As Boolean
            Dim bClose As Boolean = Connect()
            If Not HelperFunctions.CompareRVersion(expectedMajorVersion, expectedMinorVersion) Then Return False
            Return bClose
        End Function

        Friend Function GetDataFrameLength(ByVal strDataFrameName As String, Optional bUseCurrentFilter As Boolean = False) As Integer
            Dim iLength As Integer
            Dim clsDataFrameLength As New RFunction
            Dim expLength As SymbolicExpression

            clsDataFrameLength.SetRCommand(RCodeConstant.DataBookName & "$get_data_frame_length")
            clsDataFrameLength.AddParameter("data_name", Chr(34) & strDataFrameName & Chr(34))
            If bUseCurrentFilter Then
                clsDataFrameLength.AddParameter("use_current_filter", "TRUE")
            Else
                clsDataFrameLength.AddParameter("use_current_filter", "FALSE")
            End If
            expLength = RunInternalScriptGetValue(clsDataFrameLength.ToScript())
            If expLength IsNot Nothing AndAlso Not expLength.Type = Internals.SymbolicExpressionType.Null Then
                iLength = expLength.AsInteger(0)
            Else
                iLength = 0
            End If
            Return iLength
        End Function

        Friend Function GetDataFrameColumnCount(ByVal strDataFrameName As String) As Integer
            Dim iColumnCount As Integer
            Dim clsDataFrameColCount As New RFunction
            Dim expCount As SymbolicExpression

            clsDataFrameColCount.SetRCommand(RCodeConstant.DataBookName & "$get_column_count")
            clsDataFrameColCount.AddParameter("data_name", Chr(34) & strDataFrameName & Chr(34))
            expCount = RunInternalScriptGetValue(clsDataFrameColCount.ToScript())
            If expCount IsNot Nothing AndAlso Not expCount.Type = Internals.SymbolicExpressionType.Null Then
                iColumnCount = expCount.AsInteger(0)
            Else
                iColumnCount = 0
            End If
            Return iColumnCount
        End Function

        Friend Function ConvertListToRString(ByVal stringList As List(Of String)) As String
            Dim strTemp As String = ""
            Dim i As Integer

            If stringList.Count = 1 Then
                strTemp = Chr(34) & stringList.Item(0) & Chr(34)

            ElseIf stringList.Count > 1 Then
                strTemp = "c" & "("
                For i = 0 To stringList.Count - 1
                    If i > 0 Then
                        strTemp = strTemp & ","
                    End If
                    If stringList.Item(i) <> "" Then
                        strTemp = strTemp & Chr(34) & stringList.Item(i) & Chr(34)

                    End If
                Next
                strTemp = strTemp & ")"
            End If
            Return strTemp
        End Function
    End Class
End Namespace

