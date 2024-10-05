using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RenameApp.Contracts
{
    /// <summary>
    /// CityTemperatureStatics
    /// <summary>
    public partial class CityTemperatureStatics
    {
        public string WeatherForecastCity { get; set; }

        [Display(Name = "Average Temperature")]
        public double AvgTemperature { get; set; }

        [Display(Name = "Max Temperature")]
        public double MaxTemperature { get; set; }

        [Display(Name = "Min Temperature")]
        public double MinTemperature { get; set; }
    }
}
