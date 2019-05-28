Imports QwirkleLibrary
Public Class Jeu
    Dim taillePic, origineX, origineY As Integer

    Dim PremiereTuile As Boolean
    Dim TourDuJoueur As Integer
    Dim AncienneCases As New List(Of PictureBox)


    Private Sub Jeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            LabelNomJ3.Text = ("Score de " + Joueur3.Get_name() + " :")
            LabelScoreJ3.Text = (Joueur3.Get_points())
        ElseIf (Page_accueil.RadioButton3.Checked) Then
            PanelJ3.Visible = True
            PanelJ4.Visible = True
            LabelNomJ3.Text = ("Score de " + Joueur3.Get_name() + " :")
            LabelScoreJ3.Text = (Joueur3.Get_points())
            LabelNomJ4.Text = ("Score de " + Joueur4.Get_name() + " :")
            LabelScoreJ4.Text = (Joueur4.Get_points())
        End If
        Dim LaPioche As New Pioche(New Integer(5, 5) {{3, 3, 3, 3, 3, 3}, {3, 3, 3, 3, 3, 3}, {3, 3, 3, 3, 3, 3}, {3, 3, 3, 3, 3, 3}, {3, 3, 3, 3, 3, 3}, {3, 3, 3, 3, 3, 3}})
        RestePioche.Text = (LaPioche.Comptage(LaPioche.Get_TuilesRestantes()))

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

        Me.Controls("pic15_15").AllowDrop = True
        Me.Controls("pic15_15").BackColor = SystemColors.ControlDark

        PremiereTuile = 1
        TourDuJoueur = 1

        'gestion pioche et mains des joueurs
        'affichage main joueur1

        picMain1.Image = My.Resources.ResourceManager.GetObject("TrefleVert")
        picMain1.Image.Tag = "TrefleVert"

        picMain2.Image = My.Resources.ResourceManager.GetObject("CarreRouge")
        picMain2.Image.Tag = "CarreRouge"

        picMain3.Image = My.Resources.ResourceManager.GetObject("CarreBleu")
        picMain3.Image.Tag = "CarreBleu"

        picMain3.Image = My.Resources.ResourceManager.GetObject("CarreVert")
        picMain3.Image.Tag = "CarreVert"

        picMain4.Image = My.Resources.ResourceManager.GetObject("RondRouge")
        picMain4.Image.Tag = "RondRouge"

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

    Private Sub btnValide_Click(sender As Object, e As EventArgs) Handles btnValide.Click

        For Each Pic In AncienneCases 'comptage des points
            Dim i As Integer = Pic.Location.Y / taillePic
            Dim j As Integer = Pic.Location.X / taillePic

            Dim scorehaut, scorebas, scorevertical, scoregauche, scoredroite, scorehorizontal, scoretotal As Integer


            Dim pichaut As PictureBox = Me.Controls("pic" & (i - 1) & "_" & j)
            While (i <> 0 And )

            End While

            'score du joueur via objet
        Next
        AncienneCases.Clear()

        'gestion fin de partie et points bonus
        'piochage des tuiles
        'tour du joueur suivant
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