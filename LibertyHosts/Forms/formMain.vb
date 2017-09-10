Imports System.Threading
Public Class formMain
    Dim thGetHostsFile As Thread '获取Hosts文件的线程
    Dim thPing As Thread '获取延迟的线程
    Dim thStatistics As Thread '收集统计信息的线程

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

    Private Sub frmMain_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0)
    End Sub
    Private Sub Statistics()
        Try
            '收集统计信息并检查更新
            Dim varUpdateInfo As String
            varUpdateInfo = mdlDownload.subStatistics()
            If varUpdateInfo <> "" Then
                varUpdateInfo = "检测到新版本:" & varUpdateInfo & vbNewLine & "点击此处升级"
                Me.Invoke(New subLabelDelegate(AddressOf SetInfo), varUpdateInfo)
                Me.Invoke(New subLabelDelegate(AddressOf EnableLabel), varUpdateInfo)
            End If
        Finally
            thStatistics.Abort()
        End Try
    End Sub
    Private Sub formMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        thStatistics = New Thread(AddressOf Statistics)
        thStatistics.Start()
    End Sub

    Private Sub MinimizeButton_Click(sender As Object, e As EventArgs) Handles MinimizeButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        End
    End Sub

    Private Sub ToolBoxButton_Click(sender As Object, e As EventArgs) Handles ToolBoxButton.Click
        formToolbox.Show()
        Me.Hide()
    End Sub

    Private Sub GetHostsButton_Click(sender As Object, e As EventArgs) Handles GetHostsButton.Click
        thGetHostsFile = New Thread(AddressOf GetHosts)
        thGetHostsFile.Start()
    End Sub

    Private Sub GetHosts()
        Try
            Dim varInfo As String
            Dim varHostsText As String
            Dim varWriteHosts As Boolean
            varInfo = "获取Hosts文件中"
            Me.Invoke(New subLabelDelegate(AddressOf SetInfo), varInfo)

            varHostsText = mdlDownload.funcGetHosts()
            If varHostsText = "" Then
                varInfo = "获取Hosts文件失败"
                Me.Invoke(New subLabelDelegate(AddressOf SetInfo), varInfo)
                thGetHostsFile.Abort()
                Exit Sub
            End If

            varInfo = "写入Hosts文件中"
            Me.Invoke(New subLabelDelegate(AddressOf SetInfo), varInfo)
            varWriteHosts = mdlFile.funcWirteHosts(varHostsText, True)

            If varWriteHosts = False Then
                varInfo = "写入Hosts文件失败"
                Me.Invoke(New subLabelDelegate(AddressOf SetInfo), varInfo)
                thGetHostsFile.Abort()
                Exit Sub
            End If
            varInfo = "Hosts修改完成" & vbNewLine & "请点击''检查网络状态''来验证自由上网是否成功"
            Me.Invoke(New subLabelDelegate(AddressOf SetInfo), varInfo)

        Catch varExc As Exception
            MessageBox.Show(varExc.Message, Nothing, Nothing, MessageBoxIcon.Error)
        Finally
            thGetHostsFile.Abort()
        End Try
    End Sub
    Private Delegate Sub subLabelDelegate(ByVal varString As String) '自定义一个委托

    Private Sub SetInfo(ByVal Info As String) '与委托相同签名的函数或过程
        Me.Label.Text = Info
        Me.Label.Left = (Me.Width - Me.Label.Width) \ 2
    End Sub
    Private Sub EnableLabel(ByVal Info As String)
        Me.Label.Enabled = Enabled
    End Sub

    Private Sub CheckHostsButton_Click(sender As Object, e As EventArgs) Handles CheckHostsButton.Click
        thPing = New Thread(AddressOf Ping)
        thPing.Start()
    End Sub

    Private Sub Ping()
        Try
            Dim varPingReply As Single
            Dim varInfo As String

            varPingReply = mdlPing.funcPing("google.com")
            If varPingReply = -1 Then
                varInfo = "自由上网失败,无法连接到Google"
                Me.Invoke(New subLabelDelegate(AddressOf SetInfo), varInfo)
            Else
                varInfo = "自由上网成功" & vbNewLine & "Google延迟:" & varPingReply & "Ms,请使用Https访问Google"
                Me.Invoke(New subLabelDelegate(AddressOf SetInfo), varInfo)
            End If

        Catch varExc As Exception
            MessageBox.Show(varExc.Message, Nothing, Nothing, MessageBoxIcon.Error)
        Finally
            thPing.Abort()
        End Try
    End Sub

    Private Sub Label_Click(sender As Object, e As EventArgs) Handles Label.Click
        System.Diagnostics.Process.Start("https://pan.baidu.com/s/1bp71HMZ")
    End Sub
End Class
