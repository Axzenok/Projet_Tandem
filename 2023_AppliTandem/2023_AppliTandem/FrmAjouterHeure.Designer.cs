namespace _2023_AppliTandem
{
    partial class FrmAjouterHeure
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
            this.dtpDateDebut = new System.Windows.Forms.DateTimePicker();
            this.txtMoniteur = new System.Windows.Forms.TextBox();
            this.txtDuree = new System.Windows.Forms.TextBox();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.lblHeure = new System.Windows.Forms.Label();
            this.lblDuree = new System.Windows.Forms.Label();
            this.lblMoniteur = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.lblAuteur = new System.Windows.Forms.Label();
            this.txtAuteur = new System.Windows.Forms.TextBox();
            this.lblControle = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.dtpHeure = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // dtpDateDebut
            // 
            this.dtpDateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateDebut.Location = new System.Drawing.Point(130, 12);
            this.dtpDateDebut.Name = "dtpDateDebut";
            this.dtpDateDebut.Size = new System.Drawing.Size(172, 20);
            this.dtpDateDebut.TabIndex = 0;
            // 
            // txtMoniteur
            // 
            this.txtMoniteur.Location = new System.Drawing.Point(130, 90);
            this.txtMoniteur.Name = "txtMoniteur";
            this.txtMoniteur.Size = new System.Drawing.Size(172, 20);
            this.txtMoniteur.TabIndex = 2;
            // 
            // txtDuree
            // 
            this.txtDuree.Location = new System.Drawing.Point(130, 64);
            this.txtDuree.Name = "txtDuree";
            this.txtDuree.Size = new System.Drawing.Size(172, 20);
            this.txtDuree.TabIndex = 3;
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Location = new System.Drawing.Point(43, 18);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(81, 13);
            this.lblDateDebut.TabIndex = 4;
            this.lblDateDebut.Text = "Date de début :";
            // 
            // lblHeure
            // 
            this.lblHeure.AutoSize = true;
            this.lblHeure.Location = new System.Drawing.Point(82, 41);
            this.lblHeure.Name = "lblHeure";
            this.lblHeure.Size = new System.Drawing.Size(42, 13);
            this.lblHeure.TabIndex = 5;
            this.lblHeure.Text = "Heure :";
            // 
            // lblDuree
            // 
            this.lblDuree.AutoSize = true;
            this.lblDuree.Location = new System.Drawing.Point(82, 67);
            this.lblDuree.Name = "lblDuree";
            this.lblDuree.Size = new System.Drawing.Size(42, 13);
            this.lblDuree.TabIndex = 6;
            this.lblDuree.Text = "Durée :";
            // 
            // lblMoniteur
            // 
            this.lblMoniteur.AutoSize = true;
            this.lblMoniteur.Location = new System.Drawing.Point(70, 93);
            this.lblMoniteur.Name = "lblMoniteur";
            this.lblMoniteur.Size = new System.Drawing.Size(54, 13);
            this.lblMoniteur.TabIndex = 7;
            this.lblMoniteur.Text = "Moniteur :";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(12, 224);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(111, 36);
            this.btnValider.TabIndex = 10;
            this.btnValider.Text = "Ajouter";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(191, 224);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(111, 36);
            this.btnRetour.TabIndex = 11;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // lblAuteur
            // 
            this.lblAuteur.AutoSize = true;
            this.lblAuteur.Location = new System.Drawing.Point(6, 149);
            this.lblAuteur.Name = "lblAuteur";
            this.lblAuteur.Size = new System.Drawing.Size(118, 13);
            this.lblAuteur.TabIndex = 12;
            this.lblAuteur.Text = "Auteur de cette action :";
            // 
            // txtAuteur
            // 
            this.txtAuteur.Location = new System.Drawing.Point(130, 142);
            this.txtAuteur.Name = "txtAuteur";
            this.txtAuteur.Size = new System.Drawing.Size(172, 20);
            this.txtAuteur.TabIndex = 13;
            // 
            // lblControle
            // 
            this.lblControle.AutoSize = true;
            this.lblControle.Location = new System.Drawing.Point(12, 186);
            this.lblControle.Name = "lblControle";
            this.lblControle.Size = new System.Drawing.Size(52, 13);
            this.lblControle.TabIndex = 14;
            this.lblControle.Text = "Contrôle :";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(70, 186);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(99, 13);
            this.lblMessage.TabIndex = 15;
            this.lblMessage.Text = "Ajoutez votre heure";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpHeure
            // 
            this.dtpHeure.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHeure.Location = new System.Drawing.Point(130, 38);
            this.dtpHeure.Name = "dtpHeure";
            this.dtpHeure.ShowUpDown = true;
            this.dtpHeure.Size = new System.Drawing.Size(172, 20);
            this.dtpHeure.TabIndex = 16;
            // 
            // FrmAjouterHeure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 272);
            this.ControlBox = false;
            this.Controls.Add(this.dtpHeure);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblControle);
            this.Controls.Add(this.txtAuteur);
            this.Controls.Add(this.lblAuteur);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.lblMoniteur);
            this.Controls.Add(this.lblDuree);
            this.Controls.Add(this.lblHeure);
            this.Controls.Add(this.lblDateDebut);
            this.Controls.Add(this.txtDuree);
            this.Controls.Add(this.txtMoniteur);
            this.Controls.Add(this.dtpDateDebut);
            this.Name = "FrmAjouterHeure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter une heure";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDateDebut;
        private System.Windows.Forms.TextBox txtMoniteur;
        private System.Windows.Forms.TextBox txtDuree;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.Label lblHeure;
        private System.Windows.Forms.Label lblDuree;
        private System.Windows.Forms.Label lblMoniteur;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Label lblAuteur;
        private System.Windows.Forms.TextBox txtAuteur;
        private System.Windows.Forms.Label lblControle;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.DateTimePicker dtpHeure;
    }
}