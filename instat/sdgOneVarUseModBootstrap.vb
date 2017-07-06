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

Imports instat.Translations

Public Class sdgOneVarUseModBootstrap
    Public bControlsInitialised As Boolean = False
    Public clsOneVarRBootFunction, clsOneVarQuantileFunction As New RFunction
    Public bfirstload As Boolean = True

    Private Sub sdgOneVarUseModBootstrap(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        ucrNudIterations.SetParameter(New RParameter("niter", 1))
        ucrNudIterations.SetMinMax(1, 10001)
        ucrNudIterations.SetRDefault(1001)
        ucrNudIterations.Increment = 100

        ucrNudCI.SetParameter(New RParameter("CI.level", 1))
        ucrNudCI.SetMinMax(0, 1)
        ucrNudCI.Increment = 0.05

        ucrChkParametric.SetParameter(New RParameter("bootmethod", 2), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "param" & Chr(34), strNewValueIfUnchecked:=Chr(34) & "nonparam" & Chr(34))
        ucrChkParametric.SetText("Parametric")
        ucrChkParametric.SetRDefault(Chr(34) & "param" & Chr(34))
        bControlsInitialised = True
    End Sub

    Public Sub SetRFunction(clsNewRbootFunction As RFunction, clsNewQuantileFunction As RFunction, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsOneVarRBootFunction = clsNewRbootFunction
        clsOneVarQuantileFunction = clsNewQuantileFunction

        'Setting Rcode for the sub dialog
        ucrChkParametric.SetRCode(clsOneVarRBootFunction, bReset)
        ucrNudIterations.SetRCode(clsOneVarRBootFunction, bReset)
        ucrNudCI.SetRCode(clsOneVarQuantileFunction, bReset)
    End Sub
End Class