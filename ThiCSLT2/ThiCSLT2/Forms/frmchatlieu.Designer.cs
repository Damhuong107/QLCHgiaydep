
namespace ThiCSLT2.Forms
{
    partial class frmchatlieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmchatlieu));
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmachatlieu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txttenchatlieu = new System.Windows.Forms.TextBox();
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
            this.DataGridView.Location = new System.Drawing.Point(52, 221);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 62;
            this.DataGridView.RowTemplate.Height = 28;
            this.DataGridView.Size = new System.Drawing.Size(673, 150);
            this.DataGridView.TabIndex = 35;
            this.DataGridView.Click += new System.EventHandler(this.DataGridView_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "DANH MỤC CHẤT LIỆU";
            // 
            // txtmachatlieu
            // 
            this.txtmachatlieu.Location = new System.Drawing.Point(153, 75);
            this.txtmachatlieu.Name = "txtmachatlieu";
            this.txtmachatlieu.Size = new System.Drawing.Size(188, 26);
            this.txtmachatlieu.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Mã chất liệu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Tên chất liệu";
            // 
            // txttenchatlieu
            // 
            this.txttenchatlieu.Location = new System.Drawing.Point(153, 128);
            this.txttenchatlieu.Name = "txttenchatlieu";
            this.txttenchatlieu.Size = new System.Drawing.Size(188, 26);
            this.txttenchatlieu.TabIndex = 40;
            // 
            // btnthem
            // 
            this.btnthem.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.Image")));
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.Location = new System.Drawing.Point(51, 387);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(91, 37);
            this.btnthem.TabIndex = 41;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.Image")));
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsua.Location = new System.Drawing.Point(173, 387);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(93, 36);
            this.btnsua.TabIndex = 42;
            this.btnsua.Text = "Sửa";
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.Image")));
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(292, 387);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(87, 37);
            this.btnxoa.TabIndex = 43;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnluu
            // 
            this.btnluu.Image = ((System.Drawing.Image)(resources.GetObject("btnluu.Image")));
            this.btnluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnluu.Location = new System.Drawing.Point(404, 388);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(84, 39);
            this.btnluu.TabIndex = 44;
            this.btnluu.Text = "Lưu";
            this.btnluu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.Image = ((System.Drawing.Image)(resources.GetObject("btnboqua.Image")));
            this.btnboqua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnboqua.Location = new System.Drawing.Point(504, 388);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(106, 39);
            this.btnboqua.TabIndex = 48;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnboqua.UseVisualStyleBackColor = true;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // btndong
            // 
            this.btndong.Image = ((System.Drawing.Image)(resources.GetObject("btndong.Image")));
            this.btndong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndong.Location = new System.Drawing.Point(627, 387);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(98, 39);
            this.btndong.TabIndex = 49;
            this.btndong.Text = "Đóng";
            this.btndong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // frmchatlieu
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
            this.Controls.Add(this.txttenchatlieu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmachatlieu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridView);
            this.Name = "frmchatlieu";
            this.Text = "Chất liệu";
            this.Load += new System.EventHandler(this.frmchatlieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmachatlieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttenchatlieu;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.Button btndong;
    }
}