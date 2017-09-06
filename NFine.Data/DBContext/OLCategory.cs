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
    public partial class OLCategory
    {
        public OLCategory()
        {
            this.OLCommodity = new HashSet<OLCommodity>();
        }
    
    	[Required]
    
        public System.Guid OLCategoryId { get; set; }
    	[StringLength(20)]
        public string CategoryName { get; set; }
    
        public Nullable<System.DateTime> CreateTime { get; set; }
    
        public Nullable<int> SortId { get; set; }
    	[StringLength(200)]
        public string CategoryImg { get; set; }
    
        public Nullable<bool> IsDeleted { get; set; }
    
        public virtual ICollection<OLCommodity> OLCommodity { get; set; }
    }
}
