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
    
    public partial class ability
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ability()
        {
            this.caughtcreature_ability = new HashSet<caughtcreature_ability>();
            this.creature_learns_ability = new HashSet<creature_learns_ability>();
        }
    
        public string AbilityName { get; set; }
        public byte Damage { get; set; }
        public byte Accuracy { get; set; }
        public byte MaxUses { get; set; }
        public bool IsPhysical { get; set; }
        public string TypeName { get; set; }
        public string EffectName { get; set; }
    
        public virtual ability_effect ability_effect { get; set; }
        public virtual type type { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<caughtcreature_ability> caughtcreature_ability { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<creature_learns_ability> creature_learns_ability { get; set; }
    }
}
