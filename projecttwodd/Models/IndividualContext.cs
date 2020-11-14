﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecttwodd.Models
{
    public class IndividualContext:DbContext
    {
        public IndividualContext(DbContextOptions<IndividualContext> options):base(options)
        {

        }
        public DbSet<Individual> Individuals { get; set; }
    }
}
