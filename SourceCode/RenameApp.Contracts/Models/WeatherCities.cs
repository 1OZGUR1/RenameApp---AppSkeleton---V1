using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RenameApp.Contracts
{
    /// <summary>
    /// Cities
    /// <summary>
    [Display(Name = "Cities")]
    public partial class WeatherCities
    {
        public string City { get; set; }
    }
}
