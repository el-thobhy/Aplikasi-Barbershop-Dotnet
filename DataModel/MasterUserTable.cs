using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using DataModel;

namespace AplikasiBarbershop.DataModel
{
    public class MasterUserTable : BaseEntities
    {
        public int Id { get; set; }
        public string UserName { get; set; } = default!;
        public string Password { get; set; } = default!;
        public UserTypeEnum Role { get; set; } = UserTypeEnum.CUSTOMER;
        public int? BiodataId { get; set; }
        public virtual MasterBiodataTable? Biodata { get; set; }
        public virtual MasterTeamTable? Team { get; set; } = default!;
        public virtual ICollection<MasterServicesTable>? Services { get; set; } = new List<MasterServicesTable>();


    }
    public class UserConfig : IEntityTypeConfiguration<MasterUserTable>
    {
        public void Configure(EntityTypeBuilder<MasterUserTable> builder)
        {
            builder.ToTable("MasterUserTable");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).ValueGeneratedOnAdd();

            builder.Property(t => t.UserName).HasMaxLength(50).IsRequired();
            builder.HasIndex(t => t.UserName).IsUnique();
            builder.Property(t => t.BiodataId).IsRequired(false);

            builder.Property(t => t.Password).HasMaxLength(100).IsRequired();

            builder.Property(t => t.Role).IsRequired();
            builder.Seed();

            builder.HasMany(x => x.Services)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId);
            builder.HasOne(x => x.Team)
                .WithOne(x => x.User)
                .HasForeignKey<MasterTeamTable>(x => x.UserId);
        }
    }

    public static class SeedMasterUser
    {
        public static void Seed(this EntityTypeBuilder<MasterUserTable> builder)
        {
            builder.HasData(
                new MasterUserTable
                {
                    Id = 1,
                    BiodataId = 1,
                    UserName = "admin",
                    Password = "5f9235e4a01a1426a8b791e239f0c72f65ad1bc8a7cc3a6c163486c1f86037a0", //koming1@3
                    Role = UserTypeEnum.ADMIN,
                    CreateBy = "admin",
                    CreateDate = DateTime.Now,
                },
                new MasterUserTable
                {
                    Id = 2,
                    BiodataId = 2,
                    UserName = "andreas",
                    Password = "f7cc0b90dbc18a9255efa5d8193dffb78d9cfa193d5900f1a64d548c53d2e78c", //koandreas1@3
                    Role = UserTypeEnum.CUSTOMER,
                    CreateBy = "admin",
                    CreateDate = DateTime.Now,
                }
                ,
                new MasterUserTable
                {
                    Id = 3,
                    BiodataId = 3,
                    UserName = "paul",
                    Password = "dd6fa3a9f24e38363058d610c26f935bf7952f9c4f74ea60d52a1de1b27aa7f6", //kopaul1@3
                    Role = UserTypeEnum.CUSTOMER,
                    CreateBy = "admin",
                    CreateDate = DateTime.Now,
                }
                ,
                new MasterUserTable
                {
                    Id = 4,
                    BiodataId = 4,
                    UserName = "barbara",
                    Password = "1d1f5e19b999d7e8a96bcc99b83c13c5d0f1aa134b25dd638c9d4a7d871cec0a", //kobarbara1@3
                    Role = UserTypeEnum.CUSTOMER,
                    CreateBy = "admin",
                    CreateDate = DateTime.Now,
                }
            );
        }
    }
}
