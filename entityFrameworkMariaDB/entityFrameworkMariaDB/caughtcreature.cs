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
    
    public partial class caughtcreature
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public caughtcreature()
        {
            this.caughtcreature_ability = new HashSet<caughtcreature_ability>();
        }
    
        public int CatchId { get; set; }
        public string TrainerName { get; set; }
        public string CreatureName { get; set; }
        public string NickName { get; set; }
        public int XP { get; set; }
        public Nullable<int> CurrentHealth { get; set; }
        public bool Sex { get; set; }
    
        public virtual creature creature { get; set; }
        public virtual trainer trainer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<caughtcreature_ability> caughtcreature_ability { get; set; }
    }
}
