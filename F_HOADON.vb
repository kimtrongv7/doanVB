Imports System.Data.SqlClient
Public Class F_HOADON
    Dim KN As SqlConnection
    Private Sub F_HOADON_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KN = New SqlConnection("Data Source=DESKTOP-PI4AFQU\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True")
        KN.Open()
        HienThiDuLieu()
    End Sub

    Sub HienThiDuLieu()
        Dim Adapter As New SqlDataAdapter("SELECT * FROM tblChiTietHoaDon", KN)
        Dim DataSet As New DataSet()
        Adapter.Fill(DataSet, "tblChiTietHoaDon")
        Data_HD.DataSource = DataSet.Tables("tblChiTietHoaDon")

        ' ----- Căn chỉnh hiển thị -----
        With Data_HD
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill ' Tự giãn cột vừa khung
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells   ' Tự giãn chiều cao dòng
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter ' Căn giữa toàn bộ ô
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter ' Căn giữa tiêu đề
            .DefaultCellStyle.Font = New Font("Segoe UI", 10) ' Font chung
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)

            ' Nếu muốn căn riêng cho từng cột
            .Columns("SoLuong").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("ThanhTien").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With

    End Sub


    Private Function HoaDonTonTai(soHD As String) As Boolean
        Dim cmd As New SqlCommand("SELECT COUNT(*) FROM tblBanHang WHERE SoHieuHD=@SoHieuHD", KN)
        cmd.Parameters.AddWithValue("@SoHieuHD", soHD)
        Dim count As Integer = CInt(cmd.ExecuteScalar())
        Return count > 0
    End Function
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Try
            ' Kiểm tra hóa đơn có tồn tại không
            If Not HoaDonTonTai(txtSoHieuHD.Text) Then
                MessageBox.Show("Hóa đơn chưa tồn tại trong tblBanHang. Vui lòng thêm hóa đơn trước.")
                Exit Sub
            End If

            Dim cmd As New SqlCommand("INSERT INTO tblChiTietHoaDon (SoHieuHD, MaMH, SoLuong, ThanhTien) 
                                   VALUES (@SoHieuHD, @MaMH, @SoLuong, @ThanhTien)", KN)
            cmd.Parameters.AddWithValue("@SoHieuHD", txtSoHieuHD.Text)
            cmd.Parameters.AddWithValue("@MaMH", txtMaMH.Text)
            cmd.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text)
            cmd.Parameters.AddWithValue("@ThanhTien", ThanhTien.Text)
            cmd.ExecuteNonQuery()

            HienThiDuLieu()
            MessageBox.Show("Thêm chi tiết hóa đơn thành công!")
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Try
            Dim cmd As New SqlCommand("UPDATE tblChiTietHoaDon 
                                       SET MaMH=@MaMH, SoLuong=@SoLuong, ThanhTien=@ThanhTien 
                                       WHERE SoHieuHD=@SoHieuHD", KN)
            cmd.Parameters.AddWithValue("@SoHieuHD", txtSoHieuHD.Text)
            cmd.Parameters.AddWithValue("@MaMH", txtMaMH.Text)
            cmd.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text)
            cmd.Parameters.AddWithValue("@ThanhTien", ThanhTien.Text)
            cmd.ExecuteNonQuery()

            HienThiDuLieu()
            MessageBox.Show("Sửa chi tiết hóa đơn thành công!")
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message)
        End Try
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Try
            Dim cmd As New SqlCommand("DELETE FROM tblChiTietHoaDon WHERE SoHieuHD=@SoHieuHD AND MaMH=@MaMH", KN)
            cmd.Parameters.AddWithValue("@SoHieuHD", txtSoHieuHD.Text)
            cmd.Parameters.AddWithValue("@MaMH", txtMaMH.Text)
            cmd.ExecuteNonQuery()

            HienThiDuLieu()
            MessageBox.Show("Xóa chi tiết hóa đơn thành công!")
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message)
        End Try
    End Sub

    Private Sub Data_HD_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Data_HD.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = Data_HD.Rows(e.RowIndex)
            txtSoHieuHD.Text = row.Cells("SoHieuHD").Value.ToString()
            txtMaMH.Text = row.Cells("MaMH").Value.ToString()
            txtSoLuong.Text = row.Cells("SoLuong").Value.ToString()
            ThanhTien.Text = row.Cells("ThanhTien").Value.ToString()
        End If
    End Sub
End Class