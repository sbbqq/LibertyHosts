Public Class formToolbox
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

    Private Sub formToolbox_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0)
    End Sub

    Private Sub MinimizeButton_Click(sender As Object, e As EventArgs) Handles MinimizeButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
        formMain.Show()
    End Sub

    Private Sub ViewHostsButton_Click(sender As Object, e As EventArgs) Handles ViewHostsButton.Click
        Try
            System.Diagnostics.Process.Start("explorer.exe", "/select," & mdlFile.funcGetHostsDir)
        Catch varExc As Exception
            mdlMessageBox.MessageBox(varExc.Message)
        End Try
    End Sub

    Private Sub EditHosts_Click(sender As Object, e As EventArgs) Handles EditHosts.Click
        Try
            'System.Diagnostics.Process.Start(mdlFile.funcGetHostsDir)
            Me.Hide()
            formHostsEditor.Show()
        Catch varExc As Exception
            mdlMessageBox.MessageBox(varExc.Message)
        End Try
    End Sub

    Private Sub CleanHosts_Click(sender As Object, e As EventArgs) Handles CleanHosts.Click
        Try
            Dim varWriteHosts As Boolean
            varWriteHosts = mdlFile.funcWirteHosts("", True)
            CleanHosts.Text = "已经停止自由上网"
        Catch varExc As Exception
            mdlMessageBox.MessageBox(varExc.Message)
        End Try
    End Sub

    Private Sub About_Click(sender As Object, e As EventArgs) Handles About.Click
        mdlMessageBox.MessageBox("LibertyHosts 1.01 By Observateurs" & vbNewLine _
                         & "Github:https://github.com/Observateurs/LibertyHosts" & vbNewLine _
                         & "Apache License 2.0" & vbNewLine _
                         & "Hosts源地址:https://github.com/googlehosts/hosts",
                        "关于 LibertyHosts")
    End Sub
End Class