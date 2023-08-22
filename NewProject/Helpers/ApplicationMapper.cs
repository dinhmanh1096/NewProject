using AutoMapper;
using NewProject.Data;
using NewProject.Models;

namespace NewProject.Helpers
{
    public class ApplicationMapper:Profile
    {
        public ApplicationMapper()
        {
            CreateMap<Sport, SportModel>().ReverseMap();
            CreateMap<Sport, RequestSportModel>().ReverseMap();
        }
    }
}
