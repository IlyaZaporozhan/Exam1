namespace Exam.ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Clients
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Clients()
        {
            ClientBuffet = new HashSet<ClientBuffet>();
            ClientsRooms = new HashSet<ClientsRooms>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(100)]
        public string FullName { get; set; }

        public int? PasportNumber { get; set; }

        public int? PasportSeries { get; set; }

        [StringLength(100)]
        public string Registration { get; set; }

        public int? IDWorkers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientBuffet> ClientBuffet { get; set; }

        public virtual Workers Workers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientsRooms> ClientsRooms { get; set; }
    }
}
