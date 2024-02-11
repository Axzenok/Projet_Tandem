#region bibliothèques
using _2023_lib_TANDEM_v3;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using _2023_AppliTandem;
#endregion

namespace _2023_AppliTandem
{
    public partial class FrmFiltre : Form
    {
        public delegate void InformationsTrieesModuleEventHandler(List<Eleve> informationsTrieesModule);
        public event InformationsTrieesModuleEventHandler InformationsTrieesModuleEvent;

        #region listes
        //Propriétés
        private List<Eleve> listeEleves;
        private List<Eleve> listeElevesTest;
        #endregion

        #region Variables Personnalisées
        private Eleve eleveSelectionne;
        private StringBuilder queryBuilder;
        #endregion

        #region Vonnection à la BDD et création de la fenêtre
        MySqlConnection laConnection;

        public FrmFiltre(MySqlConnection laConnection)
        {
            this.laConnection = laConnection;

            InitializeComponent();

            creationEleves();

            // Initialise la variable queryBuilder
            queryBuilder = new StringBuilder();
        }
        #endregion

        #region Bouton Retour
        //Ferme la page filtre lorsque in clique sur le bouton retour
        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Déclaration de variable
        // Variables pour stocker les valeurs initiales des ComboBox
        private string cbbPrenomText;
        private string cbbNomText;
        private string cbbAgeText;
        private string cbbGenreText;
        private string cbbVilleText;
        private string cbbInscriptionText;
        #endregion

        #region Lancement de la page filtre
        //Evenement qui se lance lors du chargement de la page
        private void FrmFiltre_Load(object sender, EventArgs e)
        {
            // Sauvegarde les valeurs initiales des ComboBox
            cbbPrenomText = cbbPrenom.Text;
            cbbNomText = cbbNom.Text;
            cbbAgeText = cbbAge.Text;
            cbbGenreText = cbbGenre.Text;
            cbbVilleText = cbbVille.Text;
            cbbInscriptionText = cbbInscription.Text;
        }
        #endregion

        #region Option de tri
        //Lorsque on sélectionne un index
        //On remet les valeurs initiales des champs des combo box
        private void cbbNom_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbPrenom.Text = cbbPrenomText;
            cbbAge.Text = cbbAgeText;
            cbbGenre.Text = cbbGenreText;
            cbbVille.Text = cbbVilleText;
            cbbInscription.Text = cbbInscriptionText;

        }

