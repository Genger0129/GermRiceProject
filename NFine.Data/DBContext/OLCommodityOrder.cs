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
    public partial class OLCommodityOrder
    {
        public OLCommodityOrder()
        {
            this.OLCommodityOrderDetails = new HashSet<OLCommodityOrderDetails>();
            this.OLCommodityOrderRefund = new HashSet<OLCommodityOrderRefund>();
        }
    
    	[Required]
    
        public System.Guid OLCommodityOrderId { get; set; }
    
        public Nullable<System.Guid> CustomerId { get; set; }
    	[StringLength(50)]
        public string WeChatId { get; set; }
    	[StringLength(50)]
        public string OrderId { get; set; }
    
        public Nullable<int> OrderState { get; set; }
    
        public Nullable<decimal> Totalamount { get; set; }
    
        public Nullable<System.DateTime> BuyingTime { get; set; }
    
        public Nullable<System.DateTime> PayTime { get; set; }
    	[StringLength(20)]
        public string ContactPerson { get; set; }
    	[StringLength(20)]
        public string ContactPhone { get; set; }
    	[Required]
    	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    				
        public int SortId { get; set; }
    
        public Nullable<System.DateTime> AppointmentTime { get; set; }
    
        public Nullable<System.DateTime> CompleteTime { get; set; }
    	[StringLength(20)]
        public string ReceiveCode { get; set; }
    	[StringLength(1000)]
        public string GraveInfo { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual ICollection<OLCommodityOrderDetails> OLCommodityOrderDetails { get; set; }
        public virtual ICollection<OLCommodityOrderRefund> OLCommodityOrderRefund { get; set; }
    }
}
