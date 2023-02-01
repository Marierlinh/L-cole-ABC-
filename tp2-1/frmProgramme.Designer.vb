<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProg
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProg))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmdNouveau = New System.Windows.Forms.Button()
        Me.cmdEnlever = New System.Windows.Forms.Button()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.cmdModifier = New System.Windows.Forms.Button()
        Me.cmdAnnuler = New System.Windows.Forms.Button()
        Me.Err2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblecole = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpAction = New System.Windows.Forms.GroupBox()
        Me.grpProgramme = New System.Windows.Forms.GroupBox()
        Me.cboPro_No = New System.Windows.Forms.ComboBox()
        Me.bsProg = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds1 = New tp2_1.DS()
        Me.numProNbrUnites = New System.Windows.Forms.NumericUpDown()
        Me.numProNbrHeures = New System.Windows.Forms.NumericUpDown()
        Me.txtProNom = New System.Windows.Forms.TextBox()
        Me.lblprognbrHeures = New System.Windows.Forms.Label()
        Me.lblprognbrUnites = New System.Windows.Forms.Label()
        Me.lblprogNom = New System.Windows.Forms.Label()
        Me.lblprogNo = New System.Windows.Forms.Label()
        Me.dgEtuProg = New System.Windows.Forms.DataGridView()
        Me.EtudaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PronoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtuprenomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtunomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtusexeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtuadresseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtuvilleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtuprovinceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtutelephoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtucodepostalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsEtudiants = New System.Windows.Forms.BindingSource(Me.components)
        Me.cn = New System.Data.SqlClient.SqlConnection()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.daEtudiants = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.daProg = New System.Data.SqlClient.SqlDataAdapter()
        Me.DGProgram = New System.Windows.Forms.DataGridView()
        Me.PronoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PronomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PronbrunitesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PronbrheuresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Err2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAction.SuspendLayout()
        Me.grpProgramme.SuspendLayout()
        CType(Me.bsProg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numProNbrUnites, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numProNbrHeures, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgEtuProg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsEtudiants, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGProgram, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdNouveau
        '
        Me.cmdNouveau.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdNouveau.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdNouveau.Location = New System.Drawing.Point(21, 26)
        Me.cmdNouveau.Name = "cmdNouveau"
        Me.cmdNouveau.Size = New System.Drawing.Size(151, 39)
        Me.cmdNouveau.TabIndex = 0
        Me.cmdNouveau.Text = "Nouveau"
        Me.cmdNouveau.UseVisualStyleBackColor = False
        '
        'cmdEnlever
        '
        Me.cmdEnlever.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdEnlever.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdEnlever.Location = New System.Drawing.Point(21, 246)
        Me.cmdEnlever.Name = "cmdEnlever"
        Me.cmdEnlever.Size = New System.Drawing.Size(151, 39)
        Me.cmdEnlever.TabIndex = 4
        Me.cmdEnlever.Text = "Enlever"
        Me.cmdEnlever.UseVisualStyleBackColor = False
        '
        'cmdOK
        '
        Me.cmdOK.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdOK.Location = New System.Drawing.Point(21, 78)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(151, 39)
        Me.cmdOK.TabIndex = 1
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = False
        '
        'cmdModifier
        '
        Me.cmdModifier.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdModifier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdModifier.Location = New System.Drawing.Point(21, 188)
        Me.cmdModifier.Name = "cmdModifier"
        Me.cmdModifier.Size = New System.Drawing.Size(151, 39)
        Me.cmdModifier.TabIndex = 3
        Me.cmdModifier.Text = "Modifier"
        Me.cmdModifier.UseVisualStyleBackColor = False
        '
        'cmdAnnuler
        '
        Me.cmdAnnuler.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdAnnuler.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAnnuler.Location = New System.Drawing.Point(21, 133)
        Me.cmdAnnuler.Name = "cmdAnnuler"
        Me.cmdAnnuler.Size = New System.Drawing.Size(151, 39)
        Me.cmdAnnuler.TabIndex = 2
        Me.cmdAnnuler.Text = "Annuler"
        Me.cmdAnnuler.UseVisualStyleBackColor = False
        '
        'Err2
        '
        Me.Err2.ContainerControl = Me
        '
        'lblecole
        '
        Me.lblecole.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblecole.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblecole.Location = New System.Drawing.Point(103, 54)
        Me.lblecole.Name = "lblecole"
        Me.lblecole.Size = New System.Drawing.Size(226, 58)
        Me.lblecole.TabIndex = 29
        Me.lblecole.Text = "École ABC  "
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(24, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(108, 91)
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'grpAction
        '
        Me.grpAction.Controls.Add(Me.cmdNouveau)
        Me.grpAction.Controls.Add(Me.cmdEnlever)
        Me.grpAction.Controls.Add(Me.cmdOK)
        Me.grpAction.Controls.Add(Me.cmdModifier)
        Me.grpAction.Controls.Add(Me.cmdAnnuler)
        Me.grpAction.Location = New System.Drawing.Point(556, 78)
        Me.grpAction.Name = "grpAction"
        Me.grpAction.Size = New System.Drawing.Size(195, 299)
        Me.grpAction.TabIndex = 27
        Me.grpAction.TabStop = False
        '
        'grpProgramme
        '
        Me.grpProgramme.Controls.Add(Me.cboPro_No)
        Me.grpProgramme.Controls.Add(Me.numProNbrUnites)
        Me.grpProgramme.Controls.Add(Me.numProNbrHeures)
        Me.grpProgramme.Controls.Add(Me.txtProNom)
        Me.grpProgramme.Controls.Add(Me.lblprognbrHeures)
        Me.grpProgramme.Controls.Add(Me.lblprognbrUnites)
        Me.grpProgramme.Controls.Add(Me.lblprogNom)
        Me.grpProgramme.Controls.Add(Me.lblprogNo)
        Me.grpProgramme.Location = New System.Drawing.Point(24, 127)
        Me.grpProgramme.Name = "grpProgramme"
        Me.grpProgramme.Size = New System.Drawing.Size(496, 250)
        Me.grpProgramme.TabIndex = 24
        Me.grpProgramme.TabStop = False
        Me.grpProgramme.Text = "Programme"
        '
        'cboPro_No
        '
        Me.cboPro_No.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsProg, "pro_no", True))
        Me.cboPro_No.FormattingEnabled = True
        Me.cboPro_No.Location = New System.Drawing.Point(185, 48)
        Me.cboPro_No.MaxLength = 6
        Me.cboPro_No.Name = "cboPro_No"
        Me.cboPro_No.Size = New System.Drawing.Size(107, 28)
        Me.cboPro_No.TabIndex = 1
        '
        'bsProg
        '
        Me.bsProg.DataMember = "T_programme"
        Me.bsProg.DataSource = Me.Ds1
        '
        'Ds1
        '
        Me.Ds1.DataSetName = "DS"
        Me.Ds1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'numProNbrUnites
        '
        Me.numProNbrUnites.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.bsProg, "pro_nbr_unites", True))
        Me.numProNbrUnites.DecimalPlaces = 2
        Me.numProNbrUnites.Location = New System.Drawing.Point(185, 142)
        Me.numProNbrUnites.Name = "numProNbrUnites"
        Me.numProNbrUnites.Size = New System.Drawing.Size(85, 27)
        Me.numProNbrUnites.TabIndex = 5
        Me.numProNbrUnites.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'numProNbrHeures
        '
        Me.numProNbrHeures.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.bsProg, "pro_nbr_heures", True))
        Me.numProNbrHeures.Location = New System.Drawing.Point(185, 191)
        Me.numProNbrHeures.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.numProNbrHeures.Name = "numProNbrHeures"
        Me.numProNbrHeures.Size = New System.Drawing.Size(85, 27)
        Me.numProNbrHeures.TabIndex = 7
        Me.numProNbrHeures.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtProNom
        '
        Me.txtProNom.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsProg, "pro_nom", True))
        Me.txtProNom.Location = New System.Drawing.Point(185, 94)
        Me.txtProNom.MaxLength = 50
        Me.txtProNom.Multiline = True
        Me.txtProNom.Name = "txtProNom"
        Me.txtProNom.Size = New System.Drawing.Size(292, 31)
        Me.txtProNom.TabIndex = 3
        '
        'lblprognbrHeures
        '
        Me.lblprognbrHeures.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblprognbrHeures.Location = New System.Drawing.Point(24, 187)
        Me.lblprognbrHeures.Name = "lblprognbrHeures"
        Me.lblprognbrHeures.Size = New System.Drawing.Size(145, 31)
        Me.lblprognbrHeures.TabIndex = 6
        Me.lblprognbrHeures.Text = "Nbr. Heures :"
        Me.lblprognbrHeures.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblprognbrUnites
        '
        Me.lblprognbrUnites.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblprognbrUnites.Location = New System.Drawing.Point(24, 139)
        Me.lblprognbrUnites.Name = "lblprognbrUnites"
        Me.lblprognbrUnites.Size = New System.Drawing.Size(145, 31)
        Me.lblprognbrUnites.TabIndex = 4
        Me.lblprognbrUnites.Text = "Nbr. Unités :"
        Me.lblprognbrUnites.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblprogNom
        '
        Me.lblprogNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblprogNom.Location = New System.Drawing.Point(24, 94)
        Me.lblprogNom.Name = "lblprogNom"
        Me.lblprogNom.Size = New System.Drawing.Size(145, 31)
        Me.lblprogNom.TabIndex = 2
        Me.lblprogNom.Text = "Nom :"
        Me.lblprogNom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblprogNo
        '
        Me.lblprogNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblprogNo.Location = New System.Drawing.Point(24, 48)
        Me.lblprogNo.Name = "lblprogNo"
        Me.lblprogNo.Size = New System.Drawing.Size(145, 31)
        Me.lblprogNo.TabIndex = 0
        Me.lblprogNo.Text = "No :"
        Me.lblprogNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgEtuProg
        '
        Me.dgEtuProg.AllowUserToAddRows = False
        Me.dgEtuProg.AllowUserToDeleteRows = False
        Me.dgEtuProg.AutoGenerateColumns = False
        Me.dgEtuProg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgEtuProg.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgEtuProg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEtuProg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EtudaDataGridViewTextBoxColumn, Me.PronoDataGridViewTextBoxColumn1, Me.EtuprenomDataGridViewTextBoxColumn, Me.EtunomDataGridViewTextBoxColumn, Me.EtusexeDataGridViewTextBoxColumn, Me.EtuadresseDataGridViewTextBoxColumn, Me.EtuvilleDataGridViewTextBoxColumn, Me.EtuprovinceDataGridViewTextBoxColumn, Me.EtutelephoneDataGridViewTextBoxColumn, Me.EtucodepostalDataGridViewTextBoxColumn})
        Me.dgEtuProg.DataSource = Me.bsEtudiants
        Me.dgEtuProg.GridColor = System.Drawing.Color.CornflowerBlue
        Me.dgEtuProg.Location = New System.Drawing.Point(775, 54)
        Me.dgEtuProg.MultiSelect = False
        Me.dgEtuProg.Name = "dgEtuProg"
        Me.dgEtuProg.ReadOnly = True
        Me.dgEtuProg.RowHeadersVisible = False
        Me.dgEtuProg.RowHeadersWidth = 51
        Me.dgEtuProg.RowTemplate.Height = 24
        Me.dgEtuProg.Size = New System.Drawing.Size(479, 627)
        Me.dgEtuProg.TabIndex = 1
        '
        'EtudaDataGridViewTextBoxColumn
        '
        Me.EtudaDataGridViewTextBoxColumn.DataPropertyName = "etu_da"
        Me.EtudaDataGridViewTextBoxColumn.HeaderText = "DA"
        Me.EtudaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EtudaDataGridViewTextBoxColumn.Name = "EtudaDataGridViewTextBoxColumn"
        Me.EtudaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PronoDataGridViewTextBoxColumn1
        '
        Me.PronoDataGridViewTextBoxColumn1.DataPropertyName = "pro_no"
        Me.PronoDataGridViewTextBoxColumn1.HeaderText = "No Prog"
        Me.PronoDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.PronoDataGridViewTextBoxColumn1.Name = "PronoDataGridViewTextBoxColumn1"
        Me.PronoDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'EtuprenomDataGridViewTextBoxColumn
        '
        Me.EtuprenomDataGridViewTextBoxColumn.DataPropertyName = "etu_prenom"
        Me.EtuprenomDataGridViewTextBoxColumn.HeaderText = "Prenom"
        Me.EtuprenomDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EtuprenomDataGridViewTextBoxColumn.Name = "EtuprenomDataGridViewTextBoxColumn"
        Me.EtuprenomDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EtunomDataGridViewTextBoxColumn
        '
        Me.EtunomDataGridViewTextBoxColumn.DataPropertyName = "etu_nom"
        Me.EtunomDataGridViewTextBoxColumn.HeaderText = "Nom"
        Me.EtunomDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EtunomDataGridViewTextBoxColumn.Name = "EtunomDataGridViewTextBoxColumn"
        Me.EtunomDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EtusexeDataGridViewTextBoxColumn
        '
        Me.EtusexeDataGridViewTextBoxColumn.DataPropertyName = "etu_sexe"
        Me.EtusexeDataGridViewTextBoxColumn.HeaderText = "etu_sexe"
        Me.EtusexeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EtusexeDataGridViewTextBoxColumn.Name = "EtusexeDataGridViewTextBoxColumn"
        Me.EtusexeDataGridViewTextBoxColumn.ReadOnly = True
        Me.EtusexeDataGridViewTextBoxColumn.Visible = False
        '
        'EtuadresseDataGridViewTextBoxColumn
        '
        Me.EtuadresseDataGridViewTextBoxColumn.DataPropertyName = "etu_adresse"
        Me.EtuadresseDataGridViewTextBoxColumn.HeaderText = "etu_adresse"
        Me.EtuadresseDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EtuadresseDataGridViewTextBoxColumn.Name = "EtuadresseDataGridViewTextBoxColumn"
        Me.EtuadresseDataGridViewTextBoxColumn.ReadOnly = True
        Me.EtuadresseDataGridViewTextBoxColumn.Visible = False
        '
        'EtuvilleDataGridViewTextBoxColumn
        '
        Me.EtuvilleDataGridViewTextBoxColumn.DataPropertyName = "etu_ville"
        Me.EtuvilleDataGridViewTextBoxColumn.HeaderText = "etu_ville"
        Me.EtuvilleDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EtuvilleDataGridViewTextBoxColumn.Name = "EtuvilleDataGridViewTextBoxColumn"
        Me.EtuvilleDataGridViewTextBoxColumn.ReadOnly = True
        Me.EtuvilleDataGridViewTextBoxColumn.Visible = False
        '
        'EtuprovinceDataGridViewTextBoxColumn
        '
        Me.EtuprovinceDataGridViewTextBoxColumn.DataPropertyName = "etu_province"
        Me.EtuprovinceDataGridViewTextBoxColumn.HeaderText = "etu_province"
        Me.EtuprovinceDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EtuprovinceDataGridViewTextBoxColumn.Name = "EtuprovinceDataGridViewTextBoxColumn"
        Me.EtuprovinceDataGridViewTextBoxColumn.ReadOnly = True
        Me.EtuprovinceDataGridViewTextBoxColumn.Visible = False
        '
        'EtutelephoneDataGridViewTextBoxColumn
        '
        Me.EtutelephoneDataGridViewTextBoxColumn.DataPropertyName = "etu_telephone"
        Me.EtutelephoneDataGridViewTextBoxColumn.HeaderText = "etu_telephone"
        Me.EtutelephoneDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EtutelephoneDataGridViewTextBoxColumn.Name = "EtutelephoneDataGridViewTextBoxColumn"
        Me.EtutelephoneDataGridViewTextBoxColumn.ReadOnly = True
        Me.EtutelephoneDataGridViewTextBoxColumn.Visible = False
        '
        'EtucodepostalDataGridViewTextBoxColumn
        '
        Me.EtucodepostalDataGridViewTextBoxColumn.DataPropertyName = "etu_codepostal"
        Me.EtucodepostalDataGridViewTextBoxColumn.HeaderText = "etu_codepostal"
        Me.EtucodepostalDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EtucodepostalDataGridViewTextBoxColumn.Name = "EtucodepostalDataGridViewTextBoxColumn"
        Me.EtucodepostalDataGridViewTextBoxColumn.ReadOnly = True
        Me.EtucodepostalDataGridViewTextBoxColumn.Visible = False
        '
        'bsEtudiants
        '
        Me.bsEtudiants.DataMember = "T_etudiants"
        Me.bsEtudiants.DataSource = Me.Ds1
        '
        'cn
        '
        Me.cn.ConnectionString = "Data Source=MARIERLINASUS\SQLEXPRESS;Initial Catalog=tp_p44;Integrated Security=T" &
    "rue"
        Me.cn.FireInfoMessageEventOnUserErrors = False
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT etu_da, pro_no, etu_nom, etu_prenom, etu_sexe, etu_adresse, etu_ville, etu" &
    "_province, etu_telephone, etu_codepostal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM     T_etudiants" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE  (pro_no =" &
    " @prono)"
        Me.SqlSelectCommand2.Connection = Me.cn
        Me.SqlSelectCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@prono", System.Data.SqlDbType.VarChar, 6, "pro_no")})
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Connection = Me.cn
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@etu_da", System.Data.SqlDbType.VarChar, 0, "etu_da"), New System.Data.SqlClient.SqlParameter("@pro_no", System.Data.SqlDbType.VarChar, 0, "pro_no"), New System.Data.SqlClient.SqlParameter("@etu_nom", System.Data.SqlDbType.VarChar, 0, "etu_nom"), New System.Data.SqlClient.SqlParameter("@etu_prenom", System.Data.SqlDbType.VarChar, 0, "etu_prenom"), New System.Data.SqlClient.SqlParameter("@etu_sexe", System.Data.SqlDbType.[Char], 0, "etu_sexe"), New System.Data.SqlClient.SqlParameter("@etu_adresse", System.Data.SqlDbType.VarChar, 0, "etu_adresse"), New System.Data.SqlClient.SqlParameter("@etu_ville", System.Data.SqlDbType.VarChar, 0, "etu_ville"), New System.Data.SqlClient.SqlParameter("@etu_province", System.Data.SqlDbType.VarChar, 0, "etu_province"), New System.Data.SqlClient.SqlParameter("@etu_telephone", System.Data.SqlDbType.VarChar, 0, "etu_telephone"), New System.Data.SqlClient.SqlParameter("@etu_codepostal", System.Data.SqlDbType.VarChar, 0, "etu_codepostal")})
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Connection = Me.cn
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@etu_da", System.Data.SqlDbType.VarChar, 0, "etu_da"), New System.Data.SqlClient.SqlParameter("@pro_no", System.Data.SqlDbType.VarChar, 0, "pro_no"), New System.Data.SqlClient.SqlParameter("@etu_nom", System.Data.SqlDbType.VarChar, 0, "etu_nom"), New System.Data.SqlClient.SqlParameter("@etu_prenom", System.Data.SqlDbType.VarChar, 0, "etu_prenom"), New System.Data.SqlClient.SqlParameter("@etu_sexe", System.Data.SqlDbType.[Char], 0, "etu_sexe"), New System.Data.SqlClient.SqlParameter("@etu_adresse", System.Data.SqlDbType.VarChar, 0, "etu_adresse"), New System.Data.SqlClient.SqlParameter("@etu_ville", System.Data.SqlDbType.VarChar, 0, "etu_ville"), New System.Data.SqlClient.SqlParameter("@etu_province", System.Data.SqlDbType.VarChar, 0, "etu_province"), New System.Data.SqlClient.SqlParameter("@etu_telephone", System.Data.SqlDbType.VarChar, 0, "etu_telephone"), New System.Data.SqlClient.SqlParameter("@etu_codepostal", System.Data.SqlDbType.VarChar, 0, "etu_codepostal"), New System.Data.SqlClient.SqlParameter("@Original_etu_da", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_da", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_pro_no", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_no", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_etu_nom", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_nom", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_etu_prenom", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_prenom", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_sexe", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_sexe", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_sexe", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_sexe", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_adresse", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_adresse", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_adresse", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_adresse", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_ville", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_ville", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_ville", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_ville", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_province", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_province", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_province", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_province", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_telephone", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_telephone", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_telephone", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_telephone", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_codepostal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_codepostal", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_codepostal", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_codepostal", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = resources.GetString("SqlDeleteCommand2.CommandText")
        Me.SqlDeleteCommand2.Connection = Me.cn
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_etu_da", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_da", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_pro_no", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_no", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_etu_nom", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_nom", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_etu_prenom", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_prenom", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_sexe", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_sexe", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_sexe", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_sexe", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_adresse", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_adresse", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_adresse", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_adresse", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_ville", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_ville", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_ville", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_ville", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_province", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_province", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_province", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_province", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_telephone", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_telephone", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_telephone", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_telephone", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_codepostal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_codepostal", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_codepostal", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_codepostal", System.Data.DataRowVersion.Original, Nothing)})
        '
        'daEtudiants
        '
        Me.daEtudiants.DeleteCommand = Me.SqlDeleteCommand2
        Me.daEtudiants.InsertCommand = Me.SqlInsertCommand2
        Me.daEtudiants.SelectCommand = Me.SqlSelectCommand2
        Me.daEtudiants.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "T_etudiants", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("etu_da", "etu_da"), New System.Data.Common.DataColumnMapping("pro_no", "pro_no"), New System.Data.Common.DataColumnMapping("etu_nom", "etu_nom"), New System.Data.Common.DataColumnMapping("etu_prenom", "etu_prenom"), New System.Data.Common.DataColumnMapping("etu_sexe", "etu_sexe"), New System.Data.Common.DataColumnMapping("etu_adresse", "etu_adresse"), New System.Data.Common.DataColumnMapping("etu_ville", "etu_ville"), New System.Data.Common.DataColumnMapping("etu_province", "etu_province"), New System.Data.Common.DataColumnMapping("etu_telephone", "etu_telephone"), New System.Data.Common.DataColumnMapping("etu_codepostal", "etu_codepostal")})})
        Me.daEtudiants.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT *" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM     T_programme"
        Me.SqlSelectCommand1.Connection = Me.cn
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.cn
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@pro_no", System.Data.SqlDbType.VarChar, 0, "pro_no"), New System.Data.SqlClient.SqlParameter("@pro_nom", System.Data.SqlDbType.VarChar, 0, "pro_nom"), New System.Data.SqlClient.SqlParameter("@pro_nbr_unites", System.Data.SqlDbType.Float, 0, "pro_nbr_unites"), New System.Data.SqlClient.SqlParameter("@pro_nbr_heures", System.Data.SqlDbType.Int, 0, "pro_nbr_heures")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.cn
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@pro_no", System.Data.SqlDbType.VarChar, 0, "pro_no"), New System.Data.SqlClient.SqlParameter("@pro_nom", System.Data.SqlDbType.VarChar, 0, "pro_nom"), New System.Data.SqlClient.SqlParameter("@pro_nbr_unites", System.Data.SqlDbType.Float, 0, "pro_nbr_unites"), New System.Data.SqlClient.SqlParameter("@pro_nbr_heures", System.Data.SqlDbType.Int, 0, "pro_nbr_heures"), New System.Data.SqlClient.SqlParameter("@Original_pro_no", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_no", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_pro_nom", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_nom", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_pro_nbr_unites", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_nbr_unites", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pro_nbr_heures", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pro_nbr_heures", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pro_nbr_heures", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_nbr_heures", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.cn
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_pro_no", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_no", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_pro_nom", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_nom", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_pro_nbr_unites", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_nbr_unites", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pro_nbr_heures", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pro_nbr_heures", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pro_nbr_heures", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_nbr_heures", System.Data.DataRowVersion.Original, Nothing)})
        '
        'daProg
        '
        Me.daProg.DeleteCommand = Me.SqlDeleteCommand1
        Me.daProg.InsertCommand = Me.SqlInsertCommand1
        Me.daProg.SelectCommand = Me.SqlSelectCommand1
        Me.daProg.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "T_programme", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("pro_no", "pro_no"), New System.Data.Common.DataColumnMapping("pro_nom", "pro_nom"), New System.Data.Common.DataColumnMapping("pro_nbr_unites", "pro_nbr_unites"), New System.Data.Common.DataColumnMapping("pro_nbr_heures", "pro_nbr_heures")})})
        Me.daProg.UpdateCommand = Me.SqlUpdateCommand1
        '
        'DGProgram
        '
        Me.DGProgram.AllowUserToAddRows = False
        Me.DGProgram.AllowUserToDeleteRows = False
        Me.DGProgram.AutoGenerateColumns = False
        Me.DGProgram.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGProgram.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGProgram.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGProgram.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGProgram.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PronoDataGridViewTextBoxColumn, Me.PronomDataGridViewTextBoxColumn, Me.PronbrunitesDataGridViewTextBoxColumn, Me.PronbrheuresDataGridViewTextBoxColumn})
        Me.DGProgram.DataSource = Me.bsProg
        Me.DGProgram.GridColor = System.Drawing.Color.CornflowerBlue
        Me.DGProgram.Location = New System.Drawing.Point(24, 417)
        Me.DGProgram.MultiSelect = False
        Me.DGProgram.Name = "DGProgram"
        Me.DGProgram.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGProgram.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGProgram.RowHeadersWidth = 51
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        Me.DGProgram.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGProgram.RowTemplate.Height = 24
        Me.DGProgram.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGProgram.Size = New System.Drawing.Size(726, 263)
        Me.DGProgram.TabIndex = 0
        '
        'PronoDataGridViewTextBoxColumn
        '
        Me.PronoDataGridViewTextBoxColumn.DataPropertyName = "pro_no"
        Me.PronoDataGridViewTextBoxColumn.HeaderText = "No Prog"
        Me.PronoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PronoDataGridViewTextBoxColumn.Name = "PronoDataGridViewTextBoxColumn"
        Me.PronoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PronomDataGridViewTextBoxColumn
        '
        Me.PronomDataGridViewTextBoxColumn.DataPropertyName = "pro_nom"
        Me.PronomDataGridViewTextBoxColumn.HeaderText = "Nom"
        Me.PronomDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PronomDataGridViewTextBoxColumn.Name = "PronomDataGridViewTextBoxColumn"
        Me.PronomDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PronbrunitesDataGridViewTextBoxColumn
        '
        Me.PronbrunitesDataGridViewTextBoxColumn.DataPropertyName = "pro_nbr_unites"
        Me.PronbrunitesDataGridViewTextBoxColumn.HeaderText = "Nbr. Unités"
        Me.PronbrunitesDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PronbrunitesDataGridViewTextBoxColumn.Name = "PronbrunitesDataGridViewTextBoxColumn"
        Me.PronbrunitesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PronbrheuresDataGridViewTextBoxColumn
        '
        Me.PronbrheuresDataGridViewTextBoxColumn.DataPropertyName = "pro_nbr_heures"
        Me.PronbrheuresDataGridViewTextBoxColumn.HeaderText = "Nbr. Heures"
        Me.PronbrheuresDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PronbrheuresDataGridViewTextBoxColumn.Name = "PronbrheuresDataGridViewTextBoxColumn"
        Me.PronbrheuresDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmProg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1266, 741)
        Me.Controls.Add(Me.DGProgram)
        Me.Controls.Add(Me.dgEtuProg)
        Me.Controls.Add(Me.lblecole)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.grpAction)
        Me.Controls.Add(Me.grpProgramme)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmProg"
        Me.Text = "Gestion des programmes"
        CType(Me.Err2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAction.ResumeLayout(False)
        Me.grpProgramme.ResumeLayout(False)
        Me.grpProgramme.PerformLayout()
        CType(Me.bsProg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numProNbrUnites, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numProNbrHeures, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgEtuProg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsEtudiants, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGProgram, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdNouveau As Button
    Friend WithEvents cmdEnlever As Button
    Friend WithEvents cmdOK As Button
    Friend WithEvents cmdModifier As Button
    Friend WithEvents cmdAnnuler As Button
    Friend WithEvents Err2 As ErrorProvider
    Friend WithEvents lblecole As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents grpAction As GroupBox
    Friend WithEvents grpProgramme As GroupBox
    Friend WithEvents numProNbrUnites As NumericUpDown
    Friend WithEvents numProNbrHeures As NumericUpDown
    Friend WithEvents txtProNom As TextBox
    Friend WithEvents lblprognbrHeures As Label
    Friend WithEvents lblprognbrUnites As Label
    Friend WithEvents lblprogNom As Label
    Friend WithEvents lblprogNo As Label
    Friend WithEvents dgEtuProg As DataGridView
    Friend WithEvents cn As SqlClient.SqlConnection
    Friend WithEvents Ds1 As DS
    Friend WithEvents bsProg As BindingSource
    Friend WithEvents SqlSelectCommand2 As SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As SqlClient.SqlCommand
    Friend WithEvents daEtudiants As SqlClient.SqlDataAdapter
    Friend WithEvents EtudaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PronoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents EtuprenomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtunomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtusexeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtuadresseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtuvilleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtuprovinceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtutelephoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtucodepostalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents bsEtudiants As BindingSource
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
    Friend WithEvents daProg As SqlClient.SqlDataAdapter
    Friend WithEvents DGProgram As DataGridView
    Friend WithEvents PronoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PronomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PronbrunitesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PronbrheuresDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents cboPro_No As ComboBox
End Class
