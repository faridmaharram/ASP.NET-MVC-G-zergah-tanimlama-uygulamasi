﻿using BusWeb.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusWeb.Core.Infrastructure
{
    public interface IRouteRepository : IRepository<ROUTE>
    {
        IEnumerable<Data.Model.ROUTE> GetListById(int id);
    }
}
