<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEtudiants
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEtudiants))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.optEtu_Feminin = New System.Windows.Forms.RadioButton()
        Me.cmdModifier = New System.Windows.Forms.Button()
        Me.mskEtu_CodePostal = New System.Windows.Forms.MaskedTextBox()
        Me.bsEtudiants = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds1 = New tp2_1.DS()
        Me.txtEtu_Ville = New System.Windows.Forms.TextBox()
        Me.txtEtu_Adresse = New System.Windows.Forms.TextBox()
        Me.txtEtu_Prenom = New System.Windows.Forms.TextBox()
        Me.txtEtu_Nom = New System.Windows.Forms.TextBox()
        Me.cboEtu_Province = New System.Windows.Forms.ComboBox()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.cmdAnnuler = New System.Windows.Forms.Button()
        Me.mskEtu_Telephone = New System.Windows.Forms.MaskedTextBox()
        Me.cmdNouveau = New System.Windows.Forms.Button()
        Me.cmdEnlever = New System.Windows.Forms.Button()
        Me.Err1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblecole = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpAction = New System.Windows.Forms.GroupBox()
        Me.cboPro_No = New System.Windows.Forms.ComboBox()
        Me.bsProg = New System.Windows.Forms.BindingSource(Me.components)
        Me.mskEtu_da = New System.Windows.Forms.MaskedTextBox()
        Me.optEtu_Masculin = New System.Windows.Forms.RadioButton()
        Me.grpEtu_Sexe = New System.Windows.Forms.GroupBox()
        Me.lbletuTelephone = New System.Windows.Forms.Label()
        Me.lbletuCodePostal = New System.Windows.Forms.Label()
        Me.lbletuProvince = New System.Windows.Forms.Label()
        Me.lbletuVille = New System.Windows.Forms.Label()
        Me.lbletuAdresse = New System.Windows.Forms.Label()
        Me.lbletuNom = New System.Windows.Forms.Label()
        Me.lbletuDA = New System.Windows.Forms.Label()
        Me.grpEtudiant = New System.Windows.Forms.GroupBox()
        Me.txtSexe = New System.Windows.Forms.TextBox()
        Me.lbletuPrenom = New System.Windows.Forms.Label()
        Me.lbletuNoProg = New System.Windows.Forms.Label()
        Me.dgEtudiants = New System.Windows.Forms.DataGridView()
        Me.EtudaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PronoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtunomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtuprenomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtusexeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtuadresseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtuvilleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtuprovinceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtutelephoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtucodepostalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.cn = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.daEtudiants = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.daProg = New System.Data.SqlClient.SqlDataAdapter()
        CType(Me.bsEtudiants, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Err1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAction.SuspendLayout()
        CType(Me.bsProg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEtu_Sexe.SuspendLayout()
        Me.grpEtudiant.SuspendLayout()
        CType(Me.dgEtudiants, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'optEtu_Feminin
        '
        Me.optEtu_Feminin.AutoSize = True
        Me.optEtu_Feminin.Location = New System.Drawing.Point(6, 17)
        Me.optEtu_Feminin.Name = "optEtu_Feminin"
        Me.optEtu_Feminin.Size = New System.Drawing.Size(95, 24)
        Me.optEtu_Feminin.TabIndex = 0
        Me.optEtu_Feminin.TabStop = True
        Me.optEtu_Feminin.Tag = "F"
        Me.optEtu_Feminin.Text = "Féminin"
        Me.optEtu_Feminin.UseVisualStyleBackColor = True
        '
        'cmdModifier
        '
        Me.cmdModifier.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdModifier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdModifier.Location = New System.Drawing.Point(19, 201)
        Me.cmdModifier.Name = "cmdModifier"
        Me.cmdModifier.Size = New System.Drawing.Size(151, 39)
        Me.cmdModifier.TabIndex = 3
        Me.cmdModifier.Text = "Modifier"
        Me.cmdModifier.UseVisualStyleBackColor = False
        '
        'mskEtu_CodePostal
        '
        Me.mskEtu_CodePostal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsEtudiants, "etu_codepostal", True))
        Me.mskEtu_CodePostal.Location = New System.Drawing.Point(678, 177)
        Me.mskEtu_CodePostal.Mask = "L0L-0L0"
        Me.mskEtu_CodePostal.Name = "mskEtu_CodePostal"
        Me.mskEtu_CodePostal.Size = New System.Drawing.Size(85, 27)
        Me.mskEtu_CodePostal.TabIndex = 17
        Me.mskEtu_CodePostal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bsEtudiants
        '
        Me.bsEtudiants.DataMember = "T_etudiants"
        Me.bsEtudiants.DataSource = Me.Ds1
        '
        'Ds1
        '
        Me.Ds1.DataSetName = "DS"
        Me.Ds1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtEtu_Ville
        '
        Me.txtEtu_Ville.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsEtudiants, "etu_ville", True))
        Me.txtEtu_Ville.Location = New System.Drawing.Point(678, 80)
        Me.txtEtu_Ville.MaxLength = 50
        Me.txtEtu_Ville.Multiline = True
        Me.txtEtu_Ville.Name = "txtEtu_Ville"
        Me.txtEtu_Ville.Size = New System.Drawing.Size(302, 31)
        Me.txtEtu_Ville.TabIndex = 13
        '
        'txtEtu_Adresse
        '
        Me.txtEtu_Adresse.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsEtudiants, "etu_adresse", True))
        Me.txtEtu_Adresse.Location = New System.Drawing.Point(678, 38)
        Me.txtEtu_Adresse.MaxLength = 100
        Me.txtEtu_Adresse.Multiline = True
        Me.txtEtu_Adresse.Name = "txtEtu_Adresse"
        Me.txtEtu_Adresse.Size = New System.Drawing.Size(302, 31)
        Me.txtEtu_Adresse.TabIndex = 11
        '
        'txtEtu_Prenom
        '
        Me.txtEtu_Prenom.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsEtudiants, "etu_prenom", True))
        Me.txtEtu_Prenom.Location = New System.Drawing.Point(190, 125)
        Me.txtEtu_Prenom.MaxLength = 20
        Me.txtEtu_Prenom.Multiline = True
        Me.txtEtu_Prenom.Name = "txtEtu_Prenom"
        Me.txtEtu_Prenom.Size = New System.Drawing.Size(274, 31)
        Me.txtEtu_Prenom.TabIndex = 5
        '
        'txtEtu_Nom
        '
        Me.txtEtu_Nom.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsEtudiants, "etu_nom", True))
        Me.txtEtu_Nom.Location = New System.Drawing.Point(190, 171)
        Me.txtEtu_Nom.MaxLength = 20
        Me.txtEtu_Nom.Multiline = True
        Me.txtEtu_Nom.Name = "txtEtu_Nom"
        Me.txtEtu_Nom.Size = New System.Drawing.Size(276, 31)
        Me.txtEtu_Nom.TabIndex = 7
        '
        'cboEtu_Province
        '
        Me.cboEtu_Province.BackColor = System.Drawing.SystemColors.Window
        Me.cboEtu_Province.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsEtudiants, "etu_province", True))
        Me.cboEtu_Province.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEtu_Province.FormattingEnabled = True
        Me.cboEtu_Province.Items.AddRange(New Object() {"Alberta", "Colombie-Britannique", "Île-du-Prince-Édouard", "Manitoba", "Nouveau-Brunswick", "Nouvelle-Écosse", "Nunavut", "Ontario", "Québec", "Saskatchewan", "Terre-Neuve-et-Labrador", "Territoires du Nord-Ouest", "Yukon"})
        Me.cboEtu_Province.Location = New System.Drawing.Point(678, 132)
        Me.cboEtu_Province.MaxLength = 50
        Me.cboEtu_Province.Name = "cboEtu_Province"
        Me.cboEtu_Province.Size = New System.Drawing.Size(302, 28)
        Me.cboEtu_Province.TabIndex = 15
        '
        'cmdOK
        '
        Me.cmdOK.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdOK.Location = New System.Drawing.Point(19, 91)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(151, 39)
        Me.cmdOK.TabIndex = 1
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = False
        '
        'cmdAnnuler
        '
        Me.cmdAnnuler.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdAnnuler.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAnnuler.Location = New System.Drawing.Point(19, 146)
        Me.cmdAnnuler.Name = "cmdAnnuler"
        Me.cmdAnnuler.Size = New System.Drawing.Size(151, 39)
        Me.cmdAnnuler.TabIndex = 2
        Me.cmdAnnuler.Text = "Annuler"
        Me.cmdAnnuler.UseVisualStyleBackColor = False
        '
        'mskEtu_Telephone
        '
        Me.mskEtu_Telephone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsEtudiants, "etu_telephone", True))
        Me.mskEtu_Telephone.Location = New System.Drawing.Point(678, 224)
        Me.mskEtu_Telephone.Mask = "(000) 000-0000"
        Me.mskEtu_Telephone.Name = "mskEtu_Telephone"
        Me.mskEtu_Telephone.Size = New System.Drawing.Size(125, 27)
        Me.mskEtu_Telephone.TabIndex = 19
        '
        'cmdNouveau
        '
        Me.cmdNouveau.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdNouveau.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdNouveau.Location = New System.Drawing.Point(19, 39)
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
        Me.cmdEnlever.Location = New System.Drawing.Point(19, 259)
        Me.cmdEnlever.Name = "cmdEnlever"
        Me.cmdEnlever.Size = New System.Drawing.Size(151, 39)
        Me.cmdEnlever.TabIndex = 4
        Me.cmdEnlever.Text = "Enlever"
        Me.cmdEnlever.UseVisualStyleBackColor = False
        '
        'Err1
        '
        Me.Err1.ContainerControl = Me
        '
        'lblecole
        '
        Me.lblecole.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblecole.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblecole.Location = New System.Drawing.Point(107, 41)
        Me.lblecole.Name = "lblecole"
        Me.lblecole.Size = New System.Drawing.Size(226, 58)
        Me.lblecole.TabIndex = 0
        Me.lblecole.Text = "École ABC  "
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(28, 12)
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
        Me.grpAction.Location = New System.Drawing.Point(1135, 41)
        Me.grpAction.Name = "grpAction"
        Me.grpAction.Size = New System.Drawing.Size(195, 334)
        Me.grpAction.TabIndex = 1
        Me.grpAction.TabStop = False
        '
        'cboPro_No
        '
        Me.cboPro_No.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsEtudiants, "pro_no", True))
        Me.cboPro_No.DataSource = Me.bsProg
        Me.cboPro_No.DisplayMember = "pro_no"
        Me.cboPro_No.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPro_No.FormattingEnabled = True
        Me.cboPro_No.Location = New System.Drawing.Point(193, 80)
        Me.cboPro_No.MaxLength = 6
        Me.cboPro_No.Name = "cboPro_No"
        Me.cboPro_No.Size = New System.Drawing.Size(145, 28)
        Me.cboPro_No.TabIndex = 3
        Me.cboPro_No.ValueMember = "pro_no"
        '
        'bsProg
        '
        Me.bsProg.DataMember = "T_programme"
        Me.bsProg.DataSource = Me.Ds1
        '
        'mskEtu_da
        '
        Me.mskEtu_da.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsEtudiants, "etu_da", True))
        Me.mskEtu_da.Location = New System.Drawing.Point(190, 39)
        Me.mskEtu_da.Mask = "0000000"
        Me.mskEtu_da.Name = "mskEtu_da"
        Me.mskEtu_da.Size = New System.Drawing.Size(95, 27)
        Me.mskEtu_da.TabIndex = 1
        Me.mskEtu_da.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'optEtu_Masculin
        '
        Me.optEtu_Masculin.AutoSize = True
        Me.optEtu_Masculin.Location = New System.Drawing.Point(6, 47)
        Me.optEtu_Masculin.Name = "optEtu_Masculin"
        Me.optEtu_Masculin.Size = New System.Drawing.Size(103, 24)
        Me.optEtu_Masculin.TabIndex = 1
        Me.optEtu_Masculin.TabStop = True
        Me.optEtu_Masculin.Tag = "M"
        Me.optEtu_Masculin.Text = "Masculin"
        Me.optEtu_Masculin.UseVisualStyleBackColor = True
        '
        'grpEtu_Sexe
        '
        Me.grpEtu_Sexe.Controls.Add(Me.optEtu_Masculin)
        Me.grpEtu_Sexe.Controls.Add(Me.optEtu_Feminin)
        Me.grpEtu_Sexe.Location = New System.Drawing.Point(178, 210)
        Me.grpEtu_Sexe.Name = "grpEtu_Sexe"
        Me.grpEtu_Sexe.Size = New System.Drawing.Size(138, 101)
        Me.grpEtu_Sexe.TabIndex = 8
        Me.grpEtu_Sexe.TabStop = False
        Me.grpEtu_Sexe.Text = "Sexe"
        '
        'lbletuTelephone
        '
        Me.lbletuTelephone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbletuTelephone.Location = New System.Drawing.Point(512, 219)
        Me.lbletuTelephone.Name = "lbletuTelephone"
        Me.lbletuTelephone.Size = New System.Drawing.Size(146, 32)
        Me.lbletuTelephone.TabIndex = 18
        Me.lbletuTelephone.Text = "Téléphone :"
        Me.lbletuTelephone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbletuCodePostal
        '
        Me.lbletuCodePostal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbletuCodePostal.Location = New System.Drawing.Point(512, 174)
        Me.lbletuCodePostal.Name = "lbletuCodePostal"
        Me.lbletuCodePostal.Size = New System.Drawing.Size(146, 32)
        Me.lbletuCodePostal.TabIndex = 16
        Me.lbletuCodePostal.Text = "Code Postal :"
        Me.lbletuCodePostal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbletuProvince
        '
        Me.lbletuProvince.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbletuProvince.Location = New System.Drawing.Point(512, 128)
        Me.lbletuProvince.Name = "lbletuProvince"
        Me.lbletuProvince.Size = New System.Drawing.Size(146, 32)
        Me.lbletuProvince.TabIndex = 14
        Me.lbletuProvince.Text = "Province :"
        Me.lbletuProvince.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbletuVille
        '
        Me.lbletuVille.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbletuVille.Location = New System.Drawing.Point(512, 83)
        Me.lbletuVille.Name = "lbletuVille"
        Me.lbletuVille.Size = New System.Drawing.Size(146, 32)
        Me.lbletuVille.TabIndex = 12
        Me.lbletuVille.Text = "Ville :"
        Me.lbletuVille.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbletuAdresse
        '
        Me.lbletuAdresse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbletuAdresse.Location = New System.Drawing.Point(512, 39)
        Me.lbletuAdresse.Name = "lbletuAdresse"
        Me.lbletuAdresse.Size = New System.Drawing.Size(146, 32)
        Me.lbletuAdresse.TabIndex = 10
        Me.lbletuAdresse.Text = "Adresse :"
        Me.lbletuAdresse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbletuNom
        '
        Me.lbletuNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbletuNom.Location = New System.Drawing.Point(30, 171)
        Me.lbletuNom.Name = "lbletuNom"
        Me.lbletuNom.Size = New System.Drawing.Size(146, 32)
        Me.lbletuNom.TabIndex = 6
        Me.lbletuNom.Text = "Nom :"
        Me.lbletuNom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbletuDA
        '
        Me.lbletuDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbletuDA.Location = New System.Drawing.Point(30, 36)
        Me.lbletuDA.Name = "lbletuDA"
        Me.lbletuDA.Size = New System.Drawing.Size(146, 32)
        Me.lbletuDA.TabIndex = 0
        Me.lbletuDA.Text = "DA :"
        Me.lbletuDA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grpEtudiant
        '
        Me.grpEtudiant.Controls.Add(Me.txtSexe)
        Me.grpEtudiant.Controls.Add(Me.mskEtu_Telephone)
        Me.grpEtudiant.Controls.Add(Me.mskEtu_CodePostal)
        Me.grpEtudiant.Controls.Add(Me.txtEtu_Ville)
        Me.grpEtudiant.Controls.Add(Me.txtEtu_Adresse)
        Me.grpEtudiant.Controls.Add(Me.txtEtu_Prenom)
        Me.grpEtudiant.Controls.Add(Me.txtEtu_Nom)
        Me.grpEtudiant.Controls.Add(Me.cboEtu_Province)
        Me.grpEtudiant.Controls.Add(Me.cboPro_No)
        Me.grpEtudiant.Controls.Add(Me.mskEtu_da)
        Me.grpEtudiant.Controls.Add(Me.grpEtu_Sexe)
        Me.grpEtudiant.Controls.Add(Me.lbletuTelephone)
        Me.grpEtudiant.Controls.Add(Me.lbletuCodePostal)
        Me.grpEtudiant.Controls.Add(Me.lbletuProvince)
        Me.grpEtudiant.Controls.Add(Me.lbletuVille)
        Me.grpEtudiant.Controls.Add(Me.lbletuAdresse)
        Me.grpEtudiant.Controls.Add(Me.lbletuNom)
        Me.grpEtudiant.Controls.Add(Me.lbletuPrenom)
        Me.grpEtudiant.Controls.Add(Me.lbletuNoProg)
        Me.grpEtudiant.Controls.Add(Me.lbletuDA)
        Me.grpEtudiant.Location = New System.Drawing.Point(28, 109)
        Me.grpEtudiant.Name = "grpEtudiant"
        Me.grpEtudiant.Size = New System.Drawing.Size(1060, 320)
        Me.grpEtudiant.TabIndex = 0
        Me.grpEtudiant.TabStop = False
        Me.grpEtudiant.Text = "Étudiant"
        '
        'txtSexe
        '
        Me.txtSexe.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsEtudiants, "etu_sexe", True))
        Me.txtSexe.Location = New System.Drawing.Point(138, 239)
        Me.txtSexe.Name = "txtSexe"
        Me.txtSexe.Size = New System.Drawing.Size(40, 27)
        Me.txtSexe.TabIndex = 9
        '
        'lbletuPrenom
        '
        Me.lbletuPrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbletuPrenom.Location = New System.Drawing.Point(30, 125)
        Me.lbletuPrenom.Name = "lbletuPrenom"
        Me.lbletuPrenom.Size = New System.Drawing.Size(146, 32)
        Me.lbletuPrenom.TabIndex = 4
        Me.lbletuPrenom.Text = "Prénom :"
        Me.lbletuPrenom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbletuNoProg
        '
        Me.lbletuNoProg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbletuNoProg.Location = New System.Drawing.Point(30, 80)
        Me.lbletuNoProg.Name = "lbletuNoProg"
        Me.lbletuNoProg.Size = New System.Drawing.Size(146, 32)
        Me.lbletuNoProg.TabIndex = 2
        Me.lbletuNoProg.Text = "No Prog :"
        Me.lbletuNoProg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgEtudiants
        '
        Me.dgEtudiants.AllowUserToAddRows = False
        Me.dgEtudiants.AllowUserToDeleteRows = False
        Me.dgEtudiants.AutoGenerateColumns = False
        Me.dgEtudiants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgEtudiants.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgEtudiants.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgEtudiants.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.dgEtudiants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEtudiants.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EtudaDataGridViewTextBoxColumn, Me.PronoDataGridViewTextBoxColumn, Me.EtunomDataGridViewTextBoxColumn, Me.EtuprenomDataGridViewTextBoxColumn, Me.EtusexeDataGridViewTextBoxColumn, Me.EtuadresseDataGridViewTextBoxColumn, Me.EtuvilleDataGridViewTextBoxColumn, Me.EtuprovinceDataGridViewTextBoxColumn, Me.EtutelephoneDataGridViewTextBoxColumn, Me.EtucodepostalDataGridViewTextBoxColumn})
        Me.dgEtudiants.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgEtudiants.DataSource = Me.bsEtudiants
        Me.dgEtudiants.GridColor = System.Drawing.Color.CornflowerBlue
        Me.dgEtudiants.Location = New System.Drawing.Point(28, 456)
        Me.dgEtudiants.MultiSelect = False
        Me.dgEtudiants.Name = "dgEtudiants"
        Me.dgEtudiants.ReadOnly = True
        Me.dgEtudiants.RowHeadersWidth = 51
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgEtudiants.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgEtudiants.RowTemplate.Height = 24
        Me.dgEtudiants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgEtudiants.Size = New System.Drawing.Size(1302, 386)
        Me.dgEtudiants.TabIndex = 2
        '
        'EtudaDataGridViewTextBoxColumn
        '
        Me.EtudaDataGridViewTextBoxColumn.DataPropertyName = "etu_da"
        Me.EtudaDataGridViewTextBoxColumn.HeaderText = "DA"
        Me.EtudaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EtudaDataGridViewTextBoxColumn.Name = "EtudaDataGridViewTextBoxColumn"
        Me.EtudaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PronoDataGridViewTextBoxColumn
        '
        Me.PronoDataGridViewTextBoxColumn.DataPropertyName = "pro_no"
        Me.PronoDataGridViewTextBoxColumn.HeaderText = "No Prog."
        Me.PronoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PronoDataGridViewTextBoxColumn.Name = "PronoDataGridViewTextBoxColumn"
        Me.PronoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EtunomDataGridViewTextBoxColumn
        '
        Me.EtunomDataGridViewTextBoxColumn.DataPropertyName = "etu_nom"
        Me.EtunomDataGridViewTextBoxColumn.HeaderText = "Nom"
        Me.EtunomDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EtunomDataGridViewTextBoxColumn.Name = "EtunomDataGridViewTextBoxColumn"
        Me.EtunomDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EtuprenomDataGridViewTextBoxColumn
        '
        Me.EtuprenomDataGridViewTextBoxColumn.DataPropertyName = "etu_prenom"
        Me.EtuprenomDataGridViewTextBoxColumn.HeaderText = "Prenom"
        Me.EtuprenomDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EtuprenomDataGridViewTextBoxColumn.Name = "EtuprenomDataGridViewTextBoxColumn"
        Me.EtuprenomDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EtusexeDataGridViewTextBoxColumn
        '
        Me.EtusexeDataGridViewTextBoxColumn.DataPropertyName = "etu_sexe"
        Me.EtusexeDataGridViewTextBoxColumn.HeaderText = "Sexe"
        Me.EtusexeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EtusexeDataGridViewTextBoxColumn.Name = "EtusexeDataGridViewTextBoxColumn"
        Me.EtusexeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EtuadresseDataGridViewTextBoxColumn
        '
        Me.EtuadresseDataGridViewTextBoxColumn.DataPropertyName = "etu_adresse"
        Me.EtuadresseDataGridViewTextBoxColumn.HeaderText = "Adresse"
        Me.EtuadresseDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EtuadresseDataGridViewTextBoxColumn.Name = "EtuadresseDataGridViewTextBoxColumn"
        Me.EtuadresseDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EtuvilleDataGridViewTextBoxColumn
        '
        Me.EtuvilleDataGridViewTextBoxColumn.DataPropertyName = "etu_ville"
        Me.EtuvilleDataGridViewTextBoxColumn.HeaderText = "Ville"
        Me.EtuvilleDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EtuvilleDataGridViewTextBoxColumn.Name = "EtuvilleDataGridViewTextBoxColumn"
        Me.EtuvilleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EtuprovinceDataGridViewTextBoxColumn
        '
        Me.EtuprovinceDataGridViewTextBoxColumn.DataPropertyName = "etu_province"
        Me.EtuprovinceDataGridViewTextBoxColumn.HeaderText = "Province"
        Me.EtuprovinceDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EtuprovinceDataGridViewTextBoxColumn.Name = "EtuprovinceDataGridViewTextBoxColumn"
        Me.EtuprovinceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EtutelephoneDataGridViewTextBoxColumn
        '
        Me.EtutelephoneDataGridViewTextBoxColumn.DataPropertyName = "etu_telephone"
        Me.EtutelephoneDataGridViewTextBoxColumn.HeaderText = "Téléphone"
        Me.EtutelephoneDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EtutelephoneDataGridViewTextBoxColumn.Name = "EtutelephoneDataGridViewTextBoxColumn"
        Me.EtutelephoneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EtucodepostalDataGridViewTextBoxColumn
        '
        Me.EtucodepostalDataGridViewTextBoxColumn.DataPropertyName = "etu_codepostal"
        Me.EtucodepostalDataGridViewTextBoxColumn.HeaderText = "Code Postal"
        Me.EtucodepostalDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EtucodepostalDataGridViewTextBoxColumn.Name = "EtucodepostalDataGridViewTextBoxColumn"
        Me.EtucodepostalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT *" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM     T_etudiants"
        Me.SqlSelectCommand1.Connection = Me.cn
        '
        'cn
        '
        Me.cn.ConnectionString = "Data Source=MARIERLINASUS\SQLEXPRESS;Initial Catalog=tp_p44;Integrated Security=T" &
    "rue"
        Me.cn.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.cn
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@etu_da", System.Data.SqlDbType.VarChar, 0, "etu_da"), New System.Data.SqlClient.SqlParameter("@pro_no", System.Data.SqlDbType.VarChar, 0, "pro_no"), New System.Data.SqlClient.SqlParameter("@etu_nom", System.Data.SqlDbType.VarChar, 0, "etu_nom"), New System.Data.SqlClient.SqlParameter("@etu_prenom", System.Data.SqlDbType.VarChar, 0, "etu_prenom"), New System.Data.SqlClient.SqlParameter("@etu_sexe", System.Data.SqlDbType.[Char], 0, "etu_sexe"), New System.Data.SqlClient.SqlParameter("@etu_adresse", System.Data.SqlDbType.VarChar, 0, "etu_adresse"), New System.Data.SqlClient.SqlParameter("@etu_ville", System.Data.SqlDbType.VarChar, 0, "etu_ville"), New System.Data.SqlClient.SqlParameter("@etu_province", System.Data.SqlDbType.VarChar, 0, "etu_province"), New System.Data.SqlClient.SqlParameter("@etu_telephone", System.Data.SqlDbType.VarChar, 0, "etu_telephone"), New System.Data.SqlClient.SqlParameter("@etu_codepostal", System.Data.SqlDbType.VarChar, 0, "etu_codepostal")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.cn
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@etu_da", System.Data.SqlDbType.VarChar, 0, "etu_da"), New System.Data.SqlClient.SqlParameter("@pro_no", System.Data.SqlDbType.VarChar, 0, "pro_no"), New System.Data.SqlClient.SqlParameter("@etu_nom", System.Data.SqlDbType.VarChar, 0, "etu_nom"), New System.Data.SqlClient.SqlParameter("@etu_prenom", System.Data.SqlDbType.VarChar, 0, "etu_prenom"), New System.Data.SqlClient.SqlParameter("@etu_sexe", System.Data.SqlDbType.[Char], 0, "etu_sexe"), New System.Data.SqlClient.SqlParameter("@etu_adresse", System.Data.SqlDbType.VarChar, 0, "etu_adresse"), New System.Data.SqlClient.SqlParameter("@etu_ville", System.Data.SqlDbType.VarChar, 0, "etu_ville"), New System.Data.SqlClient.SqlParameter("@etu_province", System.Data.SqlDbType.VarChar, 0, "etu_province"), New System.Data.SqlClient.SqlParameter("@etu_telephone", System.Data.SqlDbType.VarChar, 0, "etu_telephone"), New System.Data.SqlClient.SqlParameter("@etu_codepostal", System.Data.SqlDbType.VarChar, 0, "etu_codepostal"), New System.Data.SqlClient.SqlParameter("@Original_etu_da", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_da", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_pro_no", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_no", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_etu_nom", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_nom", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_etu_prenom", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_prenom", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_sexe", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_sexe", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_sexe", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_sexe", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_adresse", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_adresse", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_adresse", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_adresse", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_ville", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_ville", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_ville", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_ville", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_province", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_province", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_province", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_province", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_telephone", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_telephone", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_telephone", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_telephone", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_codepostal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_codepostal", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_codepostal", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_codepostal", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.cn
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_etu_da", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_da", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_pro_no", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_no", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_etu_nom", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_nom", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_etu_prenom", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_prenom", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_sexe", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_sexe", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_sexe", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_sexe", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_adresse", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_adresse", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_adresse", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_adresse", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_ville", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_ville", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_ville", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_ville", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_province", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_province", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_province", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_province", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_telephone", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_telephone", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_telephone", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_telephone", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_etu_codepostal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "etu_codepostal", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_etu_codepostal", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "etu_codepostal", System.Data.DataRowVersion.Original, Nothing)})
        '
        'daEtudiants
        '
        Me.daEtudiants.DeleteCommand = Me.SqlDeleteCommand1
        Me.daEtudiants.InsertCommand = Me.SqlInsertCommand1
        Me.daEtudiants.SelectCommand = Me.SqlSelectCommand1
        Me.daEtudiants.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "T_etudiants", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("etu_da", "etu_da"), New System.Data.Common.DataColumnMapping("pro_no", "pro_no"), New System.Data.Common.DataColumnMapping("etu_nom", "etu_nom"), New System.Data.Common.DataColumnMapping("etu_prenom", "etu_prenom"), New System.Data.Common.DataColumnMapping("etu_sexe", "etu_sexe"), New System.Data.Common.DataColumnMapping("etu_adresse", "etu_adresse"), New System.Data.Common.DataColumnMapping("etu_ville", "etu_ville"), New System.Data.Common.DataColumnMapping("etu_province", "etu_province"), New System.Data.Common.DataColumnMapping("etu_telephone", "etu_telephone"), New System.Data.Common.DataColumnMapping("etu_codepostal", "etu_codepostal")})})
        Me.daEtudiants.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT *" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM     T_programme"
        Me.SqlSelectCommand2.Connection = Me.cn
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Connection = Me.cn
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@pro_no", System.Data.SqlDbType.VarChar, 0, "pro_no"), New System.Data.SqlClient.SqlParameter("@pro_nom", System.Data.SqlDbType.VarChar, 0, "pro_nom"), New System.Data.SqlClient.SqlParameter("@pro_nbr_unites", System.Data.SqlDbType.Float, 0, "pro_nbr_unites"), New System.Data.SqlClient.SqlParameter("@pro_nbr_heures", System.Data.SqlDbType.Int, 0, "pro_nbr_heures")})
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Connection = Me.cn
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@pro_no", System.Data.SqlDbType.VarChar, 0, "pro_no"), New System.Data.SqlClient.SqlParameter("@pro_nom", System.Data.SqlDbType.VarChar, 0, "pro_nom"), New System.Data.SqlClient.SqlParameter("@pro_nbr_unites", System.Data.SqlDbType.Float, 0, "pro_nbr_unites"), New System.Data.SqlClient.SqlParameter("@pro_nbr_heures", System.Data.SqlDbType.Int, 0, "pro_nbr_heures"), New System.Data.SqlClient.SqlParameter("@Original_pro_no", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_no", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_pro_nom", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_nom", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_pro_nbr_unites", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_nbr_unites", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pro_nbr_heures", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pro_nbr_heures", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pro_nbr_heures", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_nbr_heures", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = resources.GetString("SqlDeleteCommand2.CommandText")
        Me.SqlDeleteCommand2.Connection = Me.cn
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_pro_no", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_no", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_pro_nom", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_nom", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_pro_nbr_unites", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_nbr_unites", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_pro_nbr_heures", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "pro_nbr_heures", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_pro_nbr_heures", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "pro_nbr_heures", System.Data.DataRowVersion.Original, Nothing)})
        '
        'daProg
        '
        Me.daProg.DeleteCommand = Me.SqlDeleteCommand2
        Me.daProg.InsertCommand = Me.SqlInsertCommand2
        Me.daProg.SelectCommand = Me.SqlSelectCommand2
        Me.daProg.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "T_programme", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("pro_no", "pro_no"), New System.Data.Common.DataColumnMapping("pro_nom", "pro_nom"), New System.Data.Common.DataColumnMapping("pro_nbr_unites", "pro_nbr_unites"), New System.Data.Common.DataColumnMapping("pro_nbr_heures", "pro_nbr_heures")})})
        Me.daProg.UpdateCommand = Me.SqlUpdateCommand2
        '
        'frmEtudiants
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1367, 854)
        Me.Controls.Add(Me.dgEtudiants)
        Me.Controls.Add(Me.lblecole)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.grpAction)
        Me.Controls.Add(Me.grpEtudiant)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmEtudiants"
        Me.Tag = "Chicoutimi"
        Me.Text = "Gestion des étudiants"
        CType(Me.bsEtudiants, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Err1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAction.ResumeLayout(False)
        CType(Me.bsProg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEtu_Sexe.ResumeLayout(False)
        Me.grpEtu_Sexe.PerformLayout()
        Me.grpEtudiant.ResumeLayout(False)
        Me.grpEtudiant.PerformLayout()
        CType(Me.dgEtudiants, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents optEtu_Feminin As RadioButton
    Friend WithEvents cmdModifier As Button
    Friend WithEvents mskEtu_CodePostal As MaskedTextBox
    Friend WithEvents txtEtu_Ville As TextBox
    Friend WithEvents txtEtu_Adresse As TextBox
    Friend WithEvents txtEtu_Prenom As TextBox
    Friend WithEvents txtEtu_Nom As TextBox
    Friend WithEvents cboEtu_Province As ComboBox
    Friend WithEvents cmdOK As Button
    Friend WithEvents cmdAnnuler As Button
    Friend WithEvents mskEtu_Telephone As MaskedTextBox
    Friend WithEvents cmdNouveau As Button
    Friend WithEvents cmdEnlever As Button
    Friend WithEvents dgEtudiants As DataGridView
    Friend WithEvents Err1 As ErrorProvider
    Friend WithEvents lblecole As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents grpAction As GroupBox
    Friend WithEvents grpEtudiant As GroupBox
    Friend WithEvents cboPro_No As ComboBox
    Friend WithEvents mskEtu_da As MaskedTextBox
    Friend WithEvents grpEtu_Sexe As GroupBox
    Friend WithEvents optEtu_Masculin As RadioButton
    Friend WithEvents lbletuTelephone As Label
    Friend WithEvents lbletuCodePostal As Label
    Friend WithEvents lbletuProvince As Label
    Friend WithEvents lbletuVille As Label
    Friend WithEvents lbletuAdresse As Label
    Friend WithEvents lbletuNom As Label
    Friend WithEvents lbletuPrenom As Label
    Friend WithEvents lbletuNoProg As Label
    Friend WithEvents lbletuDA As Label
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents cn As SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
    Friend WithEvents daEtudiants As SqlClient.SqlDataAdapter
    Friend WithEvents Ds1 As DS
    Friend WithEvents bsEtudiants As BindingSource
    Friend WithEvents EtudaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PronoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtunomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtuprenomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtusexeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtuadresseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtuvilleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtuprovinceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtutelephoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtucodepostalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txtSexe As TextBox
    Friend WithEvents SqlSelectCommand2 As SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As SqlClient.SqlCommand
    Friend WithEvents daProg As SqlClient.SqlDataAdapter
    Friend WithEvents bsProg As BindingSource
End Class
