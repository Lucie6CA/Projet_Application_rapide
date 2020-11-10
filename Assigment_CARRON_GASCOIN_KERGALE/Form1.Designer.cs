namespace Assigment_CARRON_GASCOIN_KERGALE
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.longueur_label = new System.Windows.Forms.Label();
            this.longueur_textBox = new System.Windows.Forms.TextBox();
            this.forme_label = new System.Windows.Forms.Label();
            this.forme_comboBox = new System.Windows.Forms.ComboBox();
            this.materiau_comboBox = new System.Windows.Forms.ComboBox();
            this.materiau_label = new System.Windows.Forms.Label();
            this.module_label = new System.Windows.Forms.Label();
            this.module_textBox = new System.Windows.Forms.TextBox();
            this.largeur_label = new System.Windows.Forms.Label();
            this.largeur_textBox = new System.Windows.Forms.TextBox();
            this.epaisseur_label = new System.Windows.Forms.Label();
            this.epaisseur_textBox = new System.Windows.Forms.TextBox();
            this.diametre_textBox = new System.Windows.Forms.TextBox();
            this.diametre_label = new System.Windows.Forms.Label();
            this.charge_label = new System.Windows.Forms.Label();
            this.charge_textBox = new System.Windows.Forms.TextBox();
            this.calculer_button = new System.Windows.Forms.Button();
            this.resultat_textBox = new System.Windows.Forms.TextBox();
            this.import_button = new System.Windows.Forms.Button();
            this.export_button = new System.Windows.Forms.Button();
            this.moment_label = new System.Windows.Forms.Label();
            this.moment_textBox = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.circulaire_pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circulaire_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // longueur_label
            // 
            this.longueur_label.AutoSize = true;
            this.longueur_label.Location = new System.Drawing.Point(59, 195);
            this.longueur_label.Name = "longueur_label";
            this.longueur_label.Size = new System.Drawing.Size(102, 17);
            this.longueur_label.TabIndex = 0;
            this.longueur_label.Text = "Longueur (m) :";
            // 
            // longueur_textBox
            // 
            this.longueur_textBox.Location = new System.Drawing.Point(252, 195);
            this.longueur_textBox.Name = "longueur_textBox";
            this.longueur_textBox.Size = new System.Drawing.Size(121, 22);
            this.longueur_textBox.TabIndex = 1;
            // 
            // forme_label
            // 
            this.forme_label.AutoSize = true;
            this.forme_label.Location = new System.Drawing.Point(59, 76);
            this.forme_label.Name = "forme_label";
            this.forme_label.Size = new System.Drawing.Size(140, 17);
            this.forme_label.TabIndex = 2;
            this.forme_label.Text = "Forme de la section :";
            // 
            // forme_comboBox
            // 
            this.forme_comboBox.FormattingEnabled = true;
            this.forme_comboBox.Location = new System.Drawing.Point(252, 73);
            this.forme_comboBox.Name = "forme_comboBox";
            this.forme_comboBox.Size = new System.Drawing.Size(121, 24);
            this.forme_comboBox.TabIndex = 3;
            this.forme_comboBox.TextChanged += new System.EventHandler(this.forme_comboBox_TextChanged);
            // 
            // materiau_comboBox
            // 
            this.materiau_comboBox.FormattingEnabled = true;
            this.materiau_comboBox.Location = new System.Drawing.Point(431, 322);
            this.materiau_comboBox.Name = "materiau_comboBox";
            this.materiau_comboBox.Size = new System.Drawing.Size(121, 24);
            this.materiau_comboBox.TabIndex = 4;
            this.materiau_comboBox.TextChanged += new System.EventHandler(this.materiau_comboBox_TextChanged);
            // 
            // materiau_label
            // 
            this.materiau_label.AutoSize = true;
            this.materiau_label.Location = new System.Drawing.Point(292, 325);
            this.materiau_label.Name = "materiau_label";
            this.materiau_label.Size = new System.Drawing.Size(133, 17);
            this.materiau_label.TabIndex = 5;
            this.materiau_label.Text = "Choix du matériau : ";
            // 
            // module_label
            // 
            this.module_label.AutoSize = true;
            this.module_label.Location = new System.Drawing.Point(615, 328);
            this.module_label.Name = "module_label";
            this.module_label.Size = new System.Drawing.Size(160, 17);
            this.module_label.TabIndex = 6;
            this.module_label.Text = "Module d\'Young (GPa) :";
            // 
            // module_textBox
            // 
            this.module_textBox.Location = new System.Drawing.Point(810, 325);
            this.module_textBox.Name = "module_textBox";
            this.module_textBox.ReadOnly = true;
            this.module_textBox.Size = new System.Drawing.Size(100, 22);
            this.module_textBox.TabIndex = 7;
            // 
            // largeur_label
            // 
            this.largeur_label.AutoSize = true;
            this.largeur_label.Location = new System.Drawing.Point(549, 198);
            this.largeur_label.Name = "largeur_label";
            this.largeur_label.Size = new System.Drawing.Size(95, 17);
            this.largeur_label.TabIndex = 8;
            this.largeur_label.Text = "Largeur (m) : ";
            // 
            // largeur_textBox
            // 
            this.largeur_textBox.Location = new System.Drawing.Point(641, 195);
            this.largeur_textBox.Name = "largeur_textBox";
            this.largeur_textBox.Size = new System.Drawing.Size(100, 22);
            this.largeur_textBox.TabIndex = 9;
            // 
            // epaisseur_label
            // 
            this.epaisseur_label.AutoSize = true;
            this.epaisseur_label.Location = new System.Drawing.Point(754, 198);
            this.epaisseur_label.Name = "epaisseur_label";
            this.epaisseur_label.Size = new System.Drawing.Size(104, 17);
            this.epaisseur_label.TabIndex = 10;
            this.epaisseur_label.Text = "Epaisseur (m) :";
            // 
            // epaisseur_textBox
            // 
            this.epaisseur_textBox.Location = new System.Drawing.Point(864, 195);
            this.epaisseur_textBox.Name = "epaisseur_textBox";
            this.epaisseur_textBox.Size = new System.Drawing.Size(100, 22);
            this.epaisseur_textBox.TabIndex = 11;
            // 
            // diametre_textBox
            // 
            this.diametre_textBox.Location = new System.Drawing.Point(653, 73);
            this.diametre_textBox.Name = "diametre_textBox";
            this.diametre_textBox.Size = new System.Drawing.Size(100, 22);
            this.diametre_textBox.TabIndex = 12;
            // 
            // diametre_label
            // 
            this.diametre_label.AutoSize = true;
            this.diametre_label.Location = new System.Drawing.Point(549, 76);
            this.diametre_label.Name = "diametre_label";
            this.diametre_label.Size = new System.Drawing.Size(98, 17);
            this.diametre_label.TabIndex = 13;
            this.diametre_label.Text = "Diametre (m) :";
            // 
            // charge_label
            // 
            this.charge_label.AutoSize = true;
            this.charge_label.Location = new System.Drawing.Point(59, 132);
            this.charge_label.Name = "charge_label";
            this.charge_label.Size = new System.Drawing.Size(152, 17);
            this.charge_label.TabIndex = 14;
            this.charge_label.Text = "Charge appliquée (N) :";
            // 
            // charge_textBox
            // 
            this.charge_textBox.Location = new System.Drawing.Point(252, 132);
            this.charge_textBox.Name = "charge_textBox";
            this.charge_textBox.Size = new System.Drawing.Size(121, 22);
            this.charge_textBox.TabIndex = 15;
            // 
            // calculer_button
            // 
            this.calculer_button.Location = new System.Drawing.Point(301, 393);
            this.calculer_button.Name = "calculer_button";
            this.calculer_button.Size = new System.Drawing.Size(369, 45);
            this.calculer_button.TabIndex = 16;
            this.calculer_button.Text = "Calculer";
            this.calculer_button.UseVisualStyleBackColor = true;
            this.calculer_button.Click += new System.EventHandler(this.calculer_button_Click);
            // 
            // resultat_textBox
            // 
            this.resultat_textBox.Location = new System.Drawing.Point(282, 466);
            this.resultat_textBox.Name = "resultat_textBox";
            this.resultat_textBox.ReadOnly = true;
            this.resultat_textBox.Size = new System.Drawing.Size(183, 22);
            this.resultat_textBox.TabIndex = 17;
            // 
            // import_button
            // 
            this.import_button.Location = new System.Drawing.Point(39, 315);
            this.import_button.Name = "import_button";
            this.import_button.Size = new System.Drawing.Size(206, 37);
            this.import_button.TabIndex = 18;
            this.import_button.Text = "Importer les données";
            this.import_button.UseVisualStyleBackColor = true;
            this.import_button.Click += new System.EventHandler(this.import_button_Click);
            // 
            // export_button
            // 
            this.export_button.Location = new System.Drawing.Point(50, 515);
            this.export_button.Name = "export_button";
            this.export_button.Size = new System.Drawing.Size(914, 44);
            this.export_button.TabIndex = 19;
            this.export_button.Text = "Exporter les calculs";
            this.export_button.UseVisualStyleBackColor = true;
            this.export_button.Click += new System.EventHandler(this.export_button_Click);
            // 
            // moment_label
            // 
            this.moment_label.AutoSize = true;
            this.moment_label.Location = new System.Drawing.Point(500, 469);
            this.moment_label.Name = "moment_label";
            this.moment_label.Size = new System.Drawing.Size(191, 17);
            this.moment_label.TabIndex = 20;
            this.moment_label.Text = "Moment quadratrique (m^4) :";
            // 
            // moment_textBox
            // 
            this.moment_textBox.Location = new System.Drawing.Point(706, 464);
            this.moment_textBox.Name = "moment_textBox";
            this.moment_textBox.ReadOnly = true;
            this.moment_textBox.Size = new System.Drawing.Size(127, 22);
            this.moment_textBox.TabIndex = 21;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "calculs.txt";
            this.saveFileDialog1.Filter = "Text(.txt)|*.txt";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = ".abaque";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.ImageLocation = "C:\\Users\\i.kergale\\Documents\\Visual Studio 2013\\Projects\\Assigment_CARRON_GASCOIN" +
    "_KERGALE";
            this.pictureBox2.Location = new System.Drawing.Point(424, 132);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 129);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // circulaire_pictureBox
            // 
            this.circulaire_pictureBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("circulaire_pictureBox.ErrorImage")));
            this.circulaire_pictureBox.ImageLocation = "C:\\Users\\i.kergale\\Documents\\Visual Studio 2013\\Projects\\Assigment_CARRON_GASCOIN" +
    "_KERGALE";
            this.circulaire_pictureBox.Location = new System.Drawing.Point(424, 38);
            this.circulaire_pictureBox.Name = "circulaire_pictureBox";
            this.circulaire_pictureBox.Size = new System.Drawing.Size(100, 88);
            this.circulaire_pictureBox.TabIndex = 22;
            this.circulaire_pictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 469);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Flèche (m) :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 580);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.circulaire_pictureBox);
            this.Controls.Add(this.moment_textBox);
            this.Controls.Add(this.moment_label);
            this.Controls.Add(this.export_button);
            this.Controls.Add(this.import_button);
            this.Controls.Add(this.resultat_textBox);
            this.Controls.Add(this.calculer_button);
            this.Controls.Add(this.charge_textBox);
            this.Controls.Add(this.charge_label);
            this.Controls.Add(this.diametre_label);
            this.Controls.Add(this.diametre_textBox);
            this.Controls.Add(this.epaisseur_textBox);
            this.Controls.Add(this.epaisseur_label);
            this.Controls.Add(this.largeur_textBox);
            this.Controls.Add(this.largeur_label);
            this.Controls.Add(this.module_textBox);
            this.Controls.Add(this.module_label);
            this.Controls.Add(this.materiau_label);
            this.Controls.Add(this.materiau_comboBox);
            this.Controls.Add(this.forme_comboBox);
            this.Controls.Add(this.forme_label);
            this.Controls.Add(this.longueur_textBox);
            this.Controls.Add(this.longueur_label);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circulaire_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label longueur_label;
        private System.Windows.Forms.TextBox longueur_textBox;
        private System.Windows.Forms.Label forme_label;
        private System.Windows.Forms.ComboBox forme_comboBox;
        private System.Windows.Forms.ComboBox materiau_comboBox;
        private System.Windows.Forms.Label materiau_label;
        private System.Windows.Forms.Label module_label;
        private System.Windows.Forms.TextBox module_textBox;
        private System.Windows.Forms.Label largeur_label;
        private System.Windows.Forms.TextBox largeur_textBox;
        private System.Windows.Forms.Label epaisseur_label;
        private System.Windows.Forms.TextBox epaisseur_textBox;
        private System.Windows.Forms.TextBox diametre_textBox;
        private System.Windows.Forms.Label diametre_label;
        private System.Windows.Forms.Label charge_label;
        private System.Windows.Forms.TextBox charge_textBox;
        private System.Windows.Forms.Button calculer_button;
        private System.Windows.Forms.TextBox resultat_textBox;
        private System.Windows.Forms.Button import_button;
        private System.Windows.Forms.Button export_button;
        private System.Windows.Forms.Label moment_label;
        private System.Windows.Forms.TextBox moment_textBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox circulaire_pictureBox;
        private System.Windows.Forms.Label label1;
    }
}

