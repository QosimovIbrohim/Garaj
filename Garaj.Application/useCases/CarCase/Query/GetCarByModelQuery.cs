using Garaj.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaj.Application.useCases.CarCase.Query
{
    public class GetCarByModelQuery : IRequest<Car>
    {
        public string Model { get; set; }
    }
}
