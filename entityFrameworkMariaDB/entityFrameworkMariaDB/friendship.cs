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
    
    public partial class friendship
    {
        public int AccountId { get; set; }
        public int FriendId { get; set; }
        public System.DateTime StartDate { get; set; }
    
        public virtual account account { get; set; }
        public virtual account account1 { get; set; }
    }
}
