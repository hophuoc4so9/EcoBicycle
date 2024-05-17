
namespace EcoBicycle.Presatation
{
    partial class FrmDangNhap
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
            this.labelDangNhap = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnThoatDangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDangNhapdn = new DevExpress.XtraEditors.SimpleButton();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnDangNhap123 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDangNhap
            // 
            this.labelDangNhap.AutoSize = true;
            this.labelDangNhap.Location = new System.Drawing.Point(286, 143);
            this.labelDangNhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDangNhap.Name = "labelDangNhap";
            this.labelDangNhap.Size = new System.Drawing.Size(89, 20);
            this.labelDangNhap.TabIndex = 0;
            this.labelDangNhap.Text = "UserName:";
            this.labelDangNhap.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(286, 282);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(82, 20);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(495, 140);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(343, 26);
            this.txtUserName.TabIndex = 2;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(495, 260);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(343, 26);
            this.txtPassword.TabIndex = 4;
            // 
            // btnThoatDangNhap
            // 
            this.btnThoatDangNhap.Location = new System.Drawing.Point(1137, 747);
            this.btnThoatDangNhap.Margin = new System.Windows.Forms.Padding(8);
            this.btnThoatDangNhap.Name = "btnThoatDangNhap";
            this.btnThoatDangNhap.Size = new System.Drawing.Size(424, 162);
            this.btnThoatDangNhap.TabIndex = 5;
            this.btnThoatDangNhap.Text = "Thoát";
            this.btnThoatDangNhap.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // BtnDangNhapdn
            // 
            this.BtnDangNhapdn.Location = new System.Drawing.Point(364, 728);
            this.BtnDangNhapdn.Margin = new System.Windows.Forms.Padding(8);
            this.BtnDangNhapdn.Name = "BtnDangNhapdn";
            this.BtnDangNhapdn.Size = new System.Drawing.Size(387, 183);
            this.BtnDangNhapdn.TabIndex = 3;
            this.BtnDangNhapdn.Text = "Đăng nhập";
            this.BtnDangNhapdn.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // btnDangNhap123
            // 
            this.btnDangNhap123.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDangNhap123.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDangNhap123.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDangNhap123.Location = new System.Drawing.Point(290, 347);
            this.btnDangNhap123.Name = "btnDangNhap123";
            this.btnDangNhap123.Size = new System.Drawing.Size(184, 56);
            this.btnDangNhap123.TabIndex = 6;
            this.btnDangNhap123.Text = "Đăng nhập";
            this.btnDangNhap123.UseVisualStyleBackColor = false;
            this.btnDangNhap123.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(570, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 56);
            this.button1.TabIndex = 7;
            this.button1.Text = "Đăng xuất";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.BackgroundImage = global::EcoBicycle.Presatation.Properties.Resources.bicycle;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1099, 493);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDangNhap123);
            this.Controls.Add(this.btnThoatDangNhap);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.BtnDangNhapdn);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelDangNhap);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmDangNhap";
            this.Text = "frmDangNhap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDangNhap;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private DevExpress.XtraEditors.SimpleButton BtnDangNhapdn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraEditors.SimpleButton btnThoatDangNhap;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDangNhap123;
    }
}