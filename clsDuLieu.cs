using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace T06_TreeView_DataGrridView_LenhSQL
{
    class clsDuLieu
    {
        SqlConnection cn = new SqlConnection();

        public bool KetNoi()
        {
            string ChuoiKN = @"Data Source = .\SQLEXPRESS; Initial Catalog = QLySinhVienCD; Integrated Security = True";
            try
            {
                if (cn.State == ConnectionState.Closed || cn.State == ConnectionState.Broken)
                {
                    cn.ConnectionString = ChuoiKN;
                    cn.Open();
                }
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối, vui lòng kiểm tra lại kết nối");
                return false;
            }
        }

        public void HienThiCay2Tang(TreeView tw, DataTable tblCha, DataTable tblCon, string TenCha, string MaBgCha, string TenCon, string MaBgCon)
        {
            TreeNode NutCha, NutCon;
            tw.Nodes.Clear();
            foreach (DataRow DongCha in tblCha.Rows)
            {
                NutCha = new TreeNode();
                NutCha.Text = DongCha[TenCha].ToString();
                NutCha.Tag = DongCha[MaBgCha].ToString();
                NutCha.ForeColor = Color.Brown;
                foreach (DataRow DongCon in tblCon.Rows)
                {
                    if (DongCon[MaBgCha].ToString().ToUpper() == NutCha.Tag.ToString().ToUpper())
                    {
                        NutCon = new TreeNode();
                        NutCon.Text = DongCon[TenCon].ToString() + "(" + DongCon[MaBgCon].ToString() + ")";
                        NutCon.Tag = DongCon[MaBgCon]; //Chỉ lấy mã bảng con
                        NutCon.ForeColor = Color.DarkCyan;
                        NutCha.Nodes.Add(NutCon);
                    }
                }
                tw.Nodes.Add(NutCha);
            }
            if (tw.Nodes.Count > 0) tw.Nodes[0].ExpandAll();
        }

        public DataTable LayDLcoDKSX(string TenBang, string DK = "", string TenFieldSX = "")
        {
            DataTable tbl = new DataTable();
            string ChuoiSQL = "Select * from " + TenBang;
            if (DK != "") ChuoiSQL += " Where " + DK;
            if (TenFieldSX != "") ChuoiSQL += " Order By " + TenFieldSX;
            SqlDataAdapter da = new SqlDataAdapter(ChuoiSQL, cn);
            da.Fill(tbl);
            return tbl;
        }

        public DataTable LayBangDiem(string Ma)
        {
            string strSQL = "SELECT k.MaMH, TenMH, Diem, LanThi, SOTC " +
                "FROM MonHoc mh, KetQua k " +
                "WHERE (mh.MaMH = k.MaMH) AND k.MaSV = '" + Ma + "'";
            DataTable tbl = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(strSQL, cn);
            da.Fill(tbl);
            return tbl;
        }
    }
}
