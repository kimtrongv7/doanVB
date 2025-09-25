<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_DangKy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_DangKy))
        Me.TxtTenDN = New System.Windows.Forms.TextBox()
        Me.TxtMatKhau = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtDangKy = New System.Windows.Forms.Button()
        Me.BtThoat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtTenDN
        '
        Me.TxtTenDN.Location = New System.Drawing.Point(152, 27)
        Me.TxtTenDN.Name = "TxtTenDN"
        Me.TxtTenDN.Size = New System.Drawing.Size(132, 20)
        Me.TxtTenDN.TabIndex = 0
        '
        'TxtMatKhau
        '
        Me.TxtMatKhau.Location = New System.Drawing.Point(152, 66)
        Me.TxtMatKhau.Name = "TxtMatKhau"
        Me.TxtMatKhau.Size = New System.Drawing.Size(132, 20)
        Me.TxtMatKhau.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(35, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Mật khẩu:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(35, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Tên đăng nhập:"
        '
        'BtDangKy
        '
        Me.BtDangKy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtDangKy.ForeColor = System.Drawing.Color.Navy
        Me.BtDangKy.Location = New System.Drawing.Point(76, 107)
        Me.BtDangKy.Name = "BtDangKy"
        Me.BtDangKy.Size = New System.Drawing.Size(76, 28)
        Me.BtDangKy.TabIndex = 6
        Me.BtDangKy.Text = "Đăng ký"
        Me.BtDangKy.UseVisualStyleBackColor = True
        '
        'BtThoat
        '
        Me.BtThoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtThoat.ForeColor = System.Drawing.Color.Navy
        Me.BtThoat.Location = New System.Drawing.Point(183, 107)
        Me.BtThoat.Name = "BtThoat"
        Me.BtThoat.Size = New System.Drawing.Size(76, 28)
        Me.BtThoat.TabIndex = 7
        Me.BtThoat.Text = "Thoát"
        Me.BtThoat.UseVisualStyleBackColor = True
        '
        'F_DangKy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(438, 216)
        Me.Controls.Add(Me.BtThoat)
        Me.Controls.Add(Me.BtDangKy)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtMatKhau)
        Me.Controls.Add(Me.TxtTenDN)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "F_DangKy"
        Me.Text = "Đăng ký tài khoản"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtTenDN As TextBox
    Friend WithEvents TxtMatKhau As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtDangKy As Button
    Friend WithEvents BtThoat As Button
End Class
