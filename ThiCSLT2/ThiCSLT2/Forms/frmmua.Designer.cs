
namespace ThiCSLT2.Forms
{
    partial class frmmua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmua));
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmamua = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txttenmua = new System.Windows.Forms.TextBox();
            this.btnboqua = new System.Windows.Forms.Button();
            this.btndong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(82, 175);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 62;
            this.DataGridView.RowTemplate.Height = 28;
            this.DataGridView.Size = new System.Drawing.Size(632, 150);
            this.DataGridView.TabIndex = 37;
            this.DataGridView.Click += new System.EventHandler(this.DataGridView_Click);
            // 
            // btnthem
            // 
            this.btnthem.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.Image")));
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.Location = new System.Drawing.Point(82, 369);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(91, 37);
            this.btnthem.TabIndex = 38;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnluu
            // 
            this.btnluu.Image = ((System.Drawing.Image)(resources.GetObject("btnluu.Image")));
            this.btnluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnluu.Location = new System.Drawing.Point(394, 369);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(84, 39);
            this.btnluu.TabIndex = 39;
            this.btnluu.Text = "Lưu";
            this.btnluu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnsua
            // 
            this.btnsua.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.Image")));
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsua.Location = new System.Drawing.Point(179, 369);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(93, 36);
            this.btnsua.TabIndex = 40;
            this.btnsua.Text = "Sửa";
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.Image")));
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(289, 369);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(87, 37);
            this.btnxoa.TabIndex = 41;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(282, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 40);
            this.label1.TabIndex = 42;
            this.label1.Text = "DANH MỤC MÙA";
            // 
            // txtmamua
            // 
            this.txtmamua.Location = new System.Drawing.Point(198, 72);
            this.txtmamua.Name = "txtmamua";
            this.txtmamua.Size = new System.Drawing.Size(195, 26);
            this.txtmamua.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "Mã mùa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "Tên mùa";
            // 
            // txttenmua
            // 
            this.txttenmua.Location = new System.Drawing.Point(198, 131);
            this.txttenmua.Name = "txttenmua";
            this.txttenmua.Size = new System.Drawing.Size(195, 26);
            this.txttenmua.TabIndex = 46;
            // 
            // btnboqua
            // 
            this.btnboqua.Image = ((System.Drawing.Image)(resources.GetObject("btnboqua.Image")));
            this.btnboqua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnboqua.Location = new System.Drawing.Point(495, 369);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(106, 39);
            this.btnboqua.TabIndex = 47;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnboqua.UseVisualStyleBackColor = true;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // btndong
            // 
            this.btndong.Image = ((System.Drawing.Image)(resources.GetObject("btndong.Image")));
            this.btndong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndong.Location = new System.Drawing.Point(616, 369);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(98, 39);
            this.btndong.TabIndex = 48;
            this.btndong.Text = "Đóng";
            this.btndong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // frmmua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.txttenmua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmamua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.DataGridView);
            this.Name = "frmmua";
            this.Text = "Mùa";
            this.Load += new System.EventHandler(this.frmmua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmamua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttenmua;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.Button btndong;
    }
}