using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagementSystem.Domain.Admin.Command
{
    public class AddUserCommandHandler : IRequestHandler<AddUserCommand, Guid>
    {
        public AddUserCommandHandler() { }
        public async Task<Guid> Handle(AddUserCommand request,
            CancellationToken cancellationToken)
        {
            // First validate the request
            return Guid.NewGuid();
        }
    }
}
