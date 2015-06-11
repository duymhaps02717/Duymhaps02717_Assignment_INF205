<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLyKhachHang
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
        Me.txtSoDT = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.txtGioiTinh = New System.Windows.Forms.TextBox()
        Me.txtTenKH = New System.Windows.Forms.TextBox()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbTen.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Location = New System.Drawing.Point(189, 67)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(75, 37)
        Me.btnTimKiem.TabIndex = 13
        Me.btnTimKiem.Text = "Tìm Kiếm"
        Me.btnTimKiem.UseVisualStyleBackColor = True
        '
        'txtTimKiem
        '
        Me.txtTimKiem.Location = New System.Drawing.Point(23, 76)
        Me.txtTimKiem.Name = "txtTimKiem"
        Me.txtTimKiem.Size = New System.Drawing.Size(139, 20)
        Me.txtTimKiem.TabIndex = 14
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(261, 127)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(540, 360)
        Me.DataGridView1.TabIndex = 12
        '
        'grbTen
        '
        Me.grbTen.Controls.Add(Me.txtSoDT)
        Me.grbTen.Controls.Add(Me.Label5)
        Me.grbTen.Controls.Add(Me.txtDiaChi)
        Me.grbTen.Controls.Add(Me.Label4)
        Me.grbTen.Controls.Add(Me.btnClear)
        Me.grbTen.Controls.Add(Me.btnSua)
        Me.grbTen.Controls.Add(Me.btnXoa)
        Me.grbTen.Controls.Add(Me.btnThem)
        Me.grbTen.Controls.Add(Me.txtGioiTinh)
        Me.grbTen.Controls.Add(Me.txtTenKH)
        Me.grbTen.Controls.Add(Me.txtMaKH)
        Me.grbTen.Controls.Add(Me.Label3)
        Me.grbTen.Controls.Add(Me.Label2)
        Me.grbTen.Controls.Add(Me.Label1)
        Me.grbTen.Location = New System.Drawing.Point(13, 127)
        Me.grbTen.Name = "grbTen"
        Me.grbTen.Size = New System.Drawing.Size(228, 366)
        Me.grbTen.TabIndex = 11
        Me.grbTen.TabStop = False
        Me.grbTen.Text = "Nhập thông tin khách hàng"
        '
        'txtSoDT
        '
        Me.txtSoDT.Location = New System.Drawing.Point(73, 222)
        Me.txtSoDT.Name = "txtSoDT"
        Me.txtSoDT.Size = New System.Drawing.Size(139, 20)
        Me.txtSoDT.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Số DT"
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(73, 173)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(139, 20)
        Me.txtDiaChi.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Địa Chỉ"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(137, 323)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 37)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(10, 323)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 37)
        Me.btnSua.TabIndex = 8
        Me.btnSua.Text = "Sữa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(137, 268)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 37)
        Me.btnXoa.TabIndex = 7
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(10, 268)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 37)
        Me.btnThem.TabIndex = 6
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'txtGioiTinh
        '
        Me.txtGioiTinh.Location = New System.Drawing.Point(73, 126)
        Me.txtGioiTinh.Name = "txtGioiTinh"
        Me.txtGioiTinh.Size = New System.Drawing.Size(139, 20)
        Me.txtGioiTinh.TabIndex = 5
        '
        'txtTenKH
        '
        Me.txtTenKH.Location = New System.Drawing.Point(73, 78)
        Me.txtTenKH.Name = "txtTenKH"
        Me.txtTenKH.Size = New System.Drawing.Size(139, 20)
        Me.txtTenKH.TabIndex = 4
        '
        'txtMaKH
        '
        Me.txtMaKH.Location = New System.Drawing.Point(73, 33)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(139, 20)
        Me.txtMaKH.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Giới Tính"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên KH"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MaKH"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Green
        Me.Label6.Location = New System.Drawing.Point(256, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(297, 29)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "QUẢN LÝ KHÁCH HÀNG"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmQuanLyKhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 499)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnTimKiem)
        Me.Controls.Add(Me.txtTimKiem)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.grbTen)
        Me.Name = "frmQuanLyKhachHang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QuanLyKhachHang"
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
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents txtGioiTinh As System.Windows.Forms.TextBox
    Friend WithEvents txtTenKH As System.Windows.Forms.TextBox
    Friend WithEvents txtMaKH As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSoDT As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDiaChi As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
