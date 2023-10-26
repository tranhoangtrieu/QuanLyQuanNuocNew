namespace QuanLyQuanNuoc
{
    partial class ChiTietHoaDon
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
            this.datagrv_chitiethoadon = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datagrv_chitiethoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrv_chitiethoadon
            // 
            this.datagrv_chitiethoadon.AllowUserToAddRows = false;
            this.datagrv_chitiethoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrv_chitiethoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrv_chitiethoadon.Location = new System.Drawing.Point(30, 84);
            this.datagrv_chitiethoadon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datagrv_chitiethoadon.Name = "datagrv_chitiethoadon";
            this.datagrv_chitiethoadon.RowHeadersWidth = 51;
            this.datagrv_chitiethoadon.RowTemplate.Height = 24;
            this.datagrv_chitiethoadon.Size = new System.Drawing.Size(545, 262);
            this.datagrv_chitiethoadon.TabIndex = 0;
            // 
            // ChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.datagrv_chitiethoadon);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ChiTietHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChiTietHoaDon";
            ((System.ComponentModel.ISupportInitialize)(this.datagrv_chitiethoadon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrv_chitiethoadon;
    }
}