//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModelGenerate
{
    using System;
    using System.Collections.Generic;
    
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public partial class Sys_Role
    {
    	[Required]
    	[StringLength(50)]
        public string F_Id { get; set; }
    	[StringLength(50)]
        public string F_OrganizeId { get; set; }
    
        public Nullable<int> F_Category { get; set; }
    	[StringLength(50)]
        public string F_EnCode { get; set; }
    	[StringLength(50)]
        public string F_FullName { get; set; }
    	[StringLength(50)]
        public string F_Type { get; set; }
    
        public Nullable<bool> F_AllowEdit { get; set; }
    
        public Nullable<bool> F_AllowDelete { get; set; }
    
        public Nullable<int> F_SortCode { get; set; }
    
        public Nullable<bool> F_DeleteMark { get; set; }
    
        public Nullable<bool> F_EnabledMark { get; set; }
    	[StringLength(500)]
        public string F_Description { get; set; }
    
        public Nullable<System.DateTime> F_CreatorTime { get; set; }
    	[StringLength(50)]
        public string F_CreatorUserId { get; set; }
    
        public Nullable<System.DateTime> F_LastModifyTime { get; set; }
    	[StringLength(50)]
        public string F_LastModifyUserId { get; set; }
    
        public Nullable<System.DateTime> F_DeleteTime { get; set; }
    	[StringLength(500)]
        public string F_DeleteUserId { get; set; }
    }
}
