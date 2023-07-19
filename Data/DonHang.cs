﻿using System;
using System.Security.Permissions;

namespace My_web_API.Data
{
    public enum TinhTrangDonHang
    {
        New = 0,  Payment = 1, Complete = 2, Cancel = -1
    }
    public class DonHang
    {
        public Guid MaDh { get; set; }
        public DateTime NgayDat { get; set; }
        public DateTime? NgayGiao { get; set; }
        
        public TinhTrangDonHang TinhTrangDonHang { get; set; }
        public string NguoiNhan { get; set; }
        public string DiaChiGiao { get; set; }
        public string SoDienThoai { get; set; }

    }
}
