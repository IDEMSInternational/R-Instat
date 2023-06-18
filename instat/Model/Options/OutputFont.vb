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
''' Fonts and Colours for all text within the output screen
''' </summary>
Public Class OutputFont

    Public Shared Property RBracketColour As Color = clsInstatOptionsDefaults.DEFAULTclrScript
    Public Shared Property RBracketFont As Font = clsInstatOptionsDefaults.DEFAULTfntScript
    Public Shared Property RCommentColour As Color = clsInstatOptionsDefaults.DEFAULTclrComment
    Public Shared Property RCommentFont As Font = clsInstatOptionsDefaults.DEFAULTfntComment
    Public Shared Property RConstantStringColour As Color = clsInstatOptionsDefaults.DEFAULTclrScript
    Public Shared Property RConstantStringFont As Font = clsInstatOptionsDefaults.DEFAULTfntScript
    Public Shared Property REndScriptColour As Color = clsInstatOptionsDefaults.DEFAULTclrScript
    Public Shared Property REndScriptFont As Font = clsInstatOptionsDefaults.DEFAULTfntScript
    Public Shared Property REndStatementColour As Color = clsInstatOptionsDefaults.DEFAULTclrScript
    Public Shared Property REndStatementFont As Font = clsInstatOptionsDefaults.DEFAULTfntScript
    Public Shared Property RFunctionNameColour As Color = clsInstatOptionsDefaults.DEFAULTclrScript
    Public Shared Property RFunctionNameFont As Font = clsInstatOptionsDefaults.DEFAULTfntScript
    Public Shared Property RInvalidColour As Color = clsInstatOptionsDefaults.DEFAULTclrScript
    Public Shared Property RInvalidFont As Font = clsInstatOptionsDefaults.DEFAULTfntScript
    Public Shared Property RKeyWordColour As Color = clsInstatOptionsDefaults.DEFAULTclrScript
    Public Shared Property RKeyWordFont As Font = clsInstatOptionsDefaults.DEFAULTfntScript
    Public Shared Property RNewLineColour As Color = clsInstatOptionsDefaults.DEFAULTclrScript
    Public Shared Property RNewLineFont As Font = clsInstatOptionsDefaults.DEFAULTfntScript
    Public Shared Property ROperatorBinaryColour As Color = clsInstatOptionsDefaults.DEFAULTclrScript
    Public Shared Property ROperatorBinaryFont As Font = clsInstatOptionsDefaults.DEFAULTfntScript
    Public Shared Property ROperatorBracketColour As Color = clsInstatOptionsDefaults.DEFAULTclrScript
    Public Shared Property ROperatorBracketFont As Font = clsInstatOptionsDefaults.DEFAULTfntScript
    Public Shared Property ROperatorUnaryLeftColour As Color = clsInstatOptionsDefaults.DEFAULTclrScript
    Public Shared Property ROperatorUnaryLeftFont As Font = clsInstatOptionsDefaults.DEFAULTfntScript
    Public Shared Property ROperatorUnaryRightColour As Color = clsInstatOptionsDefaults.DEFAULTclrScript
    Public Shared Property ROperatorUnaryRightFont As Font = clsInstatOptionsDefaults.DEFAULTfntScript
    Public Shared Property ROutputColour As Color = clsInstatOptionsDefaults.DEFAULTclrOutput
    Public Shared Property ROutputFont As Font = clsInstatOptionsDefaults.DEFAULTfntOutput
    Public Shared Property RPresentationColour As Color = clsInstatOptionsDefaults.DEFAULTclrScript
    Public Shared Property RPresentationFont As Font = clsInstatOptionsDefaults.DEFAULTfntScript
    Public Shared Property RSeparatorColour As Color = clsInstatOptionsDefaults.DEFAULTclrScript
    Public Shared Property RSeparatorFont As Font = clsInstatOptionsDefaults.DEFAULTfntScript
    Public Shared Property RSpaceColour As Color = clsInstatOptionsDefaults.DEFAULTclrScript
    Public Shared Property RSpaceFont As Font = clsInstatOptionsDefaults.DEFAULTfntScript
    Public Shared Property RSyntacticNameColour As Color = clsInstatOptionsDefaults.DEFAULTclrScript
    Public Shared Property RSyntacticNameFont As Font = clsInstatOptionsDefaults.DEFAULTfntScript
    ''' <summary>
    ''' Gets Colour for text depending on element of R-Script
    ''' </summary>
    ''' <param name="scriptType"></param>
    ''' <returns></returns>
    Public Shared Function GetColourForScriptType(scriptType As clsRToken.typToken) As Color
        Select Case scriptType
            Case clsRToken.typToken.RSyntacticName
                Return RSyntacticNameColour
            Case clsRToken.typToken.RFunctionName
                Return RFunctionNameColour
            Case clsRToken.typToken.RKeyWord
                Return RKeyWordColour
            Case clsRToken.typToken.RConstantString
                Return RConstantStringColour
            Case clsRToken.typToken.RComment
                Return RCommentColour
            Case clsRToken.typToken.RSpace
                Return RSpaceColour
            Case clsRToken.typToken.RBracket
                Return RBracketColour
            Case clsRToken.typToken.RSeparator
                Return RSeparatorColour
            Case clsRToken.typToken.REndStatement
                Return REndStatementColour
            Case clsRToken.typToken.REndScript
                Return REndScriptColour
            Case clsRToken.typToken.RNewLine
                Return RNewLineColour
            Case clsRToken.typToken.ROperatorUnaryLeft
                Return ROperatorUnaryLeftColour
            Case clsRToken.typToken.ROperatorUnaryRight
                Return ROperatorUnaryRightColour
            Case clsRToken.typToken.ROperatorBinary
                Return ROperatorBinaryColour
            Case clsRToken.typToken.ROperatorBracket
                Return ROperatorBracketColour
            Case clsRToken.typToken.RPresentation
                Return RPresentationColour
            Case clsRToken.typToken.RInvalid
                Return RInvalidColour
            Case Else
                Return Color.Black
        End Select
    End Function

    ''' <summary>
    ''' Gets Font for text depending on element of R-Script
    ''' </summary>
    ''' <param name="scriptType"></param>
    ''' <returns></returns>
    Public Shared Function GetFontForScriptType(scriptType As clsRToken.typToken) As Font
        Select Case scriptType
            Case clsRToken.typToken.RSyntacticName
                Return RSyntacticNameFont
            Case clsRToken.typToken.RFunctionName
                Return RFunctionNameFont
            Case clsRToken.typToken.RKeyWord
                Return RKeyWordFont
            Case clsRToken.typToken.RConstantString
                Return RConstantStringFont
            Case clsRToken.typToken.RComment
                Return RCommentFont
            Case clsRToken.typToken.RSpace
                Return RSpaceFont
            Case clsRToken.typToken.RBracket
                Return RBracketFont
            Case clsRToken.typToken.RSeparator
                Return RSeparatorFont
            Case clsRToken.typToken.REndStatement
                Return REndStatementFont
            Case clsRToken.typToken.REndScript
                Return REndScriptFont
            Case clsRToken.typToken.RNewLine
                Return RNewLineFont
            Case clsRToken.typToken.ROperatorUnaryLeft
                Return ROperatorUnaryLeftFont
            Case clsRToken.typToken.ROperatorUnaryRight
                Return ROperatorUnaryRightFont
            Case clsRToken.typToken.ROperatorBinary
                Return ROperatorBinaryFont
            Case clsRToken.typToken.ROperatorBracket
                Return ROperatorBracketFont
            Case clsRToken.typToken.RPresentation
                Return RPresentationFont
            Case clsRToken.typToken.RInvalid
                Return RInvalidFont
            Case Else
                Return New Font("Ariel", 12, FontStyle.Bold)
        End Select
    End Function

End Class