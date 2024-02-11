using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_lib_TANDEM_v3
{
    public class heureConduite
    {
        #region Propriétés
        //Propriété de la classe heureConduite
        private int id_heureConduite;
        private Eleve eleve;
        private int nombreHeures;
        private String dateHeureConduite;
        private String etatHeureConduite;
        private String moniteur;
        #endregion

        #region Constructeur
        //Constructeur
        public heureConduite(int id_heureConduite, Eleve eleve, int nombreHeures, String dateHeureConduite, String moniteur, String etatHeureConduite)
        {
            this.id_heureConduite = id_heureConduite;
            this.eleve = eleve;
            this.nombreHeures = nombreHeures;
            this.dateHeureConduite = dateHeureConduite;
            this.moniteur = moniteur;
            this.etatHeureConduite = etatHeureConduite;
        }
        #endregion

        #region Accesseurs
        //Accesseur de la classe heureConduite
        public int ID_heureConduite
        {
            get { return id_heureConduite; }
            set { id_heureConduite = value; }
        }

        public Eleve Eleve
        {
            get { return eleve; }
        }

        public int NombreHeures
        {
            get { return nombreHeures; }
            set { nombreHeures = value; }
        }

        public String DateHeureConduite
        {
            get { return dateHeureConduite; }
            set { dateHeureConduite = value; }
        }

        public String EtatHeureConduite
        {
            get { return etatHeureConduite; }
            set {  etatHeureConduite = value;}
        }

        public String Moniteur
        {
            get { return moniteur; }
            set { moniteur = value; }
        }
        #endregion
    }
}
