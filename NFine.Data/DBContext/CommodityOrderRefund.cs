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
    public partial class CommodityOrderRefund
    {
    	[Required]
    
        public System.Guid CommodityOrderRefundId { get; set; }
    
        public Nullable<System.Guid> CommodityOrderId { get; set; }
    	[StringLength(100)]
        public string RefundReason { get; set; }
    
        public Nullable<System.DateTime> CreateTime { get; set; }
    
        public Nullable<bool> WhetherAudit { get; set; }
    
        public Nullable<System.DateTime> AuditDate { get; set; }
    
        public Nullable<System.Guid> AuditPerson { get; set; }
    
        public Nullable<bool> IsRefund { get; set; }
    	[StringLength(100)]
        public string RefundrefuseReason { get; set; }
    	[Required]
    	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    				
        public int SortId { get; set; }
    
        public virtual CommodityOrder CommodityOrder { get; set; }
    }
}
