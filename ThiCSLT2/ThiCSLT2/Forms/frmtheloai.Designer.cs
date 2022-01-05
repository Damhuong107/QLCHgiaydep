
namespace ThiCSLT2.Forms
{
    partial class frmtheloai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmtheloai));
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmaloai = new System.Windows.Forms.TextBox();
            this.txttenloai = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            this.btndong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(32, 128);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 62;
            this.DataGridView.RowTemplate.Height = 28;
            this.DataGridView.Size = new System.Drawing.Size(719, 259);
            this.DataGridView.TabIndex = 33;
            this.DataGridView.Click += new System.EventHandler(this.DataGridView_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Mã loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Tên loại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "DANH MỤC THỂ LOẠI";
            // 
            // txtmaloai
            // 
            this.txtmaloai.Location = new System.Drawing.Point(110, 60);
            this.txtmaloai.Name = "txtmaloai";
            this.txtmaloai.Size = new System.Drawing.Size(367, 26);
            this.txtmaloai.TabIndex = 37;
            // 
            // txttenloai
            // 
            this.txttenloai.Location = new System.Drawing.Point(110, 96);
            this.txttenloai.Name = "txttenloai";
            this.txttenloai.Size = new System.Drawing.Size(367, 26);
            this.txttenloai.TabIndex = 38;
            // 
            // btnthem
            // 
            this.btnthem.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.Image")));
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.Location = new System.Drawing.Point(63, 394);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(91, 37);
            this.btnthem.TabIndex = 42;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.Image")));
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsua.Location = new System.Drawing.Point(173, 397);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(93, 36);
            this.btnsua.TabIndex = 43;
            this.btnsua.Text = "Sửa";
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.Image")));
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(285, 396);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(87, 37);
            this.btnxoa.TabIndex = 44;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnluu
            // 
            this.btnluu.Image = ((System.Drawing.Image)(resources.GetObject("btnluu.Image")));
            this.btnluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnluu.Location = new System.Drawing.Point(393, 394);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(84, 39);
            this.btnluu.TabIndex = 45;
            this.btnluu.Text = "Lưu";
            this.btnluu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.Image = ((System.Drawing.Image)(resources.GetObject("btnboqua.Image")));
            this.btnboqua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnboqua.Location = new System.Drawing.Point(496, 394);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(106, 39);
            this.btnboqua.TabIndex = 49;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnboqua.UseVisualStyleBackColor = true;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // btndong
            // 
            this.btndong.Image = ((System.Drawing.Image)(resources.GetObject("btndong.Image")));
            this.btndong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndong.Location = new System.Drawing.Point(625, 394);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(98, 39);
            this.btndong.TabIndex = 50;
            this.btndong.Text = "Đóng";
            this.btndong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // frmtheloai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txttenloai);
            this.Controls.Add(this.txtmaloai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridView);
            this.Name = "frmtheloai";
            this.Text = "Thể loại";
            this.Load += new System.EventHandler(this.frmtheloai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmaloai;
        private System.Windows.Forms.TextBox txttenloai;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.Button btndong;
    }
}