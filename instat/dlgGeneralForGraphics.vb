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
Imports instat.Translations
Public Class dlgGeneralForGraphics
    Private clsRgeom_Function As New RFunction
    Private clsRggplotFunction As New RFunction
    Private clsRaesFunction As New RFunction

    Private bFirstLoad As Boolean = True
    Public clsRSyntax As New RSyntax
    Private Sub dlgGeneralForGraphics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clsrgeom_function.setrcommand(UcrGeomListWithParameters1.cboGeomList.SelectedItem)
        clsraesfunction.setrcommand("aes")
        clsrgeom_function.addparameter("mapping", clsrfunctionparameter:=clsraesfunction)
        ucrBase.clsRsyntax.SetOperatorParameter(True, clsRFunc:=clsrggplotfunction)
        ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsrgeom_function)

        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()

        End If
        autoTranslate(Me)

        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        'setting the base ggplot functions
        ucrBase.clsRsyntax.SetOperation("+")
        clsRggplotFunction.SetRCommand("ggplot")

        'this sets the geoms andthe command to be used
        UcrGeomListWithParameters1.SetGeoms()
        ucrBase.clsRsyntax.clsBaseFunction = UcrGeomListWithParameters1.clsCurrRFunction
    End Sub

    Private Sub SetDefaults()

    End Sub

    Private Sub ReopenDialog()

    End Sub
    Private Sub TestOkEnabled()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub
    Private Sub UcrGeomListWithParameters1_cboGeomList(sender As Object, e As EventArgs) Handles UcrGeomListWithParameters1.cboGeomListIndexChanged
        clsRgeom_Function.SetRCommand(UcrGeomListWithParameters1.cboGeomList.SelectedItem)
    End Sub
End Class