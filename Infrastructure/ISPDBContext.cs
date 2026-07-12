using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public class ISPDBContext : DbContext
    {
        public ISPDBContext(DbContextOptions options) : base(options)
        {
        }

    }
}
