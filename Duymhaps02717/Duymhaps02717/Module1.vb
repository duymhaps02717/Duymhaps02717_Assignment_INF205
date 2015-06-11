Module Module1
    Public Sub ExitApp()
        Dim Message As String 'Tạo biến Message.

        'Gán Bảng thông báo cho biến Message.
        Message = MessageBox.Show( _
            "Bạn có chắc chắn muốn thoát ?", _
            "Lưu ý !", _
            MessageBoxButtons.YesNo, _
            MessageBoxIcon.Warning) 'Hiện thông báo xác nhận thoát chương trình.

        If (Message = Windows.Forms.DialogResult.Yes) Then
            'Nếu người dùng chọn Yes  thì thoát chương trình.
            Application.Exit()
        End If 'Đóng cửa sổ ứng dụng.
    End Sub
End Module
