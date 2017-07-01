' Instat-R
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

Public Class ucrGridUnit

    Private bInitialiseControls As Boolean = False
    Public strUnit As String
    Private clsThemeFunction As New RFunction
    Private clsUnit As New RFunction
    Private clsBaseOperator As New ROperator
    Public Sub InitialiseControl()
        'Units
        ucrChkUnits.SetText("Units")
        ucrInputUnits.SetParameter(New RParameter("units"))
        ucrChkUnits.AddParameterPresentCondition(True, "units")
        ucrChkUnits.AddParameterPresentCondition(False, "units", False)
        ucrInputUnits.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctUnits))
        ucrInputUnits.SetDropDownStyleAsNonEditable()

        ucrInputData.SetParameter(New RParameter("data"))

        ucrInputVector.SetParameter(New RParameter("x"))

        ucrChkUnits.AddToLinkedControls(ucrInputUnits, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Centimetres")
        ucrInputUnits.SetLinkedDisplayControl(lblUnits)
        ucrChkUnits.AddToLinkedControls(ucrInputData, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="NULL")
        ucrInputData.SetLinkedDisplayControl(lblData)
        ucrChkUnits.AddToLinkedControls(ucrInputVector, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0)
        ucrInputVector.SetLinkedDisplayControl(lblVector)

    End Sub

    Public Sub SetUnits(strNewAxis As String)
        strUnit = strNewAxis
    End Sub

    Public Sub SetRCodeForControl(strNewUnit As String, clsNewUnit As RFunction, clsNewThemeFunction As RFunction, clsNewBaseOperator As ROperator, Optional bReset As Boolean = False, Optional bCloneIfNeeded As Boolean = False)
        If Not bInitialiseControls Then
            InitialiseControl()
        End If

        SetUnits(strNewUnit)
        clsBaseOperator = clsNewBaseOperator
        clsThemeFunction = clsNewThemeFunction
        clsUnit = clsNewUnit

        ucrChkUnits.SetRCode(clsUnit, bReset, bCloneIfNeeded:=bCloneIfNeeded)
        ucrInputUnits.SetRCode(clsUnit, bReset, bCloneIfNeeded:=bCloneIfNeeded)
        ucrInputData.SetRCode(clsUnit, bReset, bCloneIfNeeded:=bCloneIfNeeded)
        ucrInputVector.SetRCode(clsUnit, bReset, bCloneIfNeeded:=bCloneIfNeeded)
    End Sub

    Private Sub AddRemoveElementLineAxis()
        If ucrChkUnits.Checked Then
            clsThemeFunction.AddParameter(strUnit, clsRFunctionParameter:=clsUnit)
        Else
            clsThemeFunction.RemoveParameterByName(strUnit)
        End If
        AddRemoveTheme()
    End Sub

    Private Sub AddRemoveTheme()
        If clsThemeFunction.iParameterCount > 0 Then
            clsBaseOperator.AddParameter("theme", clsRFunctionParameter:=clsThemeFunction, iPosition:=15)
        Else
            clsBaseOperator.RemoveParameterByName("theme")
        End If
    End Sub

    Private Sub ElementTickAxisLineControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkUnits.ControlValueChanged
        AddRemoveElementLineAxis()
    End Sub

    Public Sub setlabel(strlabel As String)
        grpUnits.Text = strlabel
    End Sub

End Class
