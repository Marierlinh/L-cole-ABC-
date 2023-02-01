Imports System.Data.SqlClient 'Pour SQL Serveur

'''' <summary>
'''' Cette fenêtre enfant permettra de gérer l’inscription, la modification, la consultation et la destruction de programme.
'''' 
'''' Fait par: Marierlin Higuerey
'''' le:
'''' modifie le:
'''' </summary>
'''' 

Public Class frmProg

    Private Sub frmProgramme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'La méthode FILL: permet d'ouvrir la connexion et d'exécuter la commande SELECT
            daProg.Fill(Ds1.T_programme)
            ''pour barrer et debarrer
            If bsProg.Count > 0 Then
                Barrer(grpProgramme, cmdOK, cmdAnnuler)
                DGProgram.Focus()
            End If
        Catch ex As SqlException
            MsgBox(ex.Number & " " & ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ' <summary>
    ' Événements qui nous aide à montrer les étudiants inscrits dans chaque programme
    ' </summary>
    ' <param name="sender"></param>
    ' <param name="e"></param>
    Private Sub DGProgram_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGProgram.CellClick
        Try
            Ds1.T_etudiants.Clear()
            daEtudiants.SelectCommand.Parameters("@prono").Value = cboPro_No.Text
            daEtudiants.Fill(Ds1.T_etudiants)
        Catch ex As SqlException
            MsgBox(ex.Number & " " & ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    ''' <summary>
    ''' Botton pour ajout Programme
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdNouveau_Click(sender As Object, e As EventArgs) Handles cmdNouveau.Click
        Try
            Err2.Clear()
            'Barrer et Debarrer les différents contrôles
            Barrer(DGProgram, cmdNouveau, cmdModifier, cmdEnlever)
            DeBarrer(grpProgramme, cmdOK, cmdAnnuler, cboPro_No)
            ActionForm = ActionForm.ajout
            bsProg.AddNew()

            numProNbrHeures.Value = 0
            numProNbrUnites.Value = 0
        Catch ex As SqlException
            MsgBox(ex.Number & " " & ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Botton pour Enlever le programme
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdEnlever_Click(sender As Object, e As EventArgs) Handles cmdEnlever.Click
        Try
            Err2.Clear()
            ' Demander une confirmation au Préalable
            If MessageBox.Show("Voulez-vous enlever ce programme?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                'Verification si le programme a des étudiants
                If dgEtuProg.Rows.Count > 0 Then
                    MsgBox("Vous ne pouvez pas supprimer un programme avec des étudiants inscrit")
                Else
                    bsProg.RemoveCurrent()
                    daProg.Update(Ds1.T_programme)
                    MsgBox("Programme enlevé avec succès...")
                End If
            End If
        Catch ex As SqlException
            MsgBox(ex.Number & " " & ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
            Ds1.T_programme.RejectChanges()
        End Try
    End Sub

    ''' <summary>
    ''' Botton annuler l'action
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdAnnuler_Click(sender As Object, e As EventArgs) Handles cmdAnnuler.Click
        Try
            Err2.Clear()
            'Barrer et Debarrer les différents contrôles
            DeBarrer(DGProgram, cmdNouveau, cmdModifier, cmdEnlever)
            Barrer(grpProgramme, cmdOK, cmdAnnuler)
            'Commande pour annuler l'ajout
            bsProg.CancelEdit()
            ActionForm = ActionForm.aucune
        Catch ex As SqlException
            MsgBox(ex.Number & " " & ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Botton modifie le programme
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdModifier_Click(sender As Object, e As EventArgs) Handles cmdModifier.Click
        Try
            'Barrer et Debarrer les différents contrôles
            Barrer(DGProgram, cmdNouveau, cmdModifier, cmdEnlever, cboPro_No)
            DeBarrer(grpProgramme, cmdOK, cmdAnnuler)
            ''Valider formulaire
            'Valider_Formulaire_Prog()
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
            Err2.Clear()
            'valider le formulaire
            If Valider_Formulaire_Prog() = True Then
                bsProg.EndEdit()
                daProg.Update(Ds1.T_programme)
                If ActionForm = ActionForm.ajout Then
                    MsgBox("Programme ajouté avec succès")
                Else
                    MsgBox("Programme modifié avec succès")
                End If
                DeBarrer(DGProgram, cmdNouveau, cmdModifier, cmdEnlever)
                Barrer(grpProgramme, cmdOK, cmdAnnuler)
            Else
                MsgBox("Pour terminer, vérifiez que vous avez tout entré correctement ")
            End If
        Catch ex As SqlException
            MsgBox(ex.Number & " " & ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
            Ds1.T_programme.RejectChanges()
        End Try
    End Sub

    ''' <summary>
    ''' Fonction permettant de valider le Formulaire des programmes
    ''' </summary>
    ''' <returns></returns>
    Private Function Valider_Formulaire_Prog() As Boolean
        Try
            Err2.Clear()
            Dim ok As Boolean = True
            If cboPro_No.Text = "" Then
                Err2.SetError(cboPro_No, "No programme obligatoire")
                ok = False
            Else
                If ActionForm = ActionForm.ajout Then
                    If Existe_deja(cboPro_No.Text) Then
                        Err2.SetError(cboPro_No, "No programme existe déjà")
                        ok = False
                    Else
                        If cboPro_No.Text.Substring(3, 1) <> "." Then
                            Err2.SetError(cboPro_No, "Votre No de programme doit avoir un . dans le 4ieme caractère, Example: LEA.A1")
                            ok = False
                        End If
                    End If
                End If
            End If
            If txtProNom.Text = "" Then
                Err2.SetError(txtProNom, "Nom programme obligatoire")
                ok = False
            End If
            If numProNbrUnites.Value = 0 Then
                Err2.SetError(numProNbrUnites, "Nbr Heures obligatoire")
                ok = False
            End If
            If numProNbrHeures.Value = 0 Then
                Err2.SetError(numProNbrHeures, "Nbr Unites obligatoire")
                ok = False
            End If
            Return ok
        Catch ex As SqlException
            MsgBox(ex.Number & " " & ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' Fonction permettant de vérifier si le no programme existe déjà
    ''' </summary>
    Private Function Existe_deja(no As String) As Boolean
        Try
            Dim Existe As Boolean = False
            Dim i As Integer
            For i = 0 To DGProgram.Rows.Count - 2
                If DGProgram.Rows(i).Cells(0).Value = no Then
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
    ''' Validation des entrées dans le formulaire
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Validation_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProNom.KeyPress
        Try
            If Not (Asc(e.KeyChar) = 8) And Not (Asc(e.KeyChar) = 32) Then
                Dim allowedChars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"

                If Not allowedChars.Contains(e.KeyChar.ToString.ToUpper) Then
                    e.KeyChar = ChrW(0)
                    e.Handled = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cboPro_No_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboPro_No.KeyPress
        Try
            If Not (Asc(e.KeyChar) = 8) And Not (Asc(e.KeyChar) = 32) Then
                Dim allowedChars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ.0123456789"
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