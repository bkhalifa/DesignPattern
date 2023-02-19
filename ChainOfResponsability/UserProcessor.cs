// See https://aka.ms/new-console-template for more information
using ChainOfResponsability.Business;
using ChainOfResponsability.Exceptions;
using ChainOfResponsability.Models;
using ChainOfResponsability.Validators;

// refactoring here using chain of responsability
internal class UserProcessor
{
   // private SocialSecurityNumberValidator socialSecurityNumberValidator = new SocialSecurityNumberValidator();
    public bool Register(User user)
    {
        try
        {
            var handler = new SocialSecurityNumberValidatorHandler();

            handler.SetNext(new NameValidationHandler())
                   .SetNext(new AgeValidationHandler())
                   .SetNext(new CitizenshipRegionValidationHandler());

            handler.Handle(user);
        }
        catch (UserValdiationException ex)
        {
            return false;
        }
       
        return true;
       

        //if (!socialSecurityNumberValidator.Validate(user.SocialSecurityNumber, user.CitizenshipRegion))
        //{
        //    return false;
        //}
        //else if (user.Age < 18)
        //{
        //    return false;
        //}
        //else if (user.Name.Length <= 1)
        //{
        //    return false;
        //}
        //else if (user.CitizenshipRegion.TwoLetterISORegionName == "NO")
        //{
        //    return false;
        //}
        //else
        //{
        //    return true;
        //}
    }
}