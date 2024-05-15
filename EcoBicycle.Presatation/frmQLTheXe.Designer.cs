namespace EcoBicycle.Presatation
{
    partial class frmQLTheXe
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
            this.txtMaThe = new System.Windows.Forms.TextBox();
            this.labelMathe = new System.Windows.Forms.Label();
            this.radioNu = new System.Windows.Forms.RadioButton();
            this.radioNam = new System.Windows.Forms.RadioButton();
            this.cmbLoaiThe = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.Mathe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiThe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaThe
            // 
            this.txtMaThe.Location = new System.Drawing.Point(184, 25);
            this.txtMaThe.MaxLength = 11;
            this.txtMaThe.Name = "txtMaThe";
            this.txtMaThe.Size = new System.Drawing.Size(350, 26);
            this.txtMaThe.TabIndex = 40;
            this.txtMaThe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // labelMathe
            // 
            this.labelMathe.AutoSize = true;
            this.labelMathe.Location = new System.Drawing.Point(50, 28);
            this.labelMathe.Name = "labelMathe";
            this.labelMathe.Size = new System.Drawing.Size(62, 20);
            this.labelMathe.TabIndex = 39;
            this.labelMathe.Text = "Mã thẻ:";
            // 
            // radioNu
            // 
            this.radioNu.AutoSize = true;
            this.radioNu.BackColor = System.Drawing.Color.Honeydew;
            this.radioNu.Location = new System.Drawing.Point(963, 72);
            this.radioNu.Name = "radioNu";
            this.radioNu.Size = new System.Drawing.Size(54, 24);
            this.radioNu.TabIndex = 32;
            this.radioNu.TabStop = true;
            this.radioNu.Text = "Nữ";
            this.radioNu.UseVisualStyleBackColor = false;
            // 
            // radioNam
            // 
            this.radioNam.AutoSize = true;
            this.radioNam.BackColor = System.Drawing.Color.Honeydew;
            this.radioNam.Location = new System.Drawing.Point(778, 70);
            this.radioNam.Name = "radioNam";
            this.radioNam.Size = new System.Drawing.Size(67, 24);
            this.radioNam.TabIndex = 31;
            this.radioNam.TabStop = true;
            this.radioNam.Text = "Nam";
            this.radioNam.UseVisualStyleBackColor = false;
            // 
            // cmbLoaiThe
            // 
            this.cmbLoaiThe.Enabled = false;
            this.cmbLoaiThe.FormattingEnabled = true;
            this.cmbLoaiThe.Location = new System.Drawing.Point(778, 123);
            this.cmbLoaiThe.Name = "cmbLoaiThe";
            this.cmbLoaiThe.Size = new System.Drawing.Size(350, 28);
            this.cmbLoaiThe.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(644, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Loại thẻ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(644, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Giới tính";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(184, 120);
            this.txtPass.MaxLength = 6;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(350, 26);
            this.txtPass.TabIndex = 27;
            this.txtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPass_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Mật khẩu";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(184, 72);
            this.txtSDT.MaxLength = 11;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(350, 26);
            this.txtSDT.TabIndex = 25;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Số điện thoại:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mathe,
            this.SDT,
            this.LoaiThe});
            this.dataGridView1.Location = new System.Drawing.Point(29, 280);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1099, 288);
            this.dataGridView1.TabIndex = 45;
            this.dataGridView1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dataGridView1_Scroll);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
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
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(308, 191);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 65);
            this.btnUpdate.TabIndex = 56;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(124, 191);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(84, 65);
            this.btnNew.TabIndex = 55;
            this.btnNew.Text = "Thêm";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(946, 191);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 65);
            this.btnExit.TabIndex = 58;
            this.btnExit.Text = "thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Mathe
            // 
            this.Mathe.DataPropertyName = "Mathe";
            this.Mathe.HeaderText = "Mã thẻ";
            this.Mathe.MinimumWidth = 8;
            this.Mathe.Name = "Mathe";
            this.Mathe.Width = 150;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.MinimumWidth = 8;
            this.SDT.Name = "SDT";
            this.SDT.Width = 150;
            // 
            // LoaiThe
            // 
            this.LoaiThe.DataPropertyName = "TenThe";
            this.LoaiThe.HeaderText = "Loại Thẻ";
            this.LoaiThe.MinimumWidth = 8;
            this.LoaiThe.Name = "LoaiThe";
            this.LoaiThe.Width = 150;
            // 
            // frmQLTheXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 659);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtMaThe);
            this.Controls.Add(this.labelMathe);
            this.Controls.Add(this.radioNu);
            this.Controls.Add(this.radioNam);
            this.Controls.Add(this.cmbLoaiThe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label1);
            this.Name = "frmQLTheXe";
            this.Text = "frmQLTheXe";
            this.Load += new System.EventHandler(this.frmQLTheXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMaThe;
        private System.Windows.Forms.Label labelMathe;
        private System.Windows.Forms.RadioButton radioNu;
        private System.Windows.Forms.RadioButton radioNam;
        private System.Windows.Forms.ComboBox cmbLoaiThe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mathe;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiThe;
    }
}