using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assigment_CARRON_GASCOIN_KERGALE
{
    public partial class Form1 : Form
    {
        //lien avec les classes
        private DateExport exporter;
        private DataImport importer;
        private Dictionary<string, string> MatYoungDict;
        private Calcul calculateur;
       

        public Form1()
        {
            //Initialiser les objets
            InitializeComponent();
            exporter = new DateExport();
            importer = new DataImport();
            MatYoungDict = new Dictionary<string, string>();
            calculateur = new Calcul();

            //on assigne les deux possibilité au forme_comboBox
            forme_comboBox.Items.Add("rectangulaire");
            forme_comboBox.Items.Add("circulaire");
            
        }

        private void calculer_button_Click(object sender, EventArgs e)
        {
            //Lorque l'on click sur calculer
            try
            {
                if (forme_comboBox.Text.Contains("rectangulaire"))//on choisi rectangulaire
                {
                    //calcul du moment
                    moment_textBox.Text = calculateur.moment_rectangle(Double.Parse(largeur_textBox.Text), Double.Parse(epaisseur_textBox.Text)).ToString();
                    //calcul de la fleche
                    resultat_textBox.Text = calculateur.fleche(Double.Parse(charge_textBox.Text), Double.Parse(longueur_textBox.Text), Int32.Parse(module_textBox.Text), Double.Parse(moment_textBox.Text)).ToString();
                    
                }
                else if (forme_comboBox.Text.Contains("circulaire"))//on choisi circulaire
                {
                    //calcul du moment
                    moment_textBox.Text = calculateur.moment_circulaire(Double.Parse(diametre_textBox.Text)).ToString();
                    //calcul de la fleche
                    resultat_textBox.Text = calculateur.fleche(Double.Parse(charge_textBox.Text), Double.Parse(longueur_textBox.Text), Int32.Parse(module_textBox.Text), Double.Parse(moment_textBox.Text)).ToString();
                }
                else
                {
                    //si rien
                    MessageBox.Show("Veuillez saisir la forme");
                }
                //exporter les résultats dans sous cette forme dans le fichier .txt
                exporter.calculs(DateTime.Now + " : La flèche est égale à : " + resultat_textBox.Text + " pour une poutre de forme " + forme_comboBox.Text + " en " + materiau_comboBox.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, "The file could not be read:");
            }
                

        }

        private void export_button_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void import_button_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            //je passe le chemin du nouveau fichier calcul à mon exporter
            //grâce a la propriété ClaculFile qui modifie l'attribut privé calculFile
            exporter.CalculFile = saveFileDialog1.FileName;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            //on remplis le materiau_combobos avec les données key du dictionnaire MatYoungDict
            MatYoungDict = importer.ImportMatYoungFromFile(openFileDialog1.FileName);
            materiau_comboBox.DataSource = new BindingSource(MatYoungDict.Keys, null);

        }

        private void materiau_comboBox_TextChanged(object sender, EventArgs e)
        {
            //On Activate affiche dans le TextBox la valeur du moldule de MatYoungDict correspondant AutoCompleteMode matériau 
            module_textBox.Text = MatYoungDict[materiau_comboBox.Text];
        }

        private void forme_comboBox_TextChanged(object sender, EventArgs e)
        {
            //On grise les valeurs inutiles et on les réinitialise
            if (forme_comboBox.Text.Contains("rectangulaire"))
            {
                diametre_textBox.Text = "";
                charge_textBox.Text = " ";
                longueur_textBox.Text = " ";
                diametre_textBox.ReadOnly = true;
                largeur_textBox.ReadOnly = false;
                epaisseur_textBox.ReadOnly = false;
               

            }
            else if (forme_comboBox.Text.Contains("circulaire"))
            {
                //On grise les valeurs inutiles et les réinitialise
                largeur_textBox.Text = " ";
                epaisseur_textBox.Text = " ";
                charge_textBox.Text = " ";
                longueur_textBox.Text = " ";
                largeur_textBox.ReadOnly = true;
                epaisseur_textBox.ReadOnly = true;
                diametre_textBox.ReadOnly = false;
                


            }
        }

      

    }
}
