//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace entityFrameworkMariaDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class creature
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public creature()
        {
            this.caughtcreature = new HashSet<caughtcreature>();
            this.type = new HashSet<type>();
            this.creature_evolution = new HashSet<creature_evolution>();
            this.creature_evolution1 = new HashSet<creature_evolution>();
            this.creature_learns_ability = new HashSet<creature_learns_ability>();
        }
    
        public string CreatureName { get; set; }
        public string Description { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public byte Health { get; set; }
        public byte Strenght { get; set; }
        public byte Agility { get; set; }
        public byte Intelligence { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<caughtcreature> caughtcreature { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<type> type { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<creature_evolution> creature_evolution { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<creature_evolution> creature_evolution1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<creature_learns_ability> creature_learns_ability { get; set; }
    }
}
