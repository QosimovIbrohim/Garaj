using Garaj.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaj.Application.useCases.CarCase.Command
{
    public class CreateCarCommand : IRequest<Car>
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Guid OwnerId { get; set; }
    }
}
