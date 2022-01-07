
namespace ThiCSLT2.Forms
{
    partial class frmtimkiemnhacungcap
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
            this.label2 = new System.Windows.Forms.Label();
            this.btndong = new System.Windows.Forms.Button();
            this.btntimlai = new System.Windows.Forms.Button();
            this.txtmancc = new System.Windows.Forms.TextBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.dgvtimkiemnhacungcap = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtimkiemnhacungcap)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 229);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã NCC ";
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(740, 537);
            this.btndong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(98, 45);
            this.btndong.TabIndex = 12;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btntimlai
            // 
            this.btntimlai.Location = new System.Drawing.Point(558, 537);
            this.btntimlai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btntimlai.Name = "btntimlai";
            this.btntimlai.Size = new System.Drawing.Size(98, 45);
            this.btntimlai.TabIndex = 11;
            this.btntimlai.Text = "Tìm lại";
            this.btntimlai.UseVisualStyleBackColor = true;
            this.btntimlai.Click += new System.EventHandler(this.btntimlai_Click);
            // 
            // txtmancc
            // 
            this.txtmancc.Location = new System.Drawing.Point(558, 225);
            this.txtmancc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmancc.Name = "txtmancc";
            this.txtmancc.Size = new System.Drawing.Size(218, 26);
            this.txtmancc.TabIndex = 10;
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(352, 537);
            this.btntimkiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(98, 45);
            this.btntimkiem.TabIndex = 9;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // dgvtimkiemnhacungcap
            // 
            this.dgvtimkiemnhacungcap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtimkiemnhacungcap.Location = new System.Drawing.Point(280, 300);
            this.dgvtimkiemnhacungcap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvtimkiemnhacungcap.Name = "dgvtimkiemnhacungcap";
            this.dgvtimkiemnhacungcap.RowHeadersWidth = 62;
            this.dgvtimkiemnhacungcap.Size = new System.Drawing.Size(640, 169);
            this.dgvtimkiemnhacungcap.TabIndex = 8;
            this.dgvtimkiemnhacungcap.DoubleClick += new System.EventHandler(this.dgvtimkiemnhacungcap_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(374, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "TÌM KIẾM NHÀ CUNG CẤP";
            // 
            // frmtimkiemnhacungcap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btntimlai);
            this.Controls.Add(this.txtmancc);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.dgvtimkiemnhacungcap);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmtimkiemnhacungcap";
            this.Text = "Tìm kiếm nhà cung cấp";
            this.Load += new System.EventHandler(this.timkiemnhacungcap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtimkiemnhacungcap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btntimlai;
        private System.Windows.Forms.TextBox txtmancc;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.DataGridView dgvtimkiemnhacungcap;
        private System.Windows.Forms.Label label1;
    }
}