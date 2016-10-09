namespace Administracija.TempNarudzbe
{
    partial class PregledNarudzbi
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
            this.btnTrazi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewNekretnine = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNekretnine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTrazi
            // 
            this.btnTrazi.Location = new System.Drawing.Point(452, 40);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(68, 25);
            this.btnTrazi.TabIndex = 89;
            this.btnTrazi.Text = "Traži";
            this.btnTrazi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrazi.UseVisualStyleBackColor = true;
            this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 87;
            this.label4.Text = "Datum narudzbe";
            // 
            // dataGridViewNekretnine
            // 
            this.dataGridViewNekretnine.AllowUserToAddRows = false;
            this.dataGridViewNekretnine.AllowUserToDeleteRows = false;
            this.dataGridViewNekretnine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNekretnine.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewNekretnine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewNekretnine.Location = new System.Drawing.Point(0, 93);
            this.dataGridViewNekretnine.Name = "dataGridViewNekretnine";
            this.dataGridViewNekretnine.ReadOnly = true;
            this.dataGridViewNekretnine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewNekretnine.Size = new System.Drawing.Size(667, 254);
            this.dataGridViewNekretnine.TabIndex = 83;
            this.dataGridViewNekretnine.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNekretnine_CellDoubleClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(118, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 90;
            // 
            // PregledNarudzbi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 347);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnTrazi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewNekretnine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PregledNarudzbi";
            this.Text = "Pregled narudžbi";
            this.Load += new System.EventHandler(this.PregledNarudzbi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNekretnine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewNekretnine;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}