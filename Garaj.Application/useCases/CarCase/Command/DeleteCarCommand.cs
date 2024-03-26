using Garaj.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaj.Application.useCases.CarCase.Command
{
    public class DeleteCarCommand : IRequest<Car>
    {
        public Guid Id { get; set; }
    }
}
