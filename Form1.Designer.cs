
namespace TinhTienNhaKhoa
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.chkTramRang = new System.Windows.Forms.CheckBox();
            this.chkCaoVoi = new System.Windows.Forms.CheckBox();
            this.numNhoRang = new System.Windows.Forms.NumericUpDown();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.errHoTen = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numNhoRang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errHoTen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tính Tiền Nha Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dịch vụ sử dụng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ Tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Trám răng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cạo vôi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nhổ răng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(107, 415);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tổng tiền";
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(110, 460);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(151, 23);
            this.btnTinhTien.TabIndex = 7;
            this.btnTinhTien.Text = "Tính tiền cho anh";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(245, 129);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(324, 22);
            this.txtHoTen.TabIndex = 8;
            this.txtHoTen.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged);
            this.txtHoTen.Validating += new System.ComponentModel.CancelEventHandler(this.txtHoTen_Validating);
            // 
            // chkTramRang
            // 
            this.chkTramRang.AutoSize = true;
            this.chkTramRang.Location = new System.Drawing.Point(245, 233);
            this.chkTramRang.Name = "chkTramRang";
            this.chkTramRang.Size = new System.Drawing.Size(82, 21);
            this.chkTramRang.TabIndex = 9;
            this.chkTramRang.Text = "200.000";
            this.chkTramRang.UseVisualStyleBackColor = true;
            this.chkTramRang.CheckedChanged += new System.EventHandler(this.chkTramRang_CheckedChanged);
            // 
            // chkCaoVoi
            // 
            this.chkCaoVoi.AutoSize = true;
            this.chkCaoVoi.Location = new System.Drawing.Point(245, 288);
            this.chkCaoVoi.Name = "chkCaoVoi";
            this.chkCaoVoi.Size = new System.Drawing.Size(82, 21);
            this.chkCaoVoi.TabIndex = 10;
            this.chkCaoVoi.Text = "300.000";
            this.chkCaoVoi.UseVisualStyleBackColor = true;
            this.chkCaoVoi.CheckedChanged += new System.EventHandler(this.chkCaoVoi_CheckedChanged);
            // 
            // numNhoRang
            // 
            this.numNhoRang.Location = new System.Drawing.Point(245, 356);
            this.numNhoRang.Name = "numNhoRang";
            this.numNhoRang.Size = new System.Drawing.Size(120, 22);
            this.numNhoRang.TabIndex = 11;
            this.numNhoRang.ValueChanged += new System.EventHandler(this.numNhoRang_ValueChanged);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(245, 415);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(100, 22);
            this.txtTongTien.TabIndex = 12;
            this.txtTongTien.TextChanged += new System.EventHandler(this.txtTongTien_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(405, 361);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "(Đơn giá 100.000đ/răng)";
            // 
            // errHoTen
            // 
            this.errHoTen.ContainerControl = this;
            // 
            // txtMessage
            // 
            this.txtMessage.AutoSize = true;
            this.txtMessage.Location = new System.Drawing.Point(405, 460);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(20, 17);
            this.txtMessage.TabIndex = 14;
            this.txtMessage.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 538);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.numNhoRang);
            this.Controls.Add(this.chkCaoVoi);
            this.Controls.Add(this.chkTramRang);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numNhoRang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errHoTen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.CheckBox chkTramRang;
        private System.Windows.Forms.CheckBox chkCaoVoi;
        private System.Windows.Forms.NumericUpDown numNhoRang;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider errHoTen;
        private System.Windows.Forms.Label txtMessage;
    }
}

