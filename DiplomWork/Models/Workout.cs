namespace DiplomWork.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Workout")]
    public partial class Workout
    {
        public int WorkoutID { get; set; }

        [Required]
        [StringLength(60)]
        public string Name { get; set; }

        public int ExerciseID { get; set; }

        public int Repeat { get; set; }

        public int RoomID { get; set; }

        public int TrainerID { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime DateEnd { get; set; }
    }
}
