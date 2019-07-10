namespace Paper_Mario
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EnemyDatabaseContext3 : DbContext
    {
        public EnemyDatabaseContext3()
            : base("name=EnemyDatabaseContext3")
        {
        }

        public virtual DbSet<BattleSprite> BattleSprites { get; set; }
        public virtual DbSet<Enemy> Enemies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
