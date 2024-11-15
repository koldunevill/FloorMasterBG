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
    using System.Linq;

    public partial class Pathers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pathers()
        {
            this.ApplicationProductParthers = new HashSet<ApplicationProductParthers>();
            this.SalePlacePathers = new HashSet<SalePlacePathers>();
        }
    
        public int ID { get; set; }
        public int TypeID { get; set; }
        public string NameCompany { get; set; }
        public string Legacy_Adress { get; set; }
        public string INN { get; set; }
        public string SurnameDirector { get; set; }
        public string NameDirector { get; set; }
        public string PatronomycDirector { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Logo { get; set; }
        public decimal Rating { get; set; }

        public string FullNameDirector
        {
            get
            {
                return SurnameDirector + " " + NameDirector + " " + PatronomycDirector;
            }
        }

        public string TypeName
        {
            get
            {
                return TypePathers.Name;
            }
        }
        private int PartnerDiscount
        {
            get
            {
                if (FloopMasterEntities.GetContext().ManyArticle.Where(p => p.IDApllication == ID).Count() > 0)
                {
                    decimal PartnerProdQuantity = FloopMasterEntities.GetContext().ManyArticle.Where(p => p.IDApllication == ID).Sum(p => p.Count);
                    if (PartnerProdQuantity >= 10000 && PartnerProdQuantity < 50000)
                        return 5;
                    else if (PartnerProdQuantity >= 50000 && PartnerProdQuantity < 300000)
                        return 10;
                    else if (PartnerProdQuantity >= 300000)
                        return 15;
                    else
                        return 0;
                }
                else
                    return 0;
            }
        }

        public string PartnerDiscountDisplay
        {
            get
            {
                if (PartnerDiscount == 0)
                {
                    return "Нет скидки";
                }
                else
                {
                    return PartnerDiscount.ToString() + "%";
                }
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApplicationProductParthers> ApplicationProductParthers { get; set; }
        public virtual TypePathers TypePathers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalePlacePathers> SalePlacePathers { get; set; }
    }
}