<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLySanPham
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
        Me.btnTimKiem = New System.Windows.Forms.Button()
        Me.txtTimKiem = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.grbTen = New System.Windows.Forms.GroupBox()
        Me.txtMaLoaiSP = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtChiTietSP = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSoLuong = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.txtDonGia = New System.Windows.Forms.TextBox()
        Me.txtTenSP = New System.Windows.Forms.TextBox()
        Me.txtMaSP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbTen.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Location = New System.Drawing.Point(188, 54)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(75, 37)
        Me.btnTimKiem.TabIndex = 17
        Me.btnTimKiem.Text = "Tìm Kiếm"
        Me.btnTimKiem.UseVisualStyleBackColor = True
        '
        'txtTimKiem
        '
        Me.txtTimKiem.Location = New System.Drawing.Point(22, 63)
        Me.txtTimKiem.Name = "txtTimKiem"
        Me.txtTimKiem.Size = New System.Drawing.Size(139, 20)
        Me.txtTimKiem.TabIndex = 18
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(340, 114)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(569, 405)
        Me.DataGridView1.TabIndex = 16
        '
        'grbTen
        '
        Me.grbTen.Controls.Add(Me.txtMaLoaiSP)
        Me.grbTen.Controls.Add(Me.Label6)
        Me.grbTen.Controls.Add(Me.txtChiTietSP)
        Me.grbTen.Controls.Add(Me.Label5)
        Me.grbTen.Controls.Add(Me.txtSoLuong)
        Me.grbTen.Controls.Add(Me.Label4)
        Me.grbTen.Controls.Add(Me.btnClear)
        Me.grbTen.Controls.Add(Me.btnSua)
        Me.grbTen.Controls.Add(Me.btnXoa)
        Me.grbTen.Controls.Add(Me.btnThem)
        Me.grbTen.Controls.Add(Me.txtDonGia)
        Me.grbTen.Controls.Add(Me.txtTenSP)
        Me.grbTen.Controls.Add(Me.txtMaSP)
        Me.grbTen.Controls.Add(Me.Label3)
        Me.grbTen.Controls.Add(Me.Label2)
        Me.grbTen.Controls.Add(Me.Label1)
        Me.grbTen.Location = New System.Drawing.Point(12, 114)
        Me.grbTen.Name = "grbTen"
        Me.grbTen.Size = New System.Drawing.Size(307, 411)
        Me.grbTen.TabIndex = 15
        Me.grbTen.TabStop = False
        Me.grbTen.Text = "Nhập thông tin sản phẩm"
        '
        'txtMaLoaiSP
        '
        Me.txtMaLoaiSP.Location = New System.Drawing.Point(108, 270)
        Me.txtMaLoaiSP.Name = "txtMaLoaiSP"
        Me.txtMaLoaiSP.Size = New System.Drawing.Size(193, 20)
        Me.txtMaLoaiSP.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 277)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Mã Loại SP:"
        '
        'txtChiTietSP
        '
        Me.txtChiTietSP.Location = New System.Drawing.Point(108, 222)
        Me.txtChiTietSP.Name = "txtChiTietSP"
        Me.txtChiTietSP.Size = New System.Drawing.Size(193, 20)
        Me.txtChiTietSP.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Chi Tiết Sản Phẩm:"
        '
        'txtSoLuong
        '
        Me.txtSoLuong.Location = New System.Drawing.Point(108, 173)
        Me.txtSoLuong.Name = "txtSoLuong"
        Me.txtSoLuong.Size = New System.Drawing.Size(193, 20)
        Me.txtSoLuong.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Số Lượng:"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(135, 368)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 37)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(8, 368)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 37)
        Me.btnSua.TabIndex = 8
        Me.btnSua.Text = "Sữa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(135, 313)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 37)
        Me.btnXoa.TabIndex = 7
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(8, 313)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 37)
        Me.btnThem.TabIndex = 6
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'txtDonGia
        '
        Me.txtDonGia.Location = New System.Drawing.Point(108, 126)
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.Size = New System.Drawing.Size(193, 20)
        Me.txtDonGia.TabIndex = 5
        '
        'txtTenSP
        '
        Me.txtTenSP.Location = New System.Drawing.Point(108, 78)
        Me.txtTenSP.Name = "txtTenSP"
        Me.txtTenSP.Size = New System.Drawing.Size(193, 20)
        Me.txtTenSP.TabIndex = 4
        '
        'txtMaSP
        '
        Me.txtMaSP.Location = New System.Drawing.Point(108, 33)
        Me.txtMaSP.Name = "txtMaSP"
        Me.txtMaSP.Size = New System.Drawing.Size(193, 20)
        Me.txtMaSP.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Đơn Giá:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên SP:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MaSP:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Green
        Me.Label7.Location = New System.Drawing.Point(335, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(262, 29)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "QUẢN LÝ SẢN PHẨM"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmQuanLySanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(921, 531)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnTimKiem)
        Me.Controls.Add(Me.txtTimKiem)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.grbTen)
        Me.Name = "frmQuanLySanPham"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QuanLySanPham"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbTen.ResumeLayout(False)
        Me.grbTen.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnTimKiem As System.Windows.Forms.Button
    Friend WithEvents txtTimKiem As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents grbTen As System.Windows.Forms.GroupBox
    Friend WithEvents txtChiTietSP As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSoLuong As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents txtDonGia As System.Windows.Forms.TextBox
    Friend WithEvents txtTenSP As System.Windows.Forms.TextBox
    Friend WithEvents txtMaSP As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMaLoaiSP As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
