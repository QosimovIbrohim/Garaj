using Garaj.Application.Abstractions;
using Garaj.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Garaj.Application.useCases.CarCase.Query
{
    public class GetAllCarsQueryHandler : IRequestHandler<GetAllCarsQuery, List<Car>>
    {
        private readonly IAppDbContext _appDbContext;
        private readonly MemoryCache _cache;

        public GetAllCarsQueryHandler(IAppDbContext appDbContext, MemoryCache cache)
        {
            _appDbContext = appDbContext;
            _cache = cache;
        }

        public async Task<List<Car>> Handle(GetAllCarsQuery request, CancellationToken cancellationToken)
        {
            string key = "Cars";
            if (!_cache.TryGetValue(key, out List<Car> cars))
            {
                cars = await _appDbContext.Cars.ToListAsync(cancellationToken);

                _cache.Set(key, cars, TimeSpan.FromSeconds(30));
            }

            return cars;
        }
    }
}
