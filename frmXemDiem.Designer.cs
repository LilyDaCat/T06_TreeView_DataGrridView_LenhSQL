namespace T06_TreeView_DataGrridView_LenhSQL
{
    partial class frmXemDiem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.twLopSV = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgrDiemThi = new System.Windows.Forms.DataGridView();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.MaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LanThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDiemThi)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.twLopSV);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgrDiemThi);
            this.splitContainer1.Panel2.Controls.Add(this.lblThongTin);
            this.splitContainer1.Size = new System.Drawing.Size(822, 450);
            this.splitContainer1.SplitterDistance = 273;
            this.splitContainer1.TabIndex = 1;
            // 
            // twLopSV
            // 
            this.twLopSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.twLopSV.Location = new System.Drawing.Point(0, 38);
            this.twLopSV.Name = "twLopSV";
            this.twLopSV.Size = new System.Drawing.Size(273, 412);
            this.twLopSV.TabIndex = 1;
            this.twLopSV.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.twLopSV_AfterSelect);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH LỚP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgrDiemThi
            // 
            this.dgrDiemThi.AllowUserToAddRows = false;
            this.dgrDiemThi.AllowUserToDeleteRows = false;
            this.dgrDiemThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrDiemThi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMH,
            this.TenMH,
            this.Diem,
            this.LanThi,
            this.TinChi});
            this.dgrDiemThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrDiemThi.Location = new System.Drawing.Point(0, 38);
            this.dgrDiemThi.Name = "dgrDiemThi";
            this.dgrDiemThi.ReadOnly = true;
            this.dgrDiemThi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrDiemThi.Size = new System.Drawing.Size(545, 412);
            this.dgrDiemThi.TabIndex = 1;
            // 
            // lblThongTin
            // 
            this.lblThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblThongTin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblThongTin.Location = new System.Drawing.Point(0, 0);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(545, 38);
            this.lblThongTin.TabIndex = 0;
            this.lblThongTin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MaMH
            // 
            this.MaMH.DataPropertyName = "MaMH";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MaMH.DefaultCellStyle = dataGridViewCellStyle1;
            this.MaMH.HeaderText = "Mã MH";
            this.MaMH.Name = "MaMH";
            this.MaMH.ReadOnly = true;
            // 
            // TenMH
            // 
            this.TenMH.DataPropertyName = "TenMH";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TenMH.DefaultCellStyle = dataGridViewCellStyle2;
            this.TenMH.HeaderText = "Tên Môn Học";
            this.TenMH.Name = "TenMH";
            this.TenMH.ReadOnly = true;
            // 
            // Diem
            // 
            this.Diem.DataPropertyName = "Diem";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N1";
            dataGridViewCellStyle3.NullValue = "#0.0";
            this.Diem.DefaultCellStyle = dataGridViewCellStyle3;
            this.Diem.HeaderText = "Điểm";
            this.Diem.Name = "Diem";
            this.Diem.ReadOnly = true;
            // 
            // LanThi
            // 
            this.LanThi.DataPropertyName = "LanThi";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.LanThi.DefaultCellStyle = dataGridViewCellStyle4;
            this.LanThi.HeaderText = "Lần Thi";
            this.LanThi.Name = "LanThi";
            this.LanThi.ReadOnly = true;
            // 
            // TinChi
            // 
            this.TinChi.DataPropertyName = "SoTC";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TinChi.DefaultCellStyle = dataGridViewCellStyle5;
            this.TinChi.HeaderText = "Số Tín Chỉ";
            this.TinChi.Name = "TinChi";
            this.TinChi.ReadOnly = true;
            // 
            // frmXemDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmXemDiem";
            this.Text = "Xem điểm thi";
            this.Load += new System.EventHandler(this.frmXemDiem_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrDiemThi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView twLopSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgrDiemThi;
        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diem;
        private System.Windows.Forms.DataGridViewTextBoxColumn LanThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinChi;
    }
}

