using AutoMapper;
using LeaveManagementTest.Data;
using LeaveManagementTest.Models;

namespace LeaveManagementTest.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }
    }
}
