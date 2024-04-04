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

Imports RInsightF461

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
    Public Shared Function GetColourForScriptType(scriptType As RToken.TokenTypes) As Color
        Select Case scriptType
            Case RToken.TokenTypes.RSyntacticName
                Return RSyntacticNameColour
            Case RToken.TokenTypes.RFunctionName
                Return RFunctionNameColour
            Case RToken.TokenTypes.RKeyWord
                Return RKeyWordColour
            Case RToken.TokenTypes.RConstantString
                Return RConstantStringColour
            Case RToken.TokenTypes.RComment
                Return RCommentColour
            Case RToken.TokenTypes.RSpace
                Return RSpaceColour
            Case RToken.TokenTypes.RBracket
                Return RBracketColour
            Case RToken.TokenTypes.RSeparator
                Return RSeparatorColour
            Case RToken.TokenTypes.REndStatement
                Return REndStatementColour
            Case RToken.TokenTypes.RNewLine
                Return RNewLineColour
            Case RToken.TokenTypes.ROperatorUnaryLeft
                Return ROperatorUnaryLeftColour
            Case RToken.TokenTypes.ROperatorUnaryRight
                Return ROperatorUnaryRightColour
            Case RToken.TokenTypes.ROperatorBinary
                Return ROperatorBinaryColour
            Case RToken.TokenTypes.ROperatorBracket
                Return ROperatorBracketColour
            Case RToken.TokenTypes.RPresentation
                Return RPresentationColour
            Case Else
                Return Color.Black
        End Select
    End Function

    ''' <summary>
    ''' Gets Font for text depending on element of R-Script
    ''' </summary>
    ''' <param name="scriptType"></param>
    ''' <returns></returns>
    Public Shared Function GetFontForScriptType(scriptType As RToken.TokenTypes) As Font
        Select Case scriptType
            Case RToken.TokenTypes.RSyntacticName
                Return RSyntacticNameFont
            Case RToken.TokenTypes.RFunctionName
                Return RFunctionNameFont
            Case RToken.TokenTypes.RKeyWord
                Return RKeyWordFont
            Case RToken.TokenTypes.RConstantString
                Return RConstantStringFont
            Case RToken.TokenTypes.RComment
                Return RCommentFont
            Case RToken.TokenTypes.RSpace
                Return RSpaceFont
            Case RToken.TokenTypes.RBracket
                Return RBracketFont
            Case RToken.TokenTypes.RSeparator
                Return RSeparatorFont
            Case RToken.TokenTypes.REndStatement
                Return REndStatementFont
            Case RToken.TokenTypes.RNewLine
                Return RNewLineFont
            Case RToken.TokenTypes.ROperatorUnaryLeft
                Return ROperatorUnaryLeftFont
            Case RToken.TokenTypes.ROperatorUnaryRight
                Return ROperatorUnaryRightFont
            Case RToken.TokenTypes.ROperatorBinary
                Return ROperatorBinaryFont
            Case RToken.TokenTypes.ROperatorBracket
                Return ROperatorBracketFont
            Case RToken.TokenTypes.RPresentation
                Return RPresentationFont
            Case Else
                Return New Font("Ariel", 12, FontStyle.Bold)
        End Select
    End Function

End Class