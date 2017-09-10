Imports System.Net
Imports System.IO

Module mdlDownload
    Public Function funcGetHosts() As String
        '下载Hosts文件并返回文件内容
        Try
            '从Coding获取Hosts文件
            Dim varStream As IO.Stream = WebRequest.Create("https://coding.net/u/scaffrey/p/hosts/git/raw/master/hosts-files/hosts").GetResponse().GetResponseStream()
            'Github路径(当Coding无法访问时替换此代码)
            'Dim varStream As IO.Stream = WebRequest.Create("https://raw.githubusercontent.com/googlehosts/hosts/master/hosts-files/hosts").GetResponse().GetResponseStream()
            Dim varSr As StreamReader = New StreamReader(varStream, System.Text.Encoding.UTF8)
            Return varSr.ReadToEnd()
            varSr.Dispose()
        Catch varExc As Exception
            Return ""
            mdlMessageBox.MessageBox(varExc.Message)
        End Try
    End Function

    Public Function subStatistics() As String
        '收集统计信息并检查更新
        Try
            Dim varUpdateInfo
            Dim varStream As IO.Stream = WebRequest.Create("http://hosts.endless-ss.com/count.php").GetResponse().GetResponseStream()
            varStream.Dispose()

            varStream = WebRequest.Create("https://raw.githubusercontent.com/Observateurs/LibertyHosts/master/Update/latest.txt").GetResponse().GetResponseStream()
            Dim varSr As StreamReader = New StreamReader(varStream, System.Text.Encoding.UTF8)
            varUpdateInfo = varSr.ReadLine
            varUpdateInfo = Replace(varUpdateInfo, "Latest Version:", "")
            If varUpdateInfo <> "1.01" Then
                Return varUpdateInfo
            Else
                Return ""
            End If
            varSr.Dispose()

        Catch varExc As Exception
            Return ""
            mdlMessageBox.MessageBox(varExc.Message)
        End Try
    End Function
End Module
