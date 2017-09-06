﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NFineDbContext : DbContext
    {
        //public NFineDbContext()
        //    : base("name=NFineDbContext")
        //{
        //}
        static NFineDbContext()
        {
            Database.SetInitializer<NFineDbContext>(null);
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProvinceMap());
            modelBuilder.Configurations.Add(new RemotesacrificeServiceStepMap());
        }
    
        public virtual DbSet<AdminUser> AdminUser { get; set; }
        public virtual DbSet<ApplicationforwithdrawalRecord> ApplicationforwithdrawalRecord { get; set; }
        public virtual DbSet<Banner> Banner { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Cemetery> Cemetery { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<CommissionRecord> CommissionRecord { get; set; }
        public virtual DbSet<Commodity> Commodity { get; set; }
        public virtual DbSet<CommodityCommboBind> CommodityCommboBind { get; set; }
        public virtual DbSet<CommodityImage> CommodityImage { get; set; }
        public virtual DbSet<CommodityOrder> CommodityOrder { get; set; }
        public virtual DbSet<CommodityOrderDetails> CommodityOrderDetails { get; set; }
        public virtual DbSet<CommodityOrderRefund> CommodityOrderRefund { get; set; }
        public virtual DbSet<CommoditySpec> CommoditySpec { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<DeliveryAddress> DeliveryAddress { get; set; }
        public virtual DbSet<DeliveryType> DeliveryType { get; set; }
        public virtual DbSet<FinancialSetting> FinancialSetting { get; set; }
        public virtual DbSet<Geomantic> Geomantic { get; set; }
        public virtual DbSet<GeomanticCommodityBind> GeomanticCommodityBind { get; set; }
        public virtual DbSet<Grave> Grave { get; set; }
        public virtual DbSet<GraveDeparted> GraveDeparted { get; set; }
        public virtual DbSet<IdentifyingCode> IdentifyingCode { get; set; }
        public virtual DbSet<MyFavorites> MyFavorites { get; set; }
        public virtual DbSet<OLCategory> OLCategory { get; set; }
        public virtual DbSet<OLCemetery> OLCemetery { get; set; }
        public virtual DbSet<OLCommodity> OLCommodity { get; set; }
        public virtual DbSet<OLCommodityBind> OLCommodityBind { get; set; }
        public virtual DbSet<OLCommodityOrder> OLCommodityOrder { get; set; }
        public virtual DbSet<OLCommodityOrderDetails> OLCommodityOrderDetails { get; set; }
        public virtual DbSet<OLCommodityOrderRefund> OLCommodityOrderRefund { get; set; }
        public virtual DbSet<OLDepartedBind> OLDepartedBind { get; set; }
        public virtual DbSet<OLGrave> OLGrave { get; set; }
        public virtual DbSet<OLGraveDeparted> OLGraveDeparted { get; set; }
        public virtual DbSet<OLShoppingCart> OLShoppingCart { get; set; }
        public virtual DbSet<Position> Position { get; set; }
        public virtual DbSet<PositionPower> PositionPower { get; set; }
        public virtual DbSet<PowerBind> PowerBind { get; set; }
        public virtual DbSet<PromotionRecord> PromotionRecord { get; set; }
        public virtual DbSet<Province> Province { get; set; }
        public virtual DbSet<QRCodeMapping> QRCodeMapping { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<RemotesacrificeServiceStep> RemotesacrificeServiceStep { get; set; }
        public virtual DbSet<RemoteServiceTemplate> RemoteServiceTemplate { get; set; }
        public virtual DbSet<RemoteTemplateMapping> RemoteTemplateMapping { get; set; }
        public virtual DbSet<ShoppingCart> ShoppingCart { get; set; }
        public virtual DbSet<WeChatAccessToken> WeChatAccessToken { get; set; }
    }
}