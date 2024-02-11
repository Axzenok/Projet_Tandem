namespace _2023_AppliTandem
{
    partial class FrmFiltre
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFiltre));
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.grbTrier = new System.Windows.Forms.GroupBox();
            this.cbbGenre = new System.Windows.Forms.ComboBox();
            this.cbbPrenom = new System.Windows.Forms.ComboBox();
            this.cbbVille = new System.Windows.Forms.ComboBox();
            this.cbbInscription = new System.Windows.Forms.ComboBox();
            this.cbbAge = new System.Windows.Forms.ComboBox();
            this.cbbNom = new System.Windows.Forms.ComboBox();
            this.grbFiltrer = new System.Windows.Forms.GroupBox();
            this.tblpBoite = new System.Windows.Forms.TableLayoutPanel();
            this.rdbBoiteAuto = new System.Windows.Forms.RadioButton();
            this.rdbBoiteManuelle = new System.Windows.Forms.RadioButton();
            this.tblpConduite = new System.Windows.Forms.TableLayoutPanel();
            this.rdbConduiteAccompagnee = new System.Windows.Forms.RadioButton();
            this.rdbConduiteSupervisee = new System.Windows.Forms.RadioButton();
            this.rdbApprofondissement = new System.Windows.Forms.RadioButton();
            this.tblpDebutant = new System.Windows.Forms.TableLayoutPanel();
            this.rdbEleveDebutant = new System.Windows.Forms.RadioButton();
            this.rdbEleveFinFormation = new System.Windows.Forms.RadioButton();
            this.tblpInscrit = new System.Windows.Forms.TableLayoutPanel();
            this.rdbEleveInscrit = new System.Windows.Forms.RadioButton();
            this.rdbEleveArchive = new System.Windows.Forms.RadioButton();
            this.tblpActif = new System.Windows.Forms.TableLayoutPanel();
            this.rdbEleveActif = new System.Windows.Forms.RadioButton();
            this.rdbEleveInactif = new System.Windows.Forms.RadioButton();
            this.rdbExamProgramme = new System.Windows.Forms.RadioButton();
            this.lblFiltre = new System.Windows.Forms.Label();
            this.txtRechercheAvancee = new System.Windows.Forms.TextBox();
            this.grbRecherche = new System.Windows.Forms.GroupBox();
            this.btnEffacerRecherche = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.listBoxAvancee = new System.Windows.Forms.ListBox();
            this.btnEnvoyer = new System.Windows.Forms.Button();
            this.grbTrier.SuspendLayout();
            this.grbFiltrer.SuspendLayout();
            this.tblpBoite.SuspendLayout();
            this.tblpConduite.SuspendLayout();
            this.tblpDebutant.SuspendLayout();
            this.tblpInscrit.SuspendLayout();
            this.tblpActif.SuspendLayout();
            this.grbRecherche.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.Salmon;
            this.btnRetour.Location = new System.Drawing.Point(338, 806);
            this.btnRetour.Margin = new System.Windows.Forms.Padding(4);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(168, 26);
            this.btnRetour.TabIndex = 0;
            this.btnRetour.Text = "Annuler";
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(11, 799);
            this.btnRechercher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(132, 34);
            this.btnRechercher.TabIndex = 1;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // btnEffacer
            // 
            this.btnEffacer.Location = new System.Drawing.Point(157, 799);
            this.btnEffacer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(132, 34);
            this.btnEffacer.TabIndex = 2;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.UseVisualStyleBackColor = true;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // grbTrier
            // 
            this.grbTrier.Controls.Add(this.cbbGenre);
            this.grbTrier.Controls.Add(this.cbbPrenom);
            this.grbTrier.Controls.Add(this.cbbVille);
            this.grbTrier.Controls.Add(this.cbbInscription);
            this.grbTrier.Controls.Add(this.cbbAge);
            this.grbTrier.Controls.Add(this.cbbNom);
            this.grbTrier.Location = new System.Drawing.Point(38, 191);
            this.grbTrier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbTrier.Name = "grbTrier";
            this.grbTrier.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbTrier.Size = new System.Drawing.Size(486, 232);
            this.grbTrier.TabIndex = 4;
            this.grbTrier.TabStop = false;
            this.grbTrier.Text = "Trier";
            // 
            // cbbGenre
            // 
            this.cbbGenre.FormattingEnabled = true;
            this.cbbGenre.Items.AddRange(new object[] {
            "Femme - Homme",
            "Homme - Femme"});
            this.cbbGenre.Location = new System.Drawing.Point(235, 77);
            this.cbbGenre.Name = "cbbGenre";
            this.cbbGenre.Size = new System.Drawing.Size(181, 24);
            this.cbbGenre.TabIndex = 5;
            this.cbbGenre.Text = "Trier par genre";
            this.cbbGenre.SelectedIndexChanged += new System.EventHandler(this.cbbGenre_SelectedIndexChanged);
            // 
            // cbbPrenom
            // 
            this.cbbPrenom.FormattingEnabled = true;
            this.cbbPrenom.Items.AddRange(new object[] {
            "De A à Z",
            "De Z à A"});
            this.cbbPrenom.Location = new System.Drawing.Point(235, 36);
            this.cbbPrenom.Name = "cbbPrenom";
            this.cbbPrenom.Size = new System.Drawing.Size(181, 24);
            this.cbbPrenom.TabIndex = 4;
            this.cbbPrenom.Text = "Trier par prénom";
            this.cbbPrenom.SelectedIndexChanged += new System.EventHandler(this.cbbPrenom_SelectedIndexChanged);
            // 
            // cbbVille
            // 
            this.cbbVille.FormattingEnabled = true;
            this.cbbVille.Items.AddRange(new object[] {
            "De A à Z",
            "De Z à A"});
            this.cbbVille.Location = new System.Drawing.Point(33, 132);
            this.cbbVille.Name = "cbbVille";
            this.cbbVille.Size = new System.Drawing.Size(151, 24);
            this.cbbVille.TabIndex = 3;
            this.cbbVille.Text = "Trier par ville";
            this.cbbVille.SelectedIndexChanged += new System.EventHandler(this.cbbVille_SelectedIndexChanged);
            // 
            // cbbInscription
            // 
            this.cbbInscription.FormattingEnabled = true;
            this.cbbInscription.Items.AddRange(new object[] {
            "De la plus récente à la plus ancienne",
            "De la plus ancienne à la plus récente"});
            this.cbbInscription.Location = new System.Drawing.Point(33, 176);
            this.cbbInscription.Name = "cbbInscription";
            this.cbbInscription.Size = new System.Drawing.Size(287, 24);
            this.cbbInscription.TabIndex = 2;
            this.cbbInscription.Text = "Trier par date d\'inscription";
            this.cbbInscription.SelectedIndexChanged += new System.EventHandler(this.cbbInscription_SelectedIndexChanged);
            // 
            // cbbAge
            // 
            this.cbbAge.FormattingEnabled = true;
            this.cbbAge.Items.AddRange(new object[] {
            "Du plus agé au plus jeune",
            "Du plus jeune au plus agé "});
            this.cbbAge.Location = new System.Drawing.Point(31, 80);
            this.cbbAge.Name = "cbbAge";
            this.cbbAge.Size = new System.Drawing.Size(153, 24);
            this.cbbAge.TabIndex = 1;
            this.cbbAge.Text = "Trier par âge";
            this.cbbAge.SelectedIndexChanged += new System.EventHandler(this.cbbAge_SelectedIndexChanged);
            // 
            // cbbNom
            // 
            this.cbbNom.FormattingEnabled = true;
            this.cbbNom.Items.AddRange(new object[] {
            "De A à Z",
            "De Z à A"});
            this.cbbNom.Location = new System.Drawing.Point(33, 36);
            this.cbbNom.Name = "cbbNom";
            this.cbbNom.Size = new System.Drawing.Size(151, 24);
            this.cbbNom.TabIndex = 0;
            this.cbbNom.Text = "Trier par nom";
            this.cbbNom.SelectedIndexChanged += new System.EventHandler(this.cbbNom_SelectedIndexChanged);
            // 
            // grbFiltrer
            // 
            this.grbFiltrer.Controls.Add(this.tblpBoite);
            this.grbFiltrer.Controls.Add(this.tblpConduite);
            this.grbFiltrer.Controls.Add(this.tblpDebutant);
            this.grbFiltrer.Controls.Add(this.tblpInscrit);
            this.grbFiltrer.Controls.Add(this.tblpActif);
            this.grbFiltrer.Controls.Add(this.rdbExamProgramme);
            this.grbFiltrer.Location = new System.Drawing.Point(38, 450);
            this.grbFiltrer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbFiltrer.Name = "grbFiltrer";
            this.grbFiltrer.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbFiltrer.Size = new System.Drawing.Size(486, 300);
            this.grbFiltrer.TabIndex = 5;
            this.grbFiltrer.TabStop = false;
            this.grbFiltrer.Text = "Filtrer";
            // 
            // tblpBoite
            // 
            this.tblpBoite.ColumnCount = 2;
            this.tblpBoite.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpBoite.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpBoite.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblpBoite.Controls.Add(this.rdbBoiteAuto, 1, 0);
            this.tblpBoite.Controls.Add(this.rdbBoiteManuelle, 0, 0);
            this.tblpBoite.Location = new System.Drawing.Point(26, 161);
            this.tblpBoite.Name = "tblpBoite";
            this.tblpBoite.RowCount = 1;
            this.tblpBoite.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpBoite.Size = new System.Drawing.Size(390, 28);
            this.tblpBoite.TabIndex = 16;
            // 
            // rdbBoiteAuto
            // 
            this.rdbBoiteAuto.AutoSize = true;
            this.rdbBoiteAuto.Location = new System.Drawing.Point(198, 3);
            this.rdbBoiteAuto.Name = "rdbBoiteAuto";
            this.rdbBoiteAuto.Size = new System.Drawing.Size(88, 20);
            this.rdbBoiteAuto.TabIndex = 17;
            this.rdbBoiteAuto.TabStop = true;
            this.rdbBoiteAuto.Text = "Boîte auto";
            this.rdbBoiteAuto.UseVisualStyleBackColor = true;
            // 
            // rdbBoiteManuelle
            // 
            this.rdbBoiteManuelle.AutoSize = true;
            this.rdbBoiteManuelle.Location = new System.Drawing.Point(3, 3);
            this.rdbBoiteManuelle.Name = "rdbBoiteManuelle";
            this.rdbBoiteManuelle.Size = new System.Drawing.Size(117, 20);
            this.rdbBoiteManuelle.TabIndex = 15;
            this.rdbBoiteManuelle.TabStop = true;
            this.rdbBoiteManuelle.Text = "Boîte manuelle";
            this.rdbBoiteManuelle.UseVisualStyleBackColor = true;
            // 
            // tblpConduite
            // 
            this.tblpConduite.ColumnCount = 3;
            this.tblpConduite.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tblpConduite.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tblpConduite.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tblpConduite.Controls.Add(this.rdbConduiteAccompagnee, 0, 0);
            this.tblpConduite.Controls.Add(this.rdbConduiteSupervisee, 1, 0);
            this.tblpConduite.Controls.Add(this.rdbApprofondissement, 2, 0);
            this.tblpConduite.Location = new System.Drawing.Point(26, 204);
            this.tblpConduite.Name = "tblpConduite";
            this.tblpConduite.RowCount = 1;
            this.tblpConduite.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpConduite.Size = new System.Drawing.Size(460, 27);
            this.tblpConduite.TabIndex = 14;
            // 
            // rdbConduiteAccompagnee
            // 
            this.rdbConduiteAccompagnee.Location = new System.Drawing.Point(3, 3);
            this.rdbConduiteAccompagnee.Name = "rdbConduiteAccompagnee";
            this.rdbConduiteAccompagnee.Size = new System.Drawing.Size(122, 20);
            this.rdbConduiteAccompagnee.TabIndex = 0;
            this.rdbConduiteAccompagnee.TabStop = true;
            this.rdbConduiteAccompagnee.Text = "Accompagnée";
            this.rdbConduiteAccompagnee.UseVisualStyleBackColor = true;
            // 
            // rdbConduiteSupervisee
            // 
            this.rdbConduiteSupervisee.Location = new System.Drawing.Point(154, 3);
            this.rdbConduiteSupervisee.Name = "rdbConduiteSupervisee";
            this.rdbConduiteSupervisee.Size = new System.Drawing.Size(122, 20);
            this.rdbConduiteSupervisee.TabIndex = 0;
            this.rdbConduiteSupervisee.TabStop = true;
            this.rdbConduiteSupervisee.Text = "Supervisée";
            this.rdbConduiteSupervisee.UseVisualStyleBackColor = true;
            // 
            // rdbApprofondissement
            // 
            this.rdbApprofondissement.AutoSize = true;
            this.rdbApprofondissement.Location = new System.Drawing.Point(305, 3);
            this.rdbApprofondissement.Name = "rdbApprofondissement";
            this.rdbApprofondissement.Size = new System.Drawing.Size(145, 20);
            this.rdbApprofondissement.TabIndex = 1;
            this.rdbApprofondissement.TabStop = true;
            this.rdbApprofondissement.Text = "Approfondissement";
            this.rdbApprofondissement.UseVisualStyleBackColor = true;
            // 
            // tblpDebutant
            // 
            this.tblpDebutant.ColumnCount = 2;
            this.tblpDebutant.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpDebutant.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpDebutant.Controls.Add(this.rdbEleveDebutant, 0, 0);
            this.tblpDebutant.Controls.Add(this.rdbEleveFinFormation, 1, 0);
            this.tblpDebutant.Location = new System.Drawing.Point(26, 117);
            this.tblpDebutant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tblpDebutant.Name = "tblpDebutant";
            this.tblpDebutant.RowCount = 1;
            this.tblpDebutant.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpDebutant.Size = new System.Drawing.Size(390, 24);
            this.tblpDebutant.TabIndex = 10;
            // 
            // rdbEleveDebutant
            // 
            this.rdbEleveDebutant.AutoSize = true;
            this.rdbEleveDebutant.Location = new System.Drawing.Point(3, 2);
            this.rdbEleveDebutant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbEleveDebutant.Name = "rdbEleveDebutant";
            this.rdbEleveDebutant.Size = new System.Drawing.Size(118, 20);
            this.rdbEleveDebutant.TabIndex = 5;
            this.rdbEleveDebutant.TabStop = true;
            this.rdbEleveDebutant.Text = "Elève débutant";
            this.rdbEleveDebutant.UseVisualStyleBackColor = true;
            // 
            // rdbEleveFinFormation
            // 
            this.rdbEleveFinFormation.AutoSize = true;
            this.rdbEleveFinFormation.Location = new System.Drawing.Point(198, 2);
            this.rdbEleveFinFormation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbEleveFinFormation.Name = "rdbEleveFinFormation";
            this.rdbEleveFinFormation.Size = new System.Drawing.Size(174, 20);
            this.rdbEleveFinFormation.TabIndex = 6;
            this.rdbEleveFinFormation.TabStop = true;
            this.rdbEleveFinFormation.Text = "Elève en fin de formation";
            this.rdbEleveFinFormation.UseVisualStyleBackColor = true;
            // 
            // tblpInscrit
            // 
            this.tblpInscrit.ColumnCount = 2;
            this.tblpInscrit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpInscrit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpInscrit.Controls.Add(this.rdbEleveInscrit, 0, 0);
            this.tblpInscrit.Controls.Add(this.rdbEleveArchive, 1, 0);
            this.tblpInscrit.Location = new System.Drawing.Point(26, 74);
            this.tblpInscrit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tblpInscrit.Name = "tblpInscrit";
            this.tblpInscrit.RowCount = 1;
            this.tblpInscrit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpInscrit.Size = new System.Drawing.Size(390, 29);
            this.tblpInscrit.TabIndex = 9;
            // 
            // rdbEleveInscrit
            // 
            this.rdbEleveInscrit.AutoSize = true;
            this.rdbEleveInscrit.Location = new System.Drawing.Point(3, 2);
            this.rdbEleveInscrit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbEleveInscrit.Name = "rdbEleveInscrit";
            this.rdbEleveInscrit.Size = new System.Drawing.Size(114, 20);
            this.rdbEleveInscrit.TabIndex = 2;
            this.rdbEleveInscrit.TabStop = true;
            this.rdbEleveInscrit.Text = "Elèves inscrits";
            this.rdbEleveInscrit.UseVisualStyleBackColor = true;
            // 
            // rdbEleveArchive
            // 
            this.rdbEleveArchive.AutoSize = true;
            this.rdbEleveArchive.Location = new System.Drawing.Point(198, 2);
            this.rdbEleveArchive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbEleveArchive.Name = "rdbEleveArchive";
            this.rdbEleveArchive.Size = new System.Drawing.Size(124, 20);
            this.rdbEleveArchive.TabIndex = 3;
            this.rdbEleveArchive.TabStop = true;
            this.rdbEleveArchive.Text = "Elèves archivés";
            this.rdbEleveArchive.UseVisualStyleBackColor = true;
            // 
            // tblpActif
            // 
            this.tblpActif.ColumnCount = 2;
            this.tblpActif.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpActif.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpActif.Controls.Add(this.rdbEleveActif, 0, 0);
            this.tblpActif.Controls.Add(this.rdbEleveInactif, 1, 0);
            this.tblpActif.Location = new System.Drawing.Point(26, 33);
            this.tblpActif.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tblpActif.Name = "tblpActif";
            this.tblpActif.RowCount = 1;
            this.tblpActif.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpActif.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tblpActif.Size = new System.Drawing.Size(390, 26);
            this.tblpActif.TabIndex = 8;
            // 
            // rdbEleveActif
            // 
            this.rdbEleveActif.AccessibleDescription = "";
            this.rdbEleveActif.AutoSize = true;
            this.rdbEleveActif.Location = new System.Drawing.Point(3, 2);
            this.rdbEleveActif.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbEleveActif.Name = "rdbEleveActif";
            this.rdbEleveActif.Size = new System.Drawing.Size(104, 20);
            this.rdbEleveActif.TabIndex = 0;
            this.rdbEleveActif.TabStop = true;
            this.rdbEleveActif.Text = "Elèves actifs";
            this.rdbEleveActif.UseVisualStyleBackColor = true;
            // 
            // rdbEleveInactif
            // 
            this.rdbEleveInactif.AutoSize = true;
            this.rdbEleveInactif.Location = new System.Drawing.Point(198, 2);
            this.rdbEleveInactif.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbEleveInactif.Name = "rdbEleveInactif";
            this.rdbEleveInactif.Size = new System.Drawing.Size(114, 20);
            this.rdbEleveInactif.TabIndex = 1;
            this.rdbEleveInactif.TabStop = true;
            this.rdbEleveInactif.Text = "Elèves inactifs";
            this.rdbEleveInactif.UseVisualStyleBackColor = true;
            // 
            // rdbExamProgramme
            // 
            this.rdbExamProgramme.AutoSize = true;
            this.rdbExamProgramme.Location = new System.Drawing.Point(29, 250);
            this.rdbExamProgramme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbExamProgramme.Name = "rdbExamProgramme";
            this.rdbExamProgramme.Size = new System.Drawing.Size(150, 20);
            this.rdbExamProgramme.TabIndex = 4;
            this.rdbExamProgramme.TabStop = true;
            this.rdbExamProgramme.Text = "Examen programmé";
            this.rdbExamProgramme.UseVisualStyleBackColor = true;
            // 
            // lblFiltre
            // 
            this.lblFiltre.AutoSize = true;
            this.lblFiltre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltre.Location = new System.Drawing.Point(110, 24);
            this.lblFiltre.Name = "lblFiltre";
            this.lblFiltre.Size = new System.Drawing.Size(276, 31);
            this.lblFiltre.TabIndex = 0;
            this.lblFiltre.Text = "Recherche Avancée";
            this.lblFiltre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtRechercheAvancee
            // 
            this.txtRechercheAvancee.Location = new System.Drawing.Point(18, 30);
            this.txtRechercheAvancee.Name = "txtRechercheAvancee";
            this.txtRechercheAvancee.Size = new System.Drawing.Size(427, 22);
            this.txtRechercheAvancee.TabIndex = 6;
            this.txtRechercheAvancee.WordWrap = false;
            // 
            // grbRecherche
            // 
            this.grbRecherche.Controls.Add(this.btnEffacerRecherche);
            this.grbRecherche.Controls.Add(this.btnValider);
            this.grbRecherche.Controls.Add(this.txtRechercheAvancee);
            this.grbRecherche.Location = new System.Drawing.Point(20, 79);
            this.grbRecherche.Name = "grbRecherche";
            this.grbRecherche.Size = new System.Drawing.Size(504, 94);
            this.grbRecherche.TabIndex = 8;
            this.grbRecherche.TabStop = false;
            this.grbRecherche.Text = "Barre de recherche avancée";
            // 
            // btnEffacerRecherche
            // 
            this.btnEffacerRecherche.Location = new System.Drawing.Point(171, 58);
            this.btnEffacerRecherche.Name = "btnEffacerRecherche";
            this.btnEffacerRecherche.Size = new System.Drawing.Size(147, 25);
            this.btnEffacerRecherche.TabIndex = 8;
            this.btnEffacerRecherche.Text = "Effacer";
            this.btnEffacerRecherche.UseVisualStyleBackColor = true;
            this.btnEffacerRecherche.Click += new System.EventHandler(this.btnEffacerRecherche_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(18, 58);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(147, 25);
            this.btnValider.TabIndex = 7;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // listBoxAvancee
            // 
            this.listBoxAvancee.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAvancee.FormattingEnabled = true;
            this.listBoxAvancee.ItemHeight = 29;
            this.listBoxAvancee.Location = new System.Drawing.Point(578, 79);
            this.listBoxAvancee.Name = "listBoxAvancee";
            this.listBoxAvancee.Size = new System.Drawing.Size(546, 671);
            this.listBoxAvancee.TabIndex = 9;
            // 
            // btnEnvoyer
            // 
            this.btnEnvoyer.Location = new System.Drawing.Point(300, 762);
            this.btnEnvoyer.Name = "btnEnvoyer";
            this.btnEnvoyer.Size = new System.Drawing.Size(125, 37);
            this.btnEnvoyer.TabIndex = 10;
            this.btnEnvoyer.Text = "Envoyer";
            this.btnEnvoyer.UseVisualStyleBackColor = true;
            this.btnEnvoyer.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // FrmFiltre
            // 
            this.AcceptButton = this.btnRechercher;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1182, 854);
            this.ControlBox = false;
            this.Controls.Add(this.btnEnvoyer);
            this.Controls.Add(this.listBoxAvancee);
            this.Controls.Add(this.grbRecherche);
            this.Controls.Add(this.lblFiltre);
            this.Controls.Add(this.grbFiltrer);
            this.Controls.Add(this.grbTrier);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.btnRetour);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(510, 203);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1527, 913);
            this.MinimumSize = new System.Drawing.Size(527, 872);
            this.Name = "FrmFiltre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Liste des filtres";
            this.Load += new System.EventHandler(this.FrmFiltre_Load);
            this.grbTrier.ResumeLayout(false);
            this.grbFiltrer.ResumeLayout(false);
            this.grbFiltrer.PerformLayout();
            this.tblpBoite.ResumeLayout(false);
            this.tblpBoite.PerformLayout();
            this.tblpConduite.ResumeLayout(false);
            this.tblpConduite.PerformLayout();
            this.tblpDebutant.ResumeLayout(false);
            this.tblpDebutant.PerformLayout();
            this.tblpInscrit.ResumeLayout(false);
            this.tblpInscrit.PerformLayout();
            this.tblpActif.ResumeLayout(false);
            this.tblpActif.PerformLayout();
            this.grbRecherche.ResumeLayout(false);
            this.grbRecherche.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.GroupBox grbTrier;
        private System.Windows.Forms.GroupBox grbFiltrer;
        private System.Windows.Forms.RadioButton rdbEleveDebutant;
        private System.Windows.Forms.RadioButton rdbExamProgramme;
        private System.Windows.Forms.RadioButton rdbEleveArchive;
        private System.Windows.Forms.RadioButton rdbEleveInscrit;
        private System.Windows.Forms.RadioButton rdbEleveInactif;
        private System.Windows.Forms.RadioButton rdbEleveActif;
        private System.Windows.Forms.RadioButton rdbEleveFinFormation;
        private System.Windows.Forms.TableLayoutPanel tblpActif;
        private System.Windows.Forms.TableLayoutPanel tblpDebutant;
        private System.Windows.Forms.TableLayoutPanel tblpInscrit;
        private System.Windows.Forms.Label lblFiltre;
        private System.Windows.Forms.ComboBox cbbNom;
        private System.Windows.Forms.ComboBox cbbPrenom;
        private System.Windows.Forms.ComboBox cbbVille;
        private System.Windows.Forms.ComboBox cbbInscription;
        private System.Windows.Forms.ComboBox cbbAge;
        private System.Windows.Forms.ComboBox cbbGenre;
        private System.Windows.Forms.RadioButton rdbConduiteAccompagnee;
        private System.Windows.Forms.TableLayoutPanel tblpConduite;
        private System.Windows.Forms.RadioButton rdbConduiteSupervisee;
        private System.Windows.Forms.TextBox txtRechercheAvancee;
        private System.Windows.Forms.TableLayoutPanel tblpBoite;
        private System.Windows.Forms.RadioButton rdbBoiteAuto;
        private System.Windows.Forms.RadioButton rdbBoiteManuelle;
        private System.Windows.Forms.GroupBox grbRecherche;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnEffacerRecherche;
        private System.Windows.Forms.ListBox listBoxAvancee;
        private System.Windows.Forms.Button btnEnvoyer;
        private System.Windows.Forms.RadioButton rdbApprofondissement;
    }
}