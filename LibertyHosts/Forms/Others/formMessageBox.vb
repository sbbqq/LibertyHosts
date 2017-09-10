Imports System.IO
Public Class formMessageBox
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

    Private Sub formMessageBox_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0)
    End Sub
    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        Me.Hide()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Hide()
    End Sub
End Class