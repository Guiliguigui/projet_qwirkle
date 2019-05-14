Public Class Page_accueil
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panelj4.Enabled = False
        Panelj3.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panelj3.Enabled = True
        Panelj4.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panelj4.Enabled = True
        Panelj3.Enabled = True
    End Sub

    Private Sub commencer_Click(sender As Object, e As EventArgs) Handles commencer.Click
        Jeu.ShowDialog()
    End Sub
End Class
