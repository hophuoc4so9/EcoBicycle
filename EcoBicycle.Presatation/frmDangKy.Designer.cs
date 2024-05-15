namespace EcoBicycle.Presatation
{
    partial class frmDangKy
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDownTien = new System.Windows.Forms.TextBox();
            this.txtMaThe = new System.Windows.Forms.TextBox();
            this.labelMathe = new System.Windows.Forms.Label();
            this.txtSTK = new System.Windows.Forms.TextBox();
            this.labelSTK = new System.Windows.Forms.Label();
            this.cmbNganHang = new System.Windows.Forms.ComboBox();
            this.labelNganHang = new System.Windows.Forms.Label();
            this.labelThongBao2 = new System.Windows.Forms.Label();
            this.labelThongBao1 = new System.Windows.Forms.Label();
            this.radioNu = new System.Windows.Forms.RadioButton();
            this.radioNam = new System.Windows.Forms.RadioButton();
            this.cmbLoaiThe = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SpringGreen;
            this.panel1.BackgroundImage = global::EcoBicycle.Presatation.Properties.Resources.bicycle;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.numericUpDownTien);
            this.panel1.Controls.Add(this.txtMaThe);
            this.panel1.Controls.Add(this.labelMathe);
            this.panel1.Controls.Add(this.txtSTK);
            this.panel1.Controls.Add(this.labelSTK);
            this.panel1.Controls.Add(this.cmbNganHang);
            this.panel1.Controls.Add(this.labelNganHang);
            this.panel1.Controls.Add(this.labelThongBao2);
            this.panel1.Controls.Add(this.labelThongBao1);
            this.panel1.Controls.Add(this.radioNu);
            this.panel1.Controls.Add(this.radioNam);
            this.panel1.Controls.Add(this.cmbLoaiThe);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // numericUpDownTien
            // 
            this.numericUpDownTien.Location = new System.Drawing.Point(227, 360);
            this.numericUpDownTien.MaxLength = 10;
            this.numericUpDownTien.Name = "numericUpDownTien";
            this.numericUpDownTien.Size = new System.Drawing.Size(344, 26);
            this.numericUpDownTien.TabIndex = 23;
            this.numericUpDownTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txtMaThe
            // 
            this.txtMaThe.Location = new System.Drawing.Point(221, 12);
            this.txtMaThe.MaxLength = 11;
            this.txtMaThe.Name = "txtMaThe";
            this.txtMaThe.ReadOnly = true;
            this.txtMaThe.Size = new System.Drawing.Size(350, 26);
            this.txtMaThe.TabIndex = 22;
            // 
            // labelMathe
            // 
            this.labelMathe.AutoSize = true;
            this.labelMathe.Location = new System.Drawing.Point(87, 15);
            this.labelMathe.Name = "labelMathe";
            this.labelMathe.Size = new System.Drawing.Size(62, 20);
            this.labelMathe.TabIndex = 21;
            this.labelMathe.Text = "Mã thẻ;";
            this.labelMathe.Click += new System.EventHandler(this.labelMathe_Click);
            // 
            // txtSTK
            // 
            this.txtSTK.Location = new System.Drawing.Point(227, 328);
            this.txtSTK.MaxLength = 6;
            this.txtSTK.Name = "txtSTK";
            this.txtSTK.Size = new System.Drawing.Size(350, 26);
            this.txtSTK.TabIndex = 20;
            this.txtSTK.Visible = false;
            this.txtSTK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // labelSTK
            // 
            this.labelSTK.AutoSize = true;
            this.labelSTK.Location = new System.Drawing.Point(93, 331);
            this.labelSTK.Name = "labelSTK";
            this.labelSTK.Size = new System.Drawing.Size(98, 20);
            this.labelSTK.TabIndex = 19;
            this.labelSTK.Text = "Số tài khoản";
            this.labelSTK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSTK.Visible = false;
            // 
            // cmbNganHang
            // 
            this.cmbNganHang.FormattingEnabled = true;
            this.cmbNganHang.Location = new System.Drawing.Point(227, 259);
            this.cmbNganHang.Name = "cmbNganHang";
            this.cmbNganHang.Size = new System.Drawing.Size(347, 28);
            this.cmbNganHang.TabIndex = 18;
            this.cmbNganHang.Visible = false;
            // 
            // labelNganHang
            // 
            this.labelNganHang.AutoSize = true;
            this.labelNganHang.Location = new System.Drawing.Point(90, 262);
            this.labelNganHang.Name = "labelNganHang";
            this.labelNganHang.Size = new System.Drawing.Size(119, 20);
            this.labelNganHang.TabIndex = 17;
            this.labelNganHang.Text = "Tiên ngân hàng";
            this.labelNganHang.Visible = false;
            // 
            // labelThongBao2
            // 
            this.labelThongBao2.AutoSize = true;
            this.labelThongBao2.Location = new System.Drawing.Point(90, 331);
            this.labelThongBao2.Name = "labelThongBao2";
            this.labelThongBao2.Size = new System.Drawing.Size(163, 20);
            this.labelThongBao2.TabIndex = 16;
            this.labelThongBao2.Text = "Số tiền đã gửi: 0 đồng";
            this.labelThongBao2.Visible = false;
            // 
            // labelThongBao1
            // 
            this.labelThongBao1.AutoSize = true;
            this.labelThongBao1.Location = new System.Drawing.Point(87, 259);
            this.labelThongBao1.Name = "labelThongBao1";
            this.labelThongBao1.Size = new System.Drawing.Size(570, 20);
            this.labelThongBao1.TabIndex = 15;
            this.labelThongBao1.Text = "Để kích hoạt thẻ trả trước quý khách hàng cần gửi trước 1.000.000 đồng vào thẻ";
            this.labelThongBao1.Visible = false;
            // 
            // radioNu
            // 
            this.radioNu.AutoSize = true;
            this.radioNu.BackColor = System.Drawing.Color.Honeydew;
            this.radioNu.Location = new System.Drawing.Point(408, 149);
            this.radioNu.Name = "radioNu";
            this.radioNu.Size = new System.Drawing.Size(54, 24);
            this.radioNu.TabIndex = 14;
            this.radioNu.TabStop = true;
            this.radioNu.Text = "Nữ";
            this.radioNu.UseVisualStyleBackColor = false;
            // 
            // radioNam
            // 
            this.radioNam.AutoSize = true;
            this.radioNam.BackColor = System.Drawing.Color.Honeydew;
            this.radioNam.Location = new System.Drawing.Point(223, 147);
            this.radioNam.Name = "radioNam";
            this.radioNam.Size = new System.Drawing.Size(67, 24);
            this.radioNam.TabIndex = 13;
            this.radioNam.TabStop = true;
            this.radioNam.Text = "Nam";
            this.radioNam.UseVisualStyleBackColor = false;
            // 
            // cmbLoaiThe
            // 
            this.cmbLoaiThe.FormattingEnabled = true;
            this.cmbLoaiThe.Location = new System.Drawing.Point(224, 200);
            this.cmbLoaiThe.Name = "cmbLoaiThe";
            this.cmbLoaiThe.Size = new System.Drawing.Size(350, 28);
            this.cmbLoaiThe.TabIndex = 12;
            this.cmbLoaiThe.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(490, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 36);
            this.button2.TabIndex = 11;
            this.button2.Text = "Trở lại";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "Tiếp tục";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Loại thẻ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giới tính";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(221, 97);
            this.txtPass.MaxLength = 6;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(350, 26);
            this.txtPass.TabIndex = 3;
            this.txtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(221, 49);
            this.txtSDT.MaxLength = 11;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(350, 26);
            this.txtSDT.TabIndex = 1;
            this.txtSDT.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số điện thoại:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // frmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frmDangKy";
            this.Text = "frmDangKy";
            this.Load += new System.EventHandler(this.frmDangKy_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioNam;
        private System.Windows.Forms.RadioButton radioNu;
        private System.Windows.Forms.ComboBox cmbLoaiThe;
        private System.Windows.Forms.Label labelThongBao1;
        private System.Windows.Forms.TextBox txtSTK;
        private System.Windows.Forms.Label labelSTK;
        private System.Windows.Forms.ComboBox cmbNganHang;
        private System.Windows.Forms.Label labelNganHang;
        private System.Windows.Forms.Label labelThongBao2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
        private System.Windows.Forms.TextBox txtMaThe;
        private System.Windows.Forms.Label labelMathe;
        private System.Windows.Forms.TextBox numericUpDownTien;
    }
}