//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAnQuanLyTapHoa.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrdersDetail
    {
        public int MaOrD { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<int> ThanhTien { get; set; }
        public Nullable<int> MaSP { get; set; }
        public Nullable<int> MaOr { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual SanPham SanPham { get; set; }
    }
}
