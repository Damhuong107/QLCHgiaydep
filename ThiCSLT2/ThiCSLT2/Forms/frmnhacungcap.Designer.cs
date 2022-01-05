
namespace BTL_QLGD.Forms
{
    partial class frmnhacungcap
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
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txttenncc = new System.Windows.Forms.TextBox();
            this.txtdienthoai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnthem = new System.Windows.Forms.Button();
            this.dgridncc = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmancc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgridncc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(425, 408);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 44);
            this.btnxoa.TabIndex = 31;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(561, 408);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 44);
            this.btnsua.TabIndex = 30;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(705, 408);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 44);
            this.btnluu.TabIndex = 29;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            // 
            // btnboqua
            // 
            this.btnboqua.Location = new System.Drawing.Point(842, 408);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(75, 44);
            this.btnboqua.TabIndex = 28;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.UseVisualStyleBackColor = true;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(973, 408);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 44);
            this.btnthoat.TabIndex = 27;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(818, 113);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(230, 26);
            this.txtdiachi.TabIndex = 26;
            // 
            // txttenncc
            // 
            this.txttenncc.Location = new System.Drawing.Point(379, 182);
            this.txttenncc.Name = "txttenncc";
            this.txttenncc.Size = new System.Drawing.Size(230, 26);
            this.txttenncc.TabIndex = 25;
            // 
            // txtdienthoai
            // 
            this.txtdienthoai.Location = new System.Drawing.Point(818, 179);
            this.txtdienthoai.Name = "txtdienthoai";
            this.txtdienthoai.Size = new System.Drawing.Size(230, 26);
            this.txtdienthoai.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Tên NCC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(690, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(690, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Điện thoại";
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(284, 408);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 44);
            this.btnthem.TabIndex = 20;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            // 
            // dgridncc
            // 
            this.dgridncc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridncc.Location = new System.Drawing.Point(379, 240);
            this.dgridncc.Name = "dgridncc";
            this.dgridncc.RowHeadersWidth = 62;
            this.dgridncc.RowTemplate.Height = 28;
            this.dgridncc.Size = new System.Drawing.Size(600, 150);
            this.dgridncc.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mã NCC";
            // 
            // txtmancc
            // 
            this.txtmancc.Location = new System.Drawing.Point(379, 113);
            this.txtmancc.Name = "txtmancc";
            this.txtmancc.Size = new System.Drawing.Size(230, 26);
            this.txtmancc.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(440, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 64);
            this.label1.TabIndex = 16;
            this.label1.Text = "NHÀ CUNG CẤP";
            // 
            // frmnhacungcap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 480);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txttenncc);
            this.Controls.Add(this.txtdienthoai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dgridncc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmancc);
            this.Controls.Add(this.label1);
            this.Name = "frmnhacungcap";
            this.Text = "frmnhacungcap";
            ((System.ComponentModel.ISupportInitialize)(this.dgridncc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txttenncc;
        private System.Windows.Forms.TextBox txtdienthoai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView dgridncc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmancc;
        private System.Windows.Forms.Label label1;
    }
}