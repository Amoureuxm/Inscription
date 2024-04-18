using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InscriptionProductionCartes
{
    //INSTANCIATION DE LA CLASSE INSCRIPTION

    
    public partial class ChangePwd : Form
    {

        //ENVOIE DES DONNEES DE NEW USER DANS LOGIN

        public NewConnection GetDataForm()
        {
            return new NewConnection
            {
                newUser = userName.Text,
                newPwd = passwordBox.Text

            };
        }

        //instanciation de RECEPTION DES DONNEES DE OLD USER DE LOGIN
        public Login loginInstance;
        public ChangePwd(Login DataLogin)
        {
            InitializeComponent();
            this.loginInstance = DataLogin;
            LoadDataFromLogin();

        }

        //MISE DES DONEES DANS DES VARIABLES
        private void LoadDataFromLogin()
        {
            /*
            //Get Data
            GetData data = loginInstance.GetDataForm();
            string nom, password;
            nom = data.oldUser;
            password = data.oldPwd;
   
                    

            //SET DATA
                    oldUser.Text = nom;
                    oldPwd.Text = password;

            */

        }

        private void btnChgPwd_Click(object sender, EventArgs e)
        {
            //Get Data
            GetData data = loginInstance.GetDataForm();
            string nom, password;
            nom = data.oldUser;
            password = data.oldPwd;
            
            if (oldUser.Text.Equals(nom) && passwordBox.Text.Equals(password))
            {
                MessageBox.Show("Change successfull !");
                Login logPage = new Login();
                logPage.Show();
            }
            else { MessageBox.Show("Old entries are incorect! \n Please put the right usernane and password"); }
        }
    }

    //CLASSE DE VARIABLES POUR ENVOIE DE DATA

    public class NewConnection
    {
        public string newUser { get; set; }
        public string newPwd { get; set; }

    }
}