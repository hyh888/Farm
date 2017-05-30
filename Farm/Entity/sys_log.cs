namespace Farm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sys_log
    {
        public int ID { get; set; }

        [StringLength(20)]
        public string UserCode { get; set; }

        [StringLength(100)]
        public string UserName { get; set; }

        [StringLength(1024)]
        public string Position { get; set; }

        [StringLength(255)]
        public string Target { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        public string Message { get; set; }

        public DateTime? Date { get; set; }
    }
}
