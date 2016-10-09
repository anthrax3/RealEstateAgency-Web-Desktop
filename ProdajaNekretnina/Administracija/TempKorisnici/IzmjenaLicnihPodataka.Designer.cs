namespace Administracija.TempKorisnici
{
    partial class IzmjenaLicnihPodataka
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
            this.btnSpasi = new System.Windows.Forms.Button();
            this.telefonInput = new System.Windows.Forms.MaskedTextBox();
            this.telefonLabel = new System.Windows.Forms.Label();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.prezimeInput = new System.Windows.Forms.TextBox();
            this.prezimeLabel = new System.Windows.Forms.Label();
            this.imeInput = new System.Windows.Forms.TextBox();
            this.imeLabel = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSpasi
            // 
            this.btnSpasi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpasi.Location = new System.Drawing.Point(178, 160);
            this.btnSpasi.Name = "btnSpasi";
            this.btnSpasi.Size = new System.Drawing.Size(98, 43);
            this.btnSpasi.TabIndex = 59;
            this.btnSpasi.Text = "Spasi";
            this.btnSpasi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSpasi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSpasi.UseVisualStyleBackColor = true;
            this.btnSpasi.Click += new System.EventHandler(this.btnSpasi_Click);
            // 
            // telefonInput
            // 
            this.telefonInput.Location = new System.Drawing.Point(81, 112);
            this.telefonInput.Mask = "(999) 000-000";
            this.telefonInput.Name = "telefonInput";
            this.telefonInput.Size = new System.Drawing.Size(195, 20);
            this.telefonInput.TabIndex = 56;
            this.telefonInput.Validating += new System.ComponentModel.CancelEventHandler(this.telefonInput_Validating);
            // 
            // telefonLabel
            // 
            this.telefonLabel.AutoSize = true;
            this.telefonLabel.Location = new System.Drawing.Point(24, 112);
            this.telefonLabel.Name = "telefonLabel";
            this.telefonLabel.Size = new System.Drawing.Size(46, 13);
            this.telefonLabel.TabIndex = 58;
            this.telefonLabel.Text = "Telefon:";
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(81, 83);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(195, 20);
            this.emailInput.TabIndex = 55;
            this.emailInput.Validating += new System.ComponentModel.CancelEventHandler(this.emailInput_Validating);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(32, 86);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(38, 13);
            this.emailLabel.TabIndex = 57;
            this.emailLabel.Text = "E-mail:";
            // 
            // prezimeInput
            // 
            this.prezimeInput.Location = new System.Drawing.Point(81, 57);
            this.prezimeInput.Name = "prezimeInput";
            this.prezimeInput.Size = new System.Drawing.Size(195, 20);
            this.prezimeInput.TabIndex = 53;
            this.prezimeInput.Validating += new System.ComponentModel.CancelEventHandler(this.prezimeInput_Validating);
            // 
            // prezimeLabel
            // 
            this.prezimeLabel.AutoSize = true;
            this.prezimeLabel.Location = new System.Drawing.Point(24, 60);
            this.prezimeLabel.Name = "prezimeLabel";
            this.prezimeLabel.Size = new System.Drawing.Size(47, 13);
            this.prezimeLabel.TabIndex = 54;
            this.prezimeLabel.Text = "Prezime:";
            // 
            // imeInput
            // 
            this.imeInput.Location = new System.Drawing.Point(81, 31);
            this.imeInput.Name = "imeInput";
            this.imeInput.Size = new System.Drawing.Size(195, 20);
            this.imeInput.TabIndex = 52;
            this.imeInput.Validating += new System.ComponentModel.CancelEventHandler(this.imeInput_Validating);
            // 
            // imeLabel
            // 
            this.imeLabel.AutoSize = true;
            this.imeLabel.Location = new System.Drawing.Point(43, 31);
            this.imeLabel.Name = "imeLabel";
            this.imeLabel.Size = new System.Drawing.Size(27, 13);
            this.imeLabel.TabIndex = 51;
            this.imeLabel.Text = "Ime:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // IzmjenaLicnihPodataka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 244);
            this.Controls.Add(this.btnSpasi);
            this.Controls.Add(this.telefonInput);
            this.Controls.Add(this.telefonLabel);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.prezimeInput);
            this.Controls.Add(this.prezimeLabel);
            this.Controls.Add(this.imeInput);
            this.Controls.Add(this.imeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(332, 283);
            this.MinimumSize = new System.Drawing.Size(332, 283);
            this.Name = "IzmjenaLicnihPodataka";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izmjena licnih podataka";
            this.Load += new System.EventHandler(this.IzmjenaLicnihPodataka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpasi;
        private System.Windows.Forms.MaskedTextBox telefonInput;
        private System.Windows.Forms.Label telefonLabel;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox prezimeInput;
        private System.Windows.Forms.Label prezimeLabel;
        private System.Windows.Forms.TextBox imeInput;
        private System.Windows.Forms.Label imeLabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}