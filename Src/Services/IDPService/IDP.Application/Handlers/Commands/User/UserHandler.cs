using IDP.Application.Commands.User;
using MediatR;

namespace IDP.Application.Handlers.Commands.User
{
    public class UserHandler : IRequestHandler<AddUserCommand, bool>
    {
        public async Task<bool> Handle(AddUserCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(true);
        }
    }
}
