namespace NFine.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Province",
                c => new
                    {
                        ProvinceId = c.Guid(nullable: false),
                        ProvinceName = c.String(maxLength: 50),
                        State = c.Int(),
                    })
                .PrimaryKey(t => t.ProvinceId);
            
            CreateTable(
                "dbo.Sys_Area",
                c => new
                    {
                        F_Id = c.String(nullable: false, maxLength: 50),
                        F_ParentId = c.String(maxLength: 50),
                        F_Layers = c.Int(),
                        F_EnCode = c.String(maxLength: 50),
                        F_FullName = c.String(maxLength: 50),
                        F_SimpleSpelling = c.String(maxLength: 50),
                        F_SortCode = c.Int(),
                        F_DeleteMark = c.Boolean(),
                        F_EnabledMark = c.Boolean(),
                        F_Description = c.String(maxLength: 500),
                        F_CreatorTime = c.DateTime(),
                        F_CreatorUserId = c.String(maxLength: 50),
                        F_LastModifyTime = c.DateTime(),
                        F_LastModifyUserId = c.String(maxLength: 50),
                        F_DeleteTime = c.DateTime(),
                        F_DeleteUserId = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.F_Id);
            
            CreateTable(
                "dbo.Sys_DbBackup",
                c => new
                    {
                        F_Id = c.String(nullable: false, maxLength: 50),
                        F_BackupType = c.String(maxLength: 50),
                        F_DbName = c.String(maxLength: 50),
                        F_FileName = c.String(maxLength: 50),
                        F_FileSize = c.String(maxLength: 50),
                        F_FilePath = c.String(maxLength: 500),
                        F_BackupTime = c.DateTime(),
                        F_SortCode = c.Int(),
                        F_DeleteMark = c.Boolean(),
                        F_EnabledMark = c.Boolean(),
                        F_Description = c.String(maxLength: 500),
                        F_CreatorTime = c.DateTime(),
                        F_CreatorUserId = c.String(maxLength: 50),
                        F_LastModifyTime = c.DateTime(),
                        F_LastModifyUserId = c.String(maxLength: 50),
                        F_DeleteTime = c.DateTime(),
                        F_DeleteUserId = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.F_Id);
            
            CreateTable(
                "dbo.Sys_FilterIP",
                c => new
                    {
                        F_Id = c.String(nullable: false, maxLength: 50),
                        F_Type = c.Boolean(),
                        F_StartIP = c.String(maxLength: 50),
                        F_EndIP = c.String(maxLength: 50),
                        F_SortCode = c.Int(),
                        F_DeleteMark = c.Boolean(),
                        F_EnabledMark = c.Boolean(),
                        F_Description = c.String(maxLength: 500),
                        F_CreatorTime = c.DateTime(),
                        F_CreatorUserId = c.String(maxLength: 50),
                        F_LastModifyTime = c.DateTime(),
                        F_LastModifyUserId = c.String(maxLength: 50),
                        F_DeleteTime = c.DateTime(),
                        F_DeleteUserId = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.F_Id);
            
            CreateTable(
                "dbo.Sys_Items",
                c => new
                    {
                        F_Id = c.String(nullable: false, maxLength: 50),
                        F_ParentId = c.String(maxLength: 50),
                        F_EnCode = c.String(maxLength: 50),
                        F_FullName = c.String(maxLength: 50),
                        F_IsTree = c.Boolean(),
                        F_Layers = c.Int(),
                        F_SortCode = c.Int(),
                        F_DeleteMark = c.Boolean(),
                        F_EnabledMark = c.Boolean(),
                        F_Description = c.String(maxLength: 500),
                        F_CreatorTime = c.DateTime(),
                        F_CreatorUserId = c.String(maxLength: 50),
                        F_LastModifyTime = c.DateTime(),
                        F_LastModifyUserId = c.String(maxLength: 50),
                        F_DeleteTime = c.DateTime(),
                        F_DeleteUserId = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.F_Id);
            
            CreateTable(
                "dbo.Sys_ItemsDetail",
                c => new
                    {
                        F_Id = c.String(nullable: false, maxLength: 50),
                        F_ItemId = c.String(maxLength: 50),
                        F_ParentId = c.String(maxLength: 50),
                        F_ItemCode = c.String(maxLength: 50),
                        F_ItemName = c.String(maxLength: 50),
                        F_SimpleSpelling = c.String(maxLength: 500),
                        F_IsDefault = c.Boolean(),
                        F_Layers = c.Int(),
                        F_SortCode = c.Int(),
                        F_DeleteMark = c.Boolean(),
                        F_EnabledMark = c.Boolean(),
                        F_Description = c.String(maxLength: 500),
                        F_CreatorTime = c.DateTime(),
                        F_CreatorUserId = c.String(maxLength: 50),
                        F_LastModifyTime = c.DateTime(),
                        F_LastModifyUserId = c.String(maxLength: 50),
                        F_DeleteTime = c.DateTime(),
                        F_DeleteUserId = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.F_Id);
            
            CreateTable(
                "dbo.Sys_Log",
                c => new
                    {
                        F_Id = c.String(nullable: false, maxLength: 50),
                        F_Date = c.DateTime(),
                        F_Account = c.String(maxLength: 50),
                        F_NickName = c.String(maxLength: 50),
                        F_Type = c.String(maxLength: 50),
                        F_IPAddress = c.String(maxLength: 50),
                        F_IPAddressName = c.String(maxLength: 50),
                        F_ModuleId = c.String(maxLength: 50),
                        F_ModuleName = c.String(maxLength: 50),
                        F_Result = c.Boolean(),
                        F_Description = c.String(maxLength: 500),
                        F_CreatorTime = c.DateTime(),
                        F_CreatorUserId = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.F_Id);
            
            CreateTable(
                "dbo.Sys_Module",
                c => new
                    {
                        F_Id = c.String(nullable: false, maxLength: 50),
                        F_ParentId = c.String(maxLength: 50),
                        F_Layers = c.Int(),
                        F_EnCode = c.String(maxLength: 50),
                        F_FullName = c.String(maxLength: 50),
                        F_Icon = c.String(maxLength: 50),
                        F_UrlAddress = c.String(maxLength: 500),
                        F_Target = c.String(maxLength: 50),
                        F_IsMenu = c.Boolean(),
                        F_IsExpand = c.Boolean(),
                        F_IsPublic = c.Boolean(),
                        F_AllowEdit = c.Boolean(),
                        F_AllowDelete = c.Boolean(),
                        F_SortCode = c.Int(),
                        F_DeleteMark = c.Boolean(),
                        F_EnabledMark = c.Boolean(),
                        F_Description = c.String(maxLength: 500),
                        F_CreatorTime = c.DateTime(),
                        F_CreatorUserId = c.String(maxLength: 50),
                        F_LastModifyTime = c.DateTime(),
                        F_LastModifyUserId = c.String(maxLength: 50),
                        F_DeleteTime = c.DateTime(),
                        F_DeleteUserId = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.F_Id);
            
            CreateTable(
                "dbo.Sys_ModuleButton",
                c => new
                    {
                        F_Id = c.String(nullable: false, maxLength: 50),
                        F_ModuleId = c.String(maxLength: 50),
                        F_ParentId = c.String(maxLength: 50),
                        F_Layers = c.Int(),
                        F_EnCode = c.String(maxLength: 50),
                        F_FullName = c.String(maxLength: 50),
                        F_Icon = c.String(maxLength: 50),
                        F_Location = c.Int(),
                        F_JsEvent = c.String(maxLength: 50),
                        F_UrlAddress = c.String(maxLength: 500),
                        F_Split = c.Boolean(),
                        F_IsPublic = c.Boolean(),
                        F_AllowEdit = c.Boolean(),
                        F_AllowDelete = c.Boolean(),
                        F_SortCode = c.Int(),
                        F_DeleteMark = c.Boolean(),
                        F_EnabledMark = c.Boolean(),
                        F_Description = c.String(maxLength: 500),
                        F_CreatorTime = c.DateTime(),
                        F_CreatorUserId = c.String(maxLength: 50),
                        F_LastModifyTime = c.DateTime(),
                        F_LastModifyUserId = c.String(maxLength: 50),
                        F_DeleteTime = c.DateTime(),
                        F_DeleteUserId = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.F_Id);
            
            CreateTable(
                "dbo.Sys_ModuleForm",
                c => new
                    {
                        F_Id = c.String(nullable: false, maxLength: 50),
                        F_ModuleId = c.String(maxLength: 50),
                        F_EnCode = c.String(maxLength: 50),
                        F_FullName = c.String(maxLength: 50),
                        F_FormJson = c.String(),
                        F_SortCode = c.Int(),
                        F_DeleteMark = c.Boolean(),
                        F_EnabledMark = c.Boolean(),
                        F_Description = c.String(maxLength: 500),
                        F_CreatorTime = c.DateTime(),
                        F_CreatorUserId = c.String(maxLength: 50),
                        F_LastModifyTime = c.DateTime(),
                        F_LastModifyUserId = c.String(maxLength: 50),
                        F_DeleteTime = c.DateTime(),
                        F_DeleteUserId = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.F_Id);
            
            CreateTable(
                "dbo.Sys_ModuleFormInstance",
                c => new
                    {
                        F_Id = c.String(nullable: false, maxLength: 50),
                        F_FormId = c.String(nullable: false, maxLength: 50),
                        F_ObjectId = c.String(maxLength: 50),
                        F_InstanceJson = c.String(),
                        F_SortCode = c.Int(),
                        F_CreatorTime = c.DateTime(),
                        F_CreatorUserId = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.F_Id);
            
            CreateTable(
                "dbo.Sys_Organize",
                c => new
                    {
                        F_Id = c.String(nullable: false, maxLength: 50),
                        F_ParentId = c.String(maxLength: 50),
                        F_Layers = c.Int(),
                        F_EnCode = c.String(maxLength: 50),
                        F_FullName = c.String(maxLength: 50),
                        F_ShortName = c.String(maxLength: 50),
                        F_CategoryId = c.String(maxLength: 50),
                        F_ManagerId = c.String(maxLength: 50),
                        F_TelePhone = c.String(maxLength: 20),
                        F_MobilePhone = c.String(maxLength: 20),
                        F_WeChat = c.String(maxLength: 50),
                        F_Fax = c.String(maxLength: 20),
                        F_Email = c.String(maxLength: 50),
                        F_AreaId = c.String(maxLength: 50),
                        F_Address = c.String(maxLength: 500),
                        F_AllowEdit = c.Boolean(),
                        F_AllowDelete = c.Boolean(),
                        F_SortCode = c.Int(),
                        F_DeleteMark = c.Boolean(),
                        F_EnabledMark = c.Boolean(),
                        F_Description = c.String(maxLength: 500),
                        F_CreatorTime = c.DateTime(),
                        F_CreatorUserId = c.String(maxLength: 50),
                        F_LastModifyTime = c.DateTime(),
                        F_LastModifyUserId = c.String(maxLength: 50),
                        F_DeleteTime = c.DateTime(),
                        F_DeleteUserId = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.F_Id);
            
            CreateTable(
                "dbo.Sys_Role",
                c => new
                    {
                        F_Id = c.String(nullable: false, maxLength: 50),
                        F_OrganizeId = c.String(maxLength: 50),
                        F_Category = c.Int(),
                        F_EnCode = c.String(maxLength: 50),
                        F_FullName = c.String(maxLength: 50),
                        F_Type = c.String(maxLength: 50),
                        F_AllowEdit = c.Boolean(),
                        F_AllowDelete = c.Boolean(),
                        F_SortCode = c.Int(),
                        F_DeleteMark = c.Boolean(),
                        F_EnabledMark = c.Boolean(),
                        F_Description = c.String(maxLength: 500),
                        F_CreatorTime = c.DateTime(),
                        F_CreatorUserId = c.String(maxLength: 50),
                        F_LastModifyTime = c.DateTime(),
                        F_LastModifyUserId = c.String(maxLength: 50),
                        F_DeleteTime = c.DateTime(),
                        F_DeleteUserId = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.F_Id);
            
            CreateTable(
                "dbo.Sys_RoleAuthorize",
                c => new
                    {
                        F_Id = c.String(nullable: false, maxLength: 50),
                        F_ItemType = c.Int(),
                        F_ItemId = c.String(maxLength: 50),
                        F_ObjectType = c.Int(),
                        F_ObjectId = c.String(maxLength: 50),
                        F_SortCode = c.Int(),
                        F_CreatorTime = c.DateTime(),
                        F_CreatorUserId = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.F_Id);
            
            CreateTable(
                "dbo.Sys_User",
                c => new
                    {
                        F_Id = c.String(nullable: false, maxLength: 50),
                        F_Account = c.String(maxLength: 50),
                        F_RealName = c.String(maxLength: 50),
                        F_NickName = c.String(maxLength: 50),
                        F_HeadIcon = c.String(maxLength: 50),
                        F_Gender = c.Boolean(),
                        F_Birthday = c.DateTime(),
                        F_MobilePhone = c.String(maxLength: 20),
                        F_Email = c.String(maxLength: 50),
                        F_WeChat = c.String(maxLength: 50),
                        F_ManagerId = c.String(maxLength: 50),
                        F_SecurityLevel = c.Int(),
                        F_Signature = c.String(maxLength: 500),
                        F_OrganizeId = c.String(maxLength: 50),
                        F_DepartmentId = c.String(maxLength: 500),
                        F_RoleId = c.String(maxLength: 500),
                        F_DutyId = c.String(maxLength: 500),
                        F_IsAdministrator = c.Boolean(),
                        F_SortCode = c.Int(),
                        F_DeleteMark = c.Boolean(),
                        F_EnabledMark = c.Boolean(),
                        F_Description = c.String(maxLength: 500),
                        F_CreatorTime = c.DateTime(),
                        F_CreatorUserId = c.String(maxLength: 50),
                        F_LastModifyTime = c.DateTime(),
                        F_LastModifyUserId = c.String(maxLength: 50),
                        F_DeleteTime = c.DateTime(),
                        F_DeleteUserId = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.F_Id);
            
            CreateTable(
                "dbo.Sys_UserLogOn",
                c => new
                    {
                        F_Id = c.String(nullable: false, maxLength: 50),
                        F_UserId = c.String(maxLength: 50),
                        F_UserPassword = c.String(maxLength: 50),
                        F_UserSecretkey = c.String(maxLength: 50),
                        F_AllowStartTime = c.DateTime(),
                        F_AllowEndTime = c.DateTime(),
                        F_LockStartDate = c.DateTime(),
                        F_LockEndDate = c.DateTime(),
                        F_FirstVisitTime = c.DateTime(),
                        F_PreviousVisitTime = c.DateTime(),
                        F_LastVisitTime = c.DateTime(),
                        F_ChangePasswordDate = c.DateTime(),
                        F_MultiUserLogin = c.Boolean(),
                        F_LogOnCount = c.Int(),
                        F_UserOnLine = c.Boolean(),
                        F_Question = c.String(maxLength: 50),
                        F_AnswerQuestion = c.String(maxLength: 500),
                        F_CheckIPAddress = c.Boolean(),
                        F_Language = c.String(maxLength: 50),
                        F_Theme = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.F_Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sys_UserLogOn");
            DropTable("dbo.Sys_User");
            DropTable("dbo.Sys_RoleAuthorize");
            DropTable("dbo.Sys_Role");
            DropTable("dbo.Sys_Organize");
            DropTable("dbo.Sys_ModuleFormInstance");
            DropTable("dbo.Sys_ModuleForm");
            DropTable("dbo.Sys_ModuleButton");
            DropTable("dbo.Sys_Module");
            DropTable("dbo.Sys_Log");
            DropTable("dbo.Sys_ItemsDetail");
            DropTable("dbo.Sys_Items");
            DropTable("dbo.Sys_FilterIP");
            DropTable("dbo.Sys_DbBackup");
            DropTable("dbo.Sys_Area");
            DropTable("dbo.Province");
        }
    }
}
