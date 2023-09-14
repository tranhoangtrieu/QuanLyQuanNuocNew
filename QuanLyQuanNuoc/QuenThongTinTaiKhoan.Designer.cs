namespace QuanLyQuanNuoc
{
    partial class QuenThongTinTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuenThongTinTaiKhoan));
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_CauHoi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_answer = new System.Windows.Forms.TextBox();
            this.btn_No = new System.Windows.Forms.Button();
            this.btn_Yes = new System.Windows.Forms.Button();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(45, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quên thì chịu chứ biết sao giờ";
            // 
            // cbb_CauHoi
            // 
            this.cbb_CauHoi.FormattingEnabled = true;
            this.cbb_CauHoi.Location = new System.Drawing.Point(141, 144);
            this.cbb_CauHoi.Name = "cbb_CauHoi";
            this.cbb_CauHoi.Size = new System.Drawing.Size(192, 24);
            this.cbb_CauHoi.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(18, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Câu hỏi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(18, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Câu trả lời";
            // 
            // txt_answer
            // 
            this.txt_answer.Location = new System.Drawing.Point(141, 195);
            this.txt_answer.Name = "txt_answer";
            this.txt_answer.Size = new System.Drawing.Size(121, 22);
            this.txt_answer.TabIndex = 14;
            // 
            // btn_No
            // 
            this.btn_No.ForeColor = System.Drawing.Color.Black;
            this.btn_No.Location = new System.Drawing.Point(339, 262);
            this.btn_No.Name = "btn_No";
            this.btn_No.Size = new System.Drawing.Size(84, 39);
            this.btn_No.TabIndex = 16;
            this.btn_No.Text = "Hủy";
            this.btn_No.UseVisualStyleBackColor = true;
            this.btn_No.Click += new System.EventHandler(this.btn_No_Click);
            // 
            // btn_Yes
            // 
            this.btn_Yes.ForeColor = System.Drawing.Color.Black;
            this.btn_Yes.Location = new System.Drawing.Point(231, 262);
            this.btn_Yes.Name = "btn_Yes";
            this.btn_Yes.Size = new System.Drawing.Size(88, 39);
            this.btn_Yes.TabIndex = 17;
            this.btn_Yes.Text = "Xác nhận";
            this.btn_Yes.UseVisualStyleBackColor = true;
            this.btn_Yes.Click += new System.EventHandler(this.btn_Yes_Click);
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(141, 89);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(121, 22);
            this.txt_username.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(19, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tên tài khoản";
            // 
            // QuenThongTinTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 339);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Yes);
            this.Controls.Add(this.btn_No);
            this.Controls.Add(this.txt_answer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbb_CauHoi);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuenThongTinTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuenThongTinTaiKhoan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_CauHoi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_answer;
        private System.Windows.Forms.Button btn_No;
        private System.Windows.Forms.Button btn_Yes;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label3;
    }
}