Public Class UserControlLogin
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked

    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Form1.Guna2Panel1.Controls.Clear()
        Form1.Guna2Panel1.Controls.Add(New UserControlSign_Up())
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Form1.Guna2Panel1.Controls.Clear()
        Form1.Guna2Panel1.Controls.Add(New UserControlUseQRcodeToLogin())
    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        Form1.Guna2Panel1.Controls.Clear()
        Form1.Guna2Panel1.Controls.Add(New UserControlUsephoneEmailUsernameLogin())
    End Sub
End Class
