namespace QLKetQuaGiangDay
{
    partial class frmCrossTable
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
            this.allTyLeDatContentDgv = new System.Windows.Forms.DataGridView();
            this.printExcelBtn = new System.Windows.Forms.Button();
            this.goBackBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbbLoaiBieuDo = new System.Windows.Forms.ComboBox();
            this.bieuDoChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tyLeDatMonDgv = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.findBtn = new System.Windows.Forms.Button();
            this.findGVTxt = new System.Windows.Forms.TextBox();
            this.mGVRadioBtn = new System.Windows.Forms.RadioButton();
            this.tenGVRadioBtn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.settingBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.hkktCbb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.hkbdCbb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.allTyLeDatContentDgv)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bieuDoChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tyLeDatMonDgv)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // allTyLeDatContentDgv
            // 
            this.allTyLeDatContentDgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allTyLeDatContentDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allTyLeDatContentDgv.Location = new System.Drawing.Point(6, 118);
            this.allTyLeDatContentDgv.Name = "allTyLeDatContentDgv";
            this.allTyLeDatContentDgv.RowHeadersWidth = 51;
            this.allTyLeDatContentDgv.RowTemplate.Height = 24;
            this.allTyLeDatContentDgv.Size = new System.Drawing.Size(1198, 530);
            this.allTyLeDatContentDgv.TabIndex = 0;
            // 
            // printExcelBtn
            // 
            this.printExcelBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.printExcelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(86)))), ((int)(((byte)(182)))));
            this.printExcelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printExcelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printExcelBtn.ForeColor = System.Drawing.Color.White;
            this.printExcelBtn.Location = new System.Drawing.Point(107, 12);
            this.printExcelBtn.Name = "printExcelBtn";
            this.printExcelBtn.Size = new System.Drawing.Size(138, 39);
            this.printExcelBtn.TabIndex = 22;
            this.printExcelBtn.Text = "In file Excel";
            this.printExcelBtn.UseVisualStyleBackColor = false;
            this.printExcelBtn.Click += new System.EventHandler(this.printExcelBtn_Click);
            // 
            // goBackBtn
            // 
            this.goBackBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.goBackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(86)))), ((int)(((byte)(182)))));
            this.goBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goBackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackBtn.ForeColor = System.Drawing.Color.White;
            this.goBackBtn.Location = new System.Drawing.Point(12, 12);
            this.goBackBtn.Name = "goBackBtn";
            this.goBackBtn.Size = new System.Drawing.Size(89, 39);
            this.goBackBtn.TabIndex = 23;
            this.goBackBtn.Text = "Trở về";
            this.goBackBtn.UseVisualStyleBackColor = false;
            this.goBackBtn.Click += new System.EventHandler(this.goBackBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 57);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1218, 685);
            this.tabControl1.TabIndex = 24;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbbLoaiBieuDo);
            this.tabPage2.Controls.Add(this.bieuDoChart);
            this.tabPage2.Controls.Add(this.tyLeDatMonDgv);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1210, 656);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bảng kết hợp";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbbLoaiBieuDo
            // 
            this.cbbLoaiBieuDo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbbLoaiBieuDo.FormattingEnabled = true;
            this.cbbLoaiBieuDo.Items.AddRange(new object[] {
            "Biểu đồ dạng Column",
            "Biểu đồ dạng Bar",
            "Biểu đồ Line"});
            this.cbbLoaiBieuDo.Location = new System.Drawing.Point(6, 311);
            this.cbbLoaiBieuDo.Name = "cbbLoaiBieuDo";
            this.cbbLoaiBieuDo.Size = new System.Drawing.Size(253, 24);
            this.cbbLoaiBieuDo.TabIndex = 21;
            this.cbbLoaiBieuDo.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiBieuDo_SelectedIndexChanged);
            // 
            // bieuDoChart
            // 
            this.bieuDoChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bieuDoChart.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.Name = "ChartArea1";
            this.bieuDoChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.bieuDoChart.Legends.Add(legend1);
            this.bieuDoChart.Location = new System.Drawing.Point(6, 341);
            this.bieuDoChart.Name = "bieuDoChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.bieuDoChart.Series.Add(series1);
            this.bieuDoChart.Size = new System.Drawing.Size(1198, 307);
            this.bieuDoChart.TabIndex = 20;
            this.bieuDoChart.Text = "chart1";
            // 
            // tyLeDatMonDgv
            // 
            this.tyLeDatMonDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tyLeDatMonDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tyLeDatMonDgv.Location = new System.Drawing.Point(6, 6);
            this.tyLeDatMonDgv.Name = "tyLeDatMonDgv";
            this.tyLeDatMonDgv.RowHeadersWidth = 51;
            this.tyLeDatMonDgv.RowTemplate.Height = 24;
            this.tyLeDatMonDgv.Size = new System.Drawing.Size(1198, 303);
            this.tyLeDatMonDgv.TabIndex = 1;
            this.tyLeDatMonDgv.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tyLeDatMonDgv_CellMouseClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.allTyLeDatContentDgv);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1210, 656);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tổng quát";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.resetBtn);
            this.groupBox2.Controls.Add(this.findBtn);
            this.groupBox2.Controls.Add(this.findGVTxt);
            this.groupBox2.Controls.Add(this.mGVRadioBtn);
            this.groupBox2.Controls.Add(this.tenGVRadioBtn);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(711, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(493, 106);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.White;
            this.resetBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(86)))), ((int)(((byte)(182)))));
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(86)))), ((int)(((byte)(182)))));
            this.resetBtn.Location = new System.Drawing.Point(407, 51);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(80, 35);
            this.resetBtn.TabIndex = 7;
            this.resetBtn.Text = "Đặt lại";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // findBtn
            // 
            this.findBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(86)))), ((int)(((byte)(182)))));
            this.findBtn.FlatAppearance.BorderSize = 0;
            this.findBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findBtn.ForeColor = System.Drawing.Color.White;
            this.findBtn.Location = new System.Drawing.Point(328, 52);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(73, 34);
            this.findBtn.TabIndex = 14;
            this.findBtn.Text = "Tìm";
            this.findBtn.UseVisualStyleBackColor = false;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // findGVTxt
            // 
            this.findGVTxt.Location = new System.Drawing.Point(21, 56);
            this.findGVTxt.Name = "findGVTxt";
            this.findGVTxt.Size = new System.Drawing.Size(301, 27);
            this.findGVTxt.TabIndex = 9;
            // 
            // mGVRadioBtn
            // 
            this.mGVRadioBtn.AutoSize = true;
            this.mGVRadioBtn.Location = new System.Drawing.Point(189, 26);
            this.mGVRadioBtn.Name = "mGVRadioBtn";
            this.mGVRadioBtn.Size = new System.Drawing.Size(133, 24);
            this.mGVRadioBtn.TabIndex = 10;
            this.mGVRadioBtn.Text = "Mã giảng viên";
            this.mGVRadioBtn.UseVisualStyleBackColor = true;
            // 
            // tenGVRadioBtn
            // 
            this.tenGVRadioBtn.AutoSize = true;
            this.tenGVRadioBtn.Checked = true;
            this.tenGVRadioBtn.Location = new System.Drawing.Point(21, 26);
            this.tenGVRadioBtn.Name = "tenGVRadioBtn";
            this.tenGVRadioBtn.Size = new System.Drawing.Size(138, 24);
            this.tenGVRadioBtn.TabIndex = 11;
            this.tenGVRadioBtn.TabStop = true;
            this.tenGVRadioBtn.Text = "Tên giảng viên";
            this.tenGVRadioBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.settingBtn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.hkktCbb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.hkbdCbb);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 106);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Học kì";
            // 
            // settingBtn
            // 
            this.settingBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(86)))), ((int)(((byte)(182)))));
            this.settingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingBtn.ForeColor = System.Drawing.Color.White;
            this.settingBtn.Location = new System.Drawing.Point(297, 58);
            this.settingBtn.Name = "settingBtn";
            this.settingBtn.Size = new System.Drawing.Size(80, 38);
            this.settingBtn.TabIndex = 13;
            this.settingBtn.Text = "Nhập";
            this.settingBtn.UseVisualStyleBackColor = false;
            this.settingBtn.Click += new System.EventHandler(this.settingBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Học kì kết thúc:";
            // 
            // hkktCbb
            // 
            this.hkktCbb.FormattingEnabled = true;
            this.hkktCbb.Location = new System.Drawing.Point(148, 64);
            this.hkktCbb.Name = "hkktCbb";
            this.hkktCbb.Size = new System.Drawing.Size(134, 28);
            this.hkktCbb.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Học kì bắt đầu:";
            // 
            // hkbdCbb
            // 
            this.hkbdCbb.FormattingEnabled = true;
            this.hkbdCbb.Location = new System.Drawing.Point(148, 26);
            this.hkbdCbb.Name = "hkbdCbb";
            this.hkbdCbb.Size = new System.Drawing.Size(134, 28);
            this.hkbdCbb.TabIndex = 1;
            // 
            // frmCrossTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 742);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.goBackBtn);
            this.Controls.Add(this.printExcelBtn);
            this.Name = "frmCrossTable";
            this.Text = "CrossTable";
            this.Load += new System.EventHandler(this.frmCrossTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.allTyLeDatContentDgv)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bieuDoChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tyLeDatMonDgv)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView allTyLeDatContentDgv;
        private System.Windows.Forms.Button printExcelBtn;
        private System.Windows.Forms.Button goBackBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView tyLeDatMonDgv;
        private System.Windows.Forms.DataVisualization.Charting.Chart bieuDoChart;
        private System.Windows.Forms.ComboBox cbbLoaiBieuDo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox hkbdCbb;
        private System.Windows.Forms.ComboBox hkktCbb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button settingBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.TextBox findGVTxt;
        private System.Windows.Forms.RadioButton mGVRadioBtn;
        private System.Windows.Forms.RadioButton tenGVRadioBtn;
    }
}