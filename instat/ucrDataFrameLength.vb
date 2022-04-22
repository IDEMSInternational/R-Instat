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

Public Class ucrDataFrameLength

    Public Overrides Sub SetDataFrameSelector(clsSelector As ucrDataFrame)
        MyBase.SetDataFrameSelector(clsSelector)
        SetDataFrameLength()
    End Sub

    ''' <summary>
    ''' sets the textbox to show the length of the data frame set
    ''' </summary>
    Private Sub SetDataFrameLength()
        If ucrDataFrameSelector IsNot Nothing AndAlso ucrDataFrameSelector.cboAvailableDataFrames.Text <> "" Then
            'txtInput.Text = frmMain.clsRLink.GetDataFrameLength(ucrDataFrameSelector.cboAvailableDataFrames.Text)
            'was not preferred. Setting txtInput.Text property raises TextChanged event of the ucrInputTextBox (this control's parent)
            'However that event doesn't raise ControlValueChanged which is required for the parameter values to be updated
            'see issue #7367 for more information
            'so use SetName(). Also raises ControlValueChanged needed to update the paramete values
            SetName(frmMain.clsRLink.GetDataFrameLength(ucrDataFrameSelector.cboAvailableDataFrames.Text))
        End If
    End Sub

    ''' <summary>
    ''' Gets the length(no. of rows) of the data frame, if data frame is not set, returns 0
    ''' </summary>
    ''' <returns>length of the set data frame</returns>
    Public Function GetDataFrameLength() As Integer
        Dim iLength As Integer
        Integer.TryParse(txtInput.Text, iLength)
        Return iLength
    End Function


    Private Sub ucrDataFrameSelector_DataFrameChanged(sender As Object, e As EventArgs, strPrevDataFrame As String) Handles ucrDataFrameSelector.DataFrameChanged
        SetDataFrameLength()
    End Sub

End Class
