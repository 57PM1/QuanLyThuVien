//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAnCNPM
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_sach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_sach()
        {
            this.tbl_chitietphieu = new HashSet<tbl_chitietphieu>();
            this.tbl_tacgia = new HashSet<tbl_tacgia>();
        }
    
        public int masach { get; set; }
        public string tensach { get; set; }
        public Nullable<int> manxb { get; set; }
        public Nullable<int> malv { get; set; }
        public Nullable<int> sotrang { get; set; }
        public Nullable<int> soluonghientai { get; set; }
        public Nullable<int> soluongbandau { get; set; }
        public string ngaynhap { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_chitietphieu> tbl_chitietphieu { get; set; }
        public virtual tbl_linhvuc tbl_linhvuc { get; set; }
        public virtual tbl_nxb tbl_nxb { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_tacgia> tbl_tacgia { get; set; }
    }
}
