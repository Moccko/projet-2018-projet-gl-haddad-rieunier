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
            this.CoursesBtn = new System.Windows.Forms.Button();
            this.CoureursBtn = new System.Windows.Forms.Button();
            this.ConnexionBtn = new System.Windows.Forms.Button();
            this.TitreLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CoursesBtn
            // 
            this.CoursesBtn.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoursesBtn.Location = new System.Drawing.Point(255, 113);
            this.CoursesBtn.Name = "CoursesBtn";
            this.CoursesBtn.Size = new System.Drawing.Size(174, 67);
            this.CoursesBtn.TabIndex = 0;
            this.CoursesBtn.Text = "Gestion courses";
            this.CoursesBtn.UseVisualStyleBackColor = true;
            this.CoursesBtn.Click += new System.EventHandler(this.CoursesBtn_Click);
            // 
            // CoureursBtn
            // 
            this.CoureursBtn.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoureursBtn.Location = new System.Drawing.Point(255, 198);
            this.CoureursBtn.Name = "CoureursBtn";
            this.CoureursBtn.Size = new System.Drawing.Size(174, 67);
            this.CoureursBtn.TabIndex = 1;
            this.CoureursBtn.Text = "Gestion coureurs";
            this.CoureursBtn.UseVisualStyleBackColor = true;
            this.CoureursBtn.Click += new System.EventHandler(this.CoureursBtn_Click);
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
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 370);
            this.Controls.Add(this.TitreLb);
            this.Controls.Add(this.ConnexionBtn);
            this.Controls.Add(this.CoureursBtn);
            this.Controls.Add(this.CoursesBtn);
            this.Name = "Accueil";
            this.Text = "La gestion de courses pour les nuls";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CoursesBtn;
        private System.Windows.Forms.Button CoureursBtn;
        private System.Windows.Forms.Button ConnexionBtn;
        private System.Windows.Forms.Label TitreLb;
    }
}

