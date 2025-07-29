using MediatR;
using SiteManagementSystem.DataModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagementSystem.Domain.Admin.Query
{
    public class GetAllUsersRequestHandler : IRequestHandler<GetAllUsersRequest, List<UserDTO>>
    {
        public GetAllUsersRequestHandler() { }
        public async Task<List<UserDTO>> Handle(GetAllUsersRequest request, CancellationToken cancellationToken)
        {
            return new List<UserDTO>() { };
        }
    }
}
