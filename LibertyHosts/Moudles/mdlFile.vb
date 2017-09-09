Imports System.IO
Module mdlFile
    Dim varSysRoot As String = Environ("SystemRoot")
    Dim varHostsDir As String = varSysRoot & "\System32\drivers\etc\hosts"
    'Function funcReadHosts() As String

    'End Function

    Function funcWirteHosts(varText As String, varShell As Boolean) As Boolean
        Try
            Dim varNow As String = Now.ToString("-yyyy-MM-dd-HH-mm-ss.bak") '创建备份文件
            File.Copy(varHostsDir, varHostsDir & varNow)

            Dim varStr As New IO.StreamWriter(varHostsDir)
            If File.Exists(varHostsDir) = True Then
                varStr.WriteLine(varText)
            Else
                File.Create(varHostsDir)
                varStr.WriteLine(varText)
            End If
            varStr.Close()

            If varShell = True Then
                Shell("cmd.exe /c ipconfig/flushdns", AppWinStyle.Hide) '调用Bash刷新DNS缓存
            End If

            Return True
        Catch varExc As Exception
            Return False
            MessageBox.Show(varExc.Message, Nothing, Nothing, MessageBoxIcon.Error)
        End Try
    End Function

    Function funcGetHostsDir() As String
        Return varHostsDir
    End Function
End Module
