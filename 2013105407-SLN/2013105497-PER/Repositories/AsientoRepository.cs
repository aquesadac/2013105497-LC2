﻿using _2013105497_ENT;
using _2013105497_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace _2013105497_PER.Repositories
{
    public class AsientoRepository : Repository<Asiento>, IAsientoRepository
    {
        public AsientoRepository(EnsambladoraDbContext context) : base(context)
        {
        }
    }
}
