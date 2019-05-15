<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Page_accueil
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panelj3 = New System.Windows.Forms.Panel()
        Me.TextBoxJ3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panelj1 = New System.Windows.Forms.Panel()
        Me.TextBoxJ1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panelj4 = New System.Windows.Forms.Panel()
        Me.TextBoxJ4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panelj2 = New System.Windows.Forms.Panel()
        Me.TextBoxJ2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.commencer = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panelj3.SuspendLayout()
        Me.Panelj1.SuspendLayout()
        Me.Panelj4.SuspendLayout()
        Me.Panelj2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(296, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Qwirkle"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Controls.Add(Me.RadioButton3)
        Me.Panel1.Location = New System.Drawing.Point(16, 46)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(685, 49)
        Me.Panel1.TabIndex = 1
        '
        'RadioButton1
        '
        Me.RadioButton1.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(32, 6)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(175, 40)
        Me.RadioButton1.TabIndex = 4
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "2 Joueurs"
        Me.RadioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(253, 6)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(175, 40)
        Me.RadioButton2.TabIndex = 3
        Me.RadioButton2.Text = "3 Joueurs"
        Me.RadioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(473, 6)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(175, 40)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Text = "4 Joueurs"
        Me.RadioButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Panelj3)
        Me.GroupBox1.Controls.Add(Me.Panelj1)
        Me.GroupBox1.Controls.Add(Me.Panelj4)
        Me.GroupBox1.Controls.Add(Me.Panelj2)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 118)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(685, 254)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Noms des joueurs"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(32, 220)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(599, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Les joueurs saisissent leurs noms dans l'ordre dans lequel ils souhaitent jouer."
        '
        'Panelj3
        '
        Me.Panelj3.Controls.Add(Me.TextBoxJ3)
        Me.Panelj3.Controls.Add(Me.Label4)
        Me.Panelj3.Enabled = False
        Me.Panelj3.Location = New System.Drawing.Point(32, 124)
        Me.Panelj3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panelj3.Name = "Panelj3"
        Me.Panelj3.Size = New System.Drawing.Size(299, 87)
        Me.Panelj3.TabIndex = 3
        '
        'TextBoxJ3
        '
        Me.TextBoxJ3.Location = New System.Drawing.Point(56, 38)
        Me.TextBoxJ3.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxJ3.Name = "TextBoxJ3"
        Me.TextBoxJ3.Size = New System.Drawing.Size(188, 22)
        Me.TextBoxJ3.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(99, 18)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nom du joueur 3"
        '
        'Panelj1
        '
        Me.Panelj1.Controls.Add(Me.TextBoxJ1)
        Me.Panelj1.Controls.Add(Me.Label2)
        Me.Panelj1.Location = New System.Drawing.Point(32, 23)
        Me.Panelj1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panelj1.Name = "Panelj1"
        Me.Panelj1.Size = New System.Drawing.Size(299, 84)
        Me.Panelj1.TabIndex = 3
        '
        'TextBoxJ1
        '
        Me.TextBoxJ1.Location = New System.Drawing.Point(56, 38)
        Me.TextBoxJ1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxJ1.Name = "TextBoxJ1"
        Me.TextBoxJ1.Size = New System.Drawing.Size(188, 22)
        Me.TextBoxJ1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(99, 18)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nom du joueur 1"
        '
        'Panelj4
        '
        Me.Panelj4.Controls.Add(Me.TextBoxJ4)
        Me.Panelj4.Controls.Add(Me.Label5)
        Me.Panelj4.Enabled = False
        Me.Panelj4.Location = New System.Drawing.Point(349, 124)
        Me.Panelj4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panelj4.Name = "Panelj4"
        Me.Panelj4.Size = New System.Drawing.Size(299, 87)
        Me.Panelj4.TabIndex = 3
        '
        'TextBoxJ4
        '
        Me.TextBoxJ4.Location = New System.Drawing.Point(57, 38)
        Me.TextBoxJ4.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxJ4.Name = "TextBoxJ4"
        Me.TextBoxJ4.Size = New System.Drawing.Size(188, 22)
        Me.TextBoxJ4.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(95, 18)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Nom du joueur 4"
        '
        'Panelj2
        '
        Me.Panelj2.Controls.Add(Me.TextBoxJ2)
        Me.Panelj2.Controls.Add(Me.Label3)
        Me.Panelj2.Location = New System.Drawing.Point(349, 23)
        Me.Panelj2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panelj2.Name = "Panelj2"
        Me.Panelj2.Size = New System.Drawing.Size(299, 84)
        Me.Panelj2.TabIndex = 2
        '
        'TextBoxJ2
        '
        Me.TextBoxJ2.Location = New System.Drawing.Point(57, 39)
        Me.TextBoxJ2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxJ2.Name = "TextBoxJ2"
        Me.TextBoxJ2.Size = New System.Drawing.Size(188, 22)
        Me.TextBoxJ2.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(95, 20)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nom du joueur 2"
        '
        'commencer
        '
        Me.commencer.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.commencer.Location = New System.Drawing.Point(16, 379)
        Me.commencer.Margin = New System.Windows.Forms.Padding(4)
        Me.commencer.Name = "commencer"
        Me.commencer.Size = New System.Drawing.Size(685, 63)
        Me.commencer.TabIndex = 3
        Me.commencer.Text = "Commencer à jouer"
        Me.commencer.UseVisualStyleBackColor = True
        '
        'Page_accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 455)
        Me.Controls.Add(Me.commencer)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Page_accueil"
        Me.Text = "Qwirkle"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panelj3.ResumeLayout(False)
        Me.Panelj3.PerformLayout()
        Me.Panelj1.ResumeLayout(False)
        Me.Panelj1.PerformLayout()
        Me.Panelj4.ResumeLayout(False)
        Me.Panelj4.PerformLayout()
        Me.Panelj2.ResumeLayout(False)
        Me.Panelj2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panelj3 As Panel
    Friend WithEvents TextBoxJ3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panelj1 As Panel
    Friend WithEvents TextBoxJ1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panelj4 As Panel
    Friend WithEvents TextBoxJ4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panelj2 As Panel
    Friend WithEvents TextBoxJ2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents commencer As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
End Class
