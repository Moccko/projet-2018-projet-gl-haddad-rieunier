namespace App
{
    partial class CreerCoureur
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
            this.components = new System.ComponentModel.Container();
            this.DateLb = new System.Windows.Forms.Label();
            this.DateMTB = new System.Windows.Forms.MaskedTextBox();
            this.PrenomTB = new System.Windows.Forms.TextBox();
            this.PrenomLb = new System.Windows.Forms.Label();
            this.CreerCoureurLb = new System.Windows.Forms.Label();
            this.ValiderBtn = new System.Windows.Forms.Button();
            this.AnneeTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.DateCal = new System.Windows.Forms.MonthCalendar();
            this.NomLb = new System.Windows.Forms.Label();
            this.SexeLb = new System.Windows.Forms.Label();
            this.SexeCB = new System.Windows.Forms.ComboBox();
            this.NomTB = new System.Windows.Forms.TextBox();
            this.CourrielLb = new System.Windows.Forms.Label();
            this.CourrielTB = new System.Windows.Forms.TextBox();
            this.NoLicenceLb = new System.Windows.Forms.Label();
            this.NoLicenceMTB = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // DateLb
            // 
            this.DateLb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateLb.AutoSize = true;
            this.DateLb.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLb.Location = new System.Drawing.Point(122, 177);
            this.DateLb.Name = "DateLb";
            this.DateLb.Size = new System.Drawing.Size(150, 19);
            this.DateLb.TabIndex = 8;
            this.DateLb.Text = "Date de naissance";
            this.DateLb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DateMTB
            // 
            this.DateMTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateMTB.Location = new System.Drawing.Point(126, 199);
            this.DateMTB.Mask = "00/00/0000";
            this.DateMTB.Name = "DateMTB";
            this.DateMTB.Size = new System.Drawing.Size(146, 20);
            this.DateMTB.TabIndex = 3;
            this.DateMTB.ValidatingType = typeof(System.DateTime);
            this.DateMTB.TextChanged += new System.EventHandler(this.AnneeMTB_TextChanged);
            this.DateMTB.Enter += new System.EventHandler(this.DateMTB_Enter);
            this.DateMTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DateMTB_KeyUp);
            this.DateMTB.Leave += new System.EventHandler(this.DateMTB_Leave);
            // 
            // PrenomTB
            // 
            this.PrenomTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrenomTB.Location = new System.Drawing.Point(12, 108);
            this.PrenomTB.Name = "PrenomTB";
            this.PrenomTB.Size = new System.Drawing.Size(260, 20);
            this.PrenomTB.TabIndex = 0;
            this.PrenomTB.TextChanged += new System.EventHandler(this.NomTB_TextChanged);
            this.PrenomTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValiderBtn_Enable);
            // 
            // PrenomLb
            // 
            this.PrenomLb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrenomLb.AutoSize = true;
            this.PrenomLb.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrenomLb.Location = new System.Drawing.Point(8, 86);
            this.PrenomLb.Name = "PrenomLb";
            this.PrenomLb.Size = new System.Drawing.Size(73, 19);
            this.PrenomLb.TabIndex = 5;
            this.PrenomLb.Text = "Prénom";
            this.PrenomLb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CreerCoureurLb
            // 
            this.CreerCoureurLb.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreerCoureurLb.Location = new System.Drawing.Point(21, 23);
            this.CreerCoureurLb.Name = "CreerCoureurLb";
            this.CreerCoureurLb.Size = new System.Drawing.Size(242, 63);
            this.CreerCoureurLb.TabIndex = 9;
            this.CreerCoureurLb.Text = "Inscrire un coureur";
            this.CreerCoureurLb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ValiderBtn
            // 
            this.ValiderBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ValiderBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ValiderBtn.Enabled = false;
            this.ValiderBtn.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValiderBtn.Location = new System.Drawing.Point(61, 394);
            this.ValiderBtn.Name = "ValiderBtn";
            this.ValiderBtn.Size = new System.Drawing.Size(162, 39);
            this.ValiderBtn.TabIndex = 6;
            this.ValiderBtn.Text = "Valider";
            this.ValiderBtn.UseVisualStyleBackColor = true;
            // 
            // DateCal
            // 
            this.DateCal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DateCal.Location = new System.Drawing.Point(46, 222);
            this.DateCal.Name = "DateCal";
            this.DateCal.TabIndex = 7;
            this.DateCal.Visible = false;
            this.DateCal.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.DateCal_DateChanged);
            this.DateCal.Leave += new System.EventHandler(this.DateCal_Leave);
            // 
            // NomLb
            // 
            this.NomLb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NomLb.AutoSize = true;
            this.NomLb.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomLb.Location = new System.Drawing.Point(8, 131);
            this.NomLb.Name = "NomLb";
            this.NomLb.Size = new System.Drawing.Size(47, 19);
            this.NomLb.TabIndex = 12;
            this.NomLb.Text = "Nom";
            this.NomLb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SexeLb
            // 
            this.SexeLb.AutoSize = true;
            this.SexeLb.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SexeLb.Location = new System.Drawing.Point(8, 176);
            this.SexeLb.Name = "SexeLb";
            this.SexeLb.Size = new System.Drawing.Size(45, 19);
            this.SexeLb.TabIndex = 13;
            this.SexeLb.Text = "Sexe";
            this.SexeLb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SexeCB
            // 
            this.SexeCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.SexeCB.FormattingEnabled = true;
            this.SexeCB.Items.AddRange(new object[] {
            "Homme",
            "Femme"});
            this.SexeCB.Location = new System.Drawing.Point(12, 198);
            this.SexeCB.Name = "SexeCB";
            this.SexeCB.Size = new System.Drawing.Size(108, 21);
            this.SexeCB.TabIndex = 2;
            this.SexeCB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValiderBtn_Enable);
            // 
            // NomTB
            // 
            this.NomTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NomTB.Location = new System.Drawing.Point(12, 153);
            this.NomTB.Name = "NomTB";
            this.NomTB.Size = new System.Drawing.Size(261, 20);
            this.NomTB.TabIndex = 1;
            this.NomTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValiderBtn_Enable);
            // 
            // CourrielLb
            // 
            this.CourrielLb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CourrielLb.AutoSize = true;
            this.CourrielLb.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourrielLb.Location = new System.Drawing.Point(8, 222);
            this.CourrielLb.Name = "CourrielLb";
            this.CourrielLb.Size = new System.Drawing.Size(80, 19);
            this.CourrielLb.TabIndex = 16;
            this.CourrielLb.Text = "Courriel";
            this.CourrielLb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CourrielTB
            // 
            this.CourrielTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CourrielTB.Location = new System.Drawing.Point(12, 244);
            this.CourrielTB.Name = "CourrielTB";
            this.CourrielTB.Size = new System.Drawing.Size(261, 20);
            this.CourrielTB.TabIndex = 4;
            this.CourrielTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValiderBtn_Enable);
            // 
            // NoLicenceLb
            // 
            this.NoLicenceLb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoLicenceLb.AutoSize = true;
            this.NoLicenceLb.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoLicenceLb.Location = new System.Drawing.Point(8, 267);
            this.NoLicenceLb.Name = "NoLicenceLb";
            this.NoLicenceLb.Size = new System.Drawing.Size(195, 19);
            this.NoLicenceLb.TabIndex = 18;
            this.NoLicenceLb.Text = "Numéro de licence FFA";
            this.NoLicenceLb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NoLicenceMTB
            // 
            this.NoLicenceMTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoLicenceMTB.Location = new System.Drawing.Point(12, 290);
            this.NoLicenceMTB.Mask = "9999999L";
            this.NoLicenceMTB.Name = "NoLicenceMTB";
            this.NoLicenceMTB.Size = new System.Drawing.Size(260, 20);
            this.NoLicenceMTB.TabIndex = 5;
            this.NoLicenceMTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValiderBtn_Enable);
            // 
            // CreerCoureur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 445);
            this.Controls.Add(this.DateCal);
            this.Controls.Add(this.NoLicenceMTB);
            this.Controls.Add(this.NoLicenceLb);
            this.Controls.Add(this.CourrielTB);
            this.Controls.Add(this.CourrielLb);
            this.Controls.Add(this.NomTB);
            this.Controls.Add(this.SexeCB);
            this.Controls.Add(this.SexeLb);
            this.Controls.Add(this.NomLb);
            this.Controls.Add(this.ValiderBtn);
            this.Controls.Add(this.CreerCoureurLb);
            this.Controls.Add(this.DateLb);
            this.Controls.Add(this.DateMTB);
            this.Controls.Add(this.PrenomTB);
            this.Controls.Add(this.PrenomLb);
            this.Name = "CreerCoureur";
            this.Text = "CreerCoureur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DateLb;
        private System.Windows.Forms.MaskedTextBox DateMTB;
        private System.Windows.Forms.TextBox PrenomTB;
        private System.Windows.Forms.Label PrenomLb;
        private System.Windows.Forms.Label CreerCoureurLb;
        private System.Windows.Forms.Button ValiderBtn;
        private System.Windows.Forms.ToolTip AnneeTooltip;
        private System.Windows.Forms.MonthCalendar DateCal;
        private System.Windows.Forms.Label NomLb;
        private System.Windows.Forms.Label SexeLb;
        private System.Windows.Forms.ComboBox SexeCB;
        private System.Windows.Forms.TextBox NomTB;
        private System.Windows.Forms.Label CourrielLb;
        private System.Windows.Forms.TextBox CourrielTB;
        private System.Windows.Forms.Label NoLicenceLb;
        private System.Windows.Forms.MaskedTextBox NoLicenceMTB;
    }
}