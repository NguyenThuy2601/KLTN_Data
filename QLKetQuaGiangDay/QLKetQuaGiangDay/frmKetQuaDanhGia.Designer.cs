namespace QLKetQuaGiangDay
{
    partial class frmKetQuaDanhGia
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.stdevLbl = new System.Windows.Forms.Label();
            this.avgLbl = new System.Windows.Forms.Label();
            this.maxLbl = new System.Windows.Forms.Label();
            this.minLbl = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.changeChartBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbLoaiBieuDo = new System.Windows.Forms.ComboBox();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.slKhaoSatLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lopLbl = new System.Windows.Forms.Label();
            this.slsvLbl = new System.Windows.Forms.Label();
            this.tenGVLbl = new System.Windows.Forms.Label();
            this.mGVLbl = new System.Windows.Forms.Label();
            this.tenMHLbl = new System.Windows.Forms.Label();
            this.mMHLbl = new System.Windows.Forms.Label();
            this.hkLbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lopFixLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.resetFilterBtn = new System.Windows.Forms.Button();
            this.enterBtn = new System.Windows.Forms.Button();
            this.lopCbb = new System.Windows.Forms.ComboBox();
            this.hkCbb = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.contentTxt = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lopTab2Lbl = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tenGVTab2Lbl = new System.Windows.Forms.Label();
            this.maGVTab2Lbl = new System.Windows.Forms.Label();
            this.tenMHTab2Lbl = new System.Windows.Forms.Label();
            this.maMHTab2Lbl = new System.Windows.Forms.Label();
            this.hkTab2Lbl = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.gopYDgv = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gopYDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1178, 869);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.Chart);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.dgvDetail);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1170, 840);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kết quả";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox4.Controls.Add(this.stdevLbl);
            this.groupBox4.Controls.Add(this.avgLbl);
            this.groupBox4.Controls.Add(this.maxLbl);
            this.groupBox4.Controls.Add(this.minLbl);
            this.groupBox4.Controls.Add(this.label36);
            this.groupBox4.Controls.Add(this.label37);
            this.groupBox4.Controls.Add(this.label40);
            this.groupBox4.Controls.Add(this.label41);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(386, 195);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(352, 172);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kết quả thống kê";
            // 
            // stdevLbl
            // 
            this.stdevLbl.AutoSize = true;
            this.stdevLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdevLbl.Location = new System.Drawing.Point(133, 76);
            this.stdevLbl.Name = "stdevLbl";
            this.stdevLbl.Size = new System.Drawing.Size(121, 20);
            this.stdevLbl.TabIndex = 20;
            this.stdevLbl.Text = "Độ lệch chuẩn:";
            // 
            // avgLbl
            // 
            this.avgLbl.AutoSize = true;
            this.avgLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgLbl.Location = new System.Drawing.Point(117, 39);
            this.avgLbl.Name = "avgLbl";
            this.avgLbl.Size = new System.Drawing.Size(23, 20);
            this.avgLbl.TabIndex = 19;
            this.avgLbl.Text = "tb";
            // 
            // maxLbl
            // 
            this.maxLbl.AutoSize = true;
            this.maxLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLbl.Location = new System.Drawing.Point(227, 115);
            this.maxLbl.Name = "maxLbl";
            this.maxLbl.Size = new System.Drawing.Size(40, 20);
            this.maxLbl.TabIndex = 11;
            this.maxLbl.Text = "max";
            // 
            // minLbl
            // 
            this.minLbl.AutoSize = true;
            this.minLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLbl.Location = new System.Drawing.Point(63, 115);
            this.minLbl.Name = "minLbl";
            this.minLbl.Size = new System.Drawing.Size(36, 20);
            this.minLbl.TabIndex = 10;
            this.minLbl.Text = "min";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(6, 76);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(121, 20);
            this.label36.TabIndex = 9;
            this.label36.Text = "Độ lệch chuẩn:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(160, 115);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(45, 20);
            this.label37.TabIndex = 6;
            this.label37.Text = "Max:";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(6, 39);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(93, 20);
            this.label40.TabIndex = 3;
            this.label40.Text = "Trung bình:";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(6, 115);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(41, 20);
            this.label41.TabIndex = 2;
            this.label41.Text = "Min:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.changeChartBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbbLoaiBieuDo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(771, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 164);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cài đặt";
            // 
            // changeChartBtn
            // 
            this.changeChartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(86)))), ((int)(((byte)(182)))));
            this.changeChartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeChartBtn.ForeColor = System.Drawing.Color.White;
            this.changeChartBtn.Location = new System.Drawing.Point(307, 95);
            this.changeChartBtn.Name = "changeChartBtn";
            this.changeChartBtn.Size = new System.Drawing.Size(80, 38);
            this.changeChartBtn.TabIndex = 4;
            this.changeChartBtn.Text = "Nhập";
            this.changeChartBtn.UseVisualStyleBackColor = false;
            this.changeChartBtn.Click += new System.EventHandler(this.changeChartBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loại biểu đồ:";
            // 
            // cbbLoaiBieuDo
            // 
            this.cbbLoaiBieuDo.FormattingEnabled = true;
            this.cbbLoaiBieuDo.Items.AddRange(new object[] {
            "Biểu đồ dạng Column",
            "Biểu đồ dạng Bar",
            "Biểu đồ FastLine",
            "test"});
            this.cbbLoaiBieuDo.Location = new System.Drawing.Point(134, 53);
            this.cbbLoaiBieuDo.Name = "cbbLoaiBieuDo";
            this.cbbLoaiBieuDo.Size = new System.Drawing.Size(253, 28);
            this.cbbLoaiBieuDo.TabIndex = 3;
            // 
            // Chart
            // 
            this.Chart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Chart.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart.Legends.Add(legend1);
            this.Chart.Location = new System.Drawing.Point(13, 483);
            this.Chart.Name = "Chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Chart.Series.Add(series1);
            this.Chart.Size = new System.Drawing.Size(1151, 335);
            this.Chart.TabIndex = 18;
            this.Chart.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.slKhaoSatLbl);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lopLbl);
            this.groupBox2.Controls.Add(this.slsvLbl);
            this.groupBox2.Controls.Add(this.tenGVLbl);
            this.groupBox2.Controls.Add(this.mGVLbl);
            this.groupBox2.Controls.Add(this.tenMHLbl);
            this.groupBox2.Controls.Add(this.mMHLbl);
            this.groupBox2.Controls.Add(this.hkLbl);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lopFixLbl);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 294);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // slKhaoSatLbl
            // 
            this.slKhaoSatLbl.AutoSize = true;
            this.slKhaoSatLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slKhaoSatLbl.Location = new System.Drawing.Point(236, 226);
            this.slKhaoSatLbl.Name = "slKhaoSatLbl";
            this.slKhaoSatLbl.Size = new System.Drawing.Size(36, 20);
            this.slKhaoSatLbl.TabIndex = 18;
            this.slKhaoSatLbl.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "SL tham gia:";
            // 
            // lopLbl
            // 
            this.lopLbl.AutoSize = true;
            this.lopLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lopLbl.Location = new System.Drawing.Point(97, 264);
            this.lopLbl.Name = "lopLbl";
            this.lopLbl.Size = new System.Drawing.Size(93, 20);
            this.lopLbl.TabIndex = 16;
            this.lopLbl.Text = "Giảng viên:";
            // 
            // slsvLbl
            // 
            this.slsvLbl.AutoSize = true;
            this.slsvLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slsvLbl.Location = new System.Drawing.Point(63, 226);
            this.slsvLbl.Name = "slsvLbl";
            this.slsvLbl.Size = new System.Drawing.Size(36, 20);
            this.slsvLbl.TabIndex = 15;
            this.slsvLbl.Text = "100";
            // 
            // tenGVLbl
            // 
            this.tenGVLbl.AutoSize = true;
            this.tenGVLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenGVLbl.Location = new System.Drawing.Point(105, 187);
            this.tenGVLbl.Name = "tenGVLbl";
            this.tenGVLbl.Size = new System.Drawing.Size(93, 20);
            this.tenGVLbl.TabIndex = 14;
            this.tenGVLbl.Text = "Giảng viên:";
            // 
            // mGVLbl
            // 
            this.mGVLbl.AutoSize = true;
            this.mGVLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mGVLbl.Location = new System.Drawing.Point(86, 152);
            this.mGVLbl.Name = "mGVLbl";
            this.mGVLbl.Size = new System.Drawing.Size(93, 20);
            this.mGVLbl.TabIndex = 13;
            this.mGVLbl.Text = "Giảng viên:";
            // 
            // tenMHLbl
            // 
            this.tenMHLbl.AutoSize = true;
            this.tenMHLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenMHLbl.Location = new System.Drawing.Point(86, 115);
            this.tenMHLbl.Name = "tenMHLbl";
            this.tenMHLbl.Size = new System.Drawing.Size(93, 20);
            this.tenMHLbl.TabIndex = 12;
            this.tenMHLbl.Text = "Giảng viên:";
            // 
            // mMHLbl
            // 
            this.mMHLbl.AutoSize = true;
            this.mMHLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mMHLbl.Location = new System.Drawing.Point(86, 76);
            this.mMHLbl.Name = "mMHLbl";
            this.mMHLbl.Size = new System.Drawing.Size(93, 20);
            this.mMHLbl.TabIndex = 11;
            this.mMHLbl.Text = "Giảng viên:";
            // 
            // hkLbl
            // 
            this.hkLbl.AutoSize = true;
            this.hkLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hkLbl.Location = new System.Drawing.Point(86, 39);
            this.hkLbl.Name = "hkLbl";
            this.hkLbl.Size = new System.Drawing.Size(93, 20);
            this.hkLbl.TabIndex = 10;
            this.hkLbl.Text = "Giảng viên:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Mã GV:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Mã môn:";
            // 
            // lopFixLbl
            // 
            this.lopFixLbl.AutoSize = true;
            this.lopFixLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lopFixLbl.Location = new System.Drawing.Point(8, 264);
            this.lopFixLbl.Name = "lopFixLbl";
            this.lopFixLbl.Size = new System.Drawing.Size(85, 20);
            this.lopFixLbl.TabIndex = 5;
            this.lopFixLbl.Text = "Nhóm lớp:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "SLSV:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Môn học:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Học kì:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giảng viên:";
            // 
            // dgvDetail
            // 
            this.dgvDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Location = new System.Drawing.Point(13, 31);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.RowHeadersWidth = 51;
            this.dgvDetail.RowTemplate.Height = 24;
            this.dgvDetail.Size = new System.Drawing.Size(1151, 146);
            this.dgvDetail.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Kết quả đánh giá";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.gopYDgv);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1170, 840);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ý kiến khác";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox6.Controls.Add(this.resetFilterBtn);
            this.groupBox6.Controls.Add(this.enterBtn);
            this.groupBox6.Controls.Add(this.lopCbb);
            this.groupBox6.Controls.Add(this.hkCbb);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.label32);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(18, 412);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(352, 155);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Bộ lọc";
            // 
            // resetFilterBtn
            // 
            this.resetFilterBtn.BackColor = System.Drawing.Color.White;
            this.resetFilterBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(86)))), ((int)(((byte)(182)))));
            this.resetFilterBtn.FlatAppearance.BorderSize = 2;
            this.resetFilterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetFilterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetFilterBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(86)))), ((int)(((byte)(182)))));
            this.resetFilterBtn.Location = new System.Drawing.Point(159, 107);
            this.resetFilterBtn.Name = "resetFilterBtn";
            this.resetFilterBtn.Size = new System.Drawing.Size(82, 36);
            this.resetFilterBtn.TabIndex = 9;
            this.resetFilterBtn.Text = "Đặt lại";
            this.resetFilterBtn.UseVisualStyleBackColor = false;
            this.resetFilterBtn.Click += new System.EventHandler(this.resetFilterBtn_Click);
            // 
            // enterBtn
            // 
            this.enterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(86)))), ((int)(((byte)(182)))));
            this.enterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.enterBtn.Location = new System.Drawing.Point(247, 107);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(82, 36);
            this.enterBtn.TabIndex = 8;
            this.enterBtn.Text = "Nhập";
            this.enterBtn.UseVisualStyleBackColor = false;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // lopCbb
            // 
            this.lopCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lopCbb.FormattingEnabled = true;
            this.lopCbb.Location = new System.Drawing.Point(98, 73);
            this.lopCbb.Name = "lopCbb";
            this.lopCbb.Size = new System.Drawing.Size(231, 28);
            this.lopCbb.TabIndex = 5;
            // 
            // hkCbb
            // 
            this.hkCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hkCbb.FormattingEnabled = true;
            this.hkCbb.Location = new System.Drawing.Point(98, 36);
            this.hkCbb.Name = "hkCbb";
            this.hkCbb.Size = new System.Drawing.Size(159, 28);
            this.hkCbb.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(7, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "Học kì:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(7, 76);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(85, 20);
            this.label32.TabIndex = 2;
            this.label32.Text = "Nhóm lớp:";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox5.Controls.Add(this.contentTxt);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.lopTab2Lbl);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Location = new System.Drawing.Point(387, 412);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(758, 405);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Nội dung";
            // 
            // contentTxt
            // 
            this.contentTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentTxt.Enabled = false;
            this.contentTxt.Location = new System.Drawing.Point(10, 99);
            this.contentTxt.Name = "contentTxt";
            this.contentTxt.Size = new System.Drawing.Size(731, 282);
            this.contentTxt.TabIndex = 18;
            this.contentTxt.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Nội dung";
            // 
            // lopTab2Lbl
            // 
            this.lopTab2Lbl.AutoSize = true;
            this.lopTab2Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lopTab2Lbl.Location = new System.Drawing.Point(97, 39);
            this.lopTab2Lbl.Name = "lopTab2Lbl";
            this.lopTab2Lbl.Size = new System.Drawing.Size(93, 20);
            this.lopTab2Lbl.TabIndex = 16;
            this.lopTab2Lbl.Text = "Giảng viên:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(6, 39);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(85, 20);
            this.label22.TabIndex = 5;
            this.label22.Text = "Nhóm lớp:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Controls.Add(this.tenGVTab2Lbl);
            this.groupBox3.Controls.Add(this.maGVTab2Lbl);
            this.groupBox3.Controls.Add(this.tenMHTab2Lbl);
            this.groupBox3.Controls.Add(this.maMHTab2Lbl);
            this.groupBox3.Controls.Add(this.hkTab2Lbl);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(18, 586);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(352, 231);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin";
            // 
            // tenGVTab2Lbl
            // 
            this.tenGVTab2Lbl.AutoSize = true;
            this.tenGVTab2Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenGVTab2Lbl.Location = new System.Drawing.Point(105, 187);
            this.tenGVTab2Lbl.Name = "tenGVTab2Lbl";
            this.tenGVTab2Lbl.Size = new System.Drawing.Size(93, 20);
            this.tenGVTab2Lbl.TabIndex = 14;
            this.tenGVTab2Lbl.Text = "Giảng viên:";
            // 
            // maGVTab2Lbl
            // 
            this.maGVTab2Lbl.AutoSize = true;
            this.maGVTab2Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maGVTab2Lbl.Location = new System.Drawing.Point(86, 152);
            this.maGVTab2Lbl.Name = "maGVTab2Lbl";
            this.maGVTab2Lbl.Size = new System.Drawing.Size(93, 20);
            this.maGVTab2Lbl.TabIndex = 13;
            this.maGVTab2Lbl.Text = "Giảng viên:";
            // 
            // tenMHTab2Lbl
            // 
            this.tenMHTab2Lbl.AutoSize = true;
            this.tenMHTab2Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenMHTab2Lbl.Location = new System.Drawing.Point(86, 115);
            this.tenMHTab2Lbl.Name = "tenMHTab2Lbl";
            this.tenMHTab2Lbl.Size = new System.Drawing.Size(93, 20);
            this.tenMHTab2Lbl.TabIndex = 12;
            this.tenMHTab2Lbl.Text = "Giảng viên:";
            // 
            // maMHTab2Lbl
            // 
            this.maMHTab2Lbl.AutoSize = true;
            this.maMHTab2Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maMHTab2Lbl.Location = new System.Drawing.Point(86, 76);
            this.maMHTab2Lbl.Name = "maMHTab2Lbl";
            this.maMHTab2Lbl.Size = new System.Drawing.Size(93, 20);
            this.maMHTab2Lbl.TabIndex = 11;
            this.maMHTab2Lbl.Text = "Giảng viên:";
            // 
            // hkTab2Lbl
            // 
            this.hkTab2Lbl.AutoSize = true;
            this.hkTab2Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hkTab2Lbl.Location = new System.Drawing.Point(86, 39);
            this.hkTab2Lbl.Name = "hkTab2Lbl";
            this.hkTab2Lbl.Size = new System.Drawing.Size(93, 20);
            this.hkTab2Lbl.TabIndex = 10;
            this.hkTab2Lbl.Text = "Giảng viên:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(6, 152);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(66, 20);
            this.label20.TabIndex = 9;
            this.label20.Text = "Mã GV:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(6, 76);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(74, 20);
            this.label21.TabIndex = 6;
            this.label21.Text = "Mã môn:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(6, 115);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(78, 20);
            this.label24.TabIndex = 3;
            this.label24.Text = "Môn học:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(6, 39);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(62, 20);
            this.label25.TabIndex = 2;
            this.label25.Text = "Học kì:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(6, 187);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(93, 20);
            this.label26.TabIndex = 1;
            this.label26.Text = "Giảng viên:";
            // 
            // gopYDgv
            // 
            this.gopYDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gopYDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gopYDgv.Location = new System.Drawing.Point(18, 36);
            this.gopYDgv.Name = "gopYDgv";
            this.gopYDgv.RowHeadersWidth = 51;
            this.gopYDgv.RowTemplate.Height = 24;
            this.gopYDgv.Size = new System.Drawing.Size(1127, 370);
            this.gopYDgv.TabIndex = 10;
            this.gopYDgv.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gopYDgv_CellMouseClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 25);
            this.label11.TabIndex = 15;
            this.label11.Text = "Các ý kiến khác";
            // 
            // frmKetQuaDanhGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1192, 884);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmKetQuaDanhGia";
            this.Text = "frmKetQuaDanhGia";
            this.Load += new System.EventHandler(this.frmKetQuaDanhGia_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gopYDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button changeChartBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbLoaiBieuDo;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label slKhaoSatLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lopLbl;
        private System.Windows.Forms.Label slsvLbl;
        private System.Windows.Forms.Label tenGVLbl;
        private System.Windows.Forms.Label mGVLbl;
        private System.Windows.Forms.Label tenMHLbl;
        private System.Windows.Forms.Label mMHLbl;
        private System.Windows.Forms.Label hkLbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lopFixLbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label maxLbl;
        private System.Windows.Forms.Label minLbl;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lopTab2Lbl;
        private System.Windows.Forms.Label tenGVTab2Lbl;
        private System.Windows.Forms.Label maGVTab2Lbl;
        private System.Windows.Forms.Label tenMHTab2Lbl;
        private System.Windows.Forms.Label maMHTab2Lbl;
        private System.Windows.Forms.Label hkTab2Lbl;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DataGridView gopYDgv;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label avgLbl;
        private System.Windows.Forms.Label stdevLbl;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox contentTxt;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.ComboBox lopCbb;
        private System.Windows.Forms.ComboBox hkCbb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.Button resetFilterBtn;
    }
}