namespace PTI5_Gestion_bibliothèque_personnelle
{
    partial class Form_GestionFilms
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
            this.LB_Films = new System.Windows.Forms.ListBox();
            this.BTN_Ajouter = new System.Windows.Forms.Button();
            this.PB_Image = new System.Windows.Forms.PictureBox();
            this.BTN_Modifier = new System.Windows.Forms.Button();
            this.BTN_Supprimer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_Titre = new System.Windows.Forms.TextBox();
            this.TXT_AnneeSortie = new System.Windows.Forms.TextBox();
            this.LBL_Titre = new System.Windows.Forms.Label();
            this.LBL_Langue = new System.Windows.Forms.Label();
            this.LBL_AnneeSortie = new System.Windows.Forms.Label();
            this.GRB_Champs = new System.Windows.Forms.GroupBox();
            this.TXT_Langue = new System.Windows.Forms.TextBox();
            this.LBL_TypeMedia = new System.Windows.Forms.Label();
            this.CB_TypeMedia = new System.Windows.Forms.ComboBox();
            this.BTN_Valider = new System.Windows.Forms.Button();
            this.LBL_Infos_DateSortie = new System.Windows.Forms.Label();
            this.LBL_Infos_Titre = new System.Windows.Forms.Label();
            this.LBL_Infos_Annee = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LBL_Infos_Support = new System.Windows.Forms.Label();
            this.LBL_Infos_DateAjout = new System.Windows.Forms.Label();
            this.BTN_Retour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Image)).BeginInit();
            this.GRB_Champs.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_Films
            // 
            this.LB_Films.FormattingEnabled = true;
            this.LB_Films.Location = new System.Drawing.Point(17, 42);
            this.LB_Films.Name = "LB_Films";
            this.LB_Films.Size = new System.Drawing.Size(344, 238);
            this.LB_Films.TabIndex = 0;
            this.LB_Films.SelectedIndexChanged += new System.EventHandler(this.LB_Films_SelectedIndexChanged);
            // 
            // BTN_Ajouter
            // 
            this.BTN_Ajouter.Location = new System.Drawing.Point(367, 42);
            this.BTN_Ajouter.Name = "BTN_Ajouter";
            this.BTN_Ajouter.Size = new System.Drawing.Size(169, 27);
            this.BTN_Ajouter.TabIndex = 1;
            this.BTN_Ajouter.Text = "Ajouter un nouveau film";
            this.BTN_Ajouter.UseVisualStyleBackColor = true;
            this.BTN_Ajouter.Click += new System.EventHandler(this.BTN_Ajouter_Click);
            // 
            // PB_Image
            // 
            this.PB_Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_Image.Image = global::PTI5_Gestion_bibliothèque_personnelle.Properties.Resources.movie;
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
            this.BTN_Modifier.Text = "Modifier le film sélectionné";
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
            this.BTN_Supprimer.Text = "Supprimer le film sélectionné";
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
            this.label2.Size = new System.Drawing.Size(254, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Gestion de mes films";
            // 
            // TXT_Titre
            // 
            this.TXT_Titre.Location = new System.Drawing.Point(24, 80);
            this.TXT_Titre.MaxLength = 32;
            this.TXT_Titre.Name = "TXT_Titre";
            this.TXT_Titre.Size = new System.Drawing.Size(126, 20);
            this.TXT_Titre.TabIndex = 5;
            this.TXT_Titre.Visible = false;
            // 
            // TXT_AnneeSortie
            // 
            this.TXT_AnneeSortie.Location = new System.Drawing.Point(24, 174);
            this.TXT_AnneeSortie.MaxLength = 4;
            this.TXT_AnneeSortie.Name = "TXT_AnneeSortie";
            this.TXT_AnneeSortie.Size = new System.Drawing.Size(66, 20);
            this.TXT_AnneeSortie.TabIndex = 7;
            this.TXT_AnneeSortie.Visible = false;
            this.TXT_AnneeSortie.TextChanged += new System.EventHandler(this.TXT_AnneeSortie_TextChanged);
            // 
            // LBL_Titre
            // 
            this.LBL_Titre.AutoSize = true;
            this.LBL_Titre.Location = new System.Drawing.Point(21, 64);
            this.LBL_Titre.Name = "LBL_Titre";
            this.LBL_Titre.Size = new System.Drawing.Size(64, 13);
            this.LBL_Titre.TabIndex = 10;
            this.LBL_Titre.Text = "Titre du film:";
            this.LBL_Titre.Visible = false;
            // 
            // LBL_Langue
            // 
            this.LBL_Langue.AutoSize = true;
            this.LBL_Langue.Location = new System.Drawing.Point(21, 113);
            this.LBL_Langue.Name = "LBL_Langue";
            this.LBL_Langue.Size = new System.Drawing.Size(46, 13);
            this.LBL_Langue.TabIndex = 11;
            this.LBL_Langue.Text = "Langue:";
            this.LBL_Langue.Visible = false;
            // 
            // LBL_AnneeSortie
            // 
            this.LBL_AnneeSortie.AutoSize = true;
            this.LBL_AnneeSortie.Location = new System.Drawing.Point(21, 158);
            this.LBL_AnneeSortie.Name = "LBL_AnneeSortie";
            this.LBL_AnneeSortie.Size = new System.Drawing.Size(69, 13);
            this.LBL_AnneeSortie.TabIndex = 12;
            this.LBL_AnneeSortie.Text = "Année sortie:";
            this.LBL_AnneeSortie.Visible = false;
            // 
            // GRB_Champs
            // 
            this.GRB_Champs.Controls.Add(this.TXT_Langue);
            this.GRB_Champs.Controls.Add(this.LBL_TypeMedia);
            this.GRB_Champs.Controls.Add(this.CB_TypeMedia);
            this.GRB_Champs.Controls.Add(this.LBL_Titre);
            this.GRB_Champs.Controls.Add(this.LBL_Langue);
            this.GRB_Champs.Controls.Add(this.TXT_Titre);
            this.GRB_Champs.Controls.Add(this.LBL_AnneeSortie);
            this.GRB_Champs.Controls.Add(this.BTN_Valider);
            this.GRB_Champs.Controls.Add(this.TXT_AnneeSortie);
            this.GRB_Champs.Location = new System.Drawing.Point(367, 141);
            this.GRB_Champs.Name = "GRB_Champs";
            this.GRB_Champs.Size = new System.Drawing.Size(169, 234);
            this.GRB_Champs.TabIndex = 14;
            this.GRB_Champs.TabStop = false;
            this.GRB_Champs.Text = "Mon film";
            this.GRB_Champs.Visible = false;
            // 
            // TXT_Langue
            // 
            this.TXT_Langue.Location = new System.Drawing.Point(24, 129);
            this.TXT_Langue.MaxLength = 32;
            this.TXT_Langue.Name = "TXT_Langue";
            this.TXT_Langue.Size = new System.Drawing.Size(126, 20);
            this.TXT_Langue.TabIndex = 6;
            this.TXT_Langue.Text = "Français";
            this.TXT_Langue.Visible = false;
            // 
            // LBL_TypeMedia
            // 
            this.LBL_TypeMedia.AutoSize = true;
            this.LBL_TypeMedia.Location = new System.Drawing.Point(21, 16);
            this.LBL_TypeMedia.Name = "LBL_TypeMedia";
            this.LBL_TypeMedia.Size = new System.Drawing.Size(47, 13);
            this.LBL_TypeMedia.TabIndex = 14;
            this.LBL_TypeMedia.Text = "Support:";
            // 
            // CB_TypeMedia
            // 
            this.CB_TypeMedia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_TypeMedia.FormattingEnabled = true;
            this.CB_TypeMedia.Location = new System.Drawing.Point(24, 32);
            this.CB_TypeMedia.Name = "CB_TypeMedia";
            this.CB_TypeMedia.Size = new System.Drawing.Size(126, 21);
            this.CB_TypeMedia.TabIndex = 4;
            // 
            // BTN_Valider
            // 
            this.BTN_Valider.Location = new System.Drawing.Point(51, 207);
            this.BTN_Valider.Name = "BTN_Valider";
            this.BTN_Valider.Size = new System.Drawing.Size(75, 23);
            this.BTN_Valider.TabIndex = 8;
            this.BTN_Valider.Text = "Valider";
            this.BTN_Valider.UseVisualStyleBackColor = true;
            this.BTN_Valider.Click += new System.EventHandler(this.BTN_Valider_Click);
            // 
            // LBL_Infos_DateSortie
            // 
            this.LBL_Infos_DateSortie.AutoSize = true;
            this.LBL_Infos_DateSortie.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Infos_DateSortie.Location = new System.Drawing.Point(113, 50);
            this.LBL_Infos_DateSortie.Name = "LBL_Infos_DateSortie";
            this.LBL_Infos_DateSortie.Size = new System.Drawing.Size(66, 17);
            this.LBL_Infos_DateSortie.TabIndex = 15;
            this.LBL_Infos_DateSortie.Text = "Sortie en";
            // 
            // LBL_Infos_Titre
            // 
            this.LBL_Infos_Titre.AutoSize = true;
            this.LBL_Infos_Titre.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Infos_Titre.Location = new System.Drawing.Point(113, 30);
            this.LBL_Infos_Titre.Name = "LBL_Infos_Titre";
            this.LBL_Infos_Titre.Size = new System.Drawing.Size(0, 17);
            this.LBL_Infos_Titre.TabIndex = 16;
            // 
            // LBL_Infos_Annee
            // 
            this.LBL_Infos_Annee.AutoSize = true;
            this.LBL_Infos_Annee.Font = new System.Drawing.Font("Forte", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Infos_Annee.Location = new System.Drawing.Point(113, 96);
            this.LBL_Infos_Annee.Name = "LBL_Infos_Annee";
            this.LBL_Infos_Annee.Size = new System.Drawing.Size(95, 14);
            this.LBL_Infos_Annee.TabIndex = 17;
            this.LBL_Infos_Annee.Text = "Année de sortie:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LBL_Infos_Support);
            this.groupBox1.Controls.Add(this.LBL_Infos_DateAjout);
            this.groupBox1.Controls.Add(this.LBL_Infos_Annee);
            this.groupBox1.Controls.Add(this.PB_Image);
            this.groupBox1.Controls.Add(this.LBL_Infos_DateSortie);
            this.groupBox1.Controls.Add(this.LBL_Infos_Titre);
            this.groupBox1.Location = new System.Drawing.Point(17, 287);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 121);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations sur le film sélectionné";
            // 
            // LBL_Infos_Support
            // 
            this.LBL_Infos_Support.AutoSize = true;
            this.LBL_Infos_Support.Font = new System.Drawing.Font("Forte", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Infos_Support.Location = new System.Drawing.Point(113, 74);
            this.LBL_Infos_Support.Name = "LBL_Infos_Support";
            this.LBL_Infos_Support.Size = new System.Drawing.Size(54, 14);
            this.LBL_Infos_Support.TabIndex = 19;
            this.LBL_Infos_Support.Text = "Support:";
            // 
            // LBL_Infos_DateAjout
            // 
            this.LBL_Infos_DateAjout.AutoSize = true;
            this.LBL_Infos_DateAjout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Infos_DateAjout.Location = new System.Drawing.Point(196, 12);
            this.LBL_Infos_DateAjout.Name = "LBL_Infos_DateAjout";
            this.LBL_Infos_DateAjout.Size = new System.Drawing.Size(71, 13);
            this.LBL_Infos_DateAjout.TabIndex = 18;
            this.LBL_Infos_DateAjout.Text = "Film ajouté le:";
            this.LBL_Infos_DateAjout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BTN_Retour
            // 
            this.BTN_Retour.Location = new System.Drawing.Point(367, 381);
            this.BTN_Retour.Name = "BTN_Retour";
            this.BTN_Retour.Size = new System.Drawing.Size(169, 27);
            this.BTN_Retour.TabIndex = 9;
            this.BTN_Retour.Text = "Retour";
            this.BTN_Retour.UseVisualStyleBackColor = true;
            this.BTN_Retour.Click += new System.EventHandler(this.BTN_Retour_Click);
            // 
            // Form_GestionFilms
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
            this.Controls.Add(this.LB_Films);
            this.Controls.Add(this.GRB_Champs);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_GestionFilms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de mes films";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_GestionFilms_FormClosed);
            this.Load += new System.EventHandler(this.Form_GestionFilms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Image)).EndInit();
            this.GRB_Champs.ResumeLayout(false);
            this.GRB_Champs.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LB_Films;
        private System.Windows.Forms.Button BTN_Ajouter;
        private System.Windows.Forms.PictureBox PB_Image;
        private System.Windows.Forms.Button BTN_Modifier;
        private System.Windows.Forms.Button BTN_Supprimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_Titre;
        private System.Windows.Forms.TextBox TXT_AnneeSortie;
        private System.Windows.Forms.Label LBL_Titre;
        private System.Windows.Forms.Label LBL_Langue;
        private System.Windows.Forms.Label LBL_AnneeSortie;
        private System.Windows.Forms.GroupBox GRB_Champs;
        private System.Windows.Forms.Button BTN_Valider;
        private System.Windows.Forms.Label LBL_Infos_DateSortie;
        private System.Windows.Forms.Label LBL_Infos_Titre;
        private System.Windows.Forms.Label LBL_Infos_Annee;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LBL_Infos_DateAjout;
        private System.Windows.Forms.Button BTN_Retour;
        private System.Windows.Forms.Label LBL_TypeMedia;
        private System.Windows.Forms.ComboBox CB_TypeMedia;
        private System.Windows.Forms.Label LBL_Infos_Support;
        private System.Windows.Forms.TextBox TXT_Langue;
    }
}