﻿' R- Instat
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
Imports System.IO
Imports RScript

''' <summary>
''' Output element for an R script. 
''' Must contain an R script. The output itself is optional depending on whether the script produces the an output or not.
''' </summary>
Public Class clsOutputElement
    'holds the id given to the output element
    Private _id As Integer

    'holds the R script that produced the output
    Private _strScript As String

    'holds the output type; Text, Image, HTML etc
    Private _outputType As OutputType

    'holds the file paths to outputs or the a string output
    Private _strOutput As String


    ''' <summary>
    ''' ID used for ordering elements
    ''' </summary>
    ''' <returns></returns>
    Public Property Id() As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public ReadOnly Property Script As String
        Get
            Return _strScript
        End Get
    End Property

    ''' <summary>
    ''' Gets the type of output
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property OutputType() As OutputType
        Get
            Return _outputType
        End Get
    End Property

    Public ReadOnly Property Output As String
        Get
            Return _strOutput
        End Get
    End Property

    Public Function Clone() As clsOutputElement
        Return Me.MemberwiseClone
    End Function

    ''' <summary>
    ''' Sets the contents of the output element
    ''' </summary>
    ''' <param name="strScript">R script producing the output</param>
    ''' <param name="outputType">Type of output</param>
    ''' <param name="strOutput">Output produced, can be file name or string value</param>
    Public Sub SetContent(strScript As String, outputType As OutputType, Optional strOutput As String = "")
        _strScript = strScript
        _outputType = outputType
        _strOutput = strOutput
    End Sub

    ''' <summary>
    ''' Gets formatted R Script, split into R Script Elements
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property FormattedRScript As List(Of clsRScriptElement)
        Get
            Dim _lstRScriptElements As New List(Of clsRScriptElement)
            Try
                Dim rScript As New clsRScript(_strScript)
                Dim lstTokens As List(Of clsRToken) = rScript.GetLstTokens(rScript.GetLstLexemes(_strScript)) 'rScript.lstTokens
                If lstTokens IsNot Nothing Then
                    For Each rToken In lstTokens
                        _lstRScriptElements.Add(New clsRScriptElement With
                    {
                        .Text = rToken.strTxt,
                        .Type = rToken.enuToken
                    })
                    Next
                End If
            Catch ex As Exception
                MessageBox.Show("Unable to parse the following R Script: '" & _strScript & "'." &
                            Environment.NewLine & ex.Message,
                            "Developer Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            End Try
            Return _lstRScriptElements
        End Get
    End Property

    Public ReadOnly Property IsFile As Boolean
        Get
            Return File.Exists(Output)
        End Get
    End Property


End Class