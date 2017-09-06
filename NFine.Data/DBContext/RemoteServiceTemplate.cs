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
    public partial class RemoteServiceTemplate
    {
        public RemoteServiceTemplate()
        {
            this.CommoditySpec = new HashSet<CommoditySpec>();
            this.RemoteTemplateMapping = new HashSet<RemoteTemplateMapping>();
        }
    
    	[Required]
    
        public System.Guid RemoteServiceTemplateId { get; set; }
    	[StringLength(50)]
        public string TemplateName { get; set; }
    
        public Nullable<System.DateTime> CreateTime { get; set; }
    
        public virtual ICollection<CommoditySpec> CommoditySpec { get; set; }
        public virtual ICollection<RemoteTemplateMapping> RemoteTemplateMapping { get; set; }
    }
}
