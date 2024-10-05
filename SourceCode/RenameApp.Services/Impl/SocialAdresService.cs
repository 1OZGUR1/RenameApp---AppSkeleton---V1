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
    public class SocialAdresService : EntityServiceBase<SocialAdres, string>, ISocialAdresService
    {
        public SocialAdresService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
