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
    public partial class Customer
    {
        public Customer()
        {
            this.CommodityOrder = new HashSet<CommodityOrder>();
            this.Customer1 = new HashSet<Customer>();
            this.MyFavorites = new HashSet<MyFavorites>();
            this.OLCommodityOrder = new HashSet<OLCommodityOrder>();
            this.OLDepartedBind = new HashSet<OLDepartedBind>();
            this.OLShoppingCart = new HashSet<OLShoppingCart>();
            this.PromotionRecord = new HashSet<PromotionRecord>();
            this.ShoppingCart = new HashSet<ShoppingCart>();
        }
    
    	[Required]
    
        public System.Guid CustomerId { get; set; }
    
        public Nullable<System.Guid> GeomanticId { get; set; }
    
        public Nullable<System.Guid> Cus_CustomerId { get; set; }
    	[StringLength(50)]
        public string WeChatId { get; set; }
    	[StringLength(50)]
        public string OpenId { get; set; }
    	[StringLength(20)]
        public string Phone { get; set; }
    	[StringLength(50)]
        public string Name { get; set; }
    
        public Nullable<System.DateTime> CreateTime { get; set; }
    	[Required]
    	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    				
        public int SortId { get; set; }
    
        public Nullable<int> Sex { get; set; }
    	[StringLength(200)]
        public string HeadImgUrl { get; set; }
    
        public Nullable<int> SubscribeTime { get; set; }
    
        public virtual ICollection<CommodityOrder> CommodityOrder { get; set; }
        public virtual ICollection<Customer> Customer1 { get; set; }
        public virtual Customer Customer2 { get; set; }
        public virtual Geomantic Geomantic { get; set; }
        public virtual ICollection<MyFavorites> MyFavorites { get; set; }
        public virtual ICollection<OLCommodityOrder> OLCommodityOrder { get; set; }
        public virtual ICollection<OLDepartedBind> OLDepartedBind { get; set; }
        public virtual ICollection<OLShoppingCart> OLShoppingCart { get; set; }
        public virtual ICollection<PromotionRecord> PromotionRecord { get; set; }
        public virtual ICollection<ShoppingCart> ShoppingCart { get; set; }
    }
}
