Public Class score
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_np.Click
        Dim response
        response = MessageBox.Show("Voulez vous vraiment retourner au menu ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If response = vbYes Then
            Me.Close()
            Page_accueil.Show()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_quit.Click
        Page_accueil.Close()
        Jeu.Close()
        Me.Close()
    End Sub

    Private Sub score_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Page_accueil.Close()
        Jeu.Close()
    End Sub
End Class