using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InscriptionProductionCartes
{
    public partial class Login : Form
    {
        public GetData GetDataForm()
        {
            return new GetData
            {
                oldUser = connect[0],
                oldPwd = connect[1]

            };
        }

        //RECEPTION DES DATA USERS DE CHANGEPWD

        public ChangePwd oldUserInstance;

        //DEFAULT CONSTRUTCOR

        public Login()
        {
            InitializeComponent();
            
        }

        //DEFAULT CONSTRUCTOR OVERLOADED
        public Login(ChangePwd dataOldUser)
        {
            InitializeComponent();
            this.oldUserInstance = dataOldUser;
            LoadDataFromChangePwd();
            
        }

        //MISE DES DONEES DANS DES VARIABLES
        private void LoadDataFromChangePwd()
        {
            try
            {
                //Get Data
                NewConnection data = oldUserInstance.GetDataForm();
                string newName, newPassword;
                newName = data.newUser;
                newPassword = data.newPwd;

                //SET DATA IN THE GLOBAL ARRAY VARIABLE connect
                connect[0] = newName;
                connect[1] = newPassword;
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        //VARIABLE GLOBAL ARRAY POUR LES DATA USER

        string[] connect = new string[] { "Henry", "phil" };

        //=========================================================

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //BACKGROUND SETTINGS

            //Les couleurs du degrade
            Color startColor = Color.Black;
            Color endColor = Color.SkyBlue;

            //Zone concernee
            Rectangle rectangle = new Rectangle(0, 0, panel1.Width, panel1.Height);

            //Un pinceau de degrade
            using (LinearGradientBrush brush = new LinearGradientBrush(rectangle, startColor, endColor, LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, rectangle);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Inscription pageInscription = new Inscription();
            
           
            string name = connect[0];
            string password = connect[1];
            if (userName.Text.Equals(name) && passwordBox.Text.Equals(password)){
                
                pageInscription.Show();
                
                
            } else { MessageBox.Show("Incorrect entry"); }
            
        }

        private void btnReconnexion_Click(object sender, EventArgs e)
        {
            ChangePwd pwd = new ChangePwd(this);
            pwd.Show();
        }
    }

        public class GetData
        {
            public string oldUser { get; set; }
            public string oldPwd { get; set; }
            
        }
    
}
