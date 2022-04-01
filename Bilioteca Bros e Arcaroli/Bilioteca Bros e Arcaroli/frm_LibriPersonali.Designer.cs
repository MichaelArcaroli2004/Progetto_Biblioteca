
namespace Bilioteca_Bros_e_Arcaroli
{
    partial class frm_LibriPersonali
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
            this.pct_home = new System.Windows.Forms.PictureBox();
            this.lbl_DataRestituzione = new System.Windows.Forms.Label();
            this.lbl_DataPrestito = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pct_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pct_home
            // 
            this.pct_home.BackgroundImage = global::Bilioteca_Bros_e_Arcaroli.Properties.Resources.home_icon;
            this.pct_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pct_home.Location = new System.Drawing.Point(567, 2);
            this.pct_home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pct_home.Name = "pct_home";
            this.pct_home.Size = new System.Drawing.Size(47, 34);
            this.pct_home.TabIndex = 9;
            this.pct_home.TabStop = false;
            this.pct_home.Click += new System.EventHandler(this.pct_home_Click);
            // 
            // lbl_DataRestituzione
            // 
            this.lbl_DataRestituzione.AutoSize = true;
            this.lbl_DataRestituzione.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_DataRestituzione.Location = new System.Drawing.Point(420, 58);
            this.lbl_DataRestituzione.Name = "lbl_DataRestituzione";
            this.lbl_DataRestituzione.Size = new System.Drawing.Size(125, 19);
            this.lbl_DataRestituzione.TabIndex = 8;
            this.lbl_DataRestituzione.Text = "Data Restituzione";
            // 
            // lbl_DataPrestito
            // 
            this.lbl_DataPrestito.AutoSize = true;
            this.lbl_DataPrestito.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_DataPrestito.Location = new System.Drawing.Point(286, 58);
            this.lbl_DataPrestito.Name = "lbl_DataPrestito";
            this.lbl_DataPrestito.Size = new System.Drawing.Size(96, 19);
            this.lbl_DataPrestito.TabIndex = 7;
            this.lbl_DataPrestito.Text = "Data Prestito";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "I miei libri";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(2, 41);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(627, 8);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frm_LibriPersonali
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 338);
            this.Controls.Add(this.pct_home);
            this.Controls.Add(this.lbl_DataRestituzione);
            this.Controls.Add(this.lbl_DataPrestito);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_LibriPersonali";
            this.Text = "frm_LibriPersonali";
            this.Load += new System.EventHandler(this.frm_LibriPersonali_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pct_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pct_home;
        private System.Windows.Forms.Label lbl_DataRestituzione;
        private System.Windows.Forms.Label lbl_DataPrestito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}