namespace Farm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class biz_checkItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ChkItemId { get; set; }

        [Key]
        [StringLength(50)]
        public string ChkItemCode { get; set; }

        [Required]
        [StringLength(1000)]
        public string ChkItem { get; set; }

        public double? ItemPoints { get; set; }

        [StringLength(50)]
        public string ParentItemCode { get; set; }

        [StringLength(50)]
        public string StdItemCode { get; set; }

        [StringLength(50)]
        public string Line { get; set; }

        public int? SortNo { get; set; }

        public short IsEnable { get; set; }

        public short? IsDel { get; set; }

        public DateTime CreateDate { get; set; }

        [Required]
        [StringLength(50)]
        public string UpdatePerson { get; set; }

        public DateTime UpdateDate { get; set; }

        [Required]
        [StringLength(50)]
        public string CreatePerson { get; set; }
    }
}
