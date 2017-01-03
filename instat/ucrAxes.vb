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

Public Class ucrAxes
    Public bIsX As Boolean
    Public clsRsyntax As New RSyntax
    Public clsRggplotFunction As New RFunction
    Public clsTitleFunction As New RFunction
    Public clsScalecontinuousFunction As New RFunction
    Public clsSeqFunction As New RFunction
    Public strAxis As String
    Public bFirstLoad As Boolean = True

    Private Sub ucrAxes_Load(sender As Object, e As EventArgs) Handles Me.Load
        If bFirstLoad Then
            SetDefaults()
            InitialiseControl()
            bFirstLoad = False
        End If
    End Sub

    Private Sub SetDefaults()
        rdoTitleAuto.Checked = True
        rdoScalesAuto.Checked = True
        rdoTickMarkersAuto.Checked = True
        TitleDefaults()
        ScalesDefaults()
        TickMarkersDefaults()
        ucrTickMarkers.SetName("Interval")
        TitleFunction()
        ucrOverwriteTitle.SetName("")
        nudTickMarkersNoOfDecimalPlaces.Value = 0
        nudFrom.Value = 0
        nudTo.Value = 0
        nudInStepsOf.Value = 0
        nudLowerLimit.Value = 0
        nudUpperLimit.Value = 0
        nudScalesNoOfDecimalPlaces.Value = 0
    End Sub

    Public Sub Reset()
        SetDefaults()
    End Sub

    Private Sub InitialiseControl()
        ucrTickMarkers.cboInput.Items.Add("Interval")
        ucrTickMarkers.cboInput.Items.Add("Specific Values")
        TitleDefaults()
        ScalesDefaults()
        TickMarkersDefaults()
    End Sub

    Private Sub TitleDefaults()
        If rdoTitleAuto.Checked Then
            chkDisplayTitle.Visible = False
            chkOverwriteTitle.Visible = False
            ucrOverwriteTitle.Visible = False
        ElseIf rdoTitleCustom.Checked Then
            chkDisplayTitle.Visible = True
            chkDisplayTitle.Checked = True
            chkOverwriteTitle.Visible = True
            chkOverwriteTitle.Checked = False
        End If
    End Sub

    Private Sub ScalesDefaults()
        If rdoScalesAuto.Checked Then
            lblLowerLimit.Visible = False
            nudLowerLimit.Visible = False
            lblUpperLimit.Visible = False
            nudUpperLimit.Visible = False
            lblScalesNoDecimalPlaces.Visible = False
            nudScalesNoOfDecimalPlaces.Visible = False
        ElseIf rdoScalesCustom.Checked Then
            lblLowerLimit.Visible = True
            nudLowerLimit.Visible = True
            lblUpperLimit.Visible = True
            nudUpperLimit.Visible = True
            lblScalesNoDecimalPlaces.Visible = True
            nudScalesNoOfDecimalPlaces.Visible = True
        End If
    End Sub

    Private Sub TickMarkersDefaults()
        If rdoTickMarkersAuto.Checked Then
            ucrTickMarkers.Visible = False
            lblFrom.Visible = False
            nudFrom.Visible = False
            lblTo.Visible = False
            nudTo.Visible = False
            lblInStepsOf.Visible = False
            nudInStepsOf.Visible = False
            lblTickMarkersNoOfDecimalPlaces.Visible = False
            nudTickMarkersNoOfDecimalPlaces.Visible = False
            ucrSpecificValues.Visible = False
        ElseIf rdoTickMarkersCustom.Checked Then
            ucrTickMarkers.Visible = True
            lblFrom.Visible = True
            nudFrom.Visible = True
            lblTo.Visible = True
            nudTo.Visible = True
            lblInStepsOf.Visible = True
            nudInStepsOf.Visible = True
            lblTickMarkersNoOfDecimalPlaces.Visible = True
            nudTickMarkersNoOfDecimalPlaces.Visible = True
            ucrSpecificValues.Visible = False
        End If
    End Sub

    Public Sub SetXorY(bIsXAxis As Boolean)
        If bIsXAxis = True Then
            bIsX = True
            strAxis = "x"
            clsTitleFunction.SetRCommand("xlab")
            clsScalecontinuousFunction.SetRCommand("scale_" & strAxis & "_continuous")

            ' put scale_x_continuous function here
        ElseIf bIsXAxis = False Then
            bIsX = False
            strAxis = "y"
            clsTitleFunction.SetRCommand("ylab")
            clsScalecontinuousFunction.SetRCommand("scale_" & strAxis & "_continuous")
            ' put scale_y_continuous function here

        End If
    End Sub

    Public Sub SetRsyntaxAxis(clsRsyntaxAxis As RSyntax)
        clsRsyntax = clsRsyntaxAxis
    End Sub

    Private Sub TitleFunction()
        If rdoTitleCustom.Checked AndAlso chkDisplayTitle.Checked Then
            If chkOverwriteTitle.Checked AndAlso Not ucrOverwriteTitle.IsEmpty Then
                clsTitleFunction.AddParameter("label", Chr(34) & ucrOverwriteTitle.GetText & Chr(34))
                clsRsyntax.AddOperatorParameter(strAxis & "axistitle", clsRFunc:=clsTitleFunction)
            Else
                clsRsyntax.RemoveOperatorParameter(strAxis & "axistitle")
            End If
        Else
            clsTitleFunction.AddParameter("label", Chr(34) & "" & Chr(34))
            clsRsyntax.AddOperatorParameter(strAxis & "axistitle", clsRFunc:=clsTitleFunction)
        End If
    End Sub

    Private Sub ScalesFunction()
        If rdoScalesCustom.Checked Then
            clsScalecontinuousFunction.AddParameter("limits", "c(" & nudLowerLimit.Value & "," & nudUpperLimit.Value & ")")
            clsRsyntax.AddOperatorParameter("scale_" & strAxis & "_continuous", clsRFunc:=clsScalecontinuousFunction)
        Else
            clsRsyntax.RemoveOperatorParameter("scale_" & strAxis & "_continuous")
        End If
    End Sub

    Private Sub ucrOverwriteTitle_NameChanged() Handles ucrOverwriteTitle.NameChanged
        If rdoTitleCustom.Checked Then
            TitleFunction()
        End If
    End Sub

    Private Sub chkOverwriteTitle_CheckedChanged(sender As Object, e As EventArgs) Handles chkOverwriteTitle.CheckedChanged
        If rdoTitleCustom.Checked AndAlso chkOverwriteTitle.Checked Then
            ucrOverwriteTitle.Visible = True
        Else
            ucrOverwriteTitle.Visible = False
        End If
        TitleFunction()
    End Sub

    Private Sub chkDisplayTitle_CheckedChanged(sender As Object, e As EventArgs) Handles chkDisplayTitle.CheckedChanged
        If rdoTitleCustom.Checked AndAlso chkDisplayTitle.Checked Then
            chkOverwriteTitle.Visible = True
            If chkOverwriteTitle.Checked Then
                ucrOverwriteTitle.Visible = True
            Else
                ucrOverwriteTitle.Visible = False
            End If
        Else
            chkOverwriteTitle.Visible = False
            ucrOverwriteTitle.Visible = False
        End If
        TitleFunction()
    End Sub

    Private Sub rdoTitleCustom_CheckedChanged(sender As Object, e As EventArgs) Handles rdoTitleCustom.CheckedChanged
        TitleDefaults()
    End Sub

    Private Sub rdoTitleAuto_CheckedChanged(sender As Object, e As EventArgs) Handles rdoTitleAuto.CheckedChanged
        TitleDefaults()
    End Sub

    Private Sub rdoScalesCustom_CheckedChanged(sender As Object, e As EventArgs) Handles rdoScalesCustom.CheckedChanged
        ScalesDefaults()
    End Sub

    Private Sub rdoScalesAuto_CheckedChanged(sender As Object, e As EventArgs) Handles rdoScalesAuto.CheckedChanged
        ScalesDefaults()
    End Sub

    Private Sub rdoTickMarkersAuto_CheckedChanged(sender As Object, e As EventArgs) Handles rdoTickMarkersAuto.CheckedChanged
        TickMarkersDefaults()
    End Sub

    Private Sub rdoTickMarkersCustom_CheckedChanged(sender As Object, e As EventArgs) Handles rdoTickMarkersCustom.CheckedChanged
        TickMarkersDefaults()
    End Sub

    Private Sub nudLowerLimit_TextChanged(sender As Object, e As EventArgs) Handles nudLowerLimit.TextChanged, nudUpperLimit.TextChanged
        ScalesFunction()
    End Sub
    Private Sub nudScalesNoOfDecimalPlaces_TextChanged(sender As Object, e As EventArgs) Handles nudScalesNoOfDecimalPlaces.TextChanged
        nudUpperLimit.DecimalPlaces = nudScalesNoOfDecimalPlaces.Value
        nudLowerLimit.DecimalPlaces = nudScalesNoOfDecimalPlaces.Value
    End Sub

    Private Sub nudTickMarkersNoOfDecimalPlaces_TextChanged(sender As Object, e As EventArgs) Handles nudTickMarkersNoOfDecimalPlaces.TextChanged
        nudFrom.DecimalPlaces = nudTickMarkersNoOfDecimalPlaces.Value
        nudTo.DecimalPlaces = nudTickMarkersNoOfDecimalPlaces.Value
        nudInStepsOf.DecimalPlaces = nudTickMarkersNoOfDecimalPlaces.Value
    End Sub

    Private Sub ucrTickMarkers_NameChanged() Handles ucrTickMarkers.NameChanged
        If rdoTickMarkersCustom.Checked Then
            If ucrTickMarkers.cboInput.SelectedItem = "Interval" Then
                clsSeqFunction.SetRCommand("seq")
                clsScalecontinuousFunction.AddParameter("breaks", clsRFunctionParameter:=clsSeqFunction)

                ucrSpecificValues.Visible = False
                lblFrom.Visible = True
                nudFrom.Visible = True
                lblTo.Visible = True
                nudTo.Visible = True
                lblInStepsOf.Visible = True
                nudInStepsOf.Visible = True
                lblTickMarkersNoOfDecimalPlaces.Visible = True
                nudTickMarkersNoOfDecimalPlaces.Visible = True

            ElseIf ucrTickMarkers.cboInput.SelectedItem = "Specific Values" Then
                clsScalecontinuousFunction.RemoveParameterByName("breaks")
                ucrSpecificValues.Visible = True
                lblFrom.Visible = False
                nudFrom.Visible = False
                lblTo.Visible = False
                nudTo.Visible = False
                lblInStepsOf.Visible = False
                nudInStepsOf.Visible = False
                lblTickMarkersNoOfDecimalPlaces.Visible = False
                nudTickMarkersNoOfDecimalPlaces.Visible = False
            End If
        End If
    End Sub

    Private Sub TickMarkersInterval()

    End Sub

    Private Sub ucrSpecificValues_NameChanged() Handles ucrSpecificValues.NameChanged
        If Not ucrSpecificValues.IsEmpty Then
            clsScalecontinuousFunction.AddParameter("breaks", "c(" & ucrSpecificValues.GetText & ")")
        Else
            clsScalecontinuousFunction.RemoveParameterByName("breaks")
        End If
    End Sub

    Private Sub nudFrom_TextChanged(sender As Object, e As EventArgs) Handles nudFrom.TextChanged
        If nudFrom.Text <> "" Then
            clsSeqFunction.AddParameter("from", nudFrom.Value)
        Else
            clsSeqFunction.RemoveParameterByName("from")
        End If
    End Sub

    Private Sub nudTo_TextChanged(sender As Object, e As EventArgs) Handles nudTo.TextChanged
        If nudTo.Text <> "" Then
            clsSeqFunction.AddParameter("to", nudTo.Value)
        Else
            clsSeqFunction.RemoveParameterByName("to")
        End If
    End Sub

    Private Sub nudInStepsOf_TextChanged(sender As Object, e As EventArgs) Handles nudInStepsOf.TextChanged
        If nudFrom.Text <> "" Then
            clsSeqFunction.AddParameter("by", nudFrom.Value)
        Else
            clsSeqFunction.RemoveParameterByName("by")
        End If
    End Sub

End Class

