namespace BusWeb.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ROUTE")]
    public partial class ROUTE
    {
        public ROUTE()
        {
            STATIONs = new HashSet<STATION>();
        }

        [Key]
        public int ROUTE_ID { get; set; }

        [Required]
        [Display(Name = "G�zergah")]
        [MaxLength(40, ErrorMessage = "�ok fazla girdiniz !")]
        public string ROUTE_NAME { get; set; }

         [Display(Name = "�ehir")]
         [Required]
        public int CITY_ID { get; set; }

        
         [Display(Name = "G�zergah Tipi")]
         [Required(ErrorMessage="Bo� ge�ilemez")]
        public int ROUTE_TYPE_ID { get; set; }

       
         [Display(Name = "G�zergah Toplam S�re")]
         [Required(ErrorMessage = "Bo� ge�ilemez")]
        public short TOT_DURATION { get; set; }

       
         [Display(Name = "Peron No")]
         [Required(ErrorMessage = "Bo� ge�ilemez")]
        public short PERON_NO { get; set; }

      
        [StringLength(50)]
        [Display(Name = "Servis Tipi")]
        [Required(ErrorMessage = "Bo� ge�ilemez")]
        public string VEHICLE_TYPE { get; set; }

        public int CREATE_UID { get; set; }

        public DateTime CREATE_DATE { get; set; }

        public int LASTUPD_UID { get; set; }

        public DateTime LASTUPD_DATE { get; set; }

        public virtual CITY CITY { get; set; }

        public virtual ROUTE_TYPE ROUTE_TYPE { get; set; }

        public virtual SYSADM_USER SYSADM_USER { get; set; }

        public virtual SYSADM_USER SYSADM_USER1 { get; set; }

        public virtual ICollection<STATION> STATIONs { get; set; }
    }
}
