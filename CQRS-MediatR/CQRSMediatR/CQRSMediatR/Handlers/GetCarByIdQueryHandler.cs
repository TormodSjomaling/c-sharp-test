using CQRSMediatR.Models;
using CQRSMediatR.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSMediatR.Handlers
{
    public class GetCarByIdQueryHandler : IRequestHandler<GetCarByIdQuery, Car>
    {
        public async Task<Car> Handle(GetCarByIdQuery request, CancellationToken cancellationToken)
        {
            Car x =  new Car { Name = "sdad" };

            return x;
        }
    }
}
