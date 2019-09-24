using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThanhNguyen.Model.Models;

namespace ThanhNguyen.Data
{
    public class ThanhNguyenDbContext : DbContext
    {
        public ThanhNguyenDbContext() : base("ThanhNguyenConnection")
        {
            //Cấu hình cho Lazy Loading
            //Khi load 1 cái bảng ra không tự động include thêm bảng con nữa
            this.Configuration.LazyLoadingEnabled = false;
        }

        //Khai báo danh sách các bảng
        public DbSet<Footer> Footers { set; get; }
        public DbSet<Menu> Menus { set; get; }
        public DbSet<MenuGroup> MenuGroups { set; get; }

        internal ThanhNguyenDbContext Init()
        {
            throw new NotImplementedException();
        }

        public DbSet<Order> Orders { set; get; }
        public DbSet<OrderDetail> OrderDetails { set; get; }
        public DbSet<Page> Pages { set; get; }
        public DbSet<Post> Posts { set; get; }
        public DbSet<PostCategory> PostCategories { set; get; }
        public DbSet<PostTag> PostTags { set; get; }
        public DbSet<Product> Products { set; get; }
        public DbSet<ProductCategory> ProductCategories { set; get; }
        public DbSet<ProductTag> ProductTags { set; get; }
        public DbSet<Slide> Slides { set; get; }
        public DbSet<SupportOnline> SupportOnlines { set; get; }
        public DbSet<SystemConfig> SystemConfigs { set; get; }
        public DbSet<Tag> Tags { set; get; }
        public DbSet<VisitorStatistic> VisitorStatistics { set; get; }

        public static ThanhNguyenDbContext Context()
        {
            return new ThanhNguyenDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            
        }
    }
}
