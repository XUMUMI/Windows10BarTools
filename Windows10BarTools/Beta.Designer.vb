<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Beta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Beta))
        Me.key = New System.Windows.Forms.TextBox()
        Me.EN = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'key
        '
        Me.key.BackColor = System.Drawing.Color.White
        Me.key.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.key.Location = New System.Drawing.Point(17, 8)
        Me.key.Margin = New System.Windows.Forms.Padding(0)
        Me.key.Name = "key"
        Me.key.Size = New System.Drawing.Size(243, 23)
        Me.key.TabIndex = 0
        '
        'EN
        '
        Me.EN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EN.Location = New System.Drawing.Point(80, 45)
        Me.EN.Margin = New System.Windows.Forms.Padding(0)
        Me.EN.Name = "EN"
        Me.EN.Size = New System.Drawing.Size(110, 33)
        Me.EN.TabIndex = 1
        Me.EN.Text = "确定"
        Me.EN.UseVisualStyleBackColor = True
        '
        'Beta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(271, 92)
        Me.Controls.Add(Me.EN)
        Me.Controls.Add(Me.key)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Beta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "请输入内测码"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents key As TextBox
    Friend WithEvents EN As Button
End Class
