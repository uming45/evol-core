﻿using Evol.Common;
using Evol.Domain.Data;
using Evol.TMovie.Domain.Models.AggregateRoots;
using Evol.TMovie.Domain.QueryEntries.Parameters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Evol.TMovie.Domain.QueryEntries
{
    public interface IPermissionQueryEntry : IQueryEntry
    {
        Task<Permission> FetchAsync(Guid id);

        Task<List<Permission>> RetrieveAsync(PermissionQueryParameter param);

        Task<IPaged<Permission>> RetrievePagedAsync(PermissionQueryParameter param, int pageIndex, int pageSize);

        Task<List<Permission>> GetByPermissionIdsAsync(Guid[] ids);
    }
}
