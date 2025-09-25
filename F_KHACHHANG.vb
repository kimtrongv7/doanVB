Imports System.Data.SqlClient
Public Class F_KHACHHANG
    Dim Ket_Noi As SqlConnection
    Private Sub F_KHACHHANG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ket_Noi = New SqlConnection("Data Source=D704\SQLEXPRESS;Initial Catalog=QLYBH;Integrated Security=True")
        Ket_Noi.Open()

        ' Hiển thị dữ liệu từ bảng KHACHHANG lên DataGridView:
        Dim Adapter As New SqlDataAdapter("Select * From tblKhachHang", Ket_Noi) ' Lấy dữ liệu từ bảng
        Dim DataSet As New DataSet()  ' Lưu dữ liệu vừa lấy ra
        Adapter.Fill(DataSet, "tblKhachHang")  ' Lấy xong--> đổ vào (Fill) Dataset
        Data_DS.DataSource = DataSet.Tables("tblKhachHang")

    End Sub
    'Tạo 1 Thủ tục Load lại dữ liệu khi thêm mới, xoá, sửa:
    Private Sub Load_dulieu()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter("Select * From tblKhachHang", Ket_Noi)
        da.Fill(dt)
        Data_DS.DataSource = dt
    End Sub
    Private Sub THEM_Click(sender As Object, e As EventArgs) Handles THEM.Click
        If TxtMAKH.Text.Trim() = "" Then
            MsgBox("Bạn chưa nhập Mã khách", vbYes, "Chú ý...")
            Exit Sub
        End If
        Dim SQL_KiemTra As New SqlDataAdapter("SELECT * FROM tblKhachHang WHERE MaKH=@MaKH", Ket_Noi)
        SQL_KiemTra.SelectCommand.Parameters.AddWithValue("@MaKH", TxtMAKH.Text.Trim())
        Dim Db_Check As New DataTable
        SQL_KiemTra.Fill(Db_Check)
        If Db_Check.Rows.Count > 0 Then
            MsgBox("Mã khách này đã có!", vbYes, "Nhập lại đi.")
            Exit Sub
        End If
        ' Nếu không trùng, tiến hành lưu vào database
        Dim SQL_DangKy As New SqlCommand("INSERT INTO tblKhachHang (MaKH,HoTen,GioiTinh,DiaChi,DienThoai) VALUES (@MaKH,@HoTen,@GioiTinh,@DiaChi,@DienThoai)", Ket_Noi)
        SQL_DangKy.Parameters.AddWithValue("@MaKH", TxtMAKH.Text.Trim())
        SQL_DangKy.Parameters.AddWithValue("@HoTen", TxtHT.Text.Trim())
        SQL_DangKy.Parameters.AddWithValue("GioiTinh", Com_GT.Text.Trim())
        SQL_DangKy.Parameters.AddWithValue("@DiaChi", TxtDC.Text.Trim())
        SQL_DangKy.Parameters.AddWithValue("@DienThoai", TxtDT.Text.Trim())

        Try
            SQL_DangKy.ExecuteNonQuery()
            MsgBox("Thêm thành công: " & TxtMAKH.Text, vbYes, "Chúc mừng.")

            Load_dulieu() ' Thêm xong, Load lại để hiển thị lên DataGridView

            TxtMAKH.Clear()
            TxtHT.Clear()
            TxtDT.Clear()
            TxtDC.Clear()
            Com_GT.Text = ""

            TxtMAKH.Focus()

        Catch ex As Exception
            MsgBox("Có lỗi xảy ra khi đăng ký: " & ex.Message)
        End Try
    End Sub
    Private Sub SUA_Click(sender As Object, e As EventArgs) Handles SUA.Click
        Dim Ma_Edit As String = InputBox("Nhập mã khách hàng muốn sửa: ", "Nhập chính xác")

        If Ma_Edit <> "" Then
            Dim Sql As String = "Select * From tblKhachHang where MaKH = @MaKH "
            Dim Cmd As New SqlCommand(Sql, Ket_Noi)

            Cmd.Parameters.AddWithValue("@MaKH", Ma_Edit)

            Dim Doc_dl As SqlDataReader = Cmd.ExecuteReader()

            If Doc_dl.Read() Then
                'TxtMAKH.Text = Doc_dl("MaKH").ToString()
                TxtHT.Text = Doc_dl("HoTen").ToString()
                TxtDT.Text = Doc_dl("Dienthoai").ToString()
                TxtDC.Text = Doc_dl("DiaChi").ToString()
                Com_GT.Text = Doc_dl("GioiTinh").ToString()

            Else
                MsgBox("Không tìm thấy Mã khách hàng", vbYes, "Tìm lại mã đi")
            End If
            Doc_dl.Close()
        End If
    End Sub
    Private Sub LUU_Click(sender As Object, e As EventArgs) Handles LUU.Click
        Try

            Dim Sql As String = "Update tblKhachHang Set HoTen=@HoTen, Diachi=@DC, DienThoai=@DT, Gioitinh=@GT Where Makh=@MaKH"
            Dim Cmd As New SqlCommand(Sql, Ket_Noi)

            ' Lưu vào:
            Cmd.Parameters.AddWithValue("@HoTen", TxtHT.Text)
            Cmd.Parameters.AddWithValue("@DT", TxtDT.Text)
            Cmd.Parameters.AddWithValue("@DC", TxtDC.Text)
            Cmd.Parameters.AddWithValue("@GT", Com_GT.Text)

            If Ket_Noi.State = ConnectionState.Open Then
                Ket_Noi.Close()
            End If

            ' Thực hiện lưu:
            Dim Banghi_sau As Integer = Cmd.ExecuteNonQuery
            Ket_Noi.Close()

            If Banghi_sau > 0 Then
                MsgBox("Sửa thành công khách: ")
            Else
                MsgBox("Không thành công. ")
            End If


        Catch ex As Exception
            MsgBox("Lỗi kn ")
        End Try
        Load_dulieu()

    End Sub
End Class