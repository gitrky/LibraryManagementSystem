//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCLIBRARY.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_MESSAGE
    {
        public int ID { get; set; }
        public string SENDER { get; set; }
        public string TAKER { get; set; }
        public string SUBJECT { get; set; }
        public string CONTENTS { get; set; }
        public Nullable<System.DateTime> DATE { get; set; }
    }
}
