//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace NFine.Data
{
    using System;
    using System.Collections.Generic;
    
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public partial class Sys_Log
    {
    	[Required]
    	[StringLength(50)]
        public string F_Id { get; set; }
    
        public Nullable<System.DateTime> F_Date { get; set; }
    	[StringLength(50)]
        public string F_Account { get; set; }
    	[StringLength(50)]
        public string F_NickName { get; set; }
    	[StringLength(50)]
        public string F_Type { get; set; }
    	[StringLength(50)]
        public string F_IPAddress { get; set; }
    	[StringLength(50)]
        public string F_IPAddressName { get; set; }
    	[StringLength(50)]
        public string F_ModuleId { get; set; }
    	[StringLength(50)]
        public string F_ModuleName { get; set; }
    
        public Nullable<bool> F_Result { get; set; }
    	[StringLength(500)]
        public string F_Description { get; set; }
    
        public Nullable<System.DateTime> F_CreatorTime { get; set; }
    	[StringLength(50)]
        public string F_CreatorUserId { get; set; }
    }
}
