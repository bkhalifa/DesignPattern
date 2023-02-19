using ChainOfResponsability.Exceptions;
using ChainOfResponsability.Models;

namespace ChainOfResponsability.Business
{
    public class NameValidationHandler : Handler<User>
    {
        public override void Handle(User request)
        {
            if (request.Name.Length <= 1)
            {
                throw new UserValdiationException("Your name is unlikely this short");
            }
            base.Handle(request);
        }
    }
}
