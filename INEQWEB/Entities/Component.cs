//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Component
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public Nullable<int> ComponentTypeId { get; set; }
        public Nullable<int> Equipment_Id { get; set; }
        public Nullable<int> EquipmentType_Id { get; set; }
    
        public virtual ComponentType ComponentType { get; set; }
        public virtual Equipment Equipment { get; set; }
        public virtual EquipmentType EquipmentType { get; set; }
    }
}
