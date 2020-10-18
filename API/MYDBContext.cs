using System;
using System.Collections.Generic;
using System.Text;
using Models.LJX;
using Models.WYH;
using Models.YYF;
using Models.YH;
using Microsoft.EntityFrameworkCore;

namespace API
{
   public class MYDBContext:DbContext
    {
        public MYDBContext(DbContextOptions<MYDBContext> options) : base(options) { }
        /// <summary>
        /// 格式：
        /// public DbSet<表名> 名称 { get; set; }
        /// </summary>
        public DbSet<MenusModel> Menus { get; set; }
        public DbSet<RoleMenuModel> RoleMenu { get; set; }
        public DbSet<RoleModel> Roles { get; set; }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<UserRoleModel> UserRole { get; set; }
        public DbSet<landlordModel> landlord { get; set; }
        public DbSet<YonghuModel> Yonghu { get; set; }
        public DbSet<AreaModel> Area { get; set; }
        public DbSet<City_Model> City { get; set; }
        public DbSet<HouseModel> House { get; set; }
        public DbSet<provinceModel> province { get; set; }
        public DbSet<FinanceModel>  Finances { get; set; }
    }
}
