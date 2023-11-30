using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CV_templateDotNet.Models;

namespace CV_templateDotNet.Data
{
    public class CVtemplateDotNetContext : DbContext
    {
        public CVtemplateDotNetContext (DbContextOptions<CVtemplateDotNetContext> options)
            : base(options)
        {
        }

        public DbSet<CV_templateDotNet.Models.User> User { get; set; } = default!;
    }
}
