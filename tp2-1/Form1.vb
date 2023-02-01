''' <summary>
''' Le formulaire principal permet d’appeler les différents écrans de l’application. Cette fenêtre MDI s’assure de ne jamais ouvrir plusieurs fois la même fenêtre      Enfant.
''' 
''' Fait par: Marierlin Higuerey
''' le:
''' modifie le:
''' </summary>

Public Class FrmGestion

    ''' <summary>
    ''' Procedure permettant d'ouvrir fenêtre enfant Programme
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuProgramme_Click(sender As Object, e As EventArgs) Handles mnuProgramme.Click
        'Verifier si la fenêtre est déjà ouverte
        Dim i As Integer
        For i = 0 To Me.MdiChildren.Count - 1
            If Me.MdiChildren(i).Text = "Gestion des programmes" Then
                Me.MdiChildren(i).Activate()
                Exit Sub
            End If
        Next
        Dim frm As New frmProg
        frm.MdiParent = Me
        frm.Show()
    End Sub

    ''' <summary>
    ''' Procedure permettant d'ouvrir fenêtre enfant Étudiants
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuEtudiants_Click(sender As Object, e As EventArgs) Handles mnuEtudiants.Click
        'Verifier si la fenêtre est déjà ouverte
        Dim i As Integer
        For i = 0 To Me.MdiChildren.Count - 1
            If Me.MdiChildren(i).Text = "Gestion des étudiants" Then
                Me.MdiChildren(i).Activate()
                Exit Sub
            End If
        Next
        Dim frm As New frmEtudiants
        frm.MdiParent = Me
        frm.Show()
    End Sub

    ''' <summary>
    ''' Validation pour quitter du programme
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuQuitter_Click(sender As Object, e As EventArgs) Handles mnuQuitter.Click
        'Demander une confirmation pour Quitter
        If MessageBox.Show("Voulez-vous quitter?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub mnuListeDesProgrammes_Click(sender As Object, e As EventArgs) Handles mnuListeDesProgrammes.Click
        'Verifier si la fenêtre est déjà ouverte
        Dim i As Integer
        For i = 0 To Me.MdiChildren.Count - 1
            If Me.MdiChildren(i).Text = "Liste des programmes" Then
                Me.MdiChildren(i).Activate()
                Exit Sub
            End If
        Next
        Dim frm As New frmListeProg
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub mnuListeDesÉtudiants_Click(sender As Object, e As EventArgs) Handles mnuListeDesÉtudiants.Click
        'Verifier si la fenêtre est déjà ouverte
        Dim i As Integer
        For i = 0 To Me.MdiChildren.Count - 1
            If Me.MdiChildren(i).Text = "Liste des Étudiants" Then
                Me.MdiChildren(i).Activate()
                Exit Sub
            End If
        Next
        Dim frm As New frmListeEtu
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub mnuListeDesÉtudiantsParProgramme_Click(sender As Object, e As EventArgs) Handles mnuListeDesÉtudiantsParProgramme.Click
        'Verifier si la fenêtre est déjà ouverte
        Dim i As Integer
        For i = 0 To Me.MdiChildren.Count - 1
            If Me.MdiChildren(i).Text = "Liste des Étudiants par programme" Then
                Me.MdiChildren(i).Activate()
                Exit Sub
            End If
        Next
        Dim frm As New frmListeEtuProg
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class
