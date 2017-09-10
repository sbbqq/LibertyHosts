<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMessageBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formMessageBox))
        Me.CloseButton = New System.Windows.Forms.PictureBox()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.TextLabel = New System.Windows.Forms.Label()
        Me.NoButton = New System.Windows.Forms.Button()
        CType(Me.CloseButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CloseButton
        '
        Me.CloseButton.Image = Global.LibertyHosts.My.Resources.Resources.CloseW
        Me.CloseButton.Location = New System.Drawing.Point(305, 0)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(50, 40)
        Me.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.CloseButton.TabIndex = 2
        Me.CloseButton.TabStop = False
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TitleLabel.ForeColor = System.Drawing.Color.Black
        Me.TitleLabel.Location = New System.Drawing.Point(6, 8)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(183, 17)
        Me.TitleLabel.TabIndex = 3
        Me.TitleLabel.Text = "LibertyHosts MessageBox"
        '
        'OKButton
        '
        Me.OKButton.BackColor = System.Drawing.Color.White
        Me.OKButton.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.OKButton.ForeColor = System.Drawing.Color.Black
        Me.OKButton.Location = New System.Drawing.Point(35, 99)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(138, 33)
        Me.OKButton.TabIndex = 4
        Me.OKButton.Text = "确定"
        Me.OKButton.UseVisualStyleBackColor = False
        '
        'TextLabel
        '
        Me.TextLabel.AutoSize = True
        Me.TextLabel.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextLabel.ForeColor = System.Drawing.Color.Black
        Me.TextLabel.Location = New System.Drawing.Point(113, 47)
        Me.TextLabel.Name = "TextLabel"
        Me.TextLabel.Size = New System.Drawing.Size(126, 17)
        Me.TextLabel.TabIndex = 5
        Me.TextLabel.Text = "Default TextLabel"
        '
        'NoButton
        '
        Me.NoButton.BackColor = System.Drawing.Color.White
        Me.NoButton.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.NoButton.ForeColor = System.Drawing.Color.Black
        Me.NoButton.Location = New System.Drawing.Point(179, 99)
        Me.NoButton.Name = "NoButton"
        Me.NoButton.Size = New System.Drawing.Size(138, 33)
        Me.NoButton.TabIndex = 6
        Me.NoButton.Text = "取消"
        Me.NoButton.UseVisualStyleBackColor = False
        '
        'formMessageBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(353, 144)
        Me.Controls.Add(Me.NoButton)
        Me.Controls.Add(Me.TextLabel)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.CloseButton)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formMessageBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MessageBox"
        Me.TopMost = True
        CType(Me.CloseButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CloseButton As PictureBox
    Friend WithEvents TitleLabel As Label
    Friend WithEvents OKButton As Button
    Friend WithEvents TextLabel As Label
    Friend WithEvents NoButton As Button
End Class
