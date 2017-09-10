Module mdlMessageBox
    Function MessageBox(varText As String, Optional varTitle As String = "", Optional var2Button As Boolean = False)
        formMessageBox.TextLabel.Text = varText

        If formMessageBox.TextLabel.Width + 20 >= formMessageBox.Width Then '如果宽度超出窗口则扩大窗口
            formMessageBox.Width = formMessageBox.TextLabel.Width + 100
        End If
        If formMessageBox.TextLabel.Height + 100 >= formMessageBox.Height Then '如果高度超出窗口则扩大窗口
            formMessageBox.Height = formMessageBox.TextLabel.Height + 100
        End If
        formMessageBox.TextLabel.Left = (formMessageBox.Width - formMessageBox.TextLabel.Width) \ 2 '文字居中
        formMessageBox.OKButton.Top = (formMessageBox.Height - formMessageBox.OKButton.Height - 12) '按钮始终在下面
        formMessageBox.CloseButton.Left = (formMessageBox.Width - 50) '退出按钮始终在右侧

        If var2Button = False Then
            formMessageBox.NoButton.Visible = False
            formMessageBox.OKButton.Left = (formMessageBox.Width - formMessageBox.OKButton.Width) \ 2 '按钮居中
        Else
            formMessageBox.NoButton.Visible = True
        End If
        If varTitle = "" Then
            varTitle = "LibertyHosts 运行时出错"
        End If

        formMessageBox.TitleLabel.Text = varTitle
        formMessageBox.Show()
        Return 0
    End Function
End Module
