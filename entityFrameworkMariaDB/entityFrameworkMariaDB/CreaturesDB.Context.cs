﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class creaturesEntities : DbContext
    {
        public creaturesEntities()
            : base("name=creaturesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<account> account { get; set; }
        public virtual DbSet<caughtcreature> caughtcreature { get; set; }
        public virtual DbSet<creature> creature { get; set; }
        public virtual DbSet<trainer> trainer { get; set; }
        public virtual DbSet<type> type { get; set; }
        public virtual DbSet<account_public> account_public { get; set; }
        public virtual DbSet<type_super_effective_against> type_super_effective_against { get; set; }
        public virtual DbSet<ability> ability { get; set; }
        public virtual DbSet<ability_effect> ability_effect { get; set; }
        public virtual DbSet<ability_effect_category> ability_effect_category { get; set; }
        public virtual DbSet<creature_evolution> creature_evolution { get; set; }
        public virtual DbSet<caughtcreature_ability> caughtcreature_ability { get; set; }
        public virtual DbSet<friendship> friendship { get; set; }
        public virtual DbSet<trainer_battle> trainer_battle { get; set; }
        public virtual DbSet<creature_learns_ability> creature_learns_ability { get; set; }
        public virtual DbSet<whisper> whisper { get; set; }
    
        public virtual int CreateAccountProcedure(string email, string pw, Nullable<System.DateTime> birthdate, string firstname, string lastname, string displayname)
        {
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var pwParameter = pw != null ?
                new ObjectParameter("pw", pw) :
                new ObjectParameter("pw", typeof(string));
    
            var birthdateParameter = birthdate.HasValue ?
                new ObjectParameter("birthdate", birthdate) :
                new ObjectParameter("birthdate", typeof(System.DateTime));
    
            var firstnameParameter = firstname != null ?
                new ObjectParameter("firstname", firstname) :
                new ObjectParameter("firstname", typeof(string));
    
            var lastnameParameter = lastname != null ?
                new ObjectParameter("lastname", lastname) :
                new ObjectParameter("lastname", typeof(string));
    
            var displaynameParameter = displayname != null ?
                new ObjectParameter("displayname", displayname) :
                new ObjectParameter("displayname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreateAccountProcedure", emailParameter, pwParameter, birthdateParameter, firstnameParameter, lastnameParameter, displaynameParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> LoginProcedure(string email, string pw, ObjectParameter accId)
        {
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var pwParameter = pw != null ?
                new ObjectParameter("pw", pw) :
                new ObjectParameter("pw", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("LoginProcedure", emailParameter, pwParameter, accId);
        }
    
        public virtual int AcceptFriendRequestProcedure(Nullable<int> acc, Nullable<int> friend)
        {
            var accParameter = acc.HasValue ?
                new ObjectParameter("acc", acc) :
                new ObjectParameter("acc", typeof(int));
    
            var friendParameter = friend.HasValue ?
                new ObjectParameter("friend", friend) :
                new ObjectParameter("friend", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AcceptFriendRequestProcedure", accParameter, friendParameter);
        }
    }
}