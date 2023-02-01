Imports System.Data.SqlClient 'Pour SQL Serveur

''' <summary>
''' Cette fenêtre enfant permettra de gérer l’inscription, la modification, la consultation et la destruction d’étudiants.
''' 
''' Fait par: Marierlin Higuerey
''' le:
''' modifie le:
''' </summary>


Public Class frmEtudiants

    Private Sub frmEtudiants_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtSexe.Visible = False
            'Pas nécessaire d'ouvrir la connexion.. le DATAADAPTER le fait pour nous...
            daEtudiants.Fill(Ds1.T_etudiants)
            daProg.Fill(Ds1.T_programme)
            'La méthode FILL: permet d'ouvrir la connexion et d'exécuter la commande SELECT
            'pour barrer et debarrer
            If Ds1.T_etudiants.Rows.Count > 0 Then
                Barrer(grpEtudiant, cmdOK, cmdAnnuler)
            End If
        Catch ex As SqlException
            MsgBox(ex.Number & " " & ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtSexe_TextChanged(sender As Object, e As EventArgs) Handles txtSexe.TextChanged
        Try
            If txtSexe.Text = "M" Then
                optEtu_Masculin.Checked = True
            ElseIf txtSexe.Text = "F" Then
                optEtu_Feminin.Checked = True
            End If
        Catch ex As SqlException
            MsgBox(ex.Number & " " & ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Botton pour ajout étudiant
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdNouveau_Click(sender As Object, e As EventArgs) Handles cmdNouveau.Click
        Try
            'Barrer et Debarrer les différents contrôles
            Barrer(dgEtudiants, cmdNouveau, cmdModifier, cmdEnlever)
            DeBarrer(grpEtudiant, cmdOK, cmdAnnuler)
            'Indiquer que nonus sommes en mode ajout
            ActionForm = ActionForm.ajout
            bsEtudiants.AddNew()
            mskEtu_da.Focus()
            'Ville par défaut
            txtEtu_Ville.Text = "Chicoutimi"
            'Province par défaut
            cboEtu_Province.Text = "Québec"
        Catch ex As SqlException
            MsgBox(ex.Number & " " & ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Botton annuler l'action
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdAnnuler_Click(sender As Object, e As EventArgs) Handles cmdAnnuler.Click
        Try
            'Barrer et Debarrer les différents contrôles
            DeBarrer(dgEtudiants, cmdNouveau, cmdModifier, cmdEnlever)
            Barrer(grpEtudiant, cmdOK, cmdAnnuler)
            'Commande pour annuler l'ajout
            bsEtudiants.CancelEdit()
            ActionForm = ActionForm.aucune
            Err1.Clear()
        Catch ex As SqlException
            MsgBox(ex.Number & " " & ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Botton modifie l'étudiant
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdModifier_Click(sender As Object, e As EventArgs) Handles cmdModifier.Click
        Try
            'Barrer et Debarrer les différents contrôles
            Barrer(dgEtudiants, cmdNouveau, cmdModifier, cmdEnlever)
            DeBarrer(grpEtudiant, cmdOK, cmdAnnuler)
            'Vider l'ecran
            ActionForm = ActionForm.modif
        Catch ex As SqlException
            MsgBox(ex.Number & " " & ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Botton pour faire l'ajout ou la modification...
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click

        Try
            'valider le formulaire
            If Valider_Formulaire_Etu() Then
                bsEtudiants.EndEdit()
                daEtudiants.Update(Ds1.T_etudiants)
                Err1.Clear() 'Pour effacer les anciennes erreurs
                If ActionForm = ActionForm.ajout Then
                    MsgBox("Étudiant ajouté avec succès")
                Else
                    MsgBox("Étudiant modifié avec succès")
                End If
                DeBarrer(dgEtudiants, cmdNouveau, cmdModifier, cmdEnlever)
                Barrer(grpEtudiant, cmdOK, cmdAnnuler)
            Else
                MsgBox("Pour terminer, vérifiez que vous avez tout entré correctement")
            End If
        Catch ex As SqlException
            MsgBox(ex.Number & " " & ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
            Ds1.T_etudiants.RejectChanges()
        End Try
    End Sub

    ''' <summary>
    ''' Fonction permettant de valider le Formulaire des étudiants
    ''' </summary>
    ''' <returns></returns>
    Private Function Valider_Formulaire_Etu() As Boolean
        Try
            Dim ok As Boolean = True
            Err1.Clear() 'Pour effacer les anciennes erreurs

            If mskEtu_da.MaskFull = False Then
                Err1.SetError(mskEtu_da, "DA obligatoire")
                ok = False
            End If
            If ActionForm = ActionForm.ajout Then
                If Existe_deja(mskEtu_da.Text) Then
                    Err1.SetError(mskEtu_da, "DA existe déjà")
                    ok = False
                End If
            End If
            If cboPro_No.Text = "" Then
                Err1.SetError(cboPro_No, "Selection du programme obligatoire")
                ok = False
            End If
            If txtEtu_Nom.Text.Trim = "" Then
                Err1.SetError(txtEtu_Nom, "Nom obligatoire")
                ok = False
            End If
            If txtEtu_Prenom.Text.ToString = "" Then
                Err1.SetError(txtEtu_Prenom, "Prenom obligatoire")
                ok = False
            End If
            If txtEtu_Prenom.Text.Trim = "" Then
                Err1.SetError(txtEtu_Prenom, "Prenom obligatoire")
                ok = False
            End If
            If optEtu_Feminin.Checked = False And optEtu_Masculin.Checked = False Then
                Err1.SetError(grpEtu_Sexe, "Sexe obligatoire")
                ok = False
            End If
            If txtEtu_Adresse.Text.Trim = "" Then
                Err1.SetError(txtEtu_Adresse, "Adresse obligatoire")
                ok = False
            End If
            If txtEtu_Ville.Text.Trim = "" Then
                Err1.SetError(txtEtu_Ville, "Ville obligatoire")
                ok = False
            End If
            If cboEtu_Province.Text = "" Then
                Err1.SetError(cboEtu_Province, "Province obligatoire")
                ok = False
            End If
            If mskEtu_Telephone.MaskFull = False Then
                Err1.SetError(mskEtu_Telephone, "Téléphone obligatoire")
                ok = False
            End If
            If mskEtu_CodePostal.MaskFull = False Then
                Err1.SetError(mskEtu_CodePostal, "Code Postal obligatoire")
                ok = False
            End If
            Return ok
        Catch ex As SqlException
            MsgBox(ex.Number & " " & ex.Message)
            End
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' Fonction permettant de vérifier si le DA exite déjà
    ''' </summary>
    Private Function Existe_deja(no As String) As Boolean
        Try
            Dim Existe As Boolean = False
            Dim i As Integer
            For i = 0 To dgEtudiants.Rows.Count - 2
                If dgEtudiants.Rows(i).Cells(0).Value = no Then
                    Existe = True
                    Return Existe
                End If
            Next
        Catch ex As SqlException
            MsgBox(ex.Number & " " & ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' Funtion pour afficher le sexe aprés l'ajoute ou modifié
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub optEtu_CheckedChanged(sender As Object, e As EventArgs) Handles optEtu_Masculin.CheckedChanged, optEtu_Feminin.CheckedChanged
        Try
            If optEtu_Masculin.Checked = True Then
                txtSexe.Text = "M"
            ElseIf optEtu_Feminin.Checked = True Then
                txtSexe.Text = "F"
            End If
        Catch ex As SqlException
            MsgBox(ex.Number & " " & ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Botton pour enlever un étudiant...
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdEnlever_Click(sender As Object, e As EventArgs) Handles cmdEnlever.Click
        'Confirmation
        If MessageBox.Show("Voulez-vous enlever cet étudiant ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                bsEtudiants.RemoveCurrent()
                daEtudiants.Update(Ds1.T_etudiants)
                MsgBox("Étudiant enlevé avec succès...")
            Catch ex As SqlException
                MsgBox(ex.Number & " " & ex.Message)
            Catch ex As Exception
                MsgBox(ex.Message)
                Ds1.T_etudiants.RejectChanges()
            End Try
        End If
    End Sub


    ''' <summary>
    ''' Validation des entrées dans le formulaire
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Validation_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEtu_Ville.KeyPress, txtEtu_Prenom.KeyPress, txtEtu_Nom.KeyPress
        Try
            If Not (Asc(e.KeyChar) = 8) And Not (Asc(e.KeyChar) = 32) Then
                Dim allowedChars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ-"

                If Not allowedChars.Contains(e.KeyChar.ToString.ToUpper) Then
                    e.KeyChar = ChrW(0)
                    e.Handled = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    ''' <summary>
    ''' Validation des entrées dans le formulaire
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Validation_Adresse_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEtu_Adresse.KeyPress
        Try
            If Not (Asc(e.KeyChar) = 8) And Not (Asc(e.KeyChar) = 32) Then
                Dim allowedChars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ-0123456789"
                If Not allowedChars.Contains(e.KeyChar.ToString.ToUpper) Then
                    e.KeyChar = ChrW(0)
                    e.Handled = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class