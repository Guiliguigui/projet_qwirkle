Public Class Page_accueil
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panelj4.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panelj3.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panelj4.Enabled = True
    End Sub
End Class
