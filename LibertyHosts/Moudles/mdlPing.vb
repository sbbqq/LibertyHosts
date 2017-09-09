Imports System.Net.NetworkInformation
Module mdlPing
    Function funcPing(varUrl As String) As Single
        Try
            If varUrl.Length = 0 Then
                varUrl = "google.com" '默认Ping Google.com
            End If

            Dim varPing As Ping = New Ping()
            Dim varPingReply As PingReply
            varPingReply = varPing.Send(varUrl)

            If (varPingReply.Status = IPStatus.Success) Then '如果Ping成功返回延迟，失败返回-1
                Return varPingReply.RoundtripTime
            Else
                Return -1
            End If

        Catch varExc As Exception
            MessageBox.Show(varExc.Message, Nothing, Nothing, MessageBoxIcon.Error)
            Return -1
        End Try
    End Function
End Module
