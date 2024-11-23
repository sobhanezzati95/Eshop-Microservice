using IDP.Application.Commands.User;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace IDP.Api.Controllers.V1
{
    [Route("api/v1/user")]
    [ApiController]
    public class UserController : BaseController
    {
        private readonly IMediator _mediator;
        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }


        /// <summary>
        /// ورود اطلاعات کاربر
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddUserCommand addUserCommand)
        {
            var result = await _mediator.Send(addUserCommand);
            return Ok();
        }
    }
}
