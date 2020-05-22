namespace BlogSample.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TEST_Table
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        [StringLength(50)]
        public string Remark { get; set; }

        [StringLength(50)]
        public string userName { get; set; }

        [StringLength(50)]
        public string userPassword { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime CreateDate { get; set; }
    }
}
