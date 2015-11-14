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
Imports System.IO
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Public Class RInterface
    ' R interface class. Each instance of the class has its own REngine instanc
    Dim climateObjectPath As String = "C:\\ClimateObject\\R"
    Dim InstatObjectPath As String = "C:\\InstatObject\\R" 'path to the Instat object
    Dim clsEngine As REngine
    Dim txtOutput As New TextBox
    Dim txtLog As New TextBox
    Dim climateObjectExists As Boolean = False
    Dim InstatObjectExist As Boolean = False

    Public Sub New()
        Me.clsEngine = REngine.GetInstance()
        Me.clsEngine.Initialize()
    End Sub

    Public Sub SetOutput(tempOutput As TextBox)
        txtOutput = tempOutput
    End Sub

    Public Sub SetLog(tempLog As TextBox)
        txtLog = tempLog
    End Sub

    Public Sub LoadData()
        'Preparing the cleaning process
    End Sub

    Public Sub RunScript(strScript As String, Optional bReturnOutput As Integer = 0)
        Dim strCapturedScript As String
        Dim temp As RDotNet.SymbolicExpression
        Dim strTemp As String
        txtLog.Text = txtLog.Text & strScript & vbCrLf
        txtOutput.Text = txtOutput.Text & "> " & strScript & vbCrLf
        If bReturnOutput = 0 Then
            clsEngine.Evaluate(strScript)
        ElseIf bReturnOutput = 1 Then
            temp = clsEngine.Evaluate(strScript)
            strTemp = String.Join(vbCrLf, temp.AsCharacter())
            txtOutput.Text = txtOutput.Text & strTemp & vbCrLf
        Else
            strCapturedScript = "capture.output(" & strScript & ")"
            temp = clsEngine.Evaluate(strCapturedScript)
            strTemp = String.Join(vbCrLf, temp.AsCharacter())
            txtOutput.Text = txtOutput.Text & "> " & strTemp & vbCrLf
        End If
    End Sub

    Public Function GetData(strLabel As String) As DataFrame
        Me.clsEngine.Evaluate("temp<-" & strLabel).AsDataFrame()
        Return Me.clsEngine.GetSymbol("temp").AsDataFrame()

    End Function

    Public Function GetVariables(strLabel As String) As CharacterVector

        Return Me.clsEngine.Evaluate(strLabel).AsCharacter

    End Function

    Public Sub climateObject() 'creates an instance of the climate object
        If Not climateObjectExists Then
            Me.clsEngine.Evaluate("setwd('" & climateObjectPath & "')")
            Me.clsEngine.Evaluate("source(" & Chr(34) & "SourcingScript.R" & Chr(34) & ")")
            Me.clsEngine.Evaluate("climate_obj<-climate$new(data_tables=list(data=data))")
            climateObjectExists = True
        End If
    End Sub

    Public Sub InstatObject() 'creates an instance of the instat object
        If Not InstatObjectExist Then
            clsEngine.Evaluate("setwd('" & InstatObjectPath & "')")
            clsEngine.Evaluate("source(" & Chr(34) & "data_object.R" & Chr(34) & ")")
            clsEngine.Evaluate("source(" & Chr(34) & "instat_object.R" & Chr(34) & ")")
            'clsEngine.Evaluate("data_instat_obj<-instat_obj$new(data_tables=list(curr_data_obj=data))")
            InstatObjectExist = True
        End If
    End Sub
    'Creation of the Instat object.
    Public Function getInstatObject(strLabel As String) As Tuple(Of DataFrame, DataFrame, DataFrame)
        Dim temp_data, temp_metadata, temp_variables As DataFrame
        clsEngine.Evaluate("temp_data<-" & strLabel).AsDataFrame()
        clsEngine.Evaluate("data_instat_obj<-instat_obj$new(data_tables=list(curr_data_obj=temp_data))")
        temp_data = clsEngine.Evaluate("data_temp<-data_instat_obj$data_objects$curr_data_obj$data").AsDataFrame()
        clsEngine.Evaluate("data_variables<-data_instat_obj$data_objects$curr_data_obj$meta_data$columns").AsDataFrame()
        clsEngine.Evaluate("library(plyr);data_variables$Type<-sapply(temp_data,class)").AsDataFrame()
        temp_variables = clsEngine.Evaluate("data_variables").AsDataFrame()
        clsEngine.Evaluate("meta_data_edit<-data_instat_obj$data_objects$curr_data_obj$meta_data[-which(names(data_instat_obj$data_objects$curr_data_obj$meta_data)=='columns')]")
        clsEngine.Evaluate("x<-data.frame(meta_data_item = names(meta_data_edit))").AsDataFrame
        clsEngine.Evaluate("x$meta_data_value = meta_data_edit")
        temp_metadata = clsEngine.Evaluate("x").AsDataFrame()
        Return New Tuple(Of DataFrame, DataFrame, DataFrame)(temp_data, temp_metadata, temp_variables)
    End Function
End Class