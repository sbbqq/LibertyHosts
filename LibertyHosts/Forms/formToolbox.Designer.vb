<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formToolbox
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formToolbox))
        Me.MinimizeButton = New System.Windows.Forms.PictureBox()
        Me.CloseButton = New System.Windows.Forms.PictureBox()
        Me.ViewHostsButton = New System.Windows.Forms.Button()
        Me.EditHosts = New System.Windows.Forms.Button()
        Me.CleanHosts = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.MinimizeButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CloseButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MinimizeButton
        '
        Me.MinimizeButton.Image = Global.LibertyHosts.My.Resources.Resources.MinimizeW
        Me.MinimizeButton.Location = New System.Drawing.Point(176, 0)
        Me.MinimizeButton.Name = "MinimizeButton"
        Me.MinimizeButton.Size = New System.Drawing.Size(50, 40)
        Me.MinimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.MinimizeButton.TabIndex = 3
        Me.MinimizeButton.TabStop = False
        '
        'CloseButton
        '
        Me.CloseButton.Image = Global.LibertyHosts.My.Resources.Resources.CloseW
        Me.CloseButton.Location = New System.Drawing.Point(226, 0)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(50, 40)
        Me.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.CloseButton.TabIndex = 2
        Me.CloseButton.TabStop = False
        '
        'ViewHostsButton
        '
        Me.ViewHostsButton.BackColor = System.Drawing.Color.White
        Me.ViewHostsButton.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ViewHostsButton.ForeColor = System.Drawing.Color.Black
        Me.ViewHostsButton.Location = New System.Drawing.Point(46, 66)
        Me.ViewHostsButton.Name = "ViewHostsButton"
        Me.ViewHostsButton.Size = New System.Drawing.Size(182, 51)
        Me.ViewHostsButton.TabIndex = 4
        Me.ViewHostsButton.Text = "访问Hosts文件夹"
        Me.ViewHostsButton.UseVisualStyleBackColor = False
        '
        'EditHosts
        '
        Me.EditHosts.BackColor = System.Drawing.Color.White
        Me.EditHosts.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.EditHosts.ForeColor = System.Drawing.Color.Black
        Me.EditHosts.Location = New System.Drawing.Point(46, 139)
        Me.EditHosts.Name = "EditHosts"
        Me.EditHosts.Size = New System.Drawing.Size(182, 51)
        Me.EditHosts.TabIndex = 5
        Me.EditHosts.Text = "编辑Hosts文件"
        Me.EditHosts.UseVisualStyleBackColor = False
        '
        'CleanHosts
        '
        Me.CleanHosts.BackColor = System.Drawing.Color.White
        Me.CleanHosts.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CleanHosts.ForeColor = System.Drawing.Color.Black
        Me.CleanHosts.Location = New System.Drawing.Point(46, 212)
        Me.CleanHosts.Name = "CleanHosts"
        Me.CleanHosts.Size = New System.Drawing.Size(182, 51)
        Me.CleanHosts.TabIndex = 6
        Me.CleanHosts.Text = "停止自由上网"
        Me.CleanHosts.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(44, 285)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(182, 51)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "关于"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'formToolbox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(275, 382)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.CleanHosts)
        Me.Controls.Add(Me.EditHosts)
        Me.Controls.Add(Me.ViewHostsButton)
        Me.Controls.Add(Me.MinimizeButton)
        Me.Controls.Add(Me.CloseButton)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formToolbox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmToolbox"
        CType(Me.MinimizeButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CloseButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MinimizeButton As PictureBox
    Friend WithEvents CloseButton As PictureBox
    Friend WithEvents ViewHostsButton As Button
    Friend WithEvents EditHosts As Button
    Friend WithEvents CleanHosts As Button
    Friend WithEvents Button3 As Button
End Class
