Public Class Jeu
    Private Sub Jeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = ("Score de " + +" :")
        Label9.Text = ("Score de " + Page_accueil.TextBoxJ2.Text + " :")
        If (Page_accueil.RadioButton1.Checked) Then
            Panel4.Visible = False
            Panel5.Visible = False
        ElseIf (Page_accueil.RadioButton2.Checked) Then
            Panel4.Visible = True
            Panel5.Visible = False
            Label13.Text = ("Score de " + Page_accueil.TextBoxJ3.Text + " :")
        ElseIf (Page_accueil.RadioButton3.Checked) Then
            Panel4.Visible = True
            Panel5.Visible = True
            Label17.Text = ("Score de " + Page_accueil.TextBoxJ4.Text + " :")
        End If
    End Sub


End Class