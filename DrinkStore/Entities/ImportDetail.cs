namespace DrinkStore.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ImportDetail")]
    public partial class ImportDetail
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ImportID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductID { get; set; }

        public int? Amount { get; set; }

        public decimal? UnitCost { get; set; }

        public DateTime? ExpiredDate { get; set; }

        public virtual Import Import { get; set; }

        public virtual Product Product { get; set; }
    }
}
