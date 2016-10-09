namespace Administracija.TempKorisnici
{
    partial class PretragaKorisnika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PretragaKorisnika));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.deaktivirajSubmit = new System.Windows.Forms.ToolStripButton();
            this.izmjeneMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnStatusPodaci = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLicniPodaci = new System.Windows.Forms.ToolStripMenuItem();
            this.korisniciGrid = new System.Windows.Forms.DataGridView();
            this.imePrezimeInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deaktivirajSubmit,
            this.izmjeneMenu});
            this.toolStrip1.Location = new System.Drawing.Point(0, 72);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(471, 25);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // deaktivirajSubmit
            // 
            this.deaktivirajSubmit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.deaktivirajSubmit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deaktivirajSubmit.Name = "deaktivirajSubmit";
            this.deaktivirajSubmit.Size = new System.Drawing.Size(66, 22);
            this.deaktivirajSubmit.Text = "Deaktiviraj";
            this.deaktivirajSubmit.ToolTipText = "Deaktiviraj status";
            this.deaktivirajSubmit.Click += new System.EventHandler(this.deaktivirajSubmit_Click);
            // 
            // izmjeneMenu
            // 
            this.izmjeneMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.izmjeneMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnStatusPodaci,
            this.btnLicniPodaci});
            this.izmjeneMenu.Image = ((System.Drawing.Image)(resources.GetObject("izmjeneMenu.Image")));
            this.izmjeneMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.izmjeneMenu.Name = "izmjeneMenu";
            this.izmjeneMenu.Size = new System.Drawing.Size(61, 22);
            this.izmjeneMenu.Text = "Izmjene";
            this.izmjeneMenu.Click += new System.EventHandler(this.izmjeneMenu_Click);
            // 
            // btnStatusPodaci
            // 
            this.btnStatusPodaci.Name = "btnStatusPodaci";
            this.btnStatusPodaci.Size = new System.Drawing.Size(175, 22);
            this.btnStatusPodaci.Text = "Statusnih podataka";
            this.btnStatusPodaci.Click += new System.EventHandler(this.btnStatusPodaci_Click);
            // 
            // btnLicniPodaci
            // 
            this.btnLicniPodaci.Name = "btnLicniPodaci";
            this.btnLicniPodaci.Size = new System.Drawing.Size(175, 22);
            this.btnLicniPodaci.Text = "Ličnih podataka";
            this.btnLicniPodaci.Click += new System.EventHandler(this.btnLicniPodaci_Click);
            // 
            // korisniciGrid
            // 
            this.korisniciGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.korisniciGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.korisniciGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.korisniciGrid.Location = new System.Drawing.Point(0, 97);
            this.korisniciGrid.MultiSelect = false;
            this.korisniciGrid.Name = "korisniciGrid";
            this.korisniciGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.korisniciGrid.Size = new System.Drawing.Size(471, 223);
            this.korisniciGrid.TabIndex = 10;
            this.korisniciGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.korisniciGrid_CellClick);
            // 
            // imePrezimeInput
            // 
            this.imePrezimeInput.Location = new System.Drawing.Point(101, 13);
            this.imePrezimeInput.Name = "imePrezimeInput";
            this.imePrezimeInput.Size = new System.Drawing.Size(296, 20);
            this.imePrezimeInput.TabIndex = 9;
            this.imePrezimeInput.TextChanged += new System.EventHandler(this.imePrezimeInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ime i prezime:";
            // 
            // PretragaKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 320);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.korisniciGrid);
            this.Controls.Add(this.imePrezimeInput);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PretragaKorisnika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PretragaKorisnika";
            this.Load += new System.EventHandler(this.PretragaKorisnika_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton deaktivirajSubmit;
        private System.Windows.Forms.ToolStripDropDownButton izmjeneMenu;
        private System.Windows.Forms.ToolStripMenuItem btnStatusPodaci;
        private System.Windows.Forms.ToolStripMenuItem btnLicniPodaci;
        private System.Windows.Forms.DataGridView korisniciGrid;
        private System.Windows.Forms.TextBox imePrezimeInput;
        private System.Windows.Forms.Label label1;
    }
}