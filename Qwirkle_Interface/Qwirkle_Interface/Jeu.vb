Imports QwirkleLibrary
Public Class Jeu
    Private Sub Jeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Joueur1 As New Joueur(Page_accueil.TextBoxJ1.Text, 0, 1, {"vide", "vide", "vide", "vide", "vide", "vide"})
        Dim Joueur2 As New Joueur(Page_accueil.TextBoxJ2.Text, 0, 2, {"vide", "vide", "vide", "vide", "vide", "vide"})
        LabelNomJ1.Text = ("Score de " + Joueur1.Get_name() + " :")
        LabelNomJ2.Text = ("Score de " + Joueur2.Get_name() + " :")
        LabelScoreJ1.Text = Joueur1.Get_points()
        LabelScoreJ2.Text = Joueur2.Get_points()
        If (Page_accueil.RadioButton1.Checked) Then
            PanelJ3.Visible = False
            PanelJ4.Visible = False
        ElseIf (Page_accueil.RadioButton2.Checked) Then
            PanelJ3.Visible = True
            PanelJ4.Visible = False
            Dim Joueur3 As New Joueur(Page_accueil.TextBoxJ3.Text, 0, 3, {"vide", "vide", "vide", "vide", "vide", "vide"})
            LabelNomJ3.Text = ("Score de " + Joueur3.Get_name() + " :")
            LabelScoreJ3.Text = Joueur3.Get_points()
        ElseIf (Page_accueil.RadioButton3.Checked) Then
            PanelJ3.Visible = True
            PanelJ4.Visible = True
            Dim Joueur3 As New Joueur(Page_accueil.TextBoxJ3.Text, 0, 3, {"vide", "vide", "vide", "vide", "vide", "vide"})
            Dim Joueur4 As New Joueur(Page_accueil.TextBoxJ4.Text, 0, 4, {"vide", "vide", "vide", "vide", "vide", "vide"})
            LabelNomJ3.Text = ("Score de " + Joueur3.Get_name() + " :")
            LabelNomJ4.Text = ("Score de " + Joueur4.Get_name() + " :")
            LabelScoreJ3.Text = Joueur3.Get_points()
            LabelScoreJ4.Text = Joueur4.Get_points()
        End If
        Dim LaPioche As New Pioche(New Integer(5, 5) {{3, 3, 3, 3, 3, 3}, {3, 3, 3, 3, 3, 3}, {3, 3, 3, 3, 3, 3}, {3, 3, 3, 3, 3, 3}, {3, 3, 3, 3, 3, 3}, {3, 3, 3, 3, 3, 3}})
        RestePioche.Text = (LaPioche.Comptage(LaPioche.Get_TuilesRestantes()))
    End Sub

End Class