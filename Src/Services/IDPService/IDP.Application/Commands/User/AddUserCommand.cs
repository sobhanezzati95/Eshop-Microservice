using MediatR;
using System.ComponentModel.DataAnnotations;

namespace IDP.Application.Commands.User
{
    public record AddUserCommand : IRequest<bool>
    {
        [Required(ErrorMessage = "پر کردن نام الزامی است")]
        public required string Name { get; set; }


    }
}
