﻿using CHC.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace CHC.Domain.Entities
{
    [Table("interior_detail")]
    public class InteriorDetail
    {
        [Column("quantity")]
        public int Quantity { get; set; } = 0;

        [Column("interior_id")]
        [ForeignKey(nameof(Interior))]
        public Guid InteriorId { get; set; }
        public virtual Interior Interior { get; set; } = null!;

        [Column("material_id")]
        [ForeignKey(nameof(Material))]
        public Guid MaterialId { get; set; }
        public virtual Material Material { get; set; } = null!;
    }
}
