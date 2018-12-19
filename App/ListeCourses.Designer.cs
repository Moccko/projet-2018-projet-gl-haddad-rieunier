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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CoursesLB = new System.Windows.Forms.ListBox();
            this.NomLb = new System.Windows.Forms.Label();
            this.NomTB = new System.Windows.Forms.TextBox();
            this.DateLb = new System.Windows.Forms.Label();
            this.ListeParticipantsLb = new System.Windows.Forms.Label();
            this.EnregistrerBtn = new System.Windows.Forms.Button();
            this.CreerCourseBtn = new System.Windows.Forms.Button();
            this.ParticipantsDGV = new System.Windows.Forms.DataGridView();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coureur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDeDossard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Temps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllureMoyenne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VitesseMoyenne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AjouterParticipantBtn = new System.Windows.Forms.Button();
            this.SupprimerParticipantBtn = new System.Windows.Forms.Button();
            this.ImporterCourseBtn = new System.Windows.Forms.Button();
            this.SupprimerCourseBtn = new System.Windows.Forms.Button();
            this.DateMTB = new System.Windows.Forms.MaskedTextBox();
            this.DateCal = new System.Windows.Forms.MonthCalendar();
            this.RechercheCoursePTB = new App.PlaceholderTextBox();
            this.RechercheParticipantPTB = new App.PlaceholderTextBox();
            this.AvertissementConnexionLb = new System.Windows.Forms.Label();
            this.ClassementGlobalBtn = new System.Windows.Forms.Button();
            this.ClassementTrancheAgeBtn = new System.Windows.Forms.Button();
            this.ConnecterBtn = new System.Windows.Forms.Button();
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
            this.CoursesLB.Location = new System.Drawing.Point(13, 42);
            this.CoursesLB.Name = "CoursesLB";
            this.CoursesLB.Size = new System.Drawing.Size(220, 270);
            this.CoursesLB.TabIndex = 0;
            this.CoursesLB.SelectedIndexChanged += new System.EventHandler(this.CoursesLB_SelectedIndexChanged);
            // 
            // NomLb
            // 
            this.NomLb.AutoSize = true;
            this.NomLb.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomLb.Location = new System.Drawing.Point(263, 84);
            this.NomLb.Name = "NomLb";
            this.NomLb.Size = new System.Drawing.Size(146, 19);
            this.NomLb.TabIndex = 1;
            this.NomLb.Text = "Nom de la course";
            this.NomLb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NomTB
            // 
            this.NomTB.Location = new System.Drawing.Point(267, 106);
            this.NomTB.Name = "NomTB";
            this.NomTB.Size = new System.Drawing.Size(263, 20);
            this.NomTB.TabIndex = 2;
            this.NomTB.TextChanged += new System.EventHandler(this.NomTB_TextChanged);
            // 
            // DateLb
            // 
            this.DateLb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateLb.AutoSize = true;
            this.DateLb.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLb.Location = new System.Drawing.Point(532, 84);
            this.DateLb.Name = "DateLb";
            this.DateLb.Size = new System.Drawing.Size(145, 19);
            this.DateLb.TabIndex = 4;
            this.DateLb.Text = "Date de la course";
            this.DateLb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ListeParticipantsLb
            // 
            this.ListeParticipantsLb.AutoSize = true;
            this.ListeParticipantsLb.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListeParticipantsLb.Location = new System.Drawing.Point(263, 155);
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
            this.CreerCourseBtn.Size = new System.Drawing.Size(39, 39);
            this.CreerCourseBtn.TabIndex = 8;
            this.CreerCourseBtn.Text = "+";
            this.CreerCourseBtn.UseVisualStyleBackColor = true;
            this.CreerCourseBtn.Click += new System.EventHandler(this.CreerCourseBtn_Click);
            // 
            // ParticipantsDGV
            // 
            this.ParticipantsDGV.AllowUserToOrderColumns = true;
            this.ParticipantsDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ParticipantsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ParticipantsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ParticipantsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Course,
            this.Coureur,
            this.NumeroDeDossard,
            this.Temps,
            this.AllureMoyenne,
            this.VitesseMoyenne});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ParticipantsDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.ParticipantsDGV.Location = new System.Drawing.Point(267, 203);
            this.ParticipantsDGV.Name = "ParticipantsDGV";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ParticipantsDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ParticipantsDGV.Size = new System.Drawing.Size(400, 111);
            this.ParticipantsDGV.TabIndex = 5;
            this.ParticipantsDGV.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.ParticipantsDGV_CellBeginEdit);
            // 
            // Course
            // 
            this.Course.HeaderText = "Course";
            this.Course.Name = "Course";
            this.Course.Visible = false;
            // 
            // Coureur
            // 
            this.Coureur.HeaderText = "Coureur";
            this.Coureur.Name = "Coureur";
            this.Coureur.Visible = false;
            // 
            // NumeroDeDossard
            // 
            this.NumeroDeDossard.HeaderText = "Numéro de dossard";
            this.NumeroDeDossard.Name = "NumeroDeDossard";
            this.NumeroDeDossard.Visible = false;
            // 
            // Temps
            // 
            this.Temps.HeaderText = "Temps";
            this.Temps.Name = "Temps";
            this.Temps.Visible = false;
            // 
            // AllureMoyenne
            // 
            this.AllureMoyenne.HeaderText = "Allure Moyenne";
            this.AllureMoyenne.Name = "AllureMoyenne";
            this.AllureMoyenne.Visible = false;
            // 
            // VitesseMoyenne
            // 
            this.VitesseMoyenne.HeaderText = "Vitesse Moyenne";
            this.VitesseMoyenne.Name = "VitesseMoyenne";
            this.VitesseMoyenne.Visible = false;
            // 
            // AjouterParticipantBtn
            // 
            this.AjouterParticipantBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AjouterParticipantBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjouterParticipantBtn.Location = new System.Drawing.Point(613, 176);
            this.AjouterParticipantBtn.Name = "AjouterParticipantBtn";
            this.AjouterParticipantBtn.Size = new System.Drawing.Size(24, 24);
            this.AjouterParticipantBtn.TabIndex = 10;
            this.AjouterParticipantBtn.Text = "+";
            this.AjouterParticipantBtn.UseVisualStyleBackColor = true;
            this.AjouterParticipantBtn.Click += new System.EventHandler(this.AjouterParticipantBtn_Click);
            // 
            // SupprimerParticipantBtn
            // 
            this.SupprimerParticipantBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SupprimerParticipantBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupprimerParticipantBtn.Location = new System.Drawing.Point(643, 176);
            this.SupprimerParticipantBtn.Name = "SupprimerParticipantBtn";
            this.SupprimerParticipantBtn.Size = new System.Drawing.Size(24, 24);
            this.SupprimerParticipantBtn.TabIndex = 11;
            this.SupprimerParticipantBtn.Text = "-";
            this.SupprimerParticipantBtn.UseVisualStyleBackColor = true;
            this.SupprimerParticipantBtn.Click += new System.EventHandler(this.SupprimerParticipantBtn_Click);
            // 
            // ImporterCourseBtn
            // 
            this.ImporterCourseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ImporterCourseBtn.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImporterCourseBtn.Location = new System.Drawing.Point(102, 320);
            this.ImporterCourseBtn.Name = "ImporterCourseBtn";
            this.ImporterCourseBtn.Size = new System.Drawing.Size(131, 39);
            this.ImporterCourseBtn.TabIndex = 12;
            this.ImporterCourseBtn.Text = "Importer";
            this.ImporterCourseBtn.UseVisualStyleBackColor = true;
            this.ImporterCourseBtn.Click += new System.EventHandler(this.ImporterCourseBtn_Click);
            // 
            // SupprimerCourseBtn
            // 
            this.SupprimerCourseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SupprimerCourseBtn.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupprimerCourseBtn.Location = new System.Drawing.Point(57, 320);
            this.SupprimerCourseBtn.Name = "SupprimerCourseBtn";
            this.SupprimerCourseBtn.Size = new System.Drawing.Size(39, 39);
            this.SupprimerCourseBtn.TabIndex = 15;
            this.SupprimerCourseBtn.Text = "-";
            this.SupprimerCourseBtn.UseVisualStyleBackColor = true;
            // 
            // DateMTB
            // 
            this.DateMTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateMTB.Location = new System.Drawing.Point(536, 106);
            this.DateMTB.Mask = "00/00/0000";
            this.DateMTB.Name = "DateMTB";
            this.DateMTB.Size = new System.Drawing.Size(130, 20);
            this.DateMTB.TabIndex = 18;
            this.DateMTB.ValidatingType = typeof(System.DateTime);
            this.DateMTB.Enter += new System.EventHandler(this.DateMTB_Enter);
            this.DateMTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DateMTB_KeyUp);
            this.DateMTB.Leave += new System.EventHandler(this.DateMTB_Leave);
            // 
            // DateCal
            // 
            this.DateCal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateCal.Location = new System.Drawing.Point(440, 129);
            this.DateCal.Name = "DateCal";
            this.DateCal.TabIndex = 19;
            this.DateCal.Visible = false;
            this.DateCal.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.DateCal_DateChanged);
            this.DateCal.Leave += new System.EventHandler(this.DateCal_Leave);
            // 
            // RechercheCoursePTB
            // 
            this.RechercheCoursePTB.Location = new System.Drawing.Point(13, 16);
            this.RechercheCoursePTB.Name = "RechercheCoursePTB";
            this.RechercheCoursePTB.Placeholder = "Rechercher une course";
            this.RechercheCoursePTB.Size = new System.Drawing.Size(220, 20);
            this.RechercheCoursePTB.TabIndex = 17;
            this.RechercheCoursePTB.Text = "Rechercher une course";
            this.RechercheCoursePTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RechercheCoursePTB_KeyUp);
            // 
            // RechercheParticipantPTB
            // 
            this.RechercheParticipantPTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RechercheParticipantPTB.Location = new System.Drawing.Point(267, 177);
            this.RechercheParticipantPTB.Name = "RechercheParticipantPTB";
            this.RechercheParticipantPTB.Placeholder = "Rechercher un participant";
            this.RechercheParticipantPTB.Size = new System.Drawing.Size(340, 20);
            this.RechercheParticipantPTB.TabIndex = 16;
            this.RechercheParticipantPTB.Text = "Rechercher un participant";
            this.RechercheParticipantPTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RechercheParticipantPTB_KeyUp);
            // 
            // AvertissementConnexionLb
            // 
            this.AvertissementConnexionLb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AvertissementConnexionLb.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvertissementConnexionLb.Location = new System.Drawing.Point(263, 15);
            this.AvertissementConnexionLb.Name = "AvertissementConnexionLb";
            this.AvertissementConnexionLb.Size = new System.Drawing.Size(304, 50);
            this.AvertissementConnexionLb.TabIndex = 20;
            this.AvertissementConnexionLb.Text = "Vous devez être connecté pour accéder aux fonctionnalités d\'édition";
            this.AvertissementConnexionLb.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ClassementGlobalBtn
            // 
            this.ClassementGlobalBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ClassementGlobalBtn.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassementGlobalBtn.Location = new System.Drawing.Point(267, 132);
            this.ClassementGlobalBtn.Name = "ClassementGlobalBtn";
            this.ClassementGlobalBtn.Size = new System.Drawing.Size(155, 23);
            this.ClassementGlobalBtn.TabIndex = 22;
            this.ClassementGlobalBtn.Text = "Classement global";
            this.ClassementGlobalBtn.UseVisualStyleBackColor = true;
            this.ClassementGlobalBtn.Click += new System.EventHandler(this.ClassementGlobalBtn_Click);
            // 
            // ClassementTrancheAgeBtn
            // 
            this.ClassementTrancheAgeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ClassementTrancheAgeBtn.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassementTrancheAgeBtn.Location = new System.Drawing.Point(425, 132);
            this.ClassementTrancheAgeBtn.Name = "ClassementTrancheAgeBtn";
            this.ClassementTrancheAgeBtn.Size = new System.Drawing.Size(241, 23);
            this.ClassementTrancheAgeBtn.TabIndex = 23;
            this.ClassementTrancheAgeBtn.Text = "Classement par tranche d\'âge";
            this.ClassementTrancheAgeBtn.UseVisualStyleBackColor = true;
            this.ClassementTrancheAgeBtn.Click += new System.EventHandler(this.ClassementTrancheAgeBtn_Click);
            // 
            // ConnecterBtn
            // 
            this.ConnecterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ConnecterBtn.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnecterBtn.Location = new System.Drawing.Point(563, 25);
            this.ConnecterBtn.Name = "ConnecterBtn";
            this.ConnecterBtn.Size = new System.Drawing.Size(104, 21);
            this.ConnecterBtn.TabIndex = 24;
            this.ConnecterBtn.Text = "Se connecter";
            this.ConnecterBtn.UseVisualStyleBackColor = true;
            this.ConnecterBtn.Click += new System.EventHandler(this.ConnecterBtn_Click);
            // 
            // ListeCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 370);
            this.Controls.Add(this.ConnecterBtn);
            this.Controls.Add(this.DateCal);
            this.Controls.Add(this.ClassementTrancheAgeBtn);
            this.Controls.Add(this.ClassementGlobalBtn);
            this.Controls.Add(this.AvertissementConnexionLb);
            this.Controls.Add(this.DateMTB);
            this.Controls.Add(this.RechercheCoursePTB);
            this.Controls.Add(this.RechercheParticipantPTB);
            this.Controls.Add(this.SupprimerCourseBtn);
            this.Controls.Add(this.ImporterCourseBtn);
            this.Controls.Add(this.SupprimerParticipantBtn);
            this.Controls.Add(this.AjouterParticipantBtn);
            this.Controls.Add(this.CreerCourseBtn);
            this.Controls.Add(this.EnregistrerBtn);
            this.Controls.Add(this.ListeParticipantsLb);
            this.Controls.Add(this.ParticipantsDGV);
            this.Controls.Add(this.DateLb);
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
        private System.Windows.Forms.Label DateLb;
        private System.Windows.Forms.Label ListeParticipantsLb;
        private System.Windows.Forms.Button EnregistrerBtn;
        private System.Windows.Forms.Button CreerCourseBtn;
        private System.Windows.Forms.DataGridView ParticipantsDGV;
        private System.Windows.Forms.Button AjouterParticipantBtn;
        private System.Windows.Forms.Button SupprimerParticipantBtn;
        private System.Windows.Forms.Button ImporterCourseBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coureur;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDeDossard;
        private System.Windows.Forms.DataGridViewTextBoxColumn Temps;
        private System.Windows.Forms.DataGridViewTextBoxColumn AllureMoyenne;
        private System.Windows.Forms.DataGridViewTextBoxColumn VitesseMoyenne;
        private System.Windows.Forms.Button SupprimerCourseBtn;
        private PlaceholderTextBox RechercheParticipantPTB;
        private PlaceholderTextBox RechercheCoursePTB;
        private System.Windows.Forms.MaskedTextBox DateMTB;
        private System.Windows.Forms.MonthCalendar DateCal;
        private System.Windows.Forms.Label AvertissementConnexionLb;
        private System.Windows.Forms.Button ClassementGlobalBtn;
        private System.Windows.Forms.Button ClassementTrancheAgeBtn;
        private System.Windows.Forms.Button ConnecterBtn;
    }
}