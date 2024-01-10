using AutoMapper;

namespace DigitalEducationServicec.Application.Mapping.TrafficLine
{
    public partial class TrafficLineProfile : Profile
    {
        public TrafficLineProfile()
        {
            GetTrafficLineListMapping();
            GetTrafficLineByIDMapping();
            AddTrafficLineCommandMapping();
            EditTrafficLineCommandMapping();
        }
    }
}