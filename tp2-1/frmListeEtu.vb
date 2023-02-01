'''' <summary>
'''' Cette fenêtre enfant permettra de visualiser le rapport regroupant l’ensemble des programmes.
'''' 
'''' Fait par: Marierlin Higuerey
'''' le: 05/09/2021
'''' </summary>

Public Class frmListeEtu
    Private Sub frmListeEtu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'remplir la table programme du DataSet
            daListeEtu.Fill(DsRapport1.T_etudiants)
            'instanciation d'un rapport
            Dim rap As New rapListeEtu
            'Associer la source de données au rapport
            rap.SetDataSource(DsRapport1)
            'Placer le rapport dans l'aperçu avant impression (CRV)
            crvListeEtu.ReportSource = rap
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class