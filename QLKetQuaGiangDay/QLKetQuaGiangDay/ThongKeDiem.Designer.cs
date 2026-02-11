namespace QLKetQuaGiangDay
{
    partial class ThongKeDiem
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TheoLopChk = new System.Windows.Forms.CheckBox();
            this.getDataBtn = new System.Windows.Forms.Button();
            this.hkktCbb = new System.Windows.Forms.ComboBox();
            this.hkbdCbb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.monHoctxt = new System.Windows.Forms.TextBox();
            this.gvTxt = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.LopTxt = new System.Windows.Forms.TextBox();
            this.LopLbl = new System.Windows.Forms.Label();
            this.findBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.displayDgv = new System.Windows.Forms.DataGridView();
            this.gkBtn = new System.Windows.Forms.Button();
            this.ckBtn = new System.Windows.Forms.Button();
            this.tongKetBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Học kì bắt đầu:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.TheoLopChk);
            this.groupBox1.Controls.Add(this.getDataBtn);
            this.groupBox1.Controls.Add(this.hkktCbb);
            this.groupBox1.Controls.Add(this.hkbdCbb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 151);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // TheoLopChk
            // 
            this.TheoLopChk.AutoSize = true;
            this.TheoLopChk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TheoLopChk.Location = new System.Drawing.Point(157, 121);
            this.TheoLopChk.Name = "TheoLopChk";
            this.TheoLopChk.Size = new System.Drawing.Size(159, 24);
            this.TheoLopChk.TabIndex = 5;
            this.TheoLopChk.Text = "Thống kê theo lớp";
            this.TheoLopChk.UseVisualStyleBackColor = true;
            // 
            // getDataBtn
            // 
            this.getDataBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(86)))), ((int)(((byte)(182)))));
            this.getDataBtn.FlatAppearance.BorderSize = 0;
            this.getDataBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getDataBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.getDataBtn.Location = new System.Drawing.Point(383, 68);
            this.getDataBtn.Name = "getDataBtn";
            this.getDataBtn.Size = new System.Drawing.Size(80, 38);
            this.getDataBtn.TabIndex = 4;
            this.getDataBtn.Text = "Nhập";
            this.getDataBtn.UseVisualStyleBackColor = false;
            this.getDataBtn.Click += new System.EventHandler(this.getDataBtn_Click);
            // 
            // hkktCbb
            // 
            this.hkktCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hkktCbb.FormattingEnabled = true;
            this.hkktCbb.Location = new System.Drawing.Point(157, 78);
            this.hkktCbb.Name = "hkktCbb";
            this.hkktCbb.Size = new System.Drawing.Size(193, 28);
            this.hkktCbb.TabIndex = 3;
            // 
            // hkbdCbb
            // 
            this.hkbdCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hkbdCbb.FormattingEnabled = true;
            this.hkbdCbb.Location = new System.Drawing.Point(157, 34);
            this.hkbdCbb.Name = "hkbdCbb";
            this.hkbdCbb.Size = new System.Drawing.Size(193, 28);
            this.hkbdCbb.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Học kì kết thúc:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.monHoctxt);
            this.groupBox2.Controls.Add(this.gvTxt);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.LopTxt);
            this.groupBox2.Controls.Add(this.LopLbl);
            this.groupBox2.Controls.Add(this.findBtn);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(755, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 221);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // monHoctxt
            // 
            this.monHoctxt.Location = new System.Drawing.Point(114, 39);
            this.monHoctxt.Name = "monHoctxt";
            this.monHoctxt.Size = new System.Drawing.Size(340, 27);
            this.monHoctxt.TabIndex = 9;
            // 
            // gvTxt
            // 
            this.gvTxt.Location = new System.Drawing.Point(114, 83);
            this.gvTxt.Name = "gvTxt";
            this.gvTxt.Size = new System.Drawing.Size(299, 27);
            this.gvTxt.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(86)))), ((int)(((byte)(182)))));
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(86)))), ((int)(((byte)(182)))));
            this.button3.Location = new System.Drawing.Point(277, 171);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 38);
            this.button3.TabIndex = 7;
            this.button3.Text = "Đặt lại";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // LopTxt
            // 
            this.LopTxt.Location = new System.Drawing.Point(114, 124);
            this.LopTxt.Name = "LopTxt";
            this.LopTxt.Size = new System.Drawing.Size(195, 27);
            this.LopTxt.TabIndex = 6;
            // 
            // LopLbl
            // 
            this.LopLbl.AutoSize = true;
            this.LopLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LopLbl.Location = new System.Drawing.Point(15, 131);
            this.LopLbl.Name = "LopLbl";
            this.LopLbl.Size = new System.Drawing.Size(42, 20);
            this.LopLbl.TabIndex = 5;
            this.LopLbl.Text = "Lớp:";
            // 
            // findBtn
            // 
            this.findBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(86)))), ((int)(((byte)(182)))));
            this.findBtn.FlatAppearance.BorderSize = 0;
            this.findBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.findBtn.Location = new System.Drawing.Point(374, 171);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(80, 38);
            this.findBtn.TabIndex = 4;
            this.findBtn.Text = "Tìm";
            this.findBtn.UseVisualStyleBackColor = false;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Giảng viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Môn học:";
            // 
            // displayDgv
            // 
            this.displayDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayDgv.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.displayDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayDgv.Location = new System.Drawing.Point(12, 275);
            this.displayDgv.Name = "displayDgv";
            this.displayDgv.RowHeadersWidth = 51;
            this.displayDgv.RowTemplate.Height = 24;
            this.displayDgv.Size = new System.Drawing.Size(1218, 455);
            this.displayDgv.TabIndex = 3;
            this.displayDgv.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.displayDgv_CellMouseClick);
            // 
            // gkBtn
            // 
            this.gkBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(86)))), ((int)(((byte)(182)))));
            this.gkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gkBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gkBtn.Location = new System.Drawing.Point(12, 232);
            this.gkBtn.Name = "gkBtn";
            this.gkBtn.Size = new System.Drawing.Size(120, 37);
            this.gkBtn.TabIndex = 5;
            this.gkBtn.Text = "Điểm giữa kì";
            this.gkBtn.UseVisualStyleBackColor = false;
            this.gkBtn.Click += new System.EventHandler(this.gkBtn_Click);
            // 
            // ckBtn
            // 
            this.ckBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(86)))), ((int)(((byte)(182)))));
            this.ckBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ckBtn.Location = new System.Drawing.Point(148, 232);
            this.ckBtn.Name = "ckBtn";
            this.ckBtn.Size = new System.Drawing.Size(120, 37);
            this.ckBtn.TabIndex = 6;
            this.ckBtn.Text = "Điểm cuối kì";
            this.ckBtn.UseVisualStyleBackColor = false;
            this.ckBtn.Click += new System.EventHandler(this.ckBtn_Click);
            // 
            // tongKetBtn
            // 
            this.tongKetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(86)))), ((int)(((byte)(182)))));
            this.tongKetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tongKetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tongKetBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tongKetBtn.Location = new System.Drawing.Point(285, 232);
            this.tongKetBtn.Name = "tongKetBtn";
            this.tongKetBtn.Size = new System.Drawing.Size(149, 37);
            this.tongKetBtn.TabIndex = 7;
            this.tongKetBtn.Text = "Điểm tổng kết";
            this.tongKetBtn.UseVisualStyleBackColor = false;
            this.tongKetBtn.Click += new System.EventHandler(this.tongKetBtn_Click);
            // 
            // ThongKeDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1242, 742);
            this.Controls.Add(this.tongKetBtn);
            this.Controls.Add(this.ckBtn);
            this.Controls.Add(this.gkBtn);
            this.Controls.Add(this.displayDgv);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ThongKeDiem";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button getDataBtn;
        private System.Windows.Forms.ComboBox hkktCbb;
        private System.Windows.Forms.ComboBox hkbdCbb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox LopTxt;
        private System.Windows.Forms.Label LopLbl;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView displayDgv;
        private System.Windows.Forms.Button gkBtn;
        private System.Windows.Forms.CheckBox TheoLopChk;
        private System.Windows.Forms.Button ckBtn;
        private System.Windows.Forms.Button tongKetBtn;
        private System.Windows.Forms.TextBox monHoctxt;
        private System.Windows.Forms.TextBox gvTxt;
    }
}