//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Medicine.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MedicineOfDiseases
    {
        public int ID { get; set; }
        public int M_ID { get; set; }
        public int D_ID { get; set; }
        public int MinAge { get; set; }
        public Nullable<int> MaxAge { get; set; }
    }
}
