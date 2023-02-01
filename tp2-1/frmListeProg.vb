'''' <summary>
'''' Cette fenêtre enfant permettra de visualiser le rapport regroupant l’ensemble des étudiants par programme.
'''' 
'''' Fait par: Marierlin Higuerey
'''' le: 05/09/2021
'''' </summary>
Public Class frmListeProg
    Private Sub frmListeProg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'remplir la table programme du DataSet
            daListeProg.Fill(DsRapport1.T_programme)
            'instanciation d'un rapport
            Dim rap As New rapListeProg
            'Associer la source de données au rapport
            rap.SetDataSource(DsRapport1)
            'Placer le rapport dans l'aperçu avant impression (CRV)
            crvListeProg.ReportSource = rap
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class