//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConferenceOrganization.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int UserID { get; set; }
        public string FullName { get; set; }
        public int GenderID { get; set; }
        public int RoleID { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    
        public virtual Gender Gender { get; set; }
        public virtual Role Role { get; set; }
    }
}
