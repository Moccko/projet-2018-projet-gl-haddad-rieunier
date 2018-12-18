namespace App
{
    partial class ClassementGlobal
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
            this.CourseLb = new System.Windows.Forms.Label();
            this.ClassementLb = new System.Windows.Forms.Label();
            this.DateLb = new System.Windows.Forms.Label();
            this.ClassementLV = new System.Windows.Forms.ListView();
            this.Place = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prénom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Temps = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // CourseLb
            // 
            this.CourseLb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CourseLb.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseLb.Location = new System.Drawing.Point(13, 13);
            this.CourseLb.Name = "CourseLb";
            this.CourseLb.Size = new System.Drawing.Size(366, 60);
            this.CourseLb.TabIndex = 0;
            this.CourseLb.Text = "Nom de la course";
            this.CourseLb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ClassementLb
            // 
            this.ClassementLb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassementLb.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassementLb.Location = new System.Drawing.Point(12, 73);
            this.ClassementLb.Name = "ClassementLb";
            this.ClassementLb.Size = new System.Drawing.Size(366, 24);
            this.ClassementLb.TabIndex = 1;
            this.ClassementLb.Text = "Classement global";
            this.ClassementLb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DateLb
            // 
            this.DateLb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateLb.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLb.Location = new System.Drawing.Point(12, 97);
            this.DateLb.Name = "DateLb";
            this.DateLb.Size = new System.Drawing.Size(366, 15);
            this.DateLb.TabIndex = 2;
            this.DateLb.Text = "Le 20/20/2020";
            this.DateLb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ClassementLV
            // 
            this.ClassementLV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassementLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Place,
            this.Prénom,
            this.Nom,
            this.Temps,
            this.Age});
            this.ClassementLV.Location = new System.Drawing.Point(15, 137);
            this.ClassementLV.Name = "ClassementLV";
            this.ClassementLV.Size = new System.Drawing.Size(364, 322);
            this.ClassementLV.TabIndex = 3;
            this.ClassementLV.UseCompatibleStateImageBehavior = false;
            this.ClassementLV.View = System.Windows.Forms.View.Details;
            // 
            // Place
            // 
            this.Place.Text = "Place";
            this.Place.Width = 40;
            // 
            // Prénom
            // 
            this.Prénom.Text = "Prénom";
            this.Prénom.Width = 100;
            // 
            // Nom
            // 
            this.Nom.Text = "Nom";
            this.Nom.Width = 100;
            // 
            // Temps
            // 
            this.Temps.Text = "Temps";
            // 
            // Age
            // 
            this.Age.Text = "Âge";
            // 
            // ClassementGlobal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 471);
            this.Controls.Add(this.ClassementLV);
            this.Controls.Add(this.DateLb);
            this.Controls.Add(this.ClassementLb);
            this.Controls.Add(this.CourseLb);
            this.Name = "ClassementGlobal";
            this.Text = "Classement global";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CourseLb;
        private System.Windows.Forms.Label ClassementLb;
        private System.Windows.Forms.Label DateLb;
        private System.Windows.Forms.ListView ClassementLV;
        private System.Windows.Forms.ColumnHeader Place;
        private System.Windows.Forms.ColumnHeader Prénom;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ColumnHeader Temps;
        private System.Windows.Forms.ColumnHeader Age;
    }
}