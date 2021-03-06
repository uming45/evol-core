﻿using Evol.EntityFramework.Repository;
using Evol.TMovie.Domain.Models.Entities;
using Evol.TMovie.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Evol.TMovie.Data.Repositories
{
    public class EmployeePermissionShipRepository : BaseEntityFrameworkRepository<EmployeePermissionShip, TMovieDbContext>, IEmployeePermissionShipRepository
    {
        public EmployeePermissionShipRepository(IEfUnitOfWorkDbContextProvider dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
