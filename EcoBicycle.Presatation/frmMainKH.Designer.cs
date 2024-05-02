namespace EcoBicycle.Presatation
{
    partial class frmMainKH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainKH));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNapTien = new System.Windows.Forms.Button();
            this.btnXemThongTin = new System.Windows.Forms.Button();
            this.btnHoanTraThe = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.btnNapTien);
            this.panel1.Controls.Add(this.btnXemThongTin);
            this.panel1.Controls.Add(this.btnHoanTraThe);
            this.panel1.Controls.Add(this.btnDangNhap);
            this.panel1.Controls.Add(this.btnDangKy);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(22, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 445);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnNapTien
            // 
            this.btnNapTien.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNapTien.BackColor = System.Drawing.Color.SeaGreen;
            this.btnNapTien.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNapTien.Location = new System.Drawing.Point(0, 329);
            this.btnNapTien.Name = "btnNapTien";
            this.btnNapTien.Size = new System.Drawing.Size(184, 56);
            this.btnNapTien.TabIndex = 5;
            this.btnNapTien.Text = "Nạp tiền";
            this.btnNapTien.UseVisualStyleBackColor = false;
            // 
            // btnXemThongTin
            // 
            this.btnXemThongTin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnXemThongTin.BackColor = System.Drawing.Color.SeaGreen;
            this.btnXemThongTin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnXemThongTin.Location = new System.Drawing.Point(712, 193);
            this.btnXemThongTin.Name = "btnXemThongTin";
            this.btnXemThongTin.Size = new System.Drawing.Size(197, 56);
            this.btnXemThongTin.TabIndex = 4;
            this.btnXemThongTin.Text = "Xem thông tin thẻ";
            this.btnXemThongTin.UseVisualStyleBackColor = false;
            this.btnXemThongTin.Click += new System.EventHandler(this.btnXemThongTin_Click);
            // 
            // btnHoanTraThe
            // 
            this.btnHoanTraThe.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnHoanTraThe.BackColor = System.Drawing.Color.SeaGreen;
            this.btnHoanTraThe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHoanTraThe.Location = new System.Drawing.Point(3, 193);
            this.btnHoanTraThe.Name = "btnHoanTraThe";
            this.btnHoanTraThe.Size = new System.Drawing.Size(184, 56);
            this.btnHoanTraThe.TabIndex = 3;
            this.btnHoanTraThe.Text = "Hoàn trả thẻ";
            this.btnHoanTraThe.UseVisualStyleBackColor = false;
            this.btnHoanTraThe.Click += new System.EventHandler(this.btnHoanTraThe_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDangNhap.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDangNhap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDangNhap.Location = new System.Drawing.Point(715, 62);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(184, 56);
            this.btnDangNhap.TabIndex = 2;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnDangKy
            // 
            this.btnDangKy.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDangKy.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDangKy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDangKy.Location = new System.Drawing.Point(0, 62);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(184, 56);
            this.btnDangKy.TabIndex = 1;
            this.btnDangKy.Text = "Đăng ký thẻ";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(85, -1);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(11, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã máy:";
            // 
            // frmMainKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(977, 506);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "frmMainKH";
            this.Text = "frmMainKH";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMainKH_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnXemThongTin;
        private System.Windows.Forms.Button btnHoanTraThe;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnNapTien;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}