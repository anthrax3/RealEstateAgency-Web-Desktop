namespace Administracija
{
    partial class LoginForma
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
            this.odustaniButton = new System.Windows.Forms.Button();
            this.potvrdiButton = new System.Windows.Forms.Button();
            this.lozinkaInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.korisnickoImeInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // odustaniButton
            // 
            this.odustaniButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.odustaniButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.odustaniButton.Location = new System.Drawing.Point(124, 93);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(93, 40);
            this.odustaniButton.TabIndex = 23;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.odustaniButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // potvrdiButton
            // 
            this.potvrdiButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.potvrdiButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.potvrdiButton.Location = new System.Drawing.Point(223, 93);
            this.potvrdiButton.Name = "potvrdiButton";
            this.potvrdiButton.Size = new System.Drawing.Size(93, 40);
            this.potvrdiButton.TabIndex = 22;
            this.potvrdiButton.Text = "Potvrdi";
            this.potvrdiButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.potvrdiButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.potvrdiButton.UseVisualStyleBackColor = true;
            this.potvrdiButton.Click += new System.EventHandler(this.potvrdiButton_Click);
            // 
            // lozinkaInput
            // 
            this.lozinkaInput.Location = new System.Drawing.Point(109, 56);
            this.lozinkaInput.Name = "lozinkaInput";
            this.lozinkaInput.PasswordChar = '*';
            this.lozinkaInput.Size = new System.Drawing.Size(207, 20);
            this.lozinkaInput.TabIndex = 21;
            this.lozinkaInput.Text = "ermin2014";
            this.lozinkaInput.UseWaitCursor = true;
            this.lozinkaInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lozinkaInput_KeyPress);
            this.lozinkaInput.Validating += new System.ComponentModel.CancelEventHandler(this.lozinkaInput_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Lozinka:";
            // 
            // korisnickoImeInput
            // 
            this.korisnickoImeInput.Location = new System.Drawing.Point(109, 30);
            this.korisnickoImeInput.Name = "korisnickoImeInput";
            this.korisnickoImeInput.Size = new System.Drawing.Size(207, 20);
            this.korisnickoImeInput.TabIndex = 19;
            this.korisnickoImeInput.Text = "ermin";
            this.korisnickoImeInput.UseWaitCursor = true;
            this.korisnickoImeInput.TextChanged += new System.EventHandler(this.korisnickoImeInput_TextChanged);
            this.korisnickoImeInput.Validating += new System.ComponentModel.CancelEventHandler(this.korisnickoImeInput_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Korisničko ime:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LoginForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 158);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.potvrdiButton);
            this.Controls.Add(this.lozinkaInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.korisnickoImeInput);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(391, 197);
            this.MinimumSize = new System.Drawing.Size(391, 197);
            this.Name = "LoginForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava";
            this.Load += new System.EventHandler(this.LoginForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.Button potvrdiButton;
        private System.Windows.Forms.TextBox lozinkaInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox korisnickoImeInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

