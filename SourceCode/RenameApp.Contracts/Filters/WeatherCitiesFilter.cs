using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;
using System.ComponentModel.DataAnnotations;
using RenameApp.Common;

namespace RenameApp.Contracts
{
    public partial class WeatherCities
    {
        public class WeatherCitiesQueryModel
        {
            public WeatherForecast WeatherForecast { get; set; }
        }
    }
}
