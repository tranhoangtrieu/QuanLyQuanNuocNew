namespace QuanLyQuanNuoc
{
    partial class NhapMatKhauMoi
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
            this.txt_newPassWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_checkPassWord = new System.Windows.Forms.TextBox();
            this.btn_Yes = new System.Windows.Forms.Button();
            this.btn_No = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cấp lại mật khẩu mới";
            // 
            // txt_newPassWord
            // 
            this.txt_newPassWord.Location = new System.Drawing.Point(136, 80);
            this.txt_newPassWord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_newPassWord.Name = "txt_newPassWord";
            this.txt_newPassWord.Size = new System.Drawing.Size(119, 20);
            this.txt_newPassWord.TabIndex = 1;
            this.txt_newPassWord.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhập lại mật khẩu";
            // 
            // txt_checkPassWord
            // 
            this.txt_checkPassWord.Location = new System.Drawing.Point(136, 124);
            this.txt_checkPassWord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_checkPassWord.Name = "txt_checkPassWord";
            this.txt_checkPassWord.Size = new System.Drawing.Size(119, 20);
            this.txt_checkPassWord.TabIndex = 3;
            this.txt_checkPassWord.UseSystemPasswordChar = true;
            // 
            // btn_Yes
            // 
            this.btn_Yes.ForeColor = System.Drawing.Color.Black;
            this.btn_Yes.Location = new System.Drawing.Point(168, 166);
            this.btn_Yes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Yes.Name = "btn_Yes";
            this.btn_Yes.Size = new System.Drawing.Size(66, 32);
            this.btn_Yes.TabIndex = 19;
            this.btn_Yes.Text = "Xác nhận";
            this.btn_Yes.UseVisualStyleBackColor = true;
            this.btn_Yes.Click += new System.EventHandler(this.btn_Yes_Click);
            // 
            // btn_No
            // 
            this.btn_No.ForeColor = System.Drawing.Color.Black;
            this.btn_No.Location = new System.Drawing.Point(249, 166);
            this.btn_No.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_No.Name = "btn_No";
            this.btn_No.Size = new System.Drawing.Size(63, 32);
            this.btn_No.TabIndex = 18;
            this.btn_No.Text = "Hủy";
            this.btn_No.UseVisualStyleBackColor = true;
            this.btn_No.Click += new System.EventHandler(this.btn_No_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(279, 81);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(55, 19);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Hiện";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // NhapMatKhauMoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 221);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btn_Yes);
            this.Controls.Add(this.btn_No);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_checkPassWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_newPassWord);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NhapMatKhauMoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NhapMatKhauMoi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_newPassWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_checkPassWord;
        private System.Windows.Forms.Button btn_Yes;
        private System.Windows.Forms.Button btn_No;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}