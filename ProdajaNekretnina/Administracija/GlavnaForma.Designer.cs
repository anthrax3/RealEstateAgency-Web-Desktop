namespace Administracija
{
    partial class GlavnaForma
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNoviKorisnik = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPretragaKorisnika = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDodajNekretninu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPregledNekretnina = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPregled = new System.Windows.Forms.ToolStripMenuItem();
            this.izvještajiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvještajiPoDatumuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printanjeUgovoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem4,
            this.btnPregled,
            this.izvještajiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(633, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNoviKorisnik,
            this.btnPretragaKorisnika});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(81, 25);
            this.toolStripMenuItem1.Text = "Korisnici";
            // 
            // btnNoviKorisnik
            // 
            this.btnNoviKorisnik.Name = "btnNoviKorisnik";
            this.btnNoviKorisnik.Size = new System.Drawing.Size(206, 26);
            this.btnNoviKorisnik.Text = "Novi korisnik";
            this.btnNoviKorisnik.Click += new System.EventHandler(this.btnNoviKorisnik_Click);
            // 
            // btnPretragaKorisnika
            // 
            this.btnPretragaKorisnika.Name = "btnPretragaKorisnika";
            this.btnPretragaKorisnika.Size = new System.Drawing.Size(206, 26);
            this.btnPretragaKorisnika.Text = "Pretraga korisnika";
            this.btnPretragaKorisnika.Click += new System.EventHandler(this.btnPretragaKorisnika_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDodajNekretninu,
            this.btnPregledNekretnina});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(99, 25);
            this.toolStripMenuItem4.Text = "Nekretnine";
            // 
            // btnDodajNekretninu
            // 
            this.btnDodajNekretninu.Name = "btnDodajNekretninu";
            this.btnDodajNekretninu.Size = new System.Drawing.Size(211, 26);
            this.btnDodajNekretninu.Text = "Dodaj";
            this.btnDodajNekretninu.Click += new System.EventHandler(this.btnDodajNekretninu_Click);
            // 
            // btnPregledNekretnina
            // 
            this.btnPregledNekretnina.Name = "btnPregledNekretnina";
            this.btnPregledNekretnina.Size = new System.Drawing.Size(211, 26);
            this.btnPregledNekretnina.Text = "Pregled nekretnina";
            this.btnPregledNekretnina.Click += new System.EventHandler(this.btnPregledNekretnina_Click);
            // 
            // btnPregled
            // 
            this.btnPregled.Name = "btnPregled";
            this.btnPregled.Size = new System.Drawing.Size(140, 25);
            this.btnPregled.Text = "Pregled narudžbi";
            this.btnPregled.Click += new System.EventHandler(this.btnPregled_Click);
            // 
            // izvještajiToolStripMenuItem
            // 
            this.izvještajiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izvještajiPoDatumuToolStripMenuItem,
            this.printanjeUgovoraToolStripMenuItem});
            this.izvještajiToolStripMenuItem.Name = "izvještajiToolStripMenuItem";
            this.izvještajiToolStripMenuItem.Size = new System.Drawing.Size(81, 25);
            this.izvještajiToolStripMenuItem.Text = "Izvještaji";
            // 
            // izvještajiPoDatumuToolStripMenuItem
            // 
            this.izvještajiPoDatumuToolStripMenuItem.Name = "izvještajiPoDatumuToolStripMenuItem";
            this.izvještajiPoDatumuToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.izvještajiPoDatumuToolStripMenuItem.Text = "Izvještaji po datumu";
            this.izvještajiPoDatumuToolStripMenuItem.Click += new System.EventHandler(this.izvještajiPoDatumuToolStripMenuItem_Click);
            // 
            // printanjeUgovoraToolStripMenuItem
            // 
            this.printanjeUgovoraToolStripMenuItem.Name = "printanjeUgovoraToolStripMenuItem";
            this.printanjeUgovoraToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.printanjeUgovoraToolStripMenuItem.Text = "Printanje ugovora";
            this.printanjeUgovoraToolStripMenuItem.Click += new System.EventHandler(this.printanjeUgovoraToolStripMenuItem_Click);
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 416);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GlavnaForma";
            this.Text = "GlavnaForma";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem btnNoviKorisnik;
        private System.Windows.Forms.ToolStripMenuItem btnPretragaKorisnika;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem btnDodajNekretninu;
        private System.Windows.Forms.ToolStripMenuItem btnPregledNekretnina;
        private System.Windows.Forms.ToolStripMenuItem btnPregled;
        private System.Windows.Forms.ToolStripMenuItem izvještajiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvještajiPoDatumuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printanjeUgovoraToolStripMenuItem;
    }
}