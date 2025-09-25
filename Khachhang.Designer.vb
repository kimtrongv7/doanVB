<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Khachhang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Khachhang))
        Me.Data_DS = New System.Windows.Forms.DataGridView()
        Me.BtTHEM = New System.Windows.Forms.Button()
        Me.TxtMaKH = New System.Windows.Forms.TextBox()
        Me.TxtTenKH = New System.Windows.Forms.TextBox()
        Me.TxtDiaChi = New System.Windows.Forms.TextBox()
        Me.TxtSDT = New System.Windows.Forms.TextBox()
        Me.BtXoa = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtSua = New System.Windows.Forms.Button()
        CType(Me.Data_DS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Data_DS
        '
        Me.Data_DS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Data_DS.Location = New System.Drawing.Point(42, 21)
        Me.Data_DS.Margin = New System.Windows.Forms.Padding(4)
        Me.Data_DS.Name = "Data_DS"
        Me.Data_DS.RowHeadersWidth = 51
        Me.Data_DS.Size = New System.Drawing.Size(959, 314)
        Me.Data_DS.TabIndex = 0
        '
        'BtTHEM
        '
        Me.BtTHEM.BackColor = System.Drawing.Color.Silver
        Me.BtTHEM.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.BtTHEM.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.BtTHEM.Location = New System.Drawing.Point(639, 377)
        Me.BtTHEM.Margin = New System.Windows.Forms.Padding(4)
        Me.BtTHEM.Name = "BtTHEM"
        Me.BtTHEM.Size = New System.Drawing.Size(137, 46)
        Me.BtTHEM.TabIndex = 1
        Me.BtTHEM.Text = "Thêm"
        Me.BtTHEM.UseVisualStyleBackColor = False
        '
        'TxtMaKH
        '
        Me.TxtMaKH.Location = New System.Drawing.Point(93, 377)
        Me.TxtMaKH.Multiline = True
        Me.TxtMaKH.Name = "TxtMaKH"
        Me.TxtMaKH.Size = New System.Drawing.Size(227, 46)
        Me.TxtMaKH.TabIndex = 2
        '
        'TxtTenKH
        '
        Me.TxtTenKH.Location = New System.Drawing.Point(353, 377)
        Me.TxtTenKH.Multiline = True
        Me.TxtTenKH.Name = "TxtTenKH"
        Me.TxtTenKH.Size = New System.Drawing.Size(227, 46)
        Me.TxtTenKH.TabIndex = 2
        '
        'TxtDiaChi
        '
        Me.TxtDiaChi.Location = New System.Drawing.Point(93, 481)
        Me.TxtDiaChi.Multiline = True
        Me.TxtDiaChi.Name = "TxtDiaChi"
        Me.TxtDiaChi.Size = New System.Drawing.Size(227, 46)
        Me.TxtDiaChi.TabIndex = 2
        '
        'TxtSDT
        '
        Me.TxtSDT.Location = New System.Drawing.Point(353, 474)
        Me.TxtSDT.Multiline = True
        Me.TxtSDT.Name = "TxtSDT"
        Me.TxtSDT.Size = New System.Drawing.Size(227, 46)
        Me.TxtSDT.TabIndex = 2
        '
        'BtXoa
        '
        Me.BtXoa.BackColor = System.Drawing.Color.Silver
        Me.BtXoa.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.BtXoa.ForeColor = System.Drawing.Color.Red
        Me.BtXoa.Location = New System.Drawing.Point(835, 458)
        Me.BtXoa.Margin = New System.Windows.Forms.Padding(4)
        Me.BtXoa.Name = "BtXoa"
        Me.BtXoa.Size = New System.Drawing.Size(137, 46)
        Me.BtXoa.TabIndex = 1
        Me.BtXoa.Text = "Xóa"
        Me.BtXoa.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(122, 350)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Mã Khách Hàng"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(152, 449)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ĐỊa Chỉ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(391, 449)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Số DIện Thoại"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(379, 350)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tên Khách Hàng"
        '
        'BtSua
        '
        Me.BtSua.BackColor = System.Drawing.Color.Silver
        Me.BtSua.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.BtSua.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.BtSua.Location = New System.Drawing.Point(835, 377)
        Me.BtSua.Margin = New System.Windows.Forms.Padding(4)
        Me.BtSua.Name = "BtSua"
        Me.BtSua.Size = New System.Drawing.Size(137, 46)
        Me.BtSua.TabIndex = 1
        Me.BtSua.Text = "Sửa"
        Me.BtSua.UseVisualStyleBackColor = False
        '
        'Khachhang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1031, 548)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtSDT)
        Me.Controls.Add(Me.TxtDiaChi)
        Me.Controls.Add(Me.TxtTenKH)
        Me.Controls.Add(Me.TxtMaKH)
        Me.Controls.Add(Me.BtXoa)
        Me.Controls.Add(Me.BtSua)
        Me.Controls.Add(Me.BtTHEM)
        Me.Controls.Add(Me.Data_DS)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Khachhang"
        Me.Text = "Quản lý khách hàng"
        CType(Me.Data_DS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Data_DS As DataGridView
    Friend WithEvents BtTHEM As Button
    Friend WithEvents TxtMaKH As TextBox
    Friend WithEvents TxtTenKH As TextBox
    Friend WithEvents TxtDiaChi As TextBox
    Friend WithEvents TxtSDT As TextBox
    Friend WithEvents BtXoa As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtSua As Button
End Class
