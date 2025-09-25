Imports System.Data.SqlClient

Public Class F_DOANHTHU
    Dim KETNOI As SqlConnection
    Private Sub F_DOANHTHU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Kết nối CSDL
        KETNOI = New SqlConnection("Data Source=DESKTOP-PI4AFQU\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True")
        KETNOI.Open()
    End Sub

    Private Sub btnThongKe_Click(sender As Object, e As EventArgs) Handles btnThongKe.Click
        Dim sql As String = "SELECT b.SoHieuHD, b.NgayBan, k.TenKH, SUM(c.ThanhTien) as TongTien
                         FROM tblBanHang b
                         INNER JOIN tblKhachHang k ON b.MaKH = k.MaKH
                         INNER JOIN tblChiTietHoaDon c ON b.SoHieuHD = c.SoHieuHD
                         WHERE NgayBan BETWEEN @TuNgay AND @DenNgay
                         GROUP BY b.SoHieuHD, b.NgayBan, k.TenKH"

        Dim cmd As New SqlCommand(sql, KETNOI)
        cmd.Parameters.AddWithValue("@TuNgay", dtpTuNgay.Value.Date)
        cmd.Parameters.AddWithValue("@DenNgay", dtpDenNgay.Value.Date)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)

        ' Gán dữ liệu vào DataGridView

        dgvDoanhThu.AutoGenerateColumns = True
        dgvDoanhThu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvDoanhThu.DataSource = dt

        ' Tính tổng doanh thu
        Dim Tong As Decimal = 0
        For Each row As DataRow In dt.Rows
            Tong += Convert.ToDecimal(row("TongTien"))
        Next
        lblTongTien.Text = "Tổng doanh thu: " & Tong.ToString("N0") & " VNĐ"
    End Sub
End Class