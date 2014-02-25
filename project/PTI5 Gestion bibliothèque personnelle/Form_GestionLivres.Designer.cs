namespace PTI5_Gestion_bibliothèque_personnelle
{
    partial class Form_GestionLivres
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LB_Livres = new System.Windows.Forms.ListBox();
            this.BTN_Ajouter = new System.Windows.Forms.Button();
            this.PB_Image = new System.Windows.Forms.PictureBox();
            this.BTN_Modifier = new System.Windows.Forms.Button();
            this.BTN_Supprimer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_Nom = new System.Windows.Forms.TextBox();
            this.TXT_Auteur = new System.Windows.Forms.TextBox();
            this.LBL_Nom = new System.Windows.Forms.Label();
            this.LBL_Auteur = new System.Windows.Forms.Label();
            this.GRB_Champs = new System.Windows.Forms.GroupBox();
            this.LBL_NbPages = new System.Windows.Forms.Label();
            this.BTN_Valider = new System.Windows.Forms.Button();
            this.TXT_NbPages = new System.Windows.Forms.TextBox();
            this.LBL_Infos_Auteur = new System.Windows.Forms.Label();
            this.LBL_Infos_Titre = new System.Windows.Forms.Label();
            this.LBL_Infos_NbPages = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LBL_Infos_DateAjout = new System.Windows.Forms.Label();
            this.BTN_Retour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Image)).BeginInit();
            this.GRB_Champs.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_Livres
            // 
            this.LB_Livres.FormattingEnabled = true;
            this.LB_Livres.Location = new System.Drawing.Point(17, 42);
            this.LB_Livres.Name = "LB_Livres";
            this.LB_Livres.Size = new System.Drawing.Size(344, 238);
            this.LB_Livres.TabIndex = 0;
            this.LB_Livres.SelectedIndexChanged += new System.EventHandler(this.LB_Livres_SelectedIndexChanged);
            // 
            // BTN_Ajouter
            // 
            this.BTN_Ajouter.Location = new System.Drawing.Point(367, 42);
            this.BTN_Ajouter.Name = "BTN_Ajouter";
            this.BTN_Ajouter.Size = new System.Drawing.Size(169, 27);
            this.BTN_Ajouter.TabIndex = 1;
            this.BTN_Ajouter.Text = "Ajouter un nouveau livre";
            this.BTN_Ajouter.UseVisualStyleBackColor = true;
            this.BTN_Ajouter.Click += new System.EventHandler(this.BTN_Ajouter_Click);
            // 
            // PB_Image
            // 
            this.PB_Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_Image.Image = global::PTI5_Gestion_bibliothèque_personnelle.Properties.Resources.livres;
            this.PB_Image.Location = new System.Drawing.Point(6, 19);
            this.PB_Image.Name = "PB_Image";
            this.PB_Image.Size = new System.Drawing.Size(101, 98);
            this.PB_Image.TabIndex = 3;
            this.PB_Image.TabStop = false;
            // 
            // BTN_Modifier
            // 
            this.BTN_Modifier.Enabled = false;
            this.BTN_Modifier.Location = new System.Drawing.Point(367, 75);
            this.BTN_Modifier.Name = "BTN_Modifier";
            this.BTN_Modifier.Size = new System.Drawing.Size(169, 27);
            this.BTN_Modifier.TabIndex = 2;
            this.BTN_Modifier.Text = "Modifier le livre sélectionné";
            this.BTN_Modifier.UseVisualStyleBackColor = true;
            this.BTN_Modifier.Click += new System.EventHandler(this.BTN_Modifier_Click);
            // 
            // BTN_Supprimer
            // 
            this.BTN_Supprimer.Enabled = false;
            this.BTN_Supprimer.Location = new System.Drawing.Point(367, 108);
            this.BTN_Supprimer.Name = "BTN_Supprimer";
            this.BTN_Supprimer.Size = new System.Drawing.Size(169, 27);
            this.BTN_Supprimer.TabIndex = 3;
            this.BTN_Supprimer.Text = "Supprimer le livre sélectionné";
            this.BTN_Supprimer.UseVisualStyleBackColor = true;
            this.BTN_Supprimer.Click += new System.EventHandler(this.BTN_Supprimer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DodgerBlue;
            this.label2.Font = new System.Drawing.Font("Forte", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Gestion de mes livres";
            // 
            // TXT_Nom
            // 
            this.TXT_Nom.Location = new System.Drawing.Point(27, 36);
            this.TXT_Nom.MaxLength = 32;
            this.TXT_Nom.Name = "TXT_Nom";
            this.TXT_Nom.Size = new System.Drawing.Size(126, 20);
            this.TXT_Nom.TabIndex = 4;
            this.TXT_Nom.Visible = false;
            // 
            // TXT_Auteur
            // 
            this.TXT_Auteur.Location = new System.Drawing.Point(27, 87);
            this.TXT_Auteur.MaxLength = 32;
            this.TXT_Auteur.Name = "TXT_Auteur";
            this.TXT_Auteur.Size = new System.Drawing.Size(126, 20);
            this.TXT_Auteur.TabIndex = 5;
            this.TXT_Auteur.Visible = false;
            // 
            // LBL_Nom
            // 
            this.LBL_Nom.AutoSize = true;
            this.LBL_Nom.Location = new System.Drawing.Point(24, 20);
            this.LBL_Nom.Name = "LBL_Nom";
            this.LBL_Nom.Size = new System.Drawing.Size(68, 13);
            this.LBL_Nom.TabIndex = 10;
            this.LBL_Nom.Text = "Titre du livre:";
            this.LBL_Nom.Visible = false;
            // 
            // LBL_Auteur
            // 
            this.LBL_Auteur.AutoSize = true;
            this.LBL_Auteur.Location = new System.Drawing.Point(24, 71);
            this.LBL_Auteur.Name = "LBL_Auteur";
            this.LBL_Auteur.Size = new System.Drawing.Size(78, 13);
            this.LBL_Auteur.TabIndex = 11;
            this.LBL_Auteur.Text = "Auteur du livre:";
            this.LBL_Auteur.Visible = false;
            // 
            // GRB_Champs
            // 
            this.GRB_Champs.Controls.Add(this.LBL_Nom);
            this.GRB_Champs.Controls.Add(this.LBL_Auteur);
            this.GRB_Champs.Controls.Add(this.TXT_Nom);
            this.GRB_Champs.Controls.Add(this.LBL_NbPages);
            this.GRB_Champs.Controls.Add(this.BTN_Valider);
            this.GRB_Champs.Controls.Add(this.TXT_Auteur);
            this.GRB_Champs.Controls.Add(this.TXT_NbPages);
            this.GRB_Champs.Location = new System.Drawing.Point(367, 151);
            this.GRB_Champs.Name = "GRB_Champs";
            this.GRB_Champs.Size = new System.Drawing.Size(169, 211);
            this.GRB_Champs.TabIndex = 14;
            this.GRB_Champs.TabStop = false;
            this.GRB_Champs.Text = "Mon livre";
            this.GRB_Champs.Visible = false;
            // 
            // LBL_NbPages
            // 
            this.LBL_NbPages.AutoSize = true;
            this.LBL_NbPages.Location = new System.Drawing.Point(24, 126);
            this.LBL_NbPages.Name = "LBL_NbPages";
            this.LBL_NbPages.Size = new System.Drawing.Size(94, 13);
            this.LBL_NbPages.TabIndex = 12;
            this.LBL_NbPages.Text = "Nombre de pages:";
            this.LBL_NbPages.Visible = false;
            // 
            // BTN_Valider
            // 
            this.BTN_Valider.Location = new System.Drawing.Point(49, 178);
            this.BTN_Valider.Name = "BTN_Valider";
            this.BTN_Valider.Size = new System.Drawing.Size(75, 23);
            this.BTN_Valider.TabIndex = 7;
            this.BTN_Valider.Text = "Valider";
            this.BTN_Valider.UseVisualStyleBackColor = true;
            this.BTN_Valider.Click += new System.EventHandler(this.BTN_Valider_Click);
            // 
            // TXT_NbPages
            // 
            this.TXT_NbPages.Location = new System.Drawing.Point(27, 142);
            this.TXT_NbPages.MaxLength = 4;
            this.TXT_NbPages.Name = "TXT_NbPages";
            this.TXT_NbPages.Size = new System.Drawing.Size(39, 20);
            this.TXT_NbPages.TabIndex = 6;
            this.TXT_NbPages.Visible = false;
            this.TXT_NbPages.TextChanged += new System.EventHandler(this.TXT_AnneeSortie_TextChanged);
            // 
            // LBL_Infos_Auteur
            // 
            this.LBL_Infos_Auteur.AutoSize = true;
            this.LBL_Infos_Auteur.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Infos_Auteur.Location = new System.Drawing.Point(113, 66);
            this.LBL_Infos_Auteur.Name = "LBL_Infos_Auteur";
            this.LBL_Infos_Auteur.Size = new System.Drawing.Size(71, 17);
            this.LBL_Infos_Auteur.TabIndex = 15;
            this.LBL_Infos_Auteur.Text = "Ecrit par:";
            // 
            // LBL_Infos_Titre
            // 
            this.LBL_Infos_Titre.AutoSize = true;
            this.LBL_Infos_Titre.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Infos_Titre.Location = new System.Drawing.Point(113, 39);
            this.LBL_Infos_Titre.Name = "LBL_Infos_Titre";
            this.LBL_Infos_Titre.Size = new System.Drawing.Size(43, 17);
            this.LBL_Infos_Titre.TabIndex = 16;
            this.LBL_Infos_Titre.Text = "Titre:";
            // 
            // LBL_Infos_NbPages
            // 
            this.LBL_Infos_NbPages.AutoSize = true;
            this.LBL_Infos_NbPages.Font = new System.Drawing.Font("Forte", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Infos_NbPages.Location = new System.Drawing.Point(113, 92);
            this.LBL_Infos_NbPages.Name = "LBL_Infos_NbPages";
            this.LBL_Infos_NbPages.Size = new System.Drawing.Size(50, 14);
            this.LBL_Infos_NbPages.TabIndex = 17;
            this.LBL_Infos_NbPages.Text = "0 pages";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LBL_Infos_DateAjout);
            this.groupBox1.Controls.Add(this.LBL_Infos_NbPages);
            this.groupBox1.Controls.Add(this.PB_Image);
            this.groupBox1.Controls.Add(this.LBL_Infos_Auteur);
            this.groupBox1.Controls.Add(this.LBL_Infos_Titre);
            this.groupBox1.Location = new System.Drawing.Point(17, 287);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 121);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations sur le livre sélectionné";
            // 
            // LBL_Infos_DateAjout
            // 
            this.LBL_Infos_DateAjout.AutoSize = true;
            this.LBL_Infos_DateAjout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Infos_DateAjout.Location = new System.Drawing.Point(197, 14);
            this.LBL_Infos_DateAjout.Name = "LBL_Infos_DateAjout";
            this.LBL_Infos_DateAjout.Size = new System.Drawing.Size(76, 13);
            this.LBL_Infos_DateAjout.TabIndex = 18;
            this.LBL_Infos_DateAjout.Text = "Livre ajouté le:";
            this.LBL_Infos_DateAjout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BTN_Retour
            // 
            this.BTN_Retour.Location = new System.Drawing.Point(367, 381);
            this.BTN_Retour.Name = "BTN_Retour";
            this.BTN_Retour.Size = new System.Drawing.Size(169, 27);
            this.BTN_Retour.TabIndex = 8;
            this.BTN_Retour.Text = "Retour";
            this.BTN_Retour.UseVisualStyleBackColor = true;
            this.BTN_Retour.Click += new System.EventHandler(this.BTN_Retour_Click);
            // 
            // Form_GestionLivres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(543, 419);
            this.Controls.Add(this.BTN_Retour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTN_Supprimer);
            this.Controls.Add(this.BTN_Modifier);
            this.Controls.Add(this.BTN_Ajouter);
            this.Controls.Add(this.LB_Livres);
            this.Controls.Add(this.GRB_Champs);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_GestionLivres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de mes livres";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_GestionLivres_FormClosed);
            this.Load += new System.EventHandler(this.Form_GestionCD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Image)).EndInit();
            this.GRB_Champs.ResumeLayout(false);
            this.GRB_Champs.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LB_Livres;
        private System.Windows.Forms.Button BTN_Ajouter;
        private System.Windows.Forms.PictureBox PB_Image;
        private System.Windows.Forms.Button BTN_Modifier;
        private System.Windows.Forms.Button BTN_Supprimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_Nom;
        private System.Windows.Forms.TextBox TXT_Auteur;
        private System.Windows.Forms.Label LBL_Nom;
        private System.Windows.Forms.Label LBL_Auteur;
        private System.Windows.Forms.GroupBox GRB_Champs;
        private System.Windows.Forms.Button BTN_Valider;
        private System.Windows.Forms.Label LBL_Infos_Auteur;
        private System.Windows.Forms.Label LBL_Infos_Titre;
        private System.Windows.Forms.Label LBL_Infos_NbPages;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LBL_Infos_DateAjout;
        private System.Windows.Forms.Button BTN_Retour;
        private System.Windows.Forms.Label LBL_NbPages;
        private System.Windows.Forms.TextBox TXT_NbPages;
    }
}