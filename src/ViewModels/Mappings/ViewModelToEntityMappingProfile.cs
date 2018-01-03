
using AngularASPNETCore2WebApiAuth.Models.Entities;
using AutoMapper;
 

namespace AngularASPNETCore2WebApiAuth.ViewModels.Mappings
{
    public class ViewModelToEntityMappingProfile : Profile
    {
        public ViewModelToEntityMappingProfile()
        {
            CreateMap<RegistrationViewModel, AppUser>().ForMember(au => au.UserName, map => map.MapFrom(vm => vm.Email));
        }
    }
}
