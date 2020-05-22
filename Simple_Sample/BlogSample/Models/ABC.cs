namespace BlogSample.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ABC : DbContext
    {
        public ABC()
            : base("name=ABC")
        {
        }

        public virtual DbSet<TEST_Table> TEST_Table { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
