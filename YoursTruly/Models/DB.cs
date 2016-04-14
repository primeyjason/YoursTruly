using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace YoursTruly.Models
{


    public class AssetDBContext : DbContext
    {
        public AssetDBContext() : base((string)ConfigurationManager.ConnectionStrings["YoursTruly"].ConnectionString)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AssetDBContext, YoursTruly.Migrations.Configuration>());
        }
        public DbSet<Skill> Skills { get; set; }

        
    }
}
