using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RenameApp.Contracts
{
    /// <summary>
    /// TemperatureState
    /// </summary>
    public enum TemperatureState
    {
        [Display(Name = "Above Zero")]
        AboveZero,

        [Display(Name = "Below Zero")]
        BelowZero,
    }
}
