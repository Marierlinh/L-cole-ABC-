<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmListeEtuProg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListeEtuProg))
        Me.crvListeEtuProg = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.daListeEtuProg = New System.Data.SqlClient.SqlDataAdapter()
        Me.cn = New System.Data.SqlClient.SqlConnection()
        Me.DsRapEtuProg1 = New tp2_1.dsRapEtuProg()
        CType(Me.DsRapEtuProg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'crvListeEtuProg
        '
        Me.crvListeEtuProg.ActiveViewIndex = -1
        Me.crvListeEtuProg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvListeEtuProg.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvListeEtuProg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvListeEtuProg.Location = New System.Drawing.Point(0, 0)
        Me.crvListeEtuProg.Name = "crvListeEtuProg"
        Me.crvListeEtuProg.Size = New System.Drawing.Size(1380, 718)
        Me.crvListeEtuProg.TabIndex = 0
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
        Me.SqlSelectCommand1.Connection = Me.cn
        '
        'daListeEtuProg
        '
        Me.daListeEtuProg.SelectCommand = Me.SqlSelectCommand1
        Me.daListeEtuProg.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "T_etudiants", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("pro_no", "pro_no"), New System.Data.Common.DataColumnMapping("pro_nom", "pro_nom"), New System.Data.Common.DataColumnMapping("etu_da", "etu_da"), New System.Data.Common.DataColumnMapping("etu_nom", "etu_nom"), New System.Data.Common.DataColumnMapping("etu_prenom", "etu_prenom"), New System.Data.Common.DataColumnMapping("etu_ville", "etu_ville"), New System.Data.Common.DataColumnMapping("etu_telephone", "etu_telephone")})})
        '
        'cn
        '
        Me.cn.ConnectionString = "Data Source=MARIERLINASUS\SQLEXPRESS;Initial Catalog=tp_p44;Integrated Security=T" &
    "rue"
        Me.cn.FireInfoMessageEventOnUserErrors = False
        '
        'DsRapEtuProg1
        '
        Me.DsRapEtuProg1.DataSetName = "dsRapEtuProg"
        Me.DsRapEtuProg1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmListeEtuProg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1380, 718)
        Me.Controls.Add(Me.crvListeEtuProg)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmListeEtuProg"
        Me.Text = "Liste des Étudiants par programme"
        CType(Me.DsRapEtuProg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvListeEtuProg As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents cn As SqlClient.SqlConnection
    Friend WithEvents daListeEtuProg As SqlClient.SqlDataAdapter
    Friend WithEvents DsRapEtuProg1 As dsRapEtuProg
End Class
