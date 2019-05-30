Imports QwirkleLibrary
Public Class Jeu
    Dim taillePic, origineX, origineY As Integer
    Dim NbJoueurs As Integer = 2
    Dim PremiereTuile As Boolean
    Dim TourDuJoueur As Integer = 1
    Dim AncienneCases As New List(Of PictureBox)
    Dim ListeJoueur As New List(Of Joueur)
    Dim Main(6) As String
    Dim FormeNum As Integer
    Dim CouleurNum As Integer
    Dim Tuile As String
    Dim random As New Random()

    Dim LaPioche = New Pioche(New Integer(5, 5) {{3, 3, 3, 3, 3, 3}, {3, 3, 3, 3, 3, 3}, {3, 3, 3, 3, 3, 3}, {3, 3, 3, 3, 3, 3}, {3, 3, 3, 3, 3, 3}, {3, 3, 3, 3, 3, 3}})





    Private Sub Jeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If (Page_accueil.RadioButton1.Checked) Then
            NbJoueurs = 2
        ElseIf (Page_accueil.RadioButton2.Checked) Then
            NbJoueurs = 3
        ElseIf (Page_accueil.RadioButton3.Checked) Then
            NbJoueurs = 4
        End If

        LabelNomJ1.Text = ("Score de " + Joueur1.Get_name() + " :")
        LabelNomJ2.Text = ("Score de " + Joueur2.Get_name() + " :")
        LabelScoreJ1.Text = (Joueur1.Get_points())
        LabelScoreJ2.Text = (Joueur2.Get_points())

        ListeJoueur.Add(Joueur1)
        ListeJoueur.Add(Joueur2)

        Select Case (NbJoueurs)
            Case 2
                PanelJ3.Visible = False
                PanelJ4.Visible = False

            Case 3
                PanelJ3.Visible = True
                PanelJ4.Visible = False
                LabelNomJ3.Text = ("Score de " + Joueur3.Get_name() + " :")
                LabelScoreJ3.Text = (Joueur3.Get_points())
                ListeJoueur.Add(Joueur3)

            Case 4
                PanelJ3.Visible = True
                PanelJ4.Visible = True
                LabelNomJ3.Text = ("Score de " + Joueur3.Get_name() + " :")
                LabelScoreJ3.Text = (Joueur3.Get_points())
                LabelNomJ4.Text = ("Score de " + Joueur4.Get_name() + " :")
                LabelScoreJ4.Text = (Joueur4.Get_points())
                ListeJoueur.Add(Joueur4)

        End Select


        For Each joueur In ListeJoueur 'initialisation des mains des joueurs

            For i As Byte = 1 To 6

                FormeNum = random.Next(1, 7)
                CouleurNum = random.Next(1, 7)
                While (LaPioche.Suppr_tuile(CouleurNum - 1, FormeNum - 1) = False)
                    FormeNum = random.Next(1, 7)
                    CouleurNum = random.Next(1, 7)
                End While

                Tuile = TuileID.TuileNom(FormeNum, CouleurNum)
                Main(i) = Tuile

            Next
            joueur.Set_main(Main)
        Next


        RestePioche.Text = (LaPioche.Comptage(LaPioche.Get_TuilesRestantes()))

        taillePic = 17
        origineX = 17
        origineY = 17

        'gestion main du joueur 1 et initialisation des picturebox main

        For i As Integer = 1 To 6
            Dim picMain As PictureBox = Me.Controls("picMain" & i)
            picMain.SizeMode = PictureBoxSizeMode.StretchImage
            picMain.BorderStyle = BorderStyle.FixedSingle
            AddHandler picMain.MouseMove, AddressOf pic_MouseMove
            picMain.Image = My.Resources.ResourceManager.GetObject(Joueur1.Get_main()(i))
            picMain.Image.Tag = Joueur1.Get_main()(i)
        Next

        Dim Memorypic As PictureBox
        For i As Byte = 1 To 30
            For j As Byte = 1 To 30

                Dim newpic As New PictureBox

                newpic.Name = "pic" & i & "_" & j

                newpic.Size = New Size(taillePic, taillePic)
                newpic.BorderStyle = BorderStyle.FixedSingle
                newpic.SizeMode = PictureBoxSizeMode.StretchImage


                If i = 1 AndAlso j = 1 Then
                    newpic.Location = New Point(origineX, origineY)
                Else
                    If j = 1 Then

                        newpic.Location = New Point(taillePic, Memorypic.Height + Memorypic.Location.Y)
                    Else

                        newpic.Location = New Point(Memorypic.Height + Memorypic.Location.X, Memorypic.Location.Y)
                    End If
                End If


                newpic.AllowDrop = False
                AddHandler newpic.DragEnter, AddressOf pic_DragEnter
                AddHandler newpic.DragDrop, AddressOf pic_DragDrop

                Me.Controls.Add(newpic)
                Memorypic = newpic

            Next
        Next

        swap.AllowDrop = True

        Me.Controls("pic15_15").AllowDrop = True
        Me.Controls("pic15_15").BackColor = SystemColors.ControlDark

        PremiereTuile = True
        TourDuJoueur = 1

        JoueurName.Text = Joueur1.Get_name
    End Sub

    Private Sub pic_MouseMove(sender As Object, e As MouseEventArgs)
        Dim effetRealise As DragDropEffects
        Dim pic As PictureBox = sender

        If e.Button = MouseButtons.Left AndAlso pic.Image IsNot Nothing Then
            pic.AllowDrop = False
            effetRealise = pic.DoDragDrop(pic.Image, DragDropEffects.Move)
            If effetRealise = DragDropEffects.Move Then
                pic.Image = Nothing
            End If
            pic.AllowDrop = True
        End If
    End Sub

    Private Sub pic_DragEnter(sender As Object, e As DragEventArgs)
        Dim ok_haut, ok_bas, ok_gauche, ok_droite, ok_tuile As Boolean
        Dim pic As PictureBox = sender
        Dim X, Y, i, j As Integer
        Y = pic.Location.Y / taillePic
        X = pic.Location.X / taillePic

        'pic.Image = e.Data.GetData(DataFormats.Bitmap).Tag


        If (PremiereTuile) Then
            ok_tuile = True
            'PremiereTuile = False
            ok_bas = True
            ok_droite = True
            ok_gauche = True
            ok_haut = True

            'Else      'Vérifications de placement, non fonctionnel donc abandonné. Le problème vient du e.Data.GetData(DataFormats.Bitmap).Tag qui ne retourne pas le tag de l'image mais juste "bitmap"
            '    i = Y
            '    j = X

            '    Dim VerifAxe As Integer = 0
            '    For Each anciennetuile In AncienneCases
            '        If (anciennetuile.Location.X = pic.Location.X Or anciennetuile.Location.Y = pic.Location.Y) Then
            '            VerifAxe = VerifAxe + 1
            '        End If
            '    Next

            '    If (VerifAxe = AncienneCases.Count) Then
            '        ok_tuile = True

            '    Else
            '        ok_tuile = False
            '    End If

            '    i = Y - 1
            '    Dim pichaut As PictureBox = Me.Controls("pic" & i & "_" & j)
            '    Dim compteurhaut, compteur_valide_forme_haut, compteur_valide_couleur_haut As Integer
            '    compteurhaut = 0
            '    compteur_valide_forme_haut = 0
            '    compteur_valide_couleur_haut = 0


            '    While ((i <> 0) And pichaut.Image IsNot Nothing) 'verif haut

            '        If TuileID.MemeForme(e.Data.GetData(DataFormats.Bitmap).Tag, pichaut.Image.Tag) Then
            '            compteur_valide_forme_haut = compteur_valide_forme_haut + 1
            '        End If

            '        If TuileID.MemeCouleur(e.Data.GetData(DataFormats.Bitmap).Tag, pichaut.Image.Tag) Then
            '            compteur_valide_couleur_haut = compteur_valide_couleur_haut + 1
            '        End If

            '        compteurhaut = compteurhaut + 1
            '        i = i - 1
            '        pichaut = Me.Controls("pic" & i & "_" & j)

            '    End While

            '    If (compteur_valide_couleur_haut = compteurhaut Or compteur_valide_forme_haut = compteurhaut) Then
            '        ok_haut = True
            '    End If

            '    i = Y + 1
            '    Dim picbas As PictureBox = Me.Controls("pic" & i & "_" & j)

            '    If picbas.Image Is Nothing Then
            '        ok_bas = True
            '    End If

            '    While ((i <> 0) And picbas.Image IsNot Nothing) 'verif bas

            '        If TuileID.MemeForme(e.Data.GetData(DataFormats.Bitmap).Tag, picbas.Image.Tag) Then
            '            If TuileID.MemeCouleur(e.Data.GetData(DataFormats.Bitmap).Tag, picbas.Image.Tag) Then
            '                ok_bas = False
            '            Else
            '                ok_bas = True
            '            End If
            '        Else
            '            If TuileID.MemeCouleur(e.Data.GetData(DataFormats.Bitmap).Tag, picbas.Image.Tag) Then
            '                ok_bas = True
            '            Else
            '                ok_bas = False
            '            End If
            '        End If

            '        i = i - 1
            '        picbas = Me.Controls("pic" & i & "_" & j)

            '    End While

            '    i = Y
            '    j = X - 1
            '    Dim picgauche As PictureBox = Me.Controls("pic" & i & "_" & j)

            '    If picgauche.Image Is Nothing Then
            '        ok_gauche = True
            '    End If

            '    While ((j <> 0) And picgauche.Image IsNot Nothing) 'verif gauche

            '        If TuileID.MemeForme(e.Data.GetData(DataFormats.Bitmap).Tag, picgauche.Image.Tag) Then
            '            If TuileID.MemeCouleur(e.Data.GetData(DataFormats.Bitmap).Tag, picgauche.Image.Tag) Then
            '                ok_gauche = False
            '            Else
            '                ok_gauche = True
            '            End If
            '        Else
            '            If TuileID.MemeCouleur(e.Data.GetData(DataFormats.Bitmap).Tag, picgauche.Image.Tag) Then
            '                ok_gauche = True
            '            Else
            '                ok_gauche = False
            '            End If
            '        End If

            '        j = j - 1
            '        picgauche = Me.Controls("pic" & i & "_" & j)

            '    End While

            '    j = X + 1
            '    Dim picdroite As PictureBox = Me.Controls("pic" & i & "_" & j)

            '    If picdroite.Image Is Nothing Then
            '        ok_droite = True
            '    End If

            '    While ((j <> 0) And picdroite.Image IsNot Nothing) 'verif droite

            '        If TuileID.MemeForme(e.Data.GetData(DataFormats.Bitmap).Tag, picdroite.Image.Tag) Then
            '            If TuileID.MemeCouleur(e.Data.GetData(DataFormats.Bitmap).Tag, picdroite.Image.Tag) Then
            '                ok_droite = False
            '            Else
            '                ok_droite = True
            '            End If
            '        Else
            '            If TuileID.MemeCouleur(e.Data.GetData(DataFormats.Bitmap).Tag, picdroite.Image.Tag) Then
            '                ok_droite = True
            '            Else
            '                ok_droite = False
            '            End If
            '        End If

            '        j = j + 1
            '        picdroite = Me.Controls("pic" & i & "_" & j)

            '    End While

        End If

        If (e.Data.GetDataPresent(DataFormats.Bitmap) And ok_haut And ok_bas And ok_gauche And ok_droite And ok_tuile) Then
            e.Effect = DragDropEffects.Move
        Else
            e.Effect = DragDropEffects.None

        End If

    End Sub

    Private Sub pic_DragDrop(sender As Object, e As DragEventArgs)
        Dim pic As PictureBox = sender
        pic.Image = e.Data.GetData(DataFormats.Bitmap)
        AncienneCases.Add(pic)

        Dim i, j As Integer
        i = pic.Location.Y / taillePic
        j = pic.Location.X / taillePic

        Me.Controls("pic" & i & "_" & j).AllowDrop = False

        Dim picgauche As PictureBox = Me.Controls("pic" & i & "_" & (j - 1))
        Dim picdroite As PictureBox = Me.Controls("pic" & i & "_" & (j + 1))
        Dim pichaut As PictureBox = Me.Controls("pic" & (i - 1) & "_" & j)
        Dim picbas As PictureBox = Me.Controls("pic" & (i + 1) & "_" & j)
        If i <> 0 Then
            If pichaut.Image Is Nothing Then
                pichaut.AllowDrop = True
            End If
        End If
        If i <> 30 Then
            If picbas.Image Is Nothing Then
                picbas.AllowDrop = True
            End If
        End If

        If j <> 0 Then
            If picgauche.Image Is Nothing Then
                picgauche.AllowDrop = True
            End If
        End If
        If i <> 30 Then
            If picdroite.Image Is Nothing Then
                picdroite.AllowDrop = True
            End If
        End If

    End Sub

    'getion du bouton swap
    Private Sub pic_SwapDragEnter(sender As Object, e As DragEventArgs) Handles swap.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Move
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub pic_SwapDragDrop(sender As Object, e As DragEventArgs) Handles swap.DragDrop
        Dim pic As PictureBox = sender
        pic.Image = Nothing

        'retour tuile pioche             'non fonctionel pour les mêmes raisons que les vérifications de placement
        'LaPioche.Ajout_tuile(TuileID.TuileCouleur(e.Data.GetData(DataFormats.Bitmap).Tag), TuileID.TuileForme(e.Data.GetData(DataFormats.Bitmap).Tag))

    End Sub


    Private Sub btnValide_Click(sender As Object, e As EventArgs) Handles btnValide.Click
        Dim scorehaut, scorebas, scorevertical, scoregauche, scoredroite, scorehorizontal, scoretour As Integer
        scorebas = 0
        scoredroite = 0
        scoregauche = 0
        scorehaut = 0
        scorehorizontal = 0
        scorevertical = 0
        scoretour = 0

        For Each Pic In AncienneCases 'comptage des points
            Dim Y As Integer = Pic.Location.Y / taillePic
            Dim X As Integer = Pic.Location.X / taillePic
            Dim i, j As Integer

            i = Y - 1
            j = X
            Dim pichaut As PictureBox = Me.Controls("pic" & i & "_" & j)
            While (i <> 0 And Not AncienneCases.Contains(pichaut) And pichaut.Image IsNot Nothing)

                scorehaut = scorehaut + 1
                i = i - 1
                pichaut = Me.Controls("pic" & i & "_" & j)
            End While

            i = Y + 1
            Dim picbas As PictureBox = Me.Controls("pic" & i & "_" & j)
            While (i <> 30 And Not AncienneCases.Contains(picbas) And picbas.Image IsNot Nothing)
                scorebas = scorebas + 1
                i = i + 1
                pichaut = Me.Controls("pic" & i & "_" & j)
            End While


            scorevertical = scorehaut + scorebas + 1
            If scorevertical = 1 Then
                scorevertical = 0
            End If

            If scorevertical = 6 Then
                scorevertical = 12
            End If

            i = Y
            j = X - 1
            Dim picgauche As PictureBox = Me.Controls("pic" & i & "_" & j)
            While (j <> 0 And Not AncienneCases.Contains(picgauche) And picgauche.Image IsNot Nothing)
                scoregauche = scoregauche + 1
                j = j - 1
                picgauche = Me.Controls("pic" & i & "_" & j)
            End While

            j = X + 1
            Dim picdroite As PictureBox = Me.Controls("pic" & i & "_" & j)
            While (j <> 30 And Not AncienneCases.Contains(picdroite) And picdroite.Image IsNot Nothing)
                scoredroite = scoredroite + 1
                j = j + 1
                picdroite = Me.Controls("pic" & i & "_" & j)
            End While

            scorehorizontal = scoregauche + scoredroite + 1
            If scorevertical = 1 Then
                scorevertical = 0
            End If

            If scorehorizontal = 6 Then
                scorehorizontal = 12
            End If


            scoretour = scoretour + scorevertical + scorehorizontal

        Next

        If AncienneCases.Count = 6 Then
            scoretour = scoretour + 6
        End If

        AncienneCases.Clear()



        'tour du joueur suivant + score du joueur via objet + piochage des tuiles manquantes + affichage main joueur suivant
        Select Case (TourDuJoueur)
            Case 1
                Joueur1.Set_points(Joueur1.Get_points + scoretour)
                LabelScoreJ1.Text = Joueur1.Get_points
                J1PtsLast.Text = scoretour
                TourDuJoueur = TourDuJoueur + 1
                JoueurName.Text = Joueur2.Get_name
                Main = Joueur1.Get_main()
                For i As Integer = 1 To 6
                    Dim picMain As PictureBox = Me.Controls("picMain" & i)
                    If picMain.Image Is Nothing And LaPioche.Comptage(LaPioche.Get_TuilesRestantes()) <> 0 Then

                        FormeNum = random.Next(1, 7)
                        CouleurNum = random.Next(1, 7)
                        While (LaPioche.Suppr_tuile(CouleurNum - 1, FormeNum - 1) = False)
                            FormeNum = random.Next(1, 7)
                            CouleurNum = random.Next(1, 7)
                        End While

                        Tuile = TuileID.TuileNom(FormeNum, CouleurNum)
                        Main(i) = Tuile

                    End If
                Next
                Joueur1.Set_main(Main)

                For i As Integer = 1 To 6
                    Dim picMain As PictureBox = Me.Controls("picMain" & i)
                    picMain.Image = Nothing
                    picMain.Image = My.Resources.ResourceManager.GetObject(Joueur2.Get_main()(i))
                    picMain.Image.Tag = Joueur2.Get_main()(i)
                Next
            Case 2
                If (NbJoueurs = 2) Then
                    TourDuJoueur = 1
                    JoueurName.Text = Joueur1.Get_name
                    LabelNumTour.Text = LabelNumTour.Text + 1

                    For i As Integer = 1 To 6
                        Dim picMain As PictureBox = Me.Controls("picMain" & i)
                        picMain.Image = My.Resources.ResourceManager.GetObject(Joueur1.Get_main()(i))
                        picMain.Image.Tag = Joueur1.Get_main()(i)
                    Next
                Else
                    TourDuJoueur = 3
                    JoueurName.Text = Joueur3.Get_name

                    For i As Integer = 1 To 6
                        Dim picMain As PictureBox = Me.Controls("picMain" & i)
                        picMain.Image = My.Resources.ResourceManager.GetObject(Joueur3.Get_main()(i))
                        picMain.Image.Tag = Joueur3.Get_main()(i)
                    Next
                End If
                Joueur2.Set_points(Joueur2.Get_points + scoretour)
                LabelScoreJ2.Text = Joueur2.Get_points
                J2PtsLast.Text = scoretour
                Main = Joueur2.Get_main()
                For i As Integer = 1 To 6
                    Dim picMain As PictureBox = Me.Controls("picMain" & i)
                    If picMain.Image Is Nothing And LaPioche.Comptage(LaPioche.Get_TuilesRestantes()) <> 0 Then

                        FormeNum = random.Next(1, 7)
                        CouleurNum = random.Next(1, 7)
                        While (LaPioche.Suppr_tuile(CouleurNum - 1, FormeNum - 1) = False)
                            FormeNum = random.Next(1, 7)
                            CouleurNum = random.Next(1, 7)
                        End While

                        Tuile = TuileID.TuileNom(FormeNum, CouleurNum)
                        Main(i) = Tuile

                    End If
                Next
                Joueur2.Set_main(Main)

            Case 3
                If (NbJoueurs = 3) Then
                    TourDuJoueur = 1
                    JoueurName.Text = Joueur1.Get_name
                    LabelNumTour.Text = LabelNumTour.Text + 1

                    For i As Integer = 1 To 6
                        Dim picMain As PictureBox = Me.Controls("picMain" & i)
                        picMain.Image = My.Resources.ResourceManager.GetObject(Joueur1.Get_main()(i))
                        picMain.Image.Tag = Joueur1.Get_main()(i)
                    Next
                Else
                    TourDuJoueur = 4
                    JoueurName.Text = Joueur4.Get_name

                    For i As Integer = 1 To 6
                        Dim picMain As PictureBox = Me.Controls("picMain" & i)
                        picMain.Image = My.Resources.ResourceManager.GetObject(Joueur4.Get_main()(i))
                        picMain.Image.Tag = Joueur4.Get_main()(i)
                    Next
                End If
                Joueur3.Set_points(Joueur3.Get_points + scoretour)
                LabelScoreJ3.Text = Joueur3.Get_points
                J3PtsLast.Text = scoretour
                Main = Joueur3.Get_main()
                For i As Integer = 1 To 6
                    Dim picMain As PictureBox = Me.Controls("picMain" & i)
                    If picMain.Image Is Nothing And LaPioche.Comptage(LaPioche.Get_TuilesRestantes()) <> 0 Then

                        FormeNum = random.Next(1, 7)
                        CouleurNum = random.Next(1, 7)
                        While (LaPioche.Suppr_tuile(CouleurNum - 1, FormeNum - 1) = False)
                            FormeNum = random.Next(1, 7)
                            CouleurNum = random.Next(1, 7)
                        End While

                        Tuile = TuileID.TuileNom(FormeNum, CouleurNum)
                        Main(i) = Tuile

                    End If
                Next
                Joueur3.Set_main(Main)
            Case 4
                TourDuJoueur = 1
                JoueurName.Text = Joueur1.Get_name
                LabelNumTour.Text = LabelNumTour.Text + 1
                Joueur4.Set_points(Joueur4.Get_points + scoretour)
                LabelScoreJ4.Text = Joueur4.Get_points
                J4PtsLast.Text = scoretour
                Main = Joueur4.Get_main()
                For i As Integer = 1 To 6
                    Dim picMain As PictureBox = Me.Controls("picMain" & i)
                    If picMain.Image Is Nothing And LaPioche.Comptage(LaPioche.Get_TuilesRestantes()) <> 0 Then

                        FormeNum = random.Next(1, 7)
                        CouleurNum = random.Next(1, 7)
                        While (LaPioche.Suppr_tuile(CouleurNum - 1, FormeNum - 1) = False And LaPioche.Comptage <> 0)
                            FormeNum = random.Next(1, 7)
                            CouleurNum = random.Next(1, 7)
                        End While

                        Tuile = TuileID.TuileNom(FormeNum, CouleurNum)
                        Main(i) = Tuile

                    End If
                Next
                Joueur4.Set_main(Main)

                For i As Integer = 1 To 6
                    Dim picMain As PictureBox = Me.Controls("picMain" & i)
                    picMain.Image = My.Resources.ResourceManager.GetObject(Joueur1.Get_main()(i))
                    picMain.Image.Tag = Joueur1.Get_main()(i)
                Next
        End Select
        RestePioche.Text = (LaPioche.Comptage(LaPioche.Get_TuilesRestantes()))

        'gestion fin de partie et points bonus (non implémenté)
        If (LaPioche.Comptage(LaPioche.Get_TuilesRestantes()) = 0) Then
            Me.Hide()
            Scores.Show()
        End If
    End Sub


    Private Sub btnRetourMenu_Click(sender As Object, e As EventArgs) Handles btnRetourMenu.Click
        Dim response
        response = MessageBox.Show("Voulez vous vraiment retourner au menu ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If response = vbYes Then
            Me.Close()
            For Each joueur In ListeJoueur
                joueur.Set_main(New String() {"vide", "vide", "vide", "vide", "vide", "vide"})
                joueur.Set_points(0)
            Next
            LaPioche.Set_TuilesRestantes(New Integer(5, 5) {{3, 3, 3, 3, 3, 3}, {3, 3, 3, 3, 3, 3}, {3, 3, 3, 3, 3, 3}, {3, 3, 3, 3, 3, 3}, {3, 3, 3, 3, 3, 3}, {3, 3, 3, 3, 3, 3}})
        End If
    End Sub

    Private Sub Jeu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Page_accueil.Show()
        For Each joueur In ListeJoueur
            joueur.Set_main(New String() {"vide", "vide", "vide", "vide", "vide", "vide"})
            joueur.Set_points(0)
        Next
        LaPioche.Set_TuilesRestantes(New Integer(5, 5) {{3, 3, 3, 3, 3, 3}, {3, 3, 3, 3, 3, 3}, {3, 3, 3, 3, 3, 3}, {3, 3, 3, 3, 3, 3}, {3, 3, 3, 3, 3, 3}, {3, 3, 3, 3, 3, 3}})
    End Sub
End Class