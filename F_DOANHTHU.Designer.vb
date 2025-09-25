<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_DOANHTHU
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTongTien = New System.Windows.Forms.Label()
        Me.dtpDenNgay = New System.Windows.Forms.DateTimePicker()
        Me.dtpTuNgay = New System.Windows.Forms.DateTimePicker()
        Me.btnThongKe = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvDoanhThu = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvDoanhThu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.lblTongTien)
        Me.GroupBox1.Controls.Add(Me.dtpDenNgay)
        Me.GroupBox1.Controls.Add(Me.dtpTuNgay)
        Me.GroupBox1.Controls.Add(Me.btnThongKe)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dgvDoanhThu)
        Me.GroupBox1.Location = New System.Drawing.Point(-7, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1066, 574)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'lblTongTien
        '
        Me.lblTongTien.AutoSize = True
        Me.lblTongTien.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblTongTien.Location = New System.Drawing.Point(449, 461)
        Me.lblTongTien.Name = "lblTongTien"
        Me.lblTongTien.Size = New System.Drawing.Size(149, 36)
        Me.lblTongTien.TabIndex = 6
        Me.lblTongTien.Text = "Tổng tiên"
        '
        'dtpDenNgay
        '
        Me.dtpDenNgay.Location = New System.Drawing.Point(249, 433)
        Me.dtpDenNgay.Name = "dtpDenNgay"
        Me.dtpDenNgay.Size = New System.Drawing.Size(129, 22)
        Me.dtpDenNgay.TabIndex = 5
        '
        'dtpTuNgay
        '
        Me.dtpTuNgay.Location = New System.Drawing.Point(68, 433)
        Me.dtpTuNgay.Name = "dtpTuNgay"
        Me.dtpTuNgay.Size = New System.Drawing.Size(129, 22)
        Me.dtpTuNgay.TabIndex = 5
        '
        'btnThongKe
        '
        Me.btnThongKe.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnThongKe.Location = New System.Drawing.Point(110, 487)
        Me.btnThongKe.Name = "btnThongKe"
        Me.btnThongKe.Size = New System.Drawing.Size(224, 51)
        Me.btnThongKe.TabIndex = 3
        Me.btnThongKe.Text = "Thống kê"
        Me.btnThongKe.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label4.Location = New System.Drawing.Point(245, 396)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Đến ngày"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 396)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Từ ngày "
        '
        'dgvDoanhThu
        '
        Me.dgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDoanhThu.Location = New System.Drawing.Point(13, 15)
        Me.dgvDoanhThu.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvDoanhThu.Name = "dgvDoanhThu"
        Me.dgvDoanhThu.RowHeadersWidth = 51
        Me.dgvDoanhThu.Size = New System.Drawing.Size(1036, 358)
        Me.dgvDoanhThu.TabIndex = 0
        '
        'F_DOANHTHU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1071, 589)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "F_DOANHTHU"
        Me.Text = "F_DOANHTHU"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvDoanhThu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtpDenNgay As DateTimePicker
    Friend WithEvents dtpTuNgay As DateTimePicker
    Friend WithEvents btnThongKe As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvDoanhThu As DataGridView
    Friend WithEvents lblTongTien As Label
End Class
