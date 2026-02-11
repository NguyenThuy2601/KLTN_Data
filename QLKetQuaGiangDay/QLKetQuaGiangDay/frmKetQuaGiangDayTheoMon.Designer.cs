namespace QLKetQuaGiangDay
{
    partial class frmKetQuaGiangDayTheoMon
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.findMHTxt = new System.Windows.Forms.TextBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.findMHLbl = new System.Windows.Forms.Label();
            this.hkktCbb = new System.Windows.Forms.ComboBox();
            this.hkbdCbb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.findBtn = new System.Windows.Forms.Button();
            this.tenMHRadioBtn = new System.Windows.Forms.RadioButton();
            this.mMHRadioBtn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.setHkBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.displayDgv = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.detailChkBox = new System.Windows.Forms.CheckBox();
            this.cbbLoaiBieuDo = new System.Windows.Forms.ComboBox();
            this.bieuDoChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.monHocDGV = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayDgv)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bieuDoChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // findMHTxt
            // 
            this.findMHTxt.Location = new System.Drawing.Point(98, 51);
            this.findMHTxt.Name = "findMHTxt";
            this.findMHTxt.Size = new System.Drawing.Size(347, 27);
            this.findMHTxt.TabIndex = 9;
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.White;
            this.resetBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(86)))), ((int)(((byte)(182)))));
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(86)))), ((int)(((byte)(182)))));
            this.resetBtn.Location = new System.Drawing.Point(365, 83);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(80, 35);
            this.resetBtn.TabIndex = 7;
            this.resetBtn.Text = "Đặt lại";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // findMHLbl
            // 
            this.findMHLbl.AutoSize = true;
            this.findMHLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findMHLbl.Location = new System.Drawing.Point(6, 54);
            this.findMHLbl.Name = "findMHLbl";
            this.findMHLbl.Size = new System.Drawing.Size(79, 20);
            this.findMHLbl.TabIndex = 0;
            this.findMHLbl.Text = "Tên môn:";
            // 
            // hkktCbb
            // 
            this.hkktCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hkktCbb.FormattingEnabled = true;
            this.hkktCbb.Location = new System.Drawing.Point(144, 72);
            this.hkktCbb.Name = "hkktCbb";
            this.hkktCbb.Size = new System.Drawing.Size(186, 28);
            this.hkktCbb.TabIndex = 9;
            // 
            // hkbdCbb
            // 
            this.hkbdCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hkbdCbb.FormattingEnabled = true;
            this.hkbdCbb.Location = new System.Drawing.Point(144, 31);
            this.hkbdCbb.Name = "hkbdCbb";
            this.hkbdCbb.Size = new System.Drawing.Size(186, 28);
            this.hkbdCbb.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Học kì kết thúc:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Học kì bắt đầu:";
            // 
            // findBtn
            // 
            this.findBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(86)))), ((int)(((byte)(182)))));
            this.findBtn.FlatAppearance.BorderSize = 0;
            this.findBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findBtn.ForeColor = System.Drawing.Color.White;
            this.findBtn.Location = new System.Drawing.Point(286, 84);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(73, 34);
            this.findBtn.TabIndex = 14;
            this.findBtn.Text = "Tìm";
            this.findBtn.UseVisualStyleBackColor = false;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // tenMHRadioBtn
            // 
            this.tenMHRadioBtn.AutoSize = true;
            this.tenMHRadioBtn.Checked = true;
            this.tenMHRadioBtn.Location = new System.Drawing.Point(235, 21);
            this.tenMHRadioBtn.Name = "tenMHRadioBtn";
            this.tenMHRadioBtn.Size = new System.Drawing.Size(95, 24);
            this.tenMHRadioBtn.TabIndex = 11;
            this.tenMHRadioBtn.TabStop = true;
            this.tenMHRadioBtn.Text = "Tên môn";
            this.tenMHRadioBtn.UseVisualStyleBackColor = true;
            this.tenMHRadioBtn.CheckedChanged += new System.EventHandler(this.tenMHRadioBtn_CheckedChanged);
            // 
            // mMHRadioBtn
            // 
            this.mMHRadioBtn.AutoSize = true;
            this.mMHRadioBtn.Location = new System.Drawing.Point(344, 21);
            this.mMHRadioBtn.Name = "mMHRadioBtn";
            this.mMHRadioBtn.Size = new System.Drawing.Size(90, 24);
            this.mMHRadioBtn.TabIndex = 10;
            this.mMHRadioBtn.Text = "Mã môn";
            this.mMHRadioBtn.UseVisualStyleBackColor = true;
            this.mMHRadioBtn.CheckedChanged += new System.EventHandler(this.mMHRadioBtn_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.setHkBtn);
            this.groupBox1.Controls.Add(this.hkktCbb);
            this.groupBox1.Controls.Add(this.hkbdCbb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 122);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cài đặt";
            // 
            // setHkBtn
            // 
            this.setHkBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(86)))), ((int)(((byte)(182)))));
            this.setHkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setHkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setHkBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.setHkBtn.Location = new System.Drawing.Point(359, 66);
            this.setHkBtn.Name = "setHkBtn";
            this.setHkBtn.Size = new System.Drawing.Size(86, 38);
            this.setHkBtn.TabIndex = 13;
            this.setHkBtn.Text = "Nhập";
            this.setHkBtn.UseVisualStyleBackColor = false;
            this.setHkBtn.Click += new System.EventHandler(this.getDataBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.displayDgv);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(484, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 258);
            this.panel1.TabIndex = 15;
            // 
            // displayDgv
            // 
            this.displayDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.displayDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayDgv.Location = new System.Drawing.Point(8, 43);
            this.displayDgv.Name = "displayDgv";
            this.displayDgv.RowHeadersWidth = 51;
            this.displayDgv.RowTemplate.Height = 24;
            this.displayDgv.Size = new System.Drawing.Size(727, 203);
            this.displayDgv.TabIndex = 13;
            this.displayDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.displayDgv_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(518, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Chọn 1 môn để xem biểu đồ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Danh sách môn";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.resetBtn);
            this.groupBox2.Controls.Add(this.findBtn);
            this.groupBox2.Controls.Add(this.findMHTxt);
            this.groupBox2.Controls.Add(this.mMHRadioBtn);
            this.groupBox2.Controls.Add(this.tenMHRadioBtn);
            this.groupBox2.Controls.Add(this.findMHLbl);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(466, 130);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.detailChkBox);
            this.panel2.Controls.Add(this.cbbLoaiBieuDo);
            this.panel2.Controls.Add(this.bieuDoChart);
            this.panel2.Controls.Add(this.monHocDGV);
            this.panel2.Location = new System.Drawing.Point(12, 276);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1218, 454);
            this.panel2.TabIndex = 17;
            // 
            // detailChkBox
            // 
            this.detailChkBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.detailChkBox.AutoSize = true;
            this.detailChkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailChkBox.Location = new System.Drawing.Point(304, 124);
            this.detailChkBox.Name = "detailChkBox";
            this.detailChkBox.Size = new System.Drawing.Size(301, 24);
            this.detailChkBox.TabIndex = 15;
            this.detailChkBox.Text = "Xem chi tiết tỷ lệ quá trình và cuối kì";
            this.detailChkBox.UseVisualStyleBackColor = true;
            this.detailChkBox.Click += new System.EventHandler(this.detailChkBox_Click);
            // 
            // cbbLoaiBieuDo
            // 
            this.cbbLoaiBieuDo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbbLoaiBieuDo.FormattingEnabled = true;
            this.cbbLoaiBieuDo.Items.AddRange(new object[] {
            "Biểu đồ dạng Column",
            "Biểu đồ dạng Bar",
            "Biểu đồ Point"});
            this.cbbLoaiBieuDo.Location = new System.Drawing.Point(10, 124);
            this.cbbLoaiBieuDo.Name = "cbbLoaiBieuDo";
            this.cbbLoaiBieuDo.Size = new System.Drawing.Size(253, 24);
            this.cbbLoaiBieuDo.TabIndex = 26;
            this.cbbLoaiBieuDo.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiBieuDo_SelectedIndexChanged);
            // 
            // bieuDoChart
            // 
            this.bieuDoChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.bieuDoChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.bieuDoChart.Legends.Add(legend2);
            this.bieuDoChart.Location = new System.Drawing.Point(10, 154);
            this.bieuDoChart.Name = "bieuDoChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.bieuDoChart.Series.Add(series2);
            this.bieuDoChart.Size = new System.Drawing.Size(1197, 282);
            this.bieuDoChart.TabIndex = 25;
            this.bieuDoChart.Text = "chart1";
            // 
            // monHocDGV
            // 
            this.monHocDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monHocDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.monHocDGV.Location = new System.Drawing.Point(10, 13);
            this.monHocDGV.Name = "monHocDGV";
            this.monHocDGV.RowHeadersWidth = 51;
            this.monHocDGV.RowTemplate.Height = 24;
            this.monHocDGV.Size = new System.Drawing.Size(1197, 105);
            this.monHocDGV.TabIndex = 24;
            // 
            // frmKetQuaGiangDayTheoMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1242, 742);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmKetQuaGiangDayTheoMon";
            this.Text = "frmKetQuaGiangDay";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKetQuaGiangDayTheoMon_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmKetQuaGiangDayTheoMon_FormClosed);
            this.Load += new System.EventHandler(this.frmKetQuaGiangDay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayDgv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bieuDoChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox findMHTxt;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label findMHLbl;
        private System.Windows.Forms.ComboBox hkktCbb;
        private System.Windows.Forms.ComboBox hkbdCbb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton tenMHRadioBtn;
        private System.Windows.Forms.RadioButton mMHRadioBtn;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button setHkBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView displayDgv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbbLoaiBieuDo;
        private System.Windows.Forms.DataVisualization.Charting.Chart bieuDoChart;
        private System.Windows.Forms.DataGridView monHocDGV;
        private System.Windows.Forms.CheckBox detailChkBox;
    }
}