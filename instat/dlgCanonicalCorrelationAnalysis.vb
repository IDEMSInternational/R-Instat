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
Public Class dlgCanonicalCorrelationAnalysis
    Public bFirstLoad As Boolean = True
    Dim clsModel As New ROperator
    'Public Variables As New RSyntax
    Public YVariables, XVariables, dataframe
    Private Sub dlgCanonicalCorrelationAnalysis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If

        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrReceiverYvariables.Selector = ucrSelectorCCA
        ucrReceiverXvariables.Selector = ucrSelectorCCA
        'ucrBaseCCA.iHelpTopicID = 
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub SetDefaults()
        ucrSelectorCCA.Reset()
        ucrReceiverYvariables.SetMeAsReceiver()
        ucrSelectorCCA.Focus()
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If (Not ucrReceiverYvariables.IsEmpty()) And (Not ucrReceiverXvariables.IsEmpty()) Then
            ucrBaseCCA.OKEnabled(True)
        Else
            ucrBaseCCA.OKEnabled(False)
        End If
    End Sub

    Public Sub ucrSelectorCCA_DataFrameChanged() Handles ucrSelectorCCA.DataFrameChanged
        dataframe = ucrSelectorCCA.ucrAvailableDataFrames.clsCurrDataFrame.ToString()
    End Sub

    Private Sub ucrBaseCCA_ClickReset(sender As Object, e As EventArgs) Handles ucrBaseCCA.ClickReset
        SetDefaults()
    End Sub

    Private Sub ucrbaseCCA_clickok(sender As Object, e As EventArgs) Handles ucrBaseCCA.ClickOk
        'sdgcanonicalcorrelation.regoptions
        Options()
    End Sub



    Public Sub ucrReceiverYvariables_SelectionChanged() Handles ucrReceiverYvariables.SelectionChanged
        TestOKEnabled()
        YVariables = XYariables(ucrReceiverYvariables.GetVariableNames())
    End Sub

    Public Sub ucrReceiverXvariables_SelectionChanged() Handles ucrReceiverXvariables.SelectionChanged
        TestOKEnabled()
        XVariables = XYariables(ucrReceiverXvariables.GetVariableNames())
    End Sub

    Private Sub Options()
        Cancor()
    End Sub

    Public Function XYariables(ByVal my_variable) As String
        Dim Variables As New RSyntax
        Variables.SetFunction(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
        Variables.AddParameter("col_names", my_variable)
        Variables.AddParameter("data_name", Chr(34) & ucrSelectorCCA.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
        Return (Variables.GetScript())
    End Function

    Private Sub Cancor()
        ucrBaseCCA.clsRsyntax.SetFunction("cc") 'or matcor
        ucrBaseCCA.clsRsyntax.AddParameter("Y", YVariables)
        ucrBaseCCA.clsRsyntax.AddParameter("X", XVariables)
        frmMain.clsRLink.RunScript(ucrBaseCCA.clsRsyntax.GetScript(), 2)
    End Sub
End Class