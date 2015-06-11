<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaLoaiSP
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
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.txtTenLoaiSP = New System.Windows.Forms.TextBox()
        Me.txtMaLoaiSP = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbTen.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Location = New System.Drawing.Point(181, 59)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(75, 37)
        Me.btnTimKiem.TabIndex = 13
        Me.btnTimKiem.Text = "Tìm Kiếm"
        Me.btnTimKiem.UseVisualStyleBackColor = True
        '
        'txtTimKiem
        '
        Me.txtTimKiem.Location = New System.Drawing.Point(15, 68)
        Me.txtTimKiem.Name = "txtTimKiem"
        Me.txtTimKiem.Size = New System.Drawing.Size(139, 20)
        Me.txtTimKiem.TabIndex = 14
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(253, 119)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(349, 231)
        Me.DataGridView1.TabIndex = 12
        '
        'grbTen
        '
        Me.grbTen.Controls.Add(Me.btnClear)
        Me.grbTen.Controls.Add(Me.btnSua)
        Me.grbTen.Controls.Add(Me.btnXoa)
        Me.grbTen.Controls.Add(Me.btnThem)
        Me.grbTen.Controls.Add(Me.txtTenLoaiSP)
        Me.grbTen.Controls.Add(Me.txtMaLoaiSP)
        Me.grbTen.Controls.Add(Me.Label2)
        Me.grbTen.Controls.Add(Me.Label1)
        Me.grbTen.Location = New System.Drawing.Point(5, 119)
        Me.grbTen.Name = "grbTen"
        Me.grbTen.Size = New System.Drawing.Size(228, 231)
        Me.grbTen.TabIndex = 11
        Me.grbTen.TabStop = False
        Me.grbTen.Text = "Nhập thông tin thành viên"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(134, 175)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 37)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(7, 175)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 37)
        Me.btnSua.TabIndex = 8
        Me.btnSua.Text = "Sữa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(134, 120)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 37)
        Me.btnXoa.TabIndex = 7
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(7, 120)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 37)
        Me.btnThem.TabIndex = 6
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'txtTenLoaiSP
        '
        Me.txtTenLoaiSP.Location = New System.Drawing.Point(73, 78)
        Me.txtTenLoaiSP.Name = "txtTenLoaiSP"
        Me.txtTenLoaiSP.Size = New System.Drawing.Size(139, 20)
        Me.txtTenLoaiSP.TabIndex = 4
        '
        'txtMaLoaiSP
        '
        Me.txtMaLoaiSP.Location = New System.Drawing.Point(73, 33)
        Me.txtMaLoaiSP.Name = "txtMaLoaiSP"
        Me.txtMaLoaiSP.Size = New System.Drawing.Size(139, 20)
        Me.txtMaLoaiSP.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên Loại SP:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Loại SP:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Green
        Me.Label4.Location = New System.Drawing.Point(156, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(326, 29)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "QUẢN LÝ LOẠI SẢN PHẨM"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMaLoaiSP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 362)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnTimKiem)
        Me.Controls.Add(Me.txtTimKiem)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.grbTen)
        Me.Name = "frmMaLoaiSP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "96+"
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
    Friend WithEvents txtTenLoaiSP As System.Windows.Forms.TextBox
    Friend WithEvents txtMaLoaiSP As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
