using ChainOfResponsability.Exceptions;
using ChainOfResponsability.Models;

namespace ChainOfResponsability.Business
{
    public class CitizenshipRegionValidationHandler : Handler<User>
    {
        public override void Handle(User user)
        {
            if (user.CitizenshipRegion.TwoLetterISORegionName == "NO")
            {
                throw new UserValdiationException("We currently do not support Norwegians");
            }

            base.Handle(user);
        }
    }
}
