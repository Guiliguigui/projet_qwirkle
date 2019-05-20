Imports QwirkleLibrary
Public Class Jeu
    Private Sub Jeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Joueur1 As New Joueur(Page_accueil.TextBoxJ1.Text, 0, 1, {"vide", "vide", "vide", "vide", "vide", "vide"})
        Dim Joueur2 As New Joueur(Page_accueil.TextBoxJ2.Text, 0, 2, {"vide", "vide", "vide", "vide", "vide", "vide"})
        LabelNomJ1.Text = ("Score de " + Joueur1.Get_name() + " :")
        LabelNomJ2.Text = ("Score de " + Joueur2.Get_name() + " :")
        LabelScoreJ1.Text = (Joueur1.Get_points())
        LabelScoreJ2.Text = (Joueur2.Get_points())
        If (Page_accueil.RadioButton1.Checked) Then
            PanelJ3.Visible = False
            PanelJ4.Visible = False
        ElseIf (Page_accueil.RadioButton2.Checked) Then
            PanelJ3.Visible = True
            PanelJ4.Visible = False
            Dim Joueur3 As New Joueur(Page_accueil.TextBoxJ3.Text, 0, 3, {"vide", "vide", "vide", "vide", "vide", "vide"})
            LabelNomJ3.Text = ("Score de " + Joueur3.Get_name() + " :")
            LabelScoreJ3.Text = (Joueur3.Get_points())
        ElseIf (Page_accueil.RadioButton3.Checked) Then
            PanelJ3.Visible = True
            PanelJ4.Visible = True
            Dim Joueur3 As New Joueur(Page_accueil.TextBoxJ3.Text, 0, 3, {"vide", "vide", "vide", "vide", "vide", "vide"})
            LabelNomJ3.Text = ("Score de " + Joueur3.Get_name() + " :")
            LabelScoreJ3.Text = (Joueur3.Get_points())
            Dim Joueur4 As New Joueur(Page_accueil.TextBoxJ4.Text, 0, 4, {"vide", "vide", "vide", "vide", "vide", "vide"})
            LabelNomJ4.Text = ("Score de " + Joueur4.Get_name() + " :")
            LabelScoreJ4.Text = (Joueur4.Get_points())
        End If
        Dim LaPioche As New Pioche(New Integer(5, 5) {{3, 3, 3, 3, 3, 3}, {3, 3, 3, 3, 3, 3}, {3, 3, 3, 3, 3, 3}, {3, 3, 3, 3, 3, 3}, {3, 3, 3, 3, 3, 3}, {3, 3, 3, 3, 3, 3}})
        RestePioche.Text = (LaPioche.Comptage(LaPioche.Get_TuilesRestantes()))

        'For i As Byte = 1 To 6
        '    AddHandler Me.pnlMain.Controls("picMain" & i).MouseMove, AddressOf pic_MouseMove
        'Next

        '    For i As Byte = 1 To 30
        '        For j As Byte = 1 To 30

        '            If (i < 10) Then
        '                If (j < 10) Then


        '                    Me.pnlPlateau.Controls("pic0" & i & "0" & j).AllowDrop = True
        '                    AddHandler Me.pnlPlateau.Controls("pic0" & i & "0" & j).DragEnter, AddressOf pic_DragEnter
        '                    AddHandler Me.pnlPlateau.Controls("pic0" & i & "0" & j).DragDrop, AddressOf pic_DragDrop

        '                Else
        '                    Me.pnlPlateau.Controls("pic0" & i & j).AllowDrop = True
        '                    AddHandler Me.pnlPlateau.Controls("pic0" & i & j).DragEnter, AddressOf pic_DragEnter
        '                    AddHandler Me.pnlPlateau.Controls("pic0" & i & j).DragDrop, AddressOf pic_DragDrop
        '                End If

        '            Else
        '                If (j < 10) Then
        '                    Me.pnlPlateau.Controls("pic" & i & j).AllowDrop = True
        '                    AddHandler Me.pnlPlateau.Controls("pic" & i & "0" & j).DragEnter, AddressOf pic_DragEnter
        '                    AddHandler Me.pnlPlateau.Controls("pic" & i & "0" & j).DragDrop, AddressOf pic_DragDrop

        '                Else
        '                    Me.pnlPlateau.Controls("pic" & i & j).AllowDrop = True
        '                    AddHandler Me.pnlPlateau.Controls("pic" & i & j).DragEnter, AddressOf pic_DragEnter
        '                    AddHandler Me.pnlPlateau.Controls("pic" & i & j).DragDrop, AddressOf pic_DragDrop
        '                End If
        '            End If
        '        Next
        '    Next
        'End Sub

        'Private Sub pic_MouseMove(sender As Object, e As MouseEventArgs) Handles picMain1.mouseMove
        '    Dim effetRealise As DragDropEffects
        '    Dim pic As PictureBox = sender

        '    If e.Button = MouseButtons.Left AndAlso pic.Image IsNot Nothing Then
        '        pic.AllowDrop = False
        '        effetRealise = pic.DoDragDrop(pic.BackColor, DragDropEffects.Move)
        '        If effetRealise = DragDropEffects.Move Then
        '            pic.Image = Nothing
        '        End If
        '        pic.AllowDrop = True
        '    End If
        'End Sub

        'Private Sub pic_DragEnter(sender As Object, e As DragEventArgs) Handles pic0101.DragEnter

        '    If e.Data.GetDataPresent(DataFormats.Bitmap) Then
        '        e.Effect = DragDropEffects.Move
        '    Else
        '        e.Effect = DragDropEffects.None
        '    End If

    End Sub

    'Private Sub pic_DragDrop(sender As Object, e As DragEventArgs) Handles pic0101.DragDrop
    '    Dim pic As PictureBox = sender
    '    pic.Image = e.Data.GetData(DataFormats.Bitmap)

    'End Sub

    Private Sub btnValide_Click(sender As Object, e As EventArgs) Handles btnValide.Click

    End Sub

    Private Sub btnAnnule_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnRetourMenu_Click(sender As Object, e As EventArgs) Handles btnRetourMenu.Click
        Dim response
        response = MessageBox.Show("Voulez vous vraiment retourner au menu ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If response = vbYes Then
            Me.Close()
        End If
    End Sub
End Class