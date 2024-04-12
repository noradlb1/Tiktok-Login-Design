Public Class UserControlUsephoneEmailUsernameLogin
    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Form1.Guna2Panel1.Controls.Clear()
        Form1.Guna2Panel1.Controls.Add(New UserControlSign_Up())
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Form1.Guna2Panel1.Controls.Clear()
        Form1.Guna2Panel1.Controls.Add(New LogInWithEmailOrUsername())
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form1.Guna2Panel1.Controls.Clear()
        Form1.Guna2Panel1.Controls.Add(New LogInWithPassword())
    End Sub
End Class
