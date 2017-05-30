namespace Farm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class biz_chkListFb
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ChkListFbId { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ChkListDtlId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CorrectFinishedDate { get; set; }

        [StringLength(500)]
        public string CorrectPic { get; set; }

        [StringLength(1000)]
        public string Feedback { get; set; }

        public short IsEnable { get; set; }

        public short IsDel { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string UpdatePerson { get; set; }

        public DateTime? UpdateDate { get; set; }

        [StringLength(50)]
        public string CreatePerson { get; set; }

        [StringLength(50)]
        public string SortNo { get; set; }
    }
}
