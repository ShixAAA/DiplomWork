namespace DiplomWork.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Timetable")]
    public partial class Timetable
    {
        public int TimetableID { get; set; }

        public int TrainerID { get; set; }

        public int AdministratorID { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime DateEnd { get; set; }

        public virtual Administrator Administrator { get; set; }

        public virtual Trainer Trainer { get; set; }
    }
}
