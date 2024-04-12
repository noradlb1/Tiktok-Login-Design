Public Class UserControlSign_Up
    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Form1.Guna2Panel1.Controls.Clear()
        Form1.Guna2Panel1.Controls.Add(New UserControlLogin())
    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        Form1.Guna2Panel1.Controls.Clear()
        Form1.Guna2Panel1.Controls.Add(New UserControlSignUpCreatAcount())
    End Sub
End Class
