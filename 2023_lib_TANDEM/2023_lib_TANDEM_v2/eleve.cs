using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_lib_TANDEM_v3
{
    public class Eleve
    {
        #region propriétés
        //Elle représente les différentes informations importantes sur chaque élève
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
        private bool validationCode;
        private String dateValidationCode;
        private String handicap;
        private bool correctionVision;
        private bool autreInscription; //Indique si l'élève est déjà inscrit ailleur
        private bool parleFrancais;
        private bool conduiteAccompagnee;
        private bool conduiteSupervisee;
        private bool approfondissement;
        private bool pensionInvalidite;
        #endregion

        #region Constructeurs
        //Constructeurs
        //Ce constructeur répertorie toutes les informations essentielles sur l'élève
        public Eleve(String numNeph, String nom, String prenom, String sexe, String dateNaissance, String adresse, String ville, String telephone, String mail, 
            String dateInscription, bool validationCode, String dateValidationCode, String handicap, bool correctionVision, bool autreInscription, bool parleFrancais, 
            bool conduiteAccompagnee, bool conduiteSupervisee, bool approfondissement, bool pensionInvalidite)
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
            this.validationCode = validationCode;
            this.dateValidationCode = dateValidationCode;
            this.handicap = handicap;
            this.correctionVision = correctionVision;
            this.autreInscription = autreInscription;
            this.parleFrancais = parleFrancais;
            this.conduiteAccompagnee = conduiteAccompagnee;
            this.conduiteSupervisee = conduiteSupervisee;
            this.approfondissement = approfondissement;
            this.pensionInvalidite = pensionInvalidite;

        }

        public Eleve(String numNeph, String nom, String prenom)
        {
            this.numNeph = numNeph;
            this.nom = nom;
            this.prenom = prenom;
        }

        public Eleve(String nom, String prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }

        public Eleve(String numNeph, String nom, String prenom, String sexe)
        {
            this.numNeph = numNeph;
            this.nom = nom;
            this.prenom = prenom;
            this.sexe = sexe;
        }

        public Eleve(String nom, String prenom, String sexe, String ville, String dateInscription)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.sexe = sexe;
            this.ville = ville;
            this.dateInscription = dateInscription;
        }

        public Eleve(String numNeph, String nom, String prenom, String telephone, String mail, String ville)
        {
            this.numNeph = numNeph;
            this.nom = nom;
            this.prenom = prenom;
            this.telephone = telephone;
            this.mail = mail;
            this.ville = ville;
        }
        #endregion

        #region Accesseurs
        //Accesseurs sur les différentes propriétés de la classe élève
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

        public bool ValidationCode
        {
            get { return validationCode; }
            set { validationCode = value; }
        }

        public String DateValidationCode
        {
            get { return dateValidationCode; }
            set { dateValidationCode = value; }
        }
        
        public String Handicap
        {
            get { return handicap; }
            set { handicap = value; }
        }
        
        public bool CorrectionVision
        {
            get { return correctionVision; }
            set { correctionVision = value; }
        }

        public bool AutreInscription
        {
            get { return autreInscription; }
            set { autreInscription = value; }
        }

        public bool ParleFrancais
        {
            get { return parleFrancais; }
            set { parleFrancais = value; }
        }

        public bool ConduiteAccompagnee
        {
            get { return conduiteAccompagnee; }
            set { conduiteAccompagnee = value; }
        }

        public bool ConduiteSupervisee
        {
            get { return conduiteSupervisee; }
            set { conduiteSupervisee = value; }
        }

        public bool Approfondissement
        {
            get { return approfondissement; }
            set { approfondissement = value; }
        }

        public bool PensionInvalidite
        {
            get { return pensionInvalidite; }
            set { pensionInvalidite = value; }
        }
        #endregion
    }
}
