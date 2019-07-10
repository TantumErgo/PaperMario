namespace Paper_Mario
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BattleSprite
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public byte[] SpriteImage { get; set; }
    }
}
