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
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.ManyArticle = new HashSet<ManyArticle>();
            this.Material_Product = new HashSet<Material_Product>();
            this.CostPriceHistory = new HashSet<CostPriceHistory>();
            this.MinCostHistory = new HashSet<MinCostHistory>();
            this.ProductHistory = new HashSet<ProductHistory>();
        }
    
        public int Article { get; set; }
        public int TypeProductID { get; set; }
        public string NameProduct { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public decimal MinCost { get; set; }
        public Nullable<decimal> PackageLength { get; set; }
        public Nullable<decimal> PackageWidth { get; set; }
        public Nullable<decimal> PackageHeight { get; set; }
        public Nullable<decimal> WeightNoPackage { get; set; }
        public Nullable<decimal> WeightWithPackage { get; set; }
        public string QualitySertificatePhoto { get; set; }
        public Nullable<int> StandartNubmber { get; set; }
        public Nullable<decimal> ProductTimeCraft { get; set; }
        public Nullable<decimal> CostPrice { get; set; }
        public Nullable<int> WorkshopNumber { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ManyArticle> ManyArticle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Material_Product> Material_Product { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CostPriceHistory> CostPriceHistory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MinCostHistory> MinCostHistory { get; set; }
        public virtual TypeProduct TypeProduct { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductHistory> ProductHistory { get; set; }
    }
}
