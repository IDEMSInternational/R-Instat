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

Imports System.ComponentModel
Imports System.Windows.Forms.VisualStyles
Imports System.Runtime.InteropServices
Imports System.Diagnostics

Public Class ucrSplitButton
    Inherits Button

    Private _pushButtonState As PushButtonState
    Private ReadOnly _iSplitSectionWidth As Integer = 18
    Private ReadOnly _iBorderSize As Integer = SystemInformation.Border3DSize.Width * 2
    Private _dropDownRectangle As Rectangle
    Private _bSplitMenuVisible As Boolean

    Private _bShowSplit As Boolean
    Private _contextSplitMenuStrip As ContextMenuStrip
    Private _textFormatFlags As TextFormatFlags = TextFormatFlags.Default
    Private _bSkipNextOpen As Boolean
    Private _bMouseEntered As Boolean

    ' Toggle debugging diagnostics (set True to log measured widths)
    Private Const ENABLE_SPLITMENU_DIAGNOSTICS As Boolean = False

    Public Sub New()
        AutoSize = True
    End Sub

    <Browsable(False)>
    Public Overrides Property ContextMenuStrip As ContextMenuStrip
        Get
            Return SplitMenuStrip
        End Get
        Set(value As ContextMenuStrip)
            SplitMenuStrip = value
        End Set
    End Property

    <DefaultValue(DirectCast(Nothing, ContextMenu))>
    Public Property SplitMenuStrip As ContextMenuStrip
        Get
            Return _contextSplitMenuStrip
        End Get
        Set(value As ContextMenuStrip)
            If _contextSplitMenuStrip IsNot Nothing Then
                RemoveHandler _contextSplitMenuStrip.Closing, AddressOf SplitMenuStrip_Closing
                RemoveHandler _contextSplitMenuStrip.Opening, AddressOf SplitMenuStrip_Opening
            End If

            _contextSplitMenuStrip = value

            If _contextSplitMenuStrip IsNot Nothing Then
                ShowSplit = True
                AddHandler _contextSplitMenuStrip.Closing, AddressOf SplitMenuStrip_Closing
                AddHandler _contextSplitMenuStrip.Opening, AddressOf SplitMenuStrip_Opening
            Else
                ShowSplit = False
            End If
        End Set
    End Property

    <DefaultValue(False)>
    Private WriteOnly Property ShowSplit As Boolean
        Set(value As Boolean)
            If value <> _bShowSplit Then
                _bShowSplit = value
                Invalidate()
                If Parent IsNot Nothing Then Parent.PerformLayout()
            End If
        End Set
    End Property

    ' Public settings so Designer/other classes can access them without protection errors
    <DefaultValue(False)>
    Public Property ForceWideSplit As Boolean = False

    <DefaultValue(28)>
    Public Property ExtraMenuWidthPadding As Integer = 28

    Private Property State As PushButtonState
        Get
            Return _pushButtonState
        End Get
        Set(value As PushButtonState)
            If Not _pushButtonState.Equals(value) Then
                _pushButtonState = value
                Invalidate()
            End If
        End Set
    End Property

    Protected Overrides Function IsInputKey(keyData As Keys) As Boolean
        If keyData.Equals(Keys.Down) AndAlso _bShowSplit Then Return True
        Return MyBase.IsInputKey(keyData)
    End Function

    Protected Overrides Sub OnGotFocus(e As EventArgs)
        If Not _bShowSplit Then
            MyBase.OnGotFocus(e)
            Return
        End If
        If Not State.Equals(PushButtonState.Pressed) AndAlso Not State.Equals(PushButtonState.Disabled) Then
            State = PushButtonState.Default
        End If
    End Sub

    Protected Overrides Sub OnKeyDown(kevent As KeyEventArgs)
        If _bShowSplit Then
            If kevent.KeyCode.Equals(Keys.Down) AndAlso Not _bSplitMenuVisible Then
                ShowContextMenuStrip()
            ElseIf kevent.KeyCode.Equals(Keys.Space) AndAlso kevent.Modifiers = Keys.None Then
                State = PushButtonState.Pressed
            End If
        End If
        MyBase.OnKeyDown(kevent)
    End Sub

    Protected Overrides Sub OnKeyUp(kevent As KeyEventArgs)
        If kevent.KeyCode.Equals(Keys.Space) Then
            If MouseButtons = MouseButtons.None Then State = PushButtonState.Normal
        ElseIf kevent.KeyCode.Equals(Keys.Apps) Then
            If MouseButtons = MouseButtons.None AndAlso Not _bSplitMenuVisible Then
                ShowContextMenuStrip()
            End If
        End If
        MyBase.OnKeyUp(kevent)
    End Sub

    Protected Overrides Sub OnEnabledChanged(e As EventArgs)
        State = If(Enabled, PushButtonState.Normal, PushButtonState.Disabled)
        MyBase.OnEnabledChanged(e)
    End Sub

    Protected Overrides Sub OnLostFocus(e As EventArgs)
        If Not _bShowSplit Then
            MyBase.OnLostFocus(e)
            Return
        End If
        If Not State.Equals(PushButtonState.Pressed) AndAlso Not State.Equals(PushButtonState.Disabled) Then
            State = PushButtonState.Normal
        End If
    End Sub

    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        If Not _bShowSplit Then
            MyBase.OnMouseEnter(e)
            Return
        End If
        _bMouseEntered = True
        If Not State.Equals(PushButtonState.Pressed) AndAlso Not State.Equals(PushButtonState.Disabled) Then
            State = PushButtonState.Hot
        End If
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        If Not _bShowSplit Then
            MyBase.OnMouseLeave(e)
            Return
        End If
        _bMouseEntered = False
        If Not State.Equals(PushButtonState.Pressed) AndAlso Not State.Equals(PushButtonState.Disabled) Then
            State = If(Focused, PushButtonState.Default, PushButtonState.Normal)
        End If
    End Sub

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        If Not _bShowSplit Then
            MyBase.OnMouseDown(e)
            Return
        End If

        If _contextSplitMenuStrip IsNot Nothing AndAlso e.Button = MouseButtons.Left AndAlso Not _bMouseEntered Then
            _bSkipNextOpen = True
        End If

        If _dropDownRectangle.Contains(e.Location) AndAlso Not _bSplitMenuVisible AndAlso e.Button = MouseButtons.Left Then
            ShowContextMenuStrip()
        Else
            State = PushButtonState.Pressed
        End If
    End Sub

    Protected Overrides Sub OnMouseUp(mevent As MouseEventArgs)
        If Not _bShowSplit Then
            MyBase.OnMouseUp(mevent)
            Return
        End If

        If mevent.Button = MouseButtons.Right AndAlso ClientRectangle.Contains(mevent.Location) AndAlso Not _bSplitMenuVisible Then
            ShowContextMenuStrip()
        ElseIf _contextSplitMenuStrip Is Nothing OrElse Not _bSplitMenuVisible Then
            If ClientRectangle.Contains(mevent.Location) AndAlso Not _dropDownRectangle.Contains(mevent.Location) Then
                OnClick(EventArgs.Empty)
            End If
        End If

        State = PushButtonState.Normal
        MyBase.OnMouseUp(mevent)
    End Sub

    Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
        MyBase.OnPaint(pevent)
        If Not _bShowSplit Then Exit Sub

        Dim g As Graphics = pevent.Graphics
        Dim bounds As Rectangle = ClientRectangle

        If State <> PushButtonState.Pressed AndAlso IsDefault AndAlso Not Application.RenderWithVisualStyles Then
            Dim backgroundBounds As Rectangle = bounds
            backgroundBounds.Inflate(-1, -1)
            ButtonRenderer.DrawButton(g, backgroundBounds, State)
            g.DrawRectangle(SystemPens.WindowFrame, 0, 0, bounds.Width - 1, bounds.Height - 1)
        Else
            ButtonRenderer.DrawButton(g, bounds, State)
        End If

        _dropDownRectangle = New Rectangle(bounds.Right - _iSplitSectionWidth, 0, _iSplitSectionWidth, bounds.Height)
        Dim iInternalBorder As Integer = _iBorderSize
        Dim focusRect As Rectangle = New Rectangle(iInternalBorder - 1, iInternalBorder - 1, bounds.Width - _dropDownRectangle.Width - iInternalBorder, bounds.Height - (iInternalBorder * 2) + 2)
        Dim bDrawSplitLine As Boolean = (State = PushButtonState.Hot OrElse State = PushButtonState.Pressed OrElse Not Application.RenderWithVisualStyles)

        If bDrawSplitLine Then
            g.DrawLine(SystemPens.ButtonShadow, bounds.Right - _iSplitSectionWidth, _iBorderSize, bounds.Right - _iSplitSectionWidth, bounds.Bottom - _iBorderSize)
            g.DrawLine(SystemPens.ButtonFace, bounds.Right - _iSplitSectionWidth - 1, _iBorderSize, bounds.Right - _iSplitSectionWidth - 1, bounds.Bottom - _iBorderSize)
        End If

        PaintArrow(g, _dropDownRectangle)
        PaintTextandImage(g, New Rectangle(0, 0, ClientRectangle.Width - _iSplitSectionWidth, ClientRectangle.Height))

        If State <> PushButtonState.Pressed AndAlso Focused AndAlso ShowFocusCues Then
            ControlPaint.DrawFocusRectangle(g, focusRect)
        End If
    End Sub

    Private Sub PaintArrow(g As Graphics, dropDownRect As Rectangle)
        Dim middle As Point = New Point(Convert.ToInt32(dropDownRect.Left + dropDownRect.Width / 2), Convert.ToInt32(dropDownRect.Top + dropDownRect.Height / 2))
        middle.X += (dropDownRect.Width Mod 2)
        Dim arrow As Point() = {New Point(middle.X - 2, middle.Y - 1), New Point(middle.X + 3, middle.Y - 1), New Point(middle.X, middle.Y + 2)}

        If Enabled Then
            g.FillPolygon(SystemBrushes.ControlText, arrow)
        Else
            g.FillPolygon(SystemBrushes.ButtonShadow, arrow)
        End If
    End Sub

    Private Sub PaintTextandImage(g As Graphics, bounds As Rectangle)
        Dim textRectangle As Rectangle
        Dim imageRectangle As Rectangle
        CalculateAndSetButtonTextAndImageLayout(bounds, textRectangle, imageRectangle)

        If Image IsNot Nothing Then
            If Enabled Then
                g.DrawImage(Image, imageRectangle.X, imageRectangle.Y, Image.Width, Image.Height)
            Else
                ControlPaint.DrawImageDisabled(g, Image, imageRectangle.X, imageRectangle.Y, BackColor)
            End If
        End If

        If Not UseMnemonic Then
            _textFormatFlags = _textFormatFlags Or TextFormatFlags.NoPrefix
        ElseIf Not ShowKeyboardCues Then
            _textFormatFlags = _textFormatFlags Or TextFormatFlags.HidePrefix
        End If

        If Not String.IsNullOrEmpty(Text) Then
            If Enabled Then
                TextRenderer.DrawText(g, Text, Font, textRectangle, ForeColor, _textFormatFlags)
            Else
                ControlPaint.DrawStringDisabled(g, Text, Font, BackColor, textRectangle, _textFormatFlags)
            End If
        End If
    End Sub

    Public Overrides Function GetPreferredSize(proposedSize As Size) As Size
        Dim preferredSize As Size = MyBase.GetPreferredSize(proposedSize)
        If _bShowSplit Then
            If AutoSize Then Return CalculateButtonAutoSize()
            If Not String.IsNullOrEmpty(Text) AndAlso TextRenderer.MeasureText(Text, Font).Width + _iSplitSectionWidth > preferredSize.Width Then
                Return preferredSize + New Size(_iSplitSectionWidth + _iBorderSize * 2, 0)
            End If
        End If
        Return preferredSize
    End Function

    Private Function CalculateButtonAutoSize() As Size
        Dim rectSize As Size = Size.Empty
        Dim textSize As Size = TextRenderer.MeasureText(Text, Font)
        Dim imageSize As Size = If(Image Is Nothing, Size.Empty, Image.Size)

        If Text.Length <> 0 Then
            textSize.Height += 4
            textSize.Width += 4
        End If

        Select Case TextImageRelation
            Case TextImageRelation.Overlay
                rectSize.Height = Math.Max(If(Text.Length = 0, 0, textSize.Height), imageSize.Height)
                rectSize.Width = Math.Max(textSize.Width, imageSize.Width)
            Case TextImageRelation.ImageAboveText, TextImageRelation.TextAboveImage
                rectSize.Height = textSize.Height + imageSize.Height
                rectSize.Width = Math.Max(textSize.Width, imageSize.Width)
            Case TextImageRelation.ImageBeforeText, TextImageRelation.TextBeforeImage
                rectSize.Height = Math.Max(textSize.Height, imageSize.Height)
                rectSize.Width = textSize.Width + imageSize.Width
        End Select

        rectSize.Height += Padding.Vertical + 6
        rectSize.Width += Padding.Horizontal + 6
        If _bShowSplit Then rectSize.Width += _iSplitSectionWidth
        Return rectSize
    End Function

    Private Sub CalculateAndSetButtonTextAndImageLayout(ByRef contentRect As Rectangle, <Out> ByRef textRectangle As Rectangle, <Out> ByRef imageRectangle As Rectangle)
        Dim textSize As Size = TextRenderer.MeasureText(Text, Font, contentRect.Size, _textFormatFlags)
        Dim imageSize As Size = If(Image Is Nothing, Size.Empty, Image.Size)
        textRectangle = Rectangle.Empty
        imageRectangle = Rectangle.Empty

        Select Case TextImageRelation
            Case TextImageRelation.Overlay
                textRectangle = OverlayObjectRect(contentRect, textSize, TextAlign)
                If _pushButtonState = PushButtonState.Pressed AndAlso Not Application.RenderWithVisualStyles Then textRectangle.Offset(1, 1)
                If Image IsNot Nothing Then imageRectangle = OverlayObjectRect(contentRect, imageSize, ImageAlign)
            Case TextImageRelation.ImageAboveText
                contentRect.Inflate(-4, -4)
                SetLayoutTextAboveOrBelowImage(contentRect, False, textSize, imageSize, textRectangle, imageRectangle)
            Case TextImageRelation.TextAboveImage
                contentRect.Inflate(-4, -4)
                SetLayoutTextAboveOrBelowImage(contentRect, True, textSize, imageSize, textRectangle, imageRectangle)
            Case TextImageRelation.ImageBeforeText
                contentRect.Inflate(-4, -4)
                SetLayoutTextBeforeOrAfterImage(contentRect, False, textSize, imageSize, textRectangle, imageRectangle)
            Case TextImageRelation.TextBeforeImage
                contentRect.Inflate(-4, -4)
                SetLayoutTextBeforeOrAfterImage(contentRect, True, textSize, imageSize, textRectangle, imageRectangle)
        End Select
    End Sub

    ' Public helpers (changed from Private to Public so other compile units & designer code can access them)
    Public Function OverlayObjectRect(ByRef container As Rectangle, ByRef sizeOfObject As Size, alignment As System.Drawing.ContentAlignment) As Rectangle
        Dim x, y As Integer
        Select Case alignment
            Case System.Drawing.ContentAlignment.TopLeft
                x = 4
                y = 4
            Case System.Drawing.ContentAlignment.TopCenter
                x = (container.Width - sizeOfObject.Width) / 2
                y = 4
            Case System.Drawing.ContentAlignment.TopRight
                x = container.Width - sizeOfObject.Width - 4
                y = 4
            Case System.Drawing.ContentAlignment.MiddleLeft
                x = 4
                y = (container.Height - sizeOfObject.Height) / 2
            Case System.Drawing.ContentAlignment.MiddleCenter
                x = (container.Width - sizeOfObject.Width) / 2
                y = (container.Height - sizeOfObject.Height) / 2
            Case System.Drawing.ContentAlignment.MiddleRight
                x = container.Width - sizeOfObject.Width - 4
                y = (container.Height - sizeOfObject.Height) / 2
            Case System.Drawing.ContentAlignment.BottomLeft
                x = 4
                y = container.Height - sizeOfObject.Height - 4
            Case System.Drawing.ContentAlignment.BottomCenter
                x = (container.Width - sizeOfObject.Width) / 2
                y = container.Height - sizeOfObject.Height - 4
            Case System.Drawing.ContentAlignment.BottomRight
                x = container.Width - sizeOfObject.Width - 4
                y = container.Height - sizeOfObject.Height - 4
            Case Else
                x = 4
                y = 4
        End Select

        Return New Rectangle(x, y, sizeOfObject.Width, sizeOfObject.Height)
    End Function

    Public Sub SetLayoutTextBeforeOrAfterImage(ByVal totalArea As Rectangle, ByVal textFirst As Boolean, ByVal textSize As Size, ByVal imageSize As Size, <Out> ByRef textRect As Rectangle, <Out> ByRef imageRect As Rectangle)
        Dim iElementSpacing As Integer = 0
        Dim iTotalWidth As Integer = textSize.Width + iElementSpacing + imageSize.Width
        If Not textFirst Then iElementSpacing += 2

        If iTotalWidth > totalArea.Width Then
            textSize.Width = totalArea.Width - iElementSpacing - imageSize.Width
            iTotalWidth = totalArea.Width
        End If

        Dim iExcessWidth As Integer = totalArea.Width - iTotalWidth
        Dim iOffset As Integer = 0
        Dim finalTextRect As Rectangle
        Dim finalImageRect As Rectangle
        Dim hText As HorizontalAlignment = GetHorizontalAlignment(TextAlign)
        Dim hImage As HorizontalAlignment = GetHorizontalAlignment(ImageAlign)

        If hImage = HorizontalAlignment.Left Then
            iOffset = 0
        ElseIf hImage = HorizontalAlignment.Right AndAlso hText = HorizontalAlignment.Right Then
            iOffset = iExcessWidth
        ElseIf hImage = HorizontalAlignment.Center AndAlso (hText = HorizontalAlignment.Left OrElse hText = HorizontalAlignment.Center) Then
            iOffset += iExcessWidth / 3
        Else
            iOffset += 2 * (iExcessWidth / 3)
        End If

        If textFirst Then
            finalTextRect = New Rectangle(totalArea.Left + iOffset, GetAlignInRectangle(totalArea, textSize, TextAlign).Top, textSize.Width, textSize.Height)
            finalImageRect = New Rectangle(finalTextRect.Right + iElementSpacing, GetAlignInRectangle(totalArea, imageSize, ImageAlign).Top, imageSize.Width, imageSize.Height)
        Else
            finalImageRect = New Rectangle(totalArea.Left + iOffset, GetAlignInRectangle(totalArea, imageSize, ImageAlign).Top, imageSize.Width, imageSize.Height)
            finalTextRect = New Rectangle(finalImageRect.Right + iElementSpacing, GetAlignInRectangle(totalArea, textSize, TextAlign).Top, textSize.Width, textSize.Height)
        End If

        textRect = finalTextRect
        imageRect = finalImageRect
    End Sub

    Public Sub SetLayoutTextAboveOrBelowImage(totalArea As Rectangle, bTextFirst As Boolean, textSize As Size, imageSize As Size, <Out> ByRef textRect As Rectangle, <Out> ByRef imageRect As Rectangle)
        Dim iElementSpacing As Integer = 0
        Dim iTotalHeight As Integer = textSize.Height + iElementSpacing + imageSize.Height
        If bTextFirst Then iElementSpacing += 2
        If textSize.Width > totalArea.Width Then textSize.Width = totalArea.Width

        If iTotalHeight > totalArea.Height AndAlso bTextFirst Then
            imageSize = Size.Empty
            iTotalHeight = totalArea.Height
        End If

        Dim iExcessHeight As Integer = totalArea.Height - iTotalHeight
        Dim iOffset As Integer = 0
        Dim finalTextRect As Rectangle
        Dim finalImageRect As Rectangle
        Dim verticalText As VerticalAlignment = GetVerticalAlignment(TextAlign)
        Dim verticalImage As VerticalAlignment = GetVerticalAlignment(ImageAlign)

        If verticalImage = VerticalAlignment.Top Then
            iOffset = 0
        ElseIf verticalImage = VerticalAlignment.Bottom AndAlso verticalText = VerticalAlignment.Bottom Then
            iOffset = iExcessHeight
        ElseIf verticalImage = VerticalAlignment.Center AndAlso (verticalText = VerticalAlignment.Top OrElse verticalText = VerticalAlignment.Center) Then
            iOffset += iExcessHeight / 3
        Else
            iOffset += 2 * (iExcessHeight / 3)
        End If

        If bTextFirst Then
            finalTextRect = New Rectangle(GetAlignInRectangle(totalArea, textSize, TextAlign).Left, totalArea.Top + iOffset, textSize.Width, textSize.Height)
            finalImageRect = New Rectangle(GetAlignInRectangle(totalArea, imageSize, ImageAlign).Left, finalTextRect.Bottom + iElementSpacing, imageSize.Width, imageSize.Height)
        Else
            finalImageRect = New Rectangle(GetAlignInRectangle(totalArea, imageSize, ImageAlign).Left, totalArea.Top + iOffset, imageSize.Width, imageSize.Height)
            finalTextRect = New Rectangle(GetAlignInRectangle(totalArea, textSize, TextAlign).Left, finalImageRect.Bottom + iElementSpacing, textSize.Width, textSize.Height)
            If finalTextRect.Bottom > totalArea.Bottom Then finalTextRect.Y = totalArea.Top
        End If

        textRect = finalTextRect
        imageRect = finalImageRect
    End Sub

    Public Function GetHorizontalAlignment(enumAlign As System.Drawing.ContentAlignment) As HorizontalAlignment
        Select Case enumAlign
            Case System.Drawing.ContentAlignment.BottomLeft, System.Drawing.ContentAlignment.MiddleLeft, System.Drawing.ContentAlignment.TopLeft
                Return HorizontalAlignment.Left
            Case System.Drawing.ContentAlignment.BottomCenter, System.Drawing.ContentAlignment.MiddleCenter, System.Drawing.ContentAlignment.TopCenter
                Return HorizontalAlignment.Center
            Case System.Drawing.ContentAlignment.BottomRight, System.Drawing.ContentAlignment.MiddleRight, System.Drawing.ContentAlignment.TopRight
                Return HorizontalAlignment.Right
        End Select

        Return HorizontalAlignment.Left
    End Function

    Public Function GetVerticalAlignment(enumAlign As System.Drawing.ContentAlignment) As VerticalAlignment
        Select Case enumAlign
            Case System.Drawing.ContentAlignment.TopLeft, System.Drawing.ContentAlignment.TopCenter, System.Drawing.ContentAlignment.TopRight
                Return VerticalAlignment.Top
            Case System.Drawing.ContentAlignment.MiddleLeft, System.Drawing.ContentAlignment.MiddleCenter, System.Drawing.ContentAlignment.MiddleRight
                Return VerticalAlignment.Center
            Case System.Drawing.ContentAlignment.BottomLeft, System.Drawing.ContentAlignment.BottomCenter, System.Drawing.ContentAlignment.BottomRight
                Return VerticalAlignment.Bottom
        End Select

        Return VerticalAlignment.Top
    End Function

    Public Function GetAlignInRectangle(outer As Rectangle, inner As Size, enumAlign As System.Drawing.ContentAlignment) As Rectangle
        Dim x As Integer = 0
        Dim y As Integer = 0

        If enumAlign = System.Drawing.ContentAlignment.BottomLeft OrElse enumAlign = System.Drawing.ContentAlignment.MiddleLeft OrElse enumAlign = System.Drawing.ContentAlignment.TopLeft Then
            x = outer.X
        ElseIf enumAlign = System.Drawing.ContentAlignment.BottomCenter OrElse enumAlign = System.Drawing.ContentAlignment.MiddleCenter OrElse enumAlign = System.Drawing.ContentAlignment.TopCenter Then
            x = Math.Max(outer.X + ((outer.Width - inner.Width) / 2), outer.Left)
        ElseIf enumAlign = System.Drawing.ContentAlignment.BottomRight OrElse enumAlign = System.Drawing.ContentAlignment.MiddleRight OrElse enumAlign = System.Drawing.ContentAlignment.TopRight Then
            x = outer.Right - inner.Width
        End If

        If enumAlign = System.Drawing.ContentAlignment.TopCenter OrElse enumAlign = System.Drawing.ContentAlignment.TopLeft OrElse enumAlign = System.Drawing.ContentAlignment.TopRight Then
            y = outer.Y
        ElseIf enumAlign = System.Drawing.ContentAlignment.MiddleCenter OrElse enumAlign = System.Drawing.ContentAlignment.MiddleLeft OrElse enumAlign = System.Drawing.ContentAlignment.MiddleRight Then
            y = outer.Y + (outer.Height - inner.Height) / 2
        ElseIf enumAlign = System.Drawing.ContentAlignment.BottomCenter OrElse enumAlign = System.Drawing.ContentAlignment.BottomRight OrElse enumAlign = System.Drawing.ContentAlignment.BottomLeft Then
            y = outer.Bottom - inner.Height
        End If

        Return New Rectangle(x, y, Math.Min(inner.Width, outer.Width), Math.Min(inner.Height, outer.Height))
    End Function

    ' ========================================================
    ' Core: ShowContextMenuStrip - robust approach (measure & force width, then show native)
    ' ========================================================
    Private Sub ShowContextMenuStrip()
        If _bSkipNextOpen Then
            _bSkipNextOpen = False
            Return
        End If

        If _contextSplitMenuStrip Is Nothing Then
            Return
        End If

        State = PushButtonState.Pressed

        ' Ensure layout is up-to-date so PreferredSize/GetPreferredSize are accurate
        _contextSplitMenuStrip.PerformLayout()

        Dim menuPreferred As Size = _contextSplitMenuStrip.PreferredSize
        Dim screenRect As Rectangle = Screen.FromControl(Me).WorkingArea
        Dim maxHeight As Integer = 1000
        Dim formHeight As Integer = Math.Min(menuPreferred.Height, maxHeight)

        Dim maxItemWidth As Integer = 0
        Dim measureFont As Font = If(_contextSplitMenuStrip.Font, Me.Font)

        Dim SubMeasure As Action(Of ToolStripItemCollection) =
            Sub(items As ToolStripItemCollection)
                If items Is Nothing Then Return
                For Each tsi As ToolStripItem In items
                    If tsi Is Nothing Then Continue For
                    Try
                        Dim pref As Size = tsi.GetPreferredSize(Size.Empty)
                        If pref.Width > maxItemWidth Then maxItemWidth = pref.Width
                    Catch
                        Dim cleaned As String = If(String.IsNullOrEmpty(tsi.Text), "", tsi.Text.Replace("&"c, ""))
                        Dim measured As Size = TextRenderer.MeasureText(cleaned, measureFont, New Size(4000, 0), TextFormatFlags.SingleLine)
                        If measured.Width > maxItemWidth Then maxItemWidth = measured.Width
                    End Try
                    Dim mi = TryCast(tsi, ToolStripMenuItem)
                    If mi IsNot Nothing AndAlso mi.HasDropDownItems Then
                        SubMeasure(mi.DropDownItems)
                    End If
                Next
            End Sub

        SubMeasure(_contextSplitMenuStrip.Items)

        Dim imageCol As Integer = If(_contextSplitMenuStrip.ShowImageMargin, 36, 0)
        Dim arrowCol As Integer = 2
        Dim padding As Integer = ExtraMenuWidthPadding
        Dim computedWidth As Integer = maxItemWidth + imageCol + arrowCol + padding

        computedWidth = Math.Max(computedWidth, menuPreferred.Width)
        If ForceWideSplit Then computedWidth = Math.Max(computedWidth, Me.Width * 2)

        Dim maxAllowedWidth As Integer = screenRect.Width - 20
        If computedWidth > maxAllowedWidth Then computedWidth = maxAllowedWidth

        If ENABLE_SPLITMENU_DIAGNOSTICS Then
            Debug.WriteLine($"[ucrSplitButton] menuPreferred.Width={menuPreferred.Width}, maxItemWidth={maxItemWidth}, computedWidth={computedWidth}, screenWidth={screenRect.Width}")
        End If

        Dim prevAutoSize As Boolean = _contextSplitMenuStrip.AutoSize
        Try
            _contextSplitMenuStrip.AutoSize = False
            _contextSplitMenuStrip.Width = Math.Max(30, computedWidth)
        Catch ex As Exception
        End Try

        Dim belowScreenPoint As Point = PointToScreen(New Point(0, Height))
        Dim showAbove As Boolean = (belowScreenPoint.Y + formHeight) > screenRect.Bottom

        Try
            RemoveHandler _contextSplitMenuStrip.ItemClicked, AddressOf ContextMenu_ItemClicked_CloseHosted
        Catch ex As Exception
        End Try
        AddHandler _contextSplitMenuStrip.ItemClicked, AddressOf ContextMenu_ItemClicked_CloseHosted

        If showAbove Then
            _contextSplitMenuStrip.Show(Me, New Point(0, -formHeight))
        Else
            _contextSplitMenuStrip.Show(Me, New Point(0, Height))
        End If

        _bSplitMenuVisible = True

        Me.BeginInvoke(Sub()
                           Try
                               _contextSplitMenuStrip.AutoSize = prevAutoSize
                           Catch
                           End Try
                       End Sub)
    End Sub

    Private Sub ContextMenu_ItemClicked_CloseHosted(sender As Object, e As ToolStripItemClickedEventArgs)
        Try
            _contextSplitMenuStrip.Close()
        Catch
        End Try
    End Sub

    Private Sub SplitMenuStrip_Opening(sender As Object, e As CancelEventArgs)
        _bSplitMenuVisible = True
    End Sub

    Private Sub SplitMenuStrip_Closing(ByVal sender As Object, ByVal e As ToolStripDropDownClosingEventArgs)
        _bSplitMenuVisible = False
        SetButtonDrawState()
        If e.CloseReason = ToolStripDropDownCloseReason.AppClicked Then
            _bSkipNextOpen = _dropDownRectangle.Contains(PointToClient(Cursor.Position)) AndAlso MouseButtons = MouseButtons.Left
        End If
    End Sub

    Private Sub SetButtonDrawState()
        If Parent IsNot Nothing AndAlso Bounds.Contains(Parent.PointToClient(Cursor.Position)) Then
            State = PushButtonState.Hot
        ElseIf Focused Then
            State = PushButtonState.Default
        ElseIf Not Enabled Then
            State = PushButtonState.Disabled
        Else
            State = PushButtonState.Normal
        End If
    End Sub
End Class