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
    public partial class CommodityCommboBind
    {
    	[Required]
    
        public System.Guid CommodityCommboBindId { get; set; }
    
        public Nullable<System.Guid> CommodityId { get; set; }
    
        public Nullable<System.Guid> CommoditySpecId { get; set; }
    
        public Nullable<int> Count { get; set; }
    
        public virtual Commodity Commodity { get; set; }
        public virtual CommoditySpec CommoditySpec { get; set; }
    }
}
