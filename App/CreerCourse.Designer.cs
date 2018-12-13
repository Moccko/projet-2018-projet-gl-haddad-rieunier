namespace App
{
    partial class CreerCourse
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
            this.AnneeLb = new System.Windows.Forms.Label();
            this.AnneeMTB = new System.Windows.Forms.MaskedTextBox();
            this.NomTB = new System.Windows.Forms.TextBox();
            this.NomLb = new System.Windows.Forms.Label();
            this.CreerCourseLb = new System.Windows.Forms.Label();
            this.ValiderBtn = new System.Windows.Forms.Button();
            this.AnneeTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // AnneeLb
            // 
            this.AnneeLb.AutoSize = true;
            this.AnneeLb.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnneeLb.Location = new System.Drawing.Point(12, 144);
            this.AnneeLb.Name = "AnneeLb";
            this.AnneeLb.Size = new System.Drawing.Size(159, 19);
            this.AnneeLb.TabIndex = 8;
            this.AnneeLb.Text = "Année de la course";
            this.AnneeLb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AnneeMTB
            // 
            this.AnneeMTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AnneeMTB.Location = new System.Drawing.Point(12, 166);
            this.AnneeMTB.Mask = "2099";
            this.AnneeMTB.Name = "AnneeMTB";
            this.AnneeMTB.Size = new System.Drawing.Size(260, 20);
            this.AnneeMTB.TabIndex = 7;
            this.AnneeMTB.TextChanged += new System.EventHandler(this.AnneeMTB_TextChanged);
            // 
            // NomTB
            // 
            this.NomTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NomTB.Location = new System.Drawing.Point(12, 108);
            this.NomTB.Name = "NomTB";
            this.NomTB.Size = new System.Drawing.Size(260, 20);
            this.NomTB.TabIndex = 6;
            this.NomTB.TextChanged += new System.EventHandler(this.NomTB_TextChanged);
            // 
            // NomLb
            // 
            this.NomLb.AutoSize = true;
            this.NomLb.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomLb.Location = new System.Drawing.Point(12, 86);
            this.NomLb.Name = "NomLb";
            this.NomLb.Size = new System.Drawing.Size(146, 19);
            this.NomLb.TabIndex = 5;
            this.NomLb.Text = "Nom de la course";
            this.NomLb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CreerCourseLb
            // 
            this.CreerCourseLb.AutoSize = true;
            this.CreerCourseLb.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreerCourseLb.Location = new System.Drawing.Point(21, 23);
            this.CreerCourseLb.Name = "CreerCourseLb";
            this.CreerCourseLb.Size = new System.Drawing.Size(242, 31);
            this.CreerCourseLb.TabIndex = 9;
            this.CreerCourseLb.Text = "Créer une course";
            // 
            // ValiderBtn
            // 
            this.ValiderBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ValiderBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ValiderBtn.Enabled = false;
            this.ValiderBtn.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValiderBtn.Location = new System.Drawing.Point(61, 211);
            this.ValiderBtn.Name = "ValiderBtn";
            this.ValiderBtn.Size = new System.Drawing.Size(162, 39);
            this.ValiderBtn.TabIndex = 10;
            this.ValiderBtn.Text = "Valider";
            this.ValiderBtn.UseVisualStyleBackColor = true;
            // 
            // CreerCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.ValiderBtn);
            this.Controls.Add(this.CreerCourseLb);
            this.Controls.Add(this.AnneeLb);
            this.Controls.Add(this.AnneeMTB);
            this.Controls.Add(this.NomTB);
            this.Controls.Add(this.NomLb);
            this.Name = "CreerCourse";
            this.Text = "CreerCourse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AnneeLb;
        private System.Windows.Forms.MaskedTextBox AnneeMTB;
        private System.Windows.Forms.TextBox NomTB;
        private System.Windows.Forms.Label NomLb;
        private System.Windows.Forms.Label CreerCourseLb;
        private System.Windows.Forms.Button ValiderBtn;
        private System.Windows.Forms.ToolTip AnneeTooltip;
    }
}