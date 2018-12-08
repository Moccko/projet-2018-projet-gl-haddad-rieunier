namespace App
{
    partial class ListeCoureurs
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
            this.CoureursDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CoureursDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // CoureursDGV
            // 
            this.CoureursDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CoureursDGV.Location = new System.Drawing.Point(12, 142);
            this.CoureursDGV.Name = "CoureursDGV";
            this.CoureursDGV.Size = new System.Drawing.Size(680, 216);
            this.CoureursDGV.TabIndex = 0;
            // 
            // ListeCoureurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 370);
            this.Controls.Add(this.CoureursDGV);
            this.Name = "ListeCoureurs";
            this.Text = "ListeCoureurs";
            ((System.ComponentModel.ISupportInitialize)(this.CoureursDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CoureursDGV;
    }
}