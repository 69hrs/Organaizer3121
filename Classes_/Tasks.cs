//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Organaizer3121.Classes_
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tasks
    {
        public int ID { get; set; }
        public string User { get; set; }
        public string Task { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<bool> Done { get; set; }
        public string Description { get; set; }
    
        public virtual Users Users { get; set; }
    }
}
