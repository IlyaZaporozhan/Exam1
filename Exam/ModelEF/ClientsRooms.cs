namespace Exam.ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ClientsRooms
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? IDRoom { get; set; }

        public int? IDClient { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DateOfArrival { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DateDeparture { get; set; }

        public int? IDConditionsRoom { get; set; }

        public int? IDWorkers { get; set; }

        public virtual Clients Clients { get; set; }

        public virtual ConditionsRoom ConditionsRoom { get; set; }

        public virtual Rooms Rooms { get; set; }

        public virtual Workers Workers { get; set; }
    }
}
