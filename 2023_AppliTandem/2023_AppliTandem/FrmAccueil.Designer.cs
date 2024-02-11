namespace _2023_AppliTandem
{
    partial class FrmAccueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAccueil));
            this.grpBxListeEleve = new System.Windows.Forms.GroupBox();
            this.btnAjouterEleve = new System.Windows.Forms.Button();
            this.btnFiltres = new System.Windows.Forms.Button();
            this.btnEffacerFiltres = new System.Windows.Forms.Button();
            this.lstBxListeEleves = new System.Windows.Forms.ListBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.txtRechercher = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpBxInformations = new System.Windows.Forms.GroupBox();
            this.grpBxCPF = new System.Windows.Forms.GroupBox();
            this.txtDateFinCPF = new System.Windows.Forms.TextBox();
            this.txtDateDebutCPF = new System.Windows.Forms.TextBox();
            this.txtTarifCPF = new System.Windows.Forms.TextBox();
            this.txtNbHeuresCPF = new System.Windows.Forms.TextBox();
            this.lblDateFinCPF = new System.Windows.Forms.Label();
            this.lblDateDébutCPF = new System.Windows.Forms.Label();
            this.lblTarifCPF = new System.Windows.Forms.Label();
            this.txtNumCPF = new System.Windows.Forms.TextBox();
            this.lblNbHeuresCPF = new System.Windows.Forms.Label();
            this.lblNumCPF = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblControle = new System.Windows.Forms.Label();
            this.btnArchiverEleve = new System.Windows.Forms.Button();
            this.btnSupprimerEleve = new System.Windows.Forms.Button();
            this.txtHandicap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtSexe = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblSexe = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.pctBxPhotoEleve = new System.Windows.Forms.PictureBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtDateNaissance = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtNumNeph = new System.Windows.Forms.TextBox();
            this.btnAnnulerModif = new System.Windows.Forms.Button();
            this.btnValiderModif = new System.Windows.Forms.Button();
            this.btnModifInfos = new System.Windows.Forms.Button();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblNumNeph = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblDateNaissance = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtEleveSelectionne = new System.Windows.Forms.TextBox();
            this.chkLstBxDateHeures = new System.Windows.Forms.CheckedListBox();
            this.grpBxHeure = new System.Windows.Forms.GroupBox();
            this.cbbEtatHeure = new System.Windows.Forms.ComboBox();
            this.btnMajEtatHeure = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRetirerHeure = new System.Windows.Forms.Button();
            this.btnAjouterHeure = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblEtaHeure = new System.Windows.Forms.Label();
            this.cbxCorrectionVision = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.grpBxListeEleve.SuspendLayout();
            this.grpBxInformations.SuspendLayout();
            this.grpBxCPF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBxPhotoEleve)).BeginInit();
            this.grpBxHeure.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBxListeEleve
            // 
            this.grpBxListeEleve.Controls.Add(this.btnAjouterEleve);
            this.grpBxListeEleve.Controls.Add(this.btnFiltres);
            this.grpBxListeEleve.Controls.Add(this.btnEffacerFiltres);
            this.grpBxListeEleve.Controls.Add(this.lstBxListeEleves);
            this.grpBxListeEleve.Controls.Add(this.btnRechercher);
            this.grpBxListeEleve.Controls.Add(this.txtRechercher);
            resources.ApplyResources(this.grpBxListeEleve, "grpBxListeEleve");
            this.grpBxListeEleve.Name = "grpBxListeEleve";
            this.grpBxListeEleve.TabStop = false;
            // 
            // btnAjouterEleve
            // 
            resources.ApplyResources(this.btnAjouterEleve, "btnAjouterEleve");
            this.btnAjouterEleve.Name = "btnAjouterEleve";
            this.btnAjouterEleve.UseVisualStyleBackColor = true;
            this.btnAjouterEleve.Click += new System.EventHandler(this.btnAjouterEleve_Click);
            // 
            // btnFiltres
            // 
            this.btnFiltres.BackgroundImage = global::_2023_AppliTandem.Properties.Resources.imgFiltre;
            resources.ApplyResources(this.btnFiltres, "btnFiltres");
            this.btnFiltres.Name = "btnFiltres";
            this.btnFiltres.UseVisualStyleBackColor = true;
            this.btnFiltres.Click += new System.EventHandler(this.btnFiltres_Click);
            // 
            // btnEffacerFiltres
            // 
            resources.ApplyResources(this.btnEffacerFiltres, "btnEffacerFiltres");
            this.btnEffacerFiltres.Name = "btnEffacerFiltres";
            this.btnEffacerFiltres.UseVisualStyleBackColor = true;
            this.btnEffacerFiltres.Click += new System.EventHandler(this.btnEffacerFiltres_Click);
            // 
            // lstBxListeEleves
            // 
            resources.ApplyResources(this.lstBxListeEleves, "lstBxListeEleves");
            this.lstBxListeEleves.FormattingEnabled = true;
            this.lstBxListeEleves.Name = "lstBxListeEleves";
            this.lstBxListeEleves.SelectedIndexChanged += new System.EventHandler(this.lstBxListeEleves_SelectedIndexChanged);
            // 
            // btnRechercher
            // 
            resources.ApplyResources(this.btnRechercher, "btnRechercher");
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // txtRechercher
            // 
            resources.ApplyResources(this.txtRechercher, "txtRechercher");
            this.txtRechercher.Name = "txtRechercher";
            // 
            // grpBxInformations
            // 
            this.grpBxInformations.Controls.Add(this.checkBox6);
            this.grpBxInformations.Controls.Add(this.checkBox5);
            this.grpBxInformations.Controls.Add(this.checkBox4);
            this.grpBxInformations.Controls.Add(this.checkBox3);
            this.grpBxInformations.Controls.Add(this.checkBox2);
            this.grpBxInformations.Controls.Add(this.cbxCorrectionVision);
            this.grpBxInformations.Controls.Add(this.grpBxCPF);
            this.grpBxInformations.Controls.Add(this.lblMessage);
            this.grpBxInformations.Controls.Add(this.lblControle);
            this.grpBxInformations.Controls.Add(this.btnArchiverEleve);
            this.grpBxInformations.Controls.Add(this.btnSupprimerEleve);
            this.grpBxInformations.Controls.Add(this.txtHandicap);
            this.grpBxInformations.Controls.Add(this.label4);
            this.grpBxInformations.Controls.Add(this.txtMail);
            this.grpBxInformations.Controls.Add(this.txtAdresse);
            this.grpBxInformations.Controls.Add(this.txtSexe);
            this.grpBxInformations.Controls.Add(this.txtPrenom);
            this.grpBxInformations.Controls.Add(this.txtNom);
            this.grpBxInformations.Controls.Add(this.lblAdresse);
            this.grpBxInformations.Controls.Add(this.lblSexe);
            this.grpBxInformations.Controls.Add(this.lblPrenom);
            this.grpBxInformations.Controls.Add(this.lblNom);
            this.grpBxInformations.Controls.Add(this.pctBxPhotoEleve);
            this.grpBxInformations.Controls.Add(this.txtTelephone);
            this.grpBxInformations.Controls.Add(this.txtVille);
            this.grpBxInformations.Controls.Add(this.txtDateNaissance);
            this.grpBxInformations.Controls.Add(this.txtAge);
            this.grpBxInformations.Controls.Add(this.txtNumNeph);
            this.grpBxInformations.Controls.Add(this.btnAnnulerModif);
            this.grpBxInformations.Controls.Add(this.btnValiderModif);
            this.grpBxInformations.Controls.Add(this.btnModifInfos);
            this.grpBxInformations.Controls.Add(this.lblTelephone);
            this.grpBxInformations.Controls.Add(this.lblNumNeph);
            this.grpBxInformations.Controls.Add(this.lblMail);
            this.grpBxInformations.Controls.Add(this.lblVille);
            this.grpBxInformations.Controls.Add(this.lblDateNaissance);
            this.grpBxInformations.Controls.Add(this.lblAge);
            this.grpBxInformations.Controls.Add(this.txtEleveSelectionne);
            resources.ApplyResources(this.grpBxInformations, "grpBxInformations");
            this.grpBxInformations.Name = "grpBxInformations";
            this.grpBxInformations.TabStop = false;
            // 
            // grpBxCPF
            // 
            this.grpBxCPF.Controls.Add(this.txtDateFinCPF);
            this.grpBxCPF.Controls.Add(this.txtDateDebutCPF);
            this.grpBxCPF.Controls.Add(this.txtTarifCPF);
            this.grpBxCPF.Controls.Add(this.txtNbHeuresCPF);
            this.grpBxCPF.Controls.Add(this.lblDateFinCPF);
            this.grpBxCPF.Controls.Add(this.lblDateDébutCPF);
            this.grpBxCPF.Controls.Add(this.lblTarifCPF);
            this.grpBxCPF.Controls.Add(this.txtNumCPF);
            this.grpBxCPF.Controls.Add(this.lblNbHeuresCPF);
            this.grpBxCPF.Controls.Add(this.lblNumCPF);
            resources.ApplyResources(this.grpBxCPF, "grpBxCPF");
            this.grpBxCPF.Name = "grpBxCPF";
            this.grpBxCPF.TabStop = false;
            // 
            // txtDateFinCPF
            // 
            resources.ApplyResources(this.txtDateFinCPF, "txtDateFinCPF");
            this.txtDateFinCPF.Name = "txtDateFinCPF";
            // 
            // txtDateDebutCPF
            // 
            resources.ApplyResources(this.txtDateDebutCPF, "txtDateDebutCPF");
            this.txtDateDebutCPF.Name = "txtDateDebutCPF";
            // 
            // txtTarifCPF
            // 
            resources.ApplyResources(this.txtTarifCPF, "txtTarifCPF");
            this.txtTarifCPF.Name = "txtTarifCPF";
            // 
            // txtNbHeuresCPF
            // 
            resources.ApplyResources(this.txtNbHeuresCPF, "txtNbHeuresCPF");
            this.txtNbHeuresCPF.Name = "txtNbHeuresCPF";
            // 
            // lblDateFinCPF
            // 
            resources.ApplyResources(this.lblDateFinCPF, "lblDateFinCPF");
            this.lblDateFinCPF.Name = "lblDateFinCPF";
            // 
            // lblDateDébutCPF
            // 
            resources.ApplyResources(this.lblDateDébutCPF, "lblDateDébutCPF");
            this.lblDateDébutCPF.Name = "lblDateDébutCPF";
            // 
            // lblTarifCPF
            // 
            resources.ApplyResources(this.lblTarifCPF, "lblTarifCPF");
            this.lblTarifCPF.Name = "lblTarifCPF";
            // 
            // txtNumCPF
            // 
            resources.ApplyResources(this.txtNumCPF, "txtNumCPF");
            this.txtNumCPF.Name = "txtNumCPF";
            // 
            // lblNbHeuresCPF
            // 
            resources.ApplyResources(this.lblNbHeuresCPF, "lblNbHeuresCPF");
            this.lblNbHeuresCPF.Name = "lblNbHeuresCPF";
            // 
            // lblNumCPF
            // 
            resources.ApplyResources(this.lblNumCPF, "lblNumCPF");
            this.lblNumCPF.Name = "lblNumCPF";
            // 
            // lblMessage
            // 
            resources.ApplyResources(this.lblMessage, "lblMessage");
            this.lblMessage.Name = "lblMessage";
            // 
            // lblControle
            // 
            resources.ApplyResources(this.lblControle, "lblControle");
            this.lblControle.Name = "lblControle";
            // 
            // btnArchiverEleve
            // 
            resources.ApplyResources(this.btnArchiverEleve, "btnArchiverEleve");
            this.btnArchiverEleve.Name = "btnArchiverEleve";
            this.btnArchiverEleve.UseVisualStyleBackColor = true;
            this.btnArchiverEleve.Click += new System.EventHandler(this.btnArchiverEleve_Click);
            // 
            // btnSupprimerEleve
            // 
            resources.ApplyResources(this.btnSupprimerEleve, "btnSupprimerEleve");
            this.btnSupprimerEleve.Name = "btnSupprimerEleve";
            this.btnSupprimerEleve.UseVisualStyleBackColor = true;
            this.btnSupprimerEleve.Click += new System.EventHandler(this.btnSupprimerEleve_Click);
            // 
            // txtHandicap
            // 
            resources.ApplyResources(this.txtHandicap, "txtHandicap");
            this.txtHandicap.Name = "txtHandicap";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtMail
            // 
            resources.ApplyResources(this.txtMail, "txtMail");
            this.txtMail.Name = "txtMail";
            // 
            // txtAdresse
            // 
            resources.ApplyResources(this.txtAdresse, "txtAdresse");
            this.txtAdresse.Name = "txtAdresse";
            // 
            // txtSexe
            // 
            resources.ApplyResources(this.txtSexe, "txtSexe");
            this.txtSexe.Name = "txtSexe";
            // 
            // txtPrenom
            // 
            resources.ApplyResources(this.txtPrenom, "txtPrenom");
            this.txtPrenom.Name = "txtPrenom";
            // 
            // txtNom
            // 
            resources.ApplyResources(this.txtNom, "txtNom");
            this.txtNom.Name = "txtNom";
            // 
            // lblAdresse
            // 
            resources.ApplyResources(this.lblAdresse, "lblAdresse");
            this.lblAdresse.Name = "lblAdresse";
            // 
            // lblSexe
            // 
            resources.ApplyResources(this.lblSexe, "lblSexe");
            this.lblSexe.Name = "lblSexe";
            // 
            // lblPrenom
            // 
            resources.ApplyResources(this.lblPrenom, "lblPrenom");
            this.lblPrenom.Name = "lblPrenom";
            // 
            // lblNom
            // 
            resources.ApplyResources(this.lblNom, "lblNom");
            this.lblNom.Name = "lblNom";
            // 
            // pctBxPhotoEleve
            // 
            resources.ApplyResources(this.pctBxPhotoEleve, "pctBxPhotoEleve");
            this.pctBxPhotoEleve.Name = "pctBxPhotoEleve";
            this.pctBxPhotoEleve.TabStop = false;
            // 
            // txtTelephone
            // 
            resources.ApplyResources(this.txtTelephone, "txtTelephone");
            this.txtTelephone.Name = "txtTelephone";
            // 
            // txtVille
            // 
            resources.ApplyResources(this.txtVille, "txtVille");
            this.txtVille.Name = "txtVille";
            // 
            // txtDateNaissance
            // 
            resources.ApplyResources(this.txtDateNaissance, "txtDateNaissance");
            this.txtDateNaissance.Name = "txtDateNaissance";
            // 
            // txtAge
            // 
            resources.ApplyResources(this.txtAge, "txtAge");
            this.txtAge.Name = "txtAge";
            // 
            // txtNumNeph
            // 
            resources.ApplyResources(this.txtNumNeph, "txtNumNeph");
            this.txtNumNeph.Name = "txtNumNeph";
            // 
            // btnAnnulerModif
            // 
            resources.ApplyResources(this.btnAnnulerModif, "btnAnnulerModif");
            this.btnAnnulerModif.Name = "btnAnnulerModif";
            this.btnAnnulerModif.UseVisualStyleBackColor = true;
            this.btnAnnulerModif.Click += new System.EventHandler(this.btnAnnulerModif_Click);
            // 
            // btnValiderModif
            // 
            resources.ApplyResources(this.btnValiderModif, "btnValiderModif");
            this.btnValiderModif.Name = "btnValiderModif";
            this.btnValiderModif.UseVisualStyleBackColor = true;
            this.btnValiderModif.Click += new System.EventHandler(this.btnValiderModif_Click);
            // 
            // btnModifInfos
            // 
            resources.ApplyResources(this.btnModifInfos, "btnModifInfos");
            this.btnModifInfos.Name = "btnModifInfos";
            this.btnModifInfos.UseVisualStyleBackColor = true;
            this.btnModifInfos.Click += new System.EventHandler(this.btnModifInfos_Click);
            // 
            // lblTelephone
            // 
            resources.ApplyResources(this.lblTelephone, "lblTelephone");
            this.lblTelephone.Name = "lblTelephone";
            // 
            // lblNumNeph
            // 
            resources.ApplyResources(this.lblNumNeph, "lblNumNeph");
            this.lblNumNeph.Name = "lblNumNeph";
            // 
            // lblMail
            // 
            resources.ApplyResources(this.lblMail, "lblMail");
            this.lblMail.Name = "lblMail";
            // 
            // lblVille
            // 
            resources.ApplyResources(this.lblVille, "lblVille");
            this.lblVille.Name = "lblVille";
            // 
            // lblDateNaissance
            // 
            resources.ApplyResources(this.lblDateNaissance, "lblDateNaissance");
            this.lblDateNaissance.Name = "lblDateNaissance";
            // 
            // lblAge
            // 
            resources.ApplyResources(this.lblAge, "lblAge");
            this.lblAge.Name = "lblAge";
            // 
            // txtEleveSelectionne
            // 
            resources.ApplyResources(this.txtEleveSelectionne, "txtEleveSelectionne");
            this.txtEleveSelectionne.Name = "txtEleveSelectionne";
            // 
            // chkLstBxDateHeures
            // 
            this.chkLstBxDateHeures.CheckOnClick = true;
            resources.ApplyResources(this.chkLstBxDateHeures, "chkLstBxDateHeures");
            this.chkLstBxDateHeures.FormattingEnabled = true;
            this.chkLstBxDateHeures.Name = "chkLstBxDateHeures";
            this.chkLstBxDateHeures.Sorted = true;
            // 
            // grpBxHeure
            // 
            this.grpBxHeure.Controls.Add(this.lblEtaHeure);
            this.grpBxHeure.Controls.Add(this.cbbEtatHeure);
            this.grpBxHeure.Controls.Add(this.btnMajEtatHeure);
            this.grpBxHeure.Controls.Add(this.label3);
            this.grpBxHeure.Controls.Add(this.label2);
            this.grpBxHeure.Controls.Add(this.label1);
            this.grpBxHeure.Controls.Add(this.chkLstBxDateHeures);
            this.grpBxHeure.Controls.Add(this.btnRetirerHeure);
            this.grpBxHeure.Controls.Add(this.btnAjouterHeure);
            resources.ApplyResources(this.grpBxHeure, "grpBxHeure");
            this.grpBxHeure.Name = "grpBxHeure";
            this.grpBxHeure.TabStop = false;
            // 
            // cbbEtatHeure
            // 
            this.cbbEtatHeure.FormattingEnabled = true;
            resources.ApplyResources(this.cbbEtatHeure, "cbbEtatHeure");
            this.cbbEtatHeure.Name = "cbbEtatHeure";
            // 
            // btnMajEtatHeure
            // 
            resources.ApplyResources(this.btnMajEtatHeure, "btnMajEtatHeure");
            this.btnMajEtatHeure.Name = "btnMajEtatHeure";
            this.btnMajEtatHeure.UseVisualStyleBackColor = true;
            this.btnMajEtatHeure.Click += new System.EventHandler(this.btnMajEtatHeure_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnRetirerHeure
            // 
            resources.ApplyResources(this.btnRetirerHeure, "btnRetirerHeure");
            this.btnRetirerHeure.Name = "btnRetirerHeure";
            this.btnRetirerHeure.UseVisualStyleBackColor = true;
            this.btnRetirerHeure.Click += new System.EventHandler(this.btnRetirerHeure_Click);
            // 
            // btnAjouterHeure
            // 
            resources.ApplyResources(this.btnAjouterHeure, "btnAjouterHeure");
            this.btnAjouterHeure.Name = "btnAjouterHeure";
            this.btnAjouterHeure.UseVisualStyleBackColor = true;
            this.btnAjouterHeure.Click += new System.EventHandler(this.btnAjouterHeure_Click);
            // 
            // btnQuitter
            // 
            resources.ApplyResources(this.btnQuitter, "btnQuitter");
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // lblTitre
            // 
            resources.ApplyResources(this.lblTitre, "lblTitre");
            this.lblTitre.Name = "lblTitre";
            // 
            // lblEtaHeure
            // 
            resources.ApplyResources(this.lblEtaHeure, "lblEtaHeure");
            this.lblEtaHeure.Name = "lblEtaHeure";
            // 
            // cbxCorrectionVision
            // 
            resources.ApplyResources(this.cbxCorrectionVision, "cbxCorrectionVision");
            this.cbxCorrectionVision.Name = "cbxCorrectionVision";
            this.cbxCorrectionVision.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            resources.ApplyResources(this.checkBox2, "checkBox2");
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            resources.ApplyResources(this.checkBox3, "checkBox3");
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            resources.ApplyResources(this.checkBox4, "checkBox4");
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            resources.ApplyResources(this.checkBox5, "checkBox5");
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            resources.ApplyResources(this.checkBox6, "checkBox6");
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // FrmAccueil
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ControlBox = false;
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.grpBxHeure);
            this.Controls.Add(this.grpBxInformations);
            this.Controls.Add(this.grpBxListeEleve);
            this.Name = "FrmAccueil";
            this.grpBxListeEleve.ResumeLayout(false);
            this.grpBxListeEleve.PerformLayout();
            this.grpBxInformations.ResumeLayout(false);
            this.grpBxInformations.PerformLayout();
            this.grpBxCPF.ResumeLayout(false);
            this.grpBxCPF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBxPhotoEleve)).EndInit();
            this.grpBxHeure.ResumeLayout(false);
            this.grpBxHeure.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBxListeEleve;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grpBxInformations;
        private System.Windows.Forms.GroupBox grpBxHeure;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.TextBox txtRechercher;
        private System.Windows.Forms.ListBox lstBxListeEleves;
        private System.Windows.Forms.Button btnEffacerFiltres;
        private System.Windows.Forms.Button btnFiltres;
        private System.Windows.Forms.TextBox txtEleveSelectionne;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblNumNeph;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblDateNaissance;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Button btnRetirerHeure;
        private System.Windows.Forms.Button btnAjouterHeure;
        private System.Windows.Forms.Button btnModifInfos;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.CheckedListBox chkLstBxDateHeures;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnAjouterEleve;
        private System.Windows.Forms.Button btnAnnulerModif;
        private System.Windows.Forms.Button btnValiderModif;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtDateNaissance;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtNumNeph;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pctBxPhotoEleve;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblSexe;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtSexe;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtHandicap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSupprimerEleve;
        private System.Windows.Forms.Button btnArchiverEleve;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblControle;
        private System.Windows.Forms.GroupBox grpBxCPF;
        private System.Windows.Forms.TextBox txtNbHeuresCPF;
        private System.Windows.Forms.Label lblDateFinCPF;
        private System.Windows.Forms.Label lblDateDébutCPF;
        private System.Windows.Forms.Label lblTarifCPF;
        private System.Windows.Forms.TextBox txtNumCPF;
        private System.Windows.Forms.Label lblNbHeuresCPF;
        private System.Windows.Forms.Label lblNumCPF;
        private System.Windows.Forms.TextBox txtDateFinCPF;
        private System.Windows.Forms.TextBox txtDateDebutCPF;
        private System.Windows.Forms.TextBox txtTarifCPF;
        private System.Windows.Forms.Button btnMajEtatHeure;
        private System.Windows.Forms.ComboBox cbbEtatHeure;
        private System.Windows.Forms.Label lblEtaHeure;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox cbxCorrectionVision;
    }
}

