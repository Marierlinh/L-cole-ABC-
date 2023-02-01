'''' <summary>
'''' Cette fenêtre enfant permettra de visualiser le rapport regroupant l’ensemble des étudiants.
'''' 
'''' Fait par: Marierlin Higuerey
'''' le: 05/09/2021
'''' </summary>

Public Class frmListeEtuProg
    Private Sub frmListeEtuProg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'remplir la table programme du DataSet
            daListeEtuProg.Fill(DsRapEtuProg1.T_etudiants)
            'instanciation d'un rapport
            Dim rap As New rapListeEtuProg
            'Associer la source de données au rapport
            rap.SetDataSource(DsRapEtuProg1)
            'Placer le rapport dans l'aperçu avant impression (CRV)
            crvListeEtuProg.ReportSource = rap
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class