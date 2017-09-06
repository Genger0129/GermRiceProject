//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApplication6
{
    using System;
    using System.Collections.Generic;
    
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public partial class DeliveryType
    {
        public DeliveryType()
        {
            this.CommodityOrder = new HashSet<CommodityOrder>();
        }
    
    	[Required]
    
        public System.Guid DeliveryTypeId { get; set; }
    	[StringLength(20)]
        public string DeliveryName { get; set; }
    
        public Nullable<decimal> Amount { get; set; }
    
        public Nullable<int> DeliveryCode { get; set; }
    	[Required]
    	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    				
        public int SortId { get; set; }
    
        public virtual ICollection<CommodityOrder> CommodityOrder { get; set; }
    }
}
