namespace App
{
    partial class Connexion
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
            this.TitreLb = new System.Windows.Forms.Label();
            this.ConnexionBtn = new System.Windows.Forms.Button();
            this.IdTB = new System.Windows.Forms.TextBox();
            this.MdpTB = new System.Windows.Forms.TextBox();
            this.IdLb = new System.Windows.Forms.Label();
            this.MdpLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitreLb
            // 
            this.TitreLb.AutoSize = true;
            this.TitreLb.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitreLb.Location = new System.Drawing.Point(69, 31);
            this.TitreLb.Name = "TitreLb";
            this.TitreLb.Size = new System.Drawing.Size(141, 27);
            this.TitreLb.TabIndex = 0;
            this.TitreLb.Text = "Connexion";
            // 
            // ConnexionBtn
            // 
            this.ConnexionBtn.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnexionBtn.Location = new System.Drawing.Point(102, 211);
            this.ConnexionBtn.Name = "ConnexionBtn";
            this.ConnexionBtn.Size = new System.Drawing.Size(75, 27);
            this.ConnexionBtn.TabIndex = 1;
            this.ConnexionBtn.Text = "Entrer";
            this.ConnexionBtn.UseVisualStyleBackColor = true;
            this.ConnexionBtn.Click += new System.EventHandler(this.ConnexionBtn_Click);
            // 
            // IdTB
            // 
            this.IdTB.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTB.Location = new System.Drawing.Point(33, 97);
            this.IdTB.Name = "IdTB";
            this.IdTB.Size = new System.Drawing.Size(212, 22);
            this.IdTB.TabIndex = 2;
            // 
            // MdpTB
            // 
            this.MdpTB.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MdpTB.Location = new System.Drawing.Point(35, 156);
            this.MdpTB.Name = "MdpTB";
            this.MdpTB.PasswordChar = '*';
            this.MdpTB.Size = new System.Drawing.Size(209, 22);
            this.MdpTB.TabIndex = 3;
            // 
            // IdLb
            // 
            this.IdLb.AutoSize = true;
            this.IdLb.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLb.Location = new System.Drawing.Point(32, 79);
            this.IdLb.Name = "IdLb";
            this.IdLb.Size = new System.Drawing.Size(82, 15);
            this.IdLb.TabIndex = 4;
            this.IdLb.Text = "Identifiant";
            // 
            // MdpLb
            // 
            this.MdpLb.AutoSize = true;
            this.MdpLb.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MdpLb.Location = new System.Drawing.Point(32, 138);
            this.MdpLb.Name = "MdpLb";
            this.MdpLb.Size = new System.Drawing.Size(88, 15);
            this.MdpLb.TabIndex = 5;
            this.MdpLb.Text = "Mot de passe";
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.MdpLb);
            this.Controls.Add(this.IdLb);
            this.Controls.Add(this.MdpTB);
            this.Controls.Add(this.IdTB);
            this.Controls.Add(this.ConnexionBtn);
            this.Controls.Add(this.TitreLb);
            this.Name = "Connexion";
            this.Text = "Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitreLb;
        private System.Windows.Forms.Button ConnexionBtn;
        private System.Windows.Forms.TextBox IdTB;
        private System.Windows.Forms.TextBox MdpTB;
        private System.Windows.Forms.Label IdLb;
        private System.Windows.Forms.Label MdpLb;
    }
}