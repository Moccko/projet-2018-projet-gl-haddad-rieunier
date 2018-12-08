namespace App
{
    partial class Accueil
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
            this.ConnexionBtn = new System.Windows.Forms.Button();
            this.TitreLb = new System.Windows.Forms.Label();
            this.CoursesListeBtn = new System.Windows.Forms.Button();
            this.CoureursListeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConnexionBtn
            // 
            this.ConnexionBtn.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnexionBtn.Location = new System.Drawing.Point(590, 12);
            this.ConnexionBtn.Name = "ConnexionBtn";
            this.ConnexionBtn.Size = new System.Drawing.Size(102, 23);
            this.ConnexionBtn.TabIndex = 2;
            this.ConnexionBtn.Text = "Se connecter";
            this.ConnexionBtn.UseVisualStyleBackColor = true;
            this.ConnexionBtn.Click += new System.EventHandler(this.ConnexionBtn_Click);
            // 
            // TitreLb
            // 
            this.TitreLb.AutoSize = true;
            this.TitreLb.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitreLb.Location = new System.Drawing.Point(13, 12);
            this.TitreLb.Name = "TitreLb";
            this.TitreLb.Size = new System.Drawing.Size(484, 31);
            this.TitreLb.TabIndex = 3;
            this.TitreLb.Text = "La gestion de courses pour les nuls";
            // 
            // CoursesListeBtn
            // 
            this.CoursesListeBtn.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoursesListeBtn.Location = new System.Drawing.Point(19, 65);
            this.CoursesListeBtn.Name = "CoursesListeBtn";
            this.CoursesListeBtn.Size = new System.Drawing.Size(220, 59);
            this.CoursesListeBtn.TabIndex = 4;
            this.CoursesListeBtn.Text = "Liste des courses";
            this.CoursesListeBtn.UseVisualStyleBackColor = true;
            this.CoursesListeBtn.Click += new System.EventHandler(this.CoursesListeBtn_Click);
            // 
            // CoureursListeBtn
            // 
            this.CoureursListeBtn.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoureursListeBtn.Location = new System.Drawing.Point(19, 156);
            this.CoureursListeBtn.Name = "CoureursListeBtn";
            this.CoureursListeBtn.Size = new System.Drawing.Size(220, 59);
            this.CoureursListeBtn.TabIndex = 5;
            this.CoureursListeBtn.Text = "Liste des coureurs";
            this.CoureursListeBtn.UseVisualStyleBackColor = true;
            this.CoureursListeBtn.Click += new System.EventHandler(this.CoureursListeBtn_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 370);
            this.Controls.Add(this.CoureursListeBtn);
            this.Controls.Add(this.CoursesListeBtn);
            this.Controls.Add(this.TitreLb);
            this.Controls.Add(this.ConnexionBtn);
            this.Name = "Accueil";
            this.Text = "La gestion de courses pour les nuls";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ConnexionBtn;
        private System.Windows.Forms.Label TitreLb;
        private System.Windows.Forms.Button CoursesListeBtn;
        private System.Windows.Forms.Button CoureursListeBtn;
    }
}

