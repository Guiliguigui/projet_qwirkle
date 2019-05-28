Public Class Scores
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_np.Click
        Dim response
        response = MessageBox.Show("Voulez vous vraiment retourner au menu ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If response = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_quit.Click
        Page_accueil.Close()
        Jeu.Close()
        Me.Close()
    End Sub

    Private Sub score_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Page_accueil.Show()
        Jeu.Close()
    End Sub
End Class