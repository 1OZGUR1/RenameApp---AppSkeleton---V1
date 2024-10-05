using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using RenameApp.Common;
using RenameApp.Contracts;

namespace RenameApp.Contracts
{
    /// <summary>
    /// Cities
    /// <summary>
    public interface IWeatherCitiesService
    {
        /// <summary>
        /// Get list data without filter
        /// <summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<IEnumerable<WeatherCities>> GetListByNoFilterAsync(CancellationToken cancellationToken = default);
    }
}
