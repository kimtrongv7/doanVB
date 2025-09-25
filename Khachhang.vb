Imports System.Data.SqlClient
Public Class Khachhang
    Dim Ket_Noi As SqlConnection

    Private Sub Khachhang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ket_Noi = New SqlConnection("Data Source=DESKTOP-PI4AFQU\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True")
        Ket_Noi.Open()

        ' Hiển thị dữ liệu từ bảng KHACHHANG lên DataGridView:
        Dim Adapter As New SqlDataAdapter("SELECT * FROM tblKhachHang", Ket_Noi)
        Dim DataSet As New DataSet()
        Adapter.Fill(DataSet, "tblKhachHang")
        Data_DS.DataSource = DataSet.Tables("tblKhachHang")


        Data_DS.AutoGenerateColumns = True
        Data_DS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Data_DS.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        Data_DS.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub BtTHEM_Click(sender As Object, e As EventArgs) Handles BtTHEM.Click
        If TxtMaKH.Text.Trim() = "" Or TxtTenKH.Text.Trim() = "" Then
            MsgBox("Mã khách hàng và Tên khách hàng không được để trống!")
            Exit Sub
        End If

        Try
            Dim sql As String = "INSERT INTO tblKhachHang (MaKH, TenKH, DiaChi, SoDienThoai) VALUES (@MaKH, @TenKH, @DiaChi, @SoDienThoai)"
            Dim cmd As New SqlCommand(sql, Ket_Noi)

            ' Chuyển MaKH về kiểu int
            cmd.Parameters.AddWithValue("@MaKH", Integer.Parse(TxtMaKH.Text.Trim()))
            cmd.Parameters.AddWithValue("@TenKH", TxtTenKH.Text.Trim())
            cmd.Parameters.AddWithValue("@DiaChi", TxtDiaChi.Text.Trim())
            cmd.Parameters.AddWithValue("@SoDienThoai", TxtSDT.Text.Trim())

            Dim rows As Integer = cmd.ExecuteNonQuery()
            If rows > 0 Then
                MsgBox("Thêm khách hàng thành công!")
                Dim Adapter As New SqlDataAdapter("SELECT * FROM tblKhachHang", Ket_Noi)
                Dim DataSet As New DataSet()
                Adapter.Fill(DataSet, "tblKhachHang")
                Data_DS.DataSource = DataSet.Tables("tblKhachHang")
            Else
                MsgBox("Không thể thêm khách hàng.")
            End If
        Catch ex As Exception
            MsgBox("Lỗi khi thêm khách hàng: " & ex.Message)
        End Try
    End Sub

    Private Sub BtXoa_Click(sender As Object, e As EventArgs) Handles BtXoa.Click
        If TxtMaKH.Text.Trim() = "" Then
            MsgBox("Bạn cần nhập Mã khách hàng để xóa!")
            Exit Sub
        End If

        If MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            Exit Sub
        End If

        Try
            Dim sql As String = "DELETE FROM tblKhachHang WHERE MaKH=@MaKH"
            Dim cmd As New SqlCommand(sql, Ket_Noi)
            cmd.Parameters.AddWithValue("@MaKH", Integer.Parse(TxtMaKH.Text.Trim()))

            Dim rows As Integer = cmd.ExecuteNonQuery()
            If rows > 0 Then
                MsgBox("Xóa khách hàng thành công!")
                Dim Adapter As New SqlDataAdapter("SELECT * FROM tblKhachHang", Ket_Noi)
                Dim DataSet As New DataSet()
                Adapter.Fill(DataSet, "tblKhachHang")
                Data_DS.DataSource = DataSet.Tables("tblKhachHang")

                TxtMaKH.Clear()
                TxtTenKH.Clear()
                TxtDiaChi.Clear()
                TxtSDT.Clear()
            Else
                MsgBox("Không tìm thấy khách hàng để xóa!")
            End If
        Catch ex As Exception
            MsgBox("Lỗi khi xóa khách hàng: " & ex.Message)
        End Try
    End Sub

    Private Sub BtSua_Click(sender As Object, e As EventArgs) Handles BtSua.Click
        If TxtMaKH.Text.Trim() = "" Then
            MsgBox("Bạn cần nhập Mã khách hàng để sửa!")
            Exit Sub
        End If

        If TxtTenKH.Text.Trim() = "" Then
            MsgBox("Tên khách hàng không được để trống!")
            Exit Sub
        End If

        Try
            Dim sql As String = "UPDATE tblKhachHang 
                             SET TenKH=@TenKH, DiaChi=@DiaChi, SoDienThoai=@SoDienThoai 
                             WHERE MaKH=@MaKH"
            Dim cmd As New SqlCommand(sql, Ket_Noi)

            cmd.Parameters.AddWithValue("@MaKH", Integer.Parse(TxtMaKH.Text.Trim()))
            cmd.Parameters.AddWithValue("@TenKH", TxtTenKH.Text.Trim())
            cmd.Parameters.AddWithValue("@DiaChi", TxtDiaChi.Text.Trim())
            cmd.Parameters.AddWithValue("@SoDienThoai", TxtSDT.Text.Trim())

            Dim rows As Integer = cmd.ExecuteNonQuery()
            If rows > 0 Then
                MsgBox("Sửa thông tin khách hàng thành công!")

                ' Load lại dữ liệu lên DataGridView
                Dim Adapter As New SqlDataAdapter("SELECT * FROM tblKhachHang", Ket_Noi)
                Dim DataSet As New DataSet()
                Adapter.Fill(DataSet, "tblKhachHang")
                Data_DS.DataSource = DataSet.Tables("tblKhachHang")
            Else
                MsgBox("Không tìm thấy khách hàng để sửa!")
            End If
        Catch ex As Exception
            MsgBox("Lỗi khi sửa khách hàng: " & ex.Message)
        End Try
    End Sub
End Class