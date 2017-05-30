namespace Farm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sys_menu
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long MenuId { get; set; }

        [Key]
        [StringLength(100)]
        public string MenuCode { get; set; }

        [StringLength(100)]
        public string ParentCode { get; set; }

        [StringLength(200)]
        public string MenuName { get; set; }

        [StringLength(200)]
        public string URL { get; set; }

        [StringLength(50)]
        public string IconClass { get; set; }

        [StringLength(200)]
        public string IconURL { get; set; }

        [StringLength(10)]
        public string MenuSeq { get; set; }

        [StringLength(300)]
        public string Description { get; set; }

        public short IsEnable { get; set; }

        public short? IsDel { get; set; }

        [StringLength(50)]
        public string Line { get; set; }

        [StringLength(20)]
        public string CreatePerson { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(20)]
        public string UpdatePerson { get; set; }

        public DateTime? UpdateDate { get; set; }
    }
}
