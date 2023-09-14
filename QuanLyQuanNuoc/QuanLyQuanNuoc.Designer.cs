namespace QuanLyQuanNuoc
{
    partial class QuanLyQuanNuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyQuanNuoc));
            this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_showbill = new System.Windows.Forms.ListView();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_themmon = new System.Windows.Forms.Button();
            this.cbb_loaidoan = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_monan = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_giatien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numUD_giamgia = new System.Windows.Forms.NumericUpDown();
            this.btn_thanhtoan = new System.Windows.Forms.Button();
            this.fLP_banan = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numUD_slmon = new System.Windows.Forms.NumericUpDown();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_huyBan = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_XoaMon = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label3 = new System.Windows.Forms.Label();
            this.datagrv_menu = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_giamgia)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_slmon)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrv_menu)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xToolStripMenuItem
            // 
            this.xToolStripMenuItem.Name = "xToolStripMenuItem";
            this.xToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.xToolStripMenuItem.Text = "Menu";
            this.xToolStripMenuItem.Click += new System.EventHandler(this.xToolStripMenuItem_Click);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 75;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 75;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 100;
            // 
            // lv_showbill
            // 
            this.lv_showbill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lv_showbill.GridLines = true;
            this.lv_showbill.HideSelection = false;
            this.lv_showbill.Location = new System.Drawing.Point(3, 3);
            this.lv_showbill.Name = "lv_showbill";
            this.lv_showbill.Size = new System.Drawing.Size(446, 280);
            this.lv_showbill.TabIndex = 0;
            this.lv_showbill.UseCompatibleStateImageBehavior = false;
            this.lv_showbill.View = System.Windows.Forms.View.Details;
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.adminToolStripMenuItem.Text = "admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // btn_themmon
            // 
            this.btn_themmon.Location = new System.Drawing.Point(386, 32);
            this.btn_themmon.Name = "btn_themmon";
            this.btn_themmon.Size = new System.Drawing.Size(87, 53);
            this.btn_themmon.TabIndex = 2;
            this.btn_themmon.Text = "Thêm món";
            this.btn_themmon.UseVisualStyleBackColor = true;
            this.btn_themmon.Click += new System.EventHandler(this.btn_themmon_Click);
            // 
            // cbb_loaidoan
            // 
            this.cbb_loaidoan.FormattingEnabled = true;
            this.cbb_loaidoan.Location = new System.Drawing.Point(84, 26);
            this.cbb_loaidoan.Name = "cbb_loaidoan";
            this.cbb_loaidoan.Size = new System.Drawing.Size(176, 24);
            this.cbb_loaidoan.TabIndex = 0;
            this.cbb_loaidoan.SelectedIndexChanged += new System.EventHandler(this.comboBox_loaidoan_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(268, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Giảm giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Số lượng";
            // 
            // cbb_monan
            // 
            this.cbb_monan.FormattingEnabled = true;
            this.cbb_monan.Location = new System.Drawing.Point(84, 81);
            this.cbb_monan.Name = "cbb_monan";
            this.cbb_monan.Size = new System.Drawing.Size(176, 24);
            this.cbb_monan.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(341, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "%";
            // 
            // textBox_giatien
            // 
            this.textBox_giatien.Location = new System.Drawing.Point(354, 47);
            this.textBox_giatien.Name = "textBox_giatien";
            this.textBox_giatien.ReadOnly = true;
            this.textBox_giatien.Size = new System.Drawing.Size(125, 22);
            this.textBox_giatien.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Giá tiền";
            // 
            // numUD_giamgia
            // 
            this.numUD_giamgia.Location = new System.Drawing.Point(262, 85);
            this.numUD_giamgia.Name = "numUD_giamgia";
            this.numUD_giamgia.Size = new System.Drawing.Size(73, 22);
            this.numUD_giamgia.TabIndex = 7;
            // 
            // btn_thanhtoan
            // 
            this.btn_thanhtoan.Location = new System.Drawing.Point(375, 85);
            this.btn_thanhtoan.Name = "btn_thanhtoan";
            this.btn_thanhtoan.Size = new System.Drawing.Size(104, 57);
            this.btn_thanhtoan.TabIndex = 3;
            this.btn_thanhtoan.Text = "Thanh toán";
            this.btn_thanhtoan.UseVisualStyleBackColor = true;
            this.btn_thanhtoan.Click += new System.EventHandler(this.btn_thanhtoan_Click);
            // 
            // fLP_banan
            // 
            this.fLP_banan.AutoScroll = true;
            this.fLP_banan.Location = new System.Drawing.Point(530, 85);
            this.fLP_banan.Name = "fLP_banan";
            this.fLP_banan.Size = new System.Drawing.Size(917, 195);
            this.fLP_banan.TabIndex = 16;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.cbb_monan);
            this.panel5.Controls.Add(this.numUD_slmon);
            this.panel5.Controls.Add(this.btn_themmon);
            this.panel5.Controls.Add(this.cbb_loaidoan);
            this.panel5.Location = new System.Drawing.Point(988, 282);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(477, 118);
            this.panel5.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Tên món ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Loại đồ ăn";
            // 
            // numUD_slmon
            // 
            this.numUD_slmon.Location = new System.Drawing.Point(314, 72);
            this.numUD_slmon.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numUD_slmon.Name = "numUD_slmon";
            this.numUD_slmon.Size = new System.Drawing.Size(57, 22);
            this.numUD_slmon.TabIndex = 3;
            this.numUD_slmon.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.btn_huyBan);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.btn_XoaMon);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.textBox_giatien);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.numUD_giamgia);
            this.panel4.Controls.Add(this.btn_thanhtoan);
            this.panel4.Location = new System.Drawing.Point(982, 409);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(484, 163);
            this.panel4.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 36);
            this.label7.TabIndex = 23;
            this.label7.Text = "Chọn bàn bạn \r\nmuốn hủy";
            // 
            // btn_huyBan
            // 
            this.btn_huyBan.Location = new System.Drawing.Point(24, 75);
            this.btn_huyBan.Name = "btn_huyBan";
            this.btn_huyBan.Size = new System.Drawing.Size(50, 33);
            this.btn_huyBan.TabIndex = 22;
            this.btn_huyBan.Text = "Hủy";
            this.btn_huyBan.UseVisualStyleBackColor = true;
            this.btn_huyBan.Click += new System.EventHandler(this.btn_huyBan_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(136, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 36);
            this.label6.TabIndex = 21;
            this.label6.Text = "Chọn món bạn \r\nmuốn xóa";
            // 
            // btn_XoaMon
            // 
            this.btn_XoaMon.Location = new System.Drawing.Point(157, 75);
            this.btn_XoaMon.Name = "btn_XoaMon";
            this.btn_XoaMon.Size = new System.Drawing.Size(50, 33);
            this.btn_XoaMon.TabIndex = 20;
            this.btn_XoaMon.Text = "Xóa";
            this.btn_XoaMon.UseVisualStyleBackColor = true;
            this.btn_XoaMon.Click += new System.EventHandler(this.btn_XoaMon_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lv_showbill);
            this.panel3.Location = new System.Drawing.Point(507, 286);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(469, 290);
            this.panel3.TabIndex = 13;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.xToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1477, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(552, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(435, 36);
            this.label3.TabIndex = 17;
            this.label3.Text = "Phần mềm quản lý quán nước";
            // 
            // datagrv_menu
            // 
            this.datagrv_menu.AllowUserToAddRows = false;
            this.datagrv_menu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrv_menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrv_menu.Location = new System.Drawing.Point(3, 11);
            this.datagrv_menu.Name = "datagrv_menu";
            this.datagrv_menu.RowHeadersWidth = 51;
            this.datagrv_menu.RowTemplate.Height = 24;
            this.datagrv_menu.Size = new System.Drawing.Size(475, 467);
            this.datagrv_menu.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.datagrv_menu);
            this.panel1.Location = new System.Drawing.Point(12, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 481);
            this.panel1.TabIndex = 19;
            // 
            // QuanLyQuanNuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 588);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fLP_banan);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuanLyQuanNuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyQuanNuoc";
            ((System.ComponentModel.ISupportInitialize)(this.numUD_giamgia)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_slmon)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrv_menu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView lv_showbill;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.Button btn_themmon;
        private System.Windows.Forms.ComboBox cbb_loaidoan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_monan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_giatien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numUD_giamgia;
        private System.Windows.Forms.Button btn_thanhtoan;
        private System.Windows.Forms.FlowLayoutPanel fLP_banan;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.NumericUpDown numUD_slmon;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView datagrv_menu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_XoaMon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_huyBan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}