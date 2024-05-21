namespace DiplomWork.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Exercise")]
    public partial class Exercise
    {
        public int ExerciseID { get; set; }

        public int ExerciseTypeID { get; set; }

        [Required]
        [StringLength(80)]
        public string Name { get; set; }

        public virtual ExerciseType ExerciseType { get; set; }
    }
}
