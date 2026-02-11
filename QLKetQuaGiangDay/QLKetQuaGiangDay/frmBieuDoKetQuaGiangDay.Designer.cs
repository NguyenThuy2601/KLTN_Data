namespace QLKetQuaGiangDay
{
    partial class frmBieuDoKetQuaGiangDay
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbbLoaiBieuDo = new System.Windows.Forms.ComboBox();
            this.bieuDoChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.monHocDGV = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.resetBtn = new System.Windows.Forms.Button();
            this.cbbLoaiBieuDoGV = new System.Windows.Forms.ComboBox();
            this.GVBieuDo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gvDGV = new System.Windows.Forms.DataGridView();
            this.gvTabLbl = new System.Windows.Forms.Label();
            this.hkCbb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tenGVRadioBtn = new System.Windows.Forms.RadioButton();
            this.maGVRadioBtn = new System.Windows.Forms.RadioButton();
            this.findGVTxt = new System.Windows.Forms.TextBox();
            this.findGVBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bieuDoChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocDGV)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVBieuDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1168, 637);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbbLoaiBieuDo);
            this.tabPage1.Controls.Add(this.bieuDoChart);
            this.tabPage1.Controls.Add(this.monHocDGV);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1160, 608);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Theo môn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbbLoaiBieuDo
            // 
            this.cbbLoaiBieuDo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbbLoaiBieuDo.FormattingEnabled = true;
            this.cbbLoaiBieuDo.Items.AddRange(new object[] {
            "Biểu đồ dạng Column",
            "Biểu đồ dạng Bar",
            "Biểu đồ Line"});
            this.cbbLoaiBieuDo.Location = new System.Drawing.Point(23, 221);
            this.cbbLoaiBieuDo.Name = "cbbLoaiBieuDo";
            this.cbbLoaiBieuDo.Size = new System.Drawing.Size(253, 28);
            this.cbbLoaiBieuDo.TabIndex = 20;
            this.cbbLoaiBieuDo.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiBieuDo_SelectedIndexChanged);
            // 
            // bieuDoChart
            // 
            this.bieuDoChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bieuDoChart.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea6.Name = "ChartArea1";
            this.bieuDoChart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.bieuDoChart.Legends.Add(legend6);
            this.bieuDoChart.Location = new System.Drawing.Point(23, 255);
            this.bieuDoChart.Name = "bieuDoChart";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.bieuDoChart.Series.Add(series6);
            this.bieuDoChart.Size = new System.Drawing.Size(1114, 335);
            this.bieuDoChart.TabIndex = 19;
            this.bieuDoChart.Text = "chart1";
            // 
            // monHocDGV
            // 
            this.monHocDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monHocDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.monHocDGV.Location = new System.Drawing.Point(23, 52);
            this.monHocDGV.Name = "monHocDGV";
            this.monHocDGV.RowHeadersWidth = 51;
            this.monHocDGV.RowTemplate.Height = 24;
            this.monHocDGV.Size = new System.Drawing.Size(1114, 150);
            this.monHocDGV.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Kết quả đánh giá";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tenGVRadioBtn);
            this.tabPage2.Controls.Add(this.maGVRadioBtn);
            this.tabPage2.Controls.Add(this.findGVTxt);
            this.tabPage2.Controls.Add(this.findGVBtn);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.hkCbb);
            this.tabPage2.Controls.Add(this.resetBtn);
            this.tabPage2.Controls.Add(this.cbbLoaiBieuDoGV);
            this.tabPage2.Controls.Add(this.GVBieuDo);
            this.tabPage2.Controls.Add(this.gvDGV);
            this.tabPage2.Controls.Add(this.gvTabLbl);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1160, 608);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tất cả giảng viên";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // resetBtn
            // 
            this.resetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resetBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(86)))), ((int)(((byte)(182)))));
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.ForeColor = System.Drawing.Color.White;
            this.resetBtn.Location = new System.Drawing.Point(1067, 208);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(73, 39);
            this.resetBtn.TabIndex = 25;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // cbbLoaiBieuDoGV
            // 
            this.cbbLoaiBieuDoGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbbLoaiBieuDoGV.FormattingEnabled = true;
            this.cbbLoaiBieuDoGV.Items.AddRange(new object[] {
            "Biểu đồ dạng Column",
            "Biểu đồ dạng Bar",
            "Biểu đồ FastLine"});
            this.cbbLoaiBieuDoGV.Location = new System.Drawing.Point(26, 223);
            this.cbbLoaiBieuDoGV.Name = "cbbLoaiBieuDoGV";
            this.cbbLoaiBieuDoGV.Size = new System.Drawing.Size(253, 28);
            this.cbbLoaiBieuDoGV.TabIndex = 24;
            this.cbbLoaiBieuDoGV.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiBieuDoGV_SelectedIndexChanged);
            // 
            // GVBieuDo
            // 
            this.GVBieuDo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GVBieuDo.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea5.Name = "ChartArea1";
            this.GVBieuDo.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.GVBieuDo.Legends.Add(legend5);
            this.GVBieuDo.Location = new System.Drawing.Point(26, 257);
            this.GVBieuDo.Name = "GVBieuDo";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.GVBieuDo.Series.Add(series5);
            this.GVBieuDo.Size = new System.Drawing.Size(1114, 335);
            this.GVBieuDo.TabIndex = 23;
            this.GVBieuDo.Text = "chart1";
            // 
            // gvDGV
            // 
            this.gvDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDGV.Location = new System.Drawing.Point(26, 54);
            this.gvDGV.Name = "gvDGV";
            this.gvDGV.RowHeadersWidth = 51;
            this.gvDGV.RowTemplate.Height = 24;
            this.gvDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvDGV.Size = new System.Drawing.Size(1114, 150);
            this.gvDGV.TabIndex = 22;
            this.gvDGV.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvDGV_CellMouseClick);
            // 
            // gvTabLbl
            // 
            this.gvTabLbl.AutoSize = true;
            this.gvTabLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvTabLbl.Location = new System.Drawing.Point(21, 16);
            this.gvTabLbl.Name = "gvTabLbl";
            this.gvTabLbl.Size = new System.Drawing.Size(452, 25);
            this.gvTabLbl.TabIndex = 21;
            this.gvTabLbl.Text = "Biểu đồ tỷ lệ đạt của tất cả giảng viên từ {0} đến {1}";
            // 
            // hkCbb
            // 
            this.hkCbb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hkCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hkCbb.FormattingEnabled = true;
            this.hkCbb.Items.AddRange(new object[] {
            "Biểu đồ dạng Column",
            "Biểu đồ dạng Bar",
            "Biểu đồ FastLine"});
            this.hkCbb.Location = new System.Drawing.Point(799, 218);
            this.hkCbb.Name = "hkCbb";
            this.hkCbb.Size = new System.Drawing.Size(253, 28);
            this.hkCbb.TabIndex = 26;
            this.hkCbb.SelectionChangeCommitted += new System.EventHandler(this.hkCbb_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(731, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Học kì:";
            // 
            // tenGVRadioBtn
            // 
            this.tenGVRadioBtn.AutoSize = true;
            this.tenGVRadioBtn.Checked = true;
            this.tenGVRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenGVRadioBtn.Location = new System.Drawing.Point(598, 18);
            this.tenGVRadioBtn.Name = "tenGVRadioBtn";
            this.tenGVRadioBtn.Size = new System.Drawing.Size(87, 24);
            this.tenGVRadioBtn.TabIndex = 33;
            this.tenGVRadioBtn.TabStop = true;
            this.tenGVRadioBtn.Text = "Tên GV";
            this.tenGVRadioBtn.UseVisualStyleBackColor = true;
            // 
            // maGVRadioBtn
            // 
            this.maGVRadioBtn.AutoSize = true;
            this.maGVRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maGVRadioBtn.Location = new System.Drawing.Point(701, 17);
            this.maGVRadioBtn.Name = "maGVRadioBtn";
            this.maGVRadioBtn.Size = new System.Drawing.Size(82, 24);
            this.maGVRadioBtn.TabIndex = 32;
            this.maGVRadioBtn.Text = "Mã GV";
            this.maGVRadioBtn.UseVisualStyleBackColor = true;
            // 
            // findGVTxt
            // 
            this.findGVTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findGVTxt.Location = new System.Drawing.Point(799, 16);
            this.findGVTxt.Name = "findGVTxt";
            this.findGVTxt.Size = new System.Drawing.Size(262, 27);
            this.findGVTxt.TabIndex = 31;
            // 
            // findGVBtn
            // 
            this.findGVBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(86)))), ((int)(((byte)(182)))));
            this.findGVBtn.FlatAppearance.BorderSize = 0;
            this.findGVBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findGVBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findGVBtn.ForeColor = System.Drawing.Color.White;
            this.findGVBtn.Location = new System.Drawing.Point(1067, 14);
            this.findGVBtn.Name = "findGVBtn";
            this.findGVBtn.Size = new System.Drawing.Size(73, 32);
            this.findGVBtn.TabIndex = 29;
            this.findGVBtn.Text = "Tìm";
            this.findGVBtn.UseVisualStyleBackColor = false;
            this.findGVBtn.Click += new System.EventHandler(this.findGVBtn_Click);
            // 
            // frmBieuDoKetQuaGiangDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1192, 661);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmBieuDoKetQuaGiangDay";
            this.Text = "frmBieuDoKetQuaGiangDay";
            this.Load += new System.EventHandler(this.frmBieuDoKetQuaGiangDay_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bieuDoChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocDGV)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVBieuDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView monHocDGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart bieuDoChart;
        private System.Windows.Forms.ComboBox cbbLoaiBieuDo;
        private System.Windows.Forms.ComboBox cbbLoaiBieuDoGV;
        private System.Windows.Forms.DataVisualization.Charting.Chart GVBieuDo;
        private System.Windows.Forms.DataGridView gvDGV;
        private System.Windows.Forms.Label gvTabLbl;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox hkCbb;
        private System.Windows.Forms.RadioButton tenGVRadioBtn;
        private System.Windows.Forms.RadioButton maGVRadioBtn;
        private System.Windows.Forms.TextBox findGVTxt;
        private System.Windows.Forms.Button findGVBtn;
    }
}