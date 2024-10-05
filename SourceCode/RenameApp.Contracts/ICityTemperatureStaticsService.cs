using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using RenameApp.Common;
using RenameApp.Contracts;

namespace RenameApp.Contracts
{
    /// <summary>
    /// CityTemperatureStatics
    /// <summary>
    public interface ICityTemperatureStaticsService
    {
        /// <summary>
        /// Get list data by datefilter
        /// <summary>
        /// <param name="dateFilter"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<IEnumerable<CityTemperatureStatics>> GetListByDateFilterAsync(
            CityTemperatureStatics.DateFilter dateFilter, CancellationToken cancellationToken = default);
    }
}
