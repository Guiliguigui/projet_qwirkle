Imports QwirkleLibrary
Public Class Scores
    Dim ListeJoueur As List(Of Joueur)
    Private Sub Scores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim NbJoueurs As Integer

        If (Page_accueil.RadioButton1.Checked) Then
            NbJoueurs = 2
        ElseIf (Page_accueil.RadioButton2.Checked) Then
            NbJoueurs = 3
        ElseIf (Page_accueil.RadioButton3.Checked) Then
            NbJoueurs = 4
        End If

        Select Case NbJoueurs
            Case 2
                If (Joueur1.Get_points > Joueur2.Get_points) Then
                    numero1.Text = Joueur1.Get_name
                Else
                    numero1.Text = Joueur2.Get_name
                End If
            Case 3

                ListeJoueur.Add(Joueur1)
                ListeJoueur.Add(Joueur2)
                ListeJoueur.Add(Joueur3)
                Dim max As Integer = 0
                Dim nogagnant, i As Integer

                For Each joueur In ListeJoueur
                    If (joueur.Get_points > max) Then
                        max = joueur.Get_points
                        nogagnant = i
                    End If
                    i = i + 1
                Next

                numero1.Text = ListeJoueur.Item(nogagnant).Get_name()

            Case 4

                ListeJoueur.Add(Joueur1)
                ListeJoueur.Add(Joueur2)
                ListeJoueur.Add(Joueur3)
                ListeJoueur.Add(Joueur4)
                Dim max As Integer = 0
                Dim nogagnant, i As Integer

                For Each joueur In ListeJoueur
                    If (joueur.Get_points > max) Then
                        max = joueur.Get_points
                        nogagnant = i - 1
                    End If
                    i = i + 1
                Next

                numero1.Text = ListeJoueur.Item(nogagnant).Get_name()
        End Select

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_np.Click
        Dim response
        response = MessageBox.Show("Voulez vous vraiment retourner au menu ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If response = vbYes Then
            Me.Close()
            For Each joueur In ListeJoueur
                joueur.Set_main(New String() {"vide", "vide", "vide", "vide", "vide", "vide"})
                joueur.Set_points(0)
            Next

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