using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StockMarket.Entities.Entity;
using StockMarket.Repositories.RepositoryEntities.ApplicationRoleClaims;
using StockMarket.Repositories.RepositoryEntities.ApplicationUserClaims;
using StockMarket.Repositories.RepositoryEntities.ApplicationUserLogins;
using StockMarket.Repositories.RepositoryEntities.ApplicationUserRoles;
using StockMarket.Repositories.RepositoryEntities.ApplicationUsers;
using StockMarket.Repositories.RepositoryEntities.ApplicationUserTokens;
using StockMarket.Repositories.RepositoryEntities.StockPricesHistories;
using StockMarket.Repositories.RepositoryEntities.Stockses;
using StockMarket.Repositories.RepositoryEntities.StocksPrices;
using StockMarket.Repositories.RepositoryEntities.StocksTransactions;
using StockMarket.Repositories.RepositoryEntities.UsersNotifications;
using StockMarket.Repositories.RepositoryEntities.UsersStocks;

namespace StockMarket.Repositories.DbContexts
{
    public class AppDbContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<ApplicationRole> ApplicationRole { get; set; }
        public DbSet<ApplicationRoleClaim> ApplicationRoleClaim { get; set; }
        public DbSet<ApplicationUserClaim> ApplicationUserClaim { get; set; }
        public DbSet<ApplicationUserLogin> ApplicationUserLogin { get; set; }
        public DbSet<ApplicationUserRole> ApplicationUserRole { get; set; }
        public DbSet<ApplicationUserToken> ApplicationUserToken { get; set; }
        public DbSet<StockPrices> StockPrices { get; set; }
        public DbSet<Stocks> Stocks { get; set; }
        public DbSet<StockPricesHistory> StockPricesHistories { get; set; }
        public DbSet<StockTransactions> StockTransactions { get; set; }
        public DbSet<UserNotifications> UserNotifications { get; set; }
        public DbSet<UserStocks> UserStocks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationUserConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationRoleClaimConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationUserClaimConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationUserLoginConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationUserRoleConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationUserTokenConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(StockPricesConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(StocksConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(StockPricesHistoryConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(StockTransactionsConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserNotificationsConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserStocksConfiguration).Assembly);


        }

    }
}
