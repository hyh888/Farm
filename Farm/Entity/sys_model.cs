namespace Farm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sys_model
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ModelId { get; set; }

        [StringLength(50)]
        public string ModelCode { get; set; }

        [Key]
        [StringLength(255)]
        public string Model { get; set; }

        [StringLength(50)]
        public string SortNo { get; set; }

        [StringLength(50)]
        public string Line { get; set; }

        public short IsEnable { get; set; }

        public short? IsDel { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string UpdatePerson { get; set; }

        public DateTime? UpdateDate { get; set; }

        [StringLength(50)]
        public string CreatePerson { get; set; }
    }
}
