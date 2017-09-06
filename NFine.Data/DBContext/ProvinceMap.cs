using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    public partial class ProvinceMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Province>
    {
        public ProvinceMap()
        {
            // table
            ToTable("Province", "dbo");

            // keys
            HasKey(t => t.ProvinceId);
        }
    }
}
