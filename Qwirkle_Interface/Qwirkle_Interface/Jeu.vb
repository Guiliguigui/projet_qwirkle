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

        For i As Byte = 1 To 6
            AddHandler Me.Controls("picMain" & i).MouseMove, AddressOf pic_MouseMove
        Next


        Dim Memorypic As PictureBox
        For i As Byte = 1 To 30
            For j As Byte = 1 To 30

                If (i < 10) Then
                    If (j < 10) Then

                        Dim newpic As New PictureBox

                        newpic.Name = "pic0" & i & "_0" & j

                        newpic.Size = New Size(15, 15)
                        newpic.BorderStyle = BorderStyle.FixedSingle

                        If i = 1 AndAlso j = 1 Then
                            newpic.Location = New Point(15, 15)
                        Else
                            If j = 1 Then

                                newpic.Location = New Point(15, Memorypic.Height + Memorypic.Location.Y)
                            Else

                                newpic.Location = New Point(Memorypic.Height + Memorypic.Location.X, Memorypic.Location.Y)
                            End If
                        End If


                        newpic.AllowDrop = False
                        AddHandler newpic.DragEnter, AddressOf pic_DragEnter
                        AddHandler newpic.DragDrop, AddressOf pic_DragDrop

                        Me.Controls.Add(newpic)
                        Memorypic = newpic

                    Else
                        Dim newpic As New PictureBox


                        newpic.Name = "pic0" & i & "_" & j

                        newpic.Size = New Size(15, 15)
                        newpic.BorderStyle = BorderStyle.FixedSingle

                        newpic.Location = New Point(Memorypic.Height + Memorypic.Location.X, Memorypic.Location.Y)


                        newpic.AllowDrop = False
                        AddHandler newpic.DragEnter, AddressOf pic_DragEnter
                        AddHandler newpic.DragDrop, AddressOf pic_DragDrop

                        Me.Controls.Add(newpic)
                        Memorypic = newpic
                    End If

                Else
                    If (j < 10) Then
                        Dim newpic As New PictureBox

                        newpic.Name = "pic" & i & "_0" & j

                        newpic.Size = New Size(15, 15)
                        newpic.BorderStyle = BorderStyle.FixedSingle


                        If j = 1 Then

                            newpic.Location = New Point(15, Memorypic.Height + Memorypic.Location.Y)
                        Else

                            newpic.Location = New Point(Memorypic.Height + Memorypic.Location.X, Memorypic.Location.Y)
                        End If



                        newpic.AllowDrop = False
                        AddHandler newpic.DragEnter, AddressOf pic_DragEnter
                        AddHandler newpic.DragDrop, AddressOf pic_DragDrop

                        Me.Controls.Add(newpic)
                        Memorypic = newpic

                    Else
                        Dim newpic As New PictureBox

                        newpic.Name = "pic" & i & "_" & j

                        newpic.Size = New Size(15, 15)
                        newpic.BorderStyle = BorderStyle.FixedSingle

                        newpic.Location = New Point(Memorypic.Height + Memorypic.Location.X, Memorypic.Location.Y)


                        newpic.AllowDrop = False
                        AddHandler newpic.DragEnter, AddressOf pic_DragEnter
                        AddHandler newpic.DragDrop, AddressOf pic_DragDrop

                        Me.Controls.Add(newpic)
                        Memorypic = newpic
                    End If
                End If
            Next
        Next

        Me.Controls("pic15_15").AllowDrop = True
        Me.Controls("pic15_15").BackColor = SystemColors.ControlDark


    End Sub

    Private Sub pic_MouseMove(sender As Object, e As MouseEventArgs)
        Dim effetRealise As DragDropEffects
        Dim pic As PictureBox = sender

        If e.Button = MouseButtons.Left AndAlso pic.Image IsNot Nothing Then
            pic.AllowDrop = False
            effetRealise = pic.DoDragDrop(pic.BackColor, DragDropEffects.Move)
            If effetRealise = DragDropEffects.Move Then
                pic.Image = Nothing
            End If
            pic.AllowDrop = True
        End If
    End Sub

    Private Sub pic_DragEnter(sender As Object, e As DragEventArgs)

        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Move
        Else
            e.Effect = DragDropEffects.None
        End If

    End Sub

    Private Sub pic_DragDrop(sender As Object, e As DragEventArgs)
        Dim pic As PictureBox = sender
        pic.Image = e.Data.GetData(DataFormats.Bitmap)

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
End Class