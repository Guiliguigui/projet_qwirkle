Imports QwirkleLibrary
Public Class Jeu

    Dim PremiereTuile As Boolean
    Dim TourDuJoueur As Integer
    Dim AncienneTuilles As IList(Of PictureBox)


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

        Dim taillePic, origineX, origineY As Integer
        taillePic = 17
        origineX = 17
        origineY = 17

        For i As Byte = 1 To 6
            AddHandler Me.Controls("picMain" & i).MouseMove, AddressOf pic_MouseMove
        Next


        Dim Memorypic As PictureBox
        For i As Byte = 1 To 30
            For j As Byte = 1 To 30

                Dim newpic As New PictureBox

                newpic.Name = "pic" & i & "_" & j

                newpic.Size = New Size(taillePic, taillePic)
                newpic.BorderStyle = BorderStyle.FixedSingle

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
        Dim ok_haut, ok_bas, ok_gauche, ok_droit, ok_tuile As Boolean
        Dim pic As PictureBox = sender
        Dim X, Y, i, j As Integer
        Y = pic.Location.Y
        X = pic.Location.X

        'e.Data

        'comment 
        'récupérer le nom de l'image
        'tester différent de (=/= !=)

        If (PremiereTuile Or AncienneTuilles.Contains(Me.Controls("pic" & i + 1 & "_" & j)) Or AncienneTuilles.Contains(Me.Controls("pic" & i - 1 & "_" & j)) Or AncienneTuilles.Contains(Me.Controls("pic" & i & "_" & j + 1)) Or AncienneTuilles.Contains(Me.Controls("pic" & i & "_" & j - 1))) Then
            ok_tuile = True
            AncienneTuilles.Add(pic)
        Else
            ok_tuile = False
        End If

        'i = Y
        'While ((i!= 0) & Me.Controls("pic" & i - 1 & "_" & j)!= Empty) 'verif haut

        '    pic.Image.ToString()

        '    If TuileID.MemeForme(pic.Image.ToString, Me.Controls("pic" & i & "_" & j).Image.ToString) Then
        '        If TuileID.MemeCouleur(pic.Image.ToString, Me.Controls("pic" & i & "_" & j).Image.ToString) Then
        '            ok_haut = False
        '        Else
        '            ok_haut = True
        '        End If
        '    Else
        '        If TuileID.MemeCouleur(pic.Image.ToString, Me.Controls("pic" & i & "_" & j).Image.ToString) Then
        '            ok_haut = True
        '        Else
        '            ok_haut = False
        '        End If
        '    End If

        '    i = i - 1

        'End While

        'i = Y
        'While ((i! = 30) & Me.Controls("pic" & i + 1 & "_" & j)!= Empty) 'verif bas

        '    pic.Image.ToString()

        '    If TuileID.MemeForme(pic.Image.ToString, Me.Controls("pic" & i & "_" & j).Image.ToString) Then
        '        If TuileID.MemeCouleur(pic.Image.ToString, Me.Controls("pic" & i & "_" & j).Image.ToString) Then
        '            ok_haut = False
        '        Else
        '            ok_haut = True
        '        End If
        '    Else
        '        If TuileID.MemeCouleur(pic.Image.ToString, Me.Controls("pic" & i & "_" & j).Image.ToString) Then
        '            ok_haut = True
        '        Else
        '            ok_haut = False
        '        End If
        '    End If

        '    i = i + 1

        'End While

        'j = Y
        'While ((j! = 0) & Me.Controls("pic" & i & "_" & j - 1)!= Empty) 'verif gauche

        '    pic.Image.ToString()

        '    If TuileID.MemeForme(pic.Image.ToString, Me.Controls("pic" & i & "_" & j).Image.ToString) Then
        '        If TuileID.MemeCouleur(pic.Image.ToString, Me.Controls("pic" & i & "_" & j).Image.ToString) Then
        '            ok_haut = False
        '        Else
        '            ok_haut = True
        '        End If
        '    Else
        '        If TuileID.MemeCouleur(pic.Image.ToString, Me.Controls("pic" & i & "_" & j).Image.ToString) Then
        '            ok_haut = True
        '        Else
        '            ok_haut = False
        '        End If
        '    End If

        '    j = j - 1

        'End While

        'j = Y
        'While ((j! = 30) & Me.Controls("pic" & i & "_" & j + 1)!= Empty) 'verif droite

        '    pic.Image.ToString()

        '    If TuileID.MemeForme(pic.Image.ToString, Me.Controls("pic" & i & "_" & j).Image.ToString) Then
        '        If TuileID.MemeCouleur(pic.Image.ToString, Me.Controls("pic" & i & "_" & j).Image.ToString) Then
        '            ok_haut = False
        '        Else
        '            ok_haut = True
        '        End If
        '    Else
        '        If TuileID.MemeCouleur(pic.Image.ToString, Me.Controls("pic" & i & "_" & j).Image.ToString) Then
        '            ok_haut = True
        '        Else
        '            ok_haut = False
        '        End If
        '    End If

        '    j = j + 1

        'End While

        If (e.Data.GetDataPresent(DataFormats.Bitmap) & ok_haut & ok_bas & ok_gauche & ok_droit & ok_tuile) Then
            e.Effect = DragDropEffects.Move
        Else
            e.Effect = DragDropEffects.None
        End If

    End Sub

    Private Sub pic_DragDrop(sender As Object, e As DragEventArgs)
        Dim pic As PictureBox = sender
        pic.Image = e.Data.GetData(DataFormats.Bitmap)


        Dim i, j As Integer
        i = pic.Location.Y / 17
        j = pic.Location.X / 17
        Me.Controls("pic" & i & "_" & j).AllowDrop = False
        Me.Controls("pic" & i & "_" & (j - 1)).AllowDrop = True
        Me.Controls("pic" & i & "_" & (j + 1)).AllowDrop = True
        Me.Controls("pic" & (i - 1) & "_" & j).AllowDrop = True
        Me.Controls("pic" & (i + 1) & "_" & j).AllowDrop = True

    End Sub

    Private Sub btnValide_Click(sender As Object, e As EventArgs) Handles btnValide.Click

    End Sub


    Private Sub btnRetourMenu_Click(sender As Object, e As EventArgs) Handles btnRetourMenu.Click
        Dim response
        response = MessageBox.Show("Voulez vous vraiment retourner au menu ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If response = vbYes Then
            Me.Close()
            Page_accueil.Show()
        End If
    End Sub

    Private Sub Jeu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Page_accueil.Close()
    End Sub
End Class