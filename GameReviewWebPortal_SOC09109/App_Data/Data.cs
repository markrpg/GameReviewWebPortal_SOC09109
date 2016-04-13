using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GameReviewWebPortal_SOC09109.App_Data
{
    public class Data : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Data() : base("name=Data")
        {
            Database.SetInitializer<Data>(null);
        }

        public System.Data.Entity.DbSet<GameReviewWebPortal_SOC09109.Models.Account> Accounts { get; set; }
        public System.Data.Entity.DbSet<GameReviewWebPortal_SOC09109.Models.Game> Games { get; set; }
    }
}
