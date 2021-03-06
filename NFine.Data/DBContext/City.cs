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
    public partial class City
    {
        public City()
        {
            this.Region = new HashSet<Region>();
        }
    
    	[Required]
    
        public System.Guid CityId { get; set; }
    
        public Nullable<System.Guid> ProvinceId { get; set; }
    	[StringLength(50)]
        public string CityName { get; set; }
    
        public Nullable<int> State { get; set; }
    
        public virtual Province Province { get; set; }
        public virtual ICollection<Region> Region { get; set; }
    }
}
