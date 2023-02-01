<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListeProg
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
        Me.crvListeProg = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.daListeProg = New System.Data.SqlClient.SqlDataAdapter()
        Me.cn = New System.Data.SqlClient.SqlConnection()
        Me.DsRapport1 = New tp2_1.dsRapport()
        CType(Me.DsRapport1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'crvListeProg
        '
        Me.crvListeProg.ActiveViewIndex = -1
        Me.crvListeProg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvListeProg.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvListeProg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvListeProg.Location = New System.Drawing.Point(0, 0)
        Me.crvListeProg.Name = "crvListeProg"
        Me.crvListeProg.Size = New System.Drawing.Size(1118, 572)
        Me.crvListeProg.TabIndex = 32
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT *" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM     T_programme"
        Me.SqlSelectCommand1.Connection = Me.cn
        '
        'daListeProg
        '
        Me.daListeProg.SelectCommand = Me.SqlSelectCommand1
        Me.daListeProg.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "T_programme", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("pro_no", "pro_no"), New System.Data.Common.DataColumnMapping("pro_nom", "pro_nom"), New System.Data.Common.DataColumnMapping("pro_nbr_unites", "pro_nbr_unites"), New System.Data.Common.DataColumnMapping("pro_nbr_heures", "pro_nbr_heures")})})
        '
        'cn
        '
        Me.cn.ConnectionString = "Data Source=MARIERLINASUS\SQLEXPRESS;Initial Catalog=tp_p44;Integrated Security=T" &
    "rue"
        Me.cn.FireInfoMessageEventOnUserErrors = False
        '
        'DsRapport1
        '
        Me.DsRapport1.DataSetName = "dsRapport"
        Me.DsRapport1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmListeProg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1118, 572)
        Me.Controls.Add(Me.crvListeProg)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmListeProg"
        Me.Text = "Liste des programmes"
        CType(Me.DsRapport1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvListeProg As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents cn As SqlClient.SqlConnection
    Friend WithEvents daListeProg As SqlClient.SqlDataAdapter
    Friend WithEvents DsRapport1 As dsRapport
End Class
