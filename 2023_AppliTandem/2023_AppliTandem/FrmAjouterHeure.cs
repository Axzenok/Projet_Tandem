using System;
using System.Globalization;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

namespace _2023_AppliTandem
{
    public partial class FrmAjouterHeure : Form
    {
        #region variable
        private MySqlConnection laConnection;
        private String numNeph;
        #endregion

        #region Coeur du code
        public FrmAjouterHeure(MySqlConnection laConnection, String numNeph)
        {
            this.laConnection = laConnection;
            this.numNeph = numNeph;

            InitializeComponent();
        }
        #endregion

        #region btnClick
        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            String insertHeure = "INSERT INTO tab_heureconduite(CLE_numNeph, HEU_nombreHeures, HEU_dateHeureConduite, " +
                "HEU_EtatHeureConduite, HEU_moniteur, HEU_dateCreation, HEU_dateDerniereModification, HEU_auteurDerniereModification)" +
                "VALUES(@numNEPH, @nbHeures, @dateHeureConduite, @etat, @Moniteur, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP, @Auteur);";

            // Vérifier si tous les champs sont remplis
            if (String.IsNullOrEmpty(txtDuree.Text) ||
                String.IsNullOrEmpty(txtMoniteur.Text) ||
                String.IsNullOrEmpty(txtAuteur.Text))
            {
                lblMessage.Text = "Un ou plusieurs champs sont vides";
                return;
            }

            using (MySqlCommand cmd = new MySqlCommand(insertHeure, laConnection))
            {
                dtpDateDebut.Format = DateTimePickerFormat.Custom;
                dtpDateDebut.CustomFormat = "yyyy-MM-dd";

                dtpHeure.Format = DateTimePickerFormat.Custom;
                dtpHeure.CustomFormat = "HH:mm:ss";

                String dateHeureConduite = dtpDateDebut.Value.ToString("yyyy-MM-dd") + " " + dtpHeure.Value.ToString("HH:mm:ss");

                try
                {
                    // Ajouter les paramètres avec leurs valeurs
                    cmd.Parameters.AddWithValue("@numNEPH", numNeph);
                    cmd.Parameters.AddWithValue("@nbHeures", txtDuree.Text);
                    cmd.Parameters.AddWithValue("@dateHeureConduite", dateHeureConduite);
                    cmd.Parameters.AddWithValue("@etat", "Non réalisée");
                    cmd.Parameters.AddWithValue("@Moniteur", txtMoniteur.Text);
                    cmd.Parameters.AddWithValue("@Auteur", txtAuteur.Text);

                    // Exécuter la requête d'ajout
                    int colonnesAffectees = cmd.ExecuteNonQuery();
                    // Vérifier le nombre de colonnes affectées si nécessaire

                    lblMessage.Text = "Ajout réussi";
                }
                catch (MySqlException ex)
                {
                    // Afficher les détails de l'exception
                    Console.WriteLine("Exception levée : " + ex.ToString());

                    lblMessage.Text = "Ajout impossible";
                }
            }
        }
        #endregion
    }
}
