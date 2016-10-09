namespace Administracija.Korisnici
{
    partial class NoviKorisnik
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
            this.ulogeLabel = new System.Windows.Forms.Label();
            this.telefonInput = new System.Windows.Forms.MaskedTextBox();
            this.lozinkaInput = new System.Windows.Forms.TextBox();
            this.lozinkaLabel = new System.Windows.Forms.Label();
            this.korisnickoImeInput = new System.Windows.Forms.TextBox();
            this.korisnickoImeLabel = new System.Windows.Forms.Label();
            this.telefonLabel = new System.Windows.Forms.Label();
            this.dodajButton = new System.Windows.Forms.Button();
            this.ulogeList = new System.Windows.Forms.CheckedListBox();
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
            // ulogeLabel
            // 
            this.ulogeLabel.AutoSize = true;
            this.ulogeLabel.Location = new System.Drawing.Point(47, 212);
            this.ulogeLabel.Name = "ulogeLabel";
            this.ulogeLabel.Size = new System.Drawing.Size(38, 13);
            this.ulogeLabel.TabIndex = 60;
            this.ulogeLabel.Text = "Uloge:";
            // 
            // telefonInput
            // 
            this.telefonInput.Location = new System.Drawing.Point(95, 117);
            this.telefonInput.Mask = "(999) 000-000";
            this.telefonInput.Name = "telefonInput";
            this.telefonInput.Size = new System.Drawing.Size(195, 20);
            this.telefonInput.TabIndex = 51;
            this.telefonInput.Validating += new System.ComponentModel.CancelEventHandler(this.telefonInput_Validating);
            // 
            // lozinkaInput
            // 
            this.lozinkaInput.Location = new System.Drawing.Point(95, 186);
            this.lozinkaInput.Name = "lozinkaInput";
            this.lozinkaInput.PasswordChar = '*';
            this.lozinkaInput.Size = new System.Drawing.Size(195, 20);
            this.lozinkaInput.TabIndex = 54;
            this.lozinkaInput.Validating += new System.ComponentModel.CancelEventHandler(this.lozinkaInput_Validating);
            // 
            // lozinkaLabel
            // 
            this.lozinkaLabel.AutoSize = true;
            this.lozinkaLabel.Location = new System.Drawing.Point(38, 189);
            this.lozinkaLabel.Name = "lozinkaLabel";
            this.lozinkaLabel.Size = new System.Drawing.Size(47, 13);
            this.lozinkaLabel.TabIndex = 59;
            this.lozinkaLabel.Text = "Lozinka:";
            // 
            // korisnickoImeInput
            // 
            this.korisnickoImeInput.Location = new System.Drawing.Point(95, 160);
            this.korisnickoImeInput.Name = "korisnickoImeInput";
            this.korisnickoImeInput.Size = new System.Drawing.Size(195, 20);
            this.korisnickoImeInput.TabIndex = 53;
            this.korisnickoImeInput.Validating += new System.ComponentModel.CancelEventHandler(this.korisnickoImeInput_Validating);
            // 
            // korisnickoImeLabel
            // 
            this.korisnickoImeLabel.AutoSize = true;
            this.korisnickoImeLabel.Location = new System.Drawing.Point(11, 163);
            this.korisnickoImeLabel.Name = "korisnickoImeLabel";
            this.korisnickoImeLabel.Size = new System.Drawing.Size(78, 13);
            this.korisnickoImeLabel.TabIndex = 58;
            this.korisnickoImeLabel.Text = "Korisničko ime:";
            // 
            // telefonLabel
            // 
            this.telefonLabel.AutoSize = true;
            this.telefonLabel.Location = new System.Drawing.Point(38, 117);
            this.telefonLabel.Name = "telefonLabel";
            this.telefonLabel.Size = new System.Drawing.Size(46, 13);
            this.telefonLabel.TabIndex = 56;
            this.telefonLabel.Text = "Telefon:";
            // 
            // dodajButton
            // 
            this.dodajButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dodajButton.Location = new System.Drawing.Point(192, 268);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(98, 43);
            this.dodajButton.TabIndex = 57;
            this.dodajButton.Text = "Dodaj";
            this.dodajButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dodajButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // ulogeList
            // 
            this.ulogeList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ulogeList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ulogeList.FormattingEnabled = true;
            this.ulogeList.Location = new System.Drawing.Point(95, 212);
            this.ulogeList.Name = "ulogeList";
            this.ulogeList.Size = new System.Drawing.Size(195, 47);
            this.ulogeList.TabIndex = 55;
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(95, 88);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(195, 20);
            this.emailInput.TabIndex = 50;
            this.emailInput.Validating += new System.ComponentModel.CancelEventHandler(this.emailInput_Validating);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(46, 91);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(38, 13);
            this.emailLabel.TabIndex = 52;
            this.emailLabel.Text = "E-mail:";
            // 
            // prezimeInput
            // 
            this.prezimeInput.Location = new System.Drawing.Point(95, 62);
            this.prezimeInput.Name = "prezimeInput";
            this.prezimeInput.Size = new System.Drawing.Size(195, 20);
            this.prezimeInput.TabIndex = 48;
            this.prezimeInput.Validating += new System.ComponentModel.CancelEventHandler(this.prezimeInput_Validating);
            // 
            // prezimeLabel
            // 
            this.prezimeLabel.AutoSize = true;
            this.prezimeLabel.Location = new System.Drawing.Point(38, 65);
            this.prezimeLabel.Name = "prezimeLabel";
            this.prezimeLabel.Size = new System.Drawing.Size(47, 13);
            this.prezimeLabel.TabIndex = 49;
            this.prezimeLabel.Text = "Prezime:";
            // 
            // imeInput
            // 
            this.imeInput.Location = new System.Drawing.Point(95, 36);
            this.imeInput.Name = "imeInput";
            this.imeInput.Size = new System.Drawing.Size(195, 20);
            this.imeInput.TabIndex = 47;
            this.imeInput.Validating += new System.ComponentModel.CancelEventHandler(this.imeInput_Validating);
            // 
            // imeLabel
            // 
            this.imeLabel.AutoSize = true;
            this.imeLabel.Location = new System.Drawing.Point(57, 36);
            this.imeLabel.Name = "imeLabel";
            this.imeLabel.Size = new System.Drawing.Size(27, 13);
            this.imeLabel.TabIndex = 46;
            this.imeLabel.Text = "Ime:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // NoviKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 350);
            this.Controls.Add(this.ulogeLabel);
            this.Controls.Add(this.telefonInput);
            this.Controls.Add(this.lozinkaInput);
            this.Controls.Add(this.lozinkaLabel);
            this.Controls.Add(this.korisnickoImeInput);
            this.Controls.Add(this.korisnickoImeLabel);
            this.Controls.Add(this.telefonLabel);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.ulogeList);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.prezimeInput);
            this.Controls.Add(this.prezimeLabel);
            this.Controls.Add(this.imeInput);
            this.Controls.Add(this.imeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(335, 389);
            this.MinimumSize = new System.Drawing.Size(335, 389);
            this.Name = "NoviKorisnik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoviKorisnik";
            this.Load += new System.EventHandler(this.NoviKorisnik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ulogeLabel;
        private System.Windows.Forms.MaskedTextBox telefonInput;
        private System.Windows.Forms.TextBox lozinkaInput;
        private System.Windows.Forms.Label lozinkaLabel;
        private System.Windows.Forms.TextBox korisnickoImeInput;
        private System.Windows.Forms.Label korisnickoImeLabel;
        private System.Windows.Forms.Label telefonLabel;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.CheckedListBox ulogeList;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox prezimeInput;
        private System.Windows.Forms.Label prezimeLabel;
        private System.Windows.Forms.TextBox imeInput;
        private System.Windows.Forms.Label imeLabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}