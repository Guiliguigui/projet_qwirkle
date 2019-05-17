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

End Class