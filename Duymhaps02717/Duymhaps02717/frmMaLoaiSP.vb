﻿Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmMaLoaiSP
    Dim database As New DataTable ' Tạo đối tượng database để lưu trữ dữ liệu từ Database Online
    'Tạo chuỗi kết nối để kết nối tới Database Online
    Dim chuoiconnect As String = "workstation id=Duymhaps02717.mssql.somee.com;packet size=4096;user id=PS02717;pwd=1231230duy;data source=Duymhaps02717.mssql.somee.com;persist security info=False;initial catalog=Duymhaps02717"
    Private Sub frmMaLoaiSP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect) ' Tạo đối tượng kết nối tới DB  Online
        ' Câu truy vấn để get dữ liệu
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from LoaiSanPham", connect)
        'Kết nối mở ra
        If DataGridView1.Rows.Count > 0 Then
            'Nếu có dữ liệu thì xóa database để load lại tránh bị trùng dữ liệu
            database.Clear()
        End If
        connect.Open()
        'Đổ dữ liệu vào đối tượng database
        Query1.Fill(database)
        'Hiển thị dữ liệu ra Datagridview
        DataGridView1.DataSource = database.DefaultView
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim index As Integer = DataGridView1.CurrentCell.RowIndex
        txtMaLoaiSP.Text = DataGridView1.Item(0, index).Value
        txtTenLoaiSP.Text = DataGridView1.Item(1, index).Value
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        ' Tạo đối tượng kết nối
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        'Tạo query câu truy vấn Insert into
        Dim Query2 As String = "insert into LoaiSanPham values (@MaLoaiSP, @TenLoaiSP)"
        'Tạo đối tượng để thực thi câu truy vấn với DB ONline
        Dim ExecuteQuery1 As New SqlCommand(Query2, connect)
        'Kết nối mở ra
        connect.Open()

        Try
            'Truyền giá trị trong các ô textbox cho các biến tương ứng
            ExecuteQuery1.Parameters.AddWithValue("@MaLoaiSP", txtMaLoaiSP.Text)
            ExecuteQuery1.Parameters.AddWithValue("@TenLoaiSP", txtTenLoaiSP.Text)

            'Exucute là ghi dữ liệu vào Database
            ExecuteQuery1.ExecuteNonQuery()
            connect.Close()
            MessageBox.Show("Thêm thành công")
        Catch ex As Exception
            'Nếu thêm không được thì hiển thị thông báo
            MessageBox.Show("Không thêm được!")

        End Try
        'Refresh bang
        Dim Query3 As SqlDataAdapter = New SqlDataAdapter("select * from LoaiSanPham", connect)
        database.Clear()

        Query3.Fill(database)
        DataGridView1.DataSource = database.DefaultView
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim ketnoi1 As New SqlConnection(chuoiconnect)
        ketnoi1.Open()
        Dim Stradd1 As String = "Update LoaiSanPham Set TenLoaiSP = @TenLoaiSP where MaLoaiSP = @MaLoaiSP"
        Dim com As New SqlCommand(Stradd1, ketnoi1)
        Try
            com.Parameters.AddWithValue("@MaLoaiSP", txtMaLoaiSP.Text)
            com.Parameters.AddWithValue("@TenLoaiSP", txtTenLoaiSP.Text)
            com.ExecuteNonQuery()
            ketnoi1.Close()
            MessageBox.Show("Sữa thành công")
        Catch ex As Exception
            MessageBox.Show("Sữa không thành công")
        End Try
        database.Clear()
        DataGridView1.DataSource = database
        DataGridView1.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub LoadData()
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from LoaiSanPham", connect)

        connect.Open()
        Query1.Fill(database)
        DataGridView1.DataSource = database.DefaultView
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim ketnoi As New SqlConnection(chuoiconnect)
        ketnoi.Open()
        Dim xoadl As String = "Delete from LoaiSanPham Where MaLoaiSP = @MaLoaiSP"
        Dim lenh As New SqlCommand(xoadl, ketnoi)
        Try
            lenh.Parameters.AddWithValue("@MaLoaiSP", txtMaLoaiSP.Text)
            lenh.ExecuteNonQuery()
            ketnoi.Close()
        Catch ex As Exception
            MessageBox.Show("Xoá không thành công")
        End Try
        database.Clear()
        DataGridView1.DataSource = database
        DataGridView1.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        ' Tạo đối tượng kết nối tới DB Online
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        'Kiểm tra DataGridView đã có dữ liệu chưa
        If DataGridView1.Rows.Count > 0 Then
            'Nếu có dữ liệu thì xóa database để load lại tránh bị trùng dữ liệu
            database.Clear()
        End If
        ' Câu truy vấn để get dữ liệu
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("Select * from LoaiSanPham Where MaLoaiSP Like N'%" & txtTimKiem.Text & "%' or TenLoaiSP Like N'%" & txtTimKiem.Text & "%'", connect)
        Try
            connect.Open()
            Query1.Fill(database)
            If database.Rows.Count > 0 Then
                DataGridView1.DataSource = database.DefaultView
            Else
                MessageBox.Show("Không tìm thấy")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtMaLoaiSP.Clear()
        txtTenLoaiSP.Clear()

    End Sub
End Class