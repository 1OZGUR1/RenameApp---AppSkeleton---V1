using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace RenameApp.Contracts
{
    /// <summary>
    /// Used to display detailed information about recent weather.
    /// </summary>
    [Display(Name = "Weather")]
    public partial class WeatherForecast
    {
        /// <summary>
        /// Data unique identifier.
        /// </summary>
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [StringLength(30)]
        public string City { get; set; } = String.Empty;

        [Display(Name = "Weather Condition")]
        public WeatherState? WeatherState { get; set; }

        /// <summary>
        /// Forecast date and time.
        /// </summary>
        [Display(Name = "Date")]
        public DateOnly DateTime { get; set; }

        [Display(Name = "Temperature State")]
        public TemperatureState TemperatureStatus { get; set; } = TemperatureState.AboveZero;

        /// <summary>
        /// Temperature information in degrees Celsius.
        /// </summary>
        [Display(Name = "Temperature (Celsius)")]
        [Required]
        public double TemperatureC { get; set; }

        /// <summary>
        /// Sensory description of weather.
        /// </summary>
        public string? Summary { get; set; }
    }
}
