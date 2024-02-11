/*Travail à faire / modifier
 * 
 * approfondissement -> perfectionnement
 * définir les heures d'examens
 * pouvoir choisir un état dès la création de l'heure
 * 
 * 
 */


#region bibliothèques
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Windows.Forms;
using Image = System.Drawing.Image;
using Application = System.Windows.Forms.Application;
using _2023_lib_TANDEM_v3;
using System.Linq;
#endregion

namespace _2023_AppliTandem
{
    public partial class FrmAccueil : Form
    {
        #region Variables
        private String nom;
        private String prenom;
        private String sexe;
        private String dateNaissance;
        private String adresse;
        private String ville;
        private String telephone;
        private String mail;
        private String handicap;

        private String photo;
        String dateNaissanceFormatee;
        #endregion

        #region listes
        private List<Eleve> listeEleves;
        List<heureConduite> listeHeures;
        #endregion

        #region Variables Personnalisées
        private Eleve eleveSelectionne;
        #endregion
        
        #region connexion à la BDD
        MySqlConnection laConnection;
        private bool connexionOk;
        #endregion

        #region coeur du code
        // Début des contrôles graphiques + autre
        public FrmAccueil()
        {
            //avec Bdd
            laConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["connexionBdd"].ConnectionString);
            connexionOk = ouvertureConnexion();

            InitializeComponent();

            creationListeEleves();

            listingCbbEtatHeure();
        }
        #endregion

