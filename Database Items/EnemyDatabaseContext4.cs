namespace Paper_Mario
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EnemyDatabaseContext4 : DbContext
    {
        public EnemyDatabaseContext4()
            : base("name=EnemyDatabaseContext4")
        {
        }

        public virtual DbSet<BattleSprite> BattleSprites { get; set; }
        public virtual DbSet<Enemy> Enemies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
