<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGestion
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuGestion = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProgramme = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEtudiants = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSeparateur = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuQuitter = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRapport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuListeDesProgrammes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuListeDesÉtudiants = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuListeDesÉtudiantsParProgramme = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuGestion, Me.mnuRapport})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(15, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1417, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuGestion
        '
        Me.mnuGestion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProgramme, Me.mnuEtudiants, Me.mnuSeparateur, Me.mnuQuitter})
        Me.mnuGestion.Name = "mnuGestion"
        Me.mnuGestion.Size = New System.Drawing.Size(73, 24)
        Me.mnuGestion.Text = "Gestion"
        '
        'mnuProgramme
        '
        Me.mnuProgramme.Name = "mnuProgramme"
        Me.mnuProgramme.Size = New System.Drawing.Size(170, 26)
        Me.mnuProgramme.Text = "Programme"
        '
        'mnuEtudiants
        '
        Me.mnuEtudiants.Name = "mnuEtudiants"
        Me.mnuEtudiants.Size = New System.Drawing.Size(170, 26)
        Me.mnuEtudiants.Text = "Étudiants"
        '
        'mnuSeparateur
        '
        Me.mnuSeparateur.Name = "mnuSeparateur"
        Me.mnuSeparateur.Size = New System.Drawing.Size(167, 6)
        '
        'mnuQuitter
        '
        Me.mnuQuitter.Name = "mnuQuitter"
        Me.mnuQuitter.Size = New System.Drawing.Size(170, 26)
        Me.mnuQuitter.Text = "Quitter"
        '
        'mnuRapport
        '
        Me.mnuRapport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuListeDesProgrammes, Me.mnuListeDesÉtudiants, Me.mnuListeDesÉtudiantsParProgramme})
        Me.mnuRapport.Name = "mnuRapport"
        Me.mnuRapport.Size = New System.Drawing.Size(77, 24)
        Me.mnuRapport.Text = "Rapport"
        '
        'mnuListeDesProgrammes
        '
        Me.mnuListeDesProgrammes.Name = "mnuListeDesProgrammes"
        Me.mnuListeDesProgrammes.Size = New System.Drawing.Size(323, 26)
        Me.mnuListeDesProgrammes.Text = "Liste des Programmes"
        '
        'mnuListeDesÉtudiants
        '
        Me.mnuListeDesÉtudiants.Name = "mnuListeDesÉtudiants"
        Me.mnuListeDesÉtudiants.Size = New System.Drawing.Size(323, 26)
        Me.mnuListeDesÉtudiants.Text = "Liste des Étudiants"
        '
        'mnuListeDesÉtudiantsParProgramme
        '
        Me.mnuListeDesÉtudiantsParProgramme.Name = "mnuListeDesÉtudiantsParProgramme"
        Me.mnuListeDesÉtudiantsParProgramme.Size = New System.Drawing.Size(323, 26)
        Me.mnuListeDesÉtudiantsParProgramme.Text = "Liste des Étudiants par programme"
        '
        'FrmGestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1417, 889)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmGestion"
        Me.Text = "Gestion"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuGestion As ToolStripMenuItem
    Friend WithEvents mnuProgramme As ToolStripMenuItem
    Friend WithEvents mnuEtudiants As ToolStripMenuItem
    Friend WithEvents mnuSeparateur As ToolStripSeparator
    Friend WithEvents mnuQuitter As ToolStripMenuItem
    Friend WithEvents mnuRapport As ToolStripMenuItem
    Friend WithEvents mnuListeDesProgrammes As ToolStripMenuItem
    Friend WithEvents mnuListeDesÉtudiants As ToolStripMenuItem
    Friend WithEvents mnuListeDesÉtudiantsParProgramme As ToolStripMenuItem
End Class
