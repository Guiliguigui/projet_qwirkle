Imports QwirkleLibrary

Public Class Page_accueil
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Panelj4.Enabled = False
        Panelj3.Enabled = False
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Panelj3.Enabled = True
        Panelj4.Enabled = False
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Panelj4.Enabled = True
        Panelj3.Enabled = True
    End Sub

    Private Sub commencer_Click(sender As Object, e As EventArgs) Handles commencer.Click
        If (RadioButton1.Checked And TextBoxJ1.Text IsNot "" And TextBoxJ2.Text IsNot "") Then
            Me.Hide()
            Jeu.Show()
        ElseIf (RadioButton2.Checked And TextBoxJ1.Text IsNot "" And TextBoxJ2.Text IsNot "" And TextBoxJ3.Text IsNot "") Then
            Me.Hide()
            Jeu.Show()
        ElseIf (RadioButton3.Checked And TextBoxJ1.Text IsNot "" And TextBoxJ2.Text IsNot "" And TextBoxJ3.Text IsNot "" And TextBoxJ4.Text IsNot "") Then
            Me.Hide()
            Jeu.Show()
        Else
            MsgBox("Veuillez entrez des noms de joueurs !")
        End If



    End Sub
End Class
