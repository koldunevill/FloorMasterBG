//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FloopMasterBG
{
    using System;
    using System.Collections.Generic;
    
    public partial class Workers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Workers()
        {
            this.ApplicationProductParthers = new HashSet<ApplicationProductParthers>();
            this.MaterialProviderHistory = new HashSet<MaterialProviderHistory>();
        }
    
        public int ID { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public System.DateTime Birthday { get; set; }
        public int SeriesPassport { get; set; }
        public int NumberPassport { get; set; }
        public string NameBank { get; set; }
        public string AccountNumberBank { get; set; }
        public int BIСBAnk { get; set; }
        public string CorporateAccountBank { get; set; }
        public bool HavingFamily { get; set; }
        public string HealthStatus { get; set; }
        public int RoleID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApplicationProductParthers> ApplicationProductParthers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaterialProviderHistory> MaterialProviderHistory { get; set; }
        public virtual Role Role { get; set; }
    }
}
