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

        public int? SL { get; set; }
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

        public List<SelectedCbxModel> GetCbxVatTu(bool isAdd)
        {
            db = new DBQLVT();
            List<SelectedCbxModel> result = new List<SelectedCbxModel>();
            result = db.VatTus.ToList().Select(m => new SelectedCbxModel()
            {
                DisPlayMember = m.MaVT + " - " + m.TenVT,
                ValueMember = m.MaVT
            }).ToList();
            if (isAdd)
            {
                SelectedCbxModel sel = new SelectedCbxModel();
                sel.ValueMember = "";
                sel.DisPlayMember = "---Chọn---";
                result.Insert(0, sel);
            }
            return result;
        }

        public List<SelectedCbxModel> GetCbxStatusKTTB(bool isAdd)
        {
            db = new DBQLVT();
            List<SelectedCbxModel> result = new List<SelectedCbxModel>();
            result.Add(new SelectedCbxModel() { DisPlayMember = "Đạt", ValueMember = "1" });
            result.Add(new SelectedCbxModel() { DisPlayMember = "Không Đạt", ValueMember = "0" });
            return result;
        }

        public List<SelectedCbxModel> GetCbxKhoVT(bool isSearch)
        {
            db = new DBQLVT();
            List<SelectedCbxModel> result = new List<SelectedCbxModel>();
            result = db.KhoVatTus.Select(m => new SelectedCbxModel() { DisPlayMember = m.TenKhoVT, ValueMember = m.MaKhoVT }).ToList();
            if (isSearch)
            {
                SelectedCbxModel sel = new SelectedCbxModel();
                sel.ValueMember = "";
                sel.DisPlayMember = "---Chọn---";
                result.Insert(0, sel);
            }
            return result;
        }

        public List<SelectedCbxModel> GetCbxPTKT(bool isAdd)
        {
            db = new DBQLVT();
            List<SelectedCbxModel> result = new List<SelectedCbxModel>();
            result.Add(new SelectedCbxModel() { DisPlayMember = "Phương thức kiểm tra 1", ValueMember = "Phương thức kiểm tra 1" });
            result.Add(new SelectedCbxModel() { DisPlayMember = "Phương thức kiểm tra 2", ValueMember = "Phương thức kiểm tra 2" });
            result.Add(new SelectedCbxModel() { DisPlayMember = "Phương thức kiểm tra 3", ValueMember = "Phương thức kiểm tra 3" });
            return result;
        }

        public List<SelectedCbxModel> GetCbxTTVT(bool isAdd)
        {
            db = new DBQLVT();
            List<SelectedCbxModel> result = new List<SelectedCbxModel>();
            result.Add(new SelectedCbxModel() { DisPlayMember = "Mới", ValueMember = "Mới" });
            result.Add(new SelectedCbxModel() { DisPlayMember = "Like new", ValueMember = "Like new" });
            result.Add(new SelectedCbxModel() { DisPlayMember = "Lỗi", ValueMember = "Lỗi" });
            result.Add(new SelectedCbxModel() { DisPlayMember = "Hỏng", ValueMember = "Hỏng" });
            return result;
        }


        public List<SelectedCbxModel> GetCbxPhieuKT(string trangThai)
        {
            db = new DBQLVT();
            List<SelectedCbxModel> result = new List<SelectedCbxModel>();
            result = db.PhieuKTs.Where(m => m.TrangThai.Equals(trangThai)).Select(m => new SelectedCbxModel() { DisPlayMember = m.MaPhieuKT, ValueMember = m.MaPhieuKT}).ToList();
            return result;
        }

        public List<SelectedCbxModel> GetcbxPhieuYeuCau(string trangThai, bool isAdd)
        {
            db = new DBQLVT();
            List<SelectedCbxModel> result = new List<SelectedCbxModel>();
            result = db.PhieuYCs.Where(m => m.TrangThai.Equals(trangThai)).Select(m => new SelectedCbxModel() { DisPlayMember = m.MaPhieuYC, ValueMember = m.MaPhieuYC }).ToList();
            return result;
        }

        public List<SelectedCbxModel> GetCbxVatTuInKho(bool isAdd, string maPX)
        {
            db = new DBQLVT();
            List<SelectedCbxModel> result = new List<SelectedCbxModel>();
            var s = db.PhieuXuats.Find(maPX).MaKhoXuat;
            var model = db.ChiTietKhoVatTus.Where(m => m.MaKhoVT == s)
                .GroupBy(a => a.MaVT).Select(p => new { MaVT = p.Key, SoLuongTK = p.Sum(q => q.SoLuong) });
            var mos = model.ToList();
            var results = from m in db.VatTus
                          join n in mos on m.MaVT equals n.MaVT
                          select new SelectedCbxModel() { DisPlayMember = m.MaVT + " - " + m.TenVT, ValueMember = n.MaVT , SL = n.SoLuongTK};
            if (isAdd)
            {
                SelectedCbxModel sel = new SelectedCbxModel();
                sel.ValueMember = "";
                sel.DisPlayMember = "---Chọn---";
                results.ToList().Insert(0, sel);
            }
            return results.ToList();
        }
    }
}
