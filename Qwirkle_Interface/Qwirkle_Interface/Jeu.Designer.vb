<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Jeu
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlPlateau = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.J4PtsLast = New System.Windows.Forms.Label()
        Me.LabelScoreJ4 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.J3PtsLast = New System.Windows.Forms.Label()
        Me.LabelScoreJ3 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.J2PtsLast = New System.Windows.Forms.Label()
        Me.LabelScoreJ2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.JoueurName = New System.Windows.Forms.Label()
        Me.LabelNumTour = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.J1PtsLast = New System.Windows.Forms.Label()
        Me.LabelScoreJ1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.btnValide = New System.Windows.Forms.Button()
        Me.btnAnnule = New System.Windows.Forms.Button()
        Me.btnRetourMenu = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlPlateau
        '
        Me.pnlPlateau.Location = New System.Drawing.Point(12, 12)
        Me.pnlPlateau.Name = "pnlPlateau"
        Me.pnlPlateau.Size = New System.Drawing.Size(594, 417)
        Me.pnlPlateau.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(622, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(201, 417)
        Me.Panel1.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.J4PtsLast)
        Me.Panel5.Controls.Add(Me.LabelScoreJ4)
        Me.Panel5.Controls.Add(Me.Label16)
        Me.Panel5.Controls.Add(Me.Label17)
        Me.Panel5.Location = New System.Drawing.Point(3, 204)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(195, 61)
        Me.Panel5.TabIndex = 6
        Me.Panel5.Visible = False
        '
        'J4PtsLast
        '
        Me.J4PtsLast.AutoSize = True
        Me.J4PtsLast.Location = New System.Drawing.Point(153, 37)
        Me.J4PtsLast.Name = "J4PtsLast"
        Me.J4PtsLast.Size = New System.Drawing.Size(19, 13)
        Me.J4PtsLast.TabIndex = 3
        Me.J4PtsLast.Text = "...."
        '
        'LabelScoreJ4
        '
        Me.LabelScoreJ4.AutoSize = True
        Me.LabelScoreJ4.Location = New System.Drawing.Point(134, 13)
        Me.LabelScoreJ4.Name = "LabelScoreJ4"
        Me.LabelScoreJ4.Size = New System.Drawing.Size(19, 13)
        Me.LabelScoreJ4.TabIndex = 2
        Me.LabelScoreJ4.Text = "...."
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(3, 37)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(154, 13)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Points obtenus au dernier tour :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(3, 13)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(97, 13)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Score du joueur 4 :"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.J3PtsLast)
        Me.Panel4.Controls.Add(Me.LabelScoreJ3)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Location = New System.Drawing.Point(3, 137)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(195, 61)
        Me.Panel4.TabIndex = 5
        Me.Panel4.Visible = False
        '
        'J3PtsLast
        '
        Me.J3PtsLast.AutoSize = True
        Me.J3PtsLast.Location = New System.Drawing.Point(153, 37)
        Me.J3PtsLast.Name = "J3PtsLast"
        Me.J3PtsLast.Size = New System.Drawing.Size(19, 13)
        Me.J3PtsLast.TabIndex = 3
        Me.J3PtsLast.Text = "...."
        '
        'LabelScoreJ3
        '
        Me.LabelScoreJ3.AutoSize = True
        Me.LabelScoreJ3.Location = New System.Drawing.Point(134, 13)
        Me.LabelScoreJ3.Name = "LabelScoreJ3"
        Me.LabelScoreJ3.Size = New System.Drawing.Size(19, 13)
        Me.LabelScoreJ3.TabIndex = 2
        Me.LabelScoreJ3.Text = "...."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 37)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(154, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Points obtenus au dernier tour :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 13)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(97, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Score du joueur 3 :"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.J2PtsLast)
        Me.Panel3.Controls.Add(Me.LabelScoreJ2)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Location = New System.Drawing.Point(3, 70)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(195, 61)
        Me.Panel3.TabIndex = 4
        '
        'J2PtsLast
        '
        Me.J2PtsLast.AutoSize = True
        Me.J2PtsLast.Location = New System.Drawing.Point(153, 37)
        Me.J2PtsLast.Name = "J2PtsLast"
        Me.J2PtsLast.Size = New System.Drawing.Size(19, 13)
        Me.J2PtsLast.TabIndex = 3
        Me.J2PtsLast.Text = "...."
        '
        'LabelScoreJ2
        '
        Me.LabelScoreJ2.AutoSize = True
        Me.LabelScoreJ2.Location = New System.Drawing.Point(134, 13)
        Me.LabelScoreJ2.Name = "LabelScoreJ2"
        Me.LabelScoreJ2.Size = New System.Drawing.Size(19, 13)
        Me.LabelScoreJ2.TabIndex = 2
        Me.LabelScoreJ2.Text = "...."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(154, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Points obtenus au dernier tour :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Score du joueur 2 :"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.JoueurName)
        Me.Panel6.Controls.Add(Me.LabelNumTour)
        Me.Panel6.Controls.Add(Me.Label18)
        Me.Panel6.Location = New System.Drawing.Point(3, 295)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(195, 119)
        Me.Panel6.TabIndex = 3
        '
        'JoueurName
        '
        Me.JoueurName.AutoSize = True
        Me.JoueurName.Location = New System.Drawing.Point(3, 72)
        Me.JoueurName.Name = "JoueurName"
        Me.JoueurName.Size = New System.Drawing.Size(76, 13)
        Me.JoueurName.TabIndex = 2
        Me.JoueurName.Text = "Nom du joueur"
        '
        'LabelNumTour
        '
        Me.LabelNumTour.AutoSize = True
        Me.LabelNumTour.Location = New System.Drawing.Point(60, 43)
        Me.LabelNumTour.Name = "LabelNumTour"
        Me.LabelNumTour.Size = New System.Drawing.Size(19, 13)
        Me.LabelNumTour.TabIndex = 1
        Me.LabelNumTour.Text = "...."
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(3, 43)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(51, 13)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Tour n° : "
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.J1PtsLast)
        Me.Panel2.Controls.Add(Me.LabelScoreJ1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(195, 61)
        Me.Panel2.TabIndex = 0
        '
        'J1PtsLast
        '
        Me.J1PtsLast.AutoSize = True
        Me.J1PtsLast.Location = New System.Drawing.Point(153, 37)
        Me.J1PtsLast.Name = "J1PtsLast"
        Me.J1PtsLast.Size = New System.Drawing.Size(19, 13)
        Me.J1PtsLast.TabIndex = 3
        Me.J1PtsLast.Text = "...."
        '
        'LabelScoreJ1
        '
        Me.LabelScoreJ1.AutoSize = True
        Me.LabelScoreJ1.Location = New System.Drawing.Point(134, 13)
        Me.LabelScoreJ1.Name = "LabelScoreJ1"
        Me.LabelScoreJ1.Size = New System.Drawing.Size(19, 13)
        Me.LabelScoreJ1.TabIndex = 2
        Me.LabelScoreJ1.Text = "...."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Points obtenus au dernier tour :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Score de joueur 1 :"
        '
        'pnlMain
        '
        Me.pnlMain.Location = New System.Drawing.Point(12, 435)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(279, 43)
        Me.pnlMain.TabIndex = 2
        '
        'btnValide
        '
        Me.btnValide.Location = New System.Drawing.Point(312, 435)
        Me.btnValide.Name = "btnValide"
        Me.btnValide.Size = New System.Drawing.Size(54, 43)
        Me.btnValide.TabIndex = 3
        Me.btnValide.Text = "Button1"
        Me.btnValide.UseVisualStyleBackColor = True
        '
        'btnAnnule
        '
        Me.btnAnnule.Location = New System.Drawing.Point(372, 435)
        Me.btnAnnule.Name = "btnAnnule"
        Me.btnAnnule.Size = New System.Drawing.Size(54, 43)
        Me.btnAnnule.TabIndex = 4
        Me.btnAnnule.Text = "Button2"
        Me.btnAnnule.UseVisualStyleBackColor = True
        '
        'btnRetourMenu
        '
        Me.btnRetourMenu.Location = New System.Drawing.Point(492, 435)
        Me.btnRetourMenu.Name = "btnRetourMenu"
        Me.btnRetourMenu.Size = New System.Drawing.Size(54, 43)
        Me.btnRetourMenu.TabIndex = 6
        Me.btnRetourMenu.Text = "Button4"
        Me.btnRetourMenu.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 496)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nombre de tuiles restantes dans la pioche"
        '
        'Panel8
        '
        Me.Panel8.Location = New System.Drawing.Point(432, 435)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(54, 43)
        Me.Panel8.TabIndex = 8
        '
        'Jeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 544)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRetourMenu)
        Me.Controls.Add(Me.btnAnnule)
        Me.Controls.Add(Me.btnValide)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlPlateau)
        Me.Name = "Jeu"
        Me.Text = "Jeu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlPlateau As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents J4PtsLast As Label
    Friend WithEvents LabelScoreJ4 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents J3PtsLast As Label
    Friend WithEvents LabelScoreJ3 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents J2PtsLast As Label
    Friend WithEvents LabelScoreJ2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents JoueurName As Label
    Friend WithEvents LabelNumTour As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents J1PtsLast As Label
    Friend WithEvents LabelScoreJ1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlMain As Panel
    Friend WithEvents btnValide As Button
    Friend WithEvents btnAnnule As Button
    Friend WithEvents btnRetourMenu As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel8 As Panel
End Class
