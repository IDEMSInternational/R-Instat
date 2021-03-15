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
Public Class sdgExtremesMethod
    Private clsFevdFunction As New RFunction
    Public bControlsInitialised As Boolean = False
    Public Sub InitialiseControls()
        ucrPanelExtreme.SetParameter(New RParameter("method", 2))
        ucrPanelExtreme.AddRadioButton(rdoMLE, Chr(34) & "MLE" & Chr(34))
        ucrPanelExtreme.AddRadioButton(rdoBayesian, Chr(34) & "Bayesian" & Chr(34))
        ucrPanelExtreme.AddRadioButton(rdoGMLE, Chr(34) & "GMLE" & Chr(34))
        ucrPanelExtreme.AddRadioButton(rdoLmoments, Chr(34) & "Lmoments" & Chr(34))
        bControlsInitialised = True
    End Sub

    Public Sub SetRCode(clsNewFevdFunction As RFunction)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsFevdFunction = clsNewFevdFunction
        ucrPanelExtreme.SetRCode(clsFevdFunction)
    End Sub
End Class