//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TheSkyMartSite.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Item_Details
    {
        public long Sno { get; set; }
        public long Item_code { get; set; }
        public string Item_main_image { get; set; }
        public string Item_image_1 { get; set; }
        public string Item_image_2 { get; set; }
        public string Item_image_3 { get; set; }
        public string Item_image_4 { get; set; }
        public string Item_image_5 { get; set; }
    
        public virtual Item_master Item_master { get; set; }
    }
}
