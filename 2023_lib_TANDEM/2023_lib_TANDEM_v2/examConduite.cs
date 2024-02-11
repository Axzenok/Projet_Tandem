using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_lib_TANDEM_v3
{
    public class examConduite
    {
        #region Propriétés
        //propriétés
        private int id_examConduite;
        private Eleve eleve;
        private String dateExam;
        private bool reussite; //Indique si l'élève à réussi son examen
        #endregion

        #region Constructeur
        //Constructeur
        public examConduite(int id_examConduite, Eleve eleve, String dateExam, bool reussite)
        {
            this.id_examConduite = id_examConduite;
            this.eleve = eleve;
            this.dateExam = dateExam;
            this.reussite = reussite;
        }
        #endregion

        #region Accesseurs
        //Accesseurs
        public int ID_examConduite
        {
            get { return id_examConduite; }
            set { id_examConduite = value; }
        }

        public Eleve Eleve
        {
            get { return eleve; }
        }

        public String DateExam
        {
            get { return dateExam; }
            set { dateExam = value; }
        }

        public bool Reussite
        {
            get { return reussite; }
            set { reussite = value; }
        }
        #endregion
    }
}
