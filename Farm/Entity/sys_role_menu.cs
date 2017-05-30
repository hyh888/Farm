namespace Farm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sys_role_menu
    {
        [Key]
        public long RMId { get; set; }

        public long RoleId { get; set; }

        [Required]
        [StringLength(200)]
        public string RoleName { get; set; }

        public int MenuId { get; set; }

        [Required]
        [StringLength(255)]
        public string MenuName { get; set; }

        [StringLength(50)]
        public string Line { get; set; }

        public short IsEnable { get; set; }

        public short IsDel { get; set; }

        [StringLength(50)]
        public string CreatePerson { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string UpdatePerson { get; set; }

        public DateTime? UpdateDate { get; set; }
    }
}
