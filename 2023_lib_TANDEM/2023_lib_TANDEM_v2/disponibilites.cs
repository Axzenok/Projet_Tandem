using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_lib_TANDEM_v3
{
    
    public class disponibilites
    {
        #region Propriétés
        //Propriétés
        private int id_disponibilites;
        private Eleve eleve;
        private String jour;
        private String heureDebut;
        private String heureFin;
        #endregion

        #region Contructeur
        //Constructeur
        public disponibilites(int id_disponibilites, Eleve eleve, String jour, String heureDebut, String heureFin)
        {
            this.id_disponibilites = id_disponibilites;
            this.eleve = eleve;
            this.jour = jour;
            this.heureDebut = heureDebut;
            this.heureFin = heureFin;
        }
        #endregion

        #region Accesseurs
        //Accesseurs
        public int ID_disponibilites
        {
            get { return id_disponibilites; }
            set { id_disponibilites = value; }
        }

        public Eleve Eleve
        {
            get { return eleve; }
        }

        public String Jour
        {
            get { return jour; }
            set { jour = value; }
        }

        public String HeureDebut
        {
            get { return heureDebut; }
            set { heureDebut = value; }
        }

        public String HeureFin 
        {
            get { return heureFin; }
            set { heureFin = value; }
        }
        #endregion

    }
}
