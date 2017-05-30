namespace Farm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class biz_checkList
    {
        [Key]
        public long ChkListId { get; set; }

        [Required]
        [StringLength(50)]
        public string ChkListNo { get; set; }

        [StringLength(250)]
        public string ChkListDesc { get; set; }

        [Required]
        [StringLength(50)]
        public string OrganizeCode { get; set; }

        [Required]
        [StringLength(200)]
        public string OrganizeName { get; set; }

        public DateTime CheckDate { get; set; }

        [Required]
        [StringLength(50)]
        public string Checker { get; set; }

        [Required]
        [StringLength(50)]
        public string CheckerCode { get; set; }

        [StringLength(50)]
        public string OrgHead { get; set; }

        [StringLength(250)]
        public string HostName { get; set; }

        [StringLength(200)]
        public string CheckerOrgCode { get; set; }

        public string GRemark { get; set; }

        [StringLength(50)]
        public string Line { get; set; }

        [StringLength(50)]
        public string SortNo { get; set; }

        public short? IsEnable { get; set; }

        public short? IsDel { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string UpdatePerson { get; set; }

        public DateTime? UpdateDate { get; set; }

        [StringLength(50)]
        public string CreatePerson { get; set; }
    }
}
