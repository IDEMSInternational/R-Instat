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
Public Class dlgDescriptiveStatistics
    Public bFirstLoad As Boolean = True
    Private Sub dlgDescriptiveStatistics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ucrReceiverDescribeOneVar.Selector = ucrSelectorDescribeOneVar
        ' ucrBaseDescribeOneVar.clsRsyntax.SetFunction("")
        ' ucrBaseDescribeOneVar.clsRsyntax.iCallType = 0

        'ucrBase.clsRsyntax.iCallType = 2
        'ucrBase.clsRsyntax.SetFunction("")
        'clsModel.SetOperation("~")
        'ucrResponse.Selector = ucrSelectorSimpleReg
        'ucrExplanatory.Selector = ucrSelectorSimpleReg
        'ucrBase.iHelpTopicID = 171
        'ucrFamily.SetGLMDistributions()
        'ucrModelName.SetDataFrameSelector(ucrSelectorSimpleReg.ucrAvailableDataFrames)
        'ucrModelName.SetPrefix("reg")
        'ucrModelName.SetItemsTypeAsModels()
        'ucrModelName.SetDefaultTypeAsModel()
        'ucrModelName.SetValidationTypeAsRVariable()
        'ucrModelPreview.IsReadOnly = True
        'sdgSimpleRegOptions.SetRModelFunction(ucrBase.clsRsyntax.clsBaseFunction)
        'sdgSimpleRegOptions.SetRDataFrame(ucrSelectorSimpleReg.ucrAvailableDataFrames)
        'sdgSimpleRegOptions.SetRYVariable(ucrResponse)
        'sdgSimpleRegOptions.SetRXVariable(ucrExplanatory)
        'sdgVariableTransformations.SetRYVariable(ucrResponse)
        'sdgVariableTransformations.SetRXVariable(ucrExplanatory)
        'sdgVariableTransformations.SetRModelOperator(clsModel)
        'sdgModelOptions.SetRCIFunction(clsRCIFunction)
        'sdgVariableTransformations.SetRCIFunction(clsRCIFunction)
        'AssignModelName()
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub SetDefaults()
        ucrReceiverDescribeOneVar.SetMeAsReceiver()
        sdgDescribe.SetDefaults()
        'ucrSelectorSimpleReg.Reset()
        'ucrResponse.SetMeAsReceiver()
        'ucrSelectorSimpleReg.Focus()
        'chkSaveModel.Checked = True
        'ucrModelName.Visible = True
        'chkConvertToVariate.Checked = False
        'chkConvertToVariate.Visible = False
        'chkFunction.Checked = False
        'chkFunction.Visible = False
        'sdgSimpleRegOptions.SetDefaults()
        'sdgModelOptions.SetDefaults()
        'ucrModelName.Reset()
        'ucrModelPreview.SetName("")
        'ResponseConvert()
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverDescribeOneVar.IsEmpty() Then
            'ucrBase.clsRsyntax.AddParameter("formula", clsROperatorParameter:=clsModel)
            ucrBaseDescribeOneVar.OKEnabled(True)
        Else
            ucrBaseDescribeOneVar.OKEnabled(False)
        End If
    End Sub

    Public Sub ucrReceiverDescribeOneVar_selectionchanged() Handles ucrReceiverDescribeOneVar.SelectionChanged
        TestOKEnabled()
        'ucrBaseDescribeOneVar.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrReceiverDescribeOneVar.GetVariables())
    End Sub

    Private Sub cmdStatistics_Click(sender As Object, e As EventArgs) Handles cmdStatistics.Click
        sdgDescribe.ShowDialog()
    End Sub

    Private Sub ucrBaseDescribeOneVar_ClickOk(sender As Object, e As EventArgs) Handles ucrBaseDescribeOneVar.ClickOk
        sdgDescribe.StatsOptions()
    End Sub
End Class
