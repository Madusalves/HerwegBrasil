using AutoMapper;
using HerwegBrasil.Dtos;
using HerwegBrasil.Models;

namespace HerwegBrasil.Mappings
{
    public class BancoMapping : Profile
    {
        public BancoMapping() 
        { 
            CreateMap(typeof(ResponseGeneric<>), typeof(ResponseGeneric<>));
            CreateMap<BancoResponse, BancoModel>();
            CreateMap<BancoModel, BancoResponse>();
        }
    }
}
