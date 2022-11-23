' R- Instat
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
Imports RScript
''' <summary>
''' Output element for a r command, the output element could be just the script or the script with
''' an image or output text
''' </summary>
Public Class clsOutputElement
    Private _id As Integer
    'hold the script elements that form the R script that produced the output
    Private _lstRScriptElements As New List(Of clsRScriptElement)

    Private _outputType As OutputType

    'todo. deprecate this list with _lstTextOutput ?
    Private _lstStringOutput As New List(Of String)

    'holds the file paths to the text outputs
    Private _lstTextOutput As New List(Of String)

    'holds the file paths to the image outputs
    Private _lstImageOutput As New List(Of String)

    'holds the file paths to the html outputs
    Private _lstHtmlOutput As New List(Of String)

    ''' <summary>
    ''' Holds formated R Script, split into R Script Elements
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property FormattedRScript As List(Of clsRScriptElement)
        Get
            Return _lstRScriptElements
        End Get
    End Property

    ''' <summary>
    ''' ID used for ordering elements
    ''' </summary>
    ''' <returns></returns>
    Public Property Id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public ReadOnly Property TextOutput As String
        Get
            Return _lstTextOutput.FirstOrDefault()
        End Get
    End Property

    ''' <summary>
    ''' Holds image file path if outputType is image file
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property ImageOutput As String
        Get
            Return _lstImageOutput.FirstOrDefault()
        End Get
    End Property

    Public ReadOnly Property HtmlOutput As String
        Get
            Return _lstHtmlOutput.FirstOrDefault()
        End Get
    End Property

    ''' <summary>
    ''' Defines the type of output
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property OutputType() As OutputType
        Get
            Return _outputType
        End Get
    End Property

    ''' <summary>
    ''' Holds the string output. Not the R Script
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property StringOutput As String
        Get
            Return _lstStringOutput.FirstOrDefault()
        End Get
    End Property

    'this does a shallow clone
    'todo. add a deep clone implementation
    Public Function Clone() As clsOutputElement
        Return Me.MemberwiseClone
    End Function

    Public Sub AddTextOutput(strFileName As String, script As List(Of clsRScriptElement))
        _lstTextOutput.Add(strFileName)
        _lstRScriptElements = script
        _outputType = OutputType.TextOutput
    End Sub

    ''' <summary>
    ''' When adding Output the script must always be added too
    ''' </summary>
    ''' <param name="strFileName"></param>
    ''' <param name="script"></param>
    Public Sub AddImageOutput(strFileName As String, script As List(Of clsRScriptElement))
        _lstImageOutput.Add(strFileName)
        _lstRScriptElements = script
        _outputType = OutputType.ImageOutput
    End Sub

    Public Sub AddHtmlOutput(strFileName As String, script As List(Of clsRScriptElement))
        _lstHtmlOutput.Add(strFileName)
        _lstRScriptElements = script
        _outputType = OutputType.HtmlOutput
    End Sub

    ''' <summary>
    ''' Adds script and passes through RScript to split into elements
    ''' </summary>
    ''' <param name="strScript"></param>
    Public Sub AddScript(strScript As String)
        Try
            Dim rScript As New clsRScript(strScript)
            Dim lstTokens As List(Of clsRToken) = rScript.GetLstTokens(rScript.GetLstLexemes(strScript)) 'rScript.lstTokens
            If lstTokens IsNot Nothing Then
                For Each rToken In lstTokens
                    _lstRScriptElements.Add(New clsRScriptElement With
                    {
                        .Text = rToken.strTxt,
                        .Type = rToken.enuToken
                    })
                Next
                _outputType = OutputType.Script
            End If
        Catch ex As Exception
            MessageBox.Show("Unable to parse the following R Script: '" & strScript & "'." &
                            Environment.NewLine & ex.Message,
                            "Developer Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' When adding Output the script must always be added too
    ''' </summary>
    ''' <param name="strOutput"></param>
    Public Sub AddStringOutput(strOutput As String, script As List(Of clsRScriptElement))
        _lstStringOutput.Add(strOutput)
        _lstRScriptElements = script
        _outputType = OutputType.TextOutput
    End Sub

End Class