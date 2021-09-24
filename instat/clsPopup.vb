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

'''--------------------------------------------------------------------------------------------
''' <summary>
''' An object of this class represents a popup component that's used and displayed as a control.
''' <list type="bullet">
'''     <item><description>
'''                  set contents control of the popup
'''     </description></item>
'''     <item><description>
'''                  set size of the popup
'''     </description></item>
'''     <item><description>
'''                  specify the display position of the popup relative to the owner. Default is top
'''     </description></item>
'''     <item><description>
'''                  attach the owner control and show the popup
'''     </description></item>
'''  </list>
''' </summary>
'''--------------------------------------------------------------------------------------------
Public Class clsPopup
    ''' <summary> 
    ''' Event raised when the contents control loses focus. 
    ''' This indicates that the popup is closing. 
    '''</summary>
    Public Event Closing()

    ''' <summary>
    ''' Container used as the 'frame' of the popup component
    ''' </summary>
    Private ReadOnly frm As Form

    ''' <summary>
    ''' specifies if the popup should hide automatically on lost focus or not
    ''' </summary>
    Public Property AutoHide As Boolean

    ''' <summary>
    ''' specifies the position of the popup relative to the owner(control)
    ''' </summary> 
    Public Property Position As PopupPosition

    ''' <summary>
    ''' enumeration of allowable popup positions
    ''' </summary>
    Public Enum PopupPosition
        Top
        Below
    End Enum

    Sub New()
        'initialise variables and set defaults
        frm = New Form With {
            .ShowInTaskbar = False,
            .FormBorderStyle = FormBorderStyle.None,
            .StartPosition = FormStartPosition.Manual
        }
        'set default popup behaviours
        AutoHide = True
        Position = PopupPosition.Top
    End Sub

    Public Sub SetSize(width As Integer, height As Integer)
        SetSize(New Size(width, height))
    End Sub

    Public Sub SetSize(size As Size)
        frm.Size = size
    End Sub

    Public Sub SetLocation(x As Integer, y As Integer)
        SetLocation(New Point(x, y))
    End Sub

    Public Sub SetLocation(point As Point)
        frm.Location = point
    End Sub

    ''' <summary>
    ''' sets the specified control as the contents control of the popup
    ''' </summary>
    ''' <param name="ctr">The System.Windows.Forms.Control to set as the control contained in the popup</param>
    Public Sub SetContentControl(ctr As Control)
        frm.Controls.Clear() 'remove any existing control first
        frm.Controls.Add(ctr)
        ctr.Dock = DockStyle.Fill 'the control will always be same size as the from

        'attach the event handler that will determine auto closing
        AddHandler ctr.LostFocus, Sub()
                                      If AutoHide Then
                                          Hide()
                                      End If
                                  End Sub
    End Sub

    ''' <summary>
    ''' shows the popup relative to the location of the specified control(owner) 
    ''' and the position specified
    ''' </summary>
    ''' <param name="owner">The System.Windows.Forms.Control to set popup location based on</param>
    ''' <param name="position">PopupPosition to set the position of the popup</param>
    Public Sub Show(owner As Control, position As PopupPosition)
        Me.Position = position
        Show(owner)
    End Sub

    ''' <summary>
    ''' shows the popup relative to the location of the specified control(owner) 
    '''  and the position set
    ''' </summary>
    ''' <param name="owner">The System.Windows.Forms.Control to set popup location based on</param> 
    Public Sub Show(owner As Control)
        'compute and get the location of the specified control relative to screen coordinates
        'Don't use Point.Empty, it's not function so use Point(0, 0)
        Dim ctrPos As Point = owner.PointToScreen(New Point(0, 0))

        'then set location of the popup relative to the position specified
        Select Case Position
            Case PopupPosition.Top
                SetLocation(ctrPos.X - 2, ctrPos.Y - frm.Height - 2)
            Case PopupPosition.Below
                SetLocation(ctrPos.X - 2, ctrPos.Y + owner.Height - 2)
        End Select

        'then show popup
        frm.Show()
    End Sub

    ''' <summary>
    ''' raises popup hiding event then hides the popup
    ''' </summary>
    Public Sub Hide()
        RaiseEvent Closing()
        frm.Close()
    End Sub

End Class
