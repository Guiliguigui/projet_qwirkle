﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Jeu))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelJ4 = New System.Windows.Forms.Panel()
        Me.J4PtsLast = New System.Windows.Forms.Label()
        Me.LabelScoreJ4 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.LabelNomJ4 = New System.Windows.Forms.Label()
        Me.PanelJ3 = New System.Windows.Forms.Panel()
        Me.J3PtsLast = New System.Windows.Forms.Label()
        Me.LabelScoreJ3 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LabelNomJ3 = New System.Windows.Forms.Label()
        Me.PanelJ2 = New System.Windows.Forms.Panel()
        Me.J2PtsLast = New System.Windows.Forms.Label()
        Me.LabelScoreJ2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LabelNomJ2 = New System.Windows.Forms.Label()
        Me.PanelTourJeu = New System.Windows.Forms.Panel()
        Me.JoueurName = New System.Windows.Forms.Label()
        Me.LabelNumTour = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.PanelJ1 = New System.Windows.Forms.Panel()
        Me.J1PtsLast = New System.Windows.Forms.Label()
        Me.LabelScoreJ1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelNomJ1 = New System.Windows.Forms.Label()
        Me.btnValide = New System.Windows.Forms.Button()
        Me.btnRetourMenu = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.RestePioche = New System.Windows.Forms.Label()
        Me.picMain6 = New System.Windows.Forms.PictureBox()
        Me.picMain5 = New System.Windows.Forms.PictureBox()
        Me.picMain4 = New System.Windows.Forms.PictureBox()
        Me.picMain3 = New System.Windows.Forms.PictureBox()
        Me.picMain2 = New System.Windows.Forms.PictureBox()
        Me.picMain1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.PanelJ4.SuspendLayout()
        Me.PanelJ3.SuspendLayout()
        Me.PanelJ2.SuspendLayout()
        Me.PanelTourJeu.SuspendLayout()
        Me.PanelJ1.SuspendLayout()
        CType(Me.picMain6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMain5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMain4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMain3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMain2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMain1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PanelJ4)
        Me.Panel1.Controls.Add(Me.PanelJ3)
        Me.Panel1.Controls.Add(Me.PanelJ2)
        Me.Panel1.Controls.Add(Me.PanelTourJeu)
        Me.Panel1.Controls.Add(Me.PanelJ1)
        Me.Panel1.Location = New System.Drawing.Point(711, 13)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(268, 513)
        Me.Panel1.TabIndex = 1
        '
        'PanelJ4
        '
        Me.PanelJ4.Controls.Add(Me.J4PtsLast)
        Me.PanelJ4.Controls.Add(Me.LabelScoreJ4)
        Me.PanelJ4.Controls.Add(Me.Label16)
        Me.PanelJ4.Controls.Add(Me.LabelNomJ4)
        Me.PanelJ4.Location = New System.Drawing.Point(4, 251)
        Me.PanelJ4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelJ4.Name = "PanelJ4"
        Me.PanelJ4.Size = New System.Drawing.Size(260, 75)
        Me.PanelJ4.TabIndex = 6
        Me.PanelJ4.Visible = False
        '
        'J4PtsLast
        '
        Me.J4PtsLast.AutoSize = True
        Me.J4PtsLast.Location = New System.Drawing.Point(204, 46)
        Me.J4PtsLast.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.J4PtsLast.Name = "J4PtsLast"
        Me.J4PtsLast.Size = New System.Drawing.Size(24, 17)
        Me.J4PtsLast.TabIndex = 3
        Me.J4PtsLast.Text = "...."
        '
        'LabelScoreJ4
        '
        Me.LabelScoreJ4.AutoSize = True
        Me.LabelScoreJ4.Location = New System.Drawing.Point(179, 16)
        Me.LabelScoreJ4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelScoreJ4.Name = "LabelScoreJ4"
        Me.LabelScoreJ4.Size = New System.Drawing.Size(24, 17)
        Me.LabelScoreJ4.TabIndex = 2
        Me.LabelScoreJ4.Text = "...."
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(4, 46)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(208, 17)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Points obtenus au dernier tour :"
        '
        'LabelNomJ4
        '
        Me.LabelNomJ4.AutoSize = True
        Me.LabelNomJ4.Location = New System.Drawing.Point(4, 16)
        Me.LabelNomJ4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelNomJ4.Name = "LabelNomJ4"
        Me.LabelNomJ4.Size = New System.Drawing.Size(129, 17)
        Me.LabelNomJ4.TabIndex = 0
        Me.LabelNomJ4.Text = "Score du joueur 4 :"
        '
        'PanelJ3
        '
        Me.PanelJ3.Controls.Add(Me.J3PtsLast)
        Me.PanelJ3.Controls.Add(Me.LabelScoreJ3)
        Me.PanelJ3.Controls.Add(Me.Label12)
        Me.PanelJ3.Controls.Add(Me.LabelNomJ3)
        Me.PanelJ3.Location = New System.Drawing.Point(4, 169)
        Me.PanelJ3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelJ3.Name = "PanelJ3"
        Me.PanelJ3.Size = New System.Drawing.Size(260, 75)
        Me.PanelJ3.TabIndex = 5
        Me.PanelJ3.Visible = False
        '
        'J3PtsLast
        '
        Me.J3PtsLast.AutoSize = True
        Me.J3PtsLast.Location = New System.Drawing.Point(204, 46)
        Me.J3PtsLast.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.J3PtsLast.Name = "J3PtsLast"
        Me.J3PtsLast.Size = New System.Drawing.Size(24, 17)
        Me.J3PtsLast.TabIndex = 3
        Me.J3PtsLast.Text = "...."
        '
        'LabelScoreJ3
        '
        Me.LabelScoreJ3.AutoSize = True
        Me.LabelScoreJ3.Location = New System.Drawing.Point(179, 16)
        Me.LabelScoreJ3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelScoreJ3.Name = "LabelScoreJ3"
        Me.LabelScoreJ3.Size = New System.Drawing.Size(24, 17)
        Me.LabelScoreJ3.TabIndex = 2
        Me.LabelScoreJ3.Text = "...."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(4, 46)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(208, 17)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Points obtenus au dernier tour :"
        '
        'LabelNomJ3
        '
        Me.LabelNomJ3.AutoSize = True
        Me.LabelNomJ3.Location = New System.Drawing.Point(4, 16)
        Me.LabelNomJ3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelNomJ3.Name = "LabelNomJ3"
        Me.LabelNomJ3.Size = New System.Drawing.Size(129, 17)
        Me.LabelNomJ3.TabIndex = 0
        Me.LabelNomJ3.Text = "Score du joueur 3 :"
        '
        'PanelJ2
        '
        Me.PanelJ2.Controls.Add(Me.J2PtsLast)
        Me.PanelJ2.Controls.Add(Me.LabelScoreJ2)
        Me.PanelJ2.Controls.Add(Me.Label8)
        Me.PanelJ2.Controls.Add(Me.LabelNomJ2)
        Me.PanelJ2.Location = New System.Drawing.Point(4, 86)
        Me.PanelJ2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelJ2.Name = "PanelJ2"
        Me.PanelJ2.Size = New System.Drawing.Size(260, 75)
        Me.PanelJ2.TabIndex = 4
        '
        'J2PtsLast
        '
        Me.J2PtsLast.AutoSize = True
        Me.J2PtsLast.Location = New System.Drawing.Point(204, 46)
        Me.J2PtsLast.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.J2PtsLast.Name = "J2PtsLast"
        Me.J2PtsLast.Size = New System.Drawing.Size(24, 17)
        Me.J2PtsLast.TabIndex = 3
        Me.J2PtsLast.Text = "...."
        '
        'LabelScoreJ2
        '
        Me.LabelScoreJ2.AutoSize = True
        Me.LabelScoreJ2.Location = New System.Drawing.Point(179, 16)
        Me.LabelScoreJ2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelScoreJ2.Name = "LabelScoreJ2"
        Me.LabelScoreJ2.Size = New System.Drawing.Size(24, 17)
        Me.LabelScoreJ2.TabIndex = 2
        Me.LabelScoreJ2.Text = "...."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 46)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(208, 17)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Points obtenus au dernier tour :"
        '
        'LabelNomJ2
        '
        Me.LabelNomJ2.AutoSize = True
        Me.LabelNomJ2.Location = New System.Drawing.Point(4, 16)
        Me.LabelNomJ2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelNomJ2.Name = "LabelNomJ2"
        Me.LabelNomJ2.Size = New System.Drawing.Size(129, 17)
        Me.LabelNomJ2.TabIndex = 0
        Me.LabelNomJ2.Text = "Score du joueur 2 :"
        '
        'PanelTourJeu
        '
        Me.PanelTourJeu.Controls.Add(Me.JoueurName)
        Me.PanelTourJeu.Controls.Add(Me.LabelNumTour)
        Me.PanelTourJeu.Controls.Add(Me.Label18)
        Me.PanelTourJeu.Location = New System.Drawing.Point(4, 363)
        Me.PanelTourJeu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelTourJeu.Name = "PanelTourJeu"
        Me.PanelTourJeu.Size = New System.Drawing.Size(260, 146)
        Me.PanelTourJeu.TabIndex = 3
        '
        'JoueurName
        '
        Me.JoueurName.AutoSize = True
        Me.JoueurName.Location = New System.Drawing.Point(4, 89)
        Me.JoueurName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.JoueurName.Name = "JoueurName"
        Me.JoueurName.Size = New System.Drawing.Size(101, 17)
        Me.JoueurName.TabIndex = 2
        Me.JoueurName.Text = "Nom du joueur"
        '
        'LabelNumTour
        '
        Me.LabelNumTour.AutoSize = True
        Me.LabelNumTour.Location = New System.Drawing.Point(80, 53)
        Me.LabelNumTour.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelNumTour.Name = "LabelNumTour"
        Me.LabelNumTour.Size = New System.Drawing.Size(24, 17)
        Me.LabelNumTour.TabIndex = 1
        Me.LabelNumTour.Text = "...."
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(4, 53)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(68, 17)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Tour n° : "
        '
        'PanelJ1
        '
        Me.PanelJ1.Controls.Add(Me.J1PtsLast)
        Me.PanelJ1.Controls.Add(Me.LabelScoreJ1)
        Me.PanelJ1.Controls.Add(Me.Label3)
        Me.PanelJ1.Controls.Add(Me.LabelNomJ1)
        Me.PanelJ1.Location = New System.Drawing.Point(4, 4)
        Me.PanelJ1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelJ1.Name = "PanelJ1"
        Me.PanelJ1.Size = New System.Drawing.Size(260, 75)
        Me.PanelJ1.TabIndex = 0
        '
        'J1PtsLast
        '
        Me.J1PtsLast.AutoSize = True
        Me.J1PtsLast.Location = New System.Drawing.Point(204, 46)
        Me.J1PtsLast.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.J1PtsLast.Name = "J1PtsLast"
        Me.J1PtsLast.Size = New System.Drawing.Size(24, 17)
        Me.J1PtsLast.TabIndex = 3
        Me.J1PtsLast.Text = "...."
        '
        'LabelScoreJ1
        '
        Me.LabelScoreJ1.AutoSize = True
        Me.LabelScoreJ1.Location = New System.Drawing.Point(179, 16)
        Me.LabelScoreJ1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelScoreJ1.Name = "LabelScoreJ1"
        Me.LabelScoreJ1.Size = New System.Drawing.Size(24, 17)
        Me.LabelScoreJ1.TabIndex = 2
        Me.LabelScoreJ1.Text = "...."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 46)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(208, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Points obtenus au dernier tour :"
        '
        'LabelNomJ1
        '
        Me.LabelNomJ1.AutoSize = True
        Me.LabelNomJ1.Location = New System.Drawing.Point(4, 16)
        Me.LabelNomJ1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelNomJ1.Name = "LabelNomJ1"
        Me.LabelNomJ1.Size = New System.Drawing.Size(129, 17)
        Me.LabelNomJ1.TabIndex = 0
        Me.LabelNomJ1.Text = "Score de joueur 1 :"
        '
        'btnValide
        '
        Me.btnValide.BackgroundImage = CType(resources.GetObject("btnValide.BackgroundImage"), System.Drawing.Image)
        Me.btnValide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnValide.Location = New System.Drawing.Point(416, 659)
        Me.btnValide.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnValide.Name = "btnValide"
        Me.btnValide.Size = New System.Drawing.Size(72, 53)
        Me.btnValide.TabIndex = 3
        Me.btnValide.UseVisualStyleBackColor = True
        '
        'btnRetourMenu
        '
        Me.btnRetourMenu.BackgroundImage = CType(resources.GetObject("btnRetourMenu.BackgroundImage"), System.Drawing.Image)
        Me.btnRetourMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRetourMenu.Location = New System.Drawing.Point(576, 659)
        Me.btnRetourMenu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRetourMenu.Name = "btnRetourMenu"
        Me.btnRetourMenu.Size = New System.Drawing.Size(72, 53)
        Me.btnRetourMenu.TabIndex = 6
        Me.btnRetourMenu.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 716)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(282, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nombre de tuiles restantes dans la pioche :"
        '
        'Panel8
        '
        Me.Panel8.BackgroundImage = CType(resources.GetObject("Panel8.BackgroundImage"), System.Drawing.Image)
        Me.Panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel8.Location = New System.Drawing.Point(496, 659)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(72, 53)
        Me.Panel8.TabIndex = 8
        '
        'RestePioche
        '
        Me.RestePioche.AutoSize = True
        Me.RestePioche.Location = New System.Drawing.Point(302, 716)
        Me.RestePioche.Name = "RestePioche"
        Me.RestePioche.Size = New System.Drawing.Size(20, 17)
        Me.RestePioche.TabIndex = 9
        Me.RestePioche.Text = "..."
        '
        'picMain6
        '
        Me.picMain6.Image = CType(resources.GetObject("picMain6.Image"), System.Drawing.Image)
        Me.picMain6.InitialImage = CType(resources.GetObject("picMain6.InitialImage"), System.Drawing.Image)
        Me.picMain6.Location = New System.Drawing.Point(309, 675)
        Me.picMain6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picMain6.Name = "picMain6"
        Me.picMain6.Size = New System.Drawing.Size(40, 37)
        Me.picMain6.TabIndex = 11
        Me.picMain6.TabStop = False
        '
        'picMain5
        '
        Me.picMain5.Location = New System.Drawing.Point(261, 675)
        Me.picMain5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picMain5.Name = "picMain5"
        Me.picMain5.Size = New System.Drawing.Size(40, 37)
        Me.picMain5.TabIndex = 12
        Me.picMain5.TabStop = False
        '
        'picMain4
        '
        Me.picMain4.Location = New System.Drawing.Point(213, 675)
        Me.picMain4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picMain4.Name = "picMain4"
        Me.picMain4.Size = New System.Drawing.Size(40, 37)
        Me.picMain4.TabIndex = 13
        Me.picMain4.TabStop = False
        '
        'picMain3
        '
        Me.picMain3.Location = New System.Drawing.Point(165, 675)
        Me.picMain3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picMain3.Name = "picMain3"
        Me.picMain3.Size = New System.Drawing.Size(40, 37)
        Me.picMain3.TabIndex = 14
        Me.picMain3.TabStop = False
        '
        'picMain2
        '
        Me.picMain2.Location = New System.Drawing.Point(117, 675)
        Me.picMain2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picMain2.Name = "picMain2"
        Me.picMain2.Size = New System.Drawing.Size(40, 37)
        Me.picMain2.TabIndex = 15
        Me.picMain2.TabStop = False
        '
        'picMain1
        '
        Me.picMain1.Location = New System.Drawing.Point(69, 675)
        Me.picMain1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picMain1.Name = "picMain1"
        Me.picMain1.Size = New System.Drawing.Size(40, 37)
        Me.picMain1.TabIndex = 16
        Me.picMain1.TabStop = False
        '
        'Jeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 753)
        Me.Controls.Add(Me.picMain1)
        Me.Controls.Add(Me.picMain2)
        Me.Controls.Add(Me.picMain3)
        Me.Controls.Add(Me.picMain4)
        Me.Controls.Add(Me.picMain5)
        Me.Controls.Add(Me.picMain6)
        Me.Controls.Add(Me.RestePioche)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRetourMenu)
        Me.Controls.Add(Me.btnValide)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Jeu"
        Me.Text = "Jeu"
        Me.Panel1.ResumeLayout(False)
        Me.PanelJ4.ResumeLayout(False)
        Me.PanelJ4.PerformLayout()
        Me.PanelJ3.ResumeLayout(False)
        Me.PanelJ3.PerformLayout()
        Me.PanelJ2.ResumeLayout(False)
        Me.PanelJ2.PerformLayout()
        Me.PanelTourJeu.ResumeLayout(False)
        Me.PanelTourJeu.PerformLayout()
        Me.PanelJ1.ResumeLayout(False)
        Me.PanelJ1.PerformLayout()
        CType(Me.picMain6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMain5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMain4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMain3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMain2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMain1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelJ4 As Panel
    Friend WithEvents J4PtsLast As Label
    Friend WithEvents LabelScoreJ4 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents LabelNomJ4 As Label
    Friend WithEvents PanelJ3 As Panel
    Friend WithEvents J3PtsLast As Label
    Friend WithEvents LabelScoreJ3 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents LabelNomJ3 As Label
    Friend WithEvents PanelJ2 As Panel
    Friend WithEvents J2PtsLast As Label
    Friend WithEvents LabelScoreJ2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LabelNomJ2 As Label
    Friend WithEvents PanelTourJeu As Panel
    Friend WithEvents JoueurName As Label
    Friend WithEvents LabelNumTour As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents PanelJ1 As Panel
    Friend WithEvents J1PtsLast As Label
    Friend WithEvents LabelScoreJ1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LabelNomJ1 As Label
    Friend WithEvents btnValide As Button
    Friend WithEvents btnRetourMenu As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents RestePioche As Label
    Friend WithEvents picMain6 As PictureBox
    Friend WithEvents picMain5 As PictureBox
    Friend WithEvents picMain4 As PictureBox
    Friend WithEvents picMain3 As PictureBox
    Friend WithEvents picMain2 As PictureBox
    Friend WithEvents picMain1 As PictureBox
End Class
