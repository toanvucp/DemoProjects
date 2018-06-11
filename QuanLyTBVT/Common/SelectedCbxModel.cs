using QuanLyTBVT.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTBVT.Common
{
    public class SelectedCbxModel
    {
        public string ValueMember { get; set; }

        public string DisPlayMember { get; set; }
    }


    public class SelectedCbx
    {
        private DBQLVT db;

        public List<SelectedCbxModel> GetCbxLoaiVT()
        {
            db = new DBQLVT();
            List<SelectedCbxModel> result = new List<SelectedCbxModel>();
            result = (from m in db.LoaiVatTus select new SelectedCbxModel() { ValueMember = m.MaLoaiVT, DisPlayMember = m.MaLoaiVT + " - " + m.TenLoaiVT }).ToList();
            return result;
        }


        public List<SelectedCbxModel> GetCbxNCC()
        {
            db = new DBQLVT();
            List<SelectedCbxModel> result = new List<SelectedCbxModel>();
            result = (from m in db.NhaCungCaps select new SelectedCbxModel() { ValueMember = m.MaNCC, DisPlayMember = m.MaNCC + " - " + m.TenNCC }).ToList();
            return result;
        }

        public List<SelectedCbxModel> CreateTreeDV(bool isAdd)
        {
            db = new DBQLVT();
            mlstReturn = new List<SelectedCbxModel>();
            List<PXTD> model = (from m in db.PXTDs select m).ToList();
            //List<KhoVatTu> vlstTest = model.ToList() as List<KhoVatTu>;
            var root = model.GenerateTree(c => c.MaPXTD, c => c.ParentID);
            GetTreeList(root);
            if (isAdd)//Them moi
            {
                SelectedCbxModel sel = new SelectedCbxModel() { DisPlayMember = "---Chọn---", ValueMember = "" };
                mlstReturn.Insert(0, sel);
            }
            return mlstReturn;
        }

        private static List<SelectedCbxModel> mlstReturn = new List<SelectedCbxModel>();

        static void GetTreeList(IEnumerable<TreeItem<PXTD>> categories, int deep = 0)
        {
            foreach (var c in categories)
            {
                mlstReturn.Add(new SelectedCbxModel() { ValueMember = c.Item.MaPXTD, DisPlayMember = GenString("    ", deep) + c.Item.TenPXTD });

                //Debug.WriteLine(new String('\t', deep) + c.Item.TenKho);
                GetTreeList(c.Children, deep + 1);
            }
        }


        private static string GenString(string show, int member)
        {
            string str = "";
            for (int i = 0; i < member; i++)
            {
                str += show;
            }
            return str;
        }

        public bool CheckChildExist(string maKho)
        {
            db = new DBQLVT();
            object[] sqlParam =
            {
                new SqlParameter("@dept", maKho),
                new SqlParameter("@contain",false)
            };
            var res = db.Database.SqlQuery<KhoVatTu>("proc_getAllChildInDept @dept, @contain", sqlParam).ToList();
            if (res != null && res.Count > 0)
            {
                return true;
            }
            return false;
        }


        public List<SelectedCbxModel> GetCbxNhanVien(bool isAdd)
        {
            db = new DBQLVT();
            List<SelectedCbxModel> result = new List<SelectedCbxModel>();
            result = db.NhanViens.ToList().Select(m => new SelectedCbxModel()
            {
                DisPlayMember = m.Email.Split('@')[0],
                ValueMember = m.Email.Split('@')[0]
            }).ToList();
            return result;
        }

    }
}
