namespace OnlineStudy.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("firstgroupfirstpc.servicephoto")]
    public partial class servicephoto
    {
        public int ID { get; set; }

        public int ServiceID { get; set; }

        [Required]
        [StringLength(1000)]
        public string PhotoPath { get; set; }

        public virtual service service { get; set; }
    }
}
