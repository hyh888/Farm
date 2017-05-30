namespace Farm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sys_user
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long UserId { get; set; }

        [Key]
        [StringLength(100)]
        public string UserCode { get; set; }

        [StringLength(50)]
        public string Line { get; set; }

        [StringLength(200)]
        public string UserName { get; set; }

        [StringLength(1024)]
        public string Description { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(1000)]
        public string PositionName { get; set; }

        [StringLength(100)]
        public string OrganizeCode { get; set; }

        [StringLength(300)]
        public string OrganizeName { get; set; }

        [StringLength(4000)]
        public string ConfigJSON { get; set; }

        public int? LoginCount { get; set; }

        public DateTime? LastLoginDate { get; set; }

        [StringLength(50)]
        public string UserSeq { get; set; }

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
