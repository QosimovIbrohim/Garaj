using Garaj.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaj.Application.Abstractions
{
    public interface IAppDbContext
    {
        public DbSet<Car> Cars { get; set; }
        ValueTask<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
