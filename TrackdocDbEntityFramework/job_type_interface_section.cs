//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrackdocDbEntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class job_type_interface_section
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int job_type_section_id { get; set; }
        public int interface_section_id { get; set; }
        public int section_order { get; set; }
        public int created_by { get; set; }
        public int last_modified_by { get; set; }
        public System.DateTime date_created { get; set; }
        public System.DateTime date_last_modified { get; set; }
        public bool delete_flag { get; set; }
    
        public virtual interface_section interface_section { get; set; }
        public virtual user user { get; set; }
        public virtual job_type_section job_type_section { get; set; }
        public virtual user user1 { get; set; }
    }
}
