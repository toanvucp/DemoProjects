namespace QuanLyTBVT.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBQLVT : DbContext
    {
        public DBQLVT()
            : base("name=DBQLVT")
        {
        }

        public virtual DbSet<ChiTietKhoVatTu> ChiTietKhoVatTus { get; set; }
        public virtual DbSet<ChiTietPhieuKT> ChiTietPhieuKTs { get; set; }
        public virtual DbSet<ChiTietPhieuNhap> ChiTietPhieuNhaps { get; set; }
        public virtual DbSet<ChiTietPhieuXuat> ChiTietPhieuXuats { get; set; }
        public virtual DbSet<ChiTietPhieuYC> ChiTietPhieuYCs { get; set; }
        public virtual DbSet<KhoVatTu> KhoVatTus { get; set; }
        public virtual DbSet<LoaiVatTu> LoaiVatTus { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<PhieuKT> PhieuKTs { get; set; }
        public virtual DbSet<PhieuNhap> PhieuNhaps { get; set; }
        public virtual DbSet<PhieuXuat> PhieuXuats { get; set; }
        public virtual DbSet<PhieuYC> PhieuYCs { get; set; }
        public virtual DbSet<PXTD> PXTDs { get; set; }
        public virtual DbSet<VatTu> VatTus { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietKhoVatTu>()
                .Property(e => e.MaKhoVT)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietKhoVatTu>()
                .Property(e => e.MaVT)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietKhoVatTu>()
                .Property(e => e.TriGiaTonKho)
                .HasPrecision(19, 4);


            modelBuilder.Entity<ChiTietPhieuKT>()
                .Property(e => e.MaPhieuKT)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietPhieuKT>()
                .Property(e => e.MaVT)
                .IsFixedLength();

            modelBuilder.Entity<ChiTietPhieuKT>()
                .Property(e => e.SerialNumber)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietPhieuNhap>()
                .Property(e => e.MaPhieuNhap)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietPhieuNhap>()
                .Property(e => e.MaVT)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietPhieuNhap>()
                .Property(e => e.MaKhoVT)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietPhieuNhap>()
                .Property(e => e.SerialNumber)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietPhieuNhap>()
                .Property(e => e.MaNCC)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietPhieuNhap>()
                .Property(e => e.DonGia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ChiTietPhieuXuat>()
                .Property(e => e.MaPX)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietPhieuXuat>()
                .Property(e => e.MaPhieuYC)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietPhieuXuat>()
                .Property(e => e.MaPhieuKT)
                .IsFixedLength();

            modelBuilder.Entity<ChiTietPhieuXuat>()
                .Property(e => e.MaVT)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietPhieuXuat>()
                .Property(e => e.MaKhoVT)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietPhieuXuat>()
                .Property(e => e.SerialNumber)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietPhieuXuat>()
                .Property(e => e.DonGia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ChiTietPhieuYC>()
                .Property(e => e.MaPhieuYC)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietPhieuYC>()
                .Property(e => e.NguoiDuyet)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietPhieuYC>()
                .Property(e => e.MaKhoVT)
                .IsUnicode(false);

            modelBuilder.Entity<KhoVatTu>()
                .Property(e => e.MaKhoVT)
                .IsUnicode(false);

            modelBuilder.Entity<LoaiVatTu>()
                .Property(e => e.MaLoaiVT)
                .IsUnicode(false);

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.MaNCC)
                .IsUnicode(false);

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.MST)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.PhongBan)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.Avatar)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuKT>()
                .Property(e => e.MaPhieuKT)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuKT>()
                .Property(e => e.NguoiLap)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuKT>()
                .Property(e => e.NguoiThamGia)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuNhap>()
                .Property(e => e.MaPhieuNhap)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuNhap>()
                .Property(e => e.MaNCC)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuNhap>()
                .Property(e => e.NguoiLap)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuNhap>()
                .Property(e => e.NguoiDuyet)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuXuat>()
                .Property(e => e.MaPX)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuXuat>()
                .Property(e => e.MaPXTD)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuXuat>()
                .Property(e => e.NguoiLap)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuXuat>()
                .Property(e => e.NguoiDuyet)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuYC>()
                .Property(e => e.MaPhieuYC)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuYC>()
                .Property(e => e.NguoiLap)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuYC>()
                .Property(e => e.NguoiDuyet)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuYC>()
                .Property(e => e.MaKhoVT)
                .IsUnicode(false);

            modelBuilder.Entity<PXTD>()
                .Property(e => e.MaPXTD)
                .IsUnicode(false);

            modelBuilder.Entity<PXTD>()
                .Property(e => e.ParentID)
                .IsUnicode(false);

            modelBuilder.Entity<VatTu>()
                .Property(e => e.MaVT)
                .IsUnicode(false);

            modelBuilder.Entity<VatTu>()
                .Property(e => e.MaLoaiVT)
                .IsUnicode(false);

            modelBuilder.Entity<VatTu>()
                .Property(e => e.MaNCC)
                .IsUnicode(false);

            modelBuilder.Entity<VatTu>()
                .Property(e => e.DonGia)
                .HasPrecision(19, 4);
        }
    }
}
