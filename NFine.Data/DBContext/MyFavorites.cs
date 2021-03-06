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
    public partial class MyFavorites
    {
    	[Required]
    
        public System.Guid MyFavoritesId { get; set; }
    
        public Nullable<System.Guid> CommodityId { get; set; }
    
        public Nullable<System.Guid> GeomanticId { get; set; }
    
        public Nullable<System.Guid> CustomerId { get; set; }
    
        public Nullable<System.DateTime> CreateTime { get; set; }
    	[Required]
    	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    				
        public int SortId { get; set; }
    
        public virtual Commodity Commodity { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Geomantic Geomantic { get; set; }
    }
}
