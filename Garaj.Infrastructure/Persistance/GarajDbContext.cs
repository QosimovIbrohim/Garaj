using Garaj.Application.Abstractions;
using Garaj.Domain.Entities;
using Garaj.Domain.Entities.Auth;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Garaj.Infrastructure.Persistance
{
    public class GarajDbContext : IdentityDbContext<User, Role, Guid>, IAppDbContext
    {
        public GarajDbContext(DbContextOptions<GarajDbContext> ops)
            : base(ops) => Database.Migrate();

        public DbSet<Car> Cars { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        async ValueTask<int> IAppDbContext.SaveChangesAsync(CancellationToken cancellationToken)
            => await base.SaveChangesAsync(cancellationToken);
    }
}