        //On renouvelle cela pour chaque combo box
        private void cbbPrenom_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbNom.Text = cbbNomText;
            cbbAge.Text = cbbAgeText;
            cbbGenre.Text = cbbGenreText;
            cbbVille.Text = cbbVilleText;
            cbbInscription.Text = cbbInscriptionText;
        }

        private void cbbAge_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbPrenom.Text = cbbPrenomText;
            cbbNom.Text = cbbNomText;
            cbbGenre.Text = cbbGenreText;
            cbbVille.Text = cbbVilleText;
            cbbInscription.Text = cbbInscriptionText;
        }

        private void cbbGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbPrenom.Text = cbbPrenomText;
            cbbAge.Text = cbbAgeText;
            cbbNom.Text = cbbNomText;
            cbbVille.Text = cbbVilleText;
            cbbInscription.Text = cbbInscriptionText;
        }

        private void cbbVille_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbPrenom.Text = cbbPrenomText;
            cbbAge.Text = cbbAgeText;
            cbbGenre.Text = cbbGenreText;
            cbbNom.Text = cbbNomText;
            cbbInscription.Text = cbbInscriptionText;
        }

        private void cbbInscription_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbPrenom.Text = cbbPrenomText;
            cbbAge.Text = cbbAgeText;
            cbbGenre.Text = cbbGenreText;
            cbbVille.Text = cbbVilleText;
            cbbNom.Text = cbbNomText;
        }
        #endregion

        #region Bouton Effacer
        //On configure le bouton effacer
        private void btnEffacer_Click(object sender, EventArgs e)
        {
            // Ouvrir la fenêtre de confirmation (FrmConfirmation)
            FrmConfirmation confirmationForm = new FrmConfirmation(laConnection);
            confirmationForm.lblNomEvenement.Text = "Vous vous apprêtez à effacer la sélection.";

            // Afficher la fenêtre de confirmation en tant que boîte de dialogue modale
            DialogResult result = confirmationForm.ShowDialog();

            // Vérifier la réponse de l'utilisateur
            if (result == DialogResult.Yes)
            {
                // Effacer la sélection
                // Efface la requête précédente
                queryBuilder.Clear();

                // Réinitialisation des ComboBox
                cbbNom.SelectedIndex = -1;
                cbbPrenom.SelectedIndex = -1;
                cbbAge.SelectedIndex = -1;
                cbbGenre.SelectedIndex = -1;
                cbbVille.SelectedIndex = -1;
                cbbInscription.SelectedIndex = -1;

                //Réinitialisation des radios boutons
                rdbEleveActif.Checked = false;
                rdbEleveInactif.Checked = false;
                rdbEleveInscrit.Checked = false;
                rdbEleveArchive.Checked = false;
                rdbEleveDebutant.Checked = false;
                rdbEleveFinFormation.Checked = false;
                rdbConduiteAccompagnee.Checked = false;
                rdbConduiteSupervisee.Checked = false;
                rdbApprofondissement.Checked = false;
                rdbBoiteAuto.Checked = false;
                rdbBoiteManuelle.Checked = false;
                rdbExamProgramme.Checked = false;

                //Remet les champs des combo box par défaut
                cbbPrenom.Text = cbbPrenomText;
                cbbNom.Text = cbbNomText;
                cbbAge.Text = cbbAgeText;
                cbbGenre.Text = cbbGenreText;
                cbbVille.Text = cbbVilleText;
                cbbInscription.Text = cbbInscriptionText;
            }
        }
        #endregion

        #region Liste des Elèves
        //Création de la liste des élèves
        private void creationEleves()
        {
            Eleve eleveActuel;

            String selectAllEleves = "SELECT ELE_nom, ELE_prenom, ELE_sexe, ELE_ville, ELE_dateInscription FROM TAB_eleves ORDER BY ELE_nom ASC;";
            MySqlCommand cmd = new MySqlCommand(selectAllEleves, laConnection);

            try
            {
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    listeEleves = new List<Eleve>();

                    while (dr.Read())
                    {
                        eleveActuel = new Eleve(dr["ELE_nom"].ToString(), dr["ELE_prenom"].ToString(), dr["ELE_sexe"].ToString(), dr["ELE_ville"].ToString(), dr["ELE_dateInscription"].ToString());
                        listeEleves.Add(eleveActuel);
                    }
                }

                foreach (Eleve eleve in listeEleves)
                {
                    listBoxAvancee.Items.Add(eleve.Nom + " " + eleve.Prenom + " " + eleve.Sexe + " " + eleve.Ville + " " + eleve.DateInscription);
                }
            }
            catch (MySqlException e)
            {
                // Afficher les détails de l'exception
                Console.WriteLine("Exception levée : " + e.ToString());
            }
        }
        #endregion

        #region Bouton effacer de la barre de recherche
        private void btnEffacerRecherche_Click(object sender, EventArgs e)
        {
            txtRechercheAvancee.Clear();
        }
        #endregion

        #region Bouton Valider (barre de recherche)
        private void btnValider_Click(object sender, EventArgs e)
        {
            //Début
            Eleve eleveRecherche;

            // Requête SQL paramétrée pour rechercher les élèves correspondant au nom ou prénom saisi
            String selectEleveRecherche = "SELECT ELE_nom, ELE_prenom, ELE_sexe, ELE_ville, ELE_dateInscription " +
                                          "FROM TAB_eleves " +
                                          "WHERE ELE_nom LIKE @recherche " +
                                          "OR ELE_prenom LIKE @recherche " +
                                          "OR CLP_numNeph LIKE @recherche " +
                                          "OR ELE_telephone LIKE @recherche " +
                                          "ORDER BY ELE_nom ASC;";

            MySqlCommand cmd = new MySqlCommand(selectEleveRecherche, laConnection);

            // Ajout des paramètres de requête
            cmd.Parameters.AddWithValue("@recherche", "%" + txtRechercheAvancee.Text + "%");

            try
            {
                // Exécution de la requête SQL
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    listeEleves = new List<Eleve>();

                    // Parcourir les résultats de la requête
                    while (dr.Read())
                    {
                        // Création d'une instance d'élève pour chaque résultat
                        eleveRecherche = new Eleve(dr["ELE_nom"].ToString(), dr["ELE_prenom"].ToString(), dr["ELE_sexe"].ToString(), dr["ELE_ville"].ToString(), dr["ELE_dateInscription"].ToString());
                        listeEleves.Add(eleveRecherche);
                    }
                }

                // Effacer les éléments existants dans la liste des élèves
                listBoxAvancee.Items.Clear();

                // Ajouter les élèves recherchés à la liste des élèves
                foreach (Eleve eleve in listeEleves)
                {
                    listBoxAvancee.Items.Add(eleve.Nom + " " + eleve.Prenom + " " + eleve.Sexe + " " + eleve.Ville + " " + eleve.DateInscription);
                }
            }
            catch (MySqlException f)
            {
                // Afficher les détails de l'exception
                Console.WriteLine("Exception levée : " + f.ToString());
            }
        }
        #endregion

        #region Bouton Rechercher
        //Lancement de la requête SQL en fonction des tris et des filtres séléctionné
        private void btnRechercher_Click(object sender, EventArgs e)
        {
            // Réinitialisation de la liste des élèves
            listBoxAvancee.Items.Clear();

            // Efface la requête précédente
            queryBuilder.Clear();

            // radio bouton archive
            if (rdbEleveArchive.Checked)
            {
                queryBuilder.Append($"SELECT HIS_nom, HIS_prenom, HIS_dateNaissance, HIS_sexe, HIS_ville, HIS_dateInscription FROM tab_historique ");

                ////////////////  CONDITION WHERE   ////////////////////////


                ////////////////  CONDITION ORDER BY   /////////////////////
                // Ajout des conditions de tri en fonction des filtres sélectionnés
                if (cbbNom.SelectedIndex != -1)
                {
                    string sortOrder = (cbbNom.SelectedIndex == 0) ? "ASC" : "DESC";
                    queryBuilder.Append($"ORDER BY HIS_nom {sortOrder},");
                }

                if (cbbPrenom.SelectedIndex != -1)
                {
                    string sortOrder = (cbbPrenom.SelectedIndex == 0) ? "ASC" : "DESC";
                    queryBuilder.Append($"ORDER BY HIS_prenom {sortOrder},");
                }

                if (cbbAge.SelectedIndex != -1)
                {
                    string sortOrder = (cbbAge.SelectedIndex == 0) ? "ASC" : "DESC";
                    queryBuilder.Append($"ORDER BY HIS_dateNaissance {sortOrder},");
                }

                if (cbbGenre.SelectedIndex != -1)
                {
                    string sortOrder = (cbbGenre.SelectedIndex == 0) ? "ASC" : "DESC";
                    queryBuilder.Append($"ORDER BY HIS_sexe {sortOrder},");
                }

                if (cbbVille.SelectedIndex != -1)
                {
                    string sortOrder = (cbbVille.SelectedIndex == 0) ? "ASC" : "DESC";
                    queryBuilder.Append($"ORDER BY HIS_ville {sortOrder},");
                }

                if (cbbInscription.SelectedIndex != -1)
                {
                    string sortOrder = (cbbInscription.SelectedIndex == 0) ? "ASC" : "DESC";
                    queryBuilder.Append($"ORDER BY HIS_dateInscription {sortOrder},");
                }

                // Suppression de la virgule finale
                if (queryBuilder.ToString().EndsWith(","))
                {
                    queryBuilder.Remove(queryBuilder.Length - 1, 1);
                }

                // Exécution de la requête SQL
                try
                {
                    MySqlCommand cmd = new MySqlCommand(queryBuilder.ToString(), laConnection);
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            string nom = dr["HIS_nom"].ToString();
                            string prenom = dr["HIS_prenom"].ToString();
                            string sexe = dr["HIS_sexe"].ToString();
                            string ville = dr["HIS_ville"].ToString();
                            string dateInscription = dr["HIS_dateInscription"].ToString();

                            //Calcul de l'age de l'élève
                            string dateNaissance = dr["HIS_dateNaissance"].ToString();

                            // Convertir la date de naissance en objet DateTime
                            DateTime dateNaissanceDT = DateTime.Parse(dateNaissance);

                            // Obtenir la date actuelle
                            DateTime dateActuelle = DateTime.Now;

                            // Calculer l'âge en soustrayant l'année de naissance de l'année actuelle
                            int age = dateActuelle.Year - dateNaissanceDT.Year;

                            // Vérifier si l'anniversaire de la personne est déjà passé dans l'année en cours
                            if (dateActuelle.Month < dateNaissanceDT.Month || (dateActuelle.Month == dateNaissanceDT.Month && dateActuelle.Day < dateNaissanceDT.Day))
                            {
                                // Si l'anniversaire n'est pas encore passé, décrémenter l'âge
                                age--;
                            }

                            //Ajout des informations dans la liste box
                            listBoxAvancee.Items.Add($"{nom} {prenom} {age} {sexe} {ville} {dateInscription}");
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    // Gérer les exceptions MySQL
                    MessageBox.Show("Une erreur s'est produite lors de l'exécution de la requête SQL : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                ///////////   Fin de la condition tab_historique   /////////////
            }
            else
            {
                // Construction de la requête SQL uniquement si au moins un filtre est sélectionné
                // Ajout de la clause SELECT
                queryBuilder.Append("SELECT DISTINCT ELE_nom, ELE_prenom, ELE_dateNaissance, ELE_sexe, ELE_ville, ELE_dateInscription FROM tab_eleves ");

                // Si les boutons élèves Inactifs et élèves actifs on étaient sélectionné
                if (rdbEleveActif.Checked || rdbEleveInactif.Checked)
                {
                    queryBuilder.Append($" INNER JOIN tab_heureconduite ON ");

                    if (rdbEleveActif.Checked)
                    {
                        DateTime dateEleveActif = DateTime.Now.AddDays(-365); // Moins de un an (365 jours)
                        queryBuilder.Append($" HEU_dateDerniereModification >= '{dateEleveActif.ToString("yyyy-MM-dd")}' AND tab_heureconduite.CLE_numNeph = CLP_numNeph ");
                    }
                    else
                    {
                        DateTime dateEleveInactif = DateTime.Now.AddDays(-366); // Plus d'un an (366 jours)
                        queryBuilder.Append($" HEU_dateDerniereModification < '{dateEleveInactif.ToString("yyyy-MM-dd")}' AND tab_heureconduite.CLE_numNeph = CLP_numNeph ");
                    }
                }

                if (rdbBoiteAuto.Checked)
                {
                    queryBuilder.Append($" INNER JOIN tab_obtenir ON tab_obtenir.CLE_numNeph = CLP_numNeph AND CLE_categorie = 3 ");
                }
                if (rdbBoiteManuelle.Checked)
                {
                    queryBuilder.Append($" INNER JOIN tab_obtenir ON tab_obtenir.CLE_numNeph = CLP_numNeph AND CLE_categorie = 1 ");
                }


                if (rdbExamProgramme.Checked)
                {
                    queryBuilder.Append($" INNER JOIN tab_examconduite ON tab_examconduite.CLE_numNeph = CLP_numNeph ");
                }

                if (rdbEleveInscrit.Checked || rdbEleveDebutant.Checked || rdbEleveFinFormation.Checked ||
                    rdbConduiteAccompagnee.Checked || rdbConduiteSupervisee.Checked || rdbApprofondissement.Checked)
                {
                    queryBuilder.Append($" WHERE ");
                    ////////////////////   Code à continuer   //////////////////////
                    if (rdbEleveInscrit.Checked)
                    {
                        queryBuilder.Append(" 1 AND "); // On prend tous les élèves de la table
                    }
                    if (rdbEleveDebutant.Checked)

                    {
                        DateTime dateDebutant = DateTime.Now.AddDays(-150); // 5 mois (150 jours)
                        queryBuilder.Append($" ELE_dateInscription >= '{dateDebutant.ToString("yyyy-MM-dd")}' AND ");
                    }
                    if (rdbEleveFinFormation.Checked)
                    {
                        DateTime dateFinFormation = DateTime.Now.AddDays(-151); // Plus de 5 mois (151 jours)
                        queryBuilder.Append($" ELE_dateInscription < '{dateFinFormation.ToString("yyyy-MM-dd")}' AND ");
                    }
                    if (rdbConduiteAccompagnee.Checked)
                    {
                        queryBuilder.Append(" ELE_conduiteAccompagnee = 1 AND ");
                    }
                    if (rdbConduiteSupervisee.Checked)
                    {
                        queryBuilder.Append(" ELE_conduiteSupervisee = 1 AND ");
                    }
                    if (rdbApprofondissement.Checked)
                    {
                        queryBuilder.Append(" ELE_Approfondissement = 1 AND ");
                    }

                    // Suppression du "AND " Finale
                    if (queryBuilder.ToString().EndsWith("AND "))
                    {
                        queryBuilder.Remove(queryBuilder.Length - 4, 4);
                    }


                }

                // Ajout des conditions de tri en fonction des filtres sélectionnés
                if (cbbNom.SelectedIndex != -1)
                {
                    string sortOrder = (cbbNom.SelectedIndex == 0) ? "ASC" : "DESC";
                    queryBuilder.Append($" ORDER BY ELE_nom {sortOrder},");
                }

                if (cbbPrenom.SelectedIndex != -1)
                {
                    string sortOrder = (cbbPrenom.SelectedIndex == 0) ? "ASC" : "DESC";
                    queryBuilder.Append($" ORDER BY ELE_prenom {sortOrder},");
                }

                if (cbbAge.SelectedIndex != -1)
                {
                    string sortOrder = (cbbAge.SelectedIndex == 0) ? "ASC" : "DESC";
                    queryBuilder.Append($" ORDER BY ELE_dateNaissance {sortOrder},");
                }

                if (cbbGenre.SelectedIndex != -1)
                {
                    string sortOrder = (cbbGenre.SelectedIndex == 0) ? "ASC" : "DESC";
                    queryBuilder.Append($" ORDER BY ELE_sexe {sortOrder},");
                }

                if (cbbVille.SelectedIndex != -1)
                {
                    string sortOrder = (cbbVille.SelectedIndex == 0) ? "ASC" : "DESC";
                    queryBuilder.Append($" ORDER BY ELE_ville {sortOrder},");
                }

                if (cbbInscription.SelectedIndex != -1)
                {
                    string sortOrder = (cbbInscription.SelectedIndex == 0) ? "ASC" : "DESC";
                    queryBuilder.Append($" ORDER BY ELE_dateInscription {sortOrder},");
                }

                // Suppression de la virgule finale
                if (queryBuilder.ToString().EndsWith(","))
                {
                    queryBuilder.Remove(queryBuilder.Length - 1, 1);
                }

                // Exécution de la requête SQL
                try
                {
                    MySqlCommand cmd = new MySqlCommand(queryBuilder.ToString(), laConnection);
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            string nom = dr["ELE_nom"].ToString();
                            string prenom = dr["ELE_prenom"].ToString();
                            string sexe = dr["ELE_sexe"].ToString();
                            string ville = dr["ELE_ville"].ToString();
                            string dateInscription = dr["ELE_dateInscription"].ToString();

                            //Calcul de l'age de l'élève
                            string dateNaissance = dr["ELE_dateNaissance"].ToString();

                            // Convertir la date de naissance en objet DateTime
                            DateTime dateNaissanceDT = DateTime.Parse(dateNaissance);

                            // Obtenir la date actuelle
                            DateTime dateActuelle = DateTime.Now;

                            // Calculer l'âge en soustrayant l'année de naissance de l'année actuelle
                            int age = dateActuelle.Year - dateNaissanceDT.Year;

                            // Vérifier si l'anniversaire de la personne est déjà passé dans l'année en cours
                            if (dateActuelle.Month < dateNaissanceDT.Month || (dateActuelle.Month == dateNaissanceDT.Month && dateActuelle.Day < dateNaissanceDT.Day))
                            {
                                // Si l'anniversaire n'est pas encore passé, décrémenter l'âge
                                age--;
                            }

                            //Ajout des informations dans la liste box
                            listBoxAvancee.Items.Add($"{nom} {prenom} {age} {sexe} {ville} {dateInscription}");
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    // Gérer les exceptions MySQL
                    MessageBox.Show("Une erreur s'est produite lors de l'exécution de la requête SQL : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



            // Réinitialisation des ComboBox
            cbbNom.SelectedIndex = -1;
            cbbPrenom.SelectedIndex = -1;
            cbbAge.SelectedIndex = -1;
            cbbGenre.SelectedIndex = -1;
            cbbVille.SelectedIndex = -1;
            cbbInscription.SelectedIndex = -1;

            //Réinitialisation des radios boutons
            rdbEleveActif.Checked = false;
            rdbEleveInactif.Checked = false;
            rdbEleveInscrit.Checked = false;
            rdbEleveArchive.Checked = false;
            rdbEleveDebutant.Checked = false;
            rdbEleveFinFormation.Checked = false;
            rdbConduiteAccompagnee.Checked = false;
            rdbConduiteSupervisee.Checked = false;
            rdbApprofondissement.Checked = false;
            rdbBoiteAuto.Checked = false;
            rdbBoiteManuelle.Checked = false;
            rdbExamProgramme.Checked = false;

            //Remet les champs des combo box par défaut
            cbbPrenom.Text = cbbPrenomText;
            cbbNom.Text = cbbNomText;
            cbbAge.Text = cbbAgeText;
            cbbGenre.Text = cbbGenreText;
            cbbVille.Text = cbbVilleText;
            cbbInscription.Text = cbbInscriptionText;

        }
        #endregion

        #region Bouton test
        private void btnTest_Click(object sender, EventArgs e)
        {
            /*
             * List<Eleve> informationsTrieesModule = new List<Eleve>();
            foreach (var item in listBoxAvancee.Items)
            {
                string nomEleve = (string)item;
                // Recherche de l'objet Eleve correspondant au nom dans votre source de données
                Eleve eleve = TrouverEleveParNom(nomEleve);
                informationsTrieesModule.Add(eleve);
            }

            // Déclencher l'événement pour transmettre les informations triées
            InformationsTrieesModuleEvent?.Invoke(informationsTrieesModule);
             * */


        }

        #endregion
    }
}

