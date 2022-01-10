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
    Private _formattedRScript As List(Of clsRScriptElement)
    Private _id As Integer
    Private _lstBmpImage As List(Of Bitmap)
    Private _lstStringOutput As List(Of String)
    Private _outputType As OutputType

    ''' <summary>
    ''' Constructor
    ''' </summary>
    Public Sub New()
        _formattedRScript = New List(Of clsRScriptElement)
        _lstStringOutput = New List(Of String)
        _lstBmpImage = New List(Of Bitmap)
    End Sub

    ''' <summary>
    ''' Holds formated R Script, split into R Script Elements
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property FormatedRScript As List(Of clsRScriptElement)
        Get
            Return _formattedRScript
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

    ''' <summary>
    ''' Holds image if outputType is image
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property ImageOutput As Bitmap
        Get
            Return _lstBmpImage.FirstOrDefault()
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

    Public Function Clone() As clsOutputElement
        Return Me.MemberwiseClone
    End Function

    ''' <summary>
    ''' When adding Output the script must always be added too
    ''' </summary>
    ''' <param name="image"></param>
    Public Sub AddImageOutputFromR(image As Bitmap, script As List(Of clsRScriptElement))
        _lstBmpImage.Add(image)
        _formattedRScript = script
        _outputType = OutputType.ImageOutput
    End Sub

    ''' <summary>
    ''' Adds script and passes through RScript to split into elements
    ''' </summary>
    ''' <param name="strScript"></param>
    Public Sub AddScript(strScript As String)
        Dim rScript As New clsRScript(strScript)
        For Each rToken In rScript.GetLstTokens(rScript.GetLstLexemes(strScript)) 'rScript.lstTokens
            _formattedRScript.Add(New clsRScriptElement With
                {
                    .Text = rToken.strTxt,
                    .Type = rToken.enuToken
                })
        Next
        _outputType = OutputType.Script
    End Sub

    ''' <summary>
    ''' When adding Output the script must always be added too
    ''' </summary>
    ''' <param name="strOutput"></param>
    Public Sub AddStringOutputFromR(strOutput As String, script As List(Of clsRScriptElement))
        _lstStringOutput.Add(strOutput)
        _formattedRScript = script
        _outputType = OutputType.TextOutput
    End Sub

End Class