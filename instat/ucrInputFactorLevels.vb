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

Imports RDotNet

Public Class ucrInputFactorLevels
    Private WithEvents ucrReceiverFactor As ucrReceiverSingle
    Private clsLevels As New RFunction
    Public strQuotes As String = Chr(34)

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        SetDropDownStyleAsNonEditable()
        clsLevels.SetRCommand("levels")
        bAllowNonConditionValues = True
    End Sub

    Public Sub SetFactorReceiver(ucrNewReceiverFactor As ucrReceiverSingle)
        ucrReceiverFactor = ucrNewReceiverFactor
    End Sub

    Private Sub ucrReceiverFactor_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFactor.ControlValueChanged
        Dim expTemp As SymbolicExpression
        Dim strLevels() As String
        Dim lstLevels As New List(Of String)
        Dim clsFactor As RFunction

        If ucrReceiverFactor.IsEmpty Then
            SetItems()
            Enabled = False
        Else
            ' This is done because of bug in RunInternalScriptGetValue cannot return correct value when R code is multiple lines
            clsFactor = ucrReceiverFactor.GetVariables().Clone()
            clsFactor.RemoveAssignTo()
            clsLevels.AddParameter("x", clsRFunctionParameter:=clsFactor, iPosition:=0)

            expTemp = frmMain.clsRLink.RunInternalScriptGetValue(clsLevels.ToScript(), bSilent:=True)
            If expTemp IsNot Nothing AndAlso expTemp.Type <> Internals.SymbolicExpressionType.Null Then
                Try
                    strLevels = expTemp.AsCharacter.ToArray
                    Enabled = True
                Catch ex As Exception
                    strLevels = Nothing
                    Enabled = False
                End Try
                For i As Integer = 0 To strLevels.Count - 1
                    lstLevels.Add(strQuotes & strLevels(i) & strQuotes)
                Next
                SetItems(lstLevels.ToArray())
            End If
        End If
    End Sub
End Class
