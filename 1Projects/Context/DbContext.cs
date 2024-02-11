using Microsoft.EntityFrameworkCore;

namespace _1Projects.Context
{
   
        public class DBContext : DbContext
        {
            public DBContext(DbContextOptions<DBContext> options)
                : base(options)
            {
                    
            }

            public DbSet<Shared.ProfileData> profileDatas { get; set; }
        }
}
