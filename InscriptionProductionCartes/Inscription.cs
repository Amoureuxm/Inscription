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
using QRCoder;
using Excel = Microsoft.Office.Interop.Excel;
using System.Drawing.Printing;


namespace InscriptionProductionCartes
{
    public partial class Inscription : Form
    {
        //INSTANCIATION DE LA VARIABLE TEMP DU PROFIL

        private Image Profil;

        public  DataForm GetDataForm()
        {
            return new DataForm
            {
                matricule = matriculeBox.Text,
                nom = nomBox.Text,
                postnom = postNomBox.Text,
                sexe = genreBox.Text,
                prenom = prenomBox.Text,
                promotion = promotionBox.Text,
                numEtudiant = numEtudiantBox.Text,
                imageEtudiant = Profil
                //etudiantPicture.Image = new Bitmap(image.FileName)

        };
            
            
        }
        
        public Inscription()
        {
            InitializeComponent();
            panel1.Paint += new PaintEventHandler(panel1_Paint);
        }


        //EDITING ROWS

        void EditRows()
        {
            //foreach (DataGridViewRow row in FicheInscription.Rows)
            //{
            try
            {
                //        if (row.IsNewRow)
                //        {
                int row = FicheInscription.Rows.GetRowCount(DataGridViewElementStates.Selected);

                string matricule = FicheInscription.Rows[row].Cells["Matricule"].Value.ToString();
                string nom = FicheInscription.Rows[row].Cells["Nom"].Value.ToString();
                string postnom = FicheInscription.Rows[row].Cells["Postnom"].Value?.ToString();
                string prenom = FicheInscription.Rows[row].Cells["Prenom"].Value.ToString();
                string promotion = FicheInscription.Rows[row].Cells["Promotion"].Value.ToString();
                string numEtudiant = FicheInscription.Rows[row].Cells["N° Étudiant"].Value.ToString();
                string genre = FicheInscription.Rows[row].Cells["Genre"].Value.ToString();
                string date = FicheInscription.Rows[row].Cells[5].Value.ToString();
                string lieuNaissance = FicheInscription.Rows[row].Cells[6].Value.ToString();
                string etatCivil = FicheInscription.Rows[row].Cells["Etat civil"].Value.ToString();
                string Addresse = FicheInscription.Rows[row].Cells["Addresse"].Value.ToString();
                string phone = FicheInscription.Rows[row].Cells["N° Tel"].Value.ToString();
                string nomPere = FicheInscription.Rows[row].Cells["Nom du père"].Value.ToString();
                string nomMere = FicheInscription.Rows[row].Cells["Nom de la mère"].Value.ToString();
                string pourcentage = FicheInscription.Rows[row].Cells["Pourcentage"].Value.ToString();
                string province = FicheInscription.Rows[row].Cells["Province"].Value.ToString();
                string territoire = FicheInscription.Rows[row].Cells["Territoire"].Value.ToString();
                string dossier = FicheInscription.Rows[row].Cells["Dossier déposé"].Value.ToString();



                matriculeBox.Text = matricule;
                nomBox.Text = nom;
                postNomBox.Text = postnom;
                prenomBox.Text = prenom;
                promotionBox.Text = promotion;
                numEtudiantBox.Text = numEtudiant;
                genreBox.Text = genre;
                dateBox.Text = date;
                lieuBox.Text = lieuNaissance;
                etatCivilBox.Text = etatCivil;
                addresseBox.Text = Addresse;
                telBox.Text = phone;
                nomPereBox.Text = nomPere;
                nomMereBox.Text = nomMere;
                pourcentBox.Text = pourcentage;
                provinceBox.Text = province;
                territoireBox.Text = territoire;
                dossierBox.Text = dossier;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //BACKGROUND SETTINGS


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
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

        //Mettre placeholder
        void Placeholder(TextBox box, string word)
        {
            if (string.IsNullOrWhiteSpace(box.Text)/*!box.Equals("")*/)
            {
                box.Text = word;
                box.ForeColor = Color.Gray;
                textBox1.Focus(); //Pour mettre en focus le suivant champ
            }
        }

        //Check

        void Check(TextBox box, string valeur)
        {
            if (string.IsNullOrWhiteSpace(box.Text))
            {
                Placeholder(box, valeur);
            }
            else { }
        }

        //Remove placeholder

        void RemovePlaceholder(TextBox box)
        {
            if (!box.Equals(""))
            {
                box.Clear();
                ForeColor = Color.Black;
            }
        }

        //Table Grideview

        DataTable listEtudiant = new DataTable("listEtudiant");

        // DataGridViewCheckBoxColumn Genre = new DataGridViewCheckBoxColumn();


        //Pour ajouter des colonnes
        void AddColumn()
        {
            /*Genre.HeaderText = "Genre";
            Genre.Name = "genre";
            Genre.TrueValue = true;
            Genre.FalseValue = false;
            Genre.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            FicheInscription.Columns.Add(Genre);
            */

            ForeColor = Color.Black;
            listEtudiant.Columns.Add("Matricule", Type.GetType("System.String"));
            listEtudiant.Columns.Add("Nom", Type.GetType("System.String"));
            listEtudiant.Columns.Add("Postnom", Type.GetType("System.String"));
            listEtudiant.Columns.Add("Prenom", Type.GetType("System.String"));
            listEtudiant.Columns.Add("Promotion", Type.GetType("System.String"));
            listEtudiant.Columns.Add("N° Étudiant", Type.GetType("System.String"));
            listEtudiant.Columns.Add("Genre", Type.GetType("System.String"));
            listEtudiant.Columns.Add("Date de naissance", Type.GetType("System.String"));
            listEtudiant.Columns.Add("Lieu de naissance", Type.GetType("System.String"));
            listEtudiant.Columns.Add("Etat civil", Type.GetType("System.String"));
            listEtudiant.Columns.Add("Addresse", Type.GetType("System.String"));
            listEtudiant.Columns.Add("N° Tel", Type.GetType("System.String"));
            listEtudiant.Columns.Add("Nom du père", Type.GetType("System.String"));
            listEtudiant.Columns.Add("Nom de la mère", Type.GetType("System.String"));
            listEtudiant.Columns.Add("Pourcentage", Type.GetType("System.String"));
            listEtudiant.Columns.Add("Province", Type.GetType("System.String"));
            listEtudiant.Columns.Add("Territoire", Type.GetType("System.String"));
            listEtudiant.Columns.Add("Dossier déposé", Type.GetType("System.String"));
            FicheInscription.DataSource = listEtudiant;



        }

        //Pour ajouter des lignes

        void AddRows()
        {
            try
            {
                ForeColor = Color.Black;
                listEtudiant.Rows.Add(matriculeBox.Text, nomBox.Text, postNomBox.Text,
                    prenomBox.Text,promotionBox.Text,numEtudiantBox.Text, genreBox.Text, dateBox.Text, lieuBox.Text,
                    etatCivilBox.Text, addresseBox.Text, telBox.Text, nomPereBox.Text, nomMereBox.Text,
                    pourcentBox.Text, provinceBox.Text, territoireBox.Text, dossierBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Enreigistrer en Excel
        //Exportation DatatGrid

        void Exportation()
        {
            try
            {
                //Creer Excel
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();

                //Creation du workbook
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                app.Visible = true;

                //Creation de la feuille Excel
                Microsoft.Office.Interop.Excel._Worksheet sheet = null;
                sheet = workbook.Sheets["Feuil1"];
                sheet = workbook.ActiveSheet;
                sheet.Name = "Etudiants inscrits";

                //Exportation du titre
                for (int i = 1; i <= FicheInscription.Columns.Count; i++)
                {
                    sheet.Cells[1, i] = FicheInscription.Columns[i - 1].HeaderText;
                }

                //Exportation Contenu

                for (int i = 0; i < listEtudiant.Rows.Count; i++)
                {
                    for (int j = 0; j < listEtudiant.Columns.Count; j++)
                    {
                        if (FicheInscription.Rows[i].Cells[j].Value != null)
                        {
                            sheet.Cells[i + 2, j + 1] = FicheInscription.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    //sheet.Cells[1, j] = dataGridView1.Rows[i - 1];
                }



                //workbook.SaveAs("c:\\Vente.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                app.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        //FONCTION QRCode

        void GenererQR()
        {
            QRCodeGenerator QR = new QRCodeGenerator();
            QRCodeData data = QR.CreateQrCode(nomBox.Text+postNomBox.Text+prenomBox.Text+
                promotionBox.Text+genreBox.Text+pourcentBox.Text+dossierBox.Text, QRCodeGenerator.ECCLevel.Q);

            QRCode code = new QRCode(data);
            pictureQR.Image = code.GetGraphic(3);
        }


        //AJOUTER UNE IMAGE
        void SelectImg()
        {
            using (OpenFileDialog image = new OpenFileDialog())
            {
                image.Title = "Selectionnez une image";
                //image.FileName = "Profil";
                image.Filter = "Image files(*.jpeg; *.jpg; *.png)| *.jpeg; *.jpg; *.png;";

                if (image.ShowDialog() == DialogResult.OK)
                {
                    Image tempImg = Image.FromFile(image.FileName);
                    Profil = tempImg;
                    //etudiantPicture.Image = new Bitmap(image.FileName);
                }
            }
        }

        //Placeholder Simple
        void Place(TextBox box)
        {
            box.Clear();
            box.ForeColor = Color.DarkBlue;
            box.CharacterCasing = CharacterCasing.Upper;
            Font text = new Font("Lucida Sans Unicode", 10);
            box.Font = text;
            emailBox.CharacterCasing = CharacterCasing.Lower;
        }


        private void Inscription_Load(object sender, EventArgs e)
        {

        }

        private void matriculeBox_Click(object sender, EventArgs e)
        {
            Place(matriculeBox);
        }

        private void nomBox_Click(object sender, EventArgs e)
        {
            Place(nomBox);
        }


        private void postNomBox_Click(object sender, EventArgs e)
        {
            Place(postNomBox);
        }

        private void prenomBox_Click(object sender, EventArgs e)
        {
            Place(prenomBox);
        }

        private void lieuBox_Click(object sender, EventArgs e)
        {
            Place(lieuBox);
        }

        private void addresseBox_Click(object sender, EventArgs e)
        {
            Place(addresseBox);
        }

        private void nomPereBox_Click(object sender, EventArgs e)
        {
            Place(nomPereBox);
        }

        private void nomMereBox_Click(object sender, EventArgs e)
        {
            Place(nomMereBox);
        }

        private void provinceBox_Click(object sender, EventArgs e)
        {
            Place(provinceBox);
        }

        private void territoireBox_Click(object sender, EventArgs e)
        {
            Place(territoireBox);
        }

        private void Inscription_Load_1(object sender, EventArgs e)
        {
            AddColumn();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddRows();
            FicheInscription.ForeColor = Color.DarkBlue;
            GenererQR();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Exportation();
            
        }

        private void promotionBox_Click(object sender, EventArgs e)
        {
            Place(promotionBox);
        }

        private void numEtudiantBox_Click(object sender, EventArgs e)
        {
            Place(numEtudiantBox);
        }



        private void montantLettreBox_Click(object sender, EventArgs e)
        {
            Place(montantLettreBox);
        }

        private void emailBox_Click(object sender, EventArgs e)
        {
            Place(emailBox);
        }

        /*
        //DOCUMENTATION

            private void button1_Click(object sender, EventArgs e)
        {

            //// Capturer le contenu du formulaire en tant qu'image
            //Bitmap bmp = new Bitmap(this.Width, this.Height);
            //this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));

            //// Préparer l'impression
            //PrintDocument printDoc = new PrintDocument();
            ////printDoc.PrintController += ;
            //printDoc.PrintPage += (s, eArgs) =>
            //{
            //    // Calculer les dimensions pour imprimer l'image en entier
            //    Rectangle pageArea = eArgs.PageBounds;
            //    float ratio = Math.Min((float)pageArea.Width / bmp.Width, (float)pageArea.Height / bmp.Height);
            //    int printWidth = (int)(bmp.Width * ratio);
            //    int printHeight = (int)(bmp.Height * ratio);
            //    int marginLeft = (pageArea.Width - printWidth) / 2;
            //    int marginTop = (pageArea.Height - printHeight) / 2;

            //    // Dessiner l'image sur le document d'impression
            //    eArgs.Graphics.DrawImage(bmp, marginLeft, marginTop, printWidth, printHeight);
            //    eArgs.HasMorePages = false;
            //};

            //// Afficher la boîte de dialogue d'impression
            //PrintDialog printDialog = new PrintDialog();
            //printDialog.Document = printDoc;
            //if (printDialog.ShowDialog() == DialogResult.OK)
            //{
            //    printDoc.Print();
            //}

            
        }



        //Pour les fenetres
        //this.WindowState = FormWindowState.Minimized;
        //this.Close();
        //this.WindowState = FormWindowState.Maximized;


        //CODE JAVA POUR EDIT DATAGRIDVIEW

        /*private void tableVenteMouseClicked(java.awt.event.MouseEvent evt) {
            // TODO add your handling code here:
            DefaultTableModel table = (DefaultTableModel)tableVente.getModel();
            String tableId = table.getValueAt(tableVente.getSelectedRow(), 0).toString();
            String tableName = table.getValueAt(tableVente.getSelectedRow(), 1).toString();
            String tableCode = table.getValueAt(tableVente.getSelectedRow(), 2).toString();
            String tableProduit = table.getValueAt(tableVente.getSelectedRow(), 3).toString();
            String tableQuantite = table.getValueAt(tableVente.getSelectedRow(), 4).toString();
            String tablePrixUnit = table.getValueAt(tableVente.getSelectedRow(), 5).toString();
            String tablePrixTotal = table.getValueAt(tableVente.getSelectedRow(), 6).toString();


            idBox.setText(tableId);
            nomClientBox.setText(tableName);
            codeBox.setText(tableCode);
            quantiteBox.setText(tableQuantite);
            prixUnitBox.setText(tablePrixUnit);
            prixTotalBox.setText(tablePrixTotal);


        }

        private void btnUpdateActionPerformed(java.awt.event.ActionEvent evt) {
            // TODO add your handling code here:
            DefaultTableModel table = (DefaultTableModel)tableVente.getModel();
            if (tableVente.getSelectedRowCount() == 1)
            {
                String id = idBox.getText();
                String nom = nomClientBox.getText();
                String code = codeBox.getText();
                String produit = produitBox.getSelectedItem().toString();
                String quantite = quantiteBox.getText();
                String prixUnit = prixUnitBox.getText();
                String prixTotal = prixUnitBox.getText();


                table.setValueAt(id, tableVente.getSelectedRow(), 0);
                table.setValueAt(nom, tableVente.getSelectedRow(), 1);
                table.setValueAt(code, tableVente.getSelectedRow(), 2);
                table.setValueAt(produit, tableVente.getSelectedRow(), 3);
                table.setValueAt(quantite, tableVente.getSelectedRow(), 4);
                table.setValueAt(prixUnit, tableVente.getSelectedRow(), 5);
                table.setValueAt(prixTotal, tableVente.getSelectedRow(), 6);
                JOptionPane.showMessageDialog(this, "Update sucessfully");

            }
            else if (tableVente.getRowCount() == 0)
            {
                JOptionPane.showMessageDialog(this, "Le tableau est vide");
            }
            else { JOptionPane.showMessageDialog(this, "Please select single to update"); }


        }
        }
        
            //CODE C# POUR EDIT DATAGRIDVIEW
            
            foreach (DataGridViewRow row in FicheInscription.Rows)
            {
                try
                {
                    if (row.IsNewRow)
                    {
                        string matricule = FicheInscription.Rows[0].Cells["Matricule"].Value.ToString();
                        string nom = row.Cells["Nom"].Value.ToString();
                        string postnom = row.Cells["Postnom"].Value.ToString();
                        string prenom = row.Cells["Prenom"].Value.ToString();
                        string genre = row.Cells["Genre"].Value.ToString();
                        string date = row.Cells[5].Value.ToString();
                        string lieuNaissance = row.Cells[6].Value.ToString();
                        string etatCivil = row.Cells["Etat civil"].Value.ToString();
                        string Addresse = row.Cells["Addresse"].Value.ToString();
                        string phone = row.Cells["N° Tel"].Value.ToString();
                        string nomPere = row.Cells["Nom du père"].Value.ToString();
                        string nomMere = row.Cells["Nom de la mère"].Value.ToString();
                        string pourcentage = row.Cells["Pourcentage"].Value.ToString();
                        string province = row.Cells["Province"].Value.ToString();
                        string territoire = row.Cells["Territoire"].Value.ToString();
                        string dossier = row.Cells["Dossier déposé"].Value.ToString();



                        matriculeBox.Text = matricule;
                        nomBox.Text = nom;
                        postNomBox.Text = postnom;
                        prenomBox.Text = prenom;
                        genreBox.Text = genre;
                        dateBox.Text = date;
                        lieuBox.Text = lieuNaissance;
                        etatCivilBox.Text = etatCivil;
                        addresseBox.Text = Addresse;
                        telBox.Text = phone;
                        nomPereBox.Text = nomPere;
                        nomMereBox.Text = nomMere;
                        pourcentBox.Text = pourcentage;
                        provinceBox.Text = province;
                        territoireBox.Text = territoire;
                        dossierBox.Text = dossier;
                    }
                    
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            */

        private void FicheInscription_Click(object sender, EventArgs e)
        {
            EditRows();
        }

        private void printCard_Click(object sender, EventArgs e)
        {
            CarteEtudiant carte = new CarteEtudiant(this);
            carte.Show();
            
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            SelectImg();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
    public class DataForm
    {
        public string matricule { get; set; }
        public string nom { get; set; }
        public string postnom { get; set; }
        public string prenom { get; set; }
        public string sexe { get; set; }
        public string promotion { get; set; }
        public string numEtudiant { get; set; }
        public Image imageEtudiant { get; set; }
    }
}
    