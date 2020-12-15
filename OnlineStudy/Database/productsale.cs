namespace OnlineStudy.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("firstgroupfirstpc.productsale")]
    public partial class productsale
    {
        public int ID { get; set; }

        public DateTime SaleDate { get; set; }

        public int ProductID { get; set; }

        public int Quantity { get; set; }

        public int? ClientServiceID { get; set; }

        public virtual clientservice clientservice { get; set; }

        public virtual product product { get; set; }
    }
}
