namespace QLKetQuaGiangDay
{
    partial class frmXemDiem
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.titleLbl = new System.Windows.Forms.Label();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.changeChartBtn = new System.Windows.Forms.Button();
            this.cbbLoaiBieuDo = new System.Windows.Forms.ComboBox();
            this.cbbChonBieuDo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(16, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(95, 25);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Thống kê";
            // 
            // dgvDetail
            // 
            this.dgvDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Location = new System.Drawing.Point(21, 37);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.RowHeadersWidth = 51;
            this.dgvDetail.RowTemplate.Height = 24;
            this.dgvDetail.Size = new System.Drawing.Size(1144, 161);
            this.dgvDetail.TabIndex = 1;
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
            this.Chart.Location = new System.Drawing.Point(21, 529);
            this.Chart.Name = "Chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Chart.Series.Add(series1);
            this.Chart.Size = new System.Drawing.Size(1144, 329);
            this.Chart.TabIndex = 2;
            this.Chart.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.changeChartBtn);
            this.groupBox1.Controls.Add(this.cbbLoaiBieuDo);
            this.groupBox1.Controls.Add(this.cbbChonBieuDo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 186);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // changeChartBtn
            // 
            this.changeChartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(86)))), ((int)(((byte)(182)))));
            this.changeChartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeChartBtn.ForeColor = System.Drawing.Color.White;
            this.changeChartBtn.Location = new System.Drawing.Point(254, 134);
            this.changeChartBtn.Name = "changeChartBtn";
            this.changeChartBtn.Size = new System.Drawing.Size(80, 38);
            this.changeChartBtn.TabIndex = 4;
            this.changeChartBtn.Text = "Nhập";
            this.changeChartBtn.UseVisualStyleBackColor = false;
            this.changeChartBtn.Click += new System.EventHandler(this.changeChartBtn_Click);
            // 
            // cbbLoaiBieuDo
            // 
            this.cbbLoaiBieuDo.FormattingEnabled = true;
            this.cbbLoaiBieuDo.Items.AddRange(new object[] {
            "Biểu đồ dạng Column",
            "Biểu đồ dạng Area",
            "Biểu đồ Spline Area"});
            this.cbbLoaiBieuDo.Location = new System.Drawing.Point(126, 85);
            this.cbbLoaiBieuDo.Name = "cbbLoaiBieuDo";
            this.cbbLoaiBieuDo.Size = new System.Drawing.Size(208, 28);
            this.cbbLoaiBieuDo.TabIndex = 3;
            // 
            // cbbChonBieuDo
            // 
            this.cbbChonBieuDo.FormattingEnabled = true;
            this.cbbChonBieuDo.Items.AddRange(new object[] {
            "Số lượng",
            "Tỷ Lệ"});
            this.cbbChonBieuDo.Location = new System.Drawing.Point(122, 39);
            this.cbbChonBieuDo.Name = "cbbChonBieuDo";
            this.cbbChonBieuDo.Size = new System.Drawing.Size(212, 28);
            this.cbbChonBieuDo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dữ liệu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loại biểu đồ:";
            // 
            // pieChart
            // 
            this.pieChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pieChart.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea2.Name = "ChartArea1";
            this.pieChart.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            this.pieChart.Legends.Add(legend2);
            this.pieChart.Location = new System.Drawing.Point(781, 215);
            this.pieChart.Name = "pieChart";
            this.pieChart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.pieChart.Series.Add(series2);
            this.pieChart.Size = new System.Drawing.Size(384, 284);
            this.pieChart.TabIndex = 7;
            this.pieChart.Text = "chart3";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
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
            this.groupBox2.Location = new System.Drawing.Point(404, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 284);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // lopLbl
            // 
            this.lopLbl.AutoSize = true;
            this.lopLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lopLbl.Location = new System.Drawing.Point(253, 226);
            this.lopLbl.Name = "lopLbl";
            this.lopLbl.Size = new System.Drawing.Size(93, 20);
            this.lopLbl.TabIndex = 16;
            this.lopLbl.Text = "Giảng viên:";
            // 
            // slsvLbl
            // 
            this.slsvLbl.AutoSize = true;
            this.slsvLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slsvLbl.Location = new System.Drawing.Point(64, 226);
            this.slsvLbl.Name = "slsvLbl";
            this.slsvLbl.Size = new System.Drawing.Size(93, 20);
            this.slsvLbl.TabIndex = 15;
            this.slsvLbl.Text = "Giảng viên:";
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
            this.lopFixLbl.Location = new System.Drawing.Point(163, 226);
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
            // frmXemDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1192, 884);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pieChart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Chart);
            this.Controls.Add(this.dgvDetail);
            this.Controls.Add(this.titleLbl);
            this.Name = "frmXemDiem";
            this.Text = "frmXemDiem";
            this.Load += new System.EventHandler(this.frmXemDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button changeChartBtn;
        private System.Windows.Forms.ComboBox cbbLoaiBieuDo;
        private System.Windows.Forms.ComboBox cbbChonBieuDo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieChart;
        private System.Windows.Forms.GroupBox groupBox2;
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
    }
}