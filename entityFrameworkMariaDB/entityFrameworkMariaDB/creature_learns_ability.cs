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
    
    public partial class creature_learns_ability
    {
        public string CreatureName { get; set; }
        public string AbilityName { get; set; }
        public int LearnLevel { get; set; }
    
        public virtual ability ability { get; set; }
        public virtual creature creature { get; set; }
    }
}
