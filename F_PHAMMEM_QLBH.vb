Public Class F_PHAMMEM_QLBH
    Private Sub MT_NhanvVien_Click(sender As Object, e As EventArgs) Handles MT_NhanvVien.Click
        Dim f As New Nhanvien()
        f.ShowDialog()   ' ShowDialog = modal, Show = không khóa form chính
    End Sub

    Private Sub MT_LLNV_Click(sender As Object, e As EventArgs) Handles MT_LLNV.Click
        Dim f As New Nhanvien()
        f.ShowDialog()   ' ShowDialog = modal, Show = không khóa form chính
    End Sub

    Private Sub MT_QLNV_Click(sender As Object, e As EventArgs) Handles MT_QLNV.Click
        Dim f As New Nhanvien()
        f.ShowDialog()   ' ShowDialog = modal, Show = không khóa form chính
    End Sub

    Private Sub QL_KH_Click(sender As Object, e As EventArgs) Handles QL_KH.Click
        Dim f As New Khachhang()
        f.ShowDialog()
    End Sub

    Private Sub MT_QLSP_Click(sender As Object, e As EventArgs) Handles MT_QLSP.Click
        Dim f As New F_SANPHAM()
        f.ShowDialog()
    End Sub

    Private Sub MT_HoaDon_Click(sender As Object, e As EventArgs) Handles MT_HoaDon.Click
        Dim f As New F_HOADON()
        f.ShowDialog()
    End Sub

    Private Sub MT_DoanhThu_Click(sender As Object, e As EventArgs) Handles MT_DoanhThu.Click
        Dim f As New F_DOANHTHU()
        f.ShowDialog()

    End Sub

    Private Sub Thoat_Click(sender As Object, e As EventArgs) Handles Thoat.Click
        ' Đóng form hiện tại và quay về form đăng nhập
        Dim f As New F_DangNhap()
        Me.Hide()           ' Ẩn form chính
        f.ShowDialog()      ' Hiện form đăng nhập (modal)
        Me.Close()          ' Sau khi thoát form đăng nhập thì đóng hẳn form chính
    End Sub
End Class