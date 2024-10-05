using RenameApp.Common;
using RenameApp.Contracts;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace RenameApp.Contracts
{
    public interface IPersonService : IEntityServiceBase<Person, string>
    {
    }
}
