Imports System.Data.SqlClient
Public Class F_DangNhap
    Dim Ket_Noi As SqlConnection
    Private Sub F_DangNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ket_Noi = New SqlConnection("Data Source=DESKTOP-PI4AFQU\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True")
        Ket_Noi.Open()
    End Sub
    Private Sub DangNhap_Click(sender As Object, e As EventArgs) Handles DangNhap.Click

        If TxtTenDN.Text.Trim() = "" Then
            MsgBox("Tên đăng nhập không được để trống!")
            Exit Sub
        End If

        Dim SQL As New SqlDataAdapter("SELECT * FROM TaiKhoan WHERE TenDN=@TenDN AND MatKhau=@MatKhau", Ket_Noi)
        SQL.SelectCommand.Parameters.AddWithValue("@TenDN", TxtTenDN.Text.Trim())
        SQL.SelectCommand.Parameters.AddWithValue("@MatKhau", TxtMatKhau.Text)

        Dim Db As New DataTable
        SQL.Fill(Db)
        If Db.Rows.Count > 0 Then
            MsgBox("Đăng nhập thành công!")
            Dim frm As New F_PHAMMEM_QLBH()   ' Giả sử form chính tên là F_Main
            frm.Show()
            Me.Hide()
        Else
            MsgBox("Sai User hoặc Pass")
        End If
    End Sub
    Private Sub DangKy_Click(sender As Object, e As EventArgs) Handles DangKy.Click

        F_DangKy.Show()
        Me.Hide()
    End Sub
End Class

