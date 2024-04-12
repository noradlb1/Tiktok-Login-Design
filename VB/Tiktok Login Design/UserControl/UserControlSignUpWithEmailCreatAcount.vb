Public Class UserControlSignUpWithEmailCreatAcount
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Form1.Guna2Panel1.Controls.Clear()
        Form1.Guna2Panel1.Controls.Add(New UserControlSignUpCreatAcount())
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Form1.Guna2Panel1.Controls.Clear()
        Form1.Guna2Panel1.Controls.Add(New UserControlLogin())
    End Sub
End Class
