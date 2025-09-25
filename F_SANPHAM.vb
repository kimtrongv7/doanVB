Imports System.Data.SqlClient

Public Class F_SANPHAM
    Dim KN As SqlConnection
    Private Sub F_SANPHAM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KN = New SqlConnection("Data Source=DESKTOP-PI4AFQU\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True")
        KN.Open()
        HienThiDuLieu()
    End Sub
    Sub HienThiDuLieu()
        Dim Adapter As New SqlDataAdapter("SELECT * FROM tblMatHang", KN)
        Dim DataSet As New DataSet()
        Adapter.Fill(DataSet, "tblMatHang")
        Data_SP.DataSource = DataSet.Tables("tblMatHang")

        ' Căn giữa dữ liệu
        Data_SP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Data_SP.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        Data_SP.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Data_SP.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

    End Sub
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim cmd As New SqlCommand("INSERT INTO tblMatHang (MaMH, TenMH, Gia, SoLuong) VALUES (@MaMH, @TenMH, @Gia, @SoLuong)", KN)
        cmd.Parameters.AddWithValue("@MaMH", txtMaMH.Text)
        cmd.Parameters.AddWithValue("@TenMH", txtTenMH.Text)
        cmd.Parameters.AddWithValue("@Gia", txtGia.Text)
        cmd.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text)
        cmd.ExecuteNonQuery()
        HienThiDuLieu()
        MessageBox.Show("Thêm mặt hàng thành công!")
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim cmd As New SqlCommand("DELETE FROM tblMatHang WHERE MaMH=@MaMH", KN)
        cmd.Parameters.AddWithValue("@MaMH", txtMaMH.Text)
        cmd.ExecuteNonQuery()
        HienThiDuLieu()
        MessageBox.Show("Xóa mặt hàng thành công!")
    End Sub

    Private Sub Data_SP_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Data_SP.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = Data_SP.Rows(e.RowIndex)
            txtMaMH.Text = row.Cells("MaMH").Value.ToString()
            txtTenMH.Text = row.Cells("TenMH").Value.ToString()
            txtGia.Text = row.Cells("Gia").Value.ToString()
            txtSoLuong.Text = row.Cells("SoLuong").Value.ToString()
        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If txtMaMH.Text.Trim() = "" Then
            MessageBox.Show("Vui lòng nhập Mã mặt hàng cần xóa!")
            Exit Sub
        End If

        If MessageBox.Show("Bạn có chắc chắn muốn xóa mặt hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            Exit Sub
        End If

        Try
            Dim cmd As New SqlCommand("DELETE FROM tblMatHang WHERE MaMH=@MaMH", KN)
            cmd.Parameters.AddWithValue("@MaMH", txtMaMH.Text.Trim())
            Dim rows = cmd.ExecuteNonQuery()
            If rows > 0 Then
                MessageBox.Show("Xóa mặt hàng thành công!")
                HienThiDuLieu()
                txtMaMH.Clear()
                txtTenMH.Clear()
                txtGia.Clear()
                txtSoLuong.Clear()
            Else
                MessageBox.Show("Không tìm thấy mặt hàng để xóa!")
            End If
        Catch ex As Exception
            MessageBox.Show("Lỗi khi xóa: " & ex.Message)
        End Try
    End Sub
End Class