//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mark1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_Müsteriler
    {
        public int MüsteriID { get; set; }
        public string MüsteriAd { get; set; }
        public string MüsteriSoyad { get; set; }
        public string Tel { get; set; }
        public string TCNO { get; set; }
        public string HesKodu { get; set; }
        public Nullable<int> AraçID { get; set; }
    
        public virtual TB_Araçlar TB_Araçlar { get; set; }
    }
}
