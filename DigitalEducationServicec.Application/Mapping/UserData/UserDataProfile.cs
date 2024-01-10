using AutoMapper;

namespace DigitalEducationServicec.Application.Mapping.UserData
{
    public partial class UserDataProfile : Profile
    {
        public UserDataProfile()
        {
            GetUserDataListMapping();
            GetUserDataByIDMapping();
            AddUserDataCommandMapping();
            EditUserDataCommandMapping();
        }
    }
}
