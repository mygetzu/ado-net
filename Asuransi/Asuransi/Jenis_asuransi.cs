//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Asuransi
{
    using System;
    using System.Collections.Generic;
    
    public partial class Jenis_asuransi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Jenis_asuransi()
        {
            this.Asuransi_nasabah = new HashSet<Asuransi_nasabah>();
            this.Pembayaran_klaim = new HashSet<Pembayaran_klaim>();
            this.Setoran = new HashSet<Setoran>();
        }
    
        public int kode_asuransi { get; set; }
        public string jenis_asuransi1 { get; set; }
        public int nilai_asuransi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Asuransi_nasabah> Asuransi_nasabah { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pembayaran_klaim> Pembayaran_klaim { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Setoran> Setoran { get; set; }
    }
}
