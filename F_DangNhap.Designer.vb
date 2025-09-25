<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_DangNhap
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_DangNhap))
        Me.TxtTenDN = New System.Windows.Forms.TextBox()
        Me.TxtMatKhau = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DangNhap = New System.Windows.Forms.Button()
        Me.DangKy = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtTenDN
        '
        Me.TxtTenDN.BackColor = System.Drawing.Color.Snow
        Me.TxtTenDN.Location = New System.Drawing.Point(477, 75)
        Me.TxtTenDN.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTenDN.Multiline = True
        Me.TxtTenDN.Name = "TxtTenDN"
        Me.TxtTenDN.Size = New System.Drawing.Size(172, 30)
        Me.TxtTenDN.TabIndex = 0
        '
        'TxtMatKhau
        '
        Me.TxtMatKhau.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtMatKhau.Location = New System.Drawing.Point(477, 116)
        Me.TxtMatKhau.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMatKhau.Multiline = True
        Me.TxtMatKhau.Name = "TxtMatKhau"
        Me.TxtMatKhau.Size = New System.Drawing.Size(172, 30)
        Me.TxtMatKhau.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(327, 75)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tên đăng nhập:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(327, 119)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Mật khẩu:"
        '
        'DangNhap
        '
        Me.DangNhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DangNhap.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DangNhap.Location = New System.Drawing.Point(344, 196)
        Me.DangNhap.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DangNhap.Name = "DangNhap"
        Me.DangNhap.Size = New System.Drawing.Size(109, 28)
        Me.DangNhap.TabIndex = 4
        Me.DangNhap.Text = "Đăng nhập"
        Me.DangNhap.UseVisualStyleBackColor = True
        '
        'DangKy
        '
        Me.DangKy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DangKy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DangKy.Location = New System.Drawing.Point(477, 196)
        Me.DangKy.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DangKy.Name = "DangKy"
        Me.DangKy.Size = New System.Drawing.Size(108, 28)
        Me.DangKy.TabIndex = 5
        Me.DangKy.Text = "Đăng ký"
        Me.DangKy.UseVisualStyleBackColor = True
        '
        'F_DangNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(903, 264)
        Me.Controls.Add(Me.DangKy)
        Me.Controls.Add(Me.DangNhap)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtMatKhau)
        Me.Controls.Add(Me.TxtTenDN)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "F_DangNhap"
        Me.Text = "Đăng nhập hệ thống"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtTenDN As TextBox
    Friend WithEvents TxtMatKhau As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DangNhap As Button
    Friend WithEvents DangKy As Button
End Class
