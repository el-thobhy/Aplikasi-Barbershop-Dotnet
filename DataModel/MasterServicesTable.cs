using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplikasiBarbershop.DataModel
{
    public class MasterServicesTable: BaseEntities
    {
        public int Id { get; set; } = default!;
        public string ServicesName { get; set; } = default!;
        public string Description { get; set; } = default!;
        public double Price { get; set; } = default!;
        public string ImageUrl { get; set; } = default!;
        public int? CustomerId { get; set; } = default!;
        
        [ForeignKey("CustomerId")]
        public MasterCustomerTable? Customer { get; set; } = default!;
    }

    public class MasterServicesConfig : IEntityTypeConfiguration<MasterServicesTable>
    {
        public void Configure(EntityTypeBuilder<MasterServicesTable> builder)
        {
            builder.ToTable("MasterServicesTable");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.ServicesName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Price).IsRequired().HasPrecision(18, 2);
            builder.Property(x => x.ImageUrl).IsRequired().HasMaxLength(255);
            builder.Property(x => x.CustomerId).IsRequired(false);

            builder.Seed();
        }
    }
    public static class SeedMasterServices
    {
        public static void Seed(this EntityTypeBuilder<MasterServicesTable> builder)
        {
            builder.HasData(
                new MasterServicesTable
                {
                    Id = 1,
                    ServicesName = "Haircut Mullet style",
                    Description = "Style mullet haircut, short side",
                    Price = 200000,
                    CustomerId = 2,
                    ImageUrl = "https://haircutinspiration.com/wp-content/uploads/perm-mullet-with-quiff-750x937.jpg",
                    CreateBy = "admin",
                    CreateDate = DateTime.Now

                },
                new MasterServicesTable
                {
                    Id = 2,
                    ServicesName = "Haircut Comma hair",
                    Description = "Style comma haircut, modern hair style",
                    Price = 250000,
                    ImageUrl = "https://www.k-craze.com/wp-content/uploads/2021/09/image-138.jpg",
                    CreateBy = "admin",
                    CreateDate = DateTime.Now
                },
                new MasterServicesTable
                {
                    Id = 3,
                    ServicesName = "Haircut Mohawk",
                    Description = "Style Mohawk haircut, short side",
                    Price = 150000,
                    ImageUrl = "https://www.hottesthaircuts.com/wp-content/uploads/2018/02/3.-High-Mohawk-Fade.jpg",
                    CreateBy = "admin",
                    CreateDate = DateTime.Now
                },
                new MasterServicesTable
                {
                    Id = 4,
                    ServicesName = "Haircut wolfcut style",
                    Description = "Style wolfcut style, Modern wolfcut",
                    Price = 500000,
                    ImageUrl = "https://cdn2.fabbon.com/uploads/image/file/32093/WhatsApp_Image_2023-08-04_at_17.54.31.jpeg",
                    CreateBy = "admin",
                    CreateDate = DateTime.Now
                },
                new MasterServicesTable
                {
                    Id = 5,
                    ServicesName = "Hair Care",
                    Description = "Cream bath Services, Dandruff care",
                    Price = 400000,
                    CustomerId = 2,
                    ImageUrl = "https://cdn2.fabbon.com/uploads/image/file/32093/WhatsApp_Image_2023-08-04_at_17.54.31.jpeg",
                    CreateBy = "admin",
                    CreateDate = DateTime.Now
                }
            );
        }
    }
}
