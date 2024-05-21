namespace DiplomWork.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TypeOfActivity")]
    public partial class TypeOfActivity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TypeOfActivity()
        {
            Application = new HashSet<Application>();
        }

        public int TypeOfActivityID { get; set; }

        [Required]
        [StringLength(80)]
        public string Name { get; set; }

        public int Cost { get; set; }

        public int Duration { get; set; }

        [Required]
        [StringLength(80)]
        public string Description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Application> Application { get; set; }
    }
}
