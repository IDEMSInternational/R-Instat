' Instat+R
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

Public Class RInterface
    ' R interface class. Each instance of the class has its own REngine instance
    Dim strClimateObjectPath As String = "C:\\ClimateObject\\R"
    Dim strClimateObject As String = "ClimateObject"
    Dim strInstatObjectPath As String = "static/InstatObject/R" 'path to the Instat object
    Public strInstatDataObject As String = "InstatDataObject"
    Public clsEngine As REngine
    Dim txtOutput As New TextBox
    Dim txtLog As New TextBox
    Public bLog As Boolean = False
    Public bOutput As Boolean = False
    Public bClimateObjectExists As Boolean = False
    Public bInstatObjectExists As Boolean = False
    Public bClimsoftLinkExists As Boolean = False

    Public Sub New(Optional bWithInstatObj As Boolean = False, Optional bWithClimsoft As Boolean = False)
    End Sub

    Public Sub SetOutput(tempOutput As TextBox)
        txtOutput = tempOutput
        bOutput = True
    End Sub

    Public Sub SetLog(tempLog As TextBox)
        txtLog = tempLog
        bLog = True
    End Sub

    Public Sub FillComboDataFrames(cboDataFrames As ComboBox)
        Dim lstAvailableDataFrames As GenericVector
        Dim i As Integer

        If bInstatObjectExists Then
            lstAvailableDataFrames = clsEngine.Evaluate(strInstatDataObject & "$get_data_names()").AsList
            cboDataFrames.Items.Clear()
            For i = 0 To lstAvailableDataFrames.Length - 1
                cboDataFrames.Items.Add(lstAvailableDataFrames.AsCharacter(i))
            Next
        End If
        cboDataFrames.Text = frmEditor.grdData.CurrentWorksheet.Name
    End Sub

    Public Sub RunScript(strScript As String, Optional bReturnOutput As Integer = 0)
        Dim strCapturedScript As String
        Dim temp As RDotNet.SymbolicExpression
        Dim strTemp As String
        Dim strOutput As String
        strOutput = ""
        Try
            If bLog Then
                txtLog.Text = txtLog.Text & strScript & vbCrLf
            End If
            strOutput = "> " & strScript & vbCrLf
            If bReturnOutput = 0 Then
                clsEngine.Evaluate(strScript)
            ElseIf bReturnOutput = 1 Then
                temp = clsEngine.Evaluate(strScript)
                strTemp = String.Join(vbCrLf, temp.AsCharacter())
                strOutput = strOutput & strTemp & vbCrLf
            Else
                strCapturedScript = "capture.output(" & strScript & ")"
                temp = clsEngine.Evaluate(strCapturedScript)
                strTemp = String.Join(vbCrLf, temp.AsCharacter())
                strOutput = strOutput & strTemp & vbCrLf
            End If
            If bOutput Then
                txtOutput.Text = txtOutput.Text & strOutput
            End If
        Catch
            MsgBox(strOutput)
        End Try
    End Sub

    Public Function GetData(strLabel As String) As DataFrame

        Me.clsEngine.Evaluate("temp<-" & strLabel).AsDataFrame()
        Return Me.clsEngine.GetSymbol("temp").AsDataFrame()

    End Function

    Public Function GetVariables(strLabel As String) As CharacterVector

        Return Me.clsEngine.Evaluate(strLabel).AsCharacter

    End Function

    Public Function GetVar(strLabel As String) As CharacterVector

        Try
            Return Me.clsEngine.Evaluate(strLabel).AsCharacter()
        Catch
            MsgBox(strLabel)
            Return Nothing
        End Try

    End Function

    Public Sub climateObject() 'creates an instance of the climate object
        If Not bClimateObjectExists Then
            RunScript("setwd('" & strClimateObjectPath & "')")
            RunScript("source(" & Chr(34) & "SourcingScript.R" & Chr(34) & ")")
            MsgBox("Need to fix the code here to get data from the data object")
            RunScript("ClimateObject<-climate$new(data_tables=list(data=data))")
            bClimateObjectExists = True
        End If
    End Sub

    Public Sub RSetup()
        'run script to load libraries
        RunScript("setwd('" & strInstatObjectPath & "')") 'This is bad the wd should be flexible and not automatically set to the instat object directory 
        RunScript("source(" & Chr(34) & "data_object.R" & Chr(34) & ")")
        RunScript("source(" & Chr(34) & "instat_object.R" & Chr(34) & ")")
        RunScript("source(" & Chr(34) & "Rsetup.R" & Chr(34) & ")")
    End Sub

End Class
