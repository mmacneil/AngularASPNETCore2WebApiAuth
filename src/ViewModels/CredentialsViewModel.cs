
using AngularASPNETCore2WebApiAuth.ViewModels.Validations;
using FluentValidation.Attributes;

namespace AngularASPNETCore2WebApiAuth.ViewModels
{
    [Validator(typeof(CredentialsViewModelValidator))]
    public class CredentialsViewModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
