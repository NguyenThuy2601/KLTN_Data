namespace QLKetQuaGiangDay
{
    partial class frmGuiEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGuiEmail));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nhomGVCbb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDSGV = new System.Windows.Forms.DataGridView();
            this.enterBtn = new System.Windows.Forms.Button();
            this.hkbdCbb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.underlineBtn = new System.Windows.Forms.Button();
            this.italicBtn = new System.Windows.Forms.Button();
            this.boldBtn = new System.Windows.Forms.Button();
            this.fontSizeNumeric = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.listBtn = new System.Windows.Forms.Button();
            this.rightAlignBtn = new System.Windows.Forms.Button();
            this.leftAlignBtn = new System.Windows.Forms.Button();
            this.centerAlignBth = new System.Windows.Forms.Button();
            this.colorBtn = new System.Windows.Forms.Button();
            this.colorLbl = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.titleTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ccEmailTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.toEmailCbb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.contenRichTextBox = new System.Windows.Forms.RichTextBox();
            this.fileFlowOutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.upFileBtn = new System.Windows.Forms.Button();
            this.sendBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSGV)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontSizeNumeric)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.nhomGVCbb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dgvDSGV);
            this.groupBox1.Controls.Add(this.enterBtn);
            this.groupBox1.Controls.Add(this.hkbdCbb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 438);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // nhomGVCbb
            // 
            this.nhomGVCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nhomGVCbb.FormattingEnabled = true;
            this.nhomGVCbb.Items.AddRange(new object[] {
            "Chưa kí / ghi SBD",
            "Dạy không đúng lịch",
            "Đi trễ về sớm",
            "Thiếu tiết"});
            this.nhomGVCbb.Location = new System.Drawing.Point(79, 72);
            this.nhomGVCbb.Name = "nhomGVCbb";
            this.nhomGVCbb.Size = new System.Drawing.Size(335, 28);
            this.nhomGVCbb.TabIndex = 11;
            this.nhomGVCbb.SelectedIndexChanged += new System.EventHandler(this.nhomGVCbb_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nhóm:";
            // 
            // dgvDSGV
            // 
            this.dgvDSGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDSGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSGV.Location = new System.Drawing.Point(15, 111);
            this.dgvDSGV.Name = "dgvDSGV";
            this.dgvDSGV.RowHeadersWidth = 51;
            this.dgvDSGV.RowTemplate.Height = 24;
            this.dgvDSGV.Size = new System.Drawing.Size(506, 307);
            this.dgvDSGV.TabIndex = 9;
            // 
            // enterBtn
            // 
            this.enterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(86)))), ((int)(((byte)(182)))));
            this.enterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterBtn.ForeColor = System.Drawing.Color.White;
            this.enterBtn.Location = new System.Drawing.Point(334, 28);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(80, 38);
            this.enterBtn.TabIndex = 8;
            this.enterBtn.Text = "Nhập";
            this.enterBtn.UseVisualStyleBackColor = false;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // hkbdCbb
            // 
            this.hkbdCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hkbdCbb.FormattingEnabled = true;
            this.hkbdCbb.Location = new System.Drawing.Point(79, 35);
            this.hkbdCbb.Name = "hkbdCbb";
            this.hkbdCbb.Size = new System.Drawing.Size(249, 28);
            this.hkbdCbb.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Học kì:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.underlineBtn);
            this.groupBox2.Controls.Add(this.italicBtn);
            this.groupBox2.Controls.Add(this.boldBtn);
            this.groupBox2.Controls.Add(this.fontSizeNumeric);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.listBtn);
            this.groupBox2.Controls.Add(this.rightAlignBtn);
            this.groupBox2.Controls.Add(this.leftAlignBtn);
            this.groupBox2.Controls.Add(this.centerAlignBth);
            this.groupBox2.Controls.Add(this.colorBtn);
            this.groupBox2.Controls.Add(this.colorLbl);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(556, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(462, 200);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kiểu chữ";
            // 
            // underlineBtn
            // 
            this.underlineBtn.BackColor = System.Drawing.Color.White;
            this.underlineBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(86)))), ((int)(((byte)(182)))));
            this.underlineBtn.FlatAppearance.BorderSize = 2;
            this.underlineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.underlineBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underlineBtn.ForeColor = System.Drawing.Color.Navy;
            this.underlineBtn.Location = new System.Drawing.Point(122, 86);
            this.underlineBtn.Name = "underlineBtn";
            this.underlineBtn.Size = new System.Drawing.Size(47, 38);
            this.underlineBtn.TabIndex = 18;
            this.underlineBtn.Text = "U";
            this.underlineBtn.UseVisualStyleBackColor = false;
            this.underlineBtn.Click += new System.EventHandler(this.underlineBtn_Click);
            // 
            // italicBtn
            // 
            this.italicBtn.BackColor = System.Drawing.Color.White;
            this.italicBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(86)))), ((int)(((byte)(182)))));
            this.italicBtn.FlatAppearance.BorderSize = 2;
            this.italicBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.italicBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.italicBtn.ForeColor = System.Drawing.Color.Navy;
            this.italicBtn.Location = new System.Drawing.Point(69, 86);
            this.italicBtn.Name = "italicBtn";
            this.italicBtn.Size = new System.Drawing.Size(47, 38);
            this.italicBtn.TabIndex = 17;
            this.italicBtn.Text = "I";
            this.italicBtn.UseVisualStyleBackColor = false;
            this.italicBtn.Click += new System.EventHandler(this.italicBtn_Click);
            // 
            // boldBtn
            // 
            this.boldBtn.BackColor = System.Drawing.Color.White;
            this.boldBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(86)))), ((int)(((byte)(182)))));
            this.boldBtn.FlatAppearance.BorderSize = 2;
            this.boldBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boldBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boldBtn.ForeColor = System.Drawing.Color.Navy;
            this.boldBtn.Location = new System.Drawing.Point(16, 86);
            this.boldBtn.Name = "boldBtn";
            this.boldBtn.Size = new System.Drawing.Size(47, 38);
            this.boldBtn.TabIndex = 16;
            this.boldBtn.Text = "B";
            this.boldBtn.UseVisualStyleBackColor = false;
            this.boldBtn.Click += new System.EventHandler(this.boldBtn_Click);
            // 
            // fontSizeNumeric
            // 
            this.fontSizeNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontSizeNumeric.Location = new System.Drawing.Point(297, 45);
            this.fontSizeNumeric.Name = "fontSizeNumeric";
            this.fontSizeNumeric.Size = new System.Drawing.Size(120, 28);
            this.fontSizeNumeric.TabIndex = 15;
            this.fontSizeNumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.fontSizeNumeric.ValueChanged += new System.EventHandler(this.fontSizeNumeric_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(219, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cỡ chữ:";
            // 
            // listBtn
            // 
            this.listBtn.BackColor = System.Drawing.Color.White;
            this.listBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(86)))), ((int)(((byte)(182)))));
            this.listBtn.FlatAppearance.BorderSize = 2;
            this.listBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listBtn.ForeColor = System.Drawing.Color.Navy;
            this.listBtn.Location = new System.Drawing.Point(223, 130);
            this.listBtn.Name = "listBtn";
            this.listBtn.Size = new System.Drawing.Size(136, 38);
            this.listBtn.TabIndex = 13;
            this.listBtn.Text = "Danh sách";
            this.listBtn.UseVisualStyleBackColor = false;
            this.listBtn.Click += new System.EventHandler(this.listBtn_Click);
            // 
            // rightAlignBtn
            // 
            this.rightAlignBtn.BackColor = System.Drawing.Color.White;
            this.rightAlignBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(86)))), ((int)(((byte)(182)))));
            this.rightAlignBtn.FlatAppearance.BorderSize = 2;
            this.rightAlignBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rightAlignBtn.ForeColor = System.Drawing.Color.Navy;
            this.rightAlignBtn.Image = ((System.Drawing.Image)(resources.GetObject("rightAlignBtn.Image")));
            this.rightAlignBtn.Location = new System.Drawing.Point(122, 130);
            this.rightAlignBtn.Name = "rightAlignBtn";
            this.rightAlignBtn.Size = new System.Drawing.Size(47, 38);
            this.rightAlignBtn.TabIndex = 12;
            this.rightAlignBtn.UseVisualStyleBackColor = false;
            this.rightAlignBtn.Click += new System.EventHandler(this.rightAlignBtn_Click);
            // 
            // leftAlignBtn
            // 
            this.leftAlignBtn.BackColor = System.Drawing.Color.White;
            this.leftAlignBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(86)))), ((int)(((byte)(182)))));
            this.leftAlignBtn.FlatAppearance.BorderSize = 2;
            this.leftAlignBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leftAlignBtn.ForeColor = System.Drawing.Color.Navy;
            this.leftAlignBtn.Image = ((System.Drawing.Image)(resources.GetObject("leftAlignBtn.Image")));
            this.leftAlignBtn.Location = new System.Drawing.Point(16, 130);
            this.leftAlignBtn.Name = "leftAlignBtn";
            this.leftAlignBtn.Size = new System.Drawing.Size(47, 38);
            this.leftAlignBtn.TabIndex = 11;
            this.leftAlignBtn.UseVisualStyleBackColor = false;
            this.leftAlignBtn.Click += new System.EventHandler(this.leftAlignBtn_Click);
            // 
            // centerAlignBth
            // 
            this.centerAlignBth.BackColor = System.Drawing.Color.White;
            this.centerAlignBth.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(86)))), ((int)(((byte)(182)))));
            this.centerAlignBth.FlatAppearance.BorderSize = 2;
            this.centerAlignBth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.centerAlignBth.ForeColor = System.Drawing.Color.Navy;
            this.centerAlignBth.Image = ((System.Drawing.Image)(resources.GetObject("centerAlignBth.Image")));
            this.centerAlignBth.Location = new System.Drawing.Point(69, 130);
            this.centerAlignBth.Name = "centerAlignBth";
            this.centerAlignBth.Size = new System.Drawing.Size(47, 38);
            this.centerAlignBth.TabIndex = 10;
            this.centerAlignBth.UseVisualStyleBackColor = false;
            this.centerAlignBth.Click += new System.EventHandler(this.centerAlignBth_Click);
            // 
            // colorBtn
            // 
            this.colorBtn.BackColor = System.Drawing.Color.White;
            this.colorBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(86)))), ((int)(((byte)(182)))));
            this.colorBtn.FlatAppearance.BorderSize = 2;
            this.colorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorBtn.ForeColor = System.Drawing.Color.Navy;
            this.colorBtn.Location = new System.Drawing.Point(80, 34);
            this.colorBtn.Name = "colorBtn";
            this.colorBtn.Size = new System.Drawing.Size(103, 38);
            this.colorBtn.TabIndex = 9;
            this.colorBtn.Text = "Chọn màu";
            this.colorBtn.UseVisualStyleBackColor = false;
            this.colorBtn.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // colorLbl
            // 
            this.colorLbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.colorLbl.Location = new System.Drawing.Point(18, 38);
            this.colorLbl.Name = "colorLbl";
            this.colorLbl.Size = new System.Drawing.Size(45, 33);
            this.colorLbl.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Controls.Add(this.titleTxt);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.ccEmailTxt);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.toEmailCbb);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(556, 218);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(674, 232);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin";
            // 
            // titleTxt
            // 
            this.titleTxt.Location = new System.Drawing.Point(94, 138);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(513, 27);
            this.titleTxt.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 22);
            this.label7.TabIndex = 19;
            this.label7.Text = "Tiêu đề:";
            // 
            // ccEmailTxt
            // 
            this.ccEmailTxt.Location = new System.Drawing.Point(96, 88);
            this.ccEmailTxt.Name = "ccEmailTxt";
            this.ccEmailTxt.Size = new System.Drawing.Size(366, 27);
            this.ccEmailTxt.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 22);
            this.label6.TabIndex = 17;
            this.label6.Text = "CC:";
            // 
            // toEmailCbb
            // 
            this.toEmailCbb.FormattingEnabled = true;
            this.toEmailCbb.Items.AddRange(new object[] {
            "Chưa kí / ghi SBD",
            "Dạy không đúng lịch",
            "Đi trễ về sớm",
            "Thiếu tiết"});
            this.toEmailCbb.Location = new System.Drawing.Point(96, 41);
            this.toEmailCbb.Name = "toEmailCbb";
            this.toEmailCbb.Size = new System.Drawing.Size(366, 28);
            this.toEmailCbb.TabIndex = 16;
            this.toEmailCbb.SelectedIndexChanged += new System.EventHandler(this.toEmailCbb_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "Gửi đến:";
            // 
            // contenRichTextBox
            // 
            this.contenRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contenRichTextBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.contenRichTextBox.Location = new System.Drawing.Point(12, 530);
            this.contenRichTextBox.Name = "contenRichTextBox";
            this.contenRichTextBox.Size = new System.Drawing.Size(1218, 200);
            this.contenRichTextBox.TabIndex = 3;
            this.contenRichTextBox.Text = "";
            // 
            // fileFlowOutPanel
            // 
            this.fileFlowOutPanel.AutoScroll = true;
            this.fileFlowOutPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.fileFlowOutPanel.Location = new System.Drawing.Point(12, 456);
            this.fileFlowOutPanel.Name = "fileFlowOutPanel";
            this.fileFlowOutPanel.Size = new System.Drawing.Size(559, 63);
            this.fileFlowOutPanel.TabIndex = 4;
            // 
            // upFileBtn
            // 
            this.upFileBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(86)))), ((int)(((byte)(182)))));
            this.upFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upFileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upFileBtn.ForeColor = System.Drawing.Color.White;
            this.upFileBtn.Location = new System.Drawing.Point(577, 469);
            this.upFileBtn.Name = "upFileBtn";
            this.upFileBtn.Size = new System.Drawing.Size(98, 50);
            this.upFileBtn.TabIndex = 9;
            this.upFileBtn.Text = "Tải file";
            this.upFileBtn.UseVisualStyleBackColor = false;
            this.upFileBtn.Click += new System.EventHandler(this.upFileBtn_Click);
            // 
            // sendBtn
            // 
            this.sendBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sendBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(86)))), ((int)(((byte)(182)))));
            this.sendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBtn.ForeColor = System.Drawing.Color.White;
            this.sendBtn.Location = new System.Drawing.Point(1170, 469);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(60, 50);
            this.sendBtn.TabIndex = 10;
            this.sendBtn.Text = "Gửi";
            this.sendBtn.UseVisualStyleBackColor = false;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // frmGuiEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1242, 742);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.upFileBtn);
            this.Controls.Add(this.fileFlowOutPanel);
            this.Controls.Add(this.contenRichTextBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmGuiEmail";
            this.Text = "frmGuiEmail";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSGV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontSizeNumeric)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox hkbdCbb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.ComboBox nhomGVCbb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvDSGV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button leftAlignBtn;
        private System.Windows.Forms.Button centerAlignBth;
        private System.Windows.Forms.Button colorBtn;
        private System.Windows.Forms.Label colorLbl;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox contenRichTextBox;
        private System.Windows.Forms.FlowLayoutPanel fileFlowOutPanel;
        private System.Windows.Forms.NumericUpDown fontSizeNumeric;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button listBtn;
        private System.Windows.Forms.Button rightAlignBtn;
        private System.Windows.Forms.TextBox titleTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ccEmailTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox toEmailCbb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button upFileBtn;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Button underlineBtn;
        private System.Windows.Forms.Button italicBtn;
        private System.Windows.Forms.Button boldBtn;
    }
}