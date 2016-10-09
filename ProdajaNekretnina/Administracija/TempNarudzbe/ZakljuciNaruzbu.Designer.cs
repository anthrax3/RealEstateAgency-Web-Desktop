namespace Administracija.TempNarudzbe
{
    partial class ZakljuciNaruzbu
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbNaslov = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCijena = new System.Windows.Forms.MaskedTextBox();
            this.tbUplaceno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbVratiti = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dodajButton = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbNaslov);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tbCijena);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(334, 93);
            this.groupBox3.TabIndex = 80;
            this.groupBox3.TabStop = false;
            // 
            // tbNaslov
            // 
            this.tbNaslov.Location = new System.Drawing.Point(111, 19);
            this.tbNaslov.Name = "tbNaslov";
            this.tbNaslov.Size = new System.Drawing.Size(187, 20);
            this.tbNaslov.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Naslov:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Cijena:";
            // 
            // tbCijena
            // 
            this.tbCijena.Location = new System.Drawing.Point(111, 45);
            this.tbCijena.Name = "tbCijena";
            this.tbCijena.Size = new System.Drawing.Size(104, 20);
            this.tbCijena.TabIndex = 52;
            // 
            // tbUplaceno
            // 
            this.tbUplaceno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbUplaceno.Location = new System.Drawing.Point(123, 158);
            this.tbUplaceno.Name = "tbUplaceno";
            this.tbUplaceno.Size = new System.Drawing.Size(187, 29);
            this.tbUplaceno.TabIndex = 81;
            this.tbUplaceno.TextChanged += new System.EventHandler(this.tbUplaceno_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(21, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 24);
            this.label4.TabIndex = 82;
            this.label4.Text = "Uplaćeno:";
            // 
            // tbVratiti
            // 
            this.tbVratiti.Location = new System.Drawing.Point(123, 203);
            this.tbVratiti.Name = "tbVratiti";
            this.tbVratiti.ReadOnly = true;
            this.tbVratiti.Size = new System.Drawing.Size(187, 20);
            this.tbVratiti.TabIndex = 83;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 84;
            this.label5.Text = "Vratiti:";
            // 
            // dodajButton
            // 
            this.dodajButton.Location = new System.Drawing.Point(248, 283);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(98, 43);
            this.dodajButton.TabIndex = 85;
            this.dodajButton.Text = "Sačuvaj";
            this.dodajButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // ZakljuciNaruzbu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 364);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.tbVratiti);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbUplaceno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(394, 403);
            this.MinimumSize = new System.Drawing.Size(394, 403);
            this.Name = "ZakljuciNaruzbu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zakljuci naruzbu";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbNaslov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox tbCijena;
        private System.Windows.Forms.TextBox tbUplaceno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbVratiti;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button dodajButton;
    }
}