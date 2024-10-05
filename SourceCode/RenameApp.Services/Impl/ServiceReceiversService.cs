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
    public class ServiceReceiversService : EntityServiceBase<ServiceReceivers, string>, IServiceReceiversService
    {
        public ServiceReceiversService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
