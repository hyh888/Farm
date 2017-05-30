namespace Farm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class biz_checkListDtl
    {
        [Key]
        public long ChkListDtlId { get; set; }

        public long? ChkListId { get; set; }

        [Required]
        [StringLength(50)]
        public string ItemCode { get; set; }

        [Required]
        [StringLength(50)]
        public string StdItemCode { get; set; }

        [StringLength(1000)]
        public string ChkItem { get; set; }

        public double ItemPoints { get; set; }

        [Required]
        [StringLength(20)]
        public string ChkResult { get; set; }

        public double ChkScore { get; set; }

        [Required]
        [StringLength(50)]
        public string ChkListNo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CheckDate { get; set; }

        [StringLength(1000)]
        public string CheckerRemark { get; set; }

        [StringLength(500)]
        public string ProblemPic { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CorrectDdLine { get; set; }

        [StringLength(50)]
        public string SortNo { get; set; }

        [StringLength(20)]
        public string Importance { get; set; }

        public short IsEnable { get; set; }

        public short IsDel { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string UpdatePerson { get; set; }

        public DateTime? UpdateDate { get; set; }

        [StringLength(50)]
        public string CreatePerson { get; set; }
    }
}
