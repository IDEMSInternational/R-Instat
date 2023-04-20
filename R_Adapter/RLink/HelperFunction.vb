Imports Microsoft.VisualBasic
Imports R_Adapter.Constant
Imports R_Adapter.ScriptBuilder
Imports R_Adapter2.R_Adapter.Constant
Imports RDotNet
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace R_Adapter.RLink
    Public Class HelperFunction
        Private ReadOnly _scriptRunner As ScriptRunner

        Public Function GetRSetupScript() As String
            Dim clsSetWd = New RFunction()
            Dim clsSource = New RFunction()
            Dim clsCreateIO = New ROperator()
            Dim clsDplyrOption = New RFunction()
            Dim strScript As String = ""
            clsSetWd.SetRCommand("setwd")
            clsSource.SetRCommand("source")
            clsSource.AddParameter("file", """"c & "Rsetup.R" & """"c)
            clsCreateIO.SetOperation("<-")
            clsCreateIO.AddParameter("left", RCodeConstant.DataBookName, iPosition:=0)
            clsCreateIO.AddParameter("right", RCodeConstant.DataBookClassName & "$new()", iPosition:=1)
            clsDplyrOption.SetRCommand("options")
            clsDplyrOption.AddParameter("dplyr.summarise.inform", "FALSE", iPosition:=0)
            strScript = ""
            strScript = strScript & clsSetWd.ToScript() & Environment.NewLine
            strScript = strScript & clsSource.ToScript() & Environment.NewLine
            strScript = strScript & clsCreateIO.ToScript() & Environment.NewLine
            strScript = strScript & clsDplyrOption.ToScript()
            Return strScript
        End Function


        Public Function GetDataFrameNames() As List(Of String)
            Dim lstDataFrameNames As List(Of String) = New List(Of String)()
            Dim clsGetDataNames As RFunction = New RFunction()
            clsGetDataNames.SetRCommand(RCodeConstant.DataBookName & "$get_data_names")
            lstDataFrameNames.AddRange(_scriptRunner.RunInternalScriptGetStringArray(clsGetDataNames.ToScript()))
            Return lstDataFrameNames
        End Function

        Public Function DataFrameExists(ByVal strDataFrameName As String) As Boolean
            Dim clsDataFrameExists As RFunction = New RFunction()
            clsDataFrameExists.SetRCommand(RCodeConstant.DataBookName & "$data_frame_exists")
            clsDataFrameExists.AddParameter("data_name", Strings.Chr(34) & strDataFrameName + Strings.Chr(34))
            Return If(_scriptRunner.RunInternalScriptGetBoolean(clsDataFrameExists.ToScript()), False)
        End Function

        Public Function GetColumnNames(ByVal strDataFrameName As String, ByVal Optional bIncludeHiddenColumns As Boolean = True) As List(Of String)
            Dim lstCurrColumns As List(Of String) = New List(Of String)()
            Dim clsGetColumnNames As RFunction = New RFunction()

            If strDataFrameName <> "" AndAlso DataFrameExists(strDataFrameName) Then
                clsGetColumnNames.SetRCommand(RCodeConstant.DataBookName & "$get_column_names")
                clsGetColumnNames.AddParameter("data_name", Strings.Chr(34) & strDataFrameName + Strings.Chr(34))
                If Not bIncludeHiddenColumns Then clsGetColumnNames.AddParameter("exclude", "list(Is_Hidden = TRUE)")
                lstCurrColumns.AddRange(_scriptRunner.RunInternalScriptGetStringArray(clsGetColumnNames.ToScript()))
            End If

            Return lstCurrColumns
        End Function

        Public Function GetDefaultColumnNames(ByVal strPrefix As String, ByVal strDataFrameName As String) As String
            Dim strNextDefault As String = ""
            Dim clsGetNextDefault As RFunction = New RFunction()
            clsGetNextDefault.SetRCommand(RCodeConstant.DataBookName & "$get_next_default_column_name")
            clsGetNextDefault.AddParameter("prefix", Strings.Chr(34) & strPrefix + Strings.Chr(34))
            clsGetNextDefault.AddParameter("data_name", Strings.Chr(34) & strDataFrameName + Strings.Chr(34))
            If strDataFrameName <> "" AndAlso DataFrameExists(strDataFrameName) Then strNextDefault = _scriptRunner.RunInternalScriptGetString(clsGetNextDefault.ToScript())
            Return strNextDefault
        End Function

        Public Function GetNextDefault(ByVal strPrefix As String, ByVal lstItems As List(Of String)) As String
            Dim clsGetDefault As RFunction = New RFunction()
            Dim strExistingNames As String
            clsGetDefault.SetRCommand("next_default_item")
            clsGetDefault.AddParameter("prefix", Strings.Chr(34) & strPrefix + Strings.Chr(34))
            strExistingNames = GetListAsRString(lstItems)
            If strExistingNames <> "" Then clsGetDefault.AddParameter("existing_names", GetListAsRString(lstItems))
            Return _scriptRunner.RunInternalScriptGetString(clsGetDefault.ToScript())
        End Function

        Public Function GetListAsRString(ByVal lstStrings As List(Of String), ByVal Optional bWithQuotes As Boolean = True) As String
            Dim strTemp As String = ""
            Dim i As Integer

            If lstStrings.Count = 1 Then

                If bWithQuotes Then
                    strTemp = Strings.Chr(34) & lstStrings(0) + Strings.Chr(34)
                Else
                    strTemp = lstStrings(0)
                End If
            ElseIf lstStrings.Count > 1 Then
                strTemp = "c" & "("

                For i = 0 To lstStrings.Count - 1
                    If i > 0 Then strTemp = strTemp & ","

                    If lstStrings(i) <> "" Then

                        If bWithQuotes Then
                            strTemp = strTemp & Strings.Chr(34) & lstStrings(i) + Strings.Chr(34)
                        Else
                            strTemp = strTemp & lstStrings(i)
                        End If
                    End If
                Next

                strTemp = strTemp & ")"
            End If

            Return strTemp
        End Function

        Public Function GetLinkedToDataFrameNames(ByVal strDataName As String, ByVal Optional bIncludeSelf As Boolean = True) As List(Of String)
            Dim lstDataFrameNames As List(Of String) = New List(Of String)()
            Dim clsGetDataNames As RFunction = New RFunction()
            clsGetDataNames.SetRCommand(RCodeConstant.DataBookName & "$get_linked_to_data_name")
            clsGetDataNames.AddParameter("from_data_frame", Strings.Chr(34) & strDataName + Strings.Chr(34), iPosition:=0)

            If bIncludeSelf Then
                clsGetDataNames.AddParameter("include_self", "TRUE", iPosition:=2)
            Else
                clsGetDataNames.AddParameter("include_self", "FALSE", iPosition:=2)
            End If

            lstDataFrameNames.AddRange(_scriptRunner.RunInternalScriptGetStringArray(clsGetDataNames.ToScript()))
            Return lstDataFrameNames
        End Function

        Public Function GetPackagesNotInstalled() As String()
            Dim clsPackagesNotInstalled As RFunction = New RFunction()
            clsPackagesNotInstalled.SetRCommand("packages_not_installed")
            Return _scriptRunner.RunInternalScriptGetStringArray(clsPackagesNotInstalled.ToScript())
        End Function

        Public Function GetRSetupScript(ByVal rSetupPath As String) As String
            Dim clsSetWd As RFunction = New RFunction()
            Dim clsSource As RFunction = New RFunction()
            Dim clsCreateIO As ROperator = New ROperator()
            Dim clsDplyrOption As RFunction = New RFunction()
            Dim strScript As String = ""
            clsSetWd.SetRCommand("setwd")
            clsSetWd.AddParameter("dir", Strings.Chr(34) & rSetupPath + Strings.Chr(34))
            clsSource.SetRCommand("source")
            clsSource.AddParameter("file", Strings.Chr(34) & "Rsetup.R" + Strings.Chr(34))
            clsCreateIO.SetOperation("<-")
            clsCreateIO.AddParameter("left", RCodeConstant.DataBookName, iPosition:=0)
            clsCreateIO.AddParameter("right", RCodeConstant.DataBookClassName & "$new()", iPosition:=1)
            clsDplyrOption.SetRCommand("options")
            clsDplyrOption.AddParameter("dplyr.summarise.inform", "FALSE", iPosition:=0)
            strScript = ""
            strScript = strScript & clsSetWd.ToScript() & Environment.NewLine
            strScript = strScript & clsSource.ToScript() & Environment.NewLine
            strScript = strScript & clsCreateIO.ToScript() & Environment.NewLine
            strScript = strScript & clsDplyrOption.ToScript()
            Return strScript
        End Function

        Public Sub SetWorkingDirectory(ByVal rSetupPath As String, ByVal Optional setUpScript As String = "", ByVal Optional iCallType As Integer = 0, ByVal Optional strComment As String = "", ByVal Optional bSeparateThread As Boolean = True)
            Dim iCurrentCallType As Integer

            If setUpScript = "" Then
                setUpScript = GetRSetupScript(rSetupPath)
                iCallType = 0
                strComment = "Setting working directory, sourcing R code and loading R packages"
                bSeparateThread = True
            End If

            For Each strLine As String In setUpScript.Split(Environment.NewLine)

                If strLine.Trim(Constants.vbLf.ToCharArray()).Count() > 0 Then

                    If strLine.Contains(RCodeConstant.DataBookName & "$get_graphs") Then
                        iCurrentCallType = 3
                    Else
                        iCurrentCallType = iCallType
                    End If

                    _scriptRunner.RunScript(strScript:=strLine.Trim(Constants.vbLf.ToCharArray()), iCallType:=iCurrentCallType, strComment:=strComment, bSeparateThread:=bSeparateThread, bSilent:=True)
                End If

                strComment = ""
            Next
        End Sub

        Public Function CompareRVersion(ByVal expectedMajorVersion As String, ByVal expectedMinorVersion As String) As Boolean
            Try
                Dim strMajor As String = _scriptRunner.RunInternalScriptGetString("R.Version()$major")
                Dim strMinor As String = _scriptRunner.RunInternalScriptGetString("R.Version()$minor")
                Dim strRVersionRunning = strMajor & "." & strMinor

                If strMinor.Count() >= 3 Then
                    If Not (strMajor = expectedMajorVersion AndAlso strMinor = expectedMinorVersion) Then
                        Return False
                    End If
                Else
                    Return False
                End If

            Catch ex As Exception
                Return False
            End Try

            Return True
        End Function
    End Class
End Namespace
