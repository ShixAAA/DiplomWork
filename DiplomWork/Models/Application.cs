namespace DiplomWork.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Application")]
    public partial class Application
    {
        public int ApplicationID { get; set; }

        public int TrainerID { get; set; }

        public int ClientID { get; set; }

        public DateTime Date { get; set; }

        [StringLength(80)]
        public string Purpose { get; set; }

        public int TypeOfActivityID { get; set; }

        public virtual Client Client { get; set; }

        public virtual Trainer Trainer { get; set; }

        public virtual TypeOfActivity TypeOfActivity { get; set; }
    }
}
