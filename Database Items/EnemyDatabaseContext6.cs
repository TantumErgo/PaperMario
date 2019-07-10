namespace Paper_Mario
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EnemyDatabaseContext6 : DbContext
    {
        public EnemyDatabaseContext6()
            : base("name=EnemyDatabaseContext6")
        {
        }

        public virtual DbSet<BattleSprite> BattleSprites { get; set; }
        public virtual DbSet<Enemy> Enemies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
