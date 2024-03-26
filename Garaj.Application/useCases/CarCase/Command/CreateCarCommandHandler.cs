using Garaj.Application.Abstractions;
using Garaj.Domain.Entities;
using Garaj.Domain.Entities.Auth;
using Mapster;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaj.Application.useCases.CarCase.Command
{
    public class CreateCarCommandHandler : IRequestHandler<CreateCarCommand, Car>
    {
        private readonly IAppDbContext _appDbContext;

        public CreateCarCommandHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<Car> Handle(CreateCarCommand request, CancellationToken cancellationToken)
        {
            var car = request.Adapt<Car>();

            _appDbContext.Cars.Add(car);
            await _appDbContext.SaveChangesAsync(cancellationToken);

            return car;
        }
    }
}
