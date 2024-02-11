using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_lib_TANDEM_v3
{
    public class permis
    {
        #region Propriétés
        //propriétés
        private int id_permis;
        private String libellePermis;
        private String descriptionPermis;
        #endregion

        #region Constructeur
        //Constructeur
        public permis(int id_permis, String libellePermis, String descriptionPermis)
        {
            this.id_permis = id_permis;
            this.libellePermis = libellePermis;
            this.descriptionPermis = descriptionPermis;
        }
        #endregion

        #region Accesseurs
        //Accesseurs
        public int ID_permis
        {
            get { return id_permis; }
            set { id_permis = value; }
        }

        public String LibellePermis
        {
            get { return libellePermis; }
            set { libellePermis = value; }
        }

        public String DesccriptionPermis
        {
            get { return descriptionPermis; }
            set { descriptionPermis = value; }
        }
        #endregion
    }
}
