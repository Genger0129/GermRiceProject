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
    public partial class OLDepartedBind
    {
    	[Required]
    
        public System.Guid OLDepartedBindId { get; set; }
    
        public Nullable<System.Guid> FirstOLGraveDepartedId { get; set; }
    
        public Nullable<System.Guid> CustomerId { get; set; }
    
        public Nullable<System.Guid> SecOLGraveDepartedId { get; set; }
    
        public Nullable<System.DateTime> CreateTime { get; set; }
    	[StringLength(500)]
        public string LastCommodityList { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual OLGraveDeparted OLGraveDeparted { get; set; }
        public virtual OLGraveDeparted OLGraveDeparted1 { get; set; }
    }
}
