using Garaj.Application.Abstractions;
using Garaj.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaj.Application.useCases.CarCase.Query
{
    public class GetCarByModelQueryHandler : IRequestHandler<GetCarByModelQuery, Car>
    {
        private readonly IMediator _mediatR;

        public GetCarByModelQueryHandler(IMediator mediatR)
        {
            _mediatR = mediatR;
        }

        public async Task<Car> Handle(GetCarByModelQuery request, CancellationToken cancellationToken)
        {
            List<Car>? cars = await _mediatR.Send(new GetAllCarsQuery());

            var res = cars.FirstOrDefault(x => x.Model == request.Model);
            if (res == null)
            {
                throw new FileNotFoundException("Not found");
            }
            return res;
        }
    }
}
