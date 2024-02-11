using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _2023_lib_TANDEM_v3
{
    public class infosCPF
    {
        #region propriétés
        private String numCPF;
        private Eleve eleve;
        private int nbHeure;
        private int tarif;
        private String dateDebut;
        private String dateFin;
        #endregion

        #region Constructeur
        //Constructeur
        public infosCPF(String numCPF, Eleve eleve, int nbHeure, int tarif, String dateDebut, String dateFin) 
        { 
            this.numCPF = numCPF;
            this.eleve = eleve;
            this.nbHeure = nbHeure;
            this.tarif = tarif;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
        }
        #endregion

        #region Accesseurs
        public String NumCPF
        {
            get { return numCPF; }
            set { numCPF = value; }
        }

        public Eleve Eleve
        {
            get { return eleve; }
        }

        public int NbHeure
        {
            get { return nbHeure; }
            set { nbHeure = value; }
        }

        public int Tarif
        {
            get { return tarif; }
            set { tarif = value; }
        }

        public String DateDebut
        {
            get { return dateDebut; }
            set { dateDebut = value; }
        }
        
        public String DateFin
        {
            get { return dateFin; }
            set { dateFin = value; }
        }
        #endregion
    }
}
