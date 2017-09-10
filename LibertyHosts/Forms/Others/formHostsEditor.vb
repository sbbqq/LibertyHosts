Imports System.IO
Public Class formHostsEditor
    Private varOriginalRegion As Region = Nothing   '用于窗体移动 　　
    Private varFormDragging As Boolean = False
    Private varPointClicked As Point

    Declare Function SendMessage Lib "user32" Alias "SendMessageA" (
                                              ByVal hwnd As IntPtr,
                                              ByVal wMsg As Integer,
                                              ByVal wParam As Integer,
                                              ByVal lParam As Integer) _
                                              As Boolean
    Declare Function ReleaseCapture Lib "user32" Alias "ReleaseCapture" () As Boolean
    Const WM_SYSCOMMAND = &H112
    Const SC_MOVE = &HF010&
    Const HTCAPTION = 2
    Dim isFirstOpen As Boolean = True
    Private Sub formHostsEditor_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0)
    End Sub

    Private Sub showLineNum()
        '在Panel中显示RichTextBox的行号
        Dim p As Point = New Point(0, 0)
        Dim crntFirstIndex As Integer = Me.RichTextBox.GetCharIndexFromPosition(p)

        Dim crntFirstLine As Integer = Me.RichTextBox.GetLineFromCharIndex(crntFirstIndex)

        Dim crntFirstPos As Point = Me.RichTextBox.GetPositionFromCharIndex(crntFirstIndex)

        p.Y += Me.RichTextBox.Height

        Dim crntLastIndex As Integer = Me.RichTextBox.GetCharIndexFromPosition(p)

        Dim crntLastLine As Integer = Me.RichTextBox.GetLineFromCharIndex(crntLastIndex)
        Dim crntLastPos As Point = Me.RichTextBox.GetPositionFromCharIndex(crntLastIndex)

        Dim g As Graphics = Me.Panel.CreateGraphics()

        Dim font As New Font(Me.RichTextBox.Font, Me.RichTextBox.Font.Style)

        Dim brush As New SolidBrush(Color.Green)

        Dim rect As Rectangle = Me.Panel.ClientRectangle
        brush.Color = Me.Panel.BackColor

        g.FillRectangle(brush, 0, 0, Me.Panel.ClientRectangle.Width, Me.Panel.ClientRectangle.Height)

        brush.Color = Color.Gray

        Dim lineSpace As Integer = 0

        If crntFirstLine <> crntLastLine Then

            lineSpace = (crntLastPos.Y - crntFirstPos.Y) / (crntLastLine - crntFirstLine)
        Else


            lineSpace = Convert.ToInt32(Me.RichTextBox.Font.Size)
        End If

        Dim brushX As Integer = Me.Panel.ClientRectangle.Width - Convert.ToInt32(font.Size * 3)

        Dim brushY As Integer = crntLastPos.Y + Convert.ToInt32(font.Size * 0.21F)

        For i As Integer = crntLastLine To crntFirstLine Step -1

            g.DrawString((i + 1).ToString(), font, brush, brushX, brushY)

            brushY -= lineSpace
        Next

        g.Dispose()

        font.Dispose()

        brush.Dispose()
    End Sub

    Private Sub RichTextBox_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox.TextChanged
        showLineNum()
    End Sub

    Private Sub RichTextBox_VScroll(sender As Object, e As EventArgs) Handles RichTextBox.VScroll
        showLineNum()
    End Sub

    Private Sub MinimizeButton_Click(sender As Object, e As EventArgs) Handles MinimizeButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        isFirstOpen = True
        Me.Close()
        formToolbox.Show()
    End Sub

    Private Sub formHostsEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim varHostsDir As String = mdlFile.funcGetHostsDir
            If File.Exists(varHostsDir) = True Then
                Me.RichTextBox.Text = mdlFile.funcReadHosts()
                showLineNum()
            Else
                Dim excException As New ArgumentException("Hosts文件不存在")
                Throw excException
            End If
            Me.RichTextBox.Focus()
        Catch varExc As Exception
            mdlMessageBox.MessageBox(varExc.Message)
        End Try
    End Sub

    Private Sub RichTextBox_MouseMove(sender As Object, e As MouseEventArgs) Handles RichTextBox.MouseMove
        If isFirstOpen = True Then
            showLineNum()
            isFirstOpen = False
        End If
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Try
            Dim varHostsDir As String = mdlFile.funcGetHostsDir
            If File.Exists(varHostsDir) = True Then
                Me.RichTextBox.SaveFile(varHostsDir, RichTextBoxStreamType.PlainText)
            Else
                Dim excException As New ArgumentException("Hosts文件不存在")
                Throw excException
            End If
        Catch varExc As Exception
            mdlMessageBox.MessageBox(varExc.Message)
        End Try
    End Sub
End Class