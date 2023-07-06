using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T06_TreeView_DataGrridView_LenhSQL
{
    public partial class frmXemDiem : Form
    {
        clsDuLieu dl = new clsDuLieu();
        DataTable tblLop, tblSV, tblDiem;

        private void twLopSV_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode NutHH = twLopSV.SelectedNode;
            if (NutHH != null)
            {                
                string strMa = "";
                if (NutHH.Parent != null) //Đang chọn nút sinh viên
                {
                    strMa = NutHH.Tag.ToString();
                }
                tblDiem = dl.LayBangDiem(strMa);
                dgrDiemThi.DataSource = tblDiem;
                if (tblDiem.Rows.Count == 0)
                {
                    if (strMa == "") //Đang chọn nút Lớp
                    {
                        lblThongTin.Text = "Lớp: " + NutHH.Text + " (Sỉ số: " + NutHH.Nodes.Count + ")";
                    }
                    else //Đang chọn nút sinh viên
                    {
                        lblThongTin.Text = "Sinh viên " + NutHH.Text + " Chưa thi môn nào ";
                    }
                }
                else
                {
                    lblThongTin.Text = "Điểm thi của " + NutHH.Text;
                }
            }
        }

        public frmXemDiem()
        {
            InitializeComponent();
        }

        private void frmXemDiem_Load(object sender, EventArgs e)
        {
            if (!dl.KetNoi())
            {
                Close();
                return;
            }
            tblLop = dl.LayDLcoDKSX("Lop", "", "TenLop");
            tblSV = dl.LayDLcoDKSX("SinhVien", "", "MaSV");
            dl.HienThiCay2Tang(twLopSV, tblLop, tblSV, "TenLop", "MaLop", "HoTenSV", "MaSV");
        }
    }
}
