namespace Farm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sys_position
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PositionId { get; set; }

        [Key]
        [StringLength(50)]
        public string PositionCode { get; set; }

        [StringLength(255)]
        public string Position { get; set; }

        public short? IsDel { get; set; }

        public short? IsEnable { get; set; }

        [StringLength(50)]
        public string CreatePerson { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string UpdatePerson { get; set; }

        public DateTime? UpdateDate { get; set; }
    }
}
