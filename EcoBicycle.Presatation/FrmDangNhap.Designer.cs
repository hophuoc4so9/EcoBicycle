﻿
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDangNhap
            // 
            this.labelDangNhap.AutoSize = true;
            this.labelDangNhap.Location = new System.Drawing.Point(350, 172);
            this.labelDangNhap.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelDangNhap.Name = "labelDangNhap";
            this.labelDangNhap.Size = new System.Drawing.Size(105, 24);
            this.labelDangNhap.TabIndex = 0;
            this.labelDangNhap.Text = "UserName:";
            this.labelDangNhap.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(350, 339);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(97, 24);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(616, 172);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(418, 29);
            this.txtUserName.TabIndex = 2;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(616, 334);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(418, 29);
            this.txtPassword.TabIndex = 4;
            // 
            // btnThoatDangNhap
            // 
            this.btnThoatDangNhap.Location = new System.Drawing.Point(927, 598);
            this.btnThoatDangNhap.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnThoatDangNhap.Name = "btnThoatDangNhap";
            this.btnThoatDangNhap.Size = new System.Drawing.Size(346, 130);
            this.btnThoatDangNhap.TabIndex = 5;
            this.btnThoatDangNhap.Text = "Thoát";
            this.btnThoatDangNhap.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // BtnDangNhapdn
            // 
            this.BtnDangNhapdn.Location = new System.Drawing.Point(297, 582);
            this.BtnDangNhapdn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnDangNhapdn.Name = "BtnDangNhapdn";
            this.BtnDangNhapdn.Size = new System.Drawing.Size(315, 147);
            this.BtnDangNhapdn.TabIndex = 3;
            this.BtnDangNhapdn.Text = "Đăng nhập";
            this.BtnDangNhapdn.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 830);
            this.Controls.Add(this.btnThoatDangNhap);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.BtnDangNhapdn);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelDangNhap);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
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
    }
}