namespace Farm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sys_role
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long RoleId { get; set; }

        [Required]
        [StringLength(100)]
        public string RoleCode { get; set; }

        [Key]
        [StringLength(200)]
        public string RoleName { get; set; }

        [StringLength(2048)]
        public string Description { get; set; }

        [StringLength(50)]
        public string LineLimit { get; set; }

        [StringLength(50)]
        public string Line { get; set; }

        public short IsEnable { get; set; }

        public short IsDel { get; set; }

        [StringLength(50)]
        public string RoleSeq { get; set; }

        [StringLength(50)]
        public string CreatePerson { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string UpdatePerson { get; set; }

        public DateTime? UpdateDate { get; set; }
    }
}
