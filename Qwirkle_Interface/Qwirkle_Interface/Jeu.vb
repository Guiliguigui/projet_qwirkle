Imports QwirkleLibrary
Public Class Jeu
    Dim taillePic, origineX, origineY As Integer
    Dim NbJoueurs As Integer = 2
    Dim PremiereTuile As Boolean
    Dim TourDuJoueur As Integer = 1
    Dim AncienneCases As New List(Of PictureBox)




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

        Select Case (NbJoueurs)
            Case 2
                PanelJ3.Visible = False
                PanelJ4.Visible = False
            Case 3
                PanelJ3.Visible = True
                PanelJ4.Visible = False
                LabelNomJ3.Text = ("Score de " + Joueur3.Get_name() + " :")
                LabelScoreJ3.Text = (Joueur3.Get_points())
            Case 4
                PanelJ3.Visible = True
                PanelJ4.Visible = True
                LabelNomJ3.Text = ("Score de " + Joueur3.Get_name() + " :")
                LabelScoreJ3.Text = (Joueur3.Get_points())
                LabelNomJ4.Text = ("Score de " + Joueur4.Get_name() + " :")
                LabelScoreJ4.Text = (Joueur4.Get_points())
        End Select


        Dim LaPioche As New Pioche(New Integer(5, 5) {{3, 3, 3, 3, 3, 3}, {3, 3, 3, 3, 3, 3}, {3, 3, 3, 3, 3, 3}, {3, 3, 3, 3, 3, 3}, {3, 3, 3, 3, 3, 3}, {3, 3, 3, 3, 3, 3}})
        RestePioche.Text = (LaPioche.Comptage(LaPioche.Get_TuilesRestantes()))

        Dim random As New Random
        Dim FormeNum As Integer
        Dim CouleurNum As Integer
        Dim Tuile As String
        While (LaPioche.Comptage(LaPioche.Get_TuilesRestantes()) <> 0)
            Dim i As Integer
            For i = 1 To 6 Step 1
                If (("picMain" & i)(DataFormats.Bitmap).ToString Is Nothing) Then
                    While (LaPioche(CouleurNum)(FormeNum) = 0)
                        FormeNum = random.Next(1, 6)
                        CouleurNum = random.Next(1, 6)
                    End While
                    LaPioche.Suppr_tuile(CouleurNum, FormeNum)
                    Tuile = TuileID.TuileNom(FormeNum, CouleurNum)
                    ("picMain" & i).image = My.Resources.ResourceManager.GetObject(Tuile)
                    ("picMain" & i).image.Tag = Tuile
                End If
            Next
        End While

        taillePic = 17
        origineX = 17
        origineY = 17

        For i As Byte = 1 To 6
            Dim picmain As PictureBox = Me.Controls("picMain" & i)
            picmain.SizeMode = PictureBoxSizeMode.StretchImage
            picmain.BorderStyle = BorderStyle.FixedSingle
            AddHandler picmain.MouseMove, AddressOf pic_MouseMove
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

        PremiereTuile = 1
        TourDuJoueur = 1

        'gestion pioche et mains des joueurs


        picMain1.Image = My.Resources.ResourceManager.GetObject("TrefleVert")
        picMain1.Image.Tag = "TrefleVert"

        picMain2.Image = My.Resources.ResourceManager.GetObject("CarreRouge")
        picMain2.Image.Tag = "CarreRouge"

        picMain3.Image = My.Resources.ResourceManager.GetObject("CarreBleu")
        picMain3.Image.Tag = "CarreBleu"

        picMain4.Image = My.Resources.ResourceManager.GetObject("RondRouge")
        picMain4.Image.Tag = "RondRouge"

        picMain5.Image = My.Resources.ResourceManager.GetObject("EtoileViolet")
        picMain5.Image.Tag = "EtoileViolet"

        picMain6.Image = My.Resources.ResourceManager.GetObject("CroixOrange")
        picMain6.Image.Tag = "CroixOrange"

        'Dim pictest1, pictest2, pictest3, pictest4, pictest5 As PictureBox

        'pictest1 = Me.Controls("pic16_20")
        'pictest2 = Me.Controls("pic17_20")
        'pictest3 = Me.Controls("pic18_20")
        'pictest4 = Me.Controls("pic16_21")
        'pictest5 = Me.Controls("pic16_22")

        'pictest1.Image = My.Resources.ResourceManager.GetObject("TrefleVert")
        'pictest1.Image.Tag = "TrefleVert"

        'pictest2.Image = My.Resources.ResourceManager.GetObject("CarreRouge")
        'pictest2.Image.Tag = "CarreRouge"

        'pictest3.Image = My.Resources.ResourceManager.GetObject("CarreBleu")
        'pictest3.Image.Tag = "CarreBleu"

        'pictest4.Image = My.Resources.ResourceManager.GetObject("RondRouge")
        'pictest4.Image.Tag = "RondRouge"

        'pictest5.Image = My.Resources.ResourceManager.GetObject("EtoileViolet")
        'pictest5.Image.Tag = "EtoileViolet"


        JoueurName.Text = Joueur1.Get_name

        'affichage main joueur1

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
        'ok_bas = True
        'ok_droite = True
        'ok_gauche = True
        'ok_haut = True
        Dim pic As PictureBox = sender
        Dim X, Y, i, j As Integer
        Y = pic.Location.Y / taillePic
        X = pic.Location.X / taillePic

        'pic.Image = e.Data.GetData(DataFormats.Bitmap).Tag

        'comment 
        'récupérer le nom de l'image

        If (PremiereTuile) Then
            ok_tuile = True
            'PremiereTuile = False
            ok_bas = True
            ok_droite = True
            ok_gauche = True
            ok_haut = True

            'Else
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

        If pichaut.Image Is Nothing Then
            pichaut.AllowDrop = True
        End If
        If picbas.Image Is Nothing Then
            picbas.AllowDrop = True
        End If
        If picgauche.Image Is Nothing Then
            picgauche.AllowDrop = True
        End If
        If picdroite.Image Is Nothing Then
            picdroite.AllowDrop = True
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

        'retour tuile pioche

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


        AncienneCases.Clear()


        'gestion fin de partie et points bonus

        'piochage des tuiles

        'tour du joueur suivant + score du joueur via objet
        Select Case (TourDuJoueur)
            Case 1
                Joueur1.Set_points(Joueur1.Get_points + scoretour)
                LabelScoreJ1.Text = Joueur1.Get_points
                J1PtsLast.Text = scoretour
                TourDuJoueur = TourDuJoueur + 1
                JoueurName.Text = Joueur2.Get_name
            Case 2
                If (NbJoueurs = 2) Then
                    TourDuJoueur = 1
                    JoueurName.Text = Joueur1.Get_name
                    LabelNumTour.Text = LabelNumTour.Text + 1

                Else
                    TourDuJoueur = 3
                    JoueurName.Text = Joueur3.Get_name
                End If
                Joueur2.Set_points(Joueur2.Get_points + scoretour)
                LabelScoreJ2.Text = Joueur2.Get_points
                J2PtsLast.Text = scoretour
            Case 3
                If (NbJoueurs = 3) Then
                    TourDuJoueur = 1
                    JoueurName.Text = Joueur1.Get_name
                    LabelNumTour.Text = LabelNumTour.Text + 1

                Else
                    TourDuJoueur = 4
                    JoueurName.Text = Joueur4.Get_name
                End If
                Joueur3.Set_points(Joueur3.Get_points + scoretour)
                LabelScoreJ3.Text = Joueur3.Get_points
                J3PtsLast.Text = scoretour
            Case 4
                TourDuJoueur = 1
                JoueurName.Text = Joueur1.Get_name
                LabelNumTour.Text = LabelNumTour.Text + 1
                Joueur4.Set_points(Joueur4.Get_points + scoretour)
                LabelScoreJ4.Text = Joueur4.Get_points
                J4PtsLast.Text = scoretour
        End Select


        'affichage main joueur suivant

    End Sub

    Private Sub btnRetourMenu_Click(sender As Object, e As EventArgs) Handles btnRetourMenu.Click
        Dim response
        response = MessageBox.Show("Voulez vous vraiment retourner au menu ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If response = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub Jeu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Page_accueil.Show()
    End Sub
End Class