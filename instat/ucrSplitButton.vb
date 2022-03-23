
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles
Imports System.Runtime.InteropServices


Public Class ucrSplitButton
    Inherits Button

    Private _pushButtonState As PushButtonState
    Private ReadOnly _splitSectionWidth As Integer = 18
    Private ReadOnly _borderSize As Integer = SystemInformation.Border3DSize.Width * 2
    Private _dropDownRectangle As Rectangle
    Private _showSplit As Boolean
    Private _isSplitMenuVisible As Boolean
    Private _contextSplitMenuStrip As ContextMenuStrip
    Private _textFormatFlags As TextFormatFlags = TextFormatFlags.[Default]
    Private _skipNextOpen As Boolean
    Private _isMouseEntered As Boolean

    Public Sub New()
        AutoSize = True
    End Sub

    <Browsable(False)>
    Public Overrides Property ContextMenuStrip As ContextMenuStrip
        Get
            Return SplitMenuStrip
        End Get
        Set(ByVal value As ContextMenuStrip)
            SplitMenuStrip = value
        End Set
    End Property

    <DefaultValue(DirectCast(Nothing, ContextMenu))>
    Public Property SplitMenuStrip As ContextMenuStrip
        Get
            Return _contextSplitMenuStrip
        End Get
        Set(ByVal value As ContextMenuStrip)

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
        Set(ByVal value As Boolean)

            If value <> _showSplit Then
                _showSplit = value
                Invalidate()

                If Parent IsNot Nothing Then
                    Parent.PerformLayout()
                End If
            End If
        End Set
    End Property

    Private Property State As PushButtonState
        Get
            Return _pushButtonState
        End Get
        Set(ByVal value As PushButtonState)

            If Not _pushButtonState.Equals(value) Then
                _pushButtonState = value
                Invalidate()
            End If
        End Set
    End Property

    Protected Overrides Function IsInputKey(ByVal keyData As Keys) As Boolean
        If keyData.Equals(Keys.Down) AndAlso _showSplit Then Return True
        Return MyBase.IsInputKey(keyData)
    End Function

    Protected Overrides Sub OnGotFocus(ByVal e As EventArgs)
        If Not _showSplit Then
            MyBase.OnGotFocus(e)
            Return
        End If

        If Not State.Equals(PushButtonState.Pressed) AndAlso Not State.Equals(PushButtonState.Disabled) Then
            State = PushButtonState.[Default]
        End If
    End Sub

    Protected Overrides Sub OnKeyDown(ByVal kevent As KeyEventArgs)
        If _showSplit Then

            If kevent.KeyCode.Equals(Keys.Down) AndAlso Not _isSplitMenuVisible Then
                ShowContextMenuStrip()
            ElseIf kevent.KeyCode.Equals(Keys.Space) AndAlso kevent.Modifiers = Keys.None Then
                State = PushButtonState.Pressed
            End If
        End If

        MyBase.OnKeyDown(kevent)
    End Sub

    Protected Overrides Sub OnKeyUp(ByVal kevent As KeyEventArgs)
        If kevent.KeyCode.Equals(Keys.Space) Then

            If MouseButtons = MouseButtons.None Then
                State = PushButtonState.Normal
            End If
        ElseIf kevent.KeyCode.Equals(Keys.Apps) Then

            If MouseButtons = MouseButtons.None AndAlso Not _isSplitMenuVisible Then
                ShowContextMenuStrip()
            End If
        End If

        MyBase.OnKeyUp(kevent)
    End Sub

    Protected Overrides Sub OnEnabledChanged(ByVal e As EventArgs)
        State = If(Enabled, PushButtonState.Normal, PushButtonState.Disabled)
        MyBase.OnEnabledChanged(e)
    End Sub

    Protected Overrides Sub OnLostFocus(ByVal e As EventArgs)
        If Not _showSplit Then
            MyBase.OnLostFocus(e)
            Return
        End If

        If Not State.Equals(PushButtonState.Pressed) AndAlso Not State.Equals(PushButtonState.Disabled) Then
            State = PushButtonState.Normal
        End If
    End Sub

    Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
        If Not _showSplit Then
            MyBase.OnMouseEnter(e)
            Return
        End If

        _isMouseEntered = True

        If Not State.Equals(PushButtonState.Pressed) AndAlso Not State.Equals(PushButtonState.Disabled) Then
            State = PushButtonState.Hot
        End If
    End Sub

    Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
        If Not _showSplit Then
            MyBase.OnMouseLeave(e)
            Return
        End If

        _isMouseEntered = False

        If Not State.Equals(PushButtonState.Pressed) AndAlso Not State.Equals(PushButtonState.Disabled) Then
            State = If(Focused, PushButtonState.[Default], PushButtonState.Normal)
        End If
    End Sub

    Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
        If Not _showSplit Then
            MyBase.OnMouseDown(e)
            Return
        End If

        If _contextSplitMenuStrip IsNot Nothing AndAlso e.Button = MouseButtons.Left AndAlso Not _isMouseEntered Then
            _skipNextOpen = True
        End If

        If _dropDownRectangle.Contains(e.Location) AndAlso Not _isSplitMenuVisible AndAlso e.Button = MouseButtons.Left Then
            ShowContextMenuStrip()
        Else
            State = PushButtonState.Pressed
        End If
    End Sub

    Protected Overrides Sub OnMouseUp(ByVal mevent As MouseEventArgs)
        If Not _showSplit Then
            MyBase.OnMouseUp(mevent)
            Return
        End If

        If mevent.Button = MouseButtons.Right AndAlso ClientRectangle.Contains(mevent.Location) AndAlso Not _isSplitMenuVisible Then
            ShowContextMenuStrip()
        ElseIf _contextSplitMenuStrip Is Nothing OrElse Not _isSplitMenuVisible Then
            SetButtonDrawState()

            If ClientRectangle.Contains(mevent.Location) AndAlso Not _dropDownRectangle.Contains(mevent.Location) Then
                OnClick(New EventArgs())
            End If
        End If
    End Sub

    Protected Overrides Sub OnPaint(ByVal pevent As PaintEventArgs)
        MyBase.OnPaint(pevent)
        If Not _showSplit Then Return
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

        _dropDownRectangle = New Rectangle(bounds.Right - _splitSectionWidth, 0, _splitSectionWidth, bounds.Height)
        Dim internalBorder As Integer = _borderSize
        Dim focusRect As Rectangle = New Rectangle(internalBorder - 1, internalBorder - 1, bounds.Width - _dropDownRectangle.Width - internalBorder, bounds.Height - (internalBorder * 2) + 2)
        Dim drawSplitLine As Boolean = (State = PushButtonState.Hot OrElse State = PushButtonState.Pressed OrElse Not Application.RenderWithVisualStyles)

        If RightToLeft = RightToLeft.Yes Then
            _dropDownRectangle.X = bounds.Left + 1
            focusRect.X = _dropDownRectangle.Right

            If drawSplitLine Then
                g.DrawLine(SystemPens.ButtonShadow, bounds.Left + _splitSectionWidth, _borderSize, bounds.Left + _splitSectionWidth, bounds.Bottom - _borderSize)
                g.DrawLine(SystemPens.ButtonFace, bounds.Left + _splitSectionWidth + 1, _borderSize, bounds.Left + _splitSectionWidth + 1, bounds.Bottom - _borderSize)
            End If
        Else

            If drawSplitLine Then
                g.DrawLine(SystemPens.ButtonShadow, bounds.Right - _splitSectionWidth, _borderSize, bounds.Right - _splitSectionWidth, bounds.Bottom - _borderSize)
                g.DrawLine(SystemPens.ButtonFace, bounds.Right - _splitSectionWidth - 1, _borderSize, bounds.Right - _splitSectionWidth - 1, bounds.Bottom - _borderSize)
            End If
        End If

        PaintArrow(g, _dropDownRectangle)
        PaintTextandImage(g, New Rectangle(0, 0, ClientRectangle.Width - _splitSectionWidth, ClientRectangle.Height))

        If State <> PushButtonState.Pressed AndAlso Focused AndAlso ShowFocusCues Then
            ControlPaint.DrawFocusRectangle(g, focusRect)
        End If
    End Sub

    Private Sub PaintTextandImage(ByVal g As Graphics, ByVal bounds As Rectangle)
        Dim text_rectangle As Rectangle
        Dim image_rectangle As Rectangle
        CalculateButtonTextAndImageLayout(bounds, text_rectangle, image_rectangle)

        If Image IsNot Nothing Then

            If Enabled Then
                g.DrawImage(Image, image_rectangle.X, image_rectangle.Y, Image.Width, Image.Height)
            Else
                ControlPaint.DrawImageDisabled(g, Image, image_rectangle.X, image_rectangle.Y, BackColor)
            End If
        End If

        If Not UseMnemonic Then
            _textFormatFlags = _textFormatFlags Or TextFormatFlags.NoPrefix
        ElseIf Not ShowKeyboardCues Then
            _textFormatFlags = _textFormatFlags Or TextFormatFlags.HidePrefix
        End If

        If Not String.IsNullOrEmpty(Text) Then

            If Enabled Then
                TextRenderer.DrawText(g, Text, Font, text_rectangle, ForeColor, _textFormatFlags)
            Else
                ControlPaint.DrawStringDisabled(g, Text, Font, BackColor, text_rectangle, _textFormatFlags)
            End If
        End If
    End Sub

    Private Sub PaintArrow(ByVal g As Graphics, ByVal dropDownRect As Rectangle)
        Dim middle As Point = New Point(Convert.ToInt32(dropDownRect.Left + dropDownRect.Width / 2), Convert.ToInt32(dropDownRect.Top + dropDownRect.Height / 2))
        middle.X += (dropDownRect.Width Mod 2)
        Dim arrow As Point() = {New Point(middle.X - 2, middle.Y - 1), New Point(middle.X + 3, middle.Y - 1), New Point(middle.X, middle.Y + 2)}

        If Enabled Then
            g.FillPolygon(SystemBrushes.ControlText, arrow)
        Else
            g.FillPolygon(SystemBrushes.ButtonShadow, arrow)
        End If
    End Sub

    Public Overrides Function GetPreferredSize(ByVal proposedSize As Size) As Size
        Dim preferredSize As Size = MyBase.GetPreferredSize(proposedSize)

        If _showSplit Then
            If AutoSize Then Return CalculateButtonAutoSize()
            If Not String.IsNullOrEmpty(Text) AndAlso TextRenderer.MeasureText(Text, Font).Width + _splitSectionWidth > preferredSize.Width Then Return preferredSize + New Size(_splitSectionWidth + _borderSize * 2, 0)
        End If

        Return preferredSize
    End Function

    Private Function CalculateButtonAutoSize() As Size
        Dim ret_size As Size = Size.Empty
        Dim text_size As Size = TextRenderer.MeasureText(Text, Font)
        Dim image_size As Size = If(Image Is Nothing, Size.Empty, Image.Size)

        If Text.Length <> 0 Then
            text_size.Height += 4
            text_size.Width += 4
        End If

        Select Case TextImageRelation
            Case TextImageRelation.Overlay
                ret_size.Height = Math.Max(If(Text.Length = 0, 0, text_size.Height), image_size.Height)
                ret_size.Width = Math.Max(text_size.Width, image_size.Width)
            Case TextImageRelation.ImageAboveText, TextImageRelation.TextAboveImage
                ret_size.Height = text_size.Height + image_size.Height
                ret_size.Width = Math.Max(text_size.Width, image_size.Width)
            Case TextImageRelation.ImageBeforeText, TextImageRelation.TextBeforeImage
                ret_size.Height = Math.Max(text_size.Height, image_size.Height)
                ret_size.Width = text_size.Width + image_size.Width
        End Select

        ret_size.Height += (Padding.Vertical + 6)
        ret_size.Width += (Padding.Horizontal + 6)
        If _showSplit Then ret_size.Width += _splitSectionWidth
        Return ret_size
    End Function

    Private Sub CalculateButtonTextAndImageLayout(ByRef content_rect As Rectangle, <Out> ByRef textRectangle As Rectangle, <Out> ByRef imageRectangle As Rectangle)
        Dim text_size As Size = TextRenderer.MeasureText(Text, Font, content_rect.Size, _textFormatFlags)
        Dim image_size As Size = If(Image Is Nothing, Size.Empty, Image.Size)
        textRectangle = Rectangle.Empty
        imageRectangle = Rectangle.Empty

        Select Case TextImageRelation
            Case TextImageRelation.Overlay
                textRectangle = OverlayObjectRect(content_rect, text_size, TextAlign)
                If _pushButtonState = PushButtonState.Pressed AndAlso Not Application.RenderWithVisualStyles Then textRectangle.Offset(1, 1)
                If Image IsNot Nothing Then imageRectangle = OverlayObjectRect(content_rect, image_size, ImageAlign)
            Case TextImageRelation.ImageAboveText
                content_rect.Inflate(-4, -4)
                LayoutTextAboveOrBelowImage(content_rect, False, text_size, image_size, textRectangle, imageRectangle)
            Case TextImageRelation.TextAboveImage
                content_rect.Inflate(-4, -4)
                LayoutTextAboveOrBelowImage(content_rect, True, text_size, image_size, textRectangle, imageRectangle)
            Case TextImageRelation.ImageBeforeText
                content_rect.Inflate(-4, -4)
                LayoutTextBeforeOrAfterImage(content_rect, False, text_size, image_size, textRectangle, imageRectangle)
            Case TextImageRelation.TextBeforeImage
                content_rect.Inflate(-4, -4)
                LayoutTextBeforeOrAfterImage(content_rect, True, text_size, image_size, textRectangle, imageRectangle)
        End Select
    End Sub

    Private Function OverlayObjectRect(ByRef container As Rectangle, ByRef sizeOfObject As Size, ByVal alignment As System.Drawing.ContentAlignment) As Rectangle
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

    Private Sub LayoutTextBeforeOrAfterImage(ByVal totalArea As Rectangle, ByVal textFirst As Boolean, ByVal textSize As Size, ByVal imageSize As Size, <Out> ByRef textRect As Rectangle, <Out> ByRef imageRect As Rectangle)
        Dim element_spacing As Integer = 0
        Dim total_width As Integer = textSize.Width + element_spacing + imageSize.Width
        If Not textFirst Then element_spacing += 2

        If total_width > totalArea.Width Then
            textSize.Width = totalArea.Width - element_spacing - imageSize.Width
            total_width = totalArea.Width
        End If

        Dim excess_width As Integer = totalArea.Width - total_width
        Dim offset As Integer = 0
        Dim final_text_rect As Rectangle
        Dim final_image_rect As Rectangle
        Dim h_text As HorizontalAlignment = GetHorizontalAlignment(TextAlign)
        Dim h_image As HorizontalAlignment = GetHorizontalAlignment(ImageAlign)

        If h_image = HorizontalAlignment.Left Then
            offset = 0
        ElseIf h_image = HorizontalAlignment.Right AndAlso h_text = HorizontalAlignment.Right Then
            offset = excess_width
        ElseIf h_image = HorizontalAlignment.Center AndAlso (h_text = HorizontalAlignment.Left OrElse h_text = HorizontalAlignment.Center) Then
            offset += excess_width / 3
        Else
            offset += 2 * (excess_width / 3)
        End If

        If textFirst Then
            final_text_rect = New Rectangle(totalArea.Left + offset, AlignInRectangle(totalArea, textSize, TextAlign).Top, textSize.Width, textSize.Height)
            final_image_rect = New Rectangle(final_text_rect.Right + element_spacing, AlignInRectangle(totalArea, imageSize, ImageAlign).Top, imageSize.Width, imageSize.Height)
        Else
            final_image_rect = New Rectangle(totalArea.Left + offset, AlignInRectangle(totalArea, imageSize, ImageAlign).Top, imageSize.Width, imageSize.Height)
            final_text_rect = New Rectangle(final_image_rect.Right + element_spacing, AlignInRectangle(totalArea, textSize, TextAlign).Top, textSize.Width, textSize.Height)
        End If

        textRect = final_text_rect
        imageRect = final_image_rect
    End Sub

    Private Sub LayoutTextAboveOrBelowImage(ByVal totalArea As Rectangle, ByVal textFirst As Boolean, ByVal textSize As Size, ByVal imageSize As Size, <Out> ByRef textRect As Rectangle, <Out> ByRef imageRect As Rectangle)
        Dim element_spacing As Integer = 0
        Dim total_height As Integer = textSize.Height + element_spacing + imageSize.Height
        If textFirst Then element_spacing += 2
        If textSize.Width > totalArea.Width Then textSize.Width = totalArea.Width

        If total_height > totalArea.Height AndAlso textFirst Then
            imageSize = Size.Empty
            total_height = totalArea.Height
        End If

        Dim excess_height As Integer = totalArea.Height - total_height
        Dim offset As Integer = 0
        Dim final_text_rect As Rectangle
        Dim final_image_rect As Rectangle
        Dim v_text As VerticalAlignment = GetVerticalAlignment(TextAlign)
        Dim v_image As VerticalAlignment = GetVerticalAlignment(ImageAlign)

        If v_image = VerticalAlignment.Top Then
            offset = 0
        ElseIf v_image = VerticalAlignment.Bottom AndAlso v_text = VerticalAlignment.Bottom Then
            offset = excess_height
        ElseIf v_image = VerticalAlignment.Center AndAlso (v_text = VerticalAlignment.Top OrElse v_text = VerticalAlignment.Center) Then
            offset += excess_height / 3
        Else
            offset += 2 * (excess_height / 3)
        End If

        If textFirst Then
            final_text_rect = New Rectangle(AlignInRectangle(totalArea, textSize, TextAlign).Left, totalArea.Top + offset, textSize.Width, textSize.Height)
            final_image_rect = New Rectangle(AlignInRectangle(totalArea, imageSize, ImageAlign).Left, final_text_rect.Bottom + element_spacing, imageSize.Width, imageSize.Height)
        Else
            final_image_rect = New Rectangle(AlignInRectangle(totalArea, imageSize, ImageAlign).Left, totalArea.Top + offset, imageSize.Width, imageSize.Height)
            final_text_rect = New Rectangle(AlignInRectangle(totalArea, textSize, TextAlign).Left, final_image_rect.Bottom + element_spacing, textSize.Width, textSize.Height)
            If final_text_rect.Bottom > totalArea.Bottom Then final_text_rect.Y = totalArea.Top
        End If

        textRect = final_text_rect
        imageRect = final_image_rect
    End Sub

    Private Function GetHorizontalAlignment(ByVal align As System.Drawing.ContentAlignment) As HorizontalAlignment
        Select Case align
            Case System.Drawing.ContentAlignment.BottomLeft, System.Drawing.ContentAlignment.MiddleLeft, System.Drawing.ContentAlignment.TopLeft
                Return HorizontalAlignment.Left
            Case System.Drawing.ContentAlignment.BottomCenter, System.Drawing.ContentAlignment.MiddleCenter, System.Drawing.ContentAlignment.TopCenter
                Return HorizontalAlignment.Center
            Case System.Drawing.ContentAlignment.BottomRight, System.Drawing.ContentAlignment.MiddleRight, System.Drawing.ContentAlignment.TopRight
                Return HorizontalAlignment.Right
        End Select

        Return HorizontalAlignment.Left
    End Function

    Private Function GetVerticalAlignment(ByVal align As System.Drawing.ContentAlignment) As VerticalAlignment
        Select Case align
            Case System.Drawing.ContentAlignment.TopLeft, System.Drawing.ContentAlignment.TopCenter, System.Drawing.ContentAlignment.TopRight
                Return VerticalAlignment.Top
            Case System.Drawing.ContentAlignment.MiddleLeft, System.Drawing.ContentAlignment.MiddleCenter, System.Drawing.ContentAlignment.MiddleRight
                Return VerticalAlignment.Center
            Case System.Drawing.ContentAlignment.BottomLeft, System.Drawing.ContentAlignment.BottomCenter, System.Drawing.ContentAlignment.BottomRight
                Return VerticalAlignment.Bottom
        End Select

        Return VerticalAlignment.Top
    End Function

    Private Function AlignInRectangle(ByVal outer As Rectangle, ByVal inner As Size, ByVal align As System.Drawing.ContentAlignment) As Rectangle
        Dim x As Integer = 0
        Dim y As Integer = 0

        If align = System.Drawing.ContentAlignment.BottomLeft OrElse align = System.Drawing.ContentAlignment.MiddleLeft OrElse align = System.Drawing.ContentAlignment.TopLeft Then
            x = outer.X
        ElseIf align = System.Drawing.ContentAlignment.BottomCenter OrElse align = System.Drawing.ContentAlignment.MiddleCenter OrElse align = System.Drawing.ContentAlignment.TopCenter Then
            x = Math.Max(outer.X + ((outer.Width - inner.Width) / 2), outer.Left)
        ElseIf align = System.Drawing.ContentAlignment.BottomRight OrElse align = System.Drawing.ContentAlignment.MiddleRight OrElse align = System.Drawing.ContentAlignment.TopRight Then
            x = outer.Right - inner.Width
        End If

        If align = System.Drawing.ContentAlignment.TopCenter OrElse align = System.Drawing.ContentAlignment.TopLeft OrElse align = System.Drawing.ContentAlignment.TopRight Then
            y = outer.Y
        ElseIf align = System.Drawing.ContentAlignment.MiddleCenter OrElse align = System.Drawing.ContentAlignment.MiddleLeft OrElse align = System.Drawing.ContentAlignment.MiddleRight Then
            y = outer.Y + (outer.Height - inner.Height) / 2
        ElseIf align = System.Drawing.ContentAlignment.BottomCenter OrElse align = System.Drawing.ContentAlignment.BottomRight OrElse align = System.Drawing.ContentAlignment.BottomLeft Then
            y = outer.Bottom - inner.Height
        End If

        Return New Rectangle(x, y, Math.Min(inner.Width, outer.Width), Math.Min(inner.Height, outer.Height))
    End Function

    Private Sub ShowContextMenuStrip()
        If _skipNextOpen Then
            _skipNextOpen = False
            Return
        End If

        State = PushButtonState.Pressed

        If _contextSplitMenuStrip IsNot Nothing Then
            _contextSplitMenuStrip.Show(Me, New Point(0, Height), ToolStripDropDownDirection.BelowRight)
        End If
    End Sub

    Private Sub SplitMenuStrip_Opening(ByVal sender As Object, ByVal e As CancelEventArgs)
        _isSplitMenuVisible = True
    End Sub

    Private Sub SplitMenuStrip_Closing(ByVal sender As Object, ByVal e As ToolStripDropDownClosingEventArgs)
        _isSplitMenuVisible = False
        SetButtonDrawState()

        If e.CloseReason = ToolStripDropDownCloseReason.AppClicked Then
            _skipNextOpen = (_dropDownRectangle.Contains(PointToClient(Cursor.Position))) AndAlso MouseButtons = MouseButtons.Left
        End If
    End Sub

    Private Sub SplitMenu_Popup(ByVal sender As Object, ByVal e As EventArgs)
        _isSplitMenuVisible = True
    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)
        If m.Msg = &H212 Then
            _isSplitMenuVisible = False
            SetButtonDrawState()
        End If

        MyBase.WndProc(m)
    End Sub

    Private Sub SetButtonDrawState()
        If Bounds.Contains(Parent.PointToClient(Cursor.Position)) Then
            State = PushButtonState.Hot
        ElseIf Focused Then
            State = PushButtonState.[Default]
        ElseIf Not Enabled Then
            State = PushButtonState.Disabled
        Else
            State = PushButtonState.Normal
        End If
    End Sub
End Class


