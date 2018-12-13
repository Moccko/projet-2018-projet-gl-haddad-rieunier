namespace App
{
    partial class ListeCourses
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CoursesLB = new System.Windows.Forms.ListBox();
            this.NomLb = new System.Windows.Forms.Label();
            this.NomTB = new System.Windows.Forms.TextBox();
            this.AnneeMTB = new System.Windows.Forms.MaskedTextBox();
            this.AnneeLb = new System.Windows.Forms.Label();
            this.ListeParticipantsLb = new System.Windows.Forms.Label();
            this.EnregistrerBtn = new System.Windows.Forms.Button();
            this.CreerCourseBtn = new System.Windows.Forms.Button();
            this.ParticipantsDGV = new System.Windows.Forms.DataGridView();
            this.AjouterParticipantBtn = new System.Windows.Forms.Button();
            this.SupprimerParticipantBtn = new System.Windows.Forms.Button();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Temps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoDossard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ParticipantsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // CoursesLB
            // 
            this.CoursesLB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CoursesLB.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoursesLB.FormattingEnabled = true;
            this.CoursesLB.HorizontalScrollbar = true;
            this.CoursesLB.ItemHeight = 19;
            this.CoursesLB.Location = new System.Drawing.Point(13, 13);
            this.CoursesLB.Name = "CoursesLB";
            this.CoursesLB.Size = new System.Drawing.Size(220, 289);
            this.CoursesLB.TabIndex = 0;
            this.CoursesLB.SelectedIndexChanged += new System.EventHandler(this.CoursesLB_SelectedIndexChanged);
            // 
            // NomLb
            // 
            this.NomLb.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomLb.Location = new System.Drawing.Point(259, 13);
            this.NomLb.Name = "NomLb";
            this.NomLb.Size = new System.Drawing.Size(164, 23);
            this.NomLb.TabIndex = 1;
            this.NomLb.Text = "Nom de la course";
            this.NomLb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NomTB
            // 
            this.NomTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NomTB.Location = new System.Drawing.Point(434, 16);
            this.NomTB.Name = "NomTB";
            this.NomTB.Size = new System.Drawing.Size(233, 20);
            this.NomTB.TabIndex = 2;
            this.NomTB.TextChanged += new System.EventHandler(this.NomTB_TextChanged);
            // 
            // AnneeMTB
            // 
            this.AnneeMTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AnneeMTB.Location = new System.Drawing.Point(434, 60);
            this.AnneeMTB.Mask = "2099";
            this.AnneeMTB.Name = "AnneeMTB";
            this.AnneeMTB.Size = new System.Drawing.Size(233, 20);
            this.AnneeMTB.TabIndex = 3;
            this.AnneeMTB.TextChanged += new System.EventHandler(this.AnneeMTB_TextChanged);
            // 
            // AnneeLb
            // 
            this.AnneeLb.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnneeLb.Location = new System.Drawing.Point(263, 57);
            this.AnneeLb.Name = "AnneeLb";
            this.AnneeLb.Size = new System.Drawing.Size(160, 23);
            this.AnneeLb.TabIndex = 4;
            this.AnneeLb.Text = "Année de la course";
            this.AnneeLb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ListeParticipantsLb
            // 
            this.ListeParticipantsLb.AutoSize = true;
            this.ListeParticipantsLb.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListeParticipantsLb.Location = new System.Drawing.Point(263, 109);
            this.ListeParticipantsLb.Name = "ListeParticipantsLb";
            this.ListeParticipantsLb.Size = new System.Drawing.Size(184, 19);
            this.ListeParticipantsLb.TabIndex = 6;
            this.ListeParticipantsLb.Text = "Liste des participants";
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
            this.EnregistrerBtn.TabIndex = 7;
            this.EnregistrerBtn.Text = "Enregistrer";
            this.EnregistrerBtn.UseVisualStyleBackColor = true;
            this.EnregistrerBtn.Click += new System.EventHandler(this.EnregistrerBtn_Click);
            // 
            // CreerCourseBtn
            // 
            this.CreerCourseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreerCourseBtn.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreerCourseBtn.Location = new System.Drawing.Point(12, 320);
            this.CreerCourseBtn.Name = "CreerCourseBtn";
            this.CreerCourseBtn.Size = new System.Drawing.Size(221, 39);
            this.CreerCourseBtn.TabIndex = 8;
            this.CreerCourseBtn.Text = "Créer une course";
            this.CreerCourseBtn.UseVisualStyleBackColor = true;
            this.CreerCourseBtn.Click += new System.EventHandler(this.CreerCourseBtn_Click);
            // 
            // ParticipantsDGV
            // 
            this.ParticipantsDGV.AllowUserToOrderColumns = true;
            this.ParticipantsDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ParticipantsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.ParticipantsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ParticipantsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Prenom,
            this.Nom,
            this.Temps,
            this.NoDossard});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ParticipantsDGV.DefaultCellStyle = dataGridViewCellStyle8;
            this.ParticipantsDGV.Location = new System.Drawing.Point(267, 131);
            this.ParticipantsDGV.Name = "ParticipantsDGV";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ParticipantsDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.ParticipantsDGV.Size = new System.Drawing.Size(400, 183);
            this.ParticipantsDGV.TabIndex = 5;
            this.ParticipantsDGV.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.ParticipantsDGV_CellBeginEdit);
            // 
            // AjouterParticipantBtn
            // 
            this.AjouterParticipantBtn.Location = new System.Drawing.Point(546, 105);
            this.AjouterParticipantBtn.Name = "AjouterParticipantBtn";
            this.AjouterParticipantBtn.Size = new System.Drawing.Size(52, 23);
            this.AjouterParticipantBtn.TabIndex = 10;
            this.AjouterParticipantBtn.Text = "Ajouter";
            this.AjouterParticipantBtn.UseVisualStyleBackColor = true;
            this.AjouterParticipantBtn.Click += new System.EventHandler(this.AjouterParticipantBtn_Click);
            // 
            // SupprimerParticipantBtn
            // 
            this.SupprimerParticipantBtn.Location = new System.Drawing.Point(604, 105);
            this.SupprimerParticipantBtn.Name = "SupprimerParticipantBtn";
            this.SupprimerParticipantBtn.Size = new System.Drawing.Size(63, 23);
            this.SupprimerParticipantBtn.TabIndex = 11;
            this.SupprimerParticipantBtn.Text = "Supprimer";
            this.SupprimerParticipantBtn.UseVisualStyleBackColor = true;
            this.SupprimerParticipantBtn.Click += new System.EventHandler(this.SupprimerParticipantBtn_Click);
            // 
            // Prenom
            // 
            this.Prenom.HeaderText = "Prénom";
            this.Prenom.Name = "Prenom";
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            // 
            // Temps
            // 
            this.Temps.HeaderText = "Temps";
            this.Temps.Name = "Temps";
            // 
            // NoDossard
            // 
            this.NoDossard.HeaderText = "Numéro de dossard";
            this.NoDossard.Name = "NoDossard";
            // 
            // ListeCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 370);
            this.Controls.Add(this.SupprimerParticipantBtn);
            this.Controls.Add(this.AjouterParticipantBtn);
            this.Controls.Add(this.CreerCourseBtn);
            this.Controls.Add(this.EnregistrerBtn);
            this.Controls.Add(this.ListeParticipantsLb);
            this.Controls.Add(this.ParticipantsDGV);
            this.Controls.Add(this.AnneeLb);
            this.Controls.Add(this.AnneeMTB);
            this.Controls.Add(this.NomTB);
            this.Controls.Add(this.NomLb);
            this.Controls.Add(this.CoursesLB);
            this.Name = "ListeCourses";
            this.Text = "Liste des courses";
            ((System.ComponentModel.ISupportInitialize)(this.ParticipantsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CoursesLB;
        private System.Windows.Forms.Label NomLb;
        private System.Windows.Forms.TextBox NomTB;
        private System.Windows.Forms.MaskedTextBox AnneeMTB;
        private System.Windows.Forms.Label AnneeLb;
        private System.Windows.Forms.Label ListeParticipantsLb;
        private System.Windows.Forms.Button EnregistrerBtn;
        private System.Windows.Forms.Button CreerCourseBtn;
        private System.Windows.Forms.DataGridView ParticipantsDGV;
        private System.Windows.Forms.Button AjouterParticipantBtn;
        private System.Windows.Forms.Button SupprimerParticipantBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Temps;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoDossard;
    }
}