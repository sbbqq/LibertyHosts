<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formHostsEditor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formHostsEditor))
        Me.MinimizeButton = New System.Windows.Forms.PictureBox()
        Me.CloseButton = New System.Windows.Forms.PictureBox()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.RichTextBox = New System.Windows.Forms.RichTextBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        CType(Me.MinimizeButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CloseButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MinimizeButton
        '
        Me.MinimizeButton.Image = Global.LibertyHosts.My.Resources.Resources.MinimizeW
        Me.MinimizeButton.Location = New System.Drawing.Point(1181, 0)
        Me.MinimizeButton.Name = "MinimizeButton"
        Me.MinimizeButton.Size = New System.Drawing.Size(50, 40)
        Me.MinimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.MinimizeButton.TabIndex = 3
        Me.MinimizeButton.TabStop = False
        '
        'CloseButton
        '
        Me.CloseButton.Image = Global.LibertyHosts.My.Resources.Resources.CloseW
        Me.CloseButton.Location = New System.Drawing.Point(1231, 0)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(50, 40)
        Me.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.CloseButton.TabIndex = 2
        Me.CloseButton.TabStop = False
        '
        'Panel
        '
        Me.Panel.BackColor = System.Drawing.Color.White
        Me.Panel.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Panel.ForeColor = System.Drawing.Color.Gray
        Me.Panel.Location = New System.Drawing.Point(0, 57)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(53, 666)
        Me.Panel.TabIndex = 3
        '
        'RichTextBox
        '
        Me.RichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RichTextBox.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.RichTextBox.Location = New System.Drawing.Point(59, 57)
        Me.RichTextBox.Name = "RichTextBox"
        Me.RichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.RichTextBox.Size = New System.Drawing.Size(1222, 666)
        Me.RichTextBox.TabIndex = 2
        Me.RichTextBox.Text = ""
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.Color.White
        Me.SaveButton.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.SaveButton.ForeColor = System.Drawing.Color.Black
        Me.SaveButton.Location = New System.Drawing.Point(59, 11)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(153, 40)
        Me.SaveButton.TabIndex = 1
        Me.SaveButton.Text = "保存文件"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'formHostsEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.RichTextBox)
        Me.Controls.Add(Me.Panel)
        Me.Controls.Add(Me.MinimizeButton)
        Me.Controls.Add(Me.CloseButton)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formHostsEditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formHostsEditor"
        CType(Me.MinimizeButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CloseButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MinimizeButton As PictureBox
    Friend WithEvents CloseButton As PictureBox
    Friend WithEvents Panel As Panel
    Friend WithEvents RichTextBox As RichTextBox
    Friend WithEvents SaveButton As Button
End Class
