//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PractWork17.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int IdOrder { get; set; }
        public int IdCustomer { get; set; }
        public System.DateTime DateOfOrder { get; set; }
    
        public virtual Customer Customer { get; set; }
    }
}