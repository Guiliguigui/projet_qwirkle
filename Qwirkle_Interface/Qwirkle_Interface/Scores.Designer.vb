<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Scores
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
        Me.numero1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_np = New System.Windows.Forms.Button()
        Me.btn_quit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'numero1
        '
        Me.numero1.AutoSize = True
        Me.numero1.Font = New System.Drawing.Font("Comic Sans MS", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numero1.Location = New System.Drawing.Point(158, 128)
        Me.numero1.Name = "numero1"
        Me.numero1.Size = New System.Drawing.Size(250, 40)
        Me.numero1.TabIndex = 1
        Me.numero1.Text = """Nom du joueur"""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(200, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(171, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fin de la partie"
        '
        'btn_np
        '
        Me.btn_np.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_np.Location = New System.Drawing.Point(119, 234)
        Me.btn_np.Name = "btn_np"
        Me.btn_np.Size = New System.Drawing.Size(124, 55)
        Me.btn_np.TabIndex = 4
        Me.btn_np.Text = "Nouvelle Partie"
        Me.btn_np.UseVisualStyleBackColor = True
        '
        'btn_quit
        '
        Me.btn_quit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_quit.Location = New System.Drawing.Point(310, 234)
        Me.btn_quit.Name = "btn_quit"
        Me.btn_quit.Size = New System.Drawing.Size(124, 55)
        Me.btn_quit.TabIndex = 5
        Me.btn_quit.Text = "Quitter le jeu"
        Me.btn_quit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(225, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Gagnant:"
        '
        'Scores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(563, 336)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_quit)
        Me.Controls.Add(Me.btn_np)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.numero1)
        Me.Name = "Scores"
        Me.Text = "Scores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents numero1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_np As Button
    Friend WithEvents btn_quit As Button
    Friend WithEvents Label1 As Label
End Class
