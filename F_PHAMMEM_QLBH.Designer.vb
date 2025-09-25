<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_PHAMMEM_QLBH
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_PHAMMEM_QLBH))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MT_NhanvVien = New System.Windows.Forms.ToolStripMenuItem()
        Me.MT_LLNV = New System.Windows.Forms.ToolStripMenuItem()
        Me.MT_QLNV = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChấmCôngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThưởngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PhạtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThànhTíchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MT_KhachHang = New System.Windows.Forms.ToolStripMenuItem()
        Me.QL_KH = New System.Windows.Forms.ToolStripMenuItem()
        Me.MT_SanPham = New System.Windows.Forms.ToolStripMenuItem()
        Me.MT_QLSP = New System.Windows.Forms.ToolStripMenuItem()
        Me.MT_HoaDon = New System.Windows.Forms.ToolStripMenuItem()
        Me.MT_DoanhThu = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Thoat = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MT_NhanvVien, Me.MT_KhachHang, Me.MT_SanPham, Me.MT_HoaDon, Me.MT_DoanhThu, Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(730, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MT_NhanvVien
        '
        Me.MT_NhanvVien.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MT_LLNV, Me.MT_QLNV})
        Me.MT_NhanvVien.Name = "MT_NhanvVien"
        Me.MT_NhanvVien.Size = New System.Drawing.Size(89, 24)
        Me.MT_NhanvVien.Text = "Nhân viên"
        '
        'MT_LLNV
        '
        Me.MT_LLNV.Name = "MT_LLNV"
        Me.MT_LLNV.Size = New System.Drawing.Size(224, 26)
        Me.MT_LLNV.Text = "Lý lịch nhân viên"
        '
        'MT_QLNV
        '
        Me.MT_QLNV.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChấmCôngToolStripMenuItem, Me.ThưởngToolStripMenuItem, Me.PhạtToolStripMenuItem, Me.ThànhTíchToolStripMenuItem})
        Me.MT_QLNV.Name = "MT_QLNV"
        Me.MT_QLNV.Size = New System.Drawing.Size(224, 26)
        Me.MT_QLNV.Text = "Quản lý nhân viên"
        '
        'ChấmCôngToolStripMenuItem
        '
        Me.ChấmCôngToolStripMenuItem.Name = "ChấmCôngToolStripMenuItem"
        Me.ChấmCôngToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
        Me.ChấmCôngToolStripMenuItem.Text = "Chấm công"
        '
        'ThưởngToolStripMenuItem
        '
        Me.ThưởngToolStripMenuItem.Name = "ThưởngToolStripMenuItem"
        Me.ThưởngToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
        Me.ThưởngToolStripMenuItem.Text = "Thưởng"
        '
        'PhạtToolStripMenuItem
        '
        Me.PhạtToolStripMenuItem.Name = "PhạtToolStripMenuItem"
        Me.PhạtToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
        Me.PhạtToolStripMenuItem.Text = "Phạt"
        '
        'ThànhTíchToolStripMenuItem
        '
        Me.ThànhTíchToolStripMenuItem.Name = "ThànhTíchToolStripMenuItem"
        Me.ThànhTíchToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
        Me.ThànhTíchToolStripMenuItem.Text = "Thành tích"
        '
        'MT_KhachHang
        '
        Me.MT_KhachHang.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QL_KH})
        Me.MT_KhachHang.Name = "MT_KhachHang"
        Me.MT_KhachHang.Size = New System.Drawing.Size(100, 24)
        Me.MT_KhachHang.Text = "Khách hàng"
        '
        'QL_KH
        '
        Me.QL_KH.Name = "QL_KH"
        Me.QL_KH.Size = New System.Drawing.Size(221, 26)
        Me.QL_KH.Text = "Quản lý khách hàng"
        '
        'MT_SanPham
        '
        Me.MT_SanPham.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MT_QLSP})
        Me.MT_SanPham.Name = "MT_SanPham"
        Me.MT_SanPham.Size = New System.Drawing.Size(89, 24)
        Me.MT_SanPham.Text = "Sản phẩm"
        '
        'MT_QLSP
        '
        Me.MT_QLSP.Name = "MT_QLSP"
        Me.MT_QLSP.Size = New System.Drawing.Size(210, 26)
        Me.MT_QLSP.Text = "Quản lý sản phẩm"
        '
        'MT_HoaDon
        '
        Me.MT_HoaDon.Name = "MT_HoaDon"
        Me.MT_HoaDon.Size = New System.Drawing.Size(81, 24)
        Me.MT_HoaDon.Text = "Hoá đơn"
        '
        'MT_DoanhThu
        '
        Me.MT_DoanhThu.Name = "MT_DoanhThu"
        Me.MT_DoanhThu.Size = New System.Drawing.Size(92, 24)
        Me.MT_DoanhThu.Text = "Doanh thu"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Thoat})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(85, 24)
        Me.FileToolStripMenuItem.Text = "Hệ thống"
        '
        'Thoat
        '
        Me.Thoat.Name = "Thoat"
        Me.Thoat.Size = New System.Drawing.Size(224, 26)
        Me.Thoat.Text = "Thoát"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(52, 40)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(630, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CÔNG TY TNHH MỘT THÀNH VIÊN"
        '
        'F_PHAMMEM_QLBH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(730, 345)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "F_PHAMMEM_QLBH"
        Me.Text = "Phần mềm quản lý bán hàng"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Thoat As ToolStripMenuItem
    Friend WithEvents MT_NhanvVien As ToolStripMenuItem
    Friend WithEvents MT_LLNV As ToolStripMenuItem
    Friend WithEvents MT_QLNV As ToolStripMenuItem
    Friend WithEvents MT_KhachHang As ToolStripMenuItem
    Friend WithEvents QL_KH As ToolStripMenuItem
    Friend WithEvents MT_SanPham As ToolStripMenuItem
    Friend WithEvents MT_QLSP As ToolStripMenuItem
    Friend WithEvents MT_HoaDon As ToolStripMenuItem
    Friend WithEvents MT_DoanhThu As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents ChấmCôngToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThưởngToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PhạtToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThànhTíchToolStripMenuItem As ToolStripMenuItem
End Class
