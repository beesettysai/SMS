using MediatR;
using SiteManagementSystem.DataModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagementSystem.Domain.Admin.Query
{
    public class GetAllUsersRequest : IRequest<List<UserDTO>>
    {
    }
}
