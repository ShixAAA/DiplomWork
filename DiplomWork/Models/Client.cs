namespace DiplomWork.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Client")]
    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            Application = new HashSet<Application>();
        }

        public int ClientID { get; set; }

        [Required]
        [StringLength(20)]
        public string Phone { get; set; }

        [Column(TypeName = "image")]
        [Required]
        public byte[] Photo { get; set; }

        [Required]
        [StringLength(80)]
        public string Address { get; set; }

        [Required]
        [StringLength(80)]
        public string PassportID { get; set; }

        public int Height { get; set; }

        public int Weight { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Application> Application { get; set; }

        public virtual Passport Passport { get; set; }
    }
}
