using MediatR;
using Microsoft.AspNetCore.Mvc;
using SiteManagementSystem.Domain.Admin.Command;

namespace SiteManagementSystem.Controllers
{
    public class AdminController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AdminController(IMediator mediator) 
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> AddUsers()
        {
            try
            {
                var result = await _mediator.Send(new AddUserCommand() { });
                if(result != Guid.Empty)
                {
                    return Ok();
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
