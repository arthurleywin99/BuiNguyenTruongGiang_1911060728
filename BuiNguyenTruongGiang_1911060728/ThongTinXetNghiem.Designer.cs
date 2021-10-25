
namespace BuiNguyenTruongGiang_1911060728
{
    partial class ThongTinXetNghiem
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSapXep = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDuongTinh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvTTXN = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grTTXN = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cboCongTy = new System.Windows.Forms.ComboBox();
            this.optDuongTinh = new System.Windows.Forms.RadioButton();
            this.optAmTinh = new System.Windows.Forms.RadioButton();
            this.txtSLXN = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grTTNV = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTXN)).BeginInit();
            this.panel3.SuspendLayout();
            this.grTTXN.SuspendLayout();
            this.grTTNV.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 29);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSapXep,
            this.tsDuongTinh,
            this.toolStripSeparator1,
            this.tsThongKe});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(103, 25);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // tsSapXep
            // 
            this.tsSapXep.Name = "tsSapXep";
            this.tsSapXep.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.tsSapXep.Size = new System.Drawing.Size(385, 26);
            this.tsSapXep.Text = "Sắp xếp số lần xét nghiệm";
            this.tsSapXep.Click += new System.EventHandler(this.tsSapXep_Click);
            // 
            // tsDuongTinh
            // 
            this.tsDuongTinh.Name = "tsDuongTinh";
            this.tsDuongTinh.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.tsDuongTinh.Size = new System.Drawing.Size(385, 26);
            this.tsDuongTinh.Text = "Danh sách công ty có ca Dương tính";
            this.tsDuongTinh.Click += new System.EventHandler(this.tsDuongTinh_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(382, 6);
            // 
            // tsThongKe
            // 
            this.tsThongKe.Name = "tsThongKe";
            this.tsThongKe.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.tsThongKe.Size = new System.Drawing.Size(385, 26);
            this.tsThongKe.Text = "Xuất Thống Kê";
            this.tsThongKe.Click += new System.EventHandler(this.tsThongKe_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 532);
            this.panel1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1002, 529);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(271, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông Tin Xét Nghiệm";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(996, 418);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvTTXN);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(408, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(588, 418);
            this.panel4.TabIndex = 1;
            // 
            // dgvTTXN
            // 
            this.dgvTTXN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTTXN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTTXN.Location = new System.Drawing.Point(0, 0);
            this.dgvTTXN.Name = "dgvTTXN";
            this.dgvTTXN.Size = new System.Drawing.Size(588, 418);
            this.dgvTTXN.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grTTXN);
            this.panel3.Controls.Add(this.grTTNV);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(408, 418);
            this.panel3.TabIndex = 0;
            // 
            // grTTXN
            // 
            this.grTTXN.Controls.Add(this.btnUpdate);
            this.grTTXN.Controls.Add(this.cboCongTy);
            this.grTTXN.Controls.Add(this.optDuongTinh);
            this.grTTXN.Controls.Add(this.optAmTinh);
            this.grTTXN.Controls.Add(this.txtSLXN);
            this.grTTXN.Controls.Add(this.txtHoTen);
            this.grTTXN.Controls.Add(this.label6);
            this.grTTXN.Controls.Add(this.label5);
            this.grTTXN.Controls.Add(this.label4);
            this.grTTXN.Controls.Add(this.label3);
            this.grTTXN.Enabled = false;
            this.grTTXN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grTTXN.Location = new System.Drawing.Point(6, 103);
            this.grTTXN.Name = "grTTXN";
            this.grTTXN.Size = new System.Drawing.Size(399, 312);
            this.grTTXN.TabIndex = 1;
            this.grTTXN.TabStop = false;
            this.grTTXN.Text = "Thông tin xét nghiệm";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(121, 276);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(106, 30);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cboCongTy
            // 
            this.cboCongTy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCongTy.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCongTy.FormattingEnabled = true;
            this.cboCongTy.Location = new System.Drawing.Point(121, 220);
            this.cboCongTy.Name = "cboCongTy";
            this.cboCongTy.Size = new System.Drawing.Size(266, 31);
            this.cboCongTy.TabIndex = 9;
            // 
            // optDuongTinh
            // 
            this.optDuongTinh.AutoSize = true;
            this.optDuongTinh.Location = new System.Drawing.Point(121, 178);
            this.optDuongTinh.Name = "optDuongTinh";
            this.optDuongTinh.Size = new System.Drawing.Size(94, 23);
            this.optDuongTinh.TabIndex = 8;
            this.optDuongTinh.TabStop = true;
            this.optDuongTinh.Text = "Dương tính";
            this.optDuongTinh.UseVisualStyleBackColor = true;
            // 
            // optAmTinh
            // 
            this.optAmTinh.AutoSize = true;
            this.optAmTinh.Location = new System.Drawing.Point(121, 132);
            this.optAmTinh.Name = "optAmTinh";
            this.optAmTinh.Size = new System.Drawing.Size(74, 23);
            this.optAmTinh.TabIndex = 7;
            this.optAmTinh.Text = "Âm tính";
            this.optAmTinh.UseVisualStyleBackColor = true;
            // 
            // txtSLXN
            // 
            this.txtSLXN.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLXN.Location = new System.Drawing.Point(121, 77);
            this.txtSLXN.Name = "txtSLXN";
            this.txtSLXN.Size = new System.Drawing.Size(115, 32);
            this.txtSLXN.TabIndex = 6;
            this.txtSLXN.Text = "1";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(121, 30);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(266, 32);
            this.txtHoTen.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Công Ty";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "KQ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "SLXN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ Tên";
            // 
            // grTTNV
            // 
            this.grTTNV.Controls.Add(this.panel5);
            this.grTTNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grTTNV.Location = new System.Drawing.Point(6, 3);
            this.grTTNV.Name = "grTTNV";
            this.grTTNV.Size = new System.Drawing.Size(396, 82);
            this.grTTNV.TabIndex = 0;
            this.grTTNV.TabStop = false;
            this.grTTNV.Text = "Thông tin nhân viên";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnTim);
            this.panel5.Controls.Add(this.txtCMND);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(6, 25);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(384, 51);
            this.panel5.TabIndex = 0;
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(315, 14);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(66, 30);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtCMND
            // 
            this.txtCMND.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(115, 12);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(194, 32);
            this.txtCMND.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "CCCD/CMND";
            // 
            // ThongTinXetNghiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ThongTinXetNghiem";
            this.Text = "Thông Tin Xét Nghiệm";
            this.Load += new System.EventHandler(this.ThongTinXetNghiem_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTXN)).EndInit();
            this.panel3.ResumeLayout(false);
            this.grTTXN.ResumeLayout(false);
            this.grTTXN.PerformLayout();
            this.grTTNV.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox grTTXN;
        private System.Windows.Forms.GroupBox grTTNV;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTTXN;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cboCongTy;
        private System.Windows.Forms.RadioButton optDuongTinh;
        private System.Windows.Forms.RadioButton optAmTinh;
        private System.Windows.Forms.TextBox txtSLXN;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem tsSapXep;
        private System.Windows.Forms.ToolStripMenuItem tsDuongTinh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsThongKe;
    }
}

