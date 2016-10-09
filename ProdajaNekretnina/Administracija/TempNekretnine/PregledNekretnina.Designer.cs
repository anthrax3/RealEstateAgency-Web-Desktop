namespace Administracija.TempNekretnine
{
    partial class PregledNekretnina
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
            this.dataGridViewNekretnine = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxKategorije = new System.Windows.Forms.ComboBox();
            this.comboVrste = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxAktivna = new System.Windows.Forms.CheckBox();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNekretnine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewNekretnine
            // 
            this.dataGridViewNekretnine.AllowUserToAddRows = false;
            this.dataGridViewNekretnine.AllowUserToDeleteRows = false;
            this.dataGridViewNekretnine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNekretnine.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewNekretnine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewNekretnine.Location = new System.Drawing.Point(0, 321);
            this.dataGridViewNekretnine.Name = "dataGridViewNekretnine";
            this.dataGridViewNekretnine.ReadOnly = true;
            this.dataGridViewNekretnine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewNekretnine.Size = new System.Drawing.Size(1280, 415);
            this.dataGridViewNekretnine.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(319, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 66;
            this.label7.Text = "Kategorija:";
            // 
            // comboBoxKategorije
            // 
            this.comboBoxKategorije.CausesValidation = false;
            this.comboBoxKategorije.FormattingEnabled = true;
            this.comboBoxKategorije.Location = new System.Drawing.Point(382, 57);
            this.comboBoxKategorije.Name = "comboBoxKategorije";
            this.comboBoxKategorije.Size = new System.Drawing.Size(209, 21);
            this.comboBoxKategorije.TabIndex = 65;
            this.comboBoxKategorije.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxKategorije_Validating);
            // 
            // comboVrste
            // 
            this.comboVrste.CausesValidation = false;
            this.comboVrste.FormattingEnabled = true;
            this.comboVrste.Location = new System.Drawing.Point(74, 57);
            this.comboVrste.Name = "comboVrste";
            this.comboVrste.Size = new System.Drawing.Size(209, 21);
            this.comboVrste.TabIndex = 67;
            this.comboVrste.Validating += new System.ComponentModel.CancelEventHandler(this.comboVrste_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 68;
            this.label4.Text = "Vrsta:";
            // 
            // checkBoxAktivna
            // 
            this.checkBoxAktivna.AutoSize = true;
            this.checkBoxAktivna.CausesValidation = false;
            this.checkBoxAktivna.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxAktivna.Location = new System.Drawing.Point(26, 94);
            this.checkBoxAktivna.Name = "checkBoxAktivna";
            this.checkBoxAktivna.Size = new System.Drawing.Size(62, 17);
            this.checkBoxAktivna.TabIndex = 78;
            this.checkBoxAktivna.Text = "Aktivna";
            this.checkBoxAktivna.UseVisualStyleBackColor = true;
            // 
            // btnTrazi
            // 
            this.btnTrazi.Location = new System.Drawing.Point(523, 94);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(68, 25);
            this.btnTrazi.TabIndex = 82;
            this.btnTrazi.Text = "Traži";
            this.btnTrazi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrazi.UseVisualStyleBackColor = true;
            this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PregledNekretnina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1280, 736);
            this.Controls.Add(this.btnTrazi);
            this.Controls.Add(this.checkBoxAktivna);
            this.Controls.Add(this.comboVrste);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxKategorije);
            this.Controls.Add(this.dataGridViewNekretnine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PregledNekretnina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled nekretnina";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PregledNekretnina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNekretnine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNekretnine;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxKategorije;
        private System.Windows.Forms.ComboBox comboVrste;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxAktivna;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}