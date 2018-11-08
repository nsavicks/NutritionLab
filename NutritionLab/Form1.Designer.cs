namespace NutritionLab
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listViewNamirnice = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbNazivNamirnice = new System.Windows.Forms.TextBox();
            this.tbTraziNamirnice = new System.Windows.Forms.TextBox();
            this.tbMasNamirnice = new System.Windows.Forms.TextBox();
            this.tbProNamirnice = new System.Windows.Forms.TextBox();
            this.tbUHNamirnice = new System.Windows.Forms.TextBox();
            this.btDodajNamirnicu = new System.Windows.Forms.Button();
            this.btObrisiNamirnicu = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaDijetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sacuvajDijetuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ucitajDijetuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.g = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewNamirnice
            // 
            this.listViewNamirnice.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader12,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader13});
            this.listViewNamirnice.FullRowSelect = true;
            this.listViewNamirnice.Location = new System.Drawing.Point(860, 112);
            this.listViewNamirnice.Name = "listViewNamirnice";
            this.listViewNamirnice.Size = new System.Drawing.Size(427, 316);
            this.listViewNamirnice.TabIndex = 0;
            this.listViewNamirnice.UseCompatibleStateImageBehavior = false;
            this.listViewNamirnice.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Id";
            this.columnHeader6.Width = 43;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Naziv";
            this.columnHeader7.Width = 78;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Grupa";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Ugljeni hidrati";
            this.columnHeader8.Width = 80;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Masti";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Proteini";
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "kCal";
            this.columnHeader13.Width = 40;
            // 
            // tbNazivNamirnice
            // 
            this.tbNazivNamirnice.Location = new System.Drawing.Point(860, 435);
            this.tbNazivNamirnice.Name = "tbNazivNamirnice";
            this.tbNazivNamirnice.Size = new System.Drawing.Size(176, 20);
            this.tbNazivNamirnice.TabIndex = 5;
            // 
            // tbTraziNamirnice
            // 
            this.tbTraziNamirnice.Location = new System.Drawing.Point(860, 86);
            this.tbTraziNamirnice.Name = "tbTraziNamirnice";
            this.tbTraziNamirnice.Size = new System.Drawing.Size(282, 20);
            this.tbTraziNamirnice.TabIndex = 6;
            this.tbTraziNamirnice.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // tbMasNamirnice
            // 
            this.tbMasNamirnice.Location = new System.Drawing.Point(938, 461);
            this.tbMasNamirnice.Name = "tbMasNamirnice";
            this.tbMasNamirnice.Size = new System.Drawing.Size(70, 20);
            this.tbMasNamirnice.TabIndex = 7;
            // 
            // tbProNamirnice
            // 
            this.tbProNamirnice.Location = new System.Drawing.Point(1014, 461);
            this.tbProNamirnice.Name = "tbProNamirnice";
            this.tbProNamirnice.Size = new System.Drawing.Size(61, 20);
            this.tbProNamirnice.TabIndex = 8;
            // 
            // tbUHNamirnice
            // 
            this.tbUHNamirnice.Location = new System.Drawing.Point(860, 460);
            this.tbUHNamirnice.Name = "tbUHNamirnice";
            this.tbUHNamirnice.Size = new System.Drawing.Size(72, 20);
            this.tbUHNamirnice.TabIndex = 9;
            // 
            // btDodajNamirnicu
            // 
            this.btDodajNamirnicu.BackColor = System.Drawing.SystemColors.Highlight;
            this.btDodajNamirnicu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDodajNamirnicu.ForeColor = System.Drawing.Color.White;
            this.btDodajNamirnicu.Location = new System.Drawing.Point(1148, 434);
            this.btDodajNamirnicu.Name = "btDodajNamirnicu";
            this.btDodajNamirnicu.Size = new System.Drawing.Size(139, 46);
            this.btDodajNamirnicu.TabIndex = 10;
            this.btDodajNamirnicu.Text = "Nova";
            this.btDodajNamirnicu.UseVisualStyleBackColor = false;
            this.btDodajNamirnicu.Click += new System.EventHandler(this.button1_Click);
            // 
            // btObrisiNamirnicu
            // 
            this.btObrisiNamirnicu.Location = new System.Drawing.Point(860, 486);
            this.btObrisiNamirnicu.Name = "btObrisiNamirnicu";
            this.btObrisiNamirnicu.Size = new System.Drawing.Size(427, 37);
            this.btObrisiNamirnicu.TabIndex = 11;
            this.btObrisiNamirnicu.Text = "Obrisi oznacenu";
            this.btObrisiNamirnicu.UseVisualStyleBackColor = true;
            this.btObrisiNamirnicu.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1299, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaDijetaToolStripMenuItem,
            this.sacuvajDijetuToolStripMenuItem,
            this.ucitajDijetuToolStripMenuItem,
            this.izlazToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // novaDijetaToolStripMenuItem
            // 
            this.novaDijetaToolStripMenuItem.Name = "novaDijetaToolStripMenuItem";
            this.novaDijetaToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.novaDijetaToolStripMenuItem.Text = "Nova dijeta";
            // 
            // sacuvajDijetuToolStripMenuItem
            // 
            this.sacuvajDijetuToolStripMenuItem.Name = "sacuvajDijetuToolStripMenuItem";
            this.sacuvajDijetuToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.sacuvajDijetuToolStripMenuItem.Text = "Sacuvaj dijetu";
            // 
            // ucitajDijetuToolStripMenuItem
            // 
            this.ucitajDijetuToolStripMenuItem.Name = "ucitajDijetuToolStripMenuItem";
            this.ucitajDijetuToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.ucitajDijetuToolStripMenuItem.Text = "Ucitaj dijetu";
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramuToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // oProgramuToolStripMenuItem
            // 
            this.oProgramuToolStripMenuItem.Name = "oProgramuToolStripMenuItem";
            this.oProgramuToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.oProgramuToolStripMenuItem.Text = "O programu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(528, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 28);
            this.label2.TabIndex = 15;
            this.label2.Text = "Trenutni obrok";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(987, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 28);
            this.label3.TabIndex = 20;
            this.label3.Text = "Spisak namirnica";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(713, 265);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(91, 20);
            this.numericUpDown1.TabIndex = 21;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // g
            // 
            this.g.AutoSize = true;
            this.g.BackColor = System.Drawing.Color.Transparent;
            this.g.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.g.ForeColor = System.Drawing.Color.Black;
            this.g.Location = new System.Drawing.Point(810, 265);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(15, 18);
            this.g.TabIndex = 22;
            this.g.Text = "g";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(623, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 33);
            this.button1.TabIndex = 23;
            this.button1.Text = "Dodaj namirnice";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(398, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 33);
            this.button2.TabIndex = 24;
            this.button2.Text = "Ukloni namirnice";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(398, 341);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(219, 36);
            this.button3.TabIndex = 25;
            this.button3.Text = "Sacuvaj obrok";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(398, 383);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "s1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(427, 238);
            this.chart1.TabIndex = 26;
            this.chart1.Text = "chart1";
            title1.BackColor = System.Drawing.Color.Transparent;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "t1";
            title1.Text = "Odnos hranljivih sastojaka u obroku";
            this.chart1.Titles.Add(title1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(623, 341);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(202, 36);
            this.button4.TabIndex = 27;
            this.button4.Text = "Ucitaj obrok";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Dorucak",
            "Uzina I",
            "Rucak",
            "Uzina II",
            "Vecera"});
            this.comboBox1.Location = new System.Drawing.Point(398, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(81, 21);
            this.comboBox1.TabIndex = 29;
            this.comboBox1.Text = "Dorucak";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Highlight;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(398, 259);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(219, 33);
            this.button5.TabIndex = 30;
            this.button5.Text = "Novi obrok";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Sve grupe",
            "Zito i zitarice",
            "Mlecni proizvodi",
            "Meso i jaja",
            "Masti i ulja",
            "Povrce",
            "Voce",
            "Secerni koncentrati"});
            this.comboBox2.Location = new System.Drawing.Point(1148, 85);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(139, 21);
            this.comboBox2.TabIndex = 31;
            this.comboBox2.Text = "Sve grupe";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Zito i zitarice",
            "Mlecni proizvodi",
            "Meso i jaja",
            "Masti i ulja",
            "Povrce",
            "Voce",
            "Secerni koncentrati"});
            this.comboBox3.Location = new System.Drawing.Point(1042, 434);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(100, 21);
            this.comboBox3.TabIndex = 32;
            this.comboBox3.Text = "Zito i zitarice";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1081, 461);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(61, 20);
            this.textBox1.TabIndex = 33;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader11,
            this.columnHeader14,
            this.columnHeader15});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(398, 86);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(427, 163);
            this.listView1.TabIndex = 34;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 35;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Naziv";
            this.columnHeader2.Width = 50;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Grupa";
            this.columnHeader3.Width = 50;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ugljeni hidrati";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Masti";
            this.columnHeader5.Width = 40;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Proteini";
            this.columnHeader11.Width = 50;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "kCal";
            this.columnHeader14.Width = 40;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Kolicina (g)";
            this.columnHeader15.Width = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(759, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "0 kCal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(646, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Kolicina: ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(54, 130);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 100);
            this.tabControl1.TabIndex = 37;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 74);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1299, 639);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.g);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewNamirnice);
            this.Controls.Add(this.btObrisiNamirnicu);
            this.Controls.Add(this.tbNazivNamirnice);
            this.Controls.Add(this.btDodajNamirnicu);
            this.Controls.Add(this.tbMasNamirnice);
            this.Controls.Add(this.tbTraziNamirnice);
            this.Controls.Add(this.tbUHNamirnice);
            this.Controls.Add(this.tbProNamirnice);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "NutritionLaboratory";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listViewNamirnice;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button btDodajNamirnicu;
        private System.Windows.Forms.TextBox tbNazivNamirnice;
        private System.Windows.Forms.TextBox tbTraziNamirnice;
        private System.Windows.Forms.TextBox tbMasNamirnice;
        private System.Windows.Forms.TextBox tbProNamirnice;
        private System.Windows.Forms.TextBox tbUHNamirnice;
        private System.Windows.Forms.Button btObrisiNamirnicu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaDijetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sacuvajDijetuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ucitajDijetuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramuToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label g;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

