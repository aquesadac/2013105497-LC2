﻿using _2013105497_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013105497_PER.EntityTypeConfigurations
{
    public class BusConfiguration : EntityTypeConfiguration<Bus>
    {

        public BusConfiguration()
        {
            Property(v => v.BusId)
                .IsRequired();

        }
    }
}
