using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2023_AppliTandem
{
    public partial class FrmConfirmation : Form
    {
        #region Connection à la BDD
        //Connection à la BDD
        MySqlConnection laConnection;
        #endregion

        #region Création de la fenêtre
        //Création de la fenêtre
        public FrmConfirmation(MySqlConnection laConnection)
        {
            this.laConnection = laConnection;

            InitializeComponent();
        }
        #endregion

        #region Bouton Non
        //Fermeture de la fenêtre
        private void btnNon_Click(object sender, EventArgs e)
        {
            // Fermer la fenêtre de confirmation avec la réponse Non (No)
            this.DialogResult = DialogResult.No;
            this.Close();
        }
        #endregion

        #region Bouton Oui
        private void btnOui_Click(object sender, EventArgs e)
        {
            // Fermer la fenêtre de confirmation avec la réponse Oui (Yes)
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }
        #endregion
    }
}
