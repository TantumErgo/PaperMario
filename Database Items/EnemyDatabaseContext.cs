namespace Paper_Mario
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EnemyDatabaseContext : DbContext
    {
        public EnemyDatabaseContext()
            : base("name=EnemyDatabaseContext")
        {
        }

        public virtual DbSet<Enemy> Enemies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
