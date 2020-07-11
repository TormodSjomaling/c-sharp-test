using CQRSMediatR.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSMediatR.Queries
{
    public class GetCarByIdQuery : IRequest<Car> { }
}