#region bibliothèque
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
#endregion

namespace _2023_AppliTandem
{
    public partial class FrmCreationEleve : Form
    {
        #region variableBDD
        private MySqlConnection laConnection;
        #endregion

        #region Coeur du code
        public FrmCreationEleve(MySqlConnection laConnection)
        {
            this.laConnection = laConnection;
            
            InitializeComponent();

            listingCbbSexe();
        }
        #endregion

        #region btnClick
        private void btnCreationEleve_Click(object sender, EventArgs e)
        {
            String insertEleve = "INSERT INTO tab_eleves (CLP_numNeph, ELE_nom, ELE_prenom, ELE_sexe, ELE_dateNaissance, ELE_adresse," +
                                 "ELE_ville, ELE_telephone, ELE_mail, ELE_dateInscription, ELE_validationCode, ELE_dateValidationCode," +
                                 "ELE_handicap, ELE_correctionVision, ELE_autreInscription, ELE_parleFrancais, ELE_conduiteAccompagnee," +
                                 "ELE_conduiteSupervisee, ELE_approfondissement, ELE_pensionInvalidite, ELE_dateCreation, " +
                                 "ELE_dateDerniereModification, ELE_auteurDerniereModification) " +
                                 "VALUES(@numNeph, @nom, @prenom, @sexe, @dateNaissance, @adresse, @ville, @telephone, @mail, " +
                                 "@dateInscription, @validationCode, @dateValidationCode, @handicap, @correctionVision, @autreInscription," +
                                 "@parleFrancais,@conduiteAccompagnee,@conduiteSupervisee,@approfondissement,@pensionInvalidite," +
                                 "CURRENT_TIMESTAMP,CURRENT_TIMESTAMP,@auteurDerniereModification);";

            // Vérifier si tous les champs sont remplis
            if (String.IsNullOrEmpty(txtNumNeph.Text) ||
                String.IsNullOrEmpty(txtNom.Text) ||
                String.IsNullOrEmpty(txtPrenom.Text) ||
                String.IsNullOrEmpty(cbbSexe.Text) ||
                String.IsNullOrEmpty(dtpDateNaissance.Text) ||
                String.IsNullOrEmpty(txtAdresse.Text) ||
                String.IsNullOrEmpty(txtVille.Text) ||
                String.IsNullOrEmpty(txtTelephone.Text) ||
                String.IsNullOrEmpty(txtMail.Text) ||
                String.IsNullOrEmpty(dtpDateInscription.Text) ||
                String.IsNullOrEmpty(txtAuteur.Text))
            {
                lblMessage.Text = "Un ou plusieurs champs sont vides";
                return;
            }

            using (MySqlCommand cmdEleve = new MySqlCommand(insertEleve, laConnection))
            {
                dtpDateNaissance.Format = DateTimePickerFormat.Custom;
                dtpDateNaissance.CustomFormat = "yyyy-MM-dd";

                dtpDateInscription.Format = DateTimePickerFormat.Custom;
                dtpDateInscription.CustomFormat = "yyyy-MM-dd";

                try
                {
                    // Ajouter les paramètres avec leurs valeurs
                    cmdEleve.Parameters.AddWithValue("@numNeph", txtNumNeph.Text);
                    cmdEleve.Parameters.AddWithValue("@nom", txtNom.Text);
                    cmdEleve.Parameters.AddWithValue("@prenom", txtPrenom.Text);
                    cmdEleve.Parameters.AddWithValue("@sexe", cbbSexe.Text);
                    cmdEleve.Parameters.AddWithValue("@dateNaissance", dtpDateNaissance.Text);
                    cmdEleve.Parameters.AddWithValue("@adresse", txtAdresse.Text);
                    cmdEleve.Parameters.AddWithValue("@ville", txtVille.Text);
                    cmdEleve.Parameters.AddWithValue("@telephone", txtTelephone.Text);
                    cmdEleve.Parameters.AddWithValue("@mail", txtMail.Text);
                    cmdEleve.Parameters.AddWithValue("@dateInscription", dtpDateInscription.Text);
                    cmdEleve.Parameters.AddWithValue("@validationCode", '0');
                    cmdEleve.Parameters.AddWithValue("@dateValidationCode", null);
                    cmdEleve.Parameters.AddWithValue("@handicap", txtHandicap.Text);
                    cmdEleve.Parameters.AddWithValue("@correctionVision", cbxCorrectionVision.Checked);
                    cmdEleve.Parameters.AddWithValue("@autreInscription", cbxAutreInscription.Checked);
                    cmdEleve.Parameters.AddWithValue("@parleFrancais", cbxParleFrancais.Checked);
                    cmdEleve.Parameters.AddWithValue("@conduiteAccompagnee", cbxConduiteAccompagnee.Checked);
                    cmdEleve.Parameters.AddWithValue("@conduiteSupervisee", cbxConduiteSupervisee.Checked);
                    cmdEleve.Parameters.AddWithValue("@approfondissement", cbxApprofondissement.Checked);
                    cmdEleve.Parameters.AddWithValue("@pensionInvalidite", cbxPensionInvalidite.Checked);
                    cmdEleve.Parameters.AddWithValue("@auteurDerniereModification", txtAuteur.Text);

                    // Exécuter la requête d'ajout
                    int colonnesEleveAffectees = cmdEleve.ExecuteNonQuery();
                    // Vérifier le nombre de colonnes affectées si nécessaire

                    lblMessage.Text = "Ajout réussi";

                    if (!(String.IsNullOrEmpty(txtNumCPF.Text) ||
                          String.IsNullOrEmpty(txtNumNeph.Text) ||
                          String.IsNullOrEmpty(txtNbHeures.Text) ||
                          String.IsNullOrEmpty(txtTarif.Text) ||
                          dtpDateDebut.Value == null ||
                          dtpDateFin.Value == null ||
                          String.IsNullOrEmpty(txtAuteur.Text)))
                    {
                        String insertCPF = "INSERT INTO tab_cpf (CLP_numCPF, CLE_numNeph, CPF_nbHeure, CPF_tarif, CPF_dateDebut, CPF_dateFin, " +
                                            "CPF_auteurDerniereModification) " +
                                            "VALUES(@numCPF, @numNeph, @nbHeure, @tarif, @dateDebut, @dateFin, @auteurDerniereModification);";

                        using (MySqlCommand cmdCPF = new MySqlCommand(insertCPF, laConnection))
                        {
                            dtpDateDebut.Format = DateTimePickerFormat.Custom;
                            dtpDateDebut.CustomFormat = "yyyy-MM-dd HH:mm:ss";

                            dtpDateFin.Format = DateTimePickerFormat.Custom;
                            dtpDateFin.CustomFormat = "yyyy-MM-dd HH:mm:ss";

                            try
                            {
                                // Ajouter les paramètres avec leurs valeurs
                                cmdCPF.Parameters.AddWithValue("@numCPF", txtNumCPF.Text);
                                cmdCPF.Parameters.AddWithValue("@numNeph", txtNumNeph.Text);
                                cmdCPF.Parameters.AddWithValue("@nbHeure", txtNbHeures.Text);
                                cmdCPF.Parameters.AddWithValue("@tarif", txtTarif.Text);
                                cmdCPF.Parameters.AddWithValue("@dateDebut", dtpDateDebut.Text);
                                cmdCPF.Parameters.AddWithValue("@dateFin", dtpDateFin.Text);
                                cmdCPF.Parameters.AddWithValue("@auteurDerniereModification", txtAuteur.Text);

                                // Exécuter la requête d'ajout
                                int colonnesCPFAffectees = cmdCPF.ExecuteNonQuery();
                                // Vérifier le nombre de colonnes affectées si nécessaire

                                lblMessage.Text = "Eleve inscrit (Avec le CPF)";
                            }
                            catch (MySqlException ex)
                            {
                                // Afficher les détails de l'exception
                                Console.WriteLine("Exception levée : " + ex.ToString());

                                lblMessage.Text = "Ajout impossible";
                            }
                        }
                    }
                    else
                    {
                        lblMessage.Text = "Eleve inscrit (Sans le CPF)";
                    }
                }
                catch (MySqlException ex)
                {
                    // Afficher les détails de l'exception
                    Console.WriteLine("Exception levée : " + ex.ToString());

                    lblMessage.Text = "Ajout impossible";
                }
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region procédures
        private void listingCbbSexe()
        {
            List<String> listeSexe = new List<String>()
            {
                "Masculin",
                "Féminin"
            };

            foreach (String sexe in listeSexe)
            {
                cbbSexe.Items.Add(sexe);
            }
        }
        #endregion
    }
}