using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RenameApp.Contracts
{
    /// <summary>
    /// TemperatureStatics
    /// <summary>
    public partial class TemperatureStatics
    {
        [Display(Name = "Maximum Temperature")]
        public double MaxTem { get; set; }

        [Display(Name = "Minimum Temperature")]
        public double MinTem { get; set; }

        [Display(Name = "Average Temperature")]
        public double AvgTem { get; set; }

        [Display(Name = "Weather Count")]
        public int WeatherCount { get; set; }
    }
}
