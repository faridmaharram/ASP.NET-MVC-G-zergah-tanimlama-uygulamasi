namespace BusWeb.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ROUTE_TYPE
    {
        public ROUTE_TYPE()
        {
            ROUTEs = new HashSet<ROUTE>();
        }

        [Key]
        public int ROUTE_TYPE_ID { get; set; }

        [Display(Name = "G�zergah Tipi")]
        [MaxLength(50, ErrorMessage = "�ok fazla girdiniz !")]
        [Required(ErrorMessage = "Bo� ge�ilemez")]
        public string ROUTE_TYPE_NAME { get; set; }

        public int CREATE_UID { get; set; }

        public DateTime CREATE_DATE { get; set; }

        public int LASTUPD_UID { get; set; }

        [Column(TypeName = "date")]
        public DateTime LASTUPD_DATE { get; set; }

        public virtual ICollection<ROUTE> ROUTEs { get; set; }

        public virtual SYSADM_USER SYSADM_USER { get; set; }

        public virtual SYSADM_USER SYSADM_USER1 { get; set; }
    }
}
