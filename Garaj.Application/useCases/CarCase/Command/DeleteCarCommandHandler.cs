using Garaj.Application.Abstractions;
using Garaj.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaj.Application.useCases.CarCase.Command
{
    public class DeleteCarCommandHandler : IRequestHandler<DeleteCarCommand, Car>
    {
        private readonly IAppDbContext _appDbContext;

        public DeleteCarCommandHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<Car> Handle(DeleteCarCommand request, CancellationToken cancellationToken)
        {
            var res = await _appDbContext.Cars.FirstOrDefaultAsync(x=>x.Id== request.Id);
            if(res == null)
            {
                throw new FileNotFoundException("Not found");
            }
            _appDbContext.Cars.Remove(res);
            await _appDbContext.SaveChangesAsync(cancellationToken);

            return res;
        }
    }
}
