namespace App
{
    partial class AjouterParticipant
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
            this.ValiderBtn = new System.Windows.Forms.Button();
            this.CreerCourseLb = new System.Windows.Forms.Label();
            this.CourseTB = new System.Windows.Forms.TextBox();
            this.CourseLb = new System.Windows.Forms.Label();
            this.CoureurCB = new System.Windows.Forms.ComboBox();
            this.CoureurLb = new System.Windows.Forms.Label();
            this.TempsLb = new System.Windows.Forms.Label();
            this.TempsMTB = new System.Windows.Forms.MaskedTextBox();
            this.NoDossardLb = new System.Windows.Forms.Label();
            this.NoDossardMTB = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // ValiderBtn
            // 
            this.ValiderBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ValiderBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ValiderBtn.Enabled = false;
            this.ValiderBtn.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValiderBtn.Location = new System.Drawing.Point(61, 238);
            this.ValiderBtn.Name = "ValiderBtn";
            this.ValiderBtn.Size = new System.Drawing.Size(236, 39);
            this.ValiderBtn.TabIndex = 16;
            this.ValiderBtn.Text = "Valider";
            this.ValiderBtn.UseVisualStyleBackColor = true;
            this.ValiderBtn.Click += new System.EventHandler(this.ValiderBtn_Click);
            // 
            // CreerCourseLb
            // 
            this.CreerCourseLb.AutoSize = true;
            this.CreerCourseLb.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreerCourseLb.Location = new System.Drawing.Point(21, 18);
            this.CreerCourseLb.Name = "CreerCourseLb";
            this.CreerCourseLb.Size = new System.Drawing.Size(312, 31);
            this.CreerCourseLb.TabIndex = 15;
            this.CreerCourseLb.Text = "Ajouter participation";
            // 
            // CourseTB
            // 
            this.CourseTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CourseTB.Enabled = false;
            this.CourseTB.Location = new System.Drawing.Point(113, 70);
            this.CourseTB.Name = "CourseTB";
            this.CourseTB.Size = new System.Drawing.Size(233, 20);
            this.CourseTB.TabIndex = 12;
            // 
            // CourseLb
            // 
            this.CourseLb.AutoSize = true;
            this.CourseLb.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseLb.Location = new System.Drawing.Point(8, 71);
            this.CourseLb.Name = "CourseLb";
            this.CourseLb.Size = new System.Drawing.Size(99, 19);
            this.CourseLb.TabIndex = 11;
            this.CourseLb.Text = "À la course";
            this.CourseLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CoureurCB
            // 
            this.CoureurCB.FormattingEnabled = true;
            this.CoureurCB.Location = new System.Drawing.Point(12, 131);
            this.CoureurCB.Name = "CoureurCB";
            this.CoureurCB.Size = new System.Drawing.Size(334, 21);
            this.CoureurCB.TabIndex = 17;
            // 
            // CoureurLb
            // 
            this.CoureurLb.AutoSize = true;
            this.CoureurLb.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoureurLb.Location = new System.Drawing.Point(8, 109);
            this.CoureurLb.Name = "CoureurLb";
            this.CoureurLb.Size = new System.Drawing.Size(142, 19);
            this.CoureurLb.TabIndex = 18;
            this.CoureurLb.Text = "Nom du coureur";
            this.CoureurLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TempsLb
            // 
            this.TempsLb.AutoSize = true;
            this.TempsLb.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempsLb.Location = new System.Drawing.Point(8, 169);
            this.TempsLb.Name = "TempsLb";
            this.TempsLb.Size = new System.Drawing.Size(62, 19);
            this.TempsLb.TabIndex = 23;
            this.TempsLb.Text = "Temps";
            this.TempsLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TempsMTB
            // 
            this.TempsMTB.Location = new System.Drawing.Point(12, 197);
            this.TempsMTB.Mask = "\\00:00:00";
            this.TempsMTB.Name = "TempsMTB";
            this.TempsMTB.Size = new System.Drawing.Size(154, 20);
            this.TempsMTB.TabIndex = 25;
            this.TempsMTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TempsMTB_KeyUp);
            // 
            // NoDossardLb
            // 
            this.NoDossardLb.AutoSize = true;
            this.NoDossardLb.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoDossardLb.Location = new System.Drawing.Point(188, 176);
            this.NoDossardLb.Name = "NoDossardLb";
            this.NoDossardLb.Size = new System.Drawing.Size(165, 19);
            this.NoDossardLb.TabIndex = 26;
            this.NoDossardLb.Text = "Numéro de dossard";
            this.NoDossardLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NoDossardMTB
            // 
            this.NoDossardMTB.Location = new System.Drawing.Point(192, 197);
            this.NoDossardMTB.Mask = "999999";
            this.NoDossardMTB.Name = "NoDossardMTB";
            this.NoDossardMTB.Size = new System.Drawing.Size(154, 20);
            this.NoDossardMTB.TabIndex = 27;
            this.NoDossardMTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NoDossardMTB_KeyUp);
            // 
            // AjouterParticipant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 294);
            this.Controls.Add(this.NoDossardMTB);
            this.Controls.Add(this.NoDossardLb);
            this.Controls.Add(this.TempsMTB);
            this.Controls.Add(this.TempsLb);
            this.Controls.Add(this.CoureurLb);
            this.Controls.Add(this.CoureurCB);
            this.Controls.Add(this.ValiderBtn);
            this.Controls.Add(this.CreerCourseLb);
            this.Controls.Add(this.CourseTB);
            this.Controls.Add(this.CourseLb);
            this.Name = "AjouterParticipant";
            this.Text = "AjouterParticipant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ValiderBtn;
        private System.Windows.Forms.Label CreerCourseLb;
        private System.Windows.Forms.TextBox CourseTB;
        private System.Windows.Forms.Label CourseLb;
        private System.Windows.Forms.ComboBox CoureurCB;
        private System.Windows.Forms.Label CoureurLb;
        private System.Windows.Forms.Label TempsLb;
        private System.Windows.Forms.MaskedTextBox TempsMTB;
        private System.Windows.Forms.Label NoDossardLb;
        private System.Windows.Forms.MaskedTextBox NoDossardMTB;
    }
}