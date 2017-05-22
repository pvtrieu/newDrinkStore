namespace DrinkStore.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            ImportDetails = new HashSet<ImportDetail>();
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int ProductID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [Column(TypeName = "image")]
        public byte[] Avatar { get; set; }

        public int? CategoryID { get; set; }

        public int? BrandID { get; set; }

        public decimal? UnitPrice { get; set; }

        public int? UnitID { get; set; }

        public virtual Brand Brand { get; set; }

        public virtual Category Category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImportDetail> ImportDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        public virtual Unit Unit { get; set; }
    }
}
