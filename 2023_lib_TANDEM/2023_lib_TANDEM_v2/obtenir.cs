using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_lib_TANDEM_v3
{
    public class obtenir
    {
        #region Propriétés
        //Propriétés
        private permis permis;
        private Eleve eleve;
        private String dateObtentionPermis;
        private String centreExamen;
        #endregion

        #region Constructeur
        //Constructeur
        public obtenir(permis permis, Eleve eleve, String dateObtentionPermis, string centreExamen)
        {
            this.permis = permis;
            this.eleve = eleve;
            this.dateObtentionPermis = dateObtentionPermis;
            this.centreExamen = centreExamen;
        }
        #endregion

        #region Accesseurs
        //Accesseurs
        public permis Permis
        {
            get { return permis; }
        }

        public Eleve Eleve
        {
            get { return eleve; }
        }

        public String DateObtentionPermis
        {
            get { return dateObtentionPermis; }
            set { dateObtentionPermis = value; }
        }

        public String CentreExamen
        {
            get { return centreExamen; }
            set { centreExamen = value;}
        }
        #endregion
    }
}
