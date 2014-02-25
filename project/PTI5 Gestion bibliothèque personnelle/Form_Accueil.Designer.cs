namespace PTI5_Gestion_bibliothèque_personnelle
{
    partial class Form_Accueil
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
            this.BTN_Films = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LBL_Livres = new System.Windows.Forms.Label();
            this.LBL_CD = new System.Windows.Forms.Label();
            this.LBL_Films = new System.Windows.Forms.Label();
            this.BTN_CD = new System.Windows.Forms.Button();
            this.BTN_Livres = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_Films
            // 
            this.BTN_Films.Image = global::PTI5_Gestion_bibliothèque_personnelle.Properties.Resources.movie;
            this.BTN_Films.Location = new System.Drawing.Point(446, 67);
            this.BTN_Films.Name = "BTN_Films";
            this.BTN_Films.Size = new System.Drawing.Size(120, 111);
            this.BTN_Films.TabIndex = 2;
            this.BTN_Films.UseVisualStyleBackColor = true;
            this.BTN_Films.Click += new System.EventHandler(this.BTN_Films_Click);
            this.BTN_Films.MouseEnter += new System.EventHandler(this.BTN_Films_MouseEnter);
            this.BTN_Films.MouseLeave += new System.EventHandler(this.BTN_Films_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Font = new System.Drawing.Font("Forte", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gestion de ma bibliothèque personnelle";
            // 
            // LBL_Livres
            // 
            this.LBL_Livres.AutoSize = true;
            this.LBL_Livres.BackColor = System.Drawing.Color.DodgerBlue;
            this.LBL_Livres.Font = new System.Drawing.Font("Forte", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Livres.ForeColor = System.Drawing.Color.Yellow;
            this.LBL_Livres.Location = new System.Drawing.Point(135, 186);
            this.LBL_Livres.Name = "LBL_Livres";
            this.LBL_Livres.Size = new System.Drawing.Size(98, 21);
            this.LBL_Livres.TabIndex = 4;
            this.LBL_Livres.Text = "Mes livres";
            this.LBL_Livres.Visible = false;
            // 
            // LBL_CD
            // 
            this.LBL_CD.AutoSize = true;
            this.LBL_CD.BackColor = System.Drawing.Color.DodgerBlue;
            this.LBL_CD.Font = new System.Drawing.Font("Forte", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CD.ForeColor = System.Drawing.Color.Yellow;
            this.LBL_CD.Location = new System.Drawing.Point(309, 186);
            this.LBL_CD.Name = "LBL_CD";
            this.LBL_CD.Size = new System.Drawing.Size(78, 21);
            this.LBL_CD.TabIndex = 5;
            this.LBL_CD.Text = "Mes CD";
            this.LBL_CD.Visible = false;
            // 
            // LBL_Films
            // 
            this.LBL_Films.AutoSize = true;
            this.LBL_Films.BackColor = System.Drawing.Color.DodgerBlue;
            this.LBL_Films.Font = new System.Drawing.Font("Forte", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Films.ForeColor = System.Drawing.Color.Yellow;
            this.LBL_Films.Location = new System.Drawing.Point(456, 186);
            this.LBL_Films.Name = "LBL_Films";
            this.LBL_Films.Size = new System.Drawing.Size(98, 21);
            this.LBL_Films.TabIndex = 6;
            this.LBL_Films.Text = "Mes films";
            this.LBL_Films.Visible = false;
            // 
            // BTN_CD
            // 
            this.BTN_CD.Image = global::PTI5_Gestion_bibliothèque_personnelle.Properties.Resources.music;
            this.BTN_CD.Location = new System.Drawing.Point(287, 67);
            this.BTN_CD.Name = "BTN_CD";
            this.BTN_CD.Size = new System.Drawing.Size(120, 111);
            this.BTN_CD.TabIndex = 1;
            this.BTN_CD.UseVisualStyleBackColor = true;
            this.BTN_CD.Click += new System.EventHandler(this.BTN_CD_Click);
            this.BTN_CD.MouseEnter += new System.EventHandler(this.BTN_CD_MouseEnter);
            this.BTN_CD.MouseLeave += new System.EventHandler(this.BTN_CD_MouseLeave);
            // 
            // BTN_Livres
            // 
            this.BTN_Livres.Image = global::PTI5_Gestion_bibliothèque_personnelle.Properties.Resources.livres;
            this.BTN_Livres.Location = new System.Drawing.Point(126, 67);
            this.BTN_Livres.Name = "BTN_Livres";
            this.BTN_Livres.Size = new System.Drawing.Size(120, 111);
            this.BTN_Livres.TabIndex = 0;
            this.BTN_Livres.UseVisualStyleBackColor = true;
            this.BTN_Livres.Click += new System.EventHandler(this.BTN_Livres_Click);
            this.BTN_Livres.MouseEnter += new System.EventHandler(this.BTN_Livres_MouseEnter);
            this.BTN_Livres.MouseLeave += new System.EventHandler(this.BTN_Livres_MouseLeave);
            // 
            // Form_Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(654, 236);
            this.Controls.Add(this.LBL_Films);
            this.Controls.Add(this.LBL_CD);
            this.Controls.Add(this.LBL_Livres);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Films);
            this.Controls.Add(this.BTN_CD);
            this.Controls.Add(this.BTN_Livres);
            this.Font = new System.Drawing.Font("Forte", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Accueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de bibliothèque personnelle";
            this.Load += new System.EventHandler(this.Form_Accueil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Livres;
        private System.Windows.Forms.Button BTN_CD;
        private System.Windows.Forms.Button BTN_Films;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBL_Livres;
        private System.Windows.Forms.Label LBL_CD;
        private System.Windows.Forms.Label LBL_Films;
    }
}

