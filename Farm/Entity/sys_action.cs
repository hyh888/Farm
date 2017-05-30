namespace Farm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sys_action
    {
        [Key]
        [StringLength(100)]
        public string ActionCode { get; set; }

        [Required]
        [StringLength(100)]
        public string TableName { get; set; }

        [StringLength(50)]
        public string MIdField { get; set; }
        [StringLength(50)]
        public string IdField { get; set; }
        [StringLength(500)]
        public string SqlFrag { get; set; }

        public short IsEnable { get; set; }

        public short IsDel { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string UpdatePerson { get; set; }

        public DateTime? UpdateDate { get; set; }

        [StringLength(50)]
        public string CreatePerson { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ActionId { get; set; }
    }
}
