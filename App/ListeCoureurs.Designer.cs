namespace App
{
    partial class ListeCoureurs
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
            this.ParticipationsDGV = new System.Windows.Forms.DataGridView();
            this.SupprimerParticipantBtn = new System.Windows.Forms.Button();
            this.AjouterParticipantBtn = new System.Windows.Forms.Button();
            this.ListeParticipationsLb = new System.Windows.Forms.Label();
            this.EnregistrerBtn = new System.Windows.Forms.Button();
            this.ImporterCoureursBtn = new System.Windows.Forms.Button();
            this.CreerCoureurBtn = new System.Windows.Forms.Button();
            this.CoureursLB = new System.Windows.Forms.ListBox();
            this.SupprimerCoureurBtn = new System.Windows.Forms.Button();
            this.PrenomLb = new System.Windows.Forms.Label();
            this.NomLb = new System.Windows.Forms.Label();
            this.PrenomTB = new System.Windows.Forms.TextBox();
            this.NomTB = new System.Windows.Forms.TextBox();
            this.LicenceTB = new System.Windows.Forms.TextBox();
            this.LicenceLb = new System.Windows.Forms.Label();
            this.DateNaissanceLb = new System.Windows.Forms.Label();
            this.CourrielLb = new System.Windows.Forms.Label();
            this.CourrielTB = new System.Windows.Forms.TextBox();
            this.DateNaissanceMTB = new System.Windows.Forms.MaskedTextBox();
            this.DateNaissanceCal = new System.Windows.Forms.MonthCalendar();
            this.RechercheCoureurPTB = new App.PlaceholderTextBox();
            this.RechercheParticipationPTB = new App.PlaceholderTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ParticipationsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // ParticipationsDGV
            // 
            this.ParticipationsDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ParticipationsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ParticipationsDGV.Location = new System.Drawing.Point(267, 227);
            this.ParticipationsDGV.Name = "ParticipationsDGV";
            this.ParticipationsDGV.Size = new System.Drawing.Size(400, 87);
            this.ParticipationsDGV.TabIndex = 0;
            // 
            // SupprimerParticipantBtn
            // 
            this.SupprimerParticipantBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SupprimerParticipantBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupprimerParticipantBtn.Location = new System.Drawing.Point(643, 198);
            this.SupprimerParticipantBtn.Name = "SupprimerParticipantBtn";
            this.SupprimerParticipantBtn.Size = new System.Drawing.Size(24, 24);
            this.SupprimerParticipantBtn.TabIndex = 16;
            this.SupprimerParticipantBtn.Text = "-";
            this.SupprimerParticipantBtn.UseVisualStyleBackColor = true;
            // 
            // AjouterParticipantBtn
            // 
            this.AjouterParticipantBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AjouterParticipantBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjouterParticipantBtn.Location = new System.Drawing.Point(613, 198);
            this.AjouterParticipantBtn.Name = "AjouterParticipantBtn";
            this.AjouterParticipantBtn.Size = new System.Drawing.Size(24, 24);
            this.AjouterParticipantBtn.TabIndex = 15;
            this.AjouterParticipantBtn.Text = "+";
            this.AjouterParticipantBtn.UseVisualStyleBackColor = true;
            // 
            // ListeParticipationsLb
            // 
            this.ListeParticipationsLb.AutoSize = true;
            this.ListeParticipationsLb.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListeParticipationsLb.Location = new System.Drawing.Point(263, 179);
            this.ListeParticipationsLb.Name = "ListeParticipationsLb";
            this.ListeParticipationsLb.Size = new System.Drawing.Size(200, 19);
            this.ListeParticipationsLb.TabIndex = 14;
            this.ListeParticipationsLb.Text = "Liste des participations";
            // 
            // EnregistrerBtn
            // 
            this.EnregistrerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnregistrerBtn.Enabled = false;
            this.EnregistrerBtn.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnregistrerBtn.Location = new System.Drawing.Point(267, 320);
            this.EnregistrerBtn.Name = "EnregistrerBtn";
            this.EnregistrerBtn.Size = new System.Drawing.Size(400, 39);
            this.EnregistrerBtn.TabIndex = 18;
            this.EnregistrerBtn.Text = "Enregistrer";
            this.EnregistrerBtn.UseVisualStyleBackColor = true;
            // 
            // ImporterCoureursBtn
            // 
            this.ImporterCoureursBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ImporterCoureursBtn.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImporterCoureursBtn.Location = new System.Drawing.Point(101, 322);
            this.ImporterCoureursBtn.Name = "ImporterCoureursBtn";
            this.ImporterCoureursBtn.Size = new System.Drawing.Size(131, 39);
            this.ImporterCoureursBtn.TabIndex = 21;
            this.ImporterCoureursBtn.Text = "Importer";
            this.ImporterCoureursBtn.UseVisualStyleBackColor = true;
            // 
            // CreerCoureurBtn
            // 
            this.CreerCoureurBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreerCoureurBtn.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreerCoureurBtn.Location = new System.Drawing.Point(11, 322);
            this.CreerCoureurBtn.Name = "CreerCoureurBtn";
            this.CreerCoureurBtn.Size = new System.Drawing.Size(39, 39);
            this.CreerCoureurBtn.TabIndex = 20;
            this.CreerCoureurBtn.Text = "+";
            this.CreerCoureurBtn.UseVisualStyleBackColor = true;
            this.CreerCoureurBtn.Click += new System.EventHandler(this.CreerCoureurBtn_Click);
            // 
            // CoureursLB
            // 
            this.CoureursLB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CoureursLB.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoureursLB.FormattingEnabled = true;
            this.CoureursLB.HorizontalScrollbar = true;
            this.CoureursLB.ItemHeight = 19;
            this.CoureursLB.Location = new System.Drawing.Point(12, 44);
            this.CoureursLB.Name = "CoureursLB";
            this.CoureursLB.Size = new System.Drawing.Size(220, 270);
            this.CoureursLB.TabIndex = 19;
            this.CoureursLB.SelectedIndexChanged += new System.EventHandler(this.CoureursLB_SelectedIndexChanged);
            // 
            // SupprimerCoureurBtn
            // 
            this.SupprimerCoureurBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SupprimerCoureurBtn.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupprimerCoureurBtn.Location = new System.Drawing.Point(56, 322);
            this.SupprimerCoureurBtn.Name = "SupprimerCoureurBtn";
            this.SupprimerCoureurBtn.Size = new System.Drawing.Size(39, 39);
            this.SupprimerCoureurBtn.TabIndex = 23;
            this.SupprimerCoureurBtn.Text = "-";
            this.SupprimerCoureurBtn.UseVisualStyleBackColor = true;
            // 
            // PrenomLb
            // 
            this.PrenomLb.AutoSize = true;
            this.PrenomLb.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrenomLb.Location = new System.Drawing.Point(263, 17);
            this.PrenomLb.Name = "PrenomLb";
            this.PrenomLb.Size = new System.Drawing.Size(73, 19);
            this.PrenomLb.TabIndex = 24;
            this.PrenomLb.Text = "Prénom";
            // 
            // NomLb
            // 
            this.NomLb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NomLb.AutoSize = true;
            this.NomLb.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomLb.Location = new System.Drawing.Point(480, 19);
            this.NomLb.Name = "NomLb";
            this.NomLb.Size = new System.Drawing.Size(47, 19);
            this.NomLb.TabIndex = 25;
            this.NomLb.Text = "Nom";
            // 
            // PrenomTB
            // 
            this.PrenomTB.Location = new System.Drawing.Point(267, 40);
            this.PrenomTB.Name = "PrenomTB";
            this.PrenomTB.Size = new System.Drawing.Size(183, 20);
            this.PrenomTB.TabIndex = 26;
            // 
            // NomTB
            // 
            this.NomTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NomTB.Location = new System.Drawing.Point(484, 41);
            this.NomTB.Name = "NomTB";
            this.NomTB.Size = new System.Drawing.Size(183, 20);
            this.NomTB.TabIndex = 27;
            // 
            // LicenceTB
            // 
            this.LicenceTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LicenceTB.Location = new System.Drawing.Point(484, 85);
            this.LicenceTB.Name = "LicenceTB";
            this.LicenceTB.Size = new System.Drawing.Size(183, 20);
            this.LicenceTB.TabIndex = 31;
            // 
            // LicenceLb
            // 
            this.LicenceLb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LicenceLb.AutoSize = true;
            this.LicenceLb.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LicenceLb.Location = new System.Drawing.Point(480, 63);
            this.LicenceLb.Name = "LicenceLb";
            this.LicenceLb.Size = new System.Drawing.Size(156, 19);
            this.LicenceLb.TabIndex = 29;
            this.LicenceLb.Text = "Numéro de licence";
            // 
            // DateNaissanceLb
            // 
            this.DateNaissanceLb.AutoSize = true;
            this.DateNaissanceLb.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateNaissanceLb.Location = new System.Drawing.Point(263, 63);
            this.DateNaissanceLb.Name = "DateNaissanceLb";
            this.DateNaissanceLb.Size = new System.Drawing.Size(150, 19);
            this.DateNaissanceLb.TabIndex = 28;
            this.DateNaissanceLb.Text = "Date de naissance";
            // 
            // CourrielLb
            // 
            this.CourrielLb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CourrielLb.AutoSize = true;
            this.CourrielLb.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourrielLb.Location = new System.Drawing.Point(263, 108);
            this.CourrielLb.Name = "CourrielLb";
            this.CourrielLb.Size = new System.Drawing.Size(80, 19);
            this.CourrielLb.TabIndex = 32;
            this.CourrielLb.Text = "Courriel";
            // 
            // CourrielTB
            // 
            this.CourrielTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CourrielTB.Location = new System.Drawing.Point(267, 131);
            this.CourrielTB.Name = "CourrielTB";
            this.CourrielTB.Size = new System.Drawing.Size(400, 20);
            this.CourrielTB.TabIndex = 33;
            // 
            // DateNaissanceMTB
            // 
            this.DateNaissanceMTB.Location = new System.Drawing.Point(267, 85);
            this.DateNaissanceMTB.Mask = "00/00/0000";
            this.DateNaissanceMTB.Name = "DateNaissanceMTB";
            this.DateNaissanceMTB.Size = new System.Drawing.Size(183, 20);
            this.DateNaissanceMTB.TabIndex = 34;
            this.DateNaissanceMTB.ValidatingType = typeof(System.DateTime);
            this.DateNaissanceMTB.Enter += new System.EventHandler(this.DateNaissanceMTB_Enter);
            this.DateNaissanceMTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DateNaissanceMTB_KeyUp);
            this.DateNaissanceMTB.Leave += new System.EventHandler(this.DateNaissanceMTB_Leave);
            // 
            // DateNaissanceCal
            // 
            this.DateNaissanceCal.Location = new System.Drawing.Point(224, 108);
            this.DateNaissanceCal.Name = "DateNaissanceCal";
            this.DateNaissanceCal.TabIndex = 35;
            this.DateNaissanceCal.Visible = false;
            this.DateNaissanceCal.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.DateNaissanceCal_DateChanged);
            this.DateNaissanceCal.Leave += new System.EventHandler(this.DateNaissanceCal_Leave);
            // 
            // RechercheCoureurPTB
            // 
            this.RechercheCoureurPTB.Location = new System.Drawing.Point(12, 20);
            this.RechercheCoureurPTB.Name = "RechercheCoureurPTB";
            this.RechercheCoureurPTB.Placeholder = "Rechercher un coureur";
            this.RechercheCoureurPTB.Size = new System.Drawing.Size(220, 20);
            this.RechercheCoureurPTB.TabIndex = 36;
            this.RechercheCoureurPTB.Text = "Rechercher un coureur";
            this.RechercheCoureurPTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RechercheCoureurPTB_KeyUp);
            // 
            // RechercheParticipationPTB
            // 
            this.RechercheParticipationPTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RechercheParticipationPTB.Location = new System.Drawing.Point(267, 201);
            this.RechercheParticipationPTB.Name = "RechercheParticipationPTB";
            this.RechercheParticipationPTB.Placeholder = "Rechercher une participation";
            this.RechercheParticipationPTB.Size = new System.Drawing.Size(340, 20);
            this.RechercheParticipationPTB.TabIndex = 37;
            this.RechercheParticipationPTB.Text = "Rechercher une participation";
            this.RechercheParticipationPTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RechercheParticipationPTB_KeyUp);
            // 
            // ListeCoureurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 370);
            this.Controls.Add(this.RechercheCoureurPTB);
            this.Controls.Add(this.DateNaissanceCal);
            this.Controls.Add(this.DateNaissanceMTB);
            this.Controls.Add(this.CourrielTB);
            this.Controls.Add(this.CourrielLb);
            this.Controls.Add(this.LicenceTB);
            this.Controls.Add(this.LicenceLb);
            this.Controls.Add(this.DateNaissanceLb);
            this.Controls.Add(this.NomTB);
            this.Controls.Add(this.PrenomTB);
            this.Controls.Add(this.NomLb);
            this.Controls.Add(this.PrenomLb);
            this.Controls.Add(this.SupprimerCoureurBtn);
            this.Controls.Add(this.ImporterCoureursBtn);
            this.Controls.Add(this.CreerCoureurBtn);
            this.Controls.Add(this.CoureursLB);
            this.Controls.Add(this.EnregistrerBtn);
            this.Controls.Add(this.SupprimerParticipantBtn);
            this.Controls.Add(this.AjouterParticipantBtn);
            this.Controls.Add(this.ListeParticipationsLb);
            this.Controls.Add(this.ParticipationsDGV);
            this.Controls.Add(this.RechercheParticipationPTB);
            this.Name = "ListeCoureurs";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.ParticipationsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ParticipationsDGV;
        private System.Windows.Forms.Button SupprimerParticipantBtn;
        private System.Windows.Forms.Button AjouterParticipantBtn;
        private System.Windows.Forms.Label ListeParticipationsLb;
        private System.Windows.Forms.Button EnregistrerBtn;
        private System.Windows.Forms.Button ImporterCoureursBtn;
        private System.Windows.Forms.Button CreerCoureurBtn;
        private System.Windows.Forms.ListBox CoureursLB;
        private System.Windows.Forms.Button SupprimerCoureurBtn;
        private System.Windows.Forms.Label PrenomLb;
        private System.Windows.Forms.Label NomLb;
        private System.Windows.Forms.TextBox PrenomTB;
        private System.Windows.Forms.TextBox NomTB;
        private System.Windows.Forms.TextBox LicenceTB;
        private System.Windows.Forms.Label LicenceLb;
        private System.Windows.Forms.Label DateNaissanceLb;
        private System.Windows.Forms.Label CourrielLb;
        private System.Windows.Forms.TextBox CourrielTB;
        private System.Windows.Forms.MaskedTextBox DateNaissanceMTB;
        private System.Windows.Forms.MonthCalendar DateNaissanceCal;
        private PlaceholderTextBox RechercheCoureurPTB;
        private PlaceholderTextBox RechercheParticipationPTB;
    }
}