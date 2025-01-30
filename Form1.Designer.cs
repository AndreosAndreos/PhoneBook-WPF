namespace lista_7
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonUsun = new System.Windows.Forms.Button();
            this.buttonEdytuj = new System.Windows.Forms.Button();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.labelNazwisko = new System.Windows.Forms.Label();
            this.labelImie = new System.Windows.Forms.Label();
            this.textBoxNrTel = new System.Windows.Forms.TextBox();
            this.textBoxMiejscowosc = new System.Windows.Forms.TextBox();
            this.labelNrTel = new System.Windows.Forms.Label();
            this.labelMiejscowosc = new System.Windows.Forms.Label();
            this.labelIDusuwanie = new System.Windows.Forms.Label();
            this.textBoxUsuwanie = new System.Windows.Forms.TextBox();
            this.textBoxIDedycja = new System.Windows.Forms.TextBox();
            this.labelIDedycja = new System.Windows.Forms.Label();
            this.buttonZapiszZmiany = new System.Windows.Forms.Button();
            this.textBoxSzukajNrTel = new System.Windows.Forms.TextBox();
            this.textBoxSzukajMiejscowosc = new System.Windows.Forms.TextBox();
            this.labelSzukajNrTel = new System.Windows.Forms.Label();
            this.labelSzukajMiejscowosc = new System.Windows.Forms.Label();
            this.textBoxSzukajNazwisko = new System.Windows.Forms.TextBox();
            this.textBoxSzukajImie = new System.Windows.Forms.TextBox();
            this.labelSzukajNazwisko = new System.Windows.Forms.Label();
            this.labelSzukajImie = new System.Windows.Forms.Label();
            this.buttonWyszukaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSortowanieImie = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSortowanieNazwisko = new System.Windows.Forms.Button();
            this.buttonSortowanieMiejscowosc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSortowanieNrTelefonu = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSortowanieID = new System.Windows.Forms.Button();
            this.buttonWyczysc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(557, 139);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(645, 542);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(296, 85);
            this.buttonDodaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(176, 50);
            this.buttonDodaj.TabIndex = 1;
            this.buttonDodaj.Text = "Dodaj nowy kontakt";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonUsun
            // 
            this.buttonUsun.Location = new System.Drawing.Point(296, 455);
            this.buttonUsun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.Size = new System.Drawing.Size(176, 59);
            this.buttonUsun.TabIndex = 2;
            this.buttonUsun.Text = "Usun kontakt";
            this.buttonUsun.UseVisualStyleBackColor = true;
            this.buttonUsun.Click += new System.EventHandler(this.buttonUsun_Click);
            // 
            // buttonEdytuj
            // 
            this.buttonEdytuj.Location = new System.Drawing.Point(296, 521);
            this.buttonEdytuj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEdytuj.Name = "buttonEdytuj";
            this.buttonEdytuj.Size = new System.Drawing.Size(176, 59);
            this.buttonEdytuj.TabIndex = 3;
            this.buttonEdytuj.Text = "Edytuj kontakt";
            this.buttonEdytuj.UseVisualStyleBackColor = true;
            this.buttonEdytuj.Click += new System.EventHandler(this.buttonEdytuj_Click);
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Location = new System.Drawing.Point(108, 113);
            this.textBoxNazwisko.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(183, 22);
            this.textBoxNazwisko.TabIndex = 11;
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(108, 85);
            this.textBoxImie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(183, 22);
            this.textBoxImie.TabIndex = 10;
            // 
            // labelNazwisko
            // 
            this.labelNazwisko.AutoSize = true;
            this.labelNazwisko.Location = new System.Drawing.Point(31, 116);
            this.labelNazwisko.Name = "labelNazwisko";
            this.labelNazwisko.Size = new System.Drawing.Size(71, 16);
            this.labelNazwisko.TabIndex = 9;
            this.labelNazwisko.Text = "Nazwisko: ";
            // 
            // labelImie
            // 
            this.labelImie.AutoSize = true;
            this.labelImie.Location = new System.Drawing.Point(64, 89);
            this.labelImie.Name = "labelImie";
            this.labelImie.Size = new System.Drawing.Size(38, 16);
            this.labelImie.TabIndex = 8;
            this.labelImie.Text = "Imie: ";
            // 
            // textBoxNrTel
            // 
            this.textBoxNrTel.Location = new System.Drawing.Point(108, 169);
            this.textBoxNrTel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNrTel.Name = "textBoxNrTel";
            this.textBoxNrTel.Size = new System.Drawing.Size(183, 22);
            this.textBoxNrTel.TabIndex = 15;
            // 
            // textBoxMiejscowosc
            // 
            this.textBoxMiejscowosc.Location = new System.Drawing.Point(108, 142);
            this.textBoxMiejscowosc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMiejscowosc.Name = "textBoxMiejscowosc";
            this.textBoxMiejscowosc.Size = new System.Drawing.Size(183, 22);
            this.textBoxMiejscowosc.TabIndex = 14;
            // 
            // labelNrTel
            // 
            this.labelNrTel.AutoSize = true;
            this.labelNrTel.Location = new System.Drawing.Point(25, 172);
            this.labelNrTel.Name = "labelNrTel";
            this.labelNrTel.Size = new System.Drawing.Size(77, 16);
            this.labelNrTel.TabIndex = 13;
            this.labelNrTel.Text = "Nr telefonu: ";
            // 
            // labelMiejscowosc
            // 
            this.labelMiejscowosc.AutoSize = true;
            this.labelMiejscowosc.Location = new System.Drawing.Point(11, 144);
            this.labelMiejscowosc.Name = "labelMiejscowosc";
            this.labelMiejscowosc.Size = new System.Drawing.Size(91, 16);
            this.labelMiejscowosc.TabIndex = 12;
            this.labelMiejscowosc.Text = "Miejscowosc: ";
            // 
            // labelIDusuwanie
            // 
            this.labelIDusuwanie.AutoSize = true;
            this.labelIDusuwanie.Location = new System.Drawing.Point(49, 477);
            this.labelIDusuwanie.Name = "labelIDusuwanie";
            this.labelIDusuwanie.Size = new System.Drawing.Size(194, 16);
            this.labelIDusuwanie.TabIndex = 16;
            this.labelIDusuwanie.Text = "Podaj ID kontaktu do usuniecia:";
            // 
            // textBoxUsuwanie
            // 
            this.textBoxUsuwanie.Location = new System.Drawing.Point(249, 474);
            this.textBoxUsuwanie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUsuwanie.Name = "textBoxUsuwanie";
            this.textBoxUsuwanie.Size = new System.Drawing.Size(41, 22);
            this.textBoxUsuwanie.TabIndex = 17;
            // 
            // textBoxIDedycja
            // 
            this.textBoxIDedycja.Location = new System.Drawing.Point(249, 539);
            this.textBoxIDedycja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxIDedycja.Name = "textBoxIDedycja";
            this.textBoxIDedycja.Size = new System.Drawing.Size(41, 22);
            this.textBoxIDedycja.TabIndex = 19;
            // 
            // labelIDedycja
            // 
            this.labelIDedycja.AutoSize = true;
            this.labelIDedycja.Location = new System.Drawing.Point(70, 542);
            this.labelIDedycja.Name = "labelIDedycja";
            this.labelIDedycja.Size = new System.Drawing.Size(173, 16);
            this.labelIDedycja.TabIndex = 18;
            this.labelIDedycja.Text = "Podaj ID kontaktu do edycji:";
            // 
            // buttonZapiszZmiany
            // 
            this.buttonZapiszZmiany.Location = new System.Drawing.Point(296, 142);
            this.buttonZapiszZmiany.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonZapiszZmiany.Name = "buttonZapiszZmiany";
            this.buttonZapiszZmiany.Size = new System.Drawing.Size(176, 50);
            this.buttonZapiszZmiany.TabIndex = 20;
            this.buttonZapiszZmiany.Text = "Zapisz zmiany";
            this.buttonZapiszZmiany.UseVisualStyleBackColor = true;
            this.buttonZapiszZmiany.Click += new System.EventHandler(this.buttonZapiszZmiany_Click);
            // 
            // textBoxSzukajNrTel
            // 
            this.textBoxSzukajNrTel.Location = new System.Drawing.Point(108, 352);
            this.textBoxSzukajNrTel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSzukajNrTel.Name = "textBoxSzukajNrTel";
            this.textBoxSzukajNrTel.Size = new System.Drawing.Size(183, 22);
            this.textBoxSzukajNrTel.TabIndex = 28;
            // 
            // textBoxSzukajMiejscowosc
            // 
            this.textBoxSzukajMiejscowosc.Location = new System.Drawing.Point(108, 324);
            this.textBoxSzukajMiejscowosc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSzukajMiejscowosc.Name = "textBoxSzukajMiejscowosc";
            this.textBoxSzukajMiejscowosc.Size = new System.Drawing.Size(183, 22);
            this.textBoxSzukajMiejscowosc.TabIndex = 27;
            // 
            // labelSzukajNrTel
            // 
            this.labelSzukajNrTel.AutoSize = true;
            this.labelSzukajNrTel.Location = new System.Drawing.Point(25, 354);
            this.labelSzukajNrTel.Name = "labelSzukajNrTel";
            this.labelSzukajNrTel.Size = new System.Drawing.Size(77, 16);
            this.labelSzukajNrTel.TabIndex = 26;
            this.labelSzukajNrTel.Text = "Nr telefonu: ";
            // 
            // labelSzukajMiejscowosc
            // 
            this.labelSzukajMiejscowosc.AutoSize = true;
            this.labelSzukajMiejscowosc.Location = new System.Drawing.Point(11, 327);
            this.labelSzukajMiejscowosc.Name = "labelSzukajMiejscowosc";
            this.labelSzukajMiejscowosc.Size = new System.Drawing.Size(91, 16);
            this.labelSzukajMiejscowosc.TabIndex = 25;
            this.labelSzukajMiejscowosc.Text = "Miejscowosc: ";
            // 
            // textBoxSzukajNazwisko
            // 
            this.textBoxSzukajNazwisko.Location = new System.Drawing.Point(108, 295);
            this.textBoxSzukajNazwisko.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSzukajNazwisko.Name = "textBoxSzukajNazwisko";
            this.textBoxSzukajNazwisko.Size = new System.Drawing.Size(183, 22);
            this.textBoxSzukajNazwisko.TabIndex = 24;
            // 
            // textBoxSzukajImie
            // 
            this.textBoxSzukajImie.Location = new System.Drawing.Point(108, 268);
            this.textBoxSzukajImie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSzukajImie.Name = "textBoxSzukajImie";
            this.textBoxSzukajImie.Size = new System.Drawing.Size(183, 22);
            this.textBoxSzukajImie.TabIndex = 23;
            // 
            // labelSzukajNazwisko
            // 
            this.labelSzukajNazwisko.AutoSize = true;
            this.labelSzukajNazwisko.Location = new System.Drawing.Point(31, 299);
            this.labelSzukajNazwisko.Name = "labelSzukajNazwisko";
            this.labelSzukajNazwisko.Size = new System.Drawing.Size(71, 16);
            this.labelSzukajNazwisko.TabIndex = 22;
            this.labelSzukajNazwisko.Text = "Nazwisko: ";
            // 
            // labelSzukajImie
            // 
            this.labelSzukajImie.AutoSize = true;
            this.labelSzukajImie.Location = new System.Drawing.Point(64, 271);
            this.labelSzukajImie.Name = "labelSzukajImie";
            this.labelSzukajImie.Size = new System.Drawing.Size(38, 16);
            this.labelSzukajImie.TabIndex = 21;
            this.labelSzukajImie.Text = "Imie: ";
            // 
            // buttonWyszukaj
            // 
            this.buttonWyszukaj.Location = new System.Drawing.Point(296, 268);
            this.buttonWyszukaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonWyszukaj.Name = "buttonWyszukaj";
            this.buttonWyszukaj.Size = new System.Drawing.Size(176, 52);
            this.buttonWyszukaj.TabIndex = 29;
            this.buttonWyszukaj.Text = "Wyszukaj";
            this.buttonWyszukaj.UseVisualStyleBackColor = true;
            this.buttonWyszukaj.Click += new System.EventHandler(this.buttonWyszukaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Dodawanie / Edycja kontaktu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightCoral;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(191, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "Wyszukiwanie";
            // 
            // buttonSortowanieImie
            // 
            this.buttonSortowanieImie.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonSortowanieImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSortowanieImie.Location = new System.Drawing.Point(685, 57);
            this.buttonSortowanieImie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSortowanieImie.Name = "buttonSortowanieImie";
            this.buttonSortowanieImie.Size = new System.Drawing.Size(125, 71);
            this.buttonSortowanieImie.TabIndex = 32;
            this.buttonSortowanieImie.Text = "Imie";
            this.buttonSortowanieImie.UseVisualStyleBackColor = false;
            this.buttonSortowanieImie.Click += new System.EventHandler(this.buttonSortowanieImie_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightCoral;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(745, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "Wybierz sposob sortowania:";
            // 
            // buttonSortowanieNazwisko
            // 
            this.buttonSortowanieNazwisko.BackColor = System.Drawing.Color.Lime;
            this.buttonSortowanieNazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSortowanieNazwisko.Location = new System.Drawing.Point(817, 57);
            this.buttonSortowanieNazwisko.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSortowanieNazwisko.Name = "buttonSortowanieNazwisko";
            this.buttonSortowanieNazwisko.Size = new System.Drawing.Size(125, 71);
            this.buttonSortowanieNazwisko.TabIndex = 34;
            this.buttonSortowanieNazwisko.Text = "Nazwisko";
            this.buttonSortowanieNazwisko.UseVisualStyleBackColor = false;
            this.buttonSortowanieNazwisko.Click += new System.EventHandler(this.buttonSortowanieNazwisko_Click);
            // 
            // buttonSortowanieMiejscowosc
            // 
            this.buttonSortowanieMiejscowosc.BackColor = System.Drawing.Color.Yellow;
            this.buttonSortowanieMiejscowosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSortowanieMiejscowosc.Location = new System.Drawing.Point(949, 57);
            this.buttonSortowanieMiejscowosc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSortowanieMiejscowosc.Name = "buttonSortowanieMiejscowosc";
            this.buttonSortowanieMiejscowosc.Size = new System.Drawing.Size(147, 71);
            this.buttonSortowanieMiejscowosc.TabIndex = 35;
            this.buttonSortowanieMiejscowosc.Text = "Miejscowość";
            this.buttonSortowanieMiejscowosc.UseVisualStyleBackColor = false;
            this.buttonSortowanieMiejscowosc.Click += new System.EventHandler(this.buttonSortowanieMiejscowosc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightCoral;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(204, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 36;
            this.label4.Text = "Modyfikacja";
            // 
            // buttonSortowanieNrTelefonu
            // 
            this.buttonSortowanieNrTelefonu.BackColor = System.Drawing.Color.Red;
            this.buttonSortowanieNrTelefonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSortowanieNrTelefonu.Location = new System.Drawing.Point(1103, 57);
            this.buttonSortowanieNrTelefonu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSortowanieNrTelefonu.Name = "buttonSortowanieNrTelefonu";
            this.buttonSortowanieNrTelefonu.Size = new System.Drawing.Size(135, 71);
            this.buttonSortowanieNrTelefonu.TabIndex = 37;
            this.buttonSortowanieNrTelefonu.Text = "Nr telefonu";
            this.buttonSortowanieNrTelefonu.UseVisualStyleBackColor = false;
            this.buttonSortowanieNrTelefonu.Click += new System.EventHandler(this.buttonSortowanieNrTelefonu_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(177, 642);
            this.buttonExport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(176, 68);
            this.buttonExport.TabIndex = 38;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightCoral;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(232, 601);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 39;
            this.label5.Text = "Export";
            // 
            // buttonSortowanieID
            // 
            this.buttonSortowanieID.BackColor = System.Drawing.Color.Firebrick;
            this.buttonSortowanieID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSortowanieID.Location = new System.Drawing.Point(553, 57);
            this.buttonSortowanieID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSortowanieID.Name = "buttonSortowanieID";
            this.buttonSortowanieID.Size = new System.Drawing.Size(125, 71);
            this.buttonSortowanieID.TabIndex = 42;
            this.buttonSortowanieID.Text = "ID";
            this.buttonSortowanieID.UseVisualStyleBackColor = false;
            this.buttonSortowanieID.Click += new System.EventHandler(this.buttonSortowanieID_Click);
            // 
            // buttonWyczysc
            // 
            this.buttonWyczysc.Location = new System.Drawing.Point(297, 325);
            this.buttonWyczysc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonWyczysc.Name = "buttonWyczysc";
            this.buttonWyczysc.Size = new System.Drawing.Size(176, 52);
            this.buttonWyczysc.TabIndex = 43;
            this.buttonWyczysc.Text = "Wyczysc";
            this.buttonWyczysc.UseVisualStyleBackColor = true;
            this.buttonWyczysc.Click += new System.EventHandler(this.buttonWyczysc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.buttonWyczysc);
            this.Controls.Add(this.buttonSortowanieID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.buttonSortowanieNrTelefonu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonSortowanieMiejscowosc);
            this.Controls.Add(this.buttonSortowanieNazwisko);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonSortowanieImie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonWyszukaj);
            this.Controls.Add(this.textBoxSzukajNrTel);
            this.Controls.Add(this.textBoxSzukajMiejscowosc);
            this.Controls.Add(this.labelSzukajNrTel);
            this.Controls.Add(this.labelSzukajMiejscowosc);
            this.Controls.Add(this.textBoxSzukajNazwisko);
            this.Controls.Add(this.textBoxSzukajImie);
            this.Controls.Add(this.labelSzukajNazwisko);
            this.Controls.Add(this.labelSzukajImie);
            this.Controls.Add(this.buttonZapiszZmiany);
            this.Controls.Add(this.textBoxIDedycja);
            this.Controls.Add(this.labelIDedycja);
            this.Controls.Add(this.textBoxUsuwanie);
            this.Controls.Add(this.labelIDusuwanie);
            this.Controls.Add(this.textBoxNrTel);
            this.Controls.Add(this.textBoxMiejscowosc);
            this.Controls.Add(this.labelNrTel);
            this.Controls.Add(this.labelMiejscowosc);
            this.Controls.Add(this.textBoxNazwisko);
            this.Controls.Add(this.textBoxImie);
            this.Controls.Add(this.labelNazwisko);
            this.Controls.Add(this.labelImie);
            this.Controls.Add(this.buttonEdytuj);
            this.Controls.Add(this.buttonUsun);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonUsun;
        private System.Windows.Forms.Button buttonEdytuj;
        private System.Windows.Forms.TextBox textBoxNazwisko;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.Label labelNazwisko;
        private System.Windows.Forms.Label labelImie;
        private System.Windows.Forms.TextBox textBoxNrTel;
        private System.Windows.Forms.TextBox textBoxMiejscowosc;
        private System.Windows.Forms.Label labelNrTel;
        private System.Windows.Forms.Label labelMiejscowosc;
        private System.Windows.Forms.Label labelIDusuwanie;
        private System.Windows.Forms.TextBox textBoxUsuwanie;
        private System.Windows.Forms.TextBox textBoxIDedycja;
        private System.Windows.Forms.Label labelIDedycja;
        private System.Windows.Forms.Button buttonZapiszZmiany;
        private System.Windows.Forms.TextBox textBoxSzukajNrTel;
        private System.Windows.Forms.TextBox textBoxSzukajMiejscowosc;
        private System.Windows.Forms.Label labelSzukajNrTel;
        private System.Windows.Forms.Label labelSzukajMiejscowosc;
        private System.Windows.Forms.TextBox textBoxSzukajNazwisko;
        private System.Windows.Forms.TextBox textBoxSzukajImie;
        private System.Windows.Forms.Label labelSzukajNazwisko;
        private System.Windows.Forms.Label labelSzukajImie;
        private System.Windows.Forms.Button buttonWyszukaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSortowanieImie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSortowanieNazwisko;
        private System.Windows.Forms.Button buttonSortowanieMiejscowosc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSortowanieNrTelefonu;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSortowanieID;
        private System.Windows.Forms.Button buttonWyczysc;
    }
}

