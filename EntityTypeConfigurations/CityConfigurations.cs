using exam2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace exam2.EntityTypeConfigurations;

public class CityConfigurations : IEntityTypeConfiguration<City>
{
    private readonly City[] _cities =
    [
        new City { /*Id = 1, */Name = "Kyiv", Latitude = 50.4501, Longitude = 30.5234 },
        new City { /*Id = 2, */Name = "Lviv", Latitude = 49.8397, Longitude = 24.0297 },
        new City { /*Id = 3, */Name = "Odesa", Latitude = 46.4825, Longitude = 30.7233 },
        new City { /*Id = 4, */Name = "Dnipro", Latitude = 48.4647, Longitude = 35.0462 },
        new City { /*Id = 5, */Name = "Kharkiv", Latitude = 49.9935, Longitude = 36.2304 },
        new City { /*Id = 6, */Name = "Zaporizhzhia", Latitude = 47.8388, Longitude = 35.1396 },
        new City { /*Id = 7, */Name = "Mykolaiv", Latitude = 46.9750, Longitude = 31.9946 },
        new City { /*Id = 8, */Name = "Vinnytsia", Latitude = 49.2331, Longitude = 28.4682 },
        new City { /*Id = 9, */Name = "Poltava", Latitude = 49.5883, Longitude = 34.5514 },
        new City { /*Id = 10,*/ Name = "Chernihiv", Latitude = 51.4982, Longitude = 31.2893 },
        new City { /*Id = 11,*/ Name = "Chernivtsi", Latitude = 48.2908, Longitude = 25.9345 },
        new City { /*Id = 12,*/ Name = "Kherson", Latitude = 46.6354, Longitude = 32.6169 },
        new City { /*Id = 13,*/ Name = "Ivano-Frankivsk", Latitude = 48.9226, Longitude = 24.7103 },
        new City { /*Id = 14,*/ Name = "Sumy", Latitude = 50.9077, Longitude = 34.7981 },
        new City { /*Id = 15,*/ Name = "Ternopil", Latitude = 49.5535, Longitude = 25.5948 },
        new City { /*Id = 16,*/ Name = "Uzhhorod", Latitude = 48.6208, Longitude = 22.2879 },
        new City { /*Id = 17,*/ Name = "Zhytomyr", Latitude = 50.2649, Longitude = 28.6767 },
        new City { /*Id = 18,*/ Name = "Rivne", Latitude = 50.6199, Longitude = 26.2516 },
        new City { /*Id = 19,*/ Name = "Lutsk", Latitude = 50.7472, Longitude = 25.3254 },
        new City { /*Id = 20,*/ Name = "Kropyvnytskyi", Latitude = 48.5079, Longitude = 32.2623 },
    ];
    
    
    public void Configure(EntityTypeBuilder<City> builder)
    {
        builder.HasKey(c => c.Id);

        builder.HasIndex(c => c.Name)
            .IsUnique();

        builder.Property(c => c.Latitude)
            .IsRequired();
        
        builder.Property(c => c.Longitude)
            .IsRequired();

        builder.HasData(_cities);
    }
}


