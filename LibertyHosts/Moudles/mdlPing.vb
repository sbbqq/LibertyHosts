Imports System.Net.NetworkInformation
Module mdlPing
    Function funcPing(varUrl As String) As Single
        Try
            '如果没有指定IP,则默认Ping Google.com
            If varUrl.Length = 0 Then
                varUrl = "google.com"
            End If

            Dim varPing As Ping = New Ping()
            Dim varPingReply As PingReply
            varPingReply = varPing.Send(varUrl)

            '如果Ping成功返回延迟,失败返回-1
            If (varPingReply.Status = IPStatus.Success) Then
                Return varPingReply.RoundtripTime
            Else
                Return -1
            End If

        Catch varExc As Exception
            mdlMessageBox.MessageBox(varExc.Message)
            Return -1
        End Try
    End Function
End Module
