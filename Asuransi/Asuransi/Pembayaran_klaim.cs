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
    
    public partial class Pembayaran_klaim
    {
        public int no_pembayaran_klaim { get; set; }
        public int id_nasabah { get; set; }
        public int kode_asuransi { get; set; }
        public int id_pegawai { get; set; }
        public System.DateTime tanggal_klaim { get; set; }
        public int jumlah_bayar { get; set; }
    
        public virtual Admin Admin { get; set; }
        public virtual Jenis_asuransi Jenis_asuransi { get; set; }
        public virtual Nasabah Nasabah { get; set; }
    }
}
