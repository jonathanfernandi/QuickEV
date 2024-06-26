//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuickEV_Website.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Komunita
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Komunita()
        {
            this.Kegiatans = new HashSet<Kegiatan>();
            this.Users = new HashSet<User>();
            this.DetailKomunitas = new HashSet<DetailKomunita>();
        }
    
        public int IdKomunitas { get; set; }
        public string NamaKomunitas { get; set; }
        public string DeskripsiKomunitas { get; set; }
        public string FokusUtama { get; set; }
        public byte[] Logo { get; set; }
        public string Alamat { get; set; }
        public string Provinsi { get; set; }
        public string TelpKomunitas { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kegiatan> Kegiatans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetailKomunita> DetailKomunitas { get; set; }
    }
}
