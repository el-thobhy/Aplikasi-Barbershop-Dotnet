using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplikasiBarbershop.DataModel
{
    public class MasterTeamTable: BaseEntities
    {
        public int Id { get; set; } = default!;
        public string Name { get; set; } = default!;
        public Role Role { get; set; } = default!;
        public string Phone { get; set; } = default!;
        public int? CustomerId { get; set; } = default!;
        public string Email { get; set; } = default!;
        public Status Status { get; set; } = default!;
        public virtual MasterCustomerTable? Customer { get; set; } = default!;
    }

    public class MasterTeamConfig : IEntityTypeConfiguration<MasterTeamTable>
    {
        public void Configure(EntityTypeBuilder<MasterTeamTable> builder)
        {
            builder.ToTable("MasterTeamTable");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Role).IsRequired();
            builder.Property(x => x.CustomerId).IsRequired(false);
            builder.Property(x => x.Phone).IsRequired();
            builder.Property(x => x.Email).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Status).IsRequired();

            builder.Seed();
        }
    }

    public static class SeedMasterTableTeam
    {
        public static void Seed(this EntityTypeBuilder<MasterTeamTable> builder)
        {
            builder.HasData(
                new MasterTeamTable
                {
                    Id= 1,
                    Name = "Budi",
                    Role = Role.HAIR_STYLIST_MEN,
                    Phone = "081278912302",
                    Email = "buid@gmail.com",
                    CustomerId = 1,
                    Status = Status.BUSY,
                    CreateBy = "admin",
                    CreateDate = DateTime.Now
                },
                new MasterTeamTable
                {
                    Id = 2,
                    Name = "Asep",
                    Role = Role.HAIR_STYLIST_MEN,
                    Phone = "081123122302",
                    CustomerId = 2,
                    Email = "asep@gmail.com",
                    Status = Status.AVAILABLE,
                    CreateBy = "admin",
                    CreateDate = DateTime.Now
                },
                new MasterTeamTable
                {
                    Id = 3,
                    Name = "Putri",
                    Role = Role.HAIR_STYLIST_WOMAN,
                    Phone = "081278911232",
                    Email = "putri@gmail.com",
                    Status = Status.AVAILABLE,
                    CreateBy = "admin",
                    CreateDate = DateTime.Now
                },
                new MasterTeamTable
                {
                    Id = 4,
                    Name = "Susi",
                    Role = Role.HAIR_CARE,
                    Phone = "0812789123112",
                    CustomerId = 4,
                    Email = "susi@gmail.com",
                    Status = Status.AVAILABLE,
                    CreateBy = "admin",
                    CreateDate = DateTime.Now
                }
            );
        }
    }
}