        #region btn_Click (actions complexes)
        // btnRechercher :
        // utilise le texte écrit dans la barre de recherche pour filtrer
        private void btnRechercher_Click(object sender, EventArgs e)
        {
            Eleve eleveRecherche;

            // Requête SQL pour rechercher les élèves correspondant au nom ou prénom saisi
            String selectEleveRecherche = "SELECT CLP_numNeph, ELE_nom, ELE_prenom " +
                                          "FROM TAB_eleves " +
                                          "WHERE ELE_nom LIKE '%" + txtRechercher.Text + "%'" +
                                          "OR ELE_prenom LIKE '%" + txtRechercher.Text + "%'" +
                                          "ORDER BY ELE_nom ASC;";

            MySqlCommand cmd = new MySqlCommand(selectEleveRecherche, laConnection);

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
                        eleveRecherche = new Eleve(dr["CLP_numNeph"].ToString(), dr["ELE_nom"].ToString(), dr["ELE_prenom"].ToString());
                        listeEleves.Add(eleveRecherche);
                    }
                }

                // Effacer les éléments existants dans la liste des élèves
                lstBxListeEleves.Items.Clear();

                // Ajouter les élèves recherchés à la liste des élèves
                foreach (Eleve eleve in listeEleves)
                {
                    lstBxListeEleves.Items.Add(eleve.Nom + " " + eleve.Prenom);
                }
            }
            catch (MySqlException f)
            {
                // Afficher les détails de l'exception
                Console.WriteLine("Exception levée : " + f.ToString());
            }
        }

        // btnModifInfos :
        // Autorise la modification des informations dans le client
        private void btnModifInfos_Click(object sender, EventArgs e)
        {
            /* garde les informations avant la modifcation */
            nom = txtNom.Text;
            prenom = txtPrenom.Text;
            sexe = txtSexe.Text;
            dateNaissance = txtDateNaissance.Text;
            adresse = txtAdresse.Text;
            ville = txtVille.Text;
            telephone = txtTelephone.Text;
            mail = txtMail.Text;
            handicap = txtHandicap.Text;
            

            /* autorise les modifcations dans les champs */
            txtNom.Enabled = true;
            txtPrenom.Enabled = true;
            txtSexe.Enabled = true;
            txtDateNaissance.Enabled = true;
            txtAdresse.Enabled = true;
            txtVille.Enabled = true;
            txtTelephone.Enabled = true;
            txtMail.Enabled = true;
            txtHandicap.Enabled = true;

            /* active les boutons valider et annuler... */
            btnAnnulerModif.Enabled = true;
            btnValiderModif.Enabled = true;

            /* ...et désactive le bouton de modification */
            btnModifInfos.Enabled = false;

            lblMessage.Text = "Prêt pour les modifications";
        }

        // btnAnnulerModif :
        // Remet les informations avant les modifications
        private void btnAnnulerModif_Click(object sender, EventArgs e)
        {
            /* voir les procédures (n°1) */
            desactiverModif();

            /* remet les informations comme avant */
            txtEleveSelectionne.Text = txtNom.Text + " " + txtPrenom.Text;
            txtNom.Text = nom;
            txtPrenom.Text = prenom;
            txtSexe.Text = sexe;
            txtDateNaissance.Text = dateNaissance;
            txtAdresse.Text = adresse;
            txtVille.Text = ville;
            txtTelephone.Text = telephone;
            txtMail.Text = mail;

            lblMessage.Text = "Modification annulée";
        }

        // btnValiderModif :
        // Modifie les informations entrées par l'utilisateur
        private void btnValiderModif_Click(object sender, EventArgs e)
        {
            desactiverModif();

            // Mettre à jour la date de naissance de l'élève dans la base de données
            String updateEleve = "UPDATE tab_eleves " +
                                    "SET ELE_telephone = @telephone," +
                                    "ELE_dateNaissance = @DateNaissance " +
                                    "WHERE CLP_numNeph = @NumNeph;";

            using (MySqlCommand cmd = new MySqlCommand(updateEleve, laConnection))
            {
                try
                {
                    // Ajouter les paramètres avec leurs valeurs
                    cmd.Parameters.AddWithValue("@DateNaissance", dateNaissanceFormatee);
                    cmd.Parameters.AddWithValue("@telephone", txtTelephone.Text);
                    cmd.Parameters.AddWithValue("@NumNeph", txtNumNeph.Text);

                    // Exécuter la requête de mise à jour
                    int colonnesAffectees = cmd.ExecuteNonQuery();
                    // Vérifier le nombre de colonnes affectées si nécessaire

                    lblMessage.Text = "Modification Réussie";
                }
                catch (MySqlException ex)
                {
                    lblMessage.Text = "Impossible de modifier les informations";
                }
            }
        }

        // btnSupprimerEleve :
        // Retire l'élève de la BDD
        private void btnSupprimerEleve_Click(object sender, EventArgs e)
        {
            FrmConfirmation confirmationForm = new FrmConfirmation(laConnection);
            confirmationForm.lblNomEvenement.Text = "Vous vous apprêter à supprimer un définitivement élève";

            DialogResult result = confirmationForm.ShowDialog();

            if (result == DialogResult.Yes)
            {
                SuppresionEleveSelectionne();
            }
            
        }

        // A REVOIR
        // btnArchiverEleve :
        // Archive les informations sur l'élève dans la table dédiée
        private void btnArchiverEleve_Click(object sender, EventArgs e)
        {
            FrmConfirmation confirmationForm = new FrmConfirmation(laConnection);
            confirmationForm.lblNomEvenement.Text = "Vous vous apprêter à archiver un élève";

            DialogResult result = confirmationForm.ShowDialog();

            if (result == DialogResult.Yes)
            {
                String insertArchive = "INSERT INTO tab_historique(CLP_numNeph, HIS_photo, HIS_nom, HIS_prenom, HIS_sexe, HIS_mail, HIS_telephone, HIS_dateInscription, " +
                                        "HIS_dateObtentionPermis, HIS_adresse, HIS_ville, HIS_dateNaissance, HIS_dateCreation, HIS_dateDerniereModification, HIS_auteurDerniereModification)" +
                                            "VALUES(@numNEPH, @photo, @nom, @prenom, @sexe, @mail, @telephone, @dateInscription, @dateObtentionPermis, @adresse, @ville, @dateNaissance, " +
                                            "CURRENT_TIMESTAMP, CURRENT_TIMESTAMP, 'Admin');";

                using (MySqlCommand cmd = new MySqlCommand(insertArchive, laConnection))
                {
                    try
                    {
                        // Ajouter les paramètres avec leurs valeurs
                        cmd.Parameters.AddWithValue("@numNEPH", txtNumNeph.Text);
                        cmd.Parameters.AddWithValue("@photo", photo);
                        cmd.Parameters.AddWithValue("@nom", txtNom.Text);
                        cmd.Parameters.AddWithValue("@prenom", txtPrenom.Text);
                        cmd.Parameters.AddWithValue("@sexe", txtSexe.Text);
                        cmd.Parameters.AddWithValue("@mail", txtMail.Text);
                        cmd.Parameters.AddWithValue("@telephone", txtTelephone.Text);
                        cmd.Parameters.AddWithValue("@dateInscription", dateNaissanceFormatee);
                        cmd.Parameters.AddWithValue("@dateObtentionPermis", dateNaissanceFormatee);
                        cmd.Parameters.AddWithValue("@adresse", txtAdresse.Text);
                        cmd.Parameters.AddWithValue("@ville", txtVille.Text);
                        cmd.Parameters.AddWithValue("@dateNaissance", dateNaissanceFormatee);

                        // Exécuter la requête de mise à jour
                        int colonnesAffectees = cmd.ExecuteNonQuery();
                        // Vérifier le nombre de colonnes affectées si nécessaire

                        SuppresionEleveSelectionne();

                        lblMessage.Text = "L'élève est archivé(e)";
                    }
                    catch (MySqlException ex)
                    {
                        // Afficher les détails de l'exception
                        Console.WriteLine("Exception levée : " + ex.ToString());
                        lblMessage.Text = "L'archive n'a pas pu se faire";
                    }
                }
            }

            
        }

        // btnRetirerHeure :
        // Retire les heures sélectionnée sur la BDD
        private void btnRetirerHeure_Click(object sender, EventArgs e)
        {
            FrmConfirmation confirmationForm = new FrmConfirmation(laConnection);
            confirmationForm.lblNomEvenement.Text = "Vous vous apprêter à supprimer un définitivement une heure de conduite";

            DialogResult result = confirmationForm.ShowDialog();

            if (result == DialogResult.Yes)
            {
                // Vérifier si des heures sont sélectionnées dans la liste
                if (chkLstBxDateHeures.CheckedItems.Count > 0)
                {
                    try
                    {
                        // Parcourir les heures cochées dans la liste
                        foreach (var item in chkLstBxDateHeures.CheckedItems)
                        {
                            // Récupérer les informations de l'heure
                            String heureSelectionnee = item.ToString();
                            String[] infosHeure = heureSelectionnee.Split('\t');

                            // Récupérer les informations nécessaires pour supprimer l'heure
                            String dateHeureConduiteStr = infosHeure[0];
                            int nombreHeures = int.Parse(infosHeure[1]);
                            String moniteur = infosHeure[2];

                            // Conversion de la date de conduite au format "yyyy-MM-dd HH:mm:ss"
                            String dateHeureConduiteFormatted = DateTime.Parse(dateHeureConduiteStr).ToString("yyyy-MM-dd HH:mm:ss");

                            // Construction de la requête SQL pour supprimer l'heure de conduite
                            String deleteHeure = "DELETE FROM tab_heureConduite " +
                                                 "WHERE CLE_numNeph = @numNeph " +
                                                    "AND HEU_dateHeureConduite = @dateHeureConduite " +
                                                    "AND HEU_nombreHeures = @nombreHeures " +
                                                    "AND HEU_moniteur = @moniteur;";

                            MySqlCommand cmdDeleteHeure = new MySqlCommand(deleteHeure, laConnection);

                            // Ajouter les paramètres à la commande
                            cmdDeleteHeure.Parameters.AddWithValue("@numNeph", txtNumNeph.Text);
                            cmdDeleteHeure.Parameters.AddWithValue("@dateHeureConduite", dateHeureConduiteFormatted);
                            cmdDeleteHeure.Parameters.AddWithValue("@nombreHeures", nombreHeures);
                            cmdDeleteHeure.Parameters.AddWithValue("@moniteur", moniteur);

                            // Exécution de la requête SQL
                            int rowsAffected = cmdDeleteHeure.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Supprimer l'heure de la liste
                                listeHeures.RemoveAll(h => h.DateHeureConduite == dateHeureConduiteFormatted && h.NombreHeures == nombreHeures && h.Moniteur == moniteur);
                            }
                        }

                        // Mettre à jour l'affichage dans chkLstBxDateHeures
                        MAJChkLstBxheureConduite();
                    }
                    catch (MySqlException ex)
                    {
                        // Afficher les détails de l'exception
                        Console.WriteLine("Exception levée : " + ex.ToString());
                    }
                }
            }
            
        }
        #endregion

        #region btn_Click (actions simples)
        private void btnAjouterEleve_Click(object sender, EventArgs e)
        {
            FrmCreationEleve PageCreationEleve = new FrmCreationEleve(laConnection);
            PageCreationEleve.ShowDialog();
        }

        private void btnAjouterHeure_Click(object sender, EventArgs e)
        {
            FrmAjouterHeure PageAjouterHeure = new FrmAjouterHeure(laConnection, txtNumNeph.Text);
            PageAjouterHeure.ShowDialog();
        }

        // btnFiltres :
        // Fait appraître la fenêtre des filtres
        private void btnFiltres_Click(object sender, EventArgs e)
        {
            FrmFiltre PageFiltre = new FrmFiltre(laConnection);
            PageFiltre.Show();
        }

        // btnEffacerFiltres :
        // Enlève tous les filtres
        private void btnEffacerFiltres_Click(object sender, EventArgs e)
        {
            creationListeEleves();

            lstBxListeEleves.Items.Clear();

            foreach (Eleve eleve in listeEleves)
            {
                lstBxListeEleves.Items.Add(eleve.Nom + " " + eleve.Prenom);
            }
        }

        // btnQuitter :
        // quitte l'application
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            fermetureConnexion();
            Application.Exit();
        }
        #endregion

        #region lstBx_indexChanged
        private void lstBxListeEleves_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexSelectionne;
            Eleve selectionEleve;

            if (lstBxListeEleves.SelectedItem != null)
            {
                #region informations de base
                indexSelectionne = lstBxListeEleves.SelectedIndex;
                selectionEleve = listeEleves[indexSelectionne];

                // Construction de la requête SQL pour sélectionner les informations de base de l'élève
                String selectEleve = "SELECT * " +
                                        "FROM tab_eleves " +
                                        "WHERE CLP_numNeph = " + selectionEleve.NumNeph + ";";

                MySqlCommand cmdEleve = new MySqlCommand(selectEleve, laConnection);

                try
                {
                    // Exécution de la requête SQL et lecture des résultats
                    using (MySqlDataReader dr = cmdEleve.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            // Instanciation de l'objet Eleve avec les informations récupérées de la base de données
                            Eleve eleveSelectionne = new Eleve(dr["CLP_numNeph"].ToString(), dr["ELE_nom"].ToString(), dr["ELE_prenom"].ToString(), dr["ELE_sexe"].ToString(),
                                dr["ELE_dateNaissance"].ToString(), dr["ELE_adresse"].ToString(), dr["ELE_ville"].ToString(), dr["ELE_telephone"].ToString(),
                                dr["ELE_mail"].ToString(), dr["ELE_dateInscription"].ToString(), Convert.ToBoolean(dr["ELE_validationCode"]), dr["ELE_dateValidationCode"].ToString(),
                                dr["ELE_handicap"].ToString(), Convert.ToBoolean(dr["ELE_correctionVision"]), Convert.ToBoolean(dr["ELE_autreInscription"]),
                                Convert.ToBoolean(dr["ELE_parleFrancais"]), Convert.ToBoolean(dr["ELE_conduiteAccompagnee"]), Convert.ToBoolean(dr["ELE_conduiteSupervisee"]),
                                Convert.ToBoolean(dr["ELE_approfondissement"]), Convert.ToBoolean(dr["ELE_pensionInvalidite"]));

                            

                            // Affichage des informations de base de l'élève
                            txtEleveSelectionne.Text = eleveSelectionne.Nom + " " + eleveSelectionne.Prenom;
                            txtNumNeph.Text = eleveSelectionne.NumNeph;
                            txtNom.Text = eleveSelectionne.Nom;
                            txtPrenom.Text = eleveSelectionne.Prenom;
                            txtSexe.Text = eleveSelectionne.Sexe;
                            txtDateNaissance.Text = DateTime.Parse(eleveSelectionne.DateNaissance).ToString("dd/MM/yyyy");
                            txtAge.Text = calculAge(DateTime.Parse(eleveSelectionne.DateNaissance)).ToString();
                            txtAdresse.Text = eleveSelectionne.Adresse;
                            txtVille.Text = eleveSelectionne.Ville;
                            txtTelephone.Text = eleveSelectionne.Telephone;
                            txtMail.Text = eleveSelectionne.Mail;
                            txtHandicap.Text = eleveSelectionne.Handicap;

                            // Donne le chemin de l'image
                            photo = @"C:\PLANETE PERMIS\RAPIDO\TANDEM AUTO ECOLE\'" + eleveSelectionne.Nom + " " + eleveSelectionne.Prenom + ".jpg";
                            
                            // Vérifier si le fichier de l'image existe avant de créer l'objet Image
                            if (File.Exists(photo))
                            {
                                Image image = Image.FromFile(photo);
                                pctBxPhotoEleve.Image = image;
                            }

                            // conversion de prévision pour certains boutons
                            dateNaissanceFormatee = DateTime.Parse(txtDateNaissance.Text).ToString("yyyy-MM-dd HH:mm:ss");
                        }
                    }
                }
                catch (MySqlException f)
                {
                    // Afficher les détails de l'exception
                    Console.WriteLine("Exception levée : " + f.ToString());
                }
                #endregion

                #region infos CPF
                // affichage des infos CPF
                String selectInfosCPF = "SELECT * " +
                                            "FROM tab_CPF " +
                                            "WHERE CLE_numNeph = " + selectionEleve.NumNeph + ";";

                MySqlCommand cmdInfosCPF = new MySqlCommand(selectInfosCPF, laConnection);

                try
                {
                    // Exécution de la requête SQL et lecture des résultats
                    using (MySqlDataReader dr = cmdInfosCPF.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            if (int.TryParse(dr["CPF_nbHeure"].ToString(), out int cpfNbHeure) &&
                                int.TryParse(dr["CPF_tarif"].ToString(), out int cpfTarif))
                            {
                                infosCPF informationsCPF = new infosCPF(dr["CLP_numCPF"].ToString(), eleveSelectionne, cpfNbHeure, cpfTarif, dr["CPF_dateDebut"].ToString(), 
                                    dr["CPF_dateFin"].ToString());

                                txtNumCPF.Text = informationsCPF.NumCPF;
                                txtNbHeuresCPF.Text = informationsCPF.NbHeure.ToString();
                                txtTarifCPF.Text = informationsCPF.Tarif.ToString();
                                txtDateDebutCPF.Text = informationsCPF.DateDebut;
                                txtDateFinCPF.Text = informationsCPF.DateFin;
                            }
                        }
                    }
                }
                catch (MySqlException f)
                {
                    // Afficher les détails de l'exception
                    Console.WriteLine("Exception levée : " + f.ToString());
                }
                #endregion

                #region heures
                // Construction de la requête SQL pour sélectionner les heures de conduite de l'élève
                String selectHeures = "SELECT * " +
                                      "FROM tab_heureConduite " +
                                      "WHERE CLE_numNeph = " + selectionEleve.NumNeph + ";";

                MySqlCommand cmdHeure = new MySqlCommand(selectHeures, laConnection);

                try
                {
                    // Exécution de la requête SQL et lecture des résultats
                    using (MySqlDataReader dr = cmdHeure.ExecuteReader())
                    {
                        listeHeures = new List<heureConduite>();

                        while (dr.Read())
                        {
                            // Instanciation de l'objet heureConduite avec les informations récupérées de la base de données
                            if (int.TryParse(dr["CLP_id_heureConduite"].ToString(), out int clpIdHeureConduite) &&
                                int.TryParse(dr["HEU_nombreHeures"].ToString(), out int heuNombreHeures))
                            {
                                heureConduite heuresEleveSelectionne = new heureConduite(clpIdHeureConduite, eleveSelectionne, heuNombreHeures, dr["HEU_dateHeureConduite"].ToString(), dr["HEU_moniteur"].ToString(), dr["HEU_etatHeureConduite"].ToString());
                                listeHeures.Add(heuresEleveSelectionne); // Ajouter l'instance à la liste
                            }

                            // Afficher les informations dans chkLstBxDateHeures
                            MAJChkLstBxheureConduite();
                        }
                    }
                }
                catch (MySqlException f)
                {
                    // Afficher les détails de l'exception
                    Console.WriteLine("Exception levée : " + f.ToString());
                }
                #endregion

                btnModifInfos.Enabled = true;
                btnAjouterHeure.Enabled = true;
                btnRetirerHeure.Enabled = true;
                btnSupprimerEleve.Enabled = true;
                btnArchiverEleve.Enabled = true;

                lblMessage.Text = "Voici les informations de votre élève";
                
            }
        }
        #endregion

        #region Fonctions
        private bool ouvertureConnexion()
        {
            bool retour = true;
            try
            {
                laConnection.Open();
            }
            catch (MySqlException e)
            {
                retour = false;
            }
            return retour;
        }
        private bool fermetureConnexion()
        {
            bool retour = true;
            try
            {
                laConnection.Close();
            }
            catch (MySqlException e)
            {
                retour = false;
            }
            return retour;
        }
        private int calculAge(DateTime dateDeNaissance)
        {
            // Obtenir la date actuelle
            DateTime dateActuelle = DateTime.Now;

            // Calculer l'âge en soustrayant l'année de naissance de l'année actuelle
            int age = dateActuelle.Year - dateDeNaissance.Year;

            // Vérifier si l'anniversaire de la personne est déjà passé dans l'année en cours
            if (dateActuelle.Month < dateDeNaissance.Month || (dateActuelle.Month == dateDeNaissance.Month && dateActuelle.Day < dateDeNaissance.Day))
            {
                // Si l'anniversaire n'est pas encore passé, décrémenter l'âge
                age--;
            }

            return age;
        }
        #endregion

        #region Procédures
        // Procédure BDD n°1 : creationEleves
        // Créé la liste des élèves présents sur la BDD
        private void creationListeEleves()
        {
            Eleve eleveActuel;

            String selectAllEleves = "SELECT CLP_numNeph, ELE_nom, ELE_prenom FROM TAB_eleves ORDER BY ELE_nom ASC;";
            MySqlCommand cmd = new MySqlCommand(selectAllEleves, laConnection);

            try
            {
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    listeEleves = new List<Eleve>();

                    while (dr.Read())
                    {
                        eleveActuel = new Eleve(dr["CLP_numNeph"].ToString(), dr["ELE_nom"].ToString(), dr["ELE_prenom"].ToString());
                        listeEleves.Add(eleveActuel);
                    }
                }

                foreach (Eleve eleve in listeEleves)
                {
                    lstBxListeEleves.Items.Add(eleve.Nom + " " + eleve.Prenom);
                }
            }
            catch (MySqlException e)
            {
                // Afficher les détails de l'exception
                Console.WriteLine("Exception levée : " + e.ToString());
            }
        }

        // Procédure n°1 : desactiverModif
        // Retire les droits de modification des informations des élèves
        private void desactiverModif()
        {
            /* retire la possibilité de modifier */
            txtNom.Enabled = false;
            txtPrenom.Enabled = false;
            txtSexe.Enabled = false;
            txtDateNaissance.Enabled = false;
            txtAdresse.Enabled = false;
            txtVille.Enabled = false;
            txtTelephone.Enabled = false;
            txtMail.Enabled = false;
            txtHandicap.Enabled = false;

            /* retire la possibilité de valider/annuler */
            btnAnnulerModif.Enabled = false;
            btnValiderModif.Enabled = false;

            /* Réactive le bouton de modification 
            !!! Par souci de bien faire : mettre cette ligne à la fin pour éviter un override de la part de l'utilisateur */
            btnModifInfos.Enabled = true;
        }

        private void SuppresionEleveSelectionne()
        {
            String deleteEleve = "DELETE " +
                                    "FROM tab_cpf " +
                                    "WHERE tab_cpf.CLE_numNeph = " + txtNumNeph.Text + ";" +

                                "DELETE " +
                                    "FROM tab_examConduite " +
                                    "WHERE tab_examConduite.CLE_numNeph = " + txtNumNeph.Text + ";" +

                                "DELETE " +
                                    "FROM tab_heureConduite " +
                                    "WHERE tab_heureConduite.CLE_numNeph = " + txtNumNeph.Text + ";" +

                                "DELETE " +
                                    "FROM tab_obtenir " +
                                    "WHERE tab_obtenir.CLE_numNeph = " + txtNumNeph.Text + ";" +


                                "DELETE " +
                                    "FROM tab_disponibilites " +
                                    "WHERE tab_disponibilites.CLE_numNeph = " + txtNumNeph.Text + ";" +


                                "DELETE " +
                                    "FROM tab_eleves " +
                                    "WHERE tab_eleves.CLP_numNeph = " + txtNumNeph.Text + ";";

            using (MySqlCommand cmd = new MySqlCommand(deleteEleve, laConnection))
            {
                try
                {
                    // Exécuter la requête de suppression
                    int colonnesAffectees = cmd.ExecuteNonQuery();
                    // Vérifier le nombre de colonnes affectées si nécessaire

                    lblMessage.Text = "L'élève est supprimé(e)";
                }
                catch (MySqlException ex)
                {
                    // Afficher les détails de l'exception
                    Console.WriteLine("Exception levée : " + ex.ToString());

                    lblMessage.Text = "Suppresion impossible";
                }
            }
        }

        private void MAJChkLstBxheureConduite()
        {
            chkLstBxDateHeures.Items.Clear();
            foreach (heureConduite heure in listeHeures)
            {
                chkLstBxDateHeures.Items.Add($"{heure.DateHeureConduite}\t{heure.NombreHeures}\t{heure.Moniteur}\t{heure.EtatHeureConduite}");
            }
        }

        private void listingCbbEtatHeure()
        {
            List<String> listeEtat = new List<String>()
            {
                "non réalisé",
                "à rattrapper",
                "réalisé"
            };

            foreach (String etat in listeEtat)
            {
                cbbEtatHeure.Items.Add(etat);
            }
        }
        #endregion


        // A FAIRE
        private void btnMajEtatHeure_Click(object sender, EventArgs e)
        {
            // Vérifier si des heures sont sélectionnées dans la liste
            if (chkLstBxDateHeures.CheckedItems.Count > 0)
            {
                try
                {
                    // Parcourir les heures cochées dans la liste
                    foreach (var item in chkLstBxDateHeures.CheckedItems)
                    {
                        // Récupérer les informations de l'heure
                        String heureSelectionnee = item.ToString();
                        String[] infosHeure = heureSelectionnee.Split('\t');

                        // Récupérer les informations nécessaires pour supprimer l'heure
                        String dateHeureConduiteStr = infosHeure[0];
                        int nombreHeures = int.Parse(infosHeure[1]);
                        String moniteur = infosHeure[2];
                        String etat = infosHeure[3];

                        // Conversion de la date de conduite au format "yyyy-MM-dd HH:mm:ss"
                        String dateHeureConduiteFormatted = DateTime.Parse(dateHeureConduiteStr).ToString("yyyy-MM-dd HH:mm:ss");

                        // Construction de la requête SQL paramétrée pour supprimer l'heure de conduite
                        String updateEtatHeure = "UPDATE tab_heureconduite " +
                            "SET HEU_EtatHeureConduite = @nouvelEtat " +
                            "WHERE CLP_id_heureConduite = @numNeph " +
                            "AND HEU_dateHeureConduite = @dateHeureConduite;";

                        MySqlCommand cmdDeleteHeure = new MySqlCommand(updateEtatHeure, laConnection);

                        // Ajout des paramètres de requête
                        cmdDeleteHeure.Parameters.AddWithValue("@nouvelEtat", cbbEtatHeure.Text);
                        cmdDeleteHeure.Parameters.AddWithValue("@numNeph", txtNumNeph.Text);
                        cmdDeleteHeure.Parameters.AddWithValue("@dateHeureConduite", dateHeureConduiteFormatted);

                        // Exécution de la requête SQL
                        int rowsAffected = cmdDeleteHeure.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            listeHeures.Where(h => h.DateHeureConduite == dateHeureConduiteFormatted && h.NombreHeures == nombreHeures && 
                            h.Moniteur == moniteur && h.EtatHeureConduite == etat)
                                        .ToList()
                                        .ForEach(h => h.EtatHeureConduite = cbbEtatHeure.Text);

                        }
                    }

                    // Mettre à jour l'affichage dans chkLstBxDateHeures
                    MAJChkLstBxheureConduite();
                }
                catch (MySqlException ex)
                {
                    // Afficher les détails de l'exception
                    Console.WriteLine("Exception levée : " + ex.ToString());
                }
            }
        }
    }
}