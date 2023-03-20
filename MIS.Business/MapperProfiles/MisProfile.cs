using AutoMapper;
using MIS.Business.Models.User;
using MIS.Data.Models;

namespace MIS.Business.MapperProfiles
{
    public class MisProfile : Profile
    {
        public MisProfile()
        {
            CreateMap<RegisterUserRequest, RegisterUserResponse>().ReverseMap();

            CreateMap<RegisterUserRequest, User>().ReverseMap();
        }
    }
}
