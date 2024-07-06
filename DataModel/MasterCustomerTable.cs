using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplikasiBarbershop.DataModel
{
    public class MasterCustomerTable: BaseEntities
    {
        public int Id { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string Phone { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Address { get; set; } = default!;

        public virtual MasterTeamTable? Team { get; set; } = default!;
        public virtual ICollection<MasterServicesTable>? Services { get; set; } = new List<MasterServicesTable>();
    }
    public class MasterCustomerConfig : IEntityTypeConfiguration<MasterCustomerTable>
    {
        public void Configure(EntityTypeBuilder<MasterCustomerTable> builder)
        {
            builder.ToTable("MasterCustomerTable");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Phone).IsRequired();
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.Address).IsRequired().HasMaxLength(255);

            builder.HasMany(x => x.Services)
                .WithOne(x => x.Customer)
                .HasForeignKey(x => x.CustomerId);
            builder.HasOne(x => x.Team)
                .WithOne(x => x.Customer)
                .HasForeignKey<MasterTeamTable>(x => x.CustomerId);

            builder.Seed();
        }
    }

    public static class SeedMasterTableCustomer
    {
        public static void Seed(this EntityTypeBuilder<MasterCustomerTable> builder)
        {
            builder.HasData(
                new MasterCustomerTable
                {
                    Id = 1,
                    Name = "Irfan Hakim",
                    Phone = "08123809123",
                    Email = "irfan@gmail.com",
                    Address = "Jl. Semangka No.2, jakarta",
                    CreateBy = "admin",
                    CreateDate = DateTime.Now
                },
                new MasterCustomerTable
                {
                    Id = 2,
                    Name = "Andreas",
                    Phone = "081234809123",
                    Email = "andreas@gmail.com",
                    Address = "Jl. Mangga No.5, jakarta",
                    CreateBy = "admin",
                    CreateDate = DateTime.Now
                },
                new MasterCustomerTable
                {
                    Id = 3,
                    Name = "Paul",
                    Phone = "081123123341",
                    Email = "paul@gmail.com",
                    Address = "Jl. Nangka No.2, jakarta",
                    CreateBy = "admin",
                    CreateDate = DateTime.Now
                },
                new MasterCustomerTable
                {
                    Id = 4,
                    Name = "Barbara",
                    Phone = "0845546309123",
                    Email = "barbara@gmail.com",
                    Address = "Jl. Pisang No.2, jakarta",
                    CreateBy = "admin",
                    CreateDate = DateTime.Now
                }
            );

        }
    }
}
