namespace App
{
    partial class ClassementTrancheAge
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
            this.DateLb = new System.Windows.Forms.Label();
            this.ClassementLb = new System.Windows.Forms.Label();
            this.CourseLb = new System.Windows.Forms.Label();
            this.TranchesAgeTC = new System.Windows.Forms.TabControl();
            this.SuspendLayout();
            // 
            // DateLb
            // 
            this.DateLb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateLb.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLb.Location = new System.Drawing.Point(12, 96);
            this.DateLb.Name = "DateLb";
            this.DateLb.Size = new System.Drawing.Size(366, 15);
            this.DateLb.TabIndex = 6;
            this.DateLb.Text = "Le 20/20/2020";
            this.DateLb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ClassementLb
            // 
            this.ClassementLb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassementLb.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassementLb.Location = new System.Drawing.Point(12, 72);
            this.ClassementLb.Name = "ClassementLb";
            this.ClassementLb.Size = new System.Drawing.Size(366, 24);
            this.ClassementLb.TabIndex = 5;
            this.ClassementLb.Text = "Classement global";
            this.ClassementLb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CourseLb
            // 
            this.CourseLb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CourseLb.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseLb.Location = new System.Drawing.Point(13, 12);
            this.CourseLb.Name = "CourseLb";
            this.CourseLb.Size = new System.Drawing.Size(366, 60);
            this.CourseLb.TabIndex = 4;
            this.CourseLb.Text = "Nom de la course";
            this.CourseLb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TranchesAgeTC
            // 
            this.TranchesAgeTC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TranchesAgeTC.Location = new System.Drawing.Point(12, 114);
            this.TranchesAgeTC.Name = "TranchesAgeTC";
            this.TranchesAgeTC.SelectedIndex = 0;
            this.TranchesAgeTC.Size = new System.Drawing.Size(367, 345);
            this.TranchesAgeTC.TabIndex = 8;
            // 
            // ClassementTrancheAge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 471);
            this.Controls.Add(this.DateLb);
            this.Controls.Add(this.ClassementLb);
            this.Controls.Add(this.CourseLb);
            this.Controls.Add(this.TranchesAgeTC);
            this.Name = "ClassementTrancheAge";
            this.Text = "Classement par tranche d\'âge";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DateLb;
        private System.Windows.Forms.Label ClassementLb;
        private System.Windows.Forms.Label CourseLb;
        private System.Windows.Forms.TabControl TranchesAgeTC;
    }
}