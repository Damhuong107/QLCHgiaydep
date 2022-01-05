
namespace ThiCSLT2.Forms
{
    partial class frmdangnhap
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdangnhap));
            this.txtusername = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btndangnhap = new System.Windows.Forms.Button();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(306, 195);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(281, 26);
            this.txtusername.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(108, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(599, 46);
            this.label3.TabIndex = 14;
            this.label3.Text = "ĐĂNG NHẬP VÀO HỆ THỐNG";
            // 
            // btnthoat
            // 
            this.btnthoat.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.Image")));
            this.btnthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthoat.Location = new System.Drawing.Point(491, 321);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(96, 42);
            this.btnthoat.TabIndex = 13;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // btndangnhap
            // 
            this.btndangnhap.Image = ((System.Drawing.Image)(resources.GetObject("btndangnhap.Image")));
            this.btndangnhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndangnhap.Location = new System.Drawing.Point(306, 321);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(140, 42);
            this.btndangnhap.TabIndex = 12;
            this.btndangnhap.Text = "Đăng nhập";
            this.btndangnhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndangnhap.UseVisualStyleBackColor = true;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(306, 255);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(281, 26);
            this.txtpass.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(171, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(171, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tài khoản";
            // 
            // frmdangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btndangnhap);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmdangnhap";
            this.Text = "Đăng nhập tài khoản";
            this.Load += new System.EventHandler(this.frmdangnhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btndangnhap;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}