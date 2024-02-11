using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_lib_TANDEM_v3
{
    public class ancienEleve
    {
        #region Propriétés
        //Propriétés de la classe ancienEleve
        //Elle rerrésente les différentes informations importantes sur chaque ancien élève

        private String numNeph; //numéro d'identification de l'élève
        private String nom;
        private String prenom;
        private String sexe;
        private String dateNaissance;
        private String adresse;
        private String ville;
        private String telephone;
        private String mail;
        private String dateInscription;
        private String permis;
        private String dateObtentionPermis;
        #endregion

        #region Constructeur
        //Constructeur avec les informations essentielles
        //Il pourra servir pour crée une liste d'anciens élèves
        public ancienEleve(String numNeph, String nom, String prenom, String sexe, String dateNaissance, String adresse, String ville, String telephone, String mail, 
            String dateInscription, String permis, String dateObtentionPermis)
        {
            this.numNeph = numNeph;
            this.nom = nom;
            this.prenom = prenom;
            this.sexe = sexe;
            this.dateNaissance = dateNaissance;
            this.adresse = adresse;
            this.ville = ville;
            this.telephone = telephone;
            this.mail = mail;
            this.dateInscription = dateInscription;
            this.permis = permis;
            this.dateObtentionPermis = dateObtentionPermis;
        }
        #endregion

        #region Accesseurs
        //Accesseurs
        public String NumNeph
        {
            get { return numNeph; }
            set { numNeph = value; }
        }

        public String Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public String Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public String Sexe
        {
            get { return sexe; }
            set { sexe = value; }
        }

        public String DateNaissance
        {
            get { return dateNaissance; }
            set { dateNaissance = value; }
        }

        public String Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }

        public String Ville
        {
            get { return ville; }
            set { ville = value; }
        }

        public String Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }

        public String Mail
        {
            get { return mail; }
            set { mail = value; }
        }

        public String DateInscription
        {
            get { return dateInscription; }
            set { dateInscription = value; }
        }

        public String Permis
        {
            get { return permis; }
            set { permis = value; }
        }

        public String ValidationPermis
        {
            get { return dateObtentionPermis; }
            set { dateObtentionPermis = value; }
        }
        #endregion
    }
}
