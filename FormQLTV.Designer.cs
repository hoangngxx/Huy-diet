
namespace BTL
{
    partial class FormQLTV
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoaiSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTVDataSet = new BTL.QLTVDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comGT = new System.Windows.Forms.ComboBox();
            this.comTenTruong = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnLoc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrv = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sachTableAdapter = new BTL.QLTVDataSetTableAdapters.SachTableAdapter();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtMaLoaiSach = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtMaTG = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox1.Location = new System.Drawing.Point(89, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(318, 35);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Quản lý Tài liệu sách thư viện";
            // 
            // grdData
            // 
            this.grdData.AutoGenerateColumns = false;
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TenSach,
            this.MaLoaiSach,
            this.SoLuong,
            this.MaTG});
            this.grdData.DataSource = this.sachBindingSource;
            this.grdData.Location = new System.Drawing.Point(22, 88);
            this.grdData.Name = "grdData";
            this.grdData.RowHeadersWidth = 62;
            this.grdData.RowTemplate.Height = 28;
            this.grdData.Size = new System.Drawing.Size(460, 279);
            this.grdData.TabIndex = 1;
            this.grdData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdData_CellContentClick);
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "MaSach";
            this.MaSach.MinimumWidth = 8;
            this.MaSach.Name = "MaSach";
            this.MaSach.Width = 150;
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "TenSach";
            this.TenSach.MinimumWidth = 8;
            this.TenSach.Name = "TenSach";
            this.TenSach.Width = 150;
            // 
            // MaLoaiSach
            // 
            this.MaLoaiSach.DataPropertyName = "MaLoaiSach";
            this.MaLoaiSach.HeaderText = "MaLoaiSach";
            this.MaLoaiSach.MinimumWidth = 8;
            this.MaLoaiSach.Name = "MaLoaiSach";
            this.MaLoaiSach.Width = 150;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "SoLuong";
            this.SoLuong.MinimumWidth = 8;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 150;
            // 
            // MaTG
            // 
            this.MaTG.DataPropertyName = "MaTG";
            this.MaTG.HeaderText = "MaTG";
            this.MaTG.MinimumWidth = 8;
            this.MaTG.Name = "MaTG";
            this.MaTG.Width = 150;
            // 
            // sachBindingSource
            // 
            this.sachBindingSource.DataMember = "Sach";
            this.sachBindingSource.DataSource = this.qLTVDataSet;
            // 
            // qLTVDataSet
            // 
            this.qLTVDataSet.DataSetName = "QLTVDataSet";
            this.qLTVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comGT);
            this.groupBox1.Controls.Add(this.comTenTruong);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnLoc);
            this.groupBox1.Location = new System.Drawing.Point(500, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 142);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lọc dữ liệu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(149, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "=";
            // 
            // comGT
            // 
            this.comGT.FormattingEnabled = true;
            this.comGT.Location = new System.Drawing.Point(190, 55);
            this.comGT.Name = "comGT";
            this.comGT.Size = new System.Drawing.Size(136, 28);
            this.comGT.TabIndex = 5;
            // 
            // comTenTruong
            // 
            this.comTenTruong.FormattingEnabled = true;
            this.comTenTruong.Items.AddRange(new object[] {
            "TenSach",
            "MaLoaiSach"});
            this.comTenTruong.Location = new System.Drawing.Point(6, 55);
            this.comTenTruong.Name = "comTenTruong";
            this.comTenTruong.Size = new System.Drawing.Size(121, 28);
            this.comTenTruong.TabIndex = 4;
            this.comTenTruong.SelectedIndexChanged += new System.EventHandler(this.comTenTruong_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(209, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Giá trị lọc";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lọc theo";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(190, 89);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(136, 38);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Hủy lọc dữ liệu";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(6, 89);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(121, 38);
            this.btnLoc.TabIndex = 0;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(502, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(502, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(502, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "label6";
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(22, 394);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 32);
            this.btnFirst.TabIndex = 13;
            this.btnFirst.Text = "Đầu";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrv
            // 
            this.btnPrv.Location = new System.Drawing.Point(97, 394);
            this.btnPrv.Name = "btnPrv";
            this.btnPrv.Size = new System.Drawing.Size(75, 32);
            this.btnPrv.TabIndex = 14;
            this.btnPrv.Text = "Trước";
            this.btnPrv.UseVisualStyleBackColor = true;
            this.btnPrv.Click += new System.EventHandler(this.btnPrv_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(172, 394);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 32);
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = "Sau";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(247, 394);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 32);
            this.btnLast.TabIndex = 16;
            this.btnLast.Text = "Cuối";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(487, 413);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 17;
            this.btnAddNew.Text = "Thêm mới";
            this.btnAddNew.UseVisualStyleBackColor = true;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(568, 413);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 18;
            this.btn.Text = "button2";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(649, 413);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(730, 413);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(811, 413);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Kết thúc";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(937, 33);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.tàiKhoảnToolStripMenuItem.Text = "&Tài khoản";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(287, 34);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "1. Thông tin tài khoản";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(287, 34);
            this.đăngXuấtToolStripMenuItem.Text = "2. Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // sachTableAdapter
            // 
            this.sachTableAdapter.ClearBeforeFill = true;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(623, 228);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(181, 26);
            this.txtMaSach.TabIndex = 23;
            this.txtMaSach.TextChanged += new System.EventHandler(this.txtMaSach_TextChanged);
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(623, 266);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(181, 26);
            this.txtTenSach.TabIndex = 24;
            this.txtTenSach.TextChanged += new System.EventHandler(this.txtTenSach_TextChanged);
            // 
            // txtMaLoaiSach
            // 
            this.txtMaLoaiSach.Location = new System.Drawing.Point(623, 303);
            this.txtMaLoaiSach.Name = "txtMaLoaiSach";
            this.txtMaLoaiSach.Size = new System.Drawing.Size(181, 26);
            this.txtMaLoaiSach.TabIndex = 25;
            this.txtMaLoaiSach.TextChanged += new System.EventHandler(this.txtMaLoaiSach_TextChanged);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(624, 335);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(181, 26);
            this.txtSoLuong.TabIndex = 26;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            // 
            // txtMaTG
            // 
            this.txtMaTG.Location = new System.Drawing.Point(623, 371);
            this.txtMaTG.Name = "txtMaTG";
            this.txtMaTG.Size = new System.Drawing.Size(181, 26);
            this.txtMaTG.TabIndex = 27;
            this.txtMaTG.TextChanged += new System.EventHandler(this.txtMaTG_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(502, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(502, 377);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "label8";
            // 
            // FormQLTV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 549);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMaTG);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtMaLoaiSach);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrv);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grdData);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormQLTV";
            this.Text = "FormQLTV";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormQLTV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comGT;
        private System.Windows.Forms.ComboBox comTenTruong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrv;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private QLTVDataSet qLTVDataSet;
        private System.Windows.Forms.BindingSource sachBindingSource;
        private QLTVDataSetTableAdapters.SachTableAdapter sachTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTG;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtMaLoaiSach;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtMaTG;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}