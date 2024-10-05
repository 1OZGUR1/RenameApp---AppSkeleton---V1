using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RenameApp.Contracts;
using RenameApp.Dal;
using System;
using System.Collections.Generic;

namespace RenameApp.Dal
{
    public class WeatherForecastEntityTypeConfiguration : IEntityTypeConfiguration<WeatherForecast>
    {
        public void Configure(EntityTypeBuilder<WeatherForecast> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasComment("Data unique identifier.");

            builder
                .Property(x => x.DateTime)
                .HasConversion(typeof(DateOnlyValueConverter), typeof(DateOnlyValueComparer))
                .HasComment("Forecast date and time.");

            builder
                .Property(x => x.TemperatureC)
                .HasComment("Temperature information in degrees Celsius.");

            builder
                .Property(x => x.Summary)
                .HasComment("Sensory description of weather.");

            //TODO:Initialization data
             this.SeedData(builder);
        }

        private void SeedData(EntityTypeBuilder<WeatherForecast> builder)
        {
            builder.HasData(
                new WeatherForecast
                {
                    City = "Chicago",
                    DateTime = DateOnly.FromDateTime(new DateTime(2024, 7, 2)),
                    TemperatureStatus = TemperatureState.AboveZero,
                    Summary = "Comfortable",
                    WeatherState = WeatherState.Sunny,
                    TemperatureC = 24
                 },
                 new WeatherForecast
                 {
                     City = "Chicago",
                     DateTime = DateOnly.FromDateTime(new DateTime(2024, 7, 10)),
                     TemperatureStatus = TemperatureState.AboveZero,
                     Summary = "You need to bring an umbrella when going out",
                     WeatherState = WeatherState.Rainy,
                     TemperatureC = 27
                 },
                 new WeatherForecast
                 {
                      City = "Detroit",
                      DateTime = DateOnly.FromDateTime(new DateTime(2024, 2, 2)),
                      TemperatureStatus = TemperatureState.BelowZero,
                      Summary = "Mostly Cloudy",
                      WeatherState = WeatherState.Sunny,
                      TemperatureC = -24
                 },
                new WeatherForecast
                {
                      City = "Detroit",
                      DateTime = DateOnly.FromDateTime(new DateTime(2024, 1, 2)),
                      TemperatureStatus = TemperatureState.BelowZero,
                      Summary = "Mostly Cloudy",
                      WeatherState = WeatherState.Snowy,
                      TemperatureC = -30
                 },
                 new WeatherForecast
                 {
                      City = "Boston",
                      DateTime = DateOnly.FromDateTime(new DateTime(2024, 5, 5)),
                      TemperatureStatus = TemperatureState.AboveZero,
                      Summary = "Tornado, be careful when going out",
                      WeatherState = WeatherState.Windy,
                      TemperatureC = 12
                  },
                 new WeatherForecast
                 {
                      City = "Boston",
                      DateTime = DateOnly.FromDateTime(new DateTime(2023, 11, 23)),
                      TemperatureStatus = TemperatureState.BelowZero,
                      Summary = "Cold, keep warm",
                      WeatherState = WeatherState.Windy,
                      TemperatureC = -26
                  },
                 new WeatherForecast
                 {
                      City = "Boston",
                      DateTime = DateOnly.FromDateTime(new DateTime(2024, 6, 13)),
                      TemperatureStatus = TemperatureState.AboveZero,
                      Summary = "Hot, be careful of heat stroke",
                      WeatherState = WeatherState.Sunny,
                      TemperatureC = 32
                  },
                 new WeatherForecast
                 {
                      City = "Las Vegas",
                      DateTime = DateOnly.FromDateTime(new DateTime(2024, 2, 8)),
                      TemperatureStatus = TemperatureState.BelowZero,
                      Summary = "Dust, low visibility",
                      WeatherState = WeatherState.Windy,
                      TemperatureC = -8
                  },
                 new WeatherForecast
                 {
                      City = "Las Vegas",
                      DateTime = DateOnly.FromDateTime(new DateTime(2024, 5, 1)),
                      TemperatureStatus = TemperatureState.AboveZero,
                      Summary = "Comfortable",
                      WeatherState = WeatherState.Sunny,
                      TemperatureC = 18
                  },
                 new WeatherForecast
                 {
                      City = "New York",
                      DateTime = DateOnly.FromDateTime(new DateTime(2024, 2, 5)),
                      TemperatureStatus = TemperatureState.AboveZero,
                      Summary = "Holiday, there will be a lot of traffic",
                      WeatherState = WeatherState.Sunny,
                      TemperatureC = 15
                  },
                 new WeatherForecast
                 {
                      City = "Columbus",
                      DateTime = DateOnly.FromDateTime(new DateTime(2024, 7, 5)),
                      TemperatureStatus = TemperatureState.AboveZero,
                      Summary = "Hravy rain, try to avoid going out",
                      WeatherState = WeatherState.Rainy,
                      TemperatureC = 20
                  },
        	 new WeatherForecast
                 {
                      City = "Philadelphia",
                      DateTime = DateOnly.FromDateTime(new DateTime(2024, 6, 12)),
                      TemperatureStatus = TemperatureState.AboveZero,
                      Summary = "Extremely hot, prevent heat stroke",
                      WeatherState = WeatherState.Sunny,
                      TemperatureC = 32
                  },
        	 new WeatherForecast
                 {
                      City = "Philadelphia",
                      DateTime = DateOnly.FromDateTime(new DateTime(2023, 12, 12)),
                      TemperatureStatus = TemperatureState.BelowZero,
                      Summary = "Moderate snow, be careful of freezing rain",
                      WeatherState = WeatherState.Snowy,
                      TemperatureC = -10
                  },
        	 new WeatherForecast
                 {
                      City = "Houston",
                      DateTime = DateOnly.FromDateTime(new DateTime(2024, 3, 24)),
                      TemperatureStatus = TemperatureState.AboveZero,
                      Summary = "The temperature is gradually rising",
                      WeatherState = WeatherState.Sunny,
                      TemperatureC = 18
                  },
        	 new WeatherForecast
                 {
                      City = "Seattle",
                      DateTime = DateOnly.FromDateTime(new DateTime(2024, 4, 17)),
                      TemperatureStatus = TemperatureState.AboveZero,
                      Summary = "Summer begins",
                      WeatherState = WeatherState.Sunny,
                      TemperatureC = 26
                  },
        	 new WeatherForecast
                 {
                      City = "Burlington",
                      DateTime = DateOnly.FromDateTime(new DateTime(2024, 6, 5)),
                      TemperatureStatus = TemperatureState.AboveZero,
                      Summary = "Sunny, suitable for outdoor activities",
                      WeatherState = WeatherState.Sunny,
                      TemperatureC = 20
                  },
                 new WeatherForecast
                 {
                      City = "Fargo",
                      DateTime = DateOnly.FromDateTime(new DateTime(2024, 5, 8)),
                      TemperatureStatus = TemperatureState.AboveZero,
                      Summary = "Light rain, be cafeful of slippery roads",
                      WeatherState = WeatherState.Rainy,
                      TemperatureC = 19
                  },
        	 new WeatherForecast
                 {
                      City = "New Orleans",
                      DateTime = DateOnly.FromDateTime(new DateTime(2024, 1, 3)),
                      TemperatureStatus = TemperatureState.AboveZero,
                      Summary = "East wind",
                      WeatherState = WeatherState.Windy,
                      TemperatureC = 10
                  },
        	 new WeatherForecast
                 {
                      City = "New Orleans",
                      DateTime = DateOnly.FromDateTime(new DateTime(2023, 11, 23)),
                      TemperatureStatus = TemperatureState.BelowZero,
                      Summary = "Below zero degrees, keep warm",
                      WeatherState = WeatherState.Rainy,
                      TemperatureC = -2
                  },
        	 new WeatherForecast
                 {
                      City = "Wichita",
                      DateTime = DateOnly.FromDateTime(new DateTime(2024, 7, 13)),
                      TemperatureStatus = TemperatureState.AboveZero,
                      Summary = "Hot, reduce outdoor activities",
                      WeatherState = WeatherState.Sunny,
                      TemperatureC = 35
                  },
                 new WeatherForecast
                 {
                      City = "Denver",
                      DateTime = DateOnly.FromDateTime(new DateTime(2024, 4, 23)),
                      TemperatureStatus = TemperatureState.AboveZero,
                      Summary = "Thunderstorms",
                      WeatherState = WeatherState.Rainy,
                      TemperatureC = 26
                  },
        	 new WeatherForecast
                 {
                      City = "Denver",
                      DateTime = DateOnly.FromDateTime(new DateTime(2023, 8, 23)),
                      TemperatureStatus = TemperatureState.AboveZero,
                      Summary = "Take precautions",
                      WeatherState = WeatherState.Windy,
                      TemperatureC = 20
                  },
                 new WeatherForecast
                 {
                      City = "Boise",
                      DateTime = DateOnly.FromDateTime(new DateTime(2024, 1, 23)),
                      TemperatureStatus = TemperatureState.BelowZero,
                      Summary = "Sunny, suitable for outdoor activities",
                      WeatherState = WeatherState.Sunny,
                      TemperatureC = -34
                  },
                 new WeatherForecast
                 {
                      City = "Boise", 
                      DateTime = DateOnly.FromDateTime(new DateTime(2024, 3, 2)),
                      TemperatureStatus = TemperatureState.BelowZero,
                      Summary = "Pay attention to driving safety",
                      WeatherState = WeatherState.Snowy,
                      TemperatureC = -18
                  }
        
        );
        }
    }
}
