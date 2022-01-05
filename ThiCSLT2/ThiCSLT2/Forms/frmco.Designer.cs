
namespace ThiCSLT2.Forms
{
    partial class frmco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmco));
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmaco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txttenco = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btndong = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(34, 188);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 62;
            this.DataGridView.RowTemplate.Height = 28;
            this.DataGridView.Size = new System.Drawing.Size(719, 150);
            this.DataGridView.TabIndex = 34;
            this.DataGridView.Click += new System.EventHandler(this.DataGridView_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(295, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 40);
            this.label1.TabIndex = 35;
            this.label1.Text = "DANH MỤC CỠ";
            // 
            // txtmaco
            // 
            this.txtmaco.Location = new System.Drawing.Point(126, 68);
            this.txtmaco.Name = "txtmaco";
            this.txtmaco.Size = new System.Drawing.Size(186, 26);
            this.txtmaco.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Mã cỡ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Tên cỡ";
            // 
            // txttenco
            // 
            this.txttenco.Location = new System.Drawing.Point(126, 135);
            this.txttenco.Name = "txttenco";
            this.txttenco.Size = new System.Drawing.Size(186, 26);
            this.txttenco.TabIndex = 39;
            // 
            // btnthem
            // 
            this.btnthem.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.Image")));
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.Location = new System.Drawing.Point(34, 358);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(94, 39);
            this.btnthem.TabIndex = 40;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.Image")));
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsua.Location = new System.Drawing.Point(156, 358);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(90, 39);
            this.btnsua.TabIndex = 41;
            this.btnsua.Text = "Sửa";
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.Image")));
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(281, 358);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(89, 37);
            this.btnxoa.TabIndex = 42;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnluu
            // 
            this.btnluu.Image = ((System.Drawing.Image)(resources.GetObject("btnluu.Image")));
            this.btnluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnluu.Location = new System.Drawing.Point(402, 356);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(92, 39);
            this.btnluu.TabIndex = 43;
            this.btnluu.Text = "Lưu";
            this.btnluu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btndong
            // 
            this.btndong.Image = ((System.Drawing.Image)(resources.GetObject("btndong.Image")));
            this.btndong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndong.Location = new System.Drawing.Point(655, 354);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(98, 41);
            this.btndong.TabIndex = 44;
            this.btndong.Text = "Đóng";
            this.btndong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.Image = ((System.Drawing.Image)(resources.GetObject("btnboqua.Image")));
            this.btnboqua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnboqua.Location = new System.Drawing.Point(523, 354);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(113, 41);
            this.btnboqua.TabIndex = 45;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnboqua.UseVisualStyleBackColor = true;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // frmco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txttenco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmaco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridView);
            this.Name = "frmco";
            this.Text = "Cỡ";
            this.Load += new System.EventHandler(this.frmco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmaco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttenco;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btnboqua;
    }
}