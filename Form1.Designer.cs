namespace QuanLyDanhBa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtsodienthoai = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTenGoi = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.gridNguoi = new System.Windows.Forms.DataGridView();
            this.tenGoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsNguoi = new System.Windows.Forms.BindingSource(this.components);
            this.gridNhom = new System.Windows.Forms.DataGridView();
            this.tenNhomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsNhom = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThemNhom = new System.Windows.Forms.ToolStripButton();
            this.btnXoaN = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnThemNguoi = new System.Windows.Forms.ToolStripButton();
            this.txtTimKiem = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnXoaNg = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNguoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNguoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridNhom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhom)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtsodienthoai);
            this.panel1.Controls.Add(this.txtemail);
            this.panel1.Controls.Add(this.txtdiachi);
            this.panel1.Controls.Add(this.lblPhoneNumber);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.txtTenGoi);
            this.panel1.Controls.Add(this.lblDiaChi);
            this.panel1.Controls.Add(this.gridNguoi);
            this.panel1.Controls.Add(this.gridNhom);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 426);
            this.panel1.TabIndex = 0;
            // 
            // txtsodienthoai
            // 
            this.txtsodienthoai.AutoSize = true;
            this.txtsodienthoai.Location = new System.Drawing.Point(391, 400);
            this.txtsodienthoai.Name = "txtsodienthoai";
            this.txtsodienthoai.Size = new System.Drawing.Size(0, 13);
            this.txtsodienthoai.TabIndex = 5;
            // 
            // txtemail
            // 
            this.txtemail.AutoSize = true;
            this.txtemail.Location = new System.Drawing.Point(391, 374);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(0, 13);
            this.txtemail.TabIndex = 5;
            // 
            // txtdiachi
            // 
            this.txtdiachi.AutoSize = true;
            this.txtdiachi.Location = new System.Drawing.Point(391, 343);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(0, 13);
            this.txtdiachi.TabIndex = 5;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(283, 400);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(73, 13);
            this.lblPhoneNumber.TabIndex = 4;
            this.lblPhoneNumber.Text = "Số điện thoại:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(283, 374);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // txtTenGoi
            // 
            this.txtTenGoi.AutoSize = true;
            this.txtTenGoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenGoi.Location = new System.Drawing.Point(281, 305);
            this.txtTenGoi.Name = "txtTenGoi";
            this.txtTenGoi.Size = new System.Drawing.Size(0, 25);
            this.txtTenGoi.TabIndex = 3;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(283, 343);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(43, 13);
            this.lblDiaChi.TabIndex = 3;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // gridNguoi
            // 
            this.gridNguoi.AutoGenerateColumns = false;
            this.gridNguoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridNguoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenGoiDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn});
            this.gridNguoi.DataSource = this.bdsNguoi;
            this.gridNguoi.Location = new System.Drawing.Point(267, 28);
            this.gridNguoi.Name = "gridNguoi";
            this.gridNguoi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridNguoi.Size = new System.Drawing.Size(573, 263);
            this.gridNguoi.TabIndex = 2;
            this.gridNguoi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridNguoi_CellContentClick);
            // 
            // tenGoiDataGridViewTextBoxColumn
            // 
            this.tenGoiDataGridViewTextBoxColumn.DataPropertyName = "TenGoi";
            this.tenGoiDataGridViewTextBoxColumn.HeaderText = "Tên gọi";
            this.tenGoiDataGridViewTextBoxColumn.Name = "tenGoiDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // bdsNguoi
            // 
            this.bdsNguoi.DataSource = typeof(QuanLyDanhBa.Model.Nguoi);
            // 
            // gridNhom
            // 
            this.gridNhom.AutoGenerateColumns = false;
            this.gridNhom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridNhom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenNhomDataGridViewTextBoxColumn});
            this.gridNhom.DataSource = this.bdsNhom;
            this.gridNhom.Location = new System.Drawing.Point(3, 28);
            this.gridNhom.Name = "gridNhom";
            this.gridNhom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridNhom.Size = new System.Drawing.Size(258, 395);
            this.gridNhom.TabIndex = 1;
            this.gridNhom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridNhom_CellContentClick);
            // 
            // tenNhomDataGridViewTextBoxColumn
            // 
            this.tenNhomDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenNhomDataGridViewTextBoxColumn.DataPropertyName = "TenNhom";
            this.tenNhomDataGridViewTextBoxColumn.HeaderText = "Tên nhóm";
            this.tenNhomDataGridViewTextBoxColumn.Name = "tenNhomDataGridViewTextBoxColumn";
            // 
            // bdsNhom
            // 
            this.bdsNhom.DataSource = typeof(QuanLyDanhBa.Model.Nhom);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemNhom,
            this.btnXoaN,
            this.toolStripSeparator1,
            this.btnThemNguoi,
            this.txtTimKiem,
            this.toolStripLabel1,
            this.btnXoaNg});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(843, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThemNhom
            // 
            this.btnThemNhom.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNhom.Image")));
            this.btnThemNhom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemNhom.Name = "btnThemNhom";
            this.btnThemNhom.Size = new System.Drawing.Size(92, 22);
            this.btnThemNhom.Text = "Thêm nhóm";
            this.btnThemNhom.Click += new System.EventHandler(this.btnThemNhom_Click);
            // 
            // btnXoaN
            // 
            this.btnXoaN.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaN.Image")));
            this.btnXoaN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoaN.Name = "btnXoaN";
            this.btnXoaN.Size = new System.Drawing.Size(84, 22);
            this.btnXoaN.Text = "Xóa Nhóm";
            this.btnXoaN.Click += new System.EventHandler(this.btnXoaN_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnThemNguoi
            // 
            this.btnThemNguoi.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNguoi.Image")));
            this.btnThemNguoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemNguoi.Name = "btnThemNguoi";
            this.btnThemNguoi.Size = new System.Drawing.Size(97, 22);
            this.btnThemNguoi.Text = "Thêm liên lạc";
            this.btnThemNguoi.Click += new System.EventHandler(this.btnThemNguoi_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtTimKiem.BackColor = System.Drawing.SystemColors.Window;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(100, 25);
            this.txtTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyDown);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(93, 22);
            this.toolStripLabel1.Text = "Nhập từ cần tìm";
            // 
            // btnXoaNg
            // 
            this.btnXoaNg.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaNg.Image")));
            this.btnXoaNg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoaNg.Name = "btnXoaNg";
            this.btnXoaNg.Size = new System.Drawing.Size(87, 22);
            this.btnXoaNg.Text = "Xóa liên lạc";
            this.btnXoaNg.Click += new System.EventHandler(this.btnXoaNg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "CHƯƠNG TRÌNH QUẢN LÝ DANH BẠ - [Họ tên sinh viên]";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNguoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNguoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridNhom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhom)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gridNguoi;
        private System.Windows.Forms.DataGridView gridNhom;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label txtTenGoi;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label txtsodienthoai;
        private System.Windows.Forms.Label txtemail;
        private System.Windows.Forms.Label txtdiachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhomDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bdsNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenGoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bdsNguoi;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThemNhom;
        private System.Windows.Forms.ToolStripButton btnXoaN;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnThemNguoi;
        private System.Windows.Forms.ToolStripTextBox txtTimKiem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnXoaNg;
    }
}

