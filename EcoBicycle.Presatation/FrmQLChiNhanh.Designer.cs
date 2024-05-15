
namespace EcoBicycle.Presatation
{
    partial class FrmQLChiNhanh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQLChiNhanh));
            this.label1 = new System.Windows.Forms.Label();
            this.txtChiNhanh = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvChuyenNganh = new System.Windows.Forms.DataGridView();
            this.MaCN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenChiNhanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soxe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoThe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenCN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnxoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnthem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenNganh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Chi Nhánh";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtChiNhanh
            // 
            this.txtChiNhanh.Location = new System.Drawing.Point(283, 30);
            this.txtChiNhanh.Name = "txtChiNhanh";
            this.txtChiNhanh.Size = new System.Drawing.Size(249, 26);
            this.txtChiNhanh.TabIndex = 6;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dgvChuyenNganh
            // 
            this.dgvChuyenNganh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChuyenNganh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCN,
            this.TenChiNhanh,
            this.DiaChi,
            this.soxe,
            this.SoThe});
            this.dgvChuyenNganh.Location = new System.Drawing.Point(51, 277);
            this.dgvChuyenNganh.Name = "dgvChuyenNganh";
            this.dgvChuyenNganh.RowHeadersWidth = 62;
            this.dgvChuyenNganh.RowTemplate.Height = 28;
            this.dgvChuyenNganh.Size = new System.Drawing.Size(1191, 150);
            this.dgvChuyenNganh.TabIndex = 7;
            this.dgvChuyenNganh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChuyenNganh_CellContentClick);
            this.dgvChuyenNganh.SelectionChanged += new System.EventHandler(this.dgvChuyenNganh_SelectionChanged);
            // 
            // MaCN
            // 
            this.MaCN.DataPropertyName = "MaCN";
            this.MaCN.HeaderText = "Mã Chi Nhánh";
            this.MaCN.MinimumWidth = 8;
            this.MaCN.Name = "MaCN";
            this.MaCN.Width = 150;
            // 
            // TenChiNhanh
            // 
            this.TenChiNhanh.DataPropertyName = "TenChiNhanh";
            this.TenChiNhanh.HeaderText = "Tên Chi Nhánh";
            this.TenChiNhanh.MinimumWidth = 8;
            this.TenChiNhanh.Name = "TenChiNhanh";
            this.TenChiNhanh.Width = 150;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 8;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 150;
            // 
            // soxe
            // 
            this.soxe.DataPropertyName = "soxe";
            this.soxe.HeaderText = "Số xe";
            this.soxe.MinimumWidth = 8;
            this.soxe.Name = "soxe";
            this.soxe.Width = 150;
            // 
            // SoThe
            // 
            this.SoThe.DataPropertyName = "SoThe";
            this.SoThe.HeaderText = "Số thẻ";
            this.SoThe.MinimumWidth = 8;
            this.SoThe.Name = "SoThe";
            this.SoThe.Width = 150;
            // 
            // txtTenCN
            // 
            this.txtTenCN.Location = new System.Drawing.Point(779, 30);
            this.txtTenCN.Name = "txtTenCN";
            this.txtTenCN.Size = new System.Drawing.Size(249, 26);
            this.txtTenCN.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(637, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tên chi nhánh";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(283, 91);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(745, 71);
            this.txtDiaChi.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Địa chỉ";
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(849, 182);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 68);
            this.button1.TabIndex = 60;
            this.button1.Text = "Phân bổ xe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1063, 181);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 68);
            this.button2.TabIndex = 61;
            this.button2.Text = "Phân bổ thẻ xe";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSua
            // 
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(598, 181);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(167, 68);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.ImageOptions.Image")));
            this.btnxoa.Location = new System.Drawing.Point(328, 182);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(195, 68);
            this.btnxoa.TabIndex = 9;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.ImageOptions.Image")));
            this.btnthem.Location = new System.Drawing.Point(67, 182);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(172, 68);
            this.btnthem.TabIndex = 8;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // FrmQLChiNhanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenCN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dgvChuyenNganh);
            this.Controls.Add(this.txtChiNhanh);
            this.Controls.Add(this.label1);
            this.Name = "FrmQLChiNhanh";
            this.Text = "FrmQLChuyenNganh";
            this.Load += new System.EventHandler(this.FrmQLChuyenNganh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenNganh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChiNhanh;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dgvChuyenNganh;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnxoa;
        private DevExpress.XtraEditors.SimpleButton btnthem;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenCN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenChiNhanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn soxe;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoThe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}