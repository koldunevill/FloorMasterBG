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
    
    public partial class Material_Product
    {
        public int ID { get; set; }
        public int ProductArticle { get; set; }
        public int MaterialID { get; set; }
        public int Count { get; set; }
    
        public virtual Material Material { get; set; }
        public virtual Product Product { get; set; }
    }
}
