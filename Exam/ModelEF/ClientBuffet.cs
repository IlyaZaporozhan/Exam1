namespace Exam.ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ClientBuffet")]
    public partial class ClientBuffet
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? IDClient { get; set; }

        public int? IDTypeBuffetAccess { get; set; }

        public virtual Clients Clients { get; set; }

        public virtual TypeBuffetAccess TypeBuffetAccess { get; set; }
    }
}
