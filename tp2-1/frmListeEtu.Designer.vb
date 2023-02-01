<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmListeEtu
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.crvListeEtu = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.cn = New System.Data.SqlClient.SqlConnection()
        Me.daListeEtu = New System.Data.SqlClient.SqlDataAdapter()
        Me.DsRapport1 = New tp2_1.dsRapport()
        CType(Me.DsRapport1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'crvListeEtu
        '
        Me.crvListeEtu.ActiveViewIndex = -1
        Me.crvListeEtu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvListeEtu.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvListeEtu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvListeEtu.Location = New System.Drawing.Point(0, 0)
        Me.crvListeEtu.Name = "crvListeEtu"
        Me.crvListeEtu.Size = New System.Drawing.Size(1376, 714)
        Me.crvListeEtu.TabIndex = 0
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT etu_da, pro_no, etu_nom, etu_prenom, etu_sexe, etu_adresse, etu_ville, etu" &
    "_province, etu_telephone, etu_codepostal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM     T_etudiants"
        Me.SqlSelectCommand1.Connection = Me.cn
        '
        'cn
        '
        Me.cn.ConnectionString = "Data Source=MARIERLINASUS\SQLEXPRESS;Initial Catalog=tp_p44;Integrated Security=T" &
    "rue"
        Me.cn.FireInfoMessageEventOnUserErrors = False
        '
        'daListeEtu
        '
        Me.daListeEtu.SelectCommand = Me.SqlSelectCommand1
        Me.daListeEtu.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "T_etudiants", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("etu_da", "etu_da"), New System.Data.Common.DataColumnMapping("pro_no", "pro_no"), New System.Data.Common.DataColumnMapping("etu_nom", "etu_nom"), New System.Data.Common.DataColumnMapping("etu_prenom", "etu_prenom"), New System.Data.Common.DataColumnMapping("etu_sexe", "etu_sexe"), New System.Data.Common.DataColumnMapping("etu_adresse", "etu_adresse"), New System.Data.Common.DataColumnMapping("etu_ville", "etu_ville"), New System.Data.Common.DataColumnMapping("etu_province", "etu_province"), New System.Data.Common.DataColumnMapping("etu_telephone", "etu_telephone"), New System.Data.Common.DataColumnMapping("etu_codepostal", "etu_codepostal")})})
        '
        'DsRapport1
        '
        Me.DsRapport1.DataSetName = "dsRapport"
        Me.DsRapport1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmListeEtu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1376, 714)
        Me.Controls.Add(Me.crvListeEtu)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmListeEtu"
        Me.Text = "Liste des Étudiants"
        CType(Me.DsRapport1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvListeEtu As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents cn As SqlClient.SqlConnection
    Friend WithEvents daListeEtu As SqlClient.SqlDataAdapter
    Friend WithEvents DsRapport1 As dsRapport
End Class
