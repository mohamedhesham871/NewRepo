using Demo.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DataAccess.Data.Config
{
    internal class DepartmentConfig: IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(d => d.Id);
            builder.Property(d => d.Id).UseIdentityColumn(10,10);
            builder.Property(d => d.Name).IsRequired().HasMaxLength(30);
            builder.Property(d => d.Code).IsRequired().HasMaxLength(30);

            builder.Property(d=>d.CreatedOn).HasDefaultValueSql("GETDATE()");
            //make date calculated by the server    
            //Can't Reference to other   column in the same table
            builder.Property(d=>d.LastModifiiedOn).HasComputedColumnSql("GETDATE()");
            //Value is computed Ever Time value Change
        }

    }
   
}
