namespace Paper_Mario
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Enemy")]
    public partial class Enemy
    {
        public int EnemyId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string MaxHP { get; set; }

        [Required]
        [StringLength(50)]
        public string Attack { get; set; }

        [Required]
        [StringLength(50)]
        public string Defense { get; set; }

        [Required]
        public string Tattle { get; set; }

        public byte[] EnemyImage { get; set; }
    }
}
