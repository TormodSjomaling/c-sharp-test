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
    public class GetAllCarsQueryHandler : IRequestHandler<GetAllCarsQuery, IEnumerable<Car>>
    {
        public async Task<IEnumerable<Car>> Handle(GetAllCarsQuery request, CancellationToken cancellationToken)
        {
            //business logic here
            return new[]
            {
                new Car { Name = "Volvo" },
                new Car { Name = "Volvo" },
            };
        }
    }
}
