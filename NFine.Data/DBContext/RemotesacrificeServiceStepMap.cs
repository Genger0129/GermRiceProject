using ConsoleApplication6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    public partial class RemotesacrificeServiceStepMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<RemotesacrificeServiceStep>
    {
        public RemotesacrificeServiceStepMap()
        {
            // table
            ToTable("RemotesacrificeServiceStep", "dbo");

            // keys
            HasKey(t => t.StepId);
        }
    }
}
