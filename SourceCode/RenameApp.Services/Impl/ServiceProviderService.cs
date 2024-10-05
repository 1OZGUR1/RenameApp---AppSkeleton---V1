using Microsoft.EntityFrameworkCore;
using RenameApp.Common;
using RenameApp.Contracts;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace RenameApp.Services
{
    public class ServiceProviderService : EntityServiceBase<ServiceProvider, string>, IServiceProviderService
    {
        public ServiceProviderService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
