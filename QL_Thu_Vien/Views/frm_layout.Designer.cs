﻿namespace DoAnCNPM
{
    partial class frm_main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.item_capnhat = new System.Windows.Forms.ToolStripMenuItem();
            this.item_capnhat_nhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.item_capnhat_sach = new System.Windows.Forms.ToolStripMenuItem();
            this.item_capnhat_docgia = new System.Windows.Forms.ToolStripMenuItem();
            this.item_capnhat_tacgia = new System.Windows.Forms.ToolStripMenuItem();
            this.item_capnhat_nxb = new System.Windows.Forms.ToolStripMenuItem();
            this.item_capnhat_linhvuc = new System.Windows.Forms.ToolStripMenuItem();
            this.xửPhạtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item_muontra_sach = new System.Windows.Forms.ToolStripMenuItem();
            this.item_baocao = new System.Windows.Forms.ToolStripMenuItem();
            this.sáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.độcGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêTiềnPhạtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item_thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item_capnhat,
            this.item_muontra_sach,
            this.item_baocao,
            this.item_thoat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1284, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // item_capnhat
            // 
            this.item_capnhat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item_capnhat_nhanvien,
            this.item_capnhat_sach,
            this.item_capnhat_docgia,
            this.item_capnhat_tacgia,
            this.item_capnhat_nxb,
            this.item_capnhat_linhvuc,
            this.xửPhạtToolStripMenuItem});
            this.item_capnhat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_capnhat.Name = "item_capnhat";
            this.item_capnhat.Size = new System.Drawing.Size(72, 21);
            this.item_capnhat.Text = "Cập nhật";
            // 
            // item_capnhat_nhanvien
            // 
            this.item_capnhat_nhanvien.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_capnhat_nhanvien.Name = "item_capnhat_nhanvien";
            this.item_capnhat_nhanvien.Size = new System.Drawing.Size(158, 22);
            this.item_capnhat_nhanvien.Text = "Nhân viên";
            this.item_capnhat_nhanvien.Click += new System.EventHandler(this.btn_capnhat_nhanvien_Click);
            // 
            // item_capnhat_sach
            // 
            this.item_capnhat_sach.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_capnhat_sach.Name = "item_capnhat_sach";
            this.item_capnhat_sach.Size = new System.Drawing.Size(158, 22);
            this.item_capnhat_sach.Text = "Sách";
            this.item_capnhat_sach.Click += new System.EventHandler(this.btn_capnhat_sach_Click);
            // 
            // item_capnhat_docgia
            // 
            this.item_capnhat_docgia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_capnhat_docgia.Name = "item_capnhat_docgia";
            this.item_capnhat_docgia.Size = new System.Drawing.Size(158, 22);
            this.item_capnhat_docgia.Text = "Độc giả";
            this.item_capnhat_docgia.Click += new System.EventHandler(this.btn_capnhat_docgia_Click);
            // 
            // item_capnhat_tacgia
            // 
            this.item_capnhat_tacgia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_capnhat_tacgia.Name = "item_capnhat_tacgia";
            this.item_capnhat_tacgia.Size = new System.Drawing.Size(158, 22);
            this.item_capnhat_tacgia.Text = "Tác giả";
            this.item_capnhat_tacgia.Click += new System.EventHandler(this.btn_capnhat_tacgia_Click);
            // 
            // item_capnhat_nxb
            // 
            this.item_capnhat_nxb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_capnhat_nxb.Name = "item_capnhat_nxb";
            this.item_capnhat_nxb.Size = new System.Drawing.Size(158, 22);
            this.item_capnhat_nxb.Text = "Nhà xuất bản ";
            this.item_capnhat_nxb.Click += new System.EventHandler(this.btn_capnhat_nxb_Click);
            // 
            // item_capnhat_linhvuc
            // 
            this.item_capnhat_linhvuc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_capnhat_linhvuc.Name = "item_capnhat_linhvuc";
            this.item_capnhat_linhvuc.Size = new System.Drawing.Size(158, 22);
            this.item_capnhat_linhvuc.Text = "Lĩnh vực";
            this.item_capnhat_linhvuc.Click += new System.EventHandler(this.btn_capnhat_linhvuc_Click);
            // 
            // xửPhạtToolStripMenuItem
            // 
            this.xửPhạtToolStripMenuItem.Name = "xửPhạtToolStripMenuItem";
            this.xửPhạtToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.xửPhạtToolStripMenuItem.Text = "Xử phạt";
            this.xửPhạtToolStripMenuItem.Click += new System.EventHandler(this.xửPhạtToolStripMenuItem_Click);
            // 
            // item_muontra_sach
            // 
            this.item_muontra_sach.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_muontra_sach.Name = "item_muontra_sach";
            this.item_muontra_sach.Size = new System.Drawing.Size(106, 21);
            this.item_muontra_sach.Text = "Mượn/trả sách";
            this.item_muontra_sach.Click += new System.EventHandler(this.btn_muontra_sach_Click);
            // 
            // item_baocao
            // 
            this.item_baocao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sáchToolStripMenuItem,
            this.độcGiảToolStripMenuItem,
            this.thốngKêTiềnPhạtToolStripMenuItem});
            this.item_baocao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_baocao.Name = "item_baocao";
            this.item_baocao.Size = new System.Drawing.Size(67, 21);
            this.item_baocao.Text = "Báo cáo";
            // 
            // sáchToolStripMenuItem
            // 
            this.sáchToolStripMenuItem.Name = "sáchToolStripMenuItem";
            this.sáchToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.sáchToolStripMenuItem.Text = "Sách sắp hết số lượng";
            this.sáchToolStripMenuItem.Click += new System.EventHandler(this.sáchToolStripMenuItem_Click);
            // 
            // độcGiảToolStripMenuItem
            // 
            this.độcGiảToolStripMenuItem.Name = "độcGiảToolStripMenuItem";
            this.độcGiảToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.độcGiảToolStripMenuItem.Text = "Độc giả mượn quá hạn";
            this.độcGiảToolStripMenuItem.Click += new System.EventHandler(this.btn_bcdocgia_muonquahan_Click);
            // 
            // thốngKêTiềnPhạtToolStripMenuItem
            // 
            this.thốngKêTiềnPhạtToolStripMenuItem.Name = "thốngKêTiềnPhạtToolStripMenuItem";
            this.thốngKêTiềnPhạtToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.thốngKêTiềnPhạtToolStripMenuItem.Text = "Thống kê tiền phạt";
            this.thốngKêTiềnPhạtToolStripMenuItem.Click += new System.EventHandler(this.thốngKêTiềnPhạtToolStripMenuItem_Click);
            // 
            // item_thoat
            // 
            this.item_thoat.Name = "item_thoat";
            this.item_thoat.Size = new System.Drawing.Size(53, 21);
            this.item_thoat.Text = "Thoát";
            this.item_thoat.Click += new System.EventHandler(this.item_thoat_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(4, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 529);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_main";
            this.Text = "QUẢN LÝ THƯ VIỆN";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem item_capnhat;
        private System.Windows.Forms.ToolStripMenuItem item_capnhat_nhanvien;
        private System.Windows.Forms.ToolStripMenuItem item_capnhat_sach;
        private System.Windows.Forms.ToolStripMenuItem item_capnhat_docgia;
        private System.Windows.Forms.ToolStripMenuItem item_capnhat_tacgia;
        private System.Windows.Forms.ToolStripMenuItem item_capnhat_nxb;
        private System.Windows.Forms.ToolStripMenuItem item_capnhat_linhvuc;
        private System.Windows.Forms.ToolStripMenuItem item_muontra_sach;
        private System.Windows.Forms.ToolStripMenuItem item_baocao;
        private System.Windows.Forms.ToolStripMenuItem item_thoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem sáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem độcGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xửPhạtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêTiềnPhạtToolStripMenuItem;
    }
}

