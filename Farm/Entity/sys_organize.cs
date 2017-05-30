namespace Farm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sys_organize
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long OrganizeId { get; set; }

        [Key]
        [StringLength(100)]
        public string OrganizeCode { get; set; }

        [StringLength(300)]
        public string OrganizeName { get; set; }

        [StringLength(100)]
        public string ParentCode { get; set; }

        [StringLength(1024)]
        public string Description { get; set; }

        public byte? IsUnit { get; set; }

        public byte IsDel { get; set; }

        public byte? IsEnable { get; set; }

        [StringLength(10)]
        public string SortNo { get; set; }

        [StringLength(20)]
        public string CreatePerson { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(20)]
        public string UpdatePerson { get; set; }

        public DateTime? UpdateDate { get; set; }
    }
}
