namespace EcoBicycle.Presatation
{
    partial class frmMuonTraXe
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
            this.simpleButton2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbChiNhanh = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMaXe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Mode = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton2
            // 
            this.simpleButton2.BackColor = System.Drawing.SystemColors.Highlight;
            this.simpleButton2.BackgroundImage = global::EcoBicycle.Presatation.Properties.Resources.bicycle;
            this.simpleButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.simpleButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.ForeColor = System.Drawing.Color.Red;
            this.simpleButton2.Location = new System.Drawing.Point(458, 334);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(266, 182);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "Mở";
            this.simpleButton2.UseVisualStyleBackColor = false;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Mode);
            this.panel1.Controls.Add(this.txtMaXe);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cbbChiNhanh);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(180, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 331);
            this.panel1.TabIndex = 4;
            // 
            // cbbChiNhanh
            // 
            this.cbbChiNhanh.FormattingEnabled = true;
            this.cbbChiNhanh.Location = new System.Drawing.Point(232, 21);
            this.cbbChiNhanh.Name = "cbbChiNhanh";
            this.cbbChiNhanh.Size = new System.Drawing.Size(121, 28);
            this.cbbChiNhanh.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 66;
            this.label4.Text = "Mã Chi Nhánh";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaXe,
            this.TenXe,
            this.TenTrangThai,
            this.MaCN});
            this.dataGridView1.Location = new System.Drawing.Point(3, 94);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(789, 233);
            this.dataGridView1.TabIndex = 65;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // MaXe
            // 
            this.MaXe.DataPropertyName = "MaXe";
            this.MaXe.HeaderText = "Mã Xe";
            this.MaXe.MinimumWidth = 6;
            this.MaXe.Name = "MaXe";
            this.MaXe.Width = 70;
            // 
            // TenXe
            // 
            this.TenXe.DataPropertyName = "TenXe";
            this.TenXe.HeaderText = "Loại xe";
            this.TenXe.MinimumWidth = 6;
            this.TenXe.Name = "TenXe";
            this.TenXe.Width = 70;
            // 
            // TenTrangThai
            // 
            this.TenTrangThai.DataPropertyName = "TenTrangThai";
            this.TenTrangThai.HeaderText = "Tên Trạng thái";
            this.TenTrangThai.MinimumWidth = 6;
            this.TenTrangThai.Name = "TenTrangThai";
            this.TenTrangThai.Width = 125;
            // 
            // MaCN
            // 
            this.MaCN.DataPropertyName = "MaCN";
            this.MaCN.HeaderText = "Chi Nhánh";
            this.MaCN.MinimumWidth = 8;
            this.MaCN.Name = "MaCN";
            this.MaCN.Width = 150;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(455, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 43);
            this.button1.TabIndex = 68;
            this.button1.Text = "Mượn xe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMaXe
            // 
            this.txtMaXe.Location = new System.Drawing.Point(278, 56);
            this.txtMaXe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaXe.Name = "txtMaXe";
            this.txtMaXe.ReadOnly = true;
            this.txtMaXe.Size = new System.Drawing.Size(112, 26);
            this.txtMaXe.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 69;
            this.label2.Text = "Mã Xe Cần Mượn";
            // 
            // Mode
            // 
            this.Mode.Location = new System.Drawing.Point(685, 3);
            this.Mode.Name = "Mode";
            this.Mode.Size = new System.Drawing.Size(107, 31);
            this.Mode.TabIndex = 71;
            this.Mode.Text = "Mode Mượn";
            this.Mode.UseVisualStyleBackColor = true;
            this.Mode.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmMuonTraXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1136, 622);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.simpleButton2);
            this.DoubleBuffered = true;
            this.Name = "frmMuonTraXe";
            this.Text = "frmMuonTraXe";
            this.Load += new System.EventHandler(this.frmMuonTraXe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button simpleButton2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbbChiNhanh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCN;
        private System.Windows.Forms.TextBox txtMaXe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Mode;
    }
}