using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRSMediatR.Models;
using System.Threading;

namespace CQRSMediatR.Queries
{
    public class GetAllCarsQuery : IRequest<IEnumerable<Car>>{}
}
