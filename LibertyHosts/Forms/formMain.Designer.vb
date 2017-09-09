<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formMain
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formMain))
        Me.GetHostsButton = New System.Windows.Forms.Button()
        Me.CheckHostsButton = New System.Windows.Forms.Button()
        Me.ToolBoxButton = New System.Windows.Forms.Button()
        Me.Label = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MinimizeButton = New System.Windows.Forms.PictureBox()
        Me.CloseButton = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinimizeButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CloseButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GetHostsButton
        '
        Me.GetHostsButton.BackColor = System.Drawing.Color.White
        Me.GetHostsButton.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GetHostsButton.ForeColor = System.Drawing.Color.Black
        Me.GetHostsButton.Location = New System.Drawing.Point(13, 254)
        Me.GetHostsButton.Name = "GetHostsButton"
        Me.GetHostsButton.Size = New System.Drawing.Size(182, 51)
        Me.GetHostsButton.TabIndex = 3
        Me.GetHostsButton.Text = "自由上网"
        Me.GetHostsButton.UseVisualStyleBackColor = False
        '
        'CheckHostsButton
        '
        Me.CheckHostsButton.BackColor = System.Drawing.Color.White
        Me.CheckHostsButton.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CheckHostsButton.ForeColor = System.Drawing.Color.Black
        Me.CheckHostsButton.Location = New System.Drawing.Point(209, 254)
        Me.CheckHostsButton.Name = "CheckHostsButton"
        Me.CheckHostsButton.Size = New System.Drawing.Size(182, 51)
        Me.CheckHostsButton.TabIndex = 4
        Me.CheckHostsButton.Text = "检查网络状态"
        Me.CheckHostsButton.UseVisualStyleBackColor = False
        '
        'ToolBoxButton
        '
        Me.ToolBoxButton.BackColor = System.Drawing.Color.White
        Me.ToolBoxButton.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ToolBoxButton.ForeColor = System.Drawing.Color.Black
        Me.ToolBoxButton.Location = New System.Drawing.Point(405, 254)
        Me.ToolBoxButton.Name = "ToolBoxButton"
        Me.ToolBoxButton.Size = New System.Drawing.Size(182, 51)
        Me.ToolBoxButton.TabIndex = 5
        Me.ToolBoxButton.Text = "进阶选项"
        Me.ToolBoxButton.UseVisualStyleBackColor = False
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label.ForeColor = System.Drawing.Color.Gray
        Me.Label.Location = New System.Drawing.Point(232, 189)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(135, 21)
        Me.Label.TabIndex = 6
        Me.Label.Text = "Fight For Liberty" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LibertyHosts.My.Resources.Resources.googlelogo
        Me.PictureBox1.Location = New System.Drawing.Point(163, 69)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(272, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'MinimizeButton
        '
        Me.MinimizeButton.Image = Global.LibertyHosts.My.Resources.Resources.MinimizeW
        Me.MinimizeButton.Location = New System.Drawing.Point(501, 0)
        Me.MinimizeButton.Name = "MinimizeButton"
        Me.MinimizeButton.Size = New System.Drawing.Size(50, 40)
        Me.MinimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.MinimizeButton.TabIndex = 1
        Me.MinimizeButton.TabStop = False
        '
        'CloseButton
        '
        Me.CloseButton.Image = Global.LibertyHosts.My.Resources.Resources.CloseW
        Me.CloseButton.Location = New System.Drawing.Point(551, 0)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(50, 40)
        Me.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.CloseButton.TabIndex = 0
        Me.CloseButton.TabStop = False
        '
        'formMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(598, 328)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.ToolBoxButton)
        Me.Controls.Add(Me.CheckHostsButton)
        Me.Controls.Add(Me.GetHostsButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MinimizeButton)
        Me.Controls.Add(Me.CloseButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liberty Hosts"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinimizeButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CloseButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CloseButton As PictureBox
    Friend WithEvents MinimizeButton As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GetHostsButton As Button
    Friend WithEvents CheckHostsButton As Button
    Friend WithEvents ToolBoxButton As Button
    Friend WithEvents Label As Label
End Class
