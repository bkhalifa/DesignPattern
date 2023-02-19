using ChainOfResponsability.Exceptions;
using ChainOfResponsability.Models;

namespace ChainOfResponsability.Business
{
    public class AgeValidationHandler : Handler<User>
    {
        public override void Handle(User user)
        {
            if (user.Age < 18)
            {
                throw new UserValdiationException(" You have to be 18 years or older");
            }

            base.Handle(user);
        }
    }
}
