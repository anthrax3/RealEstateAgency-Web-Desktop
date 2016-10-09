namespace Administracija.TempNekretnine
{
    partial class NovaNekretnina
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
            this.cijenaInput = new System.Windows.Forms.MaskedTextBox();
            this.dodajSlikuButton = new System.Windows.Forms.Button();
            this.slikaInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboVrste = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBrojKvadrata = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNaslov = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxKategorije = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxSprat = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxSobe = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxStanje = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxGrijanje = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxGodina = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxAktivna = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBoxTelefon = new System.Windows.Forms.CheckBox();
            this.checkBoxGaraža = new System.Windows.Forms.CheckBox();
            this.checkBoxNedavnoAdaptiran = new System.Windows.Forms.CheckBox();
            this.checkBoxNovogradnja = new System.Windows.Forms.CheckBox();
            this.checkBoxInternet = new System.Windows.Forms.CheckBox();
            this.checkBoxNamješten = new System.Windows.Forms.CheckBox();
            this.checkBoxLift = new System.Windows.Forms.CheckBox();
            this.checkBoxParking = new System.Windows.Forms.CheckBox();
            this.checkBoxUknjiženo = new System.Windows.Forms.CheckBox();
            this.checkBoxKanalizacija = new System.Windows.Forms.CheckBox();
            this.checkBoxStruja = new System.Windows.Forms.CheckBox();
            this.checkBoxVoda = new System.Windows.Forms.CheckBox();
            this.dodajButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cijenaInput
            // 
            this.cijenaInput.Location = new System.Drawing.Point(110, 111);
            this.cijenaInput.Mask = "00000000.00";
            this.cijenaInput.Name = "cijenaInput";
            this.cijenaInput.Size = new System.Drawing.Size(187, 20);
            this.cijenaInput.TabIndex = 52;
            this.cijenaInput.Validating += new System.ComponentModel.CancelEventHandler(this.cijenaInput_Validating);
            // 
            // dodajSlikuButton
            // 
            this.dodajSlikuButton.Location = new System.Drawing.Point(110, 193);
            this.dodajSlikuButton.Name = "dodajSlikuButton";
            this.dodajSlikuButton.Size = new System.Drawing.Size(65, 23);
            this.dodajSlikuButton.TabIndex = 54;
            this.dodajSlikuButton.Text = "Odaberi";
            this.dodajSlikuButton.UseVisualStyleBackColor = true;
            this.dodajSlikuButton.Click += new System.EventHandler(this.dodajSlikuButton_Click);
            // 
            // slikaInput
            // 
            this.slikaInput.Location = new System.Drawing.Point(110, 167);
            this.slikaInput.Name = "slikaInput";
            this.slikaInput.Size = new System.Drawing.Size(187, 20);
            this.slikaInput.TabIndex = 56;
            this.slikaInput.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "Slika:";
            // 
            // comboVrste
            // 
            this.comboVrste.FormattingEnabled = true;
            this.comboVrste.Location = new System.Drawing.Point(88, 29);
            this.comboVrste.Name = "comboVrste";
            this.comboVrste.Size = new System.Drawing.Size(209, 21);
            this.comboVrste.TabIndex = 49;
            this.comboVrste.Validating += new System.ComponentModel.CancelEventHandler(this.vrstaList_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Vrsta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Cijena:";
            // 
            // tbBrojKvadrata
            // 
            this.tbBrojKvadrata.Location = new System.Drawing.Point(110, 59);
            this.tbBrojKvadrata.Name = "tbBrojKvadrata";
            this.tbBrojKvadrata.Size = new System.Drawing.Size(187, 20);
            this.tbBrojKvadrata.TabIndex = 51;
            this.tbBrojKvadrata.Validating += new System.ComponentModel.CancelEventHandler(this.nazivInput_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Broj kvadrata:";
            // 
            // tbNaslov
            // 
            this.tbNaslov.Location = new System.Drawing.Point(110, 33);
            this.tbNaslov.Name = "tbNaslov";
            this.tbNaslov.Size = new System.Drawing.Size(187, 20);
            this.tbNaslov.TabIndex = 50;
            this.tbNaslov.Validating += new System.ComponentModel.CancelEventHandler(this.sifraInput_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Naslov:";
            // 
            // comboBoxKategorije
            // 
            this.comboBoxKategorije.FormattingEnabled = true;
            this.comboBoxKategorije.Location = new System.Drawing.Point(88, 56);
            this.comboBoxKategorije.Name = "comboBoxKategorije";
            this.comboBoxKategorije.Size = new System.Drawing.Size(209, 21);
            this.comboBoxKategorije.TabIndex = 63;
            this.comboBoxKategorije.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxKategorije_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 64;
            this.label7.Text = "Kategorija:";
            // 
            // comboBoxSprat
            // 
            this.comboBoxSprat.FormattingEnabled = true;
            this.comboBoxSprat.Location = new System.Drawing.Point(89, 55);
            this.comboBoxSprat.Name = "comboBoxSprat";
            this.comboBoxSprat.Size = new System.Drawing.Size(209, 21);
            this.comboBoxSprat.TabIndex = 67;
            this.comboBoxSprat.Validating += new System.ComponentModel.CancelEventHandler(this.sprat_validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 68;
            this.label8.Text = "Sprat:";
            // 
            // comboBoxSobe
            // 
            this.comboBoxSobe.FormattingEnabled = true;
            this.comboBoxSobe.Location = new System.Drawing.Point(89, 28);
            this.comboBoxSobe.Name = "comboBoxSobe";
            this.comboBoxSobe.Size = new System.Drawing.Size(209, 21);
            this.comboBoxSobe.TabIndex = 65;
            this.comboBoxSobe.Validating += new System.ComponentModel.CancelEventHandler(this.sobe_val);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 66;
            this.label9.Text = "Broj Prostorija:";
            // 
            // comboBoxStanje
            // 
            this.comboBoxStanje.FormattingEnabled = true;
            this.comboBoxStanje.Location = new System.Drawing.Point(88, 86);
            this.comboBoxStanje.Name = "comboBoxStanje";
            this.comboBoxStanje.Size = new System.Drawing.Size(209, 21);
            this.comboBoxStanje.TabIndex = 71;
            this.comboBoxStanje.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxStanje_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 72;
            this.label10.Text = "Stanje:";
            // 
            // comboBoxGrijanje
            // 
            this.comboBoxGrijanje.FormattingEnabled = true;
            this.comboBoxGrijanje.Location = new System.Drawing.Point(89, 82);
            this.comboBoxGrijanje.Name = "comboBoxGrijanje";
            this.comboBoxGrijanje.Size = new System.Drawing.Size(209, 21);
            this.comboBoxGrijanje.TabIndex = 69;
            this.comboBoxGrijanje.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxGrijanje_Validating_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 70;
            this.label11.Text = "Grijanje:";
            // 
            // textBoxGodina
            // 
            this.textBoxGodina.Location = new System.Drawing.Point(110, 137);
            this.textBoxGodina.Name = "textBoxGodina";
            this.textBoxGodina.Size = new System.Drawing.Size(187, 20);
            this.textBoxGodina.TabIndex = 74;
            this.textBoxGodina.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxGodina_Validating);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 138);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 13);
            this.label12.TabIndex = 76;
            this.label12.Text = "Godina izgradnje:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(110, 85);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(187, 20);
            this.tbAdresa.TabIndex = 73;
            this.tbAdresa.Validating += new System.ComponentModel.CancelEventHandler(this.tbAdresa_Validating);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(51, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 75;
            this.label13.Text = "Adresa:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxSobe);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.comboBoxSprat);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.comboBoxGrijanje);
            this.groupBox1.Location = new System.Drawing.Point(376, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 138);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.comboVrste);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.comboBoxKategorije);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.comboBoxStanje);
            this.groupBox2.Location = new System.Drawing.Point(22, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 138);
            this.groupBox2.TabIndex = 78;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 74;
            this.label5.Text = "Kanton";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(88, 117);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(209, 21);
            this.comboBox1.TabIndex = 73;
            this.comboBox1.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox1_Validating);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxAktivna);
            this.groupBox3.Controls.Add(this.tbNaslov);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBoxGodina);
            this.groupBox3.Controls.Add(this.tbBrojKvadrata);
            this.groupBox3.Controls.Add(this.dodajSlikuButton);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.slikaInput);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tbAdresa);
            this.groupBox3.Controls.Add(this.cijenaInput);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(19, 147);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(334, 243);
            this.groupBox3.TabIndex = 79;
            this.groupBox3.TabStop = false;
            // 
            // checkBoxAktivna
            // 
            this.checkBoxAktivna.AutoSize = true;
            this.checkBoxAktivna.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxAktivna.Location = new System.Drawing.Point(38, 222);
            this.checkBoxAktivna.Name = "checkBoxAktivna";
            this.checkBoxAktivna.Size = new System.Drawing.Size(62, 17);
            this.checkBoxAktivna.TabIndex = 77;
            this.checkBoxAktivna.Text = "Aktivna";
            this.checkBoxAktivna.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBoxTelefon);
            this.groupBox4.Controls.Add(this.checkBoxGaraža);
            this.groupBox4.Controls.Add(this.checkBoxNedavnoAdaptiran);
            this.groupBox4.Controls.Add(this.checkBoxNovogradnja);
            this.groupBox4.Controls.Add(this.checkBoxInternet);
            this.groupBox4.Controls.Add(this.checkBoxNamješten);
            this.groupBox4.Controls.Add(this.checkBoxLift);
            this.groupBox4.Controls.Add(this.checkBoxParking);
            this.groupBox4.Controls.Add(this.checkBoxUknjiženo);
            this.groupBox4.Controls.Add(this.checkBoxKanalizacija);
            this.groupBox4.Controls.Add(this.checkBoxStruja);
            this.groupBox4.Controls.Add(this.checkBoxVoda);
            this.groupBox4.Location = new System.Drawing.Point(373, 147);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(334, 243);
            this.groupBox4.TabIndex = 80;
            this.groupBox4.TabStop = false;
            // 
            // checkBoxTelefon
            // 
            this.checkBoxTelefon.AutoSize = true;
            this.checkBoxTelefon.Location = new System.Drawing.Point(198, 196);
            this.checkBoxTelefon.Name = "checkBoxTelefon";
            this.checkBoxTelefon.Size = new System.Drawing.Size(62, 17);
            this.checkBoxTelefon.TabIndex = 11;
            this.checkBoxTelefon.Text = "Telefon";
            this.checkBoxTelefon.UseVisualStyleBackColor = true;
            // 
            // checkBoxGaraža
            // 
            this.checkBoxGaraža.AutoSize = true;
            this.checkBoxGaraža.Location = new System.Drawing.Point(198, 164);
            this.checkBoxGaraža.Name = "checkBoxGaraža";
            this.checkBoxGaraža.Size = new System.Drawing.Size(60, 17);
            this.checkBoxGaraža.TabIndex = 10;
            this.checkBoxGaraža.Text = "Garaža";
            this.checkBoxGaraža.UseVisualStyleBackColor = true;
            // 
            // checkBoxNedavnoAdaptiran
            // 
            this.checkBoxNedavnoAdaptiran.AutoSize = true;
            this.checkBoxNedavnoAdaptiran.Location = new System.Drawing.Point(198, 131);
            this.checkBoxNedavnoAdaptiran.Name = "checkBoxNedavnoAdaptiran";
            this.checkBoxNedavnoAdaptiran.Size = new System.Drawing.Size(117, 17);
            this.checkBoxNedavnoAdaptiran.TabIndex = 9;
            this.checkBoxNedavnoAdaptiran.Text = "Nedavno adaptiran";
            this.checkBoxNedavnoAdaptiran.UseVisualStyleBackColor = true;
            // 
            // checkBoxNovogradnja
            // 
            this.checkBoxNovogradnja.AutoSize = true;
            this.checkBoxNovogradnja.Location = new System.Drawing.Point(198, 98);
            this.checkBoxNovogradnja.Name = "checkBoxNovogradnja";
            this.checkBoxNovogradnja.Size = new System.Drawing.Size(87, 17);
            this.checkBoxNovogradnja.TabIndex = 8;
            this.checkBoxNovogradnja.Text = "Novogradnja";
            this.checkBoxNovogradnja.UseVisualStyleBackColor = true;
            // 
            // checkBoxInternet
            // 
            this.checkBoxInternet.AutoSize = true;
            this.checkBoxInternet.Location = new System.Drawing.Point(198, 59);
            this.checkBoxInternet.Name = "checkBoxInternet";
            this.checkBoxInternet.Size = new System.Drawing.Size(62, 17);
            this.checkBoxInternet.TabIndex = 7;
            this.checkBoxInternet.Text = "Internet";
            this.checkBoxInternet.UseVisualStyleBackColor = true;
            // 
            // checkBoxNamješten
            // 
            this.checkBoxNamješten.AutoSize = true;
            this.checkBoxNamješten.Location = new System.Drawing.Point(198, 27);
            this.checkBoxNamješten.Name = "checkBoxNamješten";
            this.checkBoxNamješten.Size = new System.Drawing.Size(76, 17);
            this.checkBoxNamješten.TabIndex = 6;
            this.checkBoxNamješten.Text = "Namješten";
            this.checkBoxNamješten.UseVisualStyleBackColor = true;
            // 
            // checkBoxLift
            // 
            this.checkBoxLift.AutoSize = true;
            this.checkBoxLift.Location = new System.Drawing.Point(75, 196);
            this.checkBoxLift.Name = "checkBoxLift";
            this.checkBoxLift.Size = new System.Drawing.Size(40, 17);
            this.checkBoxLift.TabIndex = 5;
            this.checkBoxLift.Text = "Lift";
            this.checkBoxLift.UseVisualStyleBackColor = true;
            // 
            // checkBoxParking
            // 
            this.checkBoxParking.AutoSize = true;
            this.checkBoxParking.Location = new System.Drawing.Point(75, 164);
            this.checkBoxParking.Name = "checkBoxParking";
            this.checkBoxParking.Size = new System.Drawing.Size(62, 17);
            this.checkBoxParking.TabIndex = 4;
            this.checkBoxParking.Text = "Parking";
            this.checkBoxParking.UseVisualStyleBackColor = true;
            // 
            // checkBoxUknjiženo
            // 
            this.checkBoxUknjiženo.AutoSize = true;
            this.checkBoxUknjiženo.Location = new System.Drawing.Point(75, 131);
            this.checkBoxUknjiženo.Name = "checkBoxUknjiženo";
            this.checkBoxUknjiženo.Size = new System.Drawing.Size(73, 17);
            this.checkBoxUknjiženo.TabIndex = 3;
            this.checkBoxUknjiženo.Text = "Uknjiženo";
            this.checkBoxUknjiženo.UseVisualStyleBackColor = true;
            // 
            // checkBoxKanalizacija
            // 
            this.checkBoxKanalizacija.AutoSize = true;
            this.checkBoxKanalizacija.Location = new System.Drawing.Point(75, 98);
            this.checkBoxKanalizacija.Name = "checkBoxKanalizacija";
            this.checkBoxKanalizacija.Size = new System.Drawing.Size(82, 17);
            this.checkBoxKanalizacija.TabIndex = 2;
            this.checkBoxKanalizacija.Text = "Kanalizacija";
            this.checkBoxKanalizacija.UseVisualStyleBackColor = true;
            // 
            // checkBoxStruja
            // 
            this.checkBoxStruja.AutoSize = true;
            this.checkBoxStruja.Location = new System.Drawing.Point(75, 59);
            this.checkBoxStruja.Name = "checkBoxStruja";
            this.checkBoxStruja.Size = new System.Drawing.Size(53, 17);
            this.checkBoxStruja.TabIndex = 1;
            this.checkBoxStruja.Text = "Struja";
            this.checkBoxStruja.UseVisualStyleBackColor = true;
            // 
            // checkBoxVoda
            // 
            this.checkBoxVoda.AutoSize = true;
            this.checkBoxVoda.Location = new System.Drawing.Point(75, 27);
            this.checkBoxVoda.Name = "checkBoxVoda";
            this.checkBoxVoda.Size = new System.Drawing.Size(51, 17);
            this.checkBoxVoda.TabIndex = 0;
            this.checkBoxVoda.Text = "Voda";
            this.checkBoxVoda.UseVisualStyleBackColor = true;
            // 
            // dodajButton
            // 
            this.dodajButton.Location = new System.Drawing.Point(609, 408);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(98, 43);
            this.dodajButton.TabIndex = 81;
            this.dodajButton.Text = "Sačuvaj";
            this.dodajButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(494, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 43);
            this.button1.TabIndex = 82;
            this.button1.Text = "Odustani";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(18, 408);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 83;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(341, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 78;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NovaNekretnina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 468);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(738, 507);
            this.MinimumSize = new System.Drawing.Size(738, 507);
            this.Name = "NovaNekretnina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova nekretnina";
            this.Load += new System.EventHandler(this.NovaNekretnina_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox cijenaInput;
        private System.Windows.Forms.Button dodajSlikuButton;
        private System.Windows.Forms.TextBox slikaInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboVrste;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbBrojKvadrata;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNaslov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxKategorije;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxSprat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxSobe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxStanje;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxGrijanje;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxGodina;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxAktivna;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBoxTelefon;
        private System.Windows.Forms.CheckBox checkBoxGaraža;
        private System.Windows.Forms.CheckBox checkBoxNedavnoAdaptiran;
        private System.Windows.Forms.CheckBox checkBoxNovogradnja;
        private System.Windows.Forms.CheckBox checkBoxInternet;
        private System.Windows.Forms.CheckBox checkBoxNamješten;
        private System.Windows.Forms.CheckBox checkBoxLift;
        private System.Windows.Forms.CheckBox checkBoxParking;
        private System.Windows.Forms.CheckBox checkBoxUknjiženo;
        private System.Windows.Forms.CheckBox checkBoxKanalizacija;
        private System.Windows.Forms.CheckBox checkBoxStruja;
        private System.Windows.Forms.CheckBox checkBoxVoda;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
    }
}