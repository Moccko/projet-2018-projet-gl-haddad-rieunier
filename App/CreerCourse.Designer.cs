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
            this.DateLb = new System.Windows.Forms.Label();
            this.DateMTB = new System.Windows.Forms.MaskedTextBox();
            this.NomTB = new System.Windows.Forms.TextBox();
            this.NomLb = new System.Windows.Forms.Label();
            this.CreerCourseLb = new System.Windows.Forms.Label();
            this.ValiderBtn = new System.Windows.Forms.Button();
            this.AnneeTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.DateCal = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // DateLb
            // 
            this.DateLb.AutoSize = true;
            this.DateLb.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLb.Location = new System.Drawing.Point(12, 144);
            this.DateLb.Name = "DateLb";
            this.DateLb.Size = new System.Drawing.Size(145, 19);
            this.DateLb.TabIndex = 8;
            this.DateLb.Text = "Date de la course";
            this.DateLb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DateMTB
            // 
            this.DateMTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateMTB.Location = new System.Drawing.Point(12, 166);
            this.DateMTB.Mask = "00/00/0000";
            this.DateMTB.Name = "DateMTB";
            this.DateMTB.Size = new System.Drawing.Size(260, 20);
            this.DateMTB.TabIndex = 1;
            this.DateMTB.ValidatingType = typeof(System.DateTime);
            this.DateMTB.TextChanged += new System.EventHandler(this.AnneeMTB_TextChanged);
            this.DateMTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DateMTB_KeyUp);
            // 
            // NomTB
            // 
            this.NomTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NomTB.Location = new System.Drawing.Point(12, 108);
            this.NomTB.Name = "NomTB";
            this.NomTB.Size = new System.Drawing.Size(260, 20);
            this.NomTB.TabIndex = 0;
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
            this.ValiderBtn.Location = new System.Drawing.Point(61, 370);
            this.ValiderBtn.Name = "ValiderBtn";
            this.ValiderBtn.Size = new System.Drawing.Size(162, 39);
            this.ValiderBtn.TabIndex = 2;
            this.ValiderBtn.Text = "Valider";
            this.ValiderBtn.UseVisualStyleBackColor = true;
            // 
            // DateCal
            // 
            this.DateCal.Location = new System.Drawing.Point(46, 187);
            this.DateCal.Name = "DateCal";
            this.DateCal.TabIndex = 3;
            this.DateCal.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.DateCal_DateChanged);
            // 
            // CreerCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 421);
            this.Controls.Add(this.DateCal);
            this.Controls.Add(this.ValiderBtn);
            this.Controls.Add(this.CreerCourseLb);
            this.Controls.Add(this.DateLb);
            this.Controls.Add(this.DateMTB);
            this.Controls.Add(this.NomTB);
            this.Controls.Add(this.NomLb);
            this.Name = "CreerCourse";
            this.Text = "CreerCourse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DateLb;
        private System.Windows.Forms.MaskedTextBox DateMTB;
        private System.Windows.Forms.TextBox NomTB;
        private System.Windows.Forms.Label NomLb;
        private System.Windows.Forms.Label CreerCourseLb;
        private System.Windows.Forms.Button ValiderBtn;
        private System.Windows.Forms.ToolTip AnneeTooltip;
        private System.Windows.Forms.MonthCalendar DateCal;
    }
}