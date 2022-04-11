//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PractWork18
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.OrderContents = new HashSet<OrderContent>();
        }
    
        public int IdProduct { get; set; }
        public int IdProducer { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public short Year { get; set; }
        public string Type { get; set; }
        public Nullable<decimal> Weight { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public int Count { get; set; }
    
        public virtual Producer Producer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderContent> OrderContents { get; set; }
    }
}
