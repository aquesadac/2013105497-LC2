﻿using _2013105497_ENT;
using _2013105497_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013105497_PER.Repositories
{
    public class CinturonRepository : Repository<Cinturon>, ICinturonRepository
    {
        private readonly EnsambladoraDbContext _Context;

        public CinturonRepository(EnsambladoraDbContext context)
        {
            _Context = context;
        }

        private CinturonRepository()
        {
                
        }
    }
}
