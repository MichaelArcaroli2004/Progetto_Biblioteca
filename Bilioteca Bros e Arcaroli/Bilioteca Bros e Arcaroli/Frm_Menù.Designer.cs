
namespace Bilioteca_Bros_e_Arcaroli
{
    partial class Frm_Menù
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Registrati = new System.Windows.Forms.Button();
            this.lbl_Biblioteca = new System.Windows.Forms.Label();
            this.btn_AccediSenzaAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(48, 245);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(167, 65);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Registrati
            // 
            this.btn_Registrati.Location = new System.Drawing.Point(405, 245);
            this.btn_Registrati.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Registrati.Name = "btn_Registrati";
            this.btn_Registrati.Size = new System.Drawing.Size(167, 65);
            this.btn_Registrati.TabIndex = 1;
            this.btn_Registrati.Text = "Registrati";
            this.btn_Registrati.UseVisualStyleBackColor = true;
            this.btn_Registrati.Click += new System.EventHandler(this.btn_Registrati_Click);
            // 
            // lbl_Biblioteca
            // 
            this.lbl_Biblioteca.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Biblioteca.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Biblioteca.ForeColor = System.Drawing.Color.Black;
            this.lbl_Biblioteca.Location = new System.Drawing.Point(180, 19);
            this.lbl_Biblioteca.Name = "lbl_Biblioteca";
            this.lbl_Biblioteca.Size = new System.Drawing.Size(335, 64);
            this.lbl_Biblioteca.TabIndex = 2;
            this.lbl_Biblioteca.Text = "Biblioteca";
            // 
            // btn_AccediSenzaAccount
            // 
            this.btn_AccediSenzaAccount.Location = new System.Drawing.Point(221, 244);
            this.btn_AccediSenzaAccount.Name = "btn_AccediSenzaAccount";
            this.btn_AccediSenzaAccount.Size = new System.Drawing.Size(178, 66);
            this.btn_AccediSenzaAccount.TabIndex = 3;
            this.btn_AccediSenzaAccount.Text = "Accedi senza account ";
            this.btn_AccediSenzaAccount.UseVisualStyleBackColor = true;
            this.btn_AccediSenzaAccount.Click += new System.EventHandler(this.btn_ApriVeloce_Click);
            // 
            // Frm_Menù
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 343);
            this.Controls.Add(this.btn_AccediSenzaAccount);
            this.Controls.Add(this.lbl_Biblioteca);
            this.Controls.Add(this.btn_Registrati);
            this.Controls.Add(this.btn_Login);
            this.Name = "Frm_Menù";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Registrati;
        private System.Windows.Forms.Label lbl_Biblioteca;
        private System.Windows.Forms.Button btn_AccediSenzaAccount;
    }
}

