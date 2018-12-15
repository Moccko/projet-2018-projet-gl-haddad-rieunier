namespace App
{
    partial class ImporterParticipations
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
            this.ImporterCourseLb = new System.Windows.Forms.Label();
            this.SelectionnerCsvBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ValiderBtn
            // 
            this.ValiderBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ValiderBtn.Enabled = false;
            this.ValiderBtn.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValiderBtn.Location = new System.Drawing.Point(24, 211);
            this.ValiderBtn.Name = "ValiderBtn";
            this.ValiderBtn.Size = new System.Drawing.Size(236, 39);
            this.ValiderBtn.TabIndex = 18;
            this.ValiderBtn.Text = "Valider";
            this.ValiderBtn.UseVisualStyleBackColor = true;
            this.ValiderBtn.Click += new System.EventHandler(this.ValiderBtn_Click);
            // 
            // ImporterCourseLb
            // 
            this.ImporterCourseLb.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImporterCourseLb.Location = new System.Drawing.Point(33, 9);
            this.ImporterCourseLb.Name = "ImporterCourseLb";
            this.ImporterCourseLb.Size = new System.Drawing.Size(219, 66);
            this.ImporterCourseLb.TabIndex = 17;
            this.ImporterCourseLb.Text = "Importer des résultats";
            this.ImporterCourseLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectionnerCsvBtn
            // 
            this.SelectionnerCsvBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectionnerCsvBtn.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectionnerCsvBtn.Location = new System.Drawing.Point(24, 101);
            this.SelectionnerCsvBtn.Name = "SelectionnerCsvBtn";
            this.SelectionnerCsvBtn.Size = new System.Drawing.Size(236, 81);
            this.SelectionnerCsvBtn.TabIndex = 19;
            this.SelectionnerCsvBtn.Text = "Sélectionner un ficher csv";
            this.SelectionnerCsvBtn.UseVisualStyleBackColor = true;
            this.SelectionnerCsvBtn.Click += new System.EventHandler(this.SelectionnerCsvBtn_Click);
            // 
            // ImporterParticipations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.SelectionnerCsvBtn);
            this.Controls.Add(this.ValiderBtn);
            this.Controls.Add(this.ImporterCourseLb);
            this.Name = "ImporterParticipations";
            this.Text = "ImporterCourse";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ValiderBtn;
        private System.Windows.Forms.Label ImporterCourseLb;
        private System.Windows.Forms.Button SelectionnerCsvBtn;
    }
}