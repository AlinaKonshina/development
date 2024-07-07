namespace test_SQL1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_zapros = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBox_tel_desc = new System.Windows.Forms.CheckBox();
            this.checkBox_fio_asc = new System.Windows.Forms.CheckBox();
            this.checkBox_kvr_desc = new System.Windows.Forms.CheckBox();
            this.checkBox_ulc_asc = new System.Windows.Forms.CheckBox();
            this.checkBox_dom_desc = new System.Windows.Forms.CheckBox();
            this.checkBox_dom_asc = new System.Windows.Forms.CheckBox();
            this.checkBox_ulc_desc = new System.Windows.Forms.CheckBox();
            this.checkBox_kvr_asc = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.checkBox_tel_asc = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.checkBox_fio_desc = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.teleph6 = new System.Windows.Forms.TextBox();
            this.teleph5 = new System.Windows.Forms.TextBox();
            this.teleph4 = new System.Windows.Forms.TextBox();
            this.teleph3 = new System.Windows.Forms.TextBox();
            this.teleph2 = new System.Windows.Forms.TextBox();
            this.teleph1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_IO = new System.Windows.Forms.TextBox();
            this.textBox_FIO = new System.Windows.Forms.TextBox();
            this.ADRES = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_KVR = new System.Windows.Forms.TextBox();
            this.textBox_DOM = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_ULC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.ADRES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 304);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(922, 10);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            this.splitter1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitter1_SplitterMoved);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_zapros);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ADRES);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(922, 304);
            this.panel1.TabIndex = 1;
            // 
            // textBox_zapros
            // 
            this.textBox_zapros.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_zapros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_zapros.Location = new System.Drawing.Point(702, 12);
            this.textBox_zapros.Multiline = true;
            this.textBox_zapros.Name = "textBox_zapros";
            this.textBox_zapros.Size = new System.Drawing.Size(208, 260);
            this.textBox_zapros.TabIndex = 42;
            this.textBox_zapros.Text = "*Ваш SQL запрос";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.checkBox_tel_desc);
            this.panel4.Controls.Add(this.checkBox_fio_asc);
            this.panel4.Controls.Add(this.checkBox_kvr_desc);
            this.panel4.Controls.Add(this.checkBox_ulc_asc);
            this.panel4.Controls.Add(this.checkBox_dom_desc);
            this.panel4.Controls.Add(this.checkBox_dom_asc);
            this.panel4.Controls.Add(this.checkBox_ulc_desc);
            this.panel4.Controls.Add(this.checkBox_kvr_asc);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.checkBox_tel_asc);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.checkBox_fio_desc);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Location = new System.Drawing.Point(380, 131);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(308, 144);
            this.panel4.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(3, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(228, 20);
            this.label10.TabIndex = 29;
            this.label10.Text = "Сортировка данных по:";
            // 
            // checkBox_tel_desc
            // 
            this.checkBox_tel_desc.AutoSize = true;
            this.checkBox_tel_desc.Location = new System.Drawing.Point(274, 124);
            this.checkBox_tel_desc.Name = "checkBox_tel_desc";
            this.checkBox_tel_desc.Size = new System.Drawing.Size(18, 17);
            this.checkBox_tel_desc.TabIndex = 39;
            this.checkBox_tel_desc.UseVisualStyleBackColor = true;
            this.checkBox_tel_desc.CheckedChanged += new System.EventHandler(this.checkBox_tel_desc_CheckedChanged);
            // 
            // checkBox_fio_asc
            // 
            this.checkBox_fio_asc.AutoSize = true;
            this.checkBox_fio_asc.Location = new System.Drawing.Point(250, 32);
            this.checkBox_fio_asc.Name = "checkBox_fio_asc";
            this.checkBox_fio_asc.Size = new System.Drawing.Size(18, 17);
            this.checkBox_fio_asc.TabIndex = 15;
            this.checkBox_fio_asc.UseVisualStyleBackColor = true;
            this.checkBox_fio_asc.CheckedChanged += new System.EventHandler(this.checkBox_fio_asc_CheckedChanged);
            // 
            // checkBox_kvr_desc
            // 
            this.checkBox_kvr_desc.AutoSize = true;
            this.checkBox_kvr_desc.Location = new System.Drawing.Point(274, 101);
            this.checkBox_kvr_desc.Name = "checkBox_kvr_desc";
            this.checkBox_kvr_desc.Size = new System.Drawing.Size(18, 17);
            this.checkBox_kvr_desc.TabIndex = 38;
            this.checkBox_kvr_desc.UseVisualStyleBackColor = true;
            this.checkBox_kvr_desc.CheckedChanged += new System.EventHandler(this.checkBox_kvr_desc_CheckedChanged);
            // 
            // checkBox_ulc_asc
            // 
            this.checkBox_ulc_asc.AutoSize = true;
            this.checkBox_ulc_asc.Location = new System.Drawing.Point(250, 55);
            this.checkBox_ulc_asc.Name = "checkBox_ulc_asc";
            this.checkBox_ulc_asc.Size = new System.Drawing.Size(18, 17);
            this.checkBox_ulc_asc.TabIndex = 25;
            this.checkBox_ulc_asc.UseVisualStyleBackColor = true;
            this.checkBox_ulc_asc.CheckedChanged += new System.EventHandler(this.checkBox_ulc_asc_CheckedChanged);
            // 
            // checkBox_dom_desc
            // 
            this.checkBox_dom_desc.AutoSize = true;
            this.checkBox_dom_desc.Location = new System.Drawing.Point(274, 78);
            this.checkBox_dom_desc.Name = "checkBox_dom_desc";
            this.checkBox_dom_desc.Size = new System.Drawing.Size(18, 17);
            this.checkBox_dom_desc.TabIndex = 37;
            this.checkBox_dom_desc.UseVisualStyleBackColor = true;
            this.checkBox_dom_desc.CheckedChanged += new System.EventHandler(this.checkBox_dom_desc_CheckedChanged);
            // 
            // checkBox_dom_asc
            // 
            this.checkBox_dom_asc.AutoSize = true;
            this.checkBox_dom_asc.Location = new System.Drawing.Point(250, 78);
            this.checkBox_dom_asc.Name = "checkBox_dom_asc";
            this.checkBox_dom_asc.Size = new System.Drawing.Size(18, 17);
            this.checkBox_dom_asc.TabIndex = 26;
            this.checkBox_dom_asc.UseVisualStyleBackColor = true;
            this.checkBox_dom_asc.CheckedChanged += new System.EventHandler(this.checkBox_dom_asc_CheckedChanged);
            // 
            // checkBox_ulc_desc
            // 
            this.checkBox_ulc_desc.AutoSize = true;
            this.checkBox_ulc_desc.Location = new System.Drawing.Point(274, 55);
            this.checkBox_ulc_desc.Name = "checkBox_ulc_desc";
            this.checkBox_ulc_desc.Size = new System.Drawing.Size(18, 17);
            this.checkBox_ulc_desc.TabIndex = 36;
            this.checkBox_ulc_desc.UseVisualStyleBackColor = true;
            this.checkBox_ulc_desc.CheckedChanged += new System.EventHandler(this.checkBox_ulc_desc_CheckedChanged);
            // 
            // checkBox_kvr_asc
            // 
            this.checkBox_kvr_asc.AutoSize = true;
            this.checkBox_kvr_asc.Location = new System.Drawing.Point(250, 101);
            this.checkBox_kvr_asc.Name = "checkBox_kvr_asc";
            this.checkBox_kvr_asc.Size = new System.Drawing.Size(18, 17);
            this.checkBox_kvr_asc.TabIndex = 27;
            this.checkBox_kvr_asc.UseVisualStyleBackColor = true;
            this.checkBox_kvr_asc.CheckedChanged += new System.EventHandler(this.checkBox_kvr_asc_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(146, 120);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 20);
            this.label15.TabIndex = 35;
            this.label15.Text = "Телефон";
            // 
            // checkBox_tel_asc
            // 
            this.checkBox_tel_asc.AutoSize = true;
            this.checkBox_tel_asc.Location = new System.Drawing.Point(250, 124);
            this.checkBox_tel_asc.Name = "checkBox_tel_asc";
            this.checkBox_tel_asc.Size = new System.Drawing.Size(18, 17);
            this.checkBox_tel_asc.TabIndex = 28;
            this.checkBox_tel_asc.UseVisualStyleBackColor = true;
            this.checkBox_tel_asc.CheckedChanged += new System.EventHandler(this.checkBox_tel_asc_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(141, 97);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 20);
            this.label14.TabIndex = 34;
            this.label14.Text = "Квартира";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(146, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 20);
            this.label11.TabIndex = 30;
            this.label11.Text = "Фамилия";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(187, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 20);
            this.label13.TabIndex = 33;
            this.label13.Text = "Дом";
            // 
            // checkBox_fio_desc
            // 
            this.checkBox_fio_desc.AutoSize = true;
            this.checkBox_fio_desc.Location = new System.Drawing.Point(274, 32);
            this.checkBox_fio_desc.Name = "checkBox_fio_desc";
            this.checkBox_fio_desc.Size = new System.Drawing.Size(18, 17);
            this.checkBox_fio_desc.TabIndex = 31;
            this.checkBox_fio_desc.UseVisualStyleBackColor = true;
            this.checkBox_fio_desc.CheckedChanged += new System.EventHandler(this.checkBox_fio_desc_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(171, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 20);
            this.label12.TabIndex = 32;
            this.label12.Text = "Улица";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.teleph6);
            this.panel3.Controls.Add(this.teleph5);
            this.panel3.Controls.Add(this.teleph4);
            this.panel3.Controls.Add(this.teleph3);
            this.panel3.Controls.Add(this.teleph2);
            this.panel3.Controls.Add(this.teleph1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(67, 120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 88);
            this.panel3.TabIndex = 24;
            // 
            // teleph6
            // 
            this.teleph6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.teleph6.BackColor = System.Drawing.SystemColors.Info;
            this.teleph6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teleph6.Location = new System.Drawing.Point(170, 43);
            this.teleph6.MaxLength = 1;
            this.teleph6.Name = "teleph6";
            this.teleph6.Size = new System.Drawing.Size(25, 30);
            this.teleph6.TabIndex = 14;
            this.teleph6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // teleph5
            // 
            this.teleph5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.teleph5.BackColor = System.Drawing.SystemColors.Info;
            this.teleph5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teleph5.Location = new System.Drawing.Point(139, 43);
            this.teleph5.MaxLength = 1;
            this.teleph5.Name = "teleph5";
            this.teleph5.Size = new System.Drawing.Size(25, 30);
            this.teleph5.TabIndex = 13;
            this.teleph5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // teleph4
            // 
            this.teleph4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.teleph4.BackColor = System.Drawing.SystemColors.Info;
            this.teleph4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teleph4.Location = new System.Drawing.Point(108, 43);
            this.teleph4.MaxLength = 1;
            this.teleph4.Name = "teleph4";
            this.teleph4.Size = new System.Drawing.Size(25, 30);
            this.teleph4.TabIndex = 12;
            this.teleph4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // teleph3
            // 
            this.teleph3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.teleph3.BackColor = System.Drawing.SystemColors.Info;
            this.teleph3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teleph3.Location = new System.Drawing.Point(77, 43);
            this.teleph3.MaxLength = 1;
            this.teleph3.Name = "teleph3";
            this.teleph3.Size = new System.Drawing.Size(25, 30);
            this.teleph3.TabIndex = 11;
            this.teleph3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // teleph2
            // 
            this.teleph2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.teleph2.BackColor = System.Drawing.SystemColors.Info;
            this.teleph2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teleph2.Location = new System.Drawing.Point(46, 43);
            this.teleph2.MaxLength = 1;
            this.teleph2.Name = "teleph2";
            this.teleph2.Size = new System.Drawing.Size(25, 30);
            this.teleph2.TabIndex = 10;
            this.teleph2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // teleph1
            // 
            this.teleph1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.teleph1.BackColor = System.Drawing.SystemColors.Info;
            this.teleph1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teleph1.Location = new System.Drawing.Point(15, 43);
            this.teleph1.MaxLength = 1;
            this.teleph1.Name = "teleph1";
            this.teleph1.Size = new System.Drawing.Size(25, 30);
            this.teleph1.TabIndex = 9;
            this.teleph1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(57, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Телефон";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox_IO);
            this.panel2.Controls.Add(this.textBox_FIO);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 102);
            this.panel2.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(50, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(207, 25);
            this.label9.TabIndex = 24;
            this.label9.Text = "Имя пользователя";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(174, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Инициалы";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Фамилия";
            // 
            // textBox_IO
            // 
            this.textBox_IO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_IO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_IO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_IO.Location = new System.Drawing.Point(178, 66);
            this.textBox_IO.Name = "textBox_IO";
            this.textBox_IO.Size = new System.Drawing.Size(40, 27);
            this.textBox_IO.TabIndex = 4;
            // 
            // textBox_FIO
            // 
            this.textBox_FIO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_FIO.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox_FIO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_FIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_FIO.Location = new System.Drawing.Point(24, 66);
            this.textBox_FIO.Name = "textBox_FIO";
            this.textBox_FIO.Size = new System.Drawing.Size(133, 27);
            this.textBox_FIO.TabIndex = 5;
            // 
            // ADRES
            // 
            this.ADRES.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ADRES.Controls.Add(this.label8);
            this.ADRES.Controls.Add(this.label7);
            this.ADRES.Controls.Add(this.label6);
            this.ADRES.Controls.Add(this.textBox_KVR);
            this.ADRES.Controls.Add(this.textBox_DOM);
            this.ADRES.Controls.Add(this.label5);
            this.ADRES.Controls.Add(this.textBox_ULC);
            this.ADRES.Location = new System.Drawing.Point(380, 12);
            this.ADRES.Name = "ADRES";
            this.ADRES.Size = new System.Drawing.Size(308, 110);
            this.ADRES.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(39, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(224, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "Адрес пользователя";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(198, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Квартира";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(140, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Дом";
            // 
            // textBox_KVR
            // 
            this.textBox_KVR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_KVR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_KVR.Location = new System.Drawing.Point(202, 73);
            this.textBox_KVR.Name = "textBox_KVR";
            this.textBox_KVR.Size = new System.Drawing.Size(36, 27);
            this.textBox_KVR.TabIndex = 19;
            // 
            // textBox_DOM
            // 
            this.textBox_DOM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_DOM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_DOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_DOM.Location = new System.Drawing.Point(144, 73);
            this.textBox_DOM.Name = "textBox_DOM";
            this.textBox_DOM.Size = new System.Drawing.Size(36, 27);
            this.textBox_DOM.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(18, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Улица";
            // 
            // textBox_ULC
            // 
            this.textBox_ULC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_ULC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_ULC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_ULC.Location = new System.Drawing.Point(12, 73);
            this.textBox_ULC.Name = "textBox_ULC";
            this.textBox_ULC.Size = new System.Drawing.Size(126, 27);
            this.textBox_ULC.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(366, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "*Для поиска данных, заполните необходимые Вам поля";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(111, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 72);
            this.button1.TabIndex = 0;
            this.button1.Text = "Начать поиск";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 314);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(922, 177);
            this.dataGridView1.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 491);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(922, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(147, 20);
            this.toolStripStatusLabel1.Text = "Количество строк: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 517);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ADRES.ResumeLayout(false);
            this.ADRES.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TextBox textBox_IO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_FIO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox teleph2;
        private System.Windows.Forms.TextBox teleph1;
        private System.Windows.Forms.TextBox teleph6;
        private System.Windows.Forms.TextBox teleph5;
        private System.Windows.Forms.TextBox teleph4;
        private System.Windows.Forms.TextBox teleph3;
        private System.Windows.Forms.CheckBox checkBox_fio_asc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_ULC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_KVR;
        private System.Windows.Forms.TextBox textBox_DOM;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel ADRES;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBox_tel_asc;
        private System.Windows.Forms.CheckBox checkBox_kvr_asc;
        private System.Windows.Forms.CheckBox checkBox_dom_asc;
        private System.Windows.Forms.CheckBox checkBox_ulc_asc;
        private System.Windows.Forms.CheckBox checkBox_fio_desc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkBox_tel_desc;
        private System.Windows.Forms.CheckBox checkBox_kvr_desc;
        private System.Windows.Forms.CheckBox checkBox_dom_desc;
        private System.Windows.Forms.CheckBox checkBox_ulc_desc;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox_zapros;
    }
}

