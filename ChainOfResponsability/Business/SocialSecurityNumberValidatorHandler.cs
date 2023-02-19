using ChainOfResponsability.Exceptions;
using ChainOfResponsability.Models;
using ChainOfResponsability.Validators;

namespace ChainOfResponsability.Business
{
    public class SocialSecurityNumberValidatorHandler : Handler<User>
    {
        private SocialSecurityNumberValidator socialSecurityNumberValidator = new SocialSecurityNumberValidator();
        public override void Handle(User request)
        {
            if (!socialSecurityNumberValidator.Validate(request.SocialSecurityNumber, request.CitizenshipRegion))
            {
                throw new UserValdiationException("Social security number could not be valid");
            }

            base.Handle(request);
        }

    }
}
