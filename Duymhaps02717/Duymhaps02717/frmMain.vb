Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        frmlogin.ShowDialog()
    End Sub

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        ExitApp()
    End Sub

    Private Sub LogOffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOffToolStripMenuItem.Click

    End Sub

    Private Sub TàiKhoảnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TàiKhoảnToolStripMenuItem.Click
        frmQuanLyThanhVien.ShowDialog()
    End Sub

    Private Sub KháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KháchHàngToolStripMenuItem.Click
        frmQuanLyKhachHang.ShowDialog()
    End Sub

    Private Sub SảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SảnPhẩmToolStripMenuItem.Click
        frmQuanLySanPham.ShowDialog()
    End Sub

    Private Sub LoạiSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoạiSảnPhẩmToolStripMenuItem.Click
        frmMaLoaiSP.ShowDialog()
    End Sub
End Class