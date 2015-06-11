Imports System.Data.SqlClient

'***************************************************************************************
'Author: Mai Hữu Anh Duy.
'Description: Form Login của chương trình.
'***************************************************************************************

Public Class frmLogin
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ExitApp()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim chuoiketnoi As String = "workstation id=Duymhaps02717.mssql.somee.com;packet size=4096;user id=PS02717;pwd=1231230duy;data source=Duymhaps02717.mssql.somee.com;persist security info=False;initial catalog=Duymhaps02717"

        Dim KetNoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim sqlAdapter As New SqlDataAdapter("select * from NhanVien where MaNhanVien='" & txtUsername.Text & "' and Password='" & txtPassword.Text & "' ", KetNoi)
        Dim tb As New DataTable

        Try
            KetNoi.Open()
            sqlAdapter.Fill(tb)
            If tb.Rows.Count > 0 Then
                MessageBox.Show("Kết nối thành công")
                frmMain.Show()
                Me.Hide()
            Else
                MessageBox.Show("Sai Tên đăng nhập hoặc Mật khẩu")
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
