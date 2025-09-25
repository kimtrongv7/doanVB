Imports System.Data
Imports System.Data.SqlClient

Public Class Nhanvien

    'Dim Ket_Noi As SqlConnection
    Private Ket_Noi As SqlConnection
    Private connectionString As String = "Data Source=DESKTOP-PI4AFQU\SQLEXPRESS;Initial Catalog=QuanLyNhanVien;Integrated Security=True"

    Private Sub Nhanvien_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Try
            Ket_Noi = New SqlConnection(connectionString)
            Ket_Noi.Open()
            LoadNhanVien()
            LoadChamCong()
            LoadPhat()
            LoadThuong()
            LoadThanhTich()
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message, "Kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub

    Private Sub FormatDataGridView(dgv As DataGridView)
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        ' Canh giữa tiêu đề + dữ liệu
        dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        ' Giảm cỡ chữ
        dgv.DefaultCellStyle.Font = New Font("Arial", 9)
        dgv.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 10, FontStyle.Bold)

        ' Tự động xuống dòng nếu text dài
        dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True

    End Sub

    Private Sub LoadNhanVien()
        Dim sql As String = "SELECT * FROM NhanVien"
        Dim da As New SqlDataAdapter(sql, Ket_Noi)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgvNhanVien.DataSource = dt
        FormatDataGridView(dgvNhanVien)
    End Sub





    Private Sub LoadChamCong()
        Dim sql As String = "SELECT * FROM ChamCong"
        Dim da As New SqlDataAdapter(sql, Ket_Noi)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgvChamCong.DataSource = dt
        FormatDataGridView(dgvChamCong)
    End Sub

    Private Sub LoadPhat()
        Dim sql As String = "SELECT * FROM Phat"
        Dim da As New SqlDataAdapter(sql, Ket_Noi)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgvPhat.DataSource = dt
        FormatDataGridView(dgvPhat)
    End Sub

    Private Sub LoadThuong()
        Dim sql As String = "SELECT * FROM Thuong"
        Dim da As New SqlDataAdapter(sql, Ket_Noi)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgvThuong.DataSource = dt
        FormatDataGridView(dgvThuong)
    End Sub

    Private Sub LoadThanhTich()
        Dim sql As String = "SELECT * FROM ThanhTich"
        Dim da As New SqlDataAdapter(sql, Ket_Noi)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgvThanhTich.DataSource = dt
        FormatDataGridView(dgvThanhTich)
    End Sub




    Private Sub btnThemCC_Click(sender As Object, e As EventArgs) Handles btnThemCC.Click
        dgvChamCong.Rows.Add(txtMaNV_CC.Text, txtHoTen_CC.Text, dtpNgayCong.Value.ToShortDateString(),
                        cboCaLam.Text, txtSoGioOT.Text)
    End Sub

    Private Sub dgvChamCong_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvChamCong.CellContentClick
        Dim i As Integer = dgvChamCong.CurrentRow.Index
        txtMaNV_CC.Text = dgvChamCong.Item(0, i).Value
        txtHoTen_CC.Text = dgvChamCong.Item(1, i).Value
        dtpNgayCong.Value = dgvChamCong.Item(2, i).Value
        cboCaLam.Text = dgvChamCong.Item(3, i).Value
        txtSoGioOT.Text = dgvChamCong.Item(4, i).Value
    End Sub

    Private Sub btnXoaCC_Click(sender As Object, e As EventArgs) Handles btnXoaCC.Click
        If dgvChamCong.CurrentRow IsNot Nothing Then
            dgvChamCong.Rows.RemoveAt(dgvChamCong.CurrentRow.Index)
        End If
    End Sub

    Private Sub btnThemPhat_Click(sender As Object, e As EventArgs)
        dgvPhat.Rows.Add(txtMaNV_Phat.Text, txtHoTen_Phat.Text, txtLyDo.Text,
                     txtMucPhat.Text, dtpNgayPhat.Value.ToShortDateString())
    End Sub

    Private Sub dgvPhat_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPhat.CellContentClick
        Dim i As Integer = dgvPhat.CurrentRow.Index
        txtMaNV_Phat.Text = dgvPhat.Item(0, i).Value
        txtHoTen_Phat.Text = dgvPhat.Item(1, i).Value
        txtLyDo.Text = dgvPhat.Item(2, i).Value
        txtMucPhat.Text = dgvPhat.Item(3, i).Value
        dtpNgayPhat.Value = dgvPhat.Item(4, i).Value
    End Sub



    Private Sub btnSuaCC_Click(sender As Object, e As EventArgs) Handles btnSuaCC.Click
        If dgvChamCong.CurrentRow Is Nothing Then
            MessageBox.Show("Vui lòng chọn một dòng để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim i As Integer = dgvChamCong.CurrentRow.Index
        dgvChamCong.Item(0, i).Value = txtMaNV_CC.Text
        dgvChamCong.Item(1, i).Value = txtHoTen_CC.Text
        dgvChamCong.Item(2, i).Value = dtpNgayCong.Value.ToShortDateString()
        dgvChamCong.Item(3, i).Value = cboCaLam.Text
        dgvChamCong.Item(4, i).Value = txtSoGioOT.Text

        MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnLuuCC_Click(sender As Object, e As EventArgs)
        Dim saveFile As String = "ChamCong.csv"
        Dim sw As New IO.StreamWriter(saveFile, False, System.Text.Encoding.UTF8)

        ' Ghi tiêu đề cột
        For Each col As DataGridViewColumn In dgvChamCong.Columns
            sw.Write(col.HeaderText & ",")
        Next
        sw.WriteLine()

        ' Ghi dữ liệu từng dòng
        For Each row As DataGridViewRow In dgvChamCong.Rows
            If Not row.IsNewRow Then
                For Each cell As DataGridViewCell In row.Cells
                    sw.Write(cell.Value & ",")
                Next
                sw.WriteLine()
            End If
        Next

        sw.Close()
        MessageBox.Show("Đã lưu dữ liệu chấm công vào file ChamCong.csv", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Private Sub tvPhongBan_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvPhongBan.AfterSelect
        Dim phongban As String = e.Node.Text
        MessageBox.Show("Bạn chọn phòng ban: " & phongban)
        ' Sau này bạn có thể load dữ liệu NV theo phòng ban từ database
    End Sub

    Private Sub btnthoatCC_Click(sender As Object, e As EventArgs) Handles btnthoatCC.Click
        Me.Close()
    End Sub

    Private Sub btnThemP_Click(sender As Object, e As EventArgs) Handles btnThemP.Click
        dgvPhat.Rows.Add(txtMaNV_Phat.Text, txtHoTen_Phat.Text, txtLyDo.Text,
                     txtMucPhat.Text, dtpNgayPhat.Value.ToShortDateString())
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If dgvPhat.CurrentRow Is Nothing Then
            MessageBox.Show("Vui lòng chọn một dòng để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim i As Integer = dgvPhat.CurrentRow.Index
        dgvPhat.Item(0, i).Value = txtMaNV_Phat.Text
        dgvPhat.Item(1, i).Value = txtHoTen_Phat.Text
        dgvPhat.Item(2, i).Value = txtLyDo.Text
        dgvPhat.Item(3, i).Value = txtMucPhat.Text
        dgvPhat.Item(4, i).Value = dtpNgayPhat.Value.ToShortDateString()
    End Sub

    Private Sub btnXoaP_Click(sender As Object, e As EventArgs) Handles btnXoaP.Click
        If dgvPhat.CurrentRow IsNot Nothing Then
            dgvPhat.Rows.RemoveAt(dgvPhat.CurrentRow.Index)
        End If
    End Sub

    Private Sub btnThoatP_Click(sender As Object, e As EventArgs) Handles btnThoatP.Click
        Me.Close()
    End Sub

    Private Sub btnThemT_Click(sender As Object, e As EventArgs) Handles btnThemT.Click
        dgvThuong.Rows.Add(txtMaNV_Thuong.Text, txtHoTen_Thuong.Text, txtNoiDungThuong.Text,
                       txtSoTienThuong.Text, dtpNgayThuong.Value.ToShortDateString())
    End Sub

    Private Sub btnSuaT_Click(sender As Object, e As EventArgs) Handles btnSuaT.Click
        If dgvThuong.CurrentRow Is Nothing Then
            MessageBox.Show("Vui lòng chọn một dòng để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim i As Integer = dgvThuong.CurrentRow.Index
        dgvThuong.Item(0, i).Value = txtMaNV_Thuong.Text
        dgvThuong.Item(1, i).Value = txtHoTen_Thuong.Text
        dgvThuong.Item(2, i).Value = txtNoiDungThuong.Text
        dgvThuong.Item(3, i).Value = txtSoTienThuong.Text
        dgvThuong.Item(4, i).Value = dtpNgayThuong.Value.ToShortDateString()
    End Sub

    Private Sub btnXoaT_Click(sender As Object, e As EventArgs) Handles btnXoaT.Click
        If dgvThuong.CurrentRow IsNot Nothing Then
            dgvThuong.Rows.RemoveAt(dgvThuong.CurrentRow.Index)
        End If
    End Sub

    Private Sub btnThoatT_Click(sender As Object, e As EventArgs) Handles btnThoatT.Click
        Me.Close()
    End Sub

    Private Sub btnThemTT_Click(sender As Object, e As EventArgs) Handles btnThemTT.Click
        dgvThanhTich.Rows.Add(txtMaNV_TT.Text, txtHoTen_TT.Text, txtThanhTich.Text,
                         txtNam.Text, txtGhiChu.Text)
    End Sub

    Private Sub btnSuaTT_Click(sender As Object, e As EventArgs) Handles btnSuaTT.Click
        If dgvThanhTich.CurrentRow Is Nothing Then
            MessageBox.Show("Vui lòng chọn một dòng để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim i As Integer = dgvThanhTich.CurrentRow.Index
        dgvThanhTich.Item(0, i).Value = txtMaNV_TT.Text
        dgvThanhTich.Item(1, i).Value = txtHoTen_TT.Text
        dgvThanhTich.Item(2, i).Value = txtThanhTich.Text
        dgvThanhTich.Item(3, i).Value = txtNam.Text
        dgvThanhTich.Item(4, i).Value = txtGhiChu.Text
    End Sub

    Private Sub btnXoaTT_Click(sender As Object, e As EventArgs) Handles btnXoaTT.Click
        If dgvThanhTich.CurrentRow IsNot Nothing Then
            dgvThanhTich.Rows.RemoveAt(dgvThanhTich.CurrentRow.Index)
        End If
    End Sub

    Private Sub btnThoatTT_Click(sender As Object, e As EventArgs) Handles btnThoatTT.Click
        Me.Close()
    End Sub
End Class