using AutoMapper;

namespace DigitalEducationServicec.Application.Mapping.Bus
{


    public partial class BusProfile : Profile
    {
        public BusProfile()
        {
            GetBusListMapping();
            GetBusByIDMapping();
            AddBusCommandMapping();
            EditBusCommandMapping();
        }
    }




}
