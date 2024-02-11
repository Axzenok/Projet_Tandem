namespace _2023_AppliTandem
{
    partial class FrmConfirmation
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
            this.lblConfirmation = new System.Windows.Forms.Label();
            this.lblNomEvenement = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnOui = new System.Windows.Forms.Button();
            this.btnNon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConfirmation
            // 
            this.lblConfirmation.AutoSize = true;
            this.lblConfirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmation.Location = new System.Drawing.Point(217, 23);
            this.lblConfirmation.Name = "lblConfirmation";
            this.lblConfirmation.Size = new System.Drawing.Size(188, 32);
            this.lblConfirmation.TabIndex = 0;
            this.lblConfirmation.Text = "Confirmation";
            // 
            // lblNomEvenement
            // 
            this.lblNomEvenement.AutoSize = true;
            this.lblNomEvenement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomEvenement.Location = new System.Drawing.Point(0, 70);
            this.lblNomEvenement.Name = "lblNomEvenement";
            this.lblNomEvenement.Size = new System.Drawing.Size(514, 20);
            this.lblNomEvenement.TabIndex = 1;
            this.lblNomEvenement.Text = "Vous comptez effectué cette action (insérer le nom de l\'évenement)";
            this.lblNomEvenement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(135, 143);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(308, 20);
            this.lblQuestion.TabIndex = 2;
            this.lblQuestion.Text = "Etes-vous sûr de vouloir continuer?";
            // 
            // btnOui
            // 
            this.btnOui.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOui.Location = new System.Drawing.Point(62, 199);
            this.btnOui.Name = "btnOui";
            this.btnOui.Size = new System.Drawing.Size(134, 37);
            this.btnOui.TabIndex = 3;
            this.btnOui.Text = "Oui";
            this.btnOui.UseVisualStyleBackColor = true;
            this.btnOui.Click += new System.EventHandler(this.btnOui_Click);
            // 
            // btnNon
            // 
            this.btnNon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNon.Location = new System.Drawing.Point(370, 199);
            this.btnNon.Name = "btnNon";
            this.btnNon.Size = new System.Drawing.Size(134, 37);
            this.btnNon.TabIndex = 4;
            this.btnNon.Text = "Non";
            this.btnNon.UseVisualStyleBackColor = true;
            this.btnNon.Click += new System.EventHandler(this.btnNon_Click);
            // 
            // FrmConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(582, 303);
            this.Controls.Add(this.btnNon);
            this.Controls.Add(this.btnOui);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblNomEvenement);
            this.Controls.Add(this.lblConfirmation);
            this.Name = "FrmConfirmation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConfirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConfirmation;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnOui;
        private System.Windows.Forms.Button btnNon;
        public System.Windows.Forms.Label lblNomEvenement;
    }
}