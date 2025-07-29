using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagementSystem.Domain.Admin.Command
{
    public class AddUserCommand : IRequest<Guid>
    {
    }
}
