namespace OnlineStudy.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("firstgroupfirstpc.clientservice")]
    public partial class clientservice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public clientservice()
        {
            documentbyservices = new HashSet<documentbyservice>();
            productsales = new HashSet<productsale>();
        }

        public int ID { get; set; }

        public int ClientID { get; set; }

        public int ServiceID { get; set; }

        public DateTime StartTime { get; set; }

        [StringLength(1073741823)]
        public string Comment { get; set; }

        public virtual client client { get; set; }

        public virtual service service { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<documentbyservice> documentbyservices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<productsale> productsales { get; set; }
    }
}
