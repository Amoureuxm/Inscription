using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using QRCoder;

namespace InscriptionProductionCartes
{
    public partial class CarteEtudiant : Form
    {
        //INSTANCIATION DE LA CLASSE INSCRIPTION

        public Inscription dataInstance;

        public CarteEtudiant(Inscription dataInscription)
        {
            InitializeComponent();

            //AFFECTATION DE L'INSTACIATION

            this.dataInstance = dataInscription;
            LoadDataFromInscription();
            
        }

        private void LoadDataFromInscription()
        {
            //Get Data
            DataForm data = dataInstance.GetDataForm();
            string matricule, nom, postnom, prenom, genre, promotion, numEt;
            matricule = data.matricule;
            nom = data.nom;
            postnom = data.postnom;
            prenom = data.prenom;
            genre = data.sexe;
            promotion = data.promotion;
            numEt = data.numEtudiant;
            Image profil = data.imageEtudiant;

            //SET DATA
            matriculeEtudiant.Text = matricule;
            nomBox.Text = nom +" "+ postnom + " " + prenom ;
            
            genreBox.Text = genre;
            promotionBox.Text = promotion;
            numEtudiant.Text = numEt;
            etudiantPicture.Image = profil;
            
            
        }



        //FONCTION QRCode

        void GenererQR()
        {
           
            QRCodeGenerator QR = new QRCodeGenerator();
            QRCodeData data = QR.CreateQrCode(matriculeEtudiant.Text+"\n"+ nomBox.Text + "\n" +
                promotionBox.Text + "\n" + genreBox.Text + "\n" + numEtudiant.Text + "\n Designed by Phil Bauma",
                QRCodeGenerator.ECCLevel.Q);

            QRCode code = new QRCode(data);
            qrCode.Image = code.GetGraphic(3);
        }

        //AJOUTER UNE IMAGE
        //void SelectImg()
        //{
        //    using(OpenFileDialog image = new OpenFileDialog())
        //    {
        //        image.Title = "Selectionnez une image";
        //        //image.FileName = "Profil";
        //        image.Filter = "Image files(*.jpeg; *.jpg; *.png)| *.jpeg; *.jpg; *.png;";

        //        if(image.ShowDialog() == DialogResult.OK)
        //        {
        //            etudiantPicture.Image = new Bitmap(image.FileName);
        //        }
        //    }
        //}

        private void CarteEtudiant_Load(object sender, EventArgs e)
        {
            
        }

        private void qrCode_MouseHover(object sender, EventArgs e)
        {
            GenererQR();
        }
        
        
   //IMPRESSION

        private void logoULPGL_MouseHover(object sender, EventArgs e)
        {
            // Capturer le contenu du formulaire en tant qu'image
            Bitmap bmp = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));

            // Préparer l'impression
            PrintDocument printDoc = new PrintDocument();
            //En paysage
            printDoc.DefaultPageSettings.Landscape = true;

            printDoc.PrintPage += (s, eArgs) =>
            {
                // Calculer les dimensions pour imprimer l'image en entier
                Rectangle pageArea = eArgs.PageBounds;
                float ratio = Math.Min((float)pageArea.Width / bmp.Width, (float)pageArea.Height / bmp.Height);
                int printWidth = (int)(bmp.Width * ratio);
                int printHeight = (int)(bmp.Height * ratio);
                int marginLeft = (pageArea.Width - printWidth) / 2;
                int marginTop = (pageArea.Height - printHeight) / 2;

                // Dessiner l'image sur le document d'impression
                eArgs.Graphics.DrawImage(bmp, marginLeft, marginTop, printWidth, printHeight);
                eArgs.HasMorePages = false;
            };

            // Afficher la boîte de dialogue d'impression
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDoc;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
            }
        }

        private void drapeauRDC_MouseHover(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
