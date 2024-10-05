using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using RenameApp.Common;
using RenameApp.Contracts;

namespace RenameApp.Contracts
{
    /// <summary>
    /// TemperatureStatics
    /// <summary>
    public interface ITemperatureStaticsService
    {
        /// <summary>
        /// Get single data by cityfilter
        /// <summary>
        /// <param name="cityFilter"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<TemperatureStatics?> GetByCityFilterAsync(
            TemperatureStatics.CityFilter cityFilter, CancellationToken cancellationToken = default);
    }
}
