
namespace Bilioteca_Bros_e_Arcaroli
{
    partial class Frm_Biblioteca
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pct_ImmagineUtente = new System.Windows.Forms.PictureBox();
            this.cmb_OrdineLibri = new System.Windows.Forms.ComboBox();
            this.lbl_OrdineLibri = new System.Windows.Forms.Label();
            this.txt_Cerca = new System.Windows.Forms.TextBox();
            this.lbl_Cerca = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_FiltroScelto = new System.Windows.Forms.Label();
            this.lst_NomiLibriRicerca = new System.Windows.Forms.ListBox();
            this.lbl_Profilo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_ImmagineUtente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pct_ImmagineUtente
            // 
            this.pct_ImmagineUtente.Image = global::Bilioteca_Bros_e_Arcaroli.Properties.Resources.utente;
            this.pct_ImmagineUtente.Location = new System.Drawing.Point(907, 27);
            this.pct_ImmagineUtente.Name = "pct_ImmagineUtente";
            this.pct_ImmagineUtente.Size = new System.Drawing.Size(49, 48);
            this.pct_ImmagineUtente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_ImmagineUtente.TabIndex = 0;
            this.pct_ImmagineUtente.TabStop = false;
            this.pct_ImmagineUtente.Click += new System.EventHandler(this.pct_ImmagineUtente_Click);
            // 
            // cmb_OrdineLibri
            // 
            this.cmb_OrdineLibri.FormattingEnabled = true;
            this.cmb_OrdineLibri.Location = new System.Drawing.Point(23, 32);
            this.cmb_OrdineLibri.Name = "cmb_OrdineLibri";
            this.cmb_OrdineLibri.Size = new System.Drawing.Size(151, 28);
            this.cmb_OrdineLibri.TabIndex = 1;
            // 
            // lbl_OrdineLibri
            // 
            this.lbl_OrdineLibri.AutoSize = true;
            this.lbl_OrdineLibri.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_OrdineLibri.Location = new System.Drawing.Point(23, 9);
            this.lbl_OrdineLibri.Name = "lbl_OrdineLibri";
            this.lbl_OrdineLibri.Size = new System.Drawing.Size(86, 20);
            this.lbl_OrdineLibri.TabIndex = 2;
            this.lbl_OrdineLibri.Text = "ordina per:";
            // 
            // txt_Cerca
            // 
            this.txt_Cerca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Cerca.Location = new System.Drawing.Point(530, 32);
            this.txt_Cerca.Name = "txt_Cerca";
            this.txt_Cerca.Size = new System.Drawing.Size(125, 27);
            this.txt_Cerca.TabIndex = 3;
            this.txt_Cerca.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_Cerca
            // 
            this.lbl_Cerca.AutoSize = true;
            this.lbl_Cerca.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Cerca.Location = new System.Drawing.Point(530, 9);
            this.lbl_Cerca.Name = "lbl_Cerca";
            this.lbl_Cerca.Size = new System.Drawing.Size(47, 20);
            this.lbl_Cerca.TabIndex = 4;
            this.lbl_Cerca.Text = "Cerca";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(0, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(991, 10);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_FiltroScelto
            // 
            this.lbl_FiltroScelto.AutoSize = true;
            this.lbl_FiltroScelto.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_FiltroScelto.Location = new System.Drawing.Point(41, 107);
            this.lbl_FiltroScelto.Name = "lbl_FiltroScelto";
            this.lbl_FiltroScelto.Size = new System.Drawing.Size(62, 20);
            this.lbl_FiltroScelto.TabIndex = 7;
            this.lbl_FiltroScelto.Text = "Scaffale";
            // 
            // lst_NomiLibriRicerca
            // 
            this.lst_NomiLibriRicerca.FormattingEnabled = true;
            this.lst_NomiLibriRicerca.ItemHeight = 20;
            this.lst_NomiLibriRicerca.Location = new System.Drawing.Point(530, 65);
            this.lst_NomiLibriRicerca.Name = "lst_NomiLibriRicerca";
            this.lst_NomiLibriRicerca.Size = new System.Drawing.Size(150, 104);
            this.lst_NomiLibriRicerca.TabIndex = 8;
            this.lst_NomiLibriRicerca.Visible = false;
            // 
            // lbl_Profilo
            // 
            this.lbl_Profilo.AutoSize = true;
            this.lbl_Profilo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Profilo.Location = new System.Drawing.Point(901, 0);
            this.lbl_Profilo.Name = "lbl_Profilo";
            this.lbl_Profilo.Size = new System.Drawing.Size(55, 20);
            this.lbl_Profilo.TabIndex = 9;
            this.lbl_Profilo.Text = "Profilo";
            // 
            // Frm_Biblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 537);
            this.Controls.Add(this.lbl_Profilo);
            this.Controls.Add(this.lst_NomiLibriRicerca);
            this.Controls.Add(this.lbl_FiltroScelto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_Cerca);
            this.Controls.Add(this.txt_Cerca);
            this.Controls.Add(this.lbl_OrdineLibri);
            this.Controls.Add(this.cmb_OrdineLibri);
            this.Controls.Add(this.pct_ImmagineUtente);
            this.Name = "Frm_Biblioteca";
            this.Text = "frmBiblioteca";
            this.Load += new System.EventHandler(this.frmBiblioteca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_ImmagineUtente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.PictureBox pct_ImmagineUtente;
        private System.Windows.Forms.ComboBox cmb_OrdineLibri;
        private System.Windows.Forms.Label lbl_OrdineLibri;
        private System.Windows.Forms.TextBox txt_Cerca;
        private System.Windows.Forms.Label lbl_Cerca;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_FiltroScelto;
        private System.Windows.Forms.ListBox lst_NomiLibriRicerca;
        private System.Windows.Forms.Label lbl_Profilo;
    }
}