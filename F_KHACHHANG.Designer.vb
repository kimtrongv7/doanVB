<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_KHACHHANG
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_KHACHHANG))
        Me.TxtMAKH = New System.Windows.Forms.TextBox()
        Me.TxtHT = New System.Windows.Forms.TextBox()
        Me.TxtDT = New System.Windows.Forms.TextBox()
        Me.TxtDC = New System.Windows.Forms.TextBox()
        Me.Com_GT = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.THEM = New System.Windows.Forms.Button()
        Me.SUA = New System.Windows.Forms.Button()
        Me.XOA = New System.Windows.Forms.Button()
        Me.THOAT = New System.Windows.Forms.Button()
        Me.LUU = New System.Windows.Forms.Button()
        Me.TKiem = New System.Windows.Forms.Button()
        Me.Data_DS = New System.Windows.Forms.DataGridView()
        CType(Me.Data_DS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtMAKH
        '
        Me.TxtMAKH.Location = New System.Drawing.Point(145, 299)
        Me.TxtMAKH.Name = "TxtMAKH"
        Me.TxtMAKH.Size = New System.Drawing.Size(135, 20)
        Me.TxtMAKH.TabIndex = 0
        '
        'TxtHT
        '
        Me.TxtHT.Location = New System.Drawing.Point(145, 325)
        Me.TxtHT.Name = "TxtHT"
        Me.TxtHT.Size = New System.Drawing.Size(135, 20)
        Me.TxtHT.TabIndex = 1
        '
        'TxtDT
        '
        Me.TxtDT.Location = New System.Drawing.Point(438, 326)
        Me.TxtDT.Name = "TxtDT"
        Me.TxtDT.Size = New System.Drawing.Size(135, 20)
        Me.TxtDT.TabIndex = 3
        '
        'TxtDC
        '
        Me.TxtDC.Location = New System.Drawing.Point(438, 300)
        Me.TxtDC.Name = "TxtDC"
        Me.TxtDC.Size = New System.Drawing.Size(135, 20)
        Me.TxtDC.TabIndex = 2
        '
        'Com_GT
        '
        Me.Com_GT.FormattingEnabled = True
        Me.Com_GT.Items.AddRange(New Object() {"Nam", "Nữ"})
        Me.Com_GT.Location = New System.Drawing.Point(145, 354)
        Me.Com_GT.Name = "Com_GT"
        Me.Com_GT.Size = New System.Drawing.Size(135, 21)
        Me.Com_GT.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(58, 301)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Mã khách:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(58, 326)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Họ tên:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(58, 358)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Giới tính:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(357, 300)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Địa chỉ:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(357, 327)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 15)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Điện thoại:"
        '
        'THEM
        '
        Me.THEM.BackColor = System.Drawing.Color.LightSteelBlue
        Me.THEM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.THEM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.THEM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.THEM.Location = New System.Drawing.Point(40, 248)
        Me.THEM.Name = "THEM"
        Me.THEM.Size = New System.Drawing.Size(67, 30)
        Me.THEM.TabIndex = 7
        Me.THEM.Text = "Thêm"
        Me.THEM.UseVisualStyleBackColor = False
        '
        'SUA
        '
        Me.SUA.BackColor = System.Drawing.Color.LightSteelBlue
        Me.SUA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SUA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SUA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SUA.Location = New System.Drawing.Point(125, 248)
        Me.SUA.Name = "SUA"
        Me.SUA.Size = New System.Drawing.Size(67, 30)
        Me.SUA.TabIndex = 8
        Me.SUA.Text = "Sửa"
        Me.SUA.UseVisualStyleBackColor = False
        '
        'XOA
        '
        Me.XOA.BackColor = System.Drawing.Color.LightSteelBlue
        Me.XOA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.XOA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XOA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.XOA.Location = New System.Drawing.Point(213, 248)
        Me.XOA.Name = "XOA"
        Me.XOA.Size = New System.Drawing.Size(67, 30)
        Me.XOA.TabIndex = 9
        Me.XOA.Text = "Xoá"
        Me.XOA.UseVisualStyleBackColor = False
        '
        'THOAT
        '
        Me.THOAT.BackColor = System.Drawing.Color.LightSteelBlue
        Me.THOAT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.THOAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.THOAT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.THOAT.Location = New System.Drawing.Point(520, 248)
        Me.THOAT.Name = "THOAT"
        Me.THOAT.Size = New System.Drawing.Size(65, 30)
        Me.THOAT.TabIndex = 12
        Me.THOAT.Text = "Thoát"
        Me.THOAT.UseVisualStyleBackColor = False
        '
        'LUU
        '
        Me.LUU.BackColor = System.Drawing.Color.LightSteelBlue
        Me.LUU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.LUU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LUU.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LUU.Location = New System.Drawing.Point(438, 248)
        Me.LUU.Name = "LUU"
        Me.LUU.Size = New System.Drawing.Size(65, 30)
        Me.LUU.TabIndex = 11
        Me.LUU.Text = "Lưu"
        Me.LUU.UseVisualStyleBackColor = False
        '
        'TKiem
        '
        Me.TKiem.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TKiem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TKiem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TKiem.Location = New System.Drawing.Point(351, 248)
        Me.TKiem.Name = "TKiem"
        Me.TKiem.Size = New System.Drawing.Size(80, 30)
        Me.TKiem.TabIndex = 10
        Me.TKiem.Text = "Tìm kiếm"
        Me.TKiem.UseVisualStyleBackColor = False
        '
        'Data_DS
        '
        Me.Data_DS.AllowDrop = True
        Me.Data_DS.AllowUserToOrderColumns = True
        Me.Data_DS.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Data_DS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Data_DS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Data_DS.Location = New System.Drawing.Point(27, 19)
        Me.Data_DS.Name = "Data_DS"
        Me.Data_DS.Size = New System.Drawing.Size(608, 202)
        Me.Data_DS.TabIndex = 13
        '
        'F_KHACHHANG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(687, 387)
        Me.Controls.Add(Me.Data_DS)
        Me.Controls.Add(Me.THOAT)
        Me.Controls.Add(Me.LUU)
        Me.Controls.Add(Me.TKiem)
        Me.Controls.Add(Me.XOA)
        Me.Controls.Add(Me.SUA)
        Me.Controls.Add(Me.THEM)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Com_GT)
        Me.Controls.Add(Me.TxtDT)
        Me.Controls.Add(Me.TxtDC)
        Me.Controls.Add(Me.TxtHT)
        Me.Controls.Add(Me.TxtMAKH)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "F_KHACHHANG"
        Me.Text = "Quản lý khách hàng"
        CType(Me.Data_DS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtMAKH As TextBox
    Friend WithEvents TxtHT As TextBox
    Friend WithEvents TxtDT As TextBox
    Friend WithEvents TxtDC As TextBox
    Friend WithEvents Com_GT As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents THEM As Button
    Friend WithEvents SUA As Button
    Friend WithEvents XOA As Button
    Friend WithEvents THOAT As Button
    Friend WithEvents LUU As Button
    Friend WithEvents TKiem As Button
    Friend WithEvents Data_DS As DataGridView
End Class
