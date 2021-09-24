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



''' <summary> This control allows the user to specify how an object should be saved. 
'''           <para>
'''           This control can save the object of type 'graph'.
'''           The user can enter/update the name of the saved object via a text box or combo box.
'''           A combo box may be used to display a list of possible save names (e.g. the existing 
'''           graph names).
'''           An optional check box allows the text/combo box to be made visible or not visible.
'''           </para>
''' </summary>
Public Class ucrSaveGraph
    Public Event SaveGraphCheckedChanged()
    Public Event GraphNameChanged()
    Public Event ContentsChanged()
    Public bFirstLoad As Boolean

    '''--------------------------------------------------------------------------------------------
    ''' <summary> Constructs and initializes this component. </summary>
    '''--------------------------------------------------------------------------------------------
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ucrInputGraphName.SetDefaultTypeAsGraph()
        ucrInputGraphName.SetItemsTypeAsGraphs()
        ucrInputGraphName.SetValidationTypeAsRVariable()
        bFirstLoad = True
    End Sub
    '''--------------------------------------------------------------------------------------------
    ''' <summary> Executes whenever this control loads.
    '''           If this is the first time that the control has loaded then sets the control to 
    '''           the default state.
    '''           If the control has already been loaded then this function does nothing.
    ''' </summary>
    ''' <param name="sender"> Source of the event. </param>
    ''' <param name="e"> Event information. </param>
    '''--------------------------------------------------------------------------------------------
    Private Sub ucrSaveGraph_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            SetDefaults()
            bFirstLoad = False
        End If
    End Sub
    '''--------------------------------------------------------------
    ''' <summary> Sets the control to its default state. </summary>
    '''--------------------------------------------------------------
    Private Sub SetDefaults()
        chkSaveGraph.Checked = False
        ucrInputGraphName.Visible = False
    End Sub
    '''------------------------------------------------------------------
    ''' <summary> Resets the control to its default state. </summary>
    '''------------------------------------------------------------------
    Public Sub Reset()
        SetDefaults()
    End Sub
    '''-------------------------------------------------------------------------------------------------
    ''' <summary> Sets the new data frame selector and links the selector to the combo box. </summary>
    ''' <param name="ucrNewDataFrameSelector"> The new data frame selector. </param>
    '''-------------------------------------------------------------------------------------------------
    Public Sub SetDataFrameSelector(ucrNewDataFrameSelector As ucrDataFrame)
        ucrInputGraphName.SetDataFrameSelector(ucrNewDataFrameSelector)
    End Sub
    '''----------------------------------------------------------------------------------------
    ''' <summary> Handles event triggered when the state of the check box changes. </summary>
    ''' <param name="sender"> Source of the event. </param>
    ''' <param name="e"> Event information. </param>
    '''----------------------------------------------------------------------------------------
    Private Sub chkSaveGraph_CheckedChanged(sender As Object, e As EventArgs) Handles chkSaveGraph.CheckedChanged
        ucrInputGraphName.Enabled = chkSaveGraph.Checked
        ucrInputGraphName.Visible = chkSaveGraph.Checked
        RaiseEvent SaveGraphCheckedChanged()
    End Sub
    '''--------------------------------------------------------------------------------
    ''' <summary> Handles event triggered when the combo box name changes. </summary>
    '''--------------------------------------------------------------------------------
    Private Sub ucrInputGraphName_NameChanged() Handles ucrInputGraphName.NameChanged
        If chkSaveGraph.Checked Then
            RaiseEvent GraphNameChanged()
        End If
    End Sub
    '''-----------------------------------------------------------------------------------
    ''' <summary> Handles event triggered when the combo box contents changes. </summary>
    '''-----------------------------------------------------------------------------------
    Private Sub ucrInputGraphName_ContentsChanged() Handles ucrInputGraphName.ContentsChanged
        RaiseEvent ContentsChanged()
    End Sub
    '''----------------------------------------------------------------------
    ''' <summary> Returns the state of the save graph check box. </summary>
    ''' <returns> True if the check box is checked. </returns>
    '''----------------------------------------------------------------------
    Public ReadOnly Property bSaveGraph() As Boolean
        Get
            Return chkSaveGraph.Checked
        End Get
    End Property
    '''---------------------------------------------------------------------
    ''' <summary> Sets the name of the graph in the combo box. </summary>
    ''' <returns> Return the name graph. </returns>
    '''---------------------------------------------------------------------
    Public ReadOnly Property strGraphName() As String
        Get
            Return ucrInputGraphName.GetText()
        End Get
    End Property
    '''---------------------------------------------------------------------------------
    ''' <summary> Sets the prefix for the combo box value to the new prefix. </summary>
    '''---------------------------------------------------------------------------------
    Public WriteOnly Property strPrefix() As String
        Set(strNewPrefix As String)
            ucrInputGraphName.SetPrefix(strNewPrefix)
        End Set
    End Property
End Class
